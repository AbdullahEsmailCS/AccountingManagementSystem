Imports System.Data.SqlClient
Public Class CLS_ACCOUNT

    'Function MAX_number_AC000(ByVal PARENTGUID As String) As DataTable
    '    Dim DAL As New DataAccessLayer
    '    Dim DT As New DataTable
    '    DT.Clear()
    '    DT = DAL.SelectData("select  isnull((MAX(Number)+1),1)  from AC000  WHERE ParentGUID='" & PARENTGUID & "'", Nothing)
    '    Return DT
    'End Function



    Public Function GUID_TREEE(ByVal GUID As String) As DataTable
        Dim CON As New CLS_CON
        Dim DT As New DataTable
        DT.Clear()
        DT = CON.SELECT_TXT("SELECT GUID, NAME  FROM ACCOUNT WHERE PARENTGUID='" & GUID & "'order by Code")
        Return DT
    End Function



    Public Function GUID_EMPLOYEE(ByVal NAME As String) As DataTable
        Dim CON As New CLS_CON
        Dim DT As New DataTable
        DT.Clear()
        DT = CON.SELECT_TXT("SELECT GUID,NAME  FROM ACCOUNT WHERE NAME='" & NAME & "'")
        Return DT
    End Function


    Public Function SHOW_() As DataTable
        Dim CON As New CLS_CON
        Dim DT As New DataTable
        DT.Clear()
        DT = CON.SELECT_TXT("SELECT GUID,NAME,PARENTGUID,CODE,END_ACCOUNT,NSons FROM ACCOUNT order by Code")
        Return DT
    End Function

    Public Function SHOW_GUID(ByVal GUID As String) As DataTable
        Dim CON As New CLS_CON
        Dim DT As New DataTable
        DT.Clear()
        DT = CON.SELECT_TXT("SELECT     dbo.ACCOUNT.NAME, ACCOUNT_1.GUID, ACCOUNT_1.NAME AS Expr1, dbo.ACCOUNT.END_ACCOUNT  FROM         dbo.ACCOUNT INNER JOIN                    dbo.ACCOUNT AS ACCOUNT_1 ON dbo.ACCOUNT.PARENTGUID = ACCOUNT_1.GUID WHERE ACCOUNT.GUID='" & GUID & "'")
        Return DT
    End Function
    Public Function ALL_(ByVal NAME As String) As DataTable
        Dim DT As New DataTable
        Dim CON As New CLS_CON
        DT.Clear()
        DT = CON.SELECT_TXT("SELECT GUID,NAME,PARENTGUID,CODE,END_ACCOUNT FROM ACCOUNT WHERE  (NSons =0) and (NAME LIKE '%" & NAME & "%' )")
        Return DT
    End Function
    Public Function ALL_nsons(ByVal NAME As String) As DataTable
        Dim DT As New DataTable
        Dim CON As New CLS_CON
        DT.Clear()
        DT = CON.SELECT_TXT("SELECT GUID,NAME,PARENTGUID,CODE,END_ACCOUNT FROM ACCOUNT WHERE   (NAME LIKE '%" & NAME & "%' )")
        Return DT
    End Function
    Public Function ALL_cash(ByVal NAME As String) As DataTable
        Dim DT As New DataTable
        Dim CON As New CLS_CON
        DT.Clear()
        DT = CON.SELECT_TXT("SELECT GUID,NAME,PARENTGUID,CODE,END_ACCOUNT FROM ACCOUNT WHERE (PARENTGUID='c9b91649-aded-4000-8bbf-1104c6207831') ")
        Return DT
    End Function
    Public Function searsh_code(ByVal code As Double) As DataTable
        Dim DT As New DataTable
        Dim CON As New CLS_CON
        DT.Clear()
        DT = CON.SELECT_TXT("SELECT GUID,NAME,PARENTGUID,CODE,END_ACCOUNT FROM ACCOUNT WHERE (NSons =0) and CODE = " & code & " ")
        Return DT
    End Function
    Public Function searsh_name___(ByVal name As String) As DataTable
        Dim DT As New DataTable
        Dim CON As New CLS_CON
        DT.Clear()
        DT = CON.SELECT_TXT("SELECT GUID,NAME,PARENTGUID,CODE,END_ACCOUNT FROM ACCOUNT WHERE  (NSons =0) and (NAME like  '%" & name & "%') ")
        Return DT
    End Function
    Public Function SEARSH_NAME(ByVal NAME As String) As DataTable
        Dim DT As New DataTable
        DT.Clear()
        Dim CON As New CLS_CON
        DT = CON.SELECT_TXT("SELECT * FROM ACCOUNT WHERE NAME='" & NAME & "'")
        Return DT
    End Function
    Public Function COD_(ByVal PARENTGUID As String) As DataTable
        Dim CON As New CLS_CON
        Dim DT As New DataTable
        DT.Clear()
        DT = CON.SELECT_TXT("SELECT ISNULL(MAX(CODE)+1,0) FROM ACCOUNT WHERE PARENTGUID='" & PARENTGUID & "'")
        Return DT
    End Function
    Public Sub ADD_(ByVal NAME As String,
                    ByVal PARENTGUID As String,
                    ByVal CODE As Double,
                    ByVal END_ACCOUNT As Integer,
                    ByVal NSons As Integer,
                    ByVal Debit As Double,
                    ByVal Credit As Double,
                           ByVal guid_user As String)
        Dim CON As New CLS_CON
        CON.EXECUTE_TXT("INSERT ACCOUNT (NAME,PARENTGUID,CODE,END_ACCOUNT,NSons,Debit,Credit,guid_user)VALUES('" & NAME & "','" & PARENTGUID & "'," & CODE & "," & END_ACCOUNT & "," & NSons & "," & Debit & "," & Credit & ",'" & guid_user & "')")

    End Sub
    Public Sub UPDATE_(ByVal NAME As String,
                    ByVal PARENTGUID As String,
                    ByVal END_ACCOUNT As Integer, ByVal GUID As String, ByVal guid_user As String)
        Dim CON As New CLS_CON
        CON.EXECUTE_TXT("UPDATE ACCOUNT SET NAME='" & NAME & "',PARENTGUID='" & PARENTGUID & "',END_ACCOUNT= " & END_ACCOUNT & ",guid_user='" & guid_user & "' WHERE GUID='" & GUID & "'")

    End Sub
    Public Sub delete_(ByVal guid As String)
        Dim CON As New CLS_CON
        CON.EXECUTE_TXT("delete from  ACCOUNT  WHERE GUID='" & guid & "'")

    End Sub
    'Public Function count_NSons(ByVal PARENTGUID As String) As DataTable
    '    Dim CON As New CLS_CON
    '    Dim DT As New DataTable
    '    DT.Clear()
    '    DT = CON.SELECT_TXT("SELECT     COUNT(ID) AS Expr1  FROM         dbo.ACCOUNT  WHERE     (ParentGUID = '" & PARENTGUID & "') ")
    '    Return DT
    'End Function
    'Public Sub UPDATE_NSons(ByVal NSons As Double, ByVal GUID As String)
    '    Dim CON As New CLS_CON
    '    CON.EXECUTE_TXT("UPDATE ACCOUNT SET NSons= " & NSons & " WHERE GUID='" & GUID & "'")

    'End Sub
    Public Function searsh_account_day2(ByVal GUID As String) As DataTable
        Dim CON As New CLS_CON
        Dim DT As New DataTable
        DT.Clear()
        DT = CON.SELECT_TXT("SELECT    id  FROM         day2  WHERE     (ACCOUNT_GUID = '" & GUID & "') ")
        Return DT
    End Function
    Public Function delete_account(ByVal guid As String) As DataTable
        Dim CON As New CLS_CON
        Dim DT As New DataTable
        DT.Clear()
        DT = CON.SELECT_TXT("SELECT * FROM ACCOUNT where (NSons >0) and(GUID='" & guid & "')")
        Return DT
    End Function
End Class
