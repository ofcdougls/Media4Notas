double nota1, nota2, nota3, nota4, media;
string resultado;

Console. WriteLine("-- Média de quatro notas --");

Console. Write("Digite a noata1...: ");
nota1 = Convert. ToDouble(Console.ReadLine());

Console. Write("Digite a nota2...: ");
nota2 = Convert. ToDouble(Console.ReadLine());

Console. Write("Digite a nota3...: ");
nota3 = Convert. ToDouble(Console.ReadLine());

Console. Write("Digite a nota4...: ");
nota4 = Convert. ToDouble(Console.ReadLine());

bool todasAsNotasSaoValidas = nota1 >= 0 && nota1 <= 10
                            && nota2 >= 0 && nota2 <= 10
                            && nota3 >= 0 && nota3 <= 10
                            && nota4 >= 0 && nota4 <= 10;

if (todasAsNotasSaoValidas)
{
    media = (nota1 + nota2 + nota3 + nota4) / 4 ;

    if (media < 5)
    {
        resultado = "Reprovado";
    }
    else if (media > 6)
    {
        resultado = "Aprovado";
    }
    else
    {
        resultado = "Em recuperação";
    }


    Console.WriteLine($"Você ficou com média {media:N1}. {resultado}");
}
else
{
    Console.WriteLine("Digite somente notas entre 0 e 10.");
}                      
