using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TriggerTestAssieme
{
    public partial class Form1 : Form
    {
        public static readonly string workingDirectory = Environment.CurrentDirectory;
        public static readonly string projectDirectory = Directory.GetParent(workingDirectory).Parent.Parent.FullName;
        public static readonly string CONNECTION_STRING = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + projectDirectory + @"\DriverDB.mdf;Integrated Security=True;Connect Timeout=30";

        private BindingSource bsDriver = new BindingSource();
        private BindingSource bsStoricoCancellazioni = new BindingSource();
        private BindingSource bsStoricoAggiornamenti = new BindingSource();
        private BindingSource bsStoricoAggiornamentiCampi = new BindingSource();
        private DataTable dtDriver, dtStoricoCancellazioni, dtStoricoAggiornamenti, dtStoricoAggiornamentiCampi;
        private SqlDataAdapter daDriver, daStoricoCancellazioni, daStoricoAggiornamenti, daStoricoAggiornamentiCampi;

        private void btnNazione_Click(object sender, EventArgs e)
        {
            DataTable retVal = new DataTable();
            SqlConnection con = new SqlConnection(CONNECTION_STRING);
            string sql = "SELECT dbo.F1(@country)";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@country", txtNome.Text);
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(retVal);
            con.Close();
            da.Dispose();
            dgvF1.DataSource = retVal;
        }

        private void btnCERCA_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(CONNECTION_STRING);
            string sql = "SELECT dbo.F2(@podiums_number)";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@podiums_number", Convert.ToInt32(txtPodio.Text));
            con.Open();
            int risultato = Convert.ToInt32(cmd.ExecuteScalar());
            con.Close();
            MessageBox.Show("Numero podi >= " + txtPodio.Text + " --> " + risultato.ToString());
        }

        private void OnRowsDeletedDriver(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            daDriver.Update(dtDriver);
            //MessageBox.Show("Riga cancellata su DB");
            PopulateDgv(2);
        }

        private void btnAggDB_Click(object sender, EventArgs e)
        {
            daDriver.Update(dtDriver);
            PopulateDgv(0);
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Query(string selectCommand, out SqlDataAdapter da)
        {
            da = null;
            try
            {
                // Crea un nuovo data adapter basato su selectCommand
                da = new SqlDataAdapter(selectCommand, CONNECTION_STRING);

                // Creo un command builder per generare un comando SQL update, insert, delete
                SqlCommandBuilder commandBuilder = new SqlCommandBuilder(da);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            PopulateDgv(0);
        }

        private void PopulateDgv(int tables)
        {
            switch (tables)
            {
                case 0:
                    dgvDriver.DataSource = bsDriver;
                    Query("SELECT * FROM Driver", out daDriver);
                    if (daDriver != null)
                    {
                        dtDriver = new DataTable();
                        daDriver.Fill(dtDriver);
                        bsDriver.DataSource = dtDriver;
                    }
                    dgvDriver.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader);
                    
                    dgvStoricoCancellazioni.DataSource = bsStoricoCancellazioni;
                    Query("SELECT * FROM StoricoCancellazioni", out daStoricoCancellazioni);
                    if (daStoricoCancellazioni != null)
                    {
                        dtStoricoCancellazioni = new DataTable();
                        daStoricoCancellazioni.Fill(dtStoricoCancellazioni);
                        bsStoricoCancellazioni.DataSource = dtStoricoCancellazioni;
                    }

                    dgvStoricoCancellazioni.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader);
                    
                    dgvStoricoAggiornamenti.DataSource = bsStoricoAggiornamenti;
                    Query("SELECT * FROM StoricoAggiornamenti", out daStoricoAggiornamenti);
                    if (daStoricoAggiornamenti != null)
                    {
                        dtStoricoAggiornamenti = new DataTable();
                        daStoricoAggiornamenti.Fill(dtStoricoAggiornamenti);
                        bsStoricoAggiornamenti.DataSource = dtStoricoAggiornamenti;
                    }

                    dgvDriver.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader);

                    dgvStoricoAggiornamentiCampi.DataSource = bsStoricoAggiornamentiCampi;
                    Query("SELECT * FROM StoricoAggiornamentiCampi", out daStoricoAggiornamentiCampi);
                    if (daStoricoAggiornamentiCampi != null)
                    {
                        dtStoricoAggiornamentiCampi = new DataTable();
                        daStoricoAggiornamentiCampi.Fill(dtStoricoAggiornamentiCampi);
                        bsStoricoAggiornamentiCampi.DataSource = dtStoricoAggiornamentiCampi;
                    }

                    dgvStoricoAggiornamentiCampi.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader);
                    break;
                case 1:
                    dgvDriver.DataSource = bsDriver;
                    Query("SELECT * FROM Driver", out daDriver);
                    if (daDriver != null)
                    {
                        dtDriver = new DataTable();
                        daDriver.Fill(dtDriver);
                        bsDriver.DataSource = dtDriver;
                    }
                    dgvDriver.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader);
                    break;
                case 2:
                    dgvStoricoCancellazioni.DataSource = bsStoricoCancellazioni;
                    Query("SELECT * FROM StoricoCancellazioni", out daStoricoCancellazioni);
                    if (daStoricoCancellazioni != null)
                    {
                        dtStoricoCancellazioni = new DataTable();
                        daStoricoCancellazioni.Fill(dtStoricoCancellazioni);
                        bsStoricoCancellazioni.DataSource = dtStoricoCancellazioni;
                    }

                    dgvStoricoCancellazioni.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader);
                    break;
                case 3:
                    dgvStoricoAggiornamenti.DataSource = bsStoricoAggiornamenti;
                    Query("SELECT * FROM StoricoAggiornamenti", out daStoricoAggiornamenti);
                    if (daStoricoAggiornamenti != null)
                    {
                        dtStoricoAggiornamenti = new DataTable();
                        daStoricoAggiornamenti.Fill(dtStoricoAggiornamenti);
                        bsStoricoAggiornamenti.DataSource = dtStoricoAggiornamenti;
                    }

                    dgvDriver.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader);
                    break;
            }
        }
    }
}
