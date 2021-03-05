Public Class frmMachineInfo

	Sub ListPMHistory(Optional Query As String = "", Optional Condition As String = "")

		Dim pm As PM
		Dim m As Machine
		Dim p As Part
		Dim PMHList = PMHistory.List(Query, Condition, "pm_date")
		Dim lvi As ListViewItem

		lvwPMHistoryList.Items.Clear()
		If PMHList.Count > 0 Then
			For Each pmh In PMHList.Items
				pm = New PM(pmh.pm_id)
				m = New Machine(pm.machine_id)
				p = New Part(pm.part_id)

				lvi = lvwPMHistoryList.Items.Add(pmh.pm_history_id)
				lvi.SubItems.Add(pm.pm_id)
				lvi.SubItems.Add(pmh.pm_date.ToString("yyyy-MM-dd"))
				lvi.SubItems.Add(m.machine_name)
				lvi.SubItems.Add(p.part_name)
				lvi.SubItems.Add(pmh.operator_name)
				lvi.SubItems.Add(pmh.reporter)
				lvi.SubItems.Add(pmh.pm_details)
				lvi.SubItems.Add(pmh.pm_result)

			Next
		End If

	End Sub

	Sub ShowMachineInfo(MachineID As Integer)

		Dim m As New Machine(MachineID)
		Dim p As Part
		Dim pmlist = PM.List("", "machine_id=" & m.machine_id, "next_pm")

		Dim TotalCost As Decimal = 0

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
				lvi.SubItems.Add(pm.required_qty)
				lvi.SubItems.Add((p.price * pm.required_qty).ToString("#,##0.00"))
				lvi.SubItems.Add(pm.frequency & " days")
				lvi.SubItems.Add((p.price * 365.25 / pm.frequency).ToString("#,##0.00"))
				lvi.SubItems.Add(pm.next_pm.ToString("yyyy-MM-dd"))
				lvi.SubItems.Add(pm.remark)

				' Calc Total cost
				TotalCost += (365.25 / pm.frequency) * p.price * pm.required_qty
			Next
		End If

		Dim qry As String = "select *
													from PM_History as ph inner join PM as pm
														on ph.pm_id = pm.pm_id "

		ListPMHistory(qry, "machine_id=" & m.machine_id)

		lblTotalPMCost.Text = TotalCost.ToString("#,##0.00")

	End Sub

	Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click

		Me.Dispose()

	End Sub
End Class