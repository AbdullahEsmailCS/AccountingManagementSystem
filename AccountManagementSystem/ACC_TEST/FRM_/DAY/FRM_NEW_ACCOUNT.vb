Public Class FRM_NEW_ACCOUNT
    Dim CLS_ACCOUNT_ As New CLS_ACCOUNT
    Dim CLS_END_ As New ClS_END
    Private Sub FRM_NEW_ACCOUNT_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        'Try
        '    If number_day___ = 0 Then
        '      cmb_()


        '    End If

        'Catch ex As Exception
        '    MessageBox.Show(ex.ToString)
        'End Try
    End Sub
    Sub cmb_()
        Dim dt As New DataTable
        dt.Clear()
        dt = CLS_END_.SHOW_
        CMB_END.DataSource = dt
        CMB_END.ValueMember = "id"
        CMB_END.DisplayMember = "name"
    End Sub

    Private Sub ButtonX4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX4.Click
        Try
            number_day___ = 1
            Dim F As New FRM_ALL_ACCOUNT
            F.ShowDialog()
            If F.IS_YES = True Then
                Dim I As Integer = F.DGV.CurrentRow.Index
                TXT_GUID_PARENT.Text = F.DGV.Rows(I).Cells(0).Value.ToString()
                TXT_PARENT.Text = F.DGV.Rows(I).Cells(1).Value.ToString()
                TXT_CODE_PARENT_GUID.Text = F.DGV.Rows(I).Cells(3).Value.ToString()
                CMB_END.SelectedValue = Convert.ToString(F.DGV.Rows(I).Cells(4).Value.ToString())
            End If
            number_day___ = 0
        Catch ex As Exception

        End Try
    End Sub

    Private Sub حفظToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles حفظToolStripMenuItem.Click
        Try
            If TXT_NAME.Text = Nothing Then
                MessageBox.Show("يجب ادخال اسم الحساب", "نقص", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
            '------------------------------------------------------------
            If TXT_GUID_PARENT.Text = Nothing Then
                MessageBox.Show("يجب ادخال الحساب الرئيسي", "نقص", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
            '------------------------------------------------------------

            Dim dt_ As New DataTable
            dt_.Clear()
            dt_ = CLS_ACCOUNT_.searsh_account_day2(TXT_GUID_PARENT.Text)
            If dt_.Rows.Count > 0 Then
                MessageBox.Show("الحساب الرئيسي مدخل من قبل في السندات او الفواتير لايمكن اضافته حساب رئيسي", "نقص", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
            '------------------------------------------------------------
            Dim DT As New DataTable
            DT.Clear()
            DT = CLS_ACCOUNT_.SEARSH_NAME(TXT_NAME.Text)
            If DT.Rows.Count > 0 Then
                MessageBox.Show("الاسم موجود من قبل", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
            '------------------------------------------------------------
            Dim COD__ As Double

            Dim DT_COD As New DataTable
            DT_COD.Clear()
            DT_COD = CLS_ACCOUNT_.COD_(TXT_GUID_PARENT.Text)
            If DT_COD.Rows.Count > 0 Then

                COD__ = Val(DT_COD.Rows(0)(0).ToString())
            End If
            If COD__ = "0" Then
                COD__ = Val(TXT_CODE_PARENT_GUID.Text) * 10000 + 1
            End If
            '------------------------------------------------------------------
            CLS_ACCOUNT_.ADD_(TXT_NAME.Text, TXT_GUID_PARENT.Text, Val(COD__), Convert.ToInt32(CMB_END.SelectedValue), 0, 0, 0, guid_user_log)
            'update_sons()
            MessageBox.Show("تمت عملية الحفظ بنجاح", "تاكيد", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub
    'Sub update_sons()
    '    Dim count__ As Integer = 0

    '    Dim dt As New DataTable
    '    dt.Clear()
    '    dt = CLS_ACCOUNT_.count_NSons(TXT_GUID_PARENT.Text)
    '    If dt.Rows.Count > 0 Then
    '        count__ = Val(dt.Rows(0)(0).ToString())
    '    Else
    '        count__ = 1
    '    End If
    '    '----------------------------------------------------
    '    CLS_ACCOUNT_.UPDATE_NSons(Val(count__), TXT_GUID_PARENT.Text)

    'End Sub

    Private Sub تعديلToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles تعديلToolStripMenuItem.Click
        Try
            If TXT_NAME.Text = Nothing Then
                MessageBox.Show("يجب ادخال اسم الحساب", "نقص", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
            '------------------------------------------------------------
            If TXT_GUID_PARENT.Text = Nothing Then
                MessageBox.Show("يجب ادخال الحساب الرئيسي", "نقص", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If

            '------------------------------------------------------------
            Dim dt_ As New DataTable
            dt_.Clear()
            dt_ = CLS_ACCOUNT_.searsh_account_day2(TXT_GUID_PARENT.Text)
            If dt_.Rows.Count > 0 Then
                MessageBox.Show("الحساب الرئيسي مدخل من قبل في السندات او الفواتير لايمكن اضافته حساب رئيسي", "نقص", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
            '------------------------------------------------------------
            CLS_ACCOUNT_.UPDATE_(TXT_NAME.Text, TXT_GUID_PARENT.Text, Convert.ToInt32(CMB_END.SelectedValue), TXT_GUID.Text, guid_user_log)
            'update_sons()
            MessageBox.Show("تمت عملية التعديل  بنجاح", "تاكيد", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Catch ex As Exception

        End Try
    End Sub

    Private Sub TXT_GUID_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TXT_GUID.TextChanged
        Try
            Dim DT As New DataTable
            DT.Clear()
            DT = CLS_ACCOUNT_.SHOW_GUID(TXT_GUID.Text)
            If DT.Rows.Count > 0 Then
                TXT_NAME.Text = DT.Rows(0)(0).ToString()
                TXT_PARENT.Text = DT.Rows(0)(2).ToString()
                TXT_GUID_PARENT.Text = DT.Rows(0)(1).ToString()
                CMB_END.SelectedValue = Convert.ToString(DT.Rows(0)(3).ToString())
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub TXT_GUID_PARENT_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TXT_GUID_PARENT.TextChanged

    End Sub

    Private Sub جديدToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles جديدToolStripMenuItem.Click

    End Sub
End Class