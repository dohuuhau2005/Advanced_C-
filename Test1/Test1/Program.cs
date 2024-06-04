using System.Collections;
using System.Collections.Generic;
namespace Test1
{
    internal class Program
    {
        public static void swap <t>(ref t a , ref t b)
        {
            t temp = a;
            a = b;
            b = temp;
        }
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
            Console.WriteLine("so pt " + e.Count);
            Console.WriteLine("so dau tien " + e.Peek());
            Console.WriteLine("da lay ra " + e.Pop());
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
            Dictionary<string, int> m = new Dictionary<string, int>();
            m.Add("ht", 1234);
            m.Add("hihi", 2345);
            m.Add("kiki", 54435);
            m.Add("siuu", 7);
            foreach (KeyValuePair<string, int> k in m)
            {
                Console.WriteLine(k.Key + " " + k.Value);
            }
            int l = 0;
            int r = 6;
            swap<int>(ref l, ref r);
            var s = Tuple.Create<int, string>(l, "hahgo");
            var z = new Tuple<int,int,int>(DateTime.Now.Day, DateTime.Now.Month,DateTime.Now.Year);
           Console.WriteLine("bien z"+z.Item1+" "+z.Item2+" "+z.Item3);
            var now = checkcurrentyear();
            Console.WriteLine(now.ToString());
            Console.WriteLine($"ngay = {now.Item1}/thang = {now.Item2}/nam = {now.Item3}");
            Console.WriteLine($"gio = {now.Item4}/phut = {now.Item5}/giay = {now.Item6}");
       
        
        }
        static Tuple<int, int , int ,int ,int, int> checkcurrentyear()
        {
            DateTime a = DateTime.Now;
            return new Tuple<int, int, int,int,int,int>(a.Day, a.Month, a.Year,a.Hour, a.Minute, a.Second);
            
        }
    
    }
}