using System;
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
        Random r = null;
        Randata rand = null;

        public CustomerHandler()
        {
            // r = new Random();
            rand = new Randata(new Random());

            // rand = new RandData(r);
        }

        public void addItem()
        {
            Console.WriteLine("-----------------");
            Console.WriteLine("주소록 정보 입력");
            Console.WriteLine("-----------------");
            Console.Write("이름: ");
            string name = Console.ReadLine();
            Console.Write("전화: ");
            string tel = Console.ReadLine();
            Console.Write("주소: ");
            string address = Console.ReadLine();
            Console.Write("이메일: ");
            string email = Console.ReadLine();

            addrList.Add(
                new Customer(rand.getId(),name, tel, address, email));
            Console.WriteLine("정보가 정상적으로 입력되었습니다.");
        }

        public void viewItem()
        {
            for (int i = 0; i < addrList.Count; i++)
            {
                Console.WriteLine("번호: " + (i + 1));
                Console.WriteLine("아이디: " + addrList[i].Id);
                Console.WriteLine("이름: " + addrList[i].Name);
                Console.WriteLine("전화: " + addrList[i].Tel);
                Console.WriteLine("주소: " + addrList[i].Address);
                Console.WriteLine("이메일: " + addrList[i].Email);
                Console.WriteLine("-------------------------");
            }
        }

        public int getMenu()
        {
            Console.WriteLine("-----------------");
            Console.WriteLine("1.주소록 정보 추가");
            Console.WriteLine("2.주소록 정보 보기");
            Console.WriteLine("3.랜덤 데이터 추가");
            Console.WriteLine("4.주소록 정보 삭제");
            Console.WriteLine("5.전체 데이터 삭제");
            Console.WriteLine("6.종료");
            Console.WriteLine("-----------------");
            Console.Write("메뉴 선택: ");
            int menu =
                Convert.ToInt32(Console.ReadLine());
            return menu;
        }



        public void deleteItem(string name)
        {
            for (int i = 0; i < addrList.Count; i++)
            {
                if (name.Equals(addrList[i].Name))
                {
                    addrList.RemoveAt(i--);
                }
            }
        }

        public void deleteItemAll()
        {
            addrList.Clear();
        }

        public void Randata(int count)
        {

            for (int i = 0; i < count; i++)
            {
                addrList.Add(new Customer(
                    rand.getId(),
                    rand.getName(),
                    rand.getTel(),
                    rand.getAddr(),
                    rand.getEmail()
                    ));
            }
        }

        public void updateItem(int menu)
        {
            Console.WriteLine("---------------------");
            Console.WriteLine("주소록 정보 업데이트");
            Console.WriteLine("---------------------");
            
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
    }
}

