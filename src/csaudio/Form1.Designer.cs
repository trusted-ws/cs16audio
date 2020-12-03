
namespace csaudio
{
    partial class Main
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblAudioName = new System.Windows.Forms.Label();
            this.listBoxFiles = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblExe = new System.Windows.Forms.Label();
            this.textGameDir = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.lblCredits = new System.Windows.Forms.Label();
            this.timerCredits = new System.Windows.Forms.Timer(this.components);
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btnExecutar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnSelectFiles = new System.Windows.Forms.Button();
            this.btnClearItems = new System.Windows.Forms.Button();
            this.btnDeleteItem = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblAudioName);
            this.groupBox1.Controls.Add(this.btnSelectFiles);
            this.groupBox1.Controls.Add(this.btnClearItems);
            this.groupBox1.Controls.Add(this.btnDeleteItem);
            this.groupBox1.Controls.Add(this.listBoxFiles);
            this.groupBox1.Location = new System.Drawing.Point(178, 14);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(514, 190);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Arquivos (arraste e solte)";
            // 
            // lblAudioName
            // 
            this.lblAudioName.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblAudioName.Location = new System.Drawing.Point(251, 13);
            this.lblAudioName.Name = "lblAudioName";
            this.lblAudioName.Size = new System.Drawing.Size(249, 13);
            this.lblAudioName.TabIndex = 8;
            this.lblAudioName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // listBoxFiles
            // 
            this.listBoxFiles.Font = new System.Drawing.Font("Consolas", 8F);
            this.listBoxFiles.FormattingEnabled = true;
            this.listBoxFiles.Location = new System.Drawing.Point(12, 28);
            this.listBoxFiles.Name = "listBoxFiles";
            this.listBoxFiles.Size = new System.Drawing.Size(489, 121);
            this.listBoxFiles.TabIndex = 4;
            this.listBoxFiles.SelectedIndexChanged += new System.EventHandler(this.listBoxFiles_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(159, 358);
            this.panel1.TabIndex = 3;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Controls.Add(this.lblExe);
            this.groupBox2.Controls.Add(this.textGameDir);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(178, 204);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(514, 100);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            // 
            // lblExe
            // 
            this.lblExe.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblExe.Location = new System.Drawing.Point(10, 61);
            this.lblExe.Name = "lblExe";
            this.lblExe.Size = new System.Drawing.Size(373, 21);
            this.lblExe.TabIndex = 8;
            this.lblExe.Text = "---";
            // 
            // textGameDir
            // 
            this.textGameDir.BackColor = System.Drawing.SystemColors.Control;
            this.textGameDir.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.textGameDir.Location = new System.Drawing.Point(12, 38);
            this.textGameDir.Name = "textGameDir";
            this.textGameDir.ReadOnly = true;
            this.textGameDir.Size = new System.Drawing.Size(489, 23);
            this.textGameDir.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label1.Location = new System.Drawing.Point(9, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Diretório do CS 1.6 (cstrike)";
            // 
            // lblCredits
            // 
            this.lblCredits.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblCredits.ForeColor = System.Drawing.Color.Gray;
            this.lblCredits.Location = new System.Drawing.Point(-2, 374);
            this.lblCredits.Name = "lblCredits";
            this.lblCredits.Size = new System.Drawing.Size(719, 20);
            this.lblCredits.TabIndex = 8;
            this.lblCredits.Text = "v1.1 - Developed by Murilo @ (github.com/trusted-ws/cs16audio)";
            this.lblCredits.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timerCredits
            // 
            this.timerCredits.Interval = 1000;
            this.timerCredits.Tick += new System.EventHandler(this.timerCredits_Tick);
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.button2.Image = global::csaudio.Properties.Resources.counter_strike_source_18px;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(178, 341);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(68, 25);
            this.button2.TabIndex = 9;
            this.button2.Text = "Bots";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.button1.Image = global::csaudio.Properties.Resources.reset_18px;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(437, 341);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(159, 25);
            this.button1.TabIndex = 9;
            this.button1.Text = "Resetar todos os Áudios";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.button3.Image = global::csaudio.Properties.Resources.edit_file_18px;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(430, 67);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(71, 25);
            this.button3.TabIndex = 7;
            this.button3.Text = "Alterar";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnExecutar
            // 
            this.btnExecutar.FlatAppearance.BorderSize = 0;
            this.btnExecutar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnExecutar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnExecutar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnExecutar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnExecutar.Image = global::csaudio.Properties.Resources.checkmark_18px;
            this.btnExecutar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExecutar.Location = new System.Drawing.Point(602, 341);
            this.btnExecutar.Name = "btnExecutar";
            this.btnExecutar.Size = new System.Drawing.Size(90, 25);
            this.btnExecutar.TabIndex = 6;
            this.btnExecutar.Text = "Executar";
            this.btnExecutar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExecutar.UseVisualStyleBackColor = true;
            this.btnExecutar.Click += new System.EventHandler(this.btnExecutar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::csaudio.Properties.Resources.cs161;
            this.pictureBox1.Location = new System.Drawing.Point(-301, -2);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(486, 359);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
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
            this.btnSelectFiles.Location = new System.Drawing.Point(414, 157);
            this.btnSelectFiles.Name = "btnSelectFiles";
            this.btnSelectFiles.Size = new System.Drawing.Size(86, 25);
            this.btnSelectFiles.TabIndex = 6;
            this.btnSelectFiles.Text = "Carregar";
            this.btnSelectFiles.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSelectFiles.UseVisualStyleBackColor = true;
            this.btnSelectFiles.Click += new System.EventHandler(this.btnSelectFiles_Click);
            // 
            // btnClearItems
            // 
            this.btnClearItems.FlatAppearance.BorderSize = 0;
            this.btnClearItems.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnClearItems.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnClearItems.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClearItems.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnClearItems.Image = global::csaudio.Properties.Resources.clear_symbol_18px;
            this.btnClearItems.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClearItems.Location = new System.Drawing.Point(90, 157);
            this.btnClearItems.Name = "btnClearItems";
            this.btnClearItems.Size = new System.Drawing.Size(73, 25);
            this.btnClearItems.TabIndex = 5;
            this.btnClearItems.Text = "Limpar";
            this.btnClearItems.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClearItems.UseVisualStyleBackColor = true;
            this.btnClearItems.Click += new System.EventHandler(this.btnClearItems_Click);
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
            this.btnDeleteItem.Location = new System.Drawing.Point(12, 157);
            this.btnDeleteItem.Name = "btnDeleteItem";
            this.btnDeleteItem.Size = new System.Drawing.Size(73, 25);
            this.btnDeleteItem.TabIndex = 4;
            this.btnDeleteItem.Text = "Deletar";
            this.btnDeleteItem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDeleteItem.UseVisualStyleBackColor = true;
            this.btnDeleteItem.Click += new System.EventHandler(this.btnDeleteItem_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(714, 395);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblCredits);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnExecutar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Counter Strike 1.6 - Utility";
            this.Load += new System.EventHandler(this.Main_Load);
            this.groupBox1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox listBoxFiles;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnDeleteItem;
        private System.Windows.Forms.Button btnClearItems;
        private System.Windows.Forms.Button btnExecutar;
        private System.Windows.Forms.Button btnSelectFiles;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblExe;
        private System.Windows.Forms.TextBox textGameDir;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Label lblAudioName;
        private System.Windows.Forms.Label lblCredits;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Timer timerCredits;
        private System.Windows.Forms.Button button2;
    }
}

