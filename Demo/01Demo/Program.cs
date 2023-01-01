using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1. English, 2.Hindi");
            int choice = Convert.ToInt32(Console.ReadLine());
            SpellCheckerFactory sf = new SpellCheckerFactory();
            ISpellChecker spellChecker = sf.getSpellCheckerType(choice);
            Editor editor = new Editor(spellChecker);
            editor.DoSpellCheck("akshay");
        }
    }

    public class SpellCheckerFactory {
        ISpellChecker checker = null;
        public ISpellChecker getSpellCheckerType(int choice) {
            if (choice == 1)
            {
                return new EnglishSpellChecker();
            }
            else {
                return new HindiSpellChecker();
            }
        }
    }

    public class Editor {

        ISpellChecker checker = null;
        public Editor(ISpellChecker checker) {
            this.checker = checker;
        }
        public void Cut() { 
        
        }
        public void Copy()
        {

        }
        public void Paste()
        {

        }
        public void DoSpellCheck(string word) {
            checker.Check(word);

        }
    }

    public interface ISpellChecker {
        void Check(string word);
    }

    public class EnglishSpellChecker : ISpellChecker {
        public void Check(string word) {
            Console.WriteLine("English spell check done");
        }
    }

    public class HindiSpellChecker : ISpellChecker
    {
        public void Check(string word)
        {
            Console.WriteLine("Hindi spell check done");
        }
    }
}
