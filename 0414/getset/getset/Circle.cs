using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace getset
{
    class Circle
    {
        private int r;
        public int R { get { return this.r; } set { this.r = value; } }
        //public 변수를 만들때랑 그리드뷰 할때는 {get; set;}써줘라
       //이렇게 안써도 되지만 이것이 표준임!
        public int radius { get; set; }

        public int radi
        {
            get { return this.r; }
            set
            {   //set함수의 매개변수 역할 value
                if (value < 0)
                {
                    this.r = 0;
                }
                else
                {
                    this.r = r;
                } 
            } 
        }
    //소멸자: 잘안써 가비지 컬랙터 있거든
    //
    
    }
}
