
namespace EntityProject
{
    partial class FrmAnaForm
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
            this.buttonKatİslem = new System.Windows.Forms.Button();
            this.buttonUrunİslem = new System.Windows.Forms.Button();
            this.buttonİstatistik = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonKatİslem
            // 
            this.buttonKatİslem.Location = new System.Drawing.Point(12, 12);
            this.buttonKatİslem.Name = "buttonKatİslem";
            this.buttonKatİslem.Size = new System.Drawing.Size(240, 238);
            this.buttonKatİslem.TabIndex = 0;
            this.buttonKatİslem.Text = "Kategori İşlemleri";
            this.buttonKatİslem.UseVisualStyleBackColor = true;
            this.buttonKatİslem.Click += new System.EventHandler(this.buttonKatİslem_Click);
            // 
            // buttonUrunİslem
            // 
            this.buttonUrunİslem.Location = new System.Drawing.Point(258, 12);
            this.buttonUrunİslem.Name = "buttonUrunİslem";
            this.buttonUrunİslem.Size = new System.Drawing.Size(240, 238);
            this.buttonUrunİslem.TabIndex = 1;
            this.buttonUrunİslem.Text = "Ürün İşlemleri";
            this.buttonUrunİslem.UseVisualStyleBackColor = true;
            this.buttonUrunİslem.Click += new System.EventHandler(this.buttonUrunİslem_Click);
            // 
            // buttonİstatistik
            // 
            this.buttonİstatistik.Location = new System.Drawing.Point(504, 12);
            this.buttonİstatistik.Name = "buttonİstatistik";
            this.buttonİstatistik.Size = new System.Drawing.Size(240, 238);
            this.buttonİstatistik.TabIndex = 2;
            this.buttonİstatistik.Text = "İstatistikler";
            this.buttonİstatistik.UseVisualStyleBackColor = true;
            this.buttonİstatistik.Click += new System.EventHandler(this.buttonİstatistik_Click);
            // 
            // FrmAnaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(751, 260);
            this.Controls.Add(this.buttonİstatistik);
            this.Controls.Add(this.buttonUrunİslem);
            this.Controls.Add(this.buttonKatİslem);
            this.MaximizeBox = false;
            this.Name = "FrmAnaForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmAnaForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonKatİslem;
        private System.Windows.Forms.Button buttonUrunİslem;
        private System.Windows.Forms.Button buttonİstatistik;
    }
}