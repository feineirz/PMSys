<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAddMachine
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
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAddMachine))
		Me.tbxName = New System.Windows.Forms.TextBox()
		Me.tbxDetail = New System.Windows.Forms.TextBox()
		Me.tbxRemark = New System.Windows.Forms.TextBox()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.Label3 = New System.Windows.Forms.Label()
		Me.btnClose = New System.Windows.Forms.Button()
		Me.btnSave = New System.Windows.Forms.Button()
		Me.lblNameError = New System.Windows.Forms.Label()
		Me.pnlFooter = New System.Windows.Forms.Panel()
		Me.Label4 = New System.Windows.Forms.Label()
		Me.tbxMachineCode = New System.Windows.Forms.TextBox()
		Me.lblMachineID = New System.Windows.Forms.Label()
		Me.lblMode = New System.Windows.Forms.Label()
		Me.pnlHeader = New System.Windows.Forms.Panel()
		Me.picIcon = New System.Windows.Forms.PictureBox()
		Me.lblTitle = New System.Windows.Forms.Label()
		Me.pnlFooter.SuspendLayout()
		Me.pnlHeader.SuspendLayout()
		CType(Me.picIcon, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'tbxName
		'
		Me.tbxName.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.tbxName.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.tbxName.Location = New System.Drawing.Point(43, 159)
		Me.tbxName.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
		Me.tbxName.Name = "tbxName"
		Me.tbxName.Size = New System.Drawing.Size(488, 27)
		Me.tbxName.TabIndex = 1
		'
		'tbxDetail
		'
		Me.tbxDetail.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.tbxDetail.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.tbxDetail.Location = New System.Drawing.Point(43, 215)
		Me.tbxDetail.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
		Me.tbxDetail.Multiline = True
		Me.tbxDetail.Name = "tbxDetail"
		Me.tbxDetail.Size = New System.Drawing.Size(488, 91)
		Me.tbxDetail.TabIndex = 2
		'
		'tbxRemark
		'
		Me.tbxRemark.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.tbxRemark.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.tbxRemark.Location = New System.Drawing.Point(43, 335)
		Me.tbxRemark.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
		Me.tbxRemark.Multiline = True
		Me.tbxRemark.Name = "tbxRemark"
		Me.tbxRemark.Size = New System.Drawing.Size(488, 133)
		Me.tbxRemark.TabIndex = 3
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Location = New System.Drawing.Point(40, 138)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(127, 18)
		Me.Label1.TabIndex = 3
		Me.Label1.Text = "Machine Name"
		'
		'Label2
		'
		Me.Label2.AutoSize = True
		Me.Label2.Location = New System.Drawing.Point(40, 194)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(57, 18)
		Me.Label2.TabIndex = 4
		Me.Label2.Text = "Detail"
		'
		'Label3
		'
		Me.Label3.AutoSize = True
		Me.Label3.Location = New System.Drawing.Point(40, 314)
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(69, 18)
		Me.Label3.TabIndex = 5
		Me.Label3.Text = "Remark"
		'
		'btnClose
		'
		Me.btnClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.btnClose.Image = Global.PMSys.My.Resources.Resources.close16
		Me.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.btnClose.Location = New System.Drawing.Point(436, 9)
		Me.btnClose.Name = "btnClose"
		Me.btnClose.Size = New System.Drawing.Size(130, 32)
		Me.btnClose.TabIndex = 5
		Me.btnClose.Text = "Close"
		Me.btnClose.UseVisualStyleBackColor = True
		'
		'btnSave
		'
		Me.btnSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.btnSave.Image = Global.PMSys.My.Resources.Resources.floppy_disk16
		Me.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.btnSave.Location = New System.Drawing.Point(300, 9)
		Me.btnSave.Name = "btnSave"
		Me.btnSave.Size = New System.Drawing.Size(130, 32)
		Me.btnSave.TabIndex = 4
		Me.btnSave.Text = "Save"
		Me.btnSave.UseVisualStyleBackColor = True
		'
		'lblNameError
		'
		Me.lblNameError.AutoSize = True
		Me.lblNameError.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblNameError.ForeColor = System.Drawing.Color.Red
		Me.lblNameError.Location = New System.Drawing.Point(113, 138)
		Me.lblNameError.Name = "lblNameError"
		Me.lblNameError.Size = New System.Drawing.Size(0, 16)
		Me.lblNameError.TabIndex = 6
		'
		'pnlFooter
		'
		Me.pnlFooter.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.pnlFooter.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
		Me.pnlFooter.Controls.Add(Me.btnClose)
		Me.pnlFooter.Controls.Add(Me.btnSave)
		Me.pnlFooter.Location = New System.Drawing.Point(0, 496)
		Me.pnlFooter.Name = "pnlFooter"
		Me.pnlFooter.Size = New System.Drawing.Size(574, 50)
		Me.pnlFooter.TabIndex = 8
		'
		'Label4
		'
		Me.Label4.AutoSize = True
		Me.Label4.Location = New System.Drawing.Point(40, 82)
		Me.Label4.Name = "Label4"
		Me.Label4.Size = New System.Drawing.Size(121, 18)
		Me.Label4.TabIndex = 10
		Me.Label4.Text = "Machine Code"
		'
		'tbxMachineCode
		'
		Me.tbxMachineCode.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.tbxMachineCode.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.tbxMachineCode.Location = New System.Drawing.Point(43, 103)
		Me.tbxMachineCode.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
		Me.tbxMachineCode.Name = "tbxMachineCode"
		Me.tbxMachineCode.Size = New System.Drawing.Size(488, 27)
		Me.tbxMachineCode.TabIndex = 0
		'
		'lblMachineID
		'
		Me.lblMachineID.AutoSize = True
		Me.lblMachineID.Location = New System.Drawing.Point(124, 64)
		Me.lblMachineID.Name = "lblMachineID"
		Me.lblMachineID.Size = New System.Drawing.Size(93, 18)
		Me.lblMachineID.TabIndex = 14
		Me.lblMachineID.Text = "MachineID"
		Me.lblMachineID.Visible = False
		'
		'lblMode
		'
		Me.lblMode.AutoSize = True
		Me.lblMode.Location = New System.Drawing.Point(40, 64)
		Me.lblMode.Name = "lblMode"
		Me.lblMode.Size = New System.Drawing.Size(39, 18)
		Me.lblMode.TabIndex = 13
		Me.lblMode.Text = "Add"
		Me.lblMode.Visible = False
		'
		'pnlHeader
		'
		Me.pnlHeader.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.pnlHeader.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
		Me.pnlHeader.Controls.Add(Me.picIcon)
		Me.pnlHeader.Controls.Add(Me.lblTitle)
		Me.pnlHeader.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.pnlHeader.Location = New System.Drawing.Point(0, 0)
		Me.pnlHeader.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
		Me.pnlHeader.Name = "pnlHeader"
		Me.pnlHeader.Size = New System.Drawing.Size(574, 60)
		Me.pnlHeader.TabIndex = 38
		'
		'picIcon
		'
		Me.picIcon.Image = CType(resources.GetObject("picIcon.Image"), System.Drawing.Image)
		Me.picIcon.Location = New System.Drawing.Point(3, 3)
		Me.picIcon.Name = "picIcon"
		Me.picIcon.Size = New System.Drawing.Size(50, 50)
		Me.picIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
		Me.picIcon.TabIndex = 16
		Me.picIcon.TabStop = False
		'
		'lblTitle
		'
		Me.lblTitle.AutoSize = True
		Me.lblTitle.Font = New System.Drawing.Font("Century Gothic", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblTitle.ForeColor = System.Drawing.Color.White
		Me.lblTitle.Location = New System.Drawing.Point(61, 9)
		Me.lblTitle.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
		Me.lblTitle.Name = "lblTitle"
		Me.lblTitle.Size = New System.Drawing.Size(200, 33)
		Me.lblTitle.TabIndex = 0
		Me.lblTitle.Text = "New Machine"
		'
		'frmAddMachine
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 18.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.Color.Gainsboro
		Me.ClientSize = New System.Drawing.Size(573, 545)
		Me.ControlBox = False
		Me.Controls.Add(Me.pnlHeader)
		Me.Controls.Add(Me.lblMachineID)
		Me.Controls.Add(Me.lblMode)
		Me.Controls.Add(Me.Label4)
		Me.Controls.Add(Me.tbxMachineCode)
		Me.Controls.Add(Me.pnlFooter)
		Me.Controls.Add(Me.lblNameError)
		Me.Controls.Add(Me.Label3)
		Me.Controls.Add(Me.Label2)
		Me.Controls.Add(Me.Label1)
		Me.Controls.Add(Me.tbxRemark)
		Me.Controls.Add(Me.tbxDetail)
		Me.Controls.Add(Me.tbxName)
		Me.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
		Me.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
		Me.MaximizeBox = False
		Me.MinimizeBox = False
		Me.Name = "frmAddMachine"
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.pnlFooter.ResumeLayout(False)
		Me.pnlHeader.ResumeLayout(False)
		Me.pnlHeader.PerformLayout()
		CType(Me.picIcon, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents tbxName As TextBox
	Friend WithEvents tbxDetail As TextBox
	Friend WithEvents tbxRemark As TextBox
	Friend WithEvents Label1 As Label
	Friend WithEvents Label2 As Label
	Friend WithEvents Label3 As Label
	Friend WithEvents btnClose As Button
	Friend WithEvents btnSave As Button
	Friend WithEvents lblNameError As Label
	Friend WithEvents pnlFooter As Panel
	Friend WithEvents Label4 As Label
	Friend WithEvents tbxMachineCode As TextBox
	Friend WithEvents lblMachineID As Label
	Friend WithEvents lblMode As Label
	Friend WithEvents pnlHeader As Panel
	Friend WithEvents picIcon As PictureBox
	Friend WithEvents lblTitle As Label
End Class
