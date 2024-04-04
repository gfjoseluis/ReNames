namespace ReNames
{
    partial class FrmRules
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
            ListViewItem listViewItem1 = new ListViewItem("Eliminar");
            ListViewItem listViewItem2 = new ListViewItem("Reemplazar");
            ListViewItem listViewItem3 = new ListViewItem("Añadir Inicio");
            ListViewItem listViewItem4 = new ListViewItem("Añadir Final");
            SCoptions = new SplitContainer();
            LvOptions = new ListView();
            SPButtons = new SplitContainer();
            BtnAddRule = new Button();
            BtnClose = new Button();
            ((System.ComponentModel.ISupportInitialize)SCoptions).BeginInit();
            SCoptions.Panel1.SuspendLayout();
            SCoptions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)SPButtons).BeginInit();
            SPButtons.Panel1.SuspendLayout();
            SPButtons.Panel2.SuspendLayout();
            SPButtons.SuspendLayout();
            SuspendLayout();
            // 
            // SCoptions
            // 
            SCoptions.Dock = DockStyle.Fill;
            SCoptions.Location = new Point(0, 0);
            SCoptions.Name = "SCoptions";
            // 
            // SCoptions.Panel1
            // 
            SCoptions.Panel1.Controls.Add(LvOptions);
            SCoptions.Size = new Size(564, 433);
            SCoptions.SplitterDistance = 188;
            SCoptions.TabIndex = 0;
            // 
            // LvOptions
            // 
            LvOptions.Dock = DockStyle.Fill;
            LvOptions.Items.AddRange(new ListViewItem[] { listViewItem1, listViewItem2, listViewItem3, listViewItem4 });
            LvOptions.Location = new Point(0, 0);
            LvOptions.Name = "LvOptions";
            LvOptions.Size = new Size(188, 433);
            LvOptions.TabIndex = 0;
            LvOptions.UseCompatibleStateImageBehavior = false;
            LvOptions.View = View.List;
            LvOptions.SelectedIndexChanged += LvOptions_SelectedIndexChanged;
            // 
            // SPButtons
            // 
            SPButtons.Dock = DockStyle.Bottom;
            SPButtons.Location = new Point(0, 395);
            SPButtons.Name = "SPButtons";
            // 
            // SPButtons.Panel1
            // 
            SPButtons.Panel1.Controls.Add(BtnAddRule);
            // 
            // SPButtons.Panel2
            // 
            SPButtons.Panel2.Controls.Add(BtnClose);
            SPButtons.Size = new Size(564, 38);
            SPButtons.SplitterDistance = 340;
            SPButtons.TabIndex = 1;
            // 
            // BtnAddRule
            // 
            BtnAddRule.Dock = DockStyle.Fill;
            BtnAddRule.Location = new Point(0, 0);
            BtnAddRule.Name = "BtnAddRule";
            BtnAddRule.Size = new Size(340, 38);
            BtnAddRule.TabIndex = 0;
            BtnAddRule.Text = "Añadir Regla";
            BtnAddRule.UseVisualStyleBackColor = true;
            BtnAddRule.Click += BtnAddRule_Click;
            // 
            // BtnClose
            // 
            BtnClose.Dock = DockStyle.Fill;
            BtnClose.Location = new Point(0, 0);
            BtnClose.Name = "BtnClose";
            BtnClose.Size = new Size(220, 38);
            BtnClose.TabIndex = 0;
            BtnClose.Text = "Cerrar";
            BtnClose.UseVisualStyleBackColor = true;
            BtnClose.Click += BtnClose_Click;
            // 
            // FrmRules
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(564, 433);
            Controls.Add(SPButtons);
            Controls.Add(SCoptions);
            MinimumSize = new Size(580, 470);
            Name = "FrmRules";
            Text = "FrmRules";
            SCoptions.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)SCoptions).EndInit();
            SCoptions.ResumeLayout(false);
            SPButtons.Panel1.ResumeLayout(false);
            SPButtons.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)SPButtons).EndInit();
            SPButtons.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer SCoptions;
        private ListView LvOptions;
        private SplitContainer SPButtons;
        private Button BtnAddRule;
        private Button BtnClose;
    }
}