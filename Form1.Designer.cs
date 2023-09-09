namespace Ejercicio3
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
            this.BTN_Comenzar = new System.Windows.Forms.Button();
            this.TX_1 = new System.Windows.Forms.TextBox();
            this.LT_1 = new System.Windows.Forms.ListBox();
            this.TX_2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BTN_Comenzar
            // 
            this.BTN_Comenzar.Location = new System.Drawing.Point(197, 114);
            this.BTN_Comenzar.Name = "BTN_Comenzar";
            this.BTN_Comenzar.Size = new System.Drawing.Size(75, 23);
            this.BTN_Comenzar.TabIndex = 0;
            this.BTN_Comenzar.Text = "button1";
            this.BTN_Comenzar.UseVisualStyleBackColor = true;
            this.BTN_Comenzar.Click += new System.EventHandler(this.BTN_Comenzar_Click);
            // 
            // TX_1
            // 
            this.TX_1.Location = new System.Drawing.Point(149, 36);
            this.TX_1.Name = "TX_1";
            this.TX_1.Size = new System.Drawing.Size(183, 20);
            this.TX_1.TabIndex = 1;
            // 
            // LT_1
            // 
            this.LT_1.FormattingEnabled = true;
            this.LT_1.Location = new System.Drawing.Point(174, 159);
            this.LT_1.Name = "LT_1";
            this.LT_1.Size = new System.Drawing.Size(120, 95);
            this.LT_1.TabIndex = 2;
            // 
            // TX_2
            // 
            this.TX_2.Location = new System.Drawing.Point(149, 74);
            this.TX_2.Name = "TX_2";
            this.TX_2.Size = new System.Drawing.Size(183, 20);
            this.TX_2.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 335);
            this.Controls.Add(this.TX_2);
            this.Controls.Add(this.LT_1);
            this.Controls.Add(this.TX_1);
            this.Controls.Add(this.BTN_Comenzar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTN_Comenzar;
        private System.Windows.Forms.TextBox TX_1;
        private System.Windows.Forms.ListBox LT_1;
        private System.Windows.Forms.TextBox TX_2;
    }
}

