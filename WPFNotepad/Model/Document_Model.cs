using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFNotepad.Models
{
   
    public class DocumentModel : Observable_Object
    {
        private string text;
        public string Text
        {
            get => text; 
            set
            {
                OnPropertyChanged(ref text, value);
            }
        }

        private string file_Path;
        public string FilePath
        {
            get => file_Path; 
            set
            {
                OnPropertyChanged(ref file_Path, value);
            }
        }

        private string file_Name;
        public string FileName
        {
            get => file_Name; 
            set
            {
                OnPropertyChanged(ref file_Name, value);
            }
        }

        public bool isEmpty
        {
            get
            {
                if (string.IsNullOrEmpty(FileName) || string.IsNullOrEmpty(FilePath))
                    return true;

                return false;
            }
        }
    }
}
