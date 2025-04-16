using System;

class Program
{
    class IndexersClass
    {
        private int[] names = new int[10];
        public string this[int index]
        {
            get
            {
                return names[index].ToString();
            }
            set
            {
                names[index] = int.Parse(value);
            }
        }
    }
    public static void Main()
    {
        IndexersClass indexers = new IndexersClass();
        indexers[0] = "1";
        indexers[1] = "2";  
        indexers[2] = "3";
        indexers[3] = "4";
        indexers[4] = "5";
        indexers[5] = "6";
        indexers[6] = "7";
        indexers[7] = "8";
        indexers[8] = "9";
        indexers[9] = "10";
        for (int i = 0; i < 10; i++)
        {
            Console.Write(indexers[i]+" ");
        }
    }
}