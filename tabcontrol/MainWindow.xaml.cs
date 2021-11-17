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
using System;
using System.IO;
using System.Windows;
using Microsoft.Win32;

namespace WpfTutorialSamples.Dialogs
{
	public partial class OpenFileDialogSample : Window
	{
		public OpenFileDialogSample()
		{
			InitializeComponent();
		}

		private void btnOpenFile_Click(object sender, RoutedEventArgs e)
		{
			OpenFileDialog openFileDialog = new OpenFileDialog();
			openFileDialog.Filter = "Image files (*.png;*.jpeg; *jpg; *)|*.png;*.jpeg;*.jpg|All files (*.*)|*.*";
			if (openFileDialog.ShowDialog() == true)
			{
				TabItem ti = new TabItem();
				ti.Header = openFileDialog.FileName;
				Image img = new Image();
				img.Source = new BitmapImage(new Uri(openFileDialog.FileName));
				ti.Content = img;
				zakladki.Items.Add(ti);
				zakladki.SelectedItem = zakladki.Items[zakladki.Items.Count - 1];
			}
		}

        private void btnCloseFile_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}