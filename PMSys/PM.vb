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

Public Class PM

'============================== Class Header =============================='

#Region "Class Header"

	Private Shared ConnString As String = "Server=10.13.1.10;Database=PMSys;Uid=dbadmin;Pwd=v9bdko9Nx;"
	Private Shared tableName As String = "PM"

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

	Private _pm_id As Integer
	Private _pm_type As String
	Private _machine_id As Integer
	Private _part_id As Integer
	Private _unit_require As Integer
	Private _frequency As Integer
	Private _pm_action As String
	Private _last_pm As String
	Private _next_pm As Date
	Private _remark As String

	Structure PMInfo
		Dim pm_id As Integer
		Dim pm_type As String
		Dim machine_id As Integer
		Dim part_id As Integer
		Dim unit_require As Integer
		Dim frequency As Integer
		Dim pm_action As String
		Dim last_pm As String
		Dim next_pm As Date
		Dim remark As String
	End Structure

	'------------ CONSTRUCTOR ------------'
	Sub New(PM_pm_id As String, Optional SQLConn As MySqlConnection = Nothing)

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
						" WHERE pm_id = '" & PM_pm_id & "'"

			CMD = New MySqlCommand(QRY, SQLConn)
			RD = CMD.ExecuteReader

			If RD.HasRows Then
				While RD.Read
					_pm_id = RD!pm_id
					_pm_type = RD!pm_type
					_machine_id = RD!machine_id
					_part_id = RD!part_id
					_unit_require = RD!unit_require
					_frequency = RD!frequency
					_pm_action = RD!pm_action
					_last_pm = RD!last_pm
					_next_pm = RD!next_pm
					_remark = RD!remark
				End While
			End If
			If autoCloseConnection Then SQLConn.Close()

		Catch ex As Exception
			If autoCloseConnection Then SQLConn.Close()
			MsgBox("[Error] Sub : PM.New" & vbCrLf & ex.Message)

		End Try

	End Sub

#End Region

'============================== Class Properties =============================='

