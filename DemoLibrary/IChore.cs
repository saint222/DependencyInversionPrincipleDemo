namespace DemoLibrary
{
    public interface IChore
    {
        string ChoreName { get; set; }
        IPerson Owner { get; set; }

        void CompletemChore();
        void PerformWork(double hours);
    }
}