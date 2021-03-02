﻿Public Class frmAddPM

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

	Sub LoadMachine()

		Machine.ToComboBoxItems(cmbMachineID, "machine_id", "machine_id", "machine_name", " : ", "", "machine_name")

	End Sub

	Sub LoadPart()

		Part.ToComboBoxItems(cmbPartID, "part_no", "part_id", "part_name", " : ", "", "part_no")

	End Sub

	Sub UpdatePartTotalPrice()

		If Not cmbPartID.Text = "" Then
			If cmbPartID.SelectedValue >= 0 Then
				lblPartTotalPrice.Text = (CInt(lblPartUnitPrice.Text) * numRequiredQTY.Value).ToString("#,##0.00")
			End If
		End If

	End Sub

	Sub EditMode(PMID As Integer)

		Dim pm As New PM(PMID)
		Dim i As Integer

		lblTitle.Text = "Edit PM Info"
		tbxPMType.Text = pm.pm_type
		For i = 0 To cmbMachineID.Items.Count
			If cmbMachineID.Items(i).ToString = pm.machine_id Then
				cmbMachineID.SelectedIndex = i
				Exit For
			End If
		Next
		For i = 0 To cmbPartID.Items.Count
			If cmbPartID.Items(i).ToString = pm.part_id Then
				cmbPartID.SelectedIndex = i
				Exit For
			End If
		Next

		numRequiredQTY.Value = pm.unit_require
		numFrequency.Value = pm.frequency
		dtpLastPM.Value = pm.last_pm
		tbxAction.Text = pm.pm_action
		tbxRemark.Text = pm.remark

	End Sub

	Private Sub frmAddMiantenance_Load(sender As Object, e As EventArgs) Handles MyBase.Load

		LoadMachine()
		LoadPart()

		If lblMode.Text = "Edit" Then
			If IsNumeric(lblPMID.Text) Then EditMode(lblPMID.Text)
		End If

	End Sub

	Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click

		Me.Dispose()

	End Sub

	Private Sub cmbPartID_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbPartID.SelectedIndexChanged

		If cmbPartID.SelectedIndex >= 0 Then
			Dim p As New Part(cmbPartID.SelectedValue)
			lblPartUnitPrice.Text = p.price.ToString("#,##0.00")
		Else
			lblPartUnitPrice.Text = "0.00"
		End If

		UpdatePartTotalPrice()

	End Sub

	Private Sub numRequiredQTY_ValueChanged(sender As Object, e As EventArgs) Handles numRequiredQTY.ValueChanged

		UpdatePartTotalPrice()

	End Sub
	Private Sub tbx_GotFocus(sender As Object, e As EventArgs) Handles tbxPMType.GotFocus, tbxAction.GotFocus, tbxRemark.GotFocus

		Dim tbx As TextBox = DirectCast(sender, TextBox)
		tbx.SelectAll()

	End Sub

	Private Sub num_GotFocus(sender As Object, e As EventArgs) Handles numRequiredQTY.GotFocus, numFrequency.GotFocus

		Dim num As NumericUpDown = DirectCast(sender, NumericUpDown)
		num.Select(0, 10)

	End Sub

	Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

		Dim PMInfoA As PM.PMInfo

		If lblMode.Text = "Add" Then

			PMInfoA.pm_type = tbxPMType.Text.Trim
			PMInfoA.machine_id = cmbMachineID.SelectedValue
			PMInfoA.part_id = cmbPartID.SelectedValue
			PMInfoA.unit_require = numRequiredQTY.Value
			PMInfoA.frequency = numFrequency.Value
			PMInfoA.last_pm = dtpLastPM.Value
			PMInfoA.pm_action = tbxAction.Text.Trim
			PMInfoA.remark = tbxRemark.Text.Trim

			PM.Add(PMInfoA)

		ElseIf lblMode.Text = "Edit" Then

			Dim pm As New PM(lblPMID.Text)
			pm.pm_type = tbxPMType.Text.Trim
			pm.machine_id = cmbMachineID.SelectedValue
			pm.part_id = cmbPartID.SelectedValue
			pm.unit_require = numRequiredQTY.Value
			pm.frequency = numFrequency.Value
			pm.last_pm = dtpLastPM.Value
			pm.pm_action = tbxAction.Text.Trim
			pm.remark = tbxRemark.Text.Trim

		End If

		frmMain.ListPM()
		Me.Dispose()

	End Sub
End Class