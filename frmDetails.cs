using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace TaskManager
{
    public partial class frmDetails : Form
    {
        private List<Tasks> list = new List<Tasks>();
        private List<Subjects> subjects = new List<Subjects>();
        private int WinType;
        private string dbPath;
        private int Id;
        private int St;
        private frmMain mainForm;

        public frmDetails(frmMain frmmain, int id, string dbpath, int WindowType)
        {
            InitializeComponent();
            dbPath = dbpath;
            list = DataLoader.LoadTask(dbPath, id);
            WinType = WindowType;
            subjects = DataLoader.GetSubjects(dbPath);
            Id = id;
            mainForm = frmmain;

            cbSubject.DisplayMember = "SubjectName";
            cbSubject.ValueMember = "Id";

        }
        private int GetStatus()
        {
            int status;
            if (rbTodo.Checked)
            {
                status = 1;
            }
            else if (rbInProcess.Checked)
            {
                status = 2;
            }
            else
            {
                status = 3;
            }
            return status;
        }
        private void SelectRb(int Status)
        {
            if (Status == 1)
            {
                rbTodo.Checked = true;
            }
            else if (Status == 2)
            {
                rbInProcess.Checked = true;
            }
            else
            {
                rbComplete.Checked = true;
            }
        }
        private void frmDetails_Load(object sender, EventArgs e)
        {
            if (WinType == 0)
            {
                this.Text = "Детали задачи";
                tbName.Text = list[0].Name;
                cbSubject.DataSource = subjects;
                rtbDescription.Text = list[0].Description;
                cbSubject.SelectedValue = list[0].Subject;
                St = list[0].Status;
                SelectRb(St);
                dtpDateEnd.Value = list[0].DueDate.Value;
            }
            else if (WinType == 1)
            {
                this.Text = "Новая задача";
                tbName.Text = string.Empty;
                cbSubject.DataSource = subjects;
                rtbDescription.Text = string.Empty;
            }
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            if (WinType == 0)
            {
                if (tbName.Text.Trim().Length > 0)
                {
                    int status = GetStatus();
                    DataWriter.UpdateTask(dbPath, Id, tbName.Text, cbSubject.SelectedIndex, rtbDescription.Text, dtpDateEnd.Value, 1, status);
                    mainForm.ReloadAllData();
                    mainForm.FormatCells();
                    mainForm.InitDgv();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Пустое поле данных! Введите название задачи.", "Пустое поле", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else if (WinType == 1)
            {
                if (tbName.Text.Trim().Length > 0)
                {
                    DataWriter.InsertTask(dbPath, tbName.Text, cbSubject.SelectedIndex, rtbDescription.Text, dtpDateEnd.Value, 1);
                    dtpDateEnd.Value = DateTime.Now;
                    tbName.Text = string.Empty;
                    cbSubject.SelectedIndex = 0; //error
                    rtbDescription.Text = string.Empty;
                    mainForm.ReloadAllData();
                    mainForm.FormatCells();
                    mainForm.InitDgv();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Пустое поле данных! Введите название задачи.", "Пустое поле", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

            }

        }
    }
}