using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace antsequence20th
{
    class Program
    {
        static void Main(string[] args)
        {
            // 선생님께
            // 홀로... 코드 작성은 무리일 것 같아서 인터넷에 찾아봐서...
            // 코드 공부하고... 올립니다.... ㅠㅠ 
            // 너무 어려워요...

            string ant = "1";
            string antsequence = "";
            int n = 20;

            Console.WriteLine("1번째 수열 : " + ant);

            for (int i =1; i<n; i++)
            {
                Console.Write(i + 1 + "번째 수열 : ");
                int j = 0; //while 2개 끝나면 0으로 초기화됨~^^ 이걸놓치네..^^
                while(j < ant.Length) //항상 true
                {
                    char current = ant[j];
                    int count = 1;

                    while((j+1 < ant.Length) && (current == ant[j+1]))
                    {
                        count += 1;
                        j += 1;
                    }

                    antsequence += current + count.ToString();
                    j += 1;
                }

                Console.WriteLine(antsequence);
                ant = antsequence;
                antsequence = "";
               // Console.WriteLine(i + "번째의 J 값 : " + j);

            }
        }
    }
}
