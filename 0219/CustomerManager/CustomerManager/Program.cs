using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CustomerManager
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

        static List<Customer> addrList =
                new List<Customer>();
        
        static Random r = new Random();

        static void Main(string[] args)
        {
            CustomerHandler cs = new CustomerHandler();
            
            while (true)
            {
                switch (getMenu())
                {
                    case MENU_ADD:
                        cs.addItem();
                        break;
                    case MENU_VIEW:
                        cs.viewItem();
                        break;
                    case MENU_RANDDOM_ADD:
                        cs.addrandom();
                        break;
                    case MENU_DELETE:
                        cs.deleteItem();
                        break;
                    case MENU_UPDATE:
                        cs.updateItem();
                        break;
                    case MENU_DELETE_ALL:
                        cs.deleteItemAll();
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


    }
}


