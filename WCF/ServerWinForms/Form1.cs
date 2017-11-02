using System.Windows.Forms;
using System.ServiceModel;


namespace ClientWinForms
{
    public partial class Form1 : Form
    {
        ServiceHost sh;
        public Form1()
        {
            InitializeComponent();
            sh = new ServiceHost(typeof(WCF.Service1));
            sh.Open();
        }
    }
}
