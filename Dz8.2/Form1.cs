using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dz8._2
{
    public partial class Form1 : Form
    {
        private TrueFalse database;


        public Form1()
        {
            InitializeComponent();
        }

        private void menuitemExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void menuitemNew_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            if(saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                database = new TrueFalse(saveFileDialog.FileName);
                database.Add("Сейчас 2021 год?", true);
                database.Save();
                nudNumber.Minimum = 1;
                nudNumber.Maximum = 1;
                nudNumber.Value = 1;
            }
        }

        private void nudNumber_ValueChanged(object sender, EventArgs e)
        {
            tbQuestion.Text = database[(int)nudNumber.Value - 1].Text;
            cbTrue.Checked = database[(int)nudNumber.Value - 1].TrueFalse;

        }

        private void menuitemOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                database = new TrueFalse(openFileDialog.FileName);
                database.Load();
                nudNumber.Minimum = 1;
                nudNumber.Value = 1;
                nudNumber.Maximum = database.Count;
                //MessageBox.Show(database.Count.ToString());
                
            }

        }

        private void menuitemSave_Click(object sender, EventArgs e)
        {
            if (database != null)
                database.Save();
            else
                MessageBox.Show ("Вы не открыли или не создали Базу Данных");
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (database != null)
            {
                database.Add("#" + (database.Count + 1).ToString(), true);
                nudNumber.Maximum = database.Count;
                nudNumber.Value = database.Count;
            }
            else
                MessageBox.Show("Вы не открыли или не создали Базу Данных");           
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            database.Remove((int)nudNumber.Value - 1);
            nudNumber.Maximum--;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            database[(int)nudNumber.Value - 1].Text = tbQuestion.Text;
            database[(int)nudNumber.Value - 1].TrueFalse = cbTrue.Checked;
        }

        private void itemProgramm_Click(object sender, EventArgs e)
        {
            MessageBox.Show(@"Версия приложения 1.0
Автор: Антон Домников
Любое копирование являетя нарушением, защищено каким-то правом");
        }

        private void itemSaveAll_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                if (database != null)
                    database.SaveAs(saveFileDialog.FileName);
                else
                    MessageBox.Show("Вы не открыли или не создали Базу Данных");
            }

            
        }

        
    }
}
