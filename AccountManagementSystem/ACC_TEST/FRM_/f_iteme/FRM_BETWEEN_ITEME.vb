Public Class FRM_BETWEEN_ITEME

    Dim CLS_ITEME_ As New CLS_ITEME
 
    Private Sub FRM_BETWEEN_ACCOUNT_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            DTP1.Value = Today
            DTP2.Value = Today

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
       Try
            Dim F As New FRM_ALL_ITEME
            F.ShowDialog()
            If F.isyes = True Then
                Dim i As Integer = F.DGV.CurrentRow.Index
                TXT_ITEME_GUID_1.Text = F.DGV.Rows(i).Cells(0).Value.ToString()
                TXT_ITEME_NAME1.Text = F.DGV.Rows(i).Cells(2).Value.ToString()
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
       Try
            Dim F As New FRM_ALL_ITEME
            F.ShowDialog()
            If F.isyes = True Then
                Dim i As Integer = F.DGV.CurrentRow.Index
                TXT_ITEME_GUID_2.Text = F.DGV.Rows(i).Cells(0).Value.ToString()
                TXT_ITEME_NAME2.Text = F.DGV.Rows(i).Cells(2).Value.ToString()
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub TXT_NAME_ACCOUNT_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TXT_ITEME_NAME1.KeyPress
        e.Handled = True
    End Sub

    Private Sub TXT_NAME_ACCOUNT_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TXT_ITEME_NAME1.TextChanged

    End Sub

    Private Sub TXT_NAME_ACCOUNT2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TXT_ITEME_NAME2.KeyPress
        e.Handled = True
    End Sub

    Private Sub TXT_NAME_ACCOUNT2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TXT_ITEME_NAME2.TextChanged

    End Sub

    Private Sub جديدToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles جديدToolStripMenuItem.Click
        Try
            If TXT_ITEME_GUID_1.Text = Nothing Then
                MessageBox.Show(" من مادة فارغ", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
            If TXT_ITEME_GUID_2.Text = Nothing Then
                MessageBox.Show(" الى مادة فارغ", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
            '--------------------------------------------


            CLS_ITEME_.UPDATE_BETWEEN(TXT_ITEME_GUID_2.Text, TXT_ITEME_GUID_1.Text, DTP1.Value.ToShortDateString(), DTP2.Value.ToShortDateString())
          

            MessageBox.Show("   تمت عملية النقل للحركة بنجاح ", "تاكيد", MessageBoxButtons.OK, MessageBoxIcon.Information)


        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub
End Class