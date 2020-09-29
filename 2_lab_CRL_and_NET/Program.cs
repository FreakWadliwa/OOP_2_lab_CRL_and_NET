using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_lab_CRL_and_NET
{
    class Book
    {
        public string cost;
    }
    class Program
    {
       

        static void Main(string[] args)
        {
            (int, int, int, char) localfun(int[] local, string _char)
            {
                int max = 0, min = 0, sum = 0;
                for (int i = 0; i < local.Length; i++)
                {
                    sum += local[i];
                    if (max < local[i])
                        max = local[i];
                }
                for (int i = 0; i < local.Length; i++)
                {
                    if (min > local[i])
                        min = local[i];
                }
                var finallocalfun = (min, max, sum, _char[0]);
                return finallocalfun;
            }
            int _Checked()
            {
                checked
                {
                   int n = 2147483647;
                }
                return 0;
            }

            int _UnChecked()
            {
                unchecked
                {
                    int n = 2147483647;
                }
                return 0;
            }
            Console.WriteLine("select task");
            int choose = Convert.ToInt32(Console.ReadLine());
            switch (choose)
                {
                case 1:
                    Console.WriteLine("short");
                    short _short = Convert.ToInt16(Console.ReadLine());
                    Console.WriteLine("ushort");
                    ushort _ushort = Convert.ToUInt16(Console.ReadLine());
                    Console.WriteLine("long");
                    long _long = Convert.ToInt64(Console.ReadLine());
                    Console.WriteLine("ulong");
                    ulong _ulong = Convert.ToUInt64(Console.ReadLine());
                    Console.WriteLine("int");
                    int _int = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("uint");
                    uint _uint = Convert.ToUInt32(Console.ReadLine());
                    Console.WriteLine("float");
                    float _float = Convert.ToSingle(Console.ReadLine());
                    Console.WriteLine("double");
                    double _double = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("decimal");
                    decimal _decimal = Convert.ToDecimal(Console.ReadLine());
                    Console.WriteLine("char");
                    char _char = Convert.ToChar(Console.ReadLine());
                    Console.WriteLine("byte");
                    byte _byte = Convert.ToByte(Console.ReadLine());
                    Console.WriteLine("sbyte");
                    sbyte _sbyte = Convert.ToSByte(Console.ReadLine());
                    Console.WriteLine("bool");
                    bool _bool = Convert.ToBoolean(Console.ReadLine());
                    Console.WriteLine("string");
                    string _string = Console.ReadLine();
                    Book book1 = new Book();
                    Console.WriteLine("object");
                    book1.cost = Console.ReadLine();

                    Console.WriteLine(book1.cost);
                    Console.WriteLine("short: {0}  ushort: {1} \n long: {2} ulong: {3}\n int: {4} uint: {5}\n float: {6} double: {7}" +
                        "\ndecimal: {8} char: {9} \nbyte: {10} sbyte: {11} \nbool: {12} string: {13}", _short, _ushort, _long, _ulong,
                        _int, _uint, _float, _double, _decimal, _char, _byte, _sbyte, _bool, _string);
                    //Console.WriteLine("неявные преобразования");
                    short _toint1 = 12;
                    int _fromshort = _toint1;
                    
                    byte _toint2 = 12;
                    int _frombyte = _toint2;
                    
                    int _tofloat = 12;
                    float _fromint1 = _tofloat;
                   
                    int _todouble = 12;
                    double _fromint2 = _todouble;
                    
                    int _tolong = 12;
                    long _fromint3 = _tolong;
                    //2
                    int point = 6;
                    byte a1;
                    short a2;
                    uint a3;
                    a1 = (byte)point;
                    a2 = (short)point;
                    a3 = (uint)point;
                    //3
                    int box = 5;
                    object obj = box;     // присваивание сопровождается упаковкой
                    int Unbox = (int)obj; // приведение вызовет распаковку
                    //4
                    var _forinitial = 12;
                    var _forinitial2 = "pooop";
                    //5
                    bool? _null1 = null;
                    Nullable<bool> _null2 = null;
                    Console.WriteLine(_null1);
                    //6
                    var test1 = 15;
                    //test1 = "vlad";
                    break;
                case 2:
                    //1
                    string stra = "Tech";
                    string strb = "Art";
                    Console.WriteLine(string.Compare(stra, strb));
                    //2
                    string strc = "i";
                    string concat = String.Concat(strc, stra, strb);
                    Console.WriteLine(concat);
                    string _copy = String.Copy(concat);
                    Console.WriteLine(_copy);
                    string _insert1 = "И сметри нет почетней той,";
                    string _insert2 = "\nЧто ты принять готов";
                    int ind1 = _insert1.Length - 1;
                    _insert1 = _insert1.Insert(ind1, _insert2);
                    Console.WriteLine(_insert1);
                    string _split = "За кости пращуров своих";

                    string[] words = _split.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                    foreach (string splited in words)
                    {
                        Console.WriteLine(splited);
                    }
                    string _remove = "fuЗа храм своих боговf";
                    // индекс последнего символа
                    int ind2 = _remove.Length - 1;
                    // вырезаем последний символ
                    _remove = _remove.Remove(ind2);
                    // вырезаем первые два символа
                    _remove = _remove.Remove(0, 2);
                    Console.WriteLine(_remove);
                    long interpol = 33395390;
                    Console.WriteLine($"{interpol:+## ### ### ## ###}");
                    //3
                    string _null = null;
                    string _empty = "";
                    Console.WriteLine(String.IsNullOrEmpty(_null));
                    Console.WriteLine(String.IsNullOrEmpty(_empty));
                    Console.WriteLine(String.IsNullOrWhiteSpace(_null));
                    Console.WriteLine(String.IsNullOrWhiteSpace(_empty));
                    //4
                    StringBuilder _builder = new StringBuilder("I just wanna be");
                    _builder.Remove(7, 2);
                    _builder.Insert(1, "fuf ");
                    int ind3 = _builder.Length;
                    _builder.Insert(ind3, "fuf ");
                    Console.WriteLine(_builder);
                    break;
                case 3:
                    int[][] a = { new int[4] {1, 2, 3, 4 }, new int[4] {5, 6, 7, 8 }, new int[4] { 9, 10, 11, 12 } };
                    foreach (int[] x in a)
                    {
                        foreach (int b in x)
                            Console.Write("\t" + b);
                        Console.WriteLine();
                    }
                    string[] strmass = { "One" ,  "Two" , "three" };
                    foreach (var xx in strmass)
                        Console.Write("\t" + xx);
                    Console.WriteLine("Длина:");
                    Console.WriteLine(strmass.Length);
                    Console.WriteLine("выберите элемент");
                    int element = Convert.ToInt16(Console.ReadLine());
                    int i = 0;
                    foreach (var xxx in strmass)
                    {
                        i++;
                        if (i==element)
                        {
                            Console.WriteLine("Замена");
                            strmass[i] = Console.ReadLine();
                        }
                        Console.WriteLine("\t" + xxx);
                    }
                    //3
                    int[][] stepArr = new int[4][];
                    stepArr[0] = new int[4];
                    stepArr[1] = new int[6];
                    stepArr[2] = new int[3];
                    Console.WriteLine("Заполни матрицу");

                    for (int l = 0; l < 4; l++)
                    {
                        Console.Write("Первая строка");
                        int elem = Convert.ToInt32(Console.ReadLine());
                        stepArr[0][l] = elem;

                    }
                    for (int l = 0; l < 6; l++)
                    {
                        Console.Write("Вторая строка");
                        int elem = Convert.ToInt32(Console.ReadLine());
                        stepArr[1][l] = elem;

                    }
                    for (int l = 0; l < 3; l++)
                    {
                        Console.Write("Третья строка");
                        int elem = Convert.ToInt32(Console.ReadLine());
                        stepArr[2][l] = elem;

                    }



                    foreach (int[] row in stepArr)
                    {
                        foreach (int number in row)
                        {
                            Console.Write($"{number} \t");
                        }
                        Console.WriteLine();
                    }
                    Console.WriteLine();
                    // перебор с помощью цикла for
                    for (int l = 0; l < stepArr.Length; l++)
                    {
                        for (int j = 0; j < stepArr[i].Length; j++)
                        {
                            Console.Write($"{stepArr[l][j]} \t");
                        }
                        Console.WriteLine();
                    }
                    break;
                case 31:
                    //4
                    var tit = new Book[0];
                    var tut = "";

                    break;
                case 4:
                    //1
                    var _cort1 = (123, "Back", 'I', "Black", 18446744073709551615);
                    var _cort2 = (456, "Back", 'N', "Black", 18446744073709551615);
                    //2
                    Console.WriteLine($"{_cort1.Item1} {_cort1.Item3} {_cort1.Item4}");
                    Console.WriteLine($"{_cort1}");
                    //3
                    var (c1, o1, r1, t1, e1) = _cort1;
                    (var c2, var o2, var r2, var t2, var e2) = _cort1;
                    (int c3, string o3, char r3, string t3, ulong e3) = _cort1;
                    //4
                    if (_cort1 == _cort2)
                        Console.WriteLine("Равны");
                    else
                        Console.WriteLine("Не равны");
                    //5
                    int[] _cort = new[] { 1, 23, 4, 5, 6, 7, 8, 9, 0 };
                    Console.WriteLine(localfun(_cort, "Winter is coming"));

                    _Checked(); _UnChecked();
                    break;
            }
        }

        
    }
}
