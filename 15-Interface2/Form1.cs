using _15_Interface2.Entities;

namespace _15_Interface2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            GarantiBankasi g = new GarantiBankasi();
            ZiraatBankasi z = new ZiraatBankasi();

            //BankManagerOld bManager= new BankManagerOld();
            BankManager bMan = new BankManager(z);
            MessageBox.Show(bMan.Ekle());
        }
    }
}
