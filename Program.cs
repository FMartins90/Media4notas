﻿double nota1, nota2, nota3, nota4, media;
string resultado;

Console.WriteLine("-- Média de quatro notas --");

//informar a primeira nota do aluno
Console.Write("Digite a nota #1...: ");
nota1 = Convert.ToDouble(Console.ReadLine());

//informar a segunda nota do aluno
Console.Write("Digite a nota #2...: ");
nota2 = Convert.ToDouble(Console.ReadLine());

//informar a terceira nota do aluno
Console.Write("Digite a nota #3...: ");
nota3 = Convert.ToDouble(Console.ReadLine());

//informar a quarta nota do aluno
Console.Write("Digite a nota #4...: ");
nota4 = Convert.ToDouble(Console.ReadLine());

//informa que as notas não devem ser menores que zero ou maiores que 10 para serem validas
bool todasAsNotasSaoValidas =  nota1 >= 0 && nota1 <= 10
                            && nota2 >= 0 && nota2 <= 10
                            && nota3 >= 0 && nota3 <= 10
                            && nota4 >= 0 && nota4 <= 10;

if (todasAsNotasSaoValidas)
{
    media = (nota1 + nota2 + nota3 + nota4) / 4;
//calculo da média


//informa mensagem de aprovado, reprovado ou recuperação
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


    Console.WriteLine($"Você ficou com média {media:N1}. Resultado: {resultado}");
}
else
{
    Console.WriteLine("Digite somente notas entre 0 e 10.");
}