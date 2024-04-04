namespace ReNames
{
    partial class FrmHome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmHome));
            MsMenu = new MenuStrip();
            archivoToolStripMenuItem = new ToolStripMenuItem();
            nuevoProyectoToolStripMenuItem = new ToolStripMenuItem();
            abrirCarpetaToolStripMenuItem = new ToolStripMenuItem();
            configuracionToolStripMenuItem = new ToolStripMenuItem();
            generalToolStripMenuItem = new ToolStripMenuItem();
            ayudaToolStripMenuItem = new ToolStripMenuItem();
            acercaDeToolStripMenuItem = new ToolStripMenuItem();
            TsMenu = new ToolStrip();
            BtnOpen = new ToolStripButton();
            toolStripLabel1 = new ToolStripLabel();
            BtnPreview = new ToolStripButton();
            toolStripLabel2 = new ToolStripLabel();
            BtnRename = new ToolStripButton();
            TsRules = new ToolStrip();
            BtnAddRule = new ToolStripButton();
            BtnRemoveRule = new ToolStripButton();
            DgvRules = new DataGridView();
            Nro = new DataGridViewCheckBoxColumn();
            Rule = new DataGridViewTextBoxColumn();
            Instruction = new DataGridViewTextBoxColumn();
            toolStrip1 = new ToolStrip();
            TsmArchivos = new ToolStripDropDownButton();
            marcarTodosToolStripMenuItem = new ToolStripMenuItem();
            desmarcarTodosToolStripMenuItem = new ToolStripMenuItem();
            TsmOpciones = new ToolStripDropDownButton();
            autoajustarColumnasToolStripMenuItem = new ToolStripMenuItem();
            DgvArchivos = new DataGridView();
            Status = new DataGridViewCheckBoxColumn();
            OldName = new DataGridViewTextBoxColumn();
            NewName = new DataGridViewTextBoxColumn();
            Error = new DataGridViewTextBoxColumn();
            SatusBar = new StatusStrip();
            tsStatus = new ToolStripStatusLabel();
            MsMenu.SuspendLayout();
            TsMenu.SuspendLayout();
            TsRules.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DgvRules).BeginInit();
            toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DgvArchivos).BeginInit();
            SatusBar.SuspendLayout();
            SuspendLayout();
            // 
            // MsMenu
            // 
            MsMenu.Items.AddRange(new ToolStripItem[] { archivoToolStripMenuItem, configuracionToolStripMenuItem, ayudaToolStripMenuItem });
            MsMenu.Location = new Point(0, 0);
            MsMenu.Name = "MsMenu";
            MsMenu.Size = new Size(831, 24);
            MsMenu.TabIndex = 0;
            MsMenu.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            archivoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { nuevoProyectoToolStripMenuItem, abrirCarpetaToolStripMenuItem });
            archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            archivoToolStripMenuItem.Size = new Size(60, 20);
            archivoToolStripMenuItem.Text = "Archivo";
            // 
            // nuevoProyectoToolStripMenuItem
            // 
            nuevoProyectoToolStripMenuItem.Name = "nuevoProyectoToolStripMenuItem";
            nuevoProyectoToolStripMenuItem.Size = new Size(159, 22);
            nuevoProyectoToolStripMenuItem.Text = "Nuevo Proyecto";
            // 
            // abrirCarpetaToolStripMenuItem
            // 
            abrirCarpetaToolStripMenuItem.Name = "abrirCarpetaToolStripMenuItem";
            abrirCarpetaToolStripMenuItem.Size = new Size(159, 22);
            abrirCarpetaToolStripMenuItem.Text = "Abrir Carpeta";
            // 
            // configuracionToolStripMenuItem
            // 
            configuracionToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { generalToolStripMenuItem });
            configuracionToolStripMenuItem.Name = "configuracionToolStripMenuItem";
            configuracionToolStripMenuItem.Size = new Size(95, 20);
            configuracionToolStripMenuItem.Text = "Configuracion";
            // 
            // generalToolStripMenuItem
            // 
            generalToolStripMenuItem.Name = "generalToolStripMenuItem";
            generalToolStripMenuItem.Size = new Size(114, 22);
            generalToolStripMenuItem.Text = "General";
            // 
            // ayudaToolStripMenuItem
            // 
            ayudaToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { acercaDeToolStripMenuItem });
            ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            ayudaToolStripMenuItem.Size = new Size(53, 20);
            ayudaToolStripMenuItem.Text = "Ayuda";
            // 
            // acercaDeToolStripMenuItem
            // 
            acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem";
            acercaDeToolStripMenuItem.Size = new Size(126, 22);
            acercaDeToolStripMenuItem.Text = "Acerca de";
            // 
            // TsMenu
            // 
            TsMenu.GripStyle = ToolStripGripStyle.Hidden;
            TsMenu.Items.AddRange(new ToolStripItem[] { BtnOpen, toolStripLabel1, BtnPreview, toolStripLabel2, BtnRename });
            TsMenu.Location = new Point(0, 24);
            TsMenu.Name = "TsMenu";
            TsMenu.Size = new Size(831, 55);
            TsMenu.TabIndex = 1;
            TsMenu.Text = "TsMenu";
            // 
            // BtnOpen
            // 
            BtnOpen.Image = (Image)resources.GetObject("BtnOpen.Image");
            BtnOpen.ImageScaling = ToolStripItemImageScaling.None;
            BtnOpen.ImageTransparentColor = Color.Magenta;
            BtnOpen.Name = "BtnOpen";
            BtnOpen.Size = new Size(129, 52);
            BtnOpen.Text = "Abrir Carpeta";
            BtnOpen.Click += BtnOpen_Click;
            // 
            // toolStripLabel1
            // 
            toolStripLabel1.Image = (Image)resources.GetObject("toolStripLabel1.Image");
            toolStripLabel1.Name = "toolStripLabel1";
            toolStripLabel1.Size = new Size(16, 52);
            // 
            // BtnPreview
            // 
            BtnPreview.Image = (Image)resources.GetObject("BtnPreview.Image");
            BtnPreview.ImageScaling = ToolStripItemImageScaling.None;
            BtnPreview.ImageTransparentColor = Color.Magenta;
            BtnPreview.Name = "BtnPreview";
            BtnPreview.Size = new Size(124, 52);
            BtnPreview.Text = "Previsualizar";
            // 
            // toolStripLabel2
            // 
            toolStripLabel2.Image = (Image)resources.GetObject("toolStripLabel2.Image");
            toolStripLabel2.Name = "toolStripLabel2";
            toolStripLabel2.Size = new Size(16, 52);
            // 
            // BtnRename
            // 
            BtnRename.Image = (Image)resources.GetObject("BtnRename.Image");
            BtnRename.ImageScaling = ToolStripItemImageScaling.None;
            BtnRename.ImageTransparentColor = Color.Magenta;
            BtnRename.Name = "BtnRename";
            BtnRename.Size = new Size(118, 52);
            BtnRename.Text = "Renombrar";
            // 
            // TsRules
            // 
            TsRules.GripStyle = ToolStripGripStyle.Hidden;
            TsRules.Items.AddRange(new ToolStripItem[] { BtnAddRule, BtnRemoveRule });
            TsRules.Location = new Point(0, 79);
            TsRules.Name = "TsRules";
            TsRules.Size = new Size(831, 25);
            TsRules.TabIndex = 2;
            TsRules.Text = "toolStrip1";
            // 
            // BtnAddRule
            // 
            BtnAddRule.Image = (Image)resources.GetObject("BtnAddRule.Image");
            BtnAddRule.ImageTransparentColor = Color.Magenta;
            BtnAddRule.Name = "BtnAddRule";
            BtnAddRule.Size = new Size(62, 22);
            BtnAddRule.Text = "Añadir";
            BtnAddRule.Click += BtnAddRule_Click;
            // 
            // BtnRemoveRule
            // 
            BtnRemoveRule.Image = (Image)resources.GetObject("BtnRemoveRule.Image");
            BtnRemoveRule.ImageTransparentColor = Color.Magenta;
            BtnRemoveRule.Name = "BtnRemoveRule";
            BtnRemoveRule.Size = new Size(59, 22);
            BtnRemoveRule.Text = "Borrar";
            // 
            // DgvRules
            // 
            DgvRules.AllowUserToAddRows = false;
            DgvRules.AllowUserToDeleteRows = false;
            DgvRules.CellBorderStyle = DataGridViewCellBorderStyle.None;
            DgvRules.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            DgvRules.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgvRules.Columns.AddRange(new DataGridViewColumn[] { Nro, Rule, Instruction });
            DgvRules.Dock = DockStyle.Top;
            DgvRules.Location = new Point(0, 104);
            DgvRules.Name = "DgvRules";
            DgvRules.ReadOnly = true;
            DgvRules.RowHeadersVisible = false;
            DgvRules.RowTemplate.Height = 20;
            DgvRules.ScrollBars = ScrollBars.Vertical;
            DgvRules.Size = new Size(831, 172);
            DgvRules.TabIndex = 3;
            // 
            // Nro
            // 
            Nro.HeaderText = "#";
            Nro.Name = "Nro";
            Nro.ReadOnly = true;
            Nro.Width = 50;
            // 
            // Rule
            // 
            Rule.HeaderText = "Regla";
            Rule.Name = "Rule";
            Rule.ReadOnly = true;
            // 
            // Instruction
            // 
            Instruction.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Instruction.HeaderText = "Instruccion";
            Instruction.Name = "Instruction";
            Instruction.ReadOnly = true;
            // 
            // toolStrip1
            // 
            toolStrip1.GripStyle = ToolStripGripStyle.Hidden;
            toolStrip1.Items.AddRange(new ToolStripItem[] { TsmArchivos, TsmOpciones });
            toolStrip1.Location = new Point(0, 276);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(831, 25);
            toolStrip1.TabIndex = 4;
            toolStrip1.Text = "toolStrip1";
            // 
            // TsmArchivos
            // 
            TsmArchivos.DropDownItems.AddRange(new ToolStripItem[] { marcarTodosToolStripMenuItem, desmarcarTodosToolStripMenuItem });
            TsmArchivos.Image = (Image)resources.GetObject("TsmArchivos.Image");
            TsmArchivos.ImageTransparentColor = Color.Magenta;
            TsmArchivos.Name = "TsmArchivos";
            TsmArchivos.Size = new Size(82, 22);
            TsmArchivos.Text = "Archivos";
            // 
            // marcarTodosToolStripMenuItem
            // 
            marcarTodosToolStripMenuItem.Name = "marcarTodosToolStripMenuItem";
            marcarTodosToolStripMenuItem.Size = new Size(163, 22);
            marcarTodosToolStripMenuItem.Text = "Marcar todos";
            // 
            // desmarcarTodosToolStripMenuItem
            // 
            desmarcarTodosToolStripMenuItem.Name = "desmarcarTodosToolStripMenuItem";
            desmarcarTodosToolStripMenuItem.Size = new Size(163, 22);
            desmarcarTodosToolStripMenuItem.Text = "Desmarcar todos";
            // 
            // TsmOpciones
            // 
            TsmOpciones.DropDownItems.AddRange(new ToolStripItem[] { autoajustarColumnasToolStripMenuItem });
            TsmOpciones.Image = (Image)resources.GetObject("TsmOpciones.Image");
            TsmOpciones.ImageTransparentColor = Color.Magenta;
            TsmOpciones.Name = "TsmOpciones";
            TsmOpciones.Size = new Size(86, 22);
            TsmOpciones.Text = "Opciones";
            // 
            // autoajustarColumnasToolStripMenuItem
            // 
            autoajustarColumnasToolStripMenuItem.Name = "autoajustarColumnasToolStripMenuItem";
            autoajustarColumnasToolStripMenuItem.Size = new Size(192, 22);
            autoajustarColumnasToolStripMenuItem.Text = "Autoajustar Columnas";
            // 
            // DgvArchivos
            // 
            DgvArchivos.AllowUserToAddRows = false;
            DgvArchivos.AllowUserToDeleteRows = false;
            DgvArchivos.CellBorderStyle = DataGridViewCellBorderStyle.None;
            DgvArchivos.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            DgvArchivos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgvArchivos.Columns.AddRange(new DataGridViewColumn[] { Status, OldName, NewName, Error });
            DgvArchivos.Dock = DockStyle.Fill;
            DgvArchivos.Location = new Point(0, 301);
            DgvArchivos.Name = "DgvArchivos";
            DgvArchivos.ReadOnly = true;
            DgvArchivos.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            DgvArchivos.RowHeadersVisible = false;
            DgvArchivos.RowTemplate.Height = 20;
            DgvArchivos.ScrollBars = ScrollBars.Vertical;
            DgvArchivos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DgvArchivos.Size = new Size(831, 265);
            DgvArchivos.TabIndex = 5;
            // 
            // Status
            // 
            Status.HeaderText = "Estado";
            Status.Name = "Status";
            Status.ReadOnly = true;
            Status.Width = 50;
            // 
            // OldName
            // 
            OldName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            OldName.HeaderText = "Nombre";
            OldName.MinimumWidth = 400;
            OldName.Name = "OldName";
            OldName.ReadOnly = true;
            // 
            // NewName
            // 
            NewName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            NewName.HeaderText = "Nuevo Nombre";
            NewName.Name = "NewName";
            NewName.ReadOnly = true;
            // 
            // Error
            // 
            Error.HeaderText = "Error";
            Error.Name = "Error";
            Error.ReadOnly = true;
            Error.Width = 150;
            // 
            // SatusBar
            // 
            SatusBar.Items.AddRange(new ToolStripItem[] { tsStatus });
            SatusBar.Location = new Point(0, 544);
            SatusBar.Name = "SatusBar";
            SatusBar.Size = new Size(831, 22);
            SatusBar.TabIndex = 6;
            SatusBar.Text = "StatusBar";
            // 
            // tsStatus
            // 
            tsStatus.Name = "tsStatus";
            tsStatus.Size = new Size(0, 17);
            // 
            // FrmHome
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(831, 566);
            Controls.Add(SatusBar);
            Controls.Add(DgvArchivos);
            Controls.Add(toolStrip1);
            Controls.Add(DgvRules);
            Controls.Add(TsRules);
            Controls.Add(TsMenu);
            Controls.Add(MsMenu);
            MainMenuStrip = MsMenu;
            Name = "FrmHome";
            Text = "ReNames";
            MsMenu.ResumeLayout(false);
            MsMenu.PerformLayout();
            TsMenu.ResumeLayout(false);
            TsMenu.PerformLayout();
            TsRules.ResumeLayout(false);
            TsRules.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DgvRules).EndInit();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DgvArchivos).EndInit();
            SatusBar.ResumeLayout(false);
            SatusBar.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip MsMenu;
        private ToolStripMenuItem archivoToolStripMenuItem;
        private ToolStripMenuItem nuevoProyectoToolStripMenuItem;
        private ToolStripMenuItem abrirCarpetaToolStripMenuItem;
        private ToolStripMenuItem configuracionToolStripMenuItem;
        private ToolStripMenuItem generalToolStripMenuItem;
        private ToolStripMenuItem ayudaToolStripMenuItem;
        private ToolStripMenuItem acercaDeToolStripMenuItem;
        private ToolStrip TsMenu;
        private ToolStripButton BtnOpen;
        private ToolStripLabel toolStripLabel1;
        private ToolStripButton BtnPreview;
        private ToolStripButton BtnRename;
        private ToolStripLabel toolStripLabel2;
        private ToolStrip TsRules;
        private ToolStripButton BtnAddRule;
        private ToolStripButton BtnRemoveRule;
        private DataGridView DgvRules;
        private ToolStrip toolStrip1;
        private ToolStripDropDownButton TsmArchivos;
        private ToolStripMenuItem marcarTodosToolStripMenuItem;
        private ToolStripMenuItem desmarcarTodosToolStripMenuItem;
        private ToolStripDropDownButton TsmOpciones;
        private ToolStripMenuItem autoajustarColumnasToolStripMenuItem;
        private DataGridView DgvArchivos;
        private StatusStrip SatusBar;
        private ToolStripStatusLabel tsStatus;
        private DataGridViewCheckBoxColumn Nro;
        private DataGridViewTextBoxColumn Rule;
        private DataGridViewTextBoxColumn Instruction;
        private DataGridViewCheckBoxColumn Status;
        private DataGridViewTextBoxColumn OldName;
        private DataGridViewTextBoxColumn NewName;
        private DataGridViewTextBoxColumn Error;
    }
}