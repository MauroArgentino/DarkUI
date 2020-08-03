using DarkUI.Controls;

namespace DarkUI.Forms
{
    partial class DarkOpenFileDialog
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
        	this.pnlFooter = new System.Windows.Forms.Panel();
        	this.lblTipoDeArchivo = new DarkUI.Controls.DarkLabel();
        	this.btnOk = new DarkUI.Controls.DarkButton();
        	this.btnCancel = new DarkUI.Controls.DarkButton();
        	this.lblNombreDelArchivo = new DarkUI.Controls.DarkLabel();
        	this.lblBuscarEn = new DarkUI.Controls.DarkLabel();
        	this.btnAccesoRapido = new DarkUI.Controls.DarkButton();
        	this.btnBibliotecas = new DarkUI.Controls.DarkButton();
        	this.btnEsteEquipo = new DarkUI.Controls.DarkButton();
        	this.btnRed = new DarkUI.Controls.DarkButton();
        	this.btnEscritorio = new DarkUI.Controls.DarkButton();
        	this.listView1 = new System.Windows.Forms.ListView();
        	this.colNombre = new System.Windows.Forms.ColumnHeader();
        	this.colFechaModificacion = new System.Windows.Forms.ColumnHeader();
        	this.colTamano = new System.Windows.Forms.ColumnHeader();
        	this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
        	this.darkButton1 = new DarkUI.Controls.DarkButton();
        	this.darkButton2 = new DarkUI.Controls.DarkButton();
        	this.darkButton3 = new DarkUI.Controls.DarkButton();
        	this.pnlFooter.SuspendLayout();
        	this.SuspendLayout();
        	// 
        	// pnlFooter
        	// 
        	this.pnlFooter.Controls.Add(this.lblTipoDeArchivo);
        	this.pnlFooter.Controls.Add(this.btnOk);
        	this.pnlFooter.Controls.Add(this.btnCancel);
        	this.pnlFooter.Controls.Add(this.lblNombreDelArchivo);
        	this.pnlFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
        	this.pnlFooter.Location = new System.Drawing.Point(0, 328);
        	this.pnlFooter.Name = "pnlFooter";
        	this.pnlFooter.Size = new System.Drawing.Size(584, 74);
        	this.pnlFooter.TabIndex = 1;
        	// 
        	// lblTipoDeArchivo
        	// 
        	this.lblTipoDeArchivo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
        	this.lblTipoDeArchivo.Location = new System.Drawing.Point(93, 42);
        	this.lblTipoDeArchivo.Name = "lblTipoDeArchivo";
        	this.lblTipoDeArchivo.Size = new System.Drawing.Size(102, 23);
        	this.lblTipoDeArchivo.TabIndex = 13;
        	this.lblTipoDeArchivo.Text = "Tipo de archivo:";
        	this.lblTipoDeArchivo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        	// 
        	// btnOk
        	// 
        	this.btnOk.DialogResult = System.Windows.Forms.DialogResult.OK;
        	this.btnOk.Location = new System.Drawing.Point(496, 8);
        	this.btnOk.Margin = new System.Windows.Forms.Padding(0);
        	this.btnOk.Name = "btnOk";
        	this.btnOk.Padding = new System.Windows.Forms.Padding(5);
        	this.btnOk.Size = new System.Drawing.Size(75, 26);
        	this.btnOk.TabIndex = 3;
        	this.btnOk.Text = "Ok";
        	// 
        	// btnCancel
        	// 
        	this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
        	this.btnCancel.Location = new System.Drawing.Point(496, 39);
        	this.btnCancel.Margin = new System.Windows.Forms.Padding(0);
        	this.btnCancel.Name = "btnCancel";
        	this.btnCancel.Padding = new System.Windows.Forms.Padding(5);
        	this.btnCancel.Size = new System.Drawing.Size(75, 26);
        	this.btnCancel.TabIndex = 4;
        	this.btnCancel.Text = "Cancel";
        	// 
        	// lblNombreDelArchivo
        	// 
        	this.lblNombreDelArchivo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
        	this.lblNombreDelArchivo.Location = new System.Drawing.Point(93, 11);
        	this.lblNombreDelArchivo.Name = "lblNombreDelArchivo";
        	this.lblNombreDelArchivo.Size = new System.Drawing.Size(131, 23);
        	this.lblNombreDelArchivo.TabIndex = 13;
        	this.lblNombreDelArchivo.Text = "Nombre de archivo:";
        	this.lblNombreDelArchivo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        	// 
        	// lblBuscarEn
        	// 
        	this.lblBuscarEn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
        	this.lblBuscarEn.Location = new System.Drawing.Point(13, 15);
        	this.lblBuscarEn.Name = "lblBuscarEn";
        	this.lblBuscarEn.Size = new System.Drawing.Size(74, 23);
        	this.lblBuscarEn.TabIndex = 3;
        	this.lblBuscarEn.Text = "Buscar en:";
        	this.lblBuscarEn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        	// 
        	// btnAccesoRapido
        	// 
        	this.btnAccesoRapido.Location = new System.Drawing.Point(12, 52);
        	this.btnAccesoRapido.Name = "btnAccesoRapido";
        	this.btnAccesoRapido.Padding = new System.Windows.Forms.Padding(5);
        	this.btnAccesoRapido.Size = new System.Drawing.Size(75, 60);
        	this.btnAccesoRapido.TabIndex = 4;
        	this.btnAccesoRapido.Text = "Acceso Rápido";
        	// 
        	// btnBibliotecas
        	// 
        	this.btnBibliotecas.Location = new System.Drawing.Point(12, 188);
        	this.btnBibliotecas.Name = "btnBibliotecas";
        	this.btnBibliotecas.Padding = new System.Windows.Forms.Padding(5);
        	this.btnBibliotecas.Size = new System.Drawing.Size(75, 60);
        	this.btnBibliotecas.TabIndex = 5;
        	this.btnBibliotecas.Text = "Bibliotecas";
        	// 
        	// btnEsteEquipo
        	// 
        	this.btnEsteEquipo.Location = new System.Drawing.Point(12, 256);
        	this.btnEsteEquipo.Name = "btnEsteEquipo";
        	this.btnEsteEquipo.Padding = new System.Windows.Forms.Padding(5);
        	this.btnEsteEquipo.Size = new System.Drawing.Size(75, 60);
        	this.btnEsteEquipo.TabIndex = 6;
        	this.btnEsteEquipo.Text = "Este Equipo";
        	// 
        	// btnRed
        	// 
        	this.btnRed.Location = new System.Drawing.Point(12, 324);
        	this.btnRed.Name = "btnRed";
        	this.btnRed.Padding = new System.Windows.Forms.Padding(5);
        	this.btnRed.Size = new System.Drawing.Size(75, 60);
        	this.btnRed.TabIndex = 7;
        	this.btnRed.Text = "Red";
        	// 
        	// btnEscritorio
        	// 
        	this.btnEscritorio.Location = new System.Drawing.Point(12, 120);
        	this.btnEscritorio.Name = "btnEscritorio";
        	this.btnEscritorio.Padding = new System.Windows.Forms.Padding(5);
        	this.btnEscritorio.Size = new System.Drawing.Size(75, 60);
        	this.btnEscritorio.TabIndex = 4;
        	this.btnEscritorio.Text = "Escritorio";
        	// 
        	// listView1
        	// 
        	this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
			this.colNombre,
			this.colFechaModificacion,
			this.colTamano,
			this.columnHeader4});
        	this.listView1.GridLines = true;
        	this.listView1.Location = new System.Drawing.Point(93, 44);
        	this.listView1.Name = "listView1";
        	this.listView1.Size = new System.Drawing.Size(478, 278);
        	this.listView1.TabIndex = 11;
        	this.listView1.UseCompatibleStateImageBehavior = false;
        	this.listView1.View = System.Windows.Forms.View.List;
        	// 
        	// colNombre
        	// 
        	this.colNombre.Text = "Nombre";
        	this.colNombre.Width = 150;
        	// 
        	// colFechaModificacion
        	// 
        	this.colFechaModificacion.Text = "Fecha de Modificación";
        	this.colFechaModificacion.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
        	// 
        	// colTamano
        	// 
        	this.colTamano.Text = "Tamaño";
        	// 
        	// darkButton1
        	// 
        	this.darkButton1.Location = new System.Drawing.Point(407, 13);
        	this.darkButton1.Name = "darkButton1";
        	this.darkButton1.Padding = new System.Windows.Forms.Padding(5);
        	this.darkButton1.Size = new System.Drawing.Size(24, 24);
        	this.darkButton1.TabIndex = 12;
        	this.darkButton1.Text = "darkButton1";
        	// 
        	// darkButton2
        	// 
        	this.darkButton2.Location = new System.Drawing.Point(437, 13);
        	this.darkButton2.Name = "darkButton2";
        	this.darkButton2.Padding = new System.Windows.Forms.Padding(5);
        	this.darkButton2.Size = new System.Drawing.Size(24, 24);
        	this.darkButton2.TabIndex = 12;
        	this.darkButton2.Text = "darkButton1";
        	// 
        	// darkButton3
        	// 
        	this.darkButton3.Location = new System.Drawing.Point(467, 13);
        	this.darkButton3.Name = "darkButton3";
        	this.darkButton3.Padding = new System.Windows.Forms.Padding(5);
        	this.darkButton3.Size = new System.Drawing.Size(24, 24);
        	this.darkButton3.TabIndex = 12;
        	this.darkButton3.Text = "darkButton1";
        	// 
        	// DarkOpenFileDialog
        	// 
        	this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        	this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        	this.ClientSize = new System.Drawing.Size(584, 402);
        	this.Controls.Add(this.darkButton3);
        	this.Controls.Add(this.darkButton2);
        	this.Controls.Add(this.darkButton1);
        	this.Controls.Add(this.btnRed);
        	this.Controls.Add(this.listView1);
        	this.Controls.Add(this.btnEsteEquipo);
        	this.Controls.Add(this.btnBibliotecas);
        	this.Controls.Add(this.btnEscritorio);
        	this.Controls.Add(this.btnAccesoRapido);
        	this.Controls.Add(this.lblBuscarEn);
        	this.Controls.Add(this.pnlFooter);
        	this.Name = "DarkOpenFileDialog";
        	this.Text = "Abrir";
        	this.pnlFooter.ResumeLayout(false);
        	this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlFooter;
        private DarkUI.Controls.DarkLabel lblBuscarEn;
        private DarkUI.Controls.DarkButton btnAccesoRapido;
        private DarkUI.Controls.DarkButton btnBibliotecas;
        private DarkUI.Controls.DarkButton btnEsteEquipo;
        private DarkUI.Controls.DarkButton btnRed;
        private DarkUI.Controls.DarkButton btnEscritorio;
        private System.Windows.Forms.ListView listView1;
        private DarkUI.Controls.DarkLabel lblNombreDelArchivo;
        private System.Windows.Forms.ColumnHeader colNombre;
        private System.Windows.Forms.ColumnHeader colFechaModificacion;
        private System.Windows.Forms.ColumnHeader colTamano;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private DarkUI.Controls.DarkLabel lblTipoDeArchivo;
        private DarkUI.Controls.DarkButton darkButton1;
        private DarkUI.Controls.DarkButton darkButton2;
        private DarkUI.Controls.DarkButton darkButton3;
    }
}