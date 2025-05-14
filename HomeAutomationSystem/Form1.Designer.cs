namespace HomeAutomationSystem
{
    partial class Form1
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
            this.cmbRooms = new System.Windows.Forms.ComboBox();
            this.chkLight = new System.Windows.Forms.CheckBox();
            this.chkHeater = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnIncTemp = new System.Windows.Forms.Button();
            this.btnDecTemp = new System.Windows.Forms.Button();
            this.btnApply = new System.Windows.Forms.Button();
            this.lblTemp = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // cmbRooms
            // 
            this.cmbRooms.FormattingEnabled = true;
            this.cmbRooms.Location = new System.Drawing.Point(193, 132);
            this.cmbRooms.Name = "cmbRooms";
            this.cmbRooms.Size = new System.Drawing.Size(121, 24);
            this.cmbRooms.TabIndex = 0;
            this.cmbRooms.SelectedIndexChanged += new System.EventHandler(this.cmbRooms_SelectedIndexChanged);
            // 
            // chkLight
            // 
            this.chkLight.AutoSize = true;
            this.chkLight.Location = new System.Drawing.Point(248, 287);
            this.chkLight.Name = "chkLight";
            this.chkLight.Size = new System.Drawing.Size(94, 20);
            this.chkLight.TabIndex = 1;
            this.chkLight.Text = "Light On/Of";
            this.chkLight.UseVisualStyleBackColor = true;
            // 
            // chkHeater
            // 
            this.chkHeater.AutoSize = true;
            this.chkHeater.Location = new System.Drawing.Point(248, 324);
            this.chkHeater.Name = "chkHeater";
            this.chkHeater.Size = new System.Drawing.Size(107, 20);
            this.chkHeater.TabIndex = 2;
            this.chkHeater.Text = "Heater On/Of";
            this.chkHeater.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(83, 140);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Select Room:";
            // 
            // btnIncTemp
            // 
            this.btnIncTemp.Location = new System.Drawing.Point(86, 206);
            this.btnIncTemp.Name = "btnIncTemp";
            this.btnIncTemp.Size = new System.Drawing.Size(130, 32);
            this.btnIncTemp.TabIndex = 4;
            this.btnIncTemp.Text = "Increase Temp";
            this.btnIncTemp.UseVisualStyleBackColor = true;
            this.btnIncTemp.Click += new System.EventHandler(this.btnIncTemp_Click);
            // 
            // btnDecTemp
            // 
            this.btnDecTemp.Location = new System.Drawing.Point(239, 206);
            this.btnDecTemp.Name = "btnDecTemp";
            this.btnDecTemp.Size = new System.Drawing.Size(116, 32);
            this.btnDecTemp.TabIndex = 5;
            this.btnDecTemp.Text = "Decrease Temp";
            this.btnDecTemp.UseVisualStyleBackColor = true;
            this.btnDecTemp.Click += new System.EventHandler(this.btnDecTemp_Click);
            // 
            // btnApply
            // 
            this.btnApply.Location = new System.Drawing.Point(386, 206);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(107, 32);
            this.btnApply.TabIndex = 6;
            this.btnApply.Text = "Apply ";
            this.btnApply.UseVisualStyleBackColor = true;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // lblTemp
            // 
            this.lblTemp.AutoSize = true;
            this.lblTemp.Location = new System.Drawing.Point(392, 140);
            this.lblTemp.Name = "lblTemp";
            this.lblTemp.Size = new System.Drawing.Size(0, 16);
            this.lblTemp.TabIndex = 7;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1490, 623);
            this.Controls.Add(this.lblTemp);
            this.Controls.Add(this.btnApply);
            this.Controls.Add(this.btnDecTemp);
            this.Controls.Add(this.btnIncTemp);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chkHeater);
            this.Controls.Add(this.chkLight);
            this.Controls.Add(this.cmbRooms);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cmbRooms;
        private System.Windows.Forms.CheckBox chkLight;
        private System.Windows.Forms.CheckBox chkHeater;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnIncTemp;
        private System.Windows.Forms.Button btnDecTemp;
        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.Label lblTemp;
        private System.Windows.Forms.Timer timer1;
    }
}

