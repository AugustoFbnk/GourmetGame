using GourmetGame.Factory.View.Interface;
namespace GourmetGame.Factory.View.Concrete
{
    public class ReturnMainWindowView : IView
    {
        public System.Windows.Window ReturnView()
        {
            return new MainWindow();
        }
    }
}
