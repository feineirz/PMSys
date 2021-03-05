Public Class frmAddMachine

#Region "Moveable Form Code"
	<System.Runtime.InteropServices.DllImportAttribute("user32.dll")>
	Public Shared Function SendMessage(hWnd As IntPtr, Msg As Integer, wParam As Integer, lParam As Integer) As Integer
	End Function

	<System.Runtime.InteropServices.DllImportAttribute("user32.dll")>
	Public Shared Function ReleaseCapture() As Boolean
	End Function

	Private Sub Form_MouseDown(sender As Object, e As MouseEventArgs) Handles MyBase.MouseDown, pnlHeader.MouseDown, lblTitle.MouseDown
		Const WM_NCLBUTTONDOWN As Integer = &HA1
		Const HT_CAPTION As Integer = &H2

		If e.Button = MouseButtons.Left Then
			ReleaseCapture()
			SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0)
		End If
	End Sub

#End Region

	Private Sub InitEnv()

	End Sub

	Sub EditMode(MachineID As Integer)

		Dim m As New Machine(MachineID)

		lblTitle.Text = "Edit Machine Info"
		lblMode.Text = "Edit"
		lblMachineID.Text = m.machine_id
		tbxMachineCode.Text = m.machine_code
		tbxName.Text = m.machine_name
		tbxDetail.Text = m.detail
		tbxRemark.Text = m.remark

	End Sub

	Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click

		Me.Dispose()

	End Sub

	Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

		Dim MachineInfoA As Machine.MachineInfo

		If tbxName.Text.Trim = "" Then
			tbxName.Focus()
			lblNameError.Text = "*Name cannot empty!"
			Exit Sub
		End If

		MachineInfoA.machine_code = tbxMachineCode.Text.Trim
		MachineInfoA.machine_name = tbxName.Text.Trim
		MachineInfoA.detail = tbxDetail.Text.Trim
		MachineInfoA.remark = tbxRemark.Text.Trim

		If lblMode.Text = "Add" Then
			Machine.Add(MachineInfoA)

		ElseIf lblMode.Text = "Edit" Then
			If Not lblMachineID.Text = "" Then
				MachineInfoA.machine_id = lblMachineID.Text
				Machine.Update(MachineInfoA)

			End If
		End If

		frmMain.ListMachine()
		Me.Dispose()

	End Sub

	Private Sub tbx_GotFocus(sender As Object, e As EventArgs) Handles tbxName.GotFocus, tbxDetail.GotFocus, tbxRemark.GotFocus

		Dim tbx As TextBox = DirectCast(sender, TextBox)
		tbx.SelectAll()

	End Sub
End Class