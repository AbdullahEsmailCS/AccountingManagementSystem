Imports System.Data.SqlClient
Public Class CLS_SET_POS
    Public Function MAX_1() As DataTable
        Dim CON As New CLS_CON
        Dim DT As New DataTable
        DT.Clear()
        DT = CON.SELECT_TXT("SELECT ISNULL(MAX(ID)+1,1) FROM set_pos")
        Return DT
    End Function
    Public Function MAX_() As DataTable
        Dim CON As New CLS_CON
        Dim DT As New DataTable
        DT.Clear()
        DT = CON.SELECT_TXT("SELECT ISNULL(MAX(ID),1) FROM set_pos")
        Return DT
    End Function
    Public Function MIN_() As DataTable
        Dim CON As New CLS_CON
        Dim DT As New DataTable
        DT.Clear()
        DT = CON.SELECT_TXT("SELECT ISNULL(MIN(ID),1) FROM set_pos")
        Return DT
    End Function
    Public Function SEARSH_NAME(ByVal guid_user As String)
        Dim CON As New CLS_CON
        Dim DT As New DataTable
        DT.Clear()
        DT = CON.SELECT_TXT(" SELECT * FROM set_pos WHERE guid_user='" & guid_user & "'")
        Return DT
    End Function
    Public Function SEARSH_id(ByVal id As String)
        Dim CON As New CLS_CON
        Dim DT As New DataTable
        DT.Clear()
        DT = CON.SELECT_TXT(" SELECT     dbo.set_pos.guid_user, dbo.user000.name, dbo.set_pos.guid_cu, dbo.ACCOUNT.Name AS Expr1, dbo.set_pos.guid_stor, dbo.STORE.NAME AS Expr2, dbo.set_pos.guid_currency,                       dbo.CURRENCY.NAME AS Expr3, dbo.set_pos.val_currency, dbo.set_pos.guid_job, dbo.JOB.NAME AS Expr4, dbo.set_pos.show_iteme   FROM         dbo.set_pos INNER JOIN                     dbo.user000 ON dbo.set_pos.guid_user = dbo.user000.guid INNER JOIN                      dbo.ACCOUNT ON dbo.set_pos.guid_cu = dbo.ACCOUNT.GUID INNER JOIN                      dbo.STORE ON dbo.set_pos.guid_stor = dbo.STORE.GUID INNER JOIN                   dbo.CURRENCY ON dbo.set_pos.guid_currency = dbo.CURRENCY.GUID INNER JOIN                    dbo.JOB ON dbo.set_pos.guid_job = dbo.JOB.GUID   WHERE set_pos.id= " & id & " ")
        Return DT
    End Function
    Public Function SEARSH_pos(ByVal guid_user As String)
        Dim CON As New CLS_CON
        Dim DT As New DataTable
        DT.Clear()
        DT = CON.SELECT_TXT(" SELECT  guid_cu,guid_stor,guid_currency,val_currency,guid_job,show_iteme from set_pos where  guid_user= '" & guid_user & "' ")
        Return DT
    End Function
    Public Sub add_(ByVal guid_user As String,
                    ByVal guid_cu As String,
                    ByVal guid_stor As String,
                    ByVal guid_currency As String,
                    ByVal val_currency As Double,
                    ByVal guid_job As String,
                    ByVal show_iteme As Integer)

        Dim con As New CLS_CON
        Dim prm(6) As SqlParameter

        prm(0) = New SqlParameter("@guid_user", SqlDbType.NVarChar, 500)
        prm(0).Value = guid_user

        prm(1) = New SqlParameter("@guid_cu", SqlDbType.NVarChar, 500)
        prm(1).Value = guid_cu

        prm(2) = New SqlParameter("@guid_stor", SqlDbType.NVarChar, 500)
        prm(2).Value = guid_stor

        prm(3) = New SqlParameter("@guid_currency", SqlDbType.NVarChar, 500)
        prm(3).Value = guid_currency


        prm(4) = New SqlParameter("@val_currency", SqlDbType.Float)
        prm(4).Value = val_currency

        prm(5) = New SqlParameter("@guid_job", SqlDbType.NVarChar, 500)
        prm(5).Value = guid_job
        prm(6) = New SqlParameter("@show_iteme", SqlDbType.Float)
        prm(6).Value = show_iteme

        con.EXECUTE_STORE("ADD_SET_POS", prm)
    End Sub


    Public Sub update_(ByVal guid_user As String,
                  ByVal guid_cu As String,
                  ByVal guid_stor As String,
                  ByVal guid_currency As String,
                  ByVal val_currency As Double,
                  ByVal guid_job As String,
                  ByVal show_iteme As Integer,
                  ByVal id As Integer)


        Dim con As New CLS_CON
        Dim prm(7) As SqlParameter


        prm(0) = New SqlParameter("@guid_user", SqlDbType.NVarChar, 500)
        prm(0).Value = guid_user


        prm(1) = New SqlParameter("@guid_cu", SqlDbType.NVarChar, 500)
        prm(1).Value = guid_cu

        prm(2) = New SqlParameter("@guid_stor", SqlDbType.NVarChar, 500)
        prm(2).Value = guid_stor

        prm(3) = New SqlParameter("@guid_currency", SqlDbType.NVarChar, 500)
        prm(3).Value = guid_currency


        prm(4) = New SqlParameter("@val_currency", SqlDbType.Float)
        prm(4).Value = val_currency


        prm(5) = New SqlParameter("@guid_job", SqlDbType.NVarChar, 500)
        prm(5).Value = guid_job


        prm(6) = New SqlParameter("@show_iteme", SqlDbType.Float)
        prm(6).Value = show_iteme



        prm(7) = New SqlParameter("@id", SqlDbType.Float)
        prm(7).Value = id



        con.EXECUTE_STORE("update_set_pos", prm)

    End Sub
End Class
