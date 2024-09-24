Public Class FRM_ALL_USER

    Dim CLS_USER_ As New CLS_USER
    Public isok As Boolean = False

   
    Sub SEARS_()
        Dim count__ As Integer = 0
        Dim DT As New DataTable
        DT.Clear()
        
        DT = CLS_USER_.SELECT_all()


        If DT.Rows.Count > 0 Then
            DGV.RowCount = DT.Rows.Count
            For i As Integer = 0 To DT.Rows.Count - 1
                DGV.Rows(count__).Cells(0).Value = DT.Rows(i)(0).ToString()
                DGV.Rows(count__).Cells(1).Value = DT.Rows(i)(1).ToString()
              
                count__ = count__ + 1
            Next

        End If
        'DGV.DataSource = DT
        'DGV.Columns(0).Visible = False
        'DGV.Columns(2).Visible = False
        ''DGV.Columns(3).Visible = False
        'DGV.Columns(4).Visible = False
    End Sub

    Private Sub TXT_SEARSH_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            SEARS_()
        Catch ex As Exception

        End Try
    End Sub








   
    Private Sub DGV_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        Try
            If (e.KeyChar = CType(ChrW(Keys.Enter), Char)) Then
                'Dim i As Integer = DGV.CurrentRow.Index
                'MessageBox.Show(i.ToString)
                isok = True
                Close()
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub DGV_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGV.CellClick
        isok = True
        Close()
    End Sub


    Private Sub DGV_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGV.CellContentClick

    End Sub

    Private Sub TXT_SEARSH_TextChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try

        Catch ex As Exception

        End Try
    End Sub

    Private Sub FRM_ALL_USER_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            SEARS_()
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub
End Class