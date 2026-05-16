namespace ManergerLaserCut
{
    partial class MANAGER_MENU
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
            this.panMain = new JPlatform.Client.Controls8.PanelEx();
            this.chkAll = new JPlatform.Client.Controls8.CheckEditEx();
            this.cboVSM = new DevExpress.XtraEditors.CheckedComboBoxEdit();
            this.cboResFCT = new DevExpress.XtraEditors.CheckedComboBoxEdit();
            this.cboResPlant = new DevExpress.XtraEditors.CheckedComboBoxEdit();
            this.lblPlantSub = new JPlatform.Client.Controls8.LabelEx();
            this.labelEx1 = new JPlatform.Client.Controls8.LabelEx();
            this.cboOpCD = new JPlatform.Client.Controls8.LookUpEditEx();
            this.lblOpCD = new JPlatform.Client.Controls8.LabelEx();
            this.lblPlant = new JPlatform.Client.Controls8.LabelEx();
            this.panelEx1 = new JPlatform.Client.Controls8.PanelEx();
            this.grdDGM = new JPlatform.Client.Controls8.GridControlEx();
            this.gvwDGM = new JPlatform.Client.Controls8.GridViewEx();
            this.colPLANT_ID = new JPlatform.Client.Controls8.GridColumnEx();
            this.colSUB_PLANT = new JPlatform.Client.Controls8.GridColumnEx();
            this.colLINE_CODE = new JPlatform.Client.Controls8.GridColumnEx();
            this.colRES_ID = new JPlatform.Client.Controls8.GridColumnEx();
            this.colLOG_IP = new JPlatform.Client.Controls8.GridColumnEx();
            this.colUSER_ID = new JPlatform.Client.Controls8.GridColumnEx();
            this.colUSER_NAME = new JPlatform.Client.Controls8.GridColumnEx();
            this.colSYSTEM = new JPlatform.Client.Controls8.GridColumnEx();
            this.colLOGIN_TIME = new JPlatform.Client.Controls8.GridColumnEx();
            this.colLOGOUT_TIME = new JPlatform.Client.Controls8.GridColumnEx();
            this.btnClear = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            ((System.ComponentModel.ISupportInitialize)(this.panMain)).BeginInit();
            this.panMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chkAll.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboVSM.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboResFCT.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboResPlant.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboOpCD.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelEx1)).BeginInit();
            this.panelEx1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdDGM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvwDGM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClear)).BeginInit();
            this.SuspendLayout();
            // 
            // panMain
            // 
            this.panMain.Controls.Add(this.chkAll);
            this.panMain.Controls.Add(this.cboVSM);
            this.panMain.Controls.Add(this.cboResFCT);
            this.panMain.Controls.Add(this.cboResPlant);
            this.panMain.Controls.Add(this.lblPlantSub);
            this.panMain.Controls.Add(this.labelEx1);
            this.panMain.Controls.Add(this.cboOpCD);
            this.panMain.Controls.Add(this.lblOpCD);
            this.panMain.Controls.Add(this.lblPlant);
            this.panMain.Dock = System.Windows.Forms.DockStyle.Top;
            this.panMain.Location = new System.Drawing.Point(0, 0);
            this.panMain.Name = "panMain";
            this.panMain.Size = new System.Drawing.Size(1356, 49);
            this.panMain.TabIndex = 1;
            // 
            // chkAll
            // 
            this.chkAll.ControlValue = false;
            this.chkAll.EditValue = false;
            this.chkAll.Location = new System.Drawing.Point(1024, 15);
            this.chkAll.Name = "chkAll";
            this.chkAll.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkAll.Properties.Appearance.Options.UseFont = true;
            this.chkAll.Properties.Caption = "ALL MACHINE";
            this.chkAll.Properties.ValueChecked = "Y";
            this.chkAll.Properties.ValueUnchecked = "N";
            this.chkAll.Properties.WordText = "ALL MACHINE";
            this.chkAll.Size = new System.Drawing.Size(168, 18);
            this.chkAll.TabIndex = 346;
            // 
            // cboVSM
            // 
            this.cboVSM.Location = new System.Drawing.Point(631, 13);
            this.cboVSM.Name = "cboVSM";
            this.cboVSM.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.cboVSM.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.cboVSM.Properties.Appearance.Options.UseBackColor = true;
            this.cboVSM.Properties.Appearance.Options.UseFont = true;
            this.cboVSM.Properties.AutoHeight = false;
            this.cboVSM.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboVSM.Size = new System.Drawing.Size(150, 20);
            this.cboVSM.TabIndex = 345;
            // 
            // cboResFCT
            // 
            this.cboResFCT.Location = new System.Drawing.Point(112, 13);
            this.cboResFCT.Name = "cboResFCT";
            this.cboResFCT.Properties.Appearance.BackColor = System.Drawing.Color.MistyRose;
            this.cboResFCT.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.cboResFCT.Properties.Appearance.Options.UseBackColor = true;
            this.cboResFCT.Properties.Appearance.Options.UseFont = true;
            this.cboResFCT.Properties.AutoHeight = false;
            this.cboResFCT.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboResFCT.Size = new System.Drawing.Size(150, 20);
            this.cboResFCT.TabIndex = 344;
            // 
            // cboResPlant
            // 
            this.cboResPlant.Location = new System.Drawing.Point(391, 13);
            this.cboResPlant.Name = "cboResPlant";
            this.cboResPlant.Properties.Appearance.BackColor = System.Drawing.Color.MistyRose;
            this.cboResPlant.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.cboResPlant.Properties.Appearance.Options.UseBackColor = true;
            this.cboResPlant.Properties.Appearance.Options.UseFont = true;
            this.cboResPlant.Properties.AutoHeight = false;
            this.cboResPlant.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboResPlant.Size = new System.Drawing.Size(150, 20);
            this.cboResPlant.TabIndex = 343;
            // 
            // lblPlantSub
            // 
            this.lblPlantSub.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblPlantSub.Appearance.Options.UseFont = true;
            this.lblPlantSub.Appearance.Options.UseTextOptions = true;
            this.lblPlantSub.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.lblPlantSub.Location = new System.Drawing.Point(303, 13);
            this.lblPlantSub.Name = "lblPlantSub";
            this.lblPlantSub.Size = new System.Drawing.Size(80, 20);
            this.lblPlantSub.TabIndex = 339;
            this.lblPlantSub.Text = "RES PLANT";
            this.lblPlantSub.WordText = "RES PLANT";
            // 
            // labelEx1
            // 
            this.labelEx1.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.labelEx1.Appearance.Options.UseFont = true;
            this.labelEx1.Appearance.Options.UseTextOptions = true;
            this.labelEx1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.labelEx1.Location = new System.Drawing.Point(545, 13);
            this.labelEx1.Name = "labelEx1";
            this.labelEx1.Size = new System.Drawing.Size(80, 20);
            this.labelEx1.TabIndex = 319;
            this.labelEx1.Text = "VSM";
            this.labelEx1.WordID = "W2018061516233468138";
            this.labelEx1.WordText = "VSM";
            // 
            // cboOpCD
            // 
            this.cboOpCD.ControlValue = null;
            this.cboOpCD.Location = new System.Drawing.Point(868, 13);
            this.cboOpCD.Name = "cboOpCD";
            this.cboOpCD.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.cboOpCD.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.cboOpCD.Properties.Appearance.Options.UseBackColor = true;
            this.cboOpCD.Properties.Appearance.Options.UseFont = true;
            this.cboOpCD.Properties.BeforeEditValue = null;
            this.cboOpCD.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboOpCD.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.cboOpCD.Size = new System.Drawing.Size(150, 20);
            this.cboOpCD.TabIndex = 318;
            // 
            // lblOpCD
            // 
            this.lblOpCD.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblOpCD.Appearance.Options.UseFont = true;
            this.lblOpCD.Appearance.Options.UseTextOptions = true;
            this.lblOpCD.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.lblOpCD.Location = new System.Drawing.Point(782, 13);
            this.lblOpCD.Name = "lblOpCD";
            this.lblOpCD.Size = new System.Drawing.Size(80, 20);
            this.lblOpCD.TabIndex = 317;
            this.lblOpCD.Text = " OP";
            this.lblOpCD.WordText = "OP";
            // 
            // lblPlant
            // 
            this.lblPlant.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblPlant.Appearance.Options.UseFont = true;
            this.lblPlant.Appearance.Options.UseTextOptions = true;
            this.lblPlant.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.lblPlant.Location = new System.Drawing.Point(8, 13);
            this.lblPlant.Name = "lblPlant";
            this.lblPlant.Size = new System.Drawing.Size(100, 20);
            this.lblPlant.TabIndex = 316;
            this.lblPlant.Text = "RES FCT";
            this.lblPlant.WordText = "RES FCT";
            // 
            // panelEx1
            // 
            this.panelEx1.Controls.Add(this.grdDGM);
            this.panelEx1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelEx1.Location = new System.Drawing.Point(0, 49);
            this.panelEx1.Name = "panelEx1";
            this.panelEx1.Size = new System.Drawing.Size(1356, 448);
            this.panelEx1.TabIndex = 153;
            // 
            // grdDGM
            // 
            this.grdDGM.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdDGM.Location = new System.Drawing.Point(2, 2);
            this.grdDGM.MainView = this.gvwDGM;
            this.grdDGM.Name = "grdDGM";
            this.grdDGM.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.btnClear});
            this.grdDGM.Size = new System.Drawing.Size(1352, 444);
            this.grdDGM.TabIndex = 8;
            this.grdDGM.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvwDGM});
            // 
            // gvwDGM
            // 
            this.gvwDGM.ActionMode = JPlatform.Client.Controls8.ActionMode.View;
            this.gvwDGM.Appearance.GroupFooter.Options.UseFont = true;
            this.gvwDGM.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colPLANT_ID,
            this.colSUB_PLANT,
            this.colLINE_CODE,
            this.colRES_ID,
            this.colLOG_IP,
            this.colUSER_ID,
            this.colUSER_NAME,
            this.colSYSTEM,
            this.colLOGIN_TIME,
            this.colLOGOUT_TIME});
            this.gvwDGM.GridControl = this.grdDGM;
            this.gvwDGM.Name = "gvwDGM";
            this.gvwDGM.OptionsBehavior.EditorShowMode = DevExpress.Utils.EditorShowMode.MouseDown;
            this.gvwDGM.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
            this.gvwDGM.OptionsView.ColumnAutoWidth = false;
            this.gvwDGM.OptionsView.ShowFooter = true;
            this.gvwDGM.OptionsView.ShowGroupPanel = false;
            // 
            // colPLANT_ID
            // 
            this.colPLANT_ID.AppearanceCell.Options.UseTextOptions = true;
            this.colPLANT_ID.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colPLANT_ID.AppearanceHeader.Options.UseTextOptions = true;
            this.colPLANT_ID.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colPLANT_ID.BindingField = "PLANT_ID";
            this.colPLANT_ID.Caption = "FCT";
            this.colPLANT_ID.ColumnEdit = null;
            this.colPLANT_ID.FieldName = "PLANT_ID";
            this.colPLANT_ID.Name = "colPLANT_ID";
            this.colPLANT_ID.OptionsColumn.ReadOnly = true;
            this.colPLANT_ID.Visible = true;
            this.colPLANT_ID.VisibleIndex = 0;
            this.colPLANT_ID.Width = 60;
            // 
            // colSUB_PLANT
            // 
            this.colSUB_PLANT.AppearanceCell.Options.UseTextOptions = true;
            this.colSUB_PLANT.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSUB_PLANT.AppearanceHeader.Options.UseTextOptions = true;
            this.colSUB_PLANT.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSUB_PLANT.BindingField = "SUB_PLANT";
            this.colSUB_PLANT.Caption = "PLANT";
            this.colSUB_PLANT.ColumnEdit = null;
            this.colSUB_PLANT.FieldName = "SUB_PLANT";
            this.colSUB_PLANT.Name = "colSUB_PLANT";
            this.colSUB_PLANT.OptionsColumn.ReadOnly = true;
            this.colSUB_PLANT.Visible = true;
            this.colSUB_PLANT.VisibleIndex = 1;
            // 
            // colLINE_CODE
            // 
            this.colLINE_CODE.AppearanceCell.Options.UseTextOptions = true;
            this.colLINE_CODE.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colLINE_CODE.AppearanceHeader.Options.UseTextOptions = true;
            this.colLINE_CODE.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colLINE_CODE.BindingField = "LINE_CODE";
            this.colLINE_CODE.Caption = "LINE CODE";
            this.colLINE_CODE.ColumnEdit = null;
            this.colLINE_CODE.FieldName = "LINE_CODE";
            this.colLINE_CODE.Name = "colLINE_CODE";
            this.colLINE_CODE.OptionsColumn.ReadOnly = true;
            this.colLINE_CODE.Width = 115;
            // 
            // colRES_ID
            // 
            this.colRES_ID.AppearanceCell.Options.UseTextOptions = true;
            this.colRES_ID.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colRES_ID.AppearanceHeader.Options.UseTextOptions = true;
            this.colRES_ID.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colRES_ID.BindingField = "RES_ID";
            this.colRES_ID.Caption = "MACHINE";
            this.colRES_ID.ColumnEdit = null;
            this.colRES_ID.FieldName = "RES_ID";
            this.colRES_ID.Name = "colRES_ID";
            this.colRES_ID.OptionsColumn.ReadOnly = true;
            this.colRES_ID.Visible = true;
            this.colRES_ID.VisibleIndex = 2;
            this.colRES_ID.Width = 150;
            // 
            // colLOG_IP
            // 
            this.colLOG_IP.AppearanceCell.Options.UseTextOptions = true;
            this.colLOG_IP.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colLOG_IP.AppearanceHeader.Options.UseTextOptions = true;
            this.colLOG_IP.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colLOG_IP.BindingField = "LOG_IP";
            this.colLOG_IP.Caption = "MACHINE IP";
            this.colLOG_IP.ColumnEdit = null;
            this.colLOG_IP.FieldName = "LOG_IP";
            this.colLOG_IP.Name = "colLOG_IP";
            this.colLOG_IP.OptionsColumn.ReadOnly = true;
            this.colLOG_IP.Visible = true;
            this.colLOG_IP.VisibleIndex = 3;
            this.colLOG_IP.Width = 114;
            // 
            // colUSER_ID
            // 
            this.colUSER_ID.AppearanceCell.Options.UseTextOptions = true;
            this.colUSER_ID.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colUSER_ID.AppearanceHeader.Options.UseTextOptions = true;
            this.colUSER_ID.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colUSER_ID.BindingField = "USER_ID";
            this.colUSER_ID.Caption = "USER ID";
            this.colUSER_ID.ColumnEdit = null;
            this.colUSER_ID.FieldName = "USER_ID";
            this.colUSER_ID.Name = "colUSER_ID";
            this.colUSER_ID.OptionsColumn.ReadOnly = true;
            this.colUSER_ID.Visible = true;
            this.colUSER_ID.VisibleIndex = 4;
            this.colUSER_ID.Width = 98;
            // 
            // colUSER_NAME
            // 
            this.colUSER_NAME.AppearanceCell.Options.UseTextOptions = true;
            this.colUSER_NAME.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colUSER_NAME.AppearanceHeader.Options.UseTextOptions = true;
            this.colUSER_NAME.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colUSER_NAME.BindingField = "USER_NAME";
            this.colUSER_NAME.Caption = "USER NAME";
            this.colUSER_NAME.ColumnEdit = null;
            this.colUSER_NAME.FieldName = "USER_NAME";
            this.colUSER_NAME.Name = "colUSER_NAME";
            this.colUSER_NAME.OptionsColumn.ReadOnly = true;
            this.colUSER_NAME.Visible = true;
            this.colUSER_NAME.VisibleIndex = 5;
            this.colUSER_NAME.Width = 150;
            // 
            // colSYSTEM
            // 
            this.colSYSTEM.AppearanceCell.Options.UseTextOptions = true;
            this.colSYSTEM.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSYSTEM.AppearanceHeader.Options.UseTextOptions = true;
            this.colSYSTEM.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSYSTEM.BindingField = "SYSTEM";
            this.colSYSTEM.Caption = "SYSTEM";
            this.colSYSTEM.ColumnEdit = null;
            this.colSYSTEM.FieldName = "SYSTEM";
            this.colSYSTEM.Name = "colSYSTEM";
            this.colSYSTEM.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.ShowAlways;
            this.colSYSTEM.Visible = true;
            this.colSYSTEM.VisibleIndex = 6;
            this.colSYSTEM.Width = 108;
            // 
            // colLOGIN_TIME
            // 
            this.colLOGIN_TIME.AppearanceCell.Options.UseTextOptions = true;
            this.colLOGIN_TIME.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colLOGIN_TIME.AppearanceHeader.Options.UseTextOptions = true;
            this.colLOGIN_TIME.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colLOGIN_TIME.BindingField = "LOGIN_TIME";
            this.colLOGIN_TIME.Caption = "LOGIN TIME";
            this.colLOGIN_TIME.ColumnEdit = null;
            this.colLOGIN_TIME.FieldName = "LOGIN_TIME";
            this.colLOGIN_TIME.Name = "colLOGIN_TIME";
            this.colLOGIN_TIME.OptionsColumn.ReadOnly = true;
            // 
            // colLOGOUT_TIME
            // 
            this.colLOGOUT_TIME.AppearanceCell.Options.UseTextOptions = true;
            this.colLOGOUT_TIME.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colLOGOUT_TIME.AppearanceHeader.Options.UseTextOptions = true;
            this.colLOGOUT_TIME.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colLOGOUT_TIME.BindingField = "LOGOUT_TIME";
            this.colLOGOUT_TIME.Caption = "LOGOUT TIME";
            this.colLOGOUT_TIME.ColumnEdit = null;
            this.colLOGOUT_TIME.FieldName = "LOGOUT_TIME";
            this.colLOGOUT_TIME.Name = "colLOGOUT_TIME";
            this.colLOGOUT_TIME.OptionsColumn.ReadOnly = true;
            // 
            // btnClear
            // 
            this.btnClear.AutoHeight = false;
            this.btnClear.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.btnClear.Name = "btnClear";
            this.btnClear.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            // 
            // MANAGER_MENU
            // 
            this.ClientSize = new System.Drawing.Size(1356, 497);
            this.Controls.Add(this.panelEx1);
            this.Controls.Add(this.panMain);
            this.Name = "MANAGER_MENU";
            ((System.ComponentModel.ISupportInitialize)(this.panMain)).EndInit();
            this.panMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chkAll.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboVSM.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboResFCT.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboResPlant.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboOpCD.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelEx1)).EndInit();
            this.panelEx1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdDGM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvwDGM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClear)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private JPlatform.Client.Controls8.GridViewEx gridViewEx1;
        private JPlatform.Client.Controls8.PanelEx panMain;
        private JPlatform.Client.Controls8.PanelEx panelEx1;
        private DevExpress.XtraEditors.CheckedComboBoxEdit cboVSM;
        private DevExpress.XtraEditors.CheckedComboBoxEdit cboResFCT;
        private DevExpress.XtraEditors.CheckedComboBoxEdit cboResPlant;
        private JPlatform.Client.Controls8.LabelEx lblPlantSub;
        private JPlatform.Client.Controls8.LabelEx labelEx1;
        private JPlatform.Client.Controls8.LookUpEditEx cboOpCD;
        private JPlatform.Client.Controls8.LabelEx lblOpCD;
        private JPlatform.Client.Controls8.LabelEx lblPlant;
        private JPlatform.Client.Controls8.CheckEditEx chkAll;
        private JPlatform.Client.Controls8.GridControlEx grdDGM;
        private JPlatform.Client.Controls8.GridViewEx gvwDGM;
        private JPlatform.Client.Controls8.GridColumnEx colPLANT_ID;
        private JPlatform.Client.Controls8.GridColumnEx colSUB_PLANT;
        private JPlatform.Client.Controls8.GridColumnEx colLINE_CODE;
        private JPlatform.Client.Controls8.GridColumnEx colRES_ID;
        private JPlatform.Client.Controls8.GridColumnEx colLOG_IP;
        private JPlatform.Client.Controls8.GridColumnEx colUSER_ID;
        private JPlatform.Client.Controls8.GridColumnEx colUSER_NAME;
        private JPlatform.Client.Controls8.GridColumnEx colSYSTEM;
        private JPlatform.Client.Controls8.GridColumnEx colLOGIN_TIME;
        private JPlatform.Client.Controls8.GridColumnEx colLOGOUT_TIME;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btnClear;
    }
}

