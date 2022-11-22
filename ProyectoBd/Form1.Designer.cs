namespace ProyectoBd
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.Insertar = new System.Windows.Forms.Button();
            this.Actualizar = new System.Windows.Forms.Button();
            this.Seleccionar = new System.Windows.Forms.Button();
            this.Eliminar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDuracion = new System.Windows.Forms.TextBox();
            this.txtFecha = new System.Windows.Forms.TextBox();
            this.txtArtista = new System.Windows.Forms.TextBox();
            this.txtAlbum = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDisquera = new System.Windows.Forms.TextBox();
            this.Buscar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Insertar
            // 
            this.Insertar.Location = new System.Drawing.Point(199, 337);
            this.Insertar.Name = "Insertar";
            this.Insertar.Size = new System.Drawing.Size(322, 37);
            this.Insertar.TabIndex = 10;
            this.Insertar.Text = "&Insertar";
            this.Insertar.UseVisualStyleBackColor = true;
            // 
            // Actualizar
            // 
            this.Actualizar.Location = new System.Drawing.Point(199, 386);
            this.Actualizar.Name = "Actualizar";
            this.Actualizar.Size = new System.Drawing.Size(322, 37);
            this.Actualizar.TabIndex = 11;
            this.Actualizar.Text = "&Actualizar";
            this.Actualizar.UseVisualStyleBackColor = true;
            // 
            // Seleccionar
            // 
            this.Seleccionar.Location = new System.Drawing.Point(199, 439);
            this.Seleccionar.Name = "Seleccionar";
            this.Seleccionar.Size = new System.Drawing.Size(322, 37);
            this.Seleccionar.TabIndex = 12;
            this.Seleccionar.Text = "&Seleccionar";
            this.Seleccionar.UseVisualStyleBackColor = true;
            // 
            // Eliminar
            // 
            this.Eliminar.Location = new System.Drawing.Point(199, 492);
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.Size = new System.Drawing.Size(322, 37);
            this.Eliminar.TabIndex = 13;
            this.Eliminar.Text = "&Eliminar";
            this.Eliminar.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.Buscar);
            this.panel1.Controls.Add(this.txtDisquera);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtDuracion);
            this.panel1.Controls.Add(this.txtFecha);
            this.panel1.Controls.Add(this.txtArtista);
            this.panel1.Controls.Add(this.txtAlbum);
            this.panel1.Controls.Add(this.txtNombre);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(740, 319);
            this.panel1.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(14, 222);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 20);
            this.label5.TabIndex = 19;
            this.label5.Text = "Duración";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(14, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 40);
            this.label4.TabIndex = 18;
            this.label4.Text = "Fecha de\r\nlanzamiento";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(19, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 20);
            this.label3.TabIndex = 17;
            this.label3.Text = "Artista";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(19, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 20);
            this.label2.TabIndex = 16;
            this.label2.Text = "Albúm";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 20);
            this.label1.TabIndex = 15;
            this.label1.Text = "Nombre";
            // 
            // txtDuracion
            // 
            this.txtDuracion.Location = new System.Drawing.Point(130, 222);
            this.txtDuracion.Name = "txtDuracion";
            this.txtDuracion.Size = new System.Drawing.Size(343, 22);
            this.txtDuracion.TabIndex = 14;
            // 
            // txtFecha
            // 
            this.txtFecha.Location = new System.Drawing.Point(130, 157);
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.Size = new System.Drawing.Size(343, 22);
            this.txtFecha.TabIndex = 13;
            // 
            // txtArtista
            // 
            this.txtArtista.Location = new System.Drawing.Point(130, 118);
            this.txtArtista.Name = "txtArtista";
            this.txtArtista.Size = new System.Drawing.Size(343, 22);
            this.txtArtista.TabIndex = 12;
            // 
            // txtAlbum
            // 
            this.txtAlbum.Location = new System.Drawing.Point(130, 64);
            this.txtAlbum.Name = "txtAlbum";
            this.txtAlbum.Size = new System.Drawing.Size(343, 22);
            this.txtAlbum.TabIndex = 11;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(130, 14);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(343, 22);
            this.txtNombre.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(14, 274);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 20);
            this.label6.TabIndex = 20;
            this.label6.Text = "Disquera";
            // 
            // txtDisquera
            // 
            this.txtDisquera.Location = new System.Drawing.Point(130, 272);
            this.txtDisquera.Name = "txtDisquera";
            this.txtDisquera.Size = new System.Drawing.Size(343, 22);
            this.txtDisquera.TabIndex = 21;
            // 
            // Buscar
            // 
            this.Buscar.Location = new System.Drawing.Point(580, 245);
            this.Buscar.Name = "Buscar";
            this.Buscar.Size = new System.Drawing.Size(75, 23);
            this.Buscar.TabIndex = 15;
            this.Buscar.Text = "Buscar";
            this.Buscar.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(528, 55);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(178, 174);
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(546, 32);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(140, 20);
            this.label7.TabIndex = 23;
            this.label7.Text = "Imagen del albúm";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 549);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Eliminar);
            this.Controls.Add(this.Seleccionar);
            this.Controls.Add(this.Actualizar);
            this.Controls.Add(this.Insertar);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MusicaDb";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button Insertar;
        private System.Windows.Forms.Button Actualizar;
        private System.Windows.Forms.Button Seleccionar;
        private System.Windows.Forms.Button Eliminar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDuracion;
        private System.Windows.Forms.TextBox txtFecha;
        private System.Windows.Forms.TextBox txtArtista;
        private System.Windows.Forms.TextBox txtAlbum;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Buscar;
        private System.Windows.Forms.TextBox txtDisquera;
        private System.Windows.Forms.Label label6;
    }
}

