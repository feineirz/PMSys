Public Class frmMachineInfo

	Sub ShowMachineInfo(MachineID As Integer)

		Dim m As New Machine(MachineID)
		Dim p As Part
		Dim pmlist = PM.List("", "machine_id=" & m.machine_id)

		Dim lvi As ListViewItem

		If Not m.machine_code = "" Then lblMachineName.Text = m.machine_code + " : "
		lblMachineName.Text += m.machine_name

		lvwPartList.Items.Clear()

		If pmlist.Count > 0 Then
			For Each pm In pmlist.Items
				p = New Part(pm.part_id)
				lvi = lvwPartList.Items.Add(p.part_id)
				lvi.SubItems.Add(p.part_no)
				lvi.SubItems.Add(p.part_name)
				lvi.SubItems.Add(p.price.ToString("#,##0.00"))
				lvi.SubItems.Add(pm.unit_require)
				lvi.SubItems.Add((p.price * pm.unit_require).ToString("#,##0.00"))
				lvi.SubItems.Add(pm.next_pm.ToString("yyyy-MM-dd"))
				lvi.SubItems.Add(pm.remark)
			Next
		End If


	End Sub

	Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click

		Me.Dispose()

	End Sub
End Class