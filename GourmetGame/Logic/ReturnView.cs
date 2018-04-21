using GourmetGame.Enums;
using GourmetGame.Factory.View.Concrete;
using System.Windows;
namespace GourmetGame.Logic
{
    public class ReturnView
    {
        public Branch Branch { get; set; }
        public string Food { get; set; }

        private FactoryView factoryView;
        public ReturnView(Branch branch)
        {
            this.Branch = branch;
            factoryView = new FactoryView(branch);

        }
        public ReturnView(Branch branch, string food)
        {
            Branch = branch;
            Food = food;
            factoryView = new FactoryView(branch, food);
        }

        public Window GetView(ViewEnum view)
        {
            var returnView = factoryView.Return(view);
            return returnView.ReturnView();
        }
    }
}
