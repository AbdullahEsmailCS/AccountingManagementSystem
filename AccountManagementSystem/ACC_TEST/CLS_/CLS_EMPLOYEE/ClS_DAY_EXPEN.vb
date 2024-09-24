Imports System.Data.SqlClient
Public Class ClS_DAY_EXPEN
    Public Sub ADD_DAY(ByVal DATEE As DateTime, ByVal ID_EXPEN As Integer, ByVal MONY As Double, ByVal NOTE As String, ByVal TYPEE As Integer, ByVal ID_DAY As Integer)
        Dim PRM(5) As SqlParameter
        Dim DAL As New DataAccessLayer
        PRM(0) = New SqlParameter("@DATE", SqlDbType.DateTime)
        PRM(0).Value = DATEE

        PRM(1) = New SqlParameter("@ID_EXPEN", SqlDbType.Int)
        PRM(1).Value = ID_EXPEN
        PRM(2) = New SqlParameter("@MONY", SqlDbType.Float)
        PRM(2).Value = MONY
        PRM(3) = New SqlParameter("@NOTE", SqlDbType.NVarChar, 1000)
        PRM(3).Value = NOTE

        PRM(4) = New SqlParameter("@TYPEE", SqlDbType.Int)
        PRM(4).Value = TYPEE
        PRM(5) = New SqlParameter("@ID_DAY", SqlDbType.Int)
        PRM(5).Value = ID_DAY
        DAL.ExecuteCommand("INSERT INTO DAY_EXPEN (DATE,ID_EXPEN,MONY,NOTE,TYPEE,ID_DAY)VALUES(@DATE,@ID_EXPEN,@MONY,@NOTE,@TYPEE,@ID_DAY)", PRM)
    End Sub
    Public Sub UPDATE_DAY(ByVal DATEE As DateTime, ByVal ID_EXPEN As Integer, ByVal MONY As Double, ByVal NOTE As String, ByVal TYPEE As Integer, ByVal ID_DAY As Integer)
        Dim PRM(5) As SqlParameter
        Dim DAL As New DataAccessLayer
        PRM(0) = New SqlParameter("@DATE", SqlDbType.DateTime)
        PRM(0).Value = DATEE

        PRM(1) = New SqlParameter("@ID_EXPEN", SqlDbType.Int)
        PRM(1).Value = ID_EXPEN
        PRM(2) = New SqlParameter("@MONY", SqlDbType.Float)
        PRM(2).Value = MONY
        PRM(3) = New SqlParameter("@NOTE", SqlDbType.NVarChar, 1000)
        PRM(3).Value = NOTE

        PRM(4) = New SqlParameter("@TYPEE", SqlDbType.Int)
        PRM(4).Value = TYPEE

        PRM(5) = New SqlParameter("@ID_DAY", SqlDbType.Int)
        PRM(5).Value = ID_DAY
        DAL.ExecuteCommand("UPDATE   DAY_EXPEN  SET  DATE=@DATE,ID_EXPEN=@ID_EXPEN,MONY=@MONY,NOTE=@NOTE  WHERE  TYPEE=@TYPEE AND  ID_DAY=@ID_DAY", PRM)
    End Sub
    Function SHOW_id(ByVal ID_DAY As Integer, ByVal TYPEE As Integer) As DataTable
        Dim DAL As New DataAccessLayer
        Dim DT As New DataTable
        DT.Clear()
        Dim PRM(1) As SqlParameter
        PRM(0) = New SqlParameter("@ID_DAY", SqlDbType.Int)
        PRM(0).Value = ID_DAY
        PRM(1) = New SqlParameter("@TYPEE", SqlDbType.Int)
        PRM(1).Value = TYPEE
        DT = DAL.SelectData("SELECT * FROM DAY_EXPEN WHERE ID_DAY=@ID_DAY AND TYPEE=@TYPEE", PRM)

        Return DT
    End Function
    Function MAX_ID_DAY(ByVal TYPEE As Integer) As DataTable
        Dim DAL As New DataAccessLayer
        Dim DT As New DataTable
        DT.Clear()
        Dim PRM(0) As SqlParameter
       
        PRM(0) = New SqlParameter("@TYPEE", SqlDbType.Int)
        PRM(0).Value = TYPEE
        DT = DAL.SelectData("select ISNULL(max(ID_DAY)+1,1) from DAY_EXPEN WHERE TYPEE=@TYPEE", PRM)
        Return DT
    End Function
    Public Sub DELETE_DAY(ByVal ID_DAY As Integer, ByVal TYPEE As Integer)
        Dim DAL As New DataAccessLayer
        Dim PRM(1) As SqlParameter
        PRM(0) = New SqlParameter("@ID_DAY", SqlDbType.Int)
        PRM(0).Value = ID_DAY
        PRM(1) = New SqlParameter("@TYPEE", SqlDbType.Int)
        PRM(1).Value = TYPEE
        DAL.ExecuteCommand("DELETE FROM DAY_EXPEN WHERE ID_DAY=@ID_DAY AND TYPEE=@TYPEE", PRM)
    End Sub
  
    Function SHOW_DAY(ByVal ID_DAY As Integer, ByVal TYPEE As Integer) As DataTable
        Dim DAL As New DataAccessLayer
        Dim DT As New DataTable
        DT.Clear()
        Dim PRM(1) As SqlParameter
        PRM(0) = New SqlParameter("@ID_DAY", SqlDbType.Int)
        PRM(0).Value = ID_DAY
        PRM(1) = New SqlParameter("@TYPEE", SqlDbType.Int)
        PRM(1).Value = TYPEE
        DT = DAL.SelectData("SELECT  [DATE],ID_EXPEN,MONY,NOTE,TYPEE,ID_DAY  FROM DAY_EXPEN WHERE (ID_DAY=@ID_DAY) AND (TYPEE=@TYPEE)", PRM)
        Return DT
    End Function
  
    Function MIN_ID(ByVal TYPEE As Integer) As DataTable
        Dim DAL As New DataAccessLayer
        Dim DT As New DataTable
        DT.Clear()
        Dim PRM(0) As SqlParameter

        PRM(0) = New SqlParameter("@TYPEE", SqlDbType.Int)
        PRM(0).Value = TYPEE
        DT = DAL.SelectData("select ISNULL(min(ID_DAY),1) from DAY_EXPEN WHERE TYPEE=@TYPEE", PRM)
        Return DT
    End Function
    Function NTEGA(ByVal TYPEE As Integer, ByVal D1 As DateTime, ByVal D2 As DateTime) As DataTable
        Dim DAL As New DataAccessLayer
        Dim DT As New DataTable
        DT.Clear()
        Dim PRM(2) As SqlParameter
        PRM(0) = New SqlParameter("@D1", SqlDbType.DateTime)
        PRM(0).Value = D1
        PRM(1) = New SqlParameter("@D2", SqlDbType.DateTime)
        PRM(1).Value = D2
        PRM(2) = New SqlParameter("@TYPEE", SqlDbType.Int)
        PRM(2).Value = TYPEE

        DT = DAL.SelectData("SELECT     SUM(MONY) AS Expr1 FROM         dbo.DAY_EXPEN WHERE (TYPEE = @TYPEE) AND    (DATE BETWEEN CONVERT(DATETIME, @D1, 102) AND CONVERT(DATETIME, @D2, 102))  ", PRM)
        Return DT
    End Function
End Class
