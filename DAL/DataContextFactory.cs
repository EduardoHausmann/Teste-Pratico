using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DataContextFactory
    {
        private static JogoDataContext dataContext;

        public static JogoDataContext DataContext
        {
            get
            {
                if (dataContext == null)
                    dataContext = new JogoDataContext();

                return dataContext;
            }
        }
    }
}
