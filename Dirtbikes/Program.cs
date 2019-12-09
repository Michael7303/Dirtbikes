using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dirtbikes
{    // **************************************************
    //
    // Title: Dirtbikes
    // Description: Demonstration of Classes and objects
    // Application Type: Console
    // Author: 
    // Dated Created: 11/12/2019
    // Last Modified: 12/7/2019
    //
    // **************************************************
    class Program
    {
        static void Main(string[] args)
        {
            //
            // initialize monster list
            //
            List<Dirtbike> Dirtbikes = InitializeDirtbikeList();

            //
            // call methods
            //
            DisplayMenuScreen(Dirtbikes);

        }



        static List<Dirtbike> InitializeDirtbikeList()
        {
            //
            // create list to hold monsters
            //
            List<Dirtbike> dirtbikes = new List<Dirtbike>();

            //
            // make (instantiate) new dirtbikes
            //

            Dirtbike Honda = new Dirtbike();
            Dirtbike Kawasaki = new Dirtbike();
            Dirtbike KTM = new Dirtbike();
            Dirtbike Husqvarna = new Dirtbike();
            Dirtbike beta = new Dirtbike();

            //
            // set property values 
            //

            Honda.Name = "Honda";
            Honda.firstMadeIn = 1949;
            Honda.Age = 70;
            Honda.type = Dirtbike.WhatType.FreeRide;
            Honda.rank = 5;
            
            Husqvarna.Name = "Husqvarna";
            Husqvarna.firstMadeIn = 1918;
            Husqvarna.Age = 101;
            Husqvarna.type = Dirtbike.WhatType.motocross;
            Husqvarna.rank = 2;
            
            Kawasaki.Name = "Kawasaki";
            Kawasaki.firstMadeIn = 1953; 
            Kawasaki.Age = 66;
            Kawasaki.type = Dirtbike.WhatType.motocross;
            Kawasaki.rank = 4;

            KTM.Name = "ktm";
            KTM.firstMadeIn = 1934;
            KTM.Age = 85;
            KTM.type = Dirtbike.WhatType.Supercross;
            KTM.rank = 1;

            beta.Name = "Beta";
            beta.firstMadeIn = 1948;
            beta.Age = 71;
            beta.type = Dirtbike.WhatType.trial;
            beta.rank = 3;

            //
            // add dirtbikes to list
            //
            dirtbikes.Add(Honda);
            dirtbikes.Add(Kawasaki);
            dirtbikes.Add(KTM);
            dirtbikes.Add(Husqvarna);
            dirtbikes.Add(beta);

            return dirtbikes;
        }

        static void DisplayMenuScreen(List<Dirtbike> dirtbikes)

        {
            bool quitApplication = false;
            string menuChoice;

            do

            {

                DisplayScreenHeader("Main Menu");

                //
                // get user menu choice
                //

                Console.WriteLine("a) List All Dirtbikes");
                Console.WriteLine("b) View Dirtbike Detail");
                Console.WriteLine("c) Add Dirtbike");
                Console.WriteLine("d) Delete least favorite Dirtbike");
                Console.WriteLine("e) Update Dirtbike");
                Console.WriteLine("q) Quit");
                Console.Write("Enter Choice:");

                menuChoice = Console.ReadLine().ToLower();



                //
                // process user menu choice
                //

                switch (menuChoice)

                {

                    case "a":
                        DisplayAllDirtbikes(dirtbikes);
                        break;

                    case "b":
                        DisplayViewDirtbikeDetail(dirtbikes);
                        break;

                    case "c":
                        DisplayAddDirtbike(dirtbikes);
                        break;

                    case "d":
                        DisplayDeleteDirtbike(dirtbikes);
                        break;

                    case "e":
                        DisplayUpdateDirtbike(dirtbikes);
                        break;
                                                                                           
                    case "q":

                        quitApplication = true;

                        break;

                    default:

                        Console.WriteLine();

                        Console.WriteLine("Please Enter a letter for the menu choice.");

                        DisplayContinuePrompt();

                        break;

                }





            } while (!quitApplication);

        }



        static void DisplayUpdateDirtbike(List<Dirtbike> dirtbikes)
        {
            bool validResponse = false;
            Dirtbike selectedDirtbike = null;
            do
            {
                DisplayScreenHeader("Update Dirtbike");

                //
                // display all dirtbike names
                //
                Console.WriteLine("\tDirtbike Names");
                Console.WriteLine("\t--------------");
                foreach (Dirtbike dirtbike in dirtbikes)
                {
                    Console.WriteLine("\t" + dirtbike.Name);
                }

                //
                // get user dirtbike choice
                //
                Console.WriteLine();
                Console.Write("\tEnter name:");
                string dirtbikeName = Console.ReadLine();

                //
                // get dirtbike object
                //

                foreach (Dirtbike dirtbike in dirtbikes)
                {
                    if (dirtbike.Name == dirtbikeName)
                    {
                        selectedDirtbike = dirtbike;
                        validResponse = true;
                        break;
                    }

                }

                //
                // feedback for wrong name choice
                //
                if (!validResponse)
                {
                    Console.WriteLine("\tPlease select a correct name");
                    DisplayContinuePrompt();
                }



            } while (!validResponse);


            //
            // update dirtbike
            //

            string userResponse;

            Console.WriteLine("\tReady to update, Press enter to keep the current info.");
            Console.Write($"\tCurrent Name: {selectedDirtbike.Name} New Name:");
            userResponse = Console.ReadLine();
            if (userResponse != "")
            {
                selectedDirtbike.Name = userResponse;
            }

            Console.Write($"\tCurrently made in: {selectedDirtbike.firstMadeIn} New made in year:");
            userResponse = Console.ReadLine();
            if (userResponse != "")
            {
                int.TryParse(userResponse, out int firstMadeIn);
                selectedDirtbike.firstMadeIn = firstMadeIn;
            }

            Console.Write($"\tCurrent Age: {selectedDirtbike.Age} New Age:");
            userResponse = Console.ReadLine();
            if (userResponse != "")
            {
                int.TryParse(userResponse, out int age);
                selectedDirtbike.Age = age;
            }

            Console.Write($"\tCurrent Type: {selectedDirtbike.type} New Type:");
            userResponse = Console.ReadLine();
            if (userResponse != "")
            {
                Enum.TryParse(userResponse, out Dirtbike.WhatType type);
                selectedDirtbike.type = type;
            }

            Console.Write($"\tCurrent Rank: {selectedDirtbike.rank} New Rank:");
            userResponse = Console.ReadLine();
            if (userResponse != "")
            {
                int.TryParse(userResponse, out int rank);
                selectedDirtbike.rank = rank;
            }

            Console.Clear();

            Console.WriteLine();
            Console.WriteLine("\tNew Dirtbike Properties");
            Console.WriteLine("\t-----------------------");
            DirtbikeInfo(selectedDirtbike);
            Console.WriteLine();
            Console.WriteLine("\t-----------------------");


            DisplayContinuePrompt();
        }

        static void DisplayDeleteDirtbike(List<Dirtbike> dirtbikes)
        {
            DisplayScreenHeader("Delete Dirtbike");

            //
            // display all dirtbike names
            //
            Console.WriteLine("\tDirtbike Names");
            Console.WriteLine("\t-------------");
            foreach (Dirtbike dirtbike in dirtbikes)
            {
                Console.WriteLine("\t" + dirtbike.Name);
            }

            //
            // get user dirtbike choice
            //
            Console.WriteLine();
            Console.Write("\tEnter name:");
            string dirtbikeName = Console.ReadLine();

            //
            // get dirtbike object
            //
            Dirtbike selectedDirtbike = null;
            foreach (Dirtbike dirtbike in dirtbikes)
            {
                if (dirtbike.Name == dirtbikeName)
                {
                    selectedDirtbike = dirtbike;
                    break;
                }
            }

            //
            // delete dirtbike
            //
            if (selectedDirtbike != null)
            {
                dirtbikes.Remove(selectedDirtbike);
                Console.WriteLine();
                Console.WriteLine($"\t{selectedDirtbike.Name} deleted");
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine($"\t{dirtbikeName} not found");
            }


            DisplayContinuePrompt();
        }

        static void DisplayViewDirtbikeDetail(List<Dirtbike> dirtbikes)
        {
            DisplayScreenHeader("Dirtbike Detail");
            
            //
            // display all monster names
            //
            Console.WriteLine("\tDirtbike Names");
            Console.WriteLine("\t--------------");
            foreach (Dirtbike dirtbike in dirtbikes)
            {
                Console.WriteLine("\t" + dirtbike.Name);
            }

            //
            // get user dirtbike choice
            //
            Console.WriteLine();
            Console.Write("\tEnter name:");
            string dirtbikeName = Console.ReadLine();

            //
            // get dirtbike object
            //
            Dirtbike selectedDirtbike = null;
            foreach (Dirtbike dirtbike in dirtbikes)
            {
                if (dirtbike.Name == dirtbikeName)
                {
                    selectedDirtbike = dirtbike;
                    break;
                }
            }  
            Console.Clear();
            
            //
            // display dirtbike detail
            //
            Console.WriteLine();
            Console.WriteLine("\t************************");
            DirtbikeInfo(selectedDirtbike);
            Console.WriteLine("\t************************");

            DisplayContinuePrompt();
        }

        static void DisplayAddDirtbike(List<Dirtbike> dirtbikes)
        {
            Dirtbike newDirtbike = new Dirtbike();

            DisplayScreenHeader("Add dirtbikes");

            //
            // add dirtbike object property values
            //
            Console.Write("Name: ");
            newDirtbike.Name = Console.ReadLine();
            Console.WriteLine("Age: ");
            int.TryParse(Console.ReadLine(), out int age);
            newDirtbike.Age = age;
            Console.WriteLine("Attitude: ");
            Enum.TryParse(Console.ReadLine(), out Dirtbike.WhatType type);
            newDirtbike.type = type;

            //
            //echo new dirtbike properties
            //
            Console.WriteLine("\t New Dirtbike Properties");
            DirtbikeInfo(newDirtbike);
            DisplayContinuePrompt();

            dirtbikes.Add(newDirtbike);
        }

        static void DisplayAllDirtbikes(List<Dirtbike> dirtbikes)
        {

            DisplayScreenHeader("All Dirtbikes");

            Console.WriteLine("\t***************************");
            foreach (Dirtbike dirtbike in dirtbikes)
            {
                DirtbikeInfo(dirtbike);
                Console.WriteLine();
                Console.WriteLine("\t***************************");
                
            }

            DisplayContinuePrompt();
        }


        static void DirtbikeInfo(Dirtbike dirtbike)
        {
            Console.WriteLine($"\tName: {dirtbike.Name}");
            Console.WriteLine($"\tMade In: {dirtbike.firstMadeIn}");
            Console.WriteLine($"\tage: {dirtbike.Age}");
            Console.WriteLine($"\tType: {dirtbike.type}");
            Console.WriteLine($"\tRanked: {dirtbike.rank}");
        }


        #region HELPER METHODS

        /// <summary>
        /// display welcome screen
        /// </summary>
        static void DisplayWelcomeScreen()
        {
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine("\t\tDirtbikes");
            Console.WriteLine();

            DisplayContinuePrompt();
        }

        /// <summary>
        /// display closing screen
        /// </summary>
        static void DisplayClosingScreen()
        {
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine("\t\tThank you for using dirtbikes!");
            Console.WriteLine();

            DisplayContinuePrompt();
        }

        /// <summary>
        /// display continue prompt
        /// </summary>
        static void DisplayContinuePrompt()
        {
            Console.WriteLine();
            Console.WriteLine("Press any key to continue.");
            Console.ReadKey();
        }

        /// <summary>
        /// display main menu prompt
        /// </summary>
        static void DisplayMainMenuPrompt()
        {
            Console.WriteLine();
            Console.WriteLine("Press any key to return to the Main Menu.");
            Console.ReadKey();
        }

        /// <summary>
        /// display screen header
        /// </summary>
        static void DisplayScreenHeader(string headerText)
        {
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine("\t\t" + headerText);
            Console.WriteLine();
        }

        #endregion
    }
}
