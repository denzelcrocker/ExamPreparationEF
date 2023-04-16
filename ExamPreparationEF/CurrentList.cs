using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamPreparationEF
{
    internal class CurrentList
    {
        public static Children children;
        public static List<Children> childrens = new List<Children>();
        public static ExapPreparationEfContext db = new ExapPreparationEfContext();

    }
}
