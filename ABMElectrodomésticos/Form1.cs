using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ABMElectrodomésticos
{
    public partial class FrmElectrodomesticos: Form
    {
        public FrmElectrodomesticos()
        {
            InitializeComponent();
        }

        private void FrmElectrodomesticos_Load(object sender, EventArgs e)
        {
            //Conecto la base de datos
            ConexionSql.ConectarBD();

            //Muestro la BD en la grilla
            DataTable tablita = new DataTable();
            tablita.Load(ConexionSql.LecturaBD("SELECT [Id],[electrodomesticos_codigo],[electrodomesticos_tipo],[electrodomesticos_marca]," +
                "[electrodomesticos_modelo],[electrodomesticos_caracteristicas],[electrodomesticos_cantidad_stock],[electrodomesticos_precio],[electrodomesticos_fecha_ingreso] FROM [Electrodomesticos].[dbo].[Electrodomestico]"));
            dgv_grilla.DataSource = tablita;
                


            dgv_grilla.EnableHeadersVisualStyles = false;


            //Grilla diseño
            // Cabecera
            dgv_grilla.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(50, 50, 50);
            dgv_grilla.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgv_grilla.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 8, FontStyle.Bold);
            dgv_grilla.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            //Seteo de headertext a eleccion y perzonalisado 
            dgv_grilla.Columns["electrodomesticos_codigo"].HeaderText = "Codigo";
            dgv_grilla.Columns["electrodomesticos_tipo"].HeaderText = "Tipo";
            dgv_grilla.Columns["electrodomesticos_marca"].HeaderText = "Marca";
            dgv_grilla.Columns["electrodomesticos_modelo"].HeaderText = "Modelo";
            dgv_grilla.Columns["electrodomesticos_caracteristicas"].HeaderText = "Caracteristicas";
            dgv_grilla.Columns["electrodomesticos_cantidad_stock"].HeaderText = "Stock";
            dgv_grilla.Columns["electrodomesticos_precio"].HeaderText = "Precio";
            dgv_grilla.Columns["electrodomesticos_fecha_ingreso"].HeaderText = "Fecha Ingreso";

            // Filas
            dgv_grilla.DefaultCellStyle.Font = new Font("Segoe UI", 8);
            dgv_grilla.DefaultCellStyle.BackColor = Color.White;
            dgv_grilla.DefaultCellStyle.ForeColor = Color.Black;
            dgv_grilla.DefaultCellStyle.SelectionBackColor = Color.LightSteelBlue;
            dgv_grilla.DefaultCellStyle.SelectionForeColor = Color.Black;
            // Otras cositas
            dgv_grilla.RowTemplate.Height = 35;
            dgv_grilla.GridColor = Color.Gainsboro;
            dgv_grilla.BackgroundColor = Color.White;
            dgv_grilla.BorderStyle = BorderStyle.None;
        }


        #region ControlarAcciones
        //funcion para controlar el acceso a los botones
        private void ControlarAcciones()
        {
            if (rb_agregar.Checked)
            {
                btn_agregar.Enabled = true;
                btn_modificar.Enabled = false;
                btn_eliminar.Enabled = false;
                btn_eliminar2.Enabled = false;
                txt_codigoProducto.Enabled = true;
                LimpiarCampos();

                btn_agregar.BackColor = Color.Green;
                btn_modificar.BackColor = SystemColors.Control;
                btn_eliminar.BackColor = SystemColors.Control;
                btn_eliminar2.BackColor = SystemColors.Control;
            }
            else if (rb_modificar.Checked)
            {
                btn_agregar.Enabled = false;
                btn_modificar.Enabled = true;
                btn_eliminar.Enabled = false;
                btn_eliminar2.Enabled = false;
                txt_codigoProducto.Enabled = false;
                LimpiarCampos();

                btn_modificar.BackColor = Color.Blue;
                btn_agregar.BackColor = SystemColors.Control;
                btn_eliminar.BackColor = SystemColors.Control;
                btn_eliminar2.BackColor = SystemColors.Control;
            }
            else if (rb_eliminar.Checked)
            {
                btn_agregar.Enabled = false;
                btn_modificar.Enabled = false;
                btn_eliminar.Enabled = true;
                btn_eliminar2.Enabled = true;
                LimpiarCampos();

                btn_eliminar.BackColor = Color.DarkRed;
                btn_eliminar2.BackColor = Color.DarkRed;
                btn_agregar.BackColor = SystemColors.Control;
                btn_modificar.BackColor = SystemColors.Control;
            }
            else
            {
                btn_agregar.Enabled = false;
                btn_modificar.Enabled = false;
                btn_eliminar.Enabled = false;
                btn_eliminar2.Enabled = false;
            }
        }

        private void rb_agregar_CheckedChanged(object sender, EventArgs e)
        {
            ControlarAcciones();
        }

        private void rb_modificar_CheckedChanged(object sender, EventArgs e)
        {
            ControlarAcciones();
        }

        private void rb_eliminar_CheckedChanged(object sender, EventArgs e)
        {
            ControlarAcciones();
        }
        #endregion
        
        
        //boton salir
        private void btn_salir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Seguro que querés salir?", "Confirmación",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
                ConexionSql.CierraBD();
            }
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            // Validar campos
            if (!ValidarCampos())
                return;

            // Verificar que no exista el mismo código ya en la BD
            string codigo = txt_codigoProducto.Text;
            string queryVerificar = "SELECT COUNT(*) FROM Electrodomestico WHERE electrodomesticos_codigo = '" + codigo + "'";
            SqlCommand cmd = new SqlCommand(queryVerificar, ConexionSql.ConexionSQL);
            int cantidad = (int)cmd.ExecuteScalar();
            if (cantidad > 0)
            {
                MessageBox.Show("Ya existe un electrodoméstico con ese código.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Armar el insert
            string insertQuery = "INSERT INTO dbo.Electrodomestico " +
                                 "(electrodomesticos_codigo,electrodomesticos_tipo, electrodomesticos_marca, electrodomesticos_modelo, " +
                                 "electrodomesticos_caracteristicas, electrodomesticos_cantidad_stock, electrodomesticos_precio, electrodomesticos_fecha_ingreso) " +
                                 "VALUES ('" + txt_codigoProducto.Text.Replace("'", "''") + "', " +
                                 "'" + txt_tipo.Text.Replace("'", "''") + "', " +
                                 "'" + txt_marca.Text.Replace("'", "''") + "', " +
                                 "'" + txt_modelo.Text.Replace("'", "''") + "', " +
                                 "'" + txt_caracteristicas.Text.Replace("'", "''") + "', " +
                                 txt_stock.Text + ", " +
                                 txt_precio.Text.Replace(",", ".") + ", " +  // importante si usás coma como decimal
                                 "'" + dtp_fechaIngreso.Value.ToString("yyyy-MM-dd") + "')";

            // Ejecutar
            ConexionSql.EjecutaQuery(insertQuery);
            MessageBox.Show("Artículo agregado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

            ActualizarGrilla();
            LimpiarCampos();
        }


        private void LimpiarCampos()
        {
            txt_codigoProducto.Text = "";
            txt_tipo.Text = "";
            txt_marca.Text = "";
            txt_modelo.Text = "";
            txt_caracteristicas.Text = "";
            txt_stock.Text = "";
            txt_precio.Text = "";
        }

        private void ActualizarGrilla()
        {
            string query = "SELECT Id, " +
                     "electrodomesticos_codigo AS Codigo, " +
                     "electrodomesticos_tipo AS Tipo, " +
                     "electrodomesticos_marca AS Marca, " +
                     "electrodomesticos_modelo AS Modelo, " +
                     "electrodomesticos_caracteristicas AS Caracteristicas, " +
                     "electrodomesticos_cantidad_stock AS Stock, " +
                     "electrodomesticos_precio AS Precio, " +
                     "electrodomesticos_fecha_ingreso AS [Fecha Ingreso] " +
                     "FROM Electrodomestico " +
                     "WHERE electrodomesticos_cantidad_stock > 0";

            DataTable tabla = ConexionSql.LecturaBD_DataTable(query);
            dgv_grilla.DataSource = tabla;

        }


        #region Validaciones
        private bool ValidarCampos()
        {
            // Validar código (formato tipo "0001")
            if (!Validaciones.CodigoValido(txt_codigoProducto.Text))
            {
                MessageBox.Show("El código debe tener 4 dígitos numéricos.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // Validar tipo (solo letras y espacios)
            if (!Validaciones.TextoValido(txt_tipo.Text))
            {
                MessageBox.Show("El tipo solo debe contener letras.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // Validar marca
            if (!Validaciones.TextoValido(txt_marca.Text))
            {
                MessageBox.Show("La marca solo debe contener letras.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

        
            // Validar características (que no esté vacío)
            if (Validaciones.CampoVacio(txt_caracteristicas.Text))
            {
                MessageBox.Show("Las características no pueden estar vacías.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // Validar stock (entero válido >= 0)
            if (!Validaciones.NumeroEnteroValido(txt_stock.Text))
            {
                MessageBox.Show("El stock debe ser un número entero válido.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // Validar precio (decimal válido >= 0)
            if (!Validaciones.PrecioValido(txt_precio.Text))
            {
                MessageBox.Show("El precio debe ser un número decimal válido.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true; // Si pasa todas las validaciones, retorna true
        }
        #endregion

        private void btn_modificar_Click(object sender, EventArgs e)
        {

            if (!ValidarCampos())
                return;

            if (string.IsNullOrWhiteSpace(txt_codigoProducto.Text))
            {
                MessageBox.Show("Seleccioná un registro de la grilla para modificar.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string query = "UPDATE Electrodomestico SET " +
                           "electrodomesticos_tipo = '" + txt_tipo.Text.Replace("'", "''") + "', " +
                           "electrodomesticos_marca = '" + txt_marca.Text.Replace("'", "''") + "', " +
                           "electrodomesticos_modelo = '" + txt_modelo.Text.Replace("'", "''") + "', " +
                           "electrodomesticos_caracteristicas = '" + txt_caracteristicas.Text.Replace("'", "''") + "', " +
                           "electrodomesticos_cantidad_stock = " + txt_stock.Text + ", " +
                           "electrodomesticos_precio = " + txt_precio.Text.Replace(",", ".") + ", " +
                           "electrodomesticos_fecha_ingreso = '" + dtp_fechaIngreso.Value.ToString("yyyy-MM-dd") + "' " +
                           "WHERE Id = " + txt_codigoProducto.Text;

            ConexionSql.EjecutaQuery(query);
            MessageBox.Show("Registro modificado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ActualizarGrilla();
            LimpiarCampos();
        }

        private void dgv_grilla_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            DataGridViewRow fila = dgv_grilla.Rows[e.RowIndex];

            txt_idOculto.Text = fila.Cells["Id"].Value.ToString();  // Guarda el ID real
            txt_codigoProducto.Text = fila.Cells[1].Value?.ToString(); // Código
            txt_tipo.Text = fila.Cells[2].Value?.ToString();
            txt_marca.Text = fila.Cells[3].Value?.ToString();
            txt_modelo.Text = fila.Cells[4].Value?.ToString();
            txt_caracteristicas.Text = fila.Cells[5].Value?.ToString();
            txt_stock.Text = fila.Cells[6].Value?.ToString();
            txt_precio.Text = fila.Cells[7].Value?.ToString();

            // Verificar si la celda tiene valor antes de asignar
            if (fila.Cells[8].Value != null)
                dtp_fechaIngreso.Value = Convert.ToDateTime(fila.Cells[8].Value);
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_codigoProducto.Text))
            {
                MessageBox.Show("Seleccioná un registro para dar de baja lógica.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string query = "UPDATE Electrodomestico SET electrodomesticos_cantidad_stock = 0 WHERE Id = " + txt_idOculto.Text;

            ConexionSql.EjecutaQuery(query);
            MessageBox.Show("Baja lógica realizada (stock = 0).", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ActualizarGrilla();
            LimpiarCampos();
        }

        private void btn_eliminar2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_codigoProducto.Text))
            {
                MessageBox.Show("Seleccioná un registro para eliminar.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult r = MessageBox.Show("¿Estás seguro que querés eliminar este registro?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult.No)
                return;

            string query = "DELETE FROM Electrodomestico WHERE Id = " + txt_idOculto.Text;


            ConexionSql.EjecutaQuery(query);
            MessageBox.Show("Registro eliminado definitivamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ActualizarGrilla();
             
            LimpiarCampos();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MostrarTodo();
                
         }

        private void MostrarTodo()
        {
            string query = "SELECT Id, " +
                           "electrodomesticos_codigo AS Codigo, " +
                           "electrodomesticos_tipo AS Tipo, " +
                           "electrodomesticos_marca AS Marca, " +
                           "electrodomesticos_modelo AS Modelo, " +
                           "electrodomesticos_caracteristicas AS Caracteristicas, " +
                           "electrodomesticos_cantidad_stock AS Stock, " +
                           "electrodomesticos_precio AS Precio, " +
                           "electrodomesticos_fecha_ingreso AS [Fecha Ingreso] " +
                           "FROM Electrodomestico"; // sin WHERE stock > 0

            DataTable tabla = ConexionSql.LecturaBD_DataTable(query);
            dgv_grilla.DataSource = tabla;

            dgv_grilla.ClearSelection();
            dgv_grilla.ReadOnly = true;
            dgv_grilla.AllowUserToAddRows = false;
            dgv_grilla.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_grilla.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
    }
}
