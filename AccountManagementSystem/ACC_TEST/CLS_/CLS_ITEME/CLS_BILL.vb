Imports System.Data.SqlClient
Public Class CLS_BILL
    Public Sub ADD_BILL1(ByVal PARENT_GUID As String,
                         ByVal NUMBER As Integer,
                         ByVal CUST As String,
                         ByVal NOTE As String,
                         ByVal STORE_GUID As String,
                         ByVal DATEE As DateTime,
                         ByVal disc_ As Double,
                         ByVal type_pay As String,
                         ByVal GUID_JOB As String,
                         ByVal GUID_CURRENCY As String,
                         ByVal CURRENCY_VAL As Double,
                         ByVal DELETE_NUM As Integer,
                         ByVal guid_user As String,
                         ByVal EXTEA As Double,
                         ByVal p_disc As Double,
                         ByVal p_extra As Double,
                         ByVal total_ As Double,
                         ByVal type_dis As Double,
                        ByVal disc_rate As Double,
                        ByVal CUSTOMER_NAME As String,
                        ByVal CUSTOMER_MOBILE1 As String,
                        ByVal CUSTOMER_MOBILE2 As String,
                        ByVal CUSTOMER_COMPANY As String,
                        ByVal CUSTOMER_STREET As String,
                        ByVal CUSTOMER_PHON As String,
                        ByVal CUSTOMER_EMAIL As String,
                        ByVal PAY_1_PAY As Double,
                        ByVal PAY_1_GUID As String,
                        ByVal TRAN_POS_GUID As String,
                        ByVal TRAN_POS_PAY As Double,
                        ByVal employee_pos As String,
                        ByVal time_bill As DateTime)
        Dim CON As New CLS_CON
        Dim prm(31) As SqlParameter

        prm(0) = New SqlParameter("@PARENT_GUID", SqlDbType.NVarChar, 500)
        prm(0).Value = PARENT_GUID
        prm(1) = New SqlParameter("@NUMBER", SqlDbType.Int)
        prm(1).Value = NUMBER
        prm(2) = New SqlParameter("@CUST", SqlDbType.NVarChar, 500)
        prm(2).Value = CUST
        prm(3) = New SqlParameter("@NOTE", SqlDbType.NVarChar, 500)
        prm(3).Value = NOTE
        prm(4) = New SqlParameter("@STORE_GUID", SqlDbType.NVarChar, 500)
        prm(4).Value = STORE_GUID
        prm(5) = New SqlParameter("@DATE", SqlDbType.DateTime)
        prm(5).Value = DATEE

        prm(6) = New SqlParameter("@disc", SqlDbType.Float)
        prm(6).Value = disc_
        prm(7) = New SqlParameter("@type_pay", SqlDbType.NVarChar, 500)
        prm(7).Value = type_pay

        prm(8) = New SqlParameter("@GUID_JOB", SqlDbType.NVarChar, 500)
        prm(8).Value = GUID_JOB
        prm(9) = New SqlParameter("@GUID_CURRENCY", SqlDbType.NVarChar, 500)
        prm(9).Value = GUID_CURRENCY
        prm(10) = New SqlParameter("@CURRENCY_VAL", SqlDbType.Float)
        prm(10).Value = CURRENCY_VAL

        prm(11) = New SqlParameter("@DELETE_NUM", SqlDbType.Int)
        prm(11).Value = DELETE_NUM

        prm(12) = New SqlParameter("@guid_user", SqlDbType.NVarChar, 500)
        prm(12).Value = guid_user
        prm(13) = New SqlParameter("@EXTEA", SqlDbType.Float)
        prm(13).Value = EXTEA



        prm(14) = New SqlParameter("@p_disc", SqlDbType.Float)
        prm(14).Value = p_disc
        prm(15) = New SqlParameter("@p_extra", SqlDbType.Float)
        prm(15).Value = p_extra
        prm(16) = New SqlParameter("@total", SqlDbType.Float)
        prm(16).Value = total_

        prm(17) = New SqlParameter("@type_dis", SqlDbType.Float)
        prm(17).Value = type_dis
        prm(18) = New SqlParameter("@disc_rate", SqlDbType.Float)
        prm(18).Value = disc_rate

        prm(19) = New SqlParameter("@CUSTOMER_NAME", SqlDbType.NVarChar, 500)
        prm(19).Value = CUSTOMER_NAME
        prm(20) = New SqlParameter("@CUSTOMER_MOBILE1", SqlDbType.NVarChar, 500)
        prm(20).Value = CUSTOMER_MOBILE1
        prm(21) = New SqlParameter("@CUSTOMER_MOBILE2", SqlDbType.NVarChar, 500)
        prm(21).Value = CUSTOMER_MOBILE2


        prm(22) = New SqlParameter("@CUSTOMER_COMPANY", SqlDbType.NVarChar, 500)
        prm(22).Value = CUSTOMER_COMPANY
        prm(23) = New SqlParameter("@CUSTOMER_STREET", SqlDbType.NVarChar, 500)
        prm(23).Value = CUSTOMER_STREET
        prm(24) = New SqlParameter("@CUSTOMER_PHON", SqlDbType.NVarChar, 500)
        prm(24).Value = CUSTOMER_PHON

        prm(25) = New SqlParameter("@CUSTOMER_EMAIL", SqlDbType.NVarChar, 500)
        prm(25).Value = CUSTOMER_EMAIL
        prm(26) = New SqlParameter("@PAY_1_PAY", SqlDbType.Float)
        prm(26).Value = PAY_1_PAY
        prm(27) = New SqlParameter("PAY_1_GUID", SqlDbType.NVarChar, 500)
        prm(27).Value = PAY_1_GUID

        prm(28) = New SqlParameter("@TRAN_POS_GUID", SqlDbType.NVarChar, 500)
        prm(28).Value = TRAN_POS_GUID
        prm(29) = New SqlParameter("@TRAN_POS_PAY", SqlDbType.Float)
        prm(29).Value = TRAN_POS_PAY

        prm(30) = New SqlParameter("@employee_pos", SqlDbType.NVarChar, 500)
        prm(30).Value = employee_pos
        prm(31) = New SqlParameter("@time_bill", SqlDbType.DateTime)
        prm(31).Value = time_bill

        '" & d1.Month & "/" & d1.Day & "/" & d1.Year & "'
        CON.EXECUTE_STORE("add_bill1", prm)
    End Sub
    Public Sub update_BILL1(ByVal PARENT_GUID As String,
                       ByVal NUMBER As Integer,
                       ByVal CUST As String,
                       ByVal NOTE As String,
                       ByVal STORE_GUID As String,
                       ByVal DATEE As DateTime,
                       ByVal disc_ As Double,
                       ByVal type_pay As String,
                       ByVal GUID_JOB As String,
                       ByVal GUID_CURRENCY As String,
                       ByVal CURRENCY_VAL As Double,
                       ByVal guid As String,
                       ByVal guid_user As String,
                        ByVal EXTEA As Double,
                         ByVal p_disc As Double,
                         ByVal p_extra As Double,
                        ByVal total_ As Double,
                        ByVal type_dis As Double,
                        ByVal disc_rate As Double,
                          ByVal CUSTOMER_NAME As String,
                        ByVal CUSTOMER_MOBILE1 As String,
                        ByVal CUSTOMER_MOBILE2 As String,
                        ByVal CUSTOMER_COMPANY As String,
                        ByVal CUSTOMER_STREET As String,
                        ByVal CUSTOMER_PHON As String,
                        ByVal CUSTOMER_EMAIL As String,
                        ByVal PAY_1_PAY As Double,
                        ByVal PAY_1_GUID As String,
                        ByVal TRAN_POS_GUID As String,
                        ByVal TRAN_POS_PAY As Double,
                         ByVal employee_pos As String,
                        ByVal time_bill As DateTime)
        Dim CON As New CLS_CON
        Dim prm(31) As SqlParameter

        prm(0) = New SqlParameter("@PARENT_GUID", SqlDbType.NVarChar, 500)
        prm(0).Value = PARENT_GUID
        prm(1) = New SqlParameter("@NUMBER", SqlDbType.Int)
        prm(1).Value = NUMBER
        prm(2) = New SqlParameter("@CUST", SqlDbType.NVarChar, 500)
        prm(2).Value = CUST
        prm(3) = New SqlParameter("@NOTE", SqlDbType.NVarChar, 500)
        prm(3).Value = NOTE
        prm(4) = New SqlParameter("@STORE_GUID", SqlDbType.NVarChar, 500)
        prm(4).Value = STORE_GUID
        prm(5) = New SqlParameter("@DATE", SqlDbType.DateTime)
        prm(5).Value = DATEE

        prm(6) = New SqlParameter("@disc", SqlDbType.Float)
        prm(6).Value = disc_
        prm(7) = New SqlParameter("@type_pay", SqlDbType.NVarChar, 500)
        prm(7).Value = type_pay

        prm(8) = New SqlParameter("@GUID_JOB", SqlDbType.NVarChar, 500)
        prm(8).Value = GUID_JOB
        prm(9) = New SqlParameter("@GUID_CURRENCY", SqlDbType.NVarChar, 500)
        prm(9).Value = GUID_CURRENCY
        prm(10) = New SqlParameter("@CURRENCY_VAL", SqlDbType.Float)
        prm(10).Value = CURRENCY_VAL
        prm(11) = New SqlParameter("@guid", SqlDbType.NVarChar, 500)
        prm(11).Value = guid
        prm(12) = New SqlParameter("@guid_user", SqlDbType.NVarChar, 500)
        prm(12).Value = guid_user
        prm(13) = New SqlParameter("@EXTEA", SqlDbType.Float)
        prm(13).Value = EXTEA
        prm(14) = New SqlParameter("@p_disc", SqlDbType.Float)
        prm(14).Value = p_disc
        prm(15) = New SqlParameter("@p_extra", SqlDbType.Float)
        prm(15).Value = p_extra
        prm(16) = New SqlParameter("@total", SqlDbType.Float)
        prm(16).Value = total_

        prm(17) = New SqlParameter("@type_dis", SqlDbType.Float)
        prm(17).Value = type_dis
        prm(18) = New SqlParameter("@disc_rate", SqlDbType.Float)
        prm(18).Value = disc_rate

        prm(19) = New SqlParameter("@CUSTOMER_NAME", SqlDbType.NVarChar, 500)
        prm(19).Value = CUSTOMER_NAME
        prm(20) = New SqlParameter("@CUSTOMER_MOBILE1", SqlDbType.NVarChar, 500)
        prm(20).Value = CUSTOMER_MOBILE1
        prm(21) = New SqlParameter("@CUSTOMER_MOBILE2", SqlDbType.NVarChar, 500)
        prm(21).Value = CUSTOMER_MOBILE2


        prm(22) = New SqlParameter("@CUSTOMER_COMPANY", SqlDbType.NVarChar, 500)
        prm(22).Value = CUSTOMER_COMPANY
        prm(23) = New SqlParameter("@CUSTOMER_STREET", SqlDbType.NVarChar, 500)
        prm(23).Value = CUSTOMER_STREET
        prm(24) = New SqlParameter("@CUSTOMER_PHON", SqlDbType.NVarChar, 500)
        prm(24).Value = CUSTOMER_PHON

        prm(25) = New SqlParameter("@CUSTOMER_EMAIL", SqlDbType.NVarChar, 500)
        prm(25).Value = CUSTOMER_EMAIL
        prm(26) = New SqlParameter("@PAY_1_PAY", SqlDbType.Float)
        prm(26).Value = PAY_1_PAY
        prm(27) = New SqlParameter("PAY_1_GUID", SqlDbType.NVarChar, 500)
        prm(27).Value = PAY_1_GUID

        prm(28) = New SqlParameter("@TRAN_POS_GUID", SqlDbType.NVarChar, 500)
        prm(28).Value = TRAN_POS_GUID
        prm(29) = New SqlParameter("@TRAN_POS_PAY", SqlDbType.Float)
        prm(29).Value = TRAN_POS_PAY
        prm(30) = New SqlParameter("@employee_pos", SqlDbType.NVarChar, 500)
        prm(30).Value = employee_pos
        prm(31) = New SqlParameter("@time_bill", SqlDbType.DateTime)
        prm(31).Value = time_bill

        CON.EXECUTE_STORE("update_bill1", prm)

    End Sub
    Public Sub ADD_BILL2(ByVal PARENT_GUID As String,
                         ByVal GUID_ITEME As String,
                         ByVal QTY As Double,
                         ByVal PRICE As Double,
                         ByVal NOTE As String,
                         ByVal disc As Double,
                         ByVal extra As Double,
                         ByVal guid_store As String,
                        ByVal unit_ As String,
                        ByVal qty_unit As Double,
                       ByVal recpt As Integer,
                       ByVal barcode As String)
        Dim CON As New CLS_CON
        Dim prm(11) As SqlParameter

        prm(0) = New SqlParameter("@PARENT_GUID", SqlDbType.NVarChar, 500)
        prm(0).Value = PARENT_GUID
        prm(1) = New SqlParameter("@GUID_ITEME", SqlDbType.NVarChar, 500)
        prm(1).Value = GUID_ITEME
        prm(2) = New SqlParameter("@QTY", SqlDbType.Float)
        prm(2).Value = QTY
        prm(3) = New SqlParameter("@PRICE", SqlDbType.Float)
        prm(3).Value = PRICE
        prm(4) = New SqlParameter("@NOTE", SqlDbType.NVarChar, 500)
        prm(4).Value = NOTE


        prm(5) = New SqlParameter("@disc", SqlDbType.Float)
        prm(5).Value = disc
        prm(6) = New SqlParameter("@extra", SqlDbType.Float)
        prm(6).Value = extra

        prm(7) = New SqlParameter("@guid_store", SqlDbType.NVarChar, 500)
        prm(7).Value = guid_store
        prm(8) = New SqlParameter("@unit", SqlDbType.NVarChar, 500)
        prm(8).Value = unit_

        prm(9) = New SqlParameter("@qty_unit", SqlDbType.Float)
        prm(9).Value = qty_unit
        prm(10) = New SqlParameter("@recpt", SqlDbType.Float)
        prm(10).Value = recpt
        prm(11) = New SqlParameter("@barcode", SqlDbType.NVarChar, 500)
        prm(11).Value = barcode


        CON.EXECUTE_STORE("add_bill2", prm)
    End Sub

    Public Sub delete_bill2(ByVal GUID As String)

        Dim CON As New CLS_CON
        CON.EXECUTE_TXT("delete     from BILL2 where   PARENT_GUID='" & GUID & "'")
        'CON.EXECUTE_TXT("delete     from BILL2 where   PARENT_GUID='" & GUID & "'")
    End Sub
    Public Sub delete_bill1(ByVal GUID As String)

        Dim CON As New CLS_CON
        CON.EXECUTE_TXT("delete     from BILL1 where   GUID='" & GUID & "'")
        'CON.EXECUTE_TXT("update      BILL1 set DELETE_NUM=1,Date_Delete= '" & d1.Month & "/" & d1.Day & "/" & d1.Year & "' where    GUID='" & GUID & "'")

    End Sub
    Public Function MAX_1(ByVal PARENT_ As String) As DataTable
        Dim CON As New CLS_CON
        Dim DT As New DataTable
        DT.Clear()
        DT = CON.SELECT_TXT("SELECT ISNULL(MAX(NUMBER)+1,1) FROM BILL1 WHERE (BILL1.DELETE_NUM=0) and(PARENT_GUID='" & PARENT_ & "')")
        Return DT
    End Function
    Public Function guid__(ByVal PARENT_GUID As String, ByVal NUMBER As Integer) As DataTable
        Dim CON As New CLS_CON
        Dim DT As New DataTable
        DT.Clear()
        DT = CON.SELECT_TXT("SELECT guid FROM BILL1 where (BILL1.DELETE_NUM=0) and(PARENT_GUID='" & PARENT_GUID & "') and  (NUMBER=" & NUMBER & ")")
        Return DT
    End Function
    Public Function MAX_(ByVal PARENT_ As String) As DataTable
        Dim CON As New CLS_CON
        Dim DT As New DataTable
        DT.Clear()
        DT = CON.SELECT_TXT("SELECT ISNULL(MAX(NUMBER),1) FROM BILL1 WHERE (BILL1.DELETE_NUM=0) and (PARENT_GUID='" & PARENT_ & "')")
        Return DT
    End Function
    Public Function MIN_(ByVal PARENT_ As String) As DataTable
        Dim CON As New CLS_CON
        Dim DT As New DataTable
        DT.Clear()
        DT = CON.SELECT_TXT("SELECT ISNULL(MIN(NUMBER),1) FROM BILL1 WHERE (BILL1.DELETE_NUM=0) and(PARENT_GUID='" & PARENT_ & "')")
        Return DT
    End Function
    Public Function show_bill1_DELETE(ByVal NUMBER As Integer, ByVal PARENT_GUID As String) As DataTable
        Dim CON As New CLS_CON
        Dim DT As New DataTable
        DT.Clear()
        '                                    0                   1                       2                  3                         4               5             6                                       7                   8                      9                10                    11               12                  13                            14                      15           16             17                   18                           19                           20                  21                        22                          23                        24                   25                  26                 27                  28
        DT = CON.SELECT_TXT("   SELECT     dbo.BILL1.DATE, dbo.user000.name,BILL1.GUID  FROM         dbo.BILL1 INNER JOIN                    dbo.user000 ON dbo.BILL1.guid_user = dbo.user000.guid WHERE(BILL1.NUMBER= " & NUMBER & " )AND(BILL1.PARENT_GUID='" & PARENT_GUID & "')")
        Return DT
    End Function
    Public Function show_bill1(ByVal id_ As Integer, ByVal PARENT_ As String) As DataTable
        Dim CON As New CLS_CON
        Dim DT As New DataTable
        DT.Clear()
        '                                    0                   1                       2                  3                         4               5             6                                       7                   8                      9                10                    11               12                  13                            14                      15           16             17                   18                           19                           20                  21                        22                          23                        24                   25                  26                 27                  28
        DT = CON.SELECT_TXT("SELECT     dbo.BILL1.GUID, dbo.BILL1.PARENT_GUID, dbo.BILL1.NUMBER, dbo.BILL1.DELETE_NUM, dbo.BILL1.CUST, dbo.BILL1.Date_Delete, dbo.BILL1.NOTE, dbo.BILL1.STORE_GUID,                      dbo.STORE.NAME AS Expr2, dbo.BILL1.DATE, dbo.BILL1.disc, dbo.BILL1.type_pay, dbo.BILL1.GUID_CURRENCY, dbo.CURRENCY.NAME AS Expr3, dbo.BILL1.CURRENCY_VAL, dbo.BILL1.EXTEA,                   dbo.BILL1.type_dis, dbo.BILL1.disc_rate, dbo.BILL1.CUSTOMER_NAME, dbo.BILL1.CUSTOMER_MOBILE1, dbo.BILL1.CUSTOMER_MOBILE2,               dbo.BILL1.CUSTOMER_COMPANY, dbo.BILL1.CUSTOMER_STREET, dbo.BILL1.CUSTOMER_PHON, dbo.BILL1.CUSTOMER_EMAIL, dbo.BILL1.PAY_1_PAY, dbo.BILL1.PAY_1_GUID,                  dbo.BILL1.TRAN_POS_GUID, dbo.BILL1.TRAN_POS_PAY FROM         dbo.BILL1 INNER JOIN                     dbo.STORE ON dbo.BILL1.STORE_GUID = dbo.STORE.GUID INNER JOIN                   dbo.CURRENCY ON dbo.BILL1.GUID_CURRENCY = dbo.CURRENCY.GUID where (BILL1.DELETE_NUM=0) and(BILL1.PARENT_GUID='" & PARENT_ & "')and(BILL1.NUMBER=" & id_ & ")")
        Return DT
    End Function
    Public Function show_bill1_B(ByVal id_ As Integer, ByVal PARENT_ As String) As DataTable
        Dim CON As New CLS_CON
        Dim DT As New DataTable
        DT.Clear()
        '                                    0                   1                       2                  3                         4               5             6                                       7                   8                      9                10                    11               12                  13                            14
        DT = CON.SELECT_TXT("SELECT     dbo.BILL1.GUID, dbo.BILL1.PARENT_GUID, dbo.BILL1.NUMBER, dbo.BILL1.DELETE_NUM, dbo.BILL1.CUST, dbo.BILL1.Date_Delete, dbo.BILL1.NOTE, dbo.BILL1.STORE_GUID,                      dbo.STORE.NAME AS Expr2, dbo.BILL1.DATE, dbo.BILL1.disc, dbo.BILL1.type_pay, dbo.BILL1.GUID_CURRENCY, dbo.CURRENCY.NAME AS Expr3, dbo.BILL1.CURRENCY_VAL, dbo.BILL1.EXTEA  FROM         dbo.BILL1 INNER JOIN                     dbo.STORE ON dbo.BILL1.STORE_GUID = dbo.STORE.GUID INNER JOIN                dbo.CURRENCY ON dbo.BILL1.GUID_CURRENCY = dbo.CURRENCY.GUID where (BILL1.DELETE_NUM=0) and(BILL1.PARENT_GUID='" & PARENT_ & "')and(BILL1.NUMBER=" & id_ & ")")
        Return DT
    End Function
    Public Function show_bil2(ByVal PARENT_ As String) As DataTable
        Dim CON As New CLS_CON
        Dim DT As New DataTable
        DT.Clear()
         DT = CON.SELECT_TXT("SELECT     dbo.BILL2.GUID_ITEME, dbo.BILL2.barcode, dbo.ITEME.NAME, dbo.BILL2.QTY, dbo.BILL2.PRICE, dbo.BILL2.disc, dbo.BILL2.extra,                    dbo.BILL2.PRICE * dbo.BILL2.QTY - dbo.BILL2.disc + dbo.BILL2.extra AS Expr1, dbo.BILL2.NOTE, dbo.BILL2.unit, dbo.BILL2.qty_unit, dbo.BILL2.guid_store, dbo.STORE.NAME AS Expr2,                     dbo.BILL2.recpt   FROM         dbo.BILL2 INNER JOIN                    dbo.ITEME ON dbo.BILL2.GUID_ITEME = dbo.ITEME.GUID INNER JOIN               dbo.STORE ON dbo.BILL2.guid_store = dbo.STORE.GUID where (         dbo.BILL2.PARENT_GUID='" & PARENT_ & "') order by  BILL2.id")
        Return DT
    End Function

    Public Sub UPDATE_BETWEEN(ByVal GUIDTO As String, ByVal GUIDFROM As String, ByVal D1 As DateTime, ByVal D2 As DateTime)
        Dim con As New CLS_CON
        con.EXECUTE_TXT("UPDATE BILL1 SET CUST = '" & GUIDTO & "'     WHERE     (CUST = '" & GUIDFROM & "') AND  (DATE BETWEEN CONVERT(DATETIME, '" & D1.Month & "/" & D1.Day & "/" & D1.Year & "', 102) AND CONVERT(DATETIME, '" & D2.Month & "/" & D2.Day & "/" & D2.Year & "', 102))                      ")
    End Sub
    Public Function rep_all_bill(ByVal GUID_JOB As String, ByVal dat1 As Date, ByVal dat2 As Date) As DataTable
        Dim Ds As New DataTable
        Ds.Clear()
        Dim con As New CLS_CON
        Dim prm(2) As SqlParameter

        prm(0) = New SqlParameter("@dat1", SqlDbType.DateTime)
        prm(0).Value = dat1
        prm(1) = New SqlParameter("@dat2", SqlDbType.DateTime)
        prm(1).Value = dat2
        prm(2) = New SqlParameter("@GUID_JOB", SqlDbType.NVarChar, 500)
        prm(2).Value = GUID_JOB

        Ds = con.SELECT_STOE("prt_allbill", prm)

        Return Ds
    End Function
    Public Function rep_BALANCE_DATE(ByVal dat1 As Date, ByVal dat2 As Date) As DataTable
        Dim Ds As New DataTable
        Ds.Clear()
        Dim con As New CLS_CON
        Dim prm(1) As SqlParameter

        prm(0) = New SqlParameter("@dat1", SqlDbType.DateTime)
        prm(0).Value = dat1
        prm(1) = New SqlParameter("@dat2", SqlDbType.DateTime)
        prm(1).Value = dat2
 

        Ds = con.SELECT_STOE("BALANCE_ITEME_DATE", prm)

        Return Ds
    End Function
    Public Function rep_ITEME(ByVal GUID_JOB As String, ByVal dat1 As Date, ByVal dat2 As Date, ByVal GUID_ITEME As String) As DataTable
        Dim Ds As New DataTable
        Ds.Clear()
        Dim con As New CLS_CON
        Dim prm(3) As SqlParameter

        prm(0) = New SqlParameter("@dat1", SqlDbType.DateTime)
        prm(0).Value = dat1
        prm(1) = New SqlParameter("@dat2", SqlDbType.DateTime)
        prm(1).Value = dat2
        prm(2) = New SqlParameter("@GUID_JOB", SqlDbType.NVarChar, 500)
        prm(2).Value = GUID_JOB
        prm(3) = New SqlParameter("@GUID_ITEME", SqlDbType.NVarChar, 500)
        prm(3).Value = GUID_ITEME
        Ds = con.SELECT_STOE("prt_ITEME", prm)

        Return Ds
    End Function
    Public Function SEARSH__all_(ByVal d1 As Date, ByVal d2 As Date, ByVal guid_JOB As String, ByVal guid_STORE As String, ByVal CATEGORY As String, ByVal PARENT_GUID As String) As DataTable
        Dim Ds As New DataTable
        Ds.Clear()
        Dim DAL As New DataAccessLayer

        Dim srt1 As String = "  SELECT     dbo.BILL1.DATE, dbo.BILL1.NUMBER, dbo.TYPE_BILL.NAME, .BILL1.CUSTOMER_NAME AS [الطرف الثاني],                       dbo.BILL1.NOTE, (CASE [BILL1].[GUID_JOB] WHEN 0x0 THEN '' ELSE ISNULL(dbo.fnGetjobName([BILL1].[GUID_JOB]), '') END) AS [مركز كلفة], dbo.CURRENCY.NAME AS العملة,                       dbo.BILL1.CURRENCY_VAL AS التعادل, dbo.BILL2.barcode AS الباركود, dbo.ITEME.NAME AS المادة, dbo.BILL2.QTY AS الكمية, dbo.BILL2.PRICE AS السعر, dbo.BILL2.disc AS الحسم, dbo.BILL2.extra AS الاضافي,                      dbo.BILL2.PRICE * dbo.BILL2.QTY - dbo.BILL2.disc + dbo.BILL2.extra AS الاجمالي, dbo.BILL2.unit AS الوحدة,                      (CASE [BILL1].[STORE_GUID] WHEN 0x0 THEN '' ELSE ISNULL(dbo.fnGetStoreName([BILL1].[STORE_GUID]), '') END) AS store  FROM         dbo.BILL1 INNER JOIN                     dbo.BILL2 ON dbo.BILL1.GUID = dbo.BILL2.PARENT_GUID INNER JOIN                    dbo.ITEME ON dbo.BILL2.GUID_ITEME = dbo.ITEME.GUID INNER JOIN                     dbo.TYPE_BILL ON dbo.BILL1.PARENT_GUID = dbo.TYPE_BILL.GUID INNER JOIN                  dbo.CURRENCY ON dbo.BILL1.GUID_CURRENCY = dbo.CURRENCY.GUID     WHERE (BILL1.DELETE_NUM=0)and  (BILL1.DATE BETWEEN CONVERT(DATETIME, '" & d1.Month & "/" & d1.Day & "/" & d1.Year & "', 102) AND CONVERT(DATETIME, '" & d2.Month & "/" & d2.Day & "/" & d2.Year & "', 102)) AND ( " & PARENT_GUID & "' ) AND ( " & guid_JOB & "' ) AND ( " & guid_STORE & "' ) AND ( " & CATEGORY & "' )  ORDER BY dbo.BILL1.DATE,BILL1.NUMBER  "


        Ds = DAL.SelectData(srt1, Nothing)

        Return Ds
    End Function

    Public Function delete_account(ByVal guid As String) As DataTable
        Dim CON As New CLS_CON
        Dim DT As New DataTable
        DT.Clear()
        DT = CON.SELECT_TXT("SELECT * FROM BILL1 where  (CUST='" & guid & "')")
        Return DT
    End Function
    Public Function SEARSH__all_STOCK(ByVal d1 As DateTime, ByVal d2 As DateTime) As DataTable
        Dim Ds As New DataTable
        Ds.Clear()
        Dim DAL As New DataAccessLayer

        'Dim srt1 As String = "  SELECT     dbo.BILL1.DATE, dbo.BILL1.NUMBER, dbo.TYPE_BILL.NAME, (CASE [BILL1].[CUST] WHEN 0x0 THEN '' ELSE ISNULL(dbo.fnGetAccountName([BILL1].[CUST]), '') END) AS [الطرف الثاني],                       dbo.BILL1.NOTE, (CASE [BILL1].[GUID_JOB] WHEN 0x0 THEN '' ELSE ISNULL(dbo.fnGetjobName([BILL1].[GUID_JOB]), '') END) AS [مركز كلفة], dbo.CURRENCY.NAME AS العملة,                       dbo.BILL1.CURRENCY_VAL AS التعادل, dbo.BILL2.barcode AS الباركود, dbo.ITEME.NAME AS المادة, dbo.BILL2.QTY AS الكمية, dbo.BILL2.PRICE AS السعر, dbo.BILL2.disc AS الحسم, dbo.BILL2.extra AS الاضافي,                      dbo.BILL2.PRICE * dbo.BILL2.QTY - dbo.BILL2.disc + dbo.BILL2.extra AS الاجمالي, dbo.BILL2.unit AS الوحدة,                      (CASE [BILL1].[STORE_GUID] WHEN 0x0 THEN '' ELSE ISNULL(dbo.fnGetStoreName([BILL1].[STORE_GUID]), '') END) AS store  FROM         dbo.BILL1 INNER JOIN                     dbo.BILL2 ON dbo.BILL1.GUID = dbo.BILL2.PARENT_GUID INNER JOIN                    dbo.ITEME ON dbo.BILL2.GUID_ITEME = dbo.ITEME.GUID INNER JOIN                     dbo.TYPE_BILL ON dbo.BILL1.PARENT_GUID = dbo.TYPE_BILL.GUID INNER JOIN                  dbo.CURRENCY ON dbo.BILL1.GUID_CURRENCY = dbo.CURRENCY.GUID     WHERE  (BILL1.DATE BETWEEN CONVERT(DATETIME, '" & d1.Month & "/" & d1.Day & "/" & d1.Year & "', 102) AND CONVERT(DATETIME, '" & d2.Month & "/" & d2.Day & "/" & d2.Year & "', 102))  "
        Dim srt1 As String = "SELECT     dbo.TYPE_BILL.NAME, SUM(dbo.BILL1.total) AS Expr1  FROM         dbo.BILL1 INNER JOIN                       dbo.TYPE_BILL ON dbo.BILL1.PARENT_GUID = dbo.TYPE_BILL.GUID   WHERE     (dbo.BILL1.DATE BETWEEN CONVERT(DATETIME, '" & d1.Month & "/" & d1.Day & "/" & d1.Year & "', 102) AND CONVERT(DATETIME, '" & d2.Month & "/" & d2.Day & "/" & d2.Year & "', 102))   GROUP BY dbo.TYPE_BILL.NAME "


        Ds = DAL.SelectData(srt1, Nothing)

        Return Ds
    End Function
End Class
