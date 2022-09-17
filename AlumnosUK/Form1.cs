using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlumnosUK
{
    public partial class Form1 : Form
    {
        private string connectionString;
        public Form1()
        {
            InitializeComponent();
            connectionString = "Server=localhost;Database=UnikinoDB;Trusted_Connection=True;";
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                string Query = $"INSERT INTO Alumnos (Nombre, FechaNacimiento, Email) VALUES ('{txtNombre.Text}', GETDATE(), '{txtEmail.Text}')";
                SqlConnection sqlConnection = new SqlConnection(connectionString);
                SqlCommand sqlCommand = new SqlCommand(Query,sqlConnection);
                sqlCommand.CommandType = CommandType.Text;
                sqlConnection.Open();
                sqlCommand.ExecuteNonQuery();
                sqlConnection.Close();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
