'##################################################################'
'This Class automatically generated by FeiNz's SQL Class Generator.
'Credit: FeiNz.net [feineriz@live.com]
'##################################################################'

Imports System.Drawing
Imports System.IO
Imports MySql.Data.MySqlClient
Imports System.Windows.Forms

'If this line above is shows error, please download
'[MySQL Connector for .NET] from http://dev.mysql.com/downloads/connector/net/
'and import reference to the project.

Public Class PMHistory

	'============================== Class Header =============================='

#Region "Class Header"

	Private Shared ConnString As String = "Server=" + My.Settings.Host + ";Database=" + My.Settings.Database + ";Uid=" + My.Settings.Username + ";Pwd=" + My.Settings.Password + ";"
	Private Shared tableName As String = "PM_History"

	Private _SQLConn As New MySqlConnection(ConnString)
	Private _CMD As MySqlCommand
	Private _QRY As String

	Shared Function BytesToImage(ByVal ImageBytes() As Byte) As Image

		Dim IMG As Image
		Dim MS As New MemoryStream(ImageBytes)

		IMG = Image.FromStream(MS)
		Return IMG

	End Function

	Shared Function ImageToBytes(ByVal Image As Image) As Byte()

		Dim MS As New MemoryStream
		Dim BT() As Byte

		Image.Save(MS, Image.RawFormat)
		BT = MS.GetBuffer()
		Return BT

	End Function

	Shared Function GetMySQLConnection As MySqlConnection

		Try
			Dim SQLConn As New MySqlConnection(ConnString)
			SQLConn.Open()
			Return SQLConn

		Catch ex As Exception
			Return Nothing

		End Try

	End Function 

	Private _pm_history_id As Integer
	Private _pm_id As Integer
	Private _reporter As String
	Private _operator_name As String
	Private _pm_date As Date
	Private _report_date As DateTime
	Private _pm_details As String
	Private _pm_result As String
	Private _remark As String

	Structure PMHistoryInfo
		Dim pm_history_id As Integer
		Dim pm_id As Integer
		Dim reporter As String
		Dim operator_name As String
		Dim pm_date As Date
		Dim report_date As DateTime
		Dim pm_details As String
		Dim pm_result As String
		Dim remark As String
	End Structure

	'------------ CONSTRUCTOR ------------'
	Sub New(PMHistory_pm_history_id As String, Optional SQLConn As MySqlConnection = Nothing)

		Dim autoCloseConnection As Boolean = False
		If SQLConn Is Nothing Then
			SQLConn = New MySqlConnection(ConnString)
			SQLConn.Open()
			autoCloseConnection = True
		End If

		Dim CMD As MySqlCommand
		Dim RD As MySqlDataReader
		Dim QRY As String

		Try
			QRY = "SELECT *" &
						" FROM " & tableName &
						" WHERE pm_history_id = '" & PMHistory_pm_history_id & "'"

			CMD = New MySqlCommand(QRY, SQLConn)
			RD = CMD.ExecuteReader

			If RD.HasRows Then
				While RD.Read
					_pm_history_id = RD!pm_history_id
					_pm_id = RD!pm_id
					_reporter = RD!reporter
					_operator_name = RD!operator_name
					_pm_date = RD!pm_date
					_report_date = RD!report_date
					_pm_details = RD!pm_details
					_pm_result = RD!pm_result
					_remark = RD!remark
				End While
			End If
			If autoCloseConnection Then SQLConn.Close()

		Catch ex As Exception
			If autoCloseConnection Then SQLConn.Close()
			MsgBox("[Error] Sub : PMHistory.New" & vbCrLf & ex.Message)

		End Try

	End Sub

#End Region

'============================== Class Properties =============================='

