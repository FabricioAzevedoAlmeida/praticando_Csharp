//* Exercício 1 — Calculando uma compra

// Console.Write("Digite o nome do produto: ");
// string? produto = Console.ReadLine();

// Console.Write("Digite a quantidade comprada: ");
// int quant =  int.Parse(Console.ReadLine());

// Console.Write("Digite preço unitário: ");
// decimal valor = decimal.Parse(Console.ReadLine());

// decimal valorTotal = quant * valor;

// Console.WriteLine($"Produto: {produto}");
// Console.WriteLine($"Quantidade comprada: {quant}");
// Console.WriteLine($"Preço unitário: {valor}");
// Console.WriteLine($"Valor tota: {valorTotal}");

//* Exercício 2 — Classificação de notas

// Console.Write("Digite o nome do aluno: ");
// string? aluno = Console.ReadLine();

// Console.Write("Digite a nota do aluno: ");
// int nota =  int.Parse(Console.ReadLine());

// if(nota < 0 || nota > 10)
// {
//     Console.WriteLine("Nota inválida");
// }

// if(nota >= 7 && nota <= 10)
// {
//     Console.WriteLine("Aprovado");
// }

// if(nota >= 5 && nota < 7)
// {
//     Console.WriteLine("Recuperação");
// }

// if(nota < 5 && nota >= 0)
// {
//     Console.WriteLine("Reprovado");
// }

//*Exercício 3 — Adivinhe o número
//  int NumeroSecreto = 35;

//   Console.Write("Digite um numero: ");
//   int tentativa =  int.Parse(Console.ReadLine());
//   int TotalTentativa = 0;

//  while (tentativa != NumeroSecreto)
// {

//     Console.Write("Digite outro número: ");
//     tentativa = int.Parse(Console.ReadLine());
//     TotalTentativa++;

//     if(tentativa < NumeroSecreto)
//     {
//          Console.WriteLine("O numero secreto é maior");
//     }
//     else if(tentativa > NumeroSecreto)
//     {
//          Console.WriteLine("O numero secreto é menor");
//     }

// }
//  Console.WriteLine("O numero secreto é maior");
//  Console.WriteLine($"o seu total de tentativa foi: {TotalTentativa}");

//*Exercício 4 — Calculadora com métodos

// class Program
// {
//     static double Somar(double num1, double num2)
//     {
//         return num1 + num2;
//     }

//     static double Multiplicar(double num1, double num2)
//     {
//         return num1 * num2;
//     }

//     static void Main()
//     {
//         Console.Write("Digite o primeiro número: ");
//         double n1 = Convert.ToDouble(Console.ReadLine());

//         Console.Write("Digite o segundo número: ");
//         double n2 = Convert.ToDouble(Console.ReadLine());

//         double resultadoSoma = Somar(n1, n2);
//         double resultadoMultiplicacao = Multiplicar(n1, n2);

//         Console.WriteLine($"Resultado da Soma: {resultadoSoma}");
//         Console.WriteLine($"Resultado da Multiplicação: {resultadoMultiplicacao}");
//     }
// }

//*Exercício 5 — Cadastro de notas em um array

// class Program
// {
//     static void Main()
//     {

//         double[] notas = new double[3];

//         Console.WriteLine("--- Cadastro de Notas ---");
//         for (int i = 0; i < notas.Length; i++)
//         {
//             Console.Write($"Digite a {i + 1}ª nota: ");
//             notas[i] = Convert.ToDouble(Console.ReadLine());
//         }

//         Console.WriteLine("\n--- Exibindo as Notas ---");
//         for (int i = 0; i < notas.Length; i++)
//         {
//             Console.WriteLine($"Nota {i + 1}: {notas[i]}");
//         }

//         double soma = 0;
//         foreach (double nota in notas)
//         {
//             soma += nota;
//         }
//         double media = soma / notas.Length;

//         Console.WriteLine("\n--- Resultado Final ---");
//         Console.WriteLine($"Média das notas: {media:F2}");
//     }
// }
