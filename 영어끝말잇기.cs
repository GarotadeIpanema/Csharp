using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Class1
    {
        public int[] 영어끝말잇기(int n, string[] words) { 
        //words = new string[] { "tank", "kick", "know", "wheel", "land", "dream", "mother", "robot", "tank" };
           int find = 0; 
            var complist = new List<string>();
            for (int i = 0; i < words.Length; ++i)
            {
                if (complist.Count!=0)
                {

                    if (words[i].Length <= 1 || words[i - 1].Last() != words[i].First() || complist.Contains(words[i]))
                    {
                        find = i;

                        break;
                    }

                }
                complist.Add(words[i]);
            }

            if (find == 0)
            {
                return new int[] { 0, 0 };
            }

            return new int[] { find % n + 1, (find / n + 1) };
        }
   
    }
}
