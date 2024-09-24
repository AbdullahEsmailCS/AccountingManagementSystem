Imports System.Data.SqlClient
Public Class CLS_JOBE_MPLOYEE

    Function SHOW_CATEGORY() As DataTable
        Dim DT As New DataTable
        DT.Clear()
        Dim DAL As New DataAccessLayer
        DT = DAL.SelectData("SELECT ID_CATEGORY AS[الرقم],NAME_CATEGORY AS[اسم الصنف] FROM JOBE_MPLOYEE", Nothing)
        Return DT
    End Function
    Function SHOW_CATEGORY_CMB() As DataTable
        Dim DT As New DataTable
        DT.Clear()
        Dim DAL As New DataAccessLayer
        DT = DAL.SelectData("SELECT ID_CATEGORY ,NAME_CATEGORY  FROM JOBE_MPLOYEE", Nothing)
        Return DT
    End Function
    Public Sub ADD_CATEGORY(ByVal NAME As String)
        Dim PRM(0) As SqlParameter
        Dim DAL As New DataAccessLayer
        PRM(0) = New SqlParameter("@NAME_CATEGORY", SqlDbType.NVarChar, 500)
        PRM(0).Value = NAME
        DAL.ExecuteCommand("INSERT INTO JOBE_MPLOYEE (NAME_CATEGORY)VALUES(@NAME_CATEGORY)", PRM)
    End Sub

    Public Sub UPDATE_CATEGORY(ByVal NAME As String, ByVal ID As Integer)
        Dim PRM(1) As SqlParameter
        Dim DAL As New DataAccessLayer
        PRM(0) = New SqlParameter("@NAME_CATEGORY", SqlDbType.NVarChar, 500)
        PRM(0).Value = NAME
        PRM(1) = New SqlParameter("@ID_CATEGORY", SqlDbType.Int)
        PRM(1).Value = ID
        DAL.ExecuteCommand("UPDATE   JOBE_MPLOYEE SET NAME_CATEGORY=@NAME_CATEGORY WHERE ID_CATEGORY =@ID_CATEGORY ", PRM)
    End Sub
    Function SHOW_CMB() As DataTable
        Dim DT As New DataTable
        DT.Clear()
        Dim DAL As New DataAccessLayer

        DT = DAL.SelectData("SELECT [ID_CATEGORY] ,[NAME_CATEGORY] FROM JOBE_MPLOYEE ", Nothing)
        Return DT
    End Function
End Class
