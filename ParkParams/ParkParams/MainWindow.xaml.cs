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

        private void buttonRollAll_Click(object sender, RoutedEventArgs e)
        {
            textboxTheme.Text = RollTheme.RollForTheme();
            System.Threading.Thread.Sleep(1);
            textboxModOne.Text = RollTheme.RollForModifier();
            System.Threading.Thread.Sleep(1);
            textboxModTwo.Text = RollTheme.RollForModifier();
            System.Threading.Thread.Sleep(1);
            textboxModThree.Text = RollTheme.RollForModifier();
        }

        private void buttonRollMods_Click(object sender, RoutedEventArgs e)
        {
            textboxModOne.Text = RollTheme.RollForModifier();
            System.Threading.Thread.Sleep(1);
            textboxModTwo.Text = RollTheme.RollForModifier();
            System.Threading.Thread.Sleep(1);
            textboxModThree.Text = RollTheme.RollForModifier();
        }

        private void buttonRollModOne_Click(object sender, RoutedEventArgs e)
        {
            textboxModOne.Text = RollTheme.RollForModifier();
        }

        private void buttonRollModTwo_Click(object sender, RoutedEventArgs e)
        {
            textboxModTwo.Text = RollTheme.RollForModifier();
        }

        private void buttonRollModThree_Click(object sender, RoutedEventArgs e)
        {
            textboxModThree.Text = RollTheme.RollForModifier();
        }
    }
}
