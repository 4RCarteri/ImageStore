using MySql.Data.MySqlClient;

namespace ImageStore
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
            Thread thread = new Thread(() =>
            {
                Application.Run(new Form1());
            });
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }
    }
}
