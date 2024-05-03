namespace MaU_CSharp6
{
    partial class MainForm
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
            lstToDo = new ListBox();
            groupBox1 = new GroupBox();
            label7 = new Label();
            label4 = new Label();
            label6 = new Label();
            label5 = new Label();
            dtpDateTime = new DateTimePicker();
            cmbPriority = new ComboBox();
            btnAdd = new Button();
            txtToDo = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            button2 = new Button();
            button3 = new Button();
            menuStrip1 = new MenuStrip();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // lstToDo
            // 
            lstToDo.FormattingEnabled = true;
            lstToDo.ItemHeight = 15;
            lstToDo.Location = new Point(6, 42);
            lstToDo.Name = "lstToDo";
            lstToDo.Size = new Size(812, 184);
            lstToDo.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(lstToDo);
            groupBox1.Controls.Add(label5);
            groupBox1.Location = new Point(12, 152);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(824, 241);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "To Do";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(370, 19);
            label7.Name = "label7";
            label7.Size = new Size(67, 15);
            label7.TabIndex = 11;
            label7.Text = "Description";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(7, 19);
            label4.Name = "label4";
            label4.Size = new Size(31, 15);
            label4.TabIndex = 9;
            label4.Text = "Date";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(274, 19);
            label6.Name = "label6";
            label6.Size = new Size(45, 15);
            label6.TabIndex = 10;
            label6.Text = "Priority";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(183, 19);
            label5.Name = "label5";
            label5.Size = new Size(34, 15);
            label5.TabIndex = 9;
            label5.Text = "Hour";
            // 
            // dtpDateTime
            // 
            dtpDateTime.Location = new Point(110, 23);
            dtpDateTime.Name = "dtpDateTime";
            dtpDateTime.Size = new Size(200, 23);
            dtpDateTime.TabIndex = 2;
            // 
            // cmbPriority
            // 
            cmbPriority.FormattingEnabled = true;
            cmbPriority.Location = new Point(406, 23);
            cmbPriority.Name = "cmbPriority";
            cmbPriority.Size = new Size(121, 23);
            cmbPriority.TabIndex = 3;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(195, 111);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(115, 23);
            btnAdd.TabIndex = 4;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // txtToDo
            // 
            txtToDo.Location = new Point(110, 70);
            txtToDo.Name = "txtToDo";
            txtToDo.Size = new Size(417, 23);
            txtToDo.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(19, 29);
            label1.Name = "label1";
            label1.Size = new Size(83, 15);
            label1.TabIndex = 6;
            label1.Text = "Date and Time";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(19, 73);
            label2.Name = "label2";
            label2.Size = new Size(64, 15);
            label2.TabIndex = 7;
            label2.Text = "To Do Item";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(335, 29);
            label3.Name = "label3";
            label3.Size = new Size(45, 15);
            label3.TabIndex = 8;
            label3.Text = "Priority";
            // 
            // button2
            // 
            button2.Location = new Point(61, 411);
            button2.Name = "button2";
            button2.Size = new Size(115, 23);
            button2.TabIndex = 9;
            button2.Text = "Edit";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(265, 411);
            button3.Name = "button3";
            button3.Size = new Size(115, 23);
            button3.TabIndex = 10;
            button3.Text = "Cancel";
            button3.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(848, 24);
            menuStrip1.TabIndex = 11;
            menuStrip1.Text = "menuStrip1";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(848, 460);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtToDo);
            Controls.Add(btnAdd);
            Controls.Add(cmbPriority);
            Controls.Add(dtpDateTime);
            Controls.Add(groupBox1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "MainForm";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lstToDo;
        private GroupBox groupBox1;
        private DateTimePicker dtpDateTime;
        private ComboBox cmbPriority;
        private Button btnAdd;
        private TextBox txtToDo;
        private Label label4;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label5;
        private Label label6;
        private Label label7;
        private Button button2;
        private Button button3;
        private MenuStrip menuStrip1;
    }
}
