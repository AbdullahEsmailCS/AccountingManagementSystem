Public Class FRM_ALL_HOB

    Dim CLS_JOB_ As New CLS_JOB
    Public IS_YES As Boolean = False
    Private Sub FRM_ALL_GROUP_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            SEARSH_()
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub
    Sub SEARSH_()
        Dim DT As New DataTable
        DT.Clear()
        DT = CLS_JOB_.SELECT_STORE(TXT_SEARSH.Text)
        DGV.DataSource = DT
        DGV.Columns(2).Visible = False
    End Sub

    Private Sub TXT_SEARSH_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TXT_SEARSH.TextChanged
        Try
            SEARSH_()
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub DGV_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGV.CellClick
        Try
            IS_YES = True
            Close()

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub DGV_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGV.CellContentClick

    End Sub
End Class