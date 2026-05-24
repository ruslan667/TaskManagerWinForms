using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TaskManager
{
    public partial class Form1 : Form
    {
        private List<Task> tasks = new List<Task>();
        private int nextId = 1;
        private int currentTaskIndex = -1;
        public Form1()
        {
            InitializeComponent();

            cmbPriority.Items.AddRange(new string[] { "Низкий", "Средний", "Высокий" });
            cmbPriority.SelectedIndex = 1;

            cmbSort.Items.AddRange(new string[] { "Дате выполнения", "Приоритету", "Названию" });
            cmbSort.SelectedIndex = 0;

            dtpDueDate.Value = DateTime.Today;

            lstTasks.SelectedIndexChanged += lstTasks_SelectedIndexChanged;
            btnAdd.Click += btnAdd_Click;
            btnEdit.Click += btnEdit_Click;
            btnDelete.Click += btnDelete_Click;
            btnClear.Click += btnClear_Click;
            btnComplete.Click += btnComplete_Click;

            chkHideOverdue.CheckedChanged += chkHideOverdue_CheckedChanged;
            chkShowCompleted.CheckedChanged += chkShowCompleted_CheckedChanged;
            cmbSort.SelectedIndexChanged += cmbSort_SelectedIndexChanged;

            lstTasks.DrawMode = DrawMode.OwnerDrawFixed;
            lstTasks.DrawItem += lstTasks_DrawItem;
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTitle.Text))
            {
                MessageBox.Show("Введите название задачи");
                return;
            }

            Task task = new Task
            {
                Id = nextId++,
                Title = txtTitle.Text,
                Description = txtDescription.Text,
                DueDate = dtpDueDate.Value,
                Priority = (TaskPriority)cmbPriority.SelectedIndex,
                IsCompleted = false
            };

            tasks.Add(task);

            RefreshTaskList();

            ClearFields();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (lstTasks.SelectedItem == null)
            {
                MessageBox.Show("Выберите задачу");
                return;
            }

            Task task = (Task)lstTasks.SelectedItem;

            task.Title = txtTitle.Text;
            task.Description = txtDescription.Text;
            task.DueDate = dtpDueDate.Value;
            task.Priority = (TaskPriority)cmbPriority.SelectedIndex;

            RefreshTaskList();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lstTasks.SelectedItem == null)
            {
                MessageBox.Show("Выберите задачу");
                return;
            }

            Task task = (Task)lstTasks.SelectedItem;

            tasks.Remove(task);

            RefreshTaskList();

            ClearFields();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void RefreshTaskList()
        {
            lstTasks.Items.Clear();

            IEnumerable<Task> filteredTasks = tasks;

            if (chkShowCompleted.Checked)
            {
                filteredTasks = filteredTasks.Where(t => t.IsCompleted);
            }

            if (chkHideOverdue.Checked)
            {
                filteredTasks = filteredTasks.Where(t =>
                    !t.IsOverdue());
            }

            switch (cmbSort.SelectedIndex)
            {
                case 0:
                    filteredTasks = filteredTasks.OrderBy(t => t.DueDate);
                    break;

                case 1:
                    filteredTasks = filteredTasks.OrderBy(t => t.Priority);
                    break;

                case 2:
                    filteredTasks = filteredTasks.OrderBy(t => t.Title);
                    break;
            }

            foreach (Task task in filteredTasks)
            {
                lstTasks.Items.Add(task);
            }
        }

        private void ClearFields()
        {
            txtTitle.Clear();

            txtDescription.Clear();

            cmbPriority.SelectedIndex = 1;

            dtpDueDate.Value = DateTime.Today;
        }

        private void lstTasks_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstTasks.SelectedItem == null)
            {
                return;
            }

            Task task = (Task)lstTasks.SelectedItem;

            txtTitle.Text = task.Title;
            txtDescription.Text = task.Description;
            dtpDueDate.Value = task.DueDate;

            cmbPriority.SelectedIndex = (int)task.Priority;
        }

        private void lstTasks_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (e.Index < 0)
            {
                return;
            }

            Task task = (Task)lstTasks.Items[e.Index];

            e.DrawBackground();

            Color color = Color.Black;

            if (task.IsOverdue())
            {
                color = Color.Red;
            }

            using (Brush brush = new SolidBrush(color))
            {
                string text;

                if (task.IsCompleted)
                {
                    text = $"ВЫПОЛНЕНО - {task.Title} ({task.DueDate:dd.MM.yyyy}, {task.Priority})";
                }
                else
                {
                    text = $"{task.Title} ({task.DueDate:dd.MM.yyyy}, {task.Priority})";
                }
                e.Graphics.DrawString(
                    text,
                    e.Font,
                    brush,
                    e.Bounds);
            }
            
            e.DrawFocusRectangle();
        }

        private void chkHideOverdue_CheckedChanged(object sender, EventArgs e)
        {
            RefreshTaskList();
        }

        private void chkShowCompleted_CheckedChanged(object sender, EventArgs e)
        {
            RefreshTaskList();
        }

        private void cmbSort_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshTaskList();
        }

        private void btnClear_Click_1(object sender, EventArgs e)
        {

        }
        private void btnComplete_Click(object sender, EventArgs e)
        {
            if (lstTasks.SelectedItem == null)
            {
                MessageBox.Show("Выберите задачу");
                return;
            }

            Task task = (Task)lstTasks.SelectedItem;

            task.IsCompleted = true;

            RefreshTaskList();
        }
    }
}
