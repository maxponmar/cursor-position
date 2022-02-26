namespace cursor_position
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.x_textbox = new System.Windows.Forms.TextBox();
            this.x_label = new System.Windows.Forms.Label();
            this.y_textbox = new System.Windows.Forms.TextBox();
            this.y_label = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // x_textbox
            // 
            this.x_textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.x_textbox.Location = new System.Drawing.Point(49, 12);
            this.x_textbox.Name = "x_textbox";
            this.x_textbox.Size = new System.Drawing.Size(185, 38);
            this.x_textbox.TabIndex = 0;
            // 
            // x_label
            // 
            this.x_label.AutoSize = true;
            this.x_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.x_label.Location = new System.Drawing.Point(12, 18);
            this.x_label.Name = "x_label";
            this.x_label.Size = new System.Drawing.Size(31, 29);
            this.x_label.TabIndex = 1;
            this.x_label.Text = "X";
            // 
            // y_textbox
            // 
            this.y_textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.y_textbox.Location = new System.Drawing.Point(49, 56);
            this.y_textbox.Name = "y_textbox";
            this.y_textbox.Size = new System.Drawing.Size(185, 38);
            this.y_textbox.TabIndex = 0;
            // 
            // y_label
            // 
            this.y_label.AutoSize = true;
            this.y_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.y_label.Location = new System.Drawing.Point(12, 62);
            this.y_label.Name = "y_label";
            this.y_label.Size = new System.Drawing.Size(30, 29);
            this.y_label.TabIndex = 1;
            this.y_label.Text = "Y";
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 1;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(246, 107);
            this.Controls.Add(this.y_label);
            this.Controls.Add(this.x_label);
            this.Controls.Add(this.y_textbox);
            this.Controls.Add(this.x_textbox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Cursor Position";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox x_textbox;
        private System.Windows.Forms.Label x_label;
        private System.Windows.Forms.TextBox y_textbox;
        private System.Windows.Forms.Label y_label;
        private System.Windows.Forms.Timer timer;
    }
}

