using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Test1
{
    internal class MyArrayList : ICollection
    {
       int count ;
        int maxcount = 100;
        object[] Myobj ;
        public MyArrayList() 
        {
            count = -1;
            Myobj= new object[maxcount];

        }
        public MyArrayList (int count)
        {
            this.count = count;
            Myobj = new object[count];
        }
        public MyArrayList(Array a)
        {
            a.CopyTo(Myobj, 0);
            Count = a.Length;
        }
        public int Count
        {
            set { count = value; }
            get { return count; }
        }

        public bool IsSynchronized { 
             get { throw new NotImplementedException(); }
        }

        public object SyncRoot => throw new NotImplementedException();

        public void copyto(Array a, int b)
        {
            //chep mang moi vao
            Myobj.CopyTo(a, b);
        }

        public void CopyTo(Array array, int index)
        {
            Myobj.CopyTo(array,index);
        }

        public IEnumerator GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
