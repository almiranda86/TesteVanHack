using System;
using System.Linq;

namespace CodilityTests
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Solution s = new Solution();
            //s.solution("00 - 44  48 5555 8361");
            //s.solution("0 - 22 1985--324");
            //s.solution("555372654");


            Elevator e = new Elevator();
            //peso
            int[] A = new int[] { 40, 40,100, 80, 20};
			
            //andares
            int[] B = new int[] { 3,3,2,2,3 };

            //andares
            int M = 3;

            //capacidade
            int X = 5;

            //limite de peso
            int Y = 200;


            e.solution(A, B, M, X, Y);

        }
    }


    public class Elevator{
		public int solution(int[] A, int[] B, int M, int X, int Y)
		{
            // write your code in C# 6.0 with .NET 4.5 (Mono)
            int n = 0;

            System.Collections.Generic.List<int> _A = new System.Collections.Generic.List<int>();

            for (int i = 0; i <= B.Length; i++){

                if(_A.Count < 3){
                    _A.Add(B[i]);
                }else{

                    System.Collections.Generic.List<int> q = new System.Collections.Generic.List<int>();

                    foreach(int _a in _A){

                        if(q.Contains(_a) || q.Count() == 0){
                            q.Add(_a);    
                        }
                    }

                    foreach(int Q in q){
                        _A.Remove(Q);
                    }

                    //parou no andar
                    n++;

                   
                    if(i < B.Length){
                        _A.Add(B[i]);    
                    }
					//parou no terreo;
					n++;
                }

            }


            if(_A.Count() == 1){
                _A.Remove(0);
                n++;
            }


            return n;
		}

    }






	public class Solution
	{
		public string solution(string S)
		{
            string x = S.Trim();
            x = System.Text.RegularExpressions.Regex.Replace(x, "[^0-9a-zA-Z]+", "");
            char[] n = x.ToCharArray();

            string y = "";
            int z = 1;

            for (int i = 0; i < n.Length; i++){

                y += n[i];

                if(z % 3 == 0){
                    y += "-" ;
                }

                z++;
            }

            string[] n1 = y.Split('-');

            for (int i = 0; i < n1.Length; i++){

                if(n1[i].Length != 3){
                    if(n1[i].Length < 2 && n1[i]!=""){
						string a = n1[i - 1];
						string b = a.Substring(0, 2);
						string c = a.Substring(2, 1);
                        string d = n1[i];

						n1[i - 1] = b;
                        n1[i] = c+d;
                    }else{
                        if(n1[i]==""){
                            Array.Resize(ref n1, n1.Length - 1);
                        }
                    }

                    y = "";
                    for (int q = 0; q < n1.Length; q++)
                    {
                        if (n1.Length == q + 1)
                        {
                            y += n1[q];
                        }
                        else
                        {
                            y += n1[q] + "-";
                        }
                    }
                }
            }
            return y;
		}
	}
}
