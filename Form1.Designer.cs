namespace TaskManager
{
    partial class frmMain
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvTodo = new System.Windows.Forms.DataGridView();
            this.dgvInprocess = new System.Windows.Forms.DataGridView();
            this.dgvComplete = new System.Windows.Forms.DataGridView();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnSubject = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTodo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInprocess)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvComplete)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvTodo
            // 
            this.dgvTodo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTodo.Location = new System.Drawing.Point(9, 46);
            this.dgvTodo.Margin = new System.Windows.Forms.Padding(4);
            this.dgvTodo.Name = "dgvTodo";
            this.dgvTodo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvTodo.Size = new System.Drawing.Size(399, 502);
            this.dgvTodo.TabIndex = 0;
            this.dgvTodo.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvTodo_CellMouseDoubleClick);
            // 
            // dgvInprocess
            // 
            this.dgvInprocess.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInprocess.Location = new System.Drawing.Point(464, 46);
            this.dgvInprocess.Margin = new System.Windows.Forms.Padding(4);
            this.dgvInprocess.Name = "dgvInprocess";
            this.dgvInprocess.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvInprocess.Size = new System.Drawing.Size(399, 502);
            this.dgvInprocess.TabIndex = 1;
            this.dgvInprocess.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvInprocess_CellMouseDoubleClick);
            // 
            // dgvComplete
            // 
            this.dgvComplete.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvComplete.Location = new System.Drawing.Point(915, 46);
            this.dgvComplete.Margin = new System.Windows.Forms.Padding(4);
            this.dgvComplete.Name = "dgvComplete";
            this.dgvComplete.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvComplete.Size = new System.Drawing.Size(399, 502);
            this.dgvComplete.TabIndex = 2;
            this.dgvComplete.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvComplete_CellMouseDoubleClick);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(9, 558);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(320, 28);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "Новая задача";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnSubject
            // 
            this.btnSubject.Location = new System.Drawing.Point(403, 558);
            this.btnSubject.Margin = new System.Windows.Forms.Padding(4);
            this.btnSubject.Name = "btnSubject";
            this.btnSubject.Size = new System.Drawing.Size(146, 28);
            this.btnSubject.TabIndex = 4;
            this.btnSubject.Text = "Новый предмет";
            this.btnSubject.UseVisualStyleBackColor = true;
            this.btnSubject.Click += new System.EventHandler(this.btnSubject_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 24);
            this.label1.TabIndex = 5;
            this.label1.Text = "Не начато";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(460, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(228, 24);
            this.label2.TabIndex = 6;
            this.label2.Text = "В процессе выполнения";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(911, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 24);
            this.label3.TabIndex = 7;
            this.label3.Text = "Выполнено";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1327, 599);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSubject);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dgvComplete);
            this.Controls.Add(this.dgvInprocess);
            this.Controls.Add(this.dgvTodo);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.Text = "TaskManager";
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTodo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInprocess)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvComplete)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnSubject;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvTodo;
        private System.Windows.Forms.DataGridView dgvInprocess;
        private System.Windows.Forms.DataGridView dgvComplete;
    }
}

