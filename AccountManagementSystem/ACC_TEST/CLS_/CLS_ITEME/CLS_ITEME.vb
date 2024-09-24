Imports System.Data.SqlClient
Public Class CLS_ITEME
    Public Sub ADD_(ByVal NAMEE As String,
                    ByVal NOTE As String,
                    ByVal GROUP_GUID As String,
                    ByVal BALANCE As Double,
                    ByVal avg_price As String,
                    ByVal IMG As Byte(),
                    ByVal UNIT1 As String,
                    ByVal UNIT2 As String,
                    ByVal UNIT3 As String,
                   ByVal QTY_UNIT1 As Double,
                   ByVal QTY_UNIT2 As Double,
                   ByVal QTY_UNIT3 As Double,
                   ByVal BARCODE_1 As String,
                   ByVal BARCODE_2 As String,
                   ByVal BARCODE_3 As String,
                   ByVal latin_name As String,
                   ByVal Company As String,
                   ByVal Provenance As String,
                   ByVal Quality As String,
                   ByVal Color As String,
                   ByVal Model As String,
                   ByVal Dim_ As String,
                   ByVal Pos_ As String,
                   ByVal Origin As String,
                   ByVal date_ As DateTime,
                   ByVal guid_user As String,
                   guid_currency As String,
                   WholeE As Double,
                   Half As Double,
                   EndUser As Double,
                   VendorE As Double,
                   Export As Double,
                   Retail As Double,
                   LastPrice As Double,
                   OrderLimit As Double,
                   MAX_QTY As Double,
                   MIN_QTY As Double,
                   TYPE_ITEME As Integer)
        Dim CON As New CLS_CON

        Dim prm(37) As SqlParameter
        'prm(0) = New SqlParameter("@NAMEE", SqlDbType.NVarChar, 500)
        prm(0) = New SqlParameter("@NAME", SqlDbType.NVarChar, 500)
        prm(0).Value = NAMEE
        prm(1) = New SqlParameter("@NOTE", SqlDbType.NVarChar, 500)
        prm(1).Value = NOTE
        prm(2) = New SqlParameter("@GROUP_GUID", SqlDbType.NVarChar, 500)
        prm(2).Value = GROUP_GUID
        prm(3) = New SqlParameter("@BALANCE", SqlDbType.Float)
        prm(3).Value = BALANCE
        prm(4) = New SqlParameter("@IMG", SqlDbType.Image)
        prm(4).Value = IMG

        prm(5) = New SqlParameter("@avg_price", SqlDbType.Float)
        prm(5).Value = avg_price



        prm(6) = New SqlParameter("@UNIT1", SqlDbType.NVarChar, 500)
        prm(6).Value = UNIT1
        prm(7) = New SqlParameter("@UNIT2", SqlDbType.NVarChar, 500)
        prm(7).Value = UNIT2
        prm(8) = New SqlParameter("@UNIT3", SqlDbType.NVarChar, 500)
        prm(8).Value = UNIT3


        prm(9) = New SqlParameter("@QTY_UNIT1", SqlDbType.Float)
        prm(9).Value = QTY_UNIT1
        prm(10) = New SqlParameter("@QTY_UNIT2", SqlDbType.Float)
        prm(10).Value = QTY_UNIT2
        prm(11) = New SqlParameter("@QTY_UNIT3", SqlDbType.Float)
        prm(11).Value = QTY_UNIT3


        prm(12) = New SqlParameter("@BARCODE_1", SqlDbType.NVarChar, 500)
        prm(12).Value = BARCODE_1
        prm(13) = New SqlParameter("@BARCODE_2", SqlDbType.NVarChar, 500)
        prm(13).Value = BARCODE_2
        prm(14) = New SqlParameter("@BARCODE_3", SqlDbType.NVarChar, 500)
        prm(14).Value = BARCODE_3



        prm(15) = New SqlParameter("@latin_name", SqlDbType.NVarChar, 500)
        prm(15).Value = latin_name
        prm(16) = New SqlParameter("@Company", SqlDbType.NVarChar, 500)
        prm(16).Value = Company
        prm(17) = New SqlParameter("@Provenance", SqlDbType.NVarChar, 500)
        prm(17).Value = Provenance
        prm(18) = New SqlParameter("@Quality", SqlDbType.NVarChar, 500)
        prm(18).Value = Quality
        prm(19) = New SqlParameter("@Color", SqlDbType.NVarChar, 500)
        prm(19).Value = Color
        prm(20) = New SqlParameter("@Model", SqlDbType.NVarChar, 500)
        prm(20).Value = Model
        prm(21) = New SqlParameter("@Dim", SqlDbType.NVarChar, 500)
        prm(21).Value = Dim_
        prm(22) = New SqlParameter("@Pos", SqlDbType.NVarChar, 500)
        prm(22).Value = Pos_
        prm(23) = New SqlParameter("@Origin", SqlDbType.NVarChar, 500)
        prm(23).Value = Origin


        prm(24) = New SqlParameter("@date", SqlDbType.DateTime)
        prm(24).Value = date_

        prm(25) = New SqlParameter("@guid_user", SqlDbType.NVarChar, 500)
        prm(25).Value = guid_user

        prm(26) = New SqlParameter("@guid_currency", SqlDbType.NVarChar, 500)
        prm(26).Value = guid_currency
        prm(27) = New SqlParameter("@Whole", SqlDbType.Float)
        prm(27).Value = WholeE
        prm(28) = New SqlParameter("@Half", SqlDbType.Float)
        prm(28).Value = Half
        prm(29) = New SqlParameter("@EndUser", SqlDbType.Float)
        prm(29).Value = EndUser
        prm(30) = New SqlParameter("@Vendor", SqlDbType.Float)
        prm(30).Value = VendorE


        prm(31) = New SqlParameter("@Export", SqlDbType.Float)
        prm(31).Value = Export
        prm(32) = New SqlParameter("@Retail", SqlDbType.Float)
        prm(32).Value = Retail
        prm(33) = New SqlParameter("@LastPrice", SqlDbType.Float)
        prm(33).Value = LastPrice
        prm(34) = New SqlParameter("@OrderLimit", SqlDbType.Float)
        prm(34).Value = OrderLimit
        prm(35) = New SqlParameter("@MAX_QTY", SqlDbType.Float)
        prm(35).Value = MAX_QTY
        prm(36) = New SqlParameter("@MIN_QTY", SqlDbType.Float)
        prm(36).Value = MIN_QTY

        prm(37) = New SqlParameter("@TYPE_ITEME", SqlDbType.Float)
        prm(37).Value = TYPE_ITEME

        CON.EXECUTE_STORE("add_iteme", prm)



    End Sub
    Public Sub update__(ByVal NAMEE As String,
                    ByVal NOTE As String,
                    ByVal GROUP_GUID As String,
                    ByVal BALANCE As Double,
                    ByVal avg_price As String,
                    ByVal IMG As Byte(),
                    ByVal UNIT1 As String,
                    ByVal UNIT2 As String,
                    ByVal UNIT3 As String,
                   ByVal QTY_UNIT1 As Double,
                   ByVal QTY_UNIT2 As Double,
                   ByVal QTY_UNIT3 As Double,
                   ByVal BARCODE_1 As String,
                   ByVal BARCODE_2 As String,
                   ByVal BARCODE_3 As String,
                    ByVal latin_name As String,
                   ByVal Company As String,
                   ByVal Provenance As String,
                   ByVal Quality As String,
                   ByVal Color As String,
                   ByVal Model As String,
                   ByVal Dim_ As String,
                   ByVal Pos_ As String,
                   ByVal Origin As String,
              ByVal GUID As String,
              ByVal guid_user As String,
                 guid_currency As String,
                   WholeE As Double,
                   Half As Double,
                   EndUser As Double,
                   VendorE As Double,
                   Export As Double,
                   Retail As Double,
                   LastPrice As Double,
                   OrderLimit As Double,
                   MAX_QTY As Double,
                   MIN_QTY As Double,
                   TYPE_ITEME As Integer)
        Dim CON As New CLS_CON
        Dim prm(37) As SqlParameter

        prm(0) = New SqlParameter("@NAME", SqlDbType.NVarChar, 500)
        prm(0).Value = NAMEE
        prm(1) = New SqlParameter("@NOTE", SqlDbType.NVarChar, 500)
        prm(1).Value = NOTE
        prm(2) = New SqlParameter("@GROUP_GUID", SqlDbType.NVarChar, 500)
        prm(2).Value = GROUP_GUID
        prm(3) = New SqlParameter("@BALANCE", SqlDbType.Float)
        prm(3).Value = BALANCE
        prm(4) = New SqlParameter("@IMG", SqlDbType.Image)
        prm(4).Value = IMG

        prm(5) = New SqlParameter("@avg_price", SqlDbType.Float)
        prm(5).Value = avg_price



        prm(6) = New SqlParameter("@UNIT1", SqlDbType.NVarChar, 500)
        prm(6).Value = UNIT1
        prm(7) = New SqlParameter("@UNIT2", SqlDbType.NVarChar, 500)
        prm(7).Value = UNIT2
        prm(8) = New SqlParameter("@UNIT3", SqlDbType.NVarChar, 500)
        prm(8).Value = UNIT3


        prm(9) = New SqlParameter("@QTY_UNIT1", SqlDbType.Float)
        prm(9).Value = QTY_UNIT1
        prm(10) = New SqlParameter("@QTY_UNIT2", SqlDbType.Float)
        prm(10).Value = QTY_UNIT2
        prm(11) = New SqlParameter("@QTY_UNIT3", SqlDbType.Float)
        prm(11).Value = QTY_UNIT3


        prm(12) = New SqlParameter("@BARCODE_1", SqlDbType.NVarChar, 500)
        prm(12).Value = BARCODE_1
        prm(13) = New SqlParameter("@BARCODE_2", SqlDbType.NVarChar, 500)
        prm(13).Value = BARCODE_2
        prm(14) = New SqlParameter("BARCODE_3", SqlDbType.NVarChar, 500)
        prm(14).Value = BARCODE_3

        prm(15) = New SqlParameter("@latin_name", SqlDbType.NVarChar, 500)
        prm(15).Value = latin_name
        prm(16) = New SqlParameter("@Company", SqlDbType.NVarChar, 500)
        prm(16).Value = Company
        prm(17) = New SqlParameter("@Provenance", SqlDbType.NVarChar, 500)
        prm(17).Value = Provenance
        prm(18) = New SqlParameter("@Quality", SqlDbType.NVarChar, 500)
        prm(18).Value = Quality
        prm(19) = New SqlParameter("@Color", SqlDbType.NVarChar, 500)
        prm(19).Value = Color
        prm(20) = New SqlParameter("@Model", SqlDbType.NVarChar, 500)
        prm(20).Value = Model
        prm(21) = New SqlParameter("@Dim", SqlDbType.NVarChar, 500)
        prm(21).Value = Dim_
        prm(22) = New SqlParameter("@Pos", SqlDbType.NVarChar, 500)
        prm(22).Value = Pos_
        prm(23) = New SqlParameter("@Origin", SqlDbType.NVarChar, 500)
        prm(23).Value = Origin

        prm(24) = New SqlParameter("@GUID", SqlDbType.NVarChar, 500)
        prm(24).Value = GUID

        prm(25) = New SqlParameter("@guid_user", SqlDbType.NVarChar, 500)
        prm(25).Value = guid_user



        prm(26) = New SqlParameter("@guid_currency", SqlDbType.NVarChar, 500)
        prm(26).Value = guid_currency
        prm(27) = New SqlParameter("@Whole", SqlDbType.Float)
        prm(27).Value = WholeE
        prm(28) = New SqlParameter("@Half", SqlDbType.Float)
        prm(28).Value = Half
        prm(29) = New SqlParameter("@EndUser", SqlDbType.Float)
        prm(29).Value = EndUser
        prm(30) = New SqlParameter("@Vendor", SqlDbType.Float)
        prm(30).Value = VendorE


        prm(31) = New SqlParameter("@Export", SqlDbType.Float)
        prm(31).Value = Export
        prm(32) = New SqlParameter("@Retail", SqlDbType.Float)
        prm(32).Value = Retail
        prm(33) = New SqlParameter("@LastPrice", SqlDbType.Float)
        prm(33).Value = LastPrice
        prm(34) = New SqlParameter("@OrderLimit", SqlDbType.Float)
        prm(34).Value = OrderLimit
        prm(35) = New SqlParameter("@MAX_QTY", SqlDbType.Float)
        prm(35).Value = MAX_QTY
        prm(36) = New SqlParameter("@MIN_QTY", SqlDbType.Float)
        prm(36).Value = MIN_QTY

        prm(37) = New SqlParameter("@TYPE_ITEME", SqlDbType.Float)
        prm(37).Value = TYPE_ITEME






        CON.EXECUTE_STORE("UPDATE_iteme", prm)
    End Sub
    Public Sub BUANCE_ADD(ByVal BALANCE_ As Double, ByVal Guid As String)
        Dim CON As New CLS_CON
        CON.EXECUTE_TXT("update  ITEME set BALANCE= " & BALANCE_ & "  where GUID='" & Guid & "'")
    End Sub
    Public Sub BUANCE_avg(ByVal avg_price As Double, ByVal Guid As String)
        Dim CON As New CLS_CON
        CON.EXECUTE_TXT("update  ITEME set avg_price= " & avg_price & "  where GUID='" & Guid & "'")
    End Sub
    Public Sub lastprice_(ByVal lastprice As Double, ByVal Guid As String)
        Dim CON As New CLS_CON
        CON.EXECUTE_TXT("update  ITEME set LastPrice= " & lastprice & "  where GUID='" & Guid & "'")
    End Sub
    Public Function balance____(ByVal Guid As String)
        Dim CON As New CLS_CON
        Dim DT As New DataTable
        DT.Clear()
        DT = CON.SELECT_TXT("SELECT     dbo.BILL2.GUID_ITEME, SUM(CASE TYPE_BILL.NUMBER WHEN 0 THEN (BILL2.QTY * BILL2.qty_unit) WHEN 3 THEN (BILL2.QTY * BILL2.qty_unit) WHEN 1 THEN - (BILL2.QTY * BILL2.qty_unit)                      WHEN 2 THEN - (BILL2.QTY * BILL2.qty_unit)   WHEN 7 THEN  (BILL2.QTY * BILL2.qty_unit)  WHEN 5 THEN  (BILL2.QTY * BILL2.qty_unit)  WHEN 6 THEN - (BILL2.QTY * BILL2.qty_unit) END) AS Expr1   FROM         dbo.BILL2 INNER JOIN                    dbo.BILL1 ON dbo.BILL2.PARENT_GUID = dbo.BILL1.GUID INNER JOIN                      dbo.TYPE_BILL ON dbo.BILL1.PARENT_GUID = dbo.TYPE_BILL.GUID   WHERE  (BILL1.DELETE_NUM=0) and  (BILL2.GUID_ITEME='" & Guid & "')and  (dbo.BILL2.recpt = 1) AND (dbo.TYPE_BILL.is_stock = 1)  GROUP BY dbo.BILL2.GUID_ITEME ")
        Return DT
    End Function
    Public Function balance____between(ByVal d1 As DateTime, ByVal d2 As DateTime)
        Dim CON As New CLS_CON
        Dim DT As New DataTable
        DT.Clear()
        DT = CON.SELECT_TXT("SELECT     dbo.BILL2.GUID_ITEME, SUM(CASE TYPE_BILL.NUMBER WHEN 0 THEN (BILL2.QTY * BILL2.qty_unit) WHEN 3 THEN (BILL2.QTY * BILL2.qty_unit) WHEN 1 THEN - (BILL2.QTY * BILL2.qty_unit)                      WHEN 2 THEN - (BILL2.QTY * BILL2.qty_unit) WHEN 7 THEN (BILL2.QTY * BILL2.qty_unit) WHEN 5 THEN (BILL2.QTY * BILL2.qty_unit) WHEN 6 THEN - (BILL2.QTY * BILL2.qty_unit) END)                      AS Expr1  FROM         dbo.BILL2 INNER JOIN                       dbo.BILL1 ON dbo.BILL2.PARENT_GUID = dbo.BILL1.GUID INNER JOIN                     dbo.TYPE_BILL ON dbo.BILL1.PARENT_GUID = dbo.TYPE_BILL.GUID  WHERE   (dbo.BILL1.DATE BETWEEN CONVERT(DATETIME,             '" & d1.Month & "/" & d1.Day & "/" & d1.Year & "', 102) AND CONVERT(DATETIME,  '" & d2.Month & "/" & d2.Day & "/" & d2.Year & "', 102)) and  (dbo.BILL1.DELETE_NUM = 0)   AND (dbo.BILL2.recpt = 1) AND (dbo.TYPE_BILL.is_stock = 1)   GROUP BY dbo.BILL2.GUID_ITEME")
        Return DT
    End Function
    '(BILL1.DATE BETWEEN CONVERT(DATETIME, @dat1, 102) AND CONVERT(DATETIME, @dat2, 102))
    Public Function balance____DATE(ByVal Guid As String, ByVal dat1 As Date, ByVal dat2 As Date)
        Dim CON As New CLS_CON
        Dim DT As New DataTable
        DT.Clear()
        DT = CON.SELECT_TXT("SELECT     dbo.ITEME.BARCODE_1, dbo.ITEME.NAME, SUM(CASE TYPE_BILL.NUMBER WHEN 0 THEN (BILL2.QTY * BILL2.qty_unit) WHEN 3 THEN (BILL2.QTY * BILL2.qty_unit)                     WHEN 1 THEN - (BILL2.QTY * BILL2.qty_unit) WHEN 2 THEN - (BILL2.QTY * BILL2.qty_unit) END) AS Expr1, dbo.STORE.GUID, dbo.STORE.NAME AS Expr2 FROM         dbo.BILL2 INNER JOIN                     dbo.BILL1 ON dbo.BILL2.PARENT_GUID = dbo.BILL1.GUID INNER JOIN                     dbo.TYPE_BILL ON dbo.BILL1.PARENT_GUID = dbo.TYPE_BILL.GUID INNER JOIN                     dbo.ITEME ON dbo.BILL2.GUID_ITEME = dbo.ITEME.GUID INNER JOIN                       dbo.STORE ON dbo.BILL2.guid_store = dbo.STORE.GUID   WHERE     (dbo.BILL2.recpt = 1) AND (dbo.TYPE_BILL.is_stock = 1)  GROUP BY dbo.ITEME.BARCODE_1, dbo.ITEME.NAME, dbo.STORE.GUID, dbo.STORE.NAME")
        Return DT
    End Function
    Public Function NAME(ByVal NAMEE)
        Dim CON As New CLS_CON
        Dim DT As New DataTable
        DT.Clear()
        DT = CON.SELECT_TXT("SELECT     *  FROM         dbo.ITEME  WHERE NAME='" & NAMEE & "'")
        Return DT
    End Function
    Public Function pos_NAME(ByVal categor_ As String)
        Dim CON As New CLS_CON
        Dim DT As New DataTable
        DT.Clear()
        DT = CON.SELECT_TXT("SELECT     GUID,NAME  FROM         dbo.ITEME  WHERE GROUP_GUID='" & categor_ & "' order by id")
        Return DT
    End Function
    Public Function BARCODE(ByVal Barcode_)
        Dim CON As New CLS_CON
        Dim DT As New DataTable
        DT.Clear()
        DT = CON.SELECT_TXT("SELECT     *  FROM         dbo.ITEME  WHERE Barcode='" & Barcode_ & "'")
        Return DT
    End Function
    Public Function searsh_guid(ByVal guid As String)
        Dim con As New CLS_CON
        Dim dt As New DataTable
        dt.Clear()
        dt = con.SELECT_TXT("SELECT     dbo.CATEGORY.GUID, dbo.CATEGORY.NAME AS المجموعة, dbo.ITEME.NAME AS [اسم المادة], dbo.ITEME.NOTE AS ملاحظات, dbo.ITEME.BALANCE AS الرصيد,                      dbo.ITEME.avg_price, dbo.ITEME.img, dbo.ITEME.UNIT1 AS وحدة1, dbo.ITEME.QTY_UNIT1 AS العدد, dbo.ITEME.BARCODE_1, dbo.ITEME.UNIT2, dbo.ITEME.QTY_UNIT2,                       dbo.ITEME.BARCODE_2, dbo.ITEME.UNIT3, dbo.ITEME.QTY_UNIT3, dbo.ITEME.BARCODE_3, dbo.ITEME.Company, dbo.ITEME.Provenance, dbo.ITEME.Quality,                       dbo.ITEME.Color, dbo.ITEME.Model, dbo.ITEME.Dim, dbo.ITEME.Pos, dbo.ITEME.Origin, dbo.ITEME.latin_name, dbo.ITEME.guid_currency, dbo.CURRENCY.NAME,                      dbo.ITEME.Whole, dbo.ITEME.Half, dbo.ITEME.EndUser, dbo.ITEME.Vendor, dbo.ITEME.Export, dbo.ITEME.Retail, dbo.ITEME.LastPrice, dbo.ITEME.OrderLimit,                       dbo.ITEME.MAX_QTY, dbo.ITEME.MIN_QTY, dbo.ITEME.TYPE_ITEME              FROM         dbo.ITEME INNER JOIN                      dbo.CATEGORY ON dbo.ITEME.GROUP_GUID = dbo.CATEGORY.GUID INNER JOIN                     dbo.CURRENCY ON dbo.ITEME.guid_currency = dbo.CURRENCY.GUID where  (dbo.ITEME.guid = '" & guid & "')")
        Return dt
    End Function
    Public Function searsh_iteme(ByVal name_ As String)
        Dim con As New CLS_CON
        Dim dt As New DataTable
        dt.Clear()
        dt = con.SELECT_TXT("SELECT    dbo.ITEME.GUID AS Expr1, dbo.CATEGORY.GUID, dbo.CATEGORY.NAME AS المجموعة, dbo.ITEME.NAME AS [اسم المادة], dbo.ITEME.NOTE AS ملاحظات, dbo.ITEME.BALANCE AS الرصيد                  FROM         dbo.ITEME INNER JOIN                 dbo.CATEGORY ON dbo.ITEME.GROUP_GUID = dbo.CATEGORY.GUID where  (dbo.ITEME.NAME like '%" & name_ & "%')")
        Return dt
    End Function
    Public Function searsh_itemeall(ByVal name_ As String)
        Dim con As New CLS_CON
        Dim dt As New DataTable
        dt.Clear()
        dt = con.SELECT_TXT("SELECT     GUID,BARCODE_1 AS باركود1, NAME AS [اسم المادة], UNIT1 AS الوحدة1, BALANCE AS الرصيد, avg_price ,Whole,Half,EndUser,Vendor,Export,Retail,LastPrice    FROM         dbo.ITEME where  (NAME like '%" & name_ & "%')")
        Return dt
    End Function
    Public Function searsh_name___(ByVal NAME As String)
        Dim con As New CLS_CON
        Dim dt As New DataTable
        dt.Clear()
        dt = con.SELECT_TXT("SELECT     GUID,BARCODE_1 AS باركود1, NAME AS [اسم المادة], UNIT1 AS الوحدة1 , BALANCE AS الرصيد, avg_price AS المتوسط,Whole,Half,EndUser,Vendor,Export,Retail,LastPrice  FROM         dbo.ITEME  WHERE  (NAME like  '%" & NAME & "%') ")
        Return dt
    End Function
    Public Function searsh_BARCODE_1(ByVal BARCODE_ As String)
        Dim con As New CLS_CON
        Dim dt As New DataTable
        dt.Clear()
        dt = con.SELECT_TXT("SELECT     GUID, BARCODE_1, NAME, UNIT1, QTY_UNIT1,Whole,Half,EndUser,Vendor,Export,Retail,LastPrice  FROM         dbo.ITEME  WHERE (BARCODE_1='" & BARCODE_ & "')")
        Return dt
    End Function
    Public Function searsh_BARCODE_pos(ByVal BARCODE_ As String)
        Dim con As New CLS_CON
        Dim dt As New DataTable
        dt.Clear()
        '                                0        1       2     3       4        5      6     7       8      9      10    11        12    13         14     15        16       17
        dt = con.SELECT_TXT("SELECT     GUID, BARCODE_1, NAME, UNIT1, QTY_UNIT1,Whole,Half,EndUser,Vendor,Export,Retail,LastPrice ,UNIT2,QTY_UNIT2,UNIT3,QTY_UNIT3,BARCODE_2,BARCODE_3 FROM         dbo.ITEME  WHERE ( BARCODE_1='" & BARCODE_ & "' or BARCODE_2='" & BARCODE_ & "' or BARCODE_3='" & BARCODE_ & "'  )")
        Return dt
    End Function
    Public Function searsh_BARCODE_2(ByVal BARCODE_ As String)
        Dim con As New CLS_CON
        Dim dt As New DataTable
        dt.Clear()
        dt = con.SELECT_TXT("SELECT     GUID, BARCODE_2, NAME, UNIT2, QTY_UNIT2,Whole,Half,EndUser,Vendor,Export,Retail,LastPrice  FROM         dbo.ITEME  WHERE (BARCODE_2='" & BARCODE_ & "')")
        Return dt
    End Function
    Public Function searsh_BARCODE_3(ByVal BARCODE_ As String)
        Dim con As New CLS_CON
        Dim dt As New DataTable
        dt.Clear()
        dt = con.SELECT_TXT("SELECT     GUID, BARCODE_3, NAME, UNIT3, QTY_UNIT3,Whole,Half,EndUser,Vendor,Export,Retail,LastPrice  FROM         dbo.ITEME   WHERE (BARCODE_3='" & BARCODE_ & "')")
        Return dt
    End Function
    Public Function searsh_NAME_POS(ByVal GUID As String)
        Dim con As New CLS_CON
        Dim dt As New DataTable
        dt.Clear()
        dt = con.SELECT_TXT("SELECT     GUID, BARCODE_1, NAME, UNIT1, QTY_UNIT1,Whole,Half,EndUser,Vendor,Export,Retail,LastPrice  FROM         dbo.ITEME   WHERE (GUID='" & GUID & "')")
        Return dt
    End Function
    Public Function SHOW_ALL_(ByVal GROUP_ As String)
        Dim con As New CLS_CON
        Dim dt As New DataTable
        dt.Clear()
        dt = con.SELECT_TXT("SELECT     dbo.CATEGORY.NAME AS المجموعة, dbo.ITEME.Barcode AS الباركود, dbo.ITEME.NAME AS [اسم المادة], dbo.ITEME.NOTE AS ملاحظات, dbo.ITEME.BALANCE AS الرصيد  FROM         dbo.ITEME INNER JOIN                   dbo.CATEGORY ON dbo.ITEME.GROUP_GUID = dbo.CATEGORY.GUID  WHERE (" & GROUP_ & "' )  ")
        Return dt
    End Function
    Public Function SHOW_ALL_BALNCE__(ByVal GROUP_ As String, ByVal BALNCE__ As String)
        Dim con As New CLS_CON
        Dim dt As New DataTable
        dt.Clear()
        dt = con.SELECT_TXT("SELECT     dbo.CATEGORY.NAME AS المجموعة, dbo.ITEME.Barcode AS الباركود, dbo.ITEME.NAME AS [اسم المادة], dbo.ITEME.NOTE AS ملاحظات, dbo.ITEME.BALANCE AS الرصيد  FROM         dbo.ITEME INNER JOIN                   dbo.CATEGORY ON dbo.ITEME.GROUP_GUID = dbo.CATEGORY.GUID  WHERE (" & GROUP_ & "' ) AND ( " & BALNCE__ & " )")
        Return dt
    End Function
    Public Function SHOW_UNIT__(ByVal GUID As String)
        Dim con As New CLS_CON
        Dim dt As New DataTable
        dt.Clear()
        dt = con.SELECT_TXT("SELECT     UNIT1,QTY_UNIT1,UNIT2,QTY_UNIT2,UNIT3,QTY_UNIT3  FROM  ITEME  WHERE  GUID=( '" & GUID & "' )")
        Return dt
    End Function

    Public Sub UPDATE_BETWEEN(ByVal GUIDTO As String, ByVal GUIDFROM As String, ByVal D1 As DateTime, ByVal D2 As DateTime)
        Dim con As New CLS_CON
        con.EXECUTE_TXT("UPDATE BILL2 SET GUID_ITEME = '" & GUIDTO & "' FROM BILL2 INNER JOIN BILL1  ON BILL2.PARENT_GUID = BILL1.GUID   WHERE   (BILL1.DELETE_NUM=0)and  (dbo.BILL2.GUID_ITEME = '" & GUIDFROM & "') AND  (dbo.BILL1.DATE BETWEEN CONVERT(DATETIME, '" & D1.Month & "/" & D1.Day & "/" & D1.Year & "', 102) AND CONVERT(DATETIME, '" & D2.Month & "/" & D2.Day & "/" & D2.Year & "', 102))                      ")
    End Sub
    Function CMB_Dim_DT() As DataTable
        Dim DAL As New DataAccessLayer
        Dim DT As New DataTable
        DT.Clear()
        DT = DAL.SelectData("select distinct ( Dim) FROM ITEME", Nothing)
        Return DT
    End Function
    Function CMB_Origin_DT() As DataTable
        Dim DAL As New DataAccessLayer
        Dim DT As New DataTable
        DT.Clear()
        DT = DAL.SelectData("select distinct ( Origin) FROM ITEME", Nothing)
        Return DT
    End Function
    Function CMB_Pos_DT() As DataTable
        Dim DAL As New DataAccessLayer
        Dim DT As New DataTable
        DT.Clear()
        DT = DAL.SelectData("select distinct (Pos) FROM ITEME", Nothing)
        Return DT
    End Function
    Function CMB_Company_DT() As DataTable
        Dim DAL As New DataAccessLayer
        Dim DT As New DataTable
        DT.Clear()
        DT = DAL.SelectData("select distinct ( Company) FROM ITEME", Nothing)
        Return DT
    End Function
    Function CMB_Color_DT() As DataTable
        Dim DAL As New DataAccessLayer
        Dim DT As New DataTable
        DT.Clear()
        DT = DAL.SelectData("select distinct ( Color) FROM ITEME", Nothing)
        Return DT
    End Function
    Function CMB_Provenance_DT() As DataTable
        Dim DAL As New DataAccessLayer
        Dim DT As New DataTable
        DT.Clear()
        DT = DAL.SelectData("select distinct ( Provenance) FROM ITEME", Nothing)
        Return DT
    End Function
    Function CMB_Quality_DT() As DataTable
        Dim DAL As New DataAccessLayer
        Dim DT As New DataTable
        DT.Clear()
        DT = DAL.SelectData("select distinct ( Quality) FROM ITEME", Nothing)
        Return DT
    End Function
    Function CMB_Model_DT() As DataTable
        Dim DAL As New DataAccessLayer
        Dim DT As New DataTable
        DT.Clear()
        DT = DAL.SelectData("select distinct ( Model) FROM ITEME", Nothing)
        Return DT
    End Function
    Public Function iteme_avg(ByVal GUID_ As String) As DataTable
        Dim Ds As New DataTable
        Ds.Clear()
        Dim con As New CLS_CON
        Dim prm(0) As SqlParameter

        prm(0) = New SqlParameter("@guid_iteme", SqlDbType.NVarChar, 500)
        prm(0).Value = GUID_

        Ds = con.SELECT_STOE("avg_iteme", prm)

        Return Ds
    End Function
    Public Function ITEME_END()
        Dim CON As New CLS_CON
        Dim DT As New DataTable
        DT.Clear()
        DT = CON.SELECT_TXT("SELECT     GUID,NAME,BALANCE,avg_price,LastPrice  FROM         dbo.ITEME  ")
        Return DT
    End Function
    Public Function ITEME_END_between(ByVal d1 As DateTime, ByVal d2 As DateTime)
        Dim CON As New CLS_CON
        Dim DT As New DataTable
        DT.Clear()
        DT = CON.SELECT_TXT("SELECT     dbo.ITEME.GUID,dbo.ITEME.NAME, SUM(CASE TYPE_BILL.NUMBER WHEN 0 THEN (BILL2.QTY * BILL2.qty_unit) WHEN 3 THEN (BILL2.QTY * BILL2.qty_unit) WHEN 1 THEN - (BILL2.QTY * BILL2.qty_unit)                       WHEN 2 THEN - (BILL2.QTY * BILL2.qty_unit) WHEN 7 THEN (BILL2.QTY * BILL2.qty_unit) WHEN 5 THEN (BILL2.QTY * BILL2.qty_unit) WHEN 6 THEN - (BILL2.QTY * BILL2.qty_unit) END)                     AS Expr1, dbo.ITEME.avg_price, dbo.ITEME.LastPrice  FROM         dbo.BILL2 INNER JOIN                   dbo.BILL1 ON dbo.BILL2.PARENT_GUID = dbo.BILL1.GUID INNER JOIN                     dbo.TYPE_BILL ON dbo.BILL1.PARENT_GUID = dbo.TYPE_BILL.GUID INNER JOIN                     dbo.ITEME ON dbo.BILL2.GUID_ITEME = dbo.ITEME.GUID  WHERE   (dbo.BILL1.DATE BETWEEN CONVERT(DATETIME, '" & d1.Month & "/" & d1.Day & "/" & d1.Year & "', 102) AND                      CONVERT(DATETIME, '" & d2.Month & "/" & d2.Day & "/" & d2.Year & "', 102)) and  (dbo.BILL1.DELETE_NUM = 0) AND (dbo.BILL2.recpt = 1) AND (dbo.TYPE_BILL.is_stock = 1)    GROUP BY dbo.ITEME.GUID, dbo.ITEME.NAME, dbo.ITEME.avg_price, dbo.ITEME.LastPrice")
        Return DT
    End Function
    Public Function balance____ITEME_STORE(ByVal Guid As String, ByVal GUIDSTORE As String)
        Dim CON As New CLS_CON
        Dim DT As New DataTable
        DT.Clear()
        DT = CON.SELECT_TXT("SELECT     dbo.BILL2.GUID_ITEME, SUM(CASE TYPE_BILL.NUMBER WHEN 0 THEN (BILL2.QTY * BILL2.qty_unit) WHEN 3 THEN (BILL2.QTY * BILL2.qty_unit) WHEN 1 THEN - (BILL2.QTY * BILL2.qty_unit)                   WHEN 2 THEN - (BILL2.QTY * BILL2.qty_unit) WHEN 7 THEN (BILL2.QTY * BILL2.qty_unit) WHEN 5 THEN (BILL2.QTY * BILL2.qty_unit) WHEN 6 THEN - (BILL2.QTY * BILL2.qty_unit) END)                     AS Expr1  FROM         dbo.BILL2 INNER JOIN                    dbo.BILL1 ON dbo.BILL2.PARENT_GUID = dbo.BILL1.GUID INNER JOIN                     dbo.TYPE_BILL ON dbo.BILL1.PARENT_GUID = dbo.TYPE_BILL.GUID   WHERE     (dbo.BILL2.GUID_ITEME = '" & Guid & "') AND (dbo.BILL2.guid_store = '" & GUIDSTORE & "') AND (dbo.BILL2.recpt = 1) AND (dbo.TYPE_BILL.is_stock = 1)   GROUP BY dbo.BILL2.GUID_ITEME")
        Return DT
    End Function
End Class
