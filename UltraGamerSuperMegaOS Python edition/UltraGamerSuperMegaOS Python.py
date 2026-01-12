import os
import platform
import time

def clear():
    os.system('cls' if os.name == 'nt' else 'clear')

def boot_sequence():
    clear()
    # Cores berrantes: \033[1;32;40m (Verde neon no fundo preto)
    print("\033[1;32;40m [!] INICIALIZANDO ULTRAGAMERSUPERMEGAOS v0.0.1-ALPHA [!]")
    time.sleep(1)
    print(" [>] CARREGANDO DRIVERS DE RGB... OK!")
    time.sleep(0.5)
    print(" [>] OTIMIZANDO FPS PARA 999999... OK!")
    time.sleep(0.5)
    print(" [>] INSTALANDO MAIS MEMÓRIA RAM VIA DOWNLOAD... OK!")
    time.sleep(1)
    clear()

def main():
    boot_sequence()
    
    # Estética "feia" com cores neon e fundo azul (estilo tela da morte)
    # \033[1;33;44m = Amarelo brilhante com fundo azul
    print("\033[1;33;44m") 
    print("="*60)
    print("   ULTRA GAMER SUPER MEGA OS - O MELHOR DO MUNDO   ")
    print("="*60)
    print(" Digite 'help' para ver os comandos ou 'exit' para sair. ")

    while True:
        cmd = input("\n[UGSM-OS]> ").lower().strip()

        if cmd == "help":
            print("\n--- COMANDOS DISPONÍVEIS ---")
            print(" > info:  Mostra o hardware (fake)")
            print(" > hack:  Ativa o modo hacker profissional")
            print(" > game:  Roda o melhor jogo do sistema")
            print(" > clear: Limpa essa bagunça")
            print(" > exit:  Desliga (se você for fraco)")

        elif cmd == "info":
            print(f"\n[SISTEMA] Rodando em: {platform.system()} {platform.release()}")
            print("[GPU] NVIDIA RTX 9090 Ti Super Mega Ultra (Simulada)")
            print("[CPU] Intel Core i99 de 500 núcleos")

        elif cmd == "hack":
            print("\033[0;32m") # Verde Matrix
            for i in range(20):
                print("10101010101101011110101010101010101010101010101010")
                time.sleep(0.05)
            print("SISTEMA DA NASA INVADIDO COM SUCESSO!")
            print("\033[1;33;44m") # Volta pro azul feio

        elif cmd == "game":
            print("\nINICIANDO JOGO DE ALTA PERFORMANCE...")
            time.sleep(1)
            print("Pense em um número. Você ganhou! (O OS é tão rápido que já processou sua vitória)")

        elif cmd == "clear":
            clear()
            print("="*60)
            print("   ULTRA GAMER SUPER MEGA OS - O MELHOR DO MUNDO   ")
            print("="*60)

        elif cmd == "exit":
            print("Desligando... O RGB vai fazer falta.")
            break

        else:
            print(f"ERRO CRÍTICO: O comando '{cmd}' é muito básico para este OS.")

if __name__ == "__main__":
    main()