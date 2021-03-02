Public Class frmMachineInfo

	Sub ShowMachineInfo(MachineID As Integer)

		Dim m As New Machine(MachineID)
		Dim p As Part
		Dim pm As PM
		Dim pmlist = PM.List("machine_id=" & m.machine_id)

		Dim lvi As ListViewItem

		If Not m.machine_code = "" Then lblMachineName.Text = m.machine_code + " : "
		lblMachineName.Text += m.machine_name

		lvwPartList.Items.Clear()

		If pmlist.Count > 0 Then
			For Each item In pmlist.Items
				p = New Part(item.part_id)
				lvi = lvwPartList.Items.Add(p.part_id)
				lvi.SubItems.Add(p.part_no)
				lvi.SubItems.Add(p.part_name)
				lvi.SubItems.Add(p.price.ToString("#,##0.00"))
			Next
		End If


	End Sub

	Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click

		Me.Dispose()

	End Sub
End Class