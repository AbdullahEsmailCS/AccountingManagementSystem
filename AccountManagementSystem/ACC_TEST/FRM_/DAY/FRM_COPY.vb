Public Class FRM_COPY
    Public IS_YES As Boolean = False
    Private Sub TXT_ID_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TXT_ID.KeyPress
        If (e.KeyChar >= "a" And e.KeyChar <= "z") Or (e.KeyChar >= "A" And e.KeyChar <= "Z") Or (e.KeyChar >= "ا" And e.KeyChar <= "ي") Then
            e.Handled = True
        End If
    End Sub

    Private Sub TXT_ID_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TXT_ID.TextChanged

    End Sub

    Private Sub حفظToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles حفظToolStripMenuItem.Click
        Try
            If TXT_ID.Text = Nothing Then
                MessageBox.Show("الرقم فارغ", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
            '-----------------------------------------------------------
            If Val(TXT_ID.Text) < 1 Then
                MessageBox.Show("الرقم غير صحيح", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
            '-----------------------------------------------------------
            IS_YES = True
            Me.Close()
        Catch ex As Exception

        End Try

       
    End Sub

    Private Sub FRM_COPY_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class