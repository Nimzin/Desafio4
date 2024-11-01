public class Program
{
    public static void Main()
    {
        double sp = 67836.43;
        double rj = 36678.66;
        double mg = 29229.88;
        double es = 27165.48;
        double outros = 9849.53;

        
        double somaTotal = sp + rj+ mg + es + outros;                                      //soma de todos os estados.
        Console.WriteLine($"Soma total de todos os estados: R$ {somaTotal:F2}");

        double percentualSp = (sp / somaTotal) * 100;                                       //calculo de porcentagem para o estado de sp.
        Console.WriteLine($"O percentual de SP do total é de: R$ {percentualSp:F2}%");
        
        double percentualRj = (rj / somaTotal) * 100;                                       //calculo de porcentagem para o estado do rj.
        Console.WriteLine($"O percentual de RJ do total é de: R$ {percentualRj:F2}%");

        double percentualMg = (mg / somaTotal) * 100;                                       //calculo de porcentagem para o estado de mg.
        Console.WriteLine($"O percentual de RJ do total é de: R$ {percentualMg:F2}%");

        double percentualEs = (es / somaTotal) * 100;                                       //calculo de porcentagem para o estado de es.
        Console.WriteLine($"O percentual de RJ do total é de: R$ {percentualEs:F2}%");
        
        double percentualOutros = (outros / somaTotal) * 100;                               //calculo de porcentagem para os outros estados.
        Console.WriteLine($"O percentual de RJ do total é de: R$ {percentualOutros:F2}%");

       // Console.WriteLine($"{percentualOutros+percentualEs+percentualMg+percentualSp+percentualRj}%");


    }
}