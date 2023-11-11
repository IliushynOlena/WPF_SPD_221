using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Markup;

namespace _12_FileManager
{
    public class ViewModel :INotifyPropertyChanged
    {
        private ObservableCollection<FileInfo> files = new ObservableCollection<FileInfo>();

        public event PropertyChangedEventHandler? PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string? propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public ViewModel()
        {
            LoadFiles(Environment.GetFolderPath(Environment.SpecialFolder.Desktop));
        }
        public void LoadFiles(string dirPath)
        {
            DirectoryPath = dirPath;
            DirectoryInfo directory = new DirectoryInfo(dirPath);
            var data = directory.GetFiles();
            files.Clear();
            foreach (var item in data)
            {
                files.Add(item);
            }
            //MessageBox.Show(DirectoryName);
        }

        public IEnumerable<FileInfo> Files => files;
        private string directoryPath;
        public string DirectoryPath
        {
            get { return directoryPath; }
            set { 
                directoryPath = value;
                OnPropertyChanged();
                OnPropertyChanged(nameof(DirectoryName));
            }
        }

        public string DirectoryFullName => Path.GetFullPath(DirectoryPath);
        public string DirectoryName => Path.GetFileName(DirectoryPath);
        //public FileInfo SelectedFile { get; set; }
        private FileInfo selectedFile;

        public FileInfo SelectedFile
        {
            get { return selectedFile; }
            set { 
                selectedFile = value;
                OnPropertyChanged();
            }
        }


    }
}
