using System;

class Guerrero
{
    public int Vida { get; set; }
    public int NivelAtaque { get; set; }
    public string Nombre { get; set; }

    public Guerrero(int vida, int nivelAtaque, string nombre)
    {
        Vida = vida;
        NivelAtaque = nivelAtaque;
        Nombre = nombre;
    }

    public int Ataque()
    {
        return NivelAtaque;
    }

    public void RecibeAtaque(int ataque)
    {
        Vida -= ataque;
    }
}

class Enfrentamiento
{
    public void Iniciar(Guerrero guerrero1, Guerrero guerrero2)
    {
        Console.WriteLine("Comienza el enfrentamiento entre " + guerrero1.Nombre + " y " + guerrero2.Nombre);

        while (guerrero1.Vida > 0 && guerrero2.Vida > 0)
        {
            int ataqueGuerrero1 = guerrero1.Ataque();
            int ataqueGuerrero2 = guerrero2.Ataque();

            guerrero2.RecibeAtaque(ataqueGuerrero1);
            guerrero1.RecibeAtaque(ataqueGuerrero2);

            Console.WriteLine(guerrero1.Nombre + " ataca a " + guerrero2.Nombre + " con " + ataqueGuerrero1 + " de daño.");
            Console.WriteLine(guerrero2.Nombre + " ataca a " + guerrero1.Nombre + " con " + ataqueGuerrero2 + " de daño.");
            Console.WriteLine(guerrero1.Nombre + " tiene " + guerrero1.Vida + " de vida restante.");
            Console.WriteLine(guerrero2.Nombre + " tiene " + guerrero2.Vida + " de vida restante.");
        }

        if (guerrero1.Vida <= 0)
        {
            Console.WriteLine(guerrero2.Nombre + " es el ganador!");
        }
        else
        {
            Console.WriteLine(guerrero1.Nombre + " es el ganador!");
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        Guerrero guerrero1 = new Guerrero(100, 20, "Guerrero 1");
        Guerrero guerrero2 = new Guerrero(120, 18, "Guerrero 2");

        Enfrentamiento enfrentamiento = new Enfrentamiento();
        enfrentamiento.Iniciar(guerrero1, guerrero2);
    }
}
