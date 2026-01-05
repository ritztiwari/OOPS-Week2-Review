using System;
namespace Review
{

    public class Program
    {
        static void Main(string[] args) { 
        //{   Organization org = new Organization();
        //    org.AddEmployee(new PermanentEmployee("Sai", 1, 4.5));
        //    org.AddEmployee(new PermanentEmployee("Charan", 2, 3.6));
        //    org.AddEmployee(new PermanentEmployee("Muchakarla", 3, 5.9));

        //    org.EvaluateEmployees();


                NumberToWords converter = new NumberToWords();

                Console.WriteLine(converter.Convert(124567));
                Console.WriteLine(converter.Convert(123456));
             

                Console.ReadLine(); // keeps console open
            

}
    }
}