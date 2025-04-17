/*
 과제 : 빙고게임 만들기
빙고칸은 5*5칸/들어가는 숫자는 랜덤(1~25)
내가 만약 5를 누르면, 5가 들어간 칸이 체크되어 특수기호로 바뀌어야함
한줄이면 빙고, 3줄이면 게임 끝/가로,세로,대각선
 */

namespace _250408_Bingo
{

    


    //class BingoPlace
    //{

    //    public void 



    //}



    internal class Bingo
    {


        public void BingoPlace(int[] bingoNum)            //빙고판만들기
        {
            for (int i = 0; i < bingoNum.Length; i++)        //배열 초기화
            {
                bingoNum[i] = i;
            }

        }
        public void RandomNum(int[] bingoNum, Random rand)         //랜덤 숫자 만들기
        {

            for(int i=0; i<100;i++)          // 100번 섞음
            {
                int dest = rand.Next(25);       //0~24까지
                int sour = rand.Next(25);

                int temp = bingoNum[dest];
                bingoNum[dest] = bingoNum[sour];
                bingoNum[sour] = temp;
            }
        }


        public void UserNum(ref int inputUserNum)                  //유저에게서 숫자입력받기
        {
            while(true)
            {
                string input = Console.ReadLine();
                bool isValidNum = int.TryParse(input, out inputUserNum);

                if(isValidNum)
                {
                    if(inputUserNum>0 && inputUserNum<26)           //숫자가 1~25사이이면 OK
                    {
                        break;
                    }
                    //else if(기존에 입력한 숫자와 같다면)
                    //    {
                    //    Console.WriteLine("이미 입력한 숫자입니다. 다시 입력하세요.");
                    //    break;
                    //    }
                    
                }

                Console.WriteLine("다시 입력하세요");

            }


        }


 


        public string NumberCheck(int[] bingoNum, int inputUserNum)     //빙고판과 내 숫자를 비교
        {
            bool isCorrect = bingoNum[i] = inputUserNum;        //빙고판숫자=내숫자


            if(isCorrect)
            {
                 return inputUserNum = "★";     //ToString??????????
            }
            else
            {
                Console.WriteLine("다시 입력하세요");
                
            }
        }



        public void CheckBingo()            // 빙고가 완성되었는지 체크
        {
            int bingoCount = 0;
            if (bingoCount<4)
            {
                for (int i = 0; i < 5; i++)     //세로줄 확인
                {
                    // i + 5가 전부 별이면 빙고(0,5,10,15,20)
                    bingoCount++;
                }
                for (int i = 0; i <= 20; i++)       //가로줄 확인
                {
                    //i에서 i+4까지 전부 별이면 빙고(0,1,2,3,4)
                    bingoCount++;
                    //i += 5;   다음 줄 확인
                }
                for(int i = 0; i < 5; i++)      //대각선줄1 확인
                {
                    //i + 6 이 전부 별이면 빙고
                    bingoCount++;
                }
                for (int i = 0; i < 5; i++)      //대각선줄2확인
                {
                    // i+4가 전부 별이면 빙고
                    bingoCount++;
                }
            }
            
               
        }







        public void Main()
        {
            Random rand = new Random();
            Bingo randomNum = new Bingo();
            Bingo bingo = new Bingo();
            Bingo userNum = new Bingo();

            int[] bingoNum = new int[25];       //빙고 숫자 25개 배열 생성


            Console.WriteLine("빙고게임시작");


            Console.WriteLine("");


            Bingo.UserNum();





        }



    }
}
