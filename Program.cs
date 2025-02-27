using Test;
var myClass = new Generic<bool>();
// var result = myClass.AddNumbers(a:10,b:10);
// Console.WriteLine(result);
// myClass.Print<string>("Awwal");
// myClass.Print<int>(30);
// myClass.AddNumbers(true,false);
Console.Write("Enter Your Name: ");
string name = Console.ReadLine()!;
Console.Write("Enter Your Age: ");
int age = int.Parse(Console.ReadLine()!);
Person person = new Person(){
    Name = name,
    Age = age
};
Console.WriteLine("===================================");
myClass.PrintName<Person>(person);
