namespace password_hashing
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_hash = new System.Windows.Forms.Button();
            this.lbl_hashed = new System.Windows.Forms.Label();
            this.lbl_user = new System.Windows.Forms.Label();
            this.txt_user = new System.Windows.Forms.TextBox();
            this.lbl_pass = new System.Windows.Forms.Label();
            this.txt_pass = new System.Windows.Forms.TextBox();
            this.btn_copy = new System.Windows.Forms.Button();
            this.lbl_in_hash = new System.Windows.Forms.Label();
            this.txt_in_hash = new System.Windows.Forms.TextBox();
            this.btn_in_hash = new System.Windows.Forms.Button();
            this.lbl_output_decrpy = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_hash
            // 
            this.btn_hash.Location = new System.Drawing.Point(620, 58);
            this.btn_hash.Name = "btn_hash";
            this.btn_hash.Size = new System.Drawing.Size(117, 44);
            this.btn_hash.TabIndex = 0;
            this.btn_hash.Text = "Hash!";
            this.btn_hash.UseVisualStyleBackColor = true;
            this.btn_hash.Click += new System.EventHandler(this.btn_hash_Click);
            // 
            // lbl_hashed
            // 
            this.lbl_hashed.AutoSize = true;
            this.lbl_hashed.Location = new System.Drawing.Point(223, 181);
            this.lbl_hashed.Name = "lbl_hashed";
            this.lbl_hashed.Size = new System.Drawing.Size(0, 20);
            this.lbl_hashed.TabIndex = 1;
            this.lbl_hashed.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_user
            // 
            this.lbl_user.AutoSize = true;
            this.lbl_user.Location = new System.Drawing.Point(99, 65);
            this.lbl_user.Name = "lbl_user";
            this.lbl_user.Size = new System.Drawing.Size(75, 20);
            this.lbl_user.TabIndex = 2;
            this.lbl_user.Text = "Username";
            // 
            // txt_user
            // 
            this.txt_user.Location = new System.Drawing.Point(223, 58);
            this.txt_user.Name = "txt_user";
            this.txt_user.Size = new System.Drawing.Size(314, 27);
            this.txt_user.TabIndex = 3;
            // 
            // lbl_pass
            // 
            this.lbl_pass.AutoSize = true;
            this.lbl_pass.Location = new System.Drawing.Point(99, 116);
            this.lbl_pass.Name = "lbl_pass";
            this.lbl_pass.Size = new System.Drawing.Size(70, 20);
            this.lbl_pass.TabIndex = 4;
            this.lbl_pass.Text = "Password";
            // 
            // txt_pass
            // 
            this.txt_pass.Location = new System.Drawing.Point(223, 109);
            this.txt_pass.Name = "txt_pass";
            this.txt_pass.Size = new System.Drawing.Size(314, 27);
            this.txt_pass.TabIndex = 5;
            // 
            // btn_copy
            // 
            this.btn_copy.Location = new System.Drawing.Point(620, 109);
            this.btn_copy.Name = "btn_copy";
            this.btn_copy.Size = new System.Drawing.Size(117, 51);
            this.btn_copy.TabIndex = 6;
            this.btn_copy.Text = "Copy hash";
            this.btn_copy.UseVisualStyleBackColor = true;
            this.btn_copy.Click += new System.EventHandler(this.btn_copy_Click);
            // 
            // lbl_in_hash
            // 
            this.lbl_in_hash.AutoSize = true;
            this.lbl_in_hash.Location = new System.Drawing.Point(99, 246);
            this.lbl_in_hash.Name = "lbl_in_hash";
            this.lbl_in_hash.Size = new System.Drawing.Size(77, 20);
            this.lbl_in_hash.TabIndex = 7;
            this.lbl_in_hash.Text = "Input hash";
            // 
            // txt_in_hash
            // 
            this.txt_in_hash.Location = new System.Drawing.Point(223, 246);
            this.txt_in_hash.Name = "txt_in_hash";
            this.txt_in_hash.Size = new System.Drawing.Size(314, 27);
            this.txt_in_hash.TabIndex = 8;
            // 
            // btn_in_hash
            // 
            this.btn_in_hash.Location = new System.Drawing.Point(620, 246);
            this.btn_in_hash.Name = "btn_in_hash";
            this.btn_in_hash.Size = new System.Drawing.Size(117, 39);
            this.btn_in_hash.TabIndex = 9;
            this.btn_in_hash.Text = "Decrypt";
            this.btn_in_hash.UseVisualStyleBackColor = true;
            this.btn_in_hash.Click += new System.EventHandler(this.btn_in_hash_Click);
            // 
            // lbl_output_decrpy
            // 
            this.lbl_output_decrpy.AutoSize = true;
            this.lbl_output_decrpy.Location = new System.Drawing.Point(223, 307);
            this.lbl_output_decrpy.Name = "lbl_output_decrpy";
            this.lbl_output_decrpy.Size = new System.Drawing.Size(0, 20);
            this.lbl_output_decrpy.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_output_decrpy);
            this.Controls.Add(this.btn_in_hash);
            this.Controls.Add(this.txt_in_hash);
            this.Controls.Add(this.lbl_in_hash);
            this.Controls.Add(this.btn_copy);
            this.Controls.Add(this.txt_pass);
            this.Controls.Add(this.lbl_pass);
            this.Controls.Add(this.txt_user);
            this.Controls.Add(this.lbl_user);
            this.Controls.Add(this.lbl_hashed);
            this.Controls.Add(this.btn_hash);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btn_hash;
        private Label lbl_hashed;
        private Label lbl_user;
        private TextBox txt_user;
        private Label lbl_pass;
        private TextBox txt_pass;
        private Button btn_copy;
        private Label lbl_in_hash;
        private TextBox txt_in_hash;
        private Button btn_in_hash;
        private Label lbl_output_decrpy;
    }
}