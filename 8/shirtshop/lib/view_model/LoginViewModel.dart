import 'package:cloud_firestore/cloud_firestore.dart';
import 'package:get/get.dart';
import 'package:tuple/tuple.dart';
import 'package:bcrypt/bcrypt.dart';

class LoginViewModel extends GetxController{
  
  Future<Tuple2<bool,bool>> authenticate(String username, String password) async{
    CollectionReference usersCollection = FirebaseFirestore.instance.collection('users');
    try {
      QuerySnapshot querySnapshot = await usersCollection
          .where('username', isEqualTo: username)
          .get();

      if (querySnapshot.docs.length == 1) {
        String hashedPassword = querySnapshot.docs.first.get('password');

        if (BCrypt.checkpw(password, hashedPassword)) {
          return Tuple2(true, querySnapshot.docs.first.get('isAdmin'));
        }
      }

      return Tuple2(false,false);
    } catch (error) {
      print('Error signing in: $error');
      return Tuple2(false,false);
    }
  }
}