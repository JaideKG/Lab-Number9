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
            //myList.Add;
            //atleast 5+ names
            //Console.WriteLine("Do you want information or add a name?");
            //if they want to add another student, a question must be added for each set of info
            //always adding to the end of the array list
            //Extended challenge, can't just sort. Inserting at certain position. 
            //After doing list, do so with dictionary and/or hashtable


            Console.WriteLine("Welcome to our C# class.");

            ArrayList myList = new ArrayList();

            myList.Add("Angela");
            myList.Add("Bob");
            myList.Add("Cathy");
            myList.Add("Daryl");
            myList.Add("Erica");
            myList.Add("Frank");
            myList.Add("Gayle");
            myList.Add("Harry");
            myList.Add("Ilene");
            myList.Add("Jack");
            myList.Add("Karyn");
            myList.Add("Larry");
            myList.Add("Mary");
            myList.Add("Nick");
            myList.Add("Ola");
            myList.Add("Patrick");
            myList.Add("Qiara");
            myList.Add("Ronald");
            myList.Add("Samantha");
            myList.Add("Travis");


            ArrayList NextList = new ArrayList();

            NextList.Add("Appleton");
            NextList.Add("Broderick");
            NextList.Add("Castleton");
            NextList.Add("Detroit");
            NextList.Add("Easton");
            NextList.Add("Fullerton");
            NextList.Add("Georgetown");
            NextList.Add("Hockey");
            NextList.Add("Illinois");
            NextList.Add("Jackson");
            NextList.Add("Keaton");
            NextList.Add("Lansing");
            NextList.Add("Minneapolis");
            NextList.Add("Nickelson");
            NextList.Add("Ottowa");
            NextList.Add("Persian");
            NextList.Add("Quebec");
            NextList.Add("Rosedale");
            NextList.Add("Sarasota");
            NextList.Add("Townsville");


            ArrayList ThirdList = new ArrayList();

            ThirdList.Add("Apricots");
            ThirdList.Add("Blueberries");
            ThirdList.Add("Cherries");
            ThirdList.Add("Durian");
            ThirdList.Add("Elderberries");
            ThirdList.Add("Figs");
            ThirdList.Add("Grapes");
            ThirdList.Add("Honeydew");
            ThirdList.Add("Imbe");
            ThirdList.Add("Java Apple");
            ThirdList.Add("Kiwi");
            ThirdList.Add("Lime");
            ThirdList.Add("Orange");
            ThirdList.Add("Pear");
            ThirdList.Add("Quince");
            ThirdList.Add("Raspberries");
            ThirdList.Add("Strawberries");
            ThirdList.Add("Tangerine");


            ArrayList FourthList = new ArrayList();

            FourthList.Add("1");
            FourthList.Add("2");
            FourthList.Add("3");
            FourthList.Add("4");
            FourthList.Add("5");
            FourthList.Add("6");
            FourthList.Add("7");
            FourthList.Add("8");
            FourthList.Add("9");
            FourthList.Add("10");
            FourthList.Add("11");
            FourthList.Add("12");
            FourthList.Add("13");
            FourthList.Add("14");
            FourthList.Add("15");
            FourthList.Add("16");
            FourthList.Add("17");
            FourthList.Add("18");
            FourthList.Add("19");
            FourthList.Add("20");


            string response = "Y";
            while (response == "Y")
            {
                int counter = 0;
                for (int i = 0; i < 10; i++)
                {
                    if (counter == 0)
                        Console.WriteLine("Which student would you like to learn more about?(enter a number 1-20)");
                    string input = Console.ReadLine();

                    int index;
                    int.TryParse(input, out index);

                    index--;


                    Console.WriteLine($" What would you like to know about {myList[index]}? (enter hometown, food, number)");
                    string responseOne = Console.ReadLine();
                    while (responseOne != "hometown" && responseOne != "food" && responseOne != "number")
                    {
                        Console.WriteLine("The data does not exist. Please try again. (enter \"hometown\" or \"food\" or \"number\"");
                        responseOne = Console.ReadLine();
                    }

                    if (responseOne == "hometown")
                    {
                        Console.WriteLine($"{myList[index]} is from {NextList[index]}.");
                    }
                    else if (counter > 0 && input == "food")
                    {
                        Console.WriteLine($"{myList[index]}\'s favorite food is {ThirdList[index]}.");
                    }
                    else if (counter > 0 && input == "number")
                    {
                        Console.WriteLine($"{myList[index]}\'s favorite number is {FourthList[index]}.");
                        Console.ReadLine();
                    }
                    else if (input == "new student")
                    {
                        counter = -1;
                    }
                    else
                    {
                        Console.WriteLine("Sorry, your input is invalid.");
                    }



                }
                Console.WriteLine("Would you like to enter another number? (Y/N)?");
                response = Console.ReadLine();





                if (response.ToUpper() == "N")
                {
                    Console.WriteLine("Thanks!");

                }
            }

        }
    }
}







