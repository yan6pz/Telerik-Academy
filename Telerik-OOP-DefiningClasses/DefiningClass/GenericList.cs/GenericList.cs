using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericList.cs
{
    public class GenericList<T>
    {
        const int capacity = 10;
        private T[] elements;
        private int count = 0;
        //Constructor
        public GenericList()
        {
            elements = new T[capacity];

        }
      
        public int Count
        {
            get { return this.count; }
        }
        //Methods
        public T[] Add(T element,int number)
        {


            if (count > capacity)
            {
                T[] grow = new T[elements.Length + number];
                for (int i = 0; i < elements.Length + number; i++)
                {
                    grow[i] = element;

                }
                return grow;
            }
            else
            {
                for (int i = 0; i < number; i++)
                {
                    elements[i] = element;

                }
                count += number;
                return elements;
            }
            
        }
        public void Clear()
        {

            elements = new T[capacity];
            count = 0;
        }
        public void Access(int index)
        {
            if (0 > index || index > capacity - 1)
            {
                throw new IndexOutOfRangeException();
            }
            else
            {
                Console.WriteLine(elements[index]);
            }
        }
        public void Remove(int index)
        {
            if (index > count || index < 0)
            {
                throw new IndexOutOfRangeException();
            }
            T[] array = new T[capacity];
            T symbol = elements[index];
            Array.Copy(elements, array, index);
            Array.Copy(elements, index + 1, array, index, count--);
            elements = array;
            for (int i = 0; i < capacity; i++)
            {
                Console.WriteLine(elements[i]);
            }
            
        }

        public void Find(T elem,T[] elements)
        {
           
            int index=-1;
            for (int i = 0; i < capacity; i++)
            {
                if (elements[i].Equals(elem))
                {
                    index = i;
                    Console.WriteLine("element at position{0} is mached in array.", index);
                }
              
            }
            if (index < 0) Console.WriteLine("there is no such a element");
            
        }
        public override string ToString()
        {
            StringBuilder str = new StringBuilder();
            for (int i = 0; i < count; i++)
            {
                str.Append(elements[i] + " ");
            }
            return str.ToString();
        }
        public void AutoGrow()
        {
            T[] doubleEl=new T[2*capacity]; //rising two times the capacity 
            for (int i = 0; i < capacity; i++)
			{
                doubleEl[i]=elements[i];  //overriding the elements from first to second array
			 
			}
            elements=doubleEl;
        }
        public T MIn<T>(T[] elements)
        {
            T min = elements.Min();
            return min;
            
        }
        public T Max(T[] elements)
        {
            T max = elements.Max();
            return max;
        }
    }
}
