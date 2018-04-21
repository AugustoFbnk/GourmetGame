using GourmetGame.Factory.View.Interface;
using GourmetGame.Logic;
using GourmetGame.Views;
namespace GourmetGame.Factory.View.Concrete
{
    public class ReturnAskFoodView : IView
    {
        private Branch branch;
        public ReturnAskFoodView(Branch branch)
        {
            this.branch = branch;
        }
        public System.Windows.Window ReturnView()
        {
            return new AskFoodView(branch);
        }
    }
}
