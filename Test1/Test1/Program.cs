using System.Collections;
namespace Test1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList arr = new ArrayList(100);
            arr.Add(1);
            arr.Add('k');
            arr.Add("supper man");
            //Hashtable code
            Hashtable a = new Hashtable();
            Hashtable b = new Hashtable(10);
            /*Hashtable d = new Hashtable(arr);*/ /*ko the chay dc (Error	CS1503	Argument 1: cannot convert from 'System.Collections.ArrayList' to 'System.Collections.IDictionary')*/
            b.Add(1, 2);
            b.Add("t la sieu nhan", "holishit");
            Hashtable c = new Hashtable(b);
            //Stack (first in last out)
            Stack e = new Stack();/*co the them so vao */
            e.Push(1);
            e.Push("kukiu");
            e.Push('k');
            Console.WriteLine("so pt "+e.Count);
            Console.WriteLine("so dau tien "+e.Peek());
            Console.WriteLine("da lay ra "+e.Pop());
            Console.WriteLine("so dau tien " + e.Peek());
            Stack f = new Stack(arr);
            Stack g = new Stack(a);
           // //SortedList (giong voi thg hashtable nhung phai co cach sap xep)
           // /*SortedList h = new SortedList(arr);*//*ko the chay dc (Error	CS1503	Argument 1: cannot convert from 'System.Collections.ArrayList' to 'System.Collections.IDictionary')*/
           // SortedList h = new SortedList(g,arrangeParameter());(True)
           // h.Add(1, 2);
           ///* h.Add("hihihi", "kiki");*///loi ngay day neu ko co cach sap xep
           // Console.Write(h);
           //Queue (First in first out)
           Queue i = new Queue(arr);
            Queue j = new Queue(e);
            j.Enqueue(100);           
            j.Dequeue();
            Console.WriteLine(j.Peek());
            //BitArray
            BitArray M = new BitArray(10);/*Mac dinh la false*/
            BitArray N = new BitArray(10,true);/*Mac dinh la true*/
            
        }
    }
}