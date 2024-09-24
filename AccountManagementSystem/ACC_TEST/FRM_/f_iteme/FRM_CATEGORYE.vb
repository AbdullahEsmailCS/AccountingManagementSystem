Public Class FRM_CATEGORYE
    Dim CLS_CATEGORY_ As New ClS_CATEGORYE
    Private Sub FRM_CATEGORYE_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            SHOW_()
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub
    Sub SHOW_()
        Dim DT As New DataTable
        DT.Clear()
        DT = CLS_CATEGORY_.SELECT_()
        DGV.DataSource = DT
        DGV.Columns(2).Visible = False

    End Sub

    Private Sub حفظToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles حفظToolStripMenuItem.Click
        Try
            If TXT_NAME.Text = Nothing Then
                MessageBox.Show("الاسم غير موجود", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
            '-----------------------------------------------------------
            If TXT_GUID.Text = Nothing Then
                ADD_()
                MessageBox.Show("  تمت عملية الحفظ بنجاح", "تاكيد", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else

                UPDATE_()
                MessageBox.Show("  تمت عملية التعديل بنجاح", "تاكيد", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
            SHOW_()
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub
    Sub ADD_()
        CLS_CATEGORY_.ADD_(TXT_NAME.Text, guid_user_log, "00000000-0000-0000-0000-000000000000")
    End Sub
    Sub UPDATE_()
        CLS_CATEGORY_.UPDATE_(TXT_NAME.Text, TXT_GUID.Text, guid_user_log, "00000000-0000-0000-0000-000000000000")
    End Sub

    Private Sub DGV_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGV.CellClick
        Try
            Dim I As Integer = DGV.CurrentRow.Index
            TXT_NAME.Text = DGV.Rows(I).Cells(1).Value.ToString()
            TXT_GUID.Text = DGV.Rows(I).Cells(2).Value.ToString()
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub DGV_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGV.CellContentClick

    End Sub

    Private Sub جديدToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles جديدToolStripMenuItem.Click
        Try
            TXT_NAME.Text = Nothing
            TXT_GUID.Text = Nothing
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub
End Class