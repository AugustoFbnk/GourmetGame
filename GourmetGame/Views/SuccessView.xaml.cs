using System.Windows;
namespace GourmetGame.Views
{
    /// <summary>
    /// Interaction logic for SuccessView.xaml
    /// </summary>
    public partial class SuccessView : Window
    {
        public SuccessView()
        {
            InitializeComponent();
        }
        private void btOk_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
