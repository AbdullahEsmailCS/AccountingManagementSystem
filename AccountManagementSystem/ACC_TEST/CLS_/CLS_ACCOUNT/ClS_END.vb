Imports System.Data.SqlClient
Public Class ClS_END
    Public Function SHOW_() As DataTable
        Dim CON As New CLS_CON
        Dim DT As New DataTable
        DT.Clear()
        DT = CON.SELECT_TXT("SELECT ID,NAME FROM TB_END")
        Return DT
    End Function
End Class
