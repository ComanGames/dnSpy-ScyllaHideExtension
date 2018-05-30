using System.Windows;
using System.Windows.Controls;

namespace WpfLogicAndUi
{
	/// <summary>
	/// Interaction logic for SettingsPageLayout.xaml
	/// </summary>
	public partial class SettingsPageLayout : UserControl
	{
		private SettingsPageControl _pageControl;
		public SettingsPageLayout()
		{
			_pageControl = new SettingsPageControl();
			DataContext = _pageControl;
			InitializeComponent();
		}

		private void Button_Click(object sender, RoutedEventArgs e)
		{
			_pageControl.Button_Click(sender, e);
		}
	}
}
