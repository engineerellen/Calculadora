using System.Reflection.Metadata.Ecma335;

namespace Domain
{
    public class Calculadora
    {
        public double Numero1 { get; set; }
        public double Numero2 { get; set; }

        public Calculadora(double _numero1, double _numero2)
        {
            Numero1 = _numero1;
            Numero2 = _numero2;
        }

        public double Somar() => Numero1 + Numero2;

        public double Subtrair() => Numero1 - Numero2;

        public double Multiplicar() => Numero1 * Numero2;

        public double Dividir()
        {
            if (Numero2 == 0)
                throw new DivideByZeroException();

            return Numero1 / Numero2;
        }
    }
}
