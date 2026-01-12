using System;
using System.Threading;

class UltraGamerOS
{
    static void Main()
    {
        Console.Title = "ULTRAGAMERSUPERMEGAOS v2.0 - TURBO EDITION";

        // Boot "Cinematográfico"
        Console.BackgroundColor = ConsoleColor.Blue;
        Console.ForegroundColor = ConsoleColor.White;
        Console.Clear();
        Console.WriteLine(">>> MONITORANDO TEMPERATURA DO PROCESSADOR: 120°C (OK!)");
        Console.WriteLine(">>> OVERCLOCK DE CADEIRA GAMER: ATIVADO");
        Thread.Sleep(1500);

        while (true)
        {
            // Efeito visual aleatório para irritar o usuário
            Console.BackgroundColor = (ConsoleColor)new Random().Next(1, 15);
            Console.ForegroundColor = ConsoleColor.Black;

            Console.Write("\n[UGSM-OS-PRO-GOLD]> ");
            string cmd = Console.ReadLine()?.ToLower();

            switch (cmd)
            {
                case "help":
                    Console.WriteLine("=== COMANDOS HIGH-END ===");
                    Console.WriteLine("stats - Mostra o poder do monstro");
                    Console.WriteLine("rgb   - Ativa o modo epilepsia");
                    Console.WriteLine("mine  - Minera 1 bilhão de Bitcoins");
                    Console.WriteLine("exit  - Desliga o sonho");
                    break;

                case "stats":
                    Console.WriteLine("GPU: NASA Quantum RTX 10090 (2.4 petabytes VRAM)");
                    Console.WriteLine("Internet: 500 Terabits/s (Via Satélite de Marte)");
                    break;

                case "rgb":
                    for (int i = 0; i < 20; i++)
                    {
                        Console.BackgroundColor = (ConsoleColor)(i % 15);
                        Console.Clear();
                        Console.WriteLine("!!! MODO RGB ATIVADO !!!");
                        Thread.Sleep(50);
                    }
                    break;

                case "mine":
                    Console.Write("Minerando.");
                    for (int i = 0; i < 5; i++) { Thread.Sleep(300); Console.Write("."); }
                    Console.WriteLine("\nSucesso! Você agora é dono da economia global.");
                    break;

                case "exit":
                    return;

                default:
                    Console.WriteLine("ERRO: Sua CPU é muito lenta para entender esse comando.");
                    break;
            }
        }
    }
}