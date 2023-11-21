using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrySaleskiTPFINAL
{
    internal class access
    {
        OleDbConnection conexionBD;
        OleDbCommand comandoBD;
        OleDbDataReader lectorBD;
        OleDbDataAdapter adapter;
        DataSet objDataSet = new DataSet();
        

        string cadenaDeConexion = @"Provider = Microsoft.ACE.OLEDB.12.0;" + " Data Source = ..\\..\\Resources\\EMPLEADO.accdb";

        public string estadoDeConexion = "";
        public string datosTabla = "";
        public string apellido;
        public int varContador;
        public access()
        {
            varContador = 0;
        }
        public void ConectarBD()
        {
            try
            {
                conexionBD = new OleDbConnection();
                conexionBD.ConnectionString = cadenaDeConexion;
                conexionBD.Open();
                estadoDeConexion = "Conectado";
            }
            catch (Exception ex)
            {
                estadoDeConexion = "Error" + ex.Message;
            }
        }
        public void traerDatos(DataGridView grilla)
        {
            comandoBD = new OleDbCommand();
            grilla.Rows.Clear();
            //conexionBD.Open();

            comandoBD.Connection = conexionBD;
            comandoBD.CommandType = System.Data.CommandType.TableDirect;
            comandoBD.CommandText = "DATOS PERSONALES";

            lectorBD = comandoBD.ExecuteReader();

            grilla.Columns.Add("CODIGO", "CODIGO");
            grilla.Columns.Add("NOMBRE", "NOMBRE");
            grilla.Columns.Add("APELLIDO", "APELLIDO");
            grilla.Columns.Add("DIRECCIÓN", "DIRECCIÓN");
            grilla.Columns.Add("CIUDAD", "CIUDAD");
            grilla.Columns.Add("TELEFONO", "TELEFONO");
            grilla.Columns.Add("FECHA_NAC", "FECHA_NAC");
            if (lectorBD.HasRows)
            {
                while (lectorBD.Read())
                {

                    grilla.Rows.Add(lectorBD[0], lectorBD[1], lectorBD[2], lectorBD[3], lectorBD[4], lectorBD[5], lectorBD[6]);

                }

            }

        }
        public void RegistrarEmpleado(string nombre, string apellido, string ciudad, string direccion)
        {
            try
            {
                conexionBD.Open();

                string consulta = "INGRESAR (Nombre, Apellido, Ciudad, Dirección, Numero) VALUES (NOMBRE, APELLIDO, CIUDAD, DIRECCIÒN)";
                OleDbCommand comandoBD = new OleDbCommand(consulta, conexionBD);
                comandoBD.Parameters.AddWithValue("NOMBRE", nombre);
                comandoBD.Parameters.AddWithValue("APELLIDO", apellido);
                comandoBD.Parameters.AddWithValue("CIUDAD", ciudad);
                comandoBD.Parameters.AddWithValue("DIRECCIÒN", direccion);

                comandoBD.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al registrar: {ex.Message}");
            }
            finally
            {
                conexionBD.Close();
            }
        }
        public void BuscarPorId(string codigo, DataGridView dgvMostrar)
        {
            comandoBD = new OleDbCommand();

            comandoBD.Connection = conexionBD;
            comandoBD.CommandType = System.Data.CommandType.TableDirect;
            comandoBD.CommandText = "DATOS PERSONALES";

            lectorBD = comandoBD.ExecuteReader();


            if (lectorBD.HasRows)
            {
                bool bandera = false;
                if (codigo == "")
                {
                    MessageBox.Show("ingrese un apellido");
                    bandera = true;
                }
                else
                {
                    while (lectorBD.Read())
                    {
                        if ((lectorBD[0].ToString()) == codigo)
                        {

                            dgvMostrar.Rows.Clear();
                            dgvMostrar.Rows.Add(lectorBD[0], lectorBD[1], lectorBD[2], lectorBD[3], lectorBD[4], lectorBD[6], lectorBD[7]);
                            bandera = true;
                            break;
                        }

                    }
                }

                if (bandera == false)
                {

                    MessageBox.Show("La identificación ingresada no existe", "Consulta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    traerDatos(dgvMostrar);
                }
            }
        }
        int buscador = 0;

        public void BuscarDireccion(string codigo, DataGridView dgvMostrar)
        {
            ConectarBD();
            dgvMostrar.Rows.Clear();
            comandoBD = new OleDbCommand();
            comandoBD.Connection = conexionBD;
            comandoBD.CommandType = System.Data.CommandType.TableDirect;
            comandoBD.CommandText = "DATOS PERSONALES";
            lectorBD = comandoBD.ExecuteReader();


            if (lectorBD.HasRows)
            {
                buscador = 0;
                while (lectorBD.Read()) 
                {
                    if (lectorBD[2].ToString() == codigo)
                    {
                        dgvMostrar.Rows.Add(lectorBD[0], lectorBD[1], lectorBD[2], lectorBD[3], lectorBD[4], lectorBD[5], lectorBD[6]);
                        buscador = 1;

                    }
                }
                conexionBD.Close();

                if (buscador == 0)
                {
                    MessageBox.Show("La dIrección ingresada no existe" + codigo);
                    traerDatos(dgvMostrar);
                }
            }
        }
    }
}
