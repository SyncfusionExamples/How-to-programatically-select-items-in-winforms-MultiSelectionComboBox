namespace multiselectionsample
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.multiSelectionComboBox1 = new Syncfusion.Windows.Forms.Tools.MultiSelectionComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.multiSelectionComboBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // multiSelectionComboBox1
            // 
            this.multiSelectionComboBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.multiSelectionComboBox1.BeforeTouchSize = new System.Drawing.Size(162, 30);
            this.multiSelectionComboBox1.ButtonStyle = Syncfusion.Windows.Forms.ButtonAppearance.Office2016Colorful;
            this.multiSelectionComboBox1.DataSource = ((object)(resources.GetObject("multiSelectionComboBox1.DataSource")));
            this.multiSelectionComboBox1.DisplayMode = Syncfusion.Windows.Forms.Tools.DisplayMode.NormalMode;
            this.multiSelectionComboBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.multiSelectionComboBox1.Location = new System.Drawing.Point(287, 180);
            this.multiSelectionComboBox1.Name = "multiSelectionComboBox1";
            this.multiSelectionComboBox1.ShowCheckBox = true;
            this.multiSelectionComboBox1.Size = new System.Drawing.Size(162, 30);
            this.multiSelectionComboBox1.TabIndex = 0;
            this.multiSelectionComboBox1.ThemeName = "Office2016Colorful";
            this.multiSelectionComboBox1.UseVisualStyle = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.multiSelectionComboBox1);
            this.Name = "Form1";
            this.Text = "MultiSelectionComboBox Sample";
            ((System.ComponentModel.ISupportInitialize)(this.multiSelectionComboBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Syncfusion.Windows.Forms.Tools.MultiSelectionComboBox multiSelectionComboBox1;
    }
}

