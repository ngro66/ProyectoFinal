
int num1 = 0, num2 = 0, num3 = 0, sumt = 0, prom = 0, x = 0;
string respuesta = "Si";
do
{
    Console.WriteLine("Escriba el primer numero");
 num1=int.Parse(Console.ReadLine());
 Console.WriteLine("Escriba el segundo numero");
 num2 = int.Parse(Console.ReadLine());
 Console.WriteLine("Escriba el tercer numero");
 num3 = int.Parse(Console.ReadLine());

    if (num1 > num2 && num1 > num3)
    {
        Console.WriteLine("El  numero mayor es: " + num1);
        sumt = num1 + num2 + num3;
        prom = sumt / 3;
        Console.WriteLine("La suma total es: " + sumt);
        Console.WriteLine("El promedio es: " + prom);
    }
    else if (num2 > num1 && num2 > num3)
    {
        Console.WriteLine("El numero mayor es: " + num2);
        sumt = num1 + num2 + num3;
        prom = sumt / 3;
        Console.WriteLine("La suma total es: " + sumt);
        Console.WriteLine("El promedio es: " + prom);
    }
    else if (num3 > num1 && num3 > num2)
    {
        Console.WriteLine("El numero mayor es: " + num3);
        sumt = num1 + num2 + num3;
        prom = sumt / 3;
        Console.WriteLine("La suma total es: " + sumt);
        Console.WriteLine("El promedio es: " + prom);
    }
    else if (num1 == num2 && num1 > num3)
    {

        Console.WriteLine("El numero mayor es: " + num1);
        sumt = num1 + num2 + num3;
        prom = sumt / 3;
        Console.WriteLine("La suma total es: " + sumt);
        Console.WriteLine("El promedio es: " + prom);
    }
    else if (num2 > num1 && num2 == num3)
    {

        Console.WriteLine("El numero mayor es: " + num2);
        sumt = num1 + num2 + num3;
        prom = sumt / 3;
        Console.WriteLine("La suma total es: " + sumt);
        Console.WriteLine("El promedio es: " + prom);
    }
    else if (num3 > num1 && num3 == num2)
    {
        Console.WriteLine("El numero mayor es: " + num3);
        sumt = num1 + num2 + num3;
        prom = sumt / 3;
        Console.WriteLine("La suma total es: " + sumt);
        Console.WriteLine("El promedio es: " + prom);
    }
    else
    {
        Console.WriteLine("El numero mayor es: " + num3);
        sumt = num1 + num2 + num3;
        prom = sumt / 3;
        Console.WriteLine("La suma total es: " + sumt);
        Console.WriteLine("El promedio es: " + prom);
    }
    x++;
    Console.WriteLine("Desea repetir el proceso? Si/No");
        respuesta=Console.ReadLine();
} while (respuesta == "Si" || respuesta == "si" || respuesta == "SI" || respuesta == "sI");
if (x == 1)
    Console.WriteLine("El proceso se hizo un vez");
else
    Console.WriteLine("El proceso se hizo {0} veces", x);