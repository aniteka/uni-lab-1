namespace uni_lab_1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.studentsGrid = new System.Windows.Forms.DataGridView();
            this.studentDataGrid_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentDataGrid_markA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentDataGrid_markB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentDataGrid_markC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentDataGrid_markD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentDataGrid_markF = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentsDataSave = new System.Windows.Forms.Button();
            this.studentsDataLoad = new System.Windows.Forms.Button();
            this.studentsGenerateLessMarkMenu = new System.Windows.Forms.Button();
            this.lessMarkMenu = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.studentsGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // studentsGrid
            // 
            this.studentsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.studentsGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { this.studentDataGrid_Name, this.studentDataGrid_markA, this.studentDataGrid_markB, this.studentDataGrid_markC, this.studentDataGrid_markD, this.studentDataGrid_markF });
            this.studentsGrid.Location = new System.Drawing.Point(12, 12);
            this.studentsGrid.Name = "studentsGrid";
            this.studentsGrid.Size = new System.Drawing.Size(295, 426);
            this.studentsGrid.TabIndex = 2;
            // 
            // studentDataGrid_Name
            // 
            this.studentDataGrid_Name.HeaderText = "Name";
            this.studentDataGrid_Name.Name = "studentDataGrid_Name";
            // 
            // studentDataGrid_markA
            // 
            this.studentDataGrid_markA.HeaderText = "A";
            this.studentDataGrid_markA.Name = "studentDataGrid_markA";
            this.studentDataGrid_markA.Width = 30;
            // 
            // studentDataGrid_markB
            // 
            this.studentDataGrid_markB.HeaderText = "B";
            this.studentDataGrid_markB.Name = "studentDataGrid_markB";
            this.studentDataGrid_markB.Width = 30;
            // 
            // studentDataGrid_markC
            // 
            this.studentDataGrid_markC.HeaderText = "C";
            this.studentDataGrid_markC.Name = "studentDataGrid_markC";
            this.studentDataGrid_markC.Width = 30;
            // 
            // studentDataGrid_markD
            // 
            this.studentDataGrid_markD.HeaderText = "D";
            this.studentDataGrid_markD.Name = "studentDataGrid_markD";
            this.studentDataGrid_markD.Width = 30;
            // 
            // studentDataGrid_markF
            // 
            this.studentDataGrid_markF.HeaderText = "F";
            this.studentDataGrid_markF.Name = "studentDataGrid_markF";
            this.studentDataGrid_markF.Width = 30;
            // 
            // studentsDataSave
            // 
            this.studentsDataSave.Location = new System.Drawing.Point(313, 12);
            this.studentsDataSave.Name = "studentsDataSave";
            this.studentsDataSave.Size = new System.Drawing.Size(75, 23);
            this.studentsDataSave.TabIndex = 3;
            this.studentsDataSave.Text = "SAVE";
            this.studentsDataSave.UseVisualStyleBackColor = true;
            this.studentsDataSave.Click += new System.EventHandler(this.studentsDataSave_Click);
            // 
            // studentsDataLoad
            // 
            this.studentsDataLoad.Location = new System.Drawing.Point(313, 41);
            this.studentsDataLoad.Name = "studentsDataLoad";
            this.studentsDataLoad.Size = new System.Drawing.Size(75, 23);
            this.studentsDataLoad.TabIndex = 4;
            this.studentsDataLoad.Text = "LOAD";
            this.studentsDataLoad.UseVisualStyleBackColor = true;
            this.studentsDataLoad.Click += new System.EventHandler(this.studentsDataLoad_Click);
            // 
            // studentsGenerateLessMarkMenu
            // 
            this.studentsGenerateLessMarkMenu.Location = new System.Drawing.Point(313, 70);
            this.studentsGenerateLessMarkMenu.Name = "studentsGenerateLessMarkMenu";
            this.studentsGenerateLessMarkMenu.Size = new System.Drawing.Size(75, 23);
            this.studentsGenerateLessMarkMenu.TabIndex = 5;
            this.studentsGenerateLessMarkMenu.Text = "GENERATE";
            this.studentsGenerateLessMarkMenu.UseVisualStyleBackColor = true;
            this.studentsGenerateLessMarkMenu.Click += new System.EventHandler(this.studentsGenerateLessMarkMenu_Click);
            // 
            // lessMarkMenu
            // 
            this.lessMarkMenu.Location = new System.Drawing.Point(394, 12);
            this.lessMarkMenu.Name = "lessMarkMenu";
            this.lessMarkMenu.Size = new System.Drawing.Size(222, 426);
            this.lessMarkMenu.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(628, 450);
            this.Controls.Add(this.lessMarkMenu);
            this.Controls.Add(this.studentsGenerateLessMarkMenu);
            this.Controls.Add(this.studentsDataLoad);
            this.Controls.Add(this.studentsDataSave);
            this.Controls.Add(this.studentsGrid);
            this.Location = new System.Drawing.Point(15, 15);
            this.Name = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.studentsGrid)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Label lessMarkMenu;

        private System.Windows.Forms.Button studentsGenerateLessMarkMenu;

        private System.Windows.Forms.Button studentsDataSave;
        private System.Windows.Forms.Button studentsDataLoad;

        private System.Windows.Forms.DataGridViewTextBoxColumn studentDataGrid_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentDataGrid_markA;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentDataGrid_markB;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentDataGrid_markC;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentDataGrid_markD;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentDataGrid_markF;

        private System.Windows.Forms.DataGridView studentsGrid;

        #endregion
    }
}