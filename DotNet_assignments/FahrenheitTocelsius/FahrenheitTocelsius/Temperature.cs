namespace FahrenheitTocelsius
{
    public class Temperature
    {
        public double CTF(double temp)
        {
           double F =   (9/5*temp)+32;
            return F;
        }

        public double FTC(double temp)
        {
            double C = (temp - 32) * 5 / 9;
            return C;
        }
    }
}
