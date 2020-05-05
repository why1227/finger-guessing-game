namespace finger_guessing_game
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
            this.label_player = new System.Windows.Forms.Label();
            this.label_computer = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label_result = new System.Windows.Forms.Label();
            this.button_jiandao = new System.Windows.Forms.Button();
            this.button_shitou = new System.Windows.Forms.Button();
            this.button_bu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "玩家：";
            // 
            // label_player
            // 
            this.label_player.AutoSize = true;
            this.label_player.Location = new System.Drawing.Point(109, 37);
            this.label_player.Name = "label_player";
            this.label_player.Size = new System.Drawing.Size(41, 12);
            this.label_player.TabIndex = 1;
            this.label_player.Text = "玩家出";
            // 
            // label_computer
            // 
            this.label_computer.AutoSize = true;
            this.label_computer.Location = new System.Drawing.Point(462, 37);
            this.label_computer.Name = "label_computer";
            this.label_computer.Size = new System.Drawing.Size(41, 12);
            this.label_computer.TabIndex = 3;
            this.label_computer.Text = "电脑出";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(395, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 2;
            this.label4.Text = "电脑：";
            // 
            // label_result
            // 
            this.label_result.AutoSize = true;
            this.label_result.Location = new System.Drawing.Point(261, 154);
            this.label_result.Name = "label_result";
            this.label_result.Size = new System.Drawing.Size(29, 12);
            this.label_result.TabIndex = 4;
            this.label_result.Text = "结果";
            // 
            // button_jiandao
            // 
            this.button_jiandao.Location = new System.Drawing.Point(75, 225);
            this.button_jiandao.Name = "button_jiandao";
            this.button_jiandao.Size = new System.Drawing.Size(75, 23);
            this.button_jiandao.TabIndex = 5;
            this.button_jiandao.Text = "剪刀";
            this.button_jiandao.UseVisualStyleBackColor = true;
            this.button_jiandao.Click += new System.EventHandler(this.button_Click);
            // 
            // button_shitou
            // 
            this.button_shitou.Location = new System.Drawing.Point(245, 225);
            this.button_shitou.Name = "button_shitou";
            this.button_shitou.Size = new System.Drawing.Size(75, 23);
            this.button_shitou.TabIndex = 6;
            this.button_shitou.Text = "石头";
            this.button_shitou.UseVisualStyleBackColor = true;
            this.button_shitou.Click += new System.EventHandler(this.button_Click);
            // 
            // button_bu
            // 
            this.button_bu.Location = new System.Drawing.Point(397, 225);
            this.button_bu.Name = "button_bu";
            this.button_bu.Size = new System.Drawing.Size(75, 23);
            this.button_bu.TabIndex = 7;
            this.button_bu.Text = "布";
            this.button_bu.UseVisualStyleBackColor = true;
            this.button_bu.Click += new System.EventHandler(this.button_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(563, 320);
            this.Controls.Add(this.button_bu);
            this.Controls.Add(this.button_shitou);
            this.Controls.Add(this.button_jiandao);
            this.Controls.Add(this.label_result);
            this.Controls.Add(this.label_computer);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label_player);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "猜拳";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_player;
        private System.Windows.Forms.Label label_computer;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label_result;
        private System.Windows.Forms.Button button_jiandao;
        private System.Windows.Forms.Button button_shitou;
        private System.Windows.Forms.Button button_bu;
    }
}

