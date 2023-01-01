using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo01
{
    class Program
    {
        static void Main(string[] args)
        {
            Editor editor= new Editor(new FrenchSpellChecker());
            /*Console.WriteLine("1. english, 2. french");
            /*int choice = Convert.ToInt32(Console.ReadLine());
            ISpellChecker sp = SpellCheckFactory.checkType(choice);
            editor.SpellChecker = sp;*/
            editor.WrapperCheck("akshay");
        }
    }

    public class Editor
    {
        #region commented code. 
        //public void Cut()
        //{
        //    Console.WriteLine("Cut done");
        //}
        //public void Copy()
        //{
        //    Console.WriteLine("Copy done");
        //}
        //public void Paste()
        //{
        //    Console.WriteLine("Paste done");
        //}
        #endregion

        private ISpellChecker _spellChecker = null;
        public Editor() : this(new EnglishSpellChecker())
        {
        }
        public Editor(ISpellChecker spellChecker) { 
            SpellChecker = spellChecker;
        }
        public ISpellChecker SpellChecker { 
            get { return _spellChecker; }
            set { _spellChecker = value; }
        }
        public void WrapperCheck(string word) {
            _spellChecker.DoTheSpellCheck(word);
        }
    }
    public interface ISpellChecker { 
        void DoTheSpellCheck(string word);
    }

    public class SpellCheckFactory {
        public static ISpellChecker checkType(int choice) {
            if (choice == 1)
                return new EnglishSpellChecker();
            else
                return new FrenchSpellChecker();
        }
    }

    public class EnglishSpellChecker : ISpellChecker{
        public void DoTheSpellCheck(string word) {
            Console.WriteLine("Engllish spell checking is done.");
        }
    }
    public class FrenchSpellChecker : ISpellChecker
    {
        public void DoTheSpellCheck(string word)
        {
            Console.WriteLine("French spell checking is done.");
        }
    }
}
