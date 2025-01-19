namespace CalculadoraMVC.Models
{
    public class ConversionModel
    {
        public static double LbToKg(double lb)
        {
            return lb * 0.453592;
        }

        public static double KgToLb(double kg)
        {
            return kg * 2.20462;
        }
    }
}
