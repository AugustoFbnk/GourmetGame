namespace GourmetGame.Logic
{
    public class Branch
    {
        public Branch RightBranch { get; set; }
        public Branch LeftBranch { get; set; }
        public string Food { get; set; }
        public string Ask { get; set; }

        public void AddRightBranch(string ask, string food)
        {
            RightBranch = new Branch() { Ask = string.Format(ask, food), Food = food };
        }
        public void AddLeftBranch(string ask, string food)
        {
            LeftBranch = new Branch() { Ask = string.Format(ask, food), Food = food };
        }
    }
}
