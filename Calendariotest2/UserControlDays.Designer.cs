
namespace Calendariotest2
{
    partial class UserControlDays
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

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lbldays = new System.Windows.Forms.Label();
            this.lblevent = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // lbldays
            // 
            this.lbldays.AutoSize = true;
            this.lbldays.Location = new System.Drawing.Point(35, 36);
            this.lbldays.Name = "lbldays";
            this.lbldays.Size = new System.Drawing.Size(19, 13);
            this.lbldays.TabIndex = 0;
            this.lbldays.Text = "00";
            // 
            // lblevent
            // 
            this.lblevent.AutoSize = true;
            this.lblevent.Location = new System.Drawing.Point(35, 72);
            this.lblevent.Name = "lblevent";
            this.lblevent.Size = new System.Drawing.Size(0, 13);
            this.lblevent.TabIndex = 1;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // UserControlDays
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblevent);
            this.Controls.Add(this.lbldays);
            this.Name = "UserControlDays";
            this.Size = new System.Drawing.Size(125, 100);
            this.Load += new System.EventHandler(this.UserControlDays_Load);
            this.Click += new System.EventHandler(this.UserControlDays_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbldays;
        private System.Windows.Forms.Label lblevent;
        private System.Windows.Forms.Timer timer1;
    }
}
