namespace Zork.Builder.UserControls
{
    partial class NeighborsUserControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.DirectionsTextBox = new System.Windows.Forms.TextBox();
            this.NeighborComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // DirectionsTextBox
            // 
            this.DirectionsTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DirectionsTextBox.Location = new System.Drawing.Point(3, 3);
            this.DirectionsTextBox.Name = "DirectionsTextBox";
            this.DirectionsTextBox.ReadOnly = true;
            this.DirectionsTextBox.Size = new System.Drawing.Size(216, 22);
            this.DirectionsTextBox.TabIndex = 0;
            this.DirectionsTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // NeighborComboBox
            // 
            this.NeighborComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NeighborComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.NeighborComboBox.FormattingEnabled = true;
            this.NeighborComboBox.Location = new System.Drawing.Point(3, 31);
            this.NeighborComboBox.Name = "NeighborComboBox";
            this.NeighborComboBox.Size = new System.Drawing.Size(217, 24);
            this.NeighborComboBox.TabIndex = 1;
            this.NeighborComboBox.ValueMember = "Key";
            this.NeighborComboBox.SelectedIndexChanged += new System.EventHandler(this.NeighborComboBox_SelectedIndexChanged);
            // 
            // NeighborsUserControl
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.NeighborComboBox);
            this.Controls.Add(this.DirectionsTextBox);
            this.Name = "NeighborsUserControl";
            this.Size = new System.Drawing.Size(223, 68);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox DirectionsTextBox;
        private System.Windows.Forms.ComboBox NeighborComboBox;
    }
}
