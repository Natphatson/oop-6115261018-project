using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace oop_6115261018_Project
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void DP_Shades_Click(object sender, EventArgs e)
        {

        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            try
            {

                string MyConnection2 = "datasource=localhost;port=3306;username=root;password=;database=foundation";

                string Query = "insert into detail_powder_foundation(DP_ID,DP_price,DP_CreamTexture,DP_Protection,DP_Shades,DP_Concealment,DP_volume,DP_SunProtection,DP_ColorScheme) " +
                    "values('" + this.txtDP_ID.Text + "','" + this.txtDP_price.Text + "','" + this.txtDP_CreamTexture.Text + "','" + this.txtDP_Protection.Text + "','" + this.txtDP_Shades.Text + "','" + this.txtDP_Concealment.Text + "','" + this.txtDP_volume.Text + "','" + this.txtDP_SunProtection.Text + "','" + this.txtDP_ColorScheme.Text + "'); ";

                MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);

                MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);

                MySqlDataReader MyReader2;

                MyConn2.Open();

                MyReader2 = MyCommand2.ExecuteReader();

                MessageBox.Show("Save Data");

                while (MyReader2.Read())
                {



                }

                MyConn2.Close();

            }

            catch (Exception ex)
            {



                MessageBox.Show(ex.Message);

            }

        }

        private void btnedit_Click(object sender, EventArgs e)
        {
            try
            {


                string MyConnection2 = "datasource=localhost;port=3306;username=root;password=;database=foundation";


                string Query = "update detail_powder_foundation set DP_price='" + this.txtDP_price.Text + "',DP_CreamTexture='" + this.txtDP_CreamTexture.Text + "',DP_Protection='" + this.txtDP_Protection.Text + "' + ,DP_Shades = '" + this.txtDP_Shades.Text + "',	DP_Concealment='" + this.txtDP_Concealment + "',DP_volume='" + this.txtDP_volume + "',DP_SunProtection='" + this.txtDP_SunProtection + "',DP_ColorScheme='" + this.txtDP_ColorScheme + "'+ where dp_id'" + this.txtDP_ID.Text + "';";


                MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);

                MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);

                MySqlDataReader MyReader2;

                MyConn2.Open();

                MyReader2 = MyCommand2.ExecuteReader();

                MessageBox.Show("Data Updated");

                while (MyReader2.Read())
                {



                }

                MyConn2.Close();//Connection closed here 

            }

            catch (Exception ex)
            {



                MessageBox.Show(ex.Message);

            }

        }

        private void btndisplay_Click(object sender, EventArgs e)
        {
            try
            {


                string MyConnection2 = "datasource=localhost;port=3306;username=root;password=;database=foundation";
                string Query = "select * from detail_powder_foundation;";
                MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
                MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                MySqlDataAdapter MyAdapter = new MySqlDataAdapter();
                MyAdapter.SelectCommand = MyCommand2;


                DataTable dTable = new DataTable();


                MyAdapter.Fill(dTable);
                dataGridView1.DataSource = dTable;






                // MyConn2.Close(); 


            }


            catch (Exception ex)
            {






                MessageBox.Show(ex.Message);


            }


        }

        private void btnnext_Click(object sender, EventArgs e)
        {
            {
                Form3 f3 = new Form3();
                f3.ShowDialog();
            }

        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            try
            {

                string MyConnection2 = "datasource=localhost;port=3306;username=root;password=;database=foundation";

                string Query = "delete from powder_foundation where DP_price'" + this.txtDP_price.Text + "',DP_CreamTexture'" + this.txtDP_CreamTexture.Text + "',DP_Protection'" + this.txtDP_Protection.Text + "', DP_Shades'" + this.txtDP_Shades.Text + "', DP_Concealment'" + this.txtDP_Concealment.Text + "', DP_volume" + this.txtDP_volume.Text + "', DP_SunProtection" + this.txtDP_SunProtection.Text + "',DP_ColorScheme" + this.txtDP_ColorScheme.Text + "';";

                MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);

                MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);

                MySqlDataReader MyReader2;

                MyConn2.Open();

                MyReader2 = MyCommand2.ExecuteReader();

                MessageBox.Show("Data Deleted");

                while (MyReader2.Read())
                {



                }

                MyConn2.Close();

            }

            catch (Exception ex)
            {



                MessageBox.Show(ex.Message);

            }

        }
    }
}
