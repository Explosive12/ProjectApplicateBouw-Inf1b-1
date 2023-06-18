using Microsoft.Graph.Models;
using Project1._4.RoundedItems;

namespace Project1._4.UI.Management.UC
{
    partial class AddItemUC
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
            textBoxAddItem = new RoundTextBox();
            labelAddItem = new Label();
            SuspendLayout();
            // 
            // textBoxAddItem
            // 
            textBoxAddItem.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point);
            textBoxAddItem.Location = new Point(201, 8);
            textBoxAddItem.Name = "textBoxAddItem";
            textBoxAddItem.Size = new Size(128, 22);
            textBoxAddItem.TabIndex = 0;
            textBoxAddItem.TextAlign = HorizontalAlignment.Center;
            
            // 
            // labelAddItem
            // 
            labelAddItem.AutoSize = true;
            labelAddItem.Font = new Font("Tahoma", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            labelAddItem.Location = new Point(3, 8);
            labelAddItem.Name = "labelAddItem";
            labelAddItem.Size = new Size(64, 18);
            labelAddItem.TabIndex = 1;
            labelAddItem.Text = "{word}";
            // 
            // AddItemUC
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            Controls.Add(labelAddItem);
            Controls.Add(textBoxAddItem);
            Name = "AddItemUC";
            Size = new Size(350, 35);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label labelAddItem;
        private RoundTextBox textBoxAddItem;
    }
}
