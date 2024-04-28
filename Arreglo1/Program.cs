int[] n = new int[10];
int x = 0, num;

for (int i = 0; i < n.Length; i++)
{
    Console.Write("Captura un numero para la posicion {0}: ", i + 1);
    n[i] = int.Parse(Console.ReadLine());
}

Console.Write("Ingrese el numero que desea buscar: ");
num = int.Parse(Console.ReadLine());
string posiciones = "";

for (int i = 0; i < n.Length; i++)
{
    if (n[i] == num)
    {
        x++;
        if (x==1)
        {
            posiciones = posiciones + (i + 1);
        }
        else
        {
            posiciones =  posiciones + "," + (i + 1);
        }
        
    }
}

if (x > 0)
{
    Console.WriteLine("El numero {0} se encontro en las posiciones {1}", num, posiciones);
    Console.WriteLine("Se encontro {0} veces", x);
}

else
{
    Console.WriteLine("El numero no se encontro en el arreglo");
}


/*Console.WriteLine();
 
for (i = 0; i < n.Length; i++)
{
    Console.WriteLine("Elemento {0} contiene {1}", i, n[i]);
}

Console.WriteLine();

for (i = n.Length-1; i >= 0; i--)
{
    Console.WriteLine("Elemento {0} contiene {1}", i, n[i]);
}
*/