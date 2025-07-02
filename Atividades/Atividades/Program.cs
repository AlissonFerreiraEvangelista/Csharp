namespace Atividades { 

    class Program {
        static void Main(string[] args) {
            // Exemplo de uso do método Somar
            int resultado = Somar(5, 10);
            Console.WriteLine($"A soma de 5 e 10 é: {resultado}");
        }
        // Método que recebe dois inteiros e retorna a soma deles
        static int Somar(int a, int b) {
            return a + b;
        }
    }

}