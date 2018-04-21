using GourmetGame.Logic;
using GourmetGame.Message;
using System.Windows;
namespace GourmetGame.Views
{
    /// <summary>
    /// Interaction logic for CompleteMessageView.xaml
    /// </summary>
    public partial class CompleteMessageView : Window
    {
        public string Food;
        public Branch Branch { get; set; }
        private Messages messages;
        public CompleteMessageView()
        {
            InitializeComponent();
            messages = new Messages();
        }
        
        public CompleteMessageView(Branch branch, string food) : this()
        {
            messages = new Messages();
            lbComplete.Content = string.Format(messages.CompleteMessage, food, branch.Food);
            Branch = branch;
            Food = food;
        }
        private void btOk_Click(object sender, RoutedEventArgs e)
        {
            Branch.Ask = string.Format(messages.Ask, tbComida.Text);
            Branch.AddRightBranch(messages.Ask, Branch.Food);
            Branch.AddLeftBranch(messages.Ask, Food);
            Close();
        }

        private void btCancel_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
