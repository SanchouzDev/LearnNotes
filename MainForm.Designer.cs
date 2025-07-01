namespace LearnNotes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            pictureBox = new PictureBox();
            panel1 = new Panel();
            imageNoteNameText = new Label();
            midiNoteNameText = new Label();
            midiOutText = new Label();
            newImagButton = new Button();
            checkBox = new CheckBox();
            tipText = new Label();
            checkBox_allNotes = new CheckBox();
            checkBox_C1 = new CheckBox();
            checkBox_C2 = new CheckBox();
            checkBox_C3 = new CheckBox();
            checkBox_C4 = new CheckBox();
            checkBox_C5 = new CheckBox();
            checkBox_C6 = new CheckBox();
            Apply_Button = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox
            // 
            pictureBox.BackgroundImage = (Image)resources.GetObject("pictureBox.BackgroundImage");
            pictureBox.BorderStyle = BorderStyle.FixedSingle;
            pictureBox.Location = new Point(12, 12);
            pictureBox.Name = "pictureBox";
            pictureBox.Size = new Size(500, 400);
            pictureBox.TabIndex = 0;
            pictureBox.TabStop = false;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(imageNoteNameText);
            panel1.Controls.Add(midiNoteNameText);
            panel1.Controls.Add(midiOutText);
            panel1.Location = new Point(12, 418);
            panel1.Name = "panel1";
            panel1.Size = new Size(500, 109);
            panel1.TabIndex = 2;
            // 
            // imageNoteNameText
            // 
            imageNoteNameText.AutoSize = true;
            imageNoteNameText.Location = new Point(317, 12);
            imageNoteNameText.Name = "imageNoteNameText";
            imageNoteNameText.Size = new Size(70, 45);
            imageNoteNameText.TabIndex = 2;
            imageNoteNameText.Text = "Image note:\n\n----------";
            // 
            // midiNoteNameText
            // 
            midiNoteNameText.AutoSize = true;
            midiNoteNameText.Location = new Point(401, 12);
            midiNoteNameText.Name = "midiNoteNameText";
            midiNoteNameText.Size = new Size(94, 45);
            midiNoteNameText.TabIndex = 1;
            midiNoteNameText.Text = "Midi note name:\n\n ----------";
            // 
            // midiOutText
            // 
            midiOutText.AutoSize = true;
            midiOutText.Location = new Point(3, 12);
            midiOutText.Name = "midiOutText";
            midiOutText.Size = new Size(60, 45);
            midiOutText.TabIndex = 0;
            midiOutText.Text = "Midi out:\n\n ----------";
            // 
            // newImagButton
            // 
            newImagButton.Location = new Point(12, 533);
            newImagButton.Name = "newImagButton";
            newImagButton.Size = new Size(217, 83);
            newImagButton.TabIndex = 3;
            newImagButton.Text = "Load new image";
            newImagButton.UseVisualStyleBackColor = true;
            newImagButton.Click += NewImageButton_Click;
            // 
            // checkBox
            // 
            checkBox.AutoSize = true;
            checkBox.Location = new Point(12, 622);
            checkBox.Name = "checkBox";
            checkBox.Size = new Size(146, 19);
            checkBox.TabIndex = 4;
            checkBox.Text = "view image note name";
            checkBox.UseVisualStyleBackColor = true;
            // 
            // tipText
            // 
            tipText.AutoSize = true;
            tipText.Location = new Point(12, 644);
            tipText.Name = "tipText";
            tipText.Size = new Size(142, 15);
            tipText.TabIndex = 5;
            tipText.Text = "* A0 loads new image too";
            // 
            // checkBox_allNotes
            // 
            checkBox_allNotes.AutoSize = true;
            checkBox_allNotes.Location = new Point(266, 533);
            checkBox_allNotes.Name = "checkBox_allNotes";
            checkBox_allNotes.Size = new Size(74, 19);
            checkBox_allNotes.TabIndex = 6;
            checkBox_allNotes.Text = "Select All";
            checkBox_allNotes.UseVisualStyleBackColor = true;
            checkBox_allNotes.CheckedChanged += checkBox_allNotes_CheckedChanged;
            // 
            // checkBox_C1
            // 
            checkBox_C1.AutoSize = true;
            checkBox_C1.Location = new Point(350, 533);
            checkBox_C1.Name = "checkBox_C1";
            checkBox_C1.Size = new Size(58, 19);
            checkBox_C1.TabIndex = 7;
            checkBox_C1.Text = "C1-B1";
            checkBox_C1.UseVisualStyleBackColor = true;
            // 
            // checkBox_C2
            // 
            checkBox_C2.AutoSize = true;
            checkBox_C2.Location = new Point(414, 533);
            checkBox_C2.Name = "checkBox_C2";
            checkBox_C2.Size = new Size(58, 19);
            checkBox_C2.TabIndex = 8;
            checkBox_C2.Text = "C2-B2";
            checkBox_C2.UseVisualStyleBackColor = true;
            // 
            // checkBox_C3
            // 
            checkBox_C3.AutoSize = true;
            checkBox_C3.Location = new Point(350, 558);
            checkBox_C3.Name = "checkBox_C3";
            checkBox_C3.Size = new Size(58, 19);
            checkBox_C3.TabIndex = 9;
            checkBox_C3.Text = "C3-B3";
            checkBox_C3.UseVisualStyleBackColor = true;
            // 
            // checkBox_C4
            // 
            checkBox_C4.AutoSize = true;
            checkBox_C4.Location = new Point(414, 558);
            checkBox_C4.Name = "checkBox_C4";
            checkBox_C4.Size = new Size(58, 19);
            checkBox_C4.TabIndex = 10;
            checkBox_C4.Text = "C4-B4";
            checkBox_C4.UseVisualStyleBackColor = true;
            // 
            // checkBox_C5
            // 
            checkBox_C5.AutoSize = true;
            checkBox_C5.Location = new Point(350, 583);
            checkBox_C5.Name = "checkBox_C5";
            checkBox_C5.Size = new Size(58, 19);
            checkBox_C5.TabIndex = 11;
            checkBox_C5.Text = "C5-B5";
            checkBox_C5.UseVisualStyleBackColor = true;
            // 
            // checkBox_C6
            // 
            checkBox_C6.AutoSize = true;
            checkBox_C6.Location = new Point(414, 583);
            checkBox_C6.Name = "checkBox_C6";
            checkBox_C6.Size = new Size(58, 19);
            checkBox_C6.TabIndex = 12;
            checkBox_C6.Text = "C6-B6";
            checkBox_C6.UseVisualStyleBackColor = true;
            // 
            // Apply_Button
            // 
            Apply_Button.Location = new Point(266, 618);
            Apply_Button.Name = "Apply_Button";
            Apply_Button.Size = new Size(206, 41);
            Apply_Button.TabIndex = 13;
            Apply_Button.Text = "Apply";
            Apply_Button.UseVisualStyleBackColor = true;
            Apply_Button.Click += Apply_Button_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(526, 703);
            Controls.Add(Apply_Button);
            Controls.Add(checkBox_C6);
            Controls.Add(checkBox_C5);
            Controls.Add(checkBox_C4);
            Controls.Add(checkBox_C3);
            Controls.Add(checkBox_C2);
            Controls.Add(checkBox_C1);
            Controls.Add(checkBox_allNotes);
            Controls.Add(tipText);
            Controls.Add(checkBox);
            Controls.Add(newImagButton);
            Controls.Add(panel1);
            Controls.Add(pictureBox);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MaximumSize = new Size(542, 742);
            MinimumSize = new Size(542, 742);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LearnNotes";
            Load += MainForm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox;
        private Label midiOutText;
        private Button newImagButton;
        private Label midiNoteNameText;
        private Label imageNoteNameText;
        private CheckBox checkBox;
        private Label tipText;
        private CheckBox checkBox_allNotes;
        private CheckBox checkBox_C1;
        private CheckBox checkBox_C2;
        private CheckBox checkBox_C3;
        private CheckBox checkBox_C4;
        private CheckBox checkBox_C5;
        private CheckBox checkBox_C6;
        private Button Apply_Button;
    }
}
