Public Class FRM_MENU

    Dim US00_BT_ As New US00_BT
    Dim CLS_SHOW_USE_ As New CLS_SHOW_USE
    Private Sub ButtonItem14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ACC4.Click
        Dim F As New FRM_ACCOUNT

        F.MdiParent = Me
        F.Show()

    End Sub


    Private Sub ButtonItem15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ACC5.Click
        Try
            Dim F As New FRM_DAY

            'F.TXT_TYPE.Text = "00000000-0000-0000-0000-000000000000"
            F.MdiParent = Me
            F.Show()
        Catch ex As Exception

        End Try

    End Sub

    Private Sub FRM_MENU_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try



            'Dim webAddress As String = "http://www.acc-prog.com/"
            'Process.Start(webAddress)

            'Dim sm As New SecurityManager
            'Dim serial As Double
            'Dim show_ac As Double = Val(My.Settings.txt_d)

            'serial = sm.GetSerial
            'Dim key_pc As Double = sm.CheckKey(Val(serial))
            'If Val(key_pc) <> Val(show_ac) Then

            '    FRM_ACTIVEE.ShowDialog()
            '    Exit Sub
            'Else

            'End If






            FRM_BSEAT.ShowDialog()

            Dim f As New FRM_ALL_COMPANY

            f.ShowDialog()

            Dim fF As New FRM_LOGIN
            fF.ShowDialog()

            If fF.isok = True Then
                TXT_GUID.Text = fF.TXT_GUID.Text
                use_show()
            End If

        Catch ex As Exception

        End Try

    End Sub

    Private Sub ButtonItem16_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MT1.Click
        Dim F As New FRM_CATEGORYE
        F.MdiParent = Me
        F.Show()
    End Sub

    Private Sub ButtonItem17_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MT2.Click
        Dim F As New FRM_STORE
        F.MdiParent = Me
        F.Show()
    End Sub

    Private Sub ButtonItem18_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MT3.Click
        Dim F As New FRM_ITEME
        F.SHOW_CMB()
        F.MdiParent = Me
        F.Show()
    End Sub

    Private Sub ButtonItem19_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles INV2.Click
        Try

            'Dim dt1 As New DataTable
            'dt1.Clear()

            ''ISINSERT,ISUPDATE,ISDELETE,ISprint ,ISSHOW 
            'dt1 = US00_BT_.GUID_BT_us("929d33a1-c8be-4e7d-bb39-ce59a527c305", TXT_GUID.Text)
            'If dt1.Rows.Count > 0 Then
            '    If dt1.Rows(0)(4) = False Then
            '    Else
            Dim F As New FRM_BILL
            F.TXT_PARENT_GUID.Text = "929d33a1-c8be-4e7d-bb39-ce59a527c305"
            F.Text = "مشتريات الرئيسية"
            F.TXT_NUMBER_TYPE.Text = "0"

            F.MdiParent = Me
            F.Show()
            '    End If
            'End If




        Catch ex As Exception

        End Try
    End Sub

    Private Sub ButtonItem21_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub


    Private Sub ButtonItem22_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles INV1.Click
        Try
            Dim F As New FRM_B_ITEME
            F.TXT_PARENT_GUID.Text = "699dad82-aaa8-46e3-9fc8-528ba0e4ad46"
            F.Text = " بضاعة اول المدة"
            F.TXT_NUMBER_TYPE.Text = "7"

            F.MdiParent = Me
            F.Show()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub ButtonItem23_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            Dim F As New FRM_BILL
            F.TXT_PARENT_GUID.Text = "b6709fe0-22d2-4d42-b32b-2fecf289eb0c"
            F.Text = "مشتريات فرع الرياض"
            F.TXT_NUMBER_TYPE.Text = "0"
            F.MdiParent = Me
            F.Show()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub ButtonItem24_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles INV3.Click
        Try
            Dim F As New FRM_BILL
            F.TXT_PARENT_GUID.Text = "b868b16e-214d-4936-b493-0f1773a3929f"
            F.Text = "مردودات مشتريات رئيسية"
            F.TXT_NUMBER_TYPE.Text = "1"
            F.MdiParent = Me
            F.Show()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub ButtonItem25_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles INV4.Click
        Try
            Dim F As New FRM_B_ITEME
            F.TXT_PARENT_GUID.Text = "a9c5bb03-c147-4e72-ad52-6ca519c1043a"
            F.Text = "فاتورة ادخال"
            F.TXT_NUMBER_TYPE.Text = "5"

            F.MdiParent = Me
            F.Show()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub ButtonItem26_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles INV5.Click
        Try
            Dim F As New FRM_B_ITEME
            F.TXT_PARENT_GUID.Text = "ab4db841-93c1-4c46-bae6-fa1473ba4dff"
            F.Text = "فاتورة اخراج"
            F.TXT_NUMBER_TYPE.Text = "6"

            F.MdiParent = Me
            F.Show()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub ButtonItem27_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles INV6.Click
        Try
            Dim F As New FRM_BILL
            F.TXT_PARENT_GUID.Text = "bd96714a-f1b7-4ed8-a62d-6a58a601285a"
            F.Text = "مبيعات"
            F.TXT_NUMBER_TYPE.Text = "2"
            F.MdiParent = Me
            F.Show()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub ButtonItem28_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles INV7.Click
        Try
            Dim F As New FRM_BILL
            F.TXT_PARENT_GUID.Text = "94e01972-58eb-48b3-8f1b-3c711c210a07"
            F.Text = "مردودات مبيعات"
            F.TXT_NUMBER_TYPE.Text = "3"
            F.MdiParent = Me
            F.Show()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub ButtonItem29_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ACC6.Click
        Dim F As New FRM_DAY_CASH
        F.TXT_PARENTGUID.Text = "9b70751c-4b8e-4fff-a396-5634b4877005"
        F.Text = "سند قبض"
        F.TXT_CODE.Text = "0"
        F.DGV.Columns(3).Visible = False
        F.MdiParent = Me
        F.Show()
    End Sub

    Private Sub ButtonItem30_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ACC7.Click
        Dim F As New FRM_DAY_CASH
        F.TXT_PARENTGUID.Text = "fcb7d76a-550f-4af3-ab61-7643d7e683d0"
        F.Text = "سند صرف"
        F.TXT_CODE.Text = "1"
        F.DGV.Columns(4).Visible = False
        F.MdiParent = Me
        F.Show()

    End Sub

    Private Sub ButtonItem31_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub ButtonItem21_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles REP_ACC1.Click
        Dim F As New FRM_REP_ALLDAY
        F.MdiParent = Me
        F.Show()
    End Sub

    Private Sub ButtonItem32_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ACC2.Click
        Dim F As New FRM_CURRENCY
        F.MdiParent = Me
        F.Show()
    End Sub

    Private Sub ButtonItem33_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ACC1.Click
        Dim F As New FRM_GOB
        F.MdiParent = Me
        F.Show()
    End Sub

    Private Sub ButtonItem35_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EMP1.Click
        Dim F As New FRM_JOBE_MPLOYEE
        F.MdiParent = Me
        F.Show()
    End Sub

    Private Sub ButtonItem36_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EMP2.Click
        Dim F As New FRM_EARNING
        F.MdiParent = Me
        F.Show()
    End Sub

    Private Sub ButtonItem37_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EMP3.Click
        Dim F As New FRM_EMPLOYEE
        F.MdiParent = Me
        F.Show()
    End Sub

    Private Sub ButtonItem38_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim F As New FRM_DAY_CASH
        F.TXT_PARENTGUID.Text = "2279ec78-3ef7-4fdb-a577-7d8edda2e4fa"
        F.Text = " تسديد رواتب"
        F.TXT_CODE.Text = "1"
        F.DGV.Columns(4).Visible = False
        F.MdiParent = Me
        F.Show()
    End Sub

    Private Sub ButtonItem39_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim F As New FRM_DAY_CASH
        F.TXT_PARENTGUID.Text = "d74a6150-eed1-4580-b899-53c2ac3fbca6"
        F.Text = " حسميات "
        F.TXT_CODE.Text = "1"
        F.DGV.Columns(4).Visible = False
        F.MdiParent = Me
        F.Show()
    End Sub

    

    Private Sub ButtonItem40_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim F As New FRM_DAY_CASH
        F.TXT_PARENTGUID.Text = "59fe8d11-3e59-4cd0-9517-bc72287b25a8"
        F.Text = "اضافات"
        F.TXT_CODE.Text = "0"
        F.DGV.Columns(4).Visible = False
        F.MdiParent = Me
        F.Show()
    End Sub

    Private Sub ButtonItem31_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles REP_ACC2.Click
        Dim F As New FRM_REP_ACCOUNT
        F.MdiParent = Me
        F.Show()
    End Sub

    Private Sub ButtonItem41_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles REP_ACC3.Click
        Dim F As New FRM_REP_BALANCE
        F.MdiParent = Me
        F.Show()
    End Sub

    Private Sub ButtonItem42_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles REP_ACC4.Click
        Dim F As New FRM_FINAL
        F.MdiParent = Me
        F.Show()
    End Sub

   

    Private Sub ButtonItem45_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FI2.Click
        Dim F As New Frm_company
        F.MdiParent = Me
        F.Show()
    End Sub

    Private Sub ButtonItem43_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles REP_ACC5.Click
        Dim F As New FRM_BETWEEN_ACCOUNT
        F.MdiParent = Me
        F.Show()
    End Sub

  

    Private Sub ButtonItem47_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles REP_MT1.Click
        Dim F As New FRM_ITEME_ALL
        F.MdiParent = Me
        F.Show()
    End Sub

    Private Sub ButtonItem48_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles REP_MT2.Click
        Dim F As New FRM_ITEME_DAY
        F.MdiParent = Me
        F.Show()
    End Sub

    Private Sub ButtonItem49_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles REP_MT3.Click
        Dim F As New FRM_REP_BALANCEITEME
        F.MdiParent = Me
        F.Show()
    End Sub

    Private Sub ButtonItem46_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim F As New FRM_ITEME_ALL
        F.MdiParent = Me
        F.Show()
    End Sub

    Private Sub ButtonItem50_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles REP_MT4.Click
        Dim F As New FRM_BETWEEN_ITEME
        F.MdiParent = Me
        F.Show()
    End Sub

    Private Sub ButtonItem51_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ACC3.Click
        Dim F As New FRM_TRF2
        F.MdiParent = Me
        F.Show()
    End Sub

    
    Private Sub ButtonItem23_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FI3.Click
        Dim F As New FRM_USER
        F.MdiParent = Me
        F.Show()
    End Sub

   
  

  
    Private Sub ButtonItem57_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim F As New FRM_branch
        F.MdiParent = Me
        F.Show()
    End Sub

    Private Sub ButtonItem38_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles REP_MT5.Click
        Dim F As New FRM_REP_ALL_INVENTORY
        F.MdiParent = Me
        F.Show()
    End Sub

    Private Sub ButtonItem39_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles REP_MT6.Click
        Try
            Dim F As New FRM_REP_END_ITEME
            F.MdiParent = Me
            F.Show()

        Catch ex As Exception

        End Try
    End Sub

    Private Sub ButtonItem40_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SETT1.Click
        Dim f As New FRM_SETINGS_BILL
        f.MdiParent = Me
        f.Show()
    End Sub

   

    

    Private Sub ButtonItem53_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles INV8.Click
        Try
            Dim F As New FRM_BILL
            F.TXT_PARENT_GUID.Text = "1f3d359e-5aef-4008-8191-559c834f2f70"
            F.Text = "طلب شراء"
            F.TXT_NUMBER_TYPE.Text = "9"
            F.MdiParent = Me
            F.Show()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub ButtonItem54_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles INV9.Click
        Try
            Dim F As New FRM_BILL
            F.TXT_PARENT_GUID.Text = "2fae5ae0-89a5-4f8a-8d3b-11ee10e21372"
            F.Text = " عرض سعر"
            F.TXT_NUMBER_TYPE.Text = "8"
            F.MdiParent = Me
            F.Show()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub ButtonItem56_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            Dim F As New FRM_POS
            F.TXT_PARENT_GUID.Text = "6bc2579c-9131-431e-8c27-8b97715cfe4a"
            F.Text = "POS"
            F.TXT_NUMBER_TYPE.Text = "2"
            'F.MdiParent = Me
            F.Show()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub ButtonItem55_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SETT2.Click
        Try
            Dim F As New FRM_SET_POS

            F.MdiParent = Me
            F.Show()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub FI3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FI1.Click
        FRM_ALL_COMPANY.ShowDialog()
        FRM_LOGIN.ShowDialog()

    End Sub

    Private Sub TXT_GUID_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TXT_GUID.TextChanged
        Try

        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        End Try
    End Sub
    Sub use_show()
        If TXT_GUID.Text = Nothing Then
            Exit Sub
        End If
        Dim dt As New DataTable
        dt.Clear()
        dt = CLS_SHOW_USE_.SEARSH_(TXT_GUID.Text)
        If dt.Rows.Count > 0 Then
            'Check_FI.Checked = Convert.ToBoolean(dt.Rows(0)(0).ToString())
            If Convert.ToBoolean(dt.Rows(0)(0).ToString()) = True Then
                FI.Visible = True
            Else
                FI.Visible = False
            End If
            'Check_FI1.Checked = Convert.ToBoolean(dt.Rows(0)(1).ToString())
            If Convert.ToBoolean(dt.Rows(0)(1).ToString()) = True Then
                FI1.Visible = True
            Else
                FI1.Visible = False
            End If
            'Check_FI2.Checked = Convert.ToBoolean(dt.Rows(0)(2).ToString())
            If Convert.ToBoolean(dt.Rows(0)(2).ToString()) = True Then
                FI2.Visible = True
            Else
                FI2.Visible = False
            End If
            'Check_FI3.Checked = Convert.ToBoolean(dt.Rows(0)(3).ToString())
            If Convert.ToBoolean(dt.Rows(0)(3).ToString()) = True Then
                FI3.Visible = True
            Else
                FI3.Visible = False
            End If
            'Check_FI4.Checked = Convert.ToBoolean(dt.Rows(0)(4).ToString())
            'If Convert.ToBoolean(dt.Rows(0)(4).ToString()) = True Then
            '    FI4.Visible = True
            'Else
            '    FI4.Visible = False
            'End If
            'Check_FI5.Checked = Convert.ToBoolean(dt.Rows(0)(5).ToString())
            'Check_FI6.Checked = Convert.ToBoolean(dt.Rows(0)(6).ToString())
            'Check_FI7.Checked = Convert.ToBoolean(dt.Rows(0)(7).ToString())
            'Check_FI8.Checked = Convert.ToBoolean(dt.Rows(0)(8).ToString())
            'Check_FI9.Checked = Convert.ToBoolean(dt.Rows(0)(9).ToString())
            'Check_FI10.Checked = Convert.ToBoolean(dt.Rows(0)(10).ToString())


            'Check_ACC.Checked = Convert.ToBoolean(dt.Rows(0)(11).ToString())
            If Convert.ToBoolean(dt.Rows(0)(11).ToString()) = True Then
                ACC.Visible = True
            Else
                ACC.Visible = False
            End If
            'Check_ACC1.Checked = Convert.ToBoolean(dt.Rows(0)(12).ToString())
            If Convert.ToBoolean(dt.Rows(0)(12).ToString()) = True Then
                ACC1.Visible = True
            Else
                ACC1.Visible = False
            End If
            'Check_ACC2.Checked = Convert.ToBoolean(dt.Rows(0)(13).ToString())
            If Convert.ToBoolean(dt.Rows(0)(13).ToString()) = True Then
                ACC2.Visible = True
            Else
                ACC2.Visible = False
            End If
            'Check_ACC3.Checked = Convert.ToBoolean(dt.Rows(0)(14).ToString())
            If Convert.ToBoolean(dt.Rows(0)(14).ToString()) = True Then
                ACC3.Visible = True
            Else
                ACC3.Visible = False
            End If
            'Check_ACC4.Checked = Convert.ToBoolean(dt.Rows(0)(15).ToString())
            If Convert.ToBoolean(dt.Rows(0)(15).ToString()) = True Then
                ACC4.Visible = True
            Else
                ACC4.Visible = False
            End If
            'Check_ACC5.Checked = Convert.ToBoolean(dt.Rows(0)(16).ToString())
            If Convert.ToBoolean(dt.Rows(0)(16).ToString()) = True Then
                ACC5.Visible = True
            Else
                ACC5.Visible = False
            End If
            'Check_ACC6.Checked = Convert.ToBoolean(dt.Rows(0)(17).ToString())
            If Convert.ToBoolean(dt.Rows(0)(17).ToString()) = True Then
                ACC6.Visible = True
            Else
                ACC6.Visible = False
            End If
            'Check_ACC7.Checked = Convert.ToBoolean(dt.Rows(0)(18).ToString())
            If Convert.ToBoolean(dt.Rows(0)(18).ToString()) = True Then
                ACC7.Visible = True
            Else
                ACC7.Visible = False
            End If
            'Check_ACC8.Checked = Convert.ToBoolean(dt.Rows(0)(19).ToString())
            'If Convert.ToBoolean(dt.Rows(0)(19).ToString()) = True Then
            '    ACC8.Visible = True
            'Else
            '    ACC8.Visible = False
            'End If
            'Check_ACC9.Checked = Convert.ToBoolean(dt.Rows(0)(20).ToString())
            'Check_ACC10.Checked = Convert.ToBoolean(dt.Rows(0)(21).ToString())
            'Check_ACC11.Checked = Convert.ToBoolean(dt.Rows(0)(22).ToString())
            'Check_ACC12.Checked = Convert.ToBoolean(dt.Rows(0)(23).ToString())

            'Check_MT.Checked = Convert.ToBoolean(dt.Rows(0)(24).ToString())
            If Convert.ToBoolean(dt.Rows(0)(24).ToString()) = True Then
                MT.Visible = True
            Else
                MT.Visible = False
            End If
            'Check_MT1.Checked = Convert.ToBoolean(dt.Rows(0)(25).ToString())
            If Convert.ToBoolean(dt.Rows(0)(25).ToString()) = True Then
                MT1.Visible = True
            Else
                MT1.Visible = False
            End If
            'Check_MT2.Checked = Convert.ToBoolean(dt.Rows(0)(26).ToString())
            If Convert.ToBoolean(dt.Rows(0)(26).ToString()) = True Then
                MT2.Visible = True
            Else
                MT2.Visible = False
            End If
            'Check_MT3.Checked = Convert.ToBoolean(dt.Rows(0)(27).ToString())
            If Convert.ToBoolean(dt.Rows(0)(27).ToString()) = True Then
                MT3.Visible = True
            Else
                MT3.Visible = False
            End If
            'Check_MT4.Checked = Convert.ToBoolean(dt.Rows(0)(28).ToString())
            'If Convert.ToBoolean(dt.Rows(0)(28).ToString()) = True Then
            '    MT4.Visible = True
            'Else
            '    MT4.Visible = False
            'End If
            'Check_MT5.Checked = Convert.ToBoolean(dt.Rows(0)(29).ToString())
            'Check_MT6.Checked = Convert.ToBoolean(dt.Rows(0)(30).ToString())
            'Check_MT7.Checked = Convert.ToBoolean(dt.Rows(0)(31).ToString())
            'Check_MT8.Checked = Convert.ToBoolean(dt.Rows(0)(32).ToString())
            'Check_MT9.Checked = Convert.ToBoolean(dt.Rows(0)(33).ToString())
            'Check_MT10.Checked = Convert.ToBoolean(dt.Rows(0)(34).ToString())

            'Check_INV.Checked = Convert.ToBoolean(dt.Rows(0)(35).ToString())
            If Convert.ToBoolean(dt.Rows(0)(35).ToString()) = True Then
                INV.Visible = True
            Else
                INV.Visible = False
            End If
            'Check_INV1.Checked = Convert.ToBoolean(dt.Rows(0)(36).ToString())
            If Convert.ToBoolean(dt.Rows(0)(36).ToString()) = True Then
                INV1.Visible = True
            Else
                INV1.Visible = False
            End If
            'Check_INV2.Checked = Convert.ToBoolean(dt.Rows(0)(37).ToString())
            If Convert.ToBoolean(dt.Rows(0)(37).ToString()) = True Then
                INV2.Visible = True
            Else
                INV2.Visible = False
            End If
            'Check_INV3.Checked = Convert.ToBoolean(dt.Rows(0)(38).ToString())
            If Convert.ToBoolean(dt.Rows(0)(38).ToString()) = True Then
                INV3.Visible = True
            Else
                INV3.Visible = False
            End If
            'Check_INV4.Checked = Convert.ToBoolean(dt.Rows(0)(39).ToString())
            If Convert.ToBoolean(dt.Rows(0)(39).ToString()) = True Then
                INV4.Visible = True
            Else
                INV4.Visible = False
            End If
            'Check_INV5.Checked = Convert.ToBoolean(dt.Rows(0)(40).ToString())
            If Convert.ToBoolean(dt.Rows(0)(40).ToString()) = True Then
                INV5.Visible = True
            Else
                INV5.Visible = False
            End If
            'Check_INV6.Checked = Convert.ToBoolean(dt.Rows(0)(41).ToString())
            If Convert.ToBoolean(dt.Rows(0)(41).ToString()) = True Then
                INV6.Visible = True
            Else
                INV6.Visible = False
            End If
            'Check_INV7.Checked = Convert.ToBoolean(dt.Rows(0)(42).ToString())
            If Convert.ToBoolean(dt.Rows(0)(42).ToString()) = True Then
                INV7.Visible = True
            Else
                INV7.Visible = False
            End If
            'Check_INV8.Checked = Convert.ToBoolean(dt.Rows(0)(43).ToString())
            If Convert.ToBoolean(dt.Rows(0)(43).ToString()) = True Then
                INV8.Visible = True
            Else
                INV8.Visible = False
            End If
            'Check_INV9.Checked = Convert.ToBoolean(dt.Rows(0)(44).ToString())
            If Convert.ToBoolean(dt.Rows(0)(44).ToString()) = True Then
                INV9.Visible = True
            Else
                INV9.Visible = False
            End If
            'Check_INV10.Checked = Convert.ToBoolean(dt.Rows(0)(45).ToString())
            'If Convert.ToBoolean(dt.Rows(0)(45).ToString()) = True Then
            '    INV10.Visible = True0
            'Else
            '    INV10.Visible = False
            'End If
            'Check_INV11.Checked = Convert.ToBoolean(dt.Rows(0)(46).ToString())
            'Check_INV12.Checked = Convert.ToBoolean(dt.Rows(0)(47).ToString())
            'Check_INV13.Checked = Convert.ToBoolean(dt.Rows(0)(48).ToString())
            'Check_INV14.Checked = Convert.ToBoolean(dt.Rows(0)(49).ToString())
            'Check_INV15.Checked = Convert.ToBoolean(dt.Rows(0)(50).ToString())

            'Check_EMP.Checked = Convert.ToBoolean(dt.Rows(0)(51).ToString())
            If Convert.ToBoolean(dt.Rows(0)(51).ToString()) = True Then
                EMP.Visible = True
            Else
                EMP.Visible = False
            End If
            'Check_EMP1.Checked = Convert.ToBoolean(dt.Rows(0)(52).ToString())
            If Convert.ToBoolean(dt.Rows(0)(52).ToString()) = True Then
                EMP1.Visible = True
            Else
                EMP1.Visible = False
            End If
            'Check_EMP2.Checked = Convert.ToBoolean(dt.Rows(0)(53).ToString())
            If Convert.ToBoolean(dt.Rows(0)(53).ToString()) = True Then
                EMP2.Visible = True
            Else
                EMP2.Visible = False
            End If
            'Check_EMP3.Checked = Convert.ToBoolean(dt.Rows(0)(54).ToString())
            If Convert.ToBoolean(dt.Rows(0)(54).ToString()) = True Then
                EMP3.Visible = True
            Else
                EMP3.Visible = False
            End If
            'Check_EMP4.Checked = Convert.ToBoolean(dt.Rows(0)(55).ToString())
            'If Convert.ToBoolean(dt.Rows(0)(55).ToString()) = True Then
            '    EMP4.Visible = True
            'Else
            '    EMP4.Visible = False
            'End If
            'Check_EMP5.Checked = Convert.ToBoolean(dt.Rows(0)(56).ToString())
            'Check_EMP6.Checked = Convert.ToBoolean(dt.Rows(0)(57).ToString())
            'Check_EMP7.Checked = Convert.ToBoolean(dt.Rows(0)(58).ToString())
            'Check_EMP8.Checked = Convert.ToBoolean(dt.Rows(0)(59).ToString())
            'Check_EMP9.Checked = Convert.ToBoolean(dt.Rows(0)(60).ToString())
            'Check_EMP10.Checked = Convert.ToBoolean(dt.Rows(0)(61).ToString())

            'Check_REP_ACC.Checked = Convert.ToBoolean(dt.Rows(0)(62).ToString())
            If Convert.ToBoolean(dt.Rows(0)(62).ToString()) = True Then
                REP_ACC.Visible = True
            Else
                REP_ACC.Visible = False
            End If
            'Check_REP_ACC1.Checked = Convert.ToBoolean(dt.Rows(0)(63).ToString())
            If Convert.ToBoolean(dt.Rows(0)(63).ToString()) = True Then
                REP_ACC1.Visible = True
            Else
                REP_ACC1.Visible = False
            End If
            'Check_REP_ACC2.Checked = Convert.ToBoolean(dt.Rows(0)(64).ToString())
            If Convert.ToBoolean(dt.Rows(0)(64).ToString()) = True Then
                REP_ACC2.Visible = True
            Else
                REP_ACC2.Visible = False
            End If
            'Check_REP_ACC3.Checked = Convert.ToBoolean(dt.Rows(0)(65).ToString())
            If Convert.ToBoolean(dt.Rows(0)(65).ToString()) = True Then
                REP_ACC3.Visible = True
            Else
                REP_ACC3.Visible = False
            End If
            'Check_REP_ACC4.Checked = Convert.ToBoolean(dt.Rows(0)(66).ToString())
            If Convert.ToBoolean(dt.Rows(0)(66).ToString()) = True Then
                REP_ACC4.Visible = True
            Else
                REP_ACC4.Visible = False
            End If
            'Check_REP_ACC5.Checked = Convert.ToBoolean(dt.Rows(0)(67).ToString())
            If Convert.ToBoolean(dt.Rows(0)(67).ToString()) = True Then
                REP_ACC5.Visible = True
            Else
                REP_ACC5.Visible = False
            End If
            'Check_REP_ACC6.Checked = Convert.ToBoolean(dt.Rows(0)(68).ToString())
            'If Convert.ToBoolean(dt.Rows(0)(68).ToString()) = True Then
            '    REP_ACC6.Visible = True
            'Else
            '    REP_ACC6.Visible = False
            'End If
            'Check_REP_ACC7.Checked = Convert.ToBoolean(dt.Rows(0)(69).ToString())
            'Check_REP_ACC8.Checked = Convert.ToBoolean(dt.Rows(0)(70).ToString())
            'Check_REP_ACC9.Checked = Convert.ToBoolean(dt.Rows(0)(71).ToString())
            'Check_REP_ACC10.Checked = Convert.ToBoolean(dt.Rows(0)(72).ToString())

            'Check_REP_MT.Checked = Convert.ToBoolean(dt.Rows(0)(73).ToString())
            If Convert.ToBoolean(dt.Rows(0)(73).ToString()) = True Then
                REP_MT.Visible = True
            Else
                REP_MT.Visible = False
            End If
            'Check_REP_MT1.Checked = Convert.ToBoolean(dt.Rows(0)(74).ToString())
            If Convert.ToBoolean(dt.Rows(0)(74).ToString()) = True Then
                REP_MT1.Visible = True
            Else
                REP_MT1.Visible = False
            End If
            'Check_REP_MT2.Checked = Convert.ToBoolean(dt.Rows(0)(75).ToString())
            If Convert.ToBoolean(dt.Rows(0)(75).ToString()) = True Then
                REP_MT2.Visible = True
            Else
                REP_MT2.Visible = False
            End If
            'Check_REP_MT3.Checked = Convert.ToBoolean(dt.Rows(0)(76).ToString())
            If Convert.ToBoolean(dt.Rows(0)(76).ToString()) = True Then
                REP_MT3.Visible = True
            Else
                REP_MT3.Visible = False
            End If
            'Check_REP_MT4.Checked = Convert.ToBoolean(dt.Rows(0)(77).ToString())
            If Convert.ToBoolean(dt.Rows(0)(77).ToString()) = True Then
                REP_MT4.Visible = True
            Else
                REP_MT4.Visible = False
            End If
            'Check_REP_MT5.Checked = Convert.ToBoolean(dt.Rows(0)(78).ToString())
            If Convert.ToBoolean(dt.Rows(0)(78).ToString()) = True Then
                REP_MT5.Visible = True
            Else
                REP_MT5.Visible = False
            End If
            'Check_REP_MT6.Checked = Convert.ToBoolean(dt.Rows(0)(79).ToString())
            If Convert.ToBoolean(dt.Rows(0)(79).ToString()) = True Then
                REP_MT6.Visible = True
            Else
                REP_MT6.Visible = False
            End If
            'Check_REP_MT7.Checked = Convert.ToBoolean(dt.Rows(0)(80).ToString())
            If Convert.ToBoolean(dt.Rows(0)(80).ToString()) = True Then
                REP_MT7.Visible = True
            Else
                REP_MT7.Visible = False
            End If
            'Check_REP_MT8.Checked = Convert.ToBoolean(dt.Rows(0)(81).ToString())
            If Convert.ToBoolean(dt.Rows(0)(81).ToString()) = True Then
                REP_MT8.Visible = True
            Else
                REP_MT8.Visible = False
            End If
            'Check_REP_MT9.Checked = Convert.ToBoolean(dt.Rows(0)(82).ToString())
            'Check_REP_MT10.Checked = Convert.ToBoolean(dt.Rows(0)(83).ToString())
            'Check_REP_MT11.Checked = Convert.ToBoolean(dt.Rows(0)(84).ToString())
            'Check_REP_MT12.Checked = Convert.ToBoolean(dt.Rows(0)(85).ToString())


            'Check_SETT.Checked = Convert.ToBoolean(dt.Rows(0)(86).ToString())
            If Convert.ToBoolean(dt.Rows(0)(86).ToString()) = True Then
                SETT.Visible = True
            Else
                SETT.Visible = False
            End If
            'Check_SETT1.Checked = Convert.ToBoolean(dt.Rows(0)(87).ToString())
            If Convert.ToBoolean(dt.Rows(0)(87).ToString()) = True Then
                SETT1.Visible = True
            Else
                SETT1.Visible = False
            End If
            'Check_SETT2.Checked = Convert.ToBoolean(dt.Rows(0)(88).ToString())
            If Convert.ToBoolean(dt.Rows(0)(88).ToString()) = True Then
                SETT2.Visible = True
            Else
                SETT2.Visible = False
            End If
            'Check_SETT3.Checked = Convert.ToBoolean(dt.Rows(0)(89).ToString())
            'If Convert.ToBoolean(dt.Rows(0)(89).ToString()) = True Then
            '    SETT3.Visible = True
            'Else
            '    SETT3.Visible = False
            'End If
            'Check_SETT4.Checked = Convert.ToBoolean(dt.Rows(0)(90).ToString())
            'Check_SETT5.Checked = Convert.ToBoolean(dt.Rows(0)(91).ToString())
            'Check_SETT6.Checked = Convert.ToBoolean(dt.Rows(0)(92).ToString())
            'Check_SETT7.Checked = Convert.ToBoolean(dt.Rows(0)(93).ToString())

        End If
    End Sub

  
    Private Sub REP_MT7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles REP_MT7.Click
        Dim F As New FRM_REP_INV_DELETE
        F.MdiParent = Me
        F.Show()

    End Sub

    Private Sub REP_MT8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles REP_MT8.Click
        Dim F As New FRM_REP_INV_UPDATE
        F.MdiParent = Me
        F.Show()
    End Sub
End Class