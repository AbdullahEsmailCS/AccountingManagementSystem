Imports System.IO
Public Class FRM_EMPLOYEE

    Dim CLS_EMPLOYEE_ As New CLS_EMPLOYEE
    Dim CLS_JOBE_MPLOYEE_ As New CLS_JOBE_MPLOYEE
    Dim CLS_LEARNING_ As New CLS_LEARNING
    Dim CLS_EMPLOYEE_LEARNING_ As New CLS_EMPLOYEE_LEARNING
    Dim CLS_ACCOUNT_ As New CLS_ACCOUNT
    Dim CLS_PERSONAL_ As New CLS_PERSONAL
     
    Dim CLS_END_ As New ClS_END
    Dim DT_node As New DataTable

    Dim CLS_DAY_ As New CLS_DAY
    Dim CLS_BILL_ As New CLS_BILL
    Dim CLS_CASH_DAY_ As New CLS_CASH_DAY


    Dim CLS_CU_VEN_ As New CLS_CU_VEN

    Private Sub LBL_END_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LBL_END.Click
        Try
            MAX_ID()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
    Private Sub MAX_ID()
        Dim DT As New DataTable
        DT = CLS_EMPLOYEE_.MAX_ID()
        TXT_iD.Text = DT.Rows(0).Item(0).ToString()
    End Sub

    Private Sub LB_NEXT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LB_NEXT.Click
        Try

            Dim DT As New DataTable
            DT = CLS_EMPLOYEE_.MAX_ID()
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
            DT = CLS_EMPLOYEE_.MIN_ID()
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
            DT = CLS_EMPLOYEE_.MIN_ID()

            TXT_iD.Text = DT.Rows(0).Item(0).ToString()


        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
    Sub PESR_()
        Dim DT As New DataTable
        DT.Clear()
        DT = CLS_PERSONAL_.SHOW_()
        If DT.Rows.Count > 0 Then
            TXT_GUID_PARENT.Text = DT.Rows(0)(3).ToString()
        End If
    End Sub
    Private Sub FRM_CUSTOMER_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            InputLanguage.CurrentInputLanguage = InputLanguage.InstalledInputLanguages(1)
            MAX_ID()

           PESR_


        NAME_sf()
        NAME_LEARNINIG()
        TXT_NAME.Focus()
        If number_day___ = 2 Then
            TXT_NAME.Text = name___name
        End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
    Sub NAME_sf()
        Dim DT As New DataTable
        DT = CLS_JOBE_MPLOYEE_.SHOW_CMB()
        CMB_job.DataSource = DT
        CMB_job.DisplayMember = "NAME_CATEGORY"
        CMB_job.ValueMember = "ID_CATEGORY"
    End Sub
    Sub NAME_LEARNINIG()
        Dim DT As New DataTable
        DT = CLS_LEARNING_.SHOW_CMB()
        CMB_EMPLOYEE_LEARNING.DataSource = DT
        CMB_EMPLOYEE_LEARNING.DisplayMember = "NAME"
        CMB_EMPLOYEE_LEARNING.ValueMember = "ID"
    End Sub
    Private Sub Tool_NEW_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_NEW.Click
        Try
            CLEARE()
            MAX_ID()
            DGV_LEARNING.Rows.Clear()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
    Sub CLEARE()

        TXT_NAME.Text = ""
        TXT_LAST_NAME.Text = ""
        TXT_NAME_COMPANY.Text = ""


        TXT_JOB_COMPAN.Text = ""
        TXT_CUNTRY.Text = ""
        TXT_STREET.Text = ""
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
            dt = CLS_EMPLOYEE_.SHOW_NAME(TXT_NAME.Text)


            If dt.Rows.Count <> 0 Then
                MessageBox.Show("الاسم موجود من قبل", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End If


            If TXT_NAME.Text = Nothing Then
                MessageBox.Show("اسم الطالب غير موجود", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End If
            '================================================================

            Dim msn As New MemoryStream
            pic.Image.Save(msn, pic.Image.RawFormat)
            Dim bytimage As Byte() = msn.ToArray()

            '================================================================
            ADD_ACC00()
            '================================================================
            CLS_EMPLOYEE_.ADD_CUSTOMER(DTP.Value,
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
                                      CMB_Nationality.Text,
                                      TXT_idinsurance.Text,
                                      DTP_bgndate.Value,
                                      DTP_enddate.Value,
                                      DTP_inp.Value,
                                      DTP_outpu.Value,
                                      Val(TXT_salary.Text),
                                      Val(TXT_taxes.Text),
                                      Val(TXT_insurance.Text),
                                      CMB_statuse.Text,
                                      TXT_CARD.Text,
                                      TXT_Nationality.Text,
                                      CMB_job.SelectedValue,
                                      TXT_father.Text,
                                      TXT_mather.Text,
                                      Cmb_bloodtype.Text,
                                      TXT_CountryBirths.Text,
                                      TXT_RegistrationNo.Text,
                                      TXT_Box.Text,
                                      TXT_IDnumber.Text,
                                      DTP_date_IDnumber.Value,
                                      CMB_Army.Text,
                                      DTP_date_b_Army.Value,
                                      DTP_date_e_Army.Value,
                                      TXT_country_Army.Text,
                                      CMB_Family_status.Text,
                                      TXT_number_wives.Text,
                                      TXT_Number_Children.Text,
                                      TXT_Insurance_facility.Text,
                                      TXT_ID_Insurance_facility.Text,
                                      DTP_DATE_B_Insurance_facility.Value,
                                      DTP_DATE_E_Insurance_facility.Value,
                                      TXT_GUID.Text,
                                      Convert.ToDateTime(Now.ToShortDateString()),
                                      guid_user_log)

            add_EMPLOYEE_LEARN()

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
            
            COD__ = 164001


        End If
        '----------------------------------------------------
        CLS_ACCOUNT_.ADD_(TXT_NAME.Text, TXT_GUID_PARENT.Text, Val(COD__), 1, 0, 0, 0, guid_user_log)
        '----------------------------------------------------
        Dim count__ As Integer = 0
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
                MessageBox.Show("اسم موظف غير موجود", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End If
            '================================================================
            Dim DT As New DataTable
            DT.Clear()
            DT = CLS_EMPLOYEE_LEARNING_.SHOW_(TXT_iD.Text)
            If DT.Rows.Count < 0 Then
                MessageBox.Show("اسم  غير موجود", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End If
            '================================================================
            Dim msn As New MemoryStream
            pic.Image.Save(msn, pic.Image.RawFormat)
            Dim bytimage As Byte() = msn.ToArray()

            '================================================================



            CLS_EMPLOYEE_.UPDATE_CUSTOMER(DTP.Value,
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
                                         CMB_Nationality.Text,
                                         TXT_idinsurance.Text,
                                         DTP_bgndate.Value,
                                         DTP_enddate.Value,
                                         DTP_inp.Value,
                                         DTP_outpu.Value,
                                         Val(TXT_salary.Text),
                                         Val(TXT_taxes.Text),
                                         Val(TXT_insurance.Text),
                                         CMB_statuse.Text,
                                         TXT_CARD.Text,
                                         TXT_Nationality.Text,
                                         Val(TXT_iD.Text),
                                         CMB_job.SelectedValue,
                                         TXT_father.Text,
                                         TXT_mather.Text,
                                         Cmb_bloodtype.Text,
                                         TXT_CountryBirths.Text,
                                         TXT_RegistrationNo.Text,
                                         TXT_Box.Text,
                                         TXT_IDnumber.Text,
                                         DTP_date_IDnumber.Value,
                                         CMB_Army.Text,
                                      DTP_date_b_Army.Value,
                                      DTP_date_e_Army.Value,
                                      TXT_country_Army.Text,
                                        CMB_Family_status.Text,
                                      TXT_number_wives.Text,
                                      TXT_Number_Children.Text,
                                       TXT_Insurance_facility.Text,
                                      TXT_ID_Insurance_facility.Text,
                                      DTP_DATE_B_Insurance_facility.Value,
                                      DTP_DATE_E_Insurance_facility.Value,
                                      guid_user_log)
            add_EMPLOYEE_LEARN()
            MessageBox.Show("تمت عملية التعديل بنجاح", "تاكيد", MessageBoxButtons.OK, MessageBoxIcon.Information)
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

                CLS_EMPLOYEE_.delete_(Val(TXT_iD.Text))
                CLS_ACCOUNT_.delete_(TXT_GUID_ACCOUNT.Text)

                MessageBox.Show("   تمت عملية الحذف   بنجاح ", "تاكيد", MessageBoxButtons.OK, MessageBoxIcon.Information)


            End If



        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try

       
    End Sub

    Private Sub TXT_iD_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TXT_iD.TextChanged
        Try
            show_employee()
            show_EMPLOY_LEARNING()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
    Sub show_EMPLOY_LEARNING()
        Dim COUNT_ As Integer = 0
        Dim DT As New DataTable
        DT.Clear()
        DT = CLS_EMPLOYEE_LEARNING_.SHOW_(TXT_iD.Text)
        If DT.Rows.Count > 0 Then
            DGV_LEARNING.RowCount = DT.Rows.Count
            For I As Integer = 0 To DT.Rows.Count - 1
                DGV_LEARNING.Rows(COUNT_).Cells(0).Value = DT.Rows(I)(0).ToString()
                DGV_LEARNING.Rows(COUNT_).Cells(1).Value = DT.Rows(I)(1).ToString()
                DGV_LEARNING.Rows(COUNT_).Cells(2).Value = Convert.ToDateTime(DT.Rows(I)(2).ToString()).ToShortDateString()
                DGV_LEARNING.Rows(COUNT_).Cells(3).Value = Convert.ToDateTime(DT.Rows(I)(3).ToString()).ToShortDateString()
                DGV_LEARNING.Rows(COUNT_).Cells(4).Value = DT.Rows(I)(4).ToString()
                DGV_LEARNING.Rows(COUNT_).Cells(5).Value = DT.Rows(I)(5).ToString()
                COUNT_ = COUNT_ + 1


            Next

        Else
            DGV_LEARNING.Rows.Clear()
        End If
    End Sub
    Sub show_employee()
        Dim dt As New DataTable
        dt.Clear()
        dt = CLS_EMPLOYEE_.SHOW_CUSTOMER_ID(Val(TXT_iD.Text))
        If dt.Rows.Count <> 0 Then
            TXT_GUID_ACCOUNT.Text = dt.Rows(0)(45).ToString()



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

            CMB_Nationality.Text = dt.Rows(0).Item(13).ToString()
            TXT_idinsurance.Text = dt.Rows(0).Item(14).ToString()

            DTP_bgndate.Text = Convert.ToDateTime(dt.Rows(0).Item(15).ToString())
            DTP_enddate.Text = Convert.ToDateTime(dt.Rows(0).Item(16).ToString())

            DTP_inp.Text = Convert.ToDateTime(dt.Rows(0).Item(17).ToString())
            DTP_outpu.Text = Convert.ToDateTime(dt.Rows(0).Item(18).ToString())

            TXT_salary.Text = Val(dt.Rows(0).Item(19).ToString())
            TXT_taxes.Text = Val(dt.Rows(0).Item(20).ToString())
            TXT_insurance.Text = Val(dt.Rows(0).Item(21).ToString())
            CMB_statuse.Text = dt.Rows(0).Item(22).ToString()

            TXT_CARD.Text = dt.Rows(0).Item(23).ToString()
            TXT_Nationality.Text = dt.Rows(0).Item(24).ToString()
            CMB_job.SelectedValue = Convert.ToString(dt.Rows(0).Item(25).ToString())

            TXT_father.Text = dt.Rows(0).Item(26).ToString()
            TXT_mather.Text = dt.Rows(0).Item(27).ToString()
            Cmb_bloodtype.Text = dt.Rows(0).Item(28).ToString()
            TXT_CountryBirths.Text = dt.Rows(0).Item(29).ToString()
            TXT_RegistrationNo.Text = dt.Rows(0).Item(30).ToString()
            TXT_Box.Text = dt.Rows(0).Item(31).ToString()
            TXT_IDnumber.Text = dt.Rows(0).Item(32).ToString()
            DTP_date_IDnumber.Text = Convert.ToDateTime(dt.Rows(0).Item(33).ToString())

            CMB_Army.Text = dt.Rows(0).Item(34).ToString()

            DTP_date_b_Army.Text = Convert.ToDateTime(dt.Rows(0).Item(35).ToString())
            DTP_date_e_Army.Text = Convert.ToDateTime(dt.Rows(0).Item(36).ToString())
            TXT_country_Army.Text = dt.Rows(0).Item(37).ToString()

            CMB_Family_status.Text = dt.Rows(0).Item(38).ToString()
            TXT_number_wives.Text = dt.Rows(0).Item(39).ToString()
            TXT_Number_Children.Text = dt.Rows(0).Item(40).ToString()

            TXT_Insurance_facility.Text = dt.Rows(0).Item(41).ToString()
            TXT_ID_Insurance_facility.Text = dt.Rows(0).Item(42).ToString()


            DTP_DATE_B_Insurance_facility.Text = Convert.ToDateTime(dt.Rows(0).Item(43).ToString())
            DTP_DATE_E_Insurance_facility.Text = Convert.ToDateTime(dt.Rows(0).Item(44).ToString())
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

            TXT_idinsurance.Text = Nothing



            TXT_salary.Text = 0
            TXT_taxes.Text = 0
            TXT_insurance.Text = 0


            TXT_CARD.Text = Nothing
            TXT_Nationality.Text = Nothing


            TXT_father.Text = Nothing
            TXT_mather.Text = Nothing

            TXT_CountryBirths.Text = Nothing
            TXT_RegistrationNo.Text = Nothing
            TXT_Box.Text = Nothing
            TXT_IDnumber.Text = Nothing

            CMB_Army.Text = Nothing
            TXT_country_Army.Text = Nothing

            CMB_Family_status.Text = Nothing
            TXT_number_wives.Text = Nothing
            TXT_Number_Children.Text = Nothing

            TXT_Insurance_facility.Text = Nothing
            TXT_ID_Insurance_facility.Text = Nothing
            TXT_GUID_ACCOUNT.Text = Nothing
        End If
    End Sub
    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        Try
            Dim f As New FRM_ALL_EMPLOYEE
            f.ShowDialog()
            If f.isok = True Then
                Dim I As Integer = f.DGV.CurrentRow.Index
                TXT_iD.Text = f.DGV.Rows(I).Cells(0).Value.ToString()
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub BTN_BROWS_IMAGE_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub ToolStripButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton2.Click
        'Try
        '    Dim DST As New DataSet
        '    DST.Clear()
        '    Dim cmd As New SqlDataAdapter("SELECT ID,DTP,NAME,LASTNAME,COMPANY,COMPANYJOB,CUNTRY,STREET,PHON,MOB1,MOB2,MAIL,WEB,img  FROM STUDENT  where ID=" & Val(TXT_iD.Text) & "", con)
        '    cmd.Fill(DST, "STUDENT")

        '    '======================================================
        '    If DST.Tables("STUDENT").Rows.Count > 0 Then


        '        Dim Rep As New Crystal_STUDENT_PIC



        '        Rep.SetDataSource(DST)
        '        Rep.SetParameterValue("LP", My.Settings.TXTPATH_LOGO)
        '        Rep.SetParameterValue("NAME", My.Settings.TXT_NAME)
        '        Rep.SetParameterValue("PHONE", My.Settings.TXT_PHONE)
        '        Rep.SetParameterValue("MOBILE", My.Settings.TXT_MOBILE)
        '        Rep.SetParameterValue("EMAIL", My.Settings.TXT_EMAIL)
        '        Rep.SetParameterValue("WEB", My.Settings.TXT_WEB)
        '        FRM_PRINT.CrystalReportViewer1.ReportSource = Rep

        '        FRM_PRINT.ShowDialog()
        '    End If

        'Catch ex As Exception
        '    MsgBox(ex.ToString)
        'End Try
    End Sub

    Private Sub TXT_JOB_COMPAN_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TXT_JOB_COMPAN.TextChanged

    End Sub

    Private Sub pic_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pic.Click
        Dim ofd As New OpenFileDialog
        ofd.Filter = "اختر صورة|*.jpg;*.png;*.gig;"
        If ofd.ShowDialog = Windows.Forms.DialogResult.OK Then
            pic.Image = Image.FromFile(ofd.FileName)
        End If

    End Sub


    Private Sub CMB_job_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles CMB_job.KeyPress
        e.Handled = True
    End Sub

    Private Sub CMB_job_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CMB_job.SelectedIndexChanged

    End Sub

    Private Sub CMB_statuse_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles CMB_statuse.KeyPress
        e.Handled = True
    End Sub

    Private Sub CMB_statuse_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CMB_statuse.SelectedIndexChanged

    End Sub

    Private Sub CMB_Nationality_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles CMB_Nationality.KeyPress
        e.Handled = True
    End Sub



    Private Sub CMB_Nationality_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CMB_Nationality.SelectedIndexChanged

    End Sub

    Private Sub TXT_insurance_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TXT_insurance.KeyPress
        If (e.KeyChar >= "a" And e.KeyChar <= "z") Or (e.KeyChar >= "A" And e.KeyChar <= "Z") Or (e.KeyChar >= "ا" And e.KeyChar <= "ي") Then
            e.Handled = True
        End If
    End Sub

    Private Sub TXT_insurance_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TXT_insurance.TextChanged

    End Sub

    Private Sub TXT_salary_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TXT_salary.KeyPress
        If (e.KeyChar >= "a" And e.KeyChar <= "z") Or (e.KeyChar >= "A" And e.KeyChar <= "Z") Or (e.KeyChar >= "ا" And e.KeyChar <= "ي") Then
            e.Handled = True
        End If
    End Sub

    Private Sub TXT_salary_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TXT_salary.TextChanged

    End Sub

    Private Sub TXT_taxes_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TXT_taxes.KeyPress
        If (e.KeyChar >= "a" And e.KeyChar <= "z") Or (e.KeyChar >= "A" And e.KeyChar <= "Z") Or (e.KeyChar >= "ا" And e.KeyChar <= "ي") Then
            e.Handled = True
        End If
    End Sub

    Private Sub TXT_taxes_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TXT_taxes.TextChanged

    End Sub

    Private Sub TabPage1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabPage1.Click

    End Sub

    Private Sub ToolStripButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton3.Click
        Try
            DGV_LEARNING.Rows.Add(CMB_EMPLOYEE_LEARNING.SelectedValue, CMB_EMPLOYEE_LEARNING.Text, DTP_B_EMPLOYEE_LEARNING.Value.ToShortDateString(), DTP_E_EMPLOYEE_LEARNING.Value.ToShortDateString(), TXT_T_EMPLOYEE_LEARNING.Text, TXT_COUNTRY_EMPLOYEE_LEARNING.Text)
            TXT_T_EMPLOYEE_LEARNING.Text = Nothing
            TXT_COUNTRY_EMPLOYEE_LEARNING.Text = Nothing
            DTP_B_EMPLOYEE_LEARNING.Value = Today
            DTP_E_EMPLOYEE_LEARNING.Value = Today
        Catch ex As Exception

        End Try
    End Sub

    Private Sub ToolStripButton6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton6.Click
        Try
            If MessageBox.Show("هل انت متاكد من عملية الحذف", "تنبيه", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = Windows.Forms.DialogResult.Yes Then
                Dim i As Integer = DGV_LEARNING.CurrentRow.Index
                DGV_LEARNING.Rows.RemoveAt(i)
                MessageBox.Show("تمت عملية الحذف بنجاح", "تاكيد", MessageBoxButtons.OK, MessageBoxIcon.Information)

            End If


        Catch ex As Exception

        End Try
    End Sub
    Sub add_EMPLOYEE_LEARN()
        Try
            CLS_EMPLOYEE_LEARNING_.delete_(Val(TXT_iD.Text))

            For i As Integer = 0 To DGV_LEARNING.Rows.Count - 1
                Dim note_1 As String
                If DGV_LEARNING.Rows(i).Cells(4).Value = Nothing Then
                    note_1 = "لايوجد"
                Else
                    note_1 = DGV_LEARNING.Rows(i).Cells(4).Value.ToString()
                End If

                Dim note_2 As String
                If DGV_LEARNING.Rows(i).Cells(5).Value = Nothing Then
                    note_2 = "لايوجد"
                Else
                    note_2 = DGV_LEARNING.Rows(i).Cells(5).Value.ToString()
                End If


                CLS_EMPLOYEE_LEARNING_.ADD_(Val(TXT_iD.Text), Val(DGV_LEARNING.Rows(i).Cells(0).Value), Convert.ToDateTime(DGV_LEARNING.Rows(i).Cells(2).Value), Convert.ToDateTime(DGV_LEARNING.Rows(i).Cells(3).Value), note_1, note_2)
            Next

        Catch ex As Exception

        End Try
    End Sub

    Private Sub CMB_EMPLOYEE_LEARNING_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles CMB_EMPLOYEE_LEARNING.KeyPress
        e.Handled = True
    End Sub

    Private Sub CMB_EMPLOYEE_LEARNING_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CMB_EMPLOYEE_LEARNING.SelectedIndexChanged

    End Sub
End Class