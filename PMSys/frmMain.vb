﻿Public Class frmMain

#Region "Moveable Form Code"
	<System.Runtime.InteropServices.DllImportAttribute("user32.dll")>
	Public Shared Function SendMessage(hWnd As IntPtr, Msg As Integer, wParam As Integer, lParam As Integer) As Integer
	End Function

	<System.Runtime.InteropServices.DllImportAttribute("user32.dll")>
	Public Shared Function ReleaseCapture() As Boolean
	End Function

	Private Sub Form_MouseDown(sender As Object, e As MouseEventArgs) Handles MyBase.MouseDown, pnlHeader.MouseDown
		Const WM_NCLBUTTONDOWN As Integer = &HA1
		Const HT_CAPTION As Integer = &H2

		If e.Button = MouseButtons.Left Then
			ReleaseCapture()
			SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0)
		End If
	End Sub

#End Region

	Sub ListMachine(Optional Query As String = "", Optional Condition As String = "")

		Condition = Condition.Replace("'", "''")
		If Not Condition = "" Then
			Condition = "machine_code LIKE '%" + Condition + "%' OR machine_name LIKE '%" + Condition + "%'"
		End If

		Dim MachineList = Machine.List(Query, Condition)
		Dim lvi As ListViewItem
		lvwMachine.Items.Clear()

		If MachineList.Count > 0 Then
			For Each m In MachineList.Items
				lvi = lvwMachine.Items.Add(m.machine_id)
				lvi.SubItems.Add(m.machine_code)
				lvi.SubItems.Add(m.machine_name)
				lvi.SubItems.Add(m.detail)
			Next

		End If

	End Sub

	Sub ListPart(Optional Query As String = "", Optional Condition As String = "")

		Condition = Condition.Replace("'", "''")
		If Not Condition = "" Then
			Condition = "part_no LIKE '%" + Condition + "%' OR part_name LIKE '%" + Condition + "%'"
		End If

		Dim PartList = Part.List(Query, Condition)
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

	Sub ListPM(Optional Query As String = "", Optional Condition As String = "")

		Dim mc As Machine
		Dim pt As Part

		Dim PMList = PM.List(Query, Condition)
		Dim lvi As ListViewItem
		lvwPMList.Items.Clear()

		If PMList.Count > 0 Then
			For Each pm In PMList.Items
				lvi = lvwPMList.Items.Add(pm.pm_id)
				lvi.SubItems.Add(pm.pm_type)
				mc = New Machine(pm.machine_id)
				lvi.SubItems.Add(mc.machine_name)
				pt = New Part(pm.part_id)
				lvi.SubItems.Add(pt.part_name)
				lvi.SubItems.Add(pt.price.ToString("#,##0.00"))
				lvi.SubItems.Add(pm.required_qty)
				lvi.SubItems.Add((pt.price * pm.required_qty).ToString("#,##0.00"))
				lvi.SubItems.Add(pm.frequency & " days")
				lvi.SubItems.Add(pm.last_pm)
				lvi.SubItems.Add(pm.next_pm.ToString("yyyy-MM-dd"))
				lvi.SubItems.Add(pm.pm_action)

				' Highlighter
				Dim diff As Integer = DateDiff(DateInterval.Day, Now, pm.next_pm)
				If diff < 0 Then
					lvi.BackColor = Color.DimGray
					lvi.ForeColor = Color.White
				ElseIf diff < 7 Then
					lvi.BackColor = Color.OrangeRed
					lvi.ForeColor = Color.White
				ElseIf diff < 10 Then
					lvi.BackColor = Color.Gold
				ElseIf diff < 15 Then
					lvi.BackColor = Color.LightGoldenrodYellow
				End If

			Next
		End If

	End Sub

	Sub ListPMHistory(Optional Query As String = "", Optional Condition As String = "")

		Dim pm As PM
		Dim m As Machine
		Dim p As Part
		Dim PMHList = PMHistory.List(Query, Condition)
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

	Private Sub InitEnv()

		ListMachine()
		ListPart()
		ListPM()
		ListPMHistory()

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

	Private Sub btnAddMaintenance_Click(sender As Object, e As EventArgs) Handles btnAddMaintenance.Click

		frmAddPM.ShowDialog()

	End Sub

	Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click

		Application.Exit()

	End Sub

	Private Sub mnu_PL_Edit_Click(sender As Object, e As EventArgs) Handles mnu_PL_Edit.Click

		If lvwPartList.SelectedItems.Count = 1 Then
			frmAddPart.EditMode(lvwPartList.SelectedItems(0).Text)
			frmAddPart.ShowDialog()
		End If

	End Sub

	Private Sub mnu_ML_Edit_Click(sender As Object, e As EventArgs) Handles mnu_ML_Edit.Click

		If lvwMachine.SelectedItems.Count = 1 Then
			frmAddMachine.EditMode(lvwMachine.SelectedItems(0).Text)
			frmAddMachine.ShowDialog()
		End If

	End Sub

	Private Sub mnu_PML_Edit_Click(sender As Object, e As EventArgs) Handles mnu_PML_Edit.Click

		If lvwPMList.SelectedItems.Count = 1 Then
			frmAddPM.EditMode(lvwPMList.SelectedItems(0).Text)
			frmAddPM.ShowDialog()
		End If

	End Sub

	Private Sub lvwMachine_MouseDoubleClick(sender As Object, e As EventArgs) Handles lvwMachine.MouseDoubleClick

		If lvwMachine.SelectedItems.Count = 1 Then
			frmMachineInfo.ShowMachineInfo(lvwMachine.SelectedItems(0).Text)
			frmMachineInfo.ShowDialog()
		End If

	End Sub

	Private Sub btnMachineSearch_Click(sender As Object, e As EventArgs) Handles btnMachineSearch.Click

		ListMachine("", tbxMachineSearch.Text.Trim)
		tbxMachineSearch.Focus()
		tbxMachineSearch.SelectAll()

	End Sub

	Private Sub btnPMSearch_Click(sender As Object, e As EventArgs) Handles btnPMSearch.Click

		Dim searchText = tbxPMSearch.Text.Trim.Replace("'", "''")
		Dim Query As String = "select *
			from PM as pm 
				inner join Machine as m
				on pm.machine_id = m.machine_id 
			inner join Part as p
			on pm.part_id = p.part_id "

		Dim Condition As String = "machine_name LIKE '%" + searchText + "%' "
		If chkSearch_Type.Checked Then Condition &= " OR pm_type LIKE '%" + searchText + "%' "
		If chkSearch_PartName.Checked Then Condition &= " OR part_name LIKE '%" + searchText + "%' "

		ListPM(Query, Condition)
		tbxPMSearch.Focus()
		tbxPMSearch.SelectAll()

	End Sub

	Private Sub btnPartSearch_Click(sender As Object, e As EventArgs) Handles btnPartSearch.Click

		ListPart("", tbxPartSearch.Text.Trim)
		tbxPartSearch.Focus()
		tbxPartSearch.SelectAll()

	End Sub

	Private Sub tbxMachineSearch_KeyDown(sender As Object, e As KeyEventArgs) Handles tbxMachineSearch.KeyDown

		If e.KeyCode = Keys.Enter Then
			e.SuppressKeyPress = True
			e.Handled = True
			btnMachineSearch_Click(Nothing, Nothing)
		End If

	End Sub

	Private Sub tbxPartSearch_KeyDown(sender As Object, e As KeyEventArgs) Handles tbxPartSearch.KeyDown

		If e.KeyCode = Keys.Enter Then
			e.SuppressKeyPress = True
			e.Handled = True
			btnPartSearch_Click(Nothing, Nothing)
		End If

	End Sub

	Private Sub tbxMaintenanceSearch_KeyDown(sender As Object, e As KeyEventArgs) Handles tbxPMSearch.KeyDown

		If e.KeyCode = Keys.Enter Then
			e.SuppressKeyPress = True
			e.Handled = True
			btnPMSearch_Click(Nothing, Nothing)
		End If

	End Sub

	Private Sub mnu_PML_CompletePMSchedule_Click(sender As Object, e As EventArgs) Handles mnu_PML_CompletePMSchedule.Click

		If lvwPMList.SelectedItems.Count = 1 Then

			frmAddPMHistory.InitData(lvwPMList.SelectedItems(0).Text.Trim)
			frmAddPMHistory.ShowDialog()

		End If

	End Sub

	Private Sub mnu_PMH_Edit_Click(sender As Object, e As EventArgs) Handles mnu_PMH_Edit.Click

		If lvwPMHistoryList.SelectedItems.Count = 1 Then
			frmAddPMHistory.EditMode(lvwPMHistoryList.SelectedItems(0).Text)
			frmAddPMHistory.ShowDialog()
		End If

	End Sub

	Private Sub cmsPMList_Opened(sender As Object, e As EventArgs) Handles cmsPMList.Opened

		If lvwPMList.SelectedItems.Count = 1 Then
			cmsPMList.Enabled = True

			Dim pm As New PM(lvwPMList.SelectedItems(0).Text)
			Dim diff = DateDiff(DateInterval.Day, Now, pm.next_pm)

			If diff > 15 Then
				mnu_PML_CompletePMSchedule.Enabled = False
			Else
				mnu_PML_CompletePMSchedule.Enabled = True
			End If

		Else
			cmsPMList.Enabled = False

		End If

	End Sub

	Private Sub cmsMachineList_Opened(sender As Object, e As EventArgs) Handles cmsMachineList.Opened

		If lvwMachine.SelectedItems.Count = 1 Then
			cmsMachineList.Enabled = True
		Else
			cmsMachineList.Enabled = False
		End If

	End Sub

	Private Sub cmsPartList_Opened(sender As Object, e As EventArgs) Handles cmsPartList.Opened

		If lvwPartList.SelectedItems.Count = 1 Then
			cmsPartList.Enabled = True
		Else
			cmsPartList.Enabled = False
		End If

	End Sub

	Private Sub cmsPMHistoryList_Opened(sender As Object, e As EventArgs) Handles cmsPMHistoryList.Opened

		If lvwPMHistoryList.SelectedItems.Count = 1 Then
			cmsPMHistoryList.Enabled = True
		Else
			cmsPMHistoryList.Enabled = False
		End If

	End Sub

	Private Sub tbxSearch_GotFocus(sender As Object, e As EventArgs) Handles tbxMachineSearch.GotFocus, tbxPartSearch.GotFocus, tbxPMSearch.GotFocus

		Dim tbxSearch As TextBox = DirectCast(sender, TextBox)
		tbxSearch.SelectAll()

	End Sub
End Class