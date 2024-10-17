using ConsoleApp8;



Console.WriteLine("Crearemos un objeto de la clase \"Moto\"");
Console.WriteLine("Por favor ingrese la marca: ");
string marca  = Console.ReadLine();
Console.WriteLine("Por faovr ingrese el modelo: ");
string modelo  = Console.ReadLine();
Console.WriteLine("Ingrese la cilindrada");
int cilindrada = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Ingrese la potencia en HP");
double potencia = Convert.ToDouble(Console.ReadLine());

Moto nueva_moto = new Moto(marca,modelo,cilindrada,potencia);

Console.WriteLine(nueva_moto.Marca);
Console.WriteLine(nueva_moto.Modelo);
Console.WriteLine(nueva_moto.Cilindrada);
Console.WriteLine(nueva_moto.Potencia);
Modificar: 
Console.WriteLine("¿Desea modificar algún dato?\n 1. Si\n 2. No");
int opcion = Convert.ToInt32(Console.ReadLine());

if (opcion == 1) {
    Console.WriteLine("¿Que parámetro desea modificar?\n1. Marca\n2. Modelo\n3. Cilindrada \n4. Potencia");
    int sub_opcion = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Escriba el nuevo valor");
    switch (sub_opcion) {
        case 1:
            nueva_moto.Marca = Console.ReadLine();
            break;
        case 2:
            nueva_moto.Modelo = Console.ReadLine();
            break;
        case 3:
            nueva_moto.Cilindrada = Convert.ToInt32((Console.ReadLine() + Console.ReadLine()));
            break;
        case 4:
            nueva_moto.Potencia = Convert.ToDouble(Console.ReadLine());
            break;
    
    
    }

    Console.WriteLine(nueva_moto.Marca);
    Console.WriteLine(nueva_moto.Modelo);
    Console.WriteLine(nueva_moto.Cilindrada);
    Console.WriteLine(nueva_moto.Potencia);
    goto Modificar;
}

else if (opcion == 2) { Console.WriteLine("Presione una tecla para salir"); }
