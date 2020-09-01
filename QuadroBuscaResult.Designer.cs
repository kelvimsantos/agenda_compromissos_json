namespace agenda_compromissos
{
    partial class QuadroBuscaResult
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
            this.btn_fechar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_novapesq = new System.Windows.Forms.Button();
            this.listBoxResult = new System.Windows.Forms.ListBox();
            this.lbl_registro = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_fechar
            // 
            this.btn_fechar.Location = new System.Drawing.Point(264, 168);
            this.btn_fechar.Name = "btn_fechar";
            this.btn_fechar.Size = new System.Drawing.Size(105, 23);
            this.btn_fechar.TabIndex = 0;
            this.btn_fechar.Text = "FECHAR";
            this.btn_fechar.UseVisualStyleBackColor = true;
            this.btn_fechar.Click += new System.EventHandler(this.btn_fechar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "resultados";
            // 
            // btn_novapesq
            // 
            this.btn_novapesq.Location = new System.Drawing.Point(12, 168);
            this.btn_novapesq.Name = "btn_novapesq";
            this.btn_novapesq.Size = new System.Drawing.Size(137, 23);
            this.btn_novapesq.TabIndex = 0;
            this.btn_novapesq.Text = "NOVA PESQUISA";
            this.btn_novapesq.UseVisualStyleBackColor = true;
            this.btn_novapesq.Click += new System.EventHandler(this.btn_novapesq_Click);
            // 
            // listBoxResult
            // 
            this.listBoxResult.FormattingEnabled = true;
            this.listBoxResult.Location = new System.Drawing.Point(14, 40);
            this.listBoxResult.Name = "listBoxResult";
            this.listBoxResult.Size = new System.Drawing.Size(355, 108);
            this.listBoxResult.TabIndex = 2;
            // 
            // lbl_registro
            // 
            this.lbl_registro.AutoSize = true;
            this.lbl_registro.Location = new System.Drawing.Point(12, 152);
            this.lbl_registro.Name = "lbl_registro";
            this.lbl_registro.Size = new System.Drawing.Size(58, 13);
            this.lbl_registro.TabIndex = 3;
            this.lbl_registro.Text = "registros :0";
            // 
            // QuadroBuscaResult
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(381, 216);
            this.ControlBox = false;
            this.Controls.Add(this.lbl_registro);
            this.Controls.Add(this.listBoxResult);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_novapesq);
            this.Controls.Add(this.btn_fechar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "QuadroBuscaResult";
            this.Text = "QuadroBuscaResult";
            this.Load += new System.EventHandler(this.QuadroBuscaResult_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_fechar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_novapesq;
        private System.Windows.Forms.ListBox listBoxResult;
        private System.Windows.Forms.Label lbl_registro;
    }
}