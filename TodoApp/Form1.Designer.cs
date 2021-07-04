namespace TodoApp
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.todoTextField = new System.Windows.Forms.TextBox();
            this.todoList = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // todoTextField
            // 
            this.todoTextField.Dock = System.Windows.Forms.DockStyle.Top;
            this.todoTextField.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.todoTextField.Location = new System.Drawing.Point(0, 0);
            this.todoTextField.Name = "todoTextField";
            this.todoTextField.Size = new System.Drawing.Size(478, 31);
            this.todoTextField.TabIndex = 0;
            this.todoTextField.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
            // 
            // todoList
            // 
            this.todoList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.todoList.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.todoList.FormattingEnabled = true;
            this.todoList.ItemHeight = 24;
            this.todoList.Location = new System.Drawing.Point(0, 31);
            this.todoList.Name = "todoList";
            this.todoList.Size = new System.Drawing.Size(478, 663);
            this.todoList.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 694);
            this.Controls.Add(this.todoList);
            this.Controls.Add(this.todoTextField);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Todos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox todoTextField;
        private System.Windows.Forms.ListBox todoList;
    }
}

