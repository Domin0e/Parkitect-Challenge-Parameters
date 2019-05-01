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
        static public List<string> themes, modifiers, buildreq, guestmod, rides, centerpiece = new List<string>();
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
                    modifier += RollforRide();
                    break;
            } 
            
            return modifier;
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
            string returnstring = centerpiece[rand.Next(rides.Count)];
            if (returnstring == "Ride")
            {
                returnstring = RollforRide();
            }
            return " " + returnstring;
        }
    }
}
