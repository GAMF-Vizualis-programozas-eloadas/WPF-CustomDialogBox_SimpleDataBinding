using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CustomDialogBox
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		public MainWindow()
		{
			InitializeComponent();
		}

		private void miExit_Click(object sender, RoutedEventArgs e)
		{
			Application.Current.Shutdown();
		}

		private void miNew_Click(object sender, RoutedEventArgs e)
		{
			var wnd = new wndGetAverageDlg
			{
				Owner = this,
				Person =
				{
					Name = "Valaki Eduárd",
					Average = 2
				}
			};
			var res = wnd.ShowDialog();
			if (res == true)
			{
				tbMain.Text = wnd.Person.Name + "\r\n" +
					wnd.Person.Average;
			}

		}
	}
}