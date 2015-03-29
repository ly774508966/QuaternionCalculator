namespace QuaternionCalculator
{
    partial class MainScreen
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtQX = new System.Windows.Forms.TextBox();
            this.txtQY = new System.Windows.Forms.TextBox();
            this.txtQZ = new System.Windows.Forms.TextBox();
            this.txtQW = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.grid = new System.Windows.Forms.DataGridView();
            this.ActionId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ActionDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Degrees = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnDown = new System.Windows.Forms.Button();
            this.btnUp = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.githubLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 105);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Quaternion X";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(168, 105);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 13);
            this.label8.TabIndex = 10;
            this.label8.Text = "Quaternion Y";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(480, 105);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(73, 13);
            this.label9.TabIndex = 12;
            this.label9.Text = "Quaternion W";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(324, 105);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(69, 13);
            this.label10.TabIndex = 11;
            this.label10.Text = "Quaternion Z";
            // 
            // txtQX
            // 
            this.txtQX.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtQX.Location = new System.Drawing.Point(15, 121);
            this.txtQX.Name = "txtQX";
            this.txtQX.ReadOnly = true;
            this.txtQX.Size = new System.Drawing.Size(150, 20);
            this.txtQX.TabIndex = 13;
            this.txtQX.TabStop = false;
            // 
            // txtQY
            // 
            this.txtQY.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtQY.Location = new System.Drawing.Point(171, 121);
            this.txtQY.Name = "txtQY";
            this.txtQY.ReadOnly = true;
            this.txtQY.Size = new System.Drawing.Size(150, 20);
            this.txtQY.TabIndex = 14;
            this.txtQY.TabStop = false;
            // 
            // txtQZ
            // 
            this.txtQZ.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtQZ.Location = new System.Drawing.Point(327, 121);
            this.txtQZ.Name = "txtQZ";
            this.txtQZ.ReadOnly = true;
            this.txtQZ.Size = new System.Drawing.Size(150, 20);
            this.txtQZ.TabIndex = 15;
            this.txtQZ.TabStop = false;
            // 
            // txtQW
            // 
            this.txtQW.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtQW.Location = new System.Drawing.Point(483, 121);
            this.txtQW.Name = "txtQW";
            this.txtQW.ReadOnly = true;
            this.txtQW.Size = new System.Drawing.Size(150, 20);
            this.txtQW.TabIndex = 16;
            this.txtQW.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(409, 44);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(148, 23);
            this.button1.TabIndex = 17;
            this.button1.Text = "Copy XML to Clipboard";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.OnCopyXmlClick);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(409, 69);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(148, 23);
            this.button2.TabIndex = 18;
            this.button2.Text = "Copy Text to Clipboard";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.OnCopyClick);
            // 
            // grid
            // 
            this.grid.AllowUserToAddRows = false;
            this.grid.AllowUserToDeleteRows = false;
            this.grid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ActionId,
            this.ActionDescription,
            this.Degrees});
            this.grid.Location = new System.Drawing.Point(34, 9);
            this.grid.Name = "grid";
            this.grid.RowHeadersVisible = false;
            this.grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grid.ShowEditingIcon = false;
            this.grid.ShowRowErrors = false;
            this.grid.Size = new System.Drawing.Size(306, 83);
            this.grid.TabIndex = 1;
            // 
            // ActionId
            // 
            this.ActionId.HeaderText = "ID";
            this.ActionId.Name = "ActionId";
            this.ActionId.ReadOnly = true;
            this.ActionId.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ActionId.Visible = false;
            // 
            // ActionDescription
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightSteelBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ActionDescription.DefaultCellStyle = dataGridViewCellStyle1;
            this.ActionDescription.FillWeight = 60F;
            this.ActionDescription.HeaderText = "Action";
            this.ActionDescription.MinimumWidth = 150;
            this.ActionDescription.Name = "ActionDescription";
            this.ActionDescription.ReadOnly = true;
            this.ActionDescription.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Degrees
            // 
            this.Degrees.FillWeight = 40F;
            this.Degrees.HeaderText = "Degrees";
            this.Degrees.MinimumWidth = 50;
            this.Degrees.Name = "Degrees";
            this.Degrees.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // btnDown
            // 
            this.btnDown.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnDown.Location = new System.Drawing.Point(346, 62);
            this.btnDown.Name = "btnDown";
            this.btnDown.Size = new System.Drawing.Size(26, 30);
            this.btnDown.TabIndex = 20;
            this.btnDown.Text = "▼";
            this.btnDown.UseVisualStyleBackColor = true;
            this.btnDown.Click += new System.EventHandler(this.OnButtonDownClick);
            // 
            // btnUp
            // 
            this.btnUp.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnUp.Location = new System.Drawing.Point(346, 30);
            this.btnUp.Name = "btnUp";
            this.btnUp.Size = new System.Drawing.Size(26, 30);
            this.btnUp.TabIndex = 21;
            this.btnUp.Text = "▲";
            this.btnUp.UseVisualStyleBackColor = true;
            this.btnUp.Click += new System.EventHandler(this.OnButtonUpClick);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(559, 44);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(74, 23);
            this.button3.TabIndex = 22;
            this.button3.Text = "Hint";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.OnHintClick);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(559, 69);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(74, 23);
            this.button4.TabIndex = 23;
            this.button4.Text = "Clear";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.OnClearClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = "1.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 13);
            this.label2.TabIndex = 25;
            this.label2.Text = "2.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(16, 13);
            this.label3.TabIndex = 26;
            this.label3.Text = "3.";
            // 
            // githubLabel
            // 
            this.githubLabel.AutoSize = true;
            this.githubLabel.Location = new System.Drawing.Point(352, 150);
            this.githubLabel.Name = "githubLabel";
            this.githubLabel.Size = new System.Drawing.Size(281, 13);
            this.githubLabel.TabIndex = 27;
            this.githubLabel.Text = "https://github.com/Atropin/QuaternionCalculator/releases";
            this.githubLabel.Click += new System.EventHandler(this.OnGitLinkClick);
            this.githubLabel.MouseEnter += new System.EventHandler(this.OnGitLinkMouseEnter);
            this.githubLabel.MouseLeave += new System.EventHandler(this.OnGitLinkMouseLeave);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(346, 14);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 13);
            this.label5.TabIndex = 28;
            this.label5.Text = "Order";
            // 
            // MainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(654, 172);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.githubLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnUp);
            this.Controls.Add(this.btnDown);
            this.Controls.Add(this.grid);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtQW);
            this.Controls.Add(this.txtQZ);
            this.Controls.Add(this.txtQY);
            this.Controls.Add(this.txtQX);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(660, 190);
            this.Name = "MainScreen";
            this.Text = "Quaternion Calculation";
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtQX;
        private System.Windows.Forms.TextBox txtQY;
        private System.Windows.Forms.TextBox txtQZ;
        private System.Windows.Forms.TextBox txtQW;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView grid;
        private System.Windows.Forms.Button btnDown;
        private System.Windows.Forms.Button btnUp;
        private System.Windows.Forms.DataGridViewTextBoxColumn ActionId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ActionDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn Degrees;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label githubLabel;
        private System.Windows.Forms.Label label5;
    }
}

