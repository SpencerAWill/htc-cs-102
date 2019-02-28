using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace MovieList
{
    public static class NotifyUser
    {
        public static void DisplayError(object src, string message)
        {
            string caption = "Error!";
            MessageBox.Show("Error at " + Convert.ToString(src) + ": " + "\n" + message, caption);
            
        }

        public static void RedoInput(TextBox src)
        {
            src.Clear();
            
        }

        public static void DisplayMessage(string message)
        {
            MessageBox.Show(message);
        }
    }
}
