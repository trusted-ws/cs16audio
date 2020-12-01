
namespace csaudio
{
    partial class locateCstrike
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(locateCstrike));
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSelectFiles = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.btnDeleteItem = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(319, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "O diretório do Counter Strike 1.6 não foi encontrado.\r\nSerá necessário localizá-l" +
    "o manualmente.\r\n";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 33);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(395, 119);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(395, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "O diretório do Counter Strike 1.6 não foi encontrado.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(321, 34);
            this.label3.TabIndex = 1;
            this.label3.Text = "Para continuar clique em \"Procurar\" selecione a pasta\r\n\"cstrike\" do seu Counter S" +
    "trike 1.6.";
            // 
            // btnSelectFiles
            // 
            this.btnSelectFiles.FlatAppearance.BorderSize = 0;
            this.btnSelectFiles.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnSelectFiles.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnSelectFiles.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSelectFiles.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSelectFiles.Image = global::csaudio.Properties.Resources.opened_folder_18px;
            this.btnSelectFiles.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSelectFiles.Location = new System.Drawing.Point(322, 158);
            this.btnSelectFiles.Name = "btnSelectFiles";
            this.btnSelectFiles.Size = new System.Drawing.Size(85, 32);
            this.btnSelectFiles.TabIndex = 7;
            this.btnSelectFiles.Text = "Procurar";
            this.btnSelectFiles.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSelectFiles.UseVisualStyleBackColor = true;
            this.btnSelectFiles.Click += new System.EventHandler(this.btnSelectFiles_Click);
            // 
            // btnDeleteItem
            // 
            this.btnDeleteItem.FlatAppearance.BorderSize = 0;
            this.btnDeleteItem.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnDeleteItem.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnDeleteItem.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDeleteItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnDeleteItem.Image = global::csaudio.Properties.Resources.delete_18px;
            this.btnDeleteItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeleteItem.Location = new System.Drawing.Point(262, 158);
            this.btnDeleteItem.Name = "btnDeleteItem";
            this.btnDeleteItem.Size = new System.Drawing.Size(54, 32);
            this.btnDeleteItem.TabIndex = 8;
            this.btnDeleteItem.Text = "Sair";
            this.btnDeleteItem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDeleteItem.UseVisualStyleBackColor = true;
            this.btnDeleteItem.Click += new System.EventHandler(this.btnDeleteItem_Click);
            // 
            // locateCstrike
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 228);
            this.ControlBox = false;
            this.Controls.Add(this.btnDeleteItem);
            this.Controls.Add(this.btnSelectFiles);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "locateCstrike";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Selecione a pasta \'cstrike\'";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSelectFiles;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button btnDeleteItem;
    }
}