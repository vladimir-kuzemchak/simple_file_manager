using System.Windows;
using System.Windows.Media;

namespace WPFNotepad.Models
{
    
    public class FormatModel : Observable_Object
    {
        private FontStyle style;
        public FontStyle Style
        {
            get => style; 
            set
            {
                OnPropertyChanged(ref style, value);
            }
        }

        private FontWeight weight;
        public FontWeight Weight
        {
            get => weight; 
            set
            {
                OnPropertyChanged(ref weight, value);
            }
        }

        private FontFamily family;
        public FontFamily Family
        {
            get => family; 
            set
            {
                OnPropertyChanged(ref family, value);
            }
        }

        private TextWrapping wrap;
        public TextWrapping Wrap
        {
            get => wrap; 
            set
            {
                OnPropertyChanged(ref wrap, value);
                isWrapped = value == TextWrapping.Wrap ? true : false;
            }
        }

        private bool is_Wrapped;
        public bool isWrapped
        {
            get => is_Wrapped; 
            set
            {
                OnPropertyChanged(ref is_Wrapped, value);
            }
        }

        private double size;
        public double Size
        {
            get => size; 
            set
            {
                OnPropertyChanged(ref size, value);
            }
        }
    }
}
