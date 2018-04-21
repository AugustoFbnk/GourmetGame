using GourmetGame.Logic;
using GourmetGame.Message;
using System.Windows;
namespace GourmetGame
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        private Play play;
        private Messages messages;
        public MainWindow()
        {
            InitializeComponent();
            var initBranch = new InitBranch();
            play = new Play(initBranch.InstanceInitialBranch());
        }
        private void btOk_Click(object sender, RoutedEventArgs e)
        {
            play.Run();
        }
    }
}
