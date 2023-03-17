﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserRegistrationProblems
{
    public class Program
    {
        static void Main(string[] args)
        {
            bool check = true;
            while (check)
            {
                Console.Clear();
                Console.WriteLine("Please choose any options");
                Console.WriteLine("1.Check Validation for First Name\n" +
                    "2.Exit\n");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        Console.Clear();
                        string code = Pattern.firstNamePattern;
                        Console.WriteLine("Enter how many first name want to check for validation:");
                        int number = Convert.ToInt32(Console.ReadLine());
                        string[] firstNameInputs = new string[number];
                        Console.WriteLine("\nList of FirstName between 1 to {0} for check validation:\n----------------------------------------------------", number);
                        for (int i = 0; i < number; i++)
                        {
                            Console.Write("{0} =>  ", i + 1);
                            firstNameInputs[i] = Console.ReadLine();
                        }
                        Console.WriteLine("\nList of valid and Invalid FirstName:\n-------------------------------------");
                        Pattern.ValidatePattern(firstNameInputs, code);
                        Console.Write("\nPress any key to continue...... ");
                        Console.ReadLine();
                        break;
                    default:
                        check = false;
                        break;
                }
            }
        }
    }
}