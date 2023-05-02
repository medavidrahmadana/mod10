namespace AljabarLibraries
{
    public class Aljabar
    {
        public static double[] AkarPersamaanKuadrat(double[] persamaan)
        {
            double a = persamaan[0];
            double b = persamaan[1];
            double c = persamaan[2];
            double d = b * b - 4 * a * c;
            if (d < 0)
            {
                return new double[] { double.NaN, double.NaN };
            }
            else
            {
                double x1 = (-b + Math.Sqrt(d)) / (2 * a);
                double x2 = (-b - Math.Sqrt(d)) / (2 * a);
                return new double[] { x1, x2 };
            }
        }
        public static double[] hasilKuadrat(double[] persamaan)
        {
            if (persamaan.Length != 2 || persamaan.Length == null)
            {
                throw new ArgumentException("Persamaan harus berisi dua angka.");
            }
            double a = persamaan[0];
            double b = persamaan[1];
            double rumus = a * a;
            double aSquare = 2 * a * b;
            double bSquare = b * b;

            return new double[] { rumus, aSquare, bSquare };
        }
    }
}