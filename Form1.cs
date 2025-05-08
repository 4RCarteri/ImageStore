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
            lblResult.Text = string.Empty;

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
                }
                catch (Exception ex)
                {
                    lblResult.Text = $"Error on trying load image:\n{ex.Message}";
                    lblResult.ForeColor = Color.Red;
                }
            }
        }

        private void btnInsertImage_Click(object sender, EventArgs e)
        {
            string strConn = "Server=localhost;Database=CS;Uid=root;Pwd=root;";
            MySqlConnection conn = new MySqlConnection(strConn);
            MySqlCommand cmd;
            MemoryStream ms = new MemoryStream();

            try
            {
                picImage.Image.Save(ms, picImage.Image.RawFormat);
                byte[] imageData = ms.ToArray();
                string sql = "INSERT INTO images (name, image) VALUES (@name, @image)";

                conn.Open();
                cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@name", txtImageName.Text);
                cmd.Parameters.AddWithValue("@image", imageData);

                if (cmd.ExecuteNonQuery() == 1)
                {
                    lblResult.Text = "Image inserted successfully!";
                    lblResult.ForeColor = Color.Green;
                }
                else
                {
                    lblResult.Text = "Failed to insert image.";
                    lblResult.ForeColor = Color.Red;
                }
            }
            catch (Exception ex)
            {
                lblResult.Text = $"Error on trying to connect:\n{ex.Message}";
                lblResult.ForeColor = Color.Red;
            }
            finally
            {
                conn.Close();
                conn.Dispose();
                ms.Close();
                ms.Dispose();
            }

            picImage.Image = null;
            txtImageName.Text = null;
            txtImageName.Enabled = false;
            btnInsertImage.Enabled = false;

        }
    }
}
