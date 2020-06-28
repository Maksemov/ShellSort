namespace Laba4_ShellSort
{
    partial class MainForm
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
            this.listBoxForNums = new System.Windows.Forms.ListBox();
            this.buttonSortArray = new System.Windows.Forms.Button();
            this.listBoxForSelectedNums = new System.Windows.Forms.ListBox();
            this.listBoxForSwapNums = new System.Windows.Forms.ListBox();
            this.buttonFillArrayWithRandomNumbers = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBoxForNums
            // 
            this.listBoxForNums.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBoxForNums.FormattingEnabled = true;
            this.listBoxForNums.ItemHeight = 25;
            this.listBoxForNums.Location = new System.Drawing.Point(16, 15);
            this.listBoxForNums.Margin = new System.Windows.Forms.Padding(4);
            this.listBoxForNums.Name = "listBoxForNums";
            this.listBoxForNums.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.listBoxForNums.Size = new System.Drawing.Size(135, 529);
            this.listBoxForNums.TabIndex = 0;
            // 
            // buttonSortArray
            // 
            this.buttonSortArray.BackColor = System.Drawing.Color.LightGray;
            this.buttonSortArray.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSortArray.Enabled = false;
            this.buttonSortArray.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonSortArray.FlatAppearance.BorderSize = 0;
            this.buttonSortArray.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSortArray.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSortArray.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonSortArray.Location = new System.Drawing.Point(16, 612);
            this.buttonSortArray.Margin = new System.Windows.Forms.Padding(4);
            this.buttonSortArray.Name = "buttonSortArray";
            this.buttonSortArray.Size = new System.Drawing.Size(421, 50);
            this.buttonSortArray.TabIndex = 1;
            this.buttonSortArray.Text = "Сортировать";
            this.buttonSortArray.UseVisualStyleBackColor = false;
            this.buttonSortArray.Click += new System.EventHandler(this.buttonSortArray_Click);
            // 
            // listBoxForSelectedNums
            // 
            this.listBoxForSelectedNums.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBoxForSelectedNums.FormattingEnabled = true;
            this.listBoxForSelectedNums.ItemHeight = 25;
            this.listBoxForSelectedNums.Location = new System.Drawing.Point(159, 15);
            this.listBoxForSelectedNums.Margin = new System.Windows.Forms.Padding(4);
            this.listBoxForSelectedNums.Name = "listBoxForSelectedNums";
            this.listBoxForSelectedNums.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.listBoxForSelectedNums.Size = new System.Drawing.Size(135, 529);
            this.listBoxForSelectedNums.TabIndex = 3;
            // 
            // listBoxForSwapNums
            // 
            this.listBoxForSwapNums.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBoxForSwapNums.FormattingEnabled = true;
            this.listBoxForSwapNums.ItemHeight = 25;
            this.listBoxForSwapNums.Location = new System.Drawing.Point(302, 15);
            this.listBoxForSwapNums.Margin = new System.Windows.Forms.Padding(4);
            this.listBoxForSwapNums.Name = "listBoxForSwapNums";
            this.listBoxForSwapNums.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.listBoxForSwapNums.Size = new System.Drawing.Size(135, 529);
            this.listBoxForSwapNums.TabIndex = 4;
            // 
            // buttonFillArrayWithRandomNumbers
            // 
            this.buttonFillArrayWithRandomNumbers.BackColor = System.Drawing.Color.LightGray;
            this.buttonFillArrayWithRandomNumbers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonFillArrayWithRandomNumbers.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonFillArrayWithRandomNumbers.FlatAppearance.BorderSize = 0;
            this.buttonFillArrayWithRandomNumbers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFillArrayWithRandomNumbers.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonFillArrayWithRandomNumbers.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonFillArrayWithRandomNumbers.Location = new System.Drawing.Point(16, 554);
            this.buttonFillArrayWithRandomNumbers.Margin = new System.Windows.Forms.Padding(4);
            this.buttonFillArrayWithRandomNumbers.Name = "buttonFillArrayWithRandomNumbers";
            this.buttonFillArrayWithRandomNumbers.Size = new System.Drawing.Size(421, 50);
            this.buttonFillArrayWithRandomNumbers.TabIndex = 2;
            this.buttonFillArrayWithRandomNumbers.Text = "Заполнить случайными числами";
            this.buttonFillArrayWithRandomNumbers.UseVisualStyleBackColor = false;
            this.buttonFillArrayWithRandomNumbers.Click += new System.EventHandler(this.buttonFillArrayWithRandomNumbers_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 687);
            this.Controls.Add(this.listBoxForSwapNums);
            this.Controls.Add(this.listBoxForSelectedNums);
            this.Controls.Add(this.buttonFillArrayWithRandomNumbers);
            this.Controls.Add(this.buttonSortArray);
            this.Controls.Add(this.listBoxForNums);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.Text = "Сорт Шелла  числа Фибоначчи";
            this.Load += new System.EventHandler(this.DemoModeForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxForNums;
        private System.Windows.Forms.Button buttonSortArray;
        private System.Windows.Forms.ListBox listBoxForSelectedNums;
        private System.Windows.Forms.ListBox listBoxForSwapNums;
        private System.Windows.Forms.Button buttonFillArrayWithRandomNumbers;
    }
}