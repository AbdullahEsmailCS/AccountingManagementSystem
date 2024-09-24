Public Class FRM_SETINGS_BILL

    Dim ClS_TYPE_BILL_ As New ClS_TYPE_BILL
    Private Sub FRM_SETINGS_BILL_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try

            MAX_()



        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub
    Sub MAX_()
        Dim DT As New DataTable
        DT.Clear()
        DT = ClS_TYPE_BILL_.MAX_ID
        If DT.Rows.Count > 0 Then
            TXT_ID.Text = DT.Rows(0)(0).ToString()
        End If
    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        Try
            MAX_()
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click
        Try
            Dim max___ As Double = 0
            Dim DT As New DataTable
            DT.Clear()
            DT = ClS_TYPE_BILL_.MAX_ID
            If DT.Rows.Count > 0 Then
                max___ = DT.Rows(0)(0).ToString()
            End If

            TXT_ID.Text = TXT_ID.Text + 1
            If Val(TXT_ID.Text) > Val(max___) Then
                TXT_ID.Text = max___
                MessageBox.Show("هذا اكبر رقم", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

        Catch ex As Exception

        End Try
    End Sub

    Private Sub PictureBox4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox4.Click
        Try
            Dim min___ As Double = 0
            Dim DT As New DataTable
            DT.Clear()
            DT = ClS_TYPE_BILL_.MIN_ID
            If DT.Rows.Count > 0 Then
                min___ = DT.Rows(0)(0).ToString()
            End If

            TXT_ID.Text = TXT_ID.Text - 1
            If Val(TXT_ID.Text) < Val(min___) Then
                TXT_ID.Text = min___
                MessageBox.Show("هذا اصغر رقم", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

        Catch ex As Exception

        End Try
    End Sub

    Private Sub PictureBox3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox3.Click
        Try
            MIN_()
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub
    Sub MIN_()
        Dim DT As New DataTable
        DT.Clear()
        DT = ClS_TYPE_BILL_.MIN_ID
        If DT.Rows.Count > 0 Then
            TXT_ID.Text = DT.Rows(0)(0).ToString()
        End If
    End Sub

    Private Sub TXT_NAME_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TXT_NAME.KeyPress
        e.Handled = True
    End Sub

    Private Sub TXT_NAME_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TXT_NAME.TextChanged

    End Sub

    Private Sub TXT_ITEME_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TXT_ITEME.KeyPress
        e.Handled = True
    End Sub

    Private Sub TXT_ITEME_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TXT_ITEME.TextChanged

    End Sub

    Private Sub TXT_DISC_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TXT_DISC.KeyPress
        e.Handled = True
    End Sub

    Private Sub TXT_DISC_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TXT_DISC.TextChanged

    End Sub

    Private Sub TXT_CASH_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TXT_CASH.KeyPress
        e.Handled = True
    End Sub

    Private Sub TXT_CASH_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TXT_CASH.TextChanged

    End Sub

    Private Sub CMB_PRICE_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles CMB_PRICE.KeyPress
        e.Handled = True
    End Sub

    Private Sub CMB_PRICE_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CMB_PRICE.SelectedIndexChanged

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Try
            number_day___ = 0
            Dim f As New FRM_ALL_ACCOUNT
            f.ShowDialog()
            If f.IS_YES = True Then
                Dim i As Integer = f.DGV.CurrentRow.Index
                TXT_GUID_ITEME.Text = f.DGV.Rows(i).Cells(0).Value.ToString()
                TXT_ITEME.Text = f.DGV.Rows(i).Cells(1).Value.ToString()
            End If
            number_day___ = 0
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            number_day___ = 0
            Dim f As New FRM_ALL_ACCOUNT
            f.ShowDialog()
            If f.IS_YES = True Then
                Dim i As Integer = f.DGV.CurrentRow.Index
                TXT_GUID_DISC.Text = f.DGV.Rows(i).Cells(0).Value.ToString()
                TXT_DISC.Text = f.DGV.Rows(i).Cells(1).Value.ToString()
            End If
            number_day___ = 0
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Try
            number_day___ = 0
            Dim f As New FRM_ALL_ACCOUNT
            f.ShowDialog()
            If f.IS_YES = True Then
                Dim i As Integer = f.DGV.CurrentRow.Index
                TXT_GUID_CASH.Text = f.DGV.Rows(i).Cells(0).Value.ToString()
                TXT_CASH.Text = f.DGV.Rows(i).Cells(1).Value.ToString()
            End If
            number_day___ = 0
        Catch ex As Exception

        End Try
    End Sub

    Private Sub TXT_ID_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TXT_ID.TextChanged
        Try
            Dim dt As New DataTable
            dt.Clear()
            dt = ClS_TYPE_BILL_.SHOW_id(Val(TXT_ID.Text))
            If dt.Rows.Count > 0 Then
                TXT_NAME.Text = dt.Rows(0)(0).ToString()

                TXT_GUID_ITEME.Text = dt.Rows(0)(1).ToString()
                TXT_ITEME.Text = dt.Rows(0)(2).ToString()


                TXT_GUID_DISC.Text = dt.Rows(0)(3).ToString()
                TXT_DISC.Text = dt.Rows(0)(4).ToString()



                TXT_GUID_CASH.Text = dt.Rows(0)(5).ToString()
                TXT_CASH.Text = dt.Rows(0)(6).ToString()


                Dim pess_ As Integer
                pess_ = Val(dt.Rows(0)(7).ToString())
                'CMB_PRICE.Text
                If pess_ = 0 Then
                    CMB_PRICE.Text = "الجملة"
                ElseIf pess_ = 1 Then
                    CMB_PRICE.Text = "نصف الجملة"

                ElseIf pess_ = 2 Then
                    CMB_PRICE.Text = "المستهلك"
                ElseIf pess_ = 3 Then

                    CMB_PRICE.Text = "الموزع"
                ElseIf pess_ = 4 Then
                    CMB_PRICE.Text = "التصدير"

                ElseIf pess_ = 5 Then
                    CMB_PRICE.Text = "المفرق"
                ElseIf pess_ = 6 Then
                    CMB_PRICE.Text = "اخر شراء"
                End If


              



                Check_DAY.Checked = Convert.ToInt32(dt.Rows(0)(8).ToString())
                chek_STOCK.Checked = Convert.ToInt32(dt.Rows(0)(9).ToString())

            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub حفظToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles حفظToolStripMenuItem.Click
        Try
            Dim pess_ As Integer
            If CMB_PRICE.Text = "الجملة" Then
                pess_ = 0
            ElseIf CMB_PRICE.Text = "نصف الجملة" Then
                pess_ = 1
            ElseIf CMB_PRICE.Text = "المستهلك" Then
                pess_ = 2
            ElseIf CMB_PRICE.Text = "الموزع" Then
                pess_ = 3
            ElseIf CMB_PRICE.Text = "التصدير" Then
                pess_ = 4
            ElseIf CMB_PRICE.Text = "المفرق" Then
                pess_ = 5
            ElseIf CMB_PRICE.Text = "اخر شراء" Then
                pess_ = 6

            End If



            Dim Check_DAY__ As Integer
            If Check_DAY.Checked = True Then
                Check_DAY__ = 1
            Else
                Check_DAY__ = 0
            End If

            Dim chek_STOCK_ As Integer
            If chek_STOCK.Checked = True Then
                chek_STOCK_ = 1
            Else
                chek_STOCK_ = 0
            End If

            ClS_TYPE_BILL_.UPDATE_(TXT_NAME.Text,
                                   TXT_GUID_ITEME.Text,
                                   TXT_GUID_DISC.Text,
                                   TXT_GUID_CASH.Text,
                                  Val(Check_DAY__),
                                   Val(chek_STOCK_),
                                  Val(pess_),
                                  Val(TXT_ID.Text))

            MessageBox.Show("   تمت عملية  الحفظ بنجاح ", "تاكيد", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub
End Class