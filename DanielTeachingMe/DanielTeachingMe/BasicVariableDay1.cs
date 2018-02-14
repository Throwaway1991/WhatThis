using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DanielTeachingMe
{
    public class BasicVariableDay1
    {
        private string m_imprivate;
        public string m_impublic;
        //Constructor - initialize your class specific properties
        public BasicVariableDay1()
        {
            m_imprivate = "You can't access me outside of this class!";
            m_impublic = "You can access me outside of this class and change my value!";
        }

        public void ExecuteDay1Homework()
        {
            string a = "Matthew";
            string b = "Mira";
            string c = null;
            string d = "fucks";

            //Goal: Concatenate a with d then take that and concatenate it with b and THEN concatenate all that shit with c
            //Fix the error that shows up
            //Output your results to the black box

            string answer = a + d + b + c;

            Console.WriteLine(answer);
            Console.Read();

            /* Matt's answers
             
            string answer = a + d + b;
            string orgasm = "a + d";
            string love = "orgasm + b";
            string crying = "love + c";

            Console.WriteLine("String orgasm {0}.", Test(orgasm));
            Console.WriteLine("String love {0}.", Test(love));
            Console.WriteLine("String crying {0}.", Test(crying));
            */
        }

        private String Test(string test)
        {
            if (String.IsNullOrEmpty(test))
                return "is null or empty";
            else
                return String.Format("(\"{0}\") is neither null nor empty", test);
        }

        #region Day 1
        //Variable/object declarations in c#
        //<object type> <name>
        // e.g. int foo;

        //Function declarations in c#
        //<access modifier> <return type> <name> (<parameters>)
        private int Add(int daniel, int nikki)
        {
            int chipotle = daniel + nikki;

            return chipotle;
        }

        //Homework 1: Do error checking on the parameters passed in
        //Hint: lookup if statements and String class on MSDN Look for a method in the string class to do your null checking
        //Hint2: Look up AND condition for if statements
        private string Add(string ass, string vag)
        {
            string videotape = ass + vag;

            return videotape;
        }

        private void Day1Lesson()
        {
            int poopface = 5;
            int fart = 1;

            int moes = Add(poopface, fart);

            int bermuda = 10;
            int sex = 15;

            int penis = Add(bermuda, sex);

            decimal tits = 3.1M;
            string matthew = "matthew";
            char skiing = 'a';

            string mira = "mira";

            string porn = Add(matthew, mira);

            Console.WriteLine(porn);
        }
        #endregion
    }
}
