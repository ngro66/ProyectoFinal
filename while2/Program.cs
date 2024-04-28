int num1 = 0, x = 0, num2 = 0, z = 1;
string respuesta = "Si";
do
{
    Console.WriteLine("Seleccione el numero que desea la tabla");
    num1 = int.Parse(Console.ReadLine());
    while (z <= 10)
    {
        Console.WriteLine("El resultado es:");
        num2 = num1 * z;
        Console.WriteLine("{0} x {1} = {2}", num1, z, num2);
        z = z + 1;
    }
    x++;
    Console.WriteLine("Desea repetir el proceso? Si/No");
    respuesta = Console.ReadLine();
    z = 1;
} while (respuesta == "Si" || respuesta == "si" || respuesta == "SI" || respuesta == "sI");
if (x == 1)
    Console.WriteLine("El proceso se hizo una vez");
else
    Console.WriteLine("El proceso se hizo {0} veces", x);