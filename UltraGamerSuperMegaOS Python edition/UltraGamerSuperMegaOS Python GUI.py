import tkinter as tk
from tkinter import messagebox
import random
import time

class UltraGamerOS:
    def __init__(self, root):
        self.root = root
        self.root.title("!!! ULTRAGAMERSUPERMEGAOS GOLD EDITION v4.0 !!!")
        self.root.geometry("600x500")
        
        # Cores que causam dor
        self.bg_color = "#ff00ff" # Magenta berrante
        self.fg_color = "#00ff00" # Verde limão
        self.btn_color = "#ffff00" # Amarelo
        
        self.root.configure(bg=self.bg_color)

        # Título piscante (simulado)
        self.title_label = tk.Label(root, text="=== ULTRA GAMER OS ===", 
                                    font=("Comic Sans MS", 30, "bold"),
                                    bg="red", fg="yellow", bd=10, relief="raised")
        self.title_label.pack(fill="x", pady=10)

        # Terminal interno feio
        self.terminal = tk.Text(root, height=10, bg="black", fg="#00ff00", 
                                font=("Fixedsys", 12), bd=5, relief="sunken")
        self.terminal.pack(padx=20, pady=10, fill="both")
        self.terminal.insert("1.0", "> SISTEMA INICIALIZADO COM 999% DE RGB...\n")
        self.terminal.config(state="disabled")

        # Painel de Botões Inúteis
        btn_frame = tk.Frame(root, bg=self.bg_color)
        btn_frame.pack(pady=10)

        self.create_btn(btn_frame, "BAIXAR RAM", self.baixar_ram)
        self.create_btn(btn_frame, "MODO HACKER", self.modo_hacker)
        self.create_btn(btn_frame, "FPS TURBO", self.fps_turbo)
        self.create_btn(btn_frame, "SAIR", root.quit)

        # Rodapé de erro
        self.status = tk.Label(root, text="STATUS: SUPER QUENTE (150°C)", 
                               bg="yellow", fg="red", font=("Arial", 10, "bold"))
        self.status.pack(side="bottom", fill="x")

        self.picar_titulo()

    def create_btn(self, parent, text, cmd):
        btn = tk.Button(parent, text=text, command=cmd, bg=self.btn_color, 
                        fg="blue", font=("Impact", 14), bd=5, relief="raised",
                        activebackground="orange")
        btn.pack(side="left", padx=5)

    def log(self, text):
        self.terminal.config(state="normal")
        self.terminal.insert("end", f"> {text}\n")
        self.terminal.see("end")
        self.terminal.config(state="disabled")

    def picar_titulo(self):
        current_bg = self.title_label.cget("bg")
        new_bg = "red" if current_bg == "yellow" else "yellow"
        new_fg = "yellow" if current_bg == "yellow" else "red"
        self.title_label.config(bg=new_bg, fg=new_fg)
        self.root.after(500, self.picar_titulo)

    def baixar_ram(self):
        self.log("Conectando ao servidor de RAM da NASA...")
        messagebox.showwarning("SUCESSO", "Você acabou de baixar 256GB de RAM via Wi-Fi!")
        self.log("RAM TOTAL: 256.008 GB")

    def modo_hacker(self):
        self.log("Iniciando Matrix...")
        for i in range(5):
            self.log(f"INVADINDO: {random.randint(100, 999)}.{random.randint(10, 88)}.1.1")
        self.root.configure(bg="black")
        messagebox.showerror("HACKER", "O PENTÁGONO FOI AVISADO!")
        self.root.configure(bg=self.bg_color)

    def fps_turbo(self):
        self.log("OVERCLOCK ATIVADO!")
        for i in range(10):
            self.status.config(text=f"FPS: {random.randint(9999, 999999)}")
            self.root.update()
            time.sleep(0.05)

if __name__ == "__main__":
    root = tk.Tk()
    app = UltraGamerOS(root)
    root.mainloop()