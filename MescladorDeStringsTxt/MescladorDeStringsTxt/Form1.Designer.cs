namespace MescladorDeStringsTxt
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
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.richTextBoxLog = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnAddFile = new System.Windows.Forms.Button();
            this.btnGerarTxtMesclado = new System.Windows.Forms.Button();
            this.labelMensagem = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // richTextBoxLog
            // 
            this.richTextBoxLog.Location = new System.Drawing.Point(12, 43);
            this.richTextBoxLog.Name = "richTextBoxLog";
            this.richTextBoxLog.Size = new System.Drawing.Size(436, 133);
            this.richTextBoxLog.TabIndex = 7;
            this.richTextBoxLog.Text = "";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(148, 19);
            this.label5.TabIndex = 18;
            this.label5.Text = "Arquivos importados:";
            // 
            // btnAddFile
            // 
            this.btnAddFile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddFile.Location = new System.Drawing.Point(312, 17);
            this.btnAddFile.Name = "btnAddFile";
            this.btnAddFile.Size = new System.Drawing.Size(136, 23);
            this.btnAddFile.TabIndex = 19;
            this.btnAddFile.Text = "Adicionar Arquivo";
            this.btnAddFile.UseVisualStyleBackColor = true;
            this.btnAddFile.Click += new System.EventHandler(this.btnAddFile_Click);
            // 
            // btnGerarTxtMesclado
            // 
            this.btnGerarTxtMesclado.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGerarTxtMesclado.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGerarTxtMesclado.Location = new System.Drawing.Point(12, 216);
            this.btnGerarTxtMesclado.Name = "btnGerarTxtMesclado";
            this.btnGerarTxtMesclado.Size = new System.Drawing.Size(436, 48);
            this.btnGerarTxtMesclado.TabIndex = 20;
            this.btnGerarTxtMesclado.Text = "Gerar Arquivo Mesclado";
            this.btnGerarTxtMesclado.UseVisualStyleBackColor = true;
            this.btnGerarTxtMesclado.Click += new System.EventHandler(this.btnGerarTxtMesclado_Click);
            // 
            // labelMensagem
            // 
            this.labelMensagem.Font = new System.Drawing.Font("Arial Narrow", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMensagem.Location = new System.Drawing.Point(12, 179);
            this.labelMensagem.Name = "labelMensagem";
            this.labelMensagem.Size = new System.Drawing.Size(433, 19);
            this.labelMensagem.TabIndex = 21;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 276);
            this.Controls.Add(this.labelMensagem);
            this.Controls.Add(this.btnGerarTxtMesclado);
            this.Controls.Add(this.btnAddFile);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.richTextBoxLog);
            this.Name = "Form1";
            this.Text = "Mesclador de String em TXT";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.RichTextBox richTextBoxLog;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnAddFile;
        private System.Windows.Forms.Button btnGerarTxtMesclado;
        private System.Windows.Forms.Label labelMensagem;
    }
}

