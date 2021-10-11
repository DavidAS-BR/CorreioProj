
namespace CorreioProj
{
    partial class CorreioLogistica
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.caixaPrioridadeLevel = new System.Windows.Forms.Label();
            this.caixaTempoAteDestino = new System.Windows.Forms.Label();
            this.caixaCepDestino = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.updateCaixasButton = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.buttonAddCaixaArmazem = new System.Windows.Forms.Button();
            this.buttonDefinirArmazemDados = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.caixaTamanhoComboBox = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.caixaTextBoxCepDestino = new System.Windows.Forms.TextBox();
            this.entregarButton = new System.Windows.Forms.Button();
            this.flowLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Controls.Add(this.groupBox1);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(2, 2);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(393, 544);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.caixaPrioridadeLevel);
            this.groupBox1.Controls.Add(this.caixaTempoAteDestino);
            this.groupBox1.Controls.Add(this.caixaCepDestino);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(384, 96);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Caixa 1";
            // 
            // caixaPrioridadeLevel
            // 
            this.caixaPrioridadeLevel.AutoSize = true;
            this.caixaPrioridadeLevel.Location = new System.Drawing.Point(124, 67);
            this.caixaPrioridadeLevel.Name = "caixaPrioridadeLevel";
            this.caixaPrioridadeLevel.Size = new System.Drawing.Size(50, 20);
            this.caixaPrioridadeLevel.TabIndex = 5;
            this.caixaPrioridadeLevel.Text = "label4";
            // 
            // caixaTempoAteDestino
            // 
            this.caixaTempoAteDestino.AutoSize = true;
            this.caixaTempoAteDestino.Location = new System.Drawing.Point(232, 43);
            this.caixaTempoAteDestino.Name = "caixaTempoAteDestino";
            this.caixaTempoAteDestino.Size = new System.Drawing.Size(50, 20);
            this.caixaTempoAteDestino.TabIndex = 4;
            this.caixaTempoAteDestino.Text = "label4";
            // 
            // caixaCepDestino
            // 
            this.caixaCepDestino.AutoSize = true;
            this.caixaCepDestino.Location = new System.Drawing.Point(124, 23);
            this.caixaCepDestino.Name = "caixaCepDestino";
            this.caixaCepDestino.Size = new System.Drawing.Size(50, 20);
            this.caixaCepDestino.TabIndex = 3;
            this.caixaCepDestino.Text = "label4";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nível Prioridade:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(223, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tempo de viagem até o destino:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "CEP do destino:";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(0, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(406, 637);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.entregarButton);
            this.tabPage1.Controls.Add(this.updateCaixasButton);
            this.tabPage1.Controls.Add(this.flowLayoutPanel1);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(398, 604);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // updateCaixasButton
            // 
            this.updateCaixasButton.Location = new System.Drawing.Point(293, 562);
            this.updateCaixasButton.Name = "updateCaixasButton";
            this.updateCaixasButton.Size = new System.Drawing.Size(94, 29);
            this.updateCaixasButton.TabIndex = 1;
            this.updateCaixasButton.Text = "Atualizar";
            this.updateCaixasButton.UseVisualStyleBackColor = true;
            this.updateCaixasButton.Click += new System.EventHandler(this.updateCaixasButton_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.buttonAddCaixaArmazem);
            this.tabPage2.Controls.Add(this.buttonDefinirArmazemDados);
            this.tabPage2.Controls.Add(this.textBox1);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.caixaTamanhoComboBox);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.caixaTextBoxCepDestino);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(398, 604);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // buttonAddCaixaArmazem
            // 
            this.buttonAddCaixaArmazem.Location = new System.Drawing.Point(181, 340);
            this.buttonAddCaixaArmazem.Name = "buttonAddCaixaArmazem";
            this.buttonAddCaixaArmazem.Size = new System.Drawing.Size(206, 29);
            this.buttonAddCaixaArmazem.TabIndex = 8;
            this.buttonAddCaixaArmazem.Text = "Adicionar caixa ao armazem";
            this.buttonAddCaixaArmazem.UseVisualStyleBackColor = true;
            this.buttonAddCaixaArmazem.Click += new System.EventHandler(this.buttonAddCaixaArmazem_Click);
            // 
            // buttonDefinirArmazemDados
            // 
            this.buttonDefinirArmazemDados.Location = new System.Drawing.Point(293, 79);
            this.buttonDefinirArmazemDados.Name = "buttonDefinirArmazemDados";
            this.buttonDefinirArmazemDados.Size = new System.Drawing.Size(94, 29);
            this.buttonDefinirArmazemDados.TabIndex = 7;
            this.buttonDefinirArmazemDados.Text = "Definir";
            this.buttonDefinirArmazemDados.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(141, 16);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(125, 27);
            this.textBox1.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 19);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(125, 20);
            this.label7.TabIndex = 5;
            this.label7.Text = "CEP do armazém:";
            // 
            // caixaTamanhoComboBox
            // 
            this.caixaTamanhoComboBox.FormattingEnabled = true;
            this.caixaTamanhoComboBox.Items.AddRange(new object[] {
            "15 x 10 x 2,5 cm"});
            this.caixaTamanhoComboBox.Location = new System.Drawing.Point(147, 277);
            this.caixaTamanhoComboBox.Name = "caixaTamanhoComboBox";
            this.caixaTamanhoComboBox.Size = new System.Drawing.Size(151, 28);
            this.caixaTamanhoComboBox.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 280);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(131, 20);
            this.label6.TabIndex = 3;
            this.label6.Text = "Tamanho da caixa:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 227);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(192, 20);
            this.label5.TabIndex = 2;
            this.label5.Text = "CEP do destino do produto:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(125, 187);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(147, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "Criar novos produtos";
            // 
            // caixaTextBoxCepDestino
            // 
            this.caixaTextBoxCepDestino.Location = new System.Drawing.Point(206, 224);
            this.caixaTextBoxCepDestino.Name = "caixaTextBoxCepDestino";
            this.caixaTextBoxCepDestino.Size = new System.Drawing.Size(125, 27);
            this.caixaTextBoxCepDestino.TabIndex = 0;
            // 
            // entregarButton
            // 
            this.entregarButton.Location = new System.Drawing.Point(11, 562);
            this.entregarButton.Name = "entregarButton";
            this.entregarButton.Size = new System.Drawing.Size(94, 29);
            this.entregarButton.TabIndex = 2;
            this.entregarButton.Text = "Entregar";
            this.entregarButton.UseVisualStyleBackColor = true;
            this.entregarButton.Click += new System.EventHandler(this.entregarButton_Click);
            // 
            // CorreioLogistica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 637);
            this.Controls.Add(this.tabControl1);
            this.Name = "CorreioLogistica";
            this.Text = "CorreioLogistica";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label caixaPrioridadeLevel;
        private System.Windows.Forms.Label caixaTempoAteDestino;
        private System.Windows.Forms.Label caixaCepDestino;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button updateCaixasButton;
        private System.Windows.Forms.Button buttonAddCaixaArmazem;
        private System.Windows.Forms.Button buttonDefinirArmazemDados;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox caixaTamanhoComboBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox caixaTextBoxCepDestino;
        private System.Windows.Forms.Button entregarButton;
    }
}