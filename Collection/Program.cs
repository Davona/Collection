using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collection
{
    class Program
    {
        static void Main(string[] args)
        {
            Alphabet alphabet = new Alphabet();
            foreach (var item in alphabet)
            {
                Console.WriteLine(item);
            }

            
        }
    }
    class Alphabet:IEnumerable,IEnumerator
    {
        char[] alphabet = new char []{ 'a', 'b', 'c','d','e','f','g','h' };
        int count = 0;

        public object Current => alphabet[count++];

        public IEnumerator GetEnumerator()
        {
            return new Alphabet();
        }

        public bool MoveNext()
        {
            return count < alphabet.Length;
        }

        public void Reset()
        {
            throw new NotImplementedException();
        }
    }
   
}
