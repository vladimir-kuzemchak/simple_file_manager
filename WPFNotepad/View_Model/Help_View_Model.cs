using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace WPFNotepad.ViewModels
{
    
    public class HelpViewModel : Observable_Object
    {
        public ICommand HelpCommand { get; }

        public HelpViewModel() => HelpCommand = new Relay_Command(DisplayAbout);
        

        private void DisplayAbout()
        {
            var helpDialog = new HelpDialog();
            helpDialog.ShowDialog();
        }
    }
}
