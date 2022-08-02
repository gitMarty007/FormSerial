using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsSerial
{
    class SerialManager
    {
        public SerialManager()
        {
        }

        public List<string> GetPortList()
        {
            string[] ports = SerialPort.GetPortNames();

            return ports.ToList();
        }

        public List<string> GetInfoComList()
        {
         
                List<string> ListaCom = new List<string>();
                ListaCom.Clear();

                System.Management.ManagementObjectSearcher moSearch = new System.Management.ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM Win32_PnPEntity WHERE Name LIKE '%(COM%'");
                foreach (System.Management.ManagementObject mo in moSearch.Get())
                {
                    string sPort = (mo["Name"]).ToString();
                    string manufacturer = null;

                    manufacturer = (mo["Manufacturer"]).ToString();

                    string stdata = string.Format("{0};{1}", sPort, manufacturer);

                    //int ststart = sPort.IndexOf("(") + 1;
                    //int ststop = sPort.IndexOf(")");

                    //string comPort = sPort.Substring(ststart, ststop - ststart);

                    ListaCom.Add(stdata);
                }

                return ListaCom;
          
        }
    }
}
