Imports System.Data.SqlClient
Public Class CLS_DAY
    Public Function number_day_bill(ByVal guid_bill) As DataTable
        Dim CON As New CLS_CON
        Dim DT As New DataTable
        DT.Clear()
        DT = CON.SELECT_TXT("SELECT NUMBER_D,GUID FROM DAY1 where TYPE='" & guid_bill & "'")
        Return DT
    End Function
    Public Function MAX_1() As DataTable
        Dim CON As New CLS_CON
        Dim DT As New DataTable
        DT.Clear()
        DT = CON.SELECT_TXT("SELECT ISNULL(MAX(NUMBER_D)+1,1) FROM DAY1 ")
        Return DT
    End Function
    Public Function MAX_1_T(ByVal TYPEEE As String) As DataTable
        Dim CON As New CLS_CON
        Dim DT As New DataTable
        DT.Clear()
        DT = CON.SELECT_TXT("SELECT ISNULL(MAX(NUMBER_D),1) FROM DAY1 WHERE TYPE='" & TYPEEE & "'")
        Return DT
    End Function
    Public Function MAX_() As DataTable
        Dim CON As New CLS_CON
        Dim DT As New DataTable
        DT.Clear()
        DT = CON.SELECT_TXT("SELECT ISNULL(MAX(NUMBER_D),1) FROM DAY1")
        Return DT
    End Function
    Public Function MAX_T(ByVal TYPEEE As String) As DataTable
        Dim CON As New CLS_CON
        Dim DT As New DataTable
        DT.Clear()
        DT = CON.SELECT_TXT("SELECT ISNULL(MAX(NUMBER_D),1) FROM DAY1 WHERE TYPE='" & TYPEEE & "'")
        Return DT
    End Function
    Public Function MIN_() As DataTable
        Dim CON As New CLS_CON
        Dim DT As New DataTable
        DT.Clear()
        DT = CON.SELECT_TXT("SELECT ISNULL(MIN(NUMBER_D),1) FROM DAY1")
        Return DT
    End Function
    Public Function MIN_T(ByVal TYPEEE As String) As DataTable
        Dim CON As New CLS_CON
        Dim DT As New DataTable
        DT.Clear()
        DT = CON.SELECT_TXT("SELECT ISNULL(MIN(NUMBER_D),1) FROM DAY1WHERE TYPE='" & TYPEEE & "'")
        Return DT
    End Function
    Public Function guid__(ByVal id As Integer) As DataTable
        Dim CON As New CLS_CON
        Dim DT As New DataTable
        DT.Clear()
        DT = CON.SELECT_TXT("SELECT guid FROM DAY1 where NUMBER_D=" & id & "")
        Return DT
    End Function
    Public Function show_day1(ByVal id As Integer) As DataTable
        Dim CON As New CLS_CON
        Dim DT As New DataTable
        DT.Clear()
        DT = CON.SELECT_TXT("SELECT     dbo.DAY1.GUID, dbo.DAY1.NUMBER_D, dbo.DAY1.DATE, dbo.DAY1.NOTE, dbo.DAY1.TYPE, dbo.DAY1.note_day, dbo.DAY1.GUID_JOB, dbo.JOB.NAME, dbo.DAY1.GUID_CURRENCY,                    dbo.CURRENCY.NAME AS Expr1, dbo.DAY1.CURRENCY_VAL  FROM         dbo.DAY1 INNER JOIN             dbo.JOB ON dbo.DAY1.GUID_JOB = dbo.JOB.GUID INNER JOIN          dbo.CURRENCY ON dbo.DAY1.GUID_CURRENCY = dbo.CURRENCY.GUID  where DAY1.NUMBER_D=" & id & "")
        Return DT
    End Function
    Public Function show_day1_COPY(ByVal id As Integer) As DataTable
        Dim CON As New CLS_CON
        Dim DT As New DataTable
        DT.Clear()
        DT = CON.SELECT_TXT("SELECT     dbo.DAY1.GUID, dbo.DAY1.NUMBER_D, dbo.DAY1.DATE, dbo.DAY1.NOTE, dbo.DAY1.TYPE, dbo.DAY1.note_day, dbo.DAY1.GUID_JOB, dbo.JOB.NAME, dbo.DAY1.GUID_CURRENCY,                    dbo.CURRENCY.NAME AS Expr1, dbo.DAY1.CURRENCY_VAL  FROM         dbo.DAY1 INNER JOIN             dbo.JOB ON dbo.DAY1.GUID_JOB = dbo.JOB.GUID INNER JOIN          dbo.CURRENCY ON dbo.DAY1.GUID_CURRENCY = dbo.CURRENCY.GUID  where (DAY1.TYPE='00000000-0000-0000-0000-000000000000')AND ( DAY1.NUMBER_D=" & id & ")")
        Return DT
    End Function
    Public Function show_day2(ByVal parnt__ As String) As DataTable
        Dim CON As New CLS_CON
        Dim DT As New DataTable
        DT.Clear()
        DT = CON.SELECT_TXT("SELECT     dbo.ACCOUNT.GUID, dbo.ACCOUNT.Code, dbo.ACCOUNT.Name, dbo.DAY2.DEBIT, dbo.DAY2.CREDIT, dbo.DAY2.NOTE, dbo.DAY2.GUID_JOB, dbo.JOB.NAME AS Expr1, dbo.DAY2.GUID_CURRENCY,                     dbo.CURRENCY.NAME AS Expr2, dbo.DAY2.CURRENCY_VAL  FROM         dbo.DAY1 INNER JOIN                   dbo.DAY2 ON dbo.DAY1.GUID = dbo.DAY2.PAENT_GUID INNER JOIN                    dbo.ACCOUNT ON dbo.DAY2.ACCOUNT_GUID = dbo.ACCOUNT.GUID INNER JOIN                 dbo.JOB ON dbo.DAY2.GUID_JOB = dbo.JOB.GUID INNER JOIN        dbo.CURRENCY ON dbo.DAY2.GUID_CURRENCY = dbo.CURRENCY.GUID  WHERE     (dbo.DAY1.GUID = '" & parnt__ & "')  order by DAY2.id")
        Return DT
    End Function
    Public Function show_day2_CASH(ByVal parnt__ As String, ByVal GUID As String) As DataTable
        Dim CON As New CLS_CON
        Dim DT As New DataTable
        DT.Clear()
        DT = CON.SELECT_TXT("SELECT     dbo.ACCOUNT.GUID, dbo.ACCOUNT.Code, dbo.ACCOUNT.Name, dbo.DAY2.DEBIT, dbo.DAY2.CREDIT, dbo.DAY2.NOTE, dbo.DAY2.GUID_JOB, dbo.JOB.NAME AS Expr1, dbo.DAY2.GUID_CURRENCY,                     dbo.CURRENCY.NAME AS Expr2, dbo.DAY2.CURRENCY_VAL  FROM         dbo.DAY1 INNER JOIN                   dbo.DAY2 ON dbo.DAY1.GUID = dbo.DAY2.PAENT_GUID INNER JOIN                    dbo.ACCOUNT ON dbo.DAY2.ACCOUNT_GUID = dbo.ACCOUNT.GUID INNER JOIN                 dbo.JOB ON dbo.DAY2.GUID_JOB = dbo.JOB.GUID INNER JOIN        dbo.CURRENCY ON dbo.DAY2.GUID_CURRENCY = dbo.CURRENCY.GUID  WHERE     (dbo.DAY1.GUID = '" & parnt__ & "') AND(ACCOUNT.GUID <>'" & GUID & "') order by DAY2.id")
        Return DT
    End Function
    
    Public Sub delete_day2(ByVal PAENT_GUID As String)
        Dim con As New CLS_CON
        con.EXECUTE_TXT("delete from day2 where PAENT_GUID='" & PAENT_GUID & "'")
    End Sub
    Public Sub delete_day1_bill(ByVal TYPE_ As String)
        Dim con As New CLS_CON
        con.EXECUTE_TXT("delete from day1 where TYPE='" & TYPE_ & "'")
    End Sub
    Public Sub delete_day1(ByVal GUID As String)
        Dim con As New CLS_CON
        con.EXECUTE_TXT("delete from day1 where GUID='" & GUID & "'")
    End Sub
    Public Sub add_day1(ByVal NUMBER_D As Integer,
                        ByVal DATEe As DateTime,
                        ByVal NOTE As String,
                        ByVal TYPE As String,
                        ByVal note_day As String,
                        ByVal GUID_JOB As String,
                        ByVal GUID_CURRENCY As String,
                        ByVal CURRENCY_VAL As Double,
                        ByVal guid_user As String)
        Dim con As New CLS_CON
        Dim prm(8) As SqlParameter

        prm(0) = New SqlParameter("@NUMBER_D", SqlDbType.Int)
        prm(0).Value = NUMBER_D

        prm(1) = New SqlParameter("@DATE", SqlDbType.DateTime)
        prm(1).Value = DATEe

        prm(2) = New SqlParameter("@NOTE", SqlDbType.NVarChar, 500)
        prm(2).Value = NOTE

        prm(3) = New SqlParameter("@TYPE", SqlDbType.NVarChar, 500)
        prm(3).Value = TYPE
        prm(4) = New SqlParameter("@note_day", SqlDbType.NVarChar, 500)
        prm(4).Value = note_day

        prm(5) = New SqlParameter("@GUID_JOB", SqlDbType.NVarChar, 500)
        prm(5).Value = GUID_JOB
        prm(6) = New SqlParameter("@GUID_CURRENCY", SqlDbType.NVarChar, 500)
        prm(6).Value = GUID_CURRENCY
        prm(7) = New SqlParameter("@CURRENCY_VAL", SqlDbType.Float)
        prm(7).Value = CURRENCY_VAL
        prm(8) = New SqlParameter("@guid_user", SqlDbType.NVarChar, 500)
        prm(8).Value = guid_user
        con.EXECUTE_STORE("add_day1", prm)
    End Sub
    Public Sub update_day1(ByVal DATEe As DateTime,
                       ByVal NOTE As String,
                       ByVal TYPE As String,
                       ByVal note_day As String,
                       ByVal guid As String,
                         ByVal GUID_JOB As String,
                        ByVal GUID_CURRENCY As String,
                        ByVal CURRENCY_VAL As Double,
                         ByVal guid_user As String)
        Dim con As New CLS_CON
        Dim prm(8) As SqlParameter

        prm(0) = New SqlParameter("@GUID", SqlDbType.NVarChar, 500)
        prm(0).Value = guid

        prm(1) = New SqlParameter("@DATE", SqlDbType.DateTime)
        prm(1).Value = DATEe

        prm(2) = New SqlParameter("@NOTE", SqlDbType.NVarChar, 500)
        prm(2).Value = NOTE

        prm(3) = New SqlParameter("@TYPE", SqlDbType.NVarChar, 500)
        prm(3).Value = TYPE
        prm(4) = New SqlParameter("@note_day", SqlDbType.NVarChar, 500)
        prm(4).Value = note_day


        prm(5) = New SqlParameter("@GUID_JOB", SqlDbType.NVarChar, 500)
        prm(5).Value = GUID_JOB
        prm(6) = New SqlParameter("@GUID_CURRENCY", SqlDbType.NVarChar, 500)
        prm(6).Value = GUID_CURRENCY
        prm(7) = New SqlParameter("@CURRENCY_VAL", SqlDbType.Float)
        prm(7).Value = CURRENCY_VAL
        prm(8) = New SqlParameter("@guid_user", SqlDbType.NVarChar, 500)
        prm(8).Value = guid_user
        con.EXECUTE_STORE("update_day1", prm)
    End Sub
    Public Sub add_day2(ByVal PAENT_GUID As String,
                        ByVal ACCOUNT_GUID As String,
                        ByVal DEBIT As Double,
                        ByVal CREDIT As Double,
                        ByVal note As String,
                           ByVal GUID_JOB As String,
                        ByVal GUID_CURRENCY As String,
                        ByVal CURRENCY_VAL As Double)
        Dim con As New CLS_CON
        Dim prm(7) As SqlParameter

        prm(0) = New SqlParameter("@PAENT_GUID", SqlDbType.NVarChar, 500)
        prm(0).Value = PAENT_GUID
        prm(1) = New SqlParameter("@ACCOUNT_GUID", SqlDbType.NVarChar, 500)
        prm(1).Value = ACCOUNT_GUID

        prm(2) = New SqlParameter("@DEBIT", SqlDbType.Float)
        prm(2).Value = DEBIT
        prm(3) = New SqlParameter("@CREDIT", SqlDbType.Float)
        prm(3).Value = CREDIT

        prm(4) = New SqlParameter("@note", SqlDbType.NVarChar, 500)
        prm(4).Value = note

        prm(5) = New SqlParameter("@GUID_JOB", SqlDbType.NVarChar, 500)
        prm(5).Value = GUID_JOB
        prm(6) = New SqlParameter("@GUID_CURRENCY", SqlDbType.NVarChar, 500)
        prm(6).Value = GUID_CURRENCY
        prm(7) = New SqlParameter("@CURRENCY_VAL", SqlDbType.Float)
        prm(7).Value = CURRENCY_VAL

        con.EXECUTE_STORE("add_day2", prm)
    End Sub

    'Public Function rep_all_day(ByVal GUID_JOB As String, ByVal dat1 As Date, ByVal dat2 As Date) As DataTable
    '    Dim Ds As New DataTable
    '    Ds.Clear()
    '    Dim con As New CLS_CON
    '    Dim prm(2) As SqlParameter

    '    prm(0) = New SqlParameter("@dat1", SqlDbType.DateTime)
    '    prm(0).Value = dat1
    '    prm(1) = New SqlParameter("@dat2", SqlDbType.DateTime)
    '    prm(1).Value = dat2
    '    prm(2) = New SqlParameter("@GUID_JOB", SqlDbType.NVarChar, 500)
    '    prm(2).Value = GUID_JOB

    '    Ds = con.SELECT_STOE("prt_allday", prm)

    '    Return Ds
    'End Function
    Public Function rep_all_day(ByVal d1 As Date, ByVal d2 As Date, ByVal guid_JOB As String) As DataTable
        Dim Ds As New DataTable
        Ds.Clear()
        Dim DAL As New DataAccessLayer

        Dim srt1 As String = "SELECT     dbo.View_DAY1.GUID_DAY1, dbo.View_DAY1.NUMBER_DAY1, dbo.View_DAY1.DATE_DAY1, dbo.View_DAY1.NOTE_DAY1, dbo.View_DAY1.TYPE_DAY1,                      dbo.View_DAY1.NOTE_DAY1_TYPE, dbo.View_DAY1.GUID_JOB_DAY1, dbo.View_DAY1.NAME_JOBE_DAY1, dbo.View_DAY1.GUID_CURRENCY_DAY1, dbo.View_DAY1.NAME_CURRENCY_DAY1,                     dbo.View_DAY1.CURRENCY_VAL_DAY1, dbo.View_DAY2.PAENT_GUID_DAY2, dbo.View_DAY2.ACCOUNT_GUID_DAY2, dbo.View_DAY2.Name_DAY2, dbo.View_DAY2.DEBIT_DAY2,                     dbo.View_DAY2.CREDIT_DAY2, dbo.View_DAY2.NOTE_DAY2, dbo.View_DAY2.GUID_DAY2, dbo.View_DAY2.GUID_JOB_DAY2, dbo.View_DAY2.NAME_JOB_DAY2,                      dbo.View_DAY2.GUID_CURRENCY_DAY2, dbo.View_DAY2.NAME_CURRENCY_DAY2, dbo.View_DAY2.CURRENCY_VAL  FROM         dbo.View_DAY1 INNER JOIN                  dbo.View_DAY2 ON dbo.View_DAY1.GUID_DAY1 = dbo.View_DAY2.PAENT_GUID_DAY2  WHERE     (dbo.View_DAY1.DATE_DAY1 BETWEEN CONVERT(DATETIME, '" & d1.Month & "/" & d1.Day & "/" & d1.Year & "', 102) AND CONVERT(DATETIME, '" & d2.Month & "/" & d2.Day & "/" & d2.Year & "', 102))                      AND ( " & guid_JOB & "' )  ORDER BY dbo.View_DAY1.NUMBER_DAY1     "


        Ds = DAL.SelectData(srt1, Nothing)

        Return Ds
    End Function
    Public Function rep_SEARSH_ACCOUNT(guid_JOB As String, ByVal d1 As Date, ByVal d2 As Date, GUID_ACCOUNT As String) As DataTable
        Dim Ds As New DataTable
        Ds.Clear()
        Dim DAL As New DataAccessLayer

        Dim srt1 As String = "SELECT     dbo.View_DAY1.GUID_DAY1, dbo.View_DAY1.NUMBER_DAY1, dbo.View_DAY1.DATE_DAY1, dbo.View_DAY1.NOTE_DAY1, dbo.View_DAY1.TYPE_DAY1,                      dbo.View_DAY1.NOTE_DAY1_TYPE, dbo.View_DAY1.GUID_JOB_DAY1, dbo.View_DAY1.NAME_JOBE_DAY1, dbo.View_DAY1.GUID_CURRENCY_DAY1, dbo.View_DAY1.NAME_CURRENCY_DAY1,                     dbo.View_DAY1.CURRENCY_VAL_DAY1, dbo.View_DAY2.PAENT_GUID_DAY2, dbo.View_DAY2.ACCOUNT_GUID_DAY2, dbo.View_DAY2.Name_DAY2, dbo.View_DAY2.DEBIT_DAY2,                     dbo.View_DAY2.CREDIT_DAY2, dbo.View_DAY2.NOTE_DAY2, dbo.View_DAY2.GUID_DAY2, dbo.View_DAY2.GUID_JOB_DAY2, dbo.View_DAY2.NAME_JOB_DAY2,                      dbo.View_DAY2.GUID_CURRENCY_DAY2, dbo.View_DAY2.NAME_CURRENCY_DAY2, dbo.View_DAY2.CURRENCY_VAL  FROM         dbo.View_DAY1 INNER JOIN                  dbo.View_DAY2 ON dbo.View_DAY1.GUID_DAY1 = dbo.View_DAY2.PAENT_GUID_DAY2  WHERE     (dbo.View_DAY1.DATE_DAY1 BETWEEN CONVERT(DATETIME, '" & d1.Month & "/" & d1.Day & "/" & d1.Year & "', 102) AND CONVERT(DATETIME, '" & d2.Month & "/" & d2.Day & "/" & d2.Year & "', 102))            AND(View_DAY2.ACCOUNT_GUID_DAY2='" & GUID_ACCOUNT & "')          AND ( " & guid_JOB & "' )  ORDER BY dbo.View_DAY1.NUMBER_DAY1 ,dbo.View_DAY1.DATE_DAY1    "


        Ds = DAL.SelectData(srt1, Nothing)

        Return Ds
    End Function
    Public Function rep_BEFORE_ACCOUNT(guid_JOB As String, ByVal d1 As Date, GUID_ACCOUNT As String) As DataTable
        Dim Ds As New DataTable
        Ds.Clear()
        Dim DAL As New DataAccessLayer

        Dim srt1 As String = "SELECT     dbo.View_DAY1.GUID_DAY1, dbo.View_DAY1.NUMBER_DAY1, dbo.View_DAY1.DATE_DAY1, dbo.View_DAY1.NOTE_DAY1, dbo.View_DAY1.TYPE_DAY1,                      dbo.View_DAY1.NOTE_DAY1_TYPE, dbo.View_DAY1.GUID_JOB_DAY1, dbo.View_DAY1.NAME_JOBE_DAY1, dbo.View_DAY1.GUID_CURRENCY_DAY1, dbo.View_DAY1.NAME_CURRENCY_DAY1,                     dbo.View_DAY1.CURRENCY_VAL_DAY1, dbo.View_DAY2.PAENT_GUID_DAY2, dbo.View_DAY2.ACCOUNT_GUID_DAY2, dbo.View_DAY2.Name_DAY2, dbo.View_DAY2.DEBIT_DAY2,                     dbo.View_DAY2.CREDIT_DAY2, dbo.View_DAY2.NOTE_DAY2, dbo.View_DAY2.GUID_DAY2, dbo.View_DAY2.GUID_JOB_DAY2, dbo.View_DAY2.NAME_JOB_DAY2,                      dbo.View_DAY2.GUID_CURRENCY_DAY2, dbo.View_DAY2.NAME_CURRENCY_DAY2, dbo.View_DAY2.CURRENCY_VAL  FROM         dbo.View_DAY1 INNER JOIN                  dbo.View_DAY2 ON dbo.View_DAY1.GUID_DAY1 = dbo.View_DAY2.PAENT_GUID_DAY2  WHERE        (dbo.View_DAY1.DATE_DAY1 < CONVERT(DATETIME, '" & d1.Month & "/" & d1.Day & "/" & d1.Year & "', 102))             AND(View_DAY2.ACCOUNT_GUID_DAY2='" & GUID_ACCOUNT & "')          AND ( " & guid_JOB & "' )  ORDER BY dbo.View_DAY1.NUMBER_DAY1,View_DAY1.DATE_DAY1     "


        Ds = DAL.SelectData(srt1, Nothing)

        Return Ds
    End Function
    'Public Function rep_SEARSH_ACCOUNT(ByVal GUID_JOB As String, ByVal dat1 As Date, ByVal dat2 As Date, ByVal GUID_ACCOUNT As String) As DataTable
    '    Dim Ds As New DataTable
    '    Ds.Clear()
    '    Dim con As New CLS_CON
    '    Dim prm(3) As SqlParameter

    '    prm(0) = New SqlParameter("@dat1", SqlDbType.DateTime)
    '    prm(0).Value = dat1
    '    prm(1) = New SqlParameter("@dat2", SqlDbType.DateTime)
    '    prm(1).Value = dat2
    '    prm(2) = New SqlParameter("@GUID_JOB", SqlDbType.NVarChar, 500)
    '    prm(2).Value = GUID_JOB

    '    prm(3) = New SqlParameter("@guid_ACCOUNT", SqlDbType.NVarChar, 500)
    '    prm(3).Value = GUID_ACCOUNT
    '    Ds = con.SELECT_STOE("prt_SEARSHACCOUNT", prm)

    '    Return Ds
    'End Function
    Public Function rep_BALANCE_ACCOUNT(ByVal GUID_JOB As String, ByVal dat1 As Date, ByVal dat2 As Date) As DataTable
        Dim Ds As New DataTable
        Ds.Clear()
        Dim con As New CLS_CON
        Dim prm(2) As SqlParameter

        prm(0) = New SqlParameter("@dat1", SqlDbType.DateTime)
        prm(0).Value = dat1
        prm(1) = New SqlParameter("@dat2", SqlDbType.DateTime)
        prm(1).Value = dat2
        prm(2) = New SqlParameter("@guid_job", SqlDbType.NVarChar, 500)
        prm(2).Value = GUID_JOB

        Ds = con.SELECT_STOE("prt_BALANCEACCOUNT", prm)

        Return Ds
    End Function
    Function final__(ByVal id_final As Integer, ByVal dat1 As Date, ByVal dat2 As Date) As DataTable
        Dim DT As New DataTable
        DT.Clear()
        Dim con As New CLS_CON
        Dim PRM(2) As SqlParameter

        PRM(0) = New SqlParameter("@dat1", SqlDbType.DateTime)
        PRM(0).Value = dat1
        PRM(1) = New SqlParameter("@dat2", SqlDbType.DateTime)
        PRM(1).Value = dat2
        PRM(2) = New SqlParameter("@END_ACCOUNT", SqlDbType.Int)
        PRM(2).Value = id_final

        DT = con.SELECT_STOE("prt_final", PRM)
        Return DT

    End Function
    Public Sub UPDATE_BETWEEN(ByVal GUIDTO As String, ByVal GUIDFROM As String, ByVal D1 As DateTime, ByVal D2 As DateTime)
        Dim con As New CLS_CON
        con.EXECUTE_TXT("UPDATE DAY2 SET ACCOUNT_GUID = '" & GUIDTO & "' FROM DAY2 INNER JOIN DAY1  ON DAY2.PAENT_GUID = DAY1.GUID   WHERE     (dbo.DAY2.ACCOUNT_GUID = '" & GUIDFROM & "') AND  (dbo.DAY1.DATE BETWEEN CONVERT(DATETIME, '" & D1.Month & "/" & D1.Day & "/" & D1.Year & "', 102) AND CONVERT(DATETIME, '" & D2.Month & "/" & D2.Day & "/" & D2.Year & "', 102))                      ")
    End Sub
    Public Function delete_account(ByVal guid As String) As DataTable
        Dim CON As New CLS_CON
        Dim DT As New DataTable
        DT.Clear()
        DT = CON.SELECT_TXT("SELECT * FROM DAY2 where ACCOUNT_GUID='" & guid & "'")
        Return DT
    End Function
    Function SEARSH_DRS_MONYE_date(ByVal ACCOUNT_GUID As String, ByVal d1 As DateTime, ByVal d2 As DateTime)
        Dim DAL As New CLS_CON
        Dim DT As New DataTable
        DT.Clear()
        DT = DAL.SELECT_TXT("SELECT     SUM(dbo.DAY2.DEBIT) AS Expr1  FROM         dbo.DAY1 INNER JOIN                     dbo.DAY2 ON dbo.DAY1.GUID = dbo.DAY2.PAENT_GUID  WHERE     (dbo.DAY2.ACCOUNT_GUID = '" & ACCOUNT_GUID & "') AND (dbo.DAY1.DATE >=  '" & d1.Month & "/" & d1.Day & "/" & d1.Year & "' And DAY1.DATE <='" & d2.Month & "/" & d2.Day & "/" & d2.Year & "' )")

        Return DT
    End Function
    Function SEARSH_DRS_MONYE_dateC(ByVal ACCOUNT_GUID As String, ByVal d1 As DateTime, ByVal d2 As DateTime)
        Dim DAL As New CLS_CON
        Dim DT As New DataTable
        DT.Clear()
        DT = DAL.SELECT_TXT("SELECT     SUM(dbo.DAY2.CREDIT) AS Expr1  FROM         dbo.DAY1 INNER JOIN                     dbo.DAY2 ON dbo.DAY1.GUID = dbo.DAY2.PAENT_GUID  WHERE     (dbo.DAY2.ACCOUNT_GUID = '" & ACCOUNT_GUID & "') AND (dbo.DAY1.DATE >=  '" & d1.Month & "/" & d1.Day & "/" & d1.Year & "' And DAY1.DATE <='" & d2.Month & "/" & d2.Day & "/" & d2.Year & "' )")

        Return DT
    End Function
End Class
