<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
	Inherits System.Windows.Forms.Form

	'Form overrides dispose to clean up the component list.
	<System.Diagnostics.DebuggerNonUserCode()> _
	Protected Overrides Sub Dispose(ByVal disposing As Boolean)
		Try
			If disposing AndAlso components IsNot Nothing Then
				components.Dispose()
			End If
		Finally
			MyBase.Dispose(disposing)
		End Try
	End Sub

	'Required by the Windows Form Designer
	Private components As System.ComponentModel.IContainer

	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.  
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> _
	Private Sub InitializeComponent()
		Me.components = New System.ComponentModel.Container()
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
		Me.pnlMachine = New System.Windows.Forms.Panel()
		Me.btnMachineSearch = New System.Windows.Forms.Button()
		Me.tbxMachineSearch = New System.Windows.Forms.TextBox()
		Me.btnAddMachine = New System.Windows.Forms.Button()
		Me.lvwMachine = New System.Windows.Forms.ListView()
		Me.col_M_ID = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
		Me.col_MC_Code = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
		Me.col_M_Name = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
		Me.col_M_Detail = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
		Me.cmsMachineList = New System.Windows.Forms.ContextMenuStrip(Me.components)
		Me.mnu_ML_Edit = New System.Windows.Forms.ToolStripMenuItem()
		Me.mnu_ML_Delete = New System.Windows.Forms.ToolStripMenuItem()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.Label3 = New System.Windows.Forms.Label()
		Me.pnlPart = New System.Windows.Forms.Panel()
		Me.btnPartSearch = New System.Windows.Forms.Button()
		Me.tbxPartSearch = New System.Windows.Forms.TextBox()
		Me.btnAddPart = New System.Windows.Forms.Button()
		Me.lvwPartList = New System.Windows.Forms.ListView()
		Me.col_P_ID = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
		Me.col_P_PartNo = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
		Me.col_P_Name = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
		Me.col_P_Price = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
		Me.cmsPartList = New System.Windows.Forms.ContextMenuStrip(Me.components)
		Me.mnu_PL_Edit = New System.Windows.Forms.ToolStripMenuItem()
		Me.mnu_PL_Delete = New System.Windows.Forms.ToolStripMenuItem()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.Label4 = New System.Windows.Forms.Label()
		Me.pnlMaintenance = New System.Windows.Forms.Panel()
		Me.chkSearch_PartName = New System.Windows.Forms.CheckBox()
		Me.chkSearch_MachineName = New System.Windows.Forms.CheckBox()
		Me.chkSearch_Type = New System.Windows.Forms.CheckBox()
		Me.btnPMSearch = New System.Windows.Forms.Button()
		Me.tbxPMSearch = New System.Windows.Forms.TextBox()
		Me.btnAddMaintenance = New System.Windows.Forms.Button()
		Me.lvwPMList = New System.Windows.Forms.ListView()
		Me.col_PM_ID = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
		Me.col_PM_Type = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
		Me.col_PM_MachineName = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
		Me.col_PM_PartName = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
		Me.col_PM_PartQty = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
		Me.col_PM_Frequency = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
		Me.col_PM_PartPrice = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
		Me.col_PM_TotalPrice = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
		Me.col_PM_LastPM = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
		Me.col_PM_NextPM = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
		Me.col_PM_Action = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
		Me.cmsPMList = New System.Windows.Forms.ContextMenuStrip(Me.components)
		Me.mnu_PML_Edit = New System.Windows.Forms.ToolStripMenuItem()
		Me.mnu_PML_Delete = New System.Windows.Forms.ToolStripMenuItem()
		Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator()
		Me.mnu_PML_CompletePMSchedule = New System.Windows.Forms.ToolStripMenuItem()
		Me.Label5 = New System.Windows.Forms.Label()
		Me.Label6 = New System.Windows.Forms.Label()
		Me.pnlFooter = New System.Windows.Forms.Panel()
		Me.btnExit = New System.Windows.Forms.Button()
		Me.pnlPMHistory = New System.Windows.Forms.Panel()
		Me.lvwPMHistoryList = New System.Windows.Forms.ListView()
		Me.col_PMH_ID = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
		Me.col_PMH_PMID = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
		Me.col_PMH_PMDate = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
		Me.col_PMH_MachineName = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
		Me.col_PMH_PartName = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
		Me.col_PMH_Operator = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
		Me.col_PMH_Reporter = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
		Me.col_PMH_Details = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
		Me.col_PMH_Result = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
		Me.cmsPMHistoryList = New System.Windows.Forms.ContextMenuStrip(Me.components)
		Me.mnu_PMH_Edit = New System.Windows.Forms.ToolStripMenuItem()
		Me.Label7 = New System.Windows.Forms.Label()
		Me.pnlHeader = New System.Windows.Forms.Panel()
		Me.picIcon = New System.Windows.Forms.PictureBox()
		Me.lblTitle = New System.Windows.Forms.Label()
		Me.pnlMachine.SuspendLayout()
		Me.cmsMachineList.SuspendLayout()
		Me.pnlPart.SuspendLayout()
		Me.cmsPartList.SuspendLayout()
		Me.pnlMaintenance.SuspendLayout()
		Me.cmsPMList.SuspendLayout()
		Me.pnlPMHistory.SuspendLayout()
		Me.cmsPMHistoryList.SuspendLayout()
		Me.pnlHeader.SuspendLayout()
		CType(Me.picIcon, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'pnlMachine
		'
		Me.pnlMachine.Controls.Add(Me.btnMachineSearch)
		Me.pnlMachine.Controls.Add(Me.tbxMachineSearch)
		Me.pnlMachine.Controls.Add(Me.btnAddMachine)
		Me.pnlMachine.Controls.Add(Me.lvwMachine)
		Me.pnlMachine.Controls.Add(Me.Label1)
		Me.pnlMachine.Controls.Add(Me.Label3)
		Me.pnlMachine.Location = New System.Drawing.Point(12, 81)
		Me.pnlMachine.Name = "pnlMachine"
		Me.pnlMachine.Size = New System.Drawing.Size(718, 220)
		Me.pnlMachine.TabIndex = 0
		'
		'btnMachineSearch
		'
		Me.btnMachineSearch.BackColor = System.Drawing.Color.DeepSkyBlue
		Me.btnMachineSearch.FlatAppearance.BorderSize = 0
		Me.btnMachineSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.btnMachineSearch.Image = CType(resources.GetObject("btnMachineSearch.Image"), System.Drawing.Image)
		Me.btnMachineSearch.Location = New System.Drawing.Point(527, 8)
		Me.btnMachineSearch.Name = "btnMachineSearch"
		Me.btnMachineSearch.Size = New System.Drawing.Size(24, 24)
		Me.btnMachineSearch.TabIndex = 1
		Me.btnMachineSearch.UseVisualStyleBackColor = False
		'
		'tbxMachineSearch
		'
		Me.tbxMachineSearch.Location = New System.Drawing.Point(402, 9)
		Me.tbxMachineSearch.Name = "tbxMachineSearch"
		Me.tbxMachineSearch.Size = New System.Drawing.Size(119, 23)
		Me.tbxMachineSearch.TabIndex = 0
		'
		'btnAddMachine
		'
		Me.btnAddMachine.BackColor = System.Drawing.Color.LimeGreen
		Me.btnAddMachine.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.btnAddMachine.ForeColor = System.Drawing.Color.White
		Me.btnAddMachine.Location = New System.Drawing.Point(557, 7)
		Me.btnAddMachine.Name = "btnAddMachine"
		Me.btnAddMachine.Size = New System.Drawing.Size(149, 26)
		Me.btnAddMachine.TabIndex = 2
		Me.btnAddMachine.Text = "Add Machine"
		Me.btnAddMachine.UseVisualStyleBackColor = False
		'
		'lvwMachine
		'
		Me.lvwMachine.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
			Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.lvwMachine.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.col_M_ID, Me.col_MC_Code, Me.col_M_Name, Me.col_M_Detail})
		Me.lvwMachine.ContextMenuStrip = Me.cmsMachineList
		Me.lvwMachine.FullRowSelect = True
		Me.lvwMachine.GridLines = True
		Me.lvwMachine.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
		Me.lvwMachine.HideSelection = False
		Me.lvwMachine.Location = New System.Drawing.Point(6, 37)
		Me.lvwMachine.Name = "lvwMachine"
		Me.lvwMachine.Size = New System.Drawing.Size(708, 180)
		Me.lvwMachine.TabIndex = 3
		Me.lvwMachine.UseCompatibleStateImageBehavior = False
		Me.lvwMachine.View = System.Windows.Forms.View.Details
		'
		'col_M_ID
		'
		Me.col_M_ID.Text = "ID"
		Me.col_M_ID.Width = 0
		'
		'col_MC_Code
		'
		Me.col_MC_Code.Text = "Code"
		Me.col_MC_Code.Width = 120
		'
		'col_M_Name
		'
		Me.col_M_Name.Text = "Name"
		Me.col_M_Name.Width = 220
		'
		'col_M_Detail
		'
		Me.col_M_Detail.Text = "Detail"
		Me.col_M_Detail.Width = 340
		'
		'cmsMachineList
		'
		Me.cmsMachineList.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnu_ML_Edit, Me.mnu_ML_Delete})
		Me.cmsMachineList.Name = "cmsMachineList"
		Me.cmsMachineList.Size = New System.Drawing.Size(108, 48)
		'
		'mnu_ML_Edit
		'
		Me.mnu_ML_Edit.Image = Global.PMSys.My.Resources.Resources.approval16
		Me.mnu_ML_Edit.Name = "mnu_ML_Edit"
		Me.mnu_ML_Edit.Size = New System.Drawing.Size(107, 22)
		Me.mnu_ML_Edit.Text = "Edit"
		'
		'mnu_ML_Delete
		'
		Me.mnu_ML_Delete.Enabled = False
		Me.mnu_ML_Delete.Image = Global.PMSys.My.Resources.Resources.close16
		Me.mnu_ML_Delete.Name = "mnu_ML_Delete"
		Me.mnu_ML_Delete.Size = New System.Drawing.Size(107, 22)
		Me.mnu_ML_Delete.Text = "Delete"
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label1.Location = New System.Drawing.Point(3, 10)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(138, 18)
		Me.Label1.TabIndex = 1
		Me.Label1.Text = "MACHINE LIST"
		'
		'Label3
		'
		Me.Label3.AutoSize = True
		Me.Label3.Location = New System.Drawing.Point(344, 12)
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(60, 16)
		Me.Label3.TabIndex = 4
		Me.Label3.Text = "Search:"
		'
		'pnlPart
		'
		Me.pnlPart.Controls.Add(Me.btnPartSearch)
		Me.pnlPart.Controls.Add(Me.tbxPartSearch)
		Me.pnlPart.Controls.Add(Me.btnAddPart)
		Me.pnlPart.Controls.Add(Me.lvwPartList)
		Me.pnlPart.Controls.Add(Me.Label2)
		Me.pnlPart.Controls.Add(Me.Label4)
		Me.pnlPart.Location = New System.Drawing.Point(738, 81)
		Me.pnlPart.Name = "pnlPart"
		Me.pnlPart.Size = New System.Drawing.Size(718, 220)
		Me.pnlPart.TabIndex = 1
		'
		'btnPartSearch
		'
		Me.btnPartSearch.BackColor = System.Drawing.Color.DeepSkyBlue
		Me.btnPartSearch.FlatAppearance.BorderSize = 0
		Me.btnPartSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.btnPartSearch.Image = CType(resources.GetObject("btnPartSearch.Image"), System.Drawing.Image)
		Me.btnPartSearch.Location = New System.Drawing.Point(527, 8)
		Me.btnPartSearch.Name = "btnPartSearch"
		Me.btnPartSearch.Size = New System.Drawing.Size(24, 24)
		Me.btnPartSearch.TabIndex = 1
		Me.btnPartSearch.UseVisualStyleBackColor = False
		'
		'tbxPartSearch
		'
		Me.tbxPartSearch.Location = New System.Drawing.Point(402, 9)
		Me.tbxPartSearch.Name = "tbxPartSearch"
		Me.tbxPartSearch.Size = New System.Drawing.Size(119, 23)
		Me.tbxPartSearch.TabIndex = 0
		'
		'btnAddPart
		'
		Me.btnAddPart.BackColor = System.Drawing.Color.LimeGreen
		Me.btnAddPart.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.btnAddPart.ForeColor = System.Drawing.Color.White
		Me.btnAddPart.Location = New System.Drawing.Point(557, 7)
		Me.btnAddPart.Name = "btnAddPart"
		Me.btnAddPart.Size = New System.Drawing.Size(149, 26)
		Me.btnAddPart.TabIndex = 2
		Me.btnAddPart.Text = "Add Part"
		Me.btnAddPart.UseVisualStyleBackColor = False
		'
		'lvwPartList
		'
		Me.lvwPartList.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
			Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.lvwPartList.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.col_P_ID, Me.col_P_PartNo, Me.col_P_Name, Me.col_P_Price})
		Me.lvwPartList.ContextMenuStrip = Me.cmsPartList
		Me.lvwPartList.FullRowSelect = True
		Me.lvwPartList.GridLines = True
		Me.lvwPartList.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
		Me.lvwPartList.HideSelection = False
		Me.lvwPartList.Location = New System.Drawing.Point(6, 37)
		Me.lvwPartList.Name = "lvwPartList"
		Me.lvwPartList.Size = New System.Drawing.Size(708, 180)
		Me.lvwPartList.TabIndex = 3
		Me.lvwPartList.UseCompatibleStateImageBehavior = False
		Me.lvwPartList.View = System.Windows.Forms.View.Details
		'
		'col_P_ID
		'
		Me.col_P_ID.Text = "ID"
		Me.col_P_ID.Width = 0
		'
		'col_P_PartNo
		'
		Me.col_P_PartNo.Text = "PartNo"
		Me.col_P_PartNo.Width = 200
		'
		'col_P_Name
		'
		Me.col_P_Name.Text = "Name"
		Me.col_P_Name.Width = 402
		'
		'col_P_Price
		'
		Me.col_P_Price.Text = "Price"
		Me.col_P_Price.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		Me.col_P_Price.Width = 80
		'
		'cmsPartList
		'
		Me.cmsPartList.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnu_PL_Edit, Me.mnu_PL_Delete})
		Me.cmsPartList.Name = "cmsPartList"
		Me.cmsPartList.Size = New System.Drawing.Size(108, 48)
		'
		'mnu_PL_Edit
		'
		Me.mnu_PL_Edit.Image = Global.PMSys.My.Resources.Resources.approval16
		Me.mnu_PL_Edit.Name = "mnu_PL_Edit"
		Me.mnu_PL_Edit.Size = New System.Drawing.Size(107, 22)
		Me.mnu_PL_Edit.Text = "Edit"
		'
		'mnu_PL_Delete
		'
		Me.mnu_PL_Delete.Enabled = False
		Me.mnu_PL_Delete.Image = Global.PMSys.My.Resources.Resources.close16
		Me.mnu_PL_Delete.Name = "mnu_PL_Delete"
		Me.mnu_PL_Delete.Size = New System.Drawing.Size(107, 22)
		Me.mnu_PL_Delete.Text = "Delete"
		'
		'Label2
		'
		Me.Label2.AutoSize = True
		Me.Label2.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label2.Location = New System.Drawing.Point(3, 10)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(103, 18)
		Me.Label2.TabIndex = 1
		Me.Label2.Text = "PART LIST"
		'
		'Label4
		'
		Me.Label4.AutoSize = True
		Me.Label4.Location = New System.Drawing.Point(344, 12)
		Me.Label4.Name = "Label4"
		Me.Label4.Size = New System.Drawing.Size(60, 16)
		Me.Label4.TabIndex = 6
		Me.Label4.Text = "Search:"
		'
		'pnlMaintenance
		'
		Me.pnlMaintenance.Controls.Add(Me.chkSearch_PartName)
		Me.pnlMaintenance.Controls.Add(Me.chkSearch_MachineName)
		Me.pnlMaintenance.Controls.Add(Me.chkSearch_Type)
		Me.pnlMaintenance.Controls.Add(Me.btnPMSearch)
		Me.pnlMaintenance.Controls.Add(Me.tbxPMSearch)
		Me.pnlMaintenance.Controls.Add(Me.btnAddMaintenance)
		Me.pnlMaintenance.Controls.Add(Me.lvwPMList)
		Me.pnlMaintenance.Controls.Add(Me.Label5)
		Me.pnlMaintenance.Controls.Add(Me.Label6)
		Me.pnlMaintenance.Location = New System.Drawing.Point(12, 307)
		Me.pnlMaintenance.Name = "pnlMaintenance"
		Me.pnlMaintenance.Size = New System.Drawing.Size(1444, 277)
		Me.pnlMaintenance.TabIndex = 2
		'
		'chkSearch_PartName
		'
		Me.chkSearch_PartName.AutoSize = True
		Me.chkSearch_PartName.Location = New System.Drawing.Point(945, 11)
		Me.chkSearch_PartName.Name = "chkSearch_PartName"
		Me.chkSearch_PartName.Size = New System.Drawing.Size(95, 20)
		Me.chkSearch_PartName.TabIndex = 1
		Me.chkSearch_PartName.Text = "Part Name"
		Me.chkSearch_PartName.UseVisualStyleBackColor = True
		'
		'chkSearch_MachineName
		'
		Me.chkSearch_MachineName.AutoSize = True
		Me.chkSearch_MachineName.Checked = True
		Me.chkSearch_MachineName.CheckState = System.Windows.Forms.CheckState.Checked
		Me.chkSearch_MachineName.Enabled = False
		Me.chkSearch_MachineName.Location = New System.Drawing.Point(817, 11)
		Me.chkSearch_MachineName.Name = "chkSearch_MachineName"
		Me.chkSearch_MachineName.Size = New System.Drawing.Size(122, 20)
		Me.chkSearch_MachineName.TabIndex = 9
		Me.chkSearch_MachineName.Text = "Machine Name"
		Me.chkSearch_MachineName.UseVisualStyleBackColor = True
		'
		'chkSearch_Type
		'
		Me.chkSearch_Type.AutoSize = True
		Me.chkSearch_Type.Location = New System.Drawing.Point(752, 11)
		Me.chkSearch_Type.Name = "chkSearch_Type"
		Me.chkSearch_Type.Size = New System.Drawing.Size(59, 20)
		Me.chkSearch_Type.TabIndex = 0
		Me.chkSearch_Type.Text = "Type"
		Me.chkSearch_Type.UseVisualStyleBackColor = True
		'
		'btnPMSearch
		'
		Me.btnPMSearch.BackColor = System.Drawing.Color.DeepSkyBlue
		Me.btnPMSearch.FlatAppearance.BorderSize = 0
		Me.btnPMSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.btnPMSearch.Image = CType(resources.GetObject("btnPMSearch.Image"), System.Drawing.Image)
		Me.btnPMSearch.Location = New System.Drawing.Point(1260, 8)
		Me.btnPMSearch.Name = "btnPMSearch"
		Me.btnPMSearch.Size = New System.Drawing.Size(24, 24)
		Me.btnPMSearch.TabIndex = 3
		Me.btnPMSearch.UseVisualStyleBackColor = False
		'
		'tbxPMSearch
		'
		Me.tbxPMSearch.Location = New System.Drawing.Point(1135, 9)
		Me.tbxPMSearch.Name = "tbxPMSearch"
		Me.tbxPMSearch.Size = New System.Drawing.Size(119, 23)
		Me.tbxPMSearch.TabIndex = 2
		'
		'btnAddMaintenance
		'
		Me.btnAddMaintenance.BackColor = System.Drawing.Color.LimeGreen
		Me.btnAddMaintenance.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.btnAddMaintenance.ForeColor = System.Drawing.Color.White
		Me.btnAddMaintenance.Location = New System.Drawing.Point(1290, 7)
		Me.btnAddMaintenance.Name = "btnAddMaintenance"
		Me.btnAddMaintenance.Size = New System.Drawing.Size(149, 26)
		Me.btnAddMaintenance.TabIndex = 4
		Me.btnAddMaintenance.Text = "Add PM Schedule"
		Me.btnAddMaintenance.UseVisualStyleBackColor = False
		'
		'lvwPMList
		'
		Me.lvwPMList.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
			Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.lvwPMList.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.col_PM_ID, Me.col_PM_Type, Me.col_PM_MachineName, Me.col_PM_PartName, Me.col_PM_PartPrice, Me.col_PM_PartQty, Me.col_PM_TotalPrice, Me.col_PM_Frequency, Me.col_PM_LastPM, Me.col_PM_NextPM, Me.col_PM_Action})
		Me.lvwPMList.ContextMenuStrip = Me.cmsPMList
		Me.lvwPMList.FullRowSelect = True
		Me.lvwPMList.GridLines = True
		Me.lvwPMList.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
		Me.lvwPMList.HideSelection = False
		Me.lvwPMList.Location = New System.Drawing.Point(6, 37)
		Me.lvwPMList.Name = "lvwPMList"
		Me.lvwPMList.Size = New System.Drawing.Size(1434, 237)
		Me.lvwPMList.TabIndex = 5
		Me.lvwPMList.UseCompatibleStateImageBehavior = False
		Me.lvwPMList.View = System.Windows.Forms.View.Details
		'
		'col_PM_ID
		'
		Me.col_PM_ID.Text = "ID"
		Me.col_PM_ID.Width = 0
		'
		'col_PM_Type
		'
		Me.col_PM_Type.Text = "Type"
		Me.col_PM_Type.Width = 90
		'
		'col_PM_MachineName
		'
		Me.col_PM_MachineName.Text = "Machine Name"
		Me.col_PM_MachineName.Width = 250
		'
		'col_PM_PartName
		'
		Me.col_PM_PartName.Text = "Part Name"
		Me.col_PM_PartName.Width = 300
		'
		'col_PM_PartQty
		'
		Me.col_PM_PartQty.Text = "QTY"
		Me.col_PM_PartQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		'
		'col_PM_Frequency
		'
		Me.col_PM_Frequency.Text = "Frequency"
		Me.col_PM_Frequency.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		Me.col_PM_Frequency.Width = 90
		'
		'col_PM_PartPrice
		'
		Me.col_PM_PartPrice.Text = "Price"
		Me.col_PM_PartPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		Me.col_PM_PartPrice.Width = 80
		'
		'col_PM_TotalPrice
		'
		Me.col_PM_TotalPrice.Text = "Total Price"
		Me.col_PM_TotalPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		Me.col_PM_TotalPrice.Width = 100
		'
		'col_PM_LastPM
		'
		Me.col_PM_LastPM.Text = "Last PM"
		Me.col_PM_LastPM.Width = 120
		'
		'col_PM_NextPM
		'
		Me.col_PM_NextPM.Text = "Next PM"
		Me.col_PM_NextPM.Width = 120
		'
		'col_PM_Action
		'
		Me.col_PM_Action.Text = "Action"
		Me.col_PM_Action.Width = 198
		'
		'cmsPMList
		'
		Me.cmsPMList.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnu_PML_Edit, Me.mnu_PML_Delete, Me.ToolStripMenuItem1, Me.mnu_PML_CompletePMSchedule})
		Me.cmsPMList.Name = "cmsPMList"
		Me.cmsPMList.Size = New System.Drawing.Size(199, 76)
		'
		'mnu_PML_Edit
		'
		Me.mnu_PML_Edit.Image = Global.PMSys.My.Resources.Resources.approval16
		Me.mnu_PML_Edit.Name = "mnu_PML_Edit"
		Me.mnu_PML_Edit.Size = New System.Drawing.Size(198, 22)
		Me.mnu_PML_Edit.Text = "Edit"
		'
		'mnu_PML_Delete
		'
		Me.mnu_PML_Delete.Enabled = False
		Me.mnu_PML_Delete.Image = Global.PMSys.My.Resources.Resources.close16
		Me.mnu_PML_Delete.Name = "mnu_PML_Delete"
		Me.mnu_PML_Delete.Size = New System.Drawing.Size(198, 22)
		Me.mnu_PML_Delete.Text = "Delete"
		'
		'ToolStripMenuItem1
		'
		Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
		Me.ToolStripMenuItem1.Size = New System.Drawing.Size(195, 6)
		'
		'mnu_PML_CompletePMSchedule
		'
		Me.mnu_PML_CompletePMSchedule.Image = Global.PMSys.My.Resources.Resources.check_mark16
		Me.mnu_PML_CompletePMSchedule.Name = "mnu_PML_CompletePMSchedule"
		Me.mnu_PML_CompletePMSchedule.Size = New System.Drawing.Size(198, 22)
		Me.mnu_PML_CompletePMSchedule.Text = "Complete PM Schedule"
		'
		'Label5
		'
		Me.Label5.AutoSize = True
		Me.Label5.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label5.Location = New System.Drawing.Point(3, 10)
		Me.Label5.Name = "Label5"
		Me.Label5.Size = New System.Drawing.Size(81, 18)
		Me.Label5.TabIndex = 1
		Me.Label5.Text = "PM LIST"
		'
		'Label6
		'
		Me.Label6.AutoSize = True
		Me.Label6.Location = New System.Drawing.Point(1077, 12)
		Me.Label6.Name = "Label6"
		Me.Label6.Size = New System.Drawing.Size(60, 16)
		Me.Label6.TabIndex = 6
		Me.Label6.Text = "Search:"
		'
		'pnlFooter
		'
		Me.pnlFooter.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.pnlFooter.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
		Me.pnlFooter.Location = New System.Drawing.Point(0, 891)
		Me.pnlFooter.Name = "pnlFooter"
		Me.pnlFooter.Size = New System.Drawing.Size(1465, 50)
		Me.pnlFooter.TabIndex = 13
		'
		'btnExit
		'
		Me.btnExit.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
		Me.btnExit.FlatAppearance.BorderSize = 0
		Me.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.btnExit.Image = CType(resources.GetObject("btnExit.Image"), System.Drawing.Image)
		Me.btnExit.Location = New System.Drawing.Point(1430, 2)
		Me.btnExit.Name = "btnExit"
		Me.btnExit.Size = New System.Drawing.Size(32, 32)
		Me.btnExit.TabIndex = 14
		Me.btnExit.UseVisualStyleBackColor = False
		'
		'pnlPMHistory
		'
		Me.pnlPMHistory.Controls.Add(Me.lvwPMHistoryList)
		Me.pnlPMHistory.Controls.Add(Me.Label7)
		Me.pnlPMHistory.Location = New System.Drawing.Point(12, 590)
		Me.pnlPMHistory.Name = "pnlPMHistory"
		Me.pnlPMHistory.Size = New System.Drawing.Size(1444, 277)
		Me.pnlPMHistory.TabIndex = 3
		'
		'lvwPMHistoryList
		'
		Me.lvwPMHistoryList.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
			Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.lvwPMHistoryList.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.col_PMH_ID, Me.col_PMH_PMID, Me.col_PMH_PMDate, Me.col_PMH_MachineName, Me.col_PMH_PartName, Me.col_PMH_Operator, Me.col_PMH_Reporter, Me.col_PMH_Details, Me.col_PMH_Result})
		Me.lvwPMHistoryList.ContextMenuStrip = Me.cmsPMHistoryList
		Me.lvwPMHistoryList.FullRowSelect = True
		Me.lvwPMHistoryList.GridLines = True
		Me.lvwPMHistoryList.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
		Me.lvwPMHistoryList.HideSelection = False
		Me.lvwPMHistoryList.Location = New System.Drawing.Point(6, 37)
		Me.lvwPMHistoryList.Name = "lvwPMHistoryList"
		Me.lvwPMHistoryList.Size = New System.Drawing.Size(1434, 237)
		Me.lvwPMHistoryList.TabIndex = 0
		Me.lvwPMHistoryList.UseCompatibleStateImageBehavior = False
		Me.lvwPMHistoryList.View = System.Windows.Forms.View.Details
		'
		'col_PMH_ID
		'
		Me.col_PMH_ID.Text = "ID"
		Me.col_PMH_ID.Width = 0
		'
		'col_PMH_PMID
		'
		Me.col_PMH_PMID.Text = "PMID"
		Me.col_PMH_PMID.Width = 0
		'
		'col_PMH_PMDate
		'
		Me.col_PMH_PMDate.Text = "Date"
		Me.col_PMH_PMDate.Width = 120
		'
		'col_PMH_MachineName
		'
		Me.col_PMH_MachineName.Text = "Machine Name"
		Me.col_PMH_MachineName.Width = 300
		'
		'col_PMH_PartName
		'
		Me.col_PMH_PartName.Text = "Part Name"
		Me.col_PMH_PartName.Width = 300
		'
		'col_PMH_Operator
		'
		Me.col_PMH_Operator.Text = "Operator"
		Me.col_PMH_Operator.Width = 100
		'
		'col_PMH_Reporter
		'
		Me.col_PMH_Reporter.Text = "Reporter"
		Me.col_PMH_Reporter.Width = 100
		'
		'col_PMH_Details
		'
		Me.col_PMH_Details.Text = "Details"
		Me.col_PMH_Details.Width = 290
		'
		'col_PMH_Result
		'
		Me.col_PMH_Result.Text = "Result"
		Me.col_PMH_Result.Width = 200
		'
		'cmsPMHistoryList
		'
		Me.cmsPMHistoryList.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnu_PMH_Edit})
		Me.cmsPMHistoryList.Name = "cmsPMHistoryList"
		Me.cmsPMHistoryList.Size = New System.Drawing.Size(95, 26)
		'
		'mnu_PMH_Edit
		'
		Me.mnu_PMH_Edit.Image = Global.PMSys.My.Resources.Resources.approval16
		Me.mnu_PMH_Edit.Name = "mnu_PMH_Edit"
		Me.mnu_PMH_Edit.Size = New System.Drawing.Size(94, 22)
		Me.mnu_PMH_Edit.Text = "Edit"
		'
		'Label7
		'
		Me.Label7.AutoSize = True
		Me.Label7.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label7.Location = New System.Drawing.Point(3, 10)
		Me.Label7.Name = "Label7"
		Me.Label7.Size = New System.Drawing.Size(123, 18)
		Me.Label7.TabIndex = 1
		Me.Label7.Text = "PM HISTORY"
		'
		'pnlHeader
		'
		Me.pnlHeader.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.pnlHeader.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
		Me.pnlHeader.Controls.Add(Me.picIcon)
		Me.pnlHeader.Controls.Add(Me.lblTitle)
		Me.pnlHeader.Controls.Add(Me.btnExit)
		Me.pnlHeader.Location = New System.Drawing.Point(0, 0)
		Me.pnlHeader.Name = "pnlHeader"
		Me.pnlHeader.Size = New System.Drawing.Size(1465, 60)
		Me.pnlHeader.TabIndex = 14
		'
		'picIcon
		'
		Me.picIcon.Image = CType(resources.GetObject("picIcon.Image"), System.Drawing.Image)
		Me.picIcon.Location = New System.Drawing.Point(3, 2)
		Me.picIcon.Name = "picIcon"
		Me.picIcon.Size = New System.Drawing.Size(50, 50)
		Me.picIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
		Me.picIcon.TabIndex = 18
		Me.picIcon.TabStop = False
		'
		'lblTitle
		'
		Me.lblTitle.AutoSize = True
		Me.lblTitle.Font = New System.Drawing.Font("Century Gothic", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblTitle.ForeColor = System.Drawing.Color.White
		Me.lblTitle.Location = New System.Drawing.Point(61, 9)
		Me.lblTitle.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
		Me.lblTitle.Name = "lblTitle"
		Me.lblTitle.Size = New System.Drawing.Size(375, 36)
		Me.lblTitle.TabIndex = 17
		Me.lblTitle.Text = "PM Management System"
		'
		'frmMain
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.Color.WhiteSmoke
		Me.ClientSize = New System.Drawing.Size(1465, 941)
		Me.Controls.Add(Me.pnlHeader)
		Me.Controls.Add(Me.pnlPMHistory)
		Me.Controls.Add(Me.pnlFooter)
		Me.Controls.Add(Me.pnlMaintenance)
		Me.Controls.Add(Me.pnlPart)
		Me.Controls.Add(Me.pnlMachine)
		Me.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
		Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
		Me.Margin = New System.Windows.Forms.Padding(4)
		Me.MaximizeBox = False
		Me.MinimizeBox = False
		Me.Name = "frmMain"
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = "PM.Sys"
		Me.pnlMachine.ResumeLayout(False)
		Me.pnlMachine.PerformLayout()
		Me.cmsMachineList.ResumeLayout(False)
		Me.pnlPart.ResumeLayout(False)
		Me.pnlPart.PerformLayout()
		Me.cmsPartList.ResumeLayout(False)
		Me.pnlMaintenance.ResumeLayout(False)
		Me.pnlMaintenance.PerformLayout()
		Me.cmsPMList.ResumeLayout(False)
		Me.pnlPMHistory.ResumeLayout(False)
		Me.pnlPMHistory.PerformLayout()
		Me.cmsPMHistoryList.ResumeLayout(False)
		Me.pnlHeader.ResumeLayout(False)
		Me.pnlHeader.PerformLayout()
		CType(Me.picIcon, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)

	End Sub

	Friend WithEvents pnlMachine As Panel
	Friend WithEvents lvwMachine As ListView
	Friend WithEvents col_M_ID As ColumnHeader
	Friend WithEvents col_M_Name As ColumnHeader
	Friend WithEvents col_M_Detail As ColumnHeader
	Friend WithEvents Label1 As Label
	Friend WithEvents btnAddMachine As Button
	Friend WithEvents pnlPart As Panel
	Friend WithEvents btnAddPart As Button
	Friend WithEvents lvwPartList As ListView
	Friend WithEvents col_P_ID As ColumnHeader
	Friend WithEvents col_P_PartNo As ColumnHeader
	Friend WithEvents col_P_Name As ColumnHeader
	Friend WithEvents col_P_Price As ColumnHeader
	Friend WithEvents Label2 As Label
	Friend WithEvents tbxMachineSearch As TextBox
	Friend WithEvents Label3 As Label
	Friend WithEvents tbxPartSearch As TextBox
	Friend WithEvents Label4 As Label
	Friend WithEvents btnMachineSearch As Button
	Friend WithEvents btnPartSearch As Button
	Friend WithEvents pnlMaintenance As Panel
	Friend WithEvents btnPMSearch As Button
	Friend WithEvents tbxPMSearch As TextBox
	Friend WithEvents btnAddMaintenance As Button
	Friend WithEvents lvwPMList As ListView
	Friend WithEvents col_PM_ID As ColumnHeader
	Friend WithEvents col_PM_Type As ColumnHeader
	Friend WithEvents col_PM_MachineName As ColumnHeader
	Friend WithEvents col_PM_PartName As ColumnHeader
	Friend WithEvents Label5 As Label
	Friend WithEvents Label6 As Label
	Friend WithEvents col_PM_PartQty As ColumnHeader
	Friend WithEvents col_PM_Frequency As ColumnHeader
	Friend WithEvents col_PM_PartPrice As ColumnHeader
	Friend WithEvents col_PM_TotalPrice As ColumnHeader
	Friend WithEvents col_PM_LastPM As ColumnHeader
	Friend WithEvents col_PM_NextPM As ColumnHeader
	Friend WithEvents col_PM_Action As ColumnHeader
	Friend WithEvents pnlFooter As Panel
	Friend WithEvents btnExit As Button
	Friend WithEvents col_MC_Code As ColumnHeader
	Friend WithEvents cmsPartList As ContextMenuStrip
	Friend WithEvents mnu_PL_Edit As ToolStripMenuItem
	Friend WithEvents mnu_PL_Delete As ToolStripMenuItem
	Friend WithEvents cmsMachineList As ContextMenuStrip
	Friend WithEvents mnu_ML_Edit As ToolStripMenuItem
	Friend WithEvents mnu_ML_Delete As ToolStripMenuItem
	Friend WithEvents cmsPMList As ContextMenuStrip
	Friend WithEvents mnu_PML_Edit As ToolStripMenuItem
	Friend WithEvents mnu_PML_Delete As ToolStripMenuItem
	Friend WithEvents ToolStripMenuItem1 As ToolStripSeparator
	Friend WithEvents mnu_PML_CompletePMSchedule As ToolStripMenuItem
	Friend WithEvents chkSearch_PartName As CheckBox
	Friend WithEvents chkSearch_MachineName As CheckBox
	Friend WithEvents chkSearch_Type As CheckBox
	Friend WithEvents pnlPMHistory As Panel
	Friend WithEvents lvwPMHistoryList As ListView
	Friend WithEvents col_PMH_ID As ColumnHeader
	Friend WithEvents col_PMH_PMDate As ColumnHeader
	Friend WithEvents col_PMH_MachineName As ColumnHeader
	Friend WithEvents col_PMH_PartName As ColumnHeader
	Friend WithEvents col_PMH_Operator As ColumnHeader
	Friend WithEvents col_PMH_Reporter As ColumnHeader
	Friend WithEvents col_PMH_Details As ColumnHeader
	Friend WithEvents col_PMH_Result As ColumnHeader
	Friend WithEvents Label7 As Label
	Friend WithEvents col_PMH_PMID As ColumnHeader
	Friend WithEvents pnlHeader As Panel
	Friend WithEvents picIcon As PictureBox
	Friend WithEvents lblTitle As Label
	Friend WithEvents cmsPMHistoryList As ContextMenuStrip
	Friend WithEvents mnu_PMH_Edit As ToolStripMenuItem
End Class
