﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAddPMHistory
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
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAddPMHistory))
		Me.pnlHeader = New System.Windows.Forms.Panel()
		Me.picIcon = New System.Windows.Forms.PictureBox()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.pnlFooter = New System.Windows.Forms.Panel()
		Me.btnClose = New System.Windows.Forms.Button()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.tbxPMType = New System.Windows.Forms.TextBox()
		Me.Label6 = New System.Windows.Forms.Label()
		Me.dtpLastPM = New System.Windows.Forms.DateTimePicker()
		Me.Label3 = New System.Windows.Forms.Label()
		Me.TextBox1 = New System.Windows.Forms.TextBox()
		Me.Label10 = New System.Windows.Forms.Label()
		Me.tbxRemark = New System.Windows.Forms.TextBox()
		Me.Label8 = New System.Windows.Forms.Label()
		Me.tbxAction = New System.Windows.Forms.TextBox()
		Me.Label4 = New System.Windows.Forms.Label()
		Me.lblPMID = New System.Windows.Forms.Label()
		Me.lvwDetails = New System.Windows.Forms.ListView()
		Me.col_DT_Properties = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
		Me.col_DT_Value = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
		Me.col_DT_ID = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
		Me.pnlHeader.SuspendLayout()
		CType(Me.picIcon, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.pnlFooter.SuspendLayout()
		Me.SuspendLayout()
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
		Me.pnlHeader.Size = New System.Drawing.Size(574, 60)
		Me.pnlHeader.TabIndex = 15
		'
		'picIcon
		'
		Me.picIcon.Image = CType(resources.GetObject("picIcon.Image"), System.Drawing.Image)
		Me.picIcon.Location = New System.Drawing.Point(5, 5)
		Me.picIcon.Name = "picIcon"
		Me.picIcon.Size = New System.Drawing.Size(50, 50)
		Me.picIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
		Me.picIcon.TabIndex = 16
		Me.picIcon.TabStop = False
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label1.ForeColor = System.Drawing.Color.White
		Me.Label1.Location = New System.Drawing.Point(63, 5)
		Me.Label1.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(228, 23)
		Me.Label1.TabIndex = 0
		Me.Label1.Text = "Complete PM Schedule"
		'
		'pnlFooter
		'
		Me.pnlFooter.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.pnlFooter.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
		Me.pnlFooter.Controls.Add(Me.btnClose)
		Me.pnlFooter.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.pnlFooter.Location = New System.Drawing.Point(0, 707)
		Me.pnlFooter.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
		Me.pnlFooter.Name = "pnlFooter"
		Me.pnlFooter.Size = New System.Drawing.Size(574, 50)
		Me.pnlFooter.TabIndex = 14
		'
		'btnClose
		'
		Me.btnClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.btnClose.Image = Global.PMSys.My.Resources.Resources.close16
		Me.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.btnClose.Location = New System.Drawing.Point(434, 9)
		Me.btnClose.Margin = New System.Windows.Forms.Padding(2)
		Me.btnClose.Name = "btnClose"
		Me.btnClose.Size = New System.Drawing.Size(132, 32)
		Me.btnClose.TabIndex = 7
		Me.btnClose.Text = "Close"
		Me.btnClose.UseVisualStyleBackColor = True
		'
		'Label2
		'
		Me.Label2.AutoSize = True
		Me.Label2.Location = New System.Drawing.Point(42, 322)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(78, 18)
		Me.Label2.TabIndex = 17
		Me.Label2.Text = "Reporter"
		'
		'tbxPMType
		'
		Me.tbxPMType.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.tbxPMType.Location = New System.Drawing.Point(45, 343)
		Me.tbxPMType.Name = "tbxPMType"
		Me.tbxPMType.Size = New System.Drawing.Size(486, 27)
		Me.tbxPMType.TabIndex = 2
		'
		'Label6
		'
		Me.Label6.AutoSize = True
		Me.Label6.Location = New System.Drawing.Point(42, 378)
		Me.Label6.Name = "Label6"
		Me.Label6.Size = New System.Drawing.Size(76, 18)
		Me.Label6.TabIndex = 26
		Me.Label6.Text = "PM Date"
		'
		'dtpLastPM
		'
		Me.dtpLastPM.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.dtpLastPM.Location = New System.Drawing.Point(45, 399)
		Me.dtpLastPM.Name = "dtpLastPM"
		Me.dtpLastPM.Size = New System.Drawing.Size(486, 27)
		Me.dtpLastPM.TabIndex = 3
		'
		'Label3
		'
		Me.Label3.AutoSize = True
		Me.Label3.Location = New System.Drawing.Point(42, 266)
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(80, 18)
		Me.Label3.TabIndex = 28
		Me.Label3.Text = "Operator"
		'
		'TextBox1
		'
		Me.TextBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.TextBox1.Location = New System.Drawing.Point(45, 287)
		Me.TextBox1.Name = "TextBox1"
		Me.TextBox1.Size = New System.Drawing.Size(486, 27)
		Me.TextBox1.TabIndex = 1
		'
		'Label10
		'
		Me.Label10.AutoSize = True
		Me.Label10.Location = New System.Drawing.Point(42, 490)
		Me.Label10.Name = "Label10"
		Me.Label10.Size = New System.Drawing.Size(69, 18)
		Me.Label10.TabIndex = 36
		Me.Label10.Text = "Remark"
		'
		'tbxRemark
		'
		Me.tbxRemark.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.tbxRemark.Location = New System.Drawing.Point(45, 511)
		Me.tbxRemark.Multiline = True
		Me.tbxRemark.Name = "tbxRemark"
		Me.tbxRemark.Size = New System.Drawing.Size(486, 158)
		Me.tbxRemark.TabIndex = 5
		'
		'Label8
		'
		Me.Label8.AutoSize = True
		Me.Label8.Location = New System.Drawing.Point(42, 434)
		Me.Label8.Name = "Label8"
		Me.Label8.Size = New System.Drawing.Size(89, 18)
		Me.Label8.TabIndex = 35
		Me.Label8.Text = "PM Result"
		'
		'tbxAction
		'
		Me.tbxAction.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.tbxAction.Location = New System.Drawing.Point(45, 455)
		Me.tbxAction.Name = "tbxAction"
		Me.tbxAction.Size = New System.Drawing.Size(486, 27)
		Me.tbxAction.TabIndex = 4
		'
		'Label4
		'
		Me.Label4.AutoSize = True
		Me.Label4.Location = New System.Drawing.Point(42, 94)
		Me.Label4.Name = "Label4"
		Me.Label4.Size = New System.Drawing.Size(66, 18)
		Me.Label4.TabIndex = 38
		Me.Label4.Text = "Details"
		'
		'lblPMID
		'
		Me.lblPMID.AutoSize = True
		Me.lblPMID.Location = New System.Drawing.Point(42, 685)
		Me.lblPMID.Name = "lblPMID"
		Me.lblPMID.Size = New System.Drawing.Size(50, 18)
		Me.lblPMID.TabIndex = 39
		Me.lblPMID.Text = "PMID"
		'
		'lvwDetails
		'
		Me.lvwDetails.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.col_DT_ID, Me.col_DT_Properties, Me.col_DT_Value})
		Me.lvwDetails.FullRowSelect = True
		Me.lvwDetails.GridLines = True
		Me.lvwDetails.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None
		Me.lvwDetails.HideSelection = False
		Me.lvwDetails.Location = New System.Drawing.Point(45, 115)
		Me.lvwDetails.Name = "lvwDetails"
		Me.lvwDetails.Size = New System.Drawing.Size(486, 143)
		Me.lvwDetails.TabIndex = 40
		Me.lvwDetails.UseCompatibleStateImageBehavior = False
		Me.lvwDetails.View = System.Windows.Forms.View.Details
		'
		'col_DT_Properties
		'
		Me.col_DT_Properties.Text = "Properties"
		Me.col_DT_Properties.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		Me.col_DT_Properties.Width = 120
		'
		'col_DT_Value
		'
		Me.col_DT_Value.Text = "Value"
		Me.col_DT_Value.Width = 340
		'
		'col_DT_ID
		'
		Me.col_DT_ID.Text = "ID"
		Me.col_DT_ID.Width = 0
		'
		'frmAddPMHistory
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 18.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.Color.Gainsboro
		Me.ClientSize = New System.Drawing.Size(574, 757)
		Me.Controls.Add(Me.lvwDetails)
		Me.Controls.Add(Me.lblPMID)
		Me.Controls.Add(Me.Label4)
		Me.Controls.Add(Me.Label10)
		Me.Controls.Add(Me.tbxRemark)
		Me.Controls.Add(Me.Label8)
		Me.Controls.Add(Me.tbxAction)
		Me.Controls.Add(Me.Label3)
		Me.Controls.Add(Me.TextBox1)
		Me.Controls.Add(Me.Label6)
		Me.Controls.Add(Me.dtpLastPM)
		Me.Controls.Add(Me.Label2)
		Me.Controls.Add(Me.tbxPMType)
		Me.Controls.Add(Me.pnlHeader)
		Me.Controls.Add(Me.pnlFooter)
		Me.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
		Me.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
		Me.Name = "frmAddPMHistory"
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = "Add PMHistory"
		Me.pnlHeader.ResumeLayout(False)
		Me.pnlHeader.PerformLayout()
		CType(Me.picIcon, System.ComponentModel.ISupportInitialize).EndInit()
		Me.pnlFooter.ResumeLayout(False)
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents pnlHeader As Panel
	Friend WithEvents Label1 As Label
	Friend WithEvents pnlFooter As Panel
	Friend WithEvents btnClose As Button
	Friend WithEvents picIcon As PictureBox
	Friend WithEvents Label2 As Label
	Friend WithEvents tbxPMType As TextBox
	Friend WithEvents Label6 As Label
	Friend WithEvents dtpLastPM As DateTimePicker
	Friend WithEvents Label3 As Label
	Friend WithEvents TextBox1 As TextBox
	Friend WithEvents Label10 As Label
	Friend WithEvents tbxRemark As TextBox
	Friend WithEvents Label8 As Label
	Friend WithEvents tbxAction As TextBox
	Friend WithEvents Label4 As Label
	Friend WithEvents lblPMID As Label
	Friend WithEvents lvwDetails As ListView
	Friend WithEvents col_DT_ID As ColumnHeader
	Friend WithEvents col_DT_Properties As ColumnHeader
	Friend WithEvents col_DT_Value As ColumnHeader
End Class