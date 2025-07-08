using System.Security.Cryptography.X509Certificates;

namespace Atividades { 

    class Program {
        static void Main(string[] args) {

            //Dia1.ehImpar(28);
            //Dia2.Soma(10.5, 20.3);
            //Dia2.Subtracao(10.5, 20.3);
            //Dia2.Multiplicacao(10.5, 20.3);
            //Dia2.Divisao(10.5, 20.3);
            //Dia2.Modulo(10.5, 20.3);
            //Dia2.Exponenciacao(2, 20);
            //Dia2.RaizQuadrada(144);
            //Dia3.Tabuala();
            //Dia4.ContagemRegressiva(10);
            //Dia5.MediaNotas(7.5, 8.0, 9.0);
            //Dia6.AdvinheONumero();
            Dia7.CadastroDeUsuarios();
        }
         
    }

    public static class Dia1 {
        public static void ehImpar(int x) {
           if (x % 2 == 0) {
                Console.WriteLine($"O número {x} é par ");
            }
            else { 
                Console.WriteLine($"O número {x} é ímpar");
            }

        }
    }
    public static class Dia2 {
        public static void Soma(double x, double y) {
            double resultado = x + y;
            Console.WriteLine($"A soma de {x} + {y} é igual a {resultado}");
        }
        public static void Subtracao(double x, double y) {
            double resultado = x - y;
            Console.WriteLine($"A subtração de {x} - {y} é igual a {resultado}");

        }

        public static void Multiplicacao(double x, double y) {
            double resultado = x * y;
            Console.WriteLine($"A multiplicação de {x} * {y} é igual a {resultado}");
        }

        public static void Divisao(double x, double y) { 
            if (y == 0) {
                Console.WriteLine("Divisão por zero não é permitida.");
                return;
            }
            double resultado = x / y;
            Console.WriteLine($"A divisão de {x} / {y} é igual a {resultado}");
        }

        public static void Modulo(double x, double y) {
            if (y == 0) {
                Console.WriteLine("Divisão por zero não é permitida.");
                return;
            }
            double resultado = x % y;
            Console.WriteLine($"O módulo de {x} % {y} é igual a {resultado}");

        }

        public static void Exponenciacao(double x, double y) {
            double resultado = Math.Pow(x, y);
            Console.WriteLine($"A exponenciação de {x} ^ {y} é igual a {resultado}");
        }

        public static void RaizQuadrada(double x) {
            if (x < 0) {
                Console.WriteLine("Raiz quadrada de número negativo não é permitida.");
                return;
            }
            double resultado = Math.Sqrt(x);
            Console.WriteLine($"A raiz quadrada de {x} é igual a {resultado}");
        }
    }
    public static class Dia3 {
        public static void Tabuala() {

            Console.WriteLine("Digite um número para ver sua tabuada:");
            int numero = int.Parse(Console.ReadLine() ?? "0");

            for (int i=0; i<10;i++) {
                int resultado = numero * (i + 1);
                Console.WriteLine($"{numero} x {i + 1} = {resultado}");

            }
        }
    }
    public static class Dia4 {

        public static void ContagemRegressiva(int numero) {

            if (numero <= 0) {
                Console.WriteLine("Número negativo ou Zero não é permitido.");
                return;
            }

            Console.WriteLine("Contagem Regressiva:");
            for (int i = 0; i < numero; i++) { 
                Console.WriteLine(numero - i);
            }
        }
        

    }
    public static class Dia5 { 

        public static void MediaNotas(double nota1, double nota2, double nota3) {
            
            double[] notas = { nota1, nota2, nota3 };

            double soma = 0;
            for (int i = 0; i < notas.Length; i++) {       
                soma += notas[i];
            }
            Console.WriteLine($"A média das notas é: {soma / notas.Length}");
        }

    }

    public static class Dia6 {

        public static void AdvinheONumero() {

            Random random = new Random();

            int numeroSecreto = random.Next(1, 101);
            int tentativas = 0;
            int palpite = 0;
            bool acertou = false;
            Console.WriteLine("Bem-vindo ao jogo de adivinhação! Tente adivinhar o número entre 1 e 100.");
            while (!acertou) {
                Console.WriteLine("Digite seu Palpite");
                palpite = int.Parse(Console.ReadLine() ?? "0");
                tentativas++;
                if (palpite == numeroSecreto) {
                    acertou = true;
                    Console.WriteLine($"Parabéns! Você adivinhou o número {numeroSecreto} em {tentativas} tentativas.");
                } else if (palpite < numeroSecreto) {
                    Console.WriteLine("O número é maior. Tente novamente.");
                } else {
                    Console.WriteLine("O número é menor. Tente novamente.");
                }
            }
        }


    }

    public static class Dia7 {

        public static void CadastroDeUsuarios() {

            List<string> usuarios = new List<string>();
            string opcao = string.Empty;
            do {
                Console.WriteLine("Digite o nome do usuário para cadastrar (ou 'sair' para encerrar):");
                string usuario = Console.ReadLine() ?? string.Empty;
                if (usuario.ToLower() == "sair") {
                    break;
                }
                if (!usuarios.Contains(usuario)) {
                    usuarios.Add(usuario);
                    Console.WriteLine($"Usuário '{usuario}' cadastrado com sucesso!");
                } else {
                    Console.WriteLine($"Usuário '{usuario}' já está cadastrado.");
                }
                Console.WriteLine("Deseja cadastrar outro usuário? (s/n)");
                opcao = Console.ReadLine() ?? string.Empty;
            } while (opcao.ToLower() == "s");
            Console.WriteLine("Usuários cadastrados:");
            foreach (var u in usuarios) {
                Console.WriteLine(u);
            }






        }
    }



}