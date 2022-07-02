using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDictionary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<string> sehirler = new MyDictionary<string>();
            sehirler.Add("ANKARA");
            sehirler.Add("KAYSERİ");
            sehirler.Add("İSTANBUL");



        }
        
        class MyDictionary<T>
        {
            T[] _array;
            T[] _tempArray;

            //default constructor created
            public MyDictionary()
            {
                _array = new T[0];
            }
         
            public void Add(T item)
            {
                _array = _tempArray;
                _array=new T[_array.Length+1];

                for (int i = 0; i < _tempArray.Length; i++)
                {
                    _array[i] = _tempArray[i];
                }
                _array[_array.Length-1] = item;



            }
        }







    }
}
