Public Class frmDBConnect

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

	Sub InitEnv()

		If My.Settings.Host <> "" Then tbxHost.Text = My.Settings.Host
		If My.Settings.Database <> "" Then tbxDatabase.Text = My.Settings.Database
		If My.Settings.Username <> "" Then tbxUsername.Text = My.Settings.Username

	End Sub

	Private Sub frmDBConnect_Load(sender As Object, e As EventArgs) Handles MyBase.Load

		InitEnv()

	End Sub
	Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click

		Application.Exit()

	End Sub

	Private Sub btnConnect_Click(sender As Object, e As EventArgs) Handles btnConnect.Click

		Dim DBConnectInfoA As DBConnectInfo
		DBConnectInfoA.Host = tbxHost.Text.Trim
		DBConnectInfoA.Database = tbxDatabase.Text.Trim
		DBConnectInfoA.Username = tbxUsername.Text.Trim
		DBConnectInfoA.Password = tbxPassword.Text.Trim

		If TestConnection(DBConnectInfoA) Then
			My.Settings.Host = DBConnectInfoA.Host
			My.Settings.Database = DBConnectInfoA.Database
			My.Settings.Username = DBConnectInfoA.Username
			My.Settings.Password = DBConnectInfoA.Password

			frmMain.Show()
			Me.Hide()
		End If

	End Sub

	Private Sub tbx_GotFocus(sender As Object, e As EventArgs) Handles tbxHost.GotFocus

		Dim tbx As TextBox = DirectCast(sender, TextBox)
		tbx.SelectAll()

	End Sub

	Private Sub tbx_LostFocus(sender As Object, e As EventArgs) Handles tbxHost.LostFocus, tbxDatabase.LostFocus, tbxUsername.LostFocus, tbxPassword.LostFocus

		Dim tbx As TextBox = DirectCast(sender, TextBox)
		tbx.Text = tbx.Text.Replace(" ", "").Trim

	End Sub

	Private Sub tbxPassword_KeyDown(sender As Object, e As KeyEventArgs) Handles tbxPassword.KeyDown

		If e.KeyCode = Keys.Enter Then
			e.SuppressKeyPress = True
			e.Handled = True
			btnConnect_Click(Nothing, Nothing)
		End If

	End Sub
End Class
