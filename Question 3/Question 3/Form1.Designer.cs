namespace Question_3
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
            lblTitle = new Label();
            listLanguages = new ListBox();
            txtLanguage = new TextBox();
            btnAdd = new Button();
            btnRemove = new Button();
            lblStatus = new Label();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(273, 83);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(377, 28);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "My Favourite Programming Languages";
            // 
            // listLanguages
            // 
            listLanguages.FormattingEnabled = true;
            listLanguages.Location = new Point(170, 125);
            listLanguages.Name = "listLanguages";
            listLanguages.Size = new Size(635, 244);
            listLanguages.TabIndex = 1;
            // 
            // txtLanguage
            // 
            txtLanguage.BackColor = SystemColors.Window;
            txtLanguage.Location = new Point(170, 389);
            txtLanguage.Name = "txtLanguage";
            txtLanguage.PlaceholderText = "Enter programming language";
            txtLanguage.Size = new Size(635, 27);
            txtLanguage.TabIndex = 2;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.Blue;
            btnAdd.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdd.ForeColor = Color.White;
            btnAdd.Location = new Point(170, 434);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(140, 38);
            btnAdd.TabIndex = 3;
            btnAdd.Text = "Add Language";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click_1;
            // 
            // btnRemove
            // 
            btnRemove.BackColor = Color.Red;
            btnRemove.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRemove.ForeColor = Color.White;
            btnRemove.Location = new Point(316, 434);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(140, 38);
            btnRemove.TabIndex = 4;
            btnRemove.Text = "Remove";
            btnRemove.UseVisualStyleBackColor = false;
            btnRemove.Click += btnRemove_Click;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.ForeColor = Color.DarkGray;
            lblStatus.Location = new Point(170, 486);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(0, 20);
            lblStatus.TabIndex = 5;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(909, 527);
            Controls.Add(lblStatus);
            Controls.Add(btnRemove);
            Controls.Add(btnAdd);
            Controls.Add(txtLanguage);
            Controls.Add(lblTitle);
            Controls.Add(listLanguages);
            Name = "Form1";
            Text = "Favourite Programming Languages";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private ListBox listLanguages;
        private TextBox txtLanguage;
        private Button btnAdd;
        private Button btnRemove;
        private Label lblStatus;
    }
}
