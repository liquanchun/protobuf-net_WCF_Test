using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProtoBuf_Model;
using Tools.ServiceReference1;
namespace Tools
{
    public partial class FrmProto : Form
    {
        public FrmProto()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            EndpointAddress address1 = new EndpointAddress("net.tcp://localhost:8083/Service1.svc");
            ServiceReference1.Service1Client client = new ServiceReference1.Service1Client("NetTcpBinding_IService1", address1);


            //ServiceReference1.Service1Client client = new ServiceReference1.Service1Client();

            CompositeType type = new CompositeType
            {
                BoolValue = true,
                StringValue = "liquanchun"
            };
            var newtype = client.GetDataUsingDataContract(type);
            if (newtype != null)
            {
                textBox1.Text = newtype.StringValue;
            }

            
        }
    }
}
