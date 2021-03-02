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
		Me.pnlFooter = New System.Windows.Forms.Panel()
		Me.pnlHeader = New System.Windows.Forms.Panel()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.btnClose = New System.Windows.Forms.Button()
		Me.lblMachineName = New System.Windows.Forms.Label()
		Me.lvwPartList = New System.Windows.Forms.ListView()
		Me.col_P_ID = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
		Me.col_P_PartNo = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
		Me.col_P_Name = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
		Me.col_P_Price = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
		Me.Label2 = New System.Windows.Forms.Label()
		Me.pnlFooter.SuspendLayout()
		Me.pnlHeader.SuspendLayout()
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
		Me.pnlFooter.Size = New System.Drawing.Size(759, 50)
		Me.pnlFooter.TabIndex = 12
		'
		'pnlHeader
		'
		Me.pnlHeader.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.pnlHeader.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
		Me.pnlHeader.Controls.Add(Me.Label1)
		Me.pnlHeader.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.pnlHeader.Location = New System.Drawing.Point(0, 0)
		Me.pnlHeader.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
		Me.pnlHeader.Name = "pnlHeader"
		Me.pnlHeader.Size = New System.Drawing.Size(759, 60)
		Me.pnlHeader.TabIndex = 13
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label1.ForeColor = System.Drawing.Color.White
		Me.Label1.Location = New System.Drawing.Point(30, 14)
		Me.Label1.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(134, 23)
		Me.Label1.TabIndex = 0
		Me.Label1.Text = "Machine Info"
		'
		'btnClose
		'
		Me.btnClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.btnClose.Image = Global.PMSys.My.Resources.Resources.close16
		Me.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.btnClose.Location = New System.Drawing.Point(643, 8)
		Me.btnClose.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
		Me.btnClose.Name = "btnClose"
		Me.btnClose.Size = New System.Drawing.Size(108, 32)
		Me.btnClose.TabIndex = 6
		Me.btnClose.Text = "Close"
		Me.btnClose.UseVisualStyleBackColor = True
		'
		'lblMachineName
		'
		Me.lblMachineName.AutoSize = True
		Me.lblMachineName.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblMachineName.Location = New System.Drawing.Point(31, 78)
		Me.lblMachineName.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
		Me.lblMachineName.Name = "lblMachineName"
		Me.lblMachineName.Size = New System.Drawing.Size(0, 23)
		Me.lblMachineName.TabIndex = 14
		'
		'lvwPartList
		'
		Me.lvwPartList.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.col_P_ID, Me.col_P_PartNo, Me.col_P_Name, Me.col_P_Price})
		Me.lvwPartList.FullRowSelect = True
		Me.lvwPartList.GridLines = True
		Me.lvwPartList.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
		Me.lvwPartList.HideSelection = False
		Me.lvwPartList.Location = New System.Drawing.Point(34, 142)
		Me.lvwPartList.Name = "lvwPartList"
		Me.lvwPartList.Size = New System.Drawing.Size(700, 180)
		Me.lvwPartList.TabIndex = 15
		Me.lvwPartList.UseCompatibleStateImageBehavior = False
		Me.lvwPartList.View = System.Windows.Forms.View.Details
		'
		'col_P_ID
		'
		Me.col_P_ID.Text = "ID"
		Me.col_P_ID.Width = 50
		'
		'col_P_PartNo
		'
		Me.col_P_PartNo.Text = "PartNo"
		Me.col_P_PartNo.Width = 200
		'
		'col_P_Name
		'
		Me.col_P_Name.Text = "Name"
		Me.col_P_Name.Width = 350
		'
		'col_P_Price
		'
		Me.col_P_Price.Text = "Price"
		Me.col_P_Price.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		Me.col_P_Price.Width = 80
		'
		'Label2
		'
		Me.Label2.AutoSize = True
		Me.Label2.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label2.Location = New System.Drawing.Point(31, 115)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(92, 18)
		Me.Label2.TabIndex = 16
		Me.Label2.Text = "PART LIST"
		'
		'frmMachineInfo
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 18.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(759, 732)
		Me.Controls.Add(Me.lvwPartList)
		Me.Controls.Add(Me.Label2)
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
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents pnlFooter As Panel
	Friend WithEvents pnlHeader As Panel
	Friend WithEvents Label1 As Label
	Friend WithEvents btnClose As Button
	Friend WithEvents lblMachineName As Label
	Friend WithEvents lvwPartList As ListView
	Friend WithEvents col_P_ID As ColumnHeader
	Friend WithEvents col_P_PartNo As ColumnHeader
	Friend WithEvents col_P_Name As ColumnHeader
	Friend WithEvents col_P_Price As ColumnHeader
	Friend WithEvents Label2 As Label
End Class
