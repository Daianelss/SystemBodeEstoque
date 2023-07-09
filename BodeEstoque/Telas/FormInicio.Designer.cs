namespace BodeEstoque
{
    partial class FormMenu
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
            this.btnBanca = new System.Windows.Forms.Button();
            this.PanCompleto = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuItemInicio = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemAcessoRapido = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemParametros = new System.Windows.Forms.ToolStripMenuItem();
            this.BtnPeroxido = new System.Windows.Forms.Button();
            this.btnFundicao = new System.Windows.Forms.Button();
            this.btnRodioBranco = new System.Windows.Forms.Button();
            this.btnMateriaPrima = new System.Windows.Forms.Button();
            this.btnRodioNegro = new System.Windows.Forms.Button();
            this.BtnPolitriz = new System.Windows.Forms.Button();
            this.btnPurificacao = new System.Windows.Forms.Button();
            this.btnRelatorio = new System.Windows.Forms.Button();
            this.btnHoraExtra = new System.Windows.Forms.Button();
            this.lblFundicao = new System.Windows.Forms.Label();
            this.lblBanca = new System.Windows.Forms.Label();
            this.lblPeroxido = new System.Windows.Forms.Label();
            this.lblPolitriz = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblQuebra = new System.Windows.Forms.Label();
            this.panBotões = new System.Windows.Forms.Panel();
            this.PanQuebras = new System.Windows.Forms.Panel();
            this.lblQuebraBanca = new System.Windows.Forms.Label();
            this.lblQuebraPeroxido = new System.Windows.Forms.Label();
            this.lblQuebraFundicao = new System.Windows.Forms.Label();
            this.lblQuebraPolitriz = new System.Windows.Forms.Label();
            this.lblQuebraTotal = new System.Windows.Forms.Label();
            this.panTotais = new System.Windows.Forms.Panel();
            this.lblMateriaPrimaEntrada = new System.Windows.Forms.Label();
            this.lblMateriaPrimaSaida = new System.Windows.Forms.Label();
            this.lblTotalRodio = new System.Windows.Forms.Label();
            this.lblQtdMateriaPrimaEntrada = new System.Windows.Forms.Label();
            this.lblQtdMateriaPrimaSaida = new System.Windows.Forms.Label();
            this.lblQtdRodio = new System.Windows.Forms.Label();
            this.PanCompleto.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.panBotões.SuspendLayout();
            this.PanQuebras.SuspendLayout();
            this.panTotais.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnBanca
            // 
            this.btnBanca.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.btnBanca.Location = new System.Drawing.Point(16, 41);
            this.btnBanca.Name = "btnBanca";
            this.btnBanca.Size = new System.Drawing.Size(212, 56);
            this.btnBanca.TabIndex = 0;
            this.btnBanca.Text = "Banca";
            this.btnBanca.UseVisualStyleBackColor = true;
            // 
            // PanCompleto
            // 
            this.PanCompleto.Controls.Add(this.panTotais);
            this.PanCompleto.Controls.Add(this.PanQuebras);
            this.PanCompleto.Controls.Add(this.panBotões);
            this.PanCompleto.Controls.Add(this.menuStrip1);
            this.PanCompleto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanCompleto.Location = new System.Drawing.Point(0, 0);
            this.PanCompleto.Name = "PanCompleto";
            this.PanCompleto.Size = new System.Drawing.Size(1184, 681);
            this.PanCompleto.TabIndex = 1;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemInicio,
            this.MenuItemAcessoRapido,
            this.menuItemParametros});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1184, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuItemInicio
            // 
            this.menuItemInicio.Name = "menuItemInicio";
            this.menuItemInicio.Size = new System.Drawing.Size(48, 20);
            this.menuItemInicio.Text = "Inicio";
            // 
            // MenuItemAcessoRapido
            // 
            this.MenuItemAcessoRapido.Name = "MenuItemAcessoRapido";
            this.MenuItemAcessoRapido.Size = new System.Drawing.Size(96, 20);
            this.MenuItemAcessoRapido.Text = "Acesso Rápido";
            // 
            // menuItemParametros
            // 
            this.menuItemParametros.Name = "menuItemParametros";
            this.menuItemParametros.Size = new System.Drawing.Size(79, 20);
            this.menuItemParametros.Text = "Parametros";
            // 
            // BtnPeroxido
            // 
            this.BtnPeroxido.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.BtnPeroxido.Location = new System.Drawing.Point(16, 126);
            this.BtnPeroxido.Name = "BtnPeroxido";
            this.BtnPeroxido.Size = new System.Drawing.Size(212, 56);
            this.BtnPeroxido.TabIndex = 0;
            this.BtnPeroxido.Text = "Peróxido";
            this.BtnPeroxido.UseVisualStyleBackColor = true;
            // 
            // btnFundicao
            // 
            this.btnFundicao.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.btnFundicao.Location = new System.Drawing.Point(296, 41);
            this.btnFundicao.Name = "btnFundicao";
            this.btnFundicao.Size = new System.Drawing.Size(212, 56);
            this.btnFundicao.TabIndex = 0;
            this.btnFundicao.Text = "Fundição";
            this.btnFundicao.UseVisualStyleBackColor = true;
            // 
            // btnRodioBranco
            // 
            this.btnRodioBranco.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.btnRodioBranco.Location = new System.Drawing.Point(296, 126);
            this.btnRodioBranco.Name = "btnRodioBranco";
            this.btnRodioBranco.Size = new System.Drawing.Size(212, 56);
            this.btnRodioBranco.TabIndex = 0;
            this.btnRodioBranco.Text = "Ródio Branco";
            this.btnRodioBranco.UseVisualStyleBackColor = true;
            // 
            // btnMateriaPrima
            // 
            this.btnMateriaPrima.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.btnMateriaPrima.Location = new System.Drawing.Point(576, 41);
            this.btnMateriaPrima.Name = "btnMateriaPrima";
            this.btnMateriaPrima.Size = new System.Drawing.Size(212, 56);
            this.btnMateriaPrima.TabIndex = 0;
            this.btnMateriaPrima.Text = "Matéria Prima";
            this.btnMateriaPrima.UseVisualStyleBackColor = true;
            // 
            // btnRodioNegro
            // 
            this.btnRodioNegro.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.btnRodioNegro.Location = new System.Drawing.Point(576, 126);
            this.btnRodioNegro.Name = "btnRodioNegro";
            this.btnRodioNegro.Size = new System.Drawing.Size(212, 56);
            this.btnRodioNegro.TabIndex = 0;
            this.btnRodioNegro.Text = "Ródio Negro";
            this.btnRodioNegro.UseVisualStyleBackColor = true;
            // 
            // BtnPolitriz
            // 
            this.BtnPolitriz.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.BtnPolitriz.Location = new System.Drawing.Point(16, 211);
            this.BtnPolitriz.Name = "BtnPolitriz";
            this.BtnPolitriz.Size = new System.Drawing.Size(212, 56);
            this.BtnPolitriz.TabIndex = 0;
            this.BtnPolitriz.Text = "Politriz";
            this.BtnPolitriz.UseVisualStyleBackColor = true;
            // 
            // btnPurificacao
            // 
            this.btnPurificacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.btnPurificacao.Location = new System.Drawing.Point(296, 211);
            this.btnPurificacao.Name = "btnPurificacao";
            this.btnPurificacao.Size = new System.Drawing.Size(212, 56);
            this.btnPurificacao.TabIndex = 0;
            this.btnPurificacao.Text = "Purificação";
            this.btnPurificacao.UseVisualStyleBackColor = true;
            // 
            // btnRelatorio
            // 
            this.btnRelatorio.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.btnRelatorio.Location = new System.Drawing.Point(576, 211);
            this.btnRelatorio.Name = "btnRelatorio";
            this.btnRelatorio.Size = new System.Drawing.Size(212, 56);
            this.btnRelatorio.TabIndex = 0;
            this.btnRelatorio.Text = "Relátorios";
            this.btnRelatorio.UseVisualStyleBackColor = true;
            // 
            // btnHoraExtra
            // 
            this.btnHoraExtra.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.btnHoraExtra.Location = new System.Drawing.Point(16, 296);
            this.btnHoraExtra.Name = "btnHoraExtra";
            this.btnHoraExtra.Size = new System.Drawing.Size(212, 56);
            this.btnHoraExtra.TabIndex = 0;
            this.btnHoraExtra.Text = "Hora Extra";
            this.btnHoraExtra.UseVisualStyleBackColor = true;
            // 
            // lblFundicao
            // 
            this.lblFundicao.AutoSize = true;
            this.lblFundicao.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lblFundicao.Location = new System.Drawing.Point(3, 66);
            this.lblFundicao.Name = "lblFundicao";
            this.lblFundicao.Size = new System.Drawing.Size(126, 31);
            this.lblFundicao.TabIndex = 2;
            this.lblFundicao.Text = "Fundição";
            // 
            // lblBanca
            // 
            this.lblBanca.AutoSize = true;
            this.lblBanca.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lblBanca.Location = new System.Drawing.Point(3, 115);
            this.lblBanca.Name = "lblBanca";
            this.lblBanca.Size = new System.Drawing.Size(91, 31);
            this.lblBanca.TabIndex = 2;
            this.lblBanca.Text = "Banca";
            // 
            // lblPeroxido
            // 
            this.lblPeroxido.AutoSize = true;
            this.lblPeroxido.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lblPeroxido.Location = new System.Drawing.Point(3, 162);
            this.lblPeroxido.Name = "lblPeroxido";
            this.lblPeroxido.Size = new System.Drawing.Size(120, 31);
            this.lblPeroxido.TabIndex = 2;
            this.lblPeroxido.Text = "Peróxido";
            // 
            // lblPolitriz
            // 
            this.lblPolitriz.AutoSize = true;
            this.lblPolitriz.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lblPolitriz.Location = new System.Drawing.Point(3, 210);
            this.lblPolitriz.Name = "lblPolitriz";
            this.lblPolitriz.Size = new System.Drawing.Size(96, 31);
            this.lblPolitriz.TabIndex = 2;
            this.lblPolitriz.Text = "Politriz";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lblTotal.Location = new System.Drawing.Point(6, 296);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(75, 31);
            this.lblTotal.TabIndex = 2;
            this.lblTotal.Text = "Total";
            // 
            // lblQuebra
            // 
            this.lblQuebra.AutoSize = true;
            this.lblQuebra.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lblQuebra.Location = new System.Drawing.Point(183, 18);
            this.lblQuebra.Name = "lblQuebra";
            this.lblQuebra.Size = new System.Drawing.Size(104, 31);
            this.lblQuebra.TabIndex = 2;
            this.lblQuebra.Text = "Quebra";
            // 
            // panBotões
            // 
            this.panBotões.Controls.Add(this.lblTotal);
            this.panBotões.Controls.Add(this.lblQuebraTotal);
            this.panBotões.Controls.Add(this.lblQuebraPolitriz);
            this.panBotões.Controls.Add(this.lblPolitriz);
            this.panBotões.Controls.Add(this.lblQuebraFundicao);
            this.panBotões.Controls.Add(this.lblQuebraPeroxido);
            this.panBotões.Controls.Add(this.lblFundicao);
            this.panBotões.Controls.Add(this.lblPeroxido);
            this.panBotões.Controls.Add(this.lblQuebraBanca);
            this.panBotões.Controls.Add(this.lblQuebra);
            this.panBotões.Controls.Add(this.lblBanca);
            this.panBotões.Dock = System.Windows.Forms.DockStyle.Right;
            this.panBotões.Location = new System.Drawing.Point(888, 24);
            this.panBotões.Name = "panBotões";
            this.panBotões.Size = new System.Drawing.Size(296, 657);
            this.panBotões.TabIndex = 3;
            // 
            // PanQuebras
            // 
            this.PanQuebras.Controls.Add(this.btnHoraExtra);
            this.PanQuebras.Controls.Add(this.btnBanca);
            this.PanQuebras.Controls.Add(this.btnRelatorio);
            this.PanQuebras.Controls.Add(this.BtnPeroxido);
            this.PanQuebras.Controls.Add(this.btnPurificacao);
            this.PanQuebras.Controls.Add(this.btnFundicao);
            this.PanQuebras.Controls.Add(this.btnRodioNegro);
            this.PanQuebras.Controls.Add(this.BtnPolitriz);
            this.PanQuebras.Controls.Add(this.btnRodioBranco);
            this.PanQuebras.Controls.Add(this.btnMateriaPrima);
            this.PanQuebras.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanQuebras.Location = new System.Drawing.Point(0, 24);
            this.PanQuebras.Name = "PanQuebras";
            this.PanQuebras.Size = new System.Drawing.Size(888, 657);
            this.PanQuebras.TabIndex = 4;
            // 
            // lblQuebraBanca
            // 
            this.lblQuebraBanca.AutoSize = true;
            this.lblQuebraBanca.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lblQuebraBanca.Location = new System.Drawing.Point(210, 115);
            this.lblQuebraBanca.Name = "lblQuebraBanca";
            this.lblQuebraBanca.Size = new System.Drawing.Size(52, 31);
            this.lblQuebraBanca.TabIndex = 2;
            this.lblQuebraBanca.Text = "0,0";
            // 
            // lblQuebraPeroxido
            // 
            this.lblQuebraPeroxido.AutoSize = true;
            this.lblQuebraPeroxido.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lblQuebraPeroxido.Location = new System.Drawing.Point(210, 162);
            this.lblQuebraPeroxido.Name = "lblQuebraPeroxido";
            this.lblQuebraPeroxido.Size = new System.Drawing.Size(52, 31);
            this.lblQuebraPeroxido.TabIndex = 2;
            this.lblQuebraPeroxido.Text = "0,0";
            // 
            // lblQuebraFundicao
            // 
            this.lblQuebraFundicao.AutoSize = true;
            this.lblQuebraFundicao.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lblQuebraFundicao.Location = new System.Drawing.Point(210, 66);
            this.lblQuebraFundicao.Name = "lblQuebraFundicao";
            this.lblQuebraFundicao.Size = new System.Drawing.Size(52, 31);
            this.lblQuebraFundicao.TabIndex = 2;
            this.lblQuebraFundicao.Text = "0,0";
            // 
            // lblQuebraPolitriz
            // 
            this.lblQuebraPolitriz.AutoSize = true;
            this.lblQuebraPolitriz.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lblQuebraPolitriz.Location = new System.Drawing.Point(210, 210);
            this.lblQuebraPolitriz.Name = "lblQuebraPolitriz";
            this.lblQuebraPolitriz.Size = new System.Drawing.Size(52, 31);
            this.lblQuebraPolitriz.TabIndex = 2;
            this.lblQuebraPolitriz.Text = "0,0";
            // 
            // lblQuebraTotal
            // 
            this.lblQuebraTotal.AutoSize = true;
            this.lblQuebraTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lblQuebraTotal.Location = new System.Drawing.Point(210, 296);
            this.lblQuebraTotal.Name = "lblQuebraTotal";
            this.lblQuebraTotal.Size = new System.Drawing.Size(52, 31);
            this.lblQuebraTotal.TabIndex = 2;
            this.lblQuebraTotal.Text = "0,0";
            // 
            // panTotais
            // 
            this.panTotais.Controls.Add(this.lblTotalRodio);
            this.panTotais.Controls.Add(this.lblMateriaPrimaSaida);
            this.panTotais.Controls.Add(this.lblMateriaPrimaEntrada);
            this.panTotais.Controls.Add(this.lblQtdRodio);
            this.panTotais.Controls.Add(this.lblQtdMateriaPrimaSaida);
            this.panTotais.Controls.Add(this.lblQtdMateriaPrimaEntrada);
            this.panTotais.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panTotais.Location = new System.Drawing.Point(0, 485);
            this.panTotais.Name = "panTotais";
            this.panTotais.Size = new System.Drawing.Size(888, 196);
            this.panTotais.TabIndex = 5;
            // 
            // lblMateriaPrimaEntrada
            // 
            this.lblMateriaPrimaEntrada.AutoSize = true;
            this.lblMateriaPrimaEntrada.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lblMateriaPrimaEntrada.Location = new System.Drawing.Point(12, 24);
            this.lblMateriaPrimaEntrada.Name = "lblMateriaPrimaEntrada";
            this.lblMateriaPrimaEntrada.Size = new System.Drawing.Size(288, 31);
            this.lblMateriaPrimaEntrada.TabIndex = 2;
            this.lblMateriaPrimaEntrada.Text = "Materia Prima entrada:";
            // 
            // lblMateriaPrimaSaida
            // 
            this.lblMateriaPrimaSaida.AutoSize = true;
            this.lblMateriaPrimaSaida.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lblMateriaPrimaSaida.Location = new System.Drawing.Point(12, 75);
            this.lblMateriaPrimaSaida.Name = "lblMateriaPrimaSaida";
            this.lblMateriaPrimaSaida.Size = new System.Drawing.Size(265, 31);
            this.lblMateriaPrimaSaida.TabIndex = 2;
            this.lblMateriaPrimaSaida.Text = "Materia Prima Saida:";
            // 
            // lblTotalRodio
            // 
            this.lblTotalRodio.AutoSize = true;
            this.lblTotalRodio.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lblTotalRodio.Location = new System.Drawing.Point(12, 126);
            this.lblTotalRodio.Name = "lblTotalRodio";
            this.lblTotalRodio.Size = new System.Drawing.Size(161, 31);
            this.lblTotalRodio.TabIndex = 2;
            this.lblTotalRodio.Text = "Total Ródio:";
            // 
            // lblQtdMateriaPrimaEntrada
            // 
            this.lblQtdMateriaPrimaEntrada.AutoSize = true;
            this.lblQtdMateriaPrimaEntrada.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lblQtdMateriaPrimaEntrada.Location = new System.Drawing.Point(306, 24);
            this.lblQtdMateriaPrimaEntrada.Name = "lblQtdMateriaPrimaEntrada";
            this.lblQtdMateriaPrimaEntrada.Size = new System.Drawing.Size(52, 31);
            this.lblQtdMateriaPrimaEntrada.TabIndex = 2;
            this.lblQtdMateriaPrimaEntrada.Text = "0,0";
            // 
            // lblQtdMateriaPrimaSaida
            // 
            this.lblQtdMateriaPrimaSaida.AutoSize = true;
            this.lblQtdMateriaPrimaSaida.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lblQtdMateriaPrimaSaida.Location = new System.Drawing.Point(306, 75);
            this.lblQtdMateriaPrimaSaida.Name = "lblQtdMateriaPrimaSaida";
            this.lblQtdMateriaPrimaSaida.Size = new System.Drawing.Size(52, 31);
            this.lblQtdMateriaPrimaSaida.TabIndex = 2;
            this.lblQtdMateriaPrimaSaida.Text = "0,0";
            // 
            // lblQtdRodio
            // 
            this.lblQtdRodio.AutoSize = true;
            this.lblQtdRodio.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lblQtdRodio.Location = new System.Drawing.Point(306, 126);
            this.lblQtdRodio.Name = "lblQtdRodio";
            this.lblQtdRodio.Size = new System.Drawing.Size(52, 31);
            this.lblQtdRodio.TabIndex = 2;
            this.lblQtdRodio.Text = "0,0";
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 681);
            this.Controls.Add(this.PanCompleto);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormMenu";
            this.Text = "Inicio";
            this.PanCompleto.ResumeLayout(false);
            this.PanCompleto.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panBotões.ResumeLayout(false);
            this.panBotões.PerformLayout();
            this.PanQuebras.ResumeLayout(false);
            this.panTotais.ResumeLayout(false);
            this.panTotais.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBanca;
        private System.Windows.Forms.Panel PanCompleto;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuItemInicio;
        private System.Windows.Forms.ToolStripMenuItem MenuItemAcessoRapido;
        private System.Windows.Forms.ToolStripMenuItem menuItemParametros;
        private System.Windows.Forms.Label lblFundicao;
        private System.Windows.Forms.Button btnRelatorio;
        private System.Windows.Forms.Button btnPurificacao;
        private System.Windows.Forms.Button btnRodioNegro;
        private System.Windows.Forms.Button btnRodioBranco;
        private System.Windows.Forms.Button btnHoraExtra;
        private System.Windows.Forms.Button btnMateriaPrima;
        private System.Windows.Forms.Button BtnPolitriz;
        private System.Windows.Forms.Button btnFundicao;
        private System.Windows.Forms.Button BtnPeroxido;
        private System.Windows.Forms.Panel PanQuebras;
        private System.Windows.Forms.Panel panBotões;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblQuebraPolitriz;
        private System.Windows.Forms.Label lblPolitriz;
        private System.Windows.Forms.Label lblQuebraFundicao;
        private System.Windows.Forms.Label lblQuebraPeroxido;
        private System.Windows.Forms.Label lblPeroxido;
        private System.Windows.Forms.Label lblQuebraBanca;
        private System.Windows.Forms.Label lblQuebra;
        private System.Windows.Forms.Label lblBanca;
        private System.Windows.Forms.Label lblQuebraTotal;
        private System.Windows.Forms.Panel panTotais;
        private System.Windows.Forms.Label lblTotalRodio;
        private System.Windows.Forms.Label lblMateriaPrimaSaida;
        private System.Windows.Forms.Label lblMateriaPrimaEntrada;
        private System.Windows.Forms.Label lblQtdRodio;
        private System.Windows.Forms.Label lblQtdMateriaPrimaSaida;
        private System.Windows.Forms.Label lblQtdMateriaPrimaEntrada;
    }
}

