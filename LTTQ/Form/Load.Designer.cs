
namespace LTTQ
{
    partial class Load
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
            this.lbload = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.process = new Guna.UI2.WinForms.Guna2WinProgressIndicator();
            this.lbtime = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lbload.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbload
            // 
            this.lbload.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(23)))), ((int)(((byte)(75)))));
            this.lbload.Controls.Add(this.label1);
            this.lbload.Controls.Add(this.process);
            this.lbload.Controls.Add(this.lbtime);
            this.lbload.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbload.Location = new System.Drawing.Point(0, 0);
            this.lbload.Name = "lbload";
            this.lbload.Size = new System.Drawing.Size(1331, 782);
            this.lbload.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.label1.Location = new System.Drawing.Point(602, 386);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 29);
            this.label1.TabIndex = 13;
            this.label1.Text = "Loadding...";
            // 
            // process
            // 
            this.process.Location = new System.Drawing.Point(583, 222);
            this.process.Name = "process";
            this.process.ShadowDecoration.Parent = this.process;
            this.process.Size = new System.Drawing.Size(163, 146);
            this.process.TabIndex = 12;
            // 
            // lbtime
            // 
            this.lbtime.AutoSize = true;
            this.lbtime.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbtime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.lbtime.Location = new System.Drawing.Point(641, 443);
            this.lbtime.Name = "lbtime";
            this.lbtime.Size = new System.Drawing.Size(81, 29);
            this.lbtime.TabIndex = 11;
            this.lbtime.Text = "label1";
            // 
            // timer1
            // 
            this.timer1.Interval = 5;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Load
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1331, 782);
            this.Controls.Add(this.lbload);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Load";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Load";
            this.Load += new System.EventHandler(this.Load_Load);
            this.lbload.ResumeLayout(false);
            this.lbload.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel lbload;
        private System.Windows.Forms.Label lbtime;
        private System.Windows.Forms.Timer timer1;
        private Guna.UI2.WinForms.Guna2WinProgressIndicator process;
        private System.Windows.Forms.Label label1;
    }
}