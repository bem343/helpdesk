namespace helpDesk
{
    partial class frmFormatacao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFormatacao));
            this.rtbEntrada = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnFormatacao = new System.Windows.Forms.Button();
            this.btnEspacos = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rtbSaida = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblBruto = new System.Windows.Forms.Label();
            this.lblLiquido = new System.Windows.Forms.Label();
            this.btnMaiusculo = new System.Windows.Forms.Button();
            this.btnMinusculo = new System.Windows.Forms.Button();
            this.btnAscento = new System.Windows.Forms.Button();
            this.btnAspas = new System.Windows.Forms.Button();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.aplicarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsFormatacao = new System.Windows.Forms.ToolStripMenuItem();
            this.tsEspacos = new System.Windows.Forms.ToolStripMenuItem();
            this.tsAscentos = new System.Windows.Forms.ToolStripMenuItem();
            this.tsMinusculo = new System.Windows.Forms.ToolStripMenuItem();
            this.tsMaiusculo = new System.Windows.Forms.ToolStripMenuItem();
            this.tsAspas = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsFonte = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // rtbEntrada
            // 
            this.rtbEntrada.BackColor = System.Drawing.Color.Black;
            this.rtbEntrada.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbEntrada.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbEntrada.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbEntrada.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(200)))), ((int)(((byte)(0)))));
            this.rtbEntrada.Location = new System.Drawing.Point(3, 15);
            this.rtbEntrada.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.rtbEntrada.Name = "rtbEntrada";
            this.rtbEntrada.Size = new System.Drawing.Size(536, 213);
            this.rtbEntrada.TabIndex = 0;
            this.rtbEntrada.Text = "";
            this.rtbEntrada.TextChanged += new System.EventHandler(this.rtbEntrada_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("5Computers In Love", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(200)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(12, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(289, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "Texto de entrada:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rtbEntrada);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 69);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.groupBox1.Size = new System.Drawing.Size(542, 231);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // btnFormatacao
            // 
            this.btnFormatacao.BackColor = System.Drawing.Color.Black;
            this.btnFormatacao.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnFormatacao.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro;
            this.btnFormatacao.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnFormatacao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFormatacao.Font = new System.Drawing.Font("5Computers In Love", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFormatacao.ForeColor = System.Drawing.Color.White;
            this.btnFormatacao.Location = new System.Drawing.Point(46, 337);
            this.btnFormatacao.Name = "btnFormatacao";
            this.btnFormatacao.Size = new System.Drawing.Size(145, 49);
            this.btnFormatacao.TabIndex = 1;
            this.btnFormatacao.Text = "Tirar formatacao";
            this.btnFormatacao.UseVisualStyleBackColor = false;
            this.btnFormatacao.Click += new System.EventHandler(this.btnFormatacao_Click);
            // 
            // btnEspacos
            // 
            this.btnEspacos.BackColor = System.Drawing.Color.Black;
            this.btnEspacos.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnEspacos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro;
            this.btnEspacos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnEspacos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEspacos.Font = new System.Drawing.Font("5Computers In Love", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEspacos.ForeColor = System.Drawing.Color.White;
            this.btnEspacos.Location = new System.Drawing.Point(209, 337);
            this.btnEspacos.Name = "btnEspacos";
            this.btnEspacos.Size = new System.Drawing.Size(145, 49);
            this.btnEspacos.TabIndex = 2;
            this.btnEspacos.Text = "Tirar espacos";
            this.btnEspacos.UseVisualStyleBackColor = false;
            this.btnEspacos.Click += new System.EventHandler(this.btnEspacos_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("5Computers In Love", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(200)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(12, 475);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(255, 26);
            this.label2.TabIndex = 5;
            this.label2.Text = "Texto de saida:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rtbSaida);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 504);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.groupBox2.Size = new System.Drawing.Size(542, 231);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            // 
            // rtbSaida
            // 
            this.rtbSaida.BackColor = System.Drawing.Color.Black;
            this.rtbSaida.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbSaida.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbSaida.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbSaida.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(200)))), ((int)(((byte)(0)))));
            this.rtbSaida.Location = new System.Drawing.Point(3, 15);
            this.rtbSaida.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.rtbSaida.Name = "rtbSaida";
            this.rtbSaida.Size = new System.Drawing.Size(536, 213);
            this.rtbSaida.TabIndex = 3;
            this.rtbSaida.Text = "";
            this.rtbSaida.TextChanged += new System.EventHandler(this.rtbSaida_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("5Computers In Love", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(200)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(9, 303);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 18);
            this.label3.TabIndex = 6;
            this.label3.Text = "C.Entrada:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("5Computers In Love", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(200)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(188, 303);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 18);
            this.label4.TabIndex = 7;
            this.label4.Text = "C.Saida:";
            // 
            // lblBruto
            // 
            this.lblBruto.AutoSize = true;
            this.lblBruto.Font = new System.Drawing.Font("5Computers In Love", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBruto.ForeColor = System.Drawing.Color.White;
            this.lblBruto.Location = new System.Drawing.Point(120, 303);
            this.lblBruto.Name = "lblBruto";
            this.lblBruto.Size = new System.Drawing.Size(19, 18);
            this.lblBruto.TabIndex = 8;
            this.lblBruto.Text = "0";
            // 
            // lblLiquido
            // 
            this.lblLiquido.AutoSize = true;
            this.lblLiquido.Font = new System.Drawing.Font("5Computers In Love", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLiquido.ForeColor = System.Drawing.Color.White;
            this.lblLiquido.Location = new System.Drawing.Point(277, 303);
            this.lblLiquido.Name = "lblLiquido";
            this.lblLiquido.Size = new System.Drawing.Size(19, 18);
            this.lblLiquido.TabIndex = 9;
            this.lblLiquido.Text = "0";
            // 
            // btnMaiusculo
            // 
            this.btnMaiusculo.BackColor = System.Drawing.Color.Black;
            this.btnMaiusculo.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnMaiusculo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro;
            this.btnMaiusculo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnMaiusculo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaiusculo.Font = new System.Drawing.Font("5Computers In Love", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMaiusculo.ForeColor = System.Drawing.Color.White;
            this.btnMaiusculo.Location = new System.Drawing.Point(209, 405);
            this.btnMaiusculo.Name = "btnMaiusculo";
            this.btnMaiusculo.Size = new System.Drawing.Size(145, 49);
            this.btnMaiusculo.TabIndex = 11;
            this.btnMaiusculo.Text = "Colocar em maiusculo";
            this.btnMaiusculo.UseVisualStyleBackColor = false;
            this.btnMaiusculo.Click += new System.EventHandler(this.btnMaiusculo_Click);
            // 
            // btnMinusculo
            // 
            this.btnMinusculo.BackColor = System.Drawing.Color.Black;
            this.btnMinusculo.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnMinusculo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro;
            this.btnMinusculo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnMinusculo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinusculo.Font = new System.Drawing.Font("5Computers In Love", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinusculo.ForeColor = System.Drawing.Color.White;
            this.btnMinusculo.Location = new System.Drawing.Point(46, 405);
            this.btnMinusculo.Name = "btnMinusculo";
            this.btnMinusculo.Size = new System.Drawing.Size(145, 49);
            this.btnMinusculo.TabIndex = 10;
            this.btnMinusculo.Text = "Colocar em minusculo";
            this.btnMinusculo.UseVisualStyleBackColor = false;
            this.btnMinusculo.Click += new System.EventHandler(this.btnMinusculo_Click);
            // 
            // btnAscento
            // 
            this.btnAscento.BackColor = System.Drawing.Color.Black;
            this.btnAscento.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnAscento.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro;
            this.btnAscento.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnAscento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAscento.Font = new System.Drawing.Font("5Computers In Love", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAscento.ForeColor = System.Drawing.Color.White;
            this.btnAscento.Location = new System.Drawing.Point(369, 337);
            this.btnAscento.Name = "btnAscento";
            this.btnAscento.Size = new System.Drawing.Size(145, 49);
            this.btnAscento.TabIndex = 12;
            this.btnAscento.Text = "Tirar ascentos";
            this.btnAscento.UseVisualStyleBackColor = false;
            this.btnAscento.Click += new System.EventHandler(this.btnAscento_Click);
            // 
            // btnAspas
            // 
            this.btnAspas.BackColor = System.Drawing.Color.Black;
            this.btnAspas.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnAspas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro;
            this.btnAspas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnAspas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAspas.Font = new System.Drawing.Font("5Computers In Love", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAspas.ForeColor = System.Drawing.Color.White;
            this.btnAspas.Location = new System.Drawing.Point(369, 405);
            this.btnAspas.Name = "btnAspas";
            this.btnAspas.Size = new System.Drawing.Size(145, 49);
            this.btnAspas.TabIndex = 13;
            this.btnAspas.Text = "Trocar aspas";
            this.btnAspas.UseVisualStyleBackColor = false;
            this.btnAspas.Click += new System.EventHandler(this.btnAspas_Click);
            // 
            // menuStrip
            // 
            this.menuStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.menuStrip.Font = new System.Drawing.Font("5Computers In Love", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aplicarToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(566, 25);
            this.menuStrip.TabIndex = 14;
            this.menuStrip.Text = "menuStrip1";
            // 
            // aplicarToolStripMenuItem
            // 
            this.aplicarToolStripMenuItem.BackColor = System.Drawing.Color.Transparent;
            this.aplicarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsFormatacao,
            this.tsEspacos,
            this.tsAscentos,
            this.toolStripMenuItem1,
            this.tsMinusculo,
            this.tsMaiusculo,
            this.tsAspas,
            this.tsFonte});
            this.aplicarToolStripMenuItem.ForeColor = System.Drawing.Color.DarkGray;
            this.aplicarToolStripMenuItem.Name = "aplicarToolStripMenuItem";
            this.aplicarToolStripMenuItem.Size = new System.Drawing.Size(90, 21);
            this.aplicarToolStripMenuItem.Text = "Aplicar";
            this.aplicarToolStripMenuItem.MouseEnter += new System.EventHandler(this.aplicarToolStripMenuItem_MouseEnter);
            this.aplicarToolStripMenuItem.MouseLeave += new System.EventHandler(this.aplicarToolStripMenuItem_MouseLeave);
            // 
            // tsFormatacao
            // 
            this.tsFormatacao.Name = "tsFormatacao";
            this.tsFormatacao.Size = new System.Drawing.Size(276, 22);
            this.tsFormatacao.Text = "Tirar formatacao";
            this.tsFormatacao.Click += new System.EventHandler(this.btnFormatacao_Click);
            this.tsFormatacao.MouseEnter += new System.EventHandler(this.tsFormatacao_MouseEnter);
            this.tsFormatacao.MouseLeave += new System.EventHandler(this.tsFormatacao_MouseLeave);
            // 
            // tsEspacos
            // 
            this.tsEspacos.Name = "tsEspacos";
            this.tsEspacos.Size = new System.Drawing.Size(276, 22);
            this.tsEspacos.Text = "Tirar espacos";
            this.tsEspacos.Click += new System.EventHandler(this.btnEspacos_Click);
            this.tsEspacos.MouseEnter += new System.EventHandler(this.tsEspacos_MouseEnter);
            this.tsEspacos.MouseLeave += new System.EventHandler(this.tsEspacos_MouseLeave);
            // 
            // tsAscentos
            // 
            this.tsAscentos.Name = "tsAscentos";
            this.tsAscentos.Size = new System.Drawing.Size(276, 22);
            this.tsAscentos.Text = "Tirar ascentos";
            this.tsAscentos.Click += new System.EventHandler(this.btnAscento_Click);
            this.tsAscentos.MouseEnter += new System.EventHandler(this.tsAscentos_MouseEnter);
            this.tsAscentos.MouseLeave += new System.EventHandler(this.tsAscentos_MouseLeave);
            // 
            // tsMinusculo
            // 
            this.tsMinusculo.Name = "tsMinusculo";
            this.tsMinusculo.Size = new System.Drawing.Size(276, 22);
            this.tsMinusculo.Text = "Colocar em minusculo";
            this.tsMinusculo.Click += new System.EventHandler(this.btnMinusculo_Click);
            this.tsMinusculo.MouseEnter += new System.EventHandler(this.tsMinusculo_MouseEnter);
            this.tsMinusculo.MouseLeave += new System.EventHandler(this.tsMinusculo_MouseLeave);
            // 
            // tsMaiusculo
            // 
            this.tsMaiusculo.Name = "tsMaiusculo";
            this.tsMaiusculo.Size = new System.Drawing.Size(276, 22);
            this.tsMaiusculo.Text = "Colocar em maiusculo";
            this.tsMaiusculo.Click += new System.EventHandler(this.btnMaiusculo_Click);
            this.tsMaiusculo.MouseEnter += new System.EventHandler(this.tsMaiusculo_MouseEnter);
            this.tsMaiusculo.MouseLeave += new System.EventHandler(this.tsMaiusculo_MouseLeave);
            // 
            // tsAspas
            // 
            this.tsAspas.Name = "tsAspas";
            this.tsAspas.Size = new System.Drawing.Size(276, 22);
            this.tsAspas.Text = "Trocar aspas";
            this.tsAspas.Click += new System.EventHandler(this.btnAspas_Click);
            this.tsAspas.MouseEnter += new System.EventHandler(this.tsAspas_MouseEnter);
            this.tsAspas.MouseLeave += new System.EventHandler(this.tsAspas_MouseLeave);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(273, 6);
            // 
            // tsFonte
            // 
            this.tsFonte.Name = "tsFonte";
            this.tsFonte.Size = new System.Drawing.Size(276, 22);
            this.tsFonte.Text = "Fonte sem ascentos";
            this.tsFonte.Click += new System.EventHandler(this.tsFonte_Click);
            this.tsFonte.MouseEnter += new System.EventHandler(this.tsFonte_MouseEnter);
            this.tsFonte.MouseLeave += new System.EventHandler(this.tsFonte_MouseLeave);
            // 
            // frmFormatacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(566, 747);
            this.Controls.Add(this.btnAspas);
            this.Controls.Add(this.btnAscento);
            this.Controls.Add(this.btnMaiusculo);
            this.Controls.Add(this.btnMinusculo);
            this.Controls.Add(this.lblLiquido);
            this.Controls.Add(this.lblBruto);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnEspacos);
            this.Controls.Add(this.btnFormatacao);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip;
            this.MaximizeBox = false;
            this.Name = "frmFormatacao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Help Desk";
            this.Load += new System.EventHandler(this.frmFormatacao_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbEntrada;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnFormatacao;
        private System.Windows.Forms.Button btnEspacos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RichTextBox rtbSaida;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblBruto;
        private System.Windows.Forms.Label lblLiquido;
        private System.Windows.Forms.Button btnMaiusculo;
        private System.Windows.Forms.Button btnMinusculo;
        private System.Windows.Forms.Button btnAscento;
        private System.Windows.Forms.Button btnAspas;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem aplicarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsFormatacao;
        private System.Windows.Forms.ToolStripMenuItem tsEspacos;
        private System.Windows.Forms.ToolStripMenuItem tsAscentos;
        private System.Windows.Forms.ToolStripMenuItem tsMinusculo;
        private System.Windows.Forms.ToolStripMenuItem tsMaiusculo;
        private System.Windows.Forms.ToolStripMenuItem tsAspas;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem tsFonte;
    }
}

