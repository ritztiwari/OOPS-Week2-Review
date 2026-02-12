using System;

using System;

    

   internal class DelegatesDemo
    {public delegate void CallbackMethodHandler(string message);
         internal  void Main()
        {
            DelegatesDemo obj = new DelegatesDemo();
            CallbackMethodHandler del1 = new CallbackMethodHandler(obj.CallbackMethod);
            //Here, I am calling the DoSomework function and I want the 
            //DoSomework function to call the delegate at some point of time
            //which will invoke the CallbackMethod method
            DoSomework(del1);

            Console.ReadKey();
        }

        public static void DoSomework(CallbackMethodHandler del)
        {
            Console.WriteLine("Processing some Task");
            del("Pranaya");
        }

        public void CallbackMethod(string message)
        {
            Console.WriteLine("CallbackMethod Executed");
            Console.WriteLine($"Hello: {message}, Good Morning");
        }
    }


    // internal class DelegatesDemo
    // {
    // public delegate void WorkPerformedHandler(int hours, WorkType workType);
    //     internal  void Main()
    //     {
    //         WorkPerformedHandler del1 = 
    //                     new WorkPerformedHandler(Manager_WorkPerformed);
    //         del1(10, WorkType.Golf);
    //         //del1.Invoke(50, WorkType.GotoMeetings);

    //         Console.ReadKey();
    //     }

    //     public static void Manager_WorkPerformed(int workHours, WorkType wType)
    //     {
    //         Console.WriteLine("Work Performed by Event Handler");
    //         Console.WriteLine($"Work Hours: {workHours}, Work Type: {wType}");
    //     }
    // }

    // public enum WorkType
    // {
    //     Golf,
    //     GotoMeetings,
    //     GenerateReports
    // }
