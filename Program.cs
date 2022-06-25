using System;
using System.Linq;

namespace _1165
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string a = "Долгая дорога на север привела к Финляндии, Чемоданчик";
            string b = "Мы совсем не ожидали, что дорога от Волгодонска до Португалии, окажется настолько долгая, что половина нашего отряда состарится на второй день, Чемоданчик";
            string c = "Крутая дорога привела к вершине Эльбруса, Чемоданчик";
            string[] wordsA = a.Split(new char[] { ' ' });
            string[] wordsb = b.Split(new char[] { ' ' });
            string[] wordsc = c.Split(new char[] { ' ' });
            var d = wordsA.Intersect(wordsb);
            var e = wordsA.Intersect(wordsc);
            var f = d.Intersect(e);
            string g = "1";
            foreach (string s in f)
            {
                if(g.Length<s.Length){
                    Console.WriteLine(s);
                    Console.WriteLine("длина" +s.Length);
                    g = s;
                }
            }
            Console.WriteLine("Самое длинное слово: "+g);
            Console.WriteLine("длина слова "+g.Length);
        }
    }
}
//string a = "Долгая дорога на север привела к Финляндии";
//string b = "Мы совсем не ожидали, что дорога от Волгодонска до Португалии, окажется настолько долгая, что половина нашего отряда состарится на второй день";
//string f = "Крутая дорога привела к вершине Эльбруса";
