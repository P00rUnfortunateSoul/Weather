import 'package:flutter/material.dart';
import 'package:get/get.dart';
import 'package:shirtshop/model/ShirtModel.dart';
import 'package:cloud_firestore/cloud_firestore.dart';

class ShirtViewModel extends GetxController{
  var isLoading = false.obs;
  var allShirts = <ShirtModel>[].obs;
  
  @override
  void onInit(){
    super.onInit();
    fetchAllShirts();
  }

  fetchAllShirts() async{
    isLoading.value = true;
    allShirts.clear();
    await FirebaseFirestore.instance.collection("shirts").get().then((QuerySnapshot snapshot){
      for (var shirt in snapshot.docs)
      {
        allShirts.add(ShirtModel(
          id:shirt['id'],
          color: shirt['color'],
          text: shirt['text'],
        ));
      }
      if (allShirts != null)
      {
        isLoading.value = false;
      }
    });
  }

  addShirt(String color, String text) async{
    isLoading.value = true;

    int uniqueId = DateTime.now().microsecondsSinceEpoch;

    ShirtModel shirtModel = ShirtModel();
    shirtModel.id = uniqueId;
    shirtModel.color = color;
    shirtModel.text = text;

    FirebaseFirestore.instance.collection("shirts").doc(uniqueId.toString()).set(shirtModel.toMap())
    .then((value){
      isLoading.value = false;
      fetchAllShirts();
      Get.snackbar("Shirt add", "Shirt was successfully added", colorText: Colors.white, backgroundColor: Colors.blue);
    }).catchError((error){
      isLoading.value = false;
      Get.snackbar("Shirt add", "Shirt adding failed", colorText: Colors.white, backgroundColor: Colors.red);
    } );
  }

  updateShirt(String color, String text, int id) async{
    isLoading.value = true;

    FirebaseFirestore.instance.collection("shirts").doc(id.toString()).update({'color':color, 'text':text,})
    .then((value){
      isLoading.value = false;
      fetchAllShirts();
      Get.snackbar("Shirt update", "Shirt was successfully edited", colorText: Colors.white, backgroundColor: Colors.blue);
    }).catchError((error){
      isLoading.value = false;
      Get.snackbar("Shirt update", "Shirt edit failed", colorText: Colors.white, backgroundColor: Colors.red);
    } );
  }

  deleteShirt(ShirtModel shirt) async{
    await FirebaseFirestore.instance.collection("shirts").doc(shirt.id.toString()).delete()
    .then((value){
      allShirts.remove(shirt);
      Get.snackbar("Shirt delete", "Shirt was successfully deleted", colorText: Colors.white, backgroundColor: Colors.blue);
    }).catchError((error){
      Get.snackbar("Shirt delete", "Shirt deleting failed", colorText: Colors.white, backgroundColor: Colors.red);
    });
  }

}