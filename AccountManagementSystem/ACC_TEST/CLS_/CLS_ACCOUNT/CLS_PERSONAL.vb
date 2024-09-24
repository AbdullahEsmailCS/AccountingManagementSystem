Imports System.Data.SqlClient
Public Class CLS_PERSONAL
    Public Function SHOW_() As DataTable
        Dim CON As New CLS_CON
        Dim DT As New DataTable
        DT.Clear()
        DT = CON.SELECT_TXT("SELECT customer,vender,student,employee  FROM personal ")
        Return DT
    End Function
End Class
