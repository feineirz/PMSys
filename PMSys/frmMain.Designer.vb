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
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
		Me.pnlMachine = New System.Windows.Forms.Panel()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.lvwMachine = New System.Windows.Forms.ListView()
		Me.col_M_ID = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
		Me.col_M_Name = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
		Me.col_M_Detail = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
		Me.btnAddMachine = New System.Windows.Forms.Button()
		Me.pnlPart = New System.Windows.Forms.Panel()
		Me.btnAddPart = New System.Windows.Forms.Button()
		Me.lvwPartList = New System.Windows.Forms.ListView()
		Me.col_P_ID = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
		Me.col_P_PartNo = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
		Me.col_P_Name = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
		Me.Label2 = New System.Windows.Forms.Label()
		Me.col_P_Price = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
		Me.tbxMachineSearch = New System.Windows.Forms.TextBox()
		Me.Label3 = New System.Windows.Forms.Label()
		Me.Label4 = New System.Windows.Forms.Label()
		Me.tbxPartSearch = New System.Windows.Forms.TextBox()
		Me.btnMachineSearch = New System.Windows.Forms.Button()
		Me.btnPartSearch = New System.Windows.Forms.Button()
		Me.pnlMaintenance = New System.Windows.Forms.Panel()
		Me.btnMaintenanceSearch = New System.Windows.Forms.Button()
		Me.tbxMaintenanceSearch = New System.Windows.Forms.TextBox()
		Me.btnAddMaintenance = New System.Windows.Forms.Button()
		Me.lvwMaintenanceList = New System.Windows.Forms.ListView()
		Me.col_PM_ID = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
		Me.col_PM_Type = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
		Me.col_PM_MachineName = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
		Me.col_PM_PartName = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
		Me.Label5 = New System.Windows.Forms.Label()
		Me.Label6 = New System.Windows.Forms.Label()
		Me.col_PM_PartQty = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
		Me.col_PM_Frequency = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
		Me.col_PM_PartPrice = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
		Me.col_PM_TotalPrice = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
		Me.col_PM_LastPM = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
		Me.col_PM_NextPM = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
		Me.col_PM_Action = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
		Me.pnlDashboard = New System.Windows.Forms.Panel()
		Me.pnlMachine.SuspendLayout()
		Me.pnlPart.SuspendLayout()
		Me.pnlMaintenance.SuspendLayout()
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
		Me.pnlMachine.Location = New System.Drawing.Point(12, 12)
		Me.pnlMachine.Name = "pnlMachine"
		Me.pnlMachine.Size = New System.Drawing.Size(710, 220)
		Me.pnlMachine.TabIndex = 0
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
		'lvwMachine
		'
		Me.lvwMachine.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
			Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.lvwMachine.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.col_M_ID, Me.col_M_Name, Me.col_M_Detail})
		Me.lvwMachine.FullRowSelect = True
		Me.lvwMachine.GridLines = True
		Me.lvwMachine.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
		Me.lvwMachine.HideSelection = False
		Me.lvwMachine.Location = New System.Drawing.Point(6, 37)
		Me.lvwMachine.Name = "lvwMachine"
		Me.lvwMachine.Size = New System.Drawing.Size(700, 180)
		Me.lvwMachine.TabIndex = 1
		Me.lvwMachine.UseCompatibleStateImageBehavior = False
		Me.lvwMachine.View = System.Windows.Forms.View.Details
		'
		'col_M_ID
		'
		Me.col_M_ID.Text = "ID"
		'
		'col_M_Name
		'
		Me.col_M_Name.Text = "Name"
		Me.col_M_Name.Width = 200
		'
		'col_M_Detail
		'
		Me.col_M_Detail.Text = "Detail"
		Me.col_M_Detail.Width = 420
		'
		'btnAddMachine
		'
		Me.btnAddMachine.Location = New System.Drawing.Point(557, 8)
		Me.btnAddMachine.Name = "btnAddMachine"
		Me.btnAddMachine.Size = New System.Drawing.Size(149, 25)
		Me.btnAddMachine.TabIndex = 1
		Me.btnAddMachine.Text = "Add Machine"
		Me.btnAddMachine.UseVisualStyleBackColor = True
		'
		'pnlPart
		'
		Me.pnlPart.Controls.Add(Me.btnPartSearch)
		Me.pnlPart.Controls.Add(Me.tbxPartSearch)
		Me.pnlPart.Controls.Add(Me.btnAddPart)
		Me.pnlPart.Controls.Add(Me.lvwPartList)
		Me.pnlPart.Controls.Add(Me.Label2)
		Me.pnlPart.Controls.Add(Me.Label4)
		Me.pnlPart.Location = New System.Drawing.Point(12, 238)
		Me.pnlPart.Name = "pnlPart"
		Me.pnlPart.Size = New System.Drawing.Size(710, 220)
		Me.pnlPart.TabIndex = 2
		'
		'btnAddPart
		'
		Me.btnAddPart.Location = New System.Drawing.Point(557, 8)
		Me.btnAddPart.Name = "btnAddPart"
		Me.btnAddPart.Size = New System.Drawing.Size(149, 25)
		Me.btnAddPart.TabIndex = 1
		Me.btnAddPart.Text = "Add Part"
		Me.btnAddPart.UseVisualStyleBackColor = True
		'
		'lvwPartList
		'
		Me.lvwPartList.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
			Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.lvwPartList.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.col_P_ID, Me.col_P_PartNo, Me.col_P_Name, Me.col_P_Price})
		Me.lvwPartList.FullRowSelect = True
		Me.lvwPartList.GridLines = True
		Me.lvwPartList.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
		Me.lvwPartList.HideSelection = False
		Me.lvwPartList.Location = New System.Drawing.Point(6, 37)
		Me.lvwPartList.Name = "lvwPartList"
		Me.lvwPartList.Size = New System.Drawing.Size(700, 180)
		Me.lvwPartList.TabIndex = 1
		Me.lvwPartList.UseCompatibleStateImageBehavior = False
		Me.lvwPartList.View = System.Windows.Forms.View.Details
		'
		'col_P_ID
		'
		Me.col_P_ID.Text = "ID"
		'
		'col_P_PartNo
		'
		Me.col_P_PartNo.Text = "PartNo"
		Me.col_P_PartNo.Width = 200
		'
		'col_P_Name
		'
		Me.col_P_Name.Text = "Name"
		Me.col_P_Name.Width = 340
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
		'col_P_Price
		'
		Me.col_P_Price.Text = "Price"
		Me.col_P_Price.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		Me.col_P_Price.Width = 80
		'
		'tbxMachineSearch
		'
		Me.tbxMachineSearch.Location = New System.Drawing.Point(279, 9)
		Me.tbxMachineSearch.Name = "tbxMachineSearch"
		Me.tbxMachineSearch.Size = New System.Drawing.Size(119, 23)
		Me.tbxMachineSearch.TabIndex = 3
		'
		'Label3
		'
		Me.Label3.AutoSize = True
		Me.Label3.Location = New System.Drawing.Point(221, 12)
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(60, 16)
		Me.Label3.TabIndex = 4
		Me.Label3.Text = "Search:"
		'
		'Label4
		'
		Me.Label4.AutoSize = True
		Me.Label4.Location = New System.Drawing.Point(221, 12)
		Me.Label4.Name = "Label4"
		Me.Label4.Size = New System.Drawing.Size(60, 16)
		Me.Label4.TabIndex = 6
		Me.Label4.Text = "Search:"
		'
		'tbxPartSearch
		'
		Me.tbxPartSearch.Location = New System.Drawing.Point(279, 9)
		Me.tbxPartSearch.Name = "tbxPartSearch"
		Me.tbxPartSearch.Size = New System.Drawing.Size(119, 23)
		Me.tbxPartSearch.TabIndex = 5
		'
		'btnMachineSearch
		'
		Me.btnMachineSearch.Image = CType(resources.GetObject("btnMachineSearch.Image"), System.Drawing.Image)
		Me.btnMachineSearch.Location = New System.Drawing.Point(404, 8)
		Me.btnMachineSearch.Name = "btnMachineSearch"
		Me.btnMachineSearch.Size = New System.Drawing.Size(24, 24)
		Me.btnMachineSearch.TabIndex = 3
		Me.btnMachineSearch.UseVisualStyleBackColor = True
		'
		'btnPartSearch
		'
		Me.btnPartSearch.Image = CType(resources.GetObject("btnPartSearch.Image"), System.Drawing.Image)
		Me.btnPartSearch.Location = New System.Drawing.Point(404, 8)
		Me.btnPartSearch.Name = "btnPartSearch"
		Me.btnPartSearch.Size = New System.Drawing.Size(24, 24)
		Me.btnPartSearch.TabIndex = 7
		Me.btnPartSearch.UseVisualStyleBackColor = True
		'
		'pnlMaintenance
		'
		Me.pnlMaintenance.Controls.Add(Me.btnMaintenanceSearch)
		Me.pnlMaintenance.Controls.Add(Me.tbxMaintenanceSearch)
		Me.pnlMaintenance.Controls.Add(Me.btnAddMaintenance)
		Me.pnlMaintenance.Controls.Add(Me.lvwMaintenanceList)
		Me.pnlMaintenance.Controls.Add(Me.Label5)
		Me.pnlMaintenance.Controls.Add(Me.Label6)
		Me.pnlMaintenance.Location = New System.Drawing.Point(12, 464)
		Me.pnlMaintenance.Name = "pnlMaintenance"
		Me.pnlMaintenance.Size = New System.Drawing.Size(1443, 254)
		Me.pnlMaintenance.TabIndex = 8
		'
		'btnMaintenanceSearch
		'
		Me.btnMaintenanceSearch.Image = CType(resources.GetObject("btnMaintenanceSearch.Image"), System.Drawing.Image)
		Me.btnMaintenanceSearch.Location = New System.Drawing.Point(404, 8)
		Me.btnMaintenanceSearch.Name = "btnMaintenanceSearch"
		Me.btnMaintenanceSearch.Size = New System.Drawing.Size(24, 24)
		Me.btnMaintenanceSearch.TabIndex = 7
		Me.btnMaintenanceSearch.UseVisualStyleBackColor = True
		'
		'tbxMaintenanceSearch
		'
		Me.tbxMaintenanceSearch.Location = New System.Drawing.Point(279, 9)
		Me.tbxMaintenanceSearch.Name = "tbxMaintenanceSearch"
		Me.tbxMaintenanceSearch.Size = New System.Drawing.Size(119, 23)
		Me.tbxMaintenanceSearch.TabIndex = 5
		'
		'btnAddMaintenance
		'
		Me.btnAddMaintenance.Location = New System.Drawing.Point(1290, 8)
		Me.btnAddMaintenance.Name = "btnAddMaintenance"
		Me.btnAddMaintenance.Size = New System.Drawing.Size(149, 25)
		Me.btnAddMaintenance.TabIndex = 1
		Me.btnAddMaintenance.Text = "Add Maintenance"
		Me.btnAddMaintenance.UseVisualStyleBackColor = True
		'
		'lvwMaintenanceList
		'
		Me.lvwMaintenanceList.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
			Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.lvwMaintenanceList.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.col_PM_ID, Me.col_PM_Type, Me.col_PM_MachineName, Me.col_PM_PartName, Me.col_PM_PartQty, Me.col_PM_Frequency, Me.col_PM_PartPrice, Me.col_PM_TotalPrice, Me.col_PM_LastPM, Me.col_PM_NextPM, Me.col_PM_Action})
		Me.lvwMaintenanceList.FullRowSelect = True
		Me.lvwMaintenanceList.GridLines = True
		Me.lvwMaintenanceList.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
		Me.lvwMaintenanceList.HideSelection = False
		Me.lvwMaintenanceList.Location = New System.Drawing.Point(6, 37)
		Me.lvwMaintenanceList.Name = "lvwMaintenanceList"
		Me.lvwMaintenanceList.Size = New System.Drawing.Size(1433, 214)
		Me.lvwMaintenanceList.TabIndex = 1
		Me.lvwMaintenanceList.UseCompatibleStateImageBehavior = False
		Me.lvwMaintenanceList.View = System.Windows.Forms.View.Details
		'
		'col_PM_ID
		'
		Me.col_PM_ID.Text = "ID"
		'
		'col_PM_Type
		'
		Me.col_PM_Type.Text = "Type"
		'
		'col_PM_MachineName
		'
		Me.col_PM_MachineName.Text = "Machine Name"
		Me.col_PM_MachineName.Width = 200
		'
		'col_PM_PartName
		'
		Me.col_PM_PartName.Text = "Part Name"
		Me.col_PM_PartName.Width = 200
		'
		'Label5
		'
		Me.Label5.AutoSize = True
		Me.Label5.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label5.Location = New System.Drawing.Point(3, 10)
		Me.Label5.Name = "Label5"
		Me.Label5.Size = New System.Drawing.Size(186, 18)
		Me.Label5.TabIndex = 1
		Me.Label5.Text = "MAINTENANCE LIST"
		'
		'Label6
		'
		Me.Label6.AutoSize = True
		Me.Label6.Location = New System.Drawing.Point(221, 12)
		Me.Label6.Name = "Label6"
		Me.Label6.Size = New System.Drawing.Size(60, 16)
		Me.Label6.TabIndex = 6
		Me.Label6.Text = "Search:"
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
		Me.col_PM_Frequency.Width = 100
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
		Me.col_PM_Action.Width = 310
		'
		'pnlDashboard
		'
		Me.pnlDashboard.Location = New System.Drawing.Point(728, 12)
		Me.pnlDashboard.Name = "pnlDashboard"
		Me.pnlDashboard.Size = New System.Drawing.Size(727, 446)
		Me.pnlDashboard.TabIndex = 9
		'
		'frmMain
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.Color.White
		Me.ClientSize = New System.Drawing.Size(1465, 730)
		Me.Controls.Add(Me.pnlDashboard)
		Me.Controls.Add(Me.pnlMaintenance)
		Me.Controls.Add(Me.pnlPart)
		Me.Controls.Add(Me.pnlMachine)
		Me.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
		Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
		Me.MaximizeBox = False
		Me.MinimizeBox = False
		Me.Name = "frmMain"
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = "PM.Sys"
		Me.pnlMachine.ResumeLayout(False)
		Me.pnlMachine.PerformLayout()
		Me.pnlPart.ResumeLayout(False)
		Me.pnlPart.PerformLayout()
		Me.pnlMaintenance.ResumeLayout(False)
		Me.pnlMaintenance.PerformLayout()
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
	Friend WithEvents btnMaintenanceSearch As Button
	Friend WithEvents tbxMaintenanceSearch As TextBox
	Friend WithEvents btnAddMaintenance As Button
	Friend WithEvents lvwMaintenanceList As ListView
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
	Friend WithEvents pnlDashboard As Panel
End Class
