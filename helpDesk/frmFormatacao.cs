using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Globalization;

namespace helpDesk
{
    public partial class frmFormatacao : Form
    {
        public frmFormatacao()
        {
            InitializeComponent();
        }

        private void btnFormatacao_Click(object sender, EventArgs e)
        {
            string texto = rtbSaida.Text;
            texto = texto.Replace("\n", " ");
            texto = texto.Replace("\t", " ");
            string novoTexto = "";

            //Retira os espaços em exceso
            for (int i = 0; i < texto.Length; i++)
            {
                try {
                    if (texto.Substring(i, 1) == " ")
                    {
                        if (texto.Substring(i + 1, 1) != " ")
                        { novoTexto += texto.Substring(i, 1); }
                    } else { novoTexto += texto.Substring(i, 1); }
                } catch { /*Não faz nada*/ }
            } novoTexto = novoTexto.Trim();
            rtbSaida.Text = novoTexto;
            rtbSaida.Focus();
        }

        private void btnEspacos_Click(object sender, EventArgs e)
        {
            string texto = rtbSaida.Text;
            texto = texto.Replace(" ", "");
            rtbSaida.Text = texto;
            rtbSaida.Focus();
        }

        private void btnMinusculo_Click(object sender, EventArgs e)
        {
            string texto = rtbSaida.Text;
            texto = texto.ToLower();
            rtbSaida.Text = texto;
            rtbSaida.Focus();
        }

        private void btnMaiusculo_Click(object sender, EventArgs e)
        {
            string texto = rtbSaida.Text;
            texto = texto.ToUpper();
            rtbSaida.Text = texto;
            rtbSaida.Focus();
        }

        private void btnAscento_Click(object sender, EventArgs e)
        {
            StringBuilder novoTexto = new StringBuilder();
            var texto = rtbSaida.Text.Normalize(NormalizationForm.FormD).ToCharArray();
            foreach (char letra in texto)
            {
                if (CharUnicodeInfo.GetUnicodeCategory(letra) != UnicodeCategory.NonSpacingMark)
                {
                    novoTexto.Append(letra);
                }
            }
            rtbSaida.Text = novoTexto.ToString();
            rtbSaida.Focus();
        }

        private void btnAspas_Click(object sender, EventArgs e)
        {
            string texto = rtbSaida.Text;
            texto = texto.Replace("\"", "'");
            rtbSaida.Text = texto;
            rtbSaida.Focus();
        }

        #region Text changed das rtbBox
            private void rtbEntrada_TextChanged(object sender, EventArgs e)
            {
                rtbSaida.Text = rtbEntrada.Text;
                lblBruto.Text = rtbEntrada.TextLength.ToString();
            }
            private void rtbSaida_TextChanged(object sender, EventArgs e)
            {
                lblLiquido.Text = rtbSaida.TextLength.ToString();
            }
        #endregion

        #region Page Load
            private void frmFormatacao_Load(object sender, EventArgs e)
            {
                rtbEntrada.Focus();
            }
        #endregion

        #region Enter e leaves do mouse nos itens do menu strip
            //
            private void aplicarToolStripMenuItem_MouseEnter(object sender, EventArgs e)
            {
                aplicarToolStripMenuItem.ForeColor = Color.FromArgb(0, 200, 0);
            }
            private void aplicarToolStripMenuItem_MouseLeave(object sender, EventArgs e)
            {
                aplicarToolStripMenuItem.ForeColor = Color.DarkGray;
            }
            
            //
            private void tsFormatacao_MouseEnter(object sender, EventArgs e)
            {
                tsFormatacao.ForeColor = Color.FromArgb(0, 200, 0);
            }
            private void tsFormatacao_MouseLeave(object sender, EventArgs e)
            {
                tsFormatacao.ForeColor = Color.Black;
            }

            //
            private void tsEspacos_MouseEnter(object sender, EventArgs e)
            {
                tsEspacos.ForeColor = Color.FromArgb(0, 200, 0);
            }
            private void tsEspacos_MouseLeave(object sender, EventArgs e)
            {
                tsEspacos.ForeColor = Color.Black;
            }

            //
            private void tsAscentos_MouseEnter(object sender, EventArgs e)
            {
                tsAscentos.ForeColor = Color.FromArgb(0, 200, 0);
            }
            private void tsAscentos_MouseLeave(object sender, EventArgs e)
            {
                tsAscentos.ForeColor = Color.Black;
            }

            //
            private void tsMinusculo_MouseEnter(object sender, EventArgs e)
            {
                tsMinusculo.ForeColor = Color.FromArgb(0, 200, 0);
            }
            private void tsMinusculo_MouseLeave(object sender, EventArgs e)
            {
                tsMinusculo.ForeColor = Color.Black;
            }

            //
            private void tsMaiusculo_MouseEnter(object sender, EventArgs e)
            {
                tsMaiusculo.ForeColor = Color.FromArgb(0, 200, 0);
            }
            private void tsMaiusculo_MouseLeave(object sender, EventArgs e)
            {
                tsMaiusculo.ForeColor = Color.Black;
            }

            //
            private void tsAspas_MouseEnter(object sender, EventArgs e)
            {
                tsAspas.ForeColor = Color.FromArgb(0, 200, 0);
            }
            private void tsAspas_MouseLeave(object sender, EventArgs e)
            {
                tsAspas.ForeColor = Color.Black;
            }

            // Formata o texto para fontes sem ascento
            private void tsFonte_Click(object sender, EventArgs e)
            {
                StringBuilder novoTexto = new StringBuilder();
                var texto = rtbSaida.Text.Normalize(NormalizationForm.FormD).ToCharArray();
                for (int i = 0; i < texto.Length; i++)
                {
                    if (CharUnicodeInfo.GetUnicodeCategory(texto[i]) != UnicodeCategory.NonSpacingMark)
                    { novoTexto.Append(texto[i]); }
                    else
                    {
                        novoTexto.Remove(i - 1, 1);
                        novoTexto.Append(char.ToUpper(texto[i - 1]));
                        novoTexto.Append(texto[i]);
                    }
                }
                rtbSaida.Text = novoTexto.ToString();
                rtbSaida.Focus();
            }
            private void tsFonte_MouseEnter(object sender, EventArgs e)
            {
                tsFonte.ForeColor = Color.FromArgb(0, 200, 0);
            }
            private void tsFonte_MouseLeave(object sender, EventArgs e)
            {
                tsFonte.ForeColor = Color.Black;
            }

        #endregion

    }
}
