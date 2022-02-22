
namespace PruebaAgenda
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.tDni = new System.Windows.Forms.Label();
            this.tNombre = new System.Windows.Forms.Label();
            this.tApellido = new System.Windows.Forms.Label();
            this.tDireccion = new System.Windows.Forms.Label();
            this.tTelefono = new System.Windows.Forms.Label();
            this.tFecNac = new System.Windows.Forms.Label();
            this.textDni = new System.Windows.Forms.TextBox();
            this.textApellido = new System.Windows.Forms.TextBox();
            this.textNombre = new System.Windows.Forms.TextBox();
            this.textDir = new System.Windows.Forms.TextBox();
            this.textTel = new System.Windows.Forms.TextBox();
            this.textFec = new System.Windows.Forms.TextBox();
            this.bGuardar = new System.Windows.Forms.Button();
            this.bAtras = new System.Windows.Forms.Button();
            this.bAdelante = new System.Windows.Forms.Button();
            this.tIndice = new System.Windows.Forms.Label();
            this.bIndice = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(273, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(217, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Agenda Electronica";
            // 
            // tDni
            // 
            this.tDni.AutoSize = true;
            this.tDni.Location = new System.Drawing.Point(34, 84);
            this.tDni.Name = "tDni";
            this.tDni.Size = new System.Drawing.Size(29, 13);
            this.tDni.TabIndex = 1;
            this.tDni.Text = "DNI:";
            // 
            // tNombre
            // 
            this.tNombre.AutoSize = true;
            this.tNombre.Location = new System.Drawing.Point(34, 142);
            this.tNombre.Name = "tNombre";
            this.tNombre.Size = new System.Drawing.Size(47, 13);
            this.tNombre.TabIndex = 2;
            this.tNombre.Text = "Nombre:";
            // 
            // tApellido
            // 
            this.tApellido.AutoSize = true;
            this.tApellido.Location = new System.Drawing.Point(34, 206);
            this.tApellido.Name = "tApellido";
            this.tApellido.Size = new System.Drawing.Size(47, 13);
            this.tApellido.TabIndex = 3;
            this.tApellido.Text = "Apellido:";
            // 
            // tDireccion
            // 
            this.tDireccion.AutoSize = true;
            this.tDireccion.Location = new System.Drawing.Point(418, 84);
            this.tDireccion.Name = "tDireccion";
            this.tDireccion.Size = new System.Drawing.Size(55, 13);
            this.tDireccion.TabIndex = 4;
            this.tDireccion.Text = "Direccion:";
            // 
            // tTelefono
            // 
            this.tTelefono.AutoSize = true;
            this.tTelefono.Location = new System.Drawing.Point(418, 142);
            this.tTelefono.Name = "tTelefono";
            this.tTelefono.Size = new System.Drawing.Size(52, 13);
            this.tTelefono.TabIndex = 5;
            this.tTelefono.Text = "Telefono:";
            // 
            // tFecNac
            // 
            this.tFecNac.AutoSize = true;
            this.tFecNac.Location = new System.Drawing.Point(418, 206);
            this.tFecNac.Name = "tFecNac";
            this.tFecNac.Size = new System.Drawing.Size(51, 13);
            this.tFecNac.TabIndex = 6;
            this.tFecNac.Text = "Fec Nac:";
            // 
            // textDni
            // 
            this.textDni.Location = new System.Drawing.Point(143, 84);
            this.textDni.Name = "textDni";
            this.textDni.Size = new System.Drawing.Size(238, 20);
            this.textDni.TabIndex = 7;
          
            // 
            // textApellido
            // 
            this.textApellido.Location = new System.Drawing.Point(143, 203);
            this.textApellido.Name = "textApellido";
            this.textApellido.Size = new System.Drawing.Size(238, 20);
            this.textApellido.TabIndex = 8;
            // 
            // textNombre
            // 
            this.textNombre.Location = new System.Drawing.Point(143, 142);
            this.textNombre.Name = "textNombre";
            this.textNombre.Size = new System.Drawing.Size(238, 20);
            this.textNombre.TabIndex = 9;
            // 
            // textDir
            // 
            this.textDir.Location = new System.Drawing.Point(502, 81);
            this.textDir.Name = "textDir";
            this.textDir.Size = new System.Drawing.Size(238, 20);
            this.textDir.TabIndex = 10;
            // 
            // textTel
            // 
            this.textTel.Location = new System.Drawing.Point(502, 142);
            this.textTel.Name = "textTel";
            this.textTel.Size = new System.Drawing.Size(238, 20);
            this.textTel.TabIndex = 11;
            // 
            // textFec
            // 
            this.textFec.Location = new System.Drawing.Point(502, 203);
            this.textFec.Name = "textFec";
            this.textFec.Size = new System.Drawing.Size(238, 20);
            this.textFec.TabIndex = 12;
            // 
            // bGuardar
            // 
            this.bGuardar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.bGuardar.FlatAppearance.BorderSize = 3;
            this.bGuardar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.bGuardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.bGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bGuardar.Location = new System.Drawing.Point(306, 284);
            this.bGuardar.Name = "bGuardar";
            this.bGuardar.Size = new System.Drawing.Size(205, 53);
            this.bGuardar.TabIndex = 13;
            this.bGuardar.Text = "Guardar";
            this.bGuardar.UseVisualStyleBackColor = true;
            this.bGuardar.Click += new System.EventHandler(this.bGuardar_Click);
            // 
            // bAtras
            // 
            this.bAtras.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.bAtras.FlatAppearance.BorderSize = 3;
            this.bAtras.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.bAtras.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.bAtras.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bAtras.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bAtras.Location = new System.Drawing.Point(131, 284);
            this.bAtras.Name = "bAtras";
            this.bAtras.Size = new System.Drawing.Size(119, 53);
            this.bAtras.TabIndex = 14;
            this.bAtras.Text = "<<";
            this.bAtras.UseVisualStyleBackColor = true;
            this.bAtras.Click += new System.EventHandler(this.bAtras_Click);
            // 
            // bAdelante
            // 
            this.bAdelante.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.bAdelante.FlatAppearance.BorderSize = 3;
            this.bAdelante.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.bAdelante.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.bAdelante.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bAdelante.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bAdelante.Location = new System.Drawing.Point(554, 284);
            this.bAdelante.Name = "bAdelante";
            this.bAdelante.Size = new System.Drawing.Size(119, 53);
            this.bAdelante.TabIndex = 15;
            this.bAdelante.Text = ">>";
            this.bAdelante.UseVisualStyleBackColor = true;
            this.bAdelante.Click += new System.EventHandler(this.bAdelante_Click);
            // 
            // tIndice
            // 
            this.tIndice.AutoSize = true;
            this.tIndice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tIndice.Location = new System.Drawing.Point(291, 389);
            this.tIndice.Name = "tIndice";
            this.tIndice.Size = new System.Drawing.Size(52, 20);
            this.tIndice.TabIndex = 16;
            this.tIndice.Text = "Indice";
            // 
            // bIndice
            // 
            this.bIndice.Enabled = false;
            this.bIndice.Location = new System.Drawing.Point(376, 376);
            this.bIndice.Name = "bIndice";
            this.bIndice.Size = new System.Drawing.Size(93, 49);
            this.bIndice.TabIndex = 17;
            this.bIndice.Text = "0";
            this.bIndice.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bIndice);
            this.Controls.Add(this.tIndice);
            this.Controls.Add(this.bAdelante);
            this.Controls.Add(this.bAtras);
            this.Controls.Add(this.bGuardar);
            this.Controls.Add(this.textFec);
            this.Controls.Add(this.textTel);
            this.Controls.Add(this.textDir);
            this.Controls.Add(this.textNombre);
            this.Controls.Add(this.textApellido);
            this.Controls.Add(this.textDni);
            this.Controls.Add(this.tFecNac);
            this.Controls.Add(this.tTelefono);
            this.Controls.Add(this.tDireccion);
            this.Controls.Add(this.tApellido);
            this.Controls.Add(this.tNombre);
            this.Controls.Add(this.tDni);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "AGENDA ELECTRONICA";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label tDni;
        private System.Windows.Forms.Label tNombre;
        private System.Windows.Forms.Label tApellido;
        private System.Windows.Forms.Label tDireccion;
        private System.Windows.Forms.Label tTelefono;
        private System.Windows.Forms.Label tFecNac;
        private System.Windows.Forms.TextBox textDni;
        private System.Windows.Forms.TextBox textApellido;
        private System.Windows.Forms.TextBox textNombre;
        private System.Windows.Forms.TextBox textDir;
        private System.Windows.Forms.TextBox textTel;
        private System.Windows.Forms.TextBox textFec;
        private System.Windows.Forms.Button bGuardar;
        private System.Windows.Forms.Button bAtras;
        private System.Windows.Forms.Button bAdelante;
        private System.Windows.Forms.Label tIndice;
        private System.Windows.Forms.Button bIndice;
    }
}

