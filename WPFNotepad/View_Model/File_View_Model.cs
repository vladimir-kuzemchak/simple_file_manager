using Microsoft.Win32;
using System.IO;
using System.Text;
using System.Windows.Input;
using WPFNotepad.Models;
using System.Windows.Controls;
using System.Printing;
using System.Windows.Documents;
using System.Drawing.Printing;

namespace WPFNotepad.ViewModels
{

    public class FileViewModel
    {
        public DocumentModel Document { get; private set; }

    
        public ICommand NewCommand { get; }
        public ICommand SaveCommand { get; }
        public ICommand SaveAsCommand { get; }
        public ICommand OpenCommand { get; }

        public ICommand PrintCommand { get; }

        public FileViewModel(DocumentModel document)
        {
            Document = document;
            NewCommand = new Relay_Command(NewFile);
            SaveCommand = new Relay_Command(SaveFile, () => !Document.isEmpty);
            SaveAsCommand = new Relay_Command(SaveFileAs);
            OpenCommand = new Relay_Command(OpenFile);

            PrintCommand = new Relay_Command(PrintFile);

        }

        ////Рабоате ли оно вообще?
        private void PrintFile()
        {
            var printFileDialog = new PrintDialog();
            if (printFileDialog.ShowDialog() == true)
            {
                printFileDialog.CurrentPageEnabled = true;
                printFileDialog.ShowDialog();

            }
        }


        



        public void NewFile()
        {
            Document.FileName = string.Empty;
            Document.FilePath = string.Empty;
            Document.Text = string.Empty;
        }

        private void SaveFile() => File.WriteAllText(Document.FilePath, Document.Text);
        

        private void SaveFileAs()
        {
            var saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Text File (*.txt)|*.txt";
            if(saveFileDialog.ShowDialog() == true)
            {
                DockFile(saveFileDialog);
                File.WriteAllText(saveFileDialog.FileName, Document.Text);
            }
        }

        private void OpenFile()
        {
            var openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == true)
            {
                DockFile(openFileDialog);
                Document.Text = File.ReadAllText(openFileDialog.FileName,Encoding.Default);
            }
        }

        private void DockFile<T>(T dialog) where T : FileDialog
        {
            Document.FilePath = dialog.FileName;
            Document.FileName = dialog.SafeFileName;
        }
    }
}
