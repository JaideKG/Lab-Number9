using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Number8
{
    class Program
    {
        static void Main(string[] args)
        {

            //List<string>
            //ArrayList
            //No curly brace syntax to creat list
            //nameList.Add;
            //atleast 5+ names
            //Console.WriteLine("Do you want information or add a name?");
            //if they want to add another student, a question must be added for each set of info
            //always adding to the end of the array list
            //Extended challenge, can't just sort. Inserting at certain position. 
            //After doing list, do so with dictionary and/or hashtable


            Console.WriteLine("Welcome to our C# class.");

            ArrayList nameList = new ArrayList();

            nameList.Add("Angela");
            nameList.Add("Bob");
            nameList.Add("Cathy");
            nameList.Add("Daryl");
            nameList.Add("Erica");
            nameList.Add("Frank");
            nameList.Add("Gayle");
            nameList.Add("Harry");
            nameList.Add("Ilene");
            nameList.Add("Jack");
            nameList.Add("Karyn");
            nameList.Add("Larry");
            nameList.Add("Mary");
            nameList.Add("Nick");
            nameList.Add("Ola");
            nameList.Add("Patrick");
            nameList.Add("Qiara");
            nameList.Add("Ronald");
            nameList.Add("Samantha");
            nameList.Add("Travis");


            ArrayList HometownList = new ArrayList();

            HometownList.Add("Appleton");
            HometownList.Add("Broderick");
            HometownList.Add("Castleton");
            HometownList.Add("Detroit");
            HometownList.Add("Easton");
            HometownList.Add("Fullerton");
            HometownList.Add("Georgetown");
            HometownList.Add("Hockey");
            HometownList.Add("Illinois");
            HometownList.Add("Jackson");
            HometownList.Add("Keaton");
            HometownList.Add("Lansing");
            HometownList.Add("Minneapolis");
            HometownList.Add("Nickelson");
            HometownList.Add("Ottowa");
            HometownList.Add("Persian");
            HometownList.Add("Quebec");
            HometownList.Add("Rosedale");
            HometownList.Add("Sarasota");
            HometownList.Add("Townsville");


            ArrayList FoodList = new ArrayList();

            FoodList.Add("Apricots");
            FoodList.Add("Blueberries");
            FoodList.Add("Cherries");
            FoodList.Add("Durian");
            FoodList.Add("Elderberries");
            FoodList.Add("Figs");
            FoodList.Add("Grapes");
            FoodList.Add("Honeydew");
            FoodList.Add("Imbe");
            FoodList.Add("Java Apple");
            FoodList.Add("Kiwi");
            FoodList.Add("Lime");
            FoodList.Add("Orange");
            FoodList.Add("Pear");
            FoodList.Add("Quince");
            FoodList.Add("Raspberries");
            FoodList.Add("Strawberries");
            FoodList.Add("Tangerine");


            ArrayList NumberList = new ArrayList();

            NumberList.Add(1);
            NumberList.Add(2);
            NumberList.Add(3);
            NumberList.Add(4);
            NumberList.Add(5);
            NumberList.Add(6);
            NumberList.Add(7);
            NumberList.Add(8);
            NumberList.Add(9);
            NumberList.Add(10);
            NumberList.Add(11);
            NumberList.Add(12);
            NumberList.Add(13);
            NumberList.Add(14);
            NumberList.Add(15);
            NumberList.Add(16);
            NumberList.Add(17);
            NumberList.Add(18);
            NumberList.Add(19);
            NumberList.Add(20);


            string response = "Y";
            while (response == "Y")
            {



                {
                    Console.WriteLine("Would you like to add a student or learn about a student? (Add or Learn)?");
                    string answer = Console.ReadLine();

                    if (answer == "Add")
                    {
                        Console.WriteLine("Please enter a name: ");
                        string name = Console.ReadLine();
                        while(name == "")
                        {
                            Console.WriteLine("Blank spaces are invalid.");
                            Console.WriteLine("Please enter a name: ");
                            name = Console.ReadLine();
                        }
                        nameList.Add(name);
                        

                        Console.WriteLine("Please enter hometown");
                        string hometown = Console.ReadLine();
                        HometownList.Add(hometown);
                        while(hometown == "")
                        {
                            Console.WriteLine("Blank spaces are invalid.");
                            Console.WriteLine("Please enter the hometown: ");
                            hometown = Console.ReadLine();
                        }

                        Console.WriteLine("Please enter food");
                        string food = Console.ReadLine();
                        while(food == "")
                        {
                            Console.WriteLine("Blank spaces are invalid.");
                            Console.WriteLine("Please enter food item: ");
                            food = Console.ReadLine();
                        }
                        FoodList.Add(food);
                        Console.WriteLine("Please enter number");
                        int number = 0;
                        int.TryParse(Console.ReadLine(), out number);
                        while(number == 0)
                        {
                            Console.WriteLine("Blank spaces are invalid.");
                            Console.WriteLine("Please enter a number: ");
                            int.TryParse(Console.ReadLine(), out number);
                        }
                        NumberList.Add(number);

                       
                    }
                    else if (answer == "Learn")
                    {

                        Console.WriteLine($"Index has to be a number between 1 and {nameList.Count}.");
                        Console.WriteLine("Please enter a number.");
                        string input = Console.ReadLine();
                                                
                        int index;
                        int.TryParse(input, out index);

                        while(index < 1 || index > nameList.Count)
                        {
                            Console.WriteLine($"Index has to be a number between 1 and {nameList.Count}");
                            Console.WriteLine("Please enter a number.");
                            input = Console.ReadLine();
                                                       
                            int.TryParse(input, out index);
                        }
                                                                    
                        index--;
                   


                        {
                            string respTwo = "Y";
                            while (respTwo == "Y")
                            {

                                Console.WriteLine($" What would you like to know about {nameList[index]}? (enter hometown, food, number)");
                                string responseOne = Console.ReadLine();
                                while (responseOne != "hometown" && responseOne != "food" && responseOne != "number")
                                {
                                    Console.WriteLine("The data does not exist. Please try again. (enter \"hometown\" or \"food\" or \"number\"");
                                    responseOne = Console.ReadLine();
                                }

                                if (responseOne == "hometown")
                                {
                                    Console.WriteLine($"{nameList[index]} is from {HometownList[index]}.");
                                }
                                else if (responseOne == "food")
                                {
                                    Console.WriteLine($"{nameList[index]}\'s favorite food is {FoodList[index]}.");
                                }
                                else if (responseOne == "number")
                                {
                                    Console.WriteLine($"{nameList[index]}\'s favorite number is {NumberList[index]}.");
                                }

                                Console.WriteLine("Would you like tot learn more about the student? (Y/N)?");
                                respTwo = Console.ReadLine();
                                while(respTwo != "Y" && respTwo != "N")
                                {
                                    Console.WriteLine("Your response is invalid.");
                                    Console.WriteLine("Would you like to learn more about the student? (Y/N)?");
                                    respTwo = Console.ReadLine();
                                }

                          
                            }



                        }
                    }
                    else
                    {
                        Console.WriteLine("Your input is not valid. Try again.");
                        continue;
                    }

                    Console.WriteLine("Would you like to continue? (Y/N)?");
                    response = Console.ReadLine().ToUpper();
                    while (response != "Y" && response != "N")
                    {
                        Console.WriteLine("Your response is not valid.");
                        Console.WriteLine("Would you like to continue? (Y/N)?");
                        response = Console.ReadLine().ToUpper();
                    }
                    

                    if (response.ToUpper() == "N")
                    {
                        Console.WriteLine("Thanks!");

                        break;
                    }
                }

            }
        }
    }
}







