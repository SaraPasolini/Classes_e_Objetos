using System;

class Program
{
    class Carro
    {
        public string marca { get; set; } = "";
        public string modelo { get; set; } = "";
        public string cor { get; set; } = "";
        public int anoFabricacao { get; set; }

        public static void ExibirInformacoes(Carro veiculo)
        {
            Console.WriteLine($"Marca: {veiculo.marca}");
            Console.WriteLine($"Modelo: {veiculo.modelo}");
            Console.WriteLine($"Cor: {veiculo.cor}");
            Console.WriteLine($"Ano de Fabricação: {veiculo.anoFabricacao}");
        }

        public static void Buzinar()
        {
            Console.WriteLine("Beep Beep!");
        }
    }

    public static void Main(string[] args)
    {
        // Instancia de objetos da classe Carro
        Carro carro1 = new Carro();
        Carro carro2 = new Carro();
        Carro carro3 = new Carro();

        // Definindo atributos para o carro1
        carro1.marca = "Ford";
        carro1.modelo = "Mustang";
        carro1.cor = "Vermelho";
        carro1.anoFabricacao = 1967;

        // Definindo atributos para o carro2
        carro2.marca = "Chevrolet";
        carro2.modelo = "Camaro";
        carro2.cor = "Amarelo";
        carro2.anoFabricacao = 1969;

        // Definindo atributos para o carro3
        carro3.marca = "Dodge";
        carro3.modelo = "Charger";
        carro3.cor = "Preto";
        carro3.anoFabricacao = 1970;

        Carro.ExibirInformacoes(carro1);
        Carro.ExibirInformacoes(carro2);
        Carro.ExibirInformacoes(carro3);
        Carro.Buzinar();

    }
}
