﻿namespace TP_1
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
            bsClients = new BindingSource(components);
            dgvClients = new DataGridView();
            bsCommandes = new BindingSource(components);
            dgvCommandes = new DataGridView();
            menuStrip1 = new MenuStrip();
            toolStripMenuItem1 = new ToolStripMenuItem();
            commandeToolStripMenuItem = new ToolStripMenuItem();
            clientsToolStripMenuItem = new ToolStripMenuItem();
            bsAuteurs = new BindingSource(components);
            dgvAuteurs = new DataGridView();
            cbClients = new ComboBox();
            bsClients2 = new BindingSource(components);
            btnForm2 = new Button();
            fileSystemWatcher1 = new FileSystemWatcher();
            ((System.ComponentModel.ISupportInitialize)bsClients).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvClients).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bsCommandes).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvCommandes).BeginInit();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)bsAuteurs).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvAuteurs).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bsClients2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).BeginInit();
            SuspendLayout();
            // 
            // dgvClients
            // 
            dgvClients.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvClients.Location = new Point(510, 70);
            dgvClients.Name = "dgvClients";
            dgvClients.RowTemplate.Height = 25;
            dgvClients.Size = new Size(253, 143);
            dgvClients.TabIndex = 0;
            // 
            // dgvCommandes
            // 
            dgvCommandes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCommandes.Location = new Point(30, 70);
            dgvCommandes.Name = "dgvCommandes";
            dgvCommandes.RowTemplate.Height = 25;
            dgvCommandes.Size = new Size(283, 143);
            dgvCommandes.TabIndex = 1;
            dgvCommandes.CellContentClick += dgvCommandes_CellContentClick;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { toolStripMenuItem1, commandeToolStripMenuItem, clientsToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(977, 24);
            menuStrip1.TabIndex = 2;
            menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(125, 20);
            toolStripMenuItem1.Text = "toolStripMenuItem1";
            // 
            // commandeToolStripMenuItem
            // 
            commandeToolStripMenuItem.Name = "commandeToolStripMenuItem";
            commandeToolStripMenuItem.Size = new Size(80, 20);
            commandeToolStripMenuItem.Text = "commande";
            // 
            // clientsToolStripMenuItem
            // 
            clientsToolStripMenuItem.Name = "clientsToolStripMenuItem";
            clientsToolStripMenuItem.Size = new Size(55, 20);
            clientsToolStripMenuItem.Text = "Clients";
            // 
            // dgvAuteurs
            // 
            dgvAuteurs.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAuteurs.Location = new Point(510, 330);
            dgvAuteurs.Name = "dgvAuteurs";
            dgvAuteurs.RowTemplate.Height = 25;
            dgvAuteurs.Size = new Size(287, 134);
            dgvAuteurs.TabIndex = 3;
            dgvAuteurs.CellContentClick += dgvAuteurs_CellContentClick;
            // 
            // cbClients
            // 
            cbClients.AccessibleDescription = " ";
            cbClients.AccessibleName = "";
            cbClients.DropDownStyle = ComboBoxStyle.DropDownList;
            cbClients.FormattingEnabled = true;
            cbClients.Location = new Point(341, 27);
            cbClients.Name = "cbClients";
            cbClients.Size = new Size(121, 23);
            cbClients.TabIndex = 4;
            cbClients.Tag = "";
            cbClients.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // bsClients2
            // 
            bsClients2.CurrentChanged += bsClients2_CurrentChanged;
            // 
            // btnForm2
            // 
            btnForm2.Cursor = Cursors.Hand;
            btnForm2.Location = new Point(70, 236);
            btnForm2.Name = "btnForm2";
            btnForm2.Size = new Size(184, 23);
            btnForm2.TabIndex = 5;
            btnForm2.Text = "géré une commande ?";
            btnForm2.UseVisualStyleBackColor = true;
            btnForm2.Click += button1_Click;
            // 
            // fileSystemWatcher1
            // 
            fileSystemWatcher1.EnableRaisingEvents = true;
            fileSystemWatcher1.SynchronizingObject = this;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(977, 526);
            Controls.Add(btnForm2);
            Controls.Add(cbClients);
            Controls.Add(dgvAuteurs);
            Controls.Add(dgvCommandes);
            Controls.Add(dgvClients);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)bsClients).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvClients).EndInit();
            ((System.ComponentModel.ISupportInitialize)bsCommandes).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvCommandes).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)bsAuteurs).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvAuteurs).EndInit();
            ((System.ComponentModel.ISupportInitialize)bsClients2).EndInit();
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private BindingSource bsClients;
        private DataGridView dgvClients;
        private BindingSource bsCommandes;
        private DataGridView dgvCommandes;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem commandeToolStripMenuItem;
        private ToolStripMenuItem clientsToolStripMenuItem;
        private BindingSource bsAuteurs;
        private DataGridView dgvAuteurs;
        private ComboBox cbClients;
        private BindingSource bsClients2;
        private Button btnForm2;
        private FileSystemWatcher fileSystemWatcher1;
    }
}