Imports System.Data.SqlClient
Public Class CLS_CU_VEN
    Function MAX_ID() As DataTable
        Dim DAL As New DataAccessLayer
        Dim DT As New DataTable
        DT.Clear()
        DT = DAL.SelectData("select ISNULL(max(ID)+1,1) from customer ", Nothing)
        Return DT
    End Function
    Function MIN_ID() As DataTable
        Dim DAL As New DataAccessLayer
        Dim DT As New DataTable
        DT.Clear()
        DT = DAL.SelectData("select ISNULL(min(ID),1) from customer ", Nothing)
        Return DT
    End Function
    Function MIN_ID_min() As DataTable
        Dim DAL As New DataAccessLayer
        Dim DT As New DataTable
        DT.Clear()
        DT = DAL.SelectData("select ISNULL(min(ID),1) from customer ", Nothing)
        Return DT
    End Function
    Public Sub ADD_CUSTOMER(ByVal DTP As DateTime, ByVal NAME As String, ByVal LASTNAME As String, ByVal COMPANY As String, ByVal COMPANYJOB As String, _
                 ByVal CUNTRY As String, ByVal STREET As String, ByVal PHON As String, ByVal MOB1 As String, ByVal MOB2 As String, _
                   ByVal MAIL As String, ByVal WEB As String, ByVal img As Byte(), ByVal GUID_ACCOUNT As String, ByVal typ_e As String, ByVal date_ As DateTime,
                   ByVal guid_user As String)
        Dim DAL As New DataAccessLayer
        Dim PRM(16) As SqlParameter
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



        PRM(13) = New SqlParameter("@GUID_ACCOUNT", SqlDbType.NVarChar, 500)
        PRM(13).Value = GUID_ACCOUNT

        PRM(14) = New SqlParameter("@typ_e", SqlDbType.NVarChar, 500)
        PRM(14).Value = typ_e

        PRM(15) = New SqlParameter("@date", SqlDbType.DateTime)
        PRM(15).Value = date_
        PRM(16) = New SqlParameter("@guid_user", SqlDbType.NVarChar, 500)
        PRM(16).Value = guid_user
        DAL.ExecuteCommand("INSERT INTO customer(DTP,NAME,LASTNAME,COMPANY,COMPANYJOB,CUNTRY,STREET,PHON,MOB1,MOB2,MAIL,WEB,img,GUID_ACCOUNT,typ_e,date,guid_user)VALUES(@DTP,@NAME,@LASTNAME,@COMPANY,@COMPANYJOB,@CUNTRY,@STREET,@PHON,@MOB1,@MOB2,@MAIL,@WEB,@img,@GUID_ACCOUNT,@typ_e,@date,@guid_user)", PRM)
    End Sub

    Public Sub UPDATE_CUSTOMER(ByVal DTP As DateTime, ByVal NAME As String, ByVal LASTNAME As String, ByVal COMPANY As String, ByVal COMPANYJOB As String, _
                          ByVal CUNTRY As String, ByVal STREET As String, ByVal PHON As String, ByVal MOB1 As String, ByVal MOB2 As String, ByVal MAIL As String, ByVal WEB As String, ByVal img As Byte(), ByVal ID_ As Integer,
                               ByVal guid_user As String)
        Dim DAL As New DataAccessLayer
        Dim PRM(14) As SqlParameter
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
        PRM(13) = New SqlParameter("@ID", SqlDbType.Int)
        PRM(13).Value = ID_
        PRM(14) = New SqlParameter("@guid_user", SqlDbType.NVarChar, 500)
        PRM(14).Value = guid_user

        DAL.ExecuteCommand("UPDATE  customer SET DTP=@DTP,NAME=@NAME,LASTNAME=@LASTNAME,COMPANY=@COMPANY,COMPANYJOB=@COMPANYJOB,CUNTRY=@CUNTRY,STREET=@STREET,PHON=@PHON,MOB1=@MOB1,MOB2=@MOB2,MAIL=@MAIL,WEB=@WEB,img=@img,guid_user=@guid_user  WHERE ID=@ID", PRM)
    End Sub
    Public Sub DELETE_CUSTOMER(ByVal ID As Integer)
        Dim DAL As New DataAccessLayer
        Dim PRM(0) As SqlParameter
        PRM(0) = New SqlParameter("@ID", SqlDbType.Int)
        PRM(0).Value = ID
        DAL.ExecuteCommand("DELETE FROM customer WHERE ID=@ID ", PRM)
    End Sub
    Function SHOW_CUSTOMER_ID(ByVal ID_ITEME As Integer) As DataTable
        Dim DAL As New DataAccessLayer
        Dim DT As New DataTable
        DT.Clear()
        Dim PRM(0) As SqlParameter
        PRM(0) = New SqlParameter("@ID", SqlDbType.Int)
        PRM(0).Value = ID_ITEME
        '                           0    1       2       3         4       5       6     7   8    9    10   11  12   13   14
        DT = DAL.SelectData("SELECT DTP,NAME,LASTNAME,COMPANY,COMPANYJOB,CUNTRY,STREET,PHON,MOB1,MOB2,MAIL,WEB,img,typ_e,GUID_ACCOUNT  FROM customer WHERE ID=@ID", PRM)
        Return DT
    End Function
    Function SHOW_CUSTOMER_BILL(ByVal GUID As String) As DataTable
        Dim DAL As New DataAccessLayer
        Dim DT As New DataTable
        DT.Clear()
        Dim PRM(0) As SqlParameter
        PRM(0) = New SqlParameter("@GUID_ACCOUNT", SqlDbType.NVarChar, 500)
        PRM(0).Value = GUID
        DT = DAL.SelectData("SELECT DTP,NAME,LASTNAME,COMPANY,COMPANYJOB,CUNTRY,STREET,PHON,MOB1,MOB2,MAIL,WEB,img  FROM customer WHERE GUID_ACCOUNT=@GUID_ACCOUNT", PRM)
        Return DT
    End Function
    Function SHOW_NAME(ByVal NAME As String) As DataTable
        Dim DAL As New DataAccessLayer
        Dim DT As New DataTable
        DT.Clear()
        Dim PRM(0) As SqlParameter
        PRM(0) = New SqlParameter("@NAME", SqlDbType.NVarChar, 500)
        PRM(0).Value = NAME
        DT = DAL.SelectData("SELECT * FROM customer WHERE NAME=@NAME", PRM)
        Return DT
    End Function
    Function ALL_ITEME(ByVal NAME As String)
        Dim DT As New DataTable
        DT.Clear()
        Dim DAL As New DataAccessLayer
        DT = DAL.SelectData("SELECT     dbo.customer.ID, dbo.customer.DTP AS المواليد, dbo.customer.NAME AS الاسم, dbo.customer.LASTNAME AS [الاسم اللاتيني], dbo.customer.COMPANY AS [الشركة السابقة], dbo.customer.COMPANYJOB AS [ الشركة],                      dbo.customer.CUNTRY AS المدينة, dbo.customer.STREET AS الشارع, dbo.customer.PHON AS الهاتف, dbo.customer.MOB1 AS موبايل1, dbo.customer.MOB2 AS موبايل2, dbo.customer.MAIL AS [ بطاقة الاب],                      dbo.customer.WEB AS [ بطاقة الام], dbo.customer.GUID_ACCOUNT,customer.typ_e as النوع  FROM         dbo.customer INNER JOIN                    dbo.ACCOUNT ON dbo.customer.ID = dbo.ACCOUNT.ID WHERE customer.NAME LIKE '%" & NAME & "%'", Nothing)
        Return DT
    End Function
    Function SHOW_CMB() As DataTable
        Dim DT As New DataTable
        DT.Clear()
        Dim DAL As New DataAccessLayer

        DT = DAL.SelectData("SELECT ID ,NAME FROM customer ", Nothing)
        Return DT
    End Function
    Function SHOW_ALL_STUDENT() As DataTable
        Dim DT As New DataTable
        DT.Clear()
        Dim DAL As New DataAccessLayer

        DT = DAL.SelectData("SELECT ID,DTP AS[المواليد],NAME AS[الاسم],LASTNAME  AS[اسم الاب],COMPANY  AS[اسم الام],COMPANYJOB  AS[ الشركة],CUNTRY  AS[المدينة],STREET  AS[الشارع],PHON  AS[الهاتف],MOB1  AS[موبايل1],MOB2  AS[موبايل2],MAIL  AS[ بطاقة الاب],WEB AS[ بطاقة الام],img  AS [الصورة],salary AS[الراتب الثابت],taxes AS[ضرائب],insurance AS [تامينات] FROM customer ", Nothing)
        Return DT
    End Function
    Public Function delete_account(ByVal guid As String) As DataTable
        Dim CON As New CLS_CON
        Dim DT As New DataTable
        DT.Clear()
        DT = CON.SELECT_TXT("SELECT * FROM customer where  (GUID_ACCOUNT='" & guid & "')")
        Return DT
    End Function
    Public Sub delete_(ByVal id As Integer)
        Dim CON As New CLS_CON
        CON.EXECUTE_TXT("delete from  EMPLOYEE  WHERE id= " & id & " ")

    End Sub
End Class
