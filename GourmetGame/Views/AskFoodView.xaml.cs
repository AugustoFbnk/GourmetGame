using GourmetGame.Enums;
using GourmetGame.Logic;
using System.Windows;
namespace GourmetGame.Views
{
    /// <summary>
    /// Interaction logic for AskFoodView.xaml
    /// </summary>
    public partial class AskFoodView : Window
    {
        Branch Branch { get; set; }
        public AskFoodView()
        {
            InitializeComponent();
        }
        public AskFoodView(Branch branch) : this()
        {
            Branch = branch;
        }
        private void btOk_Click(object sender, RoutedEventArgs e)
        {
            new ReturnView(Branch, tbFood.Text).GetView(ViewEnum.CompleteMessagemView).ShowDialog();
            Close();
        }

        private void btCancel_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
