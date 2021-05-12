using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto.Datos
{
    class Connection
    {
        public string server, db;
        public string chain;

        public void connect()
        {
            server = "DESKTOP-G2BG0KM\\SQLEXPRESS";
            db = "FastCarlos";
            chain = "server=" + server + ";integrated security=true;database=" + db;
        }
    }
}
