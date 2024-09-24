Public Class FRM_ALL_CUS_VEN

    Public isok As Boolean = False
    Dim CLS_CU_VEN_ As New CLS_CU_VEN
    Private Sub FRM_ALL_CUSTOMER_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        TXT_SEARSH.Text = "1"
        TXT_SEARSH.Text = ""
    End Sub


    Private Sub TXT_SEARSH_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TXT_SEARSH.TextChanged
        Try
            Dim DT As New DataTable
            DT.Clear()
            DT = CLS_CU_VEN_.ALL_ITEME(TXT_SEARSH.Text)
            DGV.DataSource = DT
            DGV.Columns(0).Visible = False
            DGV.Columns(1).Visible = False
            DGV.Columns(5).Visible = False
            'DGV.Columns(6).Visible = False
            'DGV.Columns(7).Visible = False
            'DGV.Columns(8).Visible = False
            'DGV.Columns(9).Visible = False
            'DGV.Columns(10).Visible = False
            DGV.Columns(11).Visible = False
            DGV.Columns(12).Visible = False
            DGV.Columns(13).Visible = False


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

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Dim F As New FRM_TRF2
        F.ShowDialog()
    End Sub
End Class