
class Leao : Mamifero
{
    public Leao(string nome, char sexo, DateTime dataDeNascimento)
    {
        QntDeMamas = 6;
        Pelos = true;
        CorDoPelo = "Amarelo";
        Carnivoro = true;
        Peconheto = false;
        Nome = nome;
        Sexo = sexo;
        DataDeNascimento = dataDeNascimento;
        Idade = (DateTime.Now - DataDeNascimento).Days / 365;
    }

    public override void Alimentar()
    {
        Console.WriteLine("Comendo carne...");
    }

    public override void Comunicar()
    {
        Console.WriteLine("Rugindo...");
    }

    public override void Movimentar()
    {
        Console.WriteLine("Andando...");
    }
}

class Chacal : Mamifero
{
    public Chacal(string nome, char sexo, DateTime dataDeNascimento)
    {
        QntDeMamas = 8;
        Pelos = true;
        CorDoPelo = "Cinza com amarelo";
        Carnivoro = true;
        Peconheto = false;
        Nome = nome;
        Sexo = sexo;
        DataDeNascimento = dataDeNascimento;
        Idade = (DateTime.Now - DataDeNascimento).Days / 365;
    }
    public override void Alimentar()
    {
        Console.WriteLine("Comendo carne...");
    }

    public override void Comunicar()
    {
        Console.WriteLine("Regougando...");
    }

    public override void Movimentar()
    {
        Console.WriteLine("Andando...");
    }
}

class Morcego : Mamifero, IVoar
{
    public int AltitudeMaximaEmMetros { get; set; }
    public double VelocidadeDeVoo { get; set; }

    public Morcego(string nome, char sexo, DateTime dataDeNascimento)
    {
        QntDeMamas = 2;
        Pelos = true;
        CorDoPelo = "Preto";
        Carnivoro = true;
        Peconheto = false;
        Nome = nome;
        Sexo = sexo;
        DataDeNascimento = dataDeNascimento;
        Idade = (DateTime.Now - DataDeNascimento).Days / 365;
    }

    public override void Alimentar()
    {
        Console.WriteLine("Comendo sangue...");
    }

    public override void Comunicar()
    {
        Console.WriteLine("...");
    }

    public override void Movimentar()
    {
        Console.WriteLine("Voando...");
    }

    public void Voar()
    {
        Movimentar();
    }
}

class Cisne : Ave, IOviparo, IVoar, IAquatico
{
    public int AltitudeMaximaEmMetros { get; set; }
    public double VelocidadeDeVoo { get; set; }
    public bool ViveEmTerra { get; set; }
    public bool Mergulho { get; set; }
    public bool AguaDoce { get; set; }

    public Cisne(string nome, char sexo, DateTime dataDeNascimento)
    {
        Nome = nome;
        Sexo = sexo;
        DataDeNascimento = dataDeNascimento;
        Idade = (DateTime.Now - DataDeNascimento).Days / 365;
        Carnivoro = false;
        Peconheto = false;
        Rapina = false;
        CorPena = "Branco";
        AltitudeMaximaEmMetros = 1;
        VelocidadeDeVoo = 20;
        ViveEmTerra = true;
        Mergulho = false;
        AguaDoce = true;
    }

    public override void Alimentar()
    {
        Console.WriteLine("Comendo plantas...");
    }

    public void Botar()
    {
        Console.WriteLine("Botando ovo...");
    }

    public void Chocar()
    {
        Console.WriteLine("Chocando ovo...");
    }

    public override void Comunicar()
    {
        Console.WriteLine();
    }

    public override void Movimentar()
    {
        Console.WriteLine("Nadando...");
    }

    public void Voar()
    {
        Console.WriteLine("Voando...");
    }
}

class Arara : Ave, IVoar
{
    public int AltitudeMaximaEmMetros { get; set; }
    public double VelocidadeDeVoo { get; set; }

    public Arara(string nome, char sexo, DateTime dataDeNascimento)
    {
        Nome = nome;
        Sexo = sexo;
        DataDeNascimento = dataDeNascimento;
        Idade = (DateTime.Now - DataDeNascimento).Days / 365;
        Carnivoro = false;
        Peconheto = false;
        Rapina = false;
        CorPena = "Vermelho";
        AltitudeMaximaEmMetros = 1;
        VelocidadeDeVoo = 20;
    }
    public override void Alimentar()
    {
        Console.WriteLine("Comendo frutas");
    }

    public override void Comunicar()
    {
        Console.WriteLine("Cantando...");
    }

    public override void Movimentar()
    {
        Console.WriteLine("Voando...");
    }

    public void Voar()
    {
        Movimentar();
    }
}

class DragaoDeComodo : Reptil, IOviparo
{
    public DragaoDeComodo(string nome, char sexo, DateTime dataDeNascimento)
    {
        Nome = nome;
        Sexo = sexo;
        DataDeNascimento = dataDeNascimento;
        Idade = (DateTime.Now - DataDeNascimento).Days / 365;
        Carnivoro = true;
        Peconheto = true;
        TemCasco = false;
        TemEscamas = true;
    }
    public override void Alimentar()
    {
        Console.WriteLine();
    }

    public void Botar()
    {
        Console.WriteLine("Botando ovo...");
    }

    public void Chocar()
    {
        Console.WriteLine("Chocando ovo...");
    }

    public override void Comunicar()
    {
        Console.WriteLine("Chiando...");
    }

    public override void Movimentar()
    {
        Console.WriteLine("Andando...");
    }
}

class Lontra : Mamifero, IAquatico
{
    public bool ViveEmTerra { get; set; }
    public bool Mergulho { get; set; }
    public bool AguaDoce { get; set; }

