using System;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
namespace DemoApplication
{
    [Serializable]
    class Buku
    {
        public int NoBuku;
        public String Judul;
        public double notID;
        public String notName;
        static void Main(string[] args)
        {
            Buku obj = new Buku();
            obj.NoBuku = 1;
            obj.Judul = ".Net";

            Buku obj3 = new Buku();
            obj3.NoBuku = 11;
            obj3.Judul = ".Net1";

            Buku obj2 = new Buku();
            obj2.notID = 1;
            obj2.notName = ".Net";

            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream(@"D:\ExampleNew.txt", FileMode.Create, FileAccess.Write);

            formatter.Serialize(stream, obj);
            formatter.Serialize(stream, obj3);
            stream.Close();

            stream = new FileStream(@"D:\ExampleNew.txt", FileMode.Open, FileAccess.Read);
            Buku objnew = (Buku)formatter.Deserialize(stream);

            Console.WriteLine(objnew.NoBuku);
            Console.WriteLine(objnew.Judul);

            Console.ReadKey();
        }
    }
}