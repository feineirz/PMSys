Public Class frmAddPart

#Region "Moveable Form Code"
	<System.Runtime.InteropServices.DllImportAttribute("user32.dll")>
	Public Shared Function SendMessage(hWnd As IntPtr, Msg As Integer, wParam As Integer, lParam As Integer) As Integer
	End Function

	<System.Runtime.InteropServices.DllImportAttribute("user32.dll")>
	Public Shared Function ReleaseCapture() As Boolean
	End Function

	Private Sub Form_MouseDown(sender As Object, e As MouseEventArgs) Handles MyBase.MouseDown, lblTitle.MouseDown
		Const WM_NCLBUTTONDOWN As Integer = &HA1
		Const HT_CAPTION As Integer = &H2

		If e.Button = MouseButtons.Left Then
			ReleaseCapture()
			SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0)
		End If
	End Sub

#End Region

	Sub EditMode(PartID As Integer)

		Dim p As New Part(PartID)

		lblTitle.Text = "Edit Part Info"
		lblMode.Text = "Edit"
		lblPartID.Text = p.part_id
		tbxPartNo.Text = p.part_no
		tbxPartName.Text = p.part_name
		numPrice.Value = p.price
		tbxRemark.Text = p.remark

	End Sub

	Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click

		Me.Dispose()

	End Sub

	Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

		Dim PartInfoA As Part.PartInfo
		PartInfoA.part_no = tbxPartNo.Text.Trim
		PartInfoA.part_name = tbxPartName.Text.Trim
		PartInfoA.price = numPrice.Value
		PartInfoA.remark = tbxRemark.Text.Trim

		If lblMode.Text = "Add" Then
			Part.Add(PartInfoA)

		ElseIf lblMode.Text = "Edit" Then
			PartInfoA.part_id = lblPartID.Text
			Part.Update(PartInfoA)

		End If

		frmMain.ListPart()
		Me.Dispose()

	End Sub

	Private Sub tbx_GotFocus(sender As Object, e As EventArgs) Handles tbxPartNo.GotFocus, tbxPartName.GotFocus, tbxRemark.GotFocus

		Dim tbx As TextBox = DirectCast(sender, TextBox)
		tbx.SelectAll()

	End Sub

	Private Sub num_GotFocus(sender As Object, e As EventArgs) Handles numPrice.GotFocus

		Dim num As NumericUpDown = DirectCast(sender, NumericUpDown)
		num.Select(0, 10)

	End Sub

End Class