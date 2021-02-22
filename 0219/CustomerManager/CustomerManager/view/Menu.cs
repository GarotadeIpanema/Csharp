using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace CustomerManager
{
    class Menu
    {
        public const int MENU_FORMAT_ERROR = 0;
        public const int MENU_ADD = 1;
        public const int MENU_VIEW = 2;
        public const int MENU_RANDDOM_ADD = 3;
        public const int MENU_DELETE = 4;
        public const int MENU_DELETE_ALL = 5;
        public const int MENU_UPDATE = 6;
        public const int MENU_EXIT = 7;

        public const int MENU_UPDATE_NAME = 1;
        public const int MENU_UPDATE_TEL = 2;
        public const int MENU_UPDATE_ADDR = 3;
        public const int MENU_UPDATE_EMAIL = 4;
        public const int MENU_UPDATE_EXIT = 5;



        public int mainMenu()
        {
            Console.WriteLine("----------------------");
            Console.WriteLine("   주소록 관리 v1.0 ");
            Console.WriteLine("  ##메인 메뉴##");
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
            int menu = 0;
            try
            {
                menu = Convert.ToInt32(Console.ReadLine());
            }
            catch(FormatException e)
            {
                //스택 트레이스
                Console.WriteLine("에러: " +e.Message);
            }
            return menu;
            }

            public string delMenu()
            {
                Console.WriteLine("----------------------");
                Console.WriteLine("## 삭제 메뉴 ##");
                Console.WriteLine("----------------------");
                Console.WriteLine("삭제할 이름을 입력: ");

                return Console.ReadLine();
            }
            public int updateMenu()
            {
                Console.WriteLine("---------------------");
                Console.WriteLine("## 수정 메뉴 ##");
                Console.WriteLine("---------------------");
                Console.WriteLine("1. 이름");
                Console.WriteLine("2. 전화번호");
                Console.WriteLine("3. 주소");
                Console.WriteLine("4. 이메일");
                Console.WriteLine("5. 모든 항목 업데이트");
                Console.WriteLine("업데이트할 항목 번호를 입력: ");

                int number = Convert.ToInt32(Console.ReadLine());
                return number;
            }
        }
    }

   