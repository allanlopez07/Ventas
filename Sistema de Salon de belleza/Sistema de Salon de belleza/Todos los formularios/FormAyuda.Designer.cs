namespace Sistema_de_Salon_de_belleza.Todos_los_formularios
{
    partial class FormAyuda
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
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(460, 248);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sistema Salon de Belleza mujer Bonita realizado por \r\nGladys Sosa\r\nAllan Lopez\r\nH" +
    "enry Lachira\r\nPara mas informacion escribamos al siguiente correo\r\ngladyssosa222" +
    "@gmail.com\r\n";
            // 
            // FormAyuda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 266);
            this.Controls.Add(this.label1);
            this.Name = "FormAyuda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ayuda";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
    }
}