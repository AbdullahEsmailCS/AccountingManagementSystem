Imports System.Data.SqlClient
Imports System.IO
Public Class CLS_CON
    Dim SQLCON As New SqlConnection

    Public Sub New()
        SQLCON = New SqlConnection(File.ReadAllText("c:\CONN\CONN.TXT"))
        'SQLCON = New SqlConnection("Data Source=.;Initial Catalog=DB_ACC;Integrated Security=True")
        'SQLCON = New SqlConnection(My.Settings.CONN)

    End Sub
    Public Sub OPEN_CON()
        If SQLCON.State = ConnectionState.Closed Then
            SQLCON.Open()
        End If
    End Sub
    Public Sub CLOSE_CON()
        If SQLCON.State = ConnectionState.Open Then
            SQLCON.Close()
        End If
    End Sub


    Public Sub EXECUTE_TXT(ByVal TXT_ As String)
        Dim CMD As New SqlCommand
        CMD.CommandType = CommandType.Text
        CMD.Connection = SQLCON
        OPEN_CON()
        CMD = New SqlCommand(TXT_, SQLCON)
        CMD.ExecuteNonQuery()
        CLOSE_CON()

    End Sub
    Public Sub EXECUTE_STORE(ByVal NAME_ As String, ByVal PRM() As SqlParameter)
        Dim CMD As New SqlCommand
        CMD.CommandType = CommandType.StoredProcedure
        CMD.CommandText = NAME_
        CMD.Connection = SQLCON
        OPEN_CON()
        For I As Integer = 0 To PRM.Length - 1
            CMD.Parameters.Add(PRM(I))
        Next
        CMD.ExecuteNonQuery()
        CLOSE_CON()
    End Sub


    Public Function SELECT_TXT(ByVal TXT_ As String) As DataTable
        Dim DT As New DataTable
        DT.Clear()
        Dim ADP As New SqlDataAdapter(TXT_, SQLCON)
        ADP.Fill(DT)
        Return DT
    End Function
    Public Function SELECT_DataSet(ByVal TXT_ As String) As DataSet
        Dim DT As New DataSet
        DT.Clear()
        Dim ADP As New SqlDataAdapter(TXT_, SQLCON)
        ADP.Fill(DT)
        Return DT
    End Function
    Public Function SELECT_STOE(ByVal NAME_ As String, ByVal PRM() As SqlParameter) As DataTable
        Dim CMD As New SqlCommand
        CMD.CommandType = CommandType.StoredProcedure
        CMD.CommandText = NAME_
        CMD.Connection = SQLCON
        OPEN_CON()
        For I As Integer = 0 To PRM.Length - 1
            CMD.Parameters.Add(PRM(I))
        Next
        Dim ADP As New SqlDataAdapter(CMD)
        Dim DT As New DataTable
        DT.Clear()
        ADP.Fill(DT)
        Return DT

        CLOSE_CON()

    End Function
End Class
