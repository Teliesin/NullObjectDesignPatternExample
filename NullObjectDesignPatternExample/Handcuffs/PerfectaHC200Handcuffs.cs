namespace NullObjectDesignPatternExample.Handcuffs
{
    public class PerfectaHC200Handcuffs : IHandcuffs
    {
        private bool IsLocked { get; set; }

        public void Lock()
        {
            IsLocked = true;
        }

        public void Unlock()
        {
            IsLocked = false;
        }
    }
}