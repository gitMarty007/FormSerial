using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsSerial
{
    public partial class SerialReveal : Form
    {

        SerialManager serialManager;

        public SerialReveal()
        {
            InitializeComponent();
        }

        private void btnListCom_Click(object sender, EventArgs e)
        {

            List<string> ListPort = null;
            List<string> ListProp = null;

            if (serialManager != null)
            {
                ListPort = serialManager.GetPortList();

                ListProp = serialManager.GetInfoComList();
            }

            if (ListPort != null)
            {
                foreach (string port in ListPort)
                {
                    comboBoxCOM.Items.Add(port);
                }
            }

            if(ListProp!=null)
            {
                foreach (string port in ListProp)
                {
                    UpdateTextOut(port + Environment.NewLine);
                }


            }



        }

        private void SerialReveal_Load(object sender, EventArgs e)
        {
            serialManager = new SerialManager();
        }

        private void UpdateTextOut (string text)
        {
            if (textBoxOut.InvokeRequired)
            {
                textBoxOut.Invoke(new MethodInvoker(delegate () { UpdateTextOut(text); }));
                return;
            }

            textBoxOut.AppendText(text);
        }
    }
}
