using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace getset
{
    class Person
    {
        public string name { get; set; }
        public int age { get; set; }
        //생성자 Person 만듦과 동시에 변수 지정
        //오버로딩:재사용
        public Person()
        {
            
            //이런 빈 생성자는 자동으로 만들어줌(기본 생성자)

        }

        public Person(string name)
        {
            this.name = name;


        }
        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
            
        }
        


    }
}
