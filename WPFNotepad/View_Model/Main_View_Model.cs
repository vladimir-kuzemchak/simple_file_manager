using WPFNotepad.Models;

namespace WPFNotepad.ViewModels
{
    
    public class MainViewModel
    {
        
        private DocumentModel document;
        
        public EditorViewModel Editor { get; set; }

        public FileViewModel File { get; set; }
        
        public HelpViewModel Help { get; set; }

        public MainViewModel()
        {
            document = new DocumentModel();
            Help = new HelpViewModel();
            Editor = new EditorViewModel(document);
            File = new FileViewModel(document);
        }
    }
}
