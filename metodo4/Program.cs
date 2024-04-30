
int num, x = 0;
String respuesta;
Console.WriteLine("Programa que calcula el factorial de un numero");
do
{
    Console.Write("Capture el numero: ");
    num = int.Parse(Console.ReadLine());
    Console.WriteLine("El factorial de {0} es {1}", num, factorialAcumulado(num));
    Console.WriteLine("Desea calcular el factorial para otro numero (s/n)?");
    respuesta = Console.ReadLine();
    x++;
} while (respuesta == "si" || respuesta == "Si" || respuesta == "sI" || respuesta == "SI" || respuesta == "s" || respuesta == "S");
if (x == 1)
{
    Console.WriteLine("El programa se hizo una vez");
}
else
{
    Console.WriteLine("El programa se hizo {0} veces", x);
}

int factorialAcumulado(int num)
{
    int mul = 1;
    for (int x = 1; x <= num; x++)
    {
        mul = mul * x;
    }
    return mul;
}
