namespace NullObjectDesignPatternExample.Handcuffs
{
    public class GSDoubleLockHandcuffs : IHandcuffs
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