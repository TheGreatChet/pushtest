using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Input;

namespace NamordnikApp.Classes
{
    public static class ConstraintsClass
    {
        public static void OnlyNums(TextCompositionEventArgs e)
        {
            if(!Regex.IsMatch(e.Text, @"[0-9]")) 
                e.Handled = true;
        }

        public static void ExceptSpace(KeyEventArgs e)
        {
            if (e.Key == Key.Space) 
                e.Handled = true;
        }
    }
}
