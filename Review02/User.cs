using System;
/*
 
 Problem Statement 
Design a Course Credit Evaluation System that calculates earned credits based on student 
performance. 
Ensure proper cleanup of academic processing resources. 

 OOP Concepts Used 
 Encapsulation: Academic data hidden 
 Inheritance: User  Student 
 Abstraction: Abstract User 
 Polymorphism: Credit calculation 
 Object Modeling: Student–Course mapping 
 Garbage Collection & Dispose: AcademicEngine cleanup 
 Object Modeling 
 University has Students 
 Students enroll in Courses 

 Class Diagram
 */
public abstract class User
{
    public abstract int CreditCalculation();
}