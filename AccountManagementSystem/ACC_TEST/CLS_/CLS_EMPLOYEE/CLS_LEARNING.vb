Imports System.Data.SqlClient
Public Class CLS_LEARNING
    Function SHOW_() As DataTable
        Dim DT As New DataTable
        DT.Clear()
        Dim DAL As New DataAccessLayer
        DT = DAL.SelectData("SELECT ID AS[الرقم],NAME AS[اسم ] FROM LEARNING", Nothing)
        Return DT
    End Function
    Function SHOW__CMB() As DataTable
        Dim DT As New DataTable
        DT.Clear()
        Dim DAL As New DataAccessLayer
        DT = DAL.SelectData("SELECT ID ,NAME  FROM LEARNING", Nothing)
        Return DT
    End Function
    Public Sub ADD_(ByVal NAME As String)
        Dim PRM(0) As SqlParameter
        Dim DAL As New DataAccessLayer
        PRM(0) = New SqlParameter("@NAME", SqlDbType.NVarChar, 500)
        PRM(0).Value = NAME
        DAL.ExecuteCommand("INSERT INTO LEARNING (NAME)VALUES(@NAME)", PRM)
    End Sub

    Public Sub UPDATE_(ByVal NAME As String, ByVal ID As Integer)
        Dim PRM(1) As SqlParameter
        Dim DAL As New DataAccessLayer
        PRM(0) = New SqlParameter("@NAME", SqlDbType.NVarChar, 500)
        PRM(0).Value = NAME
        PRM(1) = New SqlParameter("@ID", SqlDbType.Int)
        PRM(1).Value = ID
        DAL.ExecuteCommand("UPDATE   LEARNING SET NAME=@NAME WHERE ID =@ID ", PRM)
    End Sub
    Function SHOW_CMB() As DataTable
        Dim DT As New DataTable
        DT.Clear()
        Dim DAL As New DataAccessLayer

        DT = DAL.SelectData("SELECT [ID] ,[NAME] FROM LEARNING ", Nothing)
        Return DT
    End Function
End Class
