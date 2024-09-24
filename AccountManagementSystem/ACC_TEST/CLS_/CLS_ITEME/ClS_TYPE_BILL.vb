
Public Class ClS_TYPE_BILL
    Function MAX_ID() As DataTable
        Dim DAL As New DataAccessLayer
        Dim DT As New DataTable
        DT.Clear()
        DT = DAL.SelectData("select ISNULL(max(ID) ,1) from TYPE_BILL ", Nothing)
        Return DT
    End Function
    Function MIN_ID() As DataTable
        Dim DAL As New DataAccessLayer
        Dim DT As New DataTable
        DT.Clear()
        DT = DAL.SelectData("select ISNULL(min(ID),1) from TYPE_BILL ", Nothing)
        Return DT
    End Function
 
    Public Function SHOW_() As DataTable
        Dim CON As New CLS_CON
        Dim DT As New DataTable
        DT.Clear()
        DT = CON.SELECT_TXT("SELECT GUID,NAME  FROM TYPE_BILL ORDER BY ID")
        Return DT
    End Function
    Sub UPDATE_(ByVal NAME As String,
                ByVal day_iteme As String,
                ByVal day_disc As String,
                ByVal cash_day As String,
                ByVal is_stock As Integer,
                ByVal is_day As Integer,
                ByVal pricee As Integer,
                ByVal id As Integer)
        Dim CON As New CLS_CON
        CON.EXECUTE_TXT("UPDATE  TYPE_BILL SET NAME='" & NAME & "',day_iteme='" & day_iteme & "',day_disc='" & day_disc & "',cash_day='" & cash_day & "' ,is_stock= " & is_stock & ",is_day= " & is_day & ",pricee=  " & pricee & "    WHERE id= " & id & " ")
    End Sub
    Public Function SHOW_id(ByVal id As Integer) As DataTable
        Dim CON As New CLS_CON
        Dim DT As New DataTable
        DT.Clear()
        DT = CON.SELECT_TXT("SELECT     dbo.TYPE_BILL.NAME, dbo.TYPE_BILL.day_iteme, dbo.ACCOUNT.Name AS Expr1, dbo.TYPE_BILL.day_disc, ACCOUNT_1.Name AS Expr2, dbo.TYPE_BILL.cash_day,                    ACCOUNT_2.Name AS Expr3,TYPE_BILL.pricee as priceee,TYPE_BILL.is_day,TYPE_BILL.is_stock    FROM         dbo.TYPE_BILL INNER JOIN                     dbo.ACCOUNT ON dbo.TYPE_BILL.day_iteme = dbo.ACCOUNT.GUID INNER JOIN                   dbo.ACCOUNT AS ACCOUNT_1 ON dbo.TYPE_BILL.day_disc = ACCOUNT_1.GUID INNER JOIN                  dbo.ACCOUNT AS ACCOUNT_2 ON dbo.TYPE_BILL.cash_day = ACCOUNT_2.GUID where TYPE_BILL.id= " & id & " ")
        Return DT
    End Function
    Public Function SHOW_account(ByVal GUID As String) As DataTable
        Dim CON As New CLS_CON
        Dim DT As New DataTable
        DT.Clear()
        DT = CON.SELECT_TXT("SELECT day_iteme,day_disc,cash_day,is_day,pricee  FROM TYPE_BILL where GUID='" & GUID & "'")
        Return DT
    End Function
    Public Function ALL__()
        Dim CON As New CLS_CON
        Dim DT As New DataTable
        DT.Clear()
        DT = CON.SELECT_TXT("SELECT     GUID , NAME    FROM         dbo.TYPE_BILL  ")
        Return DT
    End Function
End Class
