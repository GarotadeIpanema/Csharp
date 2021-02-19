﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerManager
{
    class CustomerHandler
    {
        static List<Customer> addrList =
              new List<Customer>();
        static Customer stud;

        static Random r = new Random();

        

        public void addItem( ){
            Console.WriteLine("---------------------");
            Console.WriteLine("주소록 정보를 입력");
            Console.WriteLine("---------------------");
            Console.WriteLine("이름: ");
            string name = Console.ReadLine();
            Console.WriteLine("전화: ");
            string tel = Console.ReadLine();
            Console.WriteLine("주소: ");
            string address = Console.ReadLine();
            Console.WriteLine("이메일: ");
            string email = Console.ReadLine();

            stud.Name = name;
            stud.Tel = tel;
            stud.Address = address;
            stud.Email = email;
            addrList.Add(new Customer(name, tel, address, email));
            Console.WriteLine("정보가 정상적으로 입력되었습니다.");
        }
        public void viewItem()
        {
            for (int i = 0; i < addrList.Count; i++)
            {
                Console.WriteLine("이름: " + addrList[i].Name);
                Console.WriteLine("아이디: " + addrList[i].Id);
                Console.WriteLine("전화: " + addrList[i].Tel);
                Console.WriteLine("주소: " + addrList[i].Address);
                Console.WriteLine("이메일: " + addrList[i].Email);
                Console.WriteLine("-----------------------------------");

            }
        }
        public void addrandom()
        {

            string[] name = { "홍길동", "김길동", "이길동", "박길동", "최길동" };
            string[] tel = { "010-3524-4767", "010-3733-2356", "010-3764-3362", "010-3763-2723", "010-3622-2263" };
            string[] address = { "대구시 동구 신암4동 ", "서울시 동구 신암4동","광주시 동구 신암4동",
                "인천시 동구 신암4동", "부산시 동구 신암4동"};
            string[] email = { "hong@naver.com", "lee@gmail.com", "park@daum.net", "choi@hanmail.net", "kim@gmail.com" };
            Random r = new Random();
            for (int i = 0; i < 10; i++)
            {
                addrList.Add(new Customer(getId(), name[r.Next(0, 5)], tel[r.Next(0, 5)], address[r.Next(0, 5)], email[r.Next(0, 5)]
                    ));


            }

        }
        public void deleteItem()
        {
            Console.WriteLine("---------------------");
            Console.WriteLine("주소록 정보를 삭제");
            Console.WriteLine("---------------------");
            Console.WriteLine("삭제할 이름을 입력: ");


            string na = Console.ReadLine();

            for (int i = 0; i < addrList.Count; i++)
            {
                if (na.Equals(addrList[i].Name))
                {
                    addrList.RemoveAt(i--);

                }


            }
        }
        // 자료구조(데이터 베이스 엔진, 효율성 탐구)
        //        int cnt = 0;
        //        while(cnt<addrList.Count){
        //                 if(name.Equals(addrList[cnt].Name)){
        //                          addrList.RemoveAt(cnt);}
        //    else{
        //              cnt++;}

        public void deleteItemAll()
        {

            Console.WriteLine("---------------------");
            Console.WriteLine("!주소록 정보를모두 삭제!");
            Console.WriteLine("---------------------");
            Console.WriteLine("삭제를 진행하시겠습니까? ");
            addrList.Clear();


        }
        public void updateItem()
        {
            Console.WriteLine("---------------------");
            Console.WriteLine("주소록 정보 업데이트");
            Console.WriteLine("---------------------");
            Console.WriteLine("업데이트할 아이디를 입력: ");
            string id = Console.ReadLine();
            Console.WriteLine("1. 이름");
            Console.WriteLine("2. 전화번호");
            Console.WriteLine("3. 주소");
            Console.WriteLine("4. 이메일");
            Console.WriteLine("5. 모든 항목 업데이트");
            Console.WriteLine("업데이트할 항목 번호를 입력: ");

            int number = Convert.ToInt32(Console.ReadLine());

            switch (number)
            {
                case 1:

                    Console.WriteLine("새로운 이름을 입력하세요: ");
                    string newna = Console.ReadLine();

                    for (int i = 0; i < addrList.Count; i++)
                    {
                        if (id.Equals(addrList[i].Id))
                        {

                            addrList[i].Name = newna;

                        }
                    }
                    Console.WriteLine("이름이 " + newna + " 로 변경되었습니다!");
                    break;
                case 2:
                    Console.WriteLine("새로운 전화번호를 입력하세요: ");
                    string newte = Console.ReadLine();

                    for (int i = 0; i < addrList.Count; i++)
                    {
                        if (id.Equals(addrList[i].Id))
                        {

                            addrList[i].Tel = newte;
                        }

                    }
                    Console.WriteLine("전화번호가 " + newte + " 로 변경되었습니다!");
                    break;
                case 3:

                    Console.WriteLine("새로운 주소을 입력하세요: ");
                    string newad = Console.ReadLine();
                    for (int i = 0; i < addrList.Count; i++)
                    {
                        if (id.Equals(addrList[i].Id))
                        {

                            addrList[i].Address = newad;

                        }

                    }
                    Console.WriteLine("주소가 " + newad + " 로 변경되었습니다!");
                    break;
                case 4:

                    Console.WriteLine("새로운 이메일을 입력하세요: ");
                    string newem = Console.ReadLine();
                    for (int i = 0; i < addrList.Count; i++)
                    {
                        if (id.Equals(addrList[i].Id))
                        {

                            addrList[i].Email = newem;

                        }

                    }
                    Console.WriteLine("이메일이 " + newem + " 로 변경되었습니다!");
                    break;
                case 5:
                    Console.WriteLine("모든 항목이 업데이트됩니다!");
                    for (int i = 0; i < addrList.Count; i++)
                    {
                        if (id.Equals(addrList[i].Id))
                        {
                            addrList.RemoveAt(i--);

                        }
                        addItem();
                        break;

                    }
                    viewItem();
                    Console.WriteLine("위와 같이 정보가 변경됩니다!");

                    break;

            }

        }
        public string getId()
        {

            string rdata =
                "adcdefghijklmnotqrstuvwxyz012345456789ABCDEFGHIJKLMNOPQRSTUVWXYZ~!@#$%^&?";
            StringBuilder rs = new StringBuilder();
            for (int i = 0; i < 10; i++)
            {
                rs.Append(rdata[(int)(r.NextDouble() * rdata.Length)]);
            }
            //Console.WriteLine("id: " + rs.ToString());
            //append  차곡차곡 붙이는 것
            return rs.ToString();

        }



    }
}
