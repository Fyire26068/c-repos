namespace FlowControl
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
            this.rollBttn = new System.Windows.Forms.Button();
            this.pLbl = new System.Windows.Forms.Label();
            this.cpuLbl = new System.Windows.Forms.Label();
            this.pRollLbl = new System.Windows.Forms.Label();
            this.cpuRollLbl = new System.Windows.Forms.Label();
            this.winLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // rollBttn
            // 
            this.rollBttn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.rollBttn.Font = new System.Drawing.Font("Century", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.rollBttn.Location = new System.Drawing.Point(201, 336);
            this.rollBttn.Name = "rollBttn";
            this.rollBttn.Size = new System.Drawing.Size(410, 61);
            this.rollBttn.TabIndex = 0;
            this.rollBttn.Text = "ROLL";
            this.rollBttn.UseVisualStyleBackColor = true;
            this.rollBttn.Click += new System.EventHandler(this.rollBttn_Click);
            // 
            // pLbl
            // 
            this.pLbl.AutoSize = true;
            this.pLbl.Font = new System.Drawing.Font("Centaur", 18F, System.Drawing.FontStyle.Bold);
            this.pLbl.Location = new System.Drawing.Point(144, 48);
            this.pLbl.Name = "pLbl";
            this.pLbl.Size = new System.Drawing.Size(138, 27);
            this.pLbl.TabIndex = 1;
            this.pLbl.Text = "Player\'s Roll";
            this.pLbl.Click += new System.EventHandler(this.label1_Click);
            // 
            // cpuLbl
            // 
            this.cpuLbl.AutoSize = true;
            this.cpuLbl.Font = new System.Drawing.Font("Centaur", 18F, System.Drawing.FontStyle.Bold);
            this.cpuLbl.Location = new System.Drawing.Point(504, 48);
            this.cpuLbl.Name = "cpuLbl";
            this.cpuLbl.Size = new System.Drawing.Size(175, 27);
            this.cpuLbl.TabIndex = 2;
            this.cpuLbl.Text = "Computer\'s Roll";
            this.cpuLbl.Click += new System.EventHandler(this.label2_Click);
            // 
            // pRollLbl
            // 
            this.pRollLbl.AutoSize = true;
            this.pRollLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.pRollLbl.Location = new System.Drawing.Point(194, 84);
            this.pRollLbl.Name = "pRollLbl";
            this.pRollLbl.Size = new System.Drawing.Size(35, 37);
            this.pRollLbl.TabIndex = 3;
            this.pRollLbl.Text = "0";
            // 
            // cpuRollLbl
            // 
            this.cpuRollLbl.AutoSize = true;
            this.cpuRollLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.cpuRollLbl.Location = new System.Drawing.Point(576, 84);
            this.cpuRollLbl.Name = "cpuRollLbl";
            this.cpuRollLbl.Size = new System.Drawing.Size(35, 37);
            this.cpuRollLbl.TabIndex = 4;
            this.cpuRollLbl.Text = "0";
            // 
            // winLbl
            // 
            this.winLbl.Font = new System.Drawing.Font("Century", 16F, System.Drawing.FontStyle.Bold);
            this.winLbl.Location = new System.Drawing.Point(-1, 284);
            this.winLbl.Name = "winLbl";
            this.winLbl.Size = new System.Drawing.Size(806, 27);
            this.winLbl.TabIndex = 5;
            this.winLbl.Text = "starting text";
            this.winLbl.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.winLbl.Visible = false;
            this.winLbl.Click += new System.EventHandler(this.winLbl_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(806, 467);
            this.Controls.Add(this.winLbl);
            this.Controls.Add(this.cpuRollLbl);
            this.Controls.Add(this.pRollLbl);
            this.Controls.Add(this.cpuLbl);
            this.Controls.Add(this.pLbl);
            this.Controls.Add(this.rollBttn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button rollBttn;
        private System.Windows.Forms.Label pLbl;
        private System.Windows.Forms.Label cpuLbl;
        private System.Windows.Forms.Label pRollLbl;
        private System.Windows.Forms.Label cpuRollLbl;
        private System.Windows.Forms.Label winLbl;
    }
}

