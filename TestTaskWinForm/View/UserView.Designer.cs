namespace TestTaskWinForm
{
    partial class UserView
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.DataGridView dataGridViewUsers;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            textBoxName = new TextBox();
            buttonSave = new Button();
            buttonUpdate = new Button();
            buttonDelete = new Button();
            dataGridViewUsers = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridViewUsers).BeginInit();
            SuspendLayout();
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(12, 12);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(150, 30);
            textBoxName.TabIndex = 0;
            // 
            // buttonSave
            // 
            buttonSave.Location = new Point(170, 10);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(100, 30);
            buttonSave.TabIndex = 1;
            buttonSave.Text = "Save";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // buttonUpdate
            // 
            buttonUpdate.Location = new Point(280, 10);
            buttonUpdate.Name = "buttonUpdate";
            buttonUpdate.Size = new Size(100, 30);
            buttonUpdate.TabIndex = 2;
            buttonUpdate.Text = "Update";
            buttonUpdate.UseVisualStyleBackColor = true;
            buttonUpdate.Click += buttonUpdate_Click;
            // 
            // buttonDelete
            // 
            buttonDelete.Location = new Point(390, 10);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(100, 30);
            buttonDelete.TabIndex = 3;
            buttonDelete.Text = "Delete";
            buttonDelete.UseVisualStyleBackColor = true;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // dataGridViewUsers
            // 
            dataGridViewUsers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewUsers.Location = new Point(12, 50);
            dataGridViewUsers.Name = "dataGridViewUsers";
            dataGridViewUsers.RowHeadersWidth = 51;
            dataGridViewUsers.Size = new Size(480, 200);
            dataGridViewUsers.TabIndex = 4;
            dataGridViewUsers.SelectionChanged += dataGridViewUsers_SelectionChanged;
            // 
            // UserView
            // 
            ClientSize = new Size(520, 270);
            Controls.Add(dataGridViewUsers);
            Controls.Add(buttonDelete);
            Controls.Add(buttonUpdate);
            Controls.Add(buttonSave);
            Controls.Add(textBoxName);
            Name = "UserView";
            Text = "User Management";
            Load += UserView_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewUsers).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