    public Lontra(string nome, char sexo, DateTime dataDeNascimento)
    {
        Nome = nome;
        Sexo = sexo;
        DataDeNascimento = dataDeNascimento;
        Idade = (DateTime.Now - DataDeNascimento).Days / 365;
        Carnivoro = true;
        Peconheto = false;
        ViveEmTerra = true;
        Mergulho = true;
        AguaDoce = true;
    }
    public override void Alimentar()
    {
        Console.WriteLine("Comendo peixe...");
    }

    public override void Comunicar()
    {
        Console.WriteLine();
    }

    public override void Movimentar()
    {
        Console.WriteLine("Nadando...");
    }
}

class Pinguim : Ave, IAquatico, IOviparo
{
    public bool ViveEmTerra { get; set; }
    public bool Mergulho { get; set; }
    public bool AguaDoce { get; set; }
    public Pinguim(string nome, char sexo, DateTime dataDeNascimento)
    {
        Nome = nome;
        Sexo = sexo;
        DataDeNascimento = dataDeNascimento;
        Idade = (DateTime.Now - DataDeNascimento).Days / 365;
        Carnivoro = true;
        Peconheto = false;
        Rapina = false;
        CorPena = "Preto e branco";
        ViveEmTerra = true;
        Mergulho = true;
        AguaDoce = false;
    }
    public override void Alimentar()
    {
        Console.WriteLine("Comendo peixe...");
    }

    public void Botar()
    {
        Console.WriteLine("Botando ovo...");
    }

    public void Chocar()
    {
        Console.WriteLine("Chocando ovo...");
    }

    public override void Comunicar()
    {
        Console.WriteLine();
    }

    public override void Movimentar()
    {
        Console.WriteLine("Nadando...");
    }
}

class Coruja : Ave, IOviparo, IVoar
{
    public int AltitudeMaximaEmMetros { get; set; }
    public double VelocidadeDeVoo { get; set; }
    public Coruja(string nome, char sexo, DateTime dataDeNascimento)
    {
        Nome = nome;
        Sexo = sexo;
        DataDeNascimento = dataDeNascimento;
        Idade = (DateTime.Now - DataDeNascimento).Days / 365;
        Carnivoro = true;
        Peconheto = false;
        Rapina = true;
        CorPena = "Cinza";
        AltitudeMaximaEmMetros = 1;
        VelocidadeDeVoo = 20;
    }
    public override void Alimentar()
    {
        Console.WriteLine();
    }

    public void Botar()
    {
        Console.WriteLine();
    }

    public void Chocar()
    {
        Console.WriteLine();
    }

    public override void Comunicar()
    {
        Console.WriteLine();
    }

    public override void Movimentar()
    {
        Console.WriteLine("Voando");
    }

    public void Voar()
    {
        Movimentar();
    }
}

class Elefante : Mamifero
{
    public Elefante(string nome, char sexo, DateTime dataDeNascimento)
    {
        Nome = nome;
        Sexo = sexo;
        DataDeNascimento = dataDeNascimento;
        Idade = (DateTime.Now - DataDeNascimento).Days / 365;
        Carnivoro = false;
        Peconheto = false;
        QntDeMamas = 2;
        Pelos = false;
        CorDoPelo = "Cinza";
    }
    public override void Alimentar()
    {
        Console.WriteLine();
    }

    public override void Comunicar()
    {
        Console.WriteLine();
    }

    public override void Movimentar()
    {
        Console.WriteLine("Andando");
    }
}

class Jacare : Reptil, IOviparo, IAquatico
{
    public bool ViveEmTerra { get; set; }
    public bool Mergulho { get; set; }
    public bool AguaDoce { get; set; }
    public Jacare(string nome, char sexo, DateTime dataDeNascimento)
    {
        Nome = nome;
        Sexo = sexo;
        DataDeNascimento = dataDeNascimento;
        Idade = (DateTime.Now - DataDeNascimento).Days / 365;
        Carnivoro = true;
        Peconheto = false;
        ViveEmTerra = false;
        Mergulho = true;
        AguaDoce = true;
        TemEscamas = true;
        TemCasco = false;
    }
    public override void Alimentar()
    {
        Console.WriteLine("Comendo peixe...");
    }

    public void Botar()
    {
        Console.WriteLine();
    }

    public void Chocar()
    {
        Console.WriteLine();
    }

    public override void Comunicar()
    {
        Console.WriteLine();
    }

    public override void Movimentar()
    {
        Console.WriteLine("Nadando...");
    }
}

abstract class Animal
{
    public string Nome { get; set; }
    public DateTime DataDeNascimento { get; set; }
    public char Sexo { get; set; }
    public int Idade { get; set; }
    public bool Carnivoro { get; set; }
    public bool Peconheto { get; set; }
    public abstract void Movimentar();
    public abstract void Comunicar();
    public abstract void Alimentar();
    
}

abstract class Mamifero : Animal
{
    public int QntDeMamas { get; set; }
    public bool Pelos { get; set; }
    public string CorDoPelo { get; set; }
    public void Amamentar()
    {
        Console.WriteLine("Amamentando...");
    }
}

abstract class Ave : Animal
{
    public bool Rapina { get; set; }
    public string CorPena { get; set; }
    public void Ciscar()
    {
        Console.WriteLine("Ciscando...");
    }
}

abstract class Reptil : Animal
{
    public bool TemEscamas { get; set; }
    public bool TemCasco { get; set; }
}

interface IOviparo
{
    void Botar();
    void Chocar();
}

interface IVoar
{
    public int AltitudeMaximaEmMetros { get; set; }
    public double VelocidadeDeVoo { get; set; }
    void Voar();
}

interface IAquatico
{
    public bool ViveEmTerra { get; set; }
    public bool Mergulho { get; set; }
    public bool AguaDoce { get; set; }
}