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
using System.Windows.Shapes;

namespace CustomDialogBox
{
	public partial class wndGetAverageDlg : Window
	{
		public Person Person { get; set; }
		public wndGetAverageDlg()
		{
			InitializeComponent();
			Person = new Person();
			gr.DataContext = Person;
		}
		private void btOK_Click(object sender, RoutedEventArgs e)
		{
			DialogResult = true;
		}
	}
}
