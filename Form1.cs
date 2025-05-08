using MySql.Data.MySqlClient;

namespace ImageStore
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSelectImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    picImage.Image = Image.FromFile(openFileDialog.FileName);
                    txtImageName.Text = openFileDialog.SafeFileName;
                    txtImageName.Enabled = true;
                    btnInsertImage.Enabled = true;
                }catch (Exception ex){ 
                    lblResult.Text = $"Error on trying load image:\n{ex.Message}";
                    lblResult.ForeColor = Color.Red;
                }
            }
        }
    }
}
