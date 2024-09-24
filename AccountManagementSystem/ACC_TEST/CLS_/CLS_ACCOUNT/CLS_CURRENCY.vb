Imports System.Data.SqlClient
Public Class CLS_CURRENCY
    Public Function MAX_1() As DataTable
        Dim CON As New CLS_CON
        Dim DT As New DataTable
        DT.Clear()
        DT = CON.SELECT_TXT("SELECT ISNULL(MAX(ID)+1,1) FROM CURRENCY")
        Return DT
    End Function
    Public Function MAX_() As DataTable
        Dim CON As New CLS_CON
        Dim DT As New DataTable
        DT.Clear()
        DT = CON.SELECT_TXT("SELECT ISNULL(MAX(ID),1) FROM CURRENCY")
        Return DT
    End Function
    Public Function MIN_() As DataTable
        Dim CON As New CLS_CON
        Dim DT As New DataTable
        DT.Clear()
        DT = CON.SELECT_TXT("SELECT ISNULL(MIN(ID),1) FROM CURRENCY")
        Return DT
    End Function


    Public Function SELECT_CATEGORY(ByVal SEARSH_ As String)
        Dim CON As New CLS_CON
        Dim DT As New DataTable
        DT.Clear()
        DT = CON.SELECT_TXT("SELECT    GUID,  ID AS [رقم العملة], NAME AS [اسم العملة], PART_NAME AS [جزء العملة], CURRENCY_VAL AS [سعر التعادل]   FROM      CURRENCY     WHERE NAME LIKE '%" & SEARSH_ & "%'     ORDER BY [رقم العملة]")
        Return DT
    End Function
    Public Function guid__(ByVal id As Integer) As DataTable
        Dim CON As New CLS_CON
        Dim DT As New DataTable
        DT.Clear()
        DT = CON.SELECT_TXT("SELECT guid FROM CURRENCY where ID=" & id & "")
        Return DT
    End Function
    Public Function show_(ByVal id As Integer) As DataTable
        Dim CON As New CLS_CON
        Dim DT As New DataTable
        DT.Clear()
        DT = CON.SELECT_TXT("SELECT NAME,PART_NAME,CURRENCY_VAL  FROM CURRENCY  where ID=" & id & "")
        Return DT
    End Function
    Public Function SELECT_() As DataTable
        Dim CON As New CLS_CON
        Dim DT As New DataTable
        DT.Clear()
        DT = CON.SELECT_TXT("SELECT GUID,NAME,CURRENCY_VAL  FROM CURRENCY  ORDER BY ID")
        Return DT
    End Function
    Public Function SEARSH_NAME(ByVal NAME As String)
        Dim CON As New CLS_CON
        Dim DT As New DataTable
        DT.Clear()
        DT = CON.SELECT_TXT(" SELECT * FROM CURRENCY WHERE NAME='" & NAME & "'")
        Return DT
    End Function

    Public Sub add_(ByVal NAME As String,
                        ByVal PART_NAME As String,
                        ByVal CURRENCY_VAL As Double,
                        ByVal guid_user As String)
        Dim con As New CLS_CON
        Dim prm(3) As SqlParameter

        prm(0) = New SqlParameter("@NAME", SqlDbType.NVarChar, 500)
        prm(0).Value = NAME
        prm(1) = New SqlParameter("@PART_NAME", SqlDbType.NVarChar, 500)
        prm(1).Value = PART_NAME

        prm(2) = New SqlParameter("@CURRENCY_VAL", SqlDbType.Float)
        prm(2).Value = CURRENCY_VAL

        prm(3) = New SqlParameter("@guid_user", SqlDbType.NVarChar, 500)
        prm(3).Value = guid_user
        con.EXECUTE_STORE("ADD_CURRENCY", prm)
    End Sub
    Public Sub UPDATE_(ByVal NAME As String,
                       ByVal PART_NAME As String,
                       ByVal CURRENCY_VAL As Double,
                       ByVal ID As Integer,
                        ByVal guid_user As String)
        Dim con As New CLS_CON
        Dim prm(4) As SqlParameter

        prm(0) = New SqlParameter("@NAME", SqlDbType.NVarChar, 500)
        prm(0).Value = NAME
        prm(1) = New SqlParameter("@PART_NAME", SqlDbType.NVarChar, 500)
        prm(1).Value = PART_NAME

        prm(2) = New SqlParameter("@CURRENCY_VAL", SqlDbType.Float)
        prm(2).Value = CURRENCY_VAL
        prm(3) = New SqlParameter("@ID", SqlDbType.Int)
        prm(3).Value = ID
        prm(4) = New SqlParameter("@guid_user", SqlDbType.NVarChar, 500)
        prm(4).Value = guid_user
        con.EXECUTE_STORE("UPDATE_CURRENCY", prm)
    End Sub
End Class
