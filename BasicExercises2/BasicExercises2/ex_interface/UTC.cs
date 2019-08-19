using System;
using System.Collections.Generic;
using System.Text;

namespace BasicExercises2
{
    class UTC : IRank
    {
        public string Ranking(float score)
        {
            if (score >= 3.6)
            {
                return "Xuat sac";
            }             
            if (score >= 3.2)
            {
                return "Gioi";
            }               
            if (score >= 2.5)
            {
                return "Kha";
            }                
            if (score >= 2.0)
            {
                return "Trung Binh";
            }
            return "Khong xep loai";                
        }
    }
}
