class ShirtModel{
  int? id;
  String? color;
  String? text;

  ShirtModel({this.id,this.color,this.text});

  factory ShirtModel.fromJson(Map<String, dynamic> json){
    return ShirtModel(
      id: json['id'],
      color: json['color'],
      text: json['text'],    
    );
  }

  Map<String, dynamic> toMap(){
    return{
      'id':id,
      'color':color,
      'text':text,
    };
  }
}
