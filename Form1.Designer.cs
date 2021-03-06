﻿namespace mobile_reg_form
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
            this.fieldName = new System.Windows.Forms.TextBox();
            this.fieldSurname = new System.Windows.Forms.TextBox();
            this.fieldEmail = new System.Windows.Forms.TextBox();
            this.fieldPassword = new System.Windows.Forms.TextBox();
            this.fieldAge = new System.Windows.Forms.NumericUpDown();
            this.fieldPasswordRepeat = new System.Windows.Forms.TextBox();
            this.buttonSignIn = new System.Windows.Forms.Button();
            this.checkShowPassword = new System.Windows.Forms.CheckBox();
            this.registerdUsers = new System.Windows.Forms.ListView();
            ((System.ComponentModel.ISupportInitialize)(this.fieldAge)).BeginInit();
            this.SuspendLayout();
            // 
            // fieldName
            // 
            this.fieldName.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fieldName.Location = new System.Drawing.Point(12, 22);
            this.fieldName.Name = "fieldName";
            this.fieldName.Size = new System.Drawing.Size(370, 41);
            this.fieldName.TabIndex = 0;
            this.fieldName.Enter += new System.EventHandler(this.Field_Enter);
            this.fieldName.Leave += new System.EventHandler(this.Field_Leave);
            // 
            // fieldSurname
            // 
            this.fieldSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fieldSurname.Location = new System.Drawing.Point(12, 69);
            this.fieldSurname.Name = "fieldSurname";
            this.fieldSurname.Size = new System.Drawing.Size(370, 41);
            this.fieldSurname.TabIndex = 1;
            this.fieldSurname.Enter += new System.EventHandler(this.Field_Enter);
            this.fieldSurname.Leave += new System.EventHandler(this.Field_Leave);
            // 
            // fieldEmail
            // 
            this.fieldEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fieldEmail.Location = new System.Drawing.Point(12, 116);
            this.fieldEmail.Name = "fieldEmail";
            this.fieldEmail.Size = new System.Drawing.Size(370, 41);
            this.fieldEmail.TabIndex = 2;
            this.fieldEmail.Enter += new System.EventHandler(this.Field_Enter);
            this.fieldEmail.Leave += new System.EventHandler(this.Field_Leave);
            // 
            // fieldPassword
            // 
            this.fieldPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fieldPassword.Location = new System.Drawing.Point(12, 231);
            this.fieldPassword.Name = "fieldPassword";
            this.fieldPassword.Size = new System.Drawing.Size(370, 41);
            this.fieldPassword.TabIndex = 3;
            this.fieldPassword.TextChanged += new System.EventHandler(this.Password_TextChanged);
            this.fieldPassword.Enter += new System.EventHandler(this.Field_Enter);
            this.fieldPassword.Leave += new System.EventHandler(this.Field_Leave);
            // 
            // fieldAge
            // 
            this.fieldAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fieldAge.Location = new System.Drawing.Point(12, 163);
            this.fieldAge.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.fieldAge.Minimum = new decimal(new int[] {
            14,
            0,
            0,
            0});
            this.fieldAge.Name = "fieldAge";
            this.fieldAge.Size = new System.Drawing.Size(120, 41);
            this.fieldAge.TabIndex = 4;
            this.fieldAge.Value = new decimal(new int[] {
            14,
            0,
            0,
            0});
            // 
            // fieldPasswordRepeat
            // 
            this.fieldPasswordRepeat.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fieldPasswordRepeat.Location = new System.Drawing.Point(12, 278);
            this.fieldPasswordRepeat.Name = "fieldPasswordRepeat";
            this.fieldPasswordRepeat.Size = new System.Drawing.Size(370, 41);
            this.fieldPasswordRepeat.TabIndex = 5;
            this.fieldPasswordRepeat.TextChanged += new System.EventHandler(this.Password_TextChanged);
            this.fieldPasswordRepeat.Enter += new System.EventHandler(this.Field_Enter);
            this.fieldPasswordRepeat.Leave += new System.EventHandler(this.Field_Leave);
            // 
            // buttonSignIn
            // 
            this.buttonSignIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSignIn.Location = new System.Drawing.Point(12, 393);
            this.buttonSignIn.Name = "buttonSignIn";
            this.buttonSignIn.Size = new System.Drawing.Size(370, 52);
            this.buttonSignIn.TabIndex = 6;
            this.buttonSignIn.Text = "Sign In";
            this.buttonSignIn.UseVisualStyleBackColor = true;
            this.buttonSignIn.Click += new System.EventHandler(this.buttonSignIn_Click);
            // 
            // checkShowPassword
            // 
            this.checkShowPassword.AutoSize = true;
            this.checkShowPassword.Location = new System.Drawing.Point(12, 325);
            this.checkShowPassword.Name = "checkShowPassword";
            this.checkShowPassword.Size = new System.Drawing.Size(129, 21);
            this.checkShowPassword.TabIndex = 7;
            this.checkShowPassword.Text = "Show Password";
            this.checkShowPassword.UseVisualStyleBackColor = true;
            this.checkShowPassword.CheckedChanged += new System.EventHandler(this.checkShowPassword_CheckedChanged);
            // 
            // registerdUsers
            // 
            this.registerdUsers.HideSelection = false;
            this.registerdUsers.Location = new System.Drawing.Point(407, 22);
            this.registerdUsers.Name = "registerdUsers";
            this.registerdUsers.Size = new System.Drawing.Size(681, 436);
            this.registerdUsers.TabIndex = 9;
            this.registerdUsers.UseCompatibleStateImageBehavior = false;
            this.registerdUsers.View = System.Windows.Forms.View.Details;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1143, 493);
            this.Controls.Add(this.registerdUsers);
            this.Controls.Add(this.checkShowPassword);
            this.Controls.Add(this.buttonSignIn);
            this.Controls.Add(this.fieldPasswordRepeat);
            this.Controls.Add(this.fieldAge);
            this.Controls.Add(this.fieldPassword);
            this.Controls.Add(this.fieldEmail);
            this.Controls.Add(this.fieldSurname);
            this.Controls.Add(this.fieldName);
            this.Name = "Form1";
            this.Text = "s";
            ((System.ComponentModel.ISupportInitialize)(this.fieldAge)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox fieldName;
        private System.Windows.Forms.TextBox fieldSurname;
        private System.Windows.Forms.TextBox fieldEmail;
        private System.Windows.Forms.TextBox fieldPassword;
        private System.Windows.Forms.NumericUpDown fieldAge;
        private System.Windows.Forms.TextBox fieldPasswordRepeat;
        private System.Windows.Forms.Button buttonSignIn;
        private System.Windows.Forms.CheckBox checkShowPassword;
        private System.Windows.Forms.ListView registerdUsers;
    }
}

