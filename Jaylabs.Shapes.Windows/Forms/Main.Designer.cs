namespace Jaylabs.Shapes.Windows.Forms
{
    partial class Main
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
            this.FilterPanel = new System.Windows.Forms.Panel();
            this.btnGenerateShape = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAndMesurementAmount = new System.Windows.Forms.TextBox();
            this.txtAndMesurement = new System.Windows.Forms.TextBox();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.txtMesurement = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.shapeComboBox = new System.Windows.Forms.ComboBox();
            this.FilterPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // FilterPanel
            // 
            this.FilterPanel.Controls.Add(this.shapeComboBox);
            this.FilterPanel.Controls.Add(this.btnGenerateShape);
            this.FilterPanel.Controls.Add(this.label5);
            this.FilterPanel.Controls.Add(this.label4);
            this.FilterPanel.Controls.Add(this.label3);
            this.FilterPanel.Controls.Add(this.label2);
            this.FilterPanel.Controls.Add(this.label1);
            this.FilterPanel.Controls.Add(this.txtAndMesurementAmount);
            this.FilterPanel.Controls.Add(this.txtAndMesurement);
            this.FilterPanel.Controls.Add(this.txtAmount);
            this.FilterPanel.Controls.Add(this.txtMesurement);
            this.FilterPanel.Location = new System.Drawing.Point(30, 32);
            this.FilterPanel.Name = "FilterPanel";
            this.FilterPanel.Size = new System.Drawing.Size(1274, 168);
            this.FilterPanel.TabIndex = 0;
            // 
            // btnGenerateShape
            // 
            this.btnGenerateShape.Location = new System.Drawing.Point(1074, 103);
            this.btnGenerateShape.Name = "btnGenerateShape";
            this.btnGenerateShape.Size = new System.Drawing.Size(177, 53);
            this.btnGenerateShape.TabIndex = 6;
            this.btnGenerateShape.Text = "Generate Shape";
            this.btnGenerateShape.UseVisualStyleBackColor = true;
            this.btnGenerateShape.Click += new System.EventHandler(this.OnGenerateShapeClick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1030, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(23, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "of";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(807, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "(and a(n) ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(603, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "of";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(385, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "with a(n) ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Draw a(n)";
            // 
            // txtAndMesurementAmount
            // 
            this.txtAndMesurementAmount.Location = new System.Drawing.Point(1074, 54);
            this.txtAndMesurementAmount.Name = "txtAndMesurementAmount";
            this.txtAndMesurementAmount.Size = new System.Drawing.Size(177, 26);
            this.txtAndMesurementAmount.TabIndex = 5;
            // 
            // txtAndMesurement
            // 
            this.txtAndMesurement.Location = new System.Drawing.Point(890, 54);
            this.txtAndMesurement.Name = "txtAndMesurement";
            this.txtAndMesurement.Size = new System.Drawing.Size(134, 26);
            this.txtAndMesurement.TabIndex = 4;
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(632, 54);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(169, 26);
            this.txtAmount.TabIndex = 3;
            // 
            // txtMesurement
            // 
            this.txtMesurement.Location = new System.Drawing.Point(464, 54);
            this.txtMesurement.Name = "txtMesurement";
            this.txtMesurement.Size = new System.Drawing.Size(133, 26);
            this.txtMesurement.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(30, 230);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1274, 458);
            this.panel2.TabIndex = 1;
            // 
            // shapeComboBox
            // 
            this.shapeComboBox.FormattingEnabled = true;
            this.shapeComboBox.Location = new System.Drawing.Point(120, 54);
            this.shapeComboBox.Name = "shapeComboBox";
            this.shapeComboBox.Size = new System.Drawing.Size(259, 28);
            this.shapeComboBox.TabIndex = 11;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1331, 749);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.FilterPanel);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.FilterPanel.ResumeLayout(false);
            this.FilterPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel FilterPanel;
        private System.Windows.Forms.TextBox txtAndMesurementAmount;
        private System.Windows.Forms.TextBox txtAndMesurement;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.TextBox txtMesurement;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnGenerateShape;
        private System.Windows.Forms.ComboBox shapeComboBox;
    }
}