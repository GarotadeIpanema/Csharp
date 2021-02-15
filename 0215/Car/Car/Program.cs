using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car
{
    class Program
    {
        static void Main(string[] args)
        {
            String[] name = { "홍길동", " 김길동", "박길덩", "이길동", "최길동" };
            String[] tel = {"010-3524-4767","010-3733-2356","010-3764-3362","010-3763-2723","010-3622-2263"};
            String[] address = { "대구시 동구 신암4동 ", "서울시 동구 신암4동","광주시 동구 신암4동",
                "인천시 동구 신암4동", "부산시 동구 신암4동"};
            String[] model = { "SM6", "소나타", "산타페", "K7", "그랜져" };
            String[] color = { "드래곤 블루", "오랜지레드", "화이트", "실버", "블랙" };
            int[] year = { 2017, 2018, 2019, 2020, 2021 };
            String[] company = { "삼성 르노", "현대", "기아", "포드", "테슬라" };
            Car[] c = new Car[10];
            Random r = new Random();
            for(int i = 0; i < c.Length; i++)
            {   string strName = name[r.Next(0, 5)];
                string strTel = tel[r.Next(0, 5)];
                string strAddress = address[r.Next(0, 5)];
                string strModel = model[r.Next(0, 5)];
                string strColor = color[r.Next(0, 5)];
                int intYear = year[r.Next(0, 5)];
                string strCompany = company[r.Next(0, 5)];
                c[i] = new Car(strName, strTel, strColor, strModel, strAddress, intYear, strCompany);
                
                c[i].showCustomerInfo();
                
            }


        }
    }
}
