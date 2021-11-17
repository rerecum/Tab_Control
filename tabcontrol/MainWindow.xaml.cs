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
				picturebox1.Source = new BitmapImage(new Uri(openFileDialog.FileName));
				//txtEditor.Text = File.ReadAllText(openFileDialog.FileName);
		}
	}
}