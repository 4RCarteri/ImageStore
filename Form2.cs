using MySql.Data.MySqlClient;
using System.Data;

namespace ImageStore
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();

            string strConn = "Server=localhost;Database=CS;Uid=root;Pwd=root;";
            MySqlConnection conn = new MySqlConnection(strConn);
            string sql = "SELECT * FROM images";
            MySqlDataAdapter da = new MySqlDataAdapter(sql, conn);

            try
            {
                DataTable dt = new DataTable();
                conn.Open();

                if (da.Fill(dt) < 1)
                {
                    lblResult.Text = "No images found in the database.";
                    lblResult.Visible = true;
                }
                else
                {
                    foreach (DataRow dr in dt.Rows)
                    {
                        dgImageList.Rows.Add(dr.ItemArray);
                    }
                    btnDeleteImage.Enabled = true;
                    btnSaveImage.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                lblResult.Text = $"Error on trying load images:\n{ex.Message}";
                lblResult.Visible = true;
            }
            finally
            {
                conn.Close();
                da.Dispose();
            }
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

        private void dgImageList_SelectionChanged(object sender, EventArgs e)
        {
            lblResult.Text = "";
            lblResult.Visible = false;

            string strConn = "Server=localhost;Database=CS;Uid=root;Pwd=root;";
            MySqlConnection conn = new MySqlConnection(strConn);

            try
            {
                string id = dgImageList.SelectedRows[0].Cells[0].Value.ToString()!;
                string sql = $"SELECT * FROM images WHERE id = {id}";
                MySqlDataAdapter da = new MySqlDataAdapter(sql, conn);
                DataTable dt = new DataTable();
                conn.Open();
                da.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    byte[] imageData = (byte[])dt.Rows[0]["image"];
                    MemoryStream ms = new MemoryStream(imageData);
                    picImage.Image = Image.FromStream(ms);
                }
                else
                {
                    lblResult.Text = "No image found.";
                    lblResult.Visible = true;
                }
            }
            catch (Exception ex)
            {
                lblResult.Text = $"Error on trying load image:\n{ex.Message}";
                lblResult.Visible = true;
            }
            finally
            {
                conn.Close();
            }
        }

        private void btnDeleteImage_Click(object sender, EventArgs e)
        {
            string strConn = "Server=localhost;Database=CS;Uid=root;Pwd=root;";
            MySqlConnection conn = new MySqlConnection(strConn);
            string id = dgImageList.SelectedRows[0].Cells[0].Value.ToString();
            string sql = $"DELETE FROM images WHERE id = {id}";

            try
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(sql, conn);

                if (cmd.ExecuteNonQuery() > 0)
                {
                    if (dgImageList.Rows.Count > 1)
                    {
                        picImage.Image = null;
                        lblResult.Text = "Image deleted successfully!";
                        lblResult.ForeColor = Color.Green;
                        dgImageList.Rows.RemoveAt(dgImageList.SelectedRows[0].Index);
                    }
                    else
                    {
                        btnExit_Click(sender, e);
                    }
                }
                else
                {
                    lblResult.Text = "Error on delete image.";
                    lblResult.Visible = true;
                }
            }
            catch (Exception ex)
            {
                lblResult.Text = $"Error on delete image:\n{ex.Message}";
                lblResult.Visible = true;
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
