int x, num, c = 0, suma = 0, prom = 0, par = 0, m15 = 0, nneg = 0, sumimp = 0, val = 0, sumt = 0, sumnneg = 0, sumpar = 0, summ15 = 0, sumimp1;
string linea, respuesta = "Si";
do
{
    x = 0;
    for (val = 1; val <= 10; val++) 
    {
        Console.WriteLine("Ingrese el numero: ");
        linea = Console.ReadLine();
        num = int.Parse(linea);
        if (num < 0)
        {
            nneg = nneg + 1;
            sumnneg = num;
        }
        if (num % 2 == 0) 
        {
            par = par + 1;
            sumpar = num;
        }
        if (num % 15 == 0) 
        {
            m15 = m15 + 1;
            summ15 = num;
        }
        if (num % 2 != 0)
        {
            sumimp += num;
        }
        x++;
        sumt = sumt + num;
        prom = sumt / x;
    }

    Console.WriteLine("La cantidad de numeros negativos son: " + nneg);
    Console.WriteLine("La cantidad de numeros pares son: " + par);
    Console.WriteLine("La cantidad de numeros multiplos de 15 son: " + m15);
    Console.WriteLine("La suma de los numeros impares son: " + sumimp);
    c++;
    Console.WriteLine("Desea repetir el proceso? Si/No");
    respuesta = Console.ReadLine();
} while (respuesta == "Si" || respuesta == "si" || respuesta == "SI" || respuesta == "sI");

if (c == 1)
{
    Console.WriteLine("El proceso se hizo una vez");
}
else
{
    Console.WriteLine("El proceso se hizo {0} veces", c);
}
Console.WriteLine("La suma de todos los numeros es: " + sumt);
Console.WriteLine("El promedio de todos los numeros es es: " + prom);
