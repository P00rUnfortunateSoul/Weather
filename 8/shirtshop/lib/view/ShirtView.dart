import 'package:flutter/material.dart';
import 'package:get/get.dart';
import 'package:loading_overlay/loading_overlay.dart';
import 'package:shirtshop/view/Login.dart';
import 'package:shirtshop/view/UpdateShirt.dart';
import 'package:shirtshop/view_model/ShirtViewModel.dart';
import 'AddShirt.dart';



class ShirtView extends StatefulWidget {
  final ShirtViewModel shirtViewModel;

  const ShirtView({Key? key, required this.shirtViewModel}) : super(key: key);

  @override
  State<ShirtView> createState() => _ShirtViewState();
}

class _ShirtViewState extends State<ShirtView> {

  @override
  Widget build(BuildContext context) {
    return SafeArea(
        child: Scaffold(
          appBar: AppBar(title: Text("All Shirts", style: TextStyle(color: Colors.white),),
          backgroundColor: Colors.deepPurple, actions: [IconButton(onPressed: () {Get.offAll(Login());}, icon: Icon(Icons.exit_to_app, color: Colors.white,))],),
          body:Obx(() =>  LoadingOverlay(
            isLoading: widget.shirtViewModel.isLoading.value,
            child: Container(
              margin: EdgeInsets.all(8),
              child: ListView.builder(
                itemCount: widget.shirtViewModel.allShirts.length,
                itemBuilder: (context,index){  
                  return InkWell(
                    onTap: (){
                      if (widget.shirtViewModel.isAdmin){
                      Get.to(UpdateShirt(shirtViewModel: widget.shirtViewModel,),
                      arguments: widget.shirtViewModel.allShirts[index]);
                      }
                    },
                    child: Row(
                      children: <Widget>[
                        Expanded(
                          child: Container(
                            margin: EdgeInsets.all(8),
                            child: Column(
                              crossAxisAlignment: CrossAxisAlignment.start,
                              children: <Widget>[
                              Text(widget.shirtViewModel.allShirts[index].color!), 
                              Text(widget.shirtViewModel.allShirts[index].text!)
                              ],
                            ),
                          ),
                        ),
                        if (widget.shirtViewModel.isAdmin)
                          InkWell(
                            onTap: (){
                              widget.shirtViewModel.deleteShirt(widget.shirtViewModel.allShirts[index]);
                            },
                            child: Icon(Icons.delete, color: Colors.red, size:20,),),
                      ],
                    ),
                  );
                }
              ),
            ),
          )
          ),
          floatingActionButton: Visibility(visible: widget.shirtViewModel.isAdmin, 
          child: FloatingActionButton(onPressed: (){
            Get.to(AddShirt(shirtViewModel: widget.shirtViewModel,));
          },
          child: Icon(Icons.add),
          ),
        ),
        ),
    );
  }
}


