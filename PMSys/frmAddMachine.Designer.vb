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
		Me.tbxName = New System.Windows.Forms.TextBox()
		Me.tbxDetail = New System.Windows.Forms.TextBox()
		Me.tbxRemark = New System.Windows.Forms.TextBox()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.Label3 = New System.Windows.Forms.Label()
		Me.btnClose = New System.Windows.Forms.Button()
		Me.btnSave = New System.Windows.Forms.Button()
		Me.lblNameError = New System.Windows.Forms.Label()
		Me.SuspendLayout()
		'
		'tbxName
		'
		Me.tbxName.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.tbxName.Location = New System.Drawing.Point(22, 49)
		Me.tbxName.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
		Me.tbxName.Name = "tbxName"
		Me.tbxName.Size = New System.Drawing.Size(362, 27)
		Me.tbxName.TabIndex = 0
		'
		'tbxDetail
		'
		Me.tbxDetail.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.tbxDetail.Location = New System.Drawing.Point(22, 105)
		Me.tbxDetail.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
		Me.tbxDetail.Multiline = True
		Me.tbxDetail.Name = "tbxDetail"
		Me.tbxDetail.Size = New System.Drawing.Size(362, 91)
		Me.tbxDetail.TabIndex = 1
		'
		'tbxRemark
		'
		Me.tbxRemark.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.tbxRemark.Location = New System.Drawing.Point(22, 225)
		Me.tbxRemark.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
		Me.tbxRemark.Multiline = True
		Me.tbxRemark.Name = "tbxRemark"
		Me.tbxRemark.Size = New System.Drawing.Size(362, 91)
		Me.tbxRemark.TabIndex = 2
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Location = New System.Drawing.Point(19, 28)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(55, 18)
		Me.Label1.TabIndex = 3
		Me.Label1.Text = "Name"
		'
		'Label2
		'
		Me.Label2.AutoSize = True
		Me.Label2.Location = New System.Drawing.Point(19, 84)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(57, 18)
		Me.Label2.TabIndex = 4
		Me.Label2.Text = "Detail"
		'
		'Label3
		'
		Me.Label3.AutoSize = True
		Me.Label3.Location = New System.Drawing.Point(19, 204)
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(69, 18)
		Me.Label3.TabIndex = 5
		Me.Label3.Text = "Remark"
		'
		'btnClose
		'
		Me.btnClose.Location = New System.Drawing.Point(305, 326)
		Me.btnClose.Name = "btnClose"
		Me.btnClose.Size = New System.Drawing.Size(79, 27)
		Me.btnClose.TabIndex = 4
		Me.btnClose.Text = "Close"
		Me.btnClose.UseVisualStyleBackColor = True
		'
		'btnSave
		'
		Me.btnSave.Location = New System.Drawing.Point(203, 326)
		Me.btnSave.Name = "btnSave"
		Me.btnSave.Size = New System.Drawing.Size(96, 27)
		Me.btnSave.TabIndex = 3
		Me.btnSave.Text = "Save"
		Me.btnSave.UseVisualStyleBackColor = True
		'
		'lblNameError
		'
		Me.lblNameError.AutoSize = True
		Me.lblNameError.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblNameError.ForeColor = System.Drawing.Color.Red
		Me.lblNameError.Location = New System.Drawing.Point(92, 28)
		Me.lblNameError.Name = "lblNameError"
		Me.lblNameError.Size = New System.Drawing.Size(0, 16)
		Me.lblNameError.TabIndex = 6
		'
		'frmAddMachine
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 18.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.Color.White
		Me.ClientSize = New System.Drawing.Size(404, 379)
		Me.ControlBox = False
		Me.Controls.Add(Me.lblNameError)
		Me.Controls.Add(Me.btnSave)
		Me.Controls.Add(Me.btnClose)
		Me.Controls.Add(Me.Label3)
		Me.Controls.Add(Me.Label2)
		Me.Controls.Add(Me.Label1)
		Me.Controls.Add(Me.tbxRemark)
		Me.Controls.Add(Me.tbxDetail)
		Me.Controls.Add(Me.tbxName)
		Me.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
		Me.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
		Me.MaximizeBox = False
		Me.MinimizeBox = False
		Me.Name = "frmAddMachine"
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = "Add Machine"
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
End Class