#Region "Class Properties"

  '--- pm_id ---'
  ReadOnly Property pm_id As Integer
    Get
      Return _pm_id
    End Get
  End Property

  '--- pm_type ---'
  Property pm_type As String
    Get
      Return _pm_type
    End Get
    Set(ByVal value As String)
      _QRY = "UPDATE " & tableName &
             " SET pm_type = '" & value & "'" &
             " WHERE pm_id = '" & _pm_id & "'"

      Try
        _SQLConn.Open()
        _CMD = New MySqlCommand(_QRY, _SQLConn)
        _CMD.ExecuteNonQuery()
        _SQLConn.Close()

      Catch ex As Exception
        _SQLConn.Close()
        MsgBox("[Error] Property : PM.pm_type" & vbCrLf & ex.Message, , "Error")

      End Try

      _pm_type = value
    End Set
  End Property

  '--- machine_id ---'
  Property machine_id As Integer
    Get
      Return _machine_id
    End Get
    Set(ByVal value As Integer)
      _QRY = "UPDATE " & tableName &
             " SET machine_id = '" & value & "'" &
             " WHERE pm_id = '" & _pm_id & "'"

      Try
        _SQLConn.Open()
        _CMD = New MySqlCommand(_QRY, _SQLConn)
        _CMD.ExecuteNonQuery()
        _SQLConn.Close()

      Catch ex As Exception
        _SQLConn.Close()
        MsgBox("[Error] Property : PM.machine_id" & vbCrLf & ex.Message, , "Error")

      End Try

      _machine_id = value
    End Set
  End Property

  '--- part_id ---'
  Property part_id As Integer
    Get
      Return _part_id
    End Get
    Set(ByVal value As Integer)
      _QRY = "UPDATE " & tableName &
             " SET part_id = '" & value & "'" &
             " WHERE pm_id = '" & _pm_id & "'"

      Try
        _SQLConn.Open()
        _CMD = New MySqlCommand(_QRY, _SQLConn)
        _CMD.ExecuteNonQuery()
        _SQLConn.Close()

      Catch ex As Exception
        _SQLConn.Close()
        MsgBox("[Error] Property : PM.part_id" & vbCrLf & ex.Message, , "Error")

      End Try

      _part_id = value
    End Set
  End Property

  '--- unit_require ---'
  Property unit_require As Integer
    Get
      Return _unit_require
    End Get
    Set(ByVal value As Integer)
      _QRY = "UPDATE " & tableName &
             " SET unit_require = '" & value & "'" &
             " WHERE pm_id = '" & _pm_id & "'"

      Try
        _SQLConn.Open()
        _CMD = New MySqlCommand(_QRY, _SQLConn)
        _CMD.ExecuteNonQuery()
        _SQLConn.Close()

      Catch ex As Exception
        _SQLConn.Close()
        MsgBox("[Error] Property : PM.unit_require" & vbCrLf & ex.Message, , "Error")

      End Try

      _unit_require = value
    End Set
  End Property

  '--- frequency ---'
  Property frequency As Integer
    Get
      Return _frequency
    End Get
    Set(ByVal value As Integer)
      _QRY = "UPDATE " & tableName &
             " SET frequency = '" & value & "'" &
             " WHERE pm_id = '" & _pm_id & "'"

      Try
        _SQLConn.Open()
        _CMD = New MySqlCommand(_QRY, _SQLConn)
        _CMD.ExecuteNonQuery()
        _SQLConn.Close()

      Catch ex As Exception
        _SQLConn.Close()
        MsgBox("[Error] Property : PM.frequency" & vbCrLf & ex.Message, , "Error")

      End Try

      _frequency = value
    End Set
  End Property

  '--- pm_action ---'
  Property pm_action As String
    Get
      Return _pm_action
    End Get
    Set(ByVal value As String)
      _QRY = "UPDATE " & tableName &
             " SET pm_action = '" & value & "'" &
             " WHERE pm_id = '" & _pm_id & "'"

      Try
        _SQLConn.Open()
        _CMD = New MySqlCommand(_QRY, _SQLConn)
        _CMD.ExecuteNonQuery()
        _SQLConn.Close()

      Catch ex As Exception
        _SQLConn.Close()
        MsgBox("[Error] Property : PM.pm_action" & vbCrLf & ex.Message, , "Error")

      End Try

      _pm_action = value
    End Set
  End Property

  '--- last_pm ---'
  Property last_pm As String
    Get
      Return _last_pm
    End Get
    Set(ByVal value As String)
      _QRY = "UPDATE " & tableName &
             " SET last_pm = '" & value & "'" &
             " WHERE pm_id = '" & _pm_id & "'"

      Try
        _SQLConn.Open()
        _CMD = New MySqlCommand(_QRY, _SQLConn)
        _CMD.ExecuteNonQuery()
        _SQLConn.Close()

      Catch ex As Exception
        _SQLConn.Close()
        MsgBox("[Error] Property : PM.last_pm" & vbCrLf & ex.Message, , "Error")

      End Try

      _last_pm = value
    End Set
  End Property

  '--- next_pm ---'
  Property next_pm As Date
    Get
      Return _next_pm
    End Get
    Set(ByVal value As Date)
      _QRY = "UPDATE " & tableName &
             " SET next_pm = '" & value.ToString("yyyy-M-d") & "'" &
             " WHERE pm_id = '" & _pm_id & "'"

      Try
        _SQLConn.Open()
        _CMD = New MySqlCommand(_QRY, _SQLConn)
        _CMD.ExecuteNonQuery()
        _SQLConn.Close()

      Catch ex As Exception
        _SQLConn.Close()
        MsgBox("[Error] Property : PM.next_pm" & vbCrLf & ex.Message, , "Error")

      End Try

      _next_pm = value
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
             " WHERE pm_id = '" & _pm_id & "'"

      Try
        _SQLConn.Open()
        _CMD = New MySqlCommand(_QRY, _SQLConn)
        _CMD.ExecuteNonQuery()
        _SQLConn.Close()

      Catch ex As Exception
        _SQLConn.Close()
        MsgBox("[Error] Property : PM.remark" & vbCrLf & ex.Message, , "Error")

      End Try

      _remark = value
    End Set
  End Property

