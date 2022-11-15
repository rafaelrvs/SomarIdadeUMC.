/* O Programa deve ler  a idade de 10 pessoas e calcular e mostra o 
A) Percentual de pessoas com + de 20 anos conta20/10 *100
B) Quantidade de pessoas com idade inferior a 15 anos
C) Media de idade dessas pessoas */ 

double Cont20, Cont15, SomaI,  Media, idade,k;

    Cont20 = 0;
    Cont15 = 0;
    SomaI = 0;



for (k = 1; k <= 10;k = k + 1)
{
    Console.WriteLine("Digite sua Idade");
    idade = int.Parse(Console.ReadLine());

    while (idade < 8 || idade > 120)
    {


        Console.WriteLine("Erro tente novamentee");

        Console.WriteLine("Digite novamente a Idade");
        idade = int.Parse(Console.ReadLine());
    }
    if (idade > 20)
    {
        Cont20 = Cont20 + 1;
    }
    else
        if (idade < 15)
    {
        Cont15 = Cont15 + 1;
    }

    SomaI = SomaI + idade;
   
}

double perc = (Cont20 /10) * 100;
Media = SomaI / 10;
Console.WriteLine($"Percentual de pessoas com + de 20 anos:  {perc}" +"%");

Console.WriteLine($"Quantidade de pessoas com idade inferior a 15 anos: {Cont15},");
Console.WriteLine($"Media de idade dessas pessoas: {Media}");











