namespace DiabetesGestacional;
class Program
{
    static void Main(string[] args)
    {
        double Glicemia;

        Console.Clear();

        Console.Write("Glicemia (em mg/dL)...: ");
        Glicemia = Convert.ToDouble(Console.ReadLine());

        if (Glicemia < 92)
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("Reavaliar entre 24 e 28 semanas com TTOG 75g de glicose...");
            Console.ResetColor();
        }

        else if (Glicemia > 92 && Glicemia < 126)
        {
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("Compatível com Diabetes Gestacional");
            Console.ResetColor();
        }

        else
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("Diabetes Mellitus na Gravidez");
            Console.ResetColor();
        }
    }
}
