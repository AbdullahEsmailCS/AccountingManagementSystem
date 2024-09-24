Public Class FRM_ALL_ITEME_POS

    Dim CLS_ITEME_ As New CLS_ITEME
    Public isyes As Boolean = False
    Private Sub FRM_ALL_ITEME_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            SEARSH_()

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub
    Sub SEARSH_()
        Dim count__ As Integer = 0

        Dim DT As New DataTable
        DT.Clear()
        DT = CLS_ITEME_.searsh_itemeall(TXT_SEARSH.Text)
        'DGV.DataSource = DT
        'DGV.Columns(0).Visible = False
        'DGV.Columns(1).Visible = False
        If DT.Rows.Count > 0 Then
            DGV.RowCount = DT.Rows.Count

            For i As Integer = 0 To DT.Rows.Count - 1
                DGV.Rows(count__).Cells(0).Value = DT.Rows(i)(0).ToString()
                DGV.Rows(count__).Cells(1).Value = DT.Rows(i)(1).ToString()
                DGV.Rows(count__).Cells(2).Value = DT.Rows(i)(2).ToString()
                DGV.Rows(count__).Cells(3).Value = DT.Rows(i)(3).ToString()
                DGV.Rows(count__).Cells(4).Value = DT.Rows(i)(4).ToString()

                'DGV.Rows(count__).Cells(5).Value = DT.Rows(i)(5).ToString()
                DGV.Rows(count__).Cells(6).Value = DT.Rows(i)(6).ToString()
                DGV.Rows(count__).Cells(7).Value = DT.Rows(i)(7).ToString()
                DGV.Rows(count__).Cells(8).Value = DT.Rows(i)(8).ToString()
                DGV.Rows(count__).Cells(9).Value = DT.Rows(i)(9).ToString()
                DGV.Rows(count__).Cells(10).Value = DT.Rows(i)(10).ToString()
                DGV.Rows(count__).Cells(11).Value = DT.Rows(i)(11).ToString()
                DGV.Rows(count__).Cells(12).Value = DT.Rows(i)(12).ToString()

                count__ = count__ + 1

            Next
            'Me.DGV.RowTemplate.Height = 80
        End If
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
            Dim i As Integer = DGV.CurrentRow.Index
            DGV.Rows(i).Cells(5).Value = True

            isyes = True
            Close()

        Catch ex As Exception

        End Try

    End Sub

   

    Private Sub DGV_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles DGV.KeyPress
        Try

            If (e.KeyChar = CType(ChrW(Keys.Enter), Char)) Then
                'Dim i As Integer = DGV.CurrentCell.RowIndex
                'DGV.Rows(i).Cells(5).Value = True
                isyes = True
                Close()
            End If


        Catch ex As Exception

        End Try
    End Sub

 
    Private Sub ButtonX21_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX21.Click
        Close()
    End Sub

    Private Sub DGV_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGV.CellContentClick

    End Sub
End Class