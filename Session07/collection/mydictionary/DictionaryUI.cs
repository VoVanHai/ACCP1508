using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session07.collection.mydictionary
{
    public class DictionaryUI
    {
        public static void Main(string[] args)
        {
            MyDictionary dic = new MyDictionary();
            dic.addWord(new MyWord("student", "noun", "sinh vien"));
            dic.addWord(new MyWord("standard", "noun", "tieu chuan"));
            dic.addWord(new MyWord("stupid", "adj", "khung dien"));
            dic.addWord(new MyWord("system", "noun", "he thong"));

            do
            {
                Console.Write("Nhap tu can tra(@@@ de thoat): ");
                string word=Console.ReadLine();
                if(word.Equals("@@@"))break;

                MyWord lwork = dic.lookup(word);
                if(lwork!=null)
                    Console.WriteLine(lwork);
                else
                    Console.WriteLine("tu nay khong co trong tu dien");
            } while (true);
        }
    }
}
