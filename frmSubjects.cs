using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace TaskManager
{
    public partial class frmSubjects : Form
    {
        string dbPath;

        public frmSubjects(string dbpath)
        {
            InitializeComponent();
            dbPath = dbpath;
        }
        private void LoadDgv()
        {
            List<Subjects> subjects = new List<Subjects>();
            subjects = DataLoader.GetSubjects(dbPath);
            dgvSubjects.DataSource = subjects;
            tbSubject.Text = string.Empty;

            dgvSubjects.Columns[0].HeaderCell.Value = "#";
            dgvSubjects.Columns[1].HeaderCell.Value = "Название";
        }
        private void frmSubjects_Load(object sender, EventArgs e)
        {
            LoadDgv();
            dgvSubjects.Columns[0].Width = 30;
            dgvSubjects.Columns[1].Width = 287;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (tbSubject.Text.Trim().Length > 0)
            {
                DataWriter.InsertSubject(dbPath, tbSubject.Text.Trim());
                LoadDgv();
            }
            else
            {
                MessageBox.Show("Пустое поле ввода! Введите название предмета.", "Пустое поле", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}