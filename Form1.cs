using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace TaskManager
{
    public partial class frmMain : Form
    {
        private const string dbPath = "database";
        private List<SimpleTasksView> todoView = new List<SimpleTasksView>();
        private List<SimpleTasksView> inProcessView = new List<SimpleTasksView>();
        private List<SimpleTasksView> completeView = new List<SimpleTasksView>();

        public frmMain()
        {
            InitializeComponent();
            DatabaseInitializer.EnsureDatabaseFileExists();
        }

        private void dgv_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 3 && e.Value != null)
            {
                string text = e.Value.ToString();
                int maxLength = 11;
                if (text.Length > maxLength)
                {
                    e.Value = text.Substring(0, maxLength);
                    e.FormattingApplied = true;
                }
            }
        }
        public void ReloadAllData()
        {
            try
            {
                todoView = DataLoader.LoadSimpleTodoView(dbPath);
                inProcessView = DataLoader.LoadSimpleInProcessView(dbPath);
                completeView = DataLoader.LoadSimpleCompleteView(dbPath);

                dgvTodo.DataSource = null;
                dgvTodo.DataSource = todoView;

                dgvInprocess.DataSource = null;
                dgvInprocess.DataSource = inProcessView;

                dgvComplete.DataSource = null;
                dgvComplete.DataSource = completeView;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка загрузки данных: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void InitDgvBasic(DataGridView dgv)
        {
            dgv.RowHeadersVisible = false;
            dgv.Columns[0].Width = 30;
            dgv.Columns[1].Width = 145;
            dgv.Columns[2].Width = 120;
            dgv.Columns[3].Width = 100;

            dgv.Columns[0].HeaderCell.Value = "#";
            dgv.Columns[1].HeaderCell.Value = "Название";
            dgv.Columns[2].HeaderCell.Value = "Предмет";
            dgv.Columns[3].HeaderCell.Value = "Дата выполнения";
        }

        public void InitDgv()
        {
            InitDgvBasic(dgvComplete);
            InitDgvBasic(dgvInprocess);
            InitDgvBasic(dgvTodo);
        }

        public void FormatCells()
        {
            dgvTodo.CellFormatting += dgv_CellFormatting;
            dgvInprocess.CellFormatting += dgv_CellFormatting;
            dgvComplete.CellFormatting += dgv_CellFormatting;
        }
        private void frmMain_Load(object sender, EventArgs e)
        {
            FormatCells();
            ReloadAllData();

            InitDgv();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmDetails detailsForm = new frmDetails(this, 0, dbPath, 1);
            detailsForm.ShowDialog();
        }

        private void dgvTodo_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int Id = Convert.ToInt32(dgvTodo.Rows[e.RowIndex].Cells["Id"].Value);

                frmDetails detailsForm = new frmDetails(this, Id, dbPath, 0);
                detailsForm.ShowDialog();
            }
        }

        private void btnSubject_Click(object sender, EventArgs e)
        {
            frmSubjects frmSubjects = new frmSubjects(dbPath);
            frmSubjects.ShowDialog();
        }

        private void dgvInprocess_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int Id = Convert.ToInt32(dgvInprocess.Rows[e.RowIndex].Cells["Id"].Value);

                frmDetails detailsForm = new frmDetails(this, Id, dbPath, 0);
                detailsForm.ShowDialog();
            }
        }

        private void dgvComplete_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int Id = Convert.ToInt32(dgvComplete.Rows[e.RowIndex].Cells["Id"].Value);

                frmDetails detailsForm = new frmDetails(this, Id, dbPath, 0);
                detailsForm.ShowDialog();
            }
        }
    }
}
