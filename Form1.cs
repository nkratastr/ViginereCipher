using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Linq;

namespace ViginereCipher
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCipher_Click(object sender, EventArgs e)
        {
            VigenereOperation viginereOperation = new VigenereOperation();
            CipherText cipherText = new CipherText();
            viginereOperation.chiperWithSpace = cbxCipherWithSpace.Checked ? true : false;
            viginereOperation.plainText = tbxPlainText.Text.ToLower().ToString();
            viginereOperation.secretKey = tbxSecretKey.Text.ToLower().ToString();

            viginereOperation = cipherText.CipherGivenText(viginereOperation);

            tbxCipherText.Text = viginereOperation.CipherTextVigenere;
            tbxKasiskiCipherText.Text = tbxCipherText.Text;
        }

        private void btnDecipher_Click(object sender, EventArgs e)
        {
            VigenereOperation vigenereOperation = new VigenereOperation();
            CipherText cipherText = new CipherText();
            vigenereOperation.plainText = tbxCipherText.Text.ToLower().ToString();
            vigenereOperation.secretKey = tbxSecretKey.Text.ToLower().ToString();
            vigenereOperation.cipherOrDecipher = -1;
            vigenereOperation.decipherAlphabetDecreaser = 29;

            vigenereOperation = cipherText.CipherGivenText(vigenereOperation);
            tbxPlainText.Text = vigenereOperation.CipherTextVigenere;
        }

        private void btnAnalyzeKasiski_Click(object sender, EventArgs e)
        {
            CreateDatagridColumns();

            string cipherTextKasiskiAnalyze = tbxKasiskiCipherText.Text;
            tbxKasiskiCipherText.Text += "\r\n";
            int cell = 0;
            int row = 0;
            string[] triagrapOffset;
            Dictionary<int, int> offsetDistance = new Dictionary<int, int>();

            Dictionary<string, string> triagraphsInTextWithOffset = new Dictionary<string, string>();
            FindTriagpraphsInCipherText(cipherTextKasiskiAnalyze, triagraphsInTextWithOffset);

            foreach (var triagraph in triagraphsInTextWithOffset)
            {
                if (triagraph.Value.Contains(" "))
                {
                    dtgwAnalyzeKasiski.Rows.Add(triagraph.Key, " ", " ", " ", " ", " ", " ", " ");
                    tbxKasiskiCipherText.Text += triagraph.Key + "-->" + triagraph.Value + "\r\n";
                    dtgwAnalyzeKasiski.Rows[row].Cells[cell].Value = triagraph.Key;

                    triagrapOffset = triagraph.Value.Split(' ');
                    CalculateDistanceBetweenOffsets(triagrapOffset, offsetDistance);

                    cell = WriteCalculatedOffsetToTableCell(cell, row, triagrapOffset);
                    cell = 0;
                    row++;
                }
            }

            DrawDistanceBetweenOffsetGraphic(offsetDistance);

            Dictionary<int, int> dividers = FindDivider(offsetDistance);
            DrawDividersToGraphic(dividers);
        }

        private static void CalculateDistanceBetweenOffsets(string[] triagrapOffset, Dictionary<int, int> offsetDistance)
        {
            for (int i = 1; i < triagrapOffset.Length; i++)
            {
                if (!offsetDistance.ContainsKey(Convert.ToInt32(triagrapOffset[i]) - Convert.ToInt32(triagrapOffset[i - 1])))
                {
                    offsetDistance.Add(Convert.ToInt32(triagrapOffset[i]) - Convert.ToInt32(triagrapOffset[i - 1]), 1);
                }
                else if (true)
                {
                    offsetDistance[Convert.ToInt32(triagrapOffset[i]) - Convert.ToInt32(triagrapOffset[i - 1])]++;
                }
            }
        }

        private int WriteCalculatedOffsetToTableCell(int cell, int row, string[] triagrapOffset)
        {
            foreach (var offset in triagrapOffset)
            {
                cell++;
                dtgwAnalyzeKasiski.Rows[row].Cells[cell].Value = offset;
            }

            return cell;
        }

        private static void FindTriagpraphsInCipherText(string cipherTextKasiskiAnalyze, Dictionary<string, string> triagraphsInTextWithOffset)
        {
            for (int i = 0; i < cipherTextKasiskiAnalyze.Length - 2; i++)
            {
                if (triagraphsInTextWithOffset.ContainsKey(cipherTextKasiskiAnalyze.Substring(i, 3)))
                {
                    triagraphsInTextWithOffset[cipherTextKasiskiAnalyze.Substring(i, 3)] += " " + i.ToString();
                }
                else
                {
                    triagraphsInTextWithOffset.Add(cipherTextKasiskiAnalyze.Substring(i, 3), i.ToString());
                }
            }
            Application.DoEvents();
        }

        private void DrawDistanceBetweenOffsetGraphic(Dictionary<int, int> offsetDistance)
        {
            foreach (var distance in offsetDistance)
            {
                chrDistance.Series["Distance Between Offsets"].Points.Add(distance.Value).Label = distance.Key.ToString();
            }
        }

        private void CreateDatagridColumns()
        {
            dtgwAnalyzeKasiski.ColumnCount = 8;
            dtgwAnalyzeKasiski.Columns[0].Name = "Triagraph";
            dtgwAnalyzeKasiski.Columns[1].Name = "Offset";
            dtgwAnalyzeKasiski.Columns[2].Name = "Offset";
            dtgwAnalyzeKasiski.Columns[3].Name = "Offset";
            dtgwAnalyzeKasiski.Columns[4].Name = "Offset";
            dtgwAnalyzeKasiski.Columns[5].Name = "Offset";
            dtgwAnalyzeKasiski.Columns[6].Name = "Offset";
            dtgwAnalyzeKasiski.Columns[7].Name = "Offset";
        }

        public Dictionary<int, int> FindDivider(Dictionary<int, int> offsetDistance)
        {
            Dictionary<int, int> dividers = new Dictionary<int, int>();
            foreach (var distance in offsetDistance)
            {
                for (int i = 2; i < distance.Key; i++)
                {
                    if (distance.Key % i == 0)
                    {
                        if (!dividers.ContainsKey(i))
                        {
                            dividers.Add(i, distance.Value);
                        }
                        else if (dividers.ContainsKey(i))
                        {
                            dividers[i] += distance.Value;
                        }
                    }
                }
            }

            return dividers;
        }

        private void DrawDividersToGraphic(Dictionary<int, int> dividers)
        {
            foreach (var divides in dividers)
            {
                if (divides.Value > 1)
                {
                    chrDividers.Series["Possible Key Lenght"].Points.Add(divides.Value).Label = divides.Key.ToString();
                }
            }
        }
    }
}