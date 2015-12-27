namespace Directorio
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
	  if (disposing && (components != null))
	  {
	      components.Dispose();
	  }
	  base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
	  this.lblNombre = new System.Windows.Forms.Label();
	  this.lblApellido = new System.Windows.Forms.Label();
	  this.lblCelular = new System.Windows.Forms.Label();
	  this.checkBoxFavorito = new System.Windows.Forms.CheckBox();
	  this.lblFavorito = new System.Windows.Forms.Label();
	  this.txtNombre = new System.Windows.Forms.TextBox();
	  this.txtApellido = new System.Windows.Forms.TextBox();
	  this.txtCelular = new System.Windows.Forms.TextBox();
	  this.btnGuardar = new System.Windows.Forms.Button();
	  this.lblInformation = new System.Windows.Forms.Label();
	  this.dataGrid = new System.Windows.Forms.DataGridView();
	  ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
	  this.SuspendLayout();
	  // 
	  // lblNombre
	  // 
	  this.lblNombre.AutoSize = true;
	  this.lblNombre.Location = new System.Drawing.Point(37, 33);
	  this.lblNombre.Name = "lblNombre";
	  this.lblNombre.Size = new System.Drawing.Size(44, 13);
	  this.lblNombre.TabIndex = 0;
	  this.lblNombre.Text = "Nombre";
	  // 
	  // lblApellido
	  // 
	  this.lblApellido.AutoSize = true;
	  this.lblApellido.Location = new System.Drawing.Point(37, 65);
	  this.lblApellido.Name = "lblApellido";
	  this.lblApellido.Size = new System.Drawing.Size(44, 13);
	  this.lblApellido.TabIndex = 1;
	  this.lblApellido.Text = "Apellido";
	  // 
	  // lblCelular
	  // 
	  this.lblCelular.AutoSize = true;
	  this.lblCelular.Location = new System.Drawing.Point(37, 99);
	  this.lblCelular.Name = "lblCelular";
	  this.lblCelular.Size = new System.Drawing.Size(39, 13);
	  this.lblCelular.TabIndex = 2;
	  this.lblCelular.Text = "Celular";
	  // 
	  // checkBoxFavorito
	  // 
	  this.checkBoxFavorito.AutoSize = true;
	  this.checkBoxFavorito.Location = new System.Drawing.Point(97, 125);
	  this.checkBoxFavorito.Name = "checkBoxFavorito";
	  this.checkBoxFavorito.Size = new System.Drawing.Size(36, 17);
	  this.checkBoxFavorito.TabIndex = 3;
	  this.checkBoxFavorito.Text = "SI";
	  this.checkBoxFavorito.UseVisualStyleBackColor = true;
	  // 
	  // lblFavorito
	  // 
	  this.lblFavorito.AutoSize = true;
	  this.lblFavorito.Location = new System.Drawing.Point(37, 125);
	  this.lblFavorito.Name = "lblFavorito";
	  this.lblFavorito.Size = new System.Drawing.Size(45, 13);
	  this.lblFavorito.TabIndex = 4;
	  this.lblFavorito.Text = "Favorito";
	  // 
	  // txtNombre
	  // 
	  this.txtNombre.Location = new System.Drawing.Point(97, 30);
	  this.txtNombre.Name = "txtNombre";
	  this.txtNombre.Size = new System.Drawing.Size(100, 20);
	  this.txtNombre.TabIndex = 5;
	  // 
	  // txtApellido
	  // 
	  this.txtApellido.Location = new System.Drawing.Point(97, 62);
	  this.txtApellido.Name = "txtApellido";
	  this.txtApellido.Size = new System.Drawing.Size(100, 20);
	  this.txtApellido.TabIndex = 6;
	  // 
	  // txtCelular
	  // 
	  this.txtCelular.Location = new System.Drawing.Point(97, 92);
	  this.txtCelular.Name = "txtCelular";
	  this.txtCelular.Size = new System.Drawing.Size(100, 20);
	  this.txtCelular.TabIndex = 7;
	  // 
	  // btnGuardar
	  // 
	  this.btnGuardar.Location = new System.Drawing.Point(40, 159);
	  this.btnGuardar.Name = "btnGuardar";
	  this.btnGuardar.Size = new System.Drawing.Size(157, 30);
	  this.btnGuardar.TabIndex = 8;
	  this.btnGuardar.Text = "Guardar Contacto";
	  this.btnGuardar.UseVisualStyleBackColor = true;
	  this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
	  // 
	  // lblInformation
	  // 
	  this.lblInformation.AutoSize = true;
	  this.lblInformation.ForeColor = System.Drawing.Color.Red;
	  this.lblInformation.Location = new System.Drawing.Point(40, 211);
	  this.lblInformation.Name = "lblInformation";
	  this.lblInformation.Size = new System.Drawing.Size(0, 13);
	  this.lblInformation.TabIndex = 9;
	  // 
	  // dataGrid
	  // 
	  this.dataGrid.AllowUserToAddRows = false;
	  this.dataGrid.AllowUserToDeleteRows = false;
	  this.dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
	  this.dataGrid.Location = new System.Drawing.Point(222, 30);
	  this.dataGrid.Name = "dataGrid";
	  this.dataGrid.ReadOnly = true;
	  this.dataGrid.Size = new System.Drawing.Size(453, 273);
	  this.dataGrid.TabIndex = 10;
	  // 
	  // Form1
	  // 
	  this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
	  this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
	  this.ClientSize = new System.Drawing.Size(710, 329);
	  this.Controls.Add(this.dataGrid);
	  this.Controls.Add(this.lblInformation);
	  this.Controls.Add(this.btnGuardar);
	  this.Controls.Add(this.txtCelular);
	  this.Controls.Add(this.txtApellido);
	  this.Controls.Add(this.txtNombre);
	  this.Controls.Add(this.lblFavorito);
	  this.Controls.Add(this.checkBoxFavorito);
	  this.Controls.Add(this.lblCelular);
	  this.Controls.Add(this.lblApellido);
	  this.Controls.Add(this.lblNombre);
	  this.Name = "Form1";
	  this.Text = "Directorio Telefonico Diplomado";
	  ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
	  this.ResumeLayout(false);
	  this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblCelular;
        private System.Windows.Forms.CheckBox checkBoxFavorito;
        private System.Windows.Forms.Label lblFavorito;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtCelular;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label lblInformation;
        private System.Windows.Forms.DataGridView dataGrid;
    }
}

