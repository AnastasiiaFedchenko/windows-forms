namespace Фоновая6._1
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
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
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.A = new System.Windows.Forms.Button();
            this.B = new System.Windows.Forms.Button();
            this.C = new System.Windows.Forms.Button();
            this.D = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // A
            // 
            this.A.BackColor = System.Drawing.Color.Yellow;
            this.A.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.A.Location = new System.Drawing.Point(159, 89);
            this.A.Name = "A";
            this.A.Size = new System.Drawing.Size(180, 108);
            this.A.TabIndex = 0;
            this.A.Text = "A";
            this.A.UseVisualStyleBackColor = false;
            // 
            // B
            // 
            this.B.BackColor = System.Drawing.Color.Yellow;
            this.B.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.B.Location = new System.Drawing.Point(381, 95);
            this.B.Name = "B";
            this.B.Size = new System.Drawing.Size(79, 96);
            this.B.TabIndex = 1;
            this.B.Text = "B";
            this.B.UseVisualStyleBackColor = false;
            // 
            // C
            // 
            this.C.BackColor = System.Drawing.Color.Orange;
            this.C.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.C.Location = new System.Drawing.Point(159, 309);
            this.C.Name = "C";
            this.C.Size = new System.Drawing.Size(160, 64);
            this.C.TabIndex = 2;
            this.C.Text = "C";
            this.C.UseVisualStyleBackColor = false;
            this.C.Click += new System.EventHandler(this.button3_Click);
            // 
            // D
            // 
            this.D.BackColor = System.Drawing.Color.Orange;
            this.D.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.D.Location = new System.Drawing.Point(343, 309);
            this.D.Name = "D";
            this.D.Size = new System.Drawing.Size(160, 64);
            this.D.TabIndex = 3;
            this.D.Text = "D";
            this.D.UseVisualStyleBackColor = false;
            this.D.Click += new System.EventHandler(this.D_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Фоновая6._1.Properties.Resources.безшовная_картина_с_же_тыми_резиновыми_утками_54797434;
            this.ClientSize = new System.Drawing.Size(698, 472);
            this.Controls.Add(this.D);
            this.Controls.Add(this.C);
            this.Controls.Add(this.B);
            this.Controls.Add(this.A);
            this.Name = "Form1";
            this.Text = "=";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button A;
        private System.Windows.Forms.Button B;
        private System.Windows.Forms.Button C;
        private System.Windows.Forms.Button D;
    }
}

