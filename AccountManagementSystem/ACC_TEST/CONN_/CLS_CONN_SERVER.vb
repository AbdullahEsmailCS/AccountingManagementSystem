Imports System.Data.SqlClient
Public Class CLS_CONN_SERVER
    Sub ADD_DATABASE_FIN()
        If Con_SERVER.State = ConnectionState.Open Then
            Con_SERVER.Close()
        End If
        Con_SERVER.Open()
        Dim CMD As New SqlCommand("Create Database CONGIGACCOUNT", Con_SERVER)
        CMD.ExecuteNonQuery()
        Con_SERVER.Close()
    End Sub
    Sub ADD_DATABASE_SINGLE_USER_FIN()
        If Con_SERVER.State = ConnectionState.Open Then
            Con_SERVER.Close()
        End If
        Con_SERVER.Open()
        Dim CMD As New SqlCommand("USE master  ALTER DATABASE CONGIGACCOUNT SET SINGLE_USER", Con_SERVER)
        CMD.ExecuteNonQuery()
        Con_SERVER.Close()
    End Sub

    Sub DATABASE_Arabic1_FIN()
        If Con_SERVER.State = ConnectionState.Open Then
            Con_SERVER.Close()
        End If
        Con_SERVER.Open()
        Dim CMD As New SqlCommand("USE master ALTER DATABASE CONGIGACCOUNT COLLATE Arabic_CI_AS", Con_SERVER)
        CMD.ExecuteNonQuery()
        Con_SERVER.Close()
    End Sub
    Sub DATABASE_Arabic2_FIN()
        If Con_SERVER.State = ConnectionState.Open Then
            Con_SERVER.Close()
        End If
        Con_SERVER.Open()
        Dim CMD As New SqlCommand("USE master   ALTER DATABASE CONGIGACCOUNT SET MULTI_USER ", Con_SERVER)
        CMD.ExecuteNonQuery()
        Con_SERVER.Close()
    End Sub
    '============================================================================================================================
    Sub ADD_DATABASE(ByVal DATABASEE As String)
        If Con_SERVER.State = ConnectionState.Open Then
            Con_SERVER.Close()
        End If
        Con_SERVER.Open()
        Dim CMD As New SqlCommand("Create Database " & Trim(DATABASEE) & "", Con_SERVER)
        CMD.ExecuteNonQuery()
        Con_SERVER.Close()
    End Sub
    Sub ADD_DATABASE_SINGLE_USER(ByVal DATABASEE As String)
        If Con_SERVER.State = ConnectionState.Open Then
            Con_SERVER.Close()
        End If
        Con_SERVER.Open()
        Dim CMD As New SqlCommand("USE master  ALTER DATABASE " & Trim(DATABASEE) & " SET SINGLE_USER", Con_SERVER)
        CMD.ExecuteNonQuery()
        Con_SERVER.Close()
    End Sub

    Sub DATABASE_Arabic1(ByVal DATABASEE As String)
        If Con_SERVER.State = ConnectionState.Open Then
            Con_SERVER.Close()
        End If
        Con_SERVER.Open()
        Dim CMD As New SqlCommand("USE master ALTER DATABASE " & Trim(DATABASEE) & " COLLATE Arabic_CI_AS", Con_SERVER)
        CMD.ExecuteNonQuery()
        Con_SERVER.Close()
    End Sub
    Sub DATABASE_Arabic2(ByVal DATABASEE As String)
        If Con_SERVER.State = ConnectionState.Open Then
            Con_SERVER.Close()
        End If
        Con_SERVER.Open()
        Dim CMD As New SqlCommand("USE master   ALTER DATABASE " & Trim(DATABASEE) & " SET MULTI_USER ", Con_SERVER)
        CMD.ExecuteNonQuery()
        Con_SERVER.Close()
    End Sub
End Class
