using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace task3
{
    internal class shiritori
    {
        List<string> strList = new List<string>();
        public bool gameover;

        public shiritori()
        { }
        
        public void play(string word)
        {
            strList.Add(word);
            gameover=true;
            if (strList.Count>1)
            {
                for (int i = 0; i < strList.Count; i++)
                { 
                    int len = strList[i].Length;
                    if (i != strList.Count-1)
                    {
                        if (strList[i][len - 1] != strList[i+1][0])
                        {
                            gameover = false;

                        }
                    }
                }
            }
           

            
        }
        public void myshrutiwords()
        {
            Console.Clear();
            foreach(string word in strList)
            {
                Console.WriteLine(word);
            }
        }
        public void emptyList()
        {
            strList.Clear();
        }
        

    }
}
