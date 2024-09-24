Imports System.Data.SqlClient
Imports System.IO
Public Class DataAccessLayer
    Dim SqlCon As SqlConnection

    Public Sub New()
        'SqlCon = New SqlConnection("Data Source=SQL5033.myASP.NET;Initial Catalog=DB_A16609_yosefhadad00000;User Id=DB_A16609_yosefhadad00000_admin;Password=yosefhadad00000;")
        SqlCon = New SqlConnection(File.ReadAllText("c:\CONN\CONN.TXT"))
    End Sub
    Public Sub Connect()
        If SqlCon.State <> ConnectionState.Open Then
            SqlCon.Open()
        End If
    End Sub
    Public Sub Disconnect()
        If SqlCon.State <> ConnectionState.Closed Then
            SqlCon.Close()
        End If
    End Sub


    Public Sub ExecuteCommand(ByVal TXT_ As String, ByVal Param() As SqlParameter)
        Connect()
        Dim cmd As New SqlCommand(TXT_, SqlCon)
        cmd.CommandType = Data.CommandType.Text
        If Not Param Is Nothing Then
            For i As Integer = 0 To Param.Length - 1
                cmd.Parameters.Add(Param(i))
            Next
        End If
        cmd.ExecuteNonQuery()
        Disconnect()
    End Sub
    Public Function SelectData(ByVal TXT_ As String, ByVal Param() As SqlParameter) As DataTable
        Dim cmd As New SqlCommand(TXT_, SqlCon)
        cmd.CommandType = CommandType.Text
        If Not Param Is Nothing Then
            For i As Int32 = 0 To Param.Length - 1
                cmd.Parameters.Add(Param(i))
            Next

        End If
        Dim da As New SqlDataAdapter(cmd)
        Dim DT As New DataTable : da.Fill(DT)
        Return DT
    End Function
End Class
