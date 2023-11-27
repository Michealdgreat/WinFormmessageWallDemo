namespace MessageWallApp
{
    partial class Dashboard
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
            FirstName = new Label();
            FirstNametext = new TextBox();
            MessageListBox = new ListBox();
            MessageListBoxLabel = new Label();
            AddMessage = new Button();
            LastName = new Label();
            LastNameText = new TextBox();
            SuspendLayout();
            // 
            // FirstName
            // 
            FirstName.AutoSize = true;
            FirstName.Location = new Point(80, 87);
            FirstName.Name = "FirstName";
            FirstName.Size = new Size(166, 42);
            FirstName.TabIndex = 0;
            FirstName.Text = "First Name";
            FirstName.Click += label1_Click;
            // 
            // FirstNametext
            // 
            FirstNametext.Location = new Point(249, 87);
            FirstNametext.Name = "FirstNametext";
            FirstNametext.Size = new Size(376, 49);
            FirstNametext.TabIndex = 1;
            FirstNametext.TextChanged += MessageText_TextChanged;
            // 
            // MessageListBox
            // 
            MessageListBox.FormattingEnabled = true;
            MessageListBox.ItemHeight = 42;
            MessageListBox.Location = new Point(96, 315);
            MessageListBox.Name = "MessageListBox";
            MessageListBox.Size = new Size(682, 298);
            MessageListBox.TabIndex = 2;
            MessageListBox.TabStop = false;
            MessageListBox.SelectedIndexChanged += MessageListBox_SelectedIndexChanged;
            // 
            // MessageListBoxLabel
            // 
            MessageListBoxLabel.AutoSize = true;
            MessageListBoxLabel.Location = new Point(96, 270);
            MessageListBoxLabel.Name = "MessageListBoxLabel";
            MessageListBoxLabel.Size = new Size(151, 42);
            MessageListBoxLabel.TabIndex = 0;
            MessageListBoxLabel.Text = "Messages";
            MessageListBoxLabel.Click += label1_Click;
            // 
            // AddMessage
            // 
            AddMessage.Location = new Point(676, 87);
            AddMessage.Name = "AddMessage";
            AddMessage.Size = new Size(145, 46);
            AddMessage.TabIndex = 3;
            AddMessage.Text = "Add";
            AddMessage.UseVisualStyleBackColor = true;
            AddMessage.Click += AddMessage_Click;
            // 
            // LastName
            // 
            LastName.AutoSize = true;
            LastName.Location = new Point(80, 153);
            LastName.Name = "LastName";
            LastName.Size = new Size(163, 42);
            LastName.TabIndex = 0;
            LastName.Text = "Last Name";
            LastName.Click += label1_Click;
            // 
            // LastNameText
            // 
            LastNameText.Location = new Point(249, 153);
            LastNameText.Name = "LastNameText";
            LastNameText.Size = new Size(376, 49);
            LastNameText.TabIndex = 2;
            LastNameText.TextChanged += MessageText_TextChanged;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(17F, 42F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1067, 645);
            Controls.Add(AddMessage);
            Controls.Add(MessageListBox);
            Controls.Add(LastNameText);
            Controls.Add(FirstNametext);
            Controls.Add(LastName);
            Controls.Add(MessageListBoxLabel);
            Controls.Add(FirstName);
            Font = new Font("Segoe UI", 17.855999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(6);
            Name = "Dashboard";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label FirstName;
        private TextBox FirstNametext;
        private ListBox MessageListBox;
        private Label MessageListBoxLabel;
        private Button AddMessage;
        private Label LastName;
        private TextBox LastNameText;
    }
}
