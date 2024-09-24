Imports System.Data.SqlClient
Public Class CLS_EMPLOYEE_LEARNING
    Public Sub ADD_(ByVal ID_STUDENT As Integer, ByVal ID_LEARNING As Integer, ByVal DATE_B As DateTime, ByVal DATE_E As DateTime, ByVal t_EMPLOYEE_LEARN As String, ByVal coun_EMPLOYEE_LEARN As String)
        Dim PRM(5) As SqlParameter
        Dim DAL As New DataAccessLayer
        PRM(0) = New SqlParameter("@ID_STUDENT", SqlDbType.Int)
        PRM(0).Value = ID_STUDENT
        PRM(1) = New SqlParameter("@ID_LEARNING", SqlDbType.Int)
        PRM(1).Value = ID_LEARNING


        PRM(2) = New SqlParameter("@DATE_B", SqlDbType.DateTime)
        PRM(2).Value = DATE_B
        PRM(3) = New SqlParameter("@DATE_E", SqlDbType.DateTime)
        PRM(3).Value = DATE_E

        PRM(4) = New SqlParameter("@t_EMPLOYEE_LEARN", SqlDbType.NVarChar, 500)
        PRM(4).Value = t_EMPLOYEE_LEARN
        PRM(5) = New SqlParameter("@coun_EMPLOYEE_LEARN", SqlDbType.NVarChar, 500)
        PRM(5).Value = coun_EMPLOYEE_LEARN
      
        DAL.ExecuteCommand("INSERT INTO EMPLOYEE_LEARN (ID_STUDENT,ID_LEARNING,DATE_B,DATE_E,t_EMPLOYEE_LEARN,coun_EMPLOYEE_LEARN)VALUES(@ID_STUDENT,@ID_LEARNING,@DATE_B,@DATE_E,@t_EMPLOYEE_LEARN,@coun_EMPLOYEE_LEARN)", PRM)
    End Sub

    Public Sub delete_(ByVal ID_STUDENT As Integer)
        Dim PRM(0) As SqlParameter
        Dim DAL As New DataAccessLayer
        PRM(0) = New SqlParameter("@ID_STUDENT", SqlDbType.Int)
        PRM(0).Value = ID_STUDENT
      
        DAL.ExecuteCommand("delete from  EMPLOYEE_LEARN where ID_STUDENT=@ID_STUDENT", PRM)
    End Sub
    Function SHOW_(ByVal ID As Integer) As DataTable
        Dim DAL As New DataAccessLayer
        Dim DT As New DataTable
        DT.Clear()
        DT = DAL.SelectData("SELECT     dbo.EMPLOYEE_LEARN.ID_LEARNING, dbo.LEARNING.NAME, dbo.EMPLOYEE_LEARN.DATE_B, dbo.EMPLOYEE_LEARN.DATE_E, dbo.EMPLOYEE_LEARN.t_EMPLOYEE_LEARN,                   dbo.EMPLOYEE_LEARN.coun_EMPLOYEE_LEARN  FROM         dbo.EMPLOYEE_LEARN INNER JOIN            dbo.LEARNING ON dbo.EMPLOYEE_LEARN.ID_LEARNING = dbo.LEARNING.ID  WHERE EMPLOYEE_LEARN.ID_STUDENT=" & ID & " ", Nothing)
        Return DT
    End Function
End Class
