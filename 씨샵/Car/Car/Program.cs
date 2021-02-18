using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Car
{
    class Program
    {
        //씨샵에서는 COSNT자체에 정적변수 개념 포함되어 있음
        const int MENU_ADD = 1;
        const int MENU_VIEW = 2;
        const int MENU_RANDDOM_ADD = 3;
        const int MENU_DELETE = 4;
        const int MENU_DELETE_ALL = 5;
        const int MENU_UPDATE = 6;
        const int MENU_EXIT = 7;

        static List<Student> addrList =
            new List<Student>();
        static Student stud;

        static void Main(string[] args)
        {
            stud = Student.getInst();
            while (true)
            {
                switch (getMenu())
                {
                    case MENU_ADD:
                        addItem();
                        break;
                    case MENU_VIEW:
                        viewItem();
                        break;
                    case MENU_RANDDOM_ADD:
                        addrandom();
                        break;
                    case MENU_DELETE:
                        deleteItem();
                        break;
                    case MENU_UPDATE:
                        updateItem();
                        break;
                    case MENU_DELETE_ALL:
                        deleteItemAll();
                        break;

                    case MENU_EXIT:
                        Console.WriteLine("프로그램 종료");
                        Environment.Exit(0);
                        break;


                }
            }
        }
        public static int getMenu()
        {
            Console.WriteLine("----------------------");
            Console.WriteLine("   주소록 관리 v1.0 ");
            Console.WriteLine("----------------------");
            Console.WriteLine("1. 주소록 정보 추가");
            Console.WriteLine("2. 주소록 정보 보기");
            Console.WriteLine("3. 랜덤 데이터 추가");
            Console.WriteLine("4. 데이터 삭제");
            Console.WriteLine("5. 데이터 모두 삭제");
            Console.WriteLine("6. 데이터 업데이트");
            Console.WriteLine("7. 종료");
            Console.WriteLine("-------------------");
            Console.WriteLine("메뉴 선택: ");
            int menu = Convert.ToInt32(Console.ReadLine());
            return menu;


        }

        public static void addItem()
        {
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
            addrList.Add(new Student(name, tel, address, email));
            Console.WriteLine("정보가 정상적으로 입력되었습니다.");
        }
        public static void viewItem()
        {
            for (int i = 0; i < addrList.Count; i++)
            {
                Console.WriteLine("이름: " + addrList[i].Name);
                Console.WriteLine("전화: " + addrList[i].Tel);
                Console.WriteLine("주소: " + addrList[i].Address);
                Console.WriteLine("이메일: " + addrList[i].Email);
                Console.WriteLine("-----------------------------------");

            }
        }
        public static void addrandom()
        {

            string[] name = { "홍길동", "김길동", "이길동", "박길동", "최길동" };
            string[] tel = { "010-3524-4767", "010-3733-2356", "010-3764-3362", "010-3763-2723", "010-3622-2263" };
            string[] address = { "대구시 동구 신암4동 ", "서울시 동구 신암4동","광주시 동구 신암4동",
                "인천시 동구 신암4동", "부산시 동구 신암4동"};
            string[] email = { "hong@naver.com", "lee@gmail.com", "park@daum.net", "choi@hanmail.net", "kim@gmail.com" };
            Random r = new Random();
            for (int i = 0; i < 5; i++)
            {
                addrList.Add(new Student(name[r.Next(0, 5)], tel[r.Next(0, 5)], address[r.Next(0, 5)], email[r.Next(0, 5)]
                    ));
            }
        }
        static void deleteItem()
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
        static void deleteItemAll()
        {

            Console.WriteLine("---------------------");
            Console.WriteLine("!주소록 정보를모두 삭제!");
            Console.WriteLine("---------------------");
            Console.WriteLine("삭제를 진행하시겠습니까? ");
            addrList.Clear();


        }
        static void updateItem()
        {
            Console.WriteLine("---------------------");
            Console.WriteLine("주소록 정보 업데이트");
            Console.WriteLine("---------------------");
            Console.WriteLine("업데이트할 이름을 입력: ");

            string na = Console.ReadLine();

            for (int i = 0; i < addrList.Count; i++)
            {
                if (na.Equals(addrList[i].Name))
                {
                    addrList.RemoveAt(i--);

                }
                
            }
            addItem();
         

        }
    }
}
    

