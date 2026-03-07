using System;

class Program
{
    class Jogo
    {
        public string titulo { get; set; } = "";
        public string plataforma { get; set; } = "";
        public int anoLancamento { get; set; }
        public bool emprestado { get; set; }

        public static void ExibirInformacoes(Jogo j)
        {
            Console.WriteLine($"Título: {j.titulo}");
            Console.WriteLine($"Plataforma: {j.plataforma}");
            Console.WriteLine($"Ano de Lançamento: {j.anoLancamento}");
            Console.WriteLine($"Emprestado: {(j.emprestado ? "Sim" : "Não")}");
        }

        public static void Emprestar(Jogo j)
        {
            if (!j.emprestado)
            {
                j.emprestado = true;
                Console.WriteLine($"O jogo '{j.titulo}' foi emprestado.");
            }
            else
            {
                Console.WriteLine($"O jogo '{j.titulo}' já está emprestado.");
            }
        }

        public static void Devolver(Jogo j)
        {
            if (j.emprestado)
            {
                j.emprestado = false;
                Console.WriteLine($"O jogo '{j.titulo}' foi devolvido.");
            }
            else
            {
                Console.WriteLine($"O jogo '{j.titulo}' não estava emprestado.");
            }
        }
    }

     class TesteJogo
    {
         static void Main(string[] args)
        {
            
            Console.WriteLine("Quantos jogos deseja cadastrar?");
            int quantidadeFilmes = int.Parse(Console.ReadLine());

            Jogo[] jogos = new Jogo[quantidadeFilmes];

            for (int i = 0; i < quantidadeFilmes; i++)
            {
                jogos[i] = new Jogo();

                Console.Write($"Digite o título do jogo {i + 1}: ");
                jogos[i].titulo = Console.ReadLine();

                Console.Write($"Digite a plataforma do jogo {i + 1}: ");
                jogos[i].plataforma = Console.ReadLine();

                Console.Write($"Digite o ano de lançamento do jogo {i + 1}: ");
                jogos[i].anoLancamento = int.Parse(Console.ReadLine());

                jogos[i].emprestado = false; // Inicialmente o jogo não está emprestado
            }

            Console.WriteLine("\nInformações dos jogos cadastrados:");
            for (int i = 0; i < quantidadeFilmes; i++)
            {
                Jogo.ExibirInformacoes(jogos[i]);
                Jogo.Emprestar(jogos[i]);
                Jogo.Devolver(jogos[i]);
                Console.WriteLine();
            }

        }
    }


}



