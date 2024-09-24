Imports System.Data.SqlClient
Public Class CLS_EMPLOYEE
    Function MAX_ID() As DataTable
        Dim DAL As New DataAccessLayer
        Dim DT As New DataTable
        DT.Clear()
        DT = DAL.SelectData("select ISNULL(max(ID)+1,1) from EMPLOYEE ", Nothing)
        Return DT
    End Function
    Function MIN_ID() As DataTable
        Dim DAL As New DataAccessLayer
        Dim DT As New DataTable
        DT.Clear()
        DT = DAL.SelectData("select ISNULL(min(ID),1) from EMPLOYEE ", Nothing)
        Return DT
    End Function
    Function MIN_ID_min() As DataTable
        Dim DAL As New DataAccessLayer
        Dim DT As New DataTable
        DT.Clear()
        DT = DAL.SelectData("select ISNULL(min(ID),1) from EMPLOYEE ", Nothing)
        Return DT
    End Function
    Public Sub ADD_CUSTOMER(ByVal DTP As DateTime, ByVal NAME As String, ByVal LASTNAME As String, ByVal COMPANY As String, ByVal COMPANYJOB As String, _
                 ByVal CUNTRY As String, ByVal STREET As String, ByVal PHON As String, ByVal MOB1 As String, ByVal MOB2 As String, _
                   ByVal MAIL As String, ByVal WEB As String, ByVal img As Byte(),
                   ByVal Nationality As String, ByVal idinsurance As String, ByVal bgndate As DateTime, ByVal enddate As DateTime, ByVal inp As DateTime, ByVal outpu As DateTime, ByVal salary As Double, ByVal taxes As Double, ByVal insurance As Double, ByVal statuse As String,
                   ByVal CARD As String, ByVal TXTNationality As String, ByVal idjob As Integer,
                   ByVal father As String, ByVal mather As String, ByVal bloodtype As String, ByVal CountryBirths As String, ByVal RegistrationNo As String, ByVal Box As String, ByVal IDnumber As String, ByVal date_IDnumber As DateTime,
                   ByVal Army As String, ByVal date_b_Army As DateTime, ByVal date_e_Army As DateTime, ByVal country_Army As String,
                   ByVal Family_status As String, ByVal number_wives As String, ByVal Number_Children As String,
                   ByVal Insurance_facility As String, ByVal ID_Insurance_facility As String, ByVal DATE_B_Insurance_facility As DateTime, ByVal DATE_E_Insurance_facility As DateTime, ByVal GUID_ACCOUNT As String, ByVal date__ As DateTime,
                   ByVal guid_user As String)
        Dim DAL As New DataAccessLayer
        Dim PRM(47) As SqlParameter
        PRM(0) = New SqlParameter("@DTP", SqlDbType.DateTime)
        PRM(0).Value = DTP

        PRM(1) = New SqlParameter("@NAME", SqlDbType.NVarChar, 500)
        PRM(1).Value = NAME

        PRM(2) = New SqlParameter("@LASTNAME", SqlDbType.NVarChar, 500)
        PRM(2).Value = LASTNAME

        PRM(3) = New SqlParameter("@COMPANY", SqlDbType.NVarChar, 500)
        PRM(3).Value = COMPANY

        PRM(4) = New SqlParameter("@COMPANYJOB", SqlDbType.NVarChar, 500)
        PRM(4).Value = COMPANYJOB

        PRM(5) = New SqlParameter("@CUNTRY", SqlDbType.NVarChar, 500)
        PRM(5).Value = CUNTRY

        PRM(6) = New SqlParameter("@STREET", SqlDbType.NVarChar, 500)
        PRM(6).Value = STREET


        PRM(7) = New SqlParameter("@PHON", SqlDbType.NVarChar, 500)
        PRM(7).Value = PHON


        PRM(8) = New SqlParameter("@MOB1", SqlDbType.NVarChar, 500)
        PRM(8).Value = MOB1

        PRM(9) = New SqlParameter("@MOB2", SqlDbType.NVarChar, 500)
        PRM(9).Value = MOB2


        PRM(10) = New SqlParameter("@MAIL", SqlDbType.NVarChar, 500)
        PRM(10).Value = MAIL

        PRM(11) = New SqlParameter("@WEB", SqlDbType.NVarChar, 500)
        PRM(11).Value = WEB
        PRM(12) = New SqlParameter("@img", SqlDbType.Image)
        PRM(12).Value = img



        PRM(13) = New SqlParameter("@Nationality", SqlDbType.NVarChar, 500)
        PRM(13).Value = Nationality
        PRM(14) = New SqlParameter("@idinsurance", SqlDbType.NVarChar, 500)
        PRM(14).Value = idinsurance
        PRM(15) = New SqlParameter("@bgndate", SqlDbType.DateTime)
        PRM(15).Value = bgndate
        PRM(16) = New SqlParameter("@enddate", SqlDbType.DateTime)
        PRM(16).Value = enddate
        PRM(17) = New SqlParameter("@inp", SqlDbType.DateTime)
        PRM(17).Value = inp
        PRM(18) = New SqlParameter("@outpu", SqlDbType.DateTime)
        PRM(18).Value = outpu


        PRM(19) = New SqlParameter("@salary", SqlDbType.Float)
        PRM(19).Value = salary
        PRM(20) = New SqlParameter("@taxes", SqlDbType.Float)
        PRM(20).Value = taxes
        PRM(21) = New SqlParameter("@insurance", SqlDbType.Float)
        PRM(21).Value = insurance
        PRM(22) = New SqlParameter("@statuse", SqlDbType.NVarChar, 500)
        PRM(22).Value = statuse

        PRM(23) = New SqlParameter("@CARD", SqlDbType.NVarChar, 500)
        PRM(23).Value = CARD
        PRM(24) = New SqlParameter("@TXTNationality", SqlDbType.NVarChar, 500)
        PRM(24).Value = TXTNationality
        PRM(25) = New SqlParameter("@idjob", SqlDbType.Int)
        PRM(25).Value = idjob

        PRM(26) = New SqlParameter("@father", SqlDbType.NVarChar, 500)
        PRM(26).Value = father
        PRM(27) = New SqlParameter("@mather", SqlDbType.NVarChar, 500)
        PRM(27).Value = mather
        PRM(28) = New SqlParameter("@bloodtype", SqlDbType.NVarChar, 500)
        PRM(28).Value = bloodtype
        PRM(29) = New SqlParameter("@CountryBirths", SqlDbType.NVarChar, 500)
        PRM(29).Value = CountryBirths
        PRM(30) = New SqlParameter("@RegistrationNo", SqlDbType.NVarChar, 500)
        PRM(30).Value = RegistrationNo
        PRM(31) = New SqlParameter("@Box", SqlDbType.NVarChar, 500)
        PRM(31).Value = Box
        PRM(32) = New SqlParameter("@IDnumber", SqlDbType.NVarChar, 500)
        PRM(32).Value = IDnumber
        PRM(33) = New SqlParameter("@date_IDnumber", SqlDbType.DateTime)
        PRM(33).Value = date_IDnumber


        PRM(34) = New SqlParameter("@Army", SqlDbType.NVarChar, 500)
        PRM(34).Value = Army
        PRM(35) = New SqlParameter("@date_b_Army", SqlDbType.DateTime)
        PRM(35).Value = date_b_Army
        PRM(36) = New SqlParameter("@date_e_Army", SqlDbType.DateTime)
        PRM(36).Value = date_e_Army
        PRM(37) = New SqlParameter("@country_Army", SqlDbType.NVarChar, 500)
        PRM(37).Value = country_Army

        PRM(38) = New SqlParameter("@Family_status", SqlDbType.NVarChar, 500)
        PRM(38).Value = Family_status
        PRM(39) = New SqlParameter("@number_wives", SqlDbType.NVarChar, 500)
        PRM(39).Value = number_wives
        PRM(40) = New SqlParameter("@Number_Children", SqlDbType.NVarChar, 500)
        PRM(40).Value = Number_Children


        PRM(41) = New SqlParameter("@Insurance_facility", SqlDbType.NVarChar, 500)
        PRM(41).Value = Insurance_facility
        PRM(42) = New SqlParameter("@ID_Insurance_facility", SqlDbType.NVarChar, 500)
        PRM(42).Value = ID_Insurance_facility
        PRM(43) = New SqlParameter("@DATE_B_Insurance_facility", SqlDbType.DateTime)
        PRM(43).Value = DATE_B_Insurance_facility
        PRM(44) = New SqlParameter("@DATE_E_Insurance_facility", SqlDbType.DateTime)
        PRM(44).Value = DATE_E_Insurance_facility

        PRM(45) = New SqlParameter("@GUID_ACCOUNT", SqlDbType.NVarChar, 500)
        PRM(45).Value = GUID_ACCOUNT

        PRM(46) = New SqlParameter("@date", SqlDbType.DateTime)
        PRM(46).Value = date__

        PRM(47) = New SqlParameter("@guid_user", SqlDbType.NVarChar, 500)
        PRM(47).Value = guid_user

        DAL.ExecuteCommand("INSERT INTO EMPLOYEE(DTP,NAME,LASTNAME,COMPANY,COMPANYJOB,CUNTRY,STREET,PHON,MOB1,MOB2,MAIL,WEB,img,Nationality,idinsurance,bgndate,enddate,inp,outpu,salary,taxes,insurance,statuse,CARD,TXTNationality,idjob,father,mather,bloodtype,CountryBirths,RegistrationNo,Box,IDnumber,date_IDnumber,Army,date_b_Army,date_e_Army,country_Army,Family_status,number_wives,Number_Children,Insurance_facility,ID_Insurance_facility,DATE_B_Insurance_facility,DATE_E_Insurance_facility,GUID_ACCOUNT,date,guid_user)VALUES(@DTP,@NAME,@LASTNAME,@COMPANY,@COMPANYJOB,@CUNTRY,@STREET,@PHON,@MOB1,@MOB2,@MAIL,@WEB,@img,@Nationality,@idinsurance,@bgndate,@enddate,@inp,@outpu,@salary,@taxes,@insurance,@statuse,@CARD,@TXTNationality,@idjob,@father,@mather,@bloodtype,@CountryBirths,@RegistrationNo,@Box,@IDnumber,@date_IDnumber,@Army,@date_b_Army,@date_e_Army,@country_Army,@Family_status,@number_wives,@Number_Children,@Insurance_facility,@ID_Insurance_facility,@DATE_B_Insurance_facility,@DATE_E_Insurance_facility,@GUID_ACCOUNT,@date,@guid_user)", PRM)
    End Sub

    Public Sub UPDATE_CUSTOMER(ByVal DTP As DateTime, ByVal NAME As String, ByVal LASTNAME As String, ByVal COMPANY As String, ByVal COMPANYJOB As String, _
                          ByVal CUNTRY As String, ByVal STREET As String, ByVal PHON As String, ByVal MOB1 As String, ByVal MOB2 As String, ByVal MAIL As String, ByVal WEB As String, ByVal img As Byte(),
                            ByVal Nationality As String, ByVal idinsurance As String, ByVal bgndate As DateTime, ByVal enddate As DateTime, ByVal inp As DateTime, ByVal outpu As DateTime, ByVal salary As Double, ByVal taxes As Double, ByVal insurance As Double, ByVal statuse As String,
                   ByVal CARD As String, ByVal TXTNationality As String, ByVal ID As Integer, ByVal idjob As Integer,
                     ByVal father As String, ByVal mather As String, ByVal bloodtype As String, ByVal CountryBirths As String, ByVal RegistrationNo As String, ByVal Box As String, ByVal IDnumber As String, ByVal date_IDnumber As DateTime,
                      ByVal Army As String, ByVal date_b_Army As DateTime, ByVal date_e_Army As DateTime, ByVal country_Army As String,
                       ByVal Family_status As String, ByVal number_wives As String, ByVal Number_Children As String,
                          ByVal Insurance_facility As String, ByVal ID_Insurance_facility As String, ByVal DATE_B_Insurance_facility As DateTime, ByVal DATE_E_Insurance_facility As DateTime, ByVal guid_user As String)
        Dim DAL As New DataAccessLayer
        Dim PRM(46) As SqlParameter
        PRM(0) = New SqlParameter("@DTP", SqlDbType.DateTime)
        PRM(0).Value = DTP

        PRM(1) = New SqlParameter("@NAME", SqlDbType.NVarChar, 500)
        PRM(1).Value = NAME

        PRM(2) = New SqlParameter("@LASTNAME", SqlDbType.NVarChar, 500)
        PRM(2).Value = LASTNAME

        PRM(3) = New SqlParameter("@COMPANY", SqlDbType.NVarChar, 500)
        PRM(3).Value = COMPANY

        PRM(4) = New SqlParameter("@COMPANYJOB", SqlDbType.NVarChar, 500)
        PRM(4).Value = COMPANYJOB

        PRM(5) = New SqlParameter("@CUNTRY", SqlDbType.NVarChar, 500)
        PRM(5).Value = CUNTRY

        PRM(6) = New SqlParameter("@STREET", SqlDbType.NVarChar, 500)
        PRM(6).Value = STREET


        PRM(7) = New SqlParameter("@PHON", SqlDbType.NVarChar, 500)
        PRM(7).Value = PHON


        PRM(8) = New SqlParameter("@MOB1", SqlDbType.NVarChar, 500)
        PRM(8).Value = MOB1

        PRM(9) = New SqlParameter("@MOB2", SqlDbType.NVarChar, 500)
        PRM(9).Value = MOB2


        PRM(10) = New SqlParameter("@MAIL", SqlDbType.NVarChar, 500)
        PRM(10).Value = MAIL

        PRM(11) = New SqlParameter("@WEB", SqlDbType.NVarChar, 500)
        PRM(11).Value = WEB

        PRM(12) = New SqlParameter("@img", SqlDbType.Image)
        PRM(12).Value = img



        PRM(13) = New SqlParameter("@Nationality", SqlDbType.NVarChar, 500)
        PRM(13).Value = Nationality
        PRM(14) = New SqlParameter("@idinsurance", SqlDbType.NVarChar, 500)
        PRM(14).Value = idinsurance
        PRM(15) = New SqlParameter("@bgndate", SqlDbType.DateTime)
        PRM(15).Value = bgndate
        PRM(16) = New SqlParameter("@enddate", SqlDbType.DateTime)
        PRM(16).Value = enddate
        PRM(17) = New SqlParameter("@inp", SqlDbType.DateTime)
        PRM(17).Value = inp
        PRM(18) = New SqlParameter("@outpu", SqlDbType.DateTime)
        PRM(18).Value = outpu


        PRM(19) = New SqlParameter("@salary", SqlDbType.Float)
        PRM(19).Value = salary
        PRM(20) = New SqlParameter("@taxes", SqlDbType.Float)
        PRM(20).Value = taxes
        PRM(21) = New SqlParameter("@insurance", SqlDbType.Float)
        PRM(21).Value = insurance
        PRM(22) = New SqlParameter("@statuse", SqlDbType.NVarChar, 500)
        PRM(22).Value = statuse

        PRM(23) = New SqlParameter("@CARD", SqlDbType.NVarChar, 500)
        PRM(23).Value = CARD
        PRM(24) = New SqlParameter("@TXTNationality", SqlDbType.NVarChar, 500)
        PRM(24).Value = TXTNationality


        PRM(25) = New SqlParameter("@ID", SqlDbType.Int)
        PRM(25).Value = ID
        PRM(26) = New SqlParameter("@idjob", SqlDbType.Int)
        PRM(26).Value = idjob

        PRM(27) = New SqlParameter("@father", SqlDbType.NVarChar, 500)
        PRM(27).Value = father
        PRM(28) = New SqlParameter("@mather", SqlDbType.NVarChar, 500)
        PRM(28).Value = mather
        PRM(29) = New SqlParameter("@bloodtype", SqlDbType.NVarChar, 500)
        PRM(29).Value = bloodtype
        PRM(30) = New SqlParameter("@CountryBirths", SqlDbType.NVarChar, 500)
        PRM(30).Value = CountryBirths
        PRM(31) = New SqlParameter("@RegistrationNo", SqlDbType.NVarChar, 500)
        PRM(31).Value = RegistrationNo
        PRM(32) = New SqlParameter("@Box", SqlDbType.NVarChar, 500)
        PRM(32).Value = Box
        PRM(33) = New SqlParameter("@IDnumber", SqlDbType.NVarChar, 500)
        PRM(33).Value = IDnumber
        PRM(34) = New SqlParameter("@date_IDnumber", SqlDbType.DateTime)
        PRM(34).Value = date_IDnumber

        PRM(35) = New SqlParameter("@Army", SqlDbType.NVarChar, 500)
        PRM(35).Value = Army
        PRM(36) = New SqlParameter("@date_b_Army", SqlDbType.DateTime)
        PRM(36).Value = date_b_Army
        PRM(37) = New SqlParameter("@date_e_Army", SqlDbType.DateTime)
        PRM(37).Value = date_e_Army
        PRM(38) = New SqlParameter("@country_Army", SqlDbType.NVarChar, 500)
        PRM(38).Value = country_Army


        PRM(39) = New SqlParameter("@Family_status", SqlDbType.NVarChar, 500)
        PRM(39).Value = Family_status
        PRM(40) = New SqlParameter("@number_wives", SqlDbType.NVarChar, 500)
        PRM(40).Value = number_wives
        PRM(41) = New SqlParameter("@Number_Children", SqlDbType.NVarChar, 500)
        PRM(41).Value = Number_Children

        PRM(42) = New SqlParameter("@Insurance_facility", SqlDbType.NVarChar, 500)
        PRM(42).Value = Insurance_facility
        PRM(43) = New SqlParameter("@ID_Insurance_facility", SqlDbType.NVarChar, 500)
        PRM(43).Value = ID_Insurance_facility
        PRM(44) = New SqlParameter("@DATE_B_Insurance_facility", SqlDbType.DateTime)
        PRM(44).Value = DATE_B_Insurance_facility
        PRM(45) = New SqlParameter("@DATE_E_Insurance_facility", SqlDbType.DateTime)
        PRM(45).Value = DATE_E_Insurance_facility

        PRM(46) = New SqlParameter("@guid_user", SqlDbType.NVarChar, 500)
        PRM(46).Value = guid_user

        DAL.ExecuteCommand("UPDATE  EMPLOYEE SET DTP=@DTP,NAME=@NAME,LASTNAME=@LASTNAME,COMPANY=@COMPANY,COMPANYJOB=@COMPANYJOB,CUNTRY=@CUNTRY,STREET=@STREET,PHON=@PHON,MOB1=@MOB1,MOB2=@MOB2,MAIL=@MAIL,WEB=@WEB,img=@img,Nationality=@Nationality,idinsurance=@idinsurance,bgndate=@bgndate,enddate=@enddate,inp=@inp,outpu=@outpu,salary=@salary,taxes=@taxes,insurance=@insurance,statuse=@statuse,CARD=@CARD,TXTNationality=@TXTNationality,idjob=@idjob,father=@father,mather=@mather,bloodtype=@bloodtype,CountryBirths=@CountryBirths,RegistrationNo=@RegistrationNo,Box=@Box,IDnumber=@IDnumber,date_IDnumber=@date_IDnumber,Army=@Army,date_b_Army=@date_b_Army,date_e_Army=@date_e_Army,country_Army=@country_Army,Family_status=@Family_status,number_wives=@number_wives,Number_Children=@Number_Children,Insurance_facility=@Insurance_facility,ID_Insurance_facility=@ID_Insurance_facility,DATE_B_Insurance_facility=@DATE_B_Insurance_facility,DATE_E_Insurance_facility=@DATE_E_Insurance_facility,guid_user=@guid_user  WHERE ID=@ID", PRM)
    End Sub
    Public Sub DELETE_CUSTOMER(ByVal ID As Integer)
        Dim DAL As New DataAccessLayer
        Dim PRM(0) As SqlParameter
        PRM(0) = New SqlParameter("@ID", SqlDbType.Int)
        PRM(0).Value = ID
        DAL.ExecuteCommand("DELETE FROM EMPLOYEE WHERE ID=@ID ", PRM)
    End Sub
    Function SHOW_CUSTOMER_ID(ByVal ID_ITEME As Integer) As DataTable
        Dim DAL As New DataAccessLayer
        Dim DT As New DataTable
        DT.Clear()
        Dim PRM(0) As SqlParameter
        PRM(0) = New SqlParameter("@ID", SqlDbType.Int)
        PRM(0).Value = ID_ITEME
        '                           0     1      2     3         4         5     6      7    8    9    10  11   12   13           14         15      16     17  18     19     20     21        22    23     24            25    26    27      28         29             30          31    32      33           34    35            36         37             38           39         40               41                  42                        43                       44                     45       
        DT = DAL.SelectData("SELECT DTP,NAME,LASTNAME,COMPANY,COMPANYJOB,CUNTRY,STREET,PHON,MOB1,MOB2,MAIL,WEB,img,Nationality,idinsurance,bgndate,enddate,inp,outpu,salary,taxes,insurance,statuse,CARD,TXTNationality,idjob,father,mather,bloodtype,CountryBirths,RegistrationNo,Box,IDnumber,date_IDnumber,Army,date_b_Army,date_e_Army,country_Army,Family_status,number_wives,Number_Children,Insurance_facility,ID_Insurance_facility,DATE_B_Insurance_facility,DATE_E_Insurance_facility ,GUID_ACCOUNT FROM EMPLOYEE WHERE ID=@ID", PRM)
        Return DT
    End Function
    Function SHOW_NAME(ByVal NAME As String) As DataTable
        Dim DAL As New DataAccessLayer
        Dim DT As New DataTable
        DT.Clear()
        Dim PRM(0) As SqlParameter
        PRM(0) = New SqlParameter("@NAME", SqlDbType.NVarChar, 500)
        PRM(0).Value = NAME
        DT = DAL.SelectData("SELECT * FROM EMPLOYEE WHERE NAME=@NAME", PRM)
        Return DT
    End Function
    Function ALL_ITEME(ByVal NAME As String)
        Dim DT As New DataTable
        DT.Clear()
        Dim DAL As New DataAccessLayer
        DT = DAL.SelectData("SELECT ID,DTP AS[المواليد],NAME AS[الاسم],LASTNAME  AS[اسم الاب],COMPANY  AS[اسم الام],COMPANYJOB  AS[ الشركة],CUNTRY  AS[المدينة],STREET  AS[الشارع],PHON  AS[الهاتف],MOB1  AS[موبايل1],MOB2  AS[موبايل2],MAIL  AS[ بطاقة الاب],WEB AS[ بطاقة الام],GUID  FROM EMPLOYEE  WHERE NAME LIKE '%" & NAME & "%'", Nothing)
        Return DT
    End Function
    Function SHOW_CMB() As DataTable
        Dim DT As New DataTable
        DT.Clear()
        Dim DAL As New DataAccessLayer

        DT = DAL.SelectData("SELECT ID ,NAME FROM EMPLOYEE ", Nothing)
        Return DT
    End Function
    Function SHOW_ALL_STUDENT() As DataTable
        Dim DT As New DataTable
        DT.Clear()
        Dim DAL As New DataAccessLayer

        DT = DAL.SelectData("SELECT ID,DTP AS[المواليد],NAME AS[الاسم],LASTNAME  AS[اسم الاب],COMPANY  AS[اسم الام],COMPANYJOB  AS[ الشركة],CUNTRY  AS[المدينة],STREET  AS[الشارع],PHON  AS[الهاتف],MOB1  AS[موبايل1],MOB2  AS[موبايل2],MAIL  AS[ بطاقة الاب],WEB AS[ بطاقة الام],img  AS [الصورة],salary AS[الراتب الثابت],taxes AS[ضرائب],insurance AS [تامينات] FROM EMPLOYEE ", Nothing)
        Return DT
    End Function
    Function SHOW_report_student(ByVal ID_EXPEN As Integer, ByVal TYPEE As Integer, ByVal d1 As DateTime, ByVal d2 As DateTime) As DataTable
        Dim DT As New DataTable
        DT.Clear()
        Dim DAL As New DataAccessLayer

        DT = DAL.SelectData("SELECT     SUM(dbo.DAY_EXPEN.MONY) AS Expr1  FROM         dbo.DAY_EXPEN INNER JOIN                    dbo.EXPEN ON dbo.DAY_EXPEN.TYPEE = dbo.EXPEN.ID_EXPEN  WHERE     (dbo.DAY_EXPEN.ID_EXPEN = " & ID_EXPEN & ") AND (dbo.DAY_EXPEN.TYPEE = " & TYPEE & ") AND (dbo.DAY_EXPEN.DATE BETWEEN CONVERT(DATETIME,  '" & d1.Month & "/" & d1.Day & "/" & d1.Year & "', 102) AND CONVERT(DATETIME,  '" & d2.Month & "/" & d2.Day & "/" & d2.Year & "', 102)) ", Nothing)
        Return DT
    End Function
    Public Function delete_account(ByVal guid As String) As DataTable
        Dim CON As New CLS_CON
        Dim DT As New DataTable
        DT.Clear()
        DT = CON.SELECT_TXT("SELECT * FROM EMPLOYEE where  (GUID_ACCOUNT='" & guid & "')")
        Return DT
    End Function
    Public Sub delete_(ByVal id As Integer)
        Dim CON As New CLS_CON
        CON.EXECUTE_TXT("delete from  EMPLOYEE  WHERE id= " & id & " ")

    End Sub
    'Function SHOW_report_student(ByVal TYPEE As Integer, ByVal ID_EXPEN As Integer, ByVal D1 As DateTime, ByVal D2 As DateTime) As DataTable
    '    Dim DAL As New DataAccessLayer
    '    Dim DT As New DataTable
    '    DT.Clear()
    '    Dim PRM(3) As SqlParameter
    '    PRM(0) = New SqlParameter("@D1", SqlDbType.DateTime)
    '    PRM(0).Value = D1
    '    PRM(1) = New SqlParameter("@D2", SqlDbType.DateTime)
    '    PRM(1).Value = D2
    '    PRM(2) = New SqlParameter("@TYPEE", SqlDbType.Int)
    '    PRM(2).Value = TYPEE
    '    PRM(3) = New SqlParameter("@ID_EXPEN", SqlDbType.Int)
    '    PRM(3).Value = ID_EXPEN
    '    'DT = DAL.SelectData("SELECT     SUM(dbo.DAY_EXPEN.MONY) AS Expr1  FROM         dbo.DAY_EXPEN INNER JOIN                    dbo.EXPEN ON dbo.DAY_EXPEN.TYPEE = dbo.EXPEN.ID_EXPEN  WHERE     (dbo.DAY_EXPEN.ID_EXPEN = " & ID_EXPEN & ") AND (dbo.DAY_EXPEN.TYPEE = " & TYPEE & ") AND (dbo.DAY_EXPEN.DATE BETWEEN CONVERT(DATETIME,  '" & D1.Month & "/" & D1.Day & "/" & D1.Year & "', 102) AND CONVERT(DATETIME,  '" & D2.Month & "/" & D2.Day & "/" & D2.Year & "', 102)) ", Nothing)
    '    'DT = DAL.SelectData("SELECT     SUM(MONY) AS Expr1 FROM         dbo.DAY_EXPEN WHERE (ID_EXPEN = @ID_EXPEN) and(TYPEE = @TYPEE) AND    (DATE BETWEEN CONVERT(DATETIME, @D1, 102) AND CONVERT(DATETIME, @D2, 102))  ", PRM)
    '    Return DT
    'End Function
End Class