#End Region

'============================== Required Function =============================='

#Region "Required Function"

	'---------- ADD ----------'
	Shared Function Add(ByVal PMInfoA As PMInfo, Optional SQLConn As MySqlConnection = Nothing) As Boolean

		Dim autoCloseConnection As Boolean = False
		If SQLConn Is Nothing Then
			SQLConn = New MySqlConnection(ConnString)
			SQLConn.Open()
			autoCloseConnection = True
		End If

		Dim CMD As MySqlCommand
		Dim QRY As String

		Try
			QRY = "INSERT INTO " & tableName & "(pm_id, pm_type, machine_id, part_id, unit_require, frequency, pm_action, last_pm, next_pm, remark)" &
						" VALUES(@pm_id, @pm_type, @machine_id, @part_id, @unit_require, @frequency, @pm_action, @last_pm, @next_pm, @remark)"

			CMD = New MySqlCommand(QRY, SQLConn)

			CMD.Parameters.AddWithValue("@pm_id", PMInfoA.pm_id)
			CMD.Parameters.AddWithValue("@pm_type", PMInfoA.pm_type)
			CMD.Parameters.AddWithValue("@machine_id", PMInfoA.machine_id)
			CMD.Parameters.AddWithValue("@part_id", PMInfoA.part_id)
			CMD.Parameters.AddWithValue("@unit_require", PMInfoA.unit_require)
			CMD.Parameters.AddWithValue("@frequency", PMInfoA.frequency)
			CMD.Parameters.AddWithValue("@pm_action", PMInfoA.pm_action)
			CMD.Parameters.AddWithValue("@last_pm", PMInfoA.last_pm)
			CMD.Parameters.AddWithValue("@next_pm", PMInfoA.next_pm)
			CMD.Parameters.AddWithValue("@remark", PMInfoA.remark)

			CMD.ExecuteNonQuery()
			If autoCloseConnection Then SQLConn.Close()

		Catch ex As Exception
			If autoCloseConnection Then SQLConn.Close()
			MsgBox("[Error] Function : PM.Add" & vbCrLf & ex.Message)
			Return False

		End Try

		Return True

	End Function

	'---------- UPDATE ----------'	
	Shared Function Update(ByVal PMInfoA As PMInfo, Optional SQLConn As MySqlConnection = Nothing) As Boolean

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
					" pm_type = @pm_type," &
					" machine_id = @machine_id," &
					" part_id = @part_id," &
					" unit_require = @unit_require," &
					" frequency = @frequency," &
					" pm_action = @pm_action," &
					" last_pm = @last_pm," &
					" next_pm = @next_pm," &
					" remark = @remark" &
					" WHERE pm_id='" & PMInfoA.pm_id & "'"

			CMD = New MySqlCommand(QRY, SQLConn)

			CMD.Parameters.AddWithValue("@pm_type", PMInfoA.pm_type)
			CMD.Parameters.AddWithValue("@machine_id", PMInfoA.machine_id)
			CMD.Parameters.AddWithValue("@part_id", PMInfoA.part_id)
			CMD.Parameters.AddWithValue("@unit_require", PMInfoA.unit_require)
			CMD.Parameters.AddWithValue("@frequency", PMInfoA.frequency)
			CMD.Parameters.AddWithValue("@pm_action", PMInfoA.pm_action)
			CMD.Parameters.AddWithValue("@last_pm", PMInfoA.last_pm)
			CMD.Parameters.AddWithValue("@next_pm", PMInfoA.next_pm)
			CMD.Parameters.AddWithValue("@remark", PMInfoA.remark)

			CMD.ExecuteNonQuery()
			If autoCloseConnection Then SQLConn.Close()

		Catch ex As Exception
			If autoCloseConnection Then SQLConn.Close()
			MsgBox("[Error] Function : PM.Update" & vbCrLf & ex.Message)
			Return False

		End Try

		Return True

	End Function

	'---------- DELETE ----------'
	Shared Function Delete(ByVal PM_pm_id As String, Optional SQLConn As MySqlConnection = Nothing) As Boolean

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
						" WHERE pm_id='" & PM_pm_id & "'"

			CMD = New MySqlCommand(QRY, SQLConn)
			CMD.ExecuteNonQuery()
			If autoCloseConnection Then SQLConn.Close()

		Catch ex As Exception
			If autoCloseConnection Then SQLConn.Close()
			MsgBox("[Error] Function : PM.Delete" & vbCrLf & ex.Message)
			Return False

		End Try

		Return True

	End Function

	'----- Structure for LIST -----'
	Structure ListItem
		Dim Items() As PMInfo
		Dim Count As Integer
	End Structure

	'---------- LIST ----------'
	Shared Function List(Optional ByVal Query As String = "", Optional ByVal Condition As String = "", Optional ByVal SortOrder As String = "pm_id", Optional SQLConn As MySqlConnection = Nothing) As ListItem

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
		Dim PMInfoA() As PMInfo = Nothing

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
					ReDim Preserve PMInfoA(Ix)

					PMInfoA(Ix).pm_id = RD!pm_id
					PMInfoA(Ix).pm_type = RD!pm_type
					PMInfoA(Ix).machine_id = RD!machine_id
					PMInfoA(Ix).part_id = RD!part_id
					PMInfoA(Ix).unit_require = RD!unit_require
					PMInfoA(Ix).frequency = RD!frequency
					PMInfoA(Ix).pm_action = RD!pm_action
					PMInfoA(Ix).last_pm = RD!last_pm
					PMInfoA(Ix).next_pm = RD!next_pm
					PMInfoA(Ix).remark = RD!remark

					Ix += 1
				End While
			End If

			If autoCloseConnection Then SQLConn.Close()

			ListItemA.Items = PMInfoA
			ListItemA.Count = Ix

		Catch ex As Exception
			If autoCloseConnection Then SQLConn.Close()
			ListItemA.Count = 0
			MsgBox("[Error] Function : PM.List" & vbCrLf & ex.Message)

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
	Shared Function ToComboBoxItems(ByRef RefCMB As ComboBox, DisplayMember As String, ValueMember As String, Optional subDisplayMember As String = "", Optional Delimeter As String = " : ", Optional ByVal Condition As String = "", Optional ByVal SortOrder As String = "pm_id", Optional SQLConn As MySqlConnection = Nothing) As List(Of ComboBoxItems)

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
			MsgBox("[Error] Function : PM.ToComboBoxItems" & vbCrLf & ex.Message)

		End Try

		RefCMB.DisplayMember = "DisplayMember"
		RefCMB.ValueMember = "ValueMember"
		RefCMB.DataSource = cmbItems

		Return cmbItems

	End Function

  '---------- TOCLASSINFO ----------'
  Function ToPMInfo() As PMInfo

    Dim CI As PMInfo = Nothing

		CI.pm_id = _pm_id
		CI.pm_type = _pm_type
		CI.machine_id = _machine_id
		CI.part_id = _part_id
		CI.unit_require = _unit_require
		CI.frequency = _frequency
		CI.pm_action = _pm_action
		CI.last_pm = _last_pm
		CI.next_pm = _next_pm
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
			QRY = "SELECT COUNT(pm_id) " & _
						" FROM PM " & _
						" WHERE " & Condition

			CMD = New MySqlCommand(QRY, SQLConn)
			recCount = CMD.ExecuteScalar
			If autoCloseConnection Then SQLConn.Close()

		Catch ex As Exception
			If autoCloseConnection Then SQLConn.Close()
			MsgBox("[Error] Function : PM.Count" & vbCrLf & ex.Message)

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
			MsgBox("[Error] Function : PM.ClearTable" & vbCrLf & ex.Message)
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
