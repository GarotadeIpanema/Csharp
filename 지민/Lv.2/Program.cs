using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;//스트링빌더

namespace Sample
{
    class Sample
    {
        //34731
        //33168
        //32966 
        static void Main()
        {
            int[] arr = new int[] { 2, 6, 8, 14 };
            Array.Sort(arr);
            int maxyak = 0;
            for (int i = 1; i < arr.Length; i++)
            {
                maxyak = arr[i - 1] * arr[i] / Enumerable.Range(1, arr[i-1]).Where(x => arr[i-1] % x == 0 && arr[i ] % x == 0).Max();
                Console.WriteLine(maxyak.ToString());
                arr[i] = maxyak;
            }
            
            Console.WriteLine(maxyak.ToString());
            int answer = 0;
            //4 부터 
            int brown = 10; int yellow = 2;
          
            Console.WriteLine(String.Join(" ", Enumerable.Range(1, brown + yellow).Where(x => x * x == 12).ToList()));
            int n = 7;
            int[] pibo = new int[n];
            pibo[0] = 0; pibo[1] = 1;
            for (int i = 2; i < pibo.Length; i++)
            {
                pibo[i] = pibo[i - 1] + pibo[i - 2];
            }
           // int answer = pibo[n] % 1234567;
            //  0 1 1 2 3 5
            // 
        //다음큰 숫자

            //평행 ?????
            //int[,] dots = { { 1, 4 }, { 9, 2 }, { 3, 8 }, { 11, 6 } };//1
            //for (int i = 0; i < dots.Length; i++)
            //{

            //}
            //result = 0;
            //if (Math.Abs((double)(dots[0, 0] - dots[1, 0]) / (dots[0, 1] - dots[1, 1])) == Math.Abs((double)(dots[2, 0] - dots[3, 0]) / (dots[2, 1] - dots[3, 1]))) result = 1;
            //if (Math.Abs((double)(dots[0, 0] - dots[2, 0]) / (dots[0, 1] - dots[2, 1])) == Math.Abs((double)(dots[1, 0] - dots[3, 0]) / (dots[1, 1] - dots[3, 1]))) result = 1;
            //if (Math.Abs((double)(dots[0, 0] - dots[3, 0]) / (dots[0, 1] - dots[3, 1])) == Math.Abs((double)(dots[2, 0] - dots[3, 0]) / (dots[2, 1] - dots[3, 1]))) result = 1;

            //for (int i = 1; i < dots.GetLength(0) - 1; i++)
            //{
            //    for (int j = i; j < dots.GetLength(0); j++)
            //    {
            //        if (dots[j, 0] - dots[i, 0] != 0)
            //        {
            //            if (Math.Abs((double)(dots[j, 0] - dots[i, 0] / dots[j, 1] - dots[i, 1])) == Math.Abs((double)(dots[0, 0] - dots[i, 0] / dots[0, 1] - dots[i, 1])))
            //            {
            //                result = 1;
            //                break;
            //            }

            //        }
            //        else
            //        {
            //            if (dots[j, 1] - dots[i, 1] == 0)
            //            {
            //                result = 1;
            //                break;
            //            }
            //        }

            //    }
            //}

           n = 3;
            //3 1 번호차례 
            string[] words = new string[] { "tank", "kick", "know", "wheel", "land", "dream", "mother", "robot", "tank" };
            //22
            int find = 0; string word = ""; int find2 = 0;
            var complist = new List<string>();
            int[] result = new int[] { 0, 0 };

            List<string> wordList = new List<string>();
            int index = 0;
            foreach (var v in words)
            {
                if (wordList.Count != 0)
                {
                    if (v.Length == 1 || wordList.Contains(v) || wordList[index - 1].Last() != v.First())
                    {
                        result=new int[] { index % n + 1, index / n + 1 };
                    }
                }

                wordList.Add(words[index]);
                index++;
            }
          //  return new int[] { 0, 0 };
            if (words.Length <= 1)
            {
                //   return new int[] { 1, 1 };
            }
            complist.Add(words[0]);
            for (int i = 1; i < words.Length; ++i)
            {
                word = words[i - 1];

                if (words[i].Length <= 1 || word.Last() != words[i].First() || complist.Contains(words[i]))
                {
                    find = i;

                    break;
                }

                complist.Add(word);

            }


            if (find == 0)
            {
                result = new int[] { 0, 0 };
            }

            find++;//1/2
            int ans = find % n == 0 ? n : (find % n);
            int ans2 = find % n == 0 ? (find / n) : (find / n) + 1;
            result = new int[] { ans, ans2 };
            Console.WriteLine(String.Join(" ",result));

            {
                //이진변환 반복하기
                string s = "110010101001";
                s = s.Replace("0", "");

                //x 길이를 c라고 하면 c 를 이진법으로 표현한 문자열로 바꿈

                //zip   return a.Zip(b, (t1, t2) => t1 * t2).Sum();
                s = "(())()"; bool aan = false;
                int stk = 0;
                if (s[0] != ')')
                {
                    while (s.Contains("()"))
                    {
                        s = s.Replace("()", "");

                    }
                }
                foreach (var p in s)
                {
                    if (p == '(')
                    {
                        //stk.Push(p);
                        stk++;
                    }
                    else
                    {
                        //if (stk.Count == 0)
                        if (stk == 0)
                        {
                            aan = false;
                        }
                        //stk.Pop();
                        stk--;
                    }
                }

                //if (stk.Count > 0)
                if (stk > 0)
                {
                    aan = false;
                }


                Console.WriteLine(s);

                s = "3people unFollowed me";
                var list = s.Split(" ").ToArray();
                int[] a = { 1, 2 }; int[] b = { 3, 4 };
                a = a.OrderBy(x => x).ToArray();
                b = b.OrderByDescending(x => x).ToArray();
                var lis = new List<int>();
                for (int i = 0; i < a.Length; i++)
                {
                    lis.Add(a[i] * b[i]);
                    Console.WriteLine((a[i] * b[i]).ToString());
                }
                //  var lis = Enumerable.Range(0, a.Length).Select(x => a[x] * b[x]).ToList();
                //int ans= Enumerable.Range(0, a.Length).Sum(x => a[x] * b[x]);
                //  int ans = lis.Sum();
                //var lis = a.Zip(a, (t1, t2) => t1 * t2).ToArray().Distinct();
                // 12 43
                // 124  4 4 5 
                //JadenCase 문자열 
                //StringBuilder answer = new StringBuilder();
                //var charArray = s.ToLower().ToCharArray();

                //for (int i = 0; i < charArray.Length; i++)
                //{
                //    answer.Append(i == 0 || answer[i - 1] == ' ' ? char.ToUpper(charArray[i]) : charArray[i]);
                //}


                for (int i = 0; i < list.Length; i++)
                {
                    var mlist = list[i].ToCharArray();
                    for (int j = 0; j < mlist.Length; j++)
                    {

                        mlist[j] = j == 0 ? char.Parse(mlist[j].ToString().ToUpper()) : char.Parse(mlist[j].ToString().ToLower());

                    }
                    list[i] = string.Join("", mlist);

                }
                Console.WriteLine(string.Join(" ", list));
                //lv2 최대 최소
                s = "1 2 3 4";
                list = s.Split(" ").ToArray();
                int[] intArray = Array.ConvertAll(list, item => int.Parse(item));
                //for (int i = 0; i < list.Count; i++)
                //{
                //    int.Parse(list[i]);
                //}
             // answer = intArray.Min() + " " + intArray.Max();
                int min = intArray.Min();

                ////대충만든 자판
                //string[] keymap = { "ABACD", "BCEFD" };
                //string[] targets = { "ABCD", "AABB" };

                //int[] results = { };
                //for (int i = 0; i < targets.Length; i++)
                //{
                //   // char[] tc = targets[i].ToCharArray();
                //    int vez = 0;
                //    for (int j = 0; j < targets[i].Length; j++)
                //    {
                //        vez = Math.Min(Array.IndexOf(targets[0], keymap[0].Where(x => x == targets[i])), 0);
                //    }
                //}
                //문자열 나누기 시간초과 ㅠㅠ
                int unt = 0;
                string st = "a";
                if (st.Length < 2)
                {
                    unt = 0;
                }
                while (st.Length >= 1)
                {
                    // char[] sttr = st.ToCharArray();

                    char first = st[0];
                    int same = -1; int diff = -1;
                    //int count = str.Where(x => x != first).First();
                    if (st.Length == 1)
                    {
                        unt++;
                        break;
                    }
                    for (int i = 0; i < st.Length; i++)
                    {

                        if (st[i] == first)
                        {
                            same++;
                        }
                        else
                        {
                            diff++;
                        }
                        if (same == diff)
                        {

                            st = st.Substring(i + 1);

                            //first = sttr[i+1];
                            unt++;
                            break;
                        }
                    }


                }
                Console.WriteLine(unt.ToString());
               // string ans = "";
                s = "5525"; string l = "1255";
                //var numbers = Enumerable.Range(0, 9).ToList();
                //for (int i = 0; i < numbers.Count; i++)
                //{

                //    int lcount = s.ToCharArray().Where(x => x == numbers[i]).Count();
                //    if (lcount > 1)
                //    {
                //        Console.WriteLine("sdfs'");
                //    }
                //    int scount = l.Where(x => x == (char)numbers[i]).Count();
                //    int cnunt = Math.Min(lcount, scount);
                //    ans.PadLeft(cnunt, char.Parse(numbers[i].ToString()));
                //}

                //int[] ingredient = { 2, 1, 1, 2, 3, 1, 2, 3, 1 };//2
                                                                 //  string a = new string(ingredient.Where(x => .Contains("1231")).ToArray());

                // int[] ingredient = { 1, 3, 2, 1, 2, 1, 3, 1, 2 };//0
                //1-2-3-1 한개


                //               [2, 1, 1, 2, 3, 1, 2, 3, 1]	2
                //[1, 3, 2, 1, 2, 1, 3, 1, 2] 0

                while (st.Trim() != "")
                {

                    char[] sttr = st.ToCharArray();
                    char first = sttr[0];
                    int same = -1; int diff = -1;
                    //int count = str.Where(x => x != first).First();
                    if (sttr.Length == 1)
                    {
                        unt++;
                        break;
                    }
                    for (int i = 0; i < sttr.Length; i++)
                    {

                        if (sttr[i] == first)
                        {
                            same++;
                        }
                        else
                        {
                            diff++;
                        }
                        if (same == diff)
                        {
                            //  an.Add(st.Substring(0, i));
                            st = st.Substring(i + 1);
                            unt++;
                            break;
                        }
                    }


                }
                //명예의 전당
                int k = 3;
                int[] score = { 10, 100, 20, 150, 1, 100, 200 };//[10, 10, 10, 20, 20, 100, 100]
                var minlist = new List<int>();
                List<int> q = new List<int>(3);
                q.Add(score[0]);
                minlist.Add(score[0]);

                for (int i = 1; i < score.Length; i++)
                {
                    if (score[i] > q.Min())
                    {

                        q.Add(score[i]);
                        if (q.Count > k)
                        {
                            q = q.OrderByDescending(x => x).SkipLast(1).ToList();
                        }
                    }

                    Console.WriteLine(String.Join(" ", q));
                    minlist.Add(q.Min());
                }
                Console.WriteLine(String.Join(" ", minlist));

                ////푸드파이터
                //int[] food = { 1, 7, 1, 2 };//"1223330333221" 1번 음식 1개, 2번 음식 2개, 3번 음식 3개
                //answer = "";
                ////  food = food.Where(x => x > 1).ToArray();
                //for (int i = 1; i < food.Length; i++)
                //{
                //    if (food[i] >= 2)
                //    {
                //        int cont = food[i] / 2;
                //        for (int j = 0; j < cont; j++)
                //        {
                //            answer += i.ToString();
                //        }
                //    }


                //}
                //answer = answer + "0" + string.Join("", answer.OrderByDescending(x => x));
                //Console.WriteLine(answer);
                //int[] food = { 1, 7, 1, 2 };//"111303111"1번 음식 3개, 3번 음식 1개

                //둘만의 암호

                //   string s = "aukks"; string skip = "wbqd"; int index = 5;
                s = "zzzzzz"; string skip = "abcdefghijklmnopqrstuvwxy"; 
                //int index = 6;
                string abc = "abcdefghijklmnopqrstuvwxyz";
                //int turn = skip.Length / abc.Length;
                //if (turn>=1)
                //{
                //    for (int i = 0; i < turn; i++)
                //    {
                //        abc += abc;
                //    }

                //}
                abc += abc;
                var abch = abc.ToCharArray().ToList();

                var scha = s.ToCharArray().ToList(); //answer = "";
                var skipch = skip.ToCharArray().ToList();

                abch = abch.Except(skipch).ToList();
                while (abch.Count < abc.Length)
                {
                    abch.AddRange(abch);
                }

                for (int i = 0; i < scha.Count; i++)
                {
                    int abindex = abch.FindIndex(x => x == scha[i]);
                    if (abindex + index > abch.Count)
                    {

                    }
                    else
                    {
                        abindex += index;
                    }


                    answer += abch[abindex];

                }
                Console.WriteLine(answer);
                //숫자짝꿍 11~15 런타임 에러..
                //string x = "12321"; string y = "42531";
                //x = "5525"; y = "1255";
                //int result = 0;
                //ans = "";
                ////x = x.OrderByDescending(x => x).ToString();
                ////y =y.OrderByDescending(y => y));
                //x = string.Join("", x.OrderByDescending(x => x));
                //y = string.Join("", y.OrderByDescending(y => y));
                //List<char> yl = y.ToCharArray().ToList();
                //List<char> cl = x.ToCharArray().ToList();
                //var sb = new StringBuilder();

                //for (int j = 0; j < cl.Count; j++)
                //{
                //    for (int i = 0; i < yl.Count; i++)
                //    {
                //        if (yl[i] != ' '&&cl[j] == yl[i])
                //        {
                //            sb.Append(yl[i]);
                //             yl[i] = ' ';
                //            break;
                //        }

                //    }
                //    cl[j] = ' ';

                //}
                //ans = sb.ToString();
                //foreach (var item in cl)
                //{
                //    for (int i = 0; i < yl.Count; i++)
                //    {
                //        if (item == yl[i])
                //        {
                //            ans += yl[i];
                //            if (i == yl.Count - 1)
                //            {
                //                yl.RemoveAt(i);
                //            }
                //        }


                //    }

                //}
                //if (ans.Trim() != "")
                //{
                //    //ans = "100";
                //    if (ans.Where(x => x.ToString() == "0").Count() > 1)
                //    {
                //        ans = int.Parse(ans).ToString();
                //    }

                //    ans = string.Join("", ans.OrderByDescending(x => x));
                //}
                //else
                //{
                //    ans = "-1";
                //}
                //Console.WriteLine(ans.ToString());

                //int n = 5; int[] lost = { 2, 4 }; int[] reserve = { 1, 5, 3 };
                //Array.Sort(lost);
                //Array.Sort(reserve);
                //var lst = lost.Except(reserve).ToList();
                //var lrs = reserve.Except(lost).ToList();
                //int nn = n - lst.Count();

                //foreach (var item in lst)
                //{
                //    for (int i = 0; i < lrs.Count; i++)
                //    {

                //        if ((item-1==(lrs[i]) || item-1 == lrs[i]) && lrs[i] != 0)
                //        {
                //            nn++;
                //            lrs[i] = 0;
                //            break;
                //            //lrs.Remove(lst[i] - 1);
                //        }

                //    }
                //}
                //Console.WriteLine(nn.ToString());

                //while (x.Trim()!=""&& x.Trim() != "")
                //{
                //    int cnt = 0;

                //    if (y.Substring(0,1).Contains(x.Substring(0,1)))
                //    {
                //        ans += x.Substring(0, 1);
                //        int index = Array.IndexOf(yc, x.Substring(0, 1));
                //        yc.Except(index);
                //        //cnt = xc.Where(y => y == char.Parse(i.ToString())).Count()>yc.Where(y => y == char.Parse(i.ToString())).Count()? xc.Where(y => y == char.Parse(i.ToString())).Count(): yc.Where(y => y == char.Parse(i.ToString())).Count();
                //        //for (int j = 0; j < cnt; j++)
                //        //{
                //        //    ans += i.ToString();
                //        //}
                //    }
                //    x = x.Substring(1);
                //    y = y.Substring(1);
                //}



                //        Console.WriteLine(string.Join("", x.OrderByDescending(x => x)));
                //       Console.WriteLine(string.Join("", y.OrderByDescending(y => y)));
                //Console.WriteLine(string.Join("", x.ToCharArray().Except(y.ToCharArray())));
                //Enumerable.Range(0, length).Where(x => xc[x] == yc[x]).ToString();
                //      Console.WriteLine(string.Join("", Enumerable.Range(0, length).Where(x => xc[x] == yc[x]).ToString()));
                // Console.WriteLine(string.Join("",x.Where(x => x.Equals(y)).OrderByDescending(x => x)));
                // string ss = ;
                //카드뭉치
                string[] goal = { "i", "want", "to", "drink", "water" };
                string[] cards1 = { "i", "water", "drink" };
                string[] cards2 = { "want", "to" };
                //string answer = "No";
                // Console.WriteLine(string.Join(" ", goal.Where(x => cards1.Contains(x)).ToArray()));
                //if (cards1.SequenceEqual(goal))
                //{
                //    if (cards2.SequenceEqual(goal))
                //    {
                //        answer = "Yes";
                //    }
                //}
                List<string> card1 = cards1.ToList();
                List<string> card2 = cards2.ToList();
                string goalstring = string.Join("", goal);
                string compstring = "";
                for (int i = 0; i < goal.Length; i++)
                {
                    if (card1.Count > 0 && card1[0] == goal[i])
                    {
                        compstring += goal[i];
                        card1.RemoveAt(0);
                    }
                    else if (card2.Count > 0 && card2[0] == goal[i])
                    {
                        compstring += goal[i];
                        card2.RemoveAt(0);
                    }
                }
                //answer = compstring == goalstring ? "Yes" : "No";

                //if (cards1.SequenceEqual(goal.Where(x => cards1.Contains(x)).ToArray()))
                //{
                //    if (cards2.SequenceEqual(goal.Where(x => cards2.Contains(x)).ToArray()))
                //    {
                //        answer = "Yes";
                //    }
                //}
                Console.WriteLine(answer);


                ////가장 가까운 같은 숫자
                //string s = "banana";
                ////  string temp = "";
                //var an = new List<int>();
                //for (int i = 0; i < s.Length; i++)
                //{
                //    char temp = char.Parse(s.Substring(i, 1));
                //    //char[] str =Array.LastIndexOf(s.Substring(0, i).ToCharArray(),temp);
                //    int index = Array.LastIndexOf(s.Substring(0, i).ToCharArray(), temp);
                //    if (index != -1) index = i - index;

                //    //int ad = s.Substring(0,i).Contains(temp) ? 2 : -1;
                //    an.Add(index);

                //}
                //Console.WriteLine(string.Join(" ", an.ToArray()));


                int start = 0; int end = 0; int abs = 0;
                // arr[0] = new int[] { 1, 2, 3 };
                //

                int[,] lines = { { 0, 1 }, { 2, 5 }, { 3, 9 } };
                //for (int i = 0; i < arr.GetLength(0); i++)
                //{
                //    arr[i] = new int[] { line[i, 0], line[i, 1] };
                //}

                //IOrderedEnumerable<int[]> sortedByFirst = arr.OrderBy(x => x[0]);
                //int[3,2] lines = sortedByFirst.ToArray();
                // Console.WriteLine(string.Join(" ", lines));
                //int[,] sortline =lines.OrderBy(x=>x)
                // [-1, 1], [1, 3], [3, 9}  2
                //세 선분 겹치는 길이
                //                [[0, 1], [2, 5], [3, 9]]	2
                //[[-1, 1], [1, 3], [3, 9]]	0
                //[[0, 5], [3, 9], [1, 10]]	8
                //int answer = 0;
                //for (int i = -100; i < 100; i++)
                //{
                //    int cnt = 0;
                //    if (lines[0, 0] <= i && i < lines[0, 1]) { cnt++; }
                //    if (lines[1, 0] <= i && i < lines[1, 1]) { cnt++; }
                //    if (lines[2, 0] <= i && i < lines[2, 1]) { cnt++; }

                //    if (cnt > 1) { answer++; }
                //}
                //for (int i = 1; i < lines.GetLength(0); i++)
                //    {
                //        int temp = lines[i - 1, 1] > lines[i, 0] ? lines[i - 1, 1] - lines[i, 0] : 0;
                //        abs += temp;
                //    }

                //Console.WriteLine(abs.ToString());
                //for (int i = 0; i < lines.GetLength(0); i++)
                //{
                //    if (start > lines[i, 0]) start = lines[i, 0];
                //    if (end < lines[i, 1]) end = lines[i, 1];
                //}
                //}
                //int[] length = new int[end - start + 1];
                ////음수인 부분 처리해서 담을 부분도 필요 
                //for (int i = 0; i < lines.GetLength(0); i++)
                //{
                //    for (int k = lines[i, 0]; k <lines[i, 1]; k++)
                //    {

                //            length[k + 3] = 1;

                //    }
                //}

                //for (int i = 0; i < length.GetLength(0); i++)
                //{
                //    if (length[i] == 1 && length[i + 1] == 1)
                //    {
                //        abs++;
                //    }

                //}
                //Console.WriteLine((int)(abs/2));
                //for (int i = 0; i < length.GetLength(0); i++)
                //{
                //    Console.Write(length[i].ToString());

                //}
                ////  Console.WriteLine(abs);
                //Console.WriteLine(length.Where(x => x == 2).Count().ToString());
                //                [[1, 4], [9, 2], [3, 8], [11, 6]]	1
                //[[3, 5], [4, 1], [2, 4], [5, 10]]	0
                //     [a-b, c - d],[a-c, b - d],[a-d, b - c]

                // int[,] dots = { { 3, 5 }, { 4,1 }, { 2,4}, { 5,10 } };//0
                //  result = 0;
                //for (int i = 0; i < dots.GetLength(0)-1; i++)
                //{
                // //   int temp = dots[i, 0]; int temp2 = dots[i, 1];
                //    for (int j = i; j < dots.GetLength(0); j++)
                //    {
                //        if (dots[j, 0] - dots[i, 0] != 0)
                //        {
                //            if (Math.Abs(dots[j, 0] - dots[i, 0]) == Math.Abs(dots[j, 1] - dots[i, 1]))
                //            {
                //                result = 1;
                //                break;
                //            }

                //        }
                //        else
                //        {
                //            if (dots[j, 1] - dots[i, 1]==0)
                //            {
                //                result = 1;
                //                break;
                //            }
                //        }

                //    }
                //}
                //Console.WriteLine("성격유형");
                //    int[] scores = {3,2,1,0,1,2,3 };

                //    int[] choices = { 7, 1, 3 };
                //    string[] survey = { "TR", "RT", "TR" };
                //    //string[] type = { "RT", "CF", "JM", "AN" };
                //    // int[,] rank = new int[4, 2];
                //    int[] score = new int[8];
                //    string[] type = { "R", "T", "C", "F", "J", "M", "A", "N" };
                //    for (int i = 0; i < survey.Length; i++)
                //    {
                //        if (choices[i] != 4)
                //        {

                //            int index = (int)(choices[i] / 4);
                //            int find = Array.IndexOf(type,survey[i].Substring(index, 1));
                //            // index = Math.Floor(choices[i] / 4);
                //            score[find] += scores[choices[i]-1];
                //       //     score[find] +=(int) choices[i] % 4;

                //        }

                //    }
                //ans = ""; string tp = "";
                //for (int i = 0; i < score.GetLength(0); i+=2)
                //{

                //    if (score[i] == score[i+1])
                //    {
                //        tp = type[i];
                //    }
                //    else
                //    {
                //        tp = (score[i] > score[i + 1]) ? type[i] : type[i+1];
                //    }

                //    ans += tp;
                //}
                //Console.WriteLine(ans);
                Console.WriteLine("덧칠하기");
                //                8, 4, [2, 3, 6]
                //기댓값 〉	2
                // 8, 2, [2, 6]
                //int n = 4; int m = 2; int[] section = { 2, 6 };
                // int n = 8; int m = 2; int[] section = { 2,  6 };
                //int n = 8; int m = 4; int[] section = { 2, 3, 6 };
                n = 4; int m = 1; int[] section = { 1, 2, 3, 4 };
                //int[] paint = new int[n];
                //Array.Fill(paint, 1);
                //foreach (var item in section)
                //{

                //    paint[item - 1] = 0;

                //}
                //section을 순회하며 해당 지점을 시작으로 하여 최대로 칠하고 칠해진 마지막 인덱스를 갱신해 가면 됩니다.
                int res = 0;
                k = section[0] - 1;
                foreach (var item in section)
                {
                    if (item > k)
                    {
                        res++;
                        k = item + m - 1;
                    }
                }

                Console.WriteLine(res.ToString());
                //Console.WriteLine(String.Join(" ",paint));

                //k번째 수
                int[] array = { 1, 5, 2, 6, 3, 7, 4 };
                int[,] commands = { { 2, 5, 3 }, { 4, 4, 1 }, { 1, 7, 3 } };
                // Array.Sort(array);

                //var anss = new List<int>();
                //for (int i = 0; i < commands.GetLength(0); i++)
                //{

                //    var min = array.ToList()       // List로 변환
                //           .GetRange(commands[i, 0] - 1, commands[i, 1] - commands[i, 0] + 1).OrderBy(x=>x).ToArray(); // 특정 위치부터 특정 개수만큼 요소를 가져옴
                //    //int eend = array[commands[i, 0] +commands[i, 2] - 2];
                //        int eend = min[commands[i, 2] - 1];
                //        anss.Add(eend);
                //    // List<int> lstSub = lst.Where((x, idx) => idx >= nStart - 1 && idx < nEnd).OrderBy(x => x).ToList();

                //}
                // Console.WriteLine(string.Join(" ",anss.ToArray()));
                //            {
                //                버블정렬 같은 경우는 O(n2)이 걸리게 되는데 최대 원소 개수가 1,000,000개 이므로 시간이 오래 걸리게 됩니다.
                //이 문제 같은 경우 내림차순해서 m개씩 잘라도 되지만, 사실 k개가 작은 수이고 개수만 알면 되기 때문에 원래 문제의 의도대로 풀자면,
                //k = 3, m = 4, score =[1, 3, 2, 3, 2, 1, 1]

                //array k+1개 생성, arr =[0, 0, 0, 0]
                //score배열을 돌며 arr[score의 원소] += 1 방식으로 카운터를 세줍니다.arr =[0, 3, 2, 2]
                //그 다음 배열의 큰 인덱스부터해서 계산 = 상자안에 숫자(i) * 상자 안에 숫자 개수(m) * 상자의 개수(Math.floor(arr[i] / m)) 를 결과값에 더하고
                //m개씩 자르다 부족하거나 남는 경우엔 arr[i - 1] = arr[i] % m 을 통해 다음으로 이전해줍니다.
                //for (int i = arr.length - 1; i >= 1; i--) { result += i * m * Math.floor(arr[i] / m); arr[i - 1] += arr[i] % m; }

                //과일장수 사과 최대점수 k.m개씩 넣어 판매
                //int K = 3;  m = 4; int[] score = { 1, 2, 3, 1, 2, 3, 1 };
                //score= score.OrderByDescending(x => x).ToArray();
                //int answer = 0;
                ////int min = score.ToList()       // List로 변환
                ////           .GetRange(i, m) // 특정 위치부터 특정 개수만큼 요소를 가져옴
                ////           .ToArray().Min();
                //for (int i = 0; i < score.Length; i +=m)
                //{
                //    if (i+m<=score.Length)
                //    {
                //        int min = score[i + m];
                //        answer += min * m;
                //    }
                //    else
                //    {
                //        break;
                //    }


                //}

                //Console.WriteLine(answer.ToString());
                //덧칠하기




                Console.WriteLine(res.ToString());
                // paint = Enumerable.Range(1, n).Where(x=> x == 2 || x == 3 || x == 6).ToArray();
                //     paint = paint.Where(x => x == 2 || x == 3 || x == 6).Select(x => 1).ToArray();

                //for (int i = 0; i < paint.Length; i++)
                //{
                //    for (int i = 0; i < length; i++)
                //    {

                //    }
                //}
                //  N의 가장 큰 약수는 N을 제외하면 최대 N의 절반인 것을 이해하면 된다.
                static int countyak(int n)
                {
                    int cnt = 0;
                    for (int i = 1; i * i <= n; i++)
                    {
                        if (n % i == 0)
                        {
                            cnt++;
                            if (i * i < n)
                            {
                                cnt++;
                            }
                        }
                    }
                    return cnt;
                }
                //                divisor =[0 for i in range(number + 1)]
                //for i in range(2, number + 1):
                //    for j in range(1, min(number//i+1,i)):
                //        divisor[i * j] += 2
                //for i in range(1, int(number * *(1 / 2)) + 1):
                //    divisor[i * *2] += 1
                //                N의 약수를 찾을 때, 1~N 까지 모두 탐색하게 되면 시간 초과를 피하기 힘듭니다.
                //소인수 분해를 이용하여 약수의 개수를 계산하거나 N의 제곱근으로 범위를 좁혀 탐색하는 것을 추천합니다.

                //소인수 분해를 이용하는 방법
                //N을 소인수분해하여 각 소수의 지수를 구한 후, 각 지수에 1을 더한 값들을 곱한 후 1을 더하여 약수의 개수를 구합니다.
                //N이 24일 때, 이를 소인수 분해하면 2³ *3¹이며 각 지수에 1을 더한 뒤 곱하면(3 + 1) *(1 + 1) = 8로 약수의 개수를 구할 수 있습니다.

                //N의 제곱근으로 범위를 좁혀 탐색
                //N이 24일 때 소수는 1, 2, 3, 4, 6, 8, 12, 24이고 24의 제곱근은 약 4.9입니다.
                //1에서 4까지만 탐색해도 1 * 24, 2 * 12, 3 * 8, 4 * 6이므로 약수가 8개인 것을 바로 알 수 있습니다.

                //N이 다른 수의 제곱일 경우 16을 예로 들면 제곱근은 4입니다.
                //1, 2, 4, 8, 16이 약수이며 1 * 16, 2 * 8, 4 * 4로 도출이 가능합니다.

                //위 두 경우를 고려하여 N % i == 0일 때 count에 2를 더하고, N / i == i인 경우에 count를 1 빼는 식으로 함수를 짠다면 시간을 줄일 수 있습니다.

                ////탐색 범위를 1부터 N까지가 아닌 N의 제곱근 만큼만 탐색하는 방식은 N이 소수인지 판별하는 경우에도 탐색 시간을 줄이기 위해 자주 쓰이는 방식이니 알아두면 좋습니다.
                //int number = 5; int limit = 3; int power = 2;
                //var mugi = new List<int>();
                //for (int i = 1; i <= number; i++)
                //{
                //    int sum = Enumerable.Range(1, i).Where(x => i % x == 0).Count();
                //    sum = sum <= limit ? sum : power;
                //    mugi.Add(sum);
                //}
                //Console.WriteLine(String.Join(" ",mugi));
                //mugi.Sum();
                //string t = "3141592"; string p = "271";
                //int com = int.Parse(p);
                //answer = 0;
                //int length = t.Length - p.Length + 1;
                //for (int i = 0; i < length; i++)
                //{
                //    long comp = long.Parse(t.Substring(i, 3));
                //    if (int.Parse(t.Substring(i, 3)) >com)
                //    {
                //        answer++;
                //    }


                //}




                //안전지대
                int[,] board = { { 1, 1, 1, 1, 1, 1 }, { 1, 1, 1, 1, 1, 1 }, { 1, 1, 1, 1, 1, 1 }, { 1, 1, 1, 1, 1, 1 }, { 1, 1, 1, 1, 1, 1 } };
                double safe = 0;
                for (int i = 0; i < board.GetLength(0); i++)
                {
                    for (int j = 0; j < board.GetLength(1); j++)
                    {
                        if (board[i, j] == 1)
                        {

                            if (i >= 1)
                            {
                                if (j >= 1 && board[i - 1, j - 1] != 1) board[i - 1, j - 1] = 2;
                                if (board[i - 1, j] != 1) board[i - 1, j] = 2;
                                if (j + 1 < board.GetLength(1) && board[i - 1, j + 1] != 1) board[i - 1, j + 1] = 2;

                            }
                            if (j >= 1)
                            {
                                if (i + 1 < board.GetLength(0) && (board[i + 1, j - 1] != 1)) board[i + 1, j - 1] = 2;
                                if (board[i, j - 1] != 1) board[i, j - 1] = 2;
                            }
                            if (i + 1 < board.GetLength(0))
                            {
                                if (board[i + 1, j] != 1) board[i + 1, j] = 2;
                                if (j + 1 < board.GetLength(1) && board[i + 1, j + 1] != 1) board[i + 1, j + 1] = 2;

                            }
                            if (j + 1 < board.GetLength(1) && board[i, j + 1] != 1) board[i, j + 1] = 2;

                        }

                    }
                }
                for (int i = 0; i < board.GetLength(0); i++)
                {
                    for (int j = 0; j < board.GetLength(1); j++)
                    {
                        Console.Write(board[i, j].ToString());
                    }
                    Console.WriteLine();
                }
                for (int i = 0; i < board.GetLength(0); i++)
                {
                    for (int j = 0; j < board.GetLength(1); j++)
                    {
                        if (board[i, j] == 0)
                        {
                            safe++;
                        }
                    }
                }
                Console.WriteLine(safe.ToString());
                //16
                //[[0, 0, 0, 0, 0], [0, 0, 0, 0, 0], [0, 0, 0, 0, 0], [0, 0, 1, 1, 0], [0, 0, 0, 0, 0]]	13
                //[[1, 1, 1, 1, 1, 1], [1, 1, 1, 1, 1, 1], [1, 1, 1, 1, 1, 1], [1, 1, 1, 1, 1, 1], [1, 1, 1, 1, 1, 1], [1, 1, 1, 1, 1, 1]]

                //직사각형
                // int a, int b


                //int[] board={ 7, 9 };

                //string[] keyinput = { "down", "down", "down", "down", "down" };
                ////   ["left", "right", "up", "right", "right"]	[11, 11]	[2, 1]
                //board[0] = (int)board[0] / 2;
                //board[1] = (int)board[1] / 2;
                //int[] result = new int[2];
                //for (int i = 0; i < keyinput.Length; i++)
                //{
                //    switch (keyinput[i])
                //    {
                //        case "right":
                //            result[0] = Math.Abs(result[0] + 1) <= board[0] ? result[0] + 1 : result[0];
                //                break;
                //        case "left":
                //            result[0] = Math.Abs(result[0] - 1 )<= board[0] ? result[0] - 1 : result[0];
                //            break;
                //        case "up":
                //            result[1] = Math.Abs(result[1] + 1) <=board[1] ? result[1] + 1 : result[1];
                //            break;
                //        case "down":
                //            result[1] = Math.Abs(result[1] - 1) <=board[1] ? result[1] - 1 : result[1];
                //            break;
                //    }
                //}

                //   Console.WriteLine(string.Join(" ",result).ToString());
                //가까운 글자

                //int[] nRules1 = new int[] { 1, 2, 3, 4, 5 };
                //int[] nRules2 = new int[] { 2, 1, 2, 3, 2, 4, 2, 5 };
                //int[] nRules3 = new int[] { 3, 3, 1, 1, 2, 2, 4, 4, 5, 5 };
                //int[] nScores = new int[3];
                //for (int i = 0; i < answers.Length; i++)
                //{
                //    if (answers[i] == nRules1[i % nRules1.Length]) ++nScores[0];
                //    if (answers[i] == nRules2[i % nRules2.Length]) ++nScores[1];
                //    if (answers[i] == nRules3[i % nRules3.Length]) ++nScores[2];
                //}
                //List<int> lstAnswer = new List<int>();
                //if (nScores[0] == nScores.Max()) lstAnswer.Add(1);
                //if (nScores[1] == nScores.Max()) lstAnswer.Add(2);
                //if (nScores[2] == nScores.Max()) lstAnswer.Add(3);
                //return lstAnswer.ToArray();
                ////링크 쓰면 개수 제대로 안나옴,, 7~14 시간초과
                //string A = "12345";
                //string B = "21232425";
                //string C = "3311224455";
                //int[] ianswers = { 1, 2, 3, 4, 5 };
                //char[] answers = string.Join("", ianswers).ToCharArray();
                ////int[] one = { 1, 2, 3, 4, 5 };
                ////int[] two = { 2, 1, 2, 3, 2, 4, 2, 5 };
                ////int[] three = { 3, 3, 1, 1, 2, 2, 4, 4, 5, 5 };
                //char[] copyA = new char[answers.Length];
                //char[] copyB = new char[answers.Length];
                //char[] copyC = new char[answers.Length];


                //if (answers.Length>=5)
                //{
                //    System.Text.StringBuilder sb1 = new StringBuilder();
                //    System.Text.StringBuilder sb2 = new StringBuilder();
                //    System.Text.StringBuilder sb3 = new StringBuilder();
                //    for (int i = 0; i < answers.Length / 5; i++)
                //    {
                //        sb1.Append(A).Append(A);
                //        sb2.Append(B).Append(B);
                //        sb3.Append(C).Append(C);
                //    }
                //    A = sb1.ToString(); B = sb2.ToString(); C = sb3.ToString();
                //    Array.Copy(A.ToCharArray(), copyA, answers.Length);
                //    Array.Copy(B.ToCharArray(), copyB, answers.Length);
                //    Array.Copy(C.ToCharArray(), copyC, answers.Length);
                //}
                //else
                //{
                //    Array.Copy(A.ToCharArray(), copyA, answers.Length);
                //    Array.Copy(B.ToCharArray(), copyB, answers.Length);
                //    Array.Copy(C.ToCharArray(), copyC, answers.Length);
                //}

                //int acount = 0; int bcount = 0; int ccount = 0;
                //for (int i = 0; i < answers.Length; i++)
                //{
                //    if (copyA[i].ToString() == answers[i].ToString())
                //    {
                //        acount++;
                //    }
                //    if (copyB[i].ToString() == answers[i].ToString())
                //    {
                //        bcount++;
                //    }
                //    if (copyC[i].ToString() == answers[i].ToString())
                //    {
                //        ccount++;
                //    }
                //}
                //int[] answer = new int[] { acount, bcount, ccount };
                //var liss = new List<int>();
                //Console.WriteLine(String.Join(" ", answer));
                //for (int i = 0; i < answer.Length; i++)
                //{
                //    if (answer[i] == answer.Max())
                //    {
                //        liss.Add(i + 1);
                //    }
                //}
                ////  Console.WriteLine(Enumerable.Range(0, answers.Length).Where(x => copyA[x] == answers[x]).Count().ToString());

                //Console.WriteLine(String.Join(" ",liss));
                //static T[] SplitArray<T>(T[] array, int startIndex, int length)
                //{
                //    T[] result = new T[length];
                //    Array.Copy(array, startIndex, result, 0, length);
                //    return result;
                //}
                ////k번째수
                ////배열 자르기 split Array
                //int ii = 2; int jj = 5; int k= 3;

                //int[] array = { 1, 5, 2, 6, 3, 7, 4 };
                //jj = jj > ii ? jj - ii+1 : jj;
                //int[] newArray = array.Skip(ii-1).Take(jj-1).ToArray();
                //Console.WriteLine(String.Join(" ",newArray));
                //int[] sp = SplitArray(array, 2, 5);
                //int[,] commands = { { 2,5,3},{ 4,4,1},{ 1,7,3} };

                ////비동의하면 앞 동의 뒤
                ////   0011 22 33 
                ////  0123  45 6 7 
                ////              ["AN", "CF", "MJ", "RT", "NA"]	[5, 3, 2, 7, 5]	"TCMA"
                ////["TR", "RT", "TR"][7, 1, 3]   "RCJA"
                //string[] survey = { "TR", "RT", "TR" };
                //int[] choices = { 7, 1, 3 };

                //string[] type = { "RT", "TR", "FC", "CF", "MJ", "JM", "AN", "NA" };
                //string[] rtype = { "RT", "FC", "MJ", "AN"};
                //int[,] rank = new int[4,2];

                //for (int i = 0; i < survey.Length; i++)
                //{
                //    if (choices[i]!=4)
                //    {
                //        int index = Array.IndexOf(type, survey[i]);

                //        if (index%2==0)
                //        {
                //            index = index == 1 ? index - 1 : index;
                //            if (choices[i] > 4)//동의
                //            {

                //                rank[(int)index / 2, 1] += (choices[i] - 4);
                //            }
                //            else
                //            {//비동의

                //                // rank[index, 1] += choices[index];
                //                rank[(int)index / 2,0] += choices[i];

                //            }
                //        }
                //        else
                //        {
                //            index = index == 1 ? index - 1 : index;
                //            if (choices[i] > 4)//동의
                //            {

                //                rank[(int)index / 2, 0] += (choices[i] - 4);
                //            }
                //            else
                //            {//비동의

                //                // rank[index, 1] += choices[index];
                //                rank[(int)index / 2, 1] += choices[i];

                //            }
                //        }

                //    }

                //}
                //string ans = ""; string tp = "";
                //for (int i = 0; i < rank.GetLength(0); i++)
                //{

                //    if (rank[i, 0] == rank[i, 1])
                //    {
                //        tp = String.Concat(rtype[i].ToCharArray().OrderBy(x => x)).Substring(0, 1);
                //    }
                //    else
                //    {
                //        tp = (rank[i, 0] > rank[i, 1]) ? rtype[i].Substring(0, 1) : rtype[i].Substring(1, 1);
                //    }

                //    ans += tp;
                //}

                //Console.WriteLine(ans);
                //Console.WriteLine("시져암호");
                //string s = "a B  z ";
                // //string s = "a B z";
                // int  n = 4;
                //  string result = "";
                // char[] str = s.ToCharArray();
                //            // 다음 비트 나열에서 X 부분이 알파벳 결정
                //            // 다음 X만 읽어서(ch & 0x1F) 알파벳 대소문자 무시하고 판별 가능
                //            //  Large:  0000 0000 010X XXXX (XXXXX가 00001이면 'A')
                //            //  Small:  0000 0000 011X XXXX (XXXXX가 00001이면 'a')
                //public final String solution(String s, int n)
                //    {
                //        final int bound = 26 - n;
                //        final char[] cArr = s.toCharArray();

                //        for (int i = 0; i < cArr.length; i++)
                //        {
                //            if (cArr[i] > 0x20)
                //                cArr[i] += (cArr[i] & 0x1F) <= bound ? n : -bound;
                //        }

                //        return new String(cArr);
                //    }
                //string ss="ab"
                //A ~ Z
                //  Z+2=B, z+3=c             (대문자)65 ~90
                //a ~z
                //(소문자)   97 ~122
                //  if c not in (' ', 'z', 'Z'): c = chr(ord(c)+1)
                //   elif c in ('z', 'Z'): c = chr(ord(c) - 26 + 1)
                //////else: break
                //foreach (var item in str)
                //{
                //    char tep = ' ';
                //    if (item.ToString().Trim() != "")
                //    {
                //        int nu = (int)item;
                //        if (nu <= 90)
                //        {
                //            nu = (nu - 65 + n) % 26;
                //            tep = (char)((int)nu + 65);
                //        }
                //        else
                //        {
                //            nu = (nu - 97 + n) % 26;
                //            tep = (char)((int)nu + 97);
                //        }
                //        result += tep;
                //    }
                //    else
                //    {
                //        result += " ";
                //    }


                //}
                //    Console.WriteLine(result);

                //과일장수

                //   155-> 11 12번 나옴,,2 4 6  5 4 2 
                //154-> 10  11번 나옴,, 2 4 6 4 50 4 -5 1
                //            storey: 646, answer 13
                //646 4-> 650-> 5 (여기해결)700-> 3 1000-> 0 1 
                //마법의 엘레베이터
                //마법의 엘리베이터에는 -1, +1, -10, +10, -100, +100 등과 같이 절댓값이 10c (c ≥ 0 인 정수) 형태인 정수들이 적힌 버튼
                //                storey result
                //16  6   +1이 적힌 버튼을 4번, -10이 적힌 버튼 2번 
                //2554    16  -1, +100이 적힌 버튼을 4번, +10이 적힌 버튼을 5번, -1000이 적힌 버튼을 3
                int storey = 2554; int push = 0;
                char[] ss = storey.ToString().ToCharArray();
                int leg = Math.Abs(storey).ToString().Length;
                int uup = (int)GetExcelRound(storey, leg);
                int up = (int)GetExcelRound(storey, leg).ToString().Length == storey.ToString().Length ? 0 : 1;

                static double GetExcelRound(double value, int digit)
                {
                    var val1 = double.Parse((0.01 * Math.Pow(0.1, digit - 1)).ToString(), System.Globalization.NumberStyles.Float);
                    var val2 = 100 * Math.Pow(10, digit - 1);

                    return Math.Round(value * val1, 1, MidpointRounding.AwayFromZero) * val2;
                }


                //if (up == 1)
                //{
                //    i = 0;
                //    while (storey != 0)
                //    {
                //        //5 4 2 

                //        leg = Math.Abs(storey).ToString().Length - 1;
                //        if (storey % 10 != 0)
                //        {
                //            i = Enumerable.Range(Math.Abs(storey) - 5, (int)Math.Pow(10, leg + 1)).Where(x => x % 10 == 0).Min();
                //            push += Math.Abs(i - storey);
                //            storey += i - storey;//2550
                //        }
                //        if (storey / 10 != 0)
                //        {
                //            leg = Math.Abs(storey).ToString().Length - 1;
                //            i = storey > 0 ? (int)GetExcelRound(storey, leg) : (int)GetExcelRound(Math.Abs(storey), leg);
                //            push += (int)(i / (int)Math.Pow(10, leg));
                //            storey += i - storey;

                //        }
                //        if (storey / 10 != 0)
                //        {
                //            leg = Math.Abs(storey).ToString().Length;
                //            i = storey > 0 ? (int)GetExcelRound(storey, leg) : (int)GetExcelRound(Math.Abs(storey), leg);
                //            push += (int)(i / (int)Math.Pow(10, leg));
                //            storey += i - storey;

                //        }
                //        if (storey / 10 == 0)
                //        {
                //            push += Math.Abs(storey);
                //            i = push;
                //            storey = storey > 0 ? storey - i : storey + i;
                //        }
                //        if (storey == i)
                //        {
                //            leg = Math.Abs(storey).ToString().Length - 1;
                //            i = storey > 0 ? (int)GetExcelRound(storey, leg) : (int)GetExcelRound(Math.Abs(storey), leg);
                //            push += (int)(i / (int)Math.Pow(10, leg));
                //            storey = 0;
                //        }

                //    }
                //}
                //else
                //{
                //    i = 0; //154 155
                //    while (storey != 0)
                //    {
                //        if (storey % 10 != 0)
                //        {
                //            i = Enumerable.Range(Math.Abs(storey) - 5, (int)Math.Pow(10, leg + 1)).Where(x => x % 10 == 0).Min();
                //            push += Math.Abs(i - storey);
                //            storey += i - storey;
                //        }
                //        if (storey / 10 != 0)
                //        {
                //            leg = Math.Abs(storey).ToString().Length - 1;
                //            i = storey > 0 ? (int)GetExcelRound(storey, leg) : (int)GetExcelRound(Math.Abs(storey), leg);
                //            push += (int)(i / (int)Math.Pow(10, leg));
                //            if (storey == i)
                //            {
                //                push += (int)(i / (int)Math.Pow(10, leg));
                //                storey = 0;
                //            }
                //            else
                //            {
                //                storey += i - storey;
                //                if (storey / 10 == 0)
                //                {
                //                    push += Math.Abs(storey);
                //                    i = push;
                //                    storey = storey > 0 ? storey - i : storey + i;
                //                }
                //            }

                //        }


                //    }
                //}


                // i = Math.Abs(storey);
                //char[] ss = storey.ToString().ToCharArray();

                //foreach (var item in ss)
                //{
                //    push += int.Parse(item.ToString());
                //}
                Console.WriteLine(push.ToString());
                while (storey / 10 != 0)
                {

                }

                // //n = 5; int[] lost = { 2, 4 }; int[] reserve = {1,3,5 };
                //var lss = lost.OrderBy(x=>x).Except(reserve).ToList();
                //var lrs = reserve.OrderBy(x => x).Except(lost).ToList();
                //for (int i = 0; i < lrs.Count; i++)
                //{



                //    if (reserve.Contains(lost[i] - 1))
                //    {
                //        lss.Remove(lost[i]);
                //        lrs.Remove(lost[i] - 1);

                //    }
                //    if (reserve.Contains(lost[i] + 1))
                //    {
                //        lss.Remove(lost[i]);
                //        lrs.Remove(lost[i] + 1);
                //    }
                //}
                //n -= lss.Count();

                //문자열 나누기,소수찾기 만들기 시간초과
                //모의고사 런타임 에러..
                //리스트 패턴
                // 순서가 틀리기 때문에 False
                //  bool b = arr is [2, 1, 3];
                // bool match = arr is [1, 2, 3];
                //12345
                // int[] one = { 1, 2, 3, 4, 5 };
                // int[] two = { 2, 1, 2, 3, 2, 4, 2, 5 };
                // int[] three = { 3, 3, 1, 1, 2, 2, 4, 4, 5, 5};
                // int[] answers = { 1, 3, 2, 4, 2 };
                // int[] answer = new int[3];
                // for (int i = 0; i < answers.Length; i++)
                // {
                //     if (answers[i] == one[i])
                //     {
                //         answer[0]++;
                //     }
                //     else if (answers[i] == two[i])
                //     {
                //         answer[1]++;
                //     }
                //     else if (answers[i] == three[i])
                //     {
                //         answer[2]++;
                //     }
                // }
                //// int[] answer = new int[] { Enumerable.Range(0, answers.Length).Where(x => one[x] == answers[x]).Count(), Enumerable.Range(0, answers.Length).Where(x => two[x] == answers[x]).Count(), Enumerable.Range(0, answers.Length).Where(x => three[x] == answers[x]).Count() };

                // var liss = new List<int>();

                // for (int i = 0; i < answer.Length; i++)
                // {
                //     if (answer[i] == answer.Max())
                //     {
                //         liss.Add(i);
                //     }
                // }

                //var liss= Enumerable.Range(0, answer.Length).Select(x => Array.IndexOf(answer, x)).Where(x => x== answer.Max()).ToArray();
                //if (answer.Distinct().Count()>=2)
                //{
                //    Enumerable.Range(0, answers.Length).Select(x=> Array.IndexOf(answer, x)).Where(x => one[x] == answers.Max());
                //}
                //else
                //{
                //    int index =Array.IndexOf(answer, answer.Where(x => x == answer.Max()));
                //    a.Add(answer[index]);
                //        //DistinctBy(x => x == answer.Max()))
                //} 
                // DATE_FORMAT(NOW(), '%Y-%m-%d')

                //두개 뽑아 더하기 서로 다른 인덱스에 있는 두 개의 수를 뽑아 더해서 만들 수 있는 모든 수를 배열에 오름차순
                // [2,1,3,4,1]	[2,3,4,5,6,7]
                //[5,0,2,7]	[2,5,7,9,12]
                //int[] number = { 2, 1, 3, 4, 1 };
                //List<int> ann = new List<int>();

                //for (int i = 0; i < number.Length; i++)
                //{
                //    for (int j = i + 1; j < number.Length ; j++)
                //    {
                //        ann.Add(number[i] + number[j]);
                //    }
                //}

                //Console.WriteLine(String.Join(" ", ann.Distinct().OrderBy(x => x).ToArray()));
                //        //문자열 나누기,소수찾기 만들기 시간초과
                //        //첫글 같 안같 개수가 같이지는 순간 읽은 문자열 분리.또 반복 분리된 문자열 개수 리턴
                //        //  "banana"    3
                //        //"abracadabra"   6
                //        //"aaabbaccccabba"    3
                //        string st = "abracadabra";

                //List<string> an = new List<string>();
                //int unt = 0;
                //while (st.Trim() != "") {

                //    char[] sttr = st.ToCharArray();
                //    char first = sttr[0];
                //    int same = -1; int diff = -1;
                //    //int count = str.Where(x => x != first).First();
                //    if (sttr.Length==1)
                //    {
                //        unt++;
                //        break;
                //    }
                //    for (int i = 0; i < sttr.Length; i++)
                //    {

                //        if (sttr[i]==first)
                //        {
                //            same++;
                //        }
                //        else
                //        {
                //            diff++;
                //        }
                //        if (same==diff)
                //        {
                //          //  an.Add(st.Substring(0, i));
                //            st = st.Substring(i+1);
                //            unt++;
                //            break;
                //        }
                //    }


                //}
                //  int ans = an.Count();
                // Console.WriteLine(String.Join(" ",an));
                //    Console.WriteLine(unt.ToString());
                //소수만들기, 삼총사.. 세개 골라 조건 충족
                Console.WriteLine("소수만들기");
                // double answer = 0;
                //// number = { 1, 2, 7, 6, 4 };
                // for (int i = 0; i < number.Length - 2; i++)
                // {
                //     for (int j = i + 1; j < number.Length - 1; j++)
                //     {
                //         for (int k = j + 1; k < number.Length; k++)
                //         {
                //             int tep = number[i] + number[j] + number[k];
                //             if (Enumerable.Range(1, tep).Where(x => tep % x == 0).Count() == 2)
                //             {
                //                 answer++;
                //             }
                //         }
                //     }
                // }
                // Console.WriteLine(answer.ToString());
                ////소수찾기 효율성 시간 초과...ㅠㅠ
                //Console.WriteLine("소수찾기");
                //int nn = 10; result = 0;
                //for (int i = 1; i <= nn; i++)
                //{
                //    if (i % 2 != 0 && i != 2 || i % 3 != 0 && i != 3)
                //    {
                //        if (Enumerable.Range(1, i).Where(x => i % x == 0).Count() == 2)
                //        {
                //            result++;
                //        }
                //    }


                //}
                //   Console.WriteLine(result.ToString());
                //   Console.WriteLine("직사각형 넓이구하기");
                //   int[,] dots = { { 1, 1 }, { 2, 1 }, { 2, 2 }, { 1, 2 } };
                //   //1                    0,0, 0,1 1,0,1,1, 2,0,2,1
                //   double garo = 0; double sero = 0;
                //   var list = new List<int>();

                //   for (int i = 1; i < dots.GetLength(0); i++)
                //   {
                //       if (dots[i-1, 0] - dots[i, 0]!=0)
                //       {
                //           garo = Math.Abs(dots[i - 1, 0] - dots[i, 0]);
                //       }
                //       else
                //       {
                //           sero = Math.Abs(dots[i - 1, 1] - dots[i, 1]);
                //       }

                //   }

                //   Console.WriteLine((garo*sero).ToString());

                //   //다음에 올 숫자 등차 등비
                //   //일항 *( 공비 ^항갯수-1)/공비-1
                //   //  int[] common = { 1, 2, 3, 4 };2.5
                //   //int[] common = { 2, 4, 8 };
                //   //double middle =Math.Pow(common[common.Length / 2],2);
                //   // answer = 0;
                //   //if (middle==common.First()*common.Last())
                //   //{
                //   //    if (common[0]==0)
                //   //    {
                //   //        answer = 0;
                //   //    }
                //   //    else
                //   //    {
                //   //        answer = common.Last() * (common[1] / common[0]);
                //   //    }

                //   //}
                //   //else
                //   //{
                //   //    answer = common.Last() + common[1] - common[0];
                //   //}
                //   //중간항^2=양항 곱 기하평균

                //   //double avg=common.Average();
                //   //double avg2= (common.First() + common.Last())/2;
                //   //answer = 0;
                //   //if (avg==avg2)
                //   //{
                //   //    answer = common.Last() + common[1] - common[0];
                //   //}
                //   //else
                //   //{
                //   //    answer = common.Last() *(common[1] / common[0]);
                //   //}

                //   //int length = number.Length;
                //   //if (length < 3 || length > 13)
                //   //{
                //   //    return 0;
                //   //}

                //   //int answer = 0;
                //   //for (int i = 0; i < length - 2; i++)
                //   //{
                //   //    for (int j = i + 1; j < length - 1; j++)
                //   //    {
                //   //        int sum = number[i] + number[j];
                //   //        for (int k = j + 1; k < length; k++)
                //   //        {
                //   //            if (sum + number[k] == 0)
                //   //            {
                //   //                answer += 1;
                //   //            }
                //   //        }
                //   //    }
                //   //}
                //   int[] nums = { 1, 2, 7, 6, 4 }; int sum = 0;
                //   for (int i = 0; i < 3; i++)
                //   {
                //       for (int j = i; j < i+3; j++)
                //       {
                //           sum+= nums[j];
                //       }
                //   }



                //   //등수매기기
                //   int[,] score = { { 1, 3 }, { 3, 1 }, {2, 3}, {3, 2}, {1, 2}, {0, 0} };
                //   double[] arrsu = new double[score.GetLength(0)];
                //   for (int i = 0; i < score.GetLength(0); i++)
                //   {
                //     long tem  = (score[i, 0] + score[i, 1]);
                //       arrsu[i] = tem;
                //   }
                //   double[] order = arrsu.OrderByDescending(x => x).ToArray();
                // // int[] answer = arrsu.Select(x => Array.IndexOf(order, x) + 1).ToArray();
                ////   Console.WriteLine(String.Join(" ",answer));
                //   //특이한정렬
                //   //ThenByDescending을 쓰면 그다음조건으로 내림차순가능
                //   //  answer = numlist.OrderBy(x => Math.Abs(n-x)).ThenByDescending(x=>x).ToArray();
                //   //  int[] numlist = { 1, 2, 3, 4, 5, 6 };
                //   ////  int[] numlist = { 10000, 20, 36, 47, 40, 6, 10, 7000 };
                //   //  int n = 4;
                //   //  int[] liss = numlist.OrderBy(x => Math.Abs(x - n)).ToArray();
                //   //  for (int i = 1; i < numlist.Length; i++)
                //   //  {
                //   //      if (liss[i-1] < liss[i]&& Math.Abs(liss[i-1] - n) == Math.Abs(liss[i] - n))
                //   //      {
                //   //          int temp= liss[i];
                //   //          liss[i] = liss[i-1];
                //   //          liss[i-1] = temp;
                //      }
                //  }
                //   Console.WriteLine(String.Join(" ",liss));
                //int a = 5;int b = 24;
                //DateTime DT = new DateTime(2016, a, b);
                //DayOfWeek dw = DT.DayOfWeek;
                //Console.WriteLine(dw.ToString().ToUpper().Substring(0,3));


                //      string[] numbers = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };

                // s = "one4seveneight";
                //foreach (var item in numbers)
                //{
                //    if (s.Contains(item))
                //    {
                //        s = s.Replace(item, Array.IndexOf(numbers, item).ToString());
                //    }
                //}
                //int num = int.Parse(s);
                //Console.WriteLine(s);
                // 고려전산 창소프트 유미드 시스템 씨드 시스템 
                // 오토캐드 스캐치업 래빗 bim


                // int[] order = arrsu.OrderByDescending(x => x).ToArray();
                //int[] answer = arrsu.Select(x => Array.IndexOf(order, x) + 1).ToArray();
                //  n = 2;
                //내맘대로 문자열 then by!
                // string[] strings = { "sun", "bed", "car" };
                //string[] strings = { "abce", "abcd", "cdx" };
                //var lis = new List<string>();
                //  string[] strAnswer = strings.OrderBy(c => c).ToArray();
                ////  strAnswer = strAnswer.OrderBy(c => c[n]).ToArray();
                // int  count = strings.Select(x => x.Substring(n, 1)).Distinct().Count();
                //  if (count == strings.Length)
                //  {
                //      strings = strings.Select(x => x).OrderBy(x => x.Substring(n, 1)).ToArray();
                //  }
                //  else
                //  {
                //      strings = strings.Select(x => x).OrderBy(x => x.Substring(n, 1)).ThenBy(x => x).ToArray();
                //  }

                //for (int i = 0; i < order.Length; i++)
                //{
                //    if (order[i] == strings[i].Substring(n, n + 1))
                //    {
                //        lis.Add(strings[i]);
                //    }
                //}
                // string[] answer = strings.Select(x => strings[Array.IndexOf(order, x)]).ToArray();
                //  Console.WriteLine(String.Join(" ", strings));
                //로그인
                Dictionary<string, string> diction = new Dictionary<string, string>();
                string[,] db = { { "rardss", "123" }, { "yyoom", "1234" }, { "meosseugi", "1234" } };
                string[] id_pw = { "meosseugi", "1234" };
                //  string result = "fail";


                //for (int i = 0; i < db.GetLength(0); i++)
                //{
                //    if (db[i, 0] == id_pw[0])
                //    {
                //        if (db[i, 1] == id_pw[1])
                //        {
                //            result = "login";
                //            break;
                //        }
                //        else
                //        {
                //            result = "wrong pw";
                //            break;
                //        }
                //    }


                //    //}
                //    Console.WriteLine("유한소수판별");
                //    int a = 7; int b= 20;
                //    int big = a > b ? b : a;
                //    int yak = Enumerable.Range(1, big).Where(x => a % x == 0 && b % x == 0).Max();
                //    //double aa=a/ yak;
                //    int bb = (b == 1 || (b / yak) == 1 | ((b / yak)*5) %10== 0 || ((b / yak)*2)%10 == 0) ? 1 : 2;
                //    Console.WriteLine(bb.ToString());
                //    Console.WriteLine("예산");
                //int[] d = new int[] { 1, 3, 2, 5, 4 };
                //    d = d.OrderBy(x => x).ToArray();
                //    int temp = 0; 
                //    int budget = 9;
                //    int cou = 0;
                //    for (int i = 0; i < d.Length; i++)
                //        {

                //            if (temp + d[i] > budget)
                //            {
                //                break;
                //            }
                //            temp = temp + d[i] < budget ? temp + d[i] : temp;
                //            cou++;
                //        }


                //    Console.WriteLine(cou.ToString());

                //                [1,3,2,5,4]	9   3
                //[2, 2, 3, 3]   10  4
                // 9라면 캐릭터는 왼쪽으로 최대 [-4, 0]까지 오른쪽으로 최대 [4, 0]까지 이동할 수 있습니다.
                //string[] keyinput, int[] board
                //[11, 11]
                //["left", "right", "up", "right", "right"]
                //    [2, 1]

                //  Console.WriteLine(String.Join(" ",list));
                //  int num = 4;
                int total = 14;
                //int[] answer = new int[] { };
                //for (int i = -total; i < total; i++)
                //{
                //    int su = Enumerable.Range(i, num).Sum();
                //    if (su==total)
                //    {
                //       answer = Enumerable.Range(i, num).ToArray();

                //    }
                //}
                int chicken = 1081;
                var mari = new List<int>();
                int coupon = chicken;
                //  mari.Add(chicken);
                while (coupon / 10 != 0)
                {
                    mari.Add(coupon / 10);
                    coupon = coupon / 10 + coupon % 10;
                }
                Console.WriteLine(mari.Sum().ToString());

                // 2345

                string[] or = { "aya", "ye", "woo", "ma" };
                string[] baba = { "aya", "ye", "woo", "ma" };
                //  string[] noo = Enumerable.Range(0, 3).Where(x => or[x] + baba[x])

                // string[] babbling = { "aya", "yee", "u", "maa"};
                string[] babbling = { "ayaya", "uuu", "yeye", "yemawoo", "ayaayaa" };
                //for (i = 0; i < babbling.Length; i++)
                //{

                //    for (int j = 0; j < baba.Length; j++)
                //    {
                //        if (babbling[i].Trim() != "" && babbling[i].Contains(baba[j]) && babbling[i].Contains(baba[j] + baba[j]) == false)
                //        {
                //            babbling[i] = babbling[i].Replace(baba[j], " ");

                //            //  baba[j]= baba[j].Replace(baba[j], " ");
                //        }
                //        if (j == baba.Length - 1)
                //        {
                //            baba = or;
                //        }
                //    }

                //}
                int coun = babbling.Where(x => x.Trim() == "").Count();
                Console.WriteLine(coun.ToString());
                //  string answer = "";
                //string s = "try hello world";
                //s.TrimEnd();
                //[[1, 3], [3, 1], [2, 3], [3, 2], [1, 2], [0, 0]]  [3, 3, 1, 1, 5, 6]
                //foreach (var item in list)
                //{
                //    var lis = item.ToCharArray();
                //    int[] indexes = Enumerable.Range(0, lis.Length).Where(i => i%2==1).ToArray();
                //    Array.ForEach(indexes, i => lis[i] = char.ToUpper(lis[i]));

                //}
                //var list = s.Split(" ").ToList();
                //for (int i = 0; i < list.Count; i++)
                //{
                //    var lis = list[i].ToCharArray();
                //    int[] indexesodd = Enumerable.Range(0, lis.Length).Where(x => x % 2 == 0).ToArray();
                //    int[] indexes = Enumerable.Range(0, lis.Length).Where(i => i % 2 == 0).ToArray();
                //    Array.ForEach(indexes, i => lis[i] = char.ToUpper(lis[i]));
                //    Array.ForEach(indexesodd, i => lis[i] = char.ToLower(lis[i]));
                //    list[i] = String.Concat(lis);
                //}

                // answer = String.Join(" ", list);
                // Console.WriteLine(answer);
                //char[] answer = s.ToCharArray();
                //for (int i = 0; i < answer.Length; i++)
                //{
                //    if (i % 2 == 0)
                //    {
                //        answer[i] = char.ToUpper(answer[i]);
                //    }
                //}
                // string ans = string.Concat(answer);
                //유한 소수 판별
                //// 2/1
                //int a = 7; int b = 20;
                //int big = a > b ? b : a;
                //int yak = Enumerable.Range(1,big).Where(x => a % x == 0 && b % x == 0).Max();
                ////double aa=a/ yak;
                ////20 10 2 5 30
                ////125
                ////int[] yak2 = Enumerable.Range(1, big).Where(x => Math.Pow(2, x) == (b / yak)).ToArray();
                ////int[] yak5 = Enumerable.Range(1, big).Where(x => Math.Pow(5, x) == (b / yak)).ToArray();
                ////var yak25 = new List<int>();
                ////for (int i = 0; i < yak2.Length; i++)
                ////{
                ////    for (int j = 0; j < yak5.Length; j++)
                ////    {
                ////        yak25.Add(yak2[i] * yak5[j]);
                ////    }
                ////}
                ////for (int j = 0; j < yak2.Length; j++)
                ////{
                ////    for (int i = 0; i < yak5.Length; i++)
                ////    {
                ////        yak25.Add(yak2[i] * yak5[j]);
                ////    }
                ////}
                //int bb = (yak25.Contains(b / yak) || yak2.Contains(b / yak) || yak5.Contains(b / yak) || b == 1 || (b / yak) == 1) ? 1 : 2;
                //int bb = (b == 1 || (b / yak) == 1 || (b / yak) % 2 == 0 || (b / yak) % 5 == 0) ? 1 : 2;
                //      Console.WriteLine(bb.ToString());
                // int n = 3; int m = 12;
                // //int big = m > n ? m : n;
                //// int yak = Enumerable.Range(1, big).Where(x => x % n == 0 && x % m == 0).Max();
                // int bay = m * n / yak;
                // int[] answer = new int[2] { yak, (m * n / yak) };
                // //부족한 금액 계산하기
                // int price = 3;
                // int pay = Enumerable.Range(1, 4).Sum(x => x * price) -20;
                // Console.WriteLine(pay.ToString());
                // int money = 20;


                //int left = 24;
                //int right = 27; int sum = 0;
                //int count = Math.Abs(left - right)-1;
                ////int start = left < right ? left : right;
                //int answerr = 0;
                //for (int i = left; i <= right; i++)
                //{
                // //   int count = Enumerable.Range(1, i).Where(x => i % x == 0).Count();
                //    int summ = Enumerable.Range(1, i).Where(x => i % x == 0).Sum();
                //    answerr = count % 2 == 0 ? answerr + i : answerr - i;
                //}
                //Console.WriteLine(answerr.ToString());

                //   String[] s;
                //int n = 3;
                m = 12;
                //  int start = n < m ? m : n;
                // a.Zip(b, (t1, t2) => t1 * t2).Sum();
                // int count = Enumerable.Range(1, m).Where(x => n % x == 0&& n % x == 0)
                //  int[] answer = new int[] { };
                ////  Console.Clear();
                //  s = Console.ReadLine().Split(' ');

                //    int a = Int32.Parse(s[0]);
                //    int b = Int32.Parse(s[1]);
                //for ( i = 0; i < b; i++)
                //{
                //    for (int j = 0; j < a; j++)
                //    {
                //        Console.Write("*");
                //    }
                //    Console.Write("\n");
                //}

                //int n = 4;
                //// numbers.Zip(words, (first, second) => first + " " + second);
                ////= Convert.ToInt32("10101010", 2);
                //int rs = Convert.ToInt32("10101010", 2) + Convert.ToInt32("10101010", 2);
                //string result = Convert.ToString(rs, 2);//2진수 변환
                //                                        //   int[] a = { 1, 0,0,1 };
                //                                        //   int[] b = {1,1,1,1 };
                //                                        ////   Enumerable.Range(0,a.Length).Sum(x => a[x] ^ b[x]);
                //                                        //   Enumerable.Range(0, a.Length).Sum(x => a[x] * b[x]);
                //                                        // int result
                //string answer = "수";
                //     for (int i = 1; i < n; i++)
                //     {
                //         answer = i % 2 != 0 ? answer += "수" : answer += "박";
                //     }
                //    // answer =Enumerable.Range(0,n).Where(x=>x%2==0).Concat()
                //     //    int n = (s.Length + 1) % 2;
                //     //    int l = s.Length / 2 - n;
                //     //    return s.Substring(l, n + 1);
                //     string s = "qw"; string c = "";
                //     if (s.Length<=2)
                //     {
                //         c = s;
                //     }
                //     else
                //     {
                //        c = s.Length % 2 == 0 ? s.Substring((s.Length / 2) - 1, 2) : s.Substring(s.Length / 2, 1);

                //     }

                //     int[] absolutes = { 4, 7, 12 };
                //     bool[] signs = { true,false,true};
                //    // return absolutes.Select((t, idx) => signs[idx] ? t : -t).Sum();
                //     int temp = 0;
                //     temp = signs[0] == true ? temp + absolutes[0] : temp - absolutes[0];
                //     for (int i = 0; i < signs.Length; i++)
                //     {
                //        temp= signs[i] == true ? temp + absolutes[i] : temp - absolutes[i];
                //     }

                //     int[] cpnumbers = Enumerable.Range(0, 9).ToArray();
                //    int sum= Enumerable.Range(0, 9).Sum();
                //     int[] numbers = { 5, 8, 4, 0, 6, 7, 9 };//6
                //     //Console.WriteLine(String.Join(cpnumbers.Except(numbers)));
                //     sum = cpnumbers.Except(numbers).Sum();
                //    // string s = "a234";
                //   ///  int n = 0;
                // //    bool isNumeric = int.TryParse(s, out n);
                //  //   bool answer = (s.Length == 4|| s.Length == 6) && isNumeric ? true : false;
                //  //   int[] numbers = { 1, 2, 3, 4, 6, 7, 8, 0 };
                //    // int[] cpnumbers = Enumerable.Range(0,9).ToArray();

                //     //int sum = cpnumbers.Except(numbers).Sum();
                //     //김서방
                //     string phone_number = "01033334444";
                //    //  string ans = phone_number.OrderBy(x => x);
                //     string ans = "Zbcdefg";
                //  string answer = string.Concat(ans.ToCharArray());
                //     Console.WriteLine(answer);

                //     ans = phone_number.Substring(phone_number.Length - 4).PadLeft(phone_number.Length, '*');
                //     Console.WriteLine(ans);
                //     int[] arr = { 4, 3, 2, 1 };
                ////     int[] answer = new int[] { };

                //     var list = arr.Where(x => x % 5 == 0).ToList();
                //     if (list.Count==0)
                //     {
                //         list.Add(-1);
                //     }
                //  //   List<int> arr_list = new List<int>(arr);
                //     List<int> arr_list = arr.Where(num => num != arr.Min()).ToList();

                //     if (arr_list.Count == 0)
                //     {
                //         arr_list.Add(-1);
                //     }
                //     arr_list.ToArray();
                //     //// a.Take(a.Length - 1).ToArray();
                //     //int min = arr.Min();
                //     //if (arr.Length==1)
                //     //{
                //     //    answer = new int[] {-1};
                //     //}
                //     //else
                //     //{
                //     //    List<int> arr_list = new List<int>(arr);
                //     //    arr_list.RemoveAll(num => num == arr.Min());
                //     //    answer = arr_list.OrderByDescending(x => x).ToArray();
                //     //}
                //     Console.WriteLine();

                //     string[] seoul = { "Jane", "Kim" };
                //     int where =Array.IndexOf(seoul,"Kim");
                //     string answe = string.Concat("김서방은 " + Array.IndexOf(seoul, "Kim") + "에 있다");
                //     //콜라츠 추측
                //     int n = 626331;
                //     int vez = 0;
                //     while (n != 1) {
                //         n = n % 2 == 0 ? n / 2 : n * 3 + 1;
                //         vez = vez + 1;
                //         if (vez > 500)
                //         {
                //             vez = -1;
                //             break;
                //         }
                //     }
                //     Console.WriteLine(vez.ToString());
                //     //하샤드
                //     int x = 10;
                //     int hap = 0;
                //     int temp = x;
                //     while (x > 0)
                //     {
                //         hap += x % 10;
                //         x = x / 10;
                //     }
                //   //  bool sol = temp % hap == 0 ? true : false;
                //     string s = "-1234";
                //     int sint = int.Parse(s);
                //     Console.WriteLine(sint.ToString());
                //     string my_string = "4 + 2 - 5 + 3";
                //     string[] sp = my_string.Split(" ");
                //     int res = 0;
                //     for (int i = 0; i < sp.Length; i++)
                //     {
                //         if (i - 1 == 0)
                //         {
                //             res += Int32.Parse(sp[i - 1]);
                //         }
                //         if (sp[i].Contains("-"))
                //         {

                //             res -= Int32.Parse(sp[i+1]);


                //         }
                //         else if (sp[i].Contains("+"))
                //         {

                //             res +=  Int32.Parse(sp[i+1]);

                //         }
                //     }
                //     Console.WriteLine(res.ToString());
                //     //3456789101112
                //      n = 121;
                //     //string nstring =string.Concat( n.ToString,OrderBy.Descending(x => x),"");
                //    // int start = 0; int end = 0;
                //    // long answer = long.Parse(String.Concat(n.ToString().OrderByDescending(ch => ch)));
                //     int a = 5; int b = 3;

                //    // int tem = Math.Abs(b - a)+1;
                //    int start= a > b ? a : b;
                //    int end= a > b ? b : a;
                //     sum = 0;
                //     for (int i = start; i <=end; i++)
                //     {
                //         sum += i;
                //         Console.WriteLine(i.ToString());
                //     }
                // //   int sanswer = Enumerable.Range(start, end- start+ 1).Sum();
                // //    Console.WriteLine(sanswer.ToString());
                // //    var list = n.ToString().ToCharArray().ToList();
                ////      list.Reverse();
                //  //   int[] answer = list.Select(x => int.Parse(x.ToString())).ToArray();
                //    // answer = answer.Reverse();
                //    // long x = (long)Math.Sqrt(n);
                //     //  return (x * x == n) ? (x + 1) * (x + 1) : -1;
                //     // IEnumerable<int> squares = Enumerable.Range(1, (int)n).Select(x => x * x);
                //     // int nsquares = squares.Where(x => x * x==n).Max();
                //     //    .Count>0?Math.Pow(x + 1, 2):-1; 
                //     //int n = 5;
                //     //int x = 2;
                //     //long[] answer = new long[n];

                //     //for (long i = 0; i < n; i++)
                //     //{
                //     //    answer[i] = x * (i + 1);
                //     //}
                //   //  var squares = Enumerable.Range(1, n).Select(k => k *x);
                //   //  double[] answer = squares.ToArray();
                //   //  long answer = x * x == n ? (x+1)*(x+1) : -1;
                //   //Console.WriteLine(answer.ToString());
                ////    n = 12; answer = 0;
                //     //for (int i = 2; i < n; i++)
                //     //{
                //     //    if (n%i==1)
                //     //    {
                //     //        answer = i;
                //     //        break;
                //     //    }

                //     //}
                ////   answer = Enumerable.Range(3, n-2).Where(x => n % x == 1).Min();
                //   // Console.WriteLine(answer.ToString());

                //     //동류항 
                //     //   string s = "3x + 7 + x"; int hap = 0;

                //     //var list = s.Replace("+","").Split(' ').ToList();
                //     //var noxList = list.Where(i => !list.Contains("x"));
                //     //var xList = list.Where(i => list.Contains("x"));
                //     //xList = xList.Select(x => x.Replace("x", ""));
                //     //int xcount = xList.Where(x => x.Equals("")).Count();
                //     //int count = list.Sum(x => Convert.ToInt32(x));//에러
                //     //string re = String.Concat(xcount + "+" + "x" + "+" + count);
                //     //Console.WriteLine(re);
                //     ////  int xcount = list.Where(x=>!x.Equals("")).Sum(x => Convert.ToInt32(x));//에러


                //     //공던지기
                //     //  int answer = numbers[(k * 2 - 2) % numbers.Length]; 한줄풀이
                //   //  int[] numbers = { 1, 2, 3 }; int k = 3;
                //     int[] onumbers = new int[numbers.Length];

                //     //for (int i = 0; i < k; i++)
                //     //{
                //     //    onumbers = numbers.Concat(onumbers).ToArray();
                //     //}

                //     temp = 0; int p = 0;
                //     for (int i = 0; i < 3; i++)
                //     {

                //         temp = onumbers[i*2];
                //         Console.WriteLine(temp.ToString());

                //     }
                //     //수식이 옳다면 "O"를 틀리다면 "X"를 순서대로 담은 배열을 return하도록 solution 함수
                //     //ox 퀴즈
                //     //            ["3 - 4 = -3", "5 + 6 = 11"]	["X", "O"]
                //     //["19 - 6 = 13", "5 + 66 = 71", "5 - 15 = 63", "3 - 1 = 2"]	["O", "O", "X", "O"]
                //     //컨트롤 제트
                //     //var list = s.Split(' ').ToList();

                //     //while (list.Contains("Z"))
                //     //{
                //     //    list.RemoveRange(list.IndexOf("Z") - 1, 2);
                //     //}

                //     //answer = list.Sum(x => Convert.ToInt32(x));

                //     //Regex.Replace(my_string, @"\D", " ").Split(" ");
                //     //string s = ""; int hap = 0;
                //     //string[] sp = s.Split(" ");
                //     //for (int i = 0; i < sp.Length; i++)
                //     //{
                //     //    hap = sp[i] == "Z" ? hap- int.Parse(sp[i-1]) : hap + int.Parse(sp[i]);

                //     //}



                //     //string[] quiz = { "3 - 4 = -3", "5 + 6 = 11"};
                //     //string[] answer = new string[quiz.Length];
                //     //for (int i = 0; i < answer.Length; i++)
                //     //{
                //     //    string[] sp = quiz[i].Split(" ");
                //     //    if (sp[1].Trim().Contains("-"))
                //     //    {
                //     //        answer[i] = int.Parse(sp[0]) - int.Parse(sp[2]) == int.Parse(sp[4]) ? "O" :"X" ;

                //     //    }
                //     //    else
                //     //    {
                //     //        answer[i] = int.Parse(sp[0]) + int.Parse(sp[2]) == int.Parse(sp[4]) ? "O" : "X" ;
                //     //    }
                //     //   // Console.WriteLine(answer[i]);
                //     //}

                //     //영어가 싫어요
                //     string[] eng = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
                //     string sres = "onezerothreefourfivesixseveneightnine";
                //     //  string snum = string.Concat(sres.Replace(x => x == eng.Any(), Array.IndexOf(x).ToString()));
                //     foreach (var item in eng)
                //     {
                //         if (sres.Contains(item.ToString()))
                //         {
                //           sres=  sres.Replace(item, Array.IndexOf(eng,item).ToString());
                //         }
                //     }

                //   //  Console.WriteLine(sres);
                //     //// Console.WriteLine(sres.ToString());
                //     //long ans = long.Parse(sres.Trim());
                //     //int code3 = 99;
                //     //int num = 0;
                //     //char[] words = n.ToString().ToCharArray();
                //     //foreach (var item in words)
                //     //{
                //     //    answer += int.Parse(item.ToString());
                //     //}
                //     //string answer = num % 2 == 0 ? "Even" : "Odd";
                //     //if (num%2==0)
                //     //{

                //     //}
                //     n = 12;
                //  //   int sum = Enumerable.Range(1, n).Where(x=>n%x==0).Sum();
                //   ///  Console.WriteLine(sum.ToString());
                //  //   double[] arr = { 1, 2, 3, 4 };
                // //   sum = arr.Sum(x => x)/arr.Length;
                //  //   Console.WriteLine(sum.ToString());
                //     string sov(int bin1)
                //     {
                //         string answer = "";
                //         //char[] words = bin1.ToString().ToCharArray();
                ////         //words = words.Reverse();
                //         for (int i = 0; i < bin1; i++)
                //         {
                //             if (Math.Pow(2,i-1)<bin1&& Math.Pow(2, i + 1) > bin1)
                //             {

                //             }
                //         }

                //         return answer;
                //     }

                //double makeadd(string bin1,string bin2)
                //{
                //    if (bin1.Length!=bin2.Length)
                //    {
                //        string sshort = bin2.Length > bin1.Length ? bin1 : bin2;
                //        int temp=bin2.Length > bin1.Length ? bin2.Length - bin1.Length: bin1.Length - bin2.Length;
                //        string[] str1 = bin1.Split("").ToArray();
                //        string[] str2 = bin2.Split("").ToArray();
                //        List<string> lst1 = str1.ToList();
                //        List<string> lst2 = str2.ToList();

                //        for (int i = 0; i < temp; i++)
                //        {
                //            sshort = "0"+sshort;
                //        }
                //    }

                //    for (int i = 0; i < bin1.Length; i++)
                //    {

                //    }
                //   // return answer;
                //}
                double make(string bin1)
                {
                    double answer = 0;
                    char[] words = bin1.ToCharArray();
                    //words = words.Reverse();
                    for (int i = 0; i < words.Length; i++)
                    {
                        if (words[words.Length - 1 - i].ToString() == "1")
                        {
                            if (i == 0)
                            {
                                answer += 1;
                            }
                            else
                            {
                                answer += Math.Pow(2, i);
                            }

                        }

                    }

                    return answer;
                }
                //  Console.WriteLine(make("11")+make("10"));

                // char c3 = (char)code3;
                string smorse = ".--. -.-- - .... --- -.";
                string letter = "python";
                letter = "";

                // my_string = "aAb1B2cC34oOp";
                //my_string = "1a2b3c4d123Z";
                //string[] words = Regex.Replace(my_string, @"\D", " ").Split(" ");
                //int answer = 0;
                //foreach (var item in words)
                //{
                //    if (item.Trim()!="")
                //    {
                //        answer += int.Parse(item);
                //    }

                //}
                // Console.WriteLine(answer.ToString());
                // List<string> lmorse = cmorse.ToList();
                //97
                string[] morse = { ".-", "-...", "-.-.", "-..", ".", "..-.", "--.", "....", "..", ".---", "-.-", ".-..", "--", "-.", "---", ".--.", "--.-", ".-.", "...", "-", "..-", "...-", ".--", "-..-", "-.--", "--.." };
                //foreach ( var item in words)
                //{
                //    int c3 = Array.FindIndex(morse, x => x.ToString()==item)+97;

                //    letter += ((char)c3).ToString();
                //}
                //    Console.WriteLine(letter.ToLower());



                // = numbers.Where(x => x % 2 == 1).ToArray();
                // int result = onumbers[k % 2];
                //result =onumbers[(k % onumbers.Length)>0?( k % onumbers.Length)-1:k];
                // Console.WriteLine(result.ToString());
                // int result = 0;
                // [1, 2, 3, 4]	2   3  1->3 3>5 5>1 1->3 
                //[1, 2, 3, 4, 5, 6]  5   3
                ////[1, 2, 3]   3   2
                //string[] dic = { "sod", "eocd", "qixm", "adio", "soo" };
                //string[] spell = { "p", "o", "s" };
                //int cal = 0;
                //int cnt = 0;
                ////answer = 1;
                //for (int i = 0; i < dic.Length; i++)
                //{

                //    // int freq = str.Count(f => (f == ch));
                //    //int freq = str.Where(x => (x == ch)).Count();
                //    for (int j = 0; j < spell.Length; j++)
                //    {
                //        if (dic[i].ToString().Where(x => (x.ToString() == spell[j])).Count() == 1)
                //        {
                //            cnt++;
                //            dic = dic.Where((e, k) => k != i).ToArray();
                //        }
                //        if (cnt == dic.Length)
                //        {
                //            //answer = 1;
                //            //   Console.WriteLine(cnt.ToString());
                //            break;
                //        }
                //    }



                //}
                ////   Console.WriteLine(answer.ToString());
                //int[] sides = { 1, 2 };
                //ccount = 0;
                //int llong = sides[0] > sides[1] ? sides[0] : sides[1];
                //int sshort = sides[0] < sides[1] ? sides[0] : sides[1];
                //for (int i = 1; i < 1000; i++)
                //{
                //    if (i > llong)
                //    {
                //        ccount = sshort + llong > i ? ccount + 1 : ccount;
                //    }
                //    else if (Math.Pow(llong, 2) == Math.Pow(sshort, 2) + Math.Pow(i, 2))
                //    {
                //        ccount = llong > sshort + i ? ccount + 1 : ccount;
                //    }
                //    else if (Math.Pow(i, 2) == Math.Pow(sshort, 2) + Math.Pow(llong, 2))
                //    {
                //        ccount = sshort + llong < i ? ccount + 1 : ccount;
                //    }
                //    else
                //    {
                //        ccount = llong < sshort + i ? ccount + 1 : ccount;
                //    }

                //}

                ////  Console.WriteLine(ccount.ToString());
                ////나머지가 가장 긴변
                ////  sides[2] < sides[0] + sides[1]
                ////가장 짧은 변
                //for (int i = 0; i < llong; i++)
                //{
                //    ccount = llong > sides[1] + i ? ccount + 1 : ccount;
                //}
                // n = 3;
                int[] num_list = { 100, 95, 2, 4, 5, 6, 18, 33, 948 };
                //  int div = num_list.Length % d==0?num_list.Length/d: (num_list.Length / d)+1;
                //// int[,] answer = new int[,] { { } };
                //int[,] answer = new int[num_list.Length / n, n];
                //int index = 0; int count = 0;
                //for (int i = 0; i < num_list.Length; i++)
                //{
                //    for (int j = 0; j < n; i++)
                //    {
                //        answer[index, j] = num_list[i];
                //        if (j==n-1)
                //        {
                //            index++;
                //            j = 0;
                //        }
                //    }

                //}
                //for (int i = 0; i < num_list.Length; i++)
                //{

                //    answer[index, count] = num_list[i];
                //    count++;
                //    if (count == n)
                //    {
                //        index++;
                //        count = 0;
                //    }


                //}
                //for (int i = 0; i <= num_list.Length; i++)
                //{

                //        answer[index, count] = num_list[i];
                //        count++;
                //        if (count == n)
                //        {   
                //            index++;
                //            count = 0;
                //        }

                //// }
                //for (int i = 0; i < answer.GetLength(0); i++)
                //{
                //    for (int j = 0; j < answer.GetLength(1); j++)
                //    {
                //        Console.Write("answer[" + i + "," + j+ "]=" + answer[i, j] + " ");
                //    }
                //    Console.WriteLine();
                //}


                //////문자열 계산하기
                //n = 7;
                //int sol(int balls)
                //{
                //    int answer = 1;
                //    for (int i = balls; i >= 1; i--)
                //    {
                //        answer *= i;
                //    }
                //    return answer;
                //}
                //for (int i = 1; i <= n; i++)
                //{

                //    if (sol(i) >= n)
                //    {
                //        int jung = Math.Abs(n - sol(i)) > Math.Abs(n - sol(i - 1)) ? i - 1 : i;
                //        //   Console.WriteLine(jung.ToString());
                //        break;

                //    }
                //    else
                //    {

                //    }
                //}

                string ster = "olleh";

                //  my_string = "3+4";
                //  my_string =my_string.Trim();
                //res = 0;

                //  if (my_string.Contains("+"))
                //  {
                //      res += int.Parse(my_string.Substring(0, my_string.LastIndexOf('+')));
                //      res +=  int.Parse(my_string.Substring(my_string.LastIndexOf('+')));
                //  }
                //  else
                //  {
                //      res = int.Parse(my_string.Substring(0, my_string.LastIndexOf('-'))) - int.Parse(my_string.Substring(my_string.LastIndexOf('-')));
                //  }

                //  Console.WriteLine(res.ToString());
                //			int a = 11;
                //			int b = 22;

                //			string numbers = "onefourzerosixseven";
                //			string[] eng = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
                //			//char[] str = my_string.ToCharArray();
                //			string[] snum = new string[eng.Length];
                //			//+= Enumerable.Range(1, n).Count(x => i % x == 0) >= 3 ? 1 : 0;
                //			for (int i = 0; i <eng.Length; i++)
                //            {
                //                if (numbers.Contains(eng[i]))
                //                {
                //                    snum[i] = i.ToString();
                //                }
                //            }
                //			string str = string.Join("", snum);
                //			long anss = int.Parse(str);
                //           // Console.WriteLine(anss.ToString());
                //			//int answer = 0;
                //			//Dictionary<string, string> morse = new Dictionary<string,string>();
                //			//var nameQuery = from name in names
                //			//				where name.Length == 3
                //			//				select name;
                //			//foreach (string name in eng)
                //			//         {
                //			//	var 
                //			//         }
                //			//for (int i = 0; i < array.Length; i++)
                //			//{
                //			//	if (map.ContainsKey(array[i]))
                //			//	{
                //			//		map[array[i]]++;
                //			//	}
                //			//	else
                //			//	{
                //			//		map.Add(array[i], 1);
                //			//	}
                //			//}
                //			//var item = map.Where(x => x.Value == map.Values.Max()).Select(x => x.Key).ToArray();
                //			//if (item.Length > 1)
                //			//{
                //			//	answer = -1;
                //			//}
                //			//else
                //			//{
                //			//	answer = item[0];
                //			//}
                //			//return answer;

                //			//구슬개수 3 나눠줄 사람 2 결과 3
                //			//3C2
                //			//5*4*3/2*3
                //			int balls = 5; int share = 3;
                //			int solution(double balls, int share)
                //			{
                //				double answer = 1;
                //				for (int i = share; i >= 1; i--)
                //				{
                //					answer *= balls / i;
                //					balls--;
                //                    Console.WriteLine(answer.ToString());
                //				}
                //				Console.WriteLine(answer.ToString());

                //				return (int)answer;
                //			}
                //            Console.WriteLine(solution(5,3));
                //			int ans = 1;

                //			int n = 15;
                //			int count = 0;
                //			//int[] div = Enumerable.Range(1, n).Where(x => n % x == 0).ToArray();
                //            for (int i = 1; i <= n; i++)
                //            {
                //				//answer += Enumerable.Range(1, n).Count(x => i % x == 0) >= 3 ? 1 : 0;
                //				if (Enumerable.Range(1, i).Where(x => i % x == 0).ToArray().Count() >= 3)
                //                {
                //					count++;
                //				}
                //            }
                //			//for (int i = 1; i <= n; i++)
                //			//{
                //			//             //answer += Enumerable.Range(1, n).Count(x => i % x == 0) >= 3 ? 1 : 0;
                //			//             if (sol(i)<=n&&sol(i+1)>n)
                //			//             {
                //			//		count = i;
                //			//		return ;
                //			//		break;

                //			//             }
                //			//}

                //			//Console.WriteLine(count.ToString());

                //			//int share2 = balls - share>0? sol(balls - share):1;

                //			//		   ans = (sol(balls) / (sol(share)*share2));
                //			//         Console.WriteLine(ans);
                //			//고르는 순서는 고려안함
                //			//5,3,10
                //			// string answer = string.Concat(my_string.Distinct());
                //			//			morse = new Dictionary<string, string>(){
                //			//	{".-", "a"},{"--.", "g"},
                //			//	{"-...", "b"},{"....", "h"},
                //			//	{"-.-.", "c"},{"..", "i"},
                //			//	{"-..", "d"},{".---", "j"},
                //			//	{".", "e"},{".", "e"},
                //			//	{"..-.", "f"},{".", "e"},{".", "e"},

                //			//};
                //			//"hello"
                //			string answer  = {
                //                '.-':'a','-...':'b','-.-.':'c','-..':'d','.':'e',
                //					'..-.':'f',
                //			 '--.':'g','....':'h','..':'i','.---':'j','-.-':'k','.-..':'l',
                //			 '--':'m','-.':'n','---':'o','.--.':'p','--.-':'q','.-.':'r',
                //			 '...':'s','-':'t','..-':'u','...-':'v','.--':'w','-..-':'x',
                //			 '-.--':'y','--..':'z'};
                //        }
                //        //오른쪽
                //        //0324 배열회전
                //        int[] array = { 10, 11, 12 };
                //			string d = "r";
                //	        List<int> lst = array.ToList();
                //			int temp = lst[lst.Count - 1];
                //			if (d == "right")
                //			{
                //				lst.RemoveAt(lst.Count - 1);
                //				lst.Insert(0, temp);
                //			}
                //			else
                //			{
                //				temp = lst[0];
                //				lst.RemoveAt(0);
                //				lst.Add(temp);
                //			}
                //			//가까운수 한개 런타임 에러

                //			//int[] numbers = { 4, 455, 6, 4, -1, 45, 6 };

                //			//numbers = lst.ToArray();

                //			////왼쪽
                //			//int[] arrayc = new int[array.Length];

                //			//int n = 20;
                //   //         for (int i = 0; i < array.Length; i++)
                //   //         {
                //   //             arrayc[i] = Math.Abs(array[i] - n);
                //   //         }
                //			//int findIdx = Array.FindIndex(arrayc, x => x==arrayc.Min());
                //			//int result = array[findIdx];
                //   //         Console.WriteLine(result.ToString());
                //			////323 문자열 정렬하기
                //			//string my_string = "We are the world";
                //			//char[] str = my_string.ToCharArray();
                //			//str = str.Distinct().ToArray();
                //   //         Console.WriteLine(String.Join("", str));
                //			////int[] order = new int[emergency.Length];

                //			//for (int i = 0; i < order.Length; i++)
                //			//	order[i] = order.Length - i;

                //			//Array.Sort(emergency, order);
                //			int[] emergency = { 30, 10, 23, 6, 100 };
                //			int[] order = emergency.OrderByDescending(x => x).ToArray();
                //			//int[] answer = emergency.Select(x => Array.IndexOf(order, x) + 1).ToArray();
                //			// Array.Sort(emergency, order);
                //			//int[] answer = new int[emergency.Length];
                //			////List<int> reverseList = (emergency.Reverse()).ToList();
                //			////int[] emergencyr = reverseList.ToArray();
                //			////for (int i = 0; i < emergency.Length; i++)
                //			////{
                //			////	emergency[i] = Array.IndexOf(emergencyr, emergencyr[i]);

                //			////}
                //			////return emergency;
                //			////answer = emergency.Reverse();
                //			//// Console.WriteLine(String.Join(',', array));
                //			////	List<int> reverseList = Enumerable.Reverse(emergency).ToList();
                //			/////	int[] emergencyr = reverseList.ToArray();
                //			//for (int i = 0; i < emergency.Length; i++)
                //   //         {
                //   //             for (int j = 0; j < emergency.Length; j++)
                //   //             {
                //   //                 if (emergency[i] <= emergency[j])
                //   //                 {
                //			//			answer[i]++;
                //   //                 }
                //   //             }
                //   //             //Console.WriteLine(emergency[i].ToString());
                //			//}

                //			////while (age > 0)//내가 하고싶었던 끊어서 비교
                //			////{

                //			////	answer = (char)(age % 10 + 97) + answer;97씩 더하면 아스키값 반환가능
                //			////	age /= 10;
                //			////}
                //			//string age = "230";
                //			//string abd = "abcdefghijklmnopqrstuvwxyz";
                //			//char[] stag = age.ToCharArray();
                //			////string answer = "";
                //   //         for (int i = 0; i < stag.Length; i++)
                //   //         {
                //			//	int index = int.Parse(stag[i].ToString());
                //			////	answer += abd.Substring(index, 1);

                //			//}
                //			//Console.WriteLine(intage);


                //			//string intage = abd.Substring(int.Parse(age) / 10, 1) + abd.Substring(int.Parse(age) % 10, 1);

                //			int num = 29183;
                //			int k = 1;
                //			int loc = num.ToString().IndexOf("1");
                //			//int answer = num.ToString().IndexOf(k.ToString()) + 1;
                //			//return answer == 0 ? answer - 1 : answer;
                //			//if (answer!=-1)
                //   //         {
                //			//	answer++;
                //   //         }
                //			//인덱스 0부터 시작
                //		//	//Console.WriteLine(loc+1);
                //		//	int[] numbers = { 1, 2, -3, 4, -5 };
                //		//	Array.Reverse(numbers);

                //		//	Console.WriteLine("직각삼각형 출력하기");


                //		//	Console.WriteLine("최댓값만들기 0317");
                //		//	//int maxLen = numbers.Length - 1;
                //		//	//Array.Sort(numbers);
                //		//	//return (int)MathF.Max(numbers[0] * numbers[1], numbers[maxLen] * numbers[maxLen - 1]);
                //		//	List<int> list = new List<int>();
                //		//	for (int i = 0; i < numbers.Length; i++)
                //  //          {
                //  //              for (int j = 0; j < numbers.Length; j++)
                //  //              {
                //  //                  if (i!=j)
                //  //                  {
                //		//				list.Add(numbers[i] * numbers[j]);
                //  //                  }
                //  //              }
                //  //          }
                //		//	//answer = list.Max();
                //		//	//Math.Abs
                //		//	//int uniqueFactors = array.Distinct().Count();//배열의 요소 개수 세기
                //		//	Console.WriteLine("엔코01");
                //		//	//string[] input2 = input[0].Split(' ');
                //		//	var inputt = "";
                //		//	Console.WriteLine("주사위갯수 0317");
                //		//	int ju = 3;
                //		//	int[] box = { 10, 8, 6 };
                //		//	//int[] newarray = numlist.Where(x => x % nameof != 0).Toarray();
                //  // //         foreach (var item in numlist)
                //  // //         {
                //  // //             if (item%n!=0)
                //  // //             {
                //		//	//		numlist.
                //  // //             }
                //  // //         }

                //  //          int bot = box[2] / ju;
                //		//	int hi = box[1] / ju;
                //		//	int garo = box[0] / ju;
                //		//	int rt = garo * bot * hi;
                //		//	Console.WriteLine(rt);

                //  //          //       for (int i = 0; i < 10; i++)
                //  //          //       {
                //  //          //inputt+=	Console.ReadLine();
                //  //          //       }
                //  //          //List<int> list = new List<int>();
                //  //          //foreach (var it in my_string)
                //  //          //{
                //  //          //	if (int.TryParse(it.ToString(), out var value))
                //  //          //	{
                //  //          //		list.Add(value);
                //  //          //	}
                //  //          //}


                //		//	//list.Sort();
                //		//	//return list.ToArray();
                //		//	Console.WriteLine("세균증식 0317");
                //		//	//int n = 2;
                //		//	int t = 10;

                //  //          for (int i = 0; i < t; i++)
                //  //          {
                //		//		n *= 2;
                //  //          }
                //		//	// int answer = n * (int)Math.Pow(2, t);
                //		//	Console.WriteLine("문자열정렬 0317");
                //		//	//string my_string = "hi12392";
                //		//	string a = "";
                //		//	List<int> lst = new List<int>();
                //		//	lst.Reverse();

                //		//	foreach (var item in my_string)
                //		//	{
                //  //              if (item.ToString().All(char.IsDigit))
                //  //              {
                //		//		//	a += item.ToString();
                //		//			lst.Add(int.Parse(item.ToString()));
                //  //              }

                //		//	}
                //		//	lst.Sort();
                //		//	//int[] answer = lst.ToArray();
                //		//	//Console.WriteLine(lst.ToString());
                //		//	Console.WriteLine("[{0}]", string.Join(", ", lst));
                //		//	Console.WriteLine("암호해독 0317");
                //		//	string cipher = "dfjardstddetckdaccccdegk";
                //		//	//public string solution(string cipher, int code)
                //		//	//{
                //		//	//	string answer = String.Concat(cipher.Where((x, i) => (i + 1) % code == 0));
                //		//	//	return answer;
                //		//	//}
                //		//	//string answer = "";
                //		//	//for (int i = 0; i < cipher.Length + 1; i++)
                //		//	//	if (i % code == 0 && i != 0)
                //		//	//		answer += cipher[i - 1];
                //		//	//return answer;
                //		//	cipher = " " + cipher;
                //		//	int code = 4;

                //		//	string re = "";
                //		//	char[] s = cipher.ToCharArray();
                //		//	for (int i = code; i <s.Length; i++)
                //		//	{
                //  //              if (i%code==0)
                //  //              {
                //		//			re += s[i].ToString();
                //  //              }
                //		//	}
                //  //          Console.WriteLine(re);
                //		//		Console.WriteLine("가바보 0317");
                //		//	my_string = "205";
                //		//	string an = "";
                //  //          foreach (var item in my_string)
                //  //          {
                //  //              if (item=='2')
                //  //              {
                //		//			an += "0";
                //  //              }
                //		//		else if (item == '0')
                //		//		{
                //		//			an += "5";
                //		//		}
                //		//		else 
                //  //              {
                //		//			an += "2";
                //		//		}

                //  //          }
                //  //          Console.WriteLine(an);
                //		//	Console.WriteLine("대문자소문자 0317");
                //		//	my_string = "abCdEfghIJ";
                //		//	string ans = "";
                //		//	//char[] str = my_string.ToCharArray();
                //  //          for (int i = 0; i <my_string.Length; i++)
                //  //          {
                //  //              if (char.IsUpper(str[i]))
                //  //              {
                //		//			str[i] = char.Parse(str[i].ToString().ToLower());

                //		//		}
                //  //              else if (char.IsLower(str[i]))
                //  //              {
                //		//			str[i] = char.Parse(str[i].ToString().ToUpper());
                //		//		}
                //		//		ans += str[i].ToString();
                //  //          }
                //  //          Console.WriteLine(ans);

                //		//	Console.WriteLine("최빈값 0316");

                //		////	int[] array = new int[] { 1, 2, 3, 3,4,4,5,5,5,5,4};
                //		//	//	array = new int[] { 1, 1, 2, 2 };
                //		////	array = new int[] { 1 };

                //		//	//	List<int> list = array.ToList();
                //		//	//var countDic = list.GroupBy(e => e).ToDictionary(g => g.Key, g => g.Count());
                //		//	//int maxVal = countDic.Values.Max();
                //		//	//int criteria = countDic.Where(g => g.Value == maxVal).Select(g => g.Key).Count();
                //		//	//int result6 = criteria == list.Count() ? -1 : countDic.Where(g => g.Value == maxVal).Select(g => g.Key).Count();
                //		//	//         Console.WriteLine(result6);

                //		//	int[] datas = new int[] { 1, 2, 3, 3, 4, 4, 5, 5, 5, 5, 4 };


                //		//	// [2] Process

                //		//	// LINQ || lamda || query expression
                //		//	// var q = datas.GroupBy(d => d).OrderByDescending(g => g.Count()).First();
                //		//	// count = q.Count();
                //		//	// mode = q.Key;
                //		//	int[] indexes = new int[datas.Max() + 1]; // 0 ~ 5까지 점수 인덱스의 갯수
                //		//	int count = int.MinValue; // MAX 알고리즘 적용
                //		//	int mode = 0; // 최빈값이 담긴 그룻
                //		//	//datas = datas.Distinct().ToArray();
                //		//	foreach (int d in datas)
                //		//	{
                //		//		indexes[d]++;
                //		//	}
                //		//	for (int i = 0; i < indexes.Length; i++)
                //		//	{
                //		//		if (indexes[i] > count)
                //		//		{
                //		//			mode = i;
                //		//			count = indexes[i];
                //		//		}
                //		//	}
                //		//	//indexes = indexes.Distinct().ToArray();
                //		//	Array.Reverse(indexes);
                //		//	if (indexes.Length > 1 && indexes[0] == indexes[1])
                //		//	{
                //		//		count = -1;

                //		//	}
                //		//	Console.WriteLine(count);
                //		//	int[] distArray = array.Distinct().ToArray();
                //  //          int temp = -1; int number = array.Min();
                //  //          int[] arraycount = new int[distArray.Length];
                //  //         //Console.WriteLine(arraycount.Length);
                //  //          for (int i = 0; i < distArray.Length; i++)
                //  //          {
                //  //              arraycount[i] = array.Count(x => x == distArray[i]);
                //		//		//Console.WriteLine(arraycount[i]);
                //		//		if (arraycount[i] > temp)
                //  //              {
                //  //                  number = distArray[i];
                //		//			temp = arraycount[i];
                //		//		}

                //  //          }
                //  //          Array.Reverse(arraycount);

                //  //          //int mode = x.GroupBy(v => v).OrderByDescending(g => g.Count()).First().Key;
                //  //          if (arraycount.Length > 1 && arraycount[0] == arraycount[1])
                //  //          {
                //  //              number = -1;

                //  //          }

                //            // 딕셔너리 구성(key = 숫자, value = 리스트 내의 개수)
                //   //        
                //			////// 딕셔너리 아이템의 중복 개수가 중복 개수의 최대값과 동일한 아이템 개수 계산
                //			//int maxVal = countDic.Values.Max();
                //			//int criteria = countDic.Where(g => g.Value == maxVal).Select(g => g.Key).Count();
                //			////// 동일한 아이템 개수 == 리스트의 항목 개수인 경우(즉, 모두 같거나, 모두 다르거나) 최빈값 없음
                //			//int result = criteria == list.Count() ? -1 : countDic.Where(g => g.Value == maxVal).Select(g => g.Key);
                //			//	// 그렇지 않은 경우 딕셔너리 키(리스트 항목)(들을) 반환
                //			//	
                //			//Console.WriteLine(number);

                //			//Console.WriteLine("기약뷴슈 0316");
                //			////int numer1 = 1; int denom1 = 2; int numer2 = 3; int denom2=4;
                //			//int numer1 = 9; int denom1 = 2; int numer2 = 1; int denom2 = 3;
                //			//int result1 = 0; int result2 = 0;
                //			//numer1 *= denom2;
                //			//numer2 *= denom1;
                //			//result1 = (numer1 + numer2); 
                //	  //      result2=(denom1 * denom2);
                //			//int div = 0; int gonyak = 1;
                //   //         if (result1>result2)
                //   //         {
                //			//	div = result2;
                //   //         }
                //   //         else
                //   //         {
                //			//	div = result1;
                //			//}
                //   //         for (int i = div; i > 1; i--)
                //   //         {
                //   //             if (result1%i==0&&result2%i==0)
                //   //             {
                //			//		gonyak = i;// 최대공약수

                //			//	}
                //   //         }
                //			//result1 = result1 / gonyak;
                //			//result2 = result2 / gonyak;
                //			//Console.WriteLine("{0} {1}",result1,result2);
                //			//Console.WriteLine("제곱수 판별 0316");
                //			////int answer = 0;
                //			////int k = 144;
                //			//k = 976;
                //			//for (int i = 2; i < k; i++)
                //			//{
                //			//	if (Math.Pow(i, 2) == k)
                //			//	{
                //			//		answer = 1;
                //			//		break;
                //			//	}
                //			//	else
                //			//	{
                //			//		answer = 2;

                //			//	}
                //			//}
                //   //             Console.WriteLine(answer);
                //				Console.WriteLine("옹알이0316");
                //			//int answer = 0;
                //			//string[] babbling = new string[] { "aya", "yee", "u", "maa", "wyeoo" };
                //			string[] babbling = new string[] { "ayaye", "uuuma", "ye", "yemawoo", "ayaa" };	
                //			string[] ba = new string[] { "aya", "ye", "woo", "ma" };
                //            for (int i = 0; i < babbling.Length; i++)
                //            {
                //                for (int j = 0; j < ba.Length; j++)
                //                {
                //                    if (babbling[i].Trim()!=""&&babbling[i].Contains(ba[j]))
                //                    {
                //						babbling[i]=babbling[i].Replace(ba[j], " ");
                //					//	ba[j] = ba[j].Replace(ba[j], "");
                //						Console.WriteLine("?");
                //                    }
                //                }
                //            }
                //			for (int i = 0; i < babbling.Length; i++)
                //			{
                //                if (babbling[i].Trim()=="")
                //                {
                //					//answer++;
                //                }
                //                Console.WriteLine(babbling[i]);
                //			}

                //		//	Console.WriteLine(answer);
                //			Console.WriteLine("1번");
                //			//1~n번 역까지 운행하는 기차: n 3~500
                //			//trains 원소: [s번역부터, e번역까지, 최대수용인원]
                //			//bookings 원소:[a번역에서 승차, b번역에서 내림]
                //			//1<=a<b<=n
                //			int bookl = 9;
                //			//int n = 5;
                //			int[,] trains = new int[,] { { 1, 5 }, { 1, 3 }, { 2, 5 }, { 2, 4 }, { 2, 4 }, { 3, 5 }, { 4, 5 } };
                //			int[,] bookings = new int[,] { { 1,3},{ 2,5},{ 3,7},{ 4,7},{ 5,6},{ 6,7},{ 5,7} };

                //			int res = 0;


                //			//n=5, 
                //            //최대한 많은: 그리디
                //            //수용인원 초과할경우 환승이용


                //			Console.WriteLine("2번");
                //			//샐러리라는 글자중 일부만 포함해도 같다고 인식
                //			int check = 0;

                //			string text = "salary";
                //			//char[] ca = text.ToCharArray();
                //			//string[] ca = str.Split(new char[] { '' });
                //			//string[] input2= ca.ToArray();
                //			string[] input = new string[] { "salary 10000", "payback 400000", "salbry 50000" };
                //			string[] input2 = input[0].Split(' ');

                //			//string[,] arrScore = new string[input.Length, input.Length];
                //			//         for (int i = 0; i < arrScore.GetLength(0); i++)
                //			//         {
                //			//	for (int j = 0; i < arrScore.GetLength(1); j++)
                //			//	{
                //			//                 arrScore[i,j]=
                //			//	}
                //			//}
                //			int money = 0;
                //			//int[] result = new int[input.Length];
                //			//for (int i = 0; i < input.Length; i++)
                //   //         {
                //			//	check = 0;
                //			//	input2 = input[i].Split(' ');

                //			//	foreach (var item in text)
                //   //             {
                //   //                 if (input2[0].Contains(item.ToString()))
                //   //                 {
                //			//			check++;
                //			//			//Console.WriteLine(input2[0]);
                //			//		}
                //   //             }
                //   //             if (check>=4)
                //   //             {
                //			//		result[i] = 1;
                //			//		money+=int.Parse(input2[1]);

                //			//	}


                //			//}
                //            Console.WriteLine(money);

                //			Console.WriteLine("3번");
                //			//(3보다큰~) n개의 노드로 이루어진 트리 각노드에는 0번~n-1까지 숫자
                //			//조건을 만족하는 순서쌍 갯수(i,j,k)
                //			//distance(a,b) :a번~b번 경로상 간선갯수
                //			//d(i,j)+d(j,k)=d(i,k)
                //			//edges[ㅍ1,ㅍ2] ㅍ1,ㅍ2 사이 간선 존재 
                //			//
                //			n = 5;
                //			int[,] edges = new int[,] { { 0,1},{ 0,2},{ 1,3},{ 1,4} };//4행 2열
                //			//         for (int i = 0; i < edges.GetLength(0); i++)
                //			//         {
                //			//	for (int j = 0; j < edges.GetLength(1); j++)
                //			//	{
                //			//                 edges[i,j] = int.Parse(Console.ReadLine());
                //			//	}
                //			//}
                //			//int res3 = 16;
                //			//n = 4;
                //			//         edges =new int[,] { {2,3},{ 0,1},{ 1,2} };
                //			//res3 = 8;
                //			Console.WriteLine(Math.Pow(2, edges.GetLength(0)));
                //			//Console.WriteLine(2 ^ edges.GetLength(0));
                //			//int read = int.Parse(Console.ReadLine());
                //			//edges = new int[,] { { 2, 3 }, { 0, 1 }, { 1, 2 } };
                //			int[,] lines = new int[n-1, n];
                //            for (int i = 0; i < lines.GetLength(0); i++)
                //            {
                //				for (int j = 0; j < lines.GetLength(1); j++)
                //				{

                //				}
                //			}
                //			//i,j,k/ i,j/j,k/i,j
                //			//0 1 2 1 1 2
                //			//0 1 3 1 2 3
                //			//0 2 3 2 1 3
                //			//1 2 3 1 1 2
                //			//2 1 0 1 1 2
                //			//3 1 0 1 2 3
                //			//3 2 0 1 2 3
                //			//3 2 1 1 1 2
                //			//var matches = Regex.Matches(text, "[s]");
                //			//var matches = Regex.Matches(text, @"<([^<>]+)>");
                //			//Console.WriteLine(matches);

                //			//	
                //			//if (str.Contains(target))
                //			//{
                //			//	Console.WriteLine("{0}를 찾았습니다.", target);
                //			//}
                //			//else
                //			//{
                //			//	Console.WriteLine("{0}를 찾지 못했습니다.", target);
                //			//}

                //			//Console.ReadKey();
            }
        }
    }
}

