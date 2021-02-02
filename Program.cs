using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace labirinho
{
    class Program
    {
        static void Main(string[] args)
        {
            xd map1 = new xd("OWA OWA");
            bool gameisrunning = true;
            while (gameisrunning)
            {
                char command = Console.ReadKey().KeyChar;
                switch (command)
                {
                    case 'w':map1.up();break;
                    case 's':map1.down();break;
                    case 'a':map1.left();break;
                    case 'd':map1.right();break;
                    default: Console.WriteLine("Nincs ilyen parncs!");break;
                }

                map1.showmap();
            }
            Console.WriteLine(map1.getname());
            map1.showmap();
            Console.ReadKey();
        }
    }
    class xd
    {
        private char[,] map;
        private string mapname;
        public xd(string name)
        {
            this.mapname = name;
            this.map = new char[,]{
                {'#','@','#','#','#'},
                {'#','.','.','.','#'},
                {'#','.','#','.','#'},
                {'#','.','#','.','X'},
                {'#','#','#','#','#'}
            };

        }
        public string getname()
        {
            return mapname;
        }
        public char[,] getmap()
        {
            return map;
        }
        public void showmap()
        {
            int meret = this.map.GetLength(0);
            for (int row = 0; row < meret; row++)
            {
                for (int col = 0; col < meret; col++)
                {
                    Console.Write(this.map[row, col]);
                }
                Console.WriteLine(); ;
            }
        }
        public int[] whereami()
        {
            int[] pos = { 0, 0 };
            int meret = this.map.GetLength(0);
            for (int row = 0; row < meret; row++)
            {
                for (int col = 0; col < meret; col++)
                {
                    if (this.map[row, col]) == '@'{
                        pos[0] = row;
                        pos[1] = col;
                    }
                }
                Console.WriteLine(); ;
            }
            return pos;
        }
        public void up()
        {
            
        }
        public void down()
        {

        }
        public void left()
        {

        }
        public void right()
        {

        }
            

    }
}
