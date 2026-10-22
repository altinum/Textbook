namespace TextBook
{
    partial class FormAddStudent
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
            components = new System.ComponentModel.Container();
            buttonOk = new Button();
            buttonCancel = new Button();
            label1 = new Label();
            label2 = new Label();
            textBoxName = new TextBox();
            studentBindingSource = new BindingSource(components);
            label3 = new Label();
            textBoxNeptun = new TextBox();
            toolTip1 = new ToolTip(components);
            ((System.ComponentModel.ISupportInitialize)studentBindingSource).BeginInit();
            SuspendLayout();
            // 
            // buttonOk
            // 
            buttonOk.DialogResult = DialogResult.OK;
            buttonOk.Location = new Point(458, 198);
            buttonOk.Name = "buttonOk";
            buttonOk.Size = new Size(75, 23);
            buttonOk.TabIndex = 0;
            buttonOk.Text = "&Ok";
            buttonOk.UseVisualStyleBackColor = true;
            // 
            // buttonCancel
            // 
            buttonCancel.DialogResult = DialogResult.Cancel;
            buttonCancel.Location = new Point(377, 198);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(75, 23);
            buttonCancel.TabIndex = 1;
            buttonCancel.Text = "&Cancel";
            buttonCancel.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(191, 30);
            label1.TabIndex = 2;
            label1.Text = "Add new student";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 51);
            label2.Name = "label2";
            label2.Size = new Size(42, 15);
            label2.TabIndex = 3;
            label2.Text = "Name:";
            // 
            // textBoxName
            // 
            textBoxName.DataBindings.Add(new Binding("Text", studentBindingSource, "Name", true));
            textBoxName.Location = new Point(12, 69);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(521, 23);
            textBoxName.TabIndex = 4;
            textBoxName.TextChanged += textBox_TextChanged;
            // 
            // studentBindingSource
            // 
            studentBindingSource.DataSource = typeof(Models.Student);
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 108);
            label3.Name = "label3";
            label3.Size = new Size(50, 15);
            label3.TabIndex = 3;
            label3.Text = "Neptun:";
            // 
            // textBoxNeptun
            // 
            textBoxNeptun.Location = new Point(12, 126);
            textBoxNeptun.Name = "textBoxNeptun";
            textBoxNeptun.Size = new Size(521, 23);
            textBoxNeptun.TabIndex = 4;
            toolTip1.SetToolTip(textBoxNeptun, "Csupa nagy betű");
            textBoxNeptun.TextChanged += textBox_TextChanged;
            // 
            // FormAddStudent
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(545, 233);
            Controls.Add(textBoxNeptun);
            Controls.Add(label3);
            Controls.Add(textBoxName);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(buttonCancel);
            Controls.Add(buttonOk);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "FormAddStudent";
            Text = "FormAddStudent";
            Load += FormAddStudent_Load;
            ((System.ComponentModel.ISupportInitialize)studentBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonOk;
        private Button buttonCancel;
        private Label label1;
        private Label label2;
        private Label label3;
        public TextBox textBoxName;
        public TextBox textBoxNeptun;
        private BindingSource studentBindingSource;
        private ToolTip toolTip1;
    }
}