using System;
using System.Text;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;

namespace SerializeTutorial
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Initialize an object
            Tutorial obj = new Tutorial();
            obj.ID = 1;
            obj.Name = ".Net";

            //Create the filestream
            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream(@"C:\FileStream\Sample.txt", FileMode.Create, FileAccess.Write);

            //Serialize the object
            formatter.Serialize(stream, obj);
            stream.Close();

            stream = new FileStream(@"C:\FileStream\Sample.txt", FileMode.Open, FileAccess.Read);
            Tutorial objNew = (Tutorial)formatter.Deserialize(stream);

            Console.WriteLine(objNew.ID);
            Console.WriteLine(objNew.Name);

        }
    }
}
