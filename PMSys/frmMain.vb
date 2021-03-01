Public Class frmMain

	Sub ListMachine()

		Dim MachineList = Machine.List()
		Dim lvi As ListViewItem
		lvwMachine.Items.Clear()

		If MachineList.Count > 0 Then
			For Each m In MachineList.Items
				lvi = lvwMachine.Items.Add(m.machine_id)
				lvi.SubItems.Add(m.machine_name)
				lvi.SubItems.Add(m.detail)
			Next

		End If

	End Sub

	Sub ListPart()

		Dim PartList = Part.List()
		Dim lvi As ListViewItem
		lvwPartList.Items.Clear()

		If PartList.Count > 0 Then
			For Each p In PartList.Items
				lvi = lvwPartList.Items.Add(p.part_id)
				lvi.SubItems.Add(p.part_no)
				lvi.SubItems.Add(p.part_name)
				lvi.SubItems.Add(p.price.ToString("#,##0.00"))
			Next
		End If

	End Sub

	Private Sub InitEnv()

		ListMachine()
		ListPart()

	End Sub

	Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load

		InitEnv()

	End Sub

	Private Sub frmMain_Closed(sender As Object, e As EventArgs) Handles Me.Closed

		Application.Exit()

	End Sub

	Private Sub btnAddMachine_Click(sender As Object, e As EventArgs) Handles btnAddMachine.Click

		frmAddMachine.ShowDialog()

	End Sub

	Private Sub btnAddPart_Click(sender As Object, e As EventArgs) Handles btnAddPart.Click

		frmAddPart.ShowDialog()

	End Sub
End Class