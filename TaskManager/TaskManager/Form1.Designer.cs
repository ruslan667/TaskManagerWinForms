namespace TaskManager
{
    partial class Form1
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
            this.gbData = new System.Windows.Forms.GroupBox();
            this.cmbPriority = new System.Windows.Forms.ComboBox();
            this.lblPriority = new System.Windows.Forms.Label();
            this.dtpDueDate = new System.Windows.Forms.DateTimePicker();
            this.lblDate = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.lblDesc = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.gbActions = new System.Windows.Forms.GroupBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.gbFilters = new System.Windows.Forms.GroupBox();
            this.chkHideOverdue = new System.Windows.Forms.CheckBox();
            this.chkShowCompleted = new System.Windows.Forms.CheckBox();
            this.lblSort = new System.Windows.Forms.Label();
            this.lstTasks = new System.Windows.Forms.ListBox();
            this.cmbSort = new System.Windows.Forms.ComboBox();
            this.btnComplete = new System.Windows.Forms.Button();
            this.gbData.SuspendLayout();
            this.gbActions.SuspendLayout();
            this.gbFilters.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbData
            // 
            this.gbData.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbData.Controls.Add(this.cmbPriority);
            this.gbData.Controls.Add(this.lblPriority);
            this.gbData.Controls.Add(this.dtpDueDate);
            this.gbData.Controls.Add(this.lblDate);
            this.gbData.Controls.Add(this.txtDescription);
            this.gbData.Controls.Add(this.lblDesc);
            this.gbData.Controls.Add(this.txtTitle);
            this.gbData.Controls.Add(this.lblTitle);
            this.gbData.Font = new System.Drawing.Font("Segoe UI", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbData.Location = new System.Drawing.Point(20, 20);
            this.gbData.Name = "gbData";
            this.gbData.Size = new System.Drawing.Size(740, 310);
            this.gbData.TabIndex = 0;
            this.gbData.TabStop = false;
            this.gbData.Text = "Данные задачи";
            // 
            // cmbPriority
            // 
            this.cmbPriority.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbPriority.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPriority.FormattingEnabled = true;
            this.cmbPriority.Location = new System.Drawing.Point(497, 246);
            this.cmbPriority.Name = "cmbPriority";
            this.cmbPriority.Size = new System.Drawing.Size(121, 45);
            this.cmbPriority.TabIndex = 7;
            // 
            // lblPriority
            // 
            this.lblPriority.AutoSize = true;
            this.lblPriority.Location = new System.Drawing.Point(279, 249);
            this.lblPriority.Name = "lblPriority";
            this.lblPriority.Size = new System.Drawing.Size(169, 37);
            this.lblPriority.TabIndex = 6;
            this.lblPriority.Text = "Приоритет:";
            // 
            // dtpDueDate
            // 
            this.dtpDueDate.Location = new System.Drawing.Point(276, 193);
            this.dtpDueDate.Name = "dtpDueDate";
            this.dtpDueDate.Size = new System.Drawing.Size(464, 43);
            this.dtpDueDate.TabIndex = 5;
            // 
            // lblDate
            // 
            this.lblDate.Location = new System.Drawing.Point(20, 195);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(269, 41);
            this.lblDate.TabIndex = 4;
            this.lblDate.Text = "Дата выполнения:";
            // 
            // txtDescription
            // 
            this.txtDescription.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDescription.Location = new System.Drawing.Point(175, 91);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDescription.Size = new System.Drawing.Size(542, 31);
            this.txtDescription.TabIndex = 3;
            // 
            // lblDesc
            // 
            this.lblDesc.Location = new System.Drawing.Point(20, 84);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(157, 34);
            this.lblDesc.TabIndex = 2;
            this.lblDesc.Text = "Описание:";
            // 
            // txtTitle
            // 
            this.txtTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTitle.Location = new System.Drawing.Point(174, 38);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(542, 43);
            this.txtTitle.TabIndex = 1;
            // 
            // lblTitle
            // 
            this.lblTitle.Location = new System.Drawing.Point(20, 38);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(157, 35);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Название:";
            // 
            // gbActions
            // 
            this.gbActions.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gbActions.Controls.Add(this.btnComplete);
            this.gbActions.Controls.Add(this.btnClear);
            this.gbActions.Controls.Add(this.btnDelete);
            this.gbActions.Controls.Add(this.btnEdit);
            this.gbActions.Controls.Add(this.btnAdd);
            this.gbActions.Font = new System.Drawing.Font("Segoe UI", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbActions.Location = new System.Drawing.Point(780, 20);
            this.gbActions.Name = "gbActions";
            this.gbActions.Size = new System.Drawing.Size(450, 310);
            this.gbActions.TabIndex = 1;
            this.gbActions.TabStop = false;
            this.gbActions.Text = "Действия";
            // 
            // btnClear
            // 
            this.btnClear.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClear.Location = new System.Drawing.Point(20, 210);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(410, 45);
            this.btnClear.TabIndex = 3;
            this.btnClear.Text = "Очистить поля";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click_1);
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.BackColor = System.Drawing.Color.LightCoral;
            this.btnDelete.Location = new System.Drawing.Point(20, 150);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(410, 45);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Удалить выбранные";
            this.btnDelete.UseVisualStyleBackColor = false;
            // 
            // btnEdit
            // 
            this.btnEdit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEdit.Location = new System.Drawing.Point(20, 90);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(410, 45);
            this.btnEdit.TabIndex = 1;
            this.btnEdit.Text = "Редактировать";
            this.btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.BackColor = System.Drawing.Color.LightGreen;
            this.btnAdd.Location = new System.Drawing.Point(20, 30);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(410, 45);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Добавить";
            this.btnAdd.UseVisualStyleBackColor = false;
            // 
            // gbFilters
            // 
            this.gbFilters.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbFilters.Controls.Add(this.chkHideOverdue);
            this.gbFilters.Controls.Add(this.chkShowCompleted);
            this.gbFilters.Controls.Add(this.lblSort);
            this.gbFilters.Font = new System.Drawing.Font("Segoe UI", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbFilters.Location = new System.Drawing.Point(20, 350);
            this.gbFilters.Name = "gbFilters";
            this.gbFilters.Size = new System.Drawing.Size(1210, 90);
            this.gbFilters.TabIndex = 2;
            this.gbFilters.TabStop = false;
            this.gbFilters.Text = "Сортировка и фильтры";
            // 
            // chkHideOverdue
            // 
            this.chkHideOverdue.AutoSize = true;
            this.chkHideOverdue.Location = new System.Drawing.Point(517, 48);
            this.chkHideOverdue.Name = "chkHideOverdue";
            this.chkHideOverdue.Size = new System.Drawing.Size(354, 41);
            this.chkHideOverdue.TabIndex = 2;
            this.chkHideOverdue.Text = "Скрыть просроченные";
            this.chkHideOverdue.UseVisualStyleBackColor = true;
            // 
            // chkShowCompleted
            // 
            this.chkShowCompleted.AutoSize = true;
            this.chkShowCompleted.Location = new System.Drawing.Point(517, 0);
            this.chkShowCompleted.Name = "chkShowCompleted";
            this.chkShowCompleted.Size = new System.Drawing.Size(408, 41);
            this.chkShowCompleted.TabIndex = 1;
            this.chkShowCompleted.Text = "Показывать выполненные";
            this.chkShowCompleted.UseVisualStyleBackColor = true;
            // 
            // lblSort
            // 
            this.lblSort.AutoSize = true;
            this.lblSort.Location = new System.Drawing.Point(20, 50);
            this.lblSort.Name = "lblSort";
            this.lblSort.Size = new System.Drawing.Size(237, 37);
            this.lblSort.TabIndex = 0;
            this.lblSort.Text = "Сортировать по:";
            // 
            // lstTasks
            // 
            this.lstTasks.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstTasks.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.lstTasks.FormattingEnabled = true;
            this.lstTasks.IntegralHeight = false;
            this.lstTasks.Location = new System.Drawing.Point(20, 460);
            this.lstTasks.Name = "lstTasks";
            this.lstTasks.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lstTasks.Size = new System.Drawing.Size(1210, 324);
            this.lstTasks.TabIndex = 3;
            this.lstTasks.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.lstTasks_DrawItem);
            // 
            // cmbSort
            // 
            this.cmbSort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSort.FormattingEnabled = true;
            this.cmbSort.Location = new System.Drawing.Point(283, 400);
            this.cmbSort.Name = "cmbSort";
            this.cmbSort.Size = new System.Drawing.Size(168, 40);
            this.cmbSort.TabIndex = 1;
            // 
            // btnComplete
            // 
            this.btnComplete.Location = new System.Drawing.Point(20, 265);
            this.btnComplete.Name = "btnComplete";
            this.btnComplete.Size = new System.Drawing.Size(410, 45);
            this.btnComplete.TabIndex = 4;
            this.btnComplete.Text = "Отметить выполненной";
            this.btnComplete.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1224, 909);
            this.Controls.Add(this.cmbSort);
            this.Controls.Add(this.lstTasks);
            this.Controls.Add(this.gbFilters);
            this.Controls.Add(this.gbActions);
            this.Controls.Add(this.gbData);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TaskManager — Управление задачами";
            this.gbData.ResumeLayout(false);
            this.gbData.PerformLayout();
            this.gbActions.ResumeLayout(false);
            this.gbFilters.ResumeLayout(false);
            this.gbFilters.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbData;
        private System.Windows.Forms.GroupBox gbActions;
        private System.Windows.Forms.GroupBox gbFilters;
        private System.Windows.Forms.ListBox lstTasks;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Label lblDesc;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label lblPriority;
        private System.Windows.Forms.DateTimePicker dtpDueDate;
        private System.Windows.Forms.ComboBox cmbPriority;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.CheckBox chkShowCompleted;
        private System.Windows.Forms.Label lblSort;
        private System.Windows.Forms.ComboBox cmbSort;
        private System.Windows.Forms.CheckBox chkHideOverdue;
        private System.Windows.Forms.Button btnComplete;
    }
}

