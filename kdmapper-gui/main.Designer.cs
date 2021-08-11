
namespace kdmapper_gui
{
    partial class main
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
            this.richtextbox_DriverEntry = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.checkbox_mdl = new System.Windows.Forms.CheckBox();
            this.checkbox_free = new System.Windows.Forms.CheckBox();
            this.checkbox_ExAllocatePool = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textbox_driverPath = new System.Windows.Forms.TextBox();
            this.label_driverPath = new System.Windows.Forms.Label();
            this.label_mapperPath = new System.Windows.Forms.Label();
            this.textbox_mapperPath = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.checkbox_allocationPtr = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // richtextbox_DriverEntry
            // 
            this.richtextbox_DriverEntry.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richtextbox_DriverEntry.Location = new System.Drawing.Point(0, 185);
            this.richtextbox_DriverEntry.Name = "richtextbox_DriverEntry";
            this.richtextbox_DriverEntry.ReadOnly = true;
            this.richtextbox_DriverEntry.Size = new System.Drawing.Size(434, 64);
            this.richtextbox_DriverEntry.TabIndex = 0;
            this.richtextbox_DriverEntry.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(-3, 166);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(232, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Example DriverEntry routine:";
            // 
            // checkbox_mdl
            // 
            this.checkbox_mdl.AutoSize = true;
            this.checkbox_mdl.Location = new System.Drawing.Point(12, 39);
            this.checkbox_mdl.Name = "checkbox_mdl";
            this.checkbox_mdl.Size = new System.Drawing.Size(42, 17);
            this.checkbox_mdl.TabIndex = 1;
            this.checkbox_mdl.Text = "mdl";
            this.checkbox_mdl.UseVisualStyleBackColor = true;
            this.checkbox_mdl.CheckedChanged += new System.EventHandler(this.checkbox_mdl_CheckedChanged);
            this.checkbox_mdl.Click += new System.EventHandler(this.checkbox_mdl_Click);
            // 
            // checkbox_free
            // 
            this.checkbox_free.AutoSize = true;
            this.checkbox_free.Checked = true;
            this.checkbox_free.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkbox_free.Location = new System.Drawing.Point(12, 75);
            this.checkbox_free.Name = "checkbox_free";
            this.checkbox_free.Size = new System.Drawing.Size(44, 17);
            this.checkbox_free.TabIndex = 2;
            this.checkbox_free.Text = "free";
            this.checkbox_free.UseVisualStyleBackColor = true;
            // 
            // checkbox_ExAllocatePool
            // 
            this.checkbox_ExAllocatePool.AutoSize = true;
            this.checkbox_ExAllocatePool.Checked = true;
            this.checkbox_ExAllocatePool.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkbox_ExAllocatePool.Location = new System.Drawing.Point(12, 22);
            this.checkbox_ExAllocatePool.Name = "checkbox_ExAllocatePool";
            this.checkbox_ExAllocatePool.Size = new System.Drawing.Size(97, 17);
            this.checkbox_ExAllocatePool.TabIndex = 0;
            this.checkbox_ExAllocatePool.Text = "ExAllocatePool";
            this.checkbox_ExAllocatePool.UseVisualStyleBackColor = true;
            this.checkbox_ExAllocatePool.CheckedChanged += new System.EventHandler(this.checkbox_ExAllocatePool_CheckedChanged);
            this.checkbox_ExAllocatePool.Click += new System.EventHandler(this.checkbox_ExAllocatePool_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(200, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Memory Allocation Method";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(9, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(248, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Should free memory after usage";
            // 
            // textbox_driverPath
            // 
            this.textbox_driverPath.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textbox_driverPath.Location = new System.Drawing.Point(12, 143);
            this.textbox_driverPath.Name = "textbox_driverPath";
            this.textbox_driverPath.ReadOnly = true;
            this.textbox_driverPath.Size = new System.Drawing.Size(124, 20);
            this.textbox_driverPath.TabIndex = 4;
            this.textbox_driverPath.Text = "click me";
            this.textbox_driverPath.Click += new System.EventHandler(this.textbox_driverPath_Click);
            // 
            // label_driverPath
            // 
            this.label_driverPath.AutoSize = true;
            this.label_driverPath.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_driverPath.Location = new System.Drawing.Point(9, 124);
            this.label_driverPath.Name = "label_driverPath";
            this.label_driverPath.Size = new System.Drawing.Size(96, 16);
            this.label_driverPath.TabIndex = 8;
            this.label_driverPath.Text = "Driver path";
            // 
            // label_mapperPath
            // 
            this.label_mapperPath.AutoSize = true;
            this.label_mapperPath.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_mapperPath.Location = new System.Drawing.Point(155, 124);
            this.label_mapperPath.Name = "label_mapperPath";
            this.label_mapperPath.Size = new System.Drawing.Size(96, 16);
            this.label_mapperPath.TabIndex = 9;
            this.label_mapperPath.Text = "Mapper path";
            // 
            // textbox_mapperPath
            // 
            this.textbox_mapperPath.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textbox_mapperPath.Location = new System.Drawing.Point(158, 143);
            this.textbox_mapperPath.Name = "textbox_mapperPath";
            this.textbox_mapperPath.ReadOnly = true;
            this.textbox_mapperPath.Size = new System.Drawing.Size(124, 20);
            this.textbox_mapperPath.TabIndex = 5;
            this.textbox_mapperPath.Text = "click me";
            this.textbox_mapperPath.Click += new System.EventHandler(this.textbox_mapperPath_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(292, 141);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(97, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Map driver";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(9, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 16);
            this.label4.TabIndex = 12;
            this.label4.Text = "Extra";
            // 
            // checkbox_allocationPtr
            // 
            this.checkbox_allocationPtr.AutoSize = true;
            this.checkbox_allocationPtr.Location = new System.Drawing.Point(13, 108);
            this.checkbox_allocationPtr.Name = "checkbox_allocationPtr";
            this.checkbox_allocationPtr.Size = new System.Drawing.Size(112, 17);
            this.checkbox_allocationPtr.TabIndex = 3;
            this.checkbox_allocationPtr.Text = "Pass allocation ptr";
            this.checkbox_allocationPtr.UseVisualStyleBackColor = true;
            this.checkbox_allocationPtr.CheckedChanged += new System.EventHandler(this.checkbox_allocationPtr_CheckedChanged);
            this.checkbox_allocationPtr.Click += new System.EventHandler(this.checkbox_allocationPtr_Click);
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 251);
            this.Controls.Add(this.checkbox_allocationPtr);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textbox_mapperPath);
            this.Controls.Add(this.label_mapperPath);
            this.Controls.Add(this.label_driverPath);
            this.Controls.Add(this.textbox_driverPath);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.checkbox_ExAllocatePool);
            this.Controls.Add(this.checkbox_free);
            this.Controls.Add(this.checkbox_mdl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.richtextbox_DriverEntry);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(450, 290);
            this.MinimumSize = new System.Drawing.Size(450, 290);
            this.Name = "main";
            this.ShowIcon = false;
            this.Text = "kdmapper-gui";
            this.Load += new System.EventHandler(this.main_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richtextbox_DriverEntry;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkbox_mdl;
        private System.Windows.Forms.CheckBox checkbox_free;
        private System.Windows.Forms.CheckBox checkbox_ExAllocatePool;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textbox_driverPath;
        private System.Windows.Forms.Label label_driverPath;
        private System.Windows.Forms.Label label_mapperPath;
        private System.Windows.Forms.TextBox textbox_mapperPath;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox checkbox_allocationPtr;
    }
}

