Public Class FRM_ALL_ACCOUNT
    Dim CLS_ACCOUNT_ As New CLS_ACCOUNT
    Public IS_YES As Boolean = False

    Private Sub FRM_ALL_ACCOUNT_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            SEARS_()
        Catch ex As Exception

        End Try
    End Sub
    Sub SEARS_()
        Dim count__ As Integer = 0
        Dim DT As New DataTable
        DT.Clear()
        If number_day___ = 0 Then
            DT = CLS_ACCOUNT_.ALL_(TXT_SEARSH.Text)
        Else
            DT = CLS_ACCOUNT_.ALL_nsons(TXT_SEARSH.Text)
        End If

        If DT.Rows.Count > 0 Then
            DGV.RowCount = DT.Rows.Count
            For i As Integer = 0 To DT.Rows.Count - 1
                DGV.Rows(count__).Cells(0).Value = DT.Rows(i)(0).ToString()
                DGV.Rows(count__).Cells(1).Value = DT.Rows(i)(1).ToString()
                DGV.Rows(count__).Cells(2).Value = DT.Rows(i)(2).ToString()
                DGV.Rows(count__).Cells(3).Value = DT.Rows(i)(3).ToString()
                DGV.Rows(count__).Cells(4).Value = DT.Rows(i)(4).ToString()
                count__ = count__ + 1
            Next

        End If
        'DGV.DataSource = DT
        'DGV.Columns(0).Visible = False
        'DGV.Columns(2).Visible = False
        ''DGV.Columns(3).Visible = False
        'DGV.Columns(4).Visible = False
    End Sub

    Private Sub TXT_SEARSH_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TXT_SEARSH.TextChanged
        Try
            SEARS_()
        Catch ex As Exception

        End Try
    End Sub



  




    Private Sub DGV_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles DGV.DoubleClick
        Try
            Dim i As Integer = DGV.CurrentRow.Index
            DGV.Rows(i).Cells(5).Value = True

            IS_YES = True
            Close()

        Catch ex As Exception

        End Try
    End Sub
    Private Sub DGV_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles DGV.KeyPress
        Try
            If (e.KeyChar = CType(ChrW(Keys.Enter), Char)) Then
                'Dim i As Integer = DGV.CurrentRow.Index
                'MessageBox.Show(i.ToString)
                IS_YES = True
                Close()
            End If        
        Catch ex As Exception
        End Try     
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Dim F As New FRM_NEW_ACCOUNT
        F.cmb_()
        F.ShowDialog()
    End Sub
End Class