import 'package:flutter/material.dart';
import 'package:get/get.dart';
import 'package:shirtshop/view_model/ShirtViewModel.dart';
import 'package:loading_overlay/loading_overlay.dart';


class AddShirt extends StatefulWidget {
  const AddShirt({super.key});

  @override
  State<AddShirt> createState() => AddShirtState();
}

class AddShirtState extends State<AddShirt> {

  final colorController = TextEditingController();
  final textController = TextEditingController();
  final shirtViewModel = Get.put(ShirtViewModel());

  @override
  Widget build(BuildContext context) {
     return SafeArea(
        child: Scaffold(
          appBar: AppBar(title: Text("Add Shirt:", style: TextStyle(color: Colors.white),),
          backgroundColor: Colors.deepPurple,),
          body: Obx(() => LoadingOverlay(
            isLoading: shirtViewModel.isLoading.value,
            child: SingleChildScrollView(
              child: Container(
                alignment: Alignment.center,
                margin: EdgeInsets.all(16),
                child: Column(
                  children: <Widget>[
                    SizedBox(height: 24,),
                    TextField(
                      controller: colorController,
                      decoration: InputDecoration(
                        border: OutlineInputBorder(borderRadius: BorderRadius.circular(8)),
                        labelText: 'Color',
                        hintText: 'Enter Color'
                      ),
                    ),

                    SizedBox(height: 14,),
                    TextField(
                      controller: textController,
                      decoration: InputDecoration(
                        border: OutlineInputBorder(borderRadius: BorderRadius.circular(8)),
                        labelText: 'Text on Shirt',
                        hintText: 'Enter Text'
                      ),
                    ),
                    SizedBox(height: 24,),

                    InkWell(
                      onTap: (){
                        if(colorController.text != "" && textController.text != "")
                        {
                          shirtViewModel.addShirt(colorController.text, textController.text);
                          colorController.text = "";
                          textController.text = ""; 
                        } else {Get.snackbar("Data validation", "All fields must contain text", colorText: Colors.white, backgroundColor: Colors.red);}
                      },
                      child: Container(
                        width: double.infinity,
                        alignment: Alignment.center,
                        padding: EdgeInsets.all(16),
                        decoration: BoxDecoration(
                          color: Colors.green[700],
                          borderRadius: BorderRadius.circular(8)
                        ),
                        child: Text("Add", style: TextStyle(color: Colors.white),),
                      )
                    )
                  ]
                ),
              )
            )
          )
        )
      )
    );
  }
}