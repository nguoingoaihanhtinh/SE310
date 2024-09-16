namespace Farmer
{
    partial class MainForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtCow = new System.Windows.Forms.TextBox();
            this.txtSheep = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtGoat = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnOut = new System.Windows.Forms.Button();
            this.lblSounds = new System.Windows.Forms.Label();
            this.btnChild = new System.Windows.Forms.Button();
            this.lblShow = new System.Windows.Forms.Label();
            this.btnInfo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "số bò";
            // 
            // txtCow
            // 
            this.txtCow.Location = new System.Drawing.Point(53, 13);
            this.txtCow.Name = "txtCow";
            this.txtCow.Size = new System.Drawing.Size(100, 20);
            this.txtCow.TabIndex = 1;
            this.txtCow.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtSheep
            // 
            this.txtSheep.Location = new System.Drawing.Point(53, 39);
            this.txtSheep.Name = "txtSheep";
            this.txtSheep.Size = new System.Drawing.Size(100, 20);
            this.txtSheep.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "số cừu";
            // 
            // txtGoat
            // 
            this.txtGoat.Location = new System.Drawing.Point(53, 65);
            this.txtGoat.Name = "txtGoat";
            this.txtGoat.Size = new System.Drawing.Size(100, 20);
            this.txtGoat.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "số dê";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(16, 102);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(102, 23);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "thêm động vật";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click_1);
            // 
            // btnOut
            // 
            this.btnOut.Location = new System.Drawing.Point(176, 13);
            this.btnOut.Name = "btnOut";
            this.btnOut.Size = new System.Drawing.Size(102, 23);
            this.btnOut.TabIndex = 7;
            this.btnOut.Text = "hiện tiếng kêu";
            this.btnOut.UseVisualStyleBackColor = true;
            this.btnOut.Click += new System.EventHandler(this.btnOut_Click);
            // 
            // lblSounds
            // 
            this.lblSounds.AutoSize = true;
            this.lblSounds.Location = new System.Drawing.Point(173, 42);
            this.lblSounds.Name = "lblSounds";
            this.lblSounds.Padding = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.lblSounds.Size = new System.Drawing.Size(51, 19);
            this.lblSounds.TabIndex = 8;
            this.lblSounds.Text = "tiếng kêu";
            // 
            // btnChild
            // 
            this.btnChild.Location = new System.Drawing.Point(124, 102);
            this.btnChild.Name = "btnChild";
            this.btnChild.Size = new System.Drawing.Size(75, 23);
            this.btnChild.TabIndex = 9;
            this.btnChild.Text = "sinh con";
            this.btnChild.UseVisualStyleBackColor = true;
            this.btnChild.Click += new System.EventHandler(this.btnChild_Click);
            // 
            // lblShow
            // 
            this.lblShow.AutoSize = true;
            this.lblShow.Location = new System.Drawing.Point(518, 42);
            this.lblShow.Name = "lblShow";
            this.lblShow.Padding = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.lblShow.Size = new System.Drawing.Size(49, 19);
            this.lblShow.TabIndex = 10;
            this.lblShow.Text = "thống kê";
            this.lblShow.Click += new System.EventHandler(this.lblShow_Click);
            // 
            // btnInfo
            // 
            this.btnInfo.Location = new System.Drawing.Point(506, 13);
            this.btnInfo.Name = "btnInfo";
            this.btnInfo.Size = new System.Drawing.Size(75, 23);
            this.btnInfo.TabIndex = 11;
            this.btnInfo.Text = "thống kê";
            this.btnInfo.UseVisualStyleBackColor = true;
            this.btnInfo.Click += new System.EventHandler(this.btnInfo_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnInfo);
            this.Controls.Add(this.lblShow);
            this.Controls.Add(this.btnChild);
            this.Controls.Add(this.lblSounds);
            this.Controls.Add(this.btnOut);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtGoat);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtSheep);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCow);
            this.Controls.Add(this.label1);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Click += new System.EventHandler(this.MainForm_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCow;
        private System.Windows.Forms.TextBox txtSheep;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtGoat;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnOut;
        private System.Windows.Forms.Label lblSounds;
        private System.Windows.Forms.Button btnChild;
        private System.Windows.Forms.Label lblShow;
        private System.Windows.Forms.Button btnInfo;
    }
}

