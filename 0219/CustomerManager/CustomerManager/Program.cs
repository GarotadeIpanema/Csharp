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

        public const int MENU_ADD = 1;
        public const int MENU_VIEW = 2;
        public const int MENU_RANDDOM_ADD = 3;
        public const int MENU_DELETE = 4;
        public const int MENU_DELETE_ALL = 5;
        public const int MENU_UPDATE = 6;
        public const int MENU_EXIT = 7;


        static Random r = new Random();

        static void Main(string[] args)
        {
            Menu m = new Menu();
            CustomerHandler cs = new CustomerHandler();
            
            while (true)
            {
                switch (mainMenu())
                {
                    case MENU_ADD:
                        cs.addItem();
                        break;
                    case MENU_VIEW:
                        cs.viewItem();
                        break;
                    case MENU_RANDDOM_ADD:
                        cs.Randata(100);
                        break;
                    case MENU_DELETE:
                        cs.deleteItem(m.delMenu());
                        break;
                    case MENU_UPDATE:
                        cs.updateItem(m.updateMenu());
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


        public static int mainMenu()
        {
            Console.WriteLine("----------------------");
            Console.WriteLine("   주소록 관리 v1.0 ");
            Console.WriteLine("----------------------");
            Console.WriteLine("1. 주소록 정보 추가");
            Console.WriteLine("2. 주소록 정보 보기");
            Console.WriteLine("3. 랜덤 데이터 추가");
            Console.WriteLine("4. 데이터 삭제");
            Console.WriteLine("5. 데이터 모두 삭제");
            Console.WriteLine("6. 주소록 업데이트");
            Console.WriteLine("7. 종료");
            Console.WriteLine("-------------------");
            Console.WriteLine("메뉴 선택: ");
            int menu = Convert.ToInt32(Console.ReadLine());
            return menu;


        }


    }
}


