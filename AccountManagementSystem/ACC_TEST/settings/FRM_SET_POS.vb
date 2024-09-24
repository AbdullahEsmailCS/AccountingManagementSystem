Public Class FRM_SET_POS
    Dim CLS_STORE_ As New CLS_STORE
    Dim CLS_ITEME_ As New CLS_ITEME
    Dim CLS_ACCOUNT_ As New CLS_ACCOUNT
    Dim CLS_BILL_ As New CLS_BILL
    Dim CLS_DAY_ As New CLS_DAY
    Dim id_day As Integer = 0
    Dim CLS_CURRENCY_ As New CLS_CURRENCY
    Dim CLS_JOB_ As New CLS_JOB

    Dim ClS_TYPE_BILL_ As New ClS_TYPE_BILL
    Dim day_iteme As String
    Dim day_dis As String
    Dim day_cash As String
    Dim is_day As Integer
    Dim CLS_CU_VEN_ As New CLS_CU_VEN

    Dim CLS_SET_POS_ As New CLS_SET_POS
    Dim column_index As Integer = 0
    Private Sub FRM_SET_POS_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try

        
            SHOW_JOB()
            SHOW_CURRENCY()
            SHOW_store()
            MAX_1()
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub
    
    Sub MAX_1()
        Dim DT As New DataTable
        DT.Clear()
        DT = CLS_SET_POS_.MAX_1()
        If DT.Rows.Count > 0 Then
            TXT_ID.Text = DT.Rows(0)(0).ToString()
        End If
    End Sub
    Sub SHOW_JOB()
        Dim DT As New DataTable
        DT.Clear()
        DT = CLS_JOB_.SELECT_
        If DT.Rows.Count > 0 Then
            TXT_JOB.Text = DT.Rows(0)(1).ToString()
            TXT_GUID_JOB.Text = DT.Rows(0)(2).ToString()
        End If
    End Sub
    Sub SHOW_store()
        Dim DT As New DataTable
        DT.Clear()
        DT = CLS_STORE_.SELECT_
        If DT.Rows.Count > 0 Then
            TXT_STORE.Text = DT.Rows(0)(1).ToString()
            TXT_GUID_STORE.Text = DT.Rows(0)(2).ToString()
        End If
    End Sub
    Sub SHOW_CURRENCY()
        Dim DT As New DataTable
        DT.Clear()
        DT = CLS_CURRENCY_.SELECT_
        If DT.Rows.Count > 0 Then
            TXT_GUID_CURRENCY.Text = DT.Rows(0)(0).ToString()
            TXT_CURRENCY.Text = DT.Rows(0)(1).ToString()
            TXT_CURRENCY_VAL.Text = DT.Rows(0)(2).ToString()

        End If
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Try
            Dim f As New FRM_ALL_CUS_VEN
            f.ShowDialog()
            If f.isok = True Then
                Dim I As Integer = f.DGV.CurrentRow.Index

                TXT_GUID_CUSTOMER.Text = f.DGV.Rows(I).Cells(13).Value.ToString()
                TXT_NAME_CUSTOMET.Text = f.DGV.Rows(I).Cells(2).Value.ToString()
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Try
            Dim F As New FRM_ALL_STORE
            F.ShowDialog()
            If F.IS_YES = True Then
                Dim I As Integer = F.DGV.CurrentRow.Index
                TXT_GUID_STORE.Text = F.DGV.Rows(I).Cells(2).Value.ToString()
                TXT_STORE.Text = F.DGV.Rows(I).Cells(1).Value.ToString()
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Try
            Dim F As New FRM_ALL_CURRENCY
            F.ShowDialog()
            If F.IS_YES = True Then
                Dim I As Integer = F.DGV.CurrentRow.Index
                TXT_GUID_CURRENCY.Text = F.DGV.Rows(I).Cells(0).Value.ToString()
                TXT_CURRENCY.Text = F.DGV.Rows(I).Cells(2).Value.ToString()
                TXT_CURRENCY_VAL.Text = Val(F.DGV.Rows(I).Cells(4).Value.ToString()).ToString("0.00")

            End If

        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Try
            Dim F As New FRM_ALL_HOB
            F.ShowDialog()
            If F.IS_YES = True Then
                Dim I As Integer = F.DGV.CurrentRow.Index
                TXT_JOB.Text = F.DGV.Rows(I).Cells(1).Value.ToString()
                TXT_GUID_JOB.Text = F.DGV.Rows(I).Cells(2).Value.ToString()

            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            Dim f As New FRM_ALL_USER
            f.ShowDialog()
            If f.isok = True Then
                Dim I As Integer = f.DGV.CurrentRow.Index

                TXT_GUID_USER.Text = f.DGV.Rows(I).Cells(0).Value.ToString()
                TXT_NAME_USER.Text = f.DGV.Rows(I).Cells(1).Value.ToString()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        Try
            MAX_()
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub
    Sub MAX_()
        Dim DT As New DataTable
        DT.Clear()
        DT = CLS_SET_POS_.MAX_()
        If DT.Rows.Count > 0 Then
            TXT_ID.Text = DT.Rows(0)(0).ToString()
        End If
    End Sub

    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click
        Try
            Dim max___ As Double = 0
            Dim DT As New DataTable
            DT.Clear()
            DT = CLS_SET_POS_.MAX_()
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
            DT = CLS_SET_POS_.MIN_()
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
        DT = CLS_SET_POS_.MIN_()
        If DT.Rows.Count > 0 Then
            TXT_ID.Text = DT.Rows(0)(0).ToString()
        End If
    End Sub

    Private Sub حفظToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles حفظToolStripMenuItem.Click
        Try


            If TXT_GUID_USER.Text = Nothing Then
                MessageBox.Show(" لايوجد اسم  ", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
            '---------------------------------------------------------------------
            If TXT_GUID_CUSTOMER.Text = Nothing Then
                MessageBox.Show(" لايوجد   اسم الزبون", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
            '---------------------------------------------------------------------
          
            Dim DT As New DataTable
            DT.Clear()
            DT = CLS_SET_POS_.SEARSH_NAME(TXT_GUID_USER.Text)
            If DT.Rows.Count > 0 Then
                MessageBox.Show(" اسم  موجود من قبل ", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
            '---------------------------------------------------------------------
            Dim typ__ As Integer
            'If typ__ = 0 Then
            If Check_ITEME.Checked = False Then
                typ__ = 0
            Else
                typ__ = 1
            End If
            '---------------------------------------------------------------------
            CLS_SET_POS_.add_(TXT_GUID_USER.Text,
                              TXT_GUID_CUSTOMER.Text,
                              TXT_GUID_STORE.Text,
                              TXT_GUID_CURRENCY.Text,
                              Val(TXT_CURRENCY_VAL.Text),
                              TXT_GUID_JOB.Text,
                              Val(typ__))
            MessageBox.Show("   تمت عملية  الحفظ بنجاح ", "تاكيد", MessageBoxButtons.OK, MessageBoxIcon.Information)


        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub TXT_ID_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TXT_ID.TextChanged
        Try
            Dim dt As New DataTable
            dt.Clear()
            dt = CLS_SET_POS_.SEARSH_id(Val(TXT_ID.Text))
            If dt.Rows.Count > 0 Then
                TXT_GUID_USER.Text = dt.Rows(0)(0).ToString()
                TXT_NAME_USER.Text = dt.Rows(0)(1).ToString()
                TXT_GUID_CUSTOMER.Text = dt.Rows(0)(2).ToString()
                TXT_NAME_CUSTOMET.Text = dt.Rows(0)(3).ToString()

                TXT_GUID_STORE.Text = dt.Rows(0)(4).ToString()
                TXT_STORE.Text = dt.Rows(0)(5).ToString()

                TXT_GUID_CURRENCY.Text = dt.Rows(0)(6).ToString()
                TXT_CURRENCY.Text = dt.Rows(0)(7).ToString()


                TXT_CURRENCY_VAL.Text = dt.Rows(0)(8).ToString()

                TXT_GUID_JOB.Text = dt.Rows(0)(9).ToString()
                TXT_JOB.Text = dt.Rows(0)(10).ToString()

                Dim typ__ As Integer = Val(dt.Rows(0)(11).ToString())
                If typ__ = 0 Then
                    Check_ITEME.Checked = False
                Else
                    Check_ITEME.Checked = True
            End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub تعديلToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles تعديلToolStripMenuItem.Click
        Try


            If TXT_GUID_USER.Text = Nothing Then
                MessageBox.Show(" لايوجد اسم  ", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
            '---------------------------------------------------------------------
            If TXT_GUID_CUSTOMER.Text = Nothing Then
                MessageBox.Show(" لايوجد   اسم الزبون", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
            '---------------------------------------------------------------------
            Dim dt As New DataTable
            dt.Clear()
            dt = CLS_SET_POS_.SEARSH_id(Val(TXT_ID.Text))
            If dt.Rows.Count > 0 Then
            Else
                MessageBox.Show(" يجب اضافة اولا ", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
           
            '---------------------------------------------------------------------
            Dim typ__ As Integer

            If Check_ITEME.Checked = False Then
                typ__ = 0
            Else
                typ__ = 1
            End If
            '---------------------------------------------------------------------
            CLS_SET_POS_.update_(TXT_GUID_USER.Text,
                              TXT_GUID_CUSTOMER.Text,
                              TXT_GUID_STORE.Text,
                              TXT_GUID_CURRENCY.Text,
                              Val(TXT_CURRENCY_VAL.Text),
                              TXT_GUID_JOB.Text,
                              Val(typ__),
                              Val(TXT_ID.Text))

            MessageBox.Show("   تمت عملية  التعديل بنجاح ", "تاكيد", MessageBoxButtons.OK, MessageBoxIcon.Information)


        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub جديدToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles جديدToolStripMenuItem.Click
        Try
            MAX_1()
        Catch ex As Exception

        End Try
    End Sub
End Class