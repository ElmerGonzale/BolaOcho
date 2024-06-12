Console.WriteLine("¿Que desea preguntarle a la gran bola 8 de la sabiduría");
Console.ReadLine();
Console.WriteLine("La gran bola 8 de la sabiduría ha respondido: ");
int respuesta;
Random aleatorio = new Random();
respuesta = aleatorio.Next(1, 21);
switch (respuesta)
{
    case 1:
        Console.WriteLine("Es cierto");
        break;
    case 2:
        Console.WriteLine("Es decididamente así");
        break;
    case 3:
        Console.WriteLine("Sin lugar a dudas ");
        break;
    case 4:
        Console.WriteLine("Si, definitivamente");
        break;
    case 5:
        Console.WriteLine("Puedes confiar en ello");
        break;
    case 6:
        Console.WriteLine("Como yo lo veo, si");
        break;
    case 7:
        Console.WriteLine("Lo más probable");
        break;
    case 8:
        Console.WriteLine("Perspectiva buena");
        break;
    case 9:
        Console.WriteLine("Si");
        break;
    case 10:
        Console.WriteLine("Las señales apuntan a que si");
        break;
    case 11:
        Console.WriteLine("Vuelve a preguntar mas tarde");
        break;
    case 12:
        Console.WriteLine("Mejor no decirte ahora");
        break;
    case 13:
        Console.WriteLine("No se puede predecir ahora");
        break;
    case 14:
        Console.WriteLine("Concentrate y vuelve a preguntar");
        break;
    case 15:
        Console.WriteLine("Respuesta confusa, vuelve a intentarlo");
        break;
    case 16:
        Console.WriteLine("No cuentes con ello");
        break;
    case 17:
        Console.WriteLine("Mi respuesta es no");
        break;
    case 18:
        Console.WriteLine("Mis fuentes dicen que no");
        break;
    case 19:
        Console.WriteLine("Las perspectivas no son buenas");
        break;
    case 20:
        Console.WriteLine("Muy dudoso");
        break;
}
