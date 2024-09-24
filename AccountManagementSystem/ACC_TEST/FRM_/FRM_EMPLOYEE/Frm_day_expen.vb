Public Class Frm_day_expen
    Dim CLS_EXPEN_ As New CLS_EXPEN
    Dim ClS_DAY_EXPEN_ As New ClS_DAY_EXPEN
    Dim CLS_EMPLOYEE_ As New CLS_EMPLOYEE
    Private Sub Frm_day_expen_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            InputLanguage.CurrentInputLanguage = InputLanguage.InstalledInputLanguages(1)
            MAX_ID_DAY()
            'NAME_EXPEN()
            NAME_student()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
 
    Sub NAME_student()
        Dim DT As New DataTable
        DT = CLS_EMPLOYEE_.SHOW_CMB()
        cmb_student.DataSource = DT
        cmb_student.DisplayMember = "NAME"
        cmb_student.ValueMember = "ID"
    End Sub
    Sub MAX_ID_DAY()
        Dim DT As New DataTable
        DT = ClS_DAY_EXPEN_.MAX_ID_DAY(Val(TXT_TYPE.Text))
        TXT_iD_DAY.Text = DT.Rows(0).Item(0).ToString()
    End Sub
    'Sub NAME_EXPEN()
    '    Dim DT As New DataTable
    '    DT = CLS_EXPEN_.SHOW_CMB(Val(TXT_TYPE.Text))
    '    CMB_EXPEN.DataSource = DT
    '    CMB_EXPEN.DisplayMember = "NAME"
    '    CMB_EXPEN.ValueMember = "ID_EXPEN"
    'End Sub

    Private Sub CMB_CATEGORY_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        e.Handled = True
    End Sub

    Private Sub CMB_CATEGORY_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub TXT_COD_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TXT_MONEY.KeyPress
        If (e.KeyChar >= "a" And e.KeyChar <= "z") Or (e.KeyChar >= "A" And e.KeyChar <= "Z") Or (e.KeyChar >= "ا" And e.KeyChar <= "ي") Then
            e.Handled = True
        End If
    End Sub

    Private Sub TXT_COD_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TXT_MONEY.TextChanged

    End Sub

    Private Sub Tool_SAVE_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_SAVE.Click
        Try
            Dim dt2 As New DataTable
            dt2.Clear()
            dt2 = ClS_DAY_EXPEN_.SHOW_id(Val(TXT_iD_DAY.Text), Val(TXT_TYPE.Text))
            If dt2.Rows.Count <> 0 Then
                MessageBox.Show("يجب ضغط جديد اولا", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End If


            If TXT_MONEY.Text = "" Or Val(TXT_MONEY.Text) = 0 Then
                MessageBox.Show("المبلغ فارغ", "تاكيد", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End If

            ADD_DAY()
            MessageBox.Show("تمت عملية الحفظ بنجاح", "تاكيد", MessageBoxButtons.OK, MessageBoxIcon.Information)


            CLEARE()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
    Sub ADD_DAY()
        ClS_DAY_EXPEN_.ADD_DAY(DTP1.Value.ToShortDateString(), cmb_student.SelectedValue, Val(TXT_MONEY.Text), TXT_NOTE.Text, Val(TXT_TYPE.Text), Val(TXT_iD_DAY.Text))
    End Sub
    Sub UPDATEEE()
        ClS_DAY_EXPEN_.UPDATE_DAY(DTP1.Value.ToShortDateString(), cmb_student.SelectedValue, Val(TXT_MONEY.Text), TXT_NOTE.Text, Val(TXT_TYPE.Text), Val(TXT_iD_DAY.Text))
    End Sub
    Sub CLEARE()
        MAX_ID_DAY()
        TXT_MONEY.Text = 0
        TXT_NOTE.Text = ""

    End Sub

    Private Sub Tool_UPDATE_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_UPDATE.Click
        Try

            If TXT_MONEY.Text = "" Or Val(TXT_MONEY.Text) = 0 Then
                MessageBox.Show("المبلغ فارغ", "تاكيد", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End If

            Dim dt2 As New DataTable
            dt2.Clear()
            dt2 = ClS_DAY_EXPEN_.SHOW_id(Val(TXT_iD_DAY.Text), Val(TXT_TYPE.Text))
            If dt2.Rows.Count > 0 Then


                If (MessageBox.Show("هل متاكد من  التعديل", "تنبيه", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes) Then
                    UPDATEEE()
                    MessageBox.Show("تمت عملية التعديل بنجاح", "تاكيد", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If

            Else
                MessageBox.Show("يجب ضغط جديد اولا", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End If




        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
    Sub DELETE_DAY()
        ClS_DAY_EXPEN_.DELETE_DAY(Val(TXT_iD_DAY.Text), Val(TXT_TYPE.Text))
    End Sub

    Private Sub Tool_DELETE_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_DELETE.Click
        Try
            If TXT_MONEY.Text = "" Then
                MessageBox.Show("المبلغ فارغ", "تاكيد", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End If
            If (MessageBox.Show("هل متاكد من  الحذف", "تنبيه", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes) Then
                DELETE_DAY()
                MessageBox.Show("تمت عملية الحذف بنجاح", "تاكيد", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub TXT_iD_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TXT_iD_DAY.TextChanged
        Try
            Dim DT As New DataTable
            DT.Clear()


            DT = ClS_DAY_EXPEN_.SHOW_DAY(Val(TXT_iD_DAY.Text), Val(TXT_TYPE.Text))
            If DT.Rows.Count > 0 Then
                DTP1.Value = DT.Rows(0)(0).ToString()
                cmb_student.SelectedValue = Convert.ToString(DT.Rows(0)(1).ToString())
                TXT_MONEY.Text = Val(DT.Rows(0)(2).ToString())
                TXT_NOTE.Text = DT.Rows(0)(3).ToString()
            Else
                TXT_MONEY.Text = 0
                TXT_NOTE.Text = ""
            End If

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub LBL_END_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LBL_END.Click
        Try
            MAX_ID_DAY()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub LB_NEXT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LB_NEXT.Click
        Try

            Dim DT As New DataTable
            DT = ClS_DAY_EXPEN_.MAX_ID_DAY(Val(TXT_TYPE.Text))
            Dim TXTMAX As Integer
            TXTMAX = DT.Rows(0).Item(0).ToString()
            If Val(TXTMAX) = Val(TXT_iD_DAY.Text) Then
                MessageBox.Show("تنبيه هذا اكبر رقم", "تاكيد", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            Else
                TXT_iD_DAY.Text = Val(TXT_iD_DAY.Text) + 1
            End If


        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub LB_LAST_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LB_LAST.Click
        Try

            Dim DT As New DataTable
            DT = ClS_DAY_EXPEN_.MIN_ID(Val(TXT_TYPE.Text))
            Dim TXTMIN As Integer
            TXTMIN = DT.Rows(0).Item(0).ToString()
            If Val(TXTMIN) = Val(TXT_iD_DAY.Text) Then
                MessageBox.Show("تنبيه هذا اصغر رقم", "تاكيد", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            Else
                TXT_iD_DAY.Text = Val(TXT_iD_DAY.Text) - 1
            End If
            If Val(TXT_iD_DAY.Text) < 1 Then
                TXT_iD_DAY.Text = 1
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub LB_FIRST_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LB_FIRST.Click
        Try

            Dim DT As New DataTable
            DT = ClS_DAY_EXPEN_.MIN_ID(Val(TXT_TYPE.Text))

            TXT_iD_DAY.Text = DT.Rows(0).Item(0).ToString()


        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub Tool_NEW_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_NEW.Click
        Try
            CLEARE()
        Catch ex As Exception
            MsgBox(ex.ToString())
        End Try
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            InputLanguage.CurrentInputLanguage = InputLanguage.InstalledInputLanguages(1)
            Dim f As New FRM_ALL_EMPLOYEE
            f.ShowDialog()
            If f.isok = True Then
                Dim I As Integer = f.DGV.CurrentRow.Index
                cmb_student.Text = f.DGV.Rows(I).Cells(2).Value.ToString()
            End If
        Catch ex As Exception

        End Try
    End Sub
End Class