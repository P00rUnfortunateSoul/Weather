import 'package:flutter/material.dart';
import 'package:get/get.dart';
import 'package:loading_overlay/loading_overlay.dart';
import 'package:shirtshop/view/UpdateShirt.dart';
import 'package:shirtshop/view_model/ShirtViewModel.dart';
import 'AddShirt.dart';



class ShirtView extends StatefulWidget {
  const ShirtView({Key? key}) : super(key: key);

  @override
  State<ShirtView> createState() => _ShirtViewState();
}

class _ShirtViewState extends State<ShirtView> {

  final shirtViewModel = Get.put(ShirtViewModel());

  @override
  Widget build(BuildContext context) {
    return SafeArea(
        child: Scaffold(
          appBar: AppBar(title: Text("All Shirts", style: TextStyle(color: Colors.white),),
          backgroundColor: Colors.deepPurple,),
          body:Obx(() =>  LoadingOverlay(
            isLoading: shirtViewModel.isLoading.value,
            child: Container(
              margin: EdgeInsets.all(8),
              child: ListView.builder(
                itemCount: shirtViewModel.allShirts.length,
                itemBuilder: (context,index){  
                  return InkWell(
                    onTap: (){
                      Get.to(UpdateShirt(),
                      arguments: shirtViewModel.allShirts[index]);
                    },
                    child: Row(
                      children: <Widget>[
                        Expanded(
                          child: Container(
                            margin: EdgeInsets.all(8),
                            child: Column(
                              crossAxisAlignment: CrossAxisAlignment.start,
                              children: <Widget>[
                              Text(shirtViewModel.allShirts[index].color!), 
                              Text(shirtViewModel.allShirts[index].text!)
                              ],
                            ),
                          ),
                        ),
                        InkWell(
                          onTap: (){
                            shirtViewModel.deleteShirt(shirtViewModel.allShirts[index]);
                          },
                          child: Icon(Icons.delete, color: Colors.red, size:20,))
                      ],
                    ),
                  );
                }
              ),
            ),
          )
          ),
          floatingActionButton: FloatingActionButton(onPressed: (){
            Get.to(AddShirt());
          },
          child: Icon(Icons.add),
          ),
        )
    );
  }
}


