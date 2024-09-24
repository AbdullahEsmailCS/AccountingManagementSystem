Public Class FRM_BETWEEN_ACCOUNT
    Dim CLS_DAY_ As New CLS_DAY
    Dim CLS_CASH_DAY_ As New CLS_CASH_DAY
    Dim CLS_BILL_ As New CLS_BILL
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
            number_day___ = 0
            Dim f As New FRM_ALL_ACCOUNT
            f.ShowDialog()
            If f.IS_YES = True Then
                Dim i As Integer = f.DGV.CurrentRow.Index
                TXT_GUID_ACCOUNT.Text = f.DGV.Rows(i).Cells(0).Value.ToString()
                TXT_NAME_ACCOUNT.Text = f.DGV.Rows(i).Cells(1).Value.ToString()
            End If
            number_day___ = 0

        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Try
            number_day___ = 0
            Dim f As New FRM_ALL_ACCOUNT
            f.ShowDialog()
            If f.IS_YES = True Then
                Dim i As Integer = f.DGV.CurrentRow.Index
                TXT_GUID_ACCOUNT2.Text = f.DGV.Rows(i).Cells(0).Value.ToString()
                TXT_NAME_ACCOUNT2.Text = f.DGV.Rows(i).Cells(1).Value.ToString()
            End If
            number_day___ = 0

        Catch ex As Exception

        End Try
    End Sub

    Private Sub TXT_NAME_ACCOUNT_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TXT_NAME_ACCOUNT.KeyPress
        e.Handled = True
    End Sub

    Private Sub TXT_NAME_ACCOUNT_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TXT_NAME_ACCOUNT.TextChanged

    End Sub

    Private Sub TXT_NAME_ACCOUNT2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TXT_NAME_ACCOUNT2.KeyPress
        e.Handled = True
    End Sub

    Private Sub TXT_NAME_ACCOUNT2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TXT_NAME_ACCOUNT2.TextChanged

    End Sub

    Private Sub جديدToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles جديدToolStripMenuItem.Click
        Try
            If TXT_GUID_ACCOUNT.Text = Nothing Then
                MessageBox.Show(" من حساب فارغ", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
            If TXT_GUID_ACCOUNT2.Text = Nothing Then
                MessageBox.Show(" الى حساب فارغ", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
            '--------------------------------------------


            CLS_DAY_.UPDATE_BETWEEN(TXT_GUID_ACCOUNT2.Text, TXT_GUID_ACCOUNT.Text, DTP1.Value.ToShortDateString(), DTP2.Value.ToShortDateString())
            CLS_CASH_DAY_.UPDATE_BETWEEN(TXT_GUID_ACCOUNT2.Text, TXT_GUID_ACCOUNT.Text, DTP1.Value.ToShortDateString(), DTP2.Value.ToShortDateString())

            CLS_BILL_.UPDATE_BETWEEN(TXT_GUID_ACCOUNT2.Text, TXT_GUID_ACCOUNT.Text, DTP1.Value.ToShortDateString(), DTP2.Value.ToShortDateString())



            MessageBox.Show("   تمت عملية النقل للحركة بنجاح ", "تاكيد", MessageBoxButtons.OK, MessageBoxIcon.Information)


        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub
End Class