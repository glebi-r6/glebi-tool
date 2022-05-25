namespace NoRecoil
{
    partial class gui
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            //base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(gui));
            this.lblStep = new System.Windows.Forms.Label();
            this.lblDelay = new System.Windows.Forms.Label();
            this.lblIncrease = new System.Windows.Forms.Label();
            this.tbStep = new System.Windows.Forms.TrackBar();
            this.tbDelay = new System.Windows.Forms.TrackBar();
            this.tbIncrease = new System.Windows.Forms.TrackBar();
            this.lblState = new System.Windows.Forms.Label();
            this.lblMax = new System.Windows.Forms.Label();
            this.tbMax = new System.Windows.Forms.TrackBar();
            this.pbRefresh = new System.Windows.Forms.PictureBox();
            this.cbChroma = new System.Windows.Forms.CheckBox();
            this.cbConfigs = new System.Windows.Forms.ComboBox();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtCFG = new System.Windows.Forms.TextBox();
            this.btnCloseBasic = new System.Windows.Forms.PictureBox();
            this.btnMinimize = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.tbStep)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbDelay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbIncrease)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRefresh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCloseBasic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimize)).BeginInit();
            this.SuspendLayout();
            // 
            // lblStep
            // 
            this.lblStep.AutoSize = true;
            this.lblStep.ForeColor = System.Drawing.Color.Red;
            this.lblStep.Location = new System.Drawing.Point(38, 46);
            this.lblStep.Name = "lblStep";
            this.lblStep.Size = new System.Drawing.Size(77, 15);
            this.lblStep.TabIndex = 0;
            this.lblStep.Text = "Step[100]:";
            // 
            // lblDelay
            // 
            this.lblDelay.AutoSize = true;
            this.lblDelay.ForeColor = System.Drawing.Color.Red;
            this.lblDelay.Location = new System.Drawing.Point(31, 97);
            this.lblDelay.Name = "lblDelay";
            this.lblDelay.Size = new System.Drawing.Size(84, 15);
            this.lblDelay.TabIndex = 1;
            this.lblDelay.Text = "Delay[100]:";
            // 
            // lblIncrease
            // 
            this.lblIncrease.AutoSize = true;
            this.lblIncrease.ForeColor = System.Drawing.Color.Red;
            this.lblIncrease.Location = new System.Drawing.Point(10, 148);
            this.lblIncrease.Name = "lblIncrease";
            this.lblIncrease.Size = new System.Drawing.Size(105, 15);
            this.lblIncrease.TabIndex = 2;
            this.lblIncrease.Text = "Increase[100]:";
            this.lblIncrease.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // tbStep
            // 
            this.tbStep.Location = new System.Drawing.Point(121, 46);
            this.tbStep.Maximum = 20;
            this.tbStep.Minimum = 1;
            this.tbStep.Name = "tbStep";
            this.tbStep.Size = new System.Drawing.Size(197, 45);
            this.tbStep.TabIndex = 3;
            this.tbStep.TickStyle = System.Windows.Forms.TickStyle.None;
            this.tbStep.Value = 1;
            // 
            // tbDelay
            // 
            this.tbDelay.Location = new System.Drawing.Point(121, 97);
            this.tbDelay.Maximum = 500;
            this.tbDelay.Minimum = 1;
            this.tbDelay.Name = "tbDelay";
            this.tbDelay.Size = new System.Drawing.Size(197, 45);
            this.tbDelay.TabIndex = 3;
            this.tbDelay.TickStyle = System.Windows.Forms.TickStyle.None;
            this.tbDelay.Value = 1;
            // 
            // tbIncrease
            // 
            this.tbIncrease.Location = new System.Drawing.Point(121, 148);
            this.tbIncrease.Name = "tbIncrease";
            this.tbIncrease.Size = new System.Drawing.Size(197, 45);
            this.tbIncrease.TabIndex = 3;
            this.tbIncrease.TickStyle = System.Windows.Forms.TickStyle.None;
            // 
            // lblState
            // 
            this.lblState.AutoSize = true;
            this.lblState.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblState.ForeColor = System.Drawing.Color.Red;
            this.lblState.Location = new System.Drawing.Point(10, 254);
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(49, 15);
            this.lblState.TabIndex = 4;
            this.lblState.Text = "label1";
            // 
            // lblMax
            // 
            this.lblMax.AutoSize = true;
            this.lblMax.ForeColor = System.Drawing.Color.Red;
            this.lblMax.Location = new System.Drawing.Point(10, 199);
            this.lblMax.Name = "lblMax";
            this.lblMax.Size = new System.Drawing.Size(105, 15);
            this.lblMax.TabIndex = 2;
            this.lblMax.Text = "Max Inc.[100]:";
            this.lblMax.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // tbMax
            // 
            this.tbMax.Location = new System.Drawing.Point(121, 199);
            this.tbMax.Maximum = 30;
            this.tbMax.Name = "tbMax";
            this.tbMax.Size = new System.Drawing.Size(197, 45);
            this.tbMax.TabIndex = 3;
            this.tbMax.TickStyle = System.Windows.Forms.TickStyle.None;
            // 
            // pbRefresh
            // 
            this.pbRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbRefresh.Location = new System.Drawing.Point(316, 269);
            this.pbRefresh.Name = "pbRefresh";
            this.pbRefresh.Size = new System.Drawing.Size(30, 30);
            this.pbRefresh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbRefresh.TabIndex = 12;
            this.pbRefresh.TabStop = false;
            this.pbRefresh.Visible = false;
            this.pbRefresh.Click += new System.EventHandler(this.pbRefresh_Click);
            // 
            // cbChroma
            // 
            this.cbChroma.AutoSize = true;
            this.cbChroma.Location = new System.Drawing.Point(378, 273);
            this.cbChroma.Name = "cbChroma";
            this.cbChroma.Size = new System.Drawing.Size(110, 19);
            this.cbChroma.TabIndex = 13;
            this.cbChroma.Text = "Razer Chroma";
            this.cbChroma.UseVisualStyleBackColor = true;
            this.cbChroma.Visible = false;
            this.cbChroma.CheckedChanged += new System.EventHandler(this.cbChroma_CheckedChanged);
            // 
            // cbConfigs
            // 
            this.cbConfigs.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbConfigs.Location = new System.Drawing.Point(305, 275);
            this.cbConfigs.Name = "cbConfigs";
            this.cbConfigs.Size = new System.Drawing.Size(146, 23);
            this.cbConfigs.TabIndex = 5;
            this.cbConfigs.Visible = false;
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(377, 196);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(75, 23);
            this.btnLoad.TabIndex = 6;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Visible = false;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(305, 276);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Visible = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(377, 225);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 8;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Visible = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(316, 275);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 9;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Visible = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtCFG
            // 
            this.txtCFG.Location = new System.Drawing.Point(305, 276);
            this.txtCFG.Name = "txtCFG";
            this.txtCFG.Size = new System.Drawing.Size(146, 23);
            this.txtCFG.TabIndex = 10;
            this.txtCFG.Visible = false;
            // 
            // btnCloseBasic
            // 
            this.btnCloseBasic.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCloseBasic.Image = ((System.Drawing.Image)(resources.GetObject("btnCloseBasic.Image")));
            this.btnCloseBasic.Location = new System.Drawing.Point(291, 12);
            this.btnCloseBasic.Name = "btnCloseBasic";
            this.btnCloseBasic.Size = new System.Drawing.Size(18, 20);
            this.btnCloseBasic.TabIndex = 15;
            this.btnCloseBasic.TabStop = false;
            this.btnCloseBasic.Click += new System.EventHandler(this.btnCloseBasic_Click);
            // 
            // btnMinimize
            // 
            this.btnMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimize.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimize.Image")));
            this.btnMinimize.Location = new System.Drawing.Point(264, 7);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(21, 23);
            this.btnMinimize.TabIndex = 14;
            this.btnMinimize.TabStop = false;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // gui
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(330, 281);
            this.Controls.Add(this.btnCloseBasic);
            this.Controls.Add(this.btnMinimize);
            this.Controls.Add(this.cbChroma);
            this.Controls.Add(this.pbRefresh);
            this.Controls.Add(this.txtCFG);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.cbConfigs);
            this.Controls.Add(this.lblState);
            this.Controls.Add(this.tbMax);
            this.Controls.Add(this.tbIncrease);
            this.Controls.Add(this.tbDelay);
            this.Controls.Add(this.lblMax);
            this.Controls.Add(this.tbStep);
            this.Controls.Add(this.lblIncrease);
            this.Controls.Add(this.lblDelay);
            this.Controls.Add(this.lblStep);
            this.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "gui";
            this.ShowIcon = false;
            this.Text = "NoRecoil";
            this.Load += new System.EventHandler(this.gui_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.gui_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.tbStep)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbDelay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbIncrease)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRefresh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCloseBasic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimize)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblStep;
        private System.Windows.Forms.Label lblDelay;
        private System.Windows.Forms.Label lblIncrease;
        private System.Windows.Forms.TrackBar tbStep;
        private System.Windows.Forms.TrackBar tbDelay;
        private System.Windows.Forms.TrackBar tbIncrease;
        private System.Windows.Forms.Label lblState;
        private System.Windows.Forms.Label lblMax;
        private System.Windows.Forms.TrackBar tbMax;
        private System.Windows.Forms.PictureBox pbRefresh;
        private System.Windows.Forms.CheckBox cbChroma;
        private System.Windows.Forms.ComboBox cbConfigs;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtCFG;
        private System.Windows.Forms.PictureBox btnCloseBasic;
        private System.Windows.Forms.PictureBox btnMinimize;
    }
}

