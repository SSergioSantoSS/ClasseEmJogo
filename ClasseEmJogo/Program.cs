using System;

class Heroi
{
    public string Nome { get; set; }
    public int Idade { get; set; }
    public string Tipo { get; set; }

    public void Atacar()
    {
        string ataque = "";

        switch (Tipo.ToLower())
        {
            case "mago":
                ataque = "usou magia";
                break;
            case "guerreiro":
                ataque = "usou espada";
                break;
            case "monge":
                ataque = "usou artes marciais";
                break;
            case "ninja":
                ataque = "usou shuriken";
                break;
            default:
                ataque = "não tem ataque definido";
                break;
        }

        Console.WriteLine($"O {Tipo} atacou usando {ataque}");
    }
}

class Program
{
    static void Main()
    {
        Console.Write("Digite o nome do herói: ");
        string nome = Console.ReadLine();

        Console.Write("Digite a idade do herói: ");
        int idade = int.Parse(Console.ReadLine());

        Console.Write("Digite o tipo do herói (mago, guerreiro, monge ou ninja): ");
        string tipo = Console.ReadLine();

        Heroi meuHeroi = new Heroi
        {
            Nome = nome,
            Idade = idade,
            Tipo = tipo
        };

        meuHeroi.Atacar();
    }
}