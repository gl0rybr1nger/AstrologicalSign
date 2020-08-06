using System;

namespace AstrologicalSignB
{
    class Program
    {
       
            static void Main(string[] args)
            {

                
                var month = "0.0";
                var menuAnswer = "0.0";

                while (menuAnswer != "N")
                {
                    Console.WriteLine("Do you want to know your astrological sign?\nY for yes\nN for no");
                    menuAnswer = Console.ReadLine();

                    if (menuAnswer.ToUpper() == "Y")
                    {

                        Console.WriteLine("what month were you born");
                        month = Console.ReadLine();
                        

                        if (month == "1" || month.ToLower() == "january" || month.ToLower() == "jan")
                        {
                        Console.WriteLine("You are either a Capricorn or Aquarious!");
                        }
                        else if (month == "2" || month.ToLower() == "february" || month.ToLower() == "feb")
                        {
                        Console.WriteLine("You are either an Aquarious or Pisces!");
                    }
                        else if (month == "3" || month.ToLower() == "march")
                        {
                        Console.WriteLine("You are either a Pisces or Aires!");
                    }
                        else if (month == "4" || month.ToLower() == "april")
                        {
                        Console.WriteLine("You are either an Aires or Tarus!");
                    }
                        else if (month == "5" || month.ToLower() == "may")
                        {
                        Console.WriteLine("You are either a Tarus ot Gemini");
                    }
                        else if (month == "6" || month.ToLower() == "june")
                        {
                        Console.WriteLine("You are either a Gemini or Cancer!");
                    }
                        else if (month == "7" || month.ToLower() == "july")
                        {
                        Console.WriteLine("You are either a Cancer or Leo!");
                    }
                        else if (month == "8" || month.ToLower() == "august" || month.ToLower() == "aug")
                        {
                        Console.WriteLine("You are either a Leo or Virgo!");
                    }
                        else if (month == "9" || month.ToLower() == "september" || month.ToLower() == "sept")
                        {
                        Console.WriteLine("You are either a Virgo or Libra!");
                    }
                        else if (month == "10" || month.ToLower() == "october" || month.ToLower() == "oct")
                        {
                        Console.WriteLine("You are either a Libra or Scorpio!");
                    }
                        else if (month == "11" || month.ToLower() == "november" || month.ToLower() == "nov")
                        {
                        Console.WriteLine("You are either a Scorpio or Sagitarius!");
                    }
                        else if (month == "12" || month.ToLower() == "december" || month.ToLower() == "dec")
                        {
                        Console.WriteLine("You are either a Sagitarius or Capricorn!");
                    }
                        else
                        {
                            Console.WriteLine("Nope try again...");
                        }
                    }
                    else if (menuAnswer.ToUpper() == "N")
                    {
                    Console.ReadLine();
                    }
                    else
                    {
                        Console.WriteLine("Nope try again...");
                    }

                }



            }
        }
    }

