Imports System.Data.SqlClient
Public Class CLS_CASH_DAY
    Public Function MAX_1(ByVal PARENT_GUID As String) As DataTable
        Dim CON As New CLS_CON
        Dim DT As New DataTable
        DT.Clear()
        DT = CON.SELECT_TXT("SELECT ISNULL(MAX(NUMBER)+1,1) FROM CASH_DAY where  PARENT_GUID='" & PARENT_GUID & "'")
        Return DT
    End Function
    Public Function MAX_(ByVal PARENT_GUID As String) As DataTable
        Dim CON As New CLS_CON
        Dim DT As New DataTable
        DT.Clear()
        DT = CON.SELECT_TXT("SELECT ISNULL(MAX(NUMBER),1) FROM CASH_DAY where  PARENT_GUID='" & PARENT_GUID & "'")
        Return DT
    End Function
    Public Function MIN_(ByVal PARENT_GUID As String) As DataTable
        Dim CON As New CLS_CON
        Dim DT As New DataTable
        DT.Clear()
        DT = CON.SELECT_TXT("SELECT ISNULL(MIN(NUMBER),1) FROM CASH_DAY where   PARENT_GUID='" & PARENT_GUID & "'")
        Return DT
    End Function
    Public Function guid__(ByVal id As Integer, ByVal parentguid As String) As DataTable
        Dim CON As New CLS_CON
        Dim DT As New DataTable
        DT.Clear()
        DT = CON.SELECT_TXT("SELECT guid FROM CASH_DAY where   (NUMBER=" & id & ") and(PARENT_GUID='" & parentguid & "')")
        Return DT
    End Function
    Public Function show_(ByVal id_ As Integer, ByVal PARENT_ As String) As DataTable
        Dim CON As New CLS_CON
        Dim DT As New DataTable
        DT.Clear()
        '                                    0                   1                       2                        3                   4               5                          6                                       7                      8                     9                            10                   11
        DT = CON.SELECT_TXT("SELECT     dbo.CASH_DAY.GUID, dbo.CASH_DAY.NUMBER, dbo.CASH_DAY.GUID_ACCOUNT, dbo.ACCOUNT.Name, dbo.CASH_DAY.NOTE, dbo.CASH_DAY.PARENT_GUID, dbo.CASH_DAY.DATE,                     dbo.CASH_DAY.GUID_JOB, dbo.JOB.NAME AS Expr1 ,CASH_DAY.GUID_CURRENCY,dbo.CURRENCY.NAME AS Expr2, dbo.CASH_DAY.CURRENCY_VAL, dbo.CASH_DAY.number_document, dbo.CASH_DAY.name_recip, dbo.CASH_DAY.mobile_recipt  FROM         dbo.CASH_DAY INNER JOIN                     dbo.ACCOUNT ON dbo.CASH_DAY.GUID_ACCOUNT = dbo.ACCOUNT.GUID INNER JOIN                    dbo.JOB ON dbo.CASH_DAY.GUID_JOB = dbo.JOB.GUID INNER JOIN        dbo.CURRENCY ON dbo.CASH_DAY.GUID_CURRENCY = dbo.CURRENCY.GUID where   (CASH_DAY.PARENT_GUID='" & PARENT_ & "')and(.CASH_DAY.NUMBER=" & id_ & ")")
        Return DT
    End Function

    Public Sub ADD_(ByVal NUMBER_ As Integer,
                    ByVal GUID_ACCOUNT As String,
                    ByVal NOTE As String,
                    ByVal PARENT_GUID As String,
                    ByVal DATEE As DateTime,
                    ByVal GUID_JOB As String,
                    ByVal GUID_CURRENCY As String,
                    ByVal CURRENCY_VAL As Double,
                    ByVal guid_user As String,
                    ByVal number_document As String,
                    ByVal name_recip As String,
                    ByVal mobile_recipt As String,
                    ByVal ISPOSTED As Integer,
                    ByVal DELETE_NUM As Integer,
                    ByVal Date_Delete As DateTime)
        Dim CON As New CLS_CON
        Dim prm(14) As SqlParameter

        prm(0) = New SqlParameter("@NUMBER", SqlDbType.Int)
        prm(0).Value = NUMBER_
        prm(1) = New SqlParameter("@GUID_ACCOUNT", SqlDbType.NVarChar, 500)
        prm(1).Value = GUID_ACCOUNT
        prm(2) = New SqlParameter("@NOTE", SqlDbType.NVarChar, 500)
        prm(2).Value = NOTE
        prm(3) = New SqlParameter("@PARENT_GUID", SqlDbType.NVarChar, 500)
        prm(3).Value = PARENT_GUID
        prm(4) = New SqlParameter("@DATE", SqlDbType.DateTime)
        prm(4).Value = DATEE

        prm(5) = New SqlParameter("@GUID_JOB", SqlDbType.NVarChar, 500)
        prm(5).Value = GUID_JOB
        prm(6) = New SqlParameter("@GUID_CURRENCY", SqlDbType.NVarChar, 500)
        prm(6).Value = GUID_CURRENCY
        prm(7) = New SqlParameter("@CURRENCY_VAL", SqlDbType.Float)
        prm(7).Value = CURRENCY_VAL
        prm(8) = New SqlParameter("@guid_user", SqlDbType.NVarChar, 500)
        prm(8).Value = guid_user


        prm(9) = New SqlParameter("@number_document", SqlDbType.NVarChar, 500)
        prm(9).Value = number_document
        prm(10) = New SqlParameter("@name_recip", SqlDbType.NVarChar, 500)
        prm(10).Value = name_recip
        prm(11) = New SqlParameter("@mobile_recipt", SqlDbType.NVarChar, 500)
        prm(11).Value = mobile_recipt

        prm(12) = New SqlParameter("@ISPOSTED", SqlDbType.Int)
        prm(12).Value = ISPOSTED

        prm(13) = New SqlParameter("@DELETE_NUM", SqlDbType.Int)
        prm(13).Value = DELETE_NUM
        prm(14) = New SqlParameter("@Date_Delete", SqlDbType.DateTime)
        prm(14).Value = Date_Delete

        CON.EXECUTE_STORE("add_CASH_DAY", prm)
    End Sub
    Public Sub UPDATE_(ByVal GUID_ACCOUNT As String,
                       ByVal NOTE As String,
                       ByVal PARENT_GUID As String,
                       ByVal DATEE As DateTime,
                       ByVal GUID As String,
                      ByVal GUID_JOB As String,
                    ByVal GUID_CURRENCY As String,
                    ByVal CURRENCY_VAL As Double,
                    ByVal guid_user As String,
                     ByVal number_document As String,
                    ByVal name_recip As String,
                    ByVal mobile_recipt As String,
                    ByVal ISPOSTED As Integer,
                       ByVal DELETE_NUM As Integer,
                    ByVal Date_Delete As DateTime)
        Dim CON As New CLS_CON
        Dim prm(14) As SqlParameter


        prm(0) = New SqlParameter("@GUID_ACCOUNT", SqlDbType.NVarChar, 500)
        prm(0).Value = GUID_ACCOUNT
        prm(1) = New SqlParameter("@NOTE", SqlDbType.NVarChar, 500)
        prm(1).Value = NOTE
        prm(2) = New SqlParameter("@PARENT_GUID", SqlDbType.NVarChar, 500)
        prm(2).Value = PARENT_GUID
        prm(3) = New SqlParameter("@DATE", SqlDbType.DateTime)
        prm(3).Value = DATEE

        prm(4) = New SqlParameter("@GUID", SqlDbType.NVarChar, 500)
        prm(4).Value = GUID
        prm(5) = New SqlParameter("@GUID_JOB", SqlDbType.NVarChar, 500)
        prm(5).Value = GUID_JOB
        prm(6) = New SqlParameter("@GUID_CURRENCY", SqlDbType.NVarChar, 500)
        prm(6).Value = GUID_CURRENCY
        prm(7) = New SqlParameter("@CURRENCY_VAL", SqlDbType.Float)
        prm(7).Value = CURRENCY_VAL
        prm(8) = New SqlParameter("@guid_user", SqlDbType.NVarChar, 500)
        prm(8).Value = guid_user
        prm(9) = New SqlParameter("@number_document", SqlDbType.NVarChar, 500)
        prm(9).Value = number_document
        prm(10) = New SqlParameter("@name_recip", SqlDbType.NVarChar, 500)
        prm(10).Value = name_recip
        prm(11) = New SqlParameter("@mobile_recipt", SqlDbType.NVarChar, 500)
        prm(11).Value = mobile_recipt
        prm(12) = New SqlParameter("@ISPOSTED", SqlDbType.Int)
        prm(12).Value = ISPOSTED
        prm(13) = New SqlParameter("@DELETE_NUM", SqlDbType.Int)
        prm(13).Value = DELETE_NUM
        prm(14) = New SqlParameter("@Date_Delete", SqlDbType.DateTime)
        prm(14).Value = Date_Delete
        CON.EXECUTE_STORE("update_CASH_DAY", prm)
    End Sub

    Public Sub DELETE_(ByVal GUID As String)
        Dim CON As New CLS_CON
        CON.EXECUTE_TXT("DELETE  CASH_DAY  WHERE GUID='" & GUID & "'")
        'CON.EXECUTE_TXT("update      CASH_DAY set DELETE_NUM=1,Date_Delete= '" & d1.Month & "/" & d1.Day & "/" & d1.Year & "' where    GUID='" & GUID & "'")

    End Sub
    Public Sub UPDATE_BETWEEN(ByVal GUIDTO As String, ByVal GUIDFROM As String, ByVal D1 As DateTime, ByVal D2 As DateTime)
        Dim con As New CLS_CON
        con.EXECUTE_TXT("UPDATE CASH_DAY SET GUID_ACCOUNT = '" & GUIDTO & "'    WHERE     (GUID_ACCOUNT = '" & GUIDFROM & "') AND  (DATE BETWEEN CONVERT(DATETIME, '" & D1.Month & "/" & D1.Day & "/" & D1.Year & "', 102) AND CONVERT(DATETIME, '" & D2.Month & "/" & D2.Day & "/" & D2.Year & "', 102))                      ")
    End Sub
    Public Function delete_account(ByVal guid As String) As DataTable
        Dim CON As New CLS_CON
        Dim DT As New DataTable
        DT.Clear()
        DT = CON.SELECT_TXT("SELECT * FROM CASH_DAY where GUID_ACCOUNT='" & guid & "'")
        Return DT
    End Function
End Class
