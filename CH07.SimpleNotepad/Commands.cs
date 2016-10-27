using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Input;

namespace CH07.SimpleNotepad
{
    static class Commands
    {
        static readonly RoutedUICommand _zoomNormalCommand =
            new RoutedUICommand("Zoom Normal", "Normal", typeof(Commands), 
                new InputGestureCollection(new[] {new KeyGesture(Key.N, ModifierKeys.Alt)}));
    }
}
