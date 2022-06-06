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

Console.WriteLine("==========TAREAS PENDIENTES==========");

mostrarTarea(tareasPendientes);

Console.WriteLine("==========TAREAS REALIZADAS==========");

mostrarTarea(tareasRealizadas);

busqueda(tareasRealizadas);

Console.WriteLine($"Cantidad de horas trabajadas por el empleado: {horasTrabajadas(tareasRealizadas)}");

//Cuerpo de las funciones

void mostrarTarea(List<tareas> mostrar)
{
    foreach (tareas item in mostrar)
    {
        Console.WriteLine("ID: {0}", item.tareaID);
        Console.WriteLine($"Descripcion {item.descripcion}");
        Console.WriteLine($"Duracion: {item.duracion}\n");
    }
}

void confirmar(List<tareas> tareasPendientes, List<tareas> tareasRealizadas)
{
    int realizada;
    int cant = tareasPendientes.Count;
    Console.WriteLine($"Count: {cant}");
    for (int i = 0; cant != 0; i++)
    {
        realizada = 0;
        Console.WriteLine("La tarea {0} fue realizada?", i+1);
        Console.WriteLine("Ingrese 1 si esta realizada");
        realizada = Convert.ToInt32(Console.ReadLine());
        if (realizada == 1)
        {
            var tarea = tareasPendientes[i];
            tareasRealizadas.Add(tarea);
            tareasPendientes.RemoveAt(i);
            i--;
            Console.WriteLine("Tarea desplazada");
        }
        cant--;
    }
}

void busqueda(List<tareas> tareasR)
{
    Console.WriteLine("Busque una tarea ingresando su descripcion: ");
    string buscar = Console.ReadLine();

    foreach (tareas item in tareasR)
    {
        if (buscar.CompareTo(item.descripcion) == 0)
        {
            Console.WriteLine("Se encontro una coincidencia");
            Console.WriteLine("DATOS TAREA COINCIDENTE");
            Console.WriteLine($"ID : {item.tareaID}");
            Console.WriteLine($"Descripcion: {item.descripcion}");
            Console.WriteLine($"Duracion: {item.duracion}");
        }
    }
}

int horasTrabajadas(List<tareas> tareasR)
{
    int horas = 0;
    foreach (tareas item in tareasR)
    {
        horas = horas + item.duracion;
    }

    return horas;
}