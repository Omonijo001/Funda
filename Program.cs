using System;

namespace DAY1
{
    class Program
    {
        static void Main(string[] args)
        {
             
            // double num = 5.1; 
            // num = 5e9;
           // double num2 = (long) num;
            // int myInt = (int) num;
            // Console.WriteLine(myInt);

            // long myLong = long.MaxValue;
            // int ab = (int) myLong;
            // Console.WriteLine(ab);

            // int a = 3;
            // int b = 5;
            // int c = 7;
            // int nu = a + b + c;
            // int ad = nu;
            // Console.WriteLine(ad);

            // float heightInMeter = 1.74f;
            // double maxHeight = heightInMeter;
            // double minHeight = (double)heightInMeter;

            // int a = 10;
            // int b = 20;
            // string sum = "sum =" +(a + b);
            // Console.WriteLine(sum);



            // long x = 100000;
            // string a = x.ToString();
            // Console.WriteLine("my money is " + a);

            // STRING MANIPULATION,INTERPOLATION AND METHODS 

            // string a = "examination";
            // Console.WriteLine(a[1]);
            // Console.WriteLine(a[7]);
            // Console.WriteLine($"The second letter is {a[1]} and the second letter to the last letter is {a[9]}");


            // int age = 7;
            // string name = "ade";
            // Console.WriteLine($"My name is {name} and my age is {age}");

            // INDEX STRING
            // string a = "examination";
            // Console.WriteLine(a.Substring(5,6));

            // string s = "examination";
            // Console.WriteLine(s.IndexOf('x'));

            //string a = "the boy is good";
            //Console.WriteLine(a.IndexOf("is"));

            // string a = "the boy is good";
            // int b = a.IndexOf("is");
            // Console.WriteLine(b);

            // string a = "the boys is good";  
            // string y = a.Replace("is" , "are");
            // Console.WriteLine(y);         

            // string a = "manipulation";
            // string b = "ade go to school";
            // string c = "08034567893";
            // string d = "#";
            // string e = b.Replace("go","goes");
            // Console.WriteLine(a[4]);
            // Console.WriteLine(b.IndexOf("to"));
            // Console.WriteLine($"The third letter is {a[2]} , the last letter is {a[11]} and U is at index {a.IndexOf('u')}");
            // Console.WriteLine(e);
            // Console.WriteLine($"The above statement is wrong, the correct statement is {b.Replace("go","goes")} ");
            // Console.WriteLine(a.Substring(4,5));
            // Console.WriteLine(a.Substring(2,7));
            // Console.WriteLine(a.Substring(2,7).ToUpper());
            

            //STRING ESCAPING
            //    Console.WriteLine("The name of my school is \"CLH\"");
            //    Console.WriteLine("The name of my school is \t CLH");
            //   Console.WriteLine("The name of my school is \n CLH");
            //   Console.WriteLine("My best subject is \"MATH\"");


            //.ToUpper AND .ToLower
            // string a = "School";
            // string b = a.ToUpper();
            // Console.WriteLine(b);

            
            // Console.WriteLine("enter your password");
            // string input = "CLH";
            // string password = Console.ReadLine();
            // Console.WriteLine(input == password );
            // Console.WriteLine(input.ToUpper()== password.ToUpper());

            //.SPLIT
            // string a = "the boy goes to school";
            // string b = "excellence";
            // var c = a.Split(' ');
            // var d = b.Split('e');
            // Console.WriteLine(c[2]);
            // Console.WriteLine(d[2]);
            // Console.WriteLine(c[1][2]);

            //OPERATORS
            // ARITHEMETIC OPERATORS + - % / *
            // int a = 5;
            // int b = 6;
            // int c = ++a;
            // Console.WriteLine(a);
            // Console.WriteLine(c);

            // int a = 5;
            // int b = 6;
            // int c = a++;
            // Console.WriteLine(a);
            // Console.WriteLine(c);

            // int a = 5;
            // int b = 6;
            // int c = --a;
            // Console.WriteLine(a);
            // Console.WriteLine(c);

            // int a = 1;
            // int b = 5;
            // int c = a % b;
            // Console.WriteLine(a);
            // Console.WriteLine(c);


            // ASSIGNMENT OPERATORS += , -=,  %=,  /=, ,*=, ==

            // int a = 15;
            // int b = 6;
            // int c = a += b;
            // int d = a -= b;
            // Console.WriteLine(c);
            // Console.WriteLine(d);

            // int a = 15;
            // int b = 6;
            // int c = 10;
            // a += c += b += a;
            // Console.WriteLine(a);
            // Console.WriteLine(b);
            // Console.WriteLine(c);

            // int a = 15;
            // int b = 6;
            // int c = 10;
            // a /= a -= b *= c;
            // Console.WriteLine(a);
            // Console.WriteLine(b);
            // Console.WriteLine(c);

            // int a = 15;
            // int b = 6;
            // int c = 10;
            // b-=a/=a*= c;
            // Console.WriteLine(a);
            // Console.WriteLine(b);
            // Console.WriteLine(c);

            // int a = 15;
            // int b = 6;
            // int c = 10;
            // a -= c %= b += a;
            // Console.WriteLine(a);
            // Console.WriteLine(b);
            // Console.WriteLine(c);

            
            // COMPARISON OPERATORS   >, <, >= , <=, !=, ==
            // int a = 5;
            // int b = 6;
            // bool c = a>b;
            // Console.WriteLine(c);

            // int a = 5;
            // int b = 6;
            // bool c = a<b;
            // Console.WriteLine(c);

            // int a = 5;
            // int b = 6;
            // bool c = a == b;
            // Console.WriteLine(c);

            // int a = 5;
            // int b = 6;
            // bool c = a >= b;
            // Console.WriteLine(c);

            // int a = 5;
            // int b = 6;
            // bool c = a <= b;
            // Console.WriteLine(c);

            // int a = 5;
            // int b = 6;
            // bool c = a != b;
            // Console.WriteLine(c);


            //LOGICAL OPERATOR  &&, ||, !
            // bool check = true && true;
            // bool check1 = true && false;
            // bool check2 = false && true;
            // bool check3 = false && false;
            // Console.WriteLine(check);
            // Console.WriteLine(check1);
            // Console.WriteLine(check2);
            // Console.WriteLine(check3);

            // bool deck = true || true;
            // bool deck1 = true || false;
            // bool deck2 = false || true;
            // bool deck3 = false || false;
            // Console.WriteLine(deck);
            // Console.WriteLine(deck1);
            // Console.WriteLine(deck2);
            // Console.WriteLine(deck3);

            // string user = "joshua";
            // string pass = "josh";
            // Console.WriteLine("enter your username");
            // string username = Console.ReadLine();
            // if(username == user)
            // {
            //     Console.WriteLine("The username is correct");
            //     Console.WriteLine("enter your password");
            //     string password = Console.ReadLine();
            //     if(password == pass)
            //     {
            //         Console.WriteLine("the password is correct");
            //     }
            //     else
            //     {
            //         Console.WriteLine("incorrect password");
            //     }
                
            // }
            // else
            // {
            //     Console.WriteLine("incorrect username");
            // }

            // string user = "joshua";
            // string pass = "josh";
            // Console.WriteLine("enter your username");
            // string username = Console.ReadLine();
            // Console.WriteLine("enter your password");
            // string password = Console.ReadLine();
            // if((username == user)&&(password == pass))
            // {
            //     Console.WriteLine("true");
            // }
            // else
            // {
            //     Console.WriteLine("false");
            // }

           // Console.WriteLine(!true);

           //CONDITIONAL OPERATOR ?
           //int a = 5;
           //int b = 6;
           //int c = b>a ? b:a;
           //Console.WriteLine(c);


            //BITWISE OPERATORS  &, &=, ~, |, |=, ^, ^=
            // int a = 5;
            // int b = 3;
            // int c = a & b;
            // Console.WriteLine(c);

            // int a = 5;
            // int b = 3;
            // int c = a &= b;
            // Console.WriteLine(a);

            // int a = 5;
            // int b = 3;
            // int c = a | b;
            // Console.WriteLine(c);

            // int a = 5;
            // int b = 12;
            // int c = ~a;
            // Console.WriteLine(~a);

            // int a = 5;
            // int b = 3;
            // int c = a ^ b;
            // Console.WriteLine(c);

            // int a = 5;
            // int b = 3;
            // int c = a ^= b;
            // Console.WriteLine(c);



        }
    }
}
