using System;
using System.Collections;


namespace Session07.collection
{
    public class DemoCol
    {
        static void testArrayLis()
        {
            //thường dùng với 1 danh sách có thứ tự, không sắp xếp
            ArrayList al = new ArrayList();
            Random rnd = new Random();
            for (int i = 0; i < 10; i++)
            {
                al.Add("Item #" + rnd.Next(100));
            }

            foreach (var item in al)
            {
                Console.WriteLine(item);
            }
        }
        static void testStack()
        {
            //theo nguyên tắc LIFO
            Stack st = new Stack();
            st.Push(5);
            st.Push(7);
            st.Push(4);
            st.Push(9);

            object x = st.Pop();
            Console.WriteLine(x);
        }

        static void testHashtable()
        {
            //một danh sách các phần tử không sx, không thứ tự
            //quản lý theo dạng key-value
            //tìm kiếm cực nhanh: log2(n)
            Hashtable ht = new Hashtable();
            Random rnd = new Random();
            for (int i = 0; i < 10; i++)
            {
                int s = rnd.Next(100);
                ht.Add(i, s);
                Console.Write(s+", ");
            }
            var items = ht.Values;
            Console.WriteLine();
            foreach (var item in items)
            {
                Console.Write(item+", ");
            }
        }

        static void testSortedList()
        {
            //danh sách có sắp xếp
            SortedList sl = new SortedList();
            Random rnd = new Random();
            for (int i = 0; i < 10; i++)
            {
                int s = rnd.Next(100);
                sl.Add(s, s);
                Console.Write(s + ", ");
            }
            Console.WriteLine();
            var items = sl.Keys;
            foreach (var item in items)
            {
                Console.Write(item + ", ");
            }
        }

        public static void Main(string[] args)
        {
            //testArrayLis();
            //testStack();
            //testHashtable();
            testSortedList();

            Console.ReadKey();
        }
        
    }
}
