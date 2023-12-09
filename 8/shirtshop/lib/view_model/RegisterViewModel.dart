import 'package:cloud_firestore/cloud_firestore.dart';
import 'package:flutter/material.dart';
import 'package:get/get.dart';
import 'package:bcrypt/bcrypt.dart';
import 'package:shirtshop/model/UserModel.dart';
import "package:shirtshop/view/ShirtView.dart";
import "package:shirtshop/view_model/ShirtViewModel.dart";

class RegisterViewModel extends GetxController{
  void registerUser(String email, String username, String password) {
    if (email.isEmpty || username.isEmpty || password.isEmpty) {
      Get.snackbar("Input validation", "All fields must contain text", colorText: Colors.white, backgroundColor: Colors.red, snackPosition: SnackPosition.BOTTOM);
      return;
    }
    FirebaseFirestore.instance.collection('users').where('email', isEqualTo: email).get().then((querySnapshot) {
      if (querySnapshot.docs.isNotEmpty) {
        Get.snackbar("Email validation", "Email is already used", colorText: Colors.white, backgroundColor: Colors.red, snackPosition: SnackPosition.BOTTOM);
        return;
      }
      FirebaseFirestore.instance.collection('users').where('username', isEqualTo: username).get().then((usernameSnapshot) {
        if (usernameSnapshot.docs.isNotEmpty) {
          Get.snackbar("Username validation", "Username is already taken", colorText: Colors.white, backgroundColor: Colors.red, snackPosition: SnackPosition.BOTTOM);
          return;
        }
        int id = DateTime.now().microsecondsSinceEpoch;
        UserModel user = UserModel(
          id: id,
          email: email,
          username: username,
          password: BCrypt.hashpw(password, BCrypt.gensalt()), 
        );
        FirebaseFirestore.instance.collection("users").doc(id.toString()).set(user.toMap())
        .then((value){
          Get.showSnackbar(
            GetSnackBar(
              title: 'Registration Successful',
              message: 'Redirecting to Shirt page...',
              duration: Duration(seconds: 2),
              snackPosition: SnackPosition.TOP,
              showProgressIndicator: true,
              progressIndicatorBackgroundColor: Colors.blue,
            ),
          );
          Future.delayed(Duration(seconds: 2), () {
            ShirtViewModel shirtViewModel = Get.put(ShirtViewModel(isAdmin: false));
            shirtViewModel.updateAdmin(false);
            Get.offAll(ShirtView(shirtViewModel: shirtViewModel));
          });
        }).catchError((error){
          Get.snackbar("Register Error", "Registration has failed", colorText: Colors.white, backgroundColor: Colors.red);
        });          
      });
    });
  }
}