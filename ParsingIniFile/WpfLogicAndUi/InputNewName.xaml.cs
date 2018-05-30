using System.Windows;

namespace WpfLogicAndUi
{
    /// <summary>
    /// Interaction logic for InputNewName.xaml
    /// </summary>
    public partial class InputNewName : Window
    {
        public InputNewName()
        {
            InitializeComponent();
        }

		public string ResponseText
		{
			get { return ResponseTextBox.Text; }
			set { ResponseTextBox.Text = value; }
		}

		private void OKButton_Click(object sender, System.Windows.RoutedEventArgs e)
		{
			if (string.IsNullOrEmpty(ResponseText))
			{
				MessageBox.Show("Please input some name");
				return;
			}
			DialogResult = true;
		}
	}
}
