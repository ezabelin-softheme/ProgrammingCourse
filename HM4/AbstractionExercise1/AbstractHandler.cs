namespace AbstractionExercise1
{
    abstract class AbstractHandler
    {
        public abstract void Open();
        public abstract void Create();
        public abstract void Change();
        public abstract void Save();

        public void AllActionsChain()
        {
            Create();
            Open();
            Change();
            Save();
        }
    }
}
