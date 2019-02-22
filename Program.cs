using System;

namespace Encoder
{
    class Program
    {
            static void Main(string[] args)
            {
                do
                {
                    Console.WriteLine("What is the Project and Activity Name?");
                    Console.WriteLine("Project Name: ");
                    string project = GetInput();
                    Console.WriteLine("Activity Name: ");
                    string activity = GetInput();

                    Console.WriteLine("https://companyserver.com/content/{0}/files/{1}/{1}Report.pdf", project, activity, activity);
                    Console.WriteLine("Would you like to try another URL? (yes/no): ");

                } while (Console.ReadLine().ToLower().Equals("yes"));
            } // end main 

           static string GetInput()
            {
                string input = "";

                do
                {
                    input = Console.ReadLine();
                    if (IsValid(input)) return input;
                    else Console.WriteLine("This input does not have the correct characters.  Please try again.");

                } while (true);
            } // end GetInput 

            static bool IsValid(string input)
            {
       
                if (input == "0x00 - 1F")
                {
                    return true;
                }
                else
                {
                    return false; 
                }

                foreach (char text in input.ToCharArray())
                {
                    char character = ' ';

                    if (character == '!')
                    {
                        Console.WriteLine("%21");
                    }
                    if (character == ' ')
                    {
                        Console.WriteLine("%20");
                    }
                    if (character == '"')
                    {
                        Console.WriteLine("%22");
                    }
                    if (character == '#')
                    {
                        Console.WriteLine("%23");
                    }
                    if (character == '$')
                    {
                        Console.WriteLine("%24");
                    }
                    if (character == '%')
                    {
                        Console.WriteLine("%25");
                    }
                    if (character == '&')
                    {
                        Console.WriteLine("%26");
                    }
                    if (character == '(')
                    {
                        Console.WriteLine("%28");
                    }
                    if (character == ')')
                    {
                        Console.WriteLine("%29");
                    }
                    if (character == '*')
                    {
                        Console.WriteLine("%2A");
                    }
                    if (character == '+')
                    {
                        Console.WriteLine("%2B");
                    }
                    if (character == ',')
                    {
                        Console.WriteLine("%2C");
                    }
                    if (character == '-')
                    {
                        Console.WriteLine("%2D");
                    }
                    if (character == '.')
                    {
                        Console.WriteLine("%2E");
                    }
                    if (character == '>')
                    {
                        Console.WriteLine("%3E");
                    }
                    if (character == '<')
                    {
                        Console.WriteLine("%3C");
                    }
                    if (character == '/')
                    {
                        Console.WriteLine("%2F");
                    }
                    if (character == '?')
                    {
                        Console.WriteLine("%3F");
                    }
                    if (character == '@')
                    {
                        Console.WriteLine("%40");
                    }
                    if (character == ':')
                    {
                        Console.WriteLine("%3A");
                    }
                    if (character == '=')
                    {
                        Console.WriteLine("%3D");
                    }
                    if (character == '{')
                    {
                        Console.WriteLine("%7B");
                    }
                    if (character == '}')
                    {
                        Console.WriteLine("%7D");
                    }
                    if (character == '|')
                    {
                        Console.WriteLine("%7C");
                    }
                    if (character == '^')
                    {
                        Console.WriteLine("%5E");
                    }
                    if (character == '[')
                    {
                        Console.WriteLine("%5B");
                    }
                    if (character == ']')
                    {
                        Console.WriteLine("%5D");
                    }
                    if (character == '`')
                    {
                        Console.WriteLine("%60");
                    }
                } // end foreach

             } // end IsValid 

    } // end class
} // end namespace 