#Region "Class Properties"

  '--- pm_history_id ---'
  ReadOnly Property pm_history_id As Integer
    Get
      Return _pm_history_id
    End Get
  End Property

  '--- pm_id ---'
  Property pm_id As Integer
    Get
      Return _pm_id
    End Get
    Set(ByVal value As Integer)
      _QRY = "UPDATE " & tableName &
             " SET pm_id = '" & value & "'" &
             " WHERE pm_history_id = '" & _pm_history_id & "'"

      Try
        _SQLConn.Open()
        _CMD = New MySqlCommand(_QRY, _SQLConn)
        _CMD.ExecuteNonQuery()
        _SQLConn.Close()

      Catch ex As Exception
        _SQLConn.Close()
        MsgBox("[Error] Property : PMHistory.pm_id" & vbCrLf & ex.Message, , "Error")

      End Try

      _pm_id = value
    End Set
  End Property

  '--- reporter ---'
  Property reporter As String
    Get
      Return _reporter
    End Get
    Set(ByVal value As String)
      _QRY = "UPDATE " & tableName &
             " SET reporter = '" & value & "'" &
             " WHERE pm_history_id = '" & _pm_history_id & "'"

      Try
        _SQLConn.Open()
        _CMD = New MySqlCommand(_QRY, _SQLConn)
        _CMD.ExecuteNonQuery()
        _SQLConn.Close()

      Catch ex As Exception
        _SQLConn.Close()
        MsgBox("[Error] Property : PMHistory.reporter" & vbCrLf & ex.Message, , "Error")

      End Try

      _reporter = value
    End Set
  End Property

  '--- operator_name ---'
  Property operator_name As String
    Get
      Return _operator_name
    End Get
    Set(ByVal value As String)
      _QRY = "UPDATE " & tableName &
             " SET operator_name = '" & value & "'" &
             " WHERE pm_history_id = '" & _pm_history_id & "'"

      Try
        _SQLConn.Open()
        _CMD = New MySqlCommand(_QRY, _SQLConn)
        _CMD.ExecuteNonQuery()
        _SQLConn.Close()

      Catch ex As Exception
        _SQLConn.Close()
        MsgBox("[Error] Property : PMHistory.operator_name" & vbCrLf & ex.Message, , "Error")

      End Try

      _operator_name = value
    End Set
  End Property

  '--- pm_date ---'
  Property pm_date As Date
    Get
      Return _pm_date
    End Get
    Set(ByVal value As Date)
      _QRY = "UPDATE " & tableName &
             " SET pm_date = '" & value.ToString("yyyy-M-d") & "'" &
             " WHERE pm_history_id = '" & _pm_history_id & "'"

      Try
        _SQLConn.Open()
        _CMD = New MySqlCommand(_QRY, _SQLConn)
        _CMD.ExecuteNonQuery()
        _SQLConn.Close()

      Catch ex As Exception
        _SQLConn.Close()
        MsgBox("[Error] Property : PMHistory.pm_date" & vbCrLf & ex.Message, , "Error")

      End Try

      _pm_date = value
    End Set
  End Property

  '--- report_date ---'
  Property report_date As DateTime
    Get
      Return _report_date
    End Get
    Set(ByVal value As DateTime)
      _QRY = "UPDATE " & tableName &
             " SET report_date = '" & value.ToString("yyyy-M-d H:m:s") & "'" &
             " WHERE pm_history_id = '" & _pm_history_id & "'"

      Try
        _SQLConn.Open()
        _CMD = New MySqlCommand(_QRY, _SQLConn)
        _CMD.ExecuteNonQuery()
        _SQLConn.Close()

      Catch ex As Exception
        _SQLConn.Close()
        MsgBox("[Error] Property : PMHistory.report_date" & vbCrLf & ex.Message, , "Error")

      End Try

      _report_date = value
    End Set
  End Property

  '--- pm_details ---'
  Property pm_details As String
    Get
      Return _pm_details
    End Get
    Set(ByVal value As String)
      _QRY = "UPDATE " & tableName &
             " SET pm_details = '" & value & "'" &
             " WHERE pm_history_id = '" & _pm_history_id & "'"

      Try
        _SQLConn.Open()
        _CMD = New MySqlCommand(_QRY, _SQLConn)
        _CMD.ExecuteNonQuery()
        _SQLConn.Close()

      Catch ex As Exception
        _SQLConn.Close()
        MsgBox("[Error] Property : PMHistory.pm_details" & vbCrLf & ex.Message, , "Error")

      End Try

      _pm_details = value
    End Set
  End Property

  '--- pm_result ---'
  Property pm_result As String
    Get
      Return _pm_result
    End Get
    Set(ByVal value As String)
      _QRY = "UPDATE " & tableName &
             " SET pm_result = '" & value & "'" &
             " WHERE pm_history_id = '" & _pm_history_id & "'"

      Try
        _SQLConn.Open()
        _CMD = New MySqlCommand(_QRY, _SQLConn)
        _CMD.ExecuteNonQuery()
        _SQLConn.Close()

      Catch ex As Exception
        _SQLConn.Close()
        MsgBox("[Error] Property : PMHistory.pm_result" & vbCrLf & ex.Message, , "Error")

      End Try

      _pm_result = value
    End Set
  End Property

  '--- remark ---'
  Property remark As String
    Get
      Return _remark
    End Get
    Set(ByVal value As String)
      _QRY = "UPDATE " & tableName &
             " SET remark = '" & value & "'" &
             " WHERE pm_history_id = '" & _pm_history_id & "'"

      Try
        _SQLConn.Open()
        _CMD = New MySqlCommand(_QRY, _SQLConn)
        _CMD.ExecuteNonQuery()
        _SQLConn.Close()

      Catch ex As Exception
        _SQLConn.Close()
        MsgBox("[Error] Property : PMHistory.remark" & vbCrLf & ex.Message, , "Error")

      End Try

      _remark = value
    End Set
  End Property

