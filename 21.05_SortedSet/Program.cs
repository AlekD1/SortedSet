using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21._05_SortedSet
{
    class Program
    {
        static void ShowColl(SortedSet<char> ss, string s)
        {
            Console.WriteLine(s);
            foreach (char ch in ss)
                Console.Write(ch + " ");
            Console.WriteLine("\n");
        }
        static void Main()
        {
            // Создадим три множества
            SortedSet<char> A = new SortedSet<char>();
            SortedSet<char> B = new SortedSet<char>();
            SortedSet<char> C = new SortedSet<char>();
            A.Add('Л');
            A.Add('е');
            A.Add('в');
            A.Add('ч');
            A.Add('е');
            A.Add('н');
            A.Add('к');
            A.Add('о');
            ShowColl(A, "A: ");
            B.Add('Д');
            B.Add('а');
            B.Add('н');
            B.Add('и');
            B.Add('и');
            B.Add('л');
            ShowColl(B, "B: ");
            C.Add('Ю');
            C.Add('р');
            C.Add('ь');
            C.Add('е');
            C.Add('в');
            C.Add('и');
            C.Add('ч');
            ShowColl(C, "C: ");
            SortedSet<char> res = new SortedSet<char>();
            res = A;
            res.UnionWith(B);
            res.UnionWith(C);
            ShowColl(res, "Объединение множеств: ");
            res = A;
            res.IntersectWith(B);
            res.IntersectWith(C);
            ShowColl(res, "Пересечение множеств: ");
            res = A;
            res.ExceptWith(B);
            ShowColl(res, "Разность множеств A/B");
            res = B;
            res.ExceptWith(A);
            ShowColl(res, "Разность множеств B/A");
            Console.ReadLine();
        }
    }
}
