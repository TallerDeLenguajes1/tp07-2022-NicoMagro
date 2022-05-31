List<tareas> tareasPendientes = new List<tareas>();
List<tareas> tareasRealizadas = new List<tareas>();

Random rnd = new Random();
int cantTareas = rnd.Next(1,5);

Console.WriteLine("Cantidad de tareas a publicar: {0}", cantTareas);

for (int i = 0; i < cantTareas; i++)
{
    Console.WriteLine("Ingrese la descripcion de la tarea {0}", i + 1);
    tareasPendientes.Add(new tareas() {tareaID = i, descripcion = Console.ReadLine(), duracion = rnd.Next(10,100)});
}

mostrarTarea(tareasPendientes);

confirmar(tareasPendientes, tareasRealizadas);

//Cuerpo de las funciones

void mostrarTarea(List<tareas> mostrar)
{
    foreach (tareas item in tareasPendientes)
    {
        Console.WriteLine("ID: {0}", item.tareaID);
        Console.WriteLine($"Descripcion {item.descripcion}");
        Console.WriteLine($"Duracion: {item.duracion}");
    }
}

void confirmar(List<tareas> tareasPendientes, List<tareas> tareasRealizadas)
{
    int realizada;
    int cant = tareasPendientes.Count;
    Console.WriteLine($"Count: {cant}");
    while (cant )
    {
        
    }
    for (int i = 0; i < cantTareas + 1; i++)
    {
        realizada = 0;
        Console.WriteLine("La tarea {0} fue realizada?", i+1);
        Console.WriteLine("Ingrese 1 si esta realizada");
        realizada = Convert.ToInt32(Console.ReadLine());
        if (realizada == 1)
        {
            tareasRealizadas.Add(new tareas() {tareaID = tareasPendientes[i].tareaID, descripcion = tareasPendientes[i].descripcion, duracion = tareasPendientes[i].duracion});
            tareasPendientes.RemoveAt(i);
            Console.WriteLine("Tarea desplazada");
        }
    }
}