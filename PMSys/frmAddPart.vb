Public Class frmAddPart
	Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click

		Me.Close()

	End Sub

	Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

		Dim PartInfoA As Part.PartInfo
		PartInfoA.part_no = tbxPartNo.Text.Trim
		PartInfoA.part_name = tbxPartName.Text.Trim
		PartInfoA.price = numPrice.Value
		PartInfoA.remark = tbxRemark.Text.Trim

		Part.Add(PartInfoA)
		frmMain.ListPart()
		Me.Dispose()

	End Sub
End Class