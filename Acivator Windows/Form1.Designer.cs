using System;

namespace Acivator_Windows
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnActivateWindows = new System.Windows.Forms.Button();
            this.btn_activateOffice = new System.Windows.Forms.Button();
            this.rb_hwid = new System.Windows.Forms.RadioButton();
            this.rb_kms38 = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rb_Ohook = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnActivateWindows
            // 
            this.btnActivateWindows.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnActivateWindows.FlatAppearance.BorderColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.btnActivateWindows.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActivateWindows.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnActivateWindows.ForeColor = System.Drawing.Color.White;
            this.btnActivateWindows.Location = new System.Drawing.Point(23, 12);
            this.btnActivateWindows.Name = "btnActivateWindows";
            this.btnActivateWindows.Size = new System.Drawing.Size(284, 50);
            this.btnActivateWindows.TabIndex = 0;
            this.btnActivateWindows.Text = "Activate Windows";
            this.btnActivateWindows.UseVisualStyleBackColor = false;
            this.btnActivateWindows.Click += new System.EventHandler(this.btn_ActivateWindows_Click_1);
            // 
            // btn_activateOffice
            // 
            this.btn_activateOffice.BackColor = System.Drawing.Color.Gray;
            this.btn_activateOffice.Enabled = false;
            this.btn_activateOffice.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_activateOffice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_activateOffice.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btn_activateOffice.ForeColor = System.Drawing.Color.White;
            this.btn_activateOffice.Location = new System.Drawing.Point(23, 88);
            this.btn_activateOffice.Name = "btn_activateOffice";
            this.btn_activateOffice.Size = new System.Drawing.Size(284, 48);
            this.btn_activateOffice.TabIndex = 1;
            this.btn_activateOffice.Text = "Activate Office";
            this.btn_activateOffice.UseVisualStyleBackColor = false;
            this.btn_activateOffice.Click += new System.EventHandler(this.ActivateOffice_Click);
            // 
            // rb_hwid
            // 
            this.rb_hwid.AutoSize = true;
            this.rb_hwid.Checked = true;
            this.rb_hwid.Location = new System.Drawing.Point(25, 19);
            this.rb_hwid.Name = "rb_hwid";
            this.rb_hwid.Size = new System.Drawing.Size(63, 21);
            this.rb_hwid.TabIndex = 2;
            this.rb_hwid.TabStop = true;
            this.rb_hwid.Text = "HWID";
            this.rb_hwid.UseVisualStyleBackColor = true;
            this.rb_hwid.CheckedChanged += new System.EventHandler(this.rb_hwid_CheckedChanged);
            // 
            // rb_kms38
            // 
            this.rb_kms38.AutoSize = true;
            this.rb_kms38.Location = new System.Drawing.Point(114, 19);
            this.rb_kms38.Name = "rb_kms38";
            this.rb_kms38.Size = new System.Drawing.Size(67, 21);
            this.rb_kms38.TabIndex = 3;
            this.rb_kms38.Text = "KMS38";
            this.rb_kms38.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rb_Ohook);
            this.groupBox1.Controls.Add(this.rb_kms38);
            this.groupBox1.Controls.Add(this.rb_hwid);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.groupBox1.Location = new System.Drawing.Point(330, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(293, 124);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Активация";
            // 
            // rb_Ohook
            // 
            this.rb_Ohook.AutoSize = true;
            this.rb_Ohook.Location = new System.Drawing.Point(200, 19);
            this.rb_Ohook.Name = "rb_Ohook";
            this.rb_Ohook.Size = new System.Drawing.Size(67, 21);
            this.rb_Ohook.TabIndex = 4;
            this.rb_Ohook.Text = "Ohook";
            this.rb_Ohook.UseVisualStyleBackColor = true;
            this.rb_Ohook.CheckedChanged += new System.EventHandler(this.rb_Ohook_CheckedChanged_1);
            // 
            // Form1
            // 
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(642, 161);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_activateOffice);
            this.Controls.Add(this.btnActivateWindows);
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Activator Windows";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnActivateWindows;
        private System.Windows.Forms.Button btn_activateOffice;
        private System.Windows.Forms.RadioButton rb_hwid;
        private System.Windows.Forms.RadioButton rb_kms38;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rb_Ohook;
    }
}

