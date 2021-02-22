using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerManager
{
    class Randata
    {

        static string[] name = { "홍길동", "김길동", "이길동", "박길동", "최길동" };
        static string[] tel = { "010-3524-4767", "010-3733-2356", "010-3764-3362", "010-3763-2723", "010-3622-2263" };
        static string[] address = { "대구시 동구 신암4동 ", "서울시 동구 신암4동","광주시 동구 신암4동",
                "인천시 동구 신암4동", "부산시 동구 신암4동"};
        static string[] email = { "hong@naver.com", "lee@gmail.com", "park@daum.net", "choi@hanmail.net", "kim@gmail.com" };

        Random r;

        public Randata(Random r)
        {
            this.r = r;
        }

        public string getName()
        {
            return name[r.Next(0, 5)];
        }

        public string getTel()
        {
            return tel[r.Next(0, 5)];
        }

        public string getAddr()
        {
            return address[r.Next(0, 5)];
        }
        public string getEmail()
        {
            return email[r.Next(0, 5)];
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
