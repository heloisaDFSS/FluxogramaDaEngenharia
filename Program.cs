Console.WriteLine("--- Fluxograma Da Engenharia ---\n");

Console.ForegroundColor = ConsoleColor.DarkMagenta;
Console.Write("O objeto está se movendo (S/N)? ");
Console.ResetColor();

bool estaSeMovendo = Console.ReadLine()!.Trim().Substring(0, 1).ToUpper() == "S";

Console.ForegroundColor = ConsoleColor.DarkMagenta;
Console.Write("Deveria? ");
Console.ResetColor();
bool deveria = Console.ReadLine()!.Trim().Substring(0, 1).ToUpper() == "S";


string mensagem;

Console.ForegroundColor = ConsoleColor.DarkGreen;
if (!estaSeMovendo)
{
    if (!deveria)
    
    {
        mensagem = "Ótimo!";
    }
    else
    {
        mensagem = "Use WD-40.";
    }
}
else
{
    if (deveria)
    {
        mensagem = "Ótimo!";
    }
    else
    {
        mensagem = "Use Silver Tape.";
    }
}

Console.WriteLine();
Console.WriteLine(mensagem);

Console.ResetColor();
