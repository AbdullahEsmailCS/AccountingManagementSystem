Imports System.Data.SqlClient
Public Class CLS_USER
    Function GUID_us000(ByVal Number As Integer) As DataTable
        Dim DAL As New DataAccessLayer
        Dim DT As New DataTable
        DT.Clear()
        DT = DAL.SelectData("select GUID FROM user000  WHERE ID= " & Number & " ", Nothing)
        Return DT
    End Function
    Public Function MAX_1() As DataTable
        Dim CON As New CLS_CON
        Dim DT As New DataTable
        DT.Clear()
        DT = CON.SELECT_TXT("SELECT ISNULL(MAX(ID)+1,1) FROM user000")
        Return DT
    End Function
    Public Function MAX_() As DataTable
        Dim CON As New CLS_CON
        Dim DT As New DataTable
        DT.Clear()
        DT = CON.SELECT_TXT("SELECT ISNULL(MAX(ID),1) FROM user000")
        Return DT
    End Function
    Public Function MIN_() As DataTable
        Dim CON As New CLS_CON
        Dim DT As New DataTable
        DT.Clear()
        DT = CON.SELECT_TXT("SELECT ISNULL(MIN(ID),1) FROM user000")
        Return DT
    End Function


    Public Function SELECT_(ByVal SEARSH_ As String)
        Dim CON As New CLS_CON
        Dim DT As New DataTable
        DT.Clear()
        DT = CON.SELECT_TXT("SELECT    GUID,  ID , NAME AS [اسم ], PASS AS [ كلمة المرور]   FROM      user000     WHERE NAME LIKE '%" & SEARSH_ & "%'     ORDER BY ID")
        Return DT
    End Function

    Public Function show_(ByVal id As Integer) As DataTable
        Dim CON As New CLS_CON
        Dim DT As New DataTable
        DT.Clear()
        DT = CON.SELECT_TXT("SELECT NAME,PASS,GUID  FROM user000  where ID=" & id & "")
        Return DT
    End Function
    Public Function show_pas(ByVal name As String, ByVal pass As Double) As DataTable
        Dim CON As New CLS_CON
        Dim DT As New DataTable
        DT.Clear()
        DT = CON.SELECT_TXT("SELECT GUID,NAME,PASS  FROM user000  where NAME='" & name & "' and PASS =" & pass & "")
        Return DT
    End Function
    Public Function SELECT_all() As DataTable
        Dim CON As New CLS_CON
        Dim DT As New DataTable
        DT.Clear()
        DT = CON.SELECT_TXT("SELECT GUID,NAME,PASS  FROM user000  ORDER BY ID")
        Return DT
    End Function
    Public Function SEARSH_NAME(ByVal NAME As String)
        Dim CON As New CLS_CON
        Dim DT As New DataTable
        DT.Clear()
        DT = CON.SELECT_TXT(" SELECT * FROM user000 WHERE NAME='" & NAME & "'")
        Return DT
    End Function

    Public Sub add_(ByVal NAME As String,
                        ByVal PASS As String)
        Dim con As New CLS_CON
        Dim prm(1) As SqlParameter

        prm(0) = New SqlParameter("@NAME", SqlDbType.NVarChar, 500)
        prm(0).Value = NAME
        prm(1) = New SqlParameter("@PASS", SqlDbType.Float)
        prm(1).Value = PASS

        con.EXECUTE_STORE("ADD_USER", prm)
    End Sub
    Public Sub UPDATE_(ByVal NAME As String,
                       ByVal PASS As String,
                       ByVal GUID As String)
        Dim con As New CLS_CON
        Dim prm(2) As SqlParameter

        prm(0) = New SqlParameter("@NAME", SqlDbType.NVarChar, 500)
        prm(0).Value = NAME
        prm(1) = New SqlParameter("@PASS", SqlDbType.NVarChar, 500)
        prm(1).Value = PASS

        prm(2) = New SqlParameter("@GUID", SqlDbType.NVarChar, 500)
        prm(2).Value = GUID


        con.EXECUTE_STORE("UPDATE_USER", prm)
    End Sub
End Class
