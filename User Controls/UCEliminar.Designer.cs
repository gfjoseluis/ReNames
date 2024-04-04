namespace ReNames
{
    partial class UCEliminar
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
            LblEliminar = new Label();
            TxbEliminar = new TextBox();
            SuspendLayout();
            // 
            // LblEliminar
            // 
            LblEliminar.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            LblEliminar.AutoSize = true;
            LblEliminar.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            LblEliminar.Location = new Point(27, 22);
            LblEliminar.Name = "LblEliminar";
            LblEliminar.Size = new Size(206, 15);
            LblEliminar.TabIndex = 0;
            LblEliminar.Text = "Ingrese el texto que desea eliminar:";
            // 
            // TxbEliminar
            // 
            TxbEliminar.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            TxbEliminar.Location = new Point(30, 52);
            TxbEliminar.Name = "TxbEliminar";
            TxbEliminar.PlaceholderText = "Texto a eliminar";
            TxbEliminar.Size = new Size(200, 23);
            TxbEliminar.TabIndex = 1;
            // 
            // UCEliminar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(TxbEliminar);
            Controls.Add(LblEliminar);
            Name = "UCEliminar";
            Size = new Size(269, 117);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LblEliminar;
        private TextBox TxbEliminar;
    }
}
