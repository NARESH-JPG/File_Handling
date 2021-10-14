using System;
using System.IO;
 
namespace File_Handling
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("File handling......!!!");
            FileStream fs = new FileStream("D:\\.NET\\C#\\Day_3\\File_Handling\\file.txt", FileMode.Open);
            StreamReader sr = new StreamReader(fs);
            Console.WriteLine("we can read and display from file");
            string str = sr.ReadToEnd();
            while (str != null)
            {
                Console.WriteLine(str);
                str = sr.ReadLine();
            }

            fs.Flush();
            fs.Close();
        


            FileStream fwrite = new FileStream("D:\\.NET\\C#\\Day_3\\File_Handling\\file.txt", FileMode.Append);
            StreamWriter Swrite= new StreamWriter(fwrite);
            Console.WriteLine("Enter your content to file...");
         
            string content = Console.ReadLine();

            Swrite.Write(content);


            Swrite.Flush();
            fwrite.Flush();
            fwrite.Close();


        }
    }
}