
namespace CultureViewer {
    partial class MainForm {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.CBCultureType = new System.Windows.Forms.ComboBox();
            this.DGVCultures = new System.Windows.Forms.DataGridView();
            this.BtnHelp = new System.Windows.Forms.Button();
            this.TCount = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DGVCultures)).BeginInit();
            this.SuspendLayout();
            // 
            // CBCultureType
            // 
            this.CBCultureType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBCultureType.FormattingEnabled = true;
            this.CBCultureType.Location = new System.Drawing.Point(13, 13);
            this.CBCultureType.Name = "CBCultureType";
            this.CBCultureType.Size = new System.Drawing.Size(291, 28);
            this.CBCultureType.TabIndex = 0;
            this.CBCultureType.SelectedIndexChanged += new System.EventHandler(this.CBCultureType_SelectedIndexChanged);
            // 
            // DGVCultures
            // 
            this.DGVCultures.AllowUserToAddRows = false;
            this.DGVCultures.AllowUserToDeleteRows = false;
            this.DGVCultures.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DGVCultures.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.DGVCultures.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DGVCultures.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVCultures.Location = new System.Drawing.Point(13, 47);
            this.DGVCultures.Name = "DGVCultures";
            this.DGVCultures.ReadOnly = true;
            this.DGVCultures.RowHeadersVisible = false;
            this.DGVCultures.RowHeadersWidth = 51;
            this.DGVCultures.RowTemplate.Height = 29;
            this.DGVCultures.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVCultures.Size = new System.Drawing.Size(775, 391);
            this.DGVCultures.TabIndex = 1;
            // 
            // BtnHelp
            // 
            this.BtnHelp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnHelp.Location = new System.Drawing.Point(757, 13);
            this.BtnHelp.Name = "BtnHelp";
            this.BtnHelp.Size = new System.Drawing.Size(28, 28);
            this.BtnHelp.TabIndex = 2;
            this.BtnHelp.Text = "?";
            this.BtnHelp.UseVisualStyleBackColor = true;
            this.BtnHelp.Click += new System.EventHandler(this.BtnHelp_Click);
            // 
            // TCount
            // 
            this.TCount.AutoSize = true;
            this.TCount.Location = new System.Drawing.Point(310, 17);
            this.TCount.Name = "TCount";
            this.TCount.Size = new System.Drawing.Size(0, 20);
            this.TCount.TabIndex = 3;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TCount);
            this.Controls.Add(this.BtnHelp);
            this.Controls.Add(this.DGVCultures);
            this.Controls.Add(this.CBCultureType);
            this.DoubleBuffered = true;
            this.Name = "MainForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.DGVCultures)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CBCultureType;
        private System.Windows.Forms.DataGridView DGVCultures;
        private System.Windows.Forms.Button BtnHelp;
        private System.Windows.Forms.Label TCount;
    }
}

