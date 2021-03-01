<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAddPart
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
		CType(Me.numPrice, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'tbxPartNo
		'
		Me.tbxPartNo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.tbxPartNo.Location = New System.Drawing.Point(42, 53)
		Me.tbxPartNo.Name = "tbxPartNo"
		Me.tbxPartNo.Size = New System.Drawing.Size(385, 27)
		Me.tbxPartNo.TabIndex = 0
		'
		'tbxPartName
		'
		Me.tbxPartName.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.tbxPartName.Location = New System.Drawing.Point(42, 109)
		Me.tbxPartName.Name = "tbxPartName"
		Me.tbxPartName.Size = New System.Drawing.Size(385, 27)
		Me.tbxPartName.TabIndex = 1
		'
		'tbxRemark
		'
		Me.tbxRemark.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.tbxRemark.Location = New System.Drawing.Point(42, 221)
		Me.tbxRemark.Multiline = True
		Me.tbxRemark.Name = "tbxRemark"
		Me.tbxRemark.Size = New System.Drawing.Size(385, 158)
		Me.tbxRemark.TabIndex = 3
		'
		'numPrice
		'
		Me.numPrice.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.numPrice.DecimalPlaces = 2
		Me.numPrice.Location = New System.Drawing.Point(42, 165)
		Me.numPrice.Maximum = New Decimal(New Integer() {10000000, 0, 0, 0})
		Me.numPrice.Name = "numPrice"
		Me.numPrice.Size = New System.Drawing.Size(385, 27)
		Me.numPrice.TabIndex = 2
		Me.numPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		Me.numPrice.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Location = New System.Drawing.Point(39, 32)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(75, 18)
		Me.Label1.TabIndex = 4
		Me.Label1.Text = "Part No."
		'
		'Label2
		'
		Me.Label2.AutoSize = True
		Me.Label2.Location = New System.Drawing.Point(39, 88)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(55, 18)
		Me.Label2.TabIndex = 5
		Me.Label2.Text = "Name"
		'
		'Label3
		'
		Me.Label3.AutoSize = True
		Me.Label3.Location = New System.Drawing.Point(39, 144)
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(87, 18)
		Me.Label3.TabIndex = 6
		Me.Label3.Text = "Unit Price"
		'
		'Label4
		'
		Me.Label4.AutoSize = True
		Me.Label4.Location = New System.Drawing.Point(39, 200)
		Me.Label4.Name = "Label4"
		Me.Label4.Size = New System.Drawing.Size(69, 18)
		Me.Label4.TabIndex = 7
		Me.Label4.Text = "Remark"
		'
		'btnSave
		'
		Me.btnSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.btnSave.Location = New System.Drawing.Point(233, 385)
		Me.btnSave.Name = "btnSave"
		Me.btnSave.Size = New System.Drawing.Size(104, 27)
		Me.btnSave.TabIndex = 4
		Me.btnSave.Text = "Save"
		Me.btnSave.UseVisualStyleBackColor = True
		'
		'btnClose
		'
		Me.btnClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.btnClose.Location = New System.Drawing.Point(343, 385)
		Me.btnClose.Name = "btnClose"
		Me.btnClose.Size = New System.Drawing.Size(84, 27)
		Me.btnClose.TabIndex = 5
		Me.btnClose.Text = "Close"
		Me.btnClose.UseVisualStyleBackColor = True
		'
		'frmAddPart
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 18.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.Color.White
		Me.ClientSize = New System.Drawing.Size(469, 438)
		Me.ControlBox = False
		Me.Controls.Add(Me.btnClose)
		Me.Controls.Add(Me.btnSave)
		Me.Controls.Add(Me.Label4)
		Me.Controls.Add(Me.Label3)
		Me.Controls.Add(Me.Label2)
		Me.Controls.Add(Me.Label1)
		Me.Controls.Add(Me.numPrice)
		Me.Controls.Add(Me.tbxRemark)
		Me.Controls.Add(Me.tbxPartName)
		Me.Controls.Add(Me.tbxPartNo)
		Me.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
		Me.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
		Me.Name = "frmAddPart"
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = "Add Part"
		CType(Me.numPrice, System.ComponentModel.ISupportInitialize).EndInit()
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
End Class
