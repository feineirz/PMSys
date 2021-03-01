<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDBConnect
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
		Me.Label1 = New System.Windows.Forms.Label()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.btnExit = New System.Windows.Forms.Button()
		Me.btnConnect = New System.Windows.Forms.Button()
		Me.tbxHost = New System.Windows.Forms.TextBox()
		Me.tbxDatabase = New System.Windows.Forms.TextBox()
		Me.tbxUsername = New System.Windows.Forms.TextBox()
		Me.Label3 = New System.Windows.Forms.Label()
		Me.Label4 = New System.Windows.Forms.Label()
		Me.Label5 = New System.Windows.Forms.Label()
		Me.Label6 = New System.Windows.Forms.Label()
		Me.tbxPassword = New System.Windows.Forms.TextBox()
		Me.SuspendLayout()
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Font = New System.Drawing.Font("Verdana", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label1.Location = New System.Drawing.Point(76, 32)
		Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(112, 32)
		Me.Label1.TabIndex = 0
		Me.Label1.Text = "PM.Sys"
		'
		'Label2
		'
		Me.Label2.AutoSize = True
		Me.Label2.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label2.Location = New System.Drawing.Point(79, 64)
		Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(209, 18)
		Me.Label2.TabIndex = 1
		Me.Label2.Text = "DATABASE CONNECTION"
		'
		'btnExit
		'
		Me.btnExit.Location = New System.Drawing.Point(265, 249)
		Me.btnExit.Name = "btnExit"
		Me.btnExit.Size = New System.Drawing.Size(94, 29)
		Me.btnExit.TabIndex = 5
		Me.btnExit.Text = "Exit"
		Me.btnExit.UseVisualStyleBackColor = True
		'
		'btnConnect
		'
		Me.btnConnect.Location = New System.Drawing.Point(148, 249)
		Me.btnConnect.Name = "btnConnect"
		Me.btnConnect.Size = New System.Drawing.Size(111, 29)
		Me.btnConnect.TabIndex = 4
		Me.btnConnect.Text = "Connect"
		Me.btnConnect.UseVisualStyleBackColor = True
		'
		'tbxHost
		'
		Me.tbxHost.Location = New System.Drawing.Point(200, 105)
		Me.tbxHost.Name = "tbxHost"
		Me.tbxHost.Size = New System.Drawing.Size(159, 27)
		Me.tbxHost.TabIndex = 0
		Me.tbxHost.Text = "localhost"
		'
		'tbxDatabase
		'
		Me.tbxDatabase.Location = New System.Drawing.Point(200, 138)
		Me.tbxDatabase.Name = "tbxDatabase"
		Me.tbxDatabase.Size = New System.Drawing.Size(159, 27)
		Me.tbxDatabase.TabIndex = 1
		Me.tbxDatabase.Text = "PMSys"
		'
		'tbxUsername
		'
		Me.tbxUsername.Location = New System.Drawing.Point(200, 171)
		Me.tbxUsername.Name = "tbxUsername"
		Me.tbxUsername.Size = New System.Drawing.Size(159, 27)
		Me.tbxUsername.TabIndex = 2
		'
		'Label3
		'
		Me.Label3.AutoSize = True
		Me.Label3.Location = New System.Drawing.Point(147, 108)
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(53, 18)
		Me.Label3.TabIndex = 7
		Me.Label3.Text = "Host:"
		'
		'Label4
		'
		Me.Label4.AutoSize = True
		Me.Label4.Location = New System.Drawing.Point(107, 141)
		Me.Label4.Name = "Label4"
		Me.Label4.Size = New System.Drawing.Size(93, 18)
		Me.Label4.TabIndex = 8
		Me.Label4.Text = "Database:"
		'
		'Label5
		'
		Me.Label5.AutoSize = True
		Me.Label5.Location = New System.Drawing.Point(103, 174)
		Me.Label5.Name = "Label5"
		Me.Label5.Size = New System.Drawing.Size(97, 18)
		Me.Label5.TabIndex = 9
		Me.Label5.Text = "Username:"
		'
		'Label6
		'
		Me.Label6.AutoSize = True
		Me.Label6.Location = New System.Drawing.Point(108, 207)
		Me.Label6.Name = "Label6"
		Me.Label6.Size = New System.Drawing.Size(92, 18)
		Me.Label6.TabIndex = 10
		Me.Label6.Text = "Password:"
		'
		'tbxPassword
		'
		Me.tbxPassword.Location = New System.Drawing.Point(200, 204)
		Me.tbxPassword.Name = "tbxPassword"
		Me.tbxPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
		Me.tbxPassword.Size = New System.Drawing.Size(159, 27)
		Me.tbxPassword.TabIndex = 3
		'
		'frmDBConnect
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 18.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.Color.White
		Me.ClientSize = New System.Drawing.Size(420, 312)
		Me.Controls.Add(Me.tbxPassword)
		Me.Controls.Add(Me.Label6)
		Me.Controls.Add(Me.Label5)
		Me.Controls.Add(Me.Label4)
		Me.Controls.Add(Me.Label3)
		Me.Controls.Add(Me.tbxUsername)
		Me.Controls.Add(Me.tbxDatabase)
		Me.Controls.Add(Me.tbxHost)
		Me.Controls.Add(Me.btnConnect)
		Me.Controls.Add(Me.btnExit)
		Me.Controls.Add(Me.Label2)
		Me.Controls.Add(Me.Label1)
		Me.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
		Me.Margin = New System.Windows.Forms.Padding(4)
		Me.Name = "frmDBConnect"
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = "DBConnect"
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents Label1 As Label
	Friend WithEvents Label2 As Label
	Friend WithEvents btnExit As Button
	Friend WithEvents btnConnect As Button
	Friend WithEvents tbxHost As TextBox
	Friend WithEvents tbxDatabase As TextBox
	Friend WithEvents tbxUsername As TextBox
	Friend WithEvents Label3 As Label
	Friend WithEvents Label4 As Label
	Friend WithEvents Label5 As Label
	Friend WithEvents Label6 As Label
	Friend WithEvents tbxPassword As TextBox
End Class
