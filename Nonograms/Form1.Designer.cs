namespace Nonograms
{
    partial class VisualBoard
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.Nanogram_Board = new System.Windows.Forms.PictureBox();
            this.Change = new System.Windows.Forms.Button();
            this.width = new System.Windows.Forms.TextBox();
            this.height = new System.Windows.Forms.TextBox();
            this.Generate = new System.Windows.Forms.Button();
            this.Choose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Nanogram_Board)).BeginInit();
            this.SuspendLayout();
            // 
            // Nanogram_Board
            // 
            this.Nanogram_Board.Location = new System.Drawing.Point(45, 68);
            this.Nanogram_Board.Margin = new System.Windows.Forms.Padding(3, 3, 50, 50);
            this.Nanogram_Board.Name = "Nanogram_Board";
            this.Nanogram_Board.Size = new System.Drawing.Size(132, 101);
            this.Nanogram_Board.TabIndex = 0;
            this.Nanogram_Board.TabStop = false;
            this.Nanogram_Board.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseClick);
            // 
            // Change
            // 
            this.Change.Location = new System.Drawing.Point(12, 12);
            this.Change.Name = "Change";
            this.Change.Size = new System.Drawing.Size(75, 23);
            this.Change.TabIndex = 2;
            this.Change.Text = "Генерировать";
            this.Change.UseVisualStyleBackColor = true;
            this.Change.Click += new System.EventHandler(this.Change_Click);
            // 
            // width
            // 
            this.width.Location = new System.Drawing.Point(93, 15);
            this.width.Name = "width";
            this.width.Size = new System.Drawing.Size(65, 20);
            this.width.TabIndex = 3;
            this.width.Text = "Ширина";
            this.width.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // height
            // 
            this.height.Location = new System.Drawing.Point(164, 15);
            this.height.Name = "height";
            this.height.Size = new System.Drawing.Size(76, 20);
            this.height.TabIndex = 3;
            this.height.Text = "Высота";
            this.height.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Generate
            // 
            this.Generate.Location = new System.Drawing.Point(327, 15);
            this.Generate.Margin = new System.Windows.Forms.Padding(3, 3, 10, 3);
            this.Generate.Name = "Generate";
            this.Generate.Size = new System.Drawing.Size(99, 23);
            this.Generate.TabIndex = 4;
            this.Generate.Text = "Создать файл";
            this.Generate.UseVisualStyleBackColor = true;
            this.Generate.Click += new System.EventHandler(this.Generate_Click);
            // 
            // Choose
            // 
            this.Choose.Location = new System.Drawing.Point(246, 15);
            this.Choose.Name = "Choose";
            this.Choose.Size = new System.Drawing.Size(75, 23);
            this.Choose.TabIndex = 5;
            this.Choose.Text = "Выбрать файл";
            this.Choose.UseVisualStyleBackColor = true;
            this.Choose.Click += new System.EventHandler(this.Choose_Click);
            // 
            // VisualBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(403, 179);
            this.Controls.Add(this.Choose);
            this.Controls.Add(this.Generate);
            this.Controls.Add(this.height);
            this.Controls.Add(this.width);
            this.Controls.Add(this.Change);
            this.Controls.Add(this.Nanogram_Board);
            this.Name = "VisualBoard";
            this.Text = "VisualBoardGenerator";
            ((System.ComponentModel.ISupportInitialize)(this.Nanogram_Board)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Nanogram_Board;
        private System.Windows.Forms.Button Change;
        private System.Windows.Forms.TextBox width;
        private System.Windows.Forms.TextBox height;
        private System.Windows.Forms.Button Generate;
        private System.Windows.Forms.Button Choose;
    }
}

