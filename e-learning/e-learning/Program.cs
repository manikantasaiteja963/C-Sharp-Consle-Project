using elearning;
using System;
using System.Collections.Specialized;
using System.ComponentModel.Design;
using System.Net;
using System.Net.Mail;
using System.Net.NetworkInformation;
using System.Reflection.Metadata.Ecma335;
using System.Text.RegularExpressions;
using System.Xml;
using System.Xml.Linq;

namespace elearning
{
    public class courses : certificate
    {
        public static List<string> course = new List<string>();
        public static List<string> cid = new List<string>();
        public static List<int> totallessons = new List<int>();
        public static List<string> lessons = new List<string>();
        public static List<int> duration = new List<int>();
        public static List<string> assignments = new List<string>();

        public static int q, i;
        public static List<string> g = new List<string>();
        public static List<string> t = new List<string>();
        public static List<string> opt = new List<string>();
        public static List<string> correctoption = new List<string>();
        public static List<int> qn1 = new List<int>();
        public static List<int> passmarks = new List<int>();
        public void cc()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("Enter the course TITLE : ");
            Console.ForegroundColor = ConsoleColor.White;
            course.Add(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("Total course duration (in hrs) :");
            Console.ForegroundColor = ConsoleColor.White;
            duration.Add(Convert.ToInt32(Console.ReadLine()));
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("Enter total number of lessons in the course : ");
            Console.ForegroundColor = ConsoleColor.White;
            totallessons.Add(Convert.ToInt32(Console.ReadLine()));
            for (i = 0; i < totallessons[0];i++)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("Enter the lessons "+(i+1)+": ");
                Console.ForegroundColor = ConsoleColor.White;
                lessons.Add(Console.ReadLine());
            }
           
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Enter the ASSIGNMENTS : ");
            Console.Write("Total number of questions in the assignment : ");
            Console.ForegroundColor = ConsoleColor.White;
            q = Convert.ToInt32(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Enter the questions ");
            int h1 = 0;
            for (i = 1; i <= q; i++)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write(i + ". ");
                Console.ForegroundColor = ConsoleColor.Cyan;
                t.Add(Console.ReadLine());
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("\tEnter the options for the question " + i + " ");
                for (int j = 0; j < 4; j++)
                {

                    Console.Write("\t\t" + (j + 1) + " .  ");
                    Console.ForegroundColor = ConsoleColor.White;
                    opt.Add(Console.ReadLine());

                }
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Enter the correct option : ");
                Console.ForegroundColor = ConsoleColor.Green;
                correctoption.Add(Console.ReadLine());
            }
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Enter PASS MARKS : ");
            int o;
            Console.ForegroundColor = ConsoleColor.White;
            o = Convert.ToInt32(Console.ReadLine());
            passmarks.Add(o);
            Console.Clear();



            int count = 0;
            int h = 1;
            Console.WriteLine("You Entered questions are : ");
            for (i = 1; i <= q; i++)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine(t[i - 1]);
                count = 0;
                Console.ForegroundColor = ConsoleColor.Yellow;
                for (int j = h; j < opt.Count + 1; j++)
                {
                    Console.Write((count + 1) + " . " + opt[j - 1] + "\t");
                    count++;
                    if (count == 4)
                    {
                        Console.WriteLine();
                        break;
                    }


                }
                h += 4;

            }

