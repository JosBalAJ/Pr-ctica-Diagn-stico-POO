using System;

class Program
{
    static void Main(string[] args)
    {
        Mascota miMascota = new Mascota();
        miMascota.DescribirMascota();
    }
}

public class Mascota
{
    private string forma = "Redonda";
    private int numOjos = 2;
    private int numPatas = 0;

    public void DescribirMascota()
    {
        Console.WriteLine($"Tu mascota es {forma}, tiene {numOjos} ojos y también {numPatas} patas");
        ElegirComida();
    }

    public void ElegirComida()
    {
        bool incorrecto = true;
        while (incorrecto)
        {
            Console.WriteLine("Qué darás de comer a tu mascota?");
            Console.WriteLine("Helado - Chile - Lechuga");
            Console.Write("Escribe tu elección: ");
            string respuesta = Console.ReadLine();

            switch (respuesta)
            {
                case "Helado":
                    AlimentarHelado();
                    incorrecto = false;
                    break;
                case "Chile":
                    AlimentarChile();
                    incorrecto = false;
                    break;
                case "Lechuga":
                    AlimentarLechuga();
                    incorrecto = false;
                    break;
                default:
                    Console.WriteLine("La palabra es incorrecta, prueba de nuevo");
                    incorrecto = true;
                    break;
            }
        }
    }

    private void AlimentarHelado()
    {
        Console.WriteLine("Alimentando a tu mascota con Helado...");
        Barghest miBarghest = new Barghest("Azul", "Barghest");
        miBarghest.DescribirBarghest();
    }
    private void AlimentarChile()
    {
        Console.WriteLine("Alimentando a tu mascota con Chile...");
        Dragon miDragon = new Dragon("Escamas rojas", "Dragon");
        miDragon.DescribirDragon();
    }
    private void AlimentarLechuga()
    {
        Console.WriteLine("Alimentando a tu mascota con Lechuga...");
        DescribirMascota();
    }
}

public class Barghest : Mascota
{
    private string colPelaje;
    private string nombre;

    public Barghest(string colPelaje, string nombre)
    {
        this.colPelaje = colPelaje;
        this.nombre = nombre;
    }

    public void DescribirBarghest(){
        Console.WriteLine($"Ahora tu mascota se llama {nombre} y tiene pelaje de color {colPelaje}");
        Console.WriteLine("****************");
        Console.WriteLine("Deseas volver a alimentar a tu Barghest? S/N");
        string respuesta = Console.ReadLine();
        if (respuesta == "S" || respuesta == "s" || respuesta == "Si"){
            Mascota bMascota = new Mascota();
            bMascota.ElegirComida();
        }else{
            Console.WriteLine("Tu Barghest se despide de tí...");
        }
    }

}

public class Dragon : Mascota{
    private string escamas;
    private string nombre;

    public Dragon(string escamas, string nombre){
        this.escamas = escamas;
        this.nombre = nombre;
    }

    public void DescribirDragon(){
        Console.WriteLine($"Ahora tu mascota se llama {nombre} y tiene {escamas}");
        Console.WriteLine("****************");
        Console.WriteLine("Deseas volver a alimentar a tu Dragón? S/N");
        string respuesta = Console.ReadLine();
        if (respuesta == "S" || respuesta == "s" || respuesta == "Si"){
            Mascota dMascota = new Mascota();
            dMascota.ElegirComida();
        }else{
            Console.WriteLine("Tu Dragón se despide de tí...");
        }
    }
}