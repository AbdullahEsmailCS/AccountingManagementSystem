Public Class FRM_ALL_EMPLOYEE_POS
    Public isok As Boolean = False
    Dim CLS_EMPLOYEE_ As New CLS_EMPLOYEE
    Private Sub FRM_ALL_CUSTOMER_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        TXT_SEARSH.Text = "1"
        TXT_SEARSH.Text = ""
    End Sub


    Private Sub TXT_SEARSH_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TXT_SEARSH.TextChanged
        Try
            Dim DT As New DataTable
            DT.Clear()
            DT = CLS_EMPLOYEE_.ALL_ITEME(TXT_SEARSH.Text)
            DGV.DataSource = DT
            DGV.Columns(5).Visible = False
            DGV.Columns(6).Visible = False
            DGV.Columns(7).Visible = False
            DGV.Columns(8).Visible = False
            DGV.Columns(9).Visible = False
            DGV.Columns(10).Visible = False
            DGV.Columns(11).Visible = False
            DGV.Columns(12).Visible = False
            DGV.Columns(13).Visible = False

            Me.DGV.RowTemplate.Height = 80
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub DGV_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGV.CellClick
        Try
            isok = True
            Close()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub DGV_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGV.CellContentClick

    End Sub

    Private Sub ButtonX21_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX21.Click
        Close()
    End Sub
End Class