# DesignPattern
23 mẫu Design Pattern của Gang of Four(Erich Gamma, Richard Helm, Ralph Johnson và John Vlissides)
được viết trong cuốn Design Patterns: Elements of Reusable Object-Oriented Software
## Structural
### 1. Decorator
1. Pattern Decorator dùng để gắn thêm một số chức năng cho đối tượng một cách linh động, sử dụng một lớp con để mở rộng chức năng cho đối tượng
2. Như ví dụng trong phần Decorator - [Decorator](https://github.com/mramra3004/DesignPattern/tree/master/Decorator): có 1 lớp trừu tượng Decorator 
được kế thừa 1 lớp trừu tượng khác là Component, tạo ra 1 lớp là ConcreteComponentA được kế thừa bới lớp Component (đây chính là lớp chính để mở rộng các tính năng xung quanh đối tượng này). Tạo thêm đối tượng ConcreteComponentC, ConcreteComponentB để mở rộng các tính năng mong muốn cho đối tượng ConcreteComponentA
3. Tóm lại ConcreteComponentC, ConcreteComponentB chỉ để mở rộng tính năng cho đối tượng ConcreteComponentA mà chúng ta không cần phải thay đối đối tượng ConcreteComponentA như phương châm thiết kế Decorator là 
*"Luôn Open cho việc mở rộng và Closed cho việc sửa đổi"*

## Creational
### 1. Method Factory
1. Factory Method được sử dụng để định nghĩa interface tạo ra một object, nhưng chỉ để subclass quyết định class nào được sử dụng để tạo object theo class đó
2. Các thành phần:
* Product: xác định interface (abstract class) của object mà factory method tạo ra
* ConcreteProduct: các object implements Product interface (abstract class)
* Creator: 
  *  Khai báo factory method, trả về 1 object là loại product cụ thể. Creator có thể là factory method mặc định trả về ConcreteProduct object mặc định
  *  Có thể gọi đây là method factory để tạo ra Product Object 
* ConcreteCreator: override factory method để trả về instance của ConcreteProduct
3. Ví dụng về pattern method factory - [MethodFactory](https://github.com/mramra3004/DesignPattern/tree/master/MethodFactory)


