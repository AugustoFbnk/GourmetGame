using GourmetGame.Enums;

namespace GourmetGame.Logic
{
    public class ValidationNodes
    {
        public void Validation(Branch branch)
        {
            var returnView = new ReturnView(branch);
            if (!LastBranch(branch))
                if (returnView.GetView(ViewEnum.AskView).ShowDialog() == true) { HitMessageProcess(returnView, branch); }
                else { MissedMessageProcess(returnView, branch); }
        }
        private void HitMessageProcess(ReturnView returnView, Branch branch)
        {
            if (LastBranch(branch.LeftBranch)) { returnView.GetView(ViewEnum.SuccessView).ShowDialog(); }
            else { Validation(branch.LeftBranch); }
        }
        private void MissedMessageProcess(ReturnView returnView, Branch branch)
        {
            if (LastBranch(branch.RightBranch)) { returnView.GetView(ViewEnum.AskFoodView).ShowDialog(); }
            else { Validation(branch.RightBranch); }
        }
        private bool LastBranch(Branch branch)
        {
            return branch == null;
        }
    }
}
