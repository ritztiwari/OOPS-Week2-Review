

using System.IO;
    public class FolderScanner
    {
        
        public static void Run()
        {
            try{
            string path="./Data";
            string reportPath = Path.Combine(path, "report.txt");

            using(StreamWriter writer=new StreamWriter(reportPath))
                {
                    
                    string[] txtfiles= Directory.GetFiles(path, "*.txt");

                    foreach(string file in txtfiles)
                    {
                        FileInfo fileInfo = new FileInfo(file); 

                
                long sizeInKB = (fileInfo.Length )/1024;

                string line = $"{fileInfo.Name} - {sizeInKB}KB";
                Console.WriteLine(line);
                writer.WriteLine(line);  




                    }

                }

            }
               catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            
        }
    }
