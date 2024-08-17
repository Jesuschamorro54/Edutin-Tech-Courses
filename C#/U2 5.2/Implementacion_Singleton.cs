using System;

class DatabaseConnection
{
    // Campo estático para la única instancia de la clase
    private static DatabaseConnection _instance;

    // Constructor privado para evitar la instanciación directa
    private DatabaseConnection()
    {
        Console.WriteLine("Conexión a la base de datos establecida.");
    }

    // Método público para obtener la instancia única
    public static DatabaseConnection GetInstance()
    {
        if (_instance == null)
        {
            _instance = new DatabaseConnection();
        }
        return _instance;
    }

    // Método para simular la conexión a la base de datos
    public void Connect()
    {
        Console.WriteLine("Usando la conexión existente a la base de datos.");
    }
}

class Program
{
    static void Main()
    {
        // Intentar obtener varias instancias de DatabaseConnection
        DatabaseConnection conn1 = DatabaseConnection.GetInstance();
        DatabaseConnection conn2 = DatabaseConnection.GetInstance();

        // Comprobar si ambas instancias son iguales
        if (conn1 == conn2)
        {
            Console.WriteLine("Ambas referencias apuntan a la misma instancia.");
        }

        // Usar la conexión a la base de datos
        conn1.Connect();
        conn2.Connect();
    }
}