#End Region

'============================== Required Function =============================='

#Region "Required Function"

	'---------- ADD ----------'
	Shared Function Add(ByVal PMHistoryInfoA As PMHistoryInfo, Optional SQLConn As MySqlConnection = Nothing) As Boolean

		Dim autoCloseConnection As Boolean = False
		If SQLConn Is Nothing Then
			SQLConn = New MySqlConnection(ConnString)
			SQLConn.Open()
			autoCloseConnection = True
		End If

		Dim CMD As MySqlCommand
		Dim QRY As String

		Try
			QRY = "INSERT INTO " & tableName & "(pm_history_id, pm_id, reporter, operator_name, pm_date, report_date, pm_details, pm_result, remark)" &
						" VALUES(@pm_history_id, @pm_id, @reporter, @operator_name, @pm_date, @report_date, @pm_details, @pm_result, @remark)"

			CMD = New MySqlCommand(QRY, SQLConn)

			CMD.Parameters.AddWithValue("@pm_history_id", PMHistoryInfoA.pm_history_id)
			CMD.Parameters.AddWithValue("@pm_id", PMHistoryInfoA.pm_id)
			CMD.Parameters.AddWithValue("@reporter", PMHistoryInfoA.reporter)
			CMD.Parameters.AddWithValue("@operator_name", PMHistoryInfoA.operator_name)
			CMD.Parameters.AddWithValue("@pm_date", PMHistoryInfoA.pm_date)
			CMD.Parameters.AddWithValue("@report_date", PMHistoryInfoA.report_date)
			CMD.Parameters.AddWithValue("@pm_details", PMHistoryInfoA.pm_details)
			CMD.Parameters.AddWithValue("@pm_result", PMHistoryInfoA.pm_result)
			CMD.Parameters.AddWithValue("@remark", PMHistoryInfoA.remark)

			CMD.ExecuteNonQuery()
			If autoCloseConnection Then SQLConn.Close()

		Catch ex As Exception
			If autoCloseConnection Then SQLConn.Close()
			MsgBox("[Error] Function : PMHistory.Add" & vbCrLf & ex.Message)
			Return False

		End Try

		Return True

	End Function

	'---------- UPDATE ----------'	
	Shared Function Update(ByVal PMHistoryInfoA As PMHistoryInfo, Optional SQLConn As MySqlConnection = Nothing) As Boolean

		Dim autoCloseConnection As Boolean = False
		If SQLConn Is Nothing Then
			SQLConn = New MySqlConnection(ConnString)
			SQLConn.Open()
			autoCloseConnection = True
		End If

		Dim CMD As MySqlCommand
		Dim QRY As String

		Try
			QRY = "UPDATE " & tableName &
					" SET" &
					" pm_id = @pm_id," &
					" reporter = @reporter," &
					" operator_name = @operator_name," &
					" pm_date = @pm_date," &
					" report_date = @report_date," &
					" pm_details = @pm_details," &
					" pm_result = @pm_result," &
					" remark = @remark" &
					" WHERE pm_history_id='" & PMHistoryInfoA.pm_history_id & "'"

			CMD = New MySqlCommand(QRY, SQLConn)

			CMD.Parameters.AddWithValue("@pm_id", PMHistoryInfoA.pm_id)
			CMD.Parameters.AddWithValue("@reporter", PMHistoryInfoA.reporter)
			CMD.Parameters.AddWithValue("@operator_name", PMHistoryInfoA.operator_name)
			CMD.Parameters.AddWithValue("@pm_date", PMHistoryInfoA.pm_date)
			CMD.Parameters.AddWithValue("@report_date", PMHistoryInfoA.report_date)
			CMD.Parameters.AddWithValue("@pm_details", PMHistoryInfoA.pm_details)
			CMD.Parameters.AddWithValue("@pm_result", PMHistoryInfoA.pm_result)
			CMD.Parameters.AddWithValue("@remark", PMHistoryInfoA.remark)

			CMD.ExecuteNonQuery()
			If autoCloseConnection Then SQLConn.Close()

		Catch ex As Exception
			If autoCloseConnection Then SQLConn.Close()
			MsgBox("[Error] Function : PMHistory.Update" & vbCrLf & ex.Message)
			Return False

		End Try

		Return True

	End Function

	'---------- DELETE ----------'
	Shared Function Delete(ByVal PMHistory_pm_history_id As String, Optional SQLConn As MySqlConnection = Nothing) As Boolean

		Dim autoCloseConnection As Boolean = False
		If SQLConn Is Nothing Then
			SQLConn = New MySqlConnection(ConnString)
			SQLConn.Open()
			autoCloseConnection = True
		End If

		Dim CMD As MySqlCommand
		Dim QRY As String

		Try		
			QRY = "DELETE FROM" &
						" " & tableName & 
						" WHERE pm_history_id='" & PMHistory_pm_history_id & "'"

			CMD = New MySqlCommand(QRY, SQLConn)
			CMD.ExecuteNonQuery()
			If autoCloseConnection Then SQLConn.Close()

		Catch ex As Exception
			If autoCloseConnection Then SQLConn.Close()
			MsgBox("[Error] Function : PMHistory.Delete" & vbCrLf & ex.Message)
			Return False

		End Try

		Return True

	End Function

	'----- Structure for LIST -----'
	Structure ListItem
		Dim Items() As PMHistoryInfo
		Dim Count As Integer
	End Structure

	'---------- LIST ----------'
	Shared Function List(Optional ByVal Query As String = "", Optional ByVal Condition As String = "", Optional ByVal SortOrder As String = "pm_history_id", Optional SQLConn As MySqlConnection = Nothing) As ListItem

		If Not Condition = "" Then Condition = " WHERE " & Condition
		If Not SortOrder = "" Then SortOrder = " ORDER BY " & SortOrder

		Dim autoCloseConnection As Boolean = False
		If SQLConn Is Nothing Then
			SQLConn = New MySqlConnection(ConnString)
			SQLConn.Open()
			autoCloseConnection = True
		End If

		Dim CMD As MySqlCommand
		Dim RD As MySqlDataReader
		Dim QRY As String

		Dim ListItemA As ListItem
		Dim PMHistoryInfoA() As PMHistoryInfo = Nothing

		ListItemA.Items = Nothing
		ListItemA.Count = 0

		Try
			If Not Query = "" Then
				QRY = Query
			Else
				QRY = "SELECT *" &
						" FROM " & tableName
			End If
				QRY &= Condition & SortOrder

			CMD = New MySqlCommand(QRY, SQLConn)
			RD = CMD.ExecuteReader
			Dim Ix As Integer = 0
			If RD.HasRows Then

				While RD.Read
					ReDim Preserve PMHistoryInfoA(Ix)

					PMHistoryInfoA(Ix).pm_history_id = RD!pm_history_id
					PMHistoryInfoA(Ix).pm_id = RD!pm_id
					PMHistoryInfoA(Ix).reporter = RD!reporter
					PMHistoryInfoA(Ix).operator_name = RD!operator_name
					PMHistoryInfoA(Ix).pm_date = RD!pm_date
					PMHistoryInfoA(Ix).report_date = RD!report_date
					PMHistoryInfoA(Ix).pm_details = RD!pm_details
					PMHistoryInfoA(Ix).pm_result = RD!pm_result
					PMHistoryInfoA(Ix).remark = RD!remark

					Ix += 1
				End While
			End If

			If autoCloseConnection Then SQLConn.Close()

			ListItemA.Items = PMHistoryInfoA
			ListItemA.Count = Ix

		Catch ex As Exception
			If autoCloseConnection Then SQLConn.Close()
			ListItemA.Count = 0
			MsgBox("[Error] Function : PMHistory.List" & vbCrLf & ex.Message)

		End Try

		Return ListItemA

	End Function

	'----- Class for TOCOMBOBOXITEMS -----'
	Public Class ComboBoxItems

		Private _DisplayMember As String
		Private _subDisplayMember As String
		Private _ValueMember As String

		Public Overrides Function ToString() As String
			Return _ValueMember
		End Function

		Public Function ToCodeName() As String
			Return _DisplayMember
		End Function

		Public Sub New(ByVal DisplayMember As String, ByVal ValueMember As String)
			_DisplayMember = DisplayMember
			_ValueMember = ValueMember
		End Sub
		Public ReadOnly Property DisplayMember() As String
			Get
				Return _DisplayMember
			End Get
		End Property

		Public ReadOnly Property ValueMember() As String
			Get
				Return _ValueMember
			End Get
		End Property

	End Class

	'---------- TOCOMBOBOXITEMS ----------'
	Shared Function ToComboBoxItems(ByRef RefCMB As ComboBox, DisplayMember As String, ValueMember As String, Optional subDisplayMember As String = "", Optional Delimeter As String = " : ", Optional ByVal Condition As String = "", Optional ByVal SortOrder As String = "pm_history_id", Optional SQLConn As MySqlConnection = Nothing) As List(Of ComboBoxItems)

		If Not Condition = "" Then Condition = " WHERE " & Condition
		If Not SortOrder = "" Then SortOrder = " ORDER BY " & SortOrder

		Dim autoCloseConnection As Boolean = False
		If SQLConn Is Nothing Then
			SQLConn = New MySqlConnection(ConnString)
			SQLConn.Open()
			autoCloseConnection = True
		End If

		Dim RD As MySqlDataReader
		Dim CMD As MySqlCommand
		Dim QRY As String

		Dim cmbItems = New List(Of ComboBoxItems)

		Try
			QRY = "SELECT * " &
						" FROM " & tableName &
						" " & Condition &
						" " & SortOrder

			CMD = New MySqlCommand(QRY, SQLConn)
			CMD.CommandTimeout = 30
			RD = CMD.ExecuteReader()

			If RD.HasRows = True Then
				While RD.Read()
					If Not subDisplayMember = "" Then
						Dim DM As String = RD.Item(DisplayMember) & Delimeter & RD.Item(subDisplayMember)
						Dim VM As String = RD.Item(ValueMember)
						cmbItems.Add(New ComboBoxItems(DM, VM))
					Else
						cmbItems.Add(New ComboBoxItems(RD.Item(DisplayMember), RD.Item(ValueMember)))
					End If
				End While
			End If

			If autoCloseConnection Then SQLConn.Close()

		Catch ex As Exception
			If autoCloseConnection Then SQLConn.Close()
			MsgBox("[Error] Function : PMHistory.ToComboBoxItems" & vbCrLf & ex.Message)

		End Try

		RefCMB.DisplayMember = "DisplayMember"
		RefCMB.ValueMember = "ValueMember"
		RefCMB.DataSource = cmbItems

		Return cmbItems

	End Function

  '---------- TOCLASSINFO ----------'
  Function ToPMHistoryInfo() As PMHistoryInfo

    Dim CI As PMHistoryInfo = Nothing

		CI.pm_history_id = _pm_history_id
		CI.pm_id = _pm_id
		CI.reporter = _reporter
		CI.operator_name = _operator_name
		CI.pm_date = _pm_date
		CI.report_date = _report_date
		CI.pm_details = _pm_details
		CI.pm_result = _pm_result
		CI.remark = _remark

    Return CI

  End Function

	'---------- COUNT ----------'
	Shared Function Count(ByVal Condition As String, Optional SQLConn As MySqlConnection = Nothing) As Integer

		Dim autoCloseConnection As Boolean = False
		If SQLConn Is Nothing Then
			SQLConn = New MySqlConnection(ConnString)
			SQLConn.Open()
			autoCloseConnection = True
		End If

		Dim CMD As MySqlCommand
		Dim recCount As Integer = 0
		Dim QRY As String

		Try
			QRY = "SELECT COUNT(pm_history_id) " & _
						" FROM PM_History " & _
						" WHERE " & Condition

			CMD = New MySqlCommand(QRY, SQLConn)
			recCount = CMD.ExecuteScalar
			If autoCloseConnection Then SQLConn.Close()

		Catch ex As Exception
			If autoCloseConnection Then SQLConn.Close()
			MsgBox("[Error] Function : PMHistory.Count" & vbCrLf & ex.Message)

		End Try

		Return recCount

	End Function

	'---------- CLEAR TABLE ----------'
	Shared Function ClearTable(Optional SQLConn As MySqlConnection = Nothing) As Boolean

		Dim autoCloseConnection As Boolean = False
		If SQLConn Is Nothing Then
			SQLConn = New MySqlConnection(ConnString)
			SQLConn.Open()
			autoCloseConnection = True
		End If

		Dim CMD As MySqlCommand
		Dim QRY As String

		Try

			QRY = "DELETE FROM" &
					" " & tableName

			CMD = New MySqlCommand(QRY, SQLConn)
			CMD.ExecuteNonQuery()

			QRY = "ALTER TABLE " & tableName & " AUTO_INCREMENT = 0"
			CMD = New MySqlCommand(QRY, SQLConn)
			CMD.ExecuteNonQuery()

			If autoCloseConnection Then SQLConn.Close()

		Catch ex As Exception
			If autoCloseConnection Then SQLConn.Close()
			MsgBox("[Error] Function : PMHistory.ClearTable" & vbCrLf & ex.Message)
			Return False

		End Try

		Return True

	End Function

#End Region

'============================== Custom Functions =============================='

#Region "Custom Functions"

  '-----------------------------------------------'
  '---------- ADD CUSTOM FUNCTIONS HERE ----------'
  '-----------------------------------------------'
  '---- DO NOT COPY OR PASTE ON THIS SECTION -----'
  '-----------------------------------------------'




#End Region

End Class
