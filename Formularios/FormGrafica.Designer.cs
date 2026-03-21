namespace IPC2_Practica2_202303088
{
    partial class FormGrafica
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnRegresar;

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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnRegresar = new System.Windows.Forms.Button();

            // pictureBox
            this.pictureBox1.Location = new System.Drawing.Point(20, 20);
            this.pictureBox1.Size = new System.Drawing.Size(760, 400);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;

            // botón regresar
            this.btnRegresar.Location = new System.Drawing.Point(350, 430);
            this.btnRegresar.Size = new System.Drawing.Size(100, 30);
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);

            // FormGrafica
            this.ClientSize = new System.Drawing.Size(800, 500);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnRegresar);
            this.Text = "Visualización de Cola";
        }
    }
}