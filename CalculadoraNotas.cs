

public class CalculadoraNotas
{
    public Resultado CalcularNotas(NotasAluno notas)
    {
        Resultado res = new Resultado();
        res.Media = CalcularMedia(notas);
        res.Situacao = VerificarSituacao(res.Media);

        return res;
    }


    private double CalcularMedia(NotasAluno notas)
    {
        double media = (notas.Nota1 + notas.Nota2 + notas.Nota3) / 3;
        return media;
    }

    private string VerificarSituacao(double media)
    {
        string sit = "";
        if (media >= 6)
        {
            sit = "Aprovado";
        }
        else 
        {
            sit = "DP";
        }
        return sit;
    }

}