/*



� Problem Statement 
3)Create an Employee Performance Management System that evaluates employees based 
on performance scores and calculates incentives. 
The system must ensure proper cleanup of evaluation resources. 

� OOP Concepts Used 
 Encapsulation: Performance data hidden 
 Inheritance: Employee → PermanentEmployee 
 Abstraction: Abstract Employee 
 Polymorphism: Incentive calculation 
 Object Modeling: Employee–Performance mapping 
 Garbage Collection & Dispose: PerformanceEngine cleanup 

� Object Modeling 
 Organization has Employees 
 Employees have Performance Scores 

� Class Diagram



� Input 
Employee Name: Rohit 
Base Salary: 50000 
Performance Score: 4.5 

� Output 
Employee Name: Rohit 
Incentive Amount: 10000 
Performance evaluation resources released
 */

using System;
using System.Collections.Generic;

abstract class Employee
{
    public string Name { get; set; }
    public int EmployeeId { get; set; }
    protected double performanceScore;

    protected Employee(string name, int employeeId, double performanceScore)
    {
        Name = name;
        EmployeeId = employeeId;
        this.performanceScore = performanceScore;
    }

    public abstract double CalculateIncentive();
}

class PermanentEmployee : Employee
{
    public PermanentEmployee(string name, int employeeId, double performanceScore)
        : base(name, employeeId, performanceScore)
    {
    }

    public override double CalculateIncentive()
    {
        if (performanceScore >= 4.5)
            return 10000;
        else
            return 5000;
    }
}

class PerformanceEngine : IDisposable
{
    private bool disposed = false;

    public void Evaluate(Employee employee)
    {
        Console.WriteLine(
            $"ID: {employee.EmployeeId}, Name: {employee.Name}, Incentive: {employee.CalculateIncentive()}"
        );
    }

    public void Dispose()
    {
        if (!disposed)
        {
            Console.WriteLine("Performance Evaluation Resources Released");
            disposed = true;
        }
    }
}

class Organization
{
    private List<Employee> employees = new List<Employee>();

    public void AddEmployee(Employee employee)
    {
        employees.Add(employee);
    }

    public void EvaluateEmployees()
    {
        using (PerformanceEngine engine = new PerformanceEngine())
        {
            foreach (Employee emp in employees)//to manage life cycle of dispose 
            {
                engine.Evaluate(emp);
            }
        }
    }
}


