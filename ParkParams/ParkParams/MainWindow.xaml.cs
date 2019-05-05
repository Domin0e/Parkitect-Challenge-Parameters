using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ParkParams
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            RollTheme.loadLists();
        }

        private bool CheckModLegal(string input)
        {
            if (input.Contains("Climate"))
            {
                if (textboxModOne.Text.Contains("Climate") || textboxModTwo.Text.Contains("Climate") || textboxModThree.Text.Contains("Climate") || textboxModFour.Text.Contains("Climate") || textboxModFive.Text.Contains("Climate"))
                {
                    return true;
                }
            }
            else if (input.Contains("Centerpiece"))
            {
                if (textboxModOne.Text.Contains("Centerpiece") || textboxModTwo.Text.Contains("Centerpiece") || textboxModThree.Text.Contains("Centerpiece") || textboxModFour.Text.Contains("Centerpiece") || textboxModFive.Text.Contains("Centerpiece"))
                {
                    return true;
                }
            }
            else if (input.Contains("Weather"))
            {
                if (textboxModOne.Text.Contains("Weather") || textboxModTwo.Text.Contains("Weather") || textboxModThree.Text.Contains("Weather") || textboxModFour.Text.Contains("Weather") || textboxModFive.Text.Contains("Weather"))
                {
                    return true;
                }
            }
            else if ((input == textboxModOne.Text) || (input == textboxModTwo.Text) || (input == textboxModThree.Text) || (input == textboxModFour.Text) || (input == textboxModFive.Text))
            {
                return true;
            }

            return false;
        }
        private string ChooseModifier()
        {
            string mod = "";
            bool duplicate = true;

            while (duplicate)
            {
                mod = RollTheme.RollForModifier();
                duplicate = CheckModLegal(mod);
            }

            return mod;
        }

        private void buttonRollAll_Click(object sender, RoutedEventArgs e)
        {
            textboxModOne.Text = "";
            textboxModTwo.Text = "";
            textboxModThree.Text = "";
            textboxModFour.Text = "";
            textboxModFive.Text = "";

            textboxGoalOne.Text = "";
            textboxGoalTwo.Text = "";
            textboxGoalThree.Text = "";

            textboxTheme.Text = RollTheme.RollForTheme();
            System.Threading.Thread.Sleep(1);
            textboxModOne.Text = ChooseModifier();
            System.Threading.Thread.Sleep(1);
            textboxModTwo.Text = ChooseModifier();
            System.Threading.Thread.Sleep(1);
            textboxModThree.Text = ChooseModifier();
            System.Threading.Thread.Sleep(1);
            textboxModFour.Text = ChooseModifier();
            System.Threading.Thread.Sleep(1);
            textboxModFive.Text = ChooseModifier();

            System.Threading.Thread.Sleep(1);
            textboxGoalOne.Text = RollTheme.RollforGoal();
            System.Threading.Thread.Sleep(1);
            textboxGoalTwo.Text = RollTheme.RollforGoal();
            System.Threading.Thread.Sleep(1);
            textboxGoalThree.Text = RollTheme.RollforGoal();
            System.Threading.Thread.Sleep(1);
            textboxGoaltime.Text = "Time to hold Goals: " + RollTheme.RollForGoaltime();

            System.Threading.Thread.Sleep(1);
            textboxMoney.Text = "Starting Money: " + RollTheme.RollForMoney();
            System.Threading.Thread.Sleep(1);
            textboxLoans.Text = RollTheme.RollForLoan();
            System.Threading.Thread.Sleep(1);
            textboxFees.Text = RollTheme.RollForFees();
            System.Threading.Thread.Sleep(1);
            textboxGoaltime.Text = "Time to hold Goals: " + RollTheme.RollForGoaltime();
            System.Threading.Thread.Sleep(1);
            textboxMapsize.Text = RollTheme.RollForMapsize();
        }

        private void buttonRollMods_Click(object sender, RoutedEventArgs e)
        {

            textboxModOne.Text = "";
            textboxModTwo.Text = "";
            textboxModThree.Text = "";
            textboxModFour.Text = "";
            textboxModFive.Text = "";

            textboxModOne.Text = ChooseModifier();
            System.Threading.Thread.Sleep(1);
            textboxModTwo.Text = ChooseModifier();
            System.Threading.Thread.Sleep(1);
            textboxModThree.Text = ChooseModifier();
            System.Threading.Thread.Sleep(1);
            textboxModFour.Text = ChooseModifier();
            System.Threading.Thread.Sleep(1);
            textboxModFive.Text = ChooseModifier();
        }

        private void buttonRollTheme_Click(object sender, RoutedEventArgs e)
        {
            textboxTheme.Text = RollTheme.RollForTheme();
        }

        private void buttonRollModOne_Click(object sender, RoutedEventArgs e)
        {
            textboxModOne.Text = "";
            textboxModOne.Text = ChooseModifier();
        }

        private void buttonRollModTwo_Click(object sender, RoutedEventArgs e)
        {
            textboxModTwo.Text = "";
            textboxModTwo.Text = ChooseModifier();
        }

        private void buttonRollModThree_Click(object sender, RoutedEventArgs e)
        {
            textboxModThree.Text = "";
            textboxModThree.Text = ChooseModifier();
        }

        private void buttonRollModFour_Click(object sender, RoutedEventArgs e)
        {
            textboxModFour.Text = "";
            textboxModFour.Text = ChooseModifier();
        }

        private void buttonRollModFive_Click(object sender, RoutedEventArgs e)
        {
            textboxModFive.Text = "";
            textboxModFive.Text = ChooseModifier();
        }

        private void buttonRollGoalOne_Click(object sender, RoutedEventArgs e)
        {
            textboxGoalOne.Text = "";
            textboxGoalOne.Text = RollTheme.RollforGoal();
        }

        private void buttonRollGoalTwo_Click(object sender, RoutedEventArgs e)
        {
            textboxGoalTwo.Text = "";
            textboxGoalTwo.Text = RollTheme.RollforGoal();
        }

        private void buttonRollGoalThree_Click(object sender, RoutedEventArgs e)
        {
            textboxGoalThree.Text = "";
            textboxGoalThree.Text = RollTheme.RollforGoal();
        }

        private void buttonRollGoals_Click(object sender, RoutedEventArgs e)
        {
            textboxGoalOne.Text = "";
            textboxGoalTwo.Text = "";
            textboxGoalThree.Text = "";

            textboxGoalOne.Text = RollTheme.RollforGoal();
            System.Threading.Thread.Sleep(1);
            textboxGoalTwo.Text = RollTheme.RollforGoal();
            System.Threading.Thread.Sleep(1);
            textboxGoalThree.Text = RollTheme.RollforGoal();
            System.Threading.Thread.Sleep(1);
            textboxGoaltime.Text = "Time to hold Goals: " + RollTheme.RollForGoaltime();
        }

        private void buttonRollMoney_Click(object sender, RoutedEventArgs e)
        {
            textboxMoney.Text = "Starting Money: "+RollTheme.RollForMoney();
        }

        private void buttonRollLoans_Click(object sender, RoutedEventArgs e)
        {
            textboxLoans.Text = RollTheme.RollForLoan();
        }

        private void buttonRollFees_Click(object sender, RoutedEventArgs e)
        {
            textboxFees.Text = RollTheme.RollForFees();
        }

        private void buttonRollGoaltime_Click(object sender, RoutedEventArgs e)
        {
            textboxGoaltime.Text = "Time to hold Goals: " + RollTheme.RollForGoaltime();
        }

        private void buttonRollMapsize_Click(object sender, RoutedEventArgs e)
        {
            textboxMapsize.Text = RollTheme.RollForMapsize();
        }

        private void buttonRollOptions_Click(object sender, RoutedEventArgs e)
        {
            textboxMoney.Text = "Starting Money: " + RollTheme.RollForMoney();
            System.Threading.Thread.Sleep(1);
            textboxLoans.Text = RollTheme.RollForLoan();
            System.Threading.Thread.Sleep(1);
            textboxFees.Text = RollTheme.RollForFees();
            System.Threading.Thread.Sleep(1);
            textboxGoaltime.Text = "Time to hold Goals: " + RollTheme.RollForGoaltime();
            System.Threading.Thread.Sleep(1);
            textboxMapsize.Text = RollTheme.RollForMapsize();
        }
    }
}
