import "package:flutter/material.dart";
import "package:get/get.dart";
import "package:shirtshop/view/Register.dart";
import "package:shirtshop/view/ShirtView.dart";
import "package:shirtshop/view_model/LoginViewModel.dart";
import "package:shirtshop/view_model/ShirtViewModel.dart";
import "package:tuple/tuple.dart";

class Login extends StatefulWidget {
  const Login({Key? key}) : super(key: key);

  @override
  State<Login> createState() => _LoginState();
}

class _LoginState extends State<Login> {

  final loginViewModel = Get.put(LoginViewModel());
  TextEditingController usernameController = TextEditingController();
  TextEditingController passwordController = TextEditingController();

  @override
  Widget build(BuildContext context) {
    return Scaffold(
      appBar: AppBar(
        title: Text("Login"),
      ),
      body: Padding(
        padding: const EdgeInsets.all(16.0),
        child: Column(
          mainAxisAlignment: MainAxisAlignment.center,
          children: [
            TextField(
              controller: usernameController,
              decoration: InputDecoration(
                labelText: 'Username',
              ),
            ),
            SizedBox(height: 16.0),
            TextField(
              controller: passwordController,
              obscureText: true,
              decoration: InputDecoration(
                labelText: 'Password',
              ),
            ),
            SizedBox(height: 32.0),
            ElevatedButton(
              onPressed: () {
                String username = usernameController.text.trim();
                String password = passwordController.text.trim();
                showDialog(
                  context: context,
                  builder: (context) => FutureBuilder<Tuple2<bool, bool>>(
                    future: loginViewModel.authenticate(username, password),
                    builder: (context, snapshot) {
                      switch (snapshot.connectionState) {
                        case ConnectionState.none:
                        case ConnectionState.waiting:
                          return CircularProgressIndicator();
                        case ConnectionState.done:
                          if (snapshot.hasError) {
                            return Text('Error: ${snapshot.error}');
                          } else {
                            bool isAuthenticated = snapshot.data!.item1;
                            bool isAdmin = snapshot.data!.item2;

                            if (isAuthenticated) {
                              usernameController.text = "";
                              passwordController.text = "";

                              ShirtViewModel shirtViewModel = Get.put(ShirtViewModel(isAdmin: isAdmin));
                              shirtViewModel.updateAdmin(isAdmin);
                              
                              WidgetsBinding.instance!.addPostFrameCallback((_) {
                                Get.offAll(ShirtView(shirtViewModel: shirtViewModel));
                               });
                              return Container();
                            } else {
                              return AlertDialog(
                                title: Text('Login Failed'),
                                content: Text('Invalid username or password'),
                                actions: [
                                  TextButton(
                                    onPressed: () {
                                      Navigator.pop(context);
                                    },
                                    child: Text('OK'),
                                  ),
                                ],
                              );
                            }
                          }
                        default:
                          return Container();
                      }
                    },
                  ),
                );
              },
              child: Text('Login'),
            ),
            ElevatedButton(onPressed: () {
              Get.to(Register());
            }, child: Text('Register'),),
          ],
        ),
      ),
    );
  }
}