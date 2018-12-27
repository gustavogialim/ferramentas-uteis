using System;
using System.Collections.Generic;
using System.IO;
using System.Threading;
using System.Windows.Forms;

namespace MescladorDeStringsTxt
{
    public partial class Form1 : Form
    {
        OpenFileDialog openFileDialog = new OpenFileDialog();
        List<string> linhas = new List<string>();

        public Form1()
        {
            InitializeComponent();

            openFileDialog.Multiselect = true;
        }

        private void btnAddFile_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                
                foreach (var file in openFileDialog.FileNames)
                {
                    System.IO.StreamReader sr = new System.IO.StreamReader(file);

                    while (sr.EndOfStream == false)
                    {
                        string linha = sr.ReadLine();

                        if (!linhas.Contains(linha) && !string.IsNullOrEmpty(linha))
                        {
                            linhas.Add(linha);
                        }
                    }

                    richTextBoxLog.AppendText($"{file}.\r\n");
                    sr.Close();
                }
            }
        }

        private void btnGerarTxtMesclado_Click(object sender, EventArgs e)
        {
            labelMensagem.Text = "Mesclando arquivos";
            btnAddFile.Enabled = false;
            btnGerarTxtMesclado.Enabled = false;

            //Thread thread;
            //thread = new Thread(new ThreadStart(Mesclar));
            //thread.Start();

            Mesclar();
        }

        private void Mesclar()
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "(*.txt)|*.txt";
            saveFileDialog1.Title = "Arquivo TXT";
            
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if (saveFileDialog1.FileName != "")
                {
                    using (var stream = new StreamWriter(saveFileDialog1.OpenFile()))
                    {
                        foreach (var linha in linhas)
                        {
                            stream.WriteLine(linha);
                        }
                    }
                }
                else
                {
                    this.Invoke(new Action(() => { MessageBox.Show("Informe o nome do arquivo."); }));
                }
            }

            labelMensagem.Text = "Arquivo de mesclagem gerado e salvo com sucesso.";
            btnAddFile.Enabled = true;
            btnGerarTxtMesclado.Enabled = true;
            richTextBoxLog.Clear();
            linhas.Clear();
        }
    }
}
