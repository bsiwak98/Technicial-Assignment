/*      
    Bibek Siwakoti
    06/24/2021
    Techincal Assignment for GDC
*/
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
                // create array list for valid and invalid emails.
                ArrayList valid = new ArrayList();
                ArrayList invalid = new ArrayList();
                //split text into lines
                foreach(string line in splittext)
                {
                    //split lines into values
                    string[] splitline = line.Split(',');
                    if(splitline.Length >= 3)
                    {   
                        //assume third value is email
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

