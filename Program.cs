//Nivel 1: Variáveis e Operações Básicas
#region 1. Calculadora de Média Simples
//Console.Write("Digite a primeira nota:");
//Decimal nota1 = Decimal.Parse(Console.ReadLine());
//Console.Write("Digite a segunda nota: ");
//Decimal nota2 = Decimal.Parse(Console.ReadLine());
//Console.Write("Digite a terceira nota:");
//Decimal nota3 = Decimal.Parse(Console.ReadLine());

//Decimal media = (nota1 + nota2 + nota3) / 3;

//Console.WriteLine(media);


#endregion
#region 2. Conversor de idade

//Console.Write("Digite a sua idade: ");
//int idade = int.Parse(Console.ReadLine());

//int idadeEmDias = idade * 365;
//Console.WriteLine("Sua idade em dias é: " + idadeEmDias);

#endregion
#region 3. Troca de Vetores

//int a = 10;
//Console.WriteLine("Valor de a antes da troca: " + a);
//int b = 20;
//Console.WriteLine("Valor de b antes da troca: " + b);
//int temp = a;
//a = b;
//Console.WriteLine("Valor de a depois da troca: " + a);
//b = temp;
//Console.WriteLine("Valor de b depois da troca: " + b);

#endregion

//Nivel 2: Estruturas Condicionais(if, else if, else)
#region Verificador de Maioridade

//Console.WriteLine("Digite sua idade: ");
//int idade = int.Parse(Console.ReadLine());

//if (idade >= 18)
//{
//    Console.WriteLine("Você é maior de idade.");
//}
//else
//{
//    Console.WriteLine("Você é menor de idade.");
//}

#endregion

#region Classificador de Números
Console.Write("Digite um número inteiro: ");
int numero = int.Parse(Console.ReadLine());

if (numero % 2 == 0 && numero > 0) 
{
    Console.WriteLine("O numero " + numero + " é pár e positivo");
} else if (numero % 2 == 1 && numero > 0)
{
    Console.WriteLine("O numero " + numero + " é impar e positivo");
}
else if (numero < 0)
{
     Console.WriteLine(numero + " é negativo");
}
else
{
     Console.WriteLine("É zero");
}

#endregion

#region
#endregion