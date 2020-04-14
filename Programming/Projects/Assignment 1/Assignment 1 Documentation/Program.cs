using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1NEW
{
    class Program
    {
        const int exit = 5;

        static string[] customerName;
        static string[] numberPlate;

        static void Main(string[] args)
        {
            // set up variables to hold customer details
            customerName = new string[10];
            numberPlate = new string[10];

            FillArray();

            int answerCode = 0;

            //start loop
            do
            {
                // ask user what they want to do
                Console.Clear();
                answerCode = menuSelection();
                //based on that answer 
                switch (answerCode)
                {
                    case 1:
                        // Add a new Car
                        addEntry();
                        break;
                    case 2:
                        //find existing Car
                        findEntry();
                        break;
                    case 3:
                        //remove entry
                        deleteEntry();
                        break;
                    case 4:
                        //list all Cars
                        listEntry();
                        break;

                }
                // exit or ask again
            }
            while (answerCode != exit);

            Console.ReadLine();
        }
        static int menuSelection()
        {
            int result = 0;
            //display menu to user
            Console.WriteLine("Please choose what you would like to do from below list:");
            Console.WriteLine("1: Check in a car");
            Console.WriteLine("2: Find a currently parked car");
            Console.WriteLine("3: Check out a car");
            Console.WriteLine("4: Show list of cars currently parked");
            Console.WriteLine("5: Exit Program");
            
            //read users selection
            string userInput = Console.ReadLine();

            while (!userInput.Equals("1") && !userInput.Equals("2") && !userInput.Equals("3") && !userInput.Equals("4") && !userInput.Equals("5"))
            {
                Console.WriteLine("Please type between 1-5");
                userInput = Console.ReadLine();
            }
            result = Convert.ToInt32(userInput);
            //return the user's selection

            return result;
        }



        static void addEntry()
        {
            string customerNameInput;
            string customerNumberPlateInput;

            //ASk customer for details
            Console.WriteLine("Enter the customer name");
            customerNameInput = Console.ReadLine();
            Console.WriteLine("Enter the customer number plate");
            customerNumberPlateInput = Console.ReadLine();


            //find empty slot in array
            int nextAvailableSlot = FindSlot("");
            if (nextAvailableSlot != -1)
            {
                //Put details into empty slot in the array
                customerName[nextAvailableSlot] = customerNameInput.ToLower();
                numberPlate[nextAvailableSlot] = customerNumberPlateInput.ToLower();

                Console.WriteLine("Car parked.");
                System.Threading.Thread.Sleep(1500);
            }
            else
            {
                Console.WriteLine("No empty parking spaces remain");
                Console.WriteLine("Please inform new customer they will have to wait until one becomes available");
                System.Threading.Thread.Sleep(6000);
            }
        }
        static void findEntry()
        {
   
            
            int identifiedRecord;
            string userInput;
            

            //ask user to identify the customer to be edited
            Console.WriteLine("please enter the name of the customer who's car you want to find");
            userInput = Console.ReadLine();
            identifiedRecord = FindSlot(userInput.ToLower());

            if(identifiedRecord == -1)
            {          
                Console.WriteLine("{0}'s car not found", userInput);
                Console.WriteLine("Press enter to continue");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("{0}'s car has the number plate {1}", customerName[identifiedRecord], numberPlate[identifiedRecord]);
                Console.WriteLine("Press enter to continue");
                Console.ReadLine();
            }
           
        }
        static void deleteEntry()
        {
            //ask the user to identify customer they will be deleting
            Console.WriteLine("\nPlease enter the name of customer who has left the parking spot:\n");
            string nameClient = Console.ReadLine().ToLower();

            int index = FindSlot(nameClient);

            customerName[index] = "";
            numberPlate[index] = "";

            Console.WriteLine("Car checked out");
            System.Threading.Thread.Sleep(2000);
        }
        static void listEntry()
        {
            for (int index = 0; index < customerName.Length; index++)
            {
                if (customerName[index] != "" && customerName[index] != null)
                {
                    Console.WriteLine("Slot {0} is occupied by {1}. Their car has the number plate {2}", index +1, customerName[index], numberPlate[index]);                    
                    Console.ReadLine();                    
                    
                }
                else
                {
                    Console.WriteLine("There are no other cars currently parked");
                    Console.ReadLine();
                    break;
                }                
            }
        }

        static void FillArray()
        {
            for(int i = 0; i< customerName.Length; i++)
            {
                customerName[i] = "";
                numberPlate[i] = "";            
            }
        }


        static int FindSlot(string customerNames)
        {
            int result = -1;
            for (int index = 0; index < customerName.Length; index++)
            {
                    if (customerName[index].Equals(customerNames))
                    {
                        return index;
                    }
                    else if (customerNames.Equals("") && customerName[index].Equals(""))
                    {
                        return index;
                    }
            }
            return result;
        }
    }
}