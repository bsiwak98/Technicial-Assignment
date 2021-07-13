/*      
    Bibek Siwakoti
    06/24/2021
    Techincal Assignment Refactoring  for GDC
*/
using System;
using System.IO;
using System.Collections;
using System.Text.RegularExpressions;
using System.Net.Mail;
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
                        //use Regular Expessions
                        Regex regex = new Regex(@"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\.)+))([azA-Z]{2,4}|[0-9]{1,3})(\]?)$");  
                        Match match = regex.Match(email);  
                        if(match.Success) 
                        {
                            valid.Add(email);                       
                        }
                        else 
                        {
                            invalid.Add(email);
                        }
                    }                   

                } 
                //print out results
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
                //let people write the file name
                Console.WriteLine("Invalid file name, Try again.");
                return;
            }
            
        }
    }
    
}

