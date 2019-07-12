namespace snakeGame
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.canva = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.puntos = new System.Windows.Forms.Label();
            this.bucle = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.canva)).BeginInit();
            this.SuspendLayout();
            // 
            // canva
            // 
            this.canva.Location = new System.Drawing.Point(15, 16);
            this.canva.Name = "canva";
            this.canva.Size = new System.Drawing.Size(780, 390);
            this.canva.TabIndex = 0;
            this.canva.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(121, 423);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 33);
            this.label1.TabIndex = 1;
            this.label1.Text = "Puntaje";
            // 
            // puntos
            // 
            this.puntos.AutoSize = true;
            this.puntos.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.puntos.Location = new System.Drawing.Point(240, 423);
            this.puntos.Name = "puntos";
            this.puntos.Size = new System.Drawing.Size(31, 33);
            this.puntos.TabIndex = 2;
            this.puntos.Text = "0";
            // 
            // bucle
            // 
            this.bucle.Enabled = true;
            this.bucle.Tick += new System.EventHandler(this.Bucle_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 480);
            this.Controls.Add(this.puntos);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.canva);
            this.Name = "Form1";
            this.Text = "Snake";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.canva)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox canva;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label puntos;
        private System.Windows.Forms.Timer bucle;
    }
}

