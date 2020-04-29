using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace systemAnalyze5
{
    public partial class Form1 : Form
    {
        private int count = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void topsCount_ValueChanged(object sender, EventArgs e)
        {
            count = Int32.Parse(topsCount.Value.ToString());
            if (count > 0)
            {
                relationsMatrixView.RowCount = count;
                relationsMatrixView.ColumnCount = count;
            }
            else
            {
                MessageBox.Show("Значение должно быть больше 0", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            for (int i = 0; i != count; i++)
            {
                relationsMatrixView.Rows[i].HeaderCell.Value = $"{i}";
                relationsMatrixView.Columns[i].HeaderCell.Value = $"{i}";
            }
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            List<List<int>> inputValues = new List<List<int>>();
            for (int i = 0; i != count; ++i)
            {
                DataGridViewRow curRow = relationsMatrixView.Rows[i];
                List<int> curList = new List<int>();
                for (int j = 0; j != count; ++j)
                {
                    try
                    {
                        int val = Int32.Parse(curRow.Cells[j].Value.ToString());
                        curList.Add(val);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Ошибка: {ex.Message}");
                        return;
                    }
                }
                inputValues.Add(curList);
            }
            MetricsCalculation calc;
            try
            {
                calc = new MetricsCalculation(inputValues, count, !isUnorient.Checked);
                double RValue = calc.getRValue();
                double e2Value = calc.getE2Value();
                EValueLabel.Text = Math.Round(e2Value, 4).ToString();
                RValueLabel.Text = Math.Round(RValue, 4).ToString();
                if (RValue > 0)
                    graphType.Text = "Система избыточна";
                else if (RValue < 0)
                    graphType.Text = "Несвязная система";
                else
                    graphType.Text = "Система не имеет избыточности";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"ERROR: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

    }
}
