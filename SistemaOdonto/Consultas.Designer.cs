namespace SistemaOdonto
{
    partial class Consultas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Consultas));
            this.tabControlAgenda = new System.Windows.Forms.TabControl();
            this.HomeAgenda = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpDataMostrada = new System.Windows.Forms.DateTimePicker();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnAvancar = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.tabControlAgenda.SuspendLayout();
            this.HomeAgenda.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlAgenda
            // 
            this.tabControlAgenda.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.tabControlAgenda.Controls.Add(this.HomeAgenda);
            this.tabControlAgenda.Location = new System.Drawing.Point(-3, 42);
            this.tabControlAgenda.Multiline = true;
            this.tabControlAgenda.Name = "tabControlAgenda";
            this.tabControlAgenda.SelectedIndex = 0;
            this.tabControlAgenda.Size = new System.Drawing.Size(577, 497);
            this.tabControlAgenda.TabIndex = 0;
            this.tabControlAgenda.Selecting += new System.Windows.Forms.TabControlCancelEventHandler(this.tabControlAgenda_Selecting);
            // 
            // HomeAgenda
            // 
            this.HomeAgenda.BackColor = System.Drawing.Color.White;
            this.HomeAgenda.Controls.Add(this.label2);
            this.HomeAgenda.Controls.Add(this.label1);
            this.HomeAgenda.Location = new System.Drawing.Point(23, 4);
            this.HomeAgenda.Name = "HomeAgenda";
            this.HomeAgenda.Padding = new System.Windows.Forms.Padding(3);
            this.HomeAgenda.Size = new System.Drawing.Size(550, 489);
            this.HomeAgenda.TabIndex = 0;
            this.HomeAgenda.Text = "Inicio";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label2.Location = new System.Drawing.Point(21, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(518, 52);
            this.label2.TabIndex = 1;
            this.label2.Text = resources.GetString("label2.Text");
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(225, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Esta é a Agenda das Consultas";
            // 
            // dtpDataMostrada
            // 
            this.dtpDataMostrada.Location = new System.Drawing.Point(216, 12);
            this.dtpDataMostrada.Name = "dtpDataMostrada";
            this.dtpDataMostrada.Size = new System.Drawing.Size(227, 20);
            this.dtpDataMostrada.TabIndex = 40;
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.SystemColors.Desktop;
            this.btnBuscar.ForeColor = System.Drawing.SystemColors.Control;
            this.btnBuscar.Location = new System.Drawing.Point(449, 9);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 27);
            this.btnBuscar.TabIndex = 41;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            // 
            // btnAvancar
            // 
            this.btnAvancar.BackgroundImage = global::SistemaOdonto.Properties.Resources.next;
            this.btnAvancar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAvancar.Location = new System.Drawing.Point(590, 66);
            this.btnAvancar.Name = "btnAvancar";
            this.btnAvancar.Size = new System.Drawing.Size(44, 46);
            this.btnAvancar.TabIndex = 42;
            this.btnAvancar.UseVisualStyleBackColor = true;
            // 
            // btnVoltar
            // 
            this.btnVoltar.BackgroundImage = global::SistemaOdonto.Properties.Resources.previous;
            this.btnVoltar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnVoltar.Location = new System.Drawing.Point(590, 118);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(44, 46);
            this.btnVoltar.TabIndex = 43;
            this.btnVoltar.UseVisualStyleBackColor = true;
            // 
            // Consultas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.ClientSize = new System.Drawing.Size(665, 570);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnAvancar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.dtpDataMostrada);
            this.Controls.Add(this.tabControlAgenda);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Consultas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agenda de Consultas";
            this.tabControlAgenda.ResumeLayout(false);
            this.HomeAgenda.ResumeLayout(false);
            this.HomeAgenda.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabPage HomeAgenda;
        private System.Windows.Forms.DateTimePicker dtpDataMostrada;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAvancar;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.TabControl tabControlAgenda;
        private System.Windows.Forms.Label label2;
    }
}