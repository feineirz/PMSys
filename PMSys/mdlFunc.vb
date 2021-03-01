Imports MySql.Data.MySqlClient
Module mdlFunc

	Structure DBConnectInfo
		Dim Host As String
		Dim Database As String
		Dim Username As String
		Dim Password As String
	End Structure
	Public Function TestConnection(DBConnectInfoA As DBConnectInfo) As Boolean

		Dim connString As String = "host=" + DBConnectInfoA.Host + ";database=" + DBConnectInfoA.Database + ";user id=" + DBConnectInfoA.Username + ";password=" + DBConnectInfoA.Password + ";"
		Dim conn = New MySqlConnection(connString)

		Try

			conn.Open()
			conn.Close()
			Return True

		Catch ex As Exception
			MsgBox(ex.Message)
			Return False

		End Try

	End Function

End Module
