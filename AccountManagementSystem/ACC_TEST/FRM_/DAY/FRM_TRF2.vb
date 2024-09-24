Imports System.IO
Public Class FRM_TRF2

    Dim CLS_CU_VEN_ As New CLS_CU_VEN
    
    Dim CLS_ACCOUNT_ As New CLS_ACCOUNT
    Dim CLS_PERSONAL_ As New CLS_PERSONAL


    Dim CLS_JOBE_MPLOYEE_ As New CLS_JOBE_MPLOYEE
    Dim CLS_LEARNING_ As New CLS_LEARNING
    Dim CLS_EMPLOYEE_LEARNING_ As New CLS_EMPLOYEE_LEARNING
 

    Dim CLS_END_ As New ClS_END
    Dim DT_node As New DataTable

    Dim CLS_DAY_ As New CLS_DAY
    Dim CLS_BILL_ As New CLS_BILL
    Dim CLS_CASH_DAY_ As New CLS_CASH_DAY



  

    Private Sub ComboBox1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles ComboBox1.KeyPress
        e.Handled = True
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        If ComboBox1.Text = "زبون" Then
            TXT_GUID_PARENT.Text = "e89a8e3f-6440-42c3-95ec-f51204349053"
        Else
            TXT_GUID_PARENT.Text = "E0E70C50-BE10-4630-B27A-AC0DA144415D"
        End If

        Try

















            Dim DT As New DataTable
            DT.Clear()
            DT = CLS_PERSONAL_.SHOW_()
            If DT.Rows.Count > 0 Then
                If ComboBox1.Text = "زبون" Then
                    TXT_GUID_PARENT.Text = DT.Rows(0)(0).ToString()
                Else
                    TXT_GUID_PARENT.Text = DT.Rows(0)(1).ToString()
                End If

            End If
        Catch ex As Exception

        End Try
    End Sub

   
 
    Private Sub MAX_ID()
        Dim DT As New DataTable
        DT = CLS_CU_VEN_.MAX_ID()
        TXT_iD.Text = DT.Rows(0).Item(0).ToString()
    End Sub
    Private Sub Tool_NEW_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_NEW.Click
        Try
            CLEARE()
            MAX_ID()

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
    Sub CLEARE()

        TXT_NAME.Text = ""
        TXT_LAST_NAME.Text = ""
        TXT_NAME_COMPANY.Text = ""


        TXT_JOB_COMPAN.Text = ""
       
        TXT_PHONE.Text = ""

        TXT_MOBILE_1.Text = ""
        TXT_MOBILE_2.Text = ""
        TXT_MAIL.Text = ""
        TXT_WEB.Text = ""

        pic.Image = PIC_NEW.Image
    End Sub

    Private Sub Tool_SAVE_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_SAVE.Click
        Try





            Dim dt As New DataTable
            dt.Clear()
            dt = CLS_CU_VEN_.SHOW_NAME(TXT_NAME.Text)


            If dt.Rows.Count <> 0 Then
                MessageBox.Show("الاسم موجود من قبل", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End If


            If TXT_NAME.Text = Nothing Then
                MessageBox.Show("اسم  غير موجود", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End If
            '================================================================

            Dim msn As New MemoryStream
            pic.Image.Save(msn, pic.Image.RawFormat)
            Dim bytimage As Byte() = msn.ToArray()

            '================================================================
            ADD_ACC00()
            '================================================================
            CLS_CU_VEN_.ADD_CUSTOMER(DTP.Value,
                                      TXT_NAME.Text,
                                      TXT_LAST_NAME.Text,
                                      TXT_NAME_COMPANY.Text,
                                      TXT_JOB_COMPAN.Text,
                                      TXT_CUNTRY.Text,
                                      TXT_STREET.Text,
                                      TXT_PHONE.Text,
                                      TXT_MOBILE_1.Text,
                                      TXT_MOBILE_2.Text,
                                      TXT_MAIL.Text,
                                      TXT_WEB.Text,
                                      bytimage,
                                      TXT_GUID.Text,
                                      ComboBox1.Text,
                                      Convert.ToDateTime(Now.ToShortDateString()),
                                      guid_user_log)



            MessageBox.Show("تمت عملية الحفظ بنجاح", "تاكيد", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
    Private Sub ADD_ACC00()
        Dim COD__ As Double
        Dim DT_COD As New DataTable
        DT_COD.Clear()
        DT_COD = CLS_ACCOUNT_.COD_(TXT_GUID_PARENT.Text)
        If DT_COD.Rows.Count > 0 Then

            COD__ = Val(DT_COD.Rows(0)(0).ToString())
        End If
        If COD__ = "0" Then
            If ComboBox1.Text = "زبون" Then
                COD__ = 161001
            Else
                COD__ = 251001
            End If

        End If
        '----------------------------------------------------
        CLS_ACCOUNT_.ADD_(TXT_NAME.Text, TXT_GUID_PARENT.Text, Val(COD__), 1, 0, 0, 0, guid_user_log)
        '----------------------------------------------------
        'Dim count__ As Integer = 0
        'Dim dt As New DataTable
        'dt.Clear()
        'dt = CLS_ACCOUNT_.count_NSons(TXT_GUID_PARENT.Text)
        'If dt.Rows.Count > 0 Then
        '    count__ = Val(dt.Rows(0)(0).ToString())
        'Else
        '    count__ = 1
        'End If

        'CLS_ACCOUNT_.UPDATE_NSons(Val(count__), TXT_GUID_PARENT.Text)

        '----------------------------------------------------
        Dim DT4 As New DataTable
        DT4.Clear()
        DT4 = CLS_ACCOUNT_.GUID_EMPLOYEE(TXT_NAME.Text)

        If DT4.Rows.Count > 0 Then
            TXT_GUID.Text = DT4.Rows(0)(0).ToString()

        End If

    End Sub

    Private Sub Tool_UPDATE_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_UPDATE.Click
        Try
            If TXT_NAME.Text = Nothing Then
                MessageBox.Show("اسم  غير موجود", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End If
            '================================================================
            Dim dt As New DataTable
            dt.Clear()
            dt = CLS_CU_VEN_.SHOW_CUSTOMER_ID(Val(TXT_iD.Text))
            If dt.Rows.Count < 0 Then
                MessageBox.Show("اسم  غير موجود", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End If
            '================================================================

            Dim msn As New MemoryStream
            pic.Image.Save(msn, pic.Image.RawFormat)
            Dim bytimage As Byte() = msn.ToArray()


            '================================================================

0:
            CLS_CU_VEN_.UPDATE_CUSTOMER(DTP.Value,
                                         TXT_NAME.Text,
                                         TXT_LAST_NAME.Text,
                                         TXT_NAME_COMPANY.Text,
                                         TXT_JOB_COMPAN.Text,
                                         TXT_CUNTRY.Text,
                                         TXT_STREET.Text,
                                         TXT_PHONE.Text,
                                         TXT_MOBILE_1.Text,
                                         TXT_MOBILE_2.Text,
                                         TXT_MAIL.Text,
                                         TXT_WEB.Text,
                                         bytimage,
                                      Val(TXT_iD.Text),
                                      guid_user_log)

            MessageBox.Show("تمت عملية التعديل بنجاح", "تاكيد", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        Try
            Dim f As New FRM_ALL_CUS_VEN
            f.ShowDialog()
            If f.isok = True Then
                Dim I As Integer = f.DGV.CurrentRow.Index
                TXT_iD.Text = f.DGV.Rows(I).Cells(0).Value.ToString()
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub LBL_END_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LBL_END.Click
        Try
            MAX_ID()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub LB_NEXT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LB_NEXT.Click
        Try

            Dim DT As New DataTable
            DT = CLS_CU_VEN_.MAX_ID()
            Dim TXTMAX As Integer
            TXTMAX = DT.Rows(0).Item(0).ToString()
            If Val(TXTMAX) = Val(TXT_iD.Text) Then
                MessageBox.Show("تنبيه هذا اكبر رقم", "تاكيد", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            Else
                TXT_iD.Text = Val(TXT_iD.Text) + 1
            End If


        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub LB_LAST_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LB_LAST.Click
        Try

            Dim DT As New DataTable
            DT = CLS_CU_VEN_.MIN_ID()
            Dim TXTMIN As Integer
            TXTMIN = DT.Rows(0).Item(0).ToString()
            If Val(TXTMIN) = Val(TXT_iD.Text) Then
                MessageBox.Show("تنبيه هذا اصغر رقم", "تاكيد", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            Else
                TXT_iD.Text = Val(TXT_iD.Text) - 1
            End If

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub LB_FIRST_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LB_FIRST.Click
        Try

            Dim DT As New DataTable
            DT = CLS_CU_VEN_.MIN_ID()

            TXT_iD.Text = DT.Rows(0).Item(0).ToString()


        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub pic_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pic.Click
        Dim ofd As New OpenFileDialog
        ofd.Filter = "اختر صورة|*.jpg;*.png;*.gig;"
        If ofd.ShowDialog = Windows.Forms.DialogResult.OK Then
            pic.Image = Image.FromFile(ofd.FileName)
        End If
    End Sub

    Private Sub TXT_iD_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TXT_iD.TextChanged
        Try
            show_employee()

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
    Sub show_employee()
        Dim dt As New DataTable
        dt.Clear()
        dt = CLS_CU_VEN_.SHOW_CUSTOMER_ID(Val(TXT_iD.Text))
        If dt.Rows.Count <> 0 Then
            TXT_GUID_ACCOUNT.Text = dt.Rows(0)(14).ToString()


            DTP.Value = dt.Rows(0)(0).ToString()
            TXT_NAME.Text = dt.Rows(0).Item(1).ToString()
            TXT_LAST_NAME.Text = dt.Rows(0).Item(2).ToString()
            TXT_NAME_COMPANY.Text = dt.Rows(0).Item(3).ToString()
            TXT_JOB_COMPAN.Text = dt.Rows(0).Item(4).ToString()

            TXT_CUNTRY.Text = dt.Rows(0).Item(5).ToString()
            TXT_STREET.Text = dt.Rows(0).Item(6).ToString()
            TXT_PHONE.Text = dt.Rows(0).Item(7).ToString()
            TXT_MOBILE_1.Text = dt.Rows(0).Item(8).ToString()
            TXT_MOBILE_2.Text = dt.Rows(0).Item(9).ToString()


            TXT_MAIL.Text = dt.Rows(0).Item(10).ToString()
            TXT_WEB.Text = dt.Rows(0).Item(11).ToString()

            Dim imgByteArray() As Byte
            imgByteArray = dt.Rows(0).Item(12)
            Dim Stream As New MemoryStream(imgByteArray, True)
            Dim Img As System.Drawing.Image = New Bitmap(Stream)
            pic.Image = Img

            ComboBox1.Text = dt.Rows(0).Item(13).ToString()
        Else
            TXT_NAME.Text = Nothing
            TXT_LAST_NAME.Text = Nothing
            TXT_NAME_COMPANY.Text = Nothing
            TXT_JOB_COMPAN.Text = Nothing
            TXT_CUNTRY.Text = Nothing
            TXT_STREET.Text = Nothing
            TXT_PHONE.Text = Nothing
            TXT_MOBILE_1.Text = Nothing
            TXT_MOBILE_2.Text = Nothing
            TXT_MAIL.Text = Nothing
            TXT_WEB.Text = Nothing
            pic.Image = PIC_NEW.Image
            TXT_GUID_ACCOUNT.Text = Nothing
          

        End If
    End Sub

    Private Sub FRM_TRF2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try

            InputLanguage.CurrentInputLanguage = InputLanguage.InstalledInputLanguages(1)
            MAX_ID()

            TXT_NAME.Focus()
            If number_day___ = 2 Then
                TXT_NAME.Text = name___name
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub Tool_DELETE_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_DELETE.Click
        Try
            If TXT_GUID_ACCOUNT.Text = Nothing Then
                MessageBox.Show("اسم موظف غير موجود", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End If
            '================================================================

            Dim dt As New DataTable
            dt.Clear()
            dt = CLS_DAY_.delete_account(TXT_GUID_ACCOUNT.Text)
            If dt.Rows.Count > 0 Then
                MessageBox.Show("الحساب موجود بسند القيد", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                Exit Sub
            End If
            '-----------------------------------------------------------------------
            Dim dt_cash As New DataTable
            dt_cash.Clear()
            dt_cash = CLS_CASH_DAY_.delete_account(TXT_GUID_ACCOUNT.Text)
            If dt_cash.Rows.Count > 0 Then
                MessageBox.Show("الحساب موجود بسندات القبض والصرف ", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                Exit Sub
            End If


            '-----------------------------------------------------------------------
            Dim dt_acc As New DataTable
            dt_acc.Clear()
            dt_acc = CLS_ACCOUNT_.delete_account(TXT_GUID_ACCOUNT.Text)
            If dt_acc.Rows.Count > 0 Then
                MessageBox.Show("لايمكن حذف الحساب الرئيسي", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                Exit Sub
            End If
            '-----------------------------------------------------------------------
            Dim dt_bill As New DataTable
            dt_bill.Clear()
            dt_bill = CLS_BILL_.delete_account(TXT_GUID_ACCOUNT.Text)
            If dt_bill.Rows.Count > 0 Then
                MessageBox.Show("لايمكن حذف الحساب لانه موجود بالفواتير غير مرحلة", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                Exit Sub
            End If



            '---------------------------------------------------------------------
            If MessageBox.Show("هل انت متاكد من عملية الحذف", "تنبيه", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = Windows.Forms.DialogResult.Yes Then

                CLS_CU_VEN_.delete_(Val(TXT_iD.Text))
                CLS_ACCOUNT_.delete_(TXT_GUID_ACCOUNT.Text)

                MessageBox.Show("   تمت عملية الحذف   بنجاح ", "تاكيد", MessageBoxButtons.OK, MessageBoxIcon.Information)


            End If



        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try

    End Sub
End Class