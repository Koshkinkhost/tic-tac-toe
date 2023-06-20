using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace крестики_нолики
{
    internal class Arr
    {
        
        public static string[,] arr = new string[3, 3];
        private Arr() { }   
        static public string[,] getArr()
        {
            if(arr==null)
                arr = new string[3, 3];
                return arr;
        }
        static public string getArrone(int x,int y)
        {
            return arr[x, y];


        }
        static public void setArr(int x,int y,string result)
        {
            arr[x, y] = result;
        }
    }
}
