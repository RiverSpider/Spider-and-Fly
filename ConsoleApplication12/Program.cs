using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApplication12
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;
            string[] r = Console.ReadLine().Split();
            a = Convert.ToInt32(r[0]);
            b = Convert.ToInt32(r[1]);
            c = Convert.ToInt32(r[2]);
            int sx, sy, sz;
            r = Console.ReadLine().Split();
            sx = Convert.ToInt32(r[0]);
            sy = Convert.ToInt32(r[1]);
            sz = Convert.ToInt32(r[2]);
            int fx, fy, fz;
            r = Console.ReadLine().Split();
            fx = Convert.ToInt32(r[0]);
            fy = Convert.ToInt32(r[1]);
            fz = Convert.ToInt32(r[2]);
            int x = 0, y = 0, z = 0;
            double s = 0;
            if(sx == fx){
                y = (sy - fy);
                z = (sz - fz);
            }
            if (sy == fy)
            {
                x = (sx - fx);
                z = (sz - fz);
            }
            if (sz == fz)
            {
                y = (sy - fy);
                x = (sx - fx);
            }
            if (((sz == c || sz == 0) && (fx == a || fx == 0)) || ((fz == c || fz == 0) && (sx == a || sx == 0)))
            {
                if ((sz == c && fx == 0) || (fz == c && sx == a)) {
                    x = (c - fz) + (sx);
                    y = sy - fy;
                }
                if ((fz == c && sx == 0) || (sz == c && fx == a))
                {
                    x = (c - sz) + (fx);
                    y = fy - sy;
                }
            }
            if (((sz == c || sz == 0) && (fy == b || fy == 0)) || ((fz == c || fz == 0) && (sy == b || sy == 0)))
            {
                if ((sz == c && fy == 0) || (fz == c && sy == b))
                {
                    y = (c - fz) + (sy);
                    x = sx - fx;
                }
                if ((fz == c && sy == 0) || (sz == c && fy == b))
                {
                    y = (c - sz) + (fy);
                    x = fx - sx;
                }
            }
            if (((sx == a || sx == 0) && (fx == a || fx == 0)) || ((fx == a || fx == 0) && (sx == a || sx == 0)))
            {
                if ((sx == a && fx == 0) || (fx == a && sx == 0))
                {
                    z = c-fz + c-sz;
                    y = b;
                    x = fx - sx;
                }
                if ((fy == b && sy == 0) || (sy == b && fy == 0))
                {
                    z = c - fz + c - sz;
                    x = a;
                    y = fy - sy;
                }
            }
            s = Math.Sqrt(x * x + y * y + z * z);
            Console.WriteLine(s);
        }
    }
}
