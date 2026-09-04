Console.WriteLine(" ## Instrução While ##\n");

int numero;
int contador = 1;

Console.WriteLine("\nDigite um número maior que zero:\t ");
numero = Convert.ToInt32(Console.ReadLine());

if (numero > 0)
{
    Console.WriteLine($"\n## Tabuada do {numero} ##");
    while(contador < 11)
    {
        Console.WriteLine($"{numero} x {contador} = {numero * contador}");
        contador++;
    }

}
else
{
    Console.WriteLine("Número deve ser maior que zero!");
}
Console.WriteLine("\nFim do Processamento..");
Console.ReadKey();
