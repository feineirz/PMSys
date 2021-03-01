Public Class frmAddMachine
	Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click

		Me.Close()

	End Sub

	Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

		Dim MachineInfoA As Machine.MachineInfo

		If tbxName.Text.Trim = "" Then
			tbxName.Focus()
			lblNameError.Text = "*Name cannot empty!"
			Exit Sub
		End If

		MachineInfoA.machine_name = tbxName.Text.Trim
		MachineInfoA.detail = tbxDetail.Text.Trim
		MachineInfoA.remark = tbxRemark.Text.Trim

		Machine.Add(MachineInfoA)
		frmMain.ListMachine()

		Me.Dispose()

	End Sub
End Class