<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMachineInfo
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
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMachineInfo))
		Me.pnlFooter = New System.Windows.Forms.Panel()
		Me.btnClose = New System.Windows.Forms.Button()
		Me.pnlHeader = New System.Windows.Forms.Panel()
		Me.picIcon = New System.Windows.Forms.PictureBox()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.lblMachineName = New System.Windows.Forms.Label()
		Me.lvwPartList = New System.Windows.Forms.ListView()
		Me.col_PM_ID = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
		Me.col_PM_PartNo = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
		Me.col_PM_PartName = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
		Me.col_PM_PartPrice = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
		Me.col_PM_RequireQTY = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
		Me.col_PM_TotalPrice = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
		Me.col_PM_Frequency = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
		Me.col_PM_NextPM = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
		Me.col_PM_Remark = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
		Me.Label3 = New System.Windows.Forms.Label()
		Me.Label4 = New System.Windows.Forms.Label()
		Me.lblTotalPMCost = New System.Windows.Forms.Label()
		Me.col_PM_CostPerYear = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
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
		Me.Label7 = New System.Windows.Forms.Label()
		Me.pnlPMPartList = New System.Windows.Forms.Panel()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.Label5 = New System.Windows.Forms.Label()
		Me.pnlFooter.SuspendLayout()
		Me.pnlHeader.SuspendLayout()
		CType(Me.picIcon, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.pnlPMHistory.SuspendLayout()
		Me.pnlPMPartList.SuspendLayout()
		Me.SuspendLayout()
		'
		'pnlFooter
		'
		Me.pnlFooter.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.pnlFooter.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
		Me.pnlFooter.Controls.Add(Me.btnClose)
		Me.pnlFooter.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.pnlFooter.Location = New System.Drawing.Point(0, 682)
		Me.pnlFooter.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
		Me.pnlFooter.Name = "pnlFooter"
		Me.pnlFooter.Size = New System.Drawing.Size(1330, 50)
		Me.pnlFooter.TabIndex = 12
		'
		'btnClose
		'
		Me.btnClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.btnClose.Image = Global.PMSys.My.Resources.Resources.close16
		Me.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.btnClose.Location = New System.Drawing.Point(1214, 8)
		Me.btnClose.Margin = New System.Windows.Forms.Padding(2)
		Me.btnClose.Name = "btnClose"
		Me.btnClose.Size = New System.Drawing.Size(108, 32)
		Me.btnClose.TabIndex = 6
		Me.btnClose.Text = "Close"
		Me.btnClose.UseVisualStyleBackColor = True
		'
		'pnlHeader
		'
		Me.pnlHeader.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.pnlHeader.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
		Me.pnlHeader.Controls.Add(Me.picIcon)
		Me.pnlHeader.Controls.Add(Me.Label1)
		Me.pnlHeader.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.pnlHeader.Location = New System.Drawing.Point(0, 0)
		Me.pnlHeader.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
		Me.pnlHeader.Name = "pnlHeader"
		Me.pnlHeader.Size = New System.Drawing.Size(1330, 60)
		Me.pnlHeader.TabIndex = 13
		'
		'picIcon
		'
		Me.picIcon.Image = CType(resources.GetObject("picIcon.Image"), System.Drawing.Image)
		Me.picIcon.Location = New System.Drawing.Point(3, 3)
		Me.picIcon.Name = "picIcon"
		Me.picIcon.Size = New System.Drawing.Size(50, 50)
		Me.picIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
		Me.picIcon.TabIndex = 17
		Me.picIcon.TabStop = False
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Font = New System.Drawing.Font("Century Gothic", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label1.ForeColor = System.Drawing.Color.White
		Me.Label1.Location = New System.Drawing.Point(61, 9)
		Me.Label1.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(186, 33)
		Me.Label1.TabIndex = 0
		Me.Label1.Text = "Machine Info"
		'
		'lblMachineName
		'
		Me.lblMachineName.AutoSize = True
		Me.lblMachineName.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblMachineName.Location = New System.Drawing.Point(31, 78)
		Me.lblMachineName.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
		Me.lblMachineName.Name = "lblMachineName"
		Me.lblMachineName.Size = New System.Drawing.Size(0, 25)
		Me.lblMachineName.TabIndex = 14
		'
		'lvwPartList
		'
		Me.lvwPartList.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
			Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.lvwPartList.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.col_PM_ID, Me.col_PM_PartNo, Me.col_PM_PartName, Me.col_PM_PartPrice, Me.col_PM_RequireQTY, Me.col_PM_TotalPrice, Me.col_PM_Frequency, Me.col_PM_CostPerYear, Me.col_PM_NextPM, Me.col_PM_Remark})
		Me.lvwPartList.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lvwPartList.FullRowSelect = True
		Me.lvwPartList.GridLines = True
		Me.lvwPartList.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
		Me.lvwPartList.HideSelection = False
		Me.lvwPartList.Location = New System.Drawing.Point(6, 26)
		Me.lvwPartList.Name = "lvwPartList"
		Me.lvwPartList.Size = New System.Drawing.Size(1254, 189)
		Me.lvwPartList.TabIndex = 15
		Me.lvwPartList.UseCompatibleStateImageBehavior = False
		Me.lvwPartList.View = System.Windows.Forms.View.Details
		'
		'col_PM_ID
		'
		Me.col_PM_ID.Text = "ID"
		Me.col_PM_ID.Width = 0
		'
		'col_PM_PartNo
		'
		Me.col_PM_PartNo.Text = "PartNo"
		Me.col_PM_PartNo.Width = 150
		'
		'col_PM_PartName
		'
		Me.col_PM_PartName.Text = "Name"
		Me.col_PM_PartName.Width = 310
		'
		'col_PM_PartPrice
		'
		Me.col_PM_PartPrice.Text = "Price"
		Me.col_PM_PartPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		Me.col_PM_PartPrice.Width = 80
		'
		'col_PM_RequireQTY
		'
		Me.col_PM_RequireQTY.Text = "QTY"
		Me.col_PM_RequireQTY.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		Me.col_PM_RequireQTY.Width = 70
		'
		'col_PM_TotalPrice
		'
		Me.col_PM_TotalPrice.Text = "Total Price"
		Me.col_PM_TotalPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		Me.col_PM_TotalPrice.Width = 100
		'
		'col_PM_Frequency
		'
		Me.col_PM_Frequency.Text = "Frequency"
		Me.col_PM_Frequency.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		Me.col_PM_Frequency.Width = 90
		'
		'col_PM_NextPM
		'
		Me.col_PM_NextPM.Text = "Next PM"
		Me.col_PM_NextPM.Width = 120
		'
		'col_PM_Remark
		'
		Me.col_PM_Remark.Text = "Remark"
		Me.col_PM_Remark.Width = 210
		'
		'Label3
		'
		Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.Label3.AutoSize = True
		Me.Label3.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label3.Location = New System.Drawing.Point(818, 644)
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(208, 18)
		Me.Label3.TabIndex = 17
		Me.Label3.Text = "TOTAL PM COST / YEAR:"
		'
		'Label4
		'
		Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.Label4.AutoSize = True
		Me.Label4.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label4.Location = New System.Drawing.Point(1258, 644)
		Me.Label4.Name = "Label4"
		Me.Label4.Size = New System.Drawing.Size(41, 18)
		Me.Label4.TabIndex = 18
		Me.Label4.Text = "THB"
		'
		'lblTotalPMCost
		'
		Me.lblTotalPMCost.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.lblTotalPMCost.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblTotalPMCost.Location = New System.Drawing.Point(1051, 640)
		Me.lblTotalPMCost.Name = "lblTotalPMCost"
		Me.lblTotalPMCost.Size = New System.Drawing.Size(201, 25)
		Me.lblTotalPMCost.TabIndex = 19
		Me.lblTotalPMCost.Text = "0.00"
		Me.lblTotalPMCost.TextAlign = System.Drawing.ContentAlignment.TopRight
		'
		'col_PM_CostPerYear
		'
		Me.col_PM_CostPerYear.Text = "Cost/Year"
		Me.col_PM_CostPerYear.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		Me.col_PM_CostPerYear.Width = 100
		'
		'pnlPMHistory
		'
		Me.pnlPMHistory.Controls.Add(Me.lvwPMHistoryList)
		Me.pnlPMHistory.Controls.Add(Me.Label7)
		Me.pnlPMHistory.Location = New System.Drawing.Point(35, 343)
		Me.pnlPMHistory.Name = "pnlPMHistory"
		Me.pnlPMHistory.Size = New System.Drawing.Size(1264, 293)
		Me.pnlPMHistory.TabIndex = 20
		'
		'lvwPMHistoryList
		'
		Me.lvwPMHistoryList.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
			Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.lvwPMHistoryList.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.col_PMH_ID, Me.col_PMH_PMID, Me.col_PMH_PMDate, Me.col_PMH_MachineName, Me.col_PMH_PartName, Me.col_PMH_Operator, Me.col_PMH_Reporter, Me.col_PMH_Details, Me.col_PMH_Result})
		Me.lvwPMHistoryList.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lvwPMHistoryList.FullRowSelect = True
		Me.lvwPMHistoryList.GridLines = True
		Me.lvwPMHistoryList.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
		Me.lvwPMHistoryList.HideSelection = False
		Me.lvwPMHistoryList.Location = New System.Drawing.Point(6, 37)
		Me.lvwPMHistoryList.Name = "lvwPMHistoryList"
		Me.lvwPMHistoryList.Size = New System.Drawing.Size(1254, 251)
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
		Me.col_PMH_MachineName.Width = 250
		'
		'col_PMH_PartName
		'
		Me.col_PMH_PartName.Text = "Part Name"
		Me.col_PMH_PartName.Width = 250
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
		Me.col_PMH_Details.Width = 250
		'
		'col_PMH_Result
		'
		Me.col_PMH_Result.Text = "Result"
		Me.col_PMH_Result.Width = 160
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
		'pnlPMPartList
		'
		Me.pnlPMPartList.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.pnlPMPartList.Controls.Add(Me.Label2)
		Me.pnlPMPartList.Controls.Add(Me.lvwPartList)
		Me.pnlPMPartList.Location = New System.Drawing.Point(35, 116)
		Me.pnlPMPartList.Name = "pnlPMPartList"
		Me.pnlPMPartList.Size = New System.Drawing.Size(1264, 221)
		Me.pnlPMPartList.TabIndex = 21
		'
		'Label2
		'
		Me.Label2.AutoSize = True
		Me.Label2.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label2.Location = New System.Drawing.Point(3, 5)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(103, 18)
		Me.Label2.TabIndex = 2
		Me.Label2.Text = "PART LIST"
		'
		'Label5
		'
		Me.Label5.BackColor = System.Drawing.Color.DimGray
		Me.Label5.Location = New System.Drawing.Point(34, 111)
		Me.Label5.Name = "Label5"
		Me.Label5.Size = New System.Drawing.Size(1265, 2)
		Me.Label5.TabIndex = 22
		'
		'frmMachineInfo
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 18.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(1330, 732)
		Me.Controls.Add(Me.Label5)
		Me.Controls.Add(Me.pnlPMPartList)
		Me.Controls.Add(Me.pnlPMHistory)
		Me.Controls.Add(Me.lblTotalPMCost)
		Me.Controls.Add(Me.Label4)
		Me.Controls.Add(Me.Label3)
		Me.Controls.Add(Me.lblMachineName)
		Me.Controls.Add(Me.pnlHeader)
		Me.Controls.Add(Me.pnlFooter)
		Me.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
		Me.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
		Me.Name = "frmMachineInfo"
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = "Machine Info"
		Me.pnlFooter.ResumeLayout(False)
		Me.pnlHeader.ResumeLayout(False)
		Me.pnlHeader.PerformLayout()
		CType(Me.picIcon, System.ComponentModel.ISupportInitialize).EndInit()
		Me.pnlPMHistory.ResumeLayout(False)
		Me.pnlPMHistory.PerformLayout()
		Me.pnlPMPartList.ResumeLayout(False)
		Me.pnlPMPartList.PerformLayout()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents pnlFooter As Panel
	Friend WithEvents pnlHeader As Panel
	Friend WithEvents Label1 As Label
	Friend WithEvents btnClose As Button
	Friend WithEvents lblMachineName As Label
	Friend WithEvents lvwPartList As ListView
	Friend WithEvents col_PM_ID As ColumnHeader
	Friend WithEvents col_PM_PartNo As ColumnHeader
	Friend WithEvents col_PM_PartName As ColumnHeader
	Friend WithEvents col_PM_PartPrice As ColumnHeader
	Friend WithEvents col_PM_RequireQTY As ColumnHeader
	Friend WithEvents col_PM_TotalPrice As ColumnHeader
	Friend WithEvents col_PM_NextPM As ColumnHeader
	Friend WithEvents col_PM_Remark As ColumnHeader
	Friend WithEvents picIcon As PictureBox
	Friend WithEvents col_PM_Frequency As ColumnHeader
	Friend WithEvents Label3 As Label
	Friend WithEvents Label4 As Label
	Friend WithEvents lblTotalPMCost As Label
	Friend WithEvents col_PM_CostPerYear As ColumnHeader
	Friend WithEvents pnlPMHistory As Panel
	Friend WithEvents lvwPMHistoryList As ListView
	Friend WithEvents col_PMH_ID As ColumnHeader
	Friend WithEvents col_PMH_PMID As ColumnHeader
	Friend WithEvents col_PMH_PMDate As ColumnHeader
	Friend WithEvents col_PMH_MachineName As ColumnHeader
	Friend WithEvents col_PMH_PartName As ColumnHeader
	Friend WithEvents col_PMH_Operator As ColumnHeader
	Friend WithEvents col_PMH_Reporter As ColumnHeader
	Friend WithEvents col_PMH_Details As ColumnHeader
	Friend WithEvents col_PMH_Result As ColumnHeader
	Friend WithEvents Label7 As Label
	Friend WithEvents pnlPMPartList As Panel
	Friend WithEvents Label2 As Label
	Friend WithEvents Label5 As Label
End Class
