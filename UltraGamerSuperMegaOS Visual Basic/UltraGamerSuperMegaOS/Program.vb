Imports System

Module UltraGamerOS
    Sub Main()
        Console.Title = "ULTRAGAMERSUPERMEGAOS"

        ' Estética inicial: Amarelo no Azul (Clássico erro de sistema)
        Console.BackgroundColor = ConsoleColor.Blue
        Console.ForegroundColor = ConsoleColor.Yellow
        Console.Clear()

        Console.WriteLine("====================================================")
        Console.WriteLine("   ULTRAGAMERSUPERMEGAOS                            ")
        Console.WriteLine("====================================================")
        Console.WriteLine("[!] STATUS: OVERCLOCK DO MOUSE EM 5000%")
        Console.WriteLine("[!] CARREGANDO SHADERS FEIOS... OK!")

        Dim comando As String = ""

        While True
            Console.ForegroundColor = ConsoleColor.Green
            Console.Write(vbCrLf & "UGSM-VB-SHELL> ")
            Console.ForegroundColor = ConsoleColor.White
            comando = Console.ReadLine().ToLower()

            Select Case comando
                Case "help"
                    Console.WriteLine("COMANDOS: 'nitro' (mais velocidade), 'pixel' (piora o grafico), 'exit'")
                Case "nitro"
                    Console.Beep(440, 200)
                    Console.Beep(880, 200)
                    Console.WriteLine(">>> NITRO ATIVADO! O COMPUTADOR ESTA QUASE PEGANDO FOGO!")
                Case "pixel"
                    Console.BackgroundColor = ConsoleColor.Red
                    Console.Clear()
                    Console.WriteLine("GRAFICOS REDUZIDOS PARA 1x1 PIXEL PARA MAXIMO FPS!!")
                Case "exit"
                    Exit While
                Case Else
                    Console.WriteLine("ERRO CRITICO: Comando '" & comando & "' exige 128GB de RAM.")
            End Select
        End While
    End Sub
End Module