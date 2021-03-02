<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmAddPM
	Inherits System.Windows.Forms.Form

	'Form overrides dispose to clean up the component list.
	<System.Diagnostics.DebuggerNonUserCode()>
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
	<System.Diagnostics.DebuggerStepThrough()>
	Private Sub InitializeComponent()
		Me.pnlFooter = New System.Windows.Forms.Panel()
		Me.btnClose = New System.Windows.Forms.Button()
		Me.btnSave = New System.Windows.Forms.Button()
		Me.lblTitle = New System.Windows.Forms.Label()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.tbxPMType = New System.Windows.Forms.TextBox()
		Me.cmbMachineID = New System.Windows.Forms.ComboBox()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.Label3 = New System.Windows.Forms.Label()
		Me.cmbPartID = New System.Windows.Forms.ComboBox()
		Me.Label4 = New System.Windows.Forms.Label()
		Me.numRequiredQTY = New System.Windows.Forms.NumericUpDown()
		Me.Label5 = New System.Windows.Forms.Label()
		Me.numFrequency = New System.Windows.Forms.NumericUpDown()
		Me.dtpLastPM = New System.Windows.Forms.DateTimePicker()
		Me.Label6 = New System.Windows.Forms.Label()
		Me.Label7 = New System.Windows.Forms.Label()
		Me.lblPartUnitPrice = New System.Windows.Forms.Label()
		Me.lblPartTotalPrice = New System.Windows.Forms.Label()
		Me.Label9 = New System.Windows.Forms.Label()
		Me.Label8 = New System.Windows.Forms.Label()
		Me.tbxAction = New System.Windows.Forms.TextBox()
		Me.Label10 = New System.Windows.Forms.Label()
		Me.tbxRemark = New System.Windows.Forms.TextBox()
		Me.lblPMID = New System.Windows.Forms.Label()
		Me.lblMode = New System.Windows.Forms.Label()
		Me.pnlFooter.SuspendLayout()
		CType(Me.numRequiredQTY, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.numFrequency, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'pnlFooter
		'
		Me.pnlFooter.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.pnlFooter.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
		Me.pnlFooter.Controls.Add(Me.btnClose)
		Me.pnlFooter.Controls.Add(Me.btnSave)
		Me.pnlFooter.Location = New System.Drawing.Point(-1, 732)
		Me.pnlFooter.Name = "pnlFooter"
		Me.pnlFooter.Size = New System.Drawing.Size(542, 50)
		Me.pnlFooter.TabIndex = 12
		'
		'btnClose
		'
		Me.btnClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.btnClose.Image = Global.PMSys.My.Resources.Resources.close16
		Me.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.btnClose.Location = New System.Drawing.Point(403, 9)
		Me.btnClose.Name = "btnClose"
		Me.btnClose.Size = New System.Drawing.Size(130, 32)
		Me.btnClose.TabIndex = 9
		Me.btnClose.Text = "Close"
		Me.btnClose.UseVisualStyleBackColor = True
		'
		'btnSave
		'
		Me.btnSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.btnSave.Image = Global.PMSys.My.Resources.Resources.floppy_disk16
		Me.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.btnSave.Location = New System.Drawing.Point(263, 9)
		Me.btnSave.Name = "btnSave"
		Me.btnSave.Size = New System.Drawing.Size(130, 32)
		Me.btnSave.TabIndex = 8
		Me.btnSave.Text = "Save"
		Me.btnSave.UseVisualStyleBackColor = True
		'
		'lblTitle
		'
		Me.lblTitle.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.lblTitle.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
		Me.lblTitle.Font = New System.Drawing.Font("Verdana", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblTitle.ForeColor = System.Drawing.Color.White
		Me.lblTitle.Location = New System.Drawing.Point(0, 0)
		Me.lblTitle.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.lblTitle.Name = "lblTitle"
		Me.lblTitle.Size = New System.Drawing.Size(541, 57)
		Me.lblTitle.TabIndex = 11
		Me.lblTitle.Text = "NEW PM SCHEDULE"
		Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Location = New System.Drawing.Point(32, 87)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(74, 18)
		Me.Label1.TabIndex = 14
		Me.Label1.Text = "PM Type"
		'
		'tbxPMType
		'
		Me.tbxPMType.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.tbxPMType.Location = New System.Drawing.Point(35, 108)
		Me.tbxPMType.Name = "tbxPMType"
		Me.tbxPMType.Size = New System.Drawing.Size(465, 27)
		Me.tbxPMType.TabIndex = 0
		'
		'cmbMachineID
		'
		Me.cmbMachineID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.cmbMachineID.FormattingEnabled = True
		Me.cmbMachineID.Location = New System.Drawing.Point(35, 164)
		Me.cmbMachineID.Name = "cmbMachineID"
		Me.cmbMachineID.Size = New System.Drawing.Size(465, 26)
		Me.cmbMachineID.TabIndex = 1
		'
		'Label2
		'
		Me.Label2.AutoSize = True
		Me.Label2.Location = New System.Drawing.Point(32, 143)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(153, 18)
		Me.Label2.TabIndex = 16
		Me.Label2.Text = "Machine ID/Name"
		'
		'Label3
		'
		Me.Label3.AutoSize = True
		Me.Label3.Location = New System.Drawing.Point(32, 198)
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(123, 18)
		Me.Label3.TabIndex = 18
		Me.Label3.Text = "Part No/Name"
		'
		'cmbPartID
		'
		Me.cmbPartID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.cmbPartID.FormattingEnabled = True
		Me.cmbPartID.Location = New System.Drawing.Point(35, 219)
		Me.cmbPartID.Name = "cmbPartID"
		Me.cmbPartID.Size = New System.Drawing.Size(465, 26)
		Me.cmbPartID.TabIndex = 2
		'
		'Label4
		'
		Me.Label4.AutoSize = True
		Me.Label4.Location = New System.Drawing.Point(32, 269)
		Me.Label4.Name = "Label4"
		Me.Label4.Size = New System.Drawing.Size(211, 18)
		Me.Label4.TabIndex = 20
		Me.Label4.Text = "Required Quantity (Unit)"
		'
		'numRequiredQTY
		'
		Me.numRequiredQTY.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.numRequiredQTY.Location = New System.Drawing.Point(35, 290)
		Me.numRequiredQTY.Maximum = New Decimal(New Integer() {10000000, 0, 0, 0})
		Me.numRequiredQTY.Name = "numRequiredQTY"
		Me.numRequiredQTY.Size = New System.Drawing.Size(465, 27)
		Me.numRequiredQTY.TabIndex = 3
		Me.numRequiredQTY.Value = New Decimal(New Integer() {1, 0, 0, 0})
		'
		'Label5
		'
		Me.Label5.AutoSize = True
		Me.Label5.Location = New System.Drawing.Point(32, 341)
		Me.Label5.Name = "Label5"
		Me.Label5.Size = New System.Drawing.Size(150, 18)
		Me.Label5.TabIndex = 22
		Me.Label5.Text = "Frequency (Days)"
		'
		'numFrequency
		'
		Me.numFrequency.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.numFrequency.Location = New System.Drawing.Point(35, 362)
		Me.numFrequency.Maximum = New Decimal(New Integer() {10000000, 0, 0, 0})
		Me.numFrequency.Name = "numFrequency"
		Me.numFrequency.Size = New System.Drawing.Size(465, 27)
		Me.numFrequency.TabIndex = 4
		Me.numFrequency.Value = New Decimal(New Integer() {30, 0, 0, 0})
		'
		'dtpLastPM
		'
		Me.dtpLastPM.Location = New System.Drawing.Point(35, 418)
		Me.dtpLastPM.Name = "dtpLastPM"
		Me.dtpLastPM.Size = New System.Drawing.Size(465, 27)
		Me.dtpLastPM.TabIndex = 5
		'
		'Label6
		'
		Me.Label6.AutoSize = True
		Me.Label6.Location = New System.Drawing.Point(32, 397)
		Me.Label6.Name = "Label6"
		Me.Label6.Size = New System.Drawing.Size(72, 18)
		Me.Label6.TabIndex = 24
		Me.Label6.Text = "Last PM"
		'
		'Label7
		'
		Me.Label7.AutoSize = True
		Me.Label7.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label7.Location = New System.Drawing.Point(32, 248)
		Me.Label7.Name = "Label7"
		Me.Label7.Size = New System.Drawing.Size(77, 16)
		Me.Label7.TabIndex = 25
		Me.Label7.Text = "Unit Price:"
		'
		'lblPartUnitPrice
		'
		Me.lblPartUnitPrice.AutoSize = True
		Me.lblPartUnitPrice.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblPartUnitPrice.Location = New System.Drawing.Point(109, 248)
		Me.lblPartUnitPrice.Name = "lblPartUnitPrice"
		Me.lblPartUnitPrice.Size = New System.Drawing.Size(37, 16)
		Me.lblPartUnitPrice.TabIndex = 26
		Me.lblPartUnitPrice.Text = "0.00"
		'
		'lblPartTotalPrice
		'
		Me.lblPartTotalPrice.AutoSize = True
		Me.lblPartTotalPrice.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblPartTotalPrice.Location = New System.Drawing.Point(116, 320)
		Me.lblPartTotalPrice.Name = "lblPartTotalPrice"
		Me.lblPartTotalPrice.Size = New System.Drawing.Size(37, 16)
		Me.lblPartTotalPrice.TabIndex = 28
		Me.lblPartTotalPrice.Text = "0.00"
		'
		'Label9
		'
		Me.Label9.AutoSize = True
		Me.Label9.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label9.Location = New System.Drawing.Point(32, 320)
		Me.Label9.Name = "Label9"
		Me.Label9.Size = New System.Drawing.Size(84, 16)
		Me.Label9.TabIndex = 27
		Me.Label9.Text = "Total Price:"
		'
		'Label8
		'
		Me.Label8.AutoSize = True
		Me.Label8.Location = New System.Drawing.Point(32, 453)
		Me.Label8.Name = "Label8"
		Me.Label8.Size = New System.Drawing.Size(59, 18)
		Me.Label8.TabIndex = 30
		Me.Label8.Text = "Action"
		'
		'tbxAction
		'
		Me.tbxAction.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.tbxAction.Location = New System.Drawing.Point(35, 474)
		Me.tbxAction.Name = "tbxAction"
		Me.tbxAction.Size = New System.Drawing.Size(465, 27)
		Me.tbxAction.TabIndex = 6
		'
		'Label10
		'
		Me.Label10.AutoSize = True
		Me.Label10.Location = New System.Drawing.Point(32, 509)
		Me.Label10.Name = "Label10"
		Me.Label10.Size = New System.Drawing.Size(69, 18)
		Me.Label10.TabIndex = 32
		Me.Label10.Text = "Remark"
		'
		'tbxRemark
		'
		Me.tbxRemark.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.tbxRemark.Location = New System.Drawing.Point(35, 530)
		Me.tbxRemark.Multiline = True
		Me.tbxRemark.Name = "tbxRemark"
		Me.tbxRemark.Size = New System.Drawing.Size(465, 158)
		Me.tbxRemark.TabIndex = 7
		'
		'lblPMID
		'
		Me.lblPMID.AutoSize = True
		Me.lblPMID.Location = New System.Drawing.Point(116, 711)
		Me.lblPMID.Name = "lblPMID"
		Me.lblPMID.Size = New System.Drawing.Size(50, 18)
		Me.lblPMID.TabIndex = 34
		Me.lblPMID.Text = "PMID"
		Me.lblPMID.Visible = False
		'
		'lblMode
		'
		Me.lblMode.AutoSize = True
		Me.lblMode.Location = New System.Drawing.Point(32, 711)
		Me.lblMode.Name = "lblMode"
		Me.lblMode.Size = New System.Drawing.Size(39, 18)
		Me.lblMode.TabIndex = 33
		Me.lblMode.Text = "Add"
		Me.lblMode.Visible = False
		'
		'frmAddPM
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 18.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.Color.Gainsboro
		Me.ClientSize = New System.Drawing.Size(541, 781)
		Me.ControlBox = False
		Me.Controls.Add(Me.lblPMID)
		Me.Controls.Add(Me.lblMode)
		Me.Controls.Add(Me.Label10)
		Me.Controls.Add(Me.tbxRemark)
		Me.Controls.Add(Me.Label8)
		Me.Controls.Add(Me.tbxAction)
		Me.Controls.Add(Me.lblPartTotalPrice)
		Me.Controls.Add(Me.Label9)
		Me.Controls.Add(Me.lblPartUnitPrice)
		Me.Controls.Add(Me.Label7)
		Me.Controls.Add(Me.Label6)
		Me.Controls.Add(Me.dtpLastPM)
		Me.Controls.Add(Me.Label5)
		Me.Controls.Add(Me.numFrequency)
		Me.Controls.Add(Me.Label4)
		Me.Controls.Add(Me.numRequiredQTY)
		Me.Controls.Add(Me.Label3)
		Me.Controls.Add(Me.cmbPartID)
		Me.Controls.Add(Me.Label2)
		Me.Controls.Add(Me.cmbMachineID)
		Me.Controls.Add(Me.Label1)
		Me.Controls.Add(Me.tbxPMType)
		Me.Controls.Add(Me.pnlFooter)
		Me.Controls.Add(Me.lblTitle)
		Me.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
		Me.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
		Me.Name = "frmAddPM"
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = "frmAddMiantenance"
		Me.pnlFooter.ResumeLayout(False)
		CType(Me.numRequiredQTY, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.numFrequency, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents pnlFooter As Panel
	Friend WithEvents btnClose As Button
	Friend WithEvents btnSave As Button
	Friend WithEvents lblTitle As Label
	Friend WithEvents Label1 As Label
	Friend WithEvents tbxPMType As TextBox
	Friend WithEvents cmbMachineID As ComboBox
	Friend WithEvents Label2 As Label
	Friend WithEvents Label3 As Label
	Friend WithEvents cmbPartID As ComboBox
	Friend WithEvents Label4 As Label
	Friend WithEvents numRequiredQTY As NumericUpDown
	Friend WithEvents Label5 As Label
	Friend WithEvents numFrequency As NumericUpDown
	Friend WithEvents dtpLastPM As DateTimePicker
	Friend WithEvents Label6 As Label
	Friend WithEvents Label7 As Label
	Friend WithEvents lblPartUnitPrice As Label
	Friend WithEvents lblPartTotalPrice As Label
	Friend WithEvents Label9 As Label
	Friend WithEvents Label8 As Label
	Friend WithEvents tbxAction As TextBox
	Friend WithEvents Label10 As Label
	Friend WithEvents tbxRemark As TextBox
	Friend WithEvents lblPMID As Label
	Friend WithEvents lblMode As Label
End Class
