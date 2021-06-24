using System;
using System.IO;
using System.Collections;
namespace testApp
{
    class Program
    {
        static void Main(string[] args)        
        {
            try 
            {
                Console.WriteLine("Enter your File Name");
                string name = Console.ReadLine();
                string text = System.IO.File.ReadAllText(name);
                string[] splittext = text.Split('\n');
                ArrayList valid = new ArrayList();
                ArrayList invalid = new ArrayList();
                foreach(string line in splittext)
                {
                    string[] splitline = line.Split(',');
                    if(splitline.Length >= 3)
                    {   
                        string email = splitline[2];
                        if(email.Contains('@') && email.Contains('.')) 
                        {
                            valid.Add(email);                       
                        }
                        else 
                        {
                            invalid.Add(email);
                        }
                    }                   

                }
                Console.WriteLine("Valid Emails");              
                foreach(string email in valid) 
                {
                    Console.WriteLine(email);
                }
                Console.WriteLine("Invalid Emails");
                foreach(string email in invalid) 
                {
                    Console.WriteLine(email);
                }
            }
            catch 
            {
                Console.WriteLine("Invalid file name, Try again.");
                return;
            }
            
        }
    }
    
}

