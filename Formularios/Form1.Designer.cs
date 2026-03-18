namespace IPC2_Practica2_202303088
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtEdad;
        private System.Windows.Forms.ComboBox cmbEspecialidad;
        private System.Windows.Forms.ListBox listCola;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Button btnMostrar;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtEdad = new System.Windows.Forms.TextBox();
            this.cmbEspecialidad = new System.Windows.Forms.ComboBox();
            this.listCola = new System.Windows.Forms.ListBox();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.btnMostrar = new System.Windows.Forms.Button();

            // txtNombre
            this.txtNombre.Location = new System.Drawing.Point(30, 30);
            this.txtNombre.Size = new System.Drawing.Size(200, 23);
            this.txtNombre.PlaceholderText = "Nombre";

            // txtEdad
            this.txtEdad.Location = new System.Drawing.Point(30, 70);
            this.txtEdad.Size = new System.Drawing.Size(200, 23);
            this.txtEdad.PlaceholderText = "Edad";

            // cmbEspecialidad
            this.cmbEspecialidad.Location = new System.Drawing.Point(30, 110);
            this.cmbEspecialidad.Size = new System.Drawing.Size(200, 23);

            // btnRegistrar
            this.btnRegistrar.Location = new System.Drawing.Point(30, 150);
            this.btnRegistrar.Size = new System.Drawing.Size(100, 30);
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);

            // btnMostrar
            this.btnMostrar.Location = new System.Drawing.Point(140, 150);
            this.btnMostrar.Size = new System.Drawing.Size(100, 30);
            this.btnMostrar.Text = "Mostrar";
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);

            // listCola
            this.listCola.Location = new System.Drawing.Point(30, 200);
            this.listCola.Size = new System.Drawing.Size(300, 150);

            // Form1
            this.ClientSize = new System.Drawing.Size(400, 400);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtEdad);
            this.Controls.Add(this.cmbEspecialidad);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.btnMostrar);
            this.Controls.Add(this.listCola);
            this.Text = "Clínica - Turnos";

        }
    }
}