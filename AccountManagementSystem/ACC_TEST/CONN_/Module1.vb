Imports System.IO
Imports System.Data.SqlClient
Module Module1
    Public number_day___ As Integer = 0
    Public show___ As String
    Public name___name As String
    Public guid_user_log As String = File.ReadAllText("c:\CONN\txt_g.TXT")
    Public TXT_CON___ As String = File.ReadAllText("c:\CONN\CONN_SERVER.TXT")
    Public Con_SERVER As New SqlConnection(TXT_CON___)
    Public TXT_CON___CONFIG As String = File.ReadAllText("c:\CONN\CONFIG.TXT")
    Public CON_CONFIG As New SqlConnection(TXT_CON___CONFIG)
End Module
