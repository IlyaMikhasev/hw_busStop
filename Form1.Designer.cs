namespace hw_busStop
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
            this.label1 = new System.Windows.Forms.Label();
            this.l_people = new System.Windows.Forms.Label();
            this.b_start = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cb_timeBus = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Количество людей на остановке";
            // 
            // l_people
            // 
            this.l_people.AutoSize = true;
            this.l_people.Location = new System.Drawing.Point(252, 23);
            this.l_people.Name = "l_people";
            this.l_people.Size = new System.Drawing.Size(13, 13);
            this.l_people.TabIndex = 1;
            this.l_people.Text = "0";
            // 
            // b_start
            // 
            this.b_start.Location = new System.Drawing.Point(23, 141);
            this.b_start.Name = "b_start";
            this.b_start.Size = new System.Drawing.Size(75, 23);
            this.b_start.TabIndex = 2;
            this.b_start.Text = "Start";
            this.b_start.UseVisualStyleBackColor = true;
            this.b_start.Click += new System.EventHandler(this.b_start_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "автобус забрал людей в ";
            // 
            // cb_timeBus
            // 
            this.cb_timeBus.FormattingEnabled = true;
            this.cb_timeBus.Location = new System.Drawing.Point(171, 68);
            this.cb_timeBus.Name = "cb_timeBus";
            this.cb_timeBus.Size = new System.Drawing.Size(94, 21);
            this.cb_timeBus.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(347, 176);
            this.Controls.Add(this.cb_timeBus);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.b_start);
            this.Controls.Add(this.l_people);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Конечная остановка 175 АВтобуса";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label l_people;
        private System.Windows.Forms.Button b_start;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cb_timeBus;
    }
}

