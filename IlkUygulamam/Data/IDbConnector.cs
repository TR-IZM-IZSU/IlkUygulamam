using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IlkUygulamam.Data
{
    public interface IDbConnector
    {
        public bool IsConnect();
        public void ConnectDb();
        public void DisconnectDb();
    }
}
