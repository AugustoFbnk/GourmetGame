using GourmetGame.Logic;
using System.Windows;
namespace GourmetGame.Views
{
    /// <summary>
    /// Interaction logic for AskView.xaml
    /// </summary>
    public partial class AskView : Window
    {
        public Branch Branch { get; set; }
        public AskView()
        {
            InitializeComponent();
        }
        public AskView(Branch branch) : this()
        {
            Branch = branch;
			lbAsk.Content = branch.Ask;
        }

        private void btSim_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = true;
            Close();
        }

        private void btNao_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
