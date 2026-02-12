// Problem 4: Folder Scanner (Sohil)
// Given a directory path:
// •	List all .txt files
// •	Display file sizes
// •	Write report to report.txt
// Example output:
// notes.txt - 2KB
// data.txt - 5KB

using System;

namespace Name
{public class Program
    {
        public static void Main(string[] args)
        {
            try
            {
                FolderScanner.Run();
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }

            
        }
        
    }
    
}
