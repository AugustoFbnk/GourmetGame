
using GourmetGame.Enums;
using GourmetGame.Factory.View.Interface;
using GourmetGame.Logic;
namespace GourmetGame.Factory.View.Concrete
{
    public class FactoryView 
    {
        private Branch branch;
        private string food;
        public FactoryView(Branch branch, string food = "")
        {
            this.branch = branch != null ? branch : new Branch();
            this.food = food;
        }
        public IView Return(ViewEnum viewType)
        {
            switch (viewType)
            {
                case ViewEnum.AskFoodView:
                    return new ReturnAskFoodView(branch);
                case ViewEnum.AskView:
                    return new ReturnAskView(branch);
                case ViewEnum.CompleteMessagemView:
                    return new ReturnCompleteMessageView(food, branch);
                case ViewEnum.SuccessView:
                    return new ReturnSuccessView();
            }
            return new ReturnMainWindowView();
        }
    }
}
