Public Class ClS_TYPE_CASH
    Public Function SHOW_() As DataTable
        Dim CON As New CLS_CON
        Dim DT As New DataTable
        DT.Clear()
        DT = CON.SELECT_TXT("SELECT GUID,NAME  FROM TYPE_CASH ")
        Return DT
    End Function
    Public Function SHOW_CASH(ByVal TYPE_CASH As String) As DataTable
        Dim CON As New CLS_CON
        Dim DT As New DataTable
        DT.Clear()
        DT = CON.SELECT_TXT("SELECT     dbo.TYPE_CASH.CASHACCOUNT, dbo.ACCOUNT.Name  FROM         dbo.TYPE_CASH INNER JOIN                   dbo.ACCOUNT ON dbo.TYPE_CASH.CASHACCOUNT = dbo.ACCOUNT.GUID WHERE TYPE_CASH.GUID ='" & TYPE_CASH & "' ")
        Return DT
    End Function
End Class
