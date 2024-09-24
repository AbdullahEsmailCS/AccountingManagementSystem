Imports System.Data.SqlClient
Public Class CLS_EXPEN
    Function SHOW_CATEGORY(TYPE As Integer) As DataTable
        Dim DT As New DataTable
        DT.Clear()
        Dim DAL As New DataAccessLayer

        DT = DAL.SelectData("SELECT ID_EXPEN AS[الرقم],NAME AS[اسم الصنف] FROM EXPEN where TYPE=" & Val(TYPE) & "", Nothing)
        Return DT
    End Function
    Function SHOW_CATEGORY_CMB() As DataTable
        Dim DT As New DataTable
        DT.Clear()
        Dim DAL As New DataAccessLayer
        DT = DAL.SelectData("SELECT ID_EXPEN ,NAME,TYPE  FROM EXPEN", Nothing)
        Return DT
    End Function
    Public Sub ADD_CATEGORY(ByVal NAME As String, TYPE As Integer)
        Dim PRM(1) As SqlParameter
        Dim DAL As New DataAccessLayer
        PRM(0) = New SqlParameter("@NAME", SqlDbType.NVarChar, 500)
        PRM(0).Value = NAME

        PRM(1) = New SqlParameter("@TYPE", SqlDbType.Int)
        PRM(1).Value = Type
        DAL.ExecuteCommand("INSERT INTO EXPEN (NAME,TYPE)VALUES(@NAME,@TYPE)", PRM)
    End Sub

    Public Sub UPDATE_CATEGORY(ByVal NAME As String, ByVal ID As Integer)
        Dim PRM(1) As SqlParameter
        Dim DAL As New DataAccessLayer
        PRM(0) = New SqlParameter("@NAME", SqlDbType.NVarChar, 500)
        PRM(0).Value = NAME
        PRM(1) = New SqlParameter("@ID_EXPEN", SqlDbType.Int)
        PRM(1).Value = ID
        DAL.ExecuteCommand("UPDATE   EXPEN SET NAME=@NAME WHERE ID_EXPEN =@ID_EXPEN ", PRM)
    End Sub
    Function SHOW_CMB(ByVal TYPE As Integer) As DataTable
        Dim DT As New DataTable
        DT.Clear()
        Dim DAL As New DataAccessLayer

        DT = DAL.SelectData("SELECT ID_EXPEN ,NAME FROM EXPEN where TYPE=" & Val(TYPE) & "", Nothing)
        Return DT
    End Function
  
End Class
