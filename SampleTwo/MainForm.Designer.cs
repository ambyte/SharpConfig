namespace SampleTwo
{
    partial class MainForm
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
            this.bLoad = new System.Windows.Forms.Button();
            this.bSave = new System.Windows.Forms.Button();
            this.checkBox1One = new System.Windows.Forms.CheckBox();
            this.checkBox2One = new System.Windows.Forms.CheckBox();
            this.listBoxOne = new System.Windows.Forms.ListBox();
            this.textBox1One = new System.Windows.Forms.TextBox();
            this.textBox2One = new System.Windows.Forms.TextBox();
            this.tbValueForListBoxOne = new System.Windows.Forms.TextBox();
            this.bAddToListBoxOne = new System.Windows.Forms.Button();
            this.bRemoveFromListBoxOne = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.listBoxTwo = new System.Windows.Forms.ListBox();
            this.bRemoveFromListBoxTwo = new System.Windows.Forms.Button();
            this.checkBox1Two = new System.Windows.Forms.CheckBox();
            this.bAddToListBoxTwo = new System.Windows.Forms.Button();
            this.checkBox2Two = new System.Windows.Forms.CheckBox();
            this.tbValueForListBoxTwo = new System.Windows.Forms.TextBox();
            this.textBox1Two = new System.Windows.Forms.TextBox();
            this.textBox2Two = new System.Windows.Forms.TextBox();
            this.bSaveBinary = new System.Windows.Forms.Button();
            this.bLoadBinary = new System.Windows.Forms.Button();
            this.bSaveSecure = new System.Windows.Forms.Button();
            this.bLoadSecure = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // bLoad
            // 
            this.bLoad.Location = new System.Drawing.Point(316, 197);
            this.bLoad.Name = "bLoad";
            this.bLoad.Size = new System.Drawing.Size(78, 23);
            this.bLoad.TabIndex = 0;
            this.bLoad.Text = "Load";
            this.bLoad.UseVisualStyleBackColor = true;
            this.bLoad.Click += new System.EventHandler(this.bLoad_Click);
            // 
            // bSave
            // 
            this.bSave.Location = new System.Drawing.Point(400, 197);
            this.bSave.Name = "bSave";
            this.bSave.Size = new System.Drawing.Size(78, 23);
            this.bSave.TabIndex = 1;
            this.bSave.Text = "Save";
            this.bSave.UseVisualStyleBackColor = true;
            this.bSave.Click += new System.EventHandler(this.bSave_Click);
            // 
            // checkBox1One
            // 
            this.checkBox1One.AutoSize = true;
            this.checkBox1One.Location = new System.Drawing.Point(138, 27);
            this.checkBox1One.Name = "checkBox1One";
            this.checkBox1One.Size = new System.Drawing.Size(80, 17);
            this.checkBox1One.TabIndex = 3;
            this.checkBox1One.Text = "checkBox1";
            this.checkBox1One.UseVisualStyleBackColor = true;
            this.checkBox1One.CheckedChanged += new System.EventHandler(this.checkBox1One_CheckedChanged);
            // 
            // checkBox2One
            // 
            this.checkBox2One.AutoSize = true;
            this.checkBox2One.Location = new System.Drawing.Point(138, 53);
            this.checkBox2One.Name = "checkBox2One";
            this.checkBox2One.Size = new System.Drawing.Size(80, 17);
            this.checkBox2One.TabIndex = 4;
            this.checkBox2One.Text = "checkBox2";
            this.checkBox2One.UseVisualStyleBackColor = true;
            this.checkBox2One.CheckedChanged += new System.EventHandler(this.checkBox2One_CheckedChanged);
            // 
            // listBoxOne
            // 
            this.listBoxOne.FormattingEnabled = true;
            this.listBoxOne.Location = new System.Drawing.Point(18, 77);
            this.listBoxOne.Name = "listBoxOne";
            this.listBoxOne.Size = new System.Drawing.Size(200, 69);
            this.listBoxOne.TabIndex = 5;
            // 
            // textBox1One
            // 
            this.textBox1One.Location = new System.Drawing.Point(18, 25);
            this.textBox1One.Name = "textBox1One";
            this.textBox1One.Size = new System.Drawing.Size(100, 20);
            this.textBox1One.TabIndex = 6;
            // 
            // textBox2One
            // 
            this.textBox2One.Location = new System.Drawing.Point(18, 51);
            this.textBox2One.Name = "textBox2One";
            this.textBox2One.Size = new System.Drawing.Size(100, 20);
            this.textBox2One.TabIndex = 7;
            // 
            // tbValueForListBoxOne
            // 
            this.tbValueForListBoxOne.Location = new System.Drawing.Point(18, 151);
            this.tbValueForListBoxOne.Name = "tbValueForListBoxOne";
            this.tbValueForListBoxOne.Size = new System.Drawing.Size(100, 20);
            this.tbValueForListBoxOne.TabIndex = 8;
            // 
            // bAddToListBoxOne
            // 
            this.bAddToListBoxOne.Location = new System.Drawing.Point(124, 149);
            this.bAddToListBoxOne.Name = "bAddToListBoxOne";
            this.bAddToListBoxOne.Size = new System.Drawing.Size(43, 23);
            this.bAddToListBoxOne.TabIndex = 9;
            this.bAddToListBoxOne.Text = "Add";
            this.bAddToListBoxOne.UseVisualStyleBackColor = true;
            this.bAddToListBoxOne.Click += new System.EventHandler(this.bAddToListBoxOne_Click);
            // 
            // bRemoveFromListBoxOne
            // 
            this.bRemoveFromListBoxOne.Location = new System.Drawing.Point(173, 149);
            this.bRemoveFromListBoxOne.Name = "bRemoveFromListBoxOne";
            this.bRemoveFromListBoxOne.Size = new System.Drawing.Size(45, 23);
            this.bRemoveFromListBoxOne.TabIndex = 10;
            this.bRemoveFromListBoxOne.Text = "Rem";
            this.bRemoveFromListBoxOne.UseVisualStyleBackColor = true;
            this.bRemoveFromListBoxOne.Click += new System.EventHandler(this.bRemoveFromListBoxOne_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listBoxOne);
            this.groupBox1.Controls.Add(this.bRemoveFromListBoxOne);
            this.groupBox1.Controls.Add(this.checkBox1One);
            this.groupBox1.Controls.Add(this.bAddToListBoxOne);
            this.groupBox1.Controls.Add(this.checkBox2One);
            this.groupBox1.Controls.Add(this.tbValueForListBoxOne);
            this.groupBox1.Controls.Add(this.textBox1One);
            this.groupBox1.Controls.Add(this.textBox2One);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(240, 188);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "AppSettingsOne";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.listBoxTwo);
            this.groupBox2.Controls.Add(this.bRemoveFromListBoxTwo);
            this.groupBox2.Controls.Add(this.checkBox1Two);
            this.groupBox2.Controls.Add(this.bAddToListBoxTwo);
            this.groupBox2.Controls.Add(this.checkBox2Two);
            this.groupBox2.Controls.Add(this.tbValueForListBoxTwo);
            this.groupBox2.Controls.Add(this.textBox1Two);
            this.groupBox2.Controls.Add(this.textBox2Two);
            this.groupBox2.Location = new System.Drawing.Point(260, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(233, 188);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "AppSettingsTwo";
            // 
            // listBoxTwo
            // 
            this.listBoxTwo.FormattingEnabled = true;
            this.listBoxTwo.Location = new System.Drawing.Point(18, 77);
            this.listBoxTwo.Name = "listBoxTwo";
            this.listBoxTwo.Size = new System.Drawing.Size(200, 69);
            this.listBoxTwo.TabIndex = 5;
            // 
            // bRemoveFromListBoxTwo
            // 
            this.bRemoveFromListBoxTwo.Location = new System.Drawing.Point(173, 149);
            this.bRemoveFromListBoxTwo.Name = "bRemoveFromListBoxTwo";
            this.bRemoveFromListBoxTwo.Size = new System.Drawing.Size(45, 23);
            this.bRemoveFromListBoxTwo.TabIndex = 10;
            this.bRemoveFromListBoxTwo.Text = "Rem";
            this.bRemoveFromListBoxTwo.UseVisualStyleBackColor = true;
            this.bRemoveFromListBoxTwo.Click += new System.EventHandler(this.bRemoveFromListBoxTwo_Click);
            // 
            // checkBox1Two
            // 
            this.checkBox1Two.AutoSize = true;
            this.checkBox1Two.Location = new System.Drawing.Point(138, 27);
            this.checkBox1Two.Name = "checkBox1Two";
            this.checkBox1Two.Size = new System.Drawing.Size(80, 17);
            this.checkBox1Two.TabIndex = 3;
            this.checkBox1Two.Text = "checkBox3";
            this.checkBox1Two.UseVisualStyleBackColor = true;
            this.checkBox1Two.CheckedChanged += new System.EventHandler(this.checkBox1Two_CheckedChanged);
            // 
            // bAddToListBoxTwo
            // 
            this.bAddToListBoxTwo.Location = new System.Drawing.Point(124, 149);
            this.bAddToListBoxTwo.Name = "bAddToListBoxTwo";
            this.bAddToListBoxTwo.Size = new System.Drawing.Size(43, 23);
            this.bAddToListBoxTwo.TabIndex = 9;
            this.bAddToListBoxTwo.Text = "Add";
            this.bAddToListBoxTwo.UseVisualStyleBackColor = true;
            this.bAddToListBoxTwo.Click += new System.EventHandler(this.bAddToListBoxTwo_Click);
            // 
            // checkBox2Two
            // 
            this.checkBox2Two.AutoSize = true;
            this.checkBox2Two.Location = new System.Drawing.Point(138, 53);
            this.checkBox2Two.Name = "checkBox2Two";
            this.checkBox2Two.Size = new System.Drawing.Size(80, 17);
            this.checkBox2Two.TabIndex = 4;
            this.checkBox2Two.Text = "checkBox4";
            this.checkBox2Two.UseVisualStyleBackColor = true;
            this.checkBox2Two.CheckedChanged += new System.EventHandler(this.checkBox2Two_CheckedChanged);
            // 
            // tbValueForListBoxTwo
            // 
            this.tbValueForListBoxTwo.Location = new System.Drawing.Point(18, 151);
            this.tbValueForListBoxTwo.Name = "tbValueForListBoxTwo";
            this.tbValueForListBoxTwo.Size = new System.Drawing.Size(100, 20);
            this.tbValueForListBoxTwo.TabIndex = 8;
            // 
            // textBox1Two
            // 
            this.textBox1Two.Location = new System.Drawing.Point(18, 25);
            this.textBox1Two.Name = "textBox1Two";
            this.textBox1Two.Size = new System.Drawing.Size(100, 20);
            this.textBox1Two.TabIndex = 6;
            // 
            // textBox2Two
            // 
            this.textBox2Two.Location = new System.Drawing.Point(18, 51);
            this.textBox2Two.Name = "textBox2Two";
            this.textBox2Two.Size = new System.Drawing.Size(100, 20);
            this.textBox2Two.TabIndex = 7;
            // 
            // bSaveBinary
            // 
            this.bSaveBinary.Location = new System.Drawing.Point(400, 226);
            this.bSaveBinary.Name = "bSaveBinary";
            this.bSaveBinary.Size = new System.Drawing.Size(78, 23);
            this.bSaveBinary.TabIndex = 14;
            this.bSaveBinary.Text = "Save binary";
            this.bSaveBinary.UseVisualStyleBackColor = true;
            this.bSaveBinary.Click += new System.EventHandler(this.bSaveBinary_Click);
            // 
            // bLoadBinary
            // 
            this.bLoadBinary.Location = new System.Drawing.Point(316, 226);
            this.bLoadBinary.Name = "bLoadBinary";
            this.bLoadBinary.Size = new System.Drawing.Size(78, 23);
            this.bLoadBinary.TabIndex = 13;
            this.bLoadBinary.Text = "Load binary";
            this.bLoadBinary.UseVisualStyleBackColor = true;
            this.bLoadBinary.Click += new System.EventHandler(this.bLoadBinary_Click);
            // 
            // bSaveSecure
            // 
            this.bSaveSecure.Location = new System.Drawing.Point(400, 255);
            this.bSaveSecure.Name = "bSaveSecure";
            this.bSaveSecure.Size = new System.Drawing.Size(78, 23);
            this.bSaveSecure.TabIndex = 16;
            this.bSaveSecure.Text = "Save secure";
            this.bSaveSecure.UseVisualStyleBackColor = true;
            this.bSaveSecure.Click += new System.EventHandler(this.bSaveSecure_Click);
            // 
            // bLoadSecure
            // 
            this.bLoadSecure.Location = new System.Drawing.Point(316, 255);
            this.bLoadSecure.Name = "bLoadSecure";
            this.bLoadSecure.Size = new System.Drawing.Size(78, 23);
            this.bLoadSecure.TabIndex = 15;
            this.bLoadSecure.Text = "Load secure";
            this.bLoadSecure.UseVisualStyleBackColor = true;
            this.bLoadSecure.Click += new System.EventHandler(this.bLoadSecure_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 287);
            this.Controls.Add(this.bSaveSecure);
            this.Controls.Add(this.bLoadSecure);
            this.Controls.Add(this.bSaveBinary);
            this.Controls.Add(this.bLoadBinary);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.bSave);
            this.Controls.Add(this.bLoad);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "MainForm";
            this.Text = "SharpConfig ObjectConfiguration";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bLoad;
        private System.Windows.Forms.Button bSave;
        private System.Windows.Forms.CheckBox checkBox1One;
        private System.Windows.Forms.CheckBox checkBox2One;
        private System.Windows.Forms.ListBox listBoxOne;
        private System.Windows.Forms.TextBox textBox1One;
        private System.Windows.Forms.TextBox textBox2One;
        private System.Windows.Forms.TextBox tbValueForListBoxOne;
        private System.Windows.Forms.Button bAddToListBoxOne;
        private System.Windows.Forms.Button bRemoveFromListBoxOne;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox listBoxTwo;
        private System.Windows.Forms.Button bRemoveFromListBoxTwo;
        private System.Windows.Forms.CheckBox checkBox1Two;
        private System.Windows.Forms.Button bAddToListBoxTwo;
        private System.Windows.Forms.CheckBox checkBox2Two;
        private System.Windows.Forms.TextBox tbValueForListBoxTwo;
        private System.Windows.Forms.TextBox textBox1Two;
        private System.Windows.Forms.TextBox textBox2Two;
        private System.Windows.Forms.Button bSaveBinary;
        private System.Windows.Forms.Button bLoadBinary;
        private System.Windows.Forms.Button bSaveSecure;
        private System.Windows.Forms.Button bLoadSecure;
    }
}

