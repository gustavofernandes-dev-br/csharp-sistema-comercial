using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WindowsFormsApplication1
{
    class Grid: ConexaoSQL
    {
            public Boolean GridPopularWhile(DataGridView dataGrid, String query)
            {
                try
                {
                this.cmd = new System.Data.SqlClient.SqlCommand(query, this.ConexaoAtiva);
                this.cmd.CommandType = System.Data.CommandType.Text;           
                this.reader = this.cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    if (dataGrid != null || dataGrid.Rows.Count > 0 )
                    { 
                        dataGrid.Rows.Clear(); 
                    }
                    int i = 0;
                    if (reader.FieldCount == dataGrid.ColumnCount)
                    {
                        while (reader.Read())
                        {
                            dataGrid.Rows.Add(1);
                            i = dataGrid.RowCount;
                            {
                                for (int y = 0; y < dataGrid.ColumnCount; y++)
                                {
                                    dataGrid.Rows[i -1].Cells[y].Value = Convert.ToString(reader[y].ToString());
                                }
                            }
                            
                        }
                        reader.Close();
                    }
                }
                return true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message,"Error" );
                    return false;
                    throw;
                }
            }

            //Remove todos os dados nulos de uma determinada linha do Grid
            public void GridRemoveNulos(DataGridView dataGrid, Int32 ParRow)
            {
                for (int i = 0; i < dataGrid.ColumnCount; i++)
                {
                    if (dataGrid.Rows[ParRow].Cells[i].Value == null)
                    {
                        dataGrid.Rows[ParRow].Cells[i].Value = "";
                    }
                }
               
            }
            public Boolean GridPopularDataSource(DataGridView dataGrid, String query)
            {
                try
                {
                    
                    dataGrid.AutoGenerateColumns = false;
                    dataGrid.DataSource = null;
                    dataGrid.Enabled = false;
                    this.cmd = new System.Data.SqlClient.SqlCommand(query, this.ConexaoAtiva);
                    this.adp = new System.Data.SqlClient.SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adp.Fill(dt);
                    BindingSource bs = new BindingSource();
                    bs.DataSource = dt;
                    dataGrid.DataSource = bs;
                    
                    dataGrid.Enabled = true;
                    return true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error");
                    return false;
                    throw;
                }
            }


           
    }
}

//SqlConnection SQLConnection = new SqlConnection();
//                   SQLConnection.ConnectionString = strProvider;
//                   SqlCommand cmd = new SqlCommand(queryNota, SQLConnection);
//                   SQLConnection.Open();
//                   DataTable d_table = new DataTable();
//                   d_table.Load(cmd.ExecuteReader());
//                   SQLConnection.Close();

//                   //C100
//                   //gravando no arquivo o Cabeçalho da nota C100
//                   foreach (DataRow row in d_table.Rows)
//                   {
//                       foreach (DataColumn column in d_table.Columns)
//                       {
//                           string linha = (row[column].ToString()).Trim() + '|';
//                           sw.Write(linha);
//                       }
//                       sw.Write(sw.NewLine);
//                   }



//dgvUsuarios.Rows[i].Cells[0].Value = rw["US_ID"].ToString();
//dgvUsuarios.Rows[i].Cells[1].Value = rw["US_NOME"].ToString();
//dgvUsuarios.Rows[i].Cells[2].Value = rw["US_EMAIL"].ToString();
//dgvUsuarios.Rows[i].Cells[3].Value = rw["US_LOGIN"].ToString();
//dgvUsuarios.Rows[i].Cells[4].Value = rw["US_PERFIL"].ToString();
//dgvUsuarios.Rows[i].Cells[5].Value = rw["US_CADASTRO"].ToString();
//dgvUsuarios.Rows[i].Cells[6].Value = rw["US_SENHA"].ToString();
//dgvUsuarios.Rows[i].Cells[7].Value = rw["US_inativo"].ToString();
