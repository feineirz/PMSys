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
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDBConnect))
		Me.lblTitle = New System.Windows.Forms.Label()
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
		Me.picDatabase = New System.Windows.Forms.PictureBox()
		CType(Me.picDatabase, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'lblTitle
		'
		Me.lblTitle.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
		Me.lblTitle.Font = New System.Drawing.Font("Verdana", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblTitle.ForeColor = System.Drawing.Color.White
		Me.lblTitle.Location = New System.Drawing.Point(0, 0)
		Me.lblTitle.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.lblTitle.Name = "lblTitle"
		Me.lblTitle.Size = New System.Drawing.Size(420, 57)
		Me.lblTitle.TabIndex = 0
		Me.lblTitle.Text = "PM.Sys"
		Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		'Label2
		'
		Me.Label2.AutoSize = True
		Me.Label2.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label2.Location = New System.Drawing.Point(130, 80)
		Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(209, 18)
		Me.Label2.TabIndex = 1
		Me.Label2.Text = "DATABASE CONNECTION"
		'
		'btnExit
		'
		Me.btnExit.Location = New System.Drawing.Point(292, 260)
		Me.btnExit.Name = "btnExit"
		Me.btnExit.Size = New System.Drawing.Size(94, 29)
		Me.btnExit.TabIndex = 5
		Me.btnExit.Text = "Exit"
		Me.btnExit.UseVisualStyleBackColor = True
		'
		'btnConnect
		'
		Me.btnConnect.Location = New System.Drawing.Point(175, 260)
		Me.btnConnect.Name = "btnConnect"
		Me.btnConnect.Size = New System.Drawing.Size(111, 29)
		Me.btnConnect.TabIndex = 4
		Me.btnConnect.Text = "Connect"
		Me.btnConnect.UseVisualStyleBackColor = True
		'
		'tbxHost
		'
		Me.tbxHost.Location = New System.Drawing.Point(227, 116)
		Me.tbxHost.Name = "tbxHost"
		Me.tbxHost.Size = New System.Drawing.Size(159, 27)
		Me.tbxHost.TabIndex = 0
		Me.tbxHost.Text = "localhost"
		'
		'tbxDatabase
		'
		Me.tbxDatabase.Location = New System.Drawing.Point(227, 149)
		Me.tbxDatabase.Name = "tbxDatabase"
		Me.tbxDatabase.Size = New System.Drawing.Size(159, 27)
		Me.tbxDatabase.TabIndex = 1
		Me.tbxDatabase.Text = "PMSys"
		'
		'tbxUsername
		'
		Me.tbxUsername.Location = New System.Drawing.Point(227, 182)
		Me.tbxUsername.Name = "tbxUsername"
		Me.tbxUsername.Size = New System.Drawing.Size(159, 27)
		Me.tbxUsername.TabIndex = 2
		'
		'Label3
		'
		Me.Label3.AutoSize = True
		Me.Label3.Location = New System.Drawing.Point(174, 119)
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(53, 18)
		Me.Label3.TabIndex = 7
		Me.Label3.Text = "Host:"
		'
		'Label4
		'
		Me.Label4.AutoSize = True
		Me.Label4.Location = New System.Drawing.Point(134, 152)
		Me.Label4.Name = "Label4"
		Me.Label4.Size = New System.Drawing.Size(93, 18)
		Me.Label4.TabIndex = 8
		Me.Label4.Text = "Database:"
		'
		'Label5
		'
		Me.Label5.AutoSize = True
		Me.Label5.Location = New System.Drawing.Point(130, 185)
		Me.Label5.Name = "Label5"
		Me.Label5.Size = New System.Drawing.Size(97, 18)
		Me.Label5.TabIndex = 9
		Me.Label5.Text = "Username:"
		'
		'Label6
		'
		Me.Label6.AutoSize = True
		Me.Label6.Location = New System.Drawing.Point(135, 218)
		Me.Label6.Name = "Label6"
		Me.Label6.Size = New System.Drawing.Size(92, 18)
		Me.Label6.TabIndex = 10
		Me.Label6.Text = "Password:"
		'
		'tbxPassword
		'
		Me.tbxPassword.Location = New System.Drawing.Point(227, 215)
		Me.tbxPassword.Name = "tbxPassword"
		Me.tbxPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
		Me.tbxPassword.Size = New System.Drawing.Size(159, 27)
		Me.tbxPassword.TabIndex = 3
		'
		'picDatabase
		'
		Me.picDatabase.Image = CType(resources.GetObject("picDatabase.Image"), System.Drawing.Image)
		Me.picDatabase.Location = New System.Drawing.Point(24, 80)
		Me.picDatabase.Name = "picDatabase"
		Me.picDatabase.Size = New System.Drawing.Size(90, 90)
		Me.picDatabase.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
		Me.picDatabase.TabIndex = 11
		Me.picDatabase.TabStop = False
		'
		'frmDBConnect
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 18.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.Color.White
		Me.ClientSize = New System.Drawing.Size(420, 312)
		Me.Controls.Add(Me.picDatabase)
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
		Me.Controls.Add(Me.lblTitle)
		Me.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
		Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
		Me.Margin = New System.Windows.Forms.Padding(4)
		Me.Name = "frmDBConnect"
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = "DBConnect"
		CType(Me.picDatabase, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents lblTitle As Label
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
	Friend WithEvents picDatabase As PictureBox
End Class
