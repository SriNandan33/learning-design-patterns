namespace AdapterPatternDucksAndDrones.Interfaces
{
    public interface IDrone
    {
        void Display();
        void Beep();
        void SpinRotors();
        void TakeOff();
    }
}