namespace TP_1
{
    partial class Form2
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
            TxtBoxMontant = new TextBox();
            date = new DateTimePicker();
            ComboBoxListeClients = new ComboBox();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // TxtBoxMontant
            // 
            TxtBoxMontant.Location = new Point(31, 44);
            TxtBoxMontant.Name = "TxtBoxMontant";
            TxtBoxMontant.Size = new Size(100, 23);
            TxtBoxMontant.TabIndex = 0;
            // 
            // date
            // 
            date.Location = new Point(164, 44);
            date.Name = "date";
            date.Size = new Size(200, 23);
            date.TabIndex = 1;
            date.ValueChanged += date_ValueChanged;
            // 
            // ComboBoxListeClients
            // 
            ComboBoxListeClients.DropDownStyle = ComboBoxStyle.DropDownList;
            ComboBoxListeClients.FormattingEnabled = true;
            ComboBoxListeClients.Location = new Point(78, 108);
            ComboBoxListeClients.Name = "ComboBoxListeClients";
            ComboBoxListeClients.Size = new Size(121, 23);
            ComboBoxListeClients.TabIndex = 2;
            // 
            // button1
            // 
            button1.Location = new Point(164, 250);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 3;
            button1.Text = "OK";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(31, 250);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 4;
            button2.Text = "Cancel";
            button2.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(389, 319);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(ComboBoxListeClients);
            Controls.Add(date);
            Controls.Add(TxtBoxMontant);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox TxtBoxMontant;
        private DateTimePicker date;
        private ComboBox ComboBoxListeClients;
        private Button button1;
        private Button button2;
    }
}