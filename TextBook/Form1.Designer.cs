namespace TextBook
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            listStudent = new ListBox();
            studentBindingSource = new BindingSource(components);
            txtStudent = new TextBox();
            listTextbook = new ListBox();
            textbookBindingSource = new BindingSource(components);
            txtTextbook = new TextBox();
            listOrder = new ListBox();
            button1 = new Button();
            button2 = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            checkBox1 = new CheckBox();
            osztályBindingSource = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)studentBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)textbookBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)osztályBindingSource).BeginInit();
            SuspendLayout();
            // 
            // listStudent
            // 
            listStudent.DataSource = studentBindingSource;
            listStudent.DisplayMember = "Name";
            listStudent.FormattingEnabled = true;
            listStudent.Location = new Point(12, 56);
            listStudent.Name = "listStudent";
            listStudent.Size = new Size(222, 349);
            listStudent.TabIndex = 0;
            // 
            // studentBindingSource
            // 
            studentBindingSource.DataSource = typeof(Models.Student);
            studentBindingSource.CurrentChanged += studentBindingSource_CurrentChanged;
            // 
            // txtStudent
            // 
            txtStudent.Location = new Point(12, 27);
            txtStudent.Name = "txtStudent";
            txtStudent.Size = new Size(222, 23);
            txtStudent.TabIndex = 1;
            txtStudent.TextChanged += txtStudent_TextChanged;
            // 
            // listTextbook
            // 
            listTextbook.DataSource = textbookBindingSource;
            listTextbook.DisplayMember = "Title";
            listTextbook.FormattingEnabled = true;
            listTextbook.Location = new Point(556, 56);
            listTextbook.Name = "listTextbook";
            listTextbook.Size = new Size(222, 349);
            listTextbook.TabIndex = 0;
            // 
            // textbookBindingSource
            // 
            textbookBindingSource.DataSource = typeof(Models.Textbook);
            // 
            // txtTextbook
            // 
            txtTextbook.Location = new Point(556, 27);
            txtTextbook.Name = "txtTextbook";
            txtTextbook.Size = new Size(222, 23);
            txtTextbook.TabIndex = 1;
            // 
            // listOrder
            // 
            listOrder.DataSource = osztályBindingSource;
            listOrder.DisplayMember = "Könyvc0m";
            listOrder.FormattingEnabled = true;
            listOrder.Location = new Point(240, 56);
            listOrder.Name = "listOrder";
            listOrder.Size = new Size(222, 349);
            listOrder.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(475, 112);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 2;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(475, 141);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 3;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.DataBindings.Add(new Binding("Text", textbookBindingSource, "StockNumber", true));
            textBox1.Location = new Point(784, 56);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(169, 23);
            textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            textBox2.DataBindings.Add(new Binding("Text", textbookBindingSource, "Price", true));
            textBox2.Location = new Point(784, 85);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(169, 23);
            textBox2.TabIndex = 4;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.DataBindings.Add(new Binding("Checked", textbookBindingSource, "NotAvailable", true));
            checkBox1.Location = new Point(784, 116);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(82, 19);
            checkBox1.TabIndex = 5;
            checkBox1.Text = "checkBox1";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // osztályBindingSource
            // 
            osztályBindingSource.DataSource = typeof(Osztály);
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(989, 450);
            Controls.Add(checkBox1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(txtTextbook);
            Controls.Add(txtStudent);
            Controls.Add(listTextbook);
            Controls.Add(listOrder);
            Controls.Add(listStudent);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)studentBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)textbookBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)osztályBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listStudent;
        private TextBox txtStudent;
        private ListBox listTextbook;
        private TextBox txtTextbook;
        private ListBox listOrder;
        private Button button1;
        private Button button2;
        private BindingSource studentBindingSource;
        private BindingSource textbookBindingSource;
        private TextBox textBox1;
        private TextBox textBox2;
        private CheckBox checkBox1;
        private BindingSource osztályBindingSource;
    }
}
