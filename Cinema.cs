﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowControl
{
    public class Cinema //Class for handling Cinema business
    {
        private static int CinemaPrices(int age) //Set private so it is only accessible from within this class
        {
            int price = 0;

            if (age < 20) //If-statements that check the age input, and will return the price
            {
                if (age < 5)
                {
                    price = 0;
                }
                else if (age >= 5)
                {
                    price = 80;
                }
            }
            else if (age >= 20)
            {
                if (age >= 20 && age <= 64)
                {
                    price = 120;
                }
                else if (age > 64 && age <= 100)
                {
                    price = 90;
                }
                else
                {
                    price = 0;
                }
            }
            return price;
        }

        public static void CinemaAgeCheck() //Method to check print the prices depending on the visitors age
        {
            int price = 0;

            Console.Write("Welcome to the cinema!\nPlease enter your age to check the price for your ticket: ");
            int.TryParse(Console.ReadLine(), out int input); //Parsing the string input into an int

            if (input < 20)
            {
                if (input < 5)
                {
                    Console.WriteLine("Children under the age of 5 enter for free");
                }
                else if (input >= 5)
                {
                    price = CinemaPrices(input); //Caling the method which contains the prices and presenting the return value below
                    Console.WriteLine($"Youth ticket price: {price} SEK");
                }
            }
            else if (input >= 20)
            {
                if (input >= 20 && input <= 64)
                {
                    price = CinemaPrices(input);
                    Console.WriteLine($"Standard ticket price: {price} SEK");
                }
                else if (input > 64 && input <= 100)
                {
                    price = CinemaPrices(input);
                    Console.WriteLine($"Pensioner ticket price: {price} SEK");
                }
                else
                { 
                    Console.WriteLine("Pensioners over the age of 100 enter for free");
                }
            }
            else
            {
                Console.WriteLine("Error beep boop");
            }
        }

        public static void CinemaTotal() //Method for total of guests and the total price for thei tickets
        {
            int pricePerPerson = 0;
            int totalPrice = 0;

            Console.Write("Welcome to the cinema!\nPlease enter how many tickets you would like to buy: ");
            int.TryParse(Console.ReadLine(), out int numberOfTickets); //Saving the string user input into an int by parsing
            int[] ticketArray = new int[numberOfTickets]; //User input value is used to create the array, if the user asks for 5 tickets, then the numberOfTickets variable will set the array size to 5

            Console.Write("\nPlease enter the age of each person you are buying a ticket for. ");

            foreach (int ticket in ticketArray) //Looping through the value the user chose, asking for the age of each person 
            {
                Console.Write("\nAge: ");
                int.TryParse(Console.ReadLine(), out int ageInput);
                pricePerPerson = CinemaPrices(ageInput); //Calling the CinemaPrices method using the age and getting the price in return
                totalPrice += pricePerPerson; //Adding each price input to the totalPrice variable
            }
            Console.WriteLine("Number of tickets: " + numberOfTickets.ToString());
            Console.WriteLine("Total price for all tickets: " + totalPrice);

        }
    }
}