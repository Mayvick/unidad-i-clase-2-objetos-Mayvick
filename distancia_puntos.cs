using System;

class Punto
{
    public decimal x { get; set; }
    public decimal y { get; set; }
    public decimal z { get; set; }

    public Punto(decimal x, decimal y)
    {
        this.x = x;
        this.y = y;
    }

    public Punto(decimal x, decimal y, decimal z)
    {
        this.x = x;
        this.y = y;
        this.z = z;
    }

    public double MedirDistancia(Punto destino)
    {
        if (destino.z == 0 && this.z == 0)
        {
            // Distancia en un plano bidimensional
            return Math.Sqrt(Math.Pow((double)(destino.x - this.x), 2) + Math.Pow((double)(destino.y - this.y), 2));
        }
        else
        {
            // Distancia en tres dimensiones
            return Math.Sqrt(Math.Pow((double)(destino.x - this.x), 2) + Math.Pow((double)(destino.y - this.y), 2) + Math.Pow((double)(destino.z - this.z), 2));
        }
    }
}

class Program
{
    static void Main()
    {
        Punto puntoOrigen2D = new Punto(0, 0);
        Punto puntoDestino2D = new Punto(3, 4);
        double distancia2D = puntoOrigen2D.MedirDistancia(puntoDestino2D);

        Console.WriteLine("La distancia en 2D es: " + distancia2D);

        Punto puntoOrigen3D = new Punto(0, 0, 0);
        Punto puntoDestino3D = new Punto(3, 4, 5);
        double distancia3D = puntoOrigen3D.MedirDistancia(puntoDestino3D);

        Console.WriteLine("La distancia en 3D es: " + distancia3D);
    }
}
