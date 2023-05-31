using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace WpfApp1
{
    class MyCommands
    {
        public static RoutedUICommand Exit {  get;  set; }
        static MyCommands()
        {
            InputGestureCollection input=new InputGestureCollection();
            input.Add(new KeyGesture(Key.T, ModifierKeys.Control, "Ctrl+T"));
            Exit =new RoutedUICommand("Выход","Exit",typeof(MyCommands), input);
        }
    }

}
