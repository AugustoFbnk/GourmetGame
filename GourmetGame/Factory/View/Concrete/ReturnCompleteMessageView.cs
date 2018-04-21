using GourmetGame.Factory.View.Interface;
using GourmetGame.Logic;
using GourmetGame.Views;
namespace GourmetGame.Factory.View.Concrete
{
    public class ReturnCompleteMessageView : IView
    {
        private Branch branch;
        private string food;
        public ReturnCompleteMessageView(string food, Branch branch)
        {
            this.food = food;
            this.branch = branch;
        }
        public System.Windows.Window ReturnView()
        {
            return new CompleteMessageView(branch, food);
        }
    }
}
