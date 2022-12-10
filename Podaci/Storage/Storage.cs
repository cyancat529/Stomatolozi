using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Podaci.Storage
{
    public class Storage
    {
        private static Storage instance;
        public Dictionary<string, string> Administratori = new Dictionary<string, string>();
        public UserUtil UserRole { get; set; }
        public object Login { get; set; }
        private Storage()
        {
            Administratori.Add("pera","pera");
        }

        public static Storage Instance
        {
            get
            {
                if (instance == null) instance = new Storage();
                return instance;
            }
        }


    }

    public enum UserUtil
    {
        Administrator, Pacijent, Stomatolog
    }
}
