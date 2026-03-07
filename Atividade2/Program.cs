using System;

class Program
{
    class Filme
    {
        public string titulo { get; set; } = "";
        public string diretor { get; set; } = "";
        public int anoLancamento { get; set; }
        public bool emprestado { get; set; }

        public static void ExibirInformacoes(Filme f)
        {
            Console.WriteLine($"Título: {f.titulo}");
            Console.WriteLine($"Diretor: {f.diretor}");
            Console.WriteLine($"Ano de Lançamento: {f.anoLancamento}");
            Console.WriteLine($"Emprestado: {(f.emprestado ? "Sim" : "Não")}");
        }

        public static void Emprestar(Filme f)
        {
            if (!f.emprestado)
            {
                f.emprestado = true;
                Console.WriteLine($"O filme '{f.titulo}' foi emprestado.");
            }
            else
            {
                Console.WriteLine($"O filme '{f.titulo}' já está emprestado.");
            }
        }

        public static void Devolver(Filme f)
        {
            if (f.emprestado)
            {
                f.emprestado = false;
                Console.WriteLine($"O filme '{f.titulo}' foi devolvido.");
            }
            else
            {
                Console.WriteLine($"O filme '{f.titulo}' não estava emprestado.");
            }
        }
    }

    class TesteFilme
    {
         static void Main(string[] args)
        {
            
            Console.WriteLine("Quantos filmes deseja cadastrar?");
            int quantidadeFilmes = int.Parse(Console.ReadLine());

            Filme[] filmes = new Filme[quantidadeFilmes];

            for (int i = 0; i < quantidadeFilmes; i++)
            {
                filmes[i] = new Filme();

                Console.Write($"Digite o título do filme {i + 1}: ");
                filmes[i].titulo = Console.ReadLine();

                Console.Write($"Digite o diretor do filme {i + 1}: ");
                filmes[i].diretor = Console.ReadLine();

                Console.Write($"Digite o ano de lançamento do filme {i + 1}: ");
                filmes[i].anoLancamento = int.Parse(Console.ReadLine());

                filmes[i].emprestado = false; // Inicialmente o filme não está emprestado
            }

            Console.WriteLine("\nInformações dos filmes cadastrados:");
            for (int i = 0; i < quantidadeFilmes; i++)
            {
                Filme.ExibirInformacoes(filmes[i]);
                Filme.Emprestar(filmes[i]);
                Filme.Devolver(filmes[i]);
                Console.WriteLine();
            }

        }
    }

}
