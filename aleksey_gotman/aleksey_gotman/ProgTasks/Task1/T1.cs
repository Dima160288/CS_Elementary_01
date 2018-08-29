using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public struct Student
    {
        private string fName;
        private string sName;
        private int nGroup;
        private int[] assessment;
        private int avg;
        public string FName { get { return fName; } }
        public string SName { get { return sName; } }
        public int NGroup { get { return nGroup; } }
        public int[] Assessment { get { return assessment; } }
        public double Avg { get { return avg; } }


        public Student(string fn, string sn, int ng, int[] ass)
        {
            fName = fn;
            sName = sn;
            nGroup = ng;
            assessment = new int[5];
            avg = 0;
            bool trueAsse = true;
            foreach (int i in ass)
            {
                if (i < 1 && i > 5)
                    trueAsse = false;
                avg += i;
            }
            if (trueAsse)
            {
                assessment = ass;
                avg = avg / ass.Length;
            }


        }
    }
    public static class T1
    {
        public static void DoIt()
        {
            Student[] st = new Student[10];
            Random r = new Random();
            for (int i = 0; i < st.Length; i++)
            {
                st[i] = new Student("Faceles", "People", r.Next(), new int[] { r.Next(1, 6), r.Next(1, 6), r.Next(1, 6), r.Next(1, 6), r.Next(1, 6) });
            }
            st.OrderByDescending(x => x.Avg);
        }

    }
}