            Console.Clear();



        }
    }
}
public class Learning : courses
{
    static string ab = "@gmail.com$";
    static string pin1 = "[1-6]";
    public static void Main(string[] args)
    {

        List<string> Afname = new List<string>();
        List<string> Alname = new List<string>();
        List<string> Agender = new List<string>();
        List<string> Aaddress = new List<string>();
        List<string> qualification = new List<string>();
        List<string> Amail = new List<string>();
        List<long> Aphone = new List<long>();
        List<int> Aage = new List<int>();
        List<int> exp = new List<int>();
        List<string> Aloginid = new List<string>();
        List<string> Apassword = new List<string>();

        List<string> studentoption = new List<string>();
        List<string> sfname = new List<string>();
        List<string> slname = new List<string>();
        List<string> suname = new List<string>();
        List<string> spass = new List<string>();
        List<string> sscourse = new List<string>();
        List<long> sphno = new List<long>();
        List<string> sgraduation = new List<string>();
        List<string> smail = new List<string>();
        List<string> sstate = new List<string>();
        List<string> svillage = new List<string>();
        List<string> spin = new List<string>();
        List<int> sage = new List<int>();
        List<string> sgender = new List<string>();


        int a, i = 0, choice, age, q, ct, a12, choice3, cno;
        long count, num, temp, ph;
        string b, c, d, e, f, g, pin, pin1, loginid, password, login, pass, lid, pw, id, ps, mail, maila, uname;
        int[] passmark = new int[20];

        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("------------------------------------------------------------------------------------------------------------------------------------------------------------");
        Console.WriteLine("                                                               WELCOME TO OUR E-LEARNING PLATFORM                                          ");
        Console.WriteLine("------------------------------------------------------------------------------------------------------------------------------------------------------------");
    w:
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("Are you ADMIN or USER : ");
        Console.WriteLine("1.ADMIN \n2.USER \n3.DETAILS");
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("\n");
        a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine();
        Console.Clear();
        if (a == 1)
        {

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("                                                                 WELCOME TO ADMIN DASHBOARD     \n");

            Console.WriteLine();
         kl:  Console.WriteLine("ARE YOU ALREADY AN EXISTING PERSON.....[yes/no]");
            Console.ForegroundColor = ConsoleColor.White;
            b = Console.ReadLine();
        E:
            if (b == "no")
            {

            y:
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Do want register[yes/no] : ");
                Console.ForegroundColor = ConsoleColor.White;
                c = Console.ReadLine();
                Console.WriteLine();
                if (c == "yes")
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Enter your name : ");
                    Console.Write("\tfirst name                              : ");
                    Console.ForegroundColor = ConsoleColor.White;
                    Afname.Add(Console.ReadLine());
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write("\tlast name                               : ");

                    Console.ForegroundColor = ConsoleColor.White;
                    Alname.Add(Console.ReadLine());
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine();
                    Console.Write("Enter your gender                               : ");
                    Console.ForegroundColor = ConsoleColor.White;
                    Agender.Add(Console.ReadLine());
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine();
                A: Console.Write("Enter your age                                  : ");
                    Console.ForegroundColor = ConsoleColor.White;
                    age = Convert.ToInt32(Console.ReadLine());
                    if ((age <= 20) || (age >= 100))
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("You are not eligible to give lessons.....");
                        Console.WriteLine("Please enter valid age\n");
                        Console.ForegroundColor = ConsoleColor.White;
                        goto A;
                    }
                    Aage.Add(age);
                    Console.WriteLine();
                x:
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write("Enter your phone number                         : ");
                    Console.ForegroundColor = ConsoleColor.White;
                    num = Convert.ToInt64(Console.ReadLine());
                    temp = num;
                    count = 0;
                    while (temp != 0)
                    {
                        count = count + 1;
                        temp = temp / 10;
                    }
                    if (count != 10)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Please enter a valid number.....");
                        goto x;
                    }
                    Aphone.Add(num);
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.Yellow;

                X: Console.Write("Enter your mail id                              : ");
                    Regex re = new Regex(ab);
                    Console.ForegroundColor = ConsoleColor.White;
                    maila = Console.ReadLine();
                    if (re.IsMatch(maila))
                    {
                        Amail.Add(maila);
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Please eneter a valid format....");
                        Console.ForegroundColor = ConsoleColor.White;
                        goto X;
                    }
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine();
                    Console.Write("Enter your address                              : ");
                    Console.ForegroundColor = ConsoleColor.White;
                    Aaddress.Add(Console.ReadLine());
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine();
                    Console.Write("Enter your Qualification                        : ");
                    Console.ForegroundColor = ConsoleColor.White;
                    qualification.Add(Console.ReadLine());
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write("How many years of experience do you have        : ");
                    Console.ForegroundColor = ConsoleColor.White;
                    exp.Add(Convert.ToInt32(Console.ReadLine()));
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("Thank you");
                    //Console.WriteLine("Moving to homepage");
                    Thread.Sleep(2000);
                    Console.WriteLine();
                    Console.Write("Create your LOGIN ID : ");
                    Console.ForegroundColor = ConsoleColor.White;
                    loginid = Console.ReadLine();
                    Aloginid.Add(loginid);
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.Write("Create  your LOGIN password : ");
                    Console.ForegroundColor = ConsoleColor.White;
                    password = Console.ReadLine();
                    Apassword.Add(password);
                    //goto w;

                    Console.Clear();
                O:
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Do you want to login [yes/no] : ");
                    Console.ForegroundColor = ConsoleColor.White;
                    d = Console.ReadLine();
                    Console.Clear();
                    if (d == "yes")
                    {

                    z:
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("Welcome to admin login page\n\n");
                        Console.Write("Enter your LOGIN ID : ");
                        Console.ForegroundColor = ConsoleColor.White;
                        login = Console.ReadLine();
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write("Enter password : ");
                        Console.ForegroundColor = ConsoleColor.White;
                        pass = Console.ReadLine();
                        Console.Clear();
                        ct = 0;
                        for (i = 0; i < Aloginid.Count; i++)
                        {
                            if ((login == Aloginid[i]) && (pass == Apassword[i]))
                            {
                                ct = 1;
                                break;
                            }
                        }
                        if (ct == 1)
                        {

                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine("YOU HAVE LOGGED IN SUCCESSFULLY.....");
                            Thread.Sleep(1000);
                            Console.ForegroundColor = ConsoleColor.White;
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("SORRY!...Incorrect credentials");
                            Console.WriteLine("Please try again");
                            goto z;

                        }

                    v:
                        Console.WriteLine();
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("1.Create Course \n2.Update Details \n3.Delete \n4.Exit");
                        Console.Write("Enter your choice : ");
                        Console.ForegroundColor = ConsoleColor.White;
                        choice = Convert.ToInt32(Console.ReadLine());
                        if (choice == 1)
                        {
                            courses obg = new courses();
                            obg.cc();
                            goto v;
                        }
                        else if (choice == 2)
                        {
                            for (i = 0; i < Afname.Count; i++)
                            {
                                if (login == Aloginid[i] && pass == Apassword[i])
                                {
                                    Console.ForegroundColor = ConsoleColor.Cyan;
                                    Console.WriteLine("\t\t\t PERSONAL DETAILS ");
                                    Console.WriteLine("NAME          : " + Afname[i] + " " + Alname[i]);
                                    Console.WriteLine("AGE           : " + Aage[i]);
                                    Console.WriteLine("GENDER        : " + Agender[i]);
                                    Console.WriteLine("PHONE NUMBER  : " + Aphone[i]);
                                    Console.WriteLine("E-MAIL        : " + Amail[i]);
                                    Console.WriteLine("ADDRESS       : " + Aaddress[i]);
                                    Console.WriteLine("QUALIFICATION : " + qualification[i]);
                                    Console.WriteLine("Experience    : " + exp[i]);
                                    Console.WriteLine();


                                M:
                                    Console.ForegroundColor = ConsoleColor.Yellow;
                                    Console.WriteLine("Do you have any changes [yes/no] ? ");
                                    Console.ForegroundColor = ConsoleColor.White;
                                    e = Console.ReadLine();
                                    if (e == "yes")
                                    {
                                        Console.Clear();
                                        Console.ForegroundColor = ConsoleColor.Yellow;
                                        Console.WriteLine();
                                        Console.WriteLine("WHAT DO YOU WANT TO UPDATE ?");
                                        Console.ForegroundColor = ConsoleColor.Cyan;
                                        Console.WriteLine();
                                        Console.WriteLine("1.FIRST NAME \n2.LAST NAME \n3.AGE \n4.GENDER \n5.PHONE NUMBER \n6.MAIL ID \n7.ADDRESS \n8.QUALIFICATION \n9.EXPERIENCE \n10.Updates");
                                    N:
                                        Console.WriteLine();
                                        Console.ForegroundColor = ConsoleColor.Yellow;
                                        Console.Write("ENTER YOUR CHOICE : ");
                                        Console.ForegroundColor = ConsoleColor.White;
                                        int k;
                                        k = Convert.ToInt32(Console.ReadLine());
                                        Console.WriteLine();
                                        if (k == 1)
                                        {
                                            Console.ForegroundColor = ConsoleColor.Yellow;
                                            Console.Write("FIRST NAME : ");
                                            Console.ForegroundColor = ConsoleColor.White;
                                            Afname[i] = Console.ReadLine();
                                        }
                                        else if (k == 2)
                                        {
                                            Console.ForegroundColor = ConsoleColor.Yellow;
                                            Console.Write("LAST NAME : ");
                                            Console.ForegroundColor = ConsoleColor.White;
                                            Alname[i] = Console.ReadLine();
                                        }
                                        else if (k == 3)
                                        {
                                            Console.ForegroundColor = ConsoleColor.Yellow;
                                            Console.Write("AGE : ");
                                            Console.ForegroundColor = ConsoleColor.White;
                                            Aage[i] = Convert.ToInt32(Console.ReadLine());
                                        }
                                        else if (k == 4)
                                        {
                                            Console.ForegroundColor = ConsoleColor.Yellow;
                                            Console.Write("GENDER : ");
                                            Console.ForegroundColor = ConsoleColor.White;
                                            Agender[i] = Console.ReadLine();
                                        }
                                        else if (k == 5)
                                        {
                                        P:
                                            Console.ForegroundColor = ConsoleColor.Yellow;
                                            Console.Write("PHONE NUMBER : ");
                                            Console.ForegroundColor = ConsoleColor.White;
                                            ph = Convert.ToInt64(Console.ReadLine());
                                            temp = ph;
                                            count = 0;
                                            while (temp != 0)
                                            {
                                                count = count + 1;
                                                temp = temp / 10;
                                            }
                                            if (count != 10)
                                            {
                                                Console.ForegroundColor = ConsoleColor.Red;
                                                Console.WriteLine("Please enter a valid number.....");
                                                goto P;
                                            }
                                            Aphone[i] = Convert.ToInt64(Console.ReadLine());
                                        }
                                        else if (k == 6)
                                        {
                                        Q:
                                            Console.ForegroundColor = ConsoleColor.Yellow;
                                            Console.Write("MAIL ID : ");
                                            Regex er = new Regex(ab);
                                            Console.ForegroundColor = ConsoleColor.White;
                                            maila = Console.ReadLine();
                                            if (er.IsMatch(maila))
                                            {
                                                Amail[i] = maila;
                                            }
                                            else
                                            {
                                                Console.ForegroundColor = ConsoleColor.Red;
                                                Console.WriteLine("Please eneter a valid format....");
                                                goto Q;
                                            }
                                        }
                                        else if (k == 7)
                                        {
                                            Console.ForegroundColor = ConsoleColor.Yellow;
                                            Console.Write("ADDRESS : ");
                                            Console.ForegroundColor = ConsoleColor.White;
                                            Aaddress[i] = Console.ReadLine();
                                        }
                                        else if (k == 8)
                                        {
                                            Console.ForegroundColor = ConsoleColor.Yellow;
                                            Console.Write("QUALIFICATION : ");
                                            Console.ForegroundColor = ConsoleColor.White;
                                            qualification[i] = Console.ReadLine();
                                        }
                                        else if (k == 9)
                                        {
                                            Console.ForegroundColor = ConsoleColor.Yellow;
                                            Console.Write("EXPERIENCE : ");
                                            Console.ForegroundColor = ConsoleColor.White;
                                            exp[i] = Convert.ToInt32(Console.ReadLine());
                                        }
                                        else if (k == 10)
                                        {
                                            goto M;
                                        }
                                        else
                                        {
                                            Console.ForegroundColor = ConsoleColor.Red;
                                            Console.WriteLine("YOU HAVE ENTERED A INVALID CHOICE....");
                                            Console.WriteLine("Enter a valid choice[1-10]...");
                                            Console.ForegroundColor = ConsoleColor.White;
                                            goto N;
                                        }
                                    }
                                    else if (e == "no")
                                    {
                                        Console.ForegroundColor = ConsoleColor.Cyan;
                                        Console.WriteLine("THANK YOU");
                                    }
                                    else
                                    {
                                        Console.ForegroundColor = ConsoleColor.Red;
                                        Console.WriteLine("YOU HAVE ENTERED A INVALID STRING....");
                                        Console.WriteLine("PLEASE ENTER ONLY YES OR NO....");
                                    }
                                    goto v;
                                }
                            }
                        }
                        else if (choice==3)
                        {
                            Console.WriteLine("Deletion ");
                            int M;
                           H:    M =Convert.ToInt32(Console.ReadLine());
                            if(M==1)
                            {
                                Afname[i] = null;
                                Alname[i] = null;
                                Aage[i] = 0;
                                Agender[i] = null;
                                Aphone[i] = 0;
                                Amail[i] = null;
                                Aaddress[i] = null;
                                qualification[i] = null;
                                exp[i] = 0;
                                Console.WriteLine("THE DETAILS ARE DELETED ");
                                goto v;
                            }
                            else
                            {
                                Console.WriteLine("Enter  only 1");
                                goto H;
                            }


                        }
                        else if (choice == 4)
                        {
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine(" Do you want to  go HOME [yes/no]");
                            Console.ForegroundColor = ConsoleColor.White;
                            f = Console.ReadLine();
                            if (f == "yes")
                            {
                                goto w;

                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.Cyan;
                                Console.WriteLine("THANK YOU");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Please Enter  a valid number.");
                            goto v;
                        }
                    }
                    else if (d == "no")
                    {
                        goto w;
                    }
                    else
                    {
                        Console.WriteLine("You have entered worng string");
                        Console.WriteLine("Please Enter only YES or NO.");
                        goto O;
                    }
                }
                else if (c == "no")
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Thankyou! and visit again... ");
                    Console.WriteLine("Moving to homepage...");
                    Thread.Sleep(2000);
                    Console.Clear();
                    goto w;
                }

                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("You have entered a wrong entry ");
                    Console.WriteLine("Please enter a valid string");
                    goto y;
                }
            }
            else if (b == "yes")
            {
                Console.WriteLine();
                if (Aloginid.Count == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("Sorry!.....You have not registred YET \n Please Register first.");
                    Console.WriteLine("Moving to Main Menu.....");
                    Thread.Sleep(2000);
                    b = "no";
                    goto E;

                }
            B:
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Enter LOGIN ID and Password  to LOGIN : ");
                Console.Write("LOGIN ID : ");
                Console.ForegroundColor = ConsoleColor.White;
                lid = Console.ReadLine();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("Password : ");
                Console.ForegroundColor = ConsoleColor.White;
                pw = Console.ReadLine();
                ct = 0;
                for (i = 0; i < Aloginid.Count; i++)
                {
                    if ((lid == Aloginid[i]) && (pw == Apassword[i]))
                    {
                        ct = 1;
                        break;
                    }
                }
                if (ct == 1)
                {
                    Thread.Sleep(1000);
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("You have logged in successfully.....");
                    Thread.Sleep(2000);
                    Console.WriteLine();
                D: Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("1.Create Course \n2.Update  Details \n3.Main Menu");
                    Console.Write("Enter your choice : ");
                    Console.ForegroundColor = ConsoleColor.White;
                    choice = Convert.ToInt32(Console.ReadLine());
                    if (choice == 1)
                    {
                        courses obg = new courses();
                        obg.cc();
                    }
                    else if (choice == 2)
                    {
                        for (i = 0; i < Afname.Count; i++)
                        {
                            if (lid == Aloginid[i] && pw == Apassword[i])
                            {
                                Console.ForegroundColor = ConsoleColor.Yellow;
                                Console.WriteLine("\t\t\t PERSONAL DETAILS ");
                                Console.WriteLine("NAME          : " + Afname[i] + " " + Alname[i]);
                                Console.WriteLine("AGE           : " + Aage[i]);
                                Console.WriteLine("GENDER        : " + Agender[i]);
                                Console.WriteLine("PHONE NUMBER  : " + Aphone[i]);
                                Console.WriteLine("E-MAIL        : " + Amail[i]);
                                Console.WriteLine("ADDRESS       : " + Aaddress[i]);
                                Console.WriteLine("QUALIFICATION : " + qualification[i]);
                                Console.WriteLine("Experience    : " + exp[i]);
                                Console.WriteLine();
                                Console.WriteLine();
                            C: Console.ForegroundColor = ConsoleColor.Yellow;
                                Console.WriteLine("Do you have any changes [yes/no] ? ");
                                Console.ForegroundColor = ConsoleColor.White;
                                e = Console.ReadLine();
                                Thread.Sleep(1000);
                                if (e == "yes")
                                {
                                    Console.Clear();
                                    Console.ForegroundColor = ConsoleColor.Yellow;
                                    Console.WriteLine("WHAT DO YOU WANT TO UPDATE ?");
                                    Console.WriteLine("1.FIRST NAME \n2.LAST NAME \n3.AGE \n4.GENDER \n5.PHONE NUMBER \n6.MAIL ID \n7.ADDRESS \n8.QUALIFICATION \n9.EXPERIENCE \n10.EXIT");
                                    Console.WriteLine();
                                F: Console.ForegroundColor = ConsoleColor.Yellow;
                                    Console.Write("ENTER YOUR CHOICE : ");
                                    Console.ForegroundColor = ConsoleColor.White;
                                    int k;
                                    k = Convert.ToInt32(Console.ReadLine());
                                    Console.WriteLine();
                                    Thread.Sleep(500);
                                    if (k == 1)
                                    {
                                        Console.ForegroundColor = ConsoleColor.Yellow;
                                        Console.Write("FIRST NAME : ");
                                        Console.ForegroundColor = ConsoleColor.White;
                                        Afname[i] = Console.ReadLine();
                                    }
                                    else if (k == 2)
                                    {
                                        Console.ForegroundColor = ConsoleColor.Yellow;
                                        Console.Write("LAST NAME : ");
                                        Console.ForegroundColor = ConsoleColor.White;
                                        Alname[i] = Console.ReadLine();
                                    }
                                    else if (k == 3)
                                    {
                                        Console.ForegroundColor = ConsoleColor.Yellow;
                                        Console.Write("AGE : ");
                                        Console.ForegroundColor = ConsoleColor.White;
                                        Aage[i] = Convert.ToInt32(Console.ReadLine());
                                    }
                                    else if (k == 4)
                                    {
                                        Console.ForegroundColor = ConsoleColor.Yellow;
                                        Console.Write("GENDER : ");
                                        Console.ForegroundColor = ConsoleColor.White;
                                        Agender[i] = Console.ReadLine();
                                    }
                                    else if (k == 5)
                                    {
                                    P:
                                        Console.ForegroundColor = ConsoleColor.Yellow;
                                        Console.Write("PHONE NUMBER : ");
                                        Console.ForegroundColor = ConsoleColor.White;
                                        ph = Convert.ToInt64(Console.ReadLine());
                                        temp = ph;
                                        count = 0;
                                        while (temp != 0)
                                        {
                                            count = count + 1;
                                            temp = temp / 10;
                                        }
                                        if (count != 10)
                                        {
                                            Console.ForegroundColor = ConsoleColor.Red;
                                            Console.WriteLine("Please enter a valid number.....");
                                            goto P;
                                        }
                                        Aphone[i] = Convert.ToInt64(Console.ReadLine());
                                    }
                                    else if (k == 6)
                                    {
                                    Q:
                                        Console.ForegroundColor = ConsoleColor.Yellow;
                                        Console.Write("MAIL ID : ");
                                        Regex er = new Regex(ab);
                                        Console.ForegroundColor = ConsoleColor.White;
                                        maila = Console.ReadLine();
                                        if (er.IsMatch(maila))
                                        {
                                            Amail[i] = maila;
                                        }
                                        else
                                        {
                                            Console.ForegroundColor = ConsoleColor.Red;
                                            Console.WriteLine("Please eneter a valid format....");
                                            goto Q;
                                        }
                                    }
                                    else if (k == 7)
                                    {
                                        Console.ForegroundColor = ConsoleColor.Yellow;
                                        Console.Write("ADDRESS : ");
                                        Console.ForegroundColor = ConsoleColor.White;
                                        Aaddress[i] = Console.ReadLine();
                                    }
                                    else if (k == 8)
                                    {
                                        Console.ForegroundColor = ConsoleColor.Yellow;
                                        Console.Write("QUALIFICATION : ");
                                        Console.ForegroundColor = ConsoleColor.White;
                                        qualification[i] = Console.ReadLine();
                                    }
                                    else if (k == 9)
                                    {
                                        Console.ForegroundColor = ConsoleColor.Yellow;
                                        Console.Write("EXPERIENCE : ");
                                        Console.ForegroundColor = ConsoleColor.White;
                                        exp[i] = Convert.ToInt32(Console.ReadLine());
                                    }
                                    else if (k == 10)
                                    {
                                        goto C;
                                    }
                                    else
                                    {
                                        Console.ForegroundColor = ConsoleColor.Red;
                                        Console.WriteLine("You have entered a invalid choice....");
                                        Console.WriteLine("Enter a valid choice[1-10]...");
                                        Console.ForegroundColor = ConsoleColor.White;
                                        goto F;

                                    }

                                }
                                else if (e == "no")
                                {
                                    Console.ForegroundColor = ConsoleColor.Cyan;
                                    Console.WriteLine("THANK YOU");
                                }
                                else
                                {
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("You have Entered a Invalid string...");
                                    Console.WriteLine("Please enter only yes or no....");

                                }
                                goto D;
                            }
                        }
                    }
                    else if (choice == 3)
                    {

                        goto w;
                    }
                    else
                    {
                        Console.WriteLine("Please enter a valid number");
                        goto D;
                    }
                }

               


            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("SORRY!...Incorrect credentials\n");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("Please enter only ");
                Console.ForegroundColor= ConsoleColor.Cyan;
                Console.Write("yes ");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("or");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine(" no");
                Console.ForegroundColor = ConsoleColor.Yellow;


                goto kl;
            }
        }
        else if (a == 2) 
        {
        HOME:
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("                                                                 WELCOME TO USER DASHBOARD     \n");
            Console.WriteLine(" SELECT COURSE FROM THE BELOW LIST      ");
            Console.WriteLine();
            for (int x = 0; x < course.Count; x++)
            {
                Console.WriteLine(course[x]);
            }

            Console.WriteLine("ARE YOU INTRESTED TO JOIN OUR COURSES");
        home2:
            Console.WriteLine();
            Console.WriteLine("1.SIGN UP    2.LOG IN    ");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.White;
            choice = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("");
            Console.Clear();
            Console.WriteLine();

            if (choice == 1)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("FILL THE BELOW DETAILS ");
                Console.WriteLine();
                Console.WriteLine("ENTER YOUR NAME : ");
                Console.Write("\t FIRST NAME     :");
                Console.ForegroundColor = ConsoleColor.White;
                sfname.Add(Console.ReadLine());
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine();
                Console.Write("\t LAST NAME      :");
                Console.ForegroundColor = ConsoleColor.White;
                slname.Add(Console.ReadLine());
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("ENTER YOUR AGE       :");
                sage.Add(Convert.ToInt32(Console.ReadLine()));
                Console.ForegroundColor = ConsoleColor.White;

                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("ENTER YOUR GENDER    :");
                sgender.Add(Console.ReadLine());
                Console.WriteLine();
                Console.Write("ENTER USER NAME      :");
                Console.ForegroundColor = ConsoleColor.White;
                suname.Add(Console.ReadLine());
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("SET NEW PASSWORD     :");
                Console.ForegroundColor = ConsoleColor.White;
                spass.Add(Console.ReadLine());
                Console.WriteLine();
            T:
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("ENTER PHNONE NUMBER  :");
                Console.ForegroundColor = ConsoleColor.White;
                ph = Convert.ToInt64(Console.ReadLine());
                temp = ph;
                count = 0;
                while (temp != 0)
                {
                    count = count + 1;
                    temp = temp / 10;
                }
                if (count != 10)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Please enter a valid number.....");
                    goto T;
                }
                sphno.Add(ph);
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("ENTER YOUR GRADUATION:");
                Console.ForegroundColor = ConsoleColor.White;
                sgraduation.Add(Console.ReadLine());
                Console.WriteLine();
            a:
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("ENTER YOUR MAIL      :");
                Console.ForegroundColor = ConsoleColor.White;
                mail = Console.ReadLine();
                Console.WriteLine();
                Regex re = new Regex(ab);
                if (re.IsMatch(mail))
                {
                    smail.Add(mail);
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("PLEASE! ENTER VALID FORM.....");
                    Console.WriteLine();
                    goto a;
                }
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("ENTER   YOUR STATE   :");
                Console.ForegroundColor = ConsoleColor.White;
                sstate.Add(Console.ReadLine());
                Console.WriteLine();
            pi:
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("ENTER PIN CODE       :");
                Console.ForegroundColor = ConsoleColor.White;
                pin = Console.ReadLine();
                Regex re2 = new Regex(pin);
                if (re2.IsMatch(pin))
                {
                    spin.Add(pin);
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("INCORRECT FORMAT RETRY :)");
                    goto pi;
                }
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("ENTER YOUR CITY   :");
                Console.ForegroundColor = ConsoleColor.White;
                svillage.Add(Console.ReadLine());
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write("-------------YOUR REGISTRATION IS COMPLETED--------------");
                Thread.Sleep(1500);
                Console.Clear();
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("SELECT YOUR COURSE   :");
                for (int x = 0; x < course.Count; x++)
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine(course[x]);
                }
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Enter Which  course do  you want to learn : ");
                string n;
                Console.ForegroundColor = ConsoleColor.White;
                n = (Console.ReadLine());
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("You Selected  " + n + "  course");
                Console.WriteLine();
                Console.WriteLine("LESSONS IN THE COURSE ");
                for (i = 0; i < totallessons[0]; i++)
                {
                    Console.WriteLine(lessons[i]);
                }

                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine(" course details   : ");
                int cor;
                cor = course.Count;


                for (int x = 0; x < cor; x++)
                {

                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("The course TITLE               : " + course[x]);
                    Console.WriteLine();
                    Console.WriteLine("Total course duration (in hrs) :" + duration[x]);
                    Console.WriteLine();
                    Console.WriteLine("The lessons are               : " + lessons[x]);


                }
                goto home2;



            }
            else if (choice == 2)
            {
            uname:
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("ENTER USER NAME : ");
                Console.ForegroundColor = ConsoleColor.White;
                uname = Console.ReadLine();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("ENTER PASSWORD  : ");
                Console.ForegroundColor = ConsoleColor.White;
                pass = Console.ReadLine();
                Console.Clear();
                int cl = 0;
                for (i = 0; i < suname.Count; i++)
                {
                    if ((uname == suname[i]) && (pass == spass[i]))
                    {
                        cl = 1; break;

                    }

                }
                if (cl == 1)
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("YOU HAVE LOGGED IN SUCCESSFULLY  ");
                    for (int x = 0; x < sscourse.Count; x++)
                    {
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine(sscourse[x]);
                    }
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("INCORRECT CREDENTIALS ");
                    Console.WriteLine("Try again OR Register");
                    Thread.Sleep(300);
                    Console.Clear();
                    goto home2;

                }
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine(" course details   : ");
                int cor;
                cor = course.Count;


                for (int x = 0; x < cor; x++)
                {

                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("The course TITLE               : " + course[x]);
                    Console.WriteLine();
                    Console.WriteLine("Total course duration (in hrs) :" + duration[x]);
                    Console.WriteLine();
                    Console.WriteLine("The lessons are               : " + lessons[x]);


                }
                G:
                Console.ForegroundColor= ConsoleColor.Yellow;
                Console.WriteLine(" 1.TAKE TEST \n 2.GOTO HOME \n3.VIEW DETAILS \n5.DELETION \n4.Exit");

                Console.ForegroundColor = ConsoleColor.White;
                choice3 = Convert.ToInt32(Console.ReadLine());
                Thread.Sleep(1000);
                /*Console.Clear();*/
                Console.WriteLine();
                if (choice3 == 1)
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("PASS MARK FOR TEST " + passmarks[0]);
                    count = 0;
                    int h = 0;
                    Console.WriteLine();
                    for (i = 0; i < t.Count(); i++)
                    {
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write((i + 1));
                        Console.WriteLine(t[i]);
                        count = 0;
                        for (int j = h; j < opt.Count() && count < 4; j++)
                        {
                            Console.WriteLine((count + 1) + " . " + opt[j] + "\t");
                            count++;
                        }
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("ENTER YOUR OPTION");
                        studentoption.Add(Console.ReadLine());
                        h += 4;
                    }
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine("OPTIONS ARE RECORDED ");
                    count = 0;

                    for (i = 0; i < correctoption.Count && i < studentoption.Count; i++)
                    {
                        if (correctoption[i] == studentoption[i])
                        {
                            count++;
                        }
                    }
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("your marks" + count);
                    if (count >= passmark[0])
                    {
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("CONGRATULATIONS YOU ARE PASSED IN THE TEST");
                        certificate obj = new certificate();
                        obj.certify();
                        Console.ForegroundColor = ConsoleColor.Yellow;
                    ac: Console.WriteLine("CLICK 1 TO  TO HOME");
                        Console.ForegroundColor = ConsoleColor.White;
                        choice = Convert.ToInt32(Console.ReadLine());
                        if (choice == 1)
                        {
                            goto w;
                        }
                        else
                        {
                            Console.WriteLine("Enter a valid number");
                            goto ac;
                        }
                    }
                }
                else if (choice3 == 2)
                {
                    goto HOME;
                }
                else if (choice3 == 3)
                {
                    for (i = 0; i < suname.Count; i++)
                    {
                        if (uname == suname[i] && pass == spass[i])
                        {
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine("\t\t\t PERSONAL DETAILS ");
                            Console.WriteLine(" FIRST NAME  :" + sfname[i]);
                            Console.WriteLine();
                            Console.WriteLine("LAST NAME    :" + slname[i]);
                            Console.WriteLine();
                            Console.WriteLine("AGE          :" + sage[i]);
                            Console.WriteLine();
                            Console.WriteLine("GENDER       :" + sgender[i]);
                            Console.WriteLine();
                            Console.WriteLine("USER NAME    :" + suname[i]);
                            Console.WriteLine();
                            Console.WriteLine("COURSE       :" + sscourse[i]);
                            Console.WriteLine();
                            Console.WriteLine("CONTACT      :" + sphno[i]);
                            Console.WriteLine();
                            Console.WriteLine("GRADUATION   :" + sgraduation[i]);
                            Console.WriteLine();
                            Console.WriteLine("MAIL         :" + smail[i]);
                            Console.WriteLine();
                            Console.WriteLine("STATE        :" + sstate[i]);
                            Console.WriteLine();
                            Console.WriteLine("PIN CODE     :" + spin[i]);
                            Console.WriteLine();
                            Console.WriteLine("VILLAGE      :" + svillage[i]);
                            Console.WriteLine();
                            goto G;
                        ab: Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine("Do you have any changes [yes/no] ? ");
                            Console.ForegroundColor = ConsoleColor.White;
                            e = Console.ReadLine();
                            Thread.Sleep(1000);
                            if (e == "yes")
                            {
                                Console.Clear();
                                Console.ForegroundColor = ConsoleColor.Yellow;
                                Console.WriteLine("WHAT DO YOU WANT TO UPDATE ?");
                                Console.WriteLine("1.FIRST NAME \n2.LAST NAME \n3.AGE \n4.GENDER \n5.PHONE NUMBER \n6.MAIL ID \n7.VILLAGE \n8.STATE \n9.GRADUATION \n3.EXIT");
                                Console.WriteLine();
                            bc: Console.ForegroundColor = ConsoleColor.Yellow;
                                Console.Write("ENTER YOUR CHOICE : ");
                                Console.ForegroundColor = ConsoleColor.White;
                                int k;
                                k = Convert.ToInt32(Console.ReadLine());
                                Console.WriteLine();
                                Thread.Sleep(500);
                                if (k == 1)
                                {
                                    Console.ForegroundColor = ConsoleColor.Yellow;
                                    Console.Write("FIRST NAME : ");
                                    Console.ForegroundColor = ConsoleColor.White;
                                    sfname[i] = Console.ReadLine();
                                }
                                else if (k == 2)
                                {
                                    Console.ForegroundColor = ConsoleColor.Yellow;
                                    Console.Write("LAST NAME : ");
                                    Console.ForegroundColor = ConsoleColor.White;
                                    slname[i] = Console.ReadLine();
                                }
                                else if (k == 3)
                                {
                                    Console.ForegroundColor = ConsoleColor.Yellow;
                                    Console.Write("AGE : ");
                                    Console.ForegroundColor = ConsoleColor.White;
                                    sage[i] = Convert.ToInt32(Console.ReadLine());
                                }
                                else if (k == 4)
                                {
                                    Console.ForegroundColor = ConsoleColor.Yellow;
                                    Console.Write("GENDER : ");
                                    Console.ForegroundColor = ConsoleColor.White;
                                    sgender[i] = Console.ReadLine();
                                }
                                else if (k == 5)
                                {
                                J:
                                    Console.ForegroundColor = ConsoleColor.Yellow;
                                    Console.Write("PHONE NUMBER : ");
                                    Console.ForegroundColor = ConsoleColor.White;
                                    ph = Convert.ToInt64(Console.ReadLine());
                                    temp = ph;
                                    count = 0;
                                    while (temp != 0)
                                    {
                                        count = count + 1;
                                        temp = temp / 10;
                                    }
                                    if (count != 10)
                                    {
                                        Console.ForegroundColor = ConsoleColor.Red;
                                        Console.WriteLine("Please enter a valid number.....");
                                        goto J;
                                    }
                                    sphno[i] = Convert.ToInt64(Console.ReadLine());
                                }
                                else if (k == 6)
                                {
                                W:
                                    Console.ForegroundColor = ConsoleColor.Yellow;
                                    Console.Write("MAIL ID : ");
                                    Regex er = new Regex(ab);
                                    Console.ForegroundColor = ConsoleColor.White;
                                    maila = Console.ReadLine();
                                    if (er.IsMatch(maila))
                                    {
                                        smail[i] = maila;
                                    }
                                    else
                                    {
                                        Console.ForegroundColor = ConsoleColor.Red;
                                        Console.WriteLine("Please eneter a valid format....");
                                        goto W;
                                    }
                                }
                                else if (k == 7)
                                {
                                    Console.ForegroundColor = ConsoleColor.Yellow;
                                    Console.Write("VILLAGE : ");
                                    Console.ForegroundColor = ConsoleColor.White;
                                    svillage[i] = Console.ReadLine();
                                }
                                else if (k == 8)
                                {
                                    Console.ForegroundColor = ConsoleColor.Yellow;
                                    Console.Write("STATE  : ");
                                    Console.ForegroundColor = ConsoleColor.White;
                                    sstate[i] = Console.ReadLine();
                                }
                                else if (k == 9)
                                {
                                    Console.ForegroundColor = ConsoleColor.Yellow;
                                    Console.Write("GRADUATION: ");
                                    Console.ForegroundColor = ConsoleColor.White;
                                    sgraduation[i] = Console.ReadLine();
                                }
                                else if (k == 10)
                                {
                                    goto ab;
                                }
                                else
                                {
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("You have entered a invalid choice....");
                                    Console.WriteLine("Enter a valid choice[1-10]...");
                                    Console.ForegroundColor = ConsoleColor.White;
                                    goto bc;

                                }

                            }
                        }

                    }
                }
                else if(choice3 == 4)
                {
                    Console.WriteLine("Deletion ");
                    int M;
                H: M = Convert.ToInt32(Console.ReadLine());
                    if (M == 1)
                    {
                        sfname[i] = null;
                        slname[i] = null;
                        sage[i] = 0;
                        sgender[i] = null;
                        sphno[i] = 0;
                        smail[i] = null;
                        svillage[i] = null;
                        sstate[i] = null;
                        spin[i] = null;
                        sgraduation[i] = null;
                        exp[i] = 0;
                        Console.WriteLine("THE DETAILS ARE DELETED ");
                        goto G;
                    }
                    else
                    {
                        Console.WriteLine("Enter  only 1");
                        goto H;
                    }
                }

            else if (a == 3)
            {
                    int h = 0;
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("* - ONLY ADMIN CAN SEE THE DETAILS");
                    Console.WriteLine();
                    Console.WriteLine("PLEASE LOG IN FOR DETAILS");
                    Console.WriteLine();
                    Console.Write("Enter LOGIN ID      : ");
                    Console.ForegroundColor = ConsoleColor.White;
                    lid = Console.ReadLine();
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write("ENTER PASSWORD  : ");
                    Console.ForegroundColor = ConsoleColor.White;
                    pw = Console.ReadLine();
                    int ci = 0;
                    for (i = 0; i < suname.Count; i++)
                    {
                        if ((lid == Aloginid[i]) && (pw == Apassword[i]))
                        {
                            ci = 1; break;

                        }

                    }
                    if (ci == 1)
                    {
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("YOU HAVE LOGGED IN SUCCESSFULLY  ");
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("INVALID CREDENTIALS TRY AGAIN OR REGISTER ");
                        goto w;
                    }
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("LOG IN SUCCESSFULL");
                    Console.WriteLine("");
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("VIEW  DETAILS OF \n1.ADMIN  \n2.STUDENT");
                    Console.ForegroundColor = ConsoleColor.White;
                    choice = Convert.ToInt32(Console.ReadLine());
                    Thread.Sleep(100);
                    Console.Clear();
                    if (choice == 1)
                    {
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("---------------------------TOTAL ADMIN DETAILS-------------------");
                        for (i = 0; i < Afname.Count; i++)
                        {
                            if (lid == Aloginid[i] && pw == Apassword[i])
                            {
                                Console.ForegroundColor = ConsoleColor.Cyan;
                                Console.WriteLine("                         " + (i + 1) + "      ADMIN DETAILS ");
                                Console.WriteLine();
                                Console.WriteLine("NAME          : " + Afname[i] + " " + Alname[i]);
                                Console.WriteLine("AGE           : " + Aage[i]);
                                Console.WriteLine("GENDER        : " + Agender[i]);
                                Console.WriteLine("PHONE NUMBER  : " + Aphone[i]);
                                Console.WriteLine("E-MAIL        : " + Amail[i]);
                                Console.WriteLine("ADDRESS       : " + Aaddress[i]);
                                Console.WriteLine("QUALIFICATION : " + qualification[i]);
                                Console.WriteLine("COURSES       : " + course[i]);
                            }

                        }
                        Console.WriteLine("1.GOTO HOME");
                        if (choice == 1)
                        {
                            goto w;
                        }
                    }
                    else if (choice == 2)
                    {
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("-------------------------TOTAL STUDENTS DETAILS----------------------");
                        Console.WriteLine();
                        for (i = 0; i < sfname.Count; i++)
                        {

                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.WriteLine("                    " + (i + 1) + "  STUDENT  DETAILS ");
                            Console.WriteLine("");
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine(" FIRST NAME  :" + sfname[i]);
                            Console.WriteLine();
                            Console.WriteLine("LAST NAME    :" + slname[i]);
                            Console.WriteLine();
                            Console.WriteLine("USER NAME    :" + suname[i]);
                            Console.WriteLine();
                            Console.WriteLine("COURSE       :" + sscourse[i]);
                            Console.WriteLine();
                            Console.WriteLine("CONTACT      :" + sphno[i]);
                            Console.WriteLine();
                            Console.WriteLine("GRADUATION   :" + sgraduation[i]);
                            Console.WriteLine();
                            Console.WriteLine("MAIL         :" + smail[i]);
                            Console.WriteLine();
                            Console.WriteLine("STATE        :" + sstate[i]);
                            Console.WriteLine();
                            Console.WriteLine("PIN CODE     :" + spin[i]);
                            Console.WriteLine();
                            Console.WriteLine("VILLAGE      :" + svillage[i]);
                        }
                        Console.WriteLine("1.GOTO HOME");
                        if (choice == 1)
                        {
                            goto w;
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Please enter a valid number ");
                    goto w;
                }
            }
        }
    }
 }



 public class certificate
 {
            public void certify()
            {
                string name;
                Console.ForegroundColor = ConsoleColor.Green;

                Console.WriteLine(" COGRATULATIONS  YOUR QUALIFIED IN THE TEST ");
                Console.WriteLine();
                Console.WriteLine("ENTER YOUR NAME FOR CERTIFICATION");
                Console.ForegroundColor = ConsoleColor.Yellow;
                name = Console.ReadLine();
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("PLEASE WAIT FOR CERTIFICATION. ");

                Thread.Sleep(300);
                Console.Clear();
                Console.WriteLine("PLEASE WAIT FOR CERTIFICATION.. ");
                Thread.Sleep(300);
                Console.Clear();
                Console.WriteLine("PLEASE WAIT FOR CERTIFICATION... ");
                Thread.Sleep(300);
                Console.Clear();
                Console.WriteLine("PLEASE WAIT FOR CERTIFICATION.... ");
                Thread.Sleep(300);
                Console.Clear();
                Console.WriteLine("PLEASE WAIT FOR CERTIFICATION..... ");
                Thread.Sleep(300);
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("             :-----------------------------------------------------------------------:");
                Console.WriteLine("             :          *                                              *             :");
                Console.WriteLine("             :        *                 .NET CERTIFICATION                *          :");
                Console.WriteLine("             :      *                                                        *       :");
                Console.WriteLine("             :    *                 THIS CERTIFICATE IS PRESENTED TO           *     :");
                Console.WriteLine("             :  *                                                                 *  :");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("                                          " + name + "                                ");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("             :                                                                       :");
                Console.WriteLine("             :          DATE                                            SIGNATURE    :");
                Console.WriteLine("             :                                                                       :");
                Console.WriteLine("             :-----------------------------------------------------------------------:");
            }


  }

    
