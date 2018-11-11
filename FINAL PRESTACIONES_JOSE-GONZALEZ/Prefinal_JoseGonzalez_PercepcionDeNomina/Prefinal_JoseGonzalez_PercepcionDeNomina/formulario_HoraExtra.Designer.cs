namespace Prefinal_JoseGonzalez_PercepcionDeNomina
{
    partial class formulario_HoraExtra
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
            this.txt_canthoras = new System.Windows.Forms.TextBox();
            this.txt_autoriza = new System.Windows.Forms.TextBox();
            this.txt_idCon = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_monto = new System.Windows.Forms.TextBox();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_canthoras
            // 
            this.txt_canthoras.Location = new System.Drawing.Point(96, 109);
            this.txt_canthoras.Name = "txt_canthoras";
            this.txt_canthoras.Size = new System.Drawing.Size(200, 20);
            this.txt_canthoras.TabIndex = 1;
            // 
            // txt_autoriza
            // 
            this.txt_autoriza.Location = new System.Drawing.Point(96, 157);
            this.txt_autoriza.Name = "txt_autoriza";
            this.txt_autoriza.Size = new System.Drawing.Size(200, 20);
            this.txt_autoriza.TabIndex = 2;
            // 
            // txt_idCon
            // 
            this.txt_idCon.Location = new System.Drawing.Point(96, 36);
            this.txt_idCon.Name = "txt_idCon";
            this.txt_idCon.Size = new System.Drawing.Size(200, 20);
            this.txt_idCon.TabIndex = 3;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(96, 72);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 4;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(320, 78);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(553, 150);
            this.dataGridView1.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Fecha Hora Extra";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(0, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Cantidad Horas ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Autoriza";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(2, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "No. Contrato";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(320, 29);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 12;
            this.button3.Text = "Mostrar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 209);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Monto";
            // 
            // txt_monto
            // 
            this.txt_monto.Location = new System.Drawing.Point(96, 202);
            this.txt_monto.Name = "txt_monto";
            this.txt_monto.Size = new System.Drawing.Size(200, 20);
            this.txt_monto.TabIndex = 14;
            // 
            // button6
            // 
            this.button6.Image = global::Prefinal_JoseGonzalez_PercepcionDeNomina.Properties.Resources.Ejecutar;
            this.button6.Location = new System.Drawing.Point(254, 234);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(104, 92);
            this.button6.TabIndex = 17;
            this.button6.Text = "Calculo Monetario";
            this.button6.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.Image = global::Prefinal_JoseGonzalez_PercepcionDeNomina.Properties.Resources.Borrar;
            this.button5.Location = new System.Drawing.Point(499, 2);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(167, 70);
            this.button5.TabIndex = 16;
            this.button5.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.Image = global::Prefinal_JoseGonzalez_PercepcionDeNomina.Properties.Resources.Agregar;
            this.button4.Location = new System.Drawing.Point(139, 234);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(109, 92);
            this.button4.TabIndex = 15;
            this.button4.Text = "Añadir Horas";
            this.button4.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button2
            // 
            this.button2.Image = global::Prefinal_JoseGonzalez_PercepcionDeNomina.Properties.Resources.Buscar;
            this.button2.Location = new System.Drawing.Point(401, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(92, 70);
            this.button2.TabIndex = 7;
            this.button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Image = global::Prefinal_JoseGonzalez_PercepcionDeNomina.Properties.Resources.Agregar;
            this.button1.Location = new System.Drawing.Point(15, 234);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 92);
            this.button1.TabIndex = 5;
            this.button1.Text = "Agregar Empleado";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // formulario_HoraExtra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(916, 338);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.txt_monto);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.txt_idCon);
            this.Controls.Add(this.txt_autoriza);
            this.Controls.Add(this.txt_canthoras);
            this.Name = "formulario_HoraExtra";
            this.Text = "Hora Extra";
            this.Load += new System.EventHandler(this.formulario_HoraExtra_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_canthoras;
        private System.Windows.Forms.TextBox txt_autoriza;
        private System.Windows.Forms.TextBox txt_idCon;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_monto;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
    }
}