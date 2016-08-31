using System.Collections.Generic;


namespace Session07.collection.mydictionary
{
    public class MyDictionary
    {
        private Dictionary<string, MyWord> dic;
        public MyDictionary()
        {
            dic = new Dictionary<string, mydictionary.MyWord>();
        }

        public void addWord(MyWord word)
        {
            dic.Add(word.Word,word);
        }

        public MyWord lookup(string word)
        {
            if(dic.ContainsKey(word))
                return dic[word];
            return null;
        }
    }
}
