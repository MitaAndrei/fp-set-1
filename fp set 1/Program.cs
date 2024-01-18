using System;

namespace fp_set_1;

class Program
{
    static void Main(string[] args)
    {
        P1();

        Console.ReadLine();
    }


    // 1. Rezolvati ecuatia de gradul 1 cu
    // o necunoscuta: ax+b = 0, unde a si b sunt date de intrare. 
    static void P1()
    {
        Console.Write("a = ");
        double a = Convert.ToDouble(Console.ReadLine());
        if (a != 0)
        {
            Console.Write("b = ");
            double b = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"x = {-b / a}");
        }
        else
            Console.WriteLine("a nu poate fi 0");
    }

    // 2. Rezolvati ecuatia de gradul 2 cu o necunoscuta:
    // ax^2 + bx + c = 0, unde a, b si c sunt date de intrare.
    // Tratati toate cazurile posibile. 
    static void P2()
    {
        Console.Write("a = ");
        double a = Convert.ToDouble(Console.ReadLine());
        if (a != 0)
        {
            Console.Write("b = ");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.Write("c = ");
            double c = Convert.ToDouble(Console.ReadLine());

            double delta = b * b - 4 * a * c;
            if (delta > 0)
            {
                double x1 = (-b + Math.Sqrt(delta)) / (2 * a);
                double x2 = (-b - Math.Sqrt(delta)) / (2 * a);
                Console.WriteLine($"x1 = {x1}, x2 = {x2}");

            }
            else if (delta == 0)
                Console.WriteLine($"x1 = x2 = {-b / (2 * a)}");

            else
                Console.WriteLine("Ecuatia nu are solutii in R");
        }
        else
            Console.WriteLine("a nu poate fi 0");
    }


    // 3. Determinati daca n se divide cu k, unde n si k sunt date de intrare. 

    static void P3()
    {
        Console.Write("n = ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("k = ");
        int k = int.Parse(Console.ReadLine());

        if (n % k == 0)
            Console.WriteLine($"{n} se divide cu {k}");
        else
            Console.WriteLine($"{n} nu se divide cu {k}");
    }

    // 4. Detreminati daca un an y este an bisect.
    static void P4()
    {
        Console.Write("Introduceti anul: ");
        int y = int.Parse(Console.ReadLine());

        if ((y % 4 == 0 && y % 100 != 0) || y % 400 == 0)
            Console.WriteLine($"Anul {y} este bisect");
        else
            Console.WriteLine($"Anul {y} nu este bisect");
    }

    // 5. Extrageti si afisati a k-a cifra de la sfarsitul unui numar.
    // Cifrele se numara de la dreapta la stanga.

    static void P5()
    {
        Console.Write("n = ");
        string n = Console.ReadLine();
        Console.Write("k = ");
        int k = int.Parse(Console.ReadLine());

        char num = n[^k];
        Console.WriteLine(num);

    }

    // 6. Detreminati daca trei numere pozitive a, b si c
    // pot fi lungimile laturilor unui triunghi.

    static void P6()
    {
        Console.Write("a = ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("b = ");
        int b = int.Parse(Console.ReadLine());
        Console.Write("c = ");
        int c = int.Parse(Console.ReadLine());

        if ((a < b + c) && (b < a + c) && (c < a + b))
            Console.WriteLine("Numerele pot fi lungimi a laturilor unui triunghi.");
        else
            Console.WriteLine("Numerele nu pot fi lungimi a laturilor unui triunghi");

    }

    // 7 & 8. Se dau doua variabile numerice a si b ale carori
    // valori sunt date de intrare. Se cere sa se inverseze valorile
    // lor fara a folosi alte variabile suplimentare.

    static void P78()
    {
        Console.Write("a = ");
        double a = Convert.ToDouble(Console.ReadLine());
        Console.Write("b = ");
        double b = Convert.ToDouble(Console.ReadLine());

        (a, b) = (b, a);
        Console.WriteLine($"a = {a}, b = {b}");
    }

    // 9. Afisati toti divizorii numarului n.

    static void P9()
    {
        Console.Write("n = ");
        int n = int.Parse(Console.ReadLine());

        for (int i = 1; i <= Math.Sqrt(n); i++)
        {
            if (n % i == 0)
                Console.Write($"{i} {(i != n / i ? n / i : "")} ");
        }
    }

    //10. Test de primalitate: determinati daca un numar n este prim.

    static void P10()
    {
        Console.Write("n = ");
        int n = int.Parse(Console.ReadLine());
        bool ePrim = true;
        if (n <= 1)
            Console.WriteLine($"{n} nu este prim");
        else
        {
            for (int i = 2; i <= Convert.ToInt32(Math.Sqrt(n)); i++)

                if (n % i == 0)
                {
                    ePrim = false;
                    Console.WriteLine($"{n} nu e prim");
                    break;
                }

            if (ePrim)
                Console.WriteLine($"{n} e prim");
        }



    }
    // 11. Afisati in ordine inversa cifrele unui numar n.

    static void P11()
    {
        Console.Write("n = ");
        string n = Console.ReadLine();

        for (int i = n.Length - 1; i >= 0; i--)
            Console.Write(n[i]);
    }

    // 12. Determinati cate numere integi divizibile
    // cu n se afla in intervalul [a, b].

    static void P12()
    {
        Console.Write("a = ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("b = ");
        int b = int.Parse(Console.ReadLine());
        Console.Write("n = ");
        int n = int.Parse(Console.ReadLine());

        int c = 0;

        for (int i = a; i <= b; i++)
            if (i % n == 0)
                c++;

        Console.WriteLine(c);
    }


    // 13. Determianti cati ani bisecti sunt intre anii y1 si y2.

    static void P13()
    {
        Console.Write("y1 = ");
        int y1 = int.Parse(Console.ReadLine());
        Console.Write("y2 = ");
        int y2 = int.Parse(Console.ReadLine());

        int c = 0;
        for (int i = y1 + 1; i < y2; i++)

            if ((i % 4 == 0 && i % 100 != 0) || i % 400 == 0)
                c++;

        Console.WriteLine(c);
    }

    // 14. Determianti daca un numar n este palindrom.
    // (un numar este palindrom daca citit invers obtinem un
    // numar egal cu el, de ex. 121 sau 12321. 

    static void P14()
    {
        Console.Write("n = ");
        string n = Console.ReadLine();

        string b = "";
        for (int i = n.Length - 1; i >= 0; i--)
            b += n[i];

        if (b == n)
            Console.WriteLine($"{n} e palindrom");

        else
            Console.WriteLine($"{n} nu e palindrom");

    }

    // 15. Se dau 3 numere. Sa se afiseze in ordine crescatoare.

    static void P15()
    {
        double[] numbers = new double[3];
        Console.WriteLine("Introduceti 3 numere (cate unul):");
        numbers[0] = Convert.ToDouble(Console.ReadLine());
        numbers[1] = Convert.ToDouble(Console.ReadLine());
        numbers[2] = Convert.ToDouble(Console.ReadLine());
        Array.Sort(numbers);
        foreach (double i in numbers)
            Console.Write($"{i} ");
    }

    // 16. Se dau 5 numere. Sa se afiseze in ordine crescatoare.
    // (nu folositi tablouri)

    static void P16()
    {
        Console.WriteLine("Introduceti 5 numere:");
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        int c = int.Parse(Console.ReadLine());
        int d = int.Parse(Console.ReadLine());
        int e = int.Parse(Console.ReadLine());


        if (a > b) (a, b) = (b, a);
        if (a > c) (a, c) = (c, a);
        if (a > d) (a, d) = (d, a);
        if (a > e) (a, e) = (e, a);

        if (b > c) (b, c) = (c, b);
        if (b > d) (b, d) = (d, b);
        if (b > e) (b, e) = (e, b);

        if (c > d) (c, d) = (d, c);
        if (c > e) (c, e) = (e, c);

        if (d > e) (d, e) = (e, d);

        Console.WriteLine($"{a} {b} {c} {d} {e}");

    }

    // 17. Determianti cel mai mare divizor comun si cel mai mic
    // multiplu comun a doua numere. Folositi algoritmul lui Euclid.

    static void P17()
    {
        Console.Write("a = ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("b = ");
        int b = int.Parse(Console.ReadLine());
        if (a != 0 && b != 0)
        {
            int ta = a;
            int tb = b;
            while (ta != tb)

                if (ta > tb)
                    ta -= tb;
                else
                    tb -= ta;

            Console.WriteLine($"Cel mai mare divizor comun: {ta}");
            int cmmmc = a * b / ta;
            Console.WriteLine($"Cel mai mic multiplu comun: {cmmmc}");
        }
    }

    // 18. Afisati descompunerea in factori primi ai unui numar n.
    // De ex. pentru n = 1176 afisati 2^3 x 3^1 x 7^2.

    static void P18()
    {
        Console.Write("n = ");
        int n = int.Parse(Console.ReadLine());
        int d = 2;
        int p;
        string result = "";
        while (n != 1)
        {
            p = 0;
            while (n % d == 0)
            {
                p++;
                n /= d;
            }

            if (p != 0)
                result += $"{d}^{p} x ";

            d++;

            if (n > 1 && d * d > n)
                d = n;

        }

        Console.WriteLine(result[..^2]);
    }

    // 19. Determinati daca un numar e format doar cu 2 cifre
    // care se pot repeta. De ex. 23222 sau 9009000 sunt
    // astfel de numere, pe cand 593 si 4022 nu sunt.

    static void P19()
    {
        Console.Write("n = ");
        string n = Console.ReadLine();

        string seen = "";
        bool poate = true;
        foreach (char abc in n)
        {
            if (!seen.Contains(abc))
                seen += abc;

            if (seen.Length == 3)
                break;

        }
        if (seen.Length != 2)
            poate = false;

        if (poate)
            Console.WriteLine("Numarul e format doar cu 2 cfire");
        else
            Console.WriteLine("Numarul nu e format doar cu 2 cifre");
    }


    /// <summary>
    /// Afisati fractia m/n in format zecimal, cu perioada intre
    /// paranteze (daca e cazul). Exemplu: 13/30 = 0.4(3).
    /// </summary>
    /// 220/577
    // O fractie este neperiodica daca numitorul este de forma
    // 2^m*5^n unde m si n sunt mai mari sau egale decat 0
    static void P20()
    {
        Console.Write("m = ");
        int m = int.Parse(Console.ReadLine());
        Console.Write("n = ");
        int n = int.Parse(Console.ReadLine());

        int ta = m;
        int tb = n;
        while (ta != tb)

            if (ta > tb)
                ta -= tb;
            else
                tb -= ta;
        m /= ta;
        n /= ta;


        Console.WriteLine($"{m}/{n} =");

        int parteInt, parteFract;
        parteInt = m / n;
        parteFract = m % n;
        Console.Write($"{parteInt},");
        int cifra, rest;
        List<int> resturi = new List<int>();
        List<int> cifre = new List<int>();
        resturi.Add(parteFract);
        bool periodic = false;
        do
        {
            cifra = parteFract * 10 / n;
            cifre.Add(cifra);

            rest = parteFract * 10 % n;
            if (!resturi.Contains(rest))
                resturi.Add(rest);

            else
            {
                periodic = true;
                break;
            }
            parteFract = rest;
        } while (rest != 0);

        if (!periodic)
            foreach (var item in cifre)
                Console.Write(item);


        else
        {
            for (int i = 0; i < resturi.Count; i++)
            {
                if (resturi[i] == rest)
                    Console.Write("(");

                Console.Write(cifre[i]);
            }
            Console.WriteLine(")");
        }

    }

    /// <summary>
    /// Ghiciti un numar intre 1 si 1024 prin intrebari de forma
    /// "numarul este mai mare sau egal decat x?". 
    /// </summary>
    static void P21()
    {
        bool guessed = false;

        int lower = 1;
        int mid = 512;
        int upper = 1025;
        while (!guessed)
        {

            Console.Write($"Numarul este mai mare sau egal decat {mid}? ");
            string answer = Console.ReadLine().ToLower();

            if (answer == "da")
                lower = mid;


            else if (answer == "nu")
                upper = mid;

            else
            {
                Console.WriteLine("Da sau nu");
                continue;
            }

            mid = (lower + upper) / 2;

            if (lower == mid)
                guessed = true;
        }
        Console.WriteLine($"Numarul este {lower}");
    }
}

