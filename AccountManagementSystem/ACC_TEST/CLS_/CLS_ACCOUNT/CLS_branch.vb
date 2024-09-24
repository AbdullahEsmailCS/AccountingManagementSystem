Imports System.Data.SqlClient
Public Class CLS_branch
    Sub ADD_(ByVal NAME As String, ByVal guid_user As String, ByVal PARENT_GUID As String)
        Dim CON As New CLS_CON
        CON.EXECUTE_TXT("INSERT INTO branch(NAME,guid_user,PARENT_GUID)VALUES('" & NAME & "','" & guid_user & "','" & PARENT_GUID & "')")
    End Sub
    Sub UPDATE_(ByVal NAME As String, ByVal GUID As String, ByVal guid_user As String, ByVal PARENT_GUID As String)
        Dim CON As New CLS_CON
        CON.EXECUTE_TXT("UPDATE  branch SET NAME='" & NAME & "',guid_user='" & guid_user & "',PARENT_GUID='" & PARENT_GUID & "' WHERE GUID='" & GUID & "'")
    End Sub
    Public Function SELECT_()
        Dim CON As New CLS_CON
        Dim DT As New DataTable
        DT.Clear()
        DT = CON.SELECT_TXT("SELECT     ID AS الرقم, NAME AS الاسم, GUID  FROM         dbo.branch ORDER BY ID")
        Return DT
    End Function
    Public Function SELECT_STORE(ByVal SEARSH_ As String)
        Dim CON As New CLS_CON
        Dim DT As New DataTable
        DT.Clear()
        DT = CON.SELECT_TXT("SELECT     ID AS الرقم, NAME AS الاسم, GUID  FROM         dbo.branch WHERE NAME LIKE '%" & SEARSH_ & "%'")
        Return DT
    End Function
    Public Function ALL__()
        Dim CON As New CLS_CON
        Dim DT As New DataTable
        DT.Clear()
        DT = CON.SELECT_TXT("SELECT     GUID , NAME    FROM         dbo.branch   ORDER BY ID")
        Return DT
    End Function
End Class
