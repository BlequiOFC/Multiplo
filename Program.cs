Console.Clear();
Console.WriteLine("--- Múltiplo ---\n");

Console.Write("Digite um número...........: ");
int nr1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Conferir se é múltiplo de..: ");
int nr2 = Convert.ToInt32(Console.ReadLine());

if (nr1 % nr2 == 0)

{
    Console.WriteLine($"\n{nr1} é múltiplo de {nr2}");
}
else
{
    Console.WriteLine($"\n{nr1} não é múltiplo de {nr2}");
}