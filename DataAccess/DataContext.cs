using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
   public class DataContext
    {
        public static List<Student> Students;
        public static List<Group> Groups;

         static DataContext()
            {
                Students = new List<Student>();
                Groups = new List<Group>();
            }
        
    }
}
