namespace Examen_Unidad_I
{
    partial class FormaLog
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
            this.dgLog = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.comboNombre = new System.Windows.Forms.ComboBox();
            this.comboBuscar = new System.Windows.Forms.ComboBox();
            this.comboArma = new System.Windows.Forms.ComboBox();
            this.comboMovimiento = new System.Windows.Forms.ComboBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.comboHora = new System.Windows.Forms.ComboBox();
            this.btnExportar = new System.Windows.Forms.Button();
            this.btnHistorial = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgLog)).BeginInit();
            this.SuspendLayout();
            // 
            // dgLog
            // 
            this.dgLog.AllowUserToAddRows = false;
            this.dgLog.AllowUserToDeleteRows = false;
            this.dgLog.AllowUserToOrderColumns = true;
            this.dgLog.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgLog.BackgroundColor = System.Drawing.Color.Azure;
            this.dgLog.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgLog.Location = new System.Drawing.Point(60, 155);
            this.dgLog.Name = "dgLog";
            this.dgLog.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgLog.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.dgLog.Size = new System.Drawing.Size(538, 292);
            this.dgLog.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(223, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Historial de Acciones";
            // 
            // comboNombre
            // 
            this.comboNombre.Enabled = false;
            this.comboNombre.FormattingEnabled = true;
            this.comboNombre.Items.AddRange(new object[] {
            "Rey",
            "Arquero",
            "Ogro",
            "Caballero"});
            this.comboNombre.Location = new System.Drawing.Point(279, 118);
            this.comboNombre.Name = "comboNombre";
            this.comboNombre.Size = new System.Drawing.Size(126, 27);
            this.comboNombre.TabIndex = 2;
            // 
            // comboBuscar
            // 
            this.comboBuscar.FormattingEnabled = true;
            this.comboBuscar.Items.AddRange(new object[] {
            "Nombre",
            "Arma",
            "Movimiento",
            "Hora"});
            this.comboBuscar.Location = new System.Drawing.Point(146, 118);
            this.comboBuscar.Name = "comboBuscar";
            this.comboBuscar.Size = new System.Drawing.Size(126, 27);
            this.comboBuscar.TabIndex = 3;
            this.comboBuscar.SelectedIndexChanged += new System.EventHandler(this.comboBuscar_SelectedIndexChanged);
            // 
            // comboArma
            // 
            this.comboArma.AutoCompleteCustomSource.AddRange(new string[] {
            "Espada",
            "Arco y Flecha",
            "Hacha",
            "Lanza"});
            this.comboArma.Enabled = false;
            this.comboArma.FormattingEnabled = true;
            this.comboArma.Items.AddRange(new object[] {
            "Espada",
            "Arco y Flecha",
            "Hacha",
            "Lanza"});
            this.comboArma.Location = new System.Drawing.Point(279, 118);
            this.comboArma.Name = "comboArma";
            this.comboArma.Size = new System.Drawing.Size(126, 27);
            this.comboArma.TabIndex = 4;
            // 
            // comboMovimiento
            // 
            this.comboMovimiento.AutoCompleteCustomSource.AddRange(new string[] {
            "Atacar",
            "Avanzar",
            "Curar",
            "Defender"});
            this.comboMovimiento.Enabled = false;
            this.comboMovimiento.FormattingEnabled = true;
            this.comboMovimiento.Items.AddRange(new object[] {
            "Atacar",
            "Avanzar",
            "Curar",
            "Defender"});
            this.comboMovimiento.Location = new System.Drawing.Point(279, 118);
            this.comboMovimiento.Name = "comboMovimiento";
            this.comboMovimiento.Size = new System.Drawing.Size(126, 27);
            this.comboMovimiento.TabIndex = 5;
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.MintCream;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Location = new System.Drawing.Point(418, 116);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 29);
            this.btnBuscar.TabIndex = 6;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 19);
            this.label2.TabIndex = 7;
            this.label2.Text = "Buscar por:";
            // 
            // comboHora
            // 
            this.comboHora.Enabled = false;
            this.comboHora.FormattingEnabled = true;
            this.comboHora.Items.AddRange(new object[] {
            "00",
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23"});
            this.comboHora.Location = new System.Drawing.Point(279, 118);
            this.comboHora.Name = "comboHora";
            this.comboHora.Size = new System.Drawing.Size(126, 27);
            this.comboHora.TabIndex = 8;
            // 
            // btnExportar
            // 
            this.btnExportar.BackColor = System.Drawing.Color.MintCream;
            this.btnExportar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExportar.Location = new System.Drawing.Point(504, 453);
            this.btnExportar.Name = "btnExportar";
            this.btnExportar.Size = new System.Drawing.Size(93, 29);
            this.btnExportar.TabIndex = 9;
            this.btnExportar.Text = "Exportar";
            this.btnExportar.UseVisualStyleBackColor = false;
            this.btnExportar.Click += new System.EventHandler(this.btnExportar_Click);
            // 
            // btnHistorial
            // 
            this.btnHistorial.BackColor = System.Drawing.Color.MintCream;
            this.btnHistorial.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHistorial.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHistorial.Location = new System.Drawing.Point(489, 24);
            this.btnHistorial.Name = "btnHistorial";
            this.btnHistorial.Size = new System.Drawing.Size(109, 48);
            this.btnHistorial.TabIndex = 10;
            this.btnHistorial.Text = "Mostrar historial completo";
            this.btnHistorial.UseVisualStyleBackColor = false;
            this.btnHistorial.Click += new System.EventHandler(this.btnHistorial_Click);
            // 
            // FormaLog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(657, 491);
            this.Controls.Add(this.btnHistorial);
            this.Controls.Add(this.btnExportar);
            this.Controls.Add(this.comboHora);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.comboMovimiento);
            this.Controls.Add(this.comboArma);
            this.Controls.Add(this.comboBuscar);
            this.Controls.Add(this.comboNombre);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgLog);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormaLog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Log";
            ((System.ComponentModel.ISupportInitialize)(this.dgLog)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgLog;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboNombre;
        private System.Windows.Forms.ComboBox comboBuscar;
        private System.Windows.Forms.ComboBox comboArma;
        private System.Windows.Forms.ComboBox comboMovimiento;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboHora;
        private System.Windows.Forms.Button btnExportar;
        private System.Windows.Forms.Button btnHistorial;
    }
}