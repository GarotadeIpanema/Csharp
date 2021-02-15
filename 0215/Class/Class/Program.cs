using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class
{
    class Program
    {
        static void Main(string[] args)
        {

            //int[] arr = { 10, 20, 30, 40, 50, 60, 70, 80, 90, 100 };

            ////Arraytest1 at1 = new Arraytest1(arr);
            ////Arraytest1 at2 = new Arraytest1();
            ////at2.sumAvg(arr);
            //Arraytest1 at3 = new Arraytest1();
            //at3.setArray(arr);
            //at3.sumAvg();
            int[,] arr =
            new int[5, 3]{
                {100,90,80 }, {80,90,60}, {80, 50,60},{80,80,60},{90,50,60}
            };
           Studentscore st = new Studentscore(arr[0,0], arr[0,1],arr[0,2]);


        //    for (int i = 0; i < 5; i++)
        //    {
        //        new Studentscore(
        //            arr[i, 0], arr[i, 1], arr[i, 2]);
        //        st.calculator();

        //    }
        //}
        Studentscore[] arrSt = new Studentscore[5];
           for(int i=0;i<5;i++){
                
            arrSt[i] = new Studentscore();
                for(int j=0;j<3;j++)
            {
                    if (j == 0) {
                        arrSt[i].Kor = arr[i, j];
                    }
                    else if(j == 1)
                    {
                        arrSt[i].Kor = arr[i, j];
                    }
                    else if (j == 2)
                    {
                        arrSt[i].Kor = arr[i, j];
                    }
                    else if (j == 3)
                    {
                        arrSt[i].Kor = arr[i, j];
                    }

                }




    }
}
}
