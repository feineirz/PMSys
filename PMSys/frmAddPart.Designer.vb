<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmAddPart
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
		Me.tbxPartNo = New System.Windows.Forms.TextBox()
		Me.tbxPartName = New System.Windows.Forms.TextBox()
		Me.tbxRemark = New System.Windows.Forms.TextBox()
		Me.numPrice = New System.Windows.Forms.NumericUpDown()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.Label3 = New System.Windows.Forms.Label()
		Me.Label4 = New System.Windows.Forms.Label()
		Me.btnSave = New System.Windows.Forms.Button()
		Me.btnClose = New System.Windows.Forms.Button()
		Me.pnlFooter = New System.Windows.Forms.Panel()
		Me.lblTitle = New System.Windows.Forms.Label()
		Me.lblMode = New System.Windows.Forms.Label()
		Me.lblPartID = New System.Windows.Forms.Label()
		CType(Me.numPrice, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.pnlFooter.SuspendLayout()
		Me.SuspendLayout()
		'
		'tbxPartNo
		'
		Me.tbxPartNo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.tbxPartNo.Location = New System.Drawing.Point(41, 116)
		Me.tbxPartNo.Name = "tbxPartNo"
		Me.tbxPartNo.Size = New System.Drawing.Size(465, 27)
		Me.tbxPartNo.TabIndex = 0
		'
		'tbxPartName
		'
		Me.tbxPartName.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.tbxPartName.Location = New System.Drawing.Point(41, 172)
		Me.tbxPartName.Name = "tbxPartName"
		Me.tbxPartName.Size = New System.Drawing.Size(465, 27)
		Me.tbxPartName.TabIndex = 1
		'
		'tbxRemark
		'
		Me.tbxRemark.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.tbxRemark.Location = New System.Drawing.Point(41, 284)
		Me.tbxRemark.Multiline = True
		Me.tbxRemark.Name = "tbxRemark"
		Me.tbxRemark.Size = New System.Drawing.Size(465, 158)
		Me.tbxRemark.TabIndex = 3
		'
		'numPrice
		'
		Me.numPrice.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.numPrice.DecimalPlaces = 2
		Me.numPrice.Location = New System.Drawing.Point(41, 228)
		Me.numPrice.Maximum = New Decimal(New Integer() {10000000, 0, 0, 0})
		Me.numPrice.Name = "numPrice"
		Me.numPrice.Size = New System.Drawing.Size(465, 27)
		Me.numPrice.TabIndex = 2
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Location = New System.Drawing.Point(38, 95)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(75, 18)
		Me.Label1.TabIndex = 4
		Me.Label1.Text = "Part No."
		'
		'Label2
		'
		Me.Label2.AutoSize = True
		Me.Label2.Location = New System.Drawing.Point(38, 151)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(94, 18)
		Me.Label2.TabIndex = 5
		Me.Label2.Text = "Part Name"
		'
		'Label3
		'
		Me.Label3.AutoSize = True
		Me.Label3.Location = New System.Drawing.Point(38, 207)
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(87, 18)
		Me.Label3.TabIndex = 6
		Me.Label3.Text = "Unit Price"
		'
		'Label4
		'
		Me.Label4.AutoSize = True
		Me.Label4.Location = New System.Drawing.Point(38, 263)
		Me.Label4.Name = "Label4"
		Me.Label4.Size = New System.Drawing.Size(69, 18)
		Me.Label4.TabIndex = 7
		Me.Label4.Text = "Remark"
		'
		'btnSave
		'
		Me.btnSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.btnSave.Image = Global.PMSys.My.Resources.Resources.floppy_disk16
		Me.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.btnSave.Location = New System.Drawing.Point(276, 9)
		Me.btnSave.Name = "btnSave"
		Me.btnSave.Size = New System.Drawing.Size(130, 32)
		Me.btnSave.TabIndex = 4
		Me.btnSave.Text = "Save"
		Me.btnSave.UseVisualStyleBackColor = True
		'
		'btnClose
		'
		Me.btnClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.btnClose.Image = Global.PMSys.My.Resources.Resources.close16
		Me.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.btnClose.Location = New System.Drawing.Point(412, 9)
		Me.btnClose.Name = "btnClose"
		Me.btnClose.Size = New System.Drawing.Size(130, 32)
		Me.btnClose.TabIndex = 5
		Me.btnClose.Text = "Close"
		Me.btnClose.UseVisualStyleBackColor = True
		'
		'pnlFooter
		'
		Me.pnlFooter.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.pnlFooter.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
		Me.pnlFooter.Controls.Add(Me.btnClose)
		Me.pnlFooter.Controls.Add(Me.btnSave)
		Me.pnlFooter.Location = New System.Drawing.Point(-1, 493)
		Me.pnlFooter.Name = "pnlFooter"
		Me.pnlFooter.Size = New System.Drawing.Size(550, 50)
		Me.pnlFooter.TabIndex = 10
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
		Me.lblTitle.Size = New System.Drawing.Size(549, 57)
		Me.lblTitle.TabIndex = 9
		Me.lblTitle.Text = "NEW PART"
		Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		'lblMode
		'
		Me.lblMode.AutoSize = True
		Me.lblMode.Location = New System.Drawing.Point(38, 473)
		Me.lblMode.Name = "lblMode"
		Me.lblMode.Size = New System.Drawing.Size(39, 18)
		Me.lblMode.TabIndex = 11
		Me.lblMode.Text = "Add"
		Me.lblMode.Visible = False
		'
		'lblPartID
		'
		Me.lblPartID.AutoSize = True
		Me.lblPartID.Location = New System.Drawing.Point(122, 473)
		Me.lblPartID.Name = "lblPartID"
		Me.lblPartID.Size = New System.Drawing.Size(60, 18)
		Me.lblPartID.TabIndex = 12
		Me.lblPartID.Text = "PartID"
		Me.lblPartID.Visible = False
		'
		'frmAddPart
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 18.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.Color.Gainsboro
		Me.ClientSize = New System.Drawing.Size(549, 543)
		Me.ControlBox = False
		Me.Controls.Add(Me.lblPartID)
		Me.Controls.Add(Me.lblMode)
		Me.Controls.Add(Me.pnlFooter)
		Me.Controls.Add(Me.lblTitle)
		Me.Controls.Add(Me.Label4)
		Me.Controls.Add(Me.Label3)
		Me.Controls.Add(Me.Label2)
		Me.Controls.Add(Me.Label1)
		Me.Controls.Add(Me.numPrice)
		Me.Controls.Add(Me.tbxRemark)
		Me.Controls.Add(Me.tbxPartName)
		Me.Controls.Add(Me.tbxPartNo)
		Me.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
		Me.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
		Me.Name = "frmAddPart"
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = "New Part"
		CType(Me.numPrice, System.ComponentModel.ISupportInitialize).EndInit()
		Me.pnlFooter.ResumeLayout(False)
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents tbxPartNo As TextBox
	Friend WithEvents tbxPartName As TextBox
	Friend WithEvents tbxRemark As TextBox
	Friend WithEvents numPrice As NumericUpDown
	Friend WithEvents Label1 As Label
	Friend WithEvents Label2 As Label
	Friend WithEvents Label3 As Label
	Friend WithEvents Label4 As Label
	Friend WithEvents btnSave As Button
	Friend WithEvents btnClose As Button
	Friend WithEvents pnlFooter As Panel
	Friend WithEvents lblTitle As Label
	Friend WithEvents lblMode As Label
	Friend WithEvents lblPartID As Label
End Class
