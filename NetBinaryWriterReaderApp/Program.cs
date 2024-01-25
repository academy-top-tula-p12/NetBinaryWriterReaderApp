using NetBinaryWriterReaderApp;
using System.IO;

string fileName = "file01.bin";
string fileEmpl = "employees.dat";

string text = "В следующем примере показано, как использовать StreamWriter объект для записи файла со списком каталогов на диске C, а затем использовать StreamReader объект для чтения и отображения каждого имени каталога. Рекомендуется использовать эти объекты в операторе using , чтобы неуправляемые ресурсы были правильно удалены. Инструкция using автоматически вызывает Dispose объект после завершения кода, который ее использует. Конструктор, используемый в этом примере, не поддерживается для использования в приложениях Магазина Windows.";
string textHello = "Hello world";

int number = 10354;
float x = 143.780F;
double y = 23.789423e3;

//using (BinaryWriter writer = new BinaryWriter(File.Open(fileName, FileMode.Create)))
//{
//    //writer.Write(text);
//    //writer.Write(textHello);
//    writer.Write(number);
//    writer.Write(x);
//    writer.Write(y);
//}

//using(BinaryReader reader = new BinaryReader(File.Open(fileName, FileMode.Open)))
//{
//    int nn;
//    float xx;
//    double yy;

//    xx = reader.ReadSingle();
//    yy = reader.ReadDouble();
//    nn = reader.ReadInt32();


//    Console.WriteLine($"{nn} {xx} {yy}");
//}


Employee bob = new() { Name = "Bob", Age = 27 };

List<Employee> employees = new List<Employee>() 
{
    new(){ Name = "Sam", Age = 19 },
    new(){ Name = "Joe", Age = 32 },
};

//using(BinaryWriter writer = new BinaryWriter(File.OpenWrite(fileEmpl)))
//{
//    writer.Write(bob.Name);
//    writer.Write(bob.Age);

//    foreach (Employee employee in employees)
//    {
//        writer.Write(employee.Name);
//        writer.Write(employee.Age);
//    }
//    Console.WriteLine("Data written to file");
//}

using(BinaryReader reader = new BinaryReader(File.OpenRead(fileEmpl)))
{
    string name;// = reader.ReadString();
    int age;// = reader.ReadInt32();
    //Console.WriteLine($"Name: {name}, Age: {age}");

    while(reader.PeekChar() != -1)
    {
        name = reader.ReadString();
        age = reader.ReadInt32();
        Console.WriteLine($"Name: {name}, Age: {age}");
    }
}