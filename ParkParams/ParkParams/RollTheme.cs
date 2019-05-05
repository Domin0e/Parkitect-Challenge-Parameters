using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Threading.Tasks;
using System.Diagnostics;
using System.ComponentModel;
using System.IO;

namespace ParkParams
{
    static class RollTheme
    {
        static public List<string> themes, modifiers, buildreq, guestmod, rides, centerpiece, goal = new List<string>();
        static string[] goalHoldTime = { "None", "1 month", "2 months", "3 months", "6 months", "9 months", "1 year" };
        static string[] fees = { "Free Entry", "Free Rides", "Free Shops", "Free Entry and Rides", "Free Entry and Shops", "Free Rides and Shops", "None", "None", "None", "None", "None", "None" };
        static Random rand = new Random();

        static public void loadLists()
        {
            string folder = Path.GetDirectoryName(Process.GetCurrentProcess().MainModule.FileName) + @"\Lists\"; //Process.GetCurrentProcess().MainModule.FileName
            
            string filter = "Themes.txt";
            string[] files = Directory.GetFiles(folder, filter);
            themes = File.ReadAllLines(files[0]).ToList();

            filter = "Modifiers.txt";
            files = Directory.GetFiles(folder, filter);
            modifiers = File.ReadAllLines(files[0]).ToList();

            filter = "Build Requirements.txt";
            files = Directory.GetFiles(folder, filter);
            buildreq = File.ReadAllLines(files[0]).ToList();

            filter = "Guest Modificators.txt";
            files = Directory.GetFiles(folder, filter);
            guestmod = File.ReadAllLines(files[0]).ToList();

            filter = "Rides.txt";
            files = Directory.GetFiles(folder, filter);
            rides = File.ReadAllLines(files[0]).ToList();
            
            filter = "Centerpiece.txt";
            files = Directory.GetFiles(folder, filter);
            centerpiece = File.ReadAllLines(files[0]).ToList();
            
            filter = "Goals.txt";
            files = Directory.GetFiles(folder, filter);
            goal = File.ReadAllLines(files[0]).ToList();
        }
        static public string RollForTheme()
        {
            return themes[rand.Next(themes.Count)];
        }

        static public string RollForModifier()
        {
            string modifier = modifiers[rand.Next(modifiers.Count)];

            switch (modifier)
            {
                case "Build Requirement:":
                    modifier += RollforBuild();
                    break;
                case "Guest Modifier:":
                    modifier += RollforGuest();
                    break;
                case "Ride Requirement:":
                    modifier += RollforRide();
                    break;
                case "Centerpiece Requirement:":
                    modifier += RollforWeenie();
                    break;
            } 
            
            return modifier;
        }

        static public string RollforGoal()
        {
            string goals = goal[rand.Next(goal.Count)];

            if (goals.Contains("rating") && !goals.Contains("Operating"))
            {
                goals += " " + rand.Next(65, 96).ToString();
                return goals;
            }

            switch (goals)
            {
                case "Coaster count:":
                    goals += " " + rand.Next(1, 11).ToString();
                    break;
                case "Guest count:":
                    goals += " " + rand.Next(300, 1501).ToString();
                    break;
                case "Money:":
                    goals += " " + rand.Next(50000, 100001).ToString();
                    break;
                case "Park tickets:":
                    goals += " " + rand.Next(300, 3001).ToString();
                    break;
                case "Ride profit:":
                case "Operating profit:":
                case "Shop profit:":
                    goals += " " + rand.Next(1500, 15001).ToString();
                    break;
            }
            return goals;
        }

        static private string RollforBuild()
        {
            return " " + buildreq[rand.Next(buildreq.Count)];
        }

        static private string RollforGuest()
        {
            return " " + guestmod[rand.Next(guestmod.Count)];
        }

        static private string RollforRide()
        {
            return " " + rides[rand.Next(rides.Count)];
        }

        static private string RollforWeenie()
        {
            string returnstring = centerpiece[rand.Next(centerpiece.Count)];
            if (returnstring == "Ride")
            {
                returnstring = RollforRide();
            }
            return " " + returnstring;
        }

        static public int RollForMoney()
        {
            int money = rand.Next(5000, 50001);
            money /= 500;
            money *= 500;
            return money;
        }

        static public string RollForLoan()
        {
            int number = rand.Next(0, 100);
            if (number < 50)
            {
                return "No Loans Allowed";
            }
            else
            {
                return "Loans Allowed";
            }
        }

        static public string RollForFees()
        {
            return fees[rand.Next(fees.Length)];
        }

        static public string RollForGoaltime()
        {
            return goalHoldTime[rand.Next(goalHoldTime.Length)];
        }

        static public string RollForMapsize()
        {
            return "Park size: " + rand.Next(20, 101) + " x " + rand.Next(20, 101);
        }
    }
}
