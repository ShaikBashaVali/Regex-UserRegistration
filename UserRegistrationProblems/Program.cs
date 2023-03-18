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
                    "2.Check Validation for Last Name\n" +
                    "3.Check validation for Email Id\n" +
                    "4.Check validation for Mobile Number\n" +
                    "5.Check validation for Password Rule1\n" +
                    "6.Check validation for Password Rule2\n" +
                    "7.Check validation for Password Rule3\n" +
                    "8.Exit\n");
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
                    case 2:
                        Console.Clear();
                        string code1 = Pattern.lastNamePattern;
                        Console.WriteLine("Enter how many last name want to check for validation:");
                        int number1 = Convert.ToInt32(Console.ReadLine());
                        string[] lastNameInputs = new string[number1];
                        Console.WriteLine("\nList of LastName between 1 to {0} for check validation:\n----------------------------------------------------", number1);
                        for (int i = 0; i < number1; i++)
                        {
                            Console.Write("{0} =>  ", i + 1);
                            lastNameInputs[i] = Console.ReadLine();
                        }
                        Console.WriteLine("\nList of valid and Invalid Last Name:\n-------------------------------------");
                        Pattern.ValidatePattern(lastNameInputs, code1);
                        Console.Write("\nPress any key to continue...... ");
                        Console.ReadLine();
                        break;
                    case 3:
                        Console.Clear();
                        string code2 = Pattern.EmailIdPattern;
                        Console.WriteLine("Enter how many email id want to check for validation:");
                        int number2 = Convert.ToInt32(Console.ReadLine());
                        string[] emailIdInputs = new string[number2];
                        Console.WriteLine("\nList of Email id between 1 to {0} for check validation:\n----------------------------------------------------", number2);
                        for (int i = 0; i < number2; i++)
                        {
                            Console.Write("{0} =>  ", i + 1);
                            emailIdInputs[i] = Console.ReadLine();
                        }
                        Console.WriteLine("\nList of valid and Invalid Email Id:\n-------------------------------------");
                        Pattern.ValidatePattern(emailIdInputs, code2);
                        Console.Write("\nPress any key to continue...... ");
                        Console.ReadLine();
                        break;

                    case 4:
                        Console.Clear();
                        string code3 = Pattern.MobileNumberPattern;
                        Console.WriteLine("Enter how many mobile number want to check for validation:");
                        int number3 = Convert.ToInt32(Console.ReadLine());
                        string[] mobileNumberInputs = new string[number3];
                        Console.WriteLine("\nList of mobile number between 1 to {0} for check validation:\n----------------------------------------------------", number3);
                        for (int i = 0; i < number3; i++)
                        {
                            Console.Write("{0} =>  ", i + 1);
                            mobileNumberInputs[i] = Console.ReadLine();
                        }
                        Console.WriteLine("\nList of valid and Invalid Mobile number:\n-------------------------------------");
                        Pattern.ValidatePattern(mobileNumberInputs, code3);
                        Console.Write("\nPress any key to continue...... ");
                        Console.ReadLine();
                        break;
                    case 5:
                        Console.Clear();
                        string code4 = Pattern.PasswordRule1Pattern;
                        Console.WriteLine("Enter how many password want to check for minimum 8 Characters.:");
                        int number4 = Convert.ToInt32(Console.ReadLine());
                        string[] passwordRule1Inputs = new string[number4];
                        Console.WriteLine("\nList of Password between 1 to {0} for check validation:\n----------------------------------------------------", number4);
                        for (int i = 0; i < number4; i++)
                        {
                            Console.Write("{0} =>  ", i + 1);
                            passwordRule1Inputs[i] = Console.ReadLine();
                        }
                        Console.WriteLine("\nAfter apply Rule-1 List of valid and Invalid Password:\n-------------------------------------");
                        Pattern.ValidatePattern(passwordRule1Inputs, code4);
                        Console.Write("\nPress any key to continue...... ");
                        Console.ReadLine();
                        break;
                    case 6:
                        Console.Clear();
                        string code5 = Pattern.PasswordRule2Pattern;
                        Console.WriteLine("Enter how many password want to check at least 1 Upper Case:");
                        int number5 = Convert.ToInt32(Console.ReadLine());
                        string[] passwordRule2Inputs = new string[number5];
                        Console.WriteLine("\nList of Password between 1 to {0} for check validation:\n----------------------------------------------------", number5);
                        for (int i = 0; i < number5; i++)
                        {
                            Console.Write("{0} =>  ", i + 1);
                            passwordRule2Inputs[i] = Console.ReadLine();
                        }
                        Console.WriteLine("\nAfter apply Rule-2 List of valid and Invalid Password:\n-------------------------------------");
                        Pattern.ValidatePattern(passwordRule2Inputs, code5);
                        Console.Write("\nPress any key to continue...... ");
                        Console.ReadLine();
                        break;
                    case 7:
                        Console.Clear();
                        string code6 = Pattern.PasswordRule3Pattern;
                        Console.WriteLine("Enter how many password want to check at least 1 numeric number.:");
                        int number6 = Convert.ToInt32(Console.ReadLine());
                        string[] passwordRule3Inputs = new string[number6];
                        Console.WriteLine("\nList of Password between 1 to {0} for check validation:\n----------------------------------------------------", number6);
                        for (int i = 0; i < number6; i++)
                        {
                            Console.Write("{0} =>  ", i + 1);
                            passwordRule3Inputs[i] = Console.ReadLine();
                        }
                        Console.WriteLine("\nAfter apply Rule-3 List of valid and Invalid Password:\n-------------------------------------");
                        Pattern.ValidatePattern(passwordRule3Inputs, code6);
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