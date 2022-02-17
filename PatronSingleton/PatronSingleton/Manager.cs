using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronSingleton
{
    public class Manager
    {
        private static Manager session;

        public Usuario Usuario { get; set; }

        public static Manager GetManager
        {
            get
            {
                if (session == null) session = new Manager();

                return session;
            }
        }

        private Manager()
        {

        }



        
    }
}
