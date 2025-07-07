namespace Atividades { 

    class Program {
        static void Main(string[] args) {
         
            Dia1.ehImpar(28);
            Dia2.Soma(10.5, 20.3);
            Dia2.Subtracao(10.5, 20.3);
            Dia2.Multiplicacao(10.5, 20.3);
            Dia2.Divisao(10.5, 20.3);
            Dia2.Modulo(10.5, 20.3);
            Dia2.Exponenciacao(2, 20);
            Dia2.RaizQuadrada(144);
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


}