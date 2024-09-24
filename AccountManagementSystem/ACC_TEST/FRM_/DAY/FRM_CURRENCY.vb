Public Class FRM_CURRENCY
    Dim CLS_CURRENCY_ As New CLS_CURRENCY
    Private Sub FRM_CURRENCY_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try

            MAX_1()
            

         
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub
    Sub MAX_1()
        Dim DT As New DataTable
        DT.Clear()
        DT = CLS_CURRENCY_.MAX_1()
        If DT.Rows.Count > 0 Then
            TXT_ID.Text = DT.Rows(0)(0).ToString()
        End If
    End Sub
    Sub MAX_()
        Dim DT As New DataTable
        DT.Clear()
        DT = CLS_CURRENCY_.MAX_()
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
            DT = CLS_CURRENCY_.MAX_()
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
            DT = CLS_CURRENCY_.MIN_()
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
        DT = CLS_CURRENCY_.MIN_()
        If DT.Rows.Count > 0 Then
            TXT_ID.Text = DT.Rows(0)(0).ToString()
        End If
    End Sub

    Private Sub جديدToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles جديدToolStripMenuItem.Click
        Try
            MAX_1()

            TXT_NAME.Text = Nothing
            TXT_PART.Text = Nothing
            TXT_VAL.Text = Nothing

           
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub TXT_ID_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TXT_ID.TextChanged
        Try


            SHOW_CUREENCY()
            If Val(TXT_ID.Text) = 1 Then
                TXT_VAL.Enabled = False
            Else
                TXT_VAL.Enabled = True
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub
    Sub SHOW_CUREENCY()
        Dim DT As New DataTable
        DT.Clear()
        DT = CLS_CURRENCY_.show_(Val(TXT_ID.Text))
        If DT.Rows.Count > 0 Then
            TXT_NAME.Text = DT.Rows(0)(0).ToString()
            TXT_PART.Text = DT.Rows(0)(1).ToString()
            TXT_VAL.Text = Val(DT.Rows(0)(2).ToString()).ToString("0.000")
        Else
            TXT_NAME.Text = Nothing
            TXT_PART.Text = Nothing
            TXT_VAL.Text = Nothing
        End If
    End Sub

    Private Sub حفظToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles حفظToolStripMenuItem.Click
        Try
          

            If TXT_NAME.Text = Nothing Then
                MessageBox.Show(" لايوجد اسم للعملة", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
            '---------------------------------------------------------------------
            If TXT_PART.Text = Nothing Then
                MessageBox.Show(" لايوجد جزء للعملة", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
            '---------------------------------------------------------------------
            If TXT_VAL.Text = Nothing Or TXT_VAL.Text = "0" Then
                MessageBox.Show(" لايوجد سعر للعملة", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
            If TXT_VAL.Text = "0" Then
                MessageBox.Show("   لايجب ان يكون سعر التعادل 0", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
            'If Val(TXT_VAL.Text) < 0 Then
            '    MessageBox.Show("   لايجب ان يكون سعر التعادل 0", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error)
            '    Exit Sub
            'End If
            '---------------------------------------------------------------------
            Dim DT As New DataTable
            DT.Clear()
            DT = CLS_CURRENCY_.SEARSH_NAME(TXT_NAME.Text)
            If DT.Rows.Count > 0 Then
                MessageBox.Show(" اسم العملة موجود من قبل ", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
            '---------------------------------------------------------------------
            CLS_CURRENCY_.add_(TXT_NAME.Text, TXT_PART.Text, Val(TXT_VAL.Text), guid_user_log)


            MessageBox.Show("   تمت عملية  الحفظ بنجاح ", "تاكيد", MessageBoxButtons.OK, MessageBoxIcon.Information)


        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub تعديلToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles تعديلToolStripMenuItem.Click
        Try
            If TXT_NAME.Text = Nothing Then
                MessageBox.Show(" لايوجد اسم للعملة", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
            '---------------------------------------------------------------------
            If TXT_PART.Text = Nothing Then
                MessageBox.Show(" لايوجد جزء للعملة", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
            '---------------------------------------------------------------------
            If TXT_VAL.Text = Nothing Or TXT_VAL.Text = "0" Then
                MessageBox.Show(" لايوجد سعر للعملة", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
            If TXT_VAL.Text = "0" Then
                MessageBox.Show("   لايجب ان يكون سعر التعادل 0", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If

            CLS_CURRENCY_.UPDATE_(TXT_NAME.Text, TXT_PART.Text, Val(TXT_VAL.Text), Val(TXT_ID.Text), guid_user_log)

            MessageBox.Show("   تمت عملية  التعديل بنجاح ", "تاكيد", MessageBoxButtons.OK, MessageBoxIcon.Information)


        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub
End Class