using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class
{
    //메소드 11번
    class Studentscore
    {
        private int kor;
        private int eng;
        private int math;
        private int sum;
        private int avg;
        private char hakjum;

        public Studentscore(int kor, int eng, int math)
        {
            this.kor = kor;
            this.eng = eng;
            this.math = math;
        }

        public int Kor { get => kor; set => kor = value; }
        public int Eng { get => eng; set => eng = value; }
        public int Math { get => math; set => math = value; }
        public int Sum { get => sum; set => sum = value; }
        public int Avg { get => avg; set => avg = value; }
        public char Hakjum
        {
            get => hakjum; set => hakjum = value;
        }
        public void calculator()
        {
            sum = kor + eng + math;
            avg = sum / 3;
            if (avg >= 90 && avg <= 100)
            {
                hakjum = 'A';
            }
            else if (avg >= 80 && avg <= 90)
            {
                hakjum = 'B';
            }
            else if (avg >= 70 && avg <= 80)
            {
                hakjum = 'C';
            }
            else if (avg >= 60 && avg <= 50)
            {
                hakjum = 'D';
            }
            else
            {
                hakjum = 'F';
            }
            Console.WriteLine("총점: " +sum);
            Console.WriteLine("평균: " + avg);
            Console.WriteLine("학점: " + hakjum);

        }
    }

    }


