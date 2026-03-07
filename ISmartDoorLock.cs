namespace SHDMS
{
    public interface ISmartDoorLock
    {
        string GetStatus();
        void ToggleLock();
    }
}