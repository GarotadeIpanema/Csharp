// See https://aka.ms/new-console-template for more information
using Microsoft.VisualBasic;
using System.ComponentModel.Design;
using System.Dynamic;
using System.Collections.Generic;
using System.IO.Pipes;
using System.Linq;
using System.Text;
namespace Sample
{
    class Sample
    {
        static void Main()
        {
            //올바른 괄호
            string s = ")()(";
            var chars = s.ToCharArray();
            int open = 0; bool answer = false;
            if (s[0] != ')')
            {
                for (int i = 0; i < chars.Length; i++)
                {
                    // i= Array.IndexOf(chars,"(");
                    i = Array.IndexOf(chars, '(');
                    if (chars[i] == '(')
                    {
                        open++;
                    }
                    else
                    {
                        open--;
                    }
                    if (open < 0)
                    {
                        answer = false;
                    }
                }
            }

            answer = open == 0 ? true : false;
            Console.WriteLine(answer);

        }
    }
}
