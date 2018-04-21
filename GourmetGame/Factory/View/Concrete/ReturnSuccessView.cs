using GourmetGame.Factory.View.Interface;
using GourmetGame.Views;
namespace GourmetGame.Factory.View.Concrete
{
    public class ReturnSuccessView : IView
    {
        public System.Windows.Window ReturnView()
        {
            return new SuccessView();
        }
    }
}
