namespace agenda_compromissos
{
	partial class inserirEditar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(inserirEditar));
            this.lbl_compromisso = new System.Windows.Forms.Label();
            this.textCompromisso = new System.Windows.Forms.TextBox();
            this.text_Horario = new System.Windows.Forms.TextBox();
            this.lbl_horario = new System.Windows.Forms.Label();
            this.textDia = new System.Windows.Forms.TextBox();
            this.lbl_diaSemana = new System.Windows.Forms.Label();
            this.textDuracao = new System.Windows.Forms.TextBox();
            this.lbl_duracao = new System.Windows.Forms.Label();
            this.btn_inserir = new System.Windows.Forms.Button();
            this.btn_fechar = new System.Windows.Forms.Button();
            this.listBoxCompromissos = new System.Windows.Forms.ListBox();
            this.lbl = new System.Windows.Forms.Label();
            this.lbl_numRegistro = new System.Windows.Forms.Label();
            this.btn_apagar = new System.Windows.Forms.Button();
            this.btn_editar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_compromisso
            // 
            this.lbl_compromisso.AutoSize = true;
            this.lbl_compromisso.Location = new System.Drawing.Point(16, 20);
            this.lbl_compromisso.Name = "lbl_compromisso";
            this.lbl_compromisso.Size = new System.Drawing.Size(73, 15);
            this.lbl_compromisso.TabIndex = 5;
            this.lbl_compromisso.Text = "compromisso";
            // 
            // textCompromisso
            // 
            this.textCompromisso.Location = new System.Drawing.Point(120, 16);
            this.textCompromisso.Name = "textCompromisso";
            this.textCompromisso.Size = new System.Drawing.Size(283, 23);
            this.textCompromisso.TabIndex = 0;
            // 
            // text_Horario
            // 
            this.text_Horario.Location = new System.Drawing.Point(120, 46);
            this.text_Horario.Name = "text_Horario";
            this.text_Horario.Size = new System.Drawing.Size(283, 23);
            this.text_Horario.TabIndex = 1;
            // 
            // lbl_horario
            // 
            this.lbl_horario.AutoSize = true;
            this.lbl_horario.Location = new System.Drawing.Point(42, 50);
            this.lbl_horario.Name = "lbl_horario";
            this.lbl_horario.Size = new System.Drawing.Size(44, 15);
            this.lbl_horario.TabIndex = 6;
            this.lbl_horario.Text = "horario";
            // 
            // textDia
            // 
            this.textDia.Location = new System.Drawing.Point(120, 78);
            this.textDia.Name = "textDia";
            this.textDia.Size = new System.Drawing.Size(283, 23);
            this.textDia.TabIndex = 2;
            // 
            // lbl_diaSemana
            // 
            this.lbl_diaSemana.AutoSize = true;
            this.lbl_diaSemana.Location = new System.Drawing.Point(16, 82);
            this.lbl_diaSemana.Name = "lbl_diaSemana";
            this.lbl_diaSemana.Size = new System.Drawing.Size(65, 15);
            this.lbl_diaSemana.TabIndex = 7;
            this.lbl_diaSemana.Text = "dia semana";
            // 
            // textDuracao
            // 
            this.textDuracao.Location = new System.Drawing.Point(120, 108);
            this.textDuracao.Name = "textDuracao";
            this.textDuracao.Size = new System.Drawing.Size(283, 23);
            this.textDuracao.TabIndex = 3;
            this.textDuracao.TextChanged += new System.EventHandler(this.textDuracao_TextChanged);
            // 
            // lbl_duracao
            // 
            this.lbl_duracao.AutoSize = true;
            this.lbl_duracao.Location = new System.Drawing.Point(41, 112);
            this.lbl_duracao.Name = "lbl_duracao";
            this.lbl_duracao.Size = new System.Drawing.Size(42, 15);
            this.lbl_duracao.TabIndex = 8;
            this.lbl_duracao.Text = "durção";
            // 
            // btn_inserir
            // 
            this.btn_inserir.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btn_inserir.Location = new System.Drawing.Point(20, 149);
            this.btn_inserir.Name = "btn_inserir";
            this.btn_inserir.Size = new System.Drawing.Size(87, 27);
            this.btn_inserir.TabIndex = 4;
            this.btn_inserir.Text = "inserir";
            this.btn_inserir.UseVisualStyleBackColor = false;
            this.btn_inserir.Click += new System.EventHandler(this.btn_inserir_Click);
            // 
            // btn_fechar
            // 
            this.btn_fechar.BackColor = System.Drawing.Color.Teal;
            this.btn_fechar.Location = new System.Drawing.Point(502, 302);
            this.btn_fechar.Name = "btn_fechar";
            this.btn_fechar.Size = new System.Drawing.Size(87, 27);
            this.btn_fechar.TabIndex = 12;
            this.btn_fechar.Text = "fechar";
            this.btn_fechar.UseVisualStyleBackColor = false;
            this.btn_fechar.Click += new System.EventHandler(this.btn_fechar_Click);
            // 
            // listBoxCompromissos
            // 
            this.listBoxCompromissos.BackColor = System.Drawing.SystemColors.MenuText;
            this.listBoxCompromissos.Font = new System.Drawing.Font("Gabriola", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxCompromissos.ForeColor = System.Drawing.SystemColors.Window;
            this.listBoxCompromissos.FormattingEnabled = true;
            this.listBoxCompromissos.ItemHeight = 29;
            this.listBoxCompromissos.Location = new System.Drawing.Point(114, 171);
            this.listBoxCompromissos.Name = "listBoxCompromissos";
            this.listBoxCompromissos.Size = new System.Drawing.Size(474, 91);
            this.listBoxCompromissos.TabIndex = 13;
            this.listBoxCompromissos.SelectedIndexChanged += new System.EventHandler(this.listBoxCompromissos_SelectedIndexChanged);
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Location = new System.Drawing.Point(131, 149);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(125, 15);
            this.lbl.TabIndex = 14;
            this.lbl.Text = "Lista de compromissos";
            // 
            // lbl_numRegistro
            // 
            this.lbl_numRegistro.AutoSize = true;
            this.lbl_numRegistro.Location = new System.Drawing.Point(111, 284);
            this.lbl_numRegistro.Name = "lbl_numRegistro";
            this.lbl_numRegistro.Size = new System.Drawing.Size(65, 15);
            this.lbl_numRegistro.TabIndex = 10;
            this.lbl_numRegistro.Text = "registro: 0";
            // 
            // btn_apagar
            // 
            this.btn_apagar.BackColor = System.Drawing.Color.DarkCyan;
            this.btn_apagar.Location = new System.Drawing.Point(114, 302);
            this.btn_apagar.Name = "btn_apagar";
            this.btn_apagar.Size = new System.Drawing.Size(87, 27);
            this.btn_apagar.TabIndex = 11;
            this.btn_apagar.Text = "apagar";
            this.btn_apagar.UseVisualStyleBackColor = false;
            this.btn_apagar.Click += new System.EventHandler(this.btn_apagar_Click);
            // 
            // btn_editar
            // 
            this.btn_editar.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btn_editar.Location = new System.Drawing.Point(20, 197);
            this.btn_editar.Name = "btn_editar";
            this.btn_editar.Size = new System.Drawing.Size(87, 27);
            this.btn_editar.TabIndex = 9;
            this.btn_editar.Text = "editar";
            this.btn_editar.UseVisualStyleBackColor = false;
            this.btn_editar.Click += new System.EventHandler(this.btn_editar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(429, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 15);
            this.label1.TabIndex = 15;
            this.label1.Text = "Lista de compromissos";
            // 
            // inserirEditar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(603, 338);
            this.ControlBox = false;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_editar);
            this.Controls.Add(this.btn_apagar);
            this.Controls.Add(this.lbl_numRegistro);
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.listBoxCompromissos);
            this.Controls.Add(this.btn_fechar);
            this.Controls.Add(this.btn_inserir);
            this.Controls.Add(this.textDuracao);
            this.Controls.Add(this.lbl_duracao);
            this.Controls.Add(this.textDia);
            this.Controls.Add(this.lbl_diaSemana);
            this.Controls.Add(this.text_Horario);
            this.Controls.Add(this.lbl_horario);
            this.Controls.Add(this.textCompromisso);
            this.Controls.Add(this.lbl_compromisso);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "inserirEditar";
            this.Text = "inserirEditar";
            this.Load += new System.EventHandler(this.inserirEditar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lbl_compromisso;
		private System.Windows.Forms.TextBox textCompromisso;
		private System.Windows.Forms.TextBox text_Horario;
		private System.Windows.Forms.Label lbl_horario;
		private System.Windows.Forms.TextBox textDia;
		private System.Windows.Forms.Label lbl_diaSemana;
		private System.Windows.Forms.TextBox textDuracao;
		private System.Windows.Forms.Label lbl_duracao;
		private System.Windows.Forms.Button btn_inserir;
		private System.Windows.Forms.Button btn_fechar;
		private System.Windows.Forms.ListBox listBoxCompromissos;
		private System.Windows.Forms.Label lbl;
		private System.Windows.Forms.Label lbl_numRegistro;
		private System.Windows.Forms.Button btn_apagar;
		private System.Windows.Forms.Button btn_editar;
        private System.Windows.Forms.Label label1;
    }
}