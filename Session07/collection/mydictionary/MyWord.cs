using System;

namespace Session07.collection.mydictionary
{
    public class MyWord
    {
        public string Word { get; set; }
        public string WordType { get; set; }
        public string Meaning { get; set; }
        public MyWord(string word,string type, string meaning)
        {
            Word = word;
            WordType = type;
            Meaning = meaning;
        }
        public override int GetHashCode()
        {
            return Word.ToLower().GetHashCode();
        }
        public override bool Equals(object obj)
        {
            MyWord mw = (MyWord)obj;
            return mw.Word.ToLower().Equals(this.Word.ToLower());
        }

        public override string ToString()
        {
            return String.Format("{0} ({1}): {2}",Word,WordType,Meaning);
        }
    }
}
