namespace Imc.Models
{
    public class IMCService
    {
        public double IMCResult { get; private set; }

        public void SetIMC(double imc)
        {
            IMCResult = imc;
        }
    }
}
