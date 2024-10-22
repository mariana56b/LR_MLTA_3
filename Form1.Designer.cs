namespace LR_MLTA_3
{
    partial class fMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fMain));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnFloyd = new System.Windows.Forms.Button();
            this.btnDijkstra = new System.Windows.Forms.Button();
            this.tbResult = new System.Windows.Forms.TextBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.cmbStartVertex = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(15, 15);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(344, 430);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnFloyd
            // 
            this.btnFloyd.Location = new System.Drawing.Point(373, 198);
            this.btnFloyd.Name = "btnFloyd";
            this.btnFloyd.Size = new System.Drawing.Size(276, 43);
            this.btnFloyd.TabIndex = 1;
            this.btnFloyd.Text = "Алгоритм Флойда";
            this.btnFloyd.UseVisualStyleBackColor = true;
            this.btnFloyd.Click += new System.EventHandler(this.btnFloyd_Click);
            // 
            // btnDijkstra
            // 
            this.btnDijkstra.Location = new System.Drawing.Point(13, 115);
            this.btnDijkstra.Name = "btnDijkstra";
            this.btnDijkstra.Size = new System.Drawing.Size(257, 43);
            this.btnDijkstra.TabIndex = 0;
            this.btnDijkstra.Text = "Алгоритм Дейкстри";
            this.btnDijkstra.UseVisualStyleBackColor = true;
            this.btnDijkstra.Click += new System.EventHandler(this.btnDijkstra_Click);
            // 
            // tbResult
            // 
            this.tbResult.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.tbResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbResult.Location = new System.Drawing.Point(656, 16);
            this.tbResult.Margin = new System.Windows.Forms.Padding(4);
            this.tbResult.Multiline = true;
            this.tbResult.Name = "tbResult";
            this.tbResult.ReadOnly = true;
            this.tbResult.Size = new System.Drawing.Size(518, 430);
            this.tbResult.TabIndex = 2;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(367, 405);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(282, 41);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Вихід";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // cmbStartVertex
            // 
            this.cmbStartVertex.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cmbStartVertex.FormattingEnabled = true;
            this.cmbStartVertex.Location = new System.Drawing.Point(13, 76);
            this.cmbStartVertex.Name = "cmbStartVertex";
            this.cmbStartVertex.Size = new System.Drawing.Size(257, 33);
            this.cmbStartVertex.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(9, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(232, 44);
            this.label1.TabIndex = 5;
            this.label1.Text = "Оберіть стартову вершину\r\n для алгоритма Дейкстри";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnDijkstra);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cmbStartVertex);
            this.groupBox1.Location = new System.Drawing.Point(373, 16);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(276, 176);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Алгоритм Дейкстри";
            // 
            // fMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 458);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnFloyd);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tbResult);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "fMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Пошук найкоротших шляхів на графах ";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox tbResult;
        private System.Windows.Forms.Button btnDijkstra;
        private System.Windows.Forms.Button btnFloyd;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.ComboBox cmbStartVertex;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

