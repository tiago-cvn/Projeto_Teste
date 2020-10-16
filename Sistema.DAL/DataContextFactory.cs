using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema.DAL
{
   public  class DataContextFactory
    {
        private static DataClasses1DataContext DataContext ;
            public static DataClasses1DataContext dataContext
        {
            get
             {
               if (DataContext == null)
                    DataContext = new DataClasses1DataContext();
                return DataContext;
             }
        }
    }
}
