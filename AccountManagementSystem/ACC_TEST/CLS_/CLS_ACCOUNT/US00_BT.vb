Imports System.Data.SqlClient
Public Class US00_BT
    Public Sub ADD_Bt(ByVal GUIDUSER As String, ByVal GUID_BT As String,
                      ByVal ISINSERT As Boolean,
                      ByVal ISUPDATE As Boolean, ByVal ISDELETE As Boolean, ByVal ISprint As Boolean, ByVal ISSHOW As Boolean)

        Dim DAL As New DataAccessLayer
        Dim PRM(6) As SqlParameter
        PRM(0) = New SqlParameter("@GUIDUSER", SqlDbType.NVarChar, 500)
        PRM(0).Value = GUIDUSER
        PRM(1) = New SqlParameter("@GUID_BT", SqlDbType.NVarChar, 500)
        PRM(1).Value = GUID_BT

        PRM(2) = New SqlParameter("@ISINSERT", SqlDbType.Bit)
        PRM(2).Value = ISINSERT

        PRM(3) = New SqlParameter("@ISUPDATE", SqlDbType.Bit)
        PRM(3).Value = ISUPDATE
        PRM(4) = New SqlParameter("@ISDELETE", SqlDbType.Bit)
        PRM(4).Value = ISDELETE
        PRM(5) = New SqlParameter("@ISprint", SqlDbType.Bit)
        PRM(5).Value = ISprint
        PRM(6) = New SqlParameter("@ISSHOW", SqlDbType.Bit)
        PRM(6).Value = ISSHOW

        DAL.ExecuteCommand("insert into US00_BT (GUIDUSER,GUID_BT,ISINSERT,ISUPDATE,ISDELETE,ISprint ,ISSHOW )values (@GUIDUSER,@GUID_BT,@ISINSERT,@ISUPDATE,@ISDELETE,@ISprint ,@ISSHOW ) ", PRM)
    End Sub
    Public Sub ADD_ET(ByVal GUIDUSER As String, ByVal GUID_BT As String,
                      ByVal ISINSERT As Boolean,
                      ByVal ISUPDATE As Boolean, ByVal ISDELETE As Boolean, ByVal ISprint As Boolean, ByVal ISSHOW As Boolean)

        Dim DAL As New DataAccessLayer
        Dim PRM(6) As SqlParameter
        PRM(0) = New SqlParameter("@GUIDUSER", SqlDbType.NVarChar, 500)
        PRM(0).Value = GUIDUSER
        PRM(1) = New SqlParameter("@GUID_BT", SqlDbType.NVarChar, 500)
        PRM(1).Value = GUID_BT

        PRM(2) = New SqlParameter("@ISINSERT", SqlDbType.Bit)
        PRM(2).Value = ISINSERT

        PRM(3) = New SqlParameter("@ISUPDATE", SqlDbType.Bit)
        PRM(3).Value = ISUPDATE
        PRM(4) = New SqlParameter("@ISDELETE", SqlDbType.Bit)
        PRM(4).Value = ISDELETE
        PRM(5) = New SqlParameter("@ISprint", SqlDbType.Bit)
        PRM(5).Value = ISprint
        PRM(6) = New SqlParameter("@ISSHOW", SqlDbType.Bit)
        PRM(6).Value = ISSHOW

        DAL.ExecuteCommand("insert into US00_ET (GUIDUSER,GUID_BT,ISINSERT,ISUPDATE,ISDELETE,ISprint ,ISSHOW )values (@GUIDUSER,@GUID_BT,@ISINSERT,@ISUPDATE,@ISDELETE,@ISprint ,@ISSHOW ) ", PRM)
    End Sub
    Public Sub delete_BT(ByVal GUIDUSER As String)

        Dim DAL As New DataAccessLayer
        Dim PRM(0) As SqlParameter
        PRM(0) = New SqlParameter("@GUIDUSER", SqlDbType.NVarChar, 500)
        PRM(0).Value = GUIDUSER

        DAL.ExecuteCommand("delete from US00_BT where  GUIDUSER=@GUIDUSER ", PRM)
    End Sub
    Public Sub delete_ET(ByVal GUIDUSER As String)

        Dim DAL As New DataAccessLayer
        Dim PRM(0) As SqlParameter
        PRM(0) = New SqlParameter("@GUIDUSER", SqlDbType.NVarChar, 500)
        PRM(0).Value = GUIDUSER

        DAL.ExecuteCommand("delete from US00_ET where  GUIDUSER=@GUIDUSER ", PRM)
    End Sub
    Function GUID_BT_(ByVal GUID_BT As String) As DataTable
        Dim DAL As New DataAccessLayer
        Dim DT As New DataTable
        DT.Clear()
        DT = DAL.SelectData("select  *  FROM US00_BT  where GUIDUSER='" & GUID_BT & "' ", Nothing)
        Return DT
    End Function
    Function GUID_ET_(ByVal GUID_BT As String) As DataTable
        Dim DAL As New DataAccessLayer
        Dim DT As New DataTable
        DT.Clear()
        DT = DAL.SelectData("select  *  FROM US00_ET  where GUIDUSER='" & GUID_BT & "' ", Nothing)
        Return DT
    End Function
    Function GUID_BT_us(ByVal GUID_BT As String, ByVal GUIDUSER As String) As DataTable
        Dim DAL As New DataAccessLayer
        Dim DT As New DataTable
        DT.Clear()
        DT = DAL.SelectData("select  ISINSERT,ISUPDATE,ISDELETE,ISprint ,ISSHOW FROM US00_BT  where GUID_BT='" & GUID_BT & "' and GUIDUSER='" & GUIDUSER & "'", Nothing)
        Return DT
    End Function
    Function GUID_ET_us(ByVal GUID_BT As String, ByVal GUIDUSER As String) As DataTable
        Dim DAL As New DataAccessLayer
        Dim DT As New DataTable
        DT.Clear()
        DT = DAL.SelectData("select  ISINSERT,ISUPDATE,ISDELETE,ISprint ,ISSHOW FROM US00_ET  where GUID_BT='" & GUID_BT & "' and GUIDUSER='" & GUIDUSER & "'", Nothing)
        Return DT
    End Function
End Class
