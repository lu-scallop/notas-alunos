namespace estudo;
class Program
{
    static void Main(string[] args)
    {
        NotasAluno notas = new NotasAluno();

        Console.WriteLine("Informe a nota 1:");
        notas.Nota1 = double.Parse(Console.ReadLine());

        Console.WriteLine("Informe a nota 2:");
        notas.Nota2 = double.Parse(Console.ReadLine());

        Console.WriteLine("Informe a nota 3:");
        notas.Nota3 = double.Parse(Console.ReadLine());


        CalculadoraNotas calculadora = new CalculadoraNotas();
        Resultado res = calculadora.CalcularNotas(notas);

        Console.WriteLine("A média é " + res.Media);
        Console.WriteLine("Situação: " + res.Situacao);
    }


}
