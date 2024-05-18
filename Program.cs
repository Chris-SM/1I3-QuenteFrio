
using System.Security.Cryptography;
Console.Clear();
int RoboEscolho = RandomNumberGenerator.GetInt32(1,101);
int UsuarioEscolheu;
bool Acertou = false;

Console.ForegroundColor = ConsoleColor.DarkRed;
Console.BackgroundColor = ConsoleColor.Gray;
Console.Write("----- Estou pensando num numero -----");
Console.ResetColor();
Console.Write("\n\n\n");
while(!Acertou)
{
    UsuarioEscolheu = Convert.ToInt32(Console.ReadLine());
    if(UsuarioEscolheu == RoboEscolho)
    {
        Acertou = true;
    }
    else if(UsuarioEscolheu < RoboEscolho+3 && UsuarioEscolheu > RoboEscolho-3)
    {
        Console.WriteLine("Está pelando");
    }
    else if(UsuarioEscolheu < RoboEscolho+10 && UsuarioEscolheu > RoboEscolho-10 )
    {
        Console.WriteLine("Está quente");
    }
    else if(UsuarioEscolheu < RoboEscolho+30 && UsuarioEscolheu > RoboEscolho-30 )
    {
        Console.WriteLine("Está congelando");
    }
    else
    {
        Console.WriteLine("Está frio");
    }
    Console.Write("");
}
Console.BackgroundColor = ConsoleColor.White;
Console.ForegroundColor = ConsoleColor.DarkCyan;
Console.Write("----- Você ganhou. Parabéns -----");
Console.ResetColor();