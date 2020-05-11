namespace Snake
{
    partial class VentanaDelJuego
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VentanaDelJuego));
            this._snake = new System.Windows.Forms.Label();
            this._comida = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // _snake
            // 
            this._snake.AutoSize = true;
            this._snake.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._snake.Location = new System.Drawing.Point(248, 197);
            this._snake.Name = "_snake";
            this._snake.Size = new System.Drawing.Size(24, 31);
            this._snake.TabIndex = 0;
            this._snake.Text = "-";
            // 
            // _comida
            // 
            this._comida.AutoSize = true;
            this._comida.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._comida.ForeColor = System.Drawing.Color.Red;
            this._comida.Location = new System.Drawing.Point(473, 212);
            this._comida.Name = "_comida";
            this._comida.Size = new System.Drawing.Size(14, 16);
            this._comida.TabIndex = 1;
            this._comida.Text = "*";
            // 
            // VentanaDelJuego
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this._comida);
            this.Controls.Add(this._snake);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "VentanaDelJuego";
            this.Text = "Juego Snake";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label _snake;
        private System.Windows.Forms.Label _comida;
    }
}

