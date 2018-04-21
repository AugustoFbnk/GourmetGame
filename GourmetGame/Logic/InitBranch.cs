using GourmetGame.Message;

namespace GourmetGame.Logic
{
    public class InitBranch
    {
        public Branch InstanceInitialBranch()
        {
            var messages = new Messages();
            var ask = string.Format(messages.DefaultMessage, messages.Massa);
            var RootBranch = new Branch{Ask = ask };
            RootBranch.AddRightBranch(messages.DefaultMessage, messages.BoloDeChocolate);
            RootBranch.AddLeftBranch(messages.DefaultMessage, messages.Lasanha);

            return RootBranch;
        }
    }
}
