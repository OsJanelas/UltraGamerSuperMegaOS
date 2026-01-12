#include <iostream>
#include <string>
#include <thread>
#include <chrono>

void color(std::string code) { std::cout << "\033[" << code << "m"; }

int main() {
    color("1;37;41"); // Branco com fundo Vermelho (horroroso)
    std::cout << "  INICIALIZANDO ULTRAGAMERSUPERMEGAOS)  " << std::endl;
    std::this_thread::sleep_for(std::chrono::seconds(1));

    std::string cmd;
    while (true) {
        color("1;33;44"); // Amarelo com fundo Azul
        std::cout << "\n[UGSM-OS-CPP]> ";
        std::cin >> cmd;

        if (cmd == "game") std::cout << "VUCE ACAOU DE NENCER)";
        if (cmd == "mem") std::cout << "MEMORIA ATUAL: 999999999999 (Overclock Ativo!)";
        if (cmd == "fps") std::cout << "FPS ATUAL: 9999999 (Overclock Ativo!)";
        else if (cmd == "exit") break;
        else std::cout << "COMANDO DESCONHECIDO PELO CORE I999";
    }
    return 0;
}