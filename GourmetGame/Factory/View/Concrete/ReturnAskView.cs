using GourmetGame.Factory.View.Interface;
using GourmetGame.Logic;
using GourmetGame.Views;
namespace GourmetGame.Factory.View.Concrete
{
    public class ReturnAskView : IView
    {
        private Branch branch { get; set; }
        public ReturnAskView(Branch branch)
        {
            this.branch = branch;
        }
        public System.Windows.Window ReturnView()
        {
            return new AskView(branch);
        }
    }
}
