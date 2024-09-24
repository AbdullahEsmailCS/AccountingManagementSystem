Imports System.Data.SqlClient
Public Class CLS_CON_CONFIG
    Sub ADD_(ByVal COMPANY As String, ByVal CON_____ As String, ByVal TXT____ As String)
        If CON_CONFIG.State = ConnectionState.Open Then
            CON_CONFIG.Close()
        End If
        CON_CONFIG.Open()
        Dim CMD As New SqlCommand("INSERT INTO COMPANY(Name,DataBasee,CONN)values('" & COMPANY & "','" & CON_____ & "','" & TXT____ & "')", Con_SERVER)
        CMD.ExecuteNonQuery()
        CON_CONFIG.Close()
    End Sub
End Class
