using System;
using System.Collections.Generic;
using System.Text;

namespace Hospital_Billing_System
{
    /*
     � Problem Statement 
2)Design an Advanced Hospital Billing System that manages patients, treatments, and 
billing rules. 
The system must calculate bills dynamically and release medical processing resources using 
Dispose(). 

� OOP Concepts Used 
 Encapsulation: Patient medical data hidden 
 Inheritance: Person → Patient 
 Abstraction: Abstract Person 
 Polymorphism: Bill calculation 
 Object Modeling: Patient–Treatment relationship 
 Garbage Collection & Dispose: MedicalBillingEngine cleanup 
� Object Modeling 
 Hospital manages Patients 
 Patients undergo Treatments 
 BillingEngine processes charges 


    �
� Input 
Patient Name: Sita 
Patient ID: 509 
Treatment Cost: 18000 
Emergency Charge: 2000 
�
� Output 
Patient Name: Sita 
Patient ID: 509 
Total Bill Amount: 20000 
Medical billing resources released
     */
    public abstract class Person
    {
        public string Name;
        public Person(string name)
        {
            Name = name;
        }
        public abstract double CalculateBill();
    }

    

    
    
}
