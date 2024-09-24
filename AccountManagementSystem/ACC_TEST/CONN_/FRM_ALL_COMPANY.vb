Imports System.Data.SqlClient
Imports System.IO

Public Class FRM_ALL_COMPANY

    Private Sub FRM_ALL_COMPANY_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            SHOW_DGV()
        Catch ex As Exception

        End Try
    End Sub
    Sub SHOW_DGV()
        'If TXT_CON___CONFIG = Nothing Then
        '    Exit Sub
        'End If


        Dim Con_1 As New SqlConnection(File.ReadAllText("c:\CONN\CONFIG.TXT"))

        If (Con_1.State = ConnectionState.Open) Then
            Con_1.Close()
        End If

        Con_1.Open()

        Dim ADP As New SqlDataAdapter("SELECT ID,Name,DataBasee,CONN FROM COMPANY", Con_1)
        Dim DT As New DataTable
        DT.Clear()
        ADP.Fill(DT)
        If DT.Rows.Count > 0 Then
            DGV.DataSource = DT
            'DGV.Columns(2).Visible = False
            DGV.Columns(3).Visible = False
        End If
     

        Con_1.Close()
      

    End Sub
    Private Sub Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub DGV_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGV.CellClick
      
    End Sub

    Private Sub DGV_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGV.CellContentClick

    End Sub

    Private Sub ButtonX1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX1.Click

        Try
            Dim f As New FRM_NEW_COMPANY

            f.ShowDialog()

            SHOW_DGV()
            ButtonX1.Enabled = False
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
      
    End Sub

    Private Sub ButtonX2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX2.Click

        Application.Exit()
    End Sub

    Private Sub DGV_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGV.CellDoubleClick
        Try
            Dim I As Integer = DGV.CurrentRow.Index
            Dim TXT As String = DGV.Rows(I).Cells(3).Value.ToString()

            File.WriteAllText("c:\CONN\conn.TXT", TXT)
            Close()
        Catch ex As Exception

        End Try
    End Sub
End Class