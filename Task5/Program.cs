

using Task5;

//class Person

var person1=new Person("Komron", "streat Gisar home ~41");

Console.WriteLine($"Name: {person1.GetName()} Address: {person1.GetAddress()}");
Console.WriteLine();
//class Student

var student1 = new Student("Komron", "streat Gisar home ~42", "C#", 20, 25.4);

student1.setProgram("HTML");
student1.setYear(22);
student1.setFee(12.7);

Console.WriteLine($"Name: {student1.GetName()} Address: {student1.GetAddress()} Program: {student1.getProgram()} Year: {student1.getYear()} Fee: {student1.getFee()}");
Console.WriteLine();

//class Staff

var staff1 = new Staff("Komron", "streat Gisar home ~43", "Number 41", 500);

staff1.setSchool("Number 54");
staff1.setPay(1000);

Console.WriteLine($"Name: {staff1.GetName()} Address: {staff1.GetAddress()} School: {staff1.getSchool()} Pay: {staff1.getPay()}");



