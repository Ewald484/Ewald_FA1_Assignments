namespace SectionB_Question2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            label2 = new Label();
            txtName = new TextBox();
            label3 = new Label();
            txtID = new TextBox();
            label4 = new Label();
            btnValidate = new Button();
            btnGenerate = new Button();
            lblResults = new Label();
            txtOutput = new TextBox();
            lblResult = new Label();
            piclogo = new PictureBox();
            cmbCitizen = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)piclogo).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Green;
            label1.Location = new Point(658, 73);
            label1.Name = "label1";
            label1.Size = new Size(532, 38);
            label1.TabIndex = 0;
            label1.Text = "Home Affairs Digital Identity Processor";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(658, 176);
            label2.Name = "label2";
            label2.Size = new Size(150, 23);
            label2.TabIndex = 1;
            label2.Text = "Enter your Name:";
            // 
            // txtName
            // 
            txtName.Location = new Point(863, 176);
            txtName.Name = "txtName";
            txtName.Size = new Size(326, 27);
            txtName.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(658, 250);
            label3.Name = "label3";
            label3.Size = new Size(121, 23);
            label3.TabIndex = 3;
            label3.Text = "Enter your ID:";
            // 
            // txtID
            // 
            txtID.Location = new Point(863, 250);
            txtID.Name = "txtID";
            txtID.Size = new Size(326, 27);
            txtID.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(658, 321);
            label4.Name = "label4";
            label4.Size = new Size(173, 23);
            label4.TabIndex = 5;
            label4.Text = "Choose your Citizen:";
            // 
            // btnValidate
            // 
            btnValidate.BackColor = Color.DarkGreen;
            btnValidate.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnValidate.Location = new Point(949, 395);
            btnValidate.Name = "btnValidate";
            btnValidate.Size = new Size(162, 44);
            btnValidate.TabIndex = 7;
            btnValidate.Text = "Validate ID";
            btnValidate.UseVisualStyleBackColor = false;
            btnValidate.Click += btnValidate_Click;
            // 
            // btnGenerate
            // 
            btnGenerate.BackColor = Color.DarkGreen;
            btnGenerate.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGenerate.Location = new Point(949, 772);
            btnGenerate.Name = "btnGenerate";
            btnGenerate.Size = new Size(171, 54);
            btnGenerate.TabIndex = 8;
            btnGenerate.Text = "Generate Profile";
            btnGenerate.UseVisualStyleBackColor = false;
            btnGenerate.Click += btnGenerate_Click;
            // 
            // lblResults
            // 
            lblResults.AutoSize = true;
            lblResults.Location = new Point(848, 470);
            lblResults.Name = "lblResults";
            lblResults.Size = new Size(0, 20);
            lblResults.TabIndex = 9;
            // 
            // txtOutput
            // 
            txtOutput.Location = new Point(831, 516);
            txtOutput.Multiline = true;
            txtOutput.Name = "txtOutput";
            txtOutput.Size = new Size(399, 212);
            txtOutput.TabIndex = 10;
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Location = new Point(864, 469);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(0, 20);
            lblResult.TabIndex = 11;
            // 
            // piclogo
            // 
            piclogo.BackColor = Color.Transparent;
            piclogo.Image = (Image)resources.GetObject("piclogo.Image");
            piclogo.Location = new Point(66, 73);
            piclogo.Name = "piclogo";
            piclogo.Size = new Size(572, 640);
            piclogo.SizeMode = PictureBoxSizeMode.StretchImage;
            piclogo.TabIndex = 12;
            piclogo.TabStop = false;
            // 
            // cmbCitizen
            // 
            cmbCitizen.FormattingEnabled = true;
            cmbCitizen.Location = new Point(863, 321);
            cmbCitizen.Name = "cmbCitizen";
            cmbCitizen.Size = new Size(327, 28);
            cmbCitizen.TabIndex = 13;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 192, 128);
            ClientSize = new Size(1404, 907);
            Controls.Add(cmbCitizen);
            Controls.Add(piclogo);
            Controls.Add(lblResult);
            Controls.Add(txtOutput);
            Controls.Add(lblResults);
            Controls.Add(btnGenerate);
            Controls.Add(btnValidate);
            Controls.Add(label4);
            Controls.Add(txtID);
            Controls.Add(label3);
            Controls.Add(txtName);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)piclogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtName;
        private Label label3;
        private TextBox txtID;
        private Label label4;
        private Button btnValidate;
        private Button btnGenerate;
        private Label lblResults;
        private TextBox txtOutput;
        private Label lblResult;
        private PictureBox piclogo;
        private ComboBox cmbCitizen;
    }
}
