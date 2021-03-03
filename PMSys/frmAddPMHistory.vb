Public Class frmAddPMHistory

	Sub InitData(PMID As Integer)

		Dim pm As New PM(PMID)
		If pm IsNot Nothing Then

			lblPMID.Text = pm.pm_id

			Dim m As New Machine(pm.machine_id)
			Dim p As New Part(pm.part_id)

			Dim lvi As ListViewItem

			Dim machine_info As String = ""
			Dim part_info As String = ""

			If Not m.machine_code = "" Then
				machine_info = m.machine_code & " / " & m.machine_name
			Else
				machine_info = m.machine_name
			End If

			If Not p.part_no = "" Then
				part_info = p.part_no & " / " & p.part_name
			Else
				part_info = p.part_name
			End If

			lvwDetails.Items.Clear()
			lvi = lvwDetails.Items.Add(0)
			lvi.SubItems.Add("Type")
			lvi.SubItems.Add(pm.pm_type)

			lvi = lvwDetails.Items.Add(0)
			lvi.SubItems.Add("Machine")
			lvi.SubItems.Add(machine_info)

			lvi = lvwDetails.Items.Add(0)
			lvi.SubItems.Add("Part")
			lvi.SubItems.Add(part_info)

			lvi = lvwDetails.Items.Add(0)
			lvi.SubItems.Add("Unit Price")
			lvi.SubItems.Add(p.price.ToString("#,##0.00") & " THB")

			lvi = lvwDetails.Items.Add(0)
			lvi.SubItems.Add("Req. QTY")
			lvi.SubItems.Add(pm.unit_require & " Unit(s)")

			lvi = lvwDetails.Items.Add(0)
			lvi.SubItems.Add("Total Price")
			lvi.SubItems.Add((p.price * pm.unit_require).ToString("#,##0.00") & " THB")

		End If

	End Sub

	Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click

		Me.Dispose()

	End Sub

	Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

		Dim pmh_info As PMHistory.PMHistoryInfo
		pmh_info.pm_id = lblPMID.Text
		pmh_info.reporter = tbxReporter.Text.Trim
		pmh_info.operator_name = tbxOperatorName.Text.Trim
		pmh_info.pm_date = dtpPMDate.Value
		pmh_info.report_date = Now
		pmh_info.pm_result = tbxPMResult.Text.Trim
		pmh_info.remark = tbxRemark.Text.Trim

		If PMHistory.Add(pmh_info) Then
			Dim pm As New PM(lblPMID.Text)
			pm.last_pm = dtpPMDate.Value

			frmMain.ListPM()
			Me.Dispose()
		End If

	End Sub
End Class