open System
open System.Threading

// Configurações de cores para a experiência estética traumática
let color (fg: ConsoleColor) (bg: ConsoleColor) =
    Console.ForegroundColor <- fg
    Console.BackgroundColor <- bg

let bootSequence () =
    Console.Clear()
    color ConsoleColor.White ConsoleColor.Red
    printfn " [!!!] ULTRAGAMERSUPERMEGAOS: F# FUNCTIONAL EDITION [!!!] "
    Thread.Sleep(1000)
    
    color ConsoleColor.Green ConsoleColor.Black
    let passos = [| "Verificando imutabilidade do RGB..."; "Mapeando FPS infinito..."; "Currying de memória RAM..." |]
    for passo in passos do
        printf " > %s " passo
        for _ in 1..5 do Thread.Sleep(100); printf "."
        printfn " OK!"

let mainLoop () =
    let mutable rodando = true
    while rodando do
        // Cores berrantes: Amarelo no Azul (estilo BIOS antiga)
        color ConsoleColor.Yellow ConsoleColor.Blue
        printf "\n[UGSM-FSHARP-CORE]> "
        
        let input = Console.ReadLine().ToLower().Trim()
        
        match input with
        | "help" ->
            color ConsoleColor.Cyan ConsoleColor.Black
            printfn "\n--- COMANDOS FUNCIONAIS ---"
            printfn " > overclock : Ativa o modo recursivo extremo"
            printfn " > status    : Verifica a saude do hardware"
            printfn " > glitch    : Gera um erro visual"
            printfn " > exit      : Aborta a execução"
            
        | "overclock" ->
            color ConsoleColor.Red ConsoleColor.Black
            printfn "EXECUTANDO RECURSÃO INFINITA PARA MAIS VELOCIDADE!"
            for i in 1..10 do
                printf "FPS: %d | " (i * 100000)
                Thread.Sleep(50)
            printfn "\nSISTEMA ESTÁVEL (PODE SAIR FUMAÇA)"

        | "status" ->
            color ConsoleColor.Magenta ConsoleColor.White
            printfn " [INFO] CPU: F# Quantum Processor "
            printfn " [INFO] RAM: Baixada via NuGet (Unlimited Edition) "

        | "glitch" ->
            let rnd = Random()
            for _ in 1..100 do
                Console.BackgroundColor <- enum<ConsoleColor>(rnd.Next(0, 16))
                printf "ERROR "
                Thread.Sleep(10)
            Console.ResetColor()
            Console.Clear()

        | "exit" ->
            printfn "Encerrando... A função 'Vida' retornou 0."
            rodando <- false

        | _ ->
            color ConsoleColor.White ConsoleColor.DarkRed
            printfn "ERRO: Comando não reconhecido pelo paradigma funcional."

[<EntryPoint>]
let main argv =
    bootSequence()
    mainLoop()
    0 // Retorno padrão