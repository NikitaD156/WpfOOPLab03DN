using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using static System.Net.Mime.MediaTypeNames;

namespace WpfOOPLab03DN
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        
        public MainWindow()
        {
            InitializeComponent();
        }

        private void BtnInPut_Click(object sender, RoutedEventArgs e)
        {
            ClassInPut classInPut = new ClassInPut(TextBoxNote.Text,TextBoxDctrName.Text,TextBoxPtntName.Text, (DateTime)DatePickerNote.SelectedDate);
            MessageBox.Show(TextBoxNote.Text + " " + TextBoxDctrName.Text + " " + TextBoxPtntName.Text + " " + (DateTime)DatePickerNote.SelectedDate + " - Запись содана");
            TextBoxNote.Text = "";
            TextBoxDctrName.Text = "";
            TextBoxPtntName.Text = "";
            DatePickerNote.SelectedDate = null;
        }

        private void BtnOutPut_Click(object sender, RoutedEventArgs e)
        {
            OutPutTextBlock.Text = (string)ClassOutPut.OutPut();
        }

        private void BtnDelNote_Click(object sender, RoutedEventArgs e)
        {
            bool b = int.TryParse(DelChng_TextBox.Text, out int INote);
            ClassNoteRemove.NoteRemove(INote);
            MessageBox.Show("Запись успешно удалена");
        }

        private void BtnSortNotes_Click(object sender, RoutedEventArgs e)
        {
            ClassSortNote.SortNote();
        }
    }
}
