int dia = 0;
Console.Write("Numero de dia: ");
dia = int.Parse(Console.ReadLine());
switch(dia)
{
    case 1: dia = 1;
            Console.WriteLine("El dia es Lunes");
        break;
    case 2: dia = 2;
        Console.WriteLine("El dia es Martes");
        break;
    case 3: dia = 3;
        Console.WriteLine("El dia es Miercoles");
        break;
    case 4: dia = 4;
        Console.WriteLine("El dia es Jueves");
        break;
    case 5: dia = 5;
        Console.WriteLine("El dia es Viernes");
        break;
    case 6: dia = 6;
        Console.WriteLine("El dia es Sabado");
        break;
    case 7: dia = 7;
        Console.WriteLine("El dia es Domingo");
        break;
    default:
        Console.WriteLine("Numero invalido");
        break;
}