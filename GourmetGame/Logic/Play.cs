namespace GourmetGame.Logic
{
    public class Play
    {
        public Branch RootBranch { get; set; }
        private ValidationNodes Validate;
		public Play(Branch rootBranch)
		{
            Validate = new ValidationNodes();
            RootBranch = rootBranch;
		}
		public void Run()
		{
            Validate.Validation(RootBranch);
		}
    }
}
