//using System;
//using System.Collections.Generic;
//List<Student> students = new List<Student>();

//students.Add(new Student("Meena", 811, 78));
//foreach (var student in students)
//{
//    Console.WriteLine($"Student Name: {student.Name}");

//    Console.WriteLine($"Student Credits: {student.CreditCalculation()}");

//    Console.WriteLine($"Academic resource released ");
//    GC.Collect();
//}



ValidParanthesis vp =new ValidParanthesis();
Console.WriteLine(vp.check("(()"));

Console.ReadKey();