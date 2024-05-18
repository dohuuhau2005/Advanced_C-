using System.Collections;
namespace Test1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Hashtable a = new Hashtable();
            Hashtable b = new Hashtable(10);
            b.Add(1, 2);
            b.Add("t la sieu nhan","holishit");
            Hashtable c = new Hashtable(b);

        }
    }
}