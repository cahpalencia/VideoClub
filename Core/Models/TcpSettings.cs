using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Models
{
    public class TcpSettings
    {
        public TcpSettings(string serverIp, string serverPort) {
            this.ServerIp = serverIp;
            this.ServerPort = serverPort;
        }
        public string ServerIp { get; set; }
        public string ServerPort { get; set; }
    }
}
