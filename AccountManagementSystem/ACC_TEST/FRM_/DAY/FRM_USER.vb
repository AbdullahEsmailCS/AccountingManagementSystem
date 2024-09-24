Public Class FRM_USER

    Dim CLS_USER_ As New CLS_USER
    Dim ClS_TYPE_BILL_ As New ClS_TYPE_BILL
    Dim ClS_TYPE_CASH_ As New ClS_TYPE_CASH
    Dim US00_BT_ As New US00_BT
    Dim CLS_SHOW_USE_ As New CLS_SHOW_USE
    Private Sub FRM_CURRENCY_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try

            MAX_1()
            add_bt()
            add_et()

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub
    Sub add_et()
        Dim count_ As Integer = 0
        Dim dt As New DataTable
        dt.Clear()
        dt = ClS_TYPE_CASH_.SHOW_
        If dt.Rows.Count > 0 Then
            DGV_ET000.RowCount = dt.Rows.Count
            For i As Integer = 0 To dt.Rows.Count - 1
                DGV_ET000.Rows(count_).Cells(0).Value = dt.Rows(i)(0).ToString()
                DGV_ET000.Rows(count_).Cells(1).Value = dt.Rows(i)(1).ToString()
                count_ = count_ + 1
            Next
        End If
    End Sub
    Sub add_bt()
        Dim count_ As Integer = 0
        Dim dt As New DataTable
        dt.Clear()
        dt = ClS_TYPE_BILL_.SHOW_
        If dt.Rows.Count > 0 Then
            DGV_BT000.RowCount = dt.Rows.Count
            For i As Integer = 0 To dt.Rows.Count - 1
                DGV_BT000.Rows(count_).Cells(0).Value = dt.Rows(i)(0).ToString()
                DGV_BT000.Rows(count_).Cells(1).Value = dt.Rows(i)(1).ToString()
                count_ = count_ + 1
            Next
        End If
    End Sub
    Sub MAX_1()
        Dim DT As New DataTable
        DT.Clear()
        DT = CLS_USER_.MAX_1()
        If DT.Rows.Count > 0 Then
            TXT_ID.Text = DT.Rows(0)(0).ToString()
        End If
    End Sub
    Sub MAX_()
        Dim DT As New DataTable
        DT.Clear()
        DT = CLS_USER_.MAX_()
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
            DT = CLS_USER_.MAX_()
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
            DT = CLS_USER_.MIN_()
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
        DT = CLS_USER_.MIN_()
        If DT.Rows.Count > 0 Then
            TXT_ID.Text = DT.Rows(0)(0).ToString()
        End If
    End Sub

    Private Sub جديدToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles جديدToolStripMenuItem.Click
        Try
            MAX_1()

            TXT_NAME.Text = Nothing
            TXT_PSS.Text = Nothing



        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub TXT_ID_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TXT_ID.TextChanged
        Try


            SHOW_CUREENCY()

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub
    Sub SHOW_CUREENCY()
        Dim DT As New DataTable
        DT.Clear()
        DT = CLS_USER_.show_(Val(TXT_ID.Text))
        If DT.Rows.Count > 0 Then
            TXT_NAME.Text = DT.Rows(0)(0).ToString()
            Dim sm As New CLS_PS
            Dim show_ac As Double = Val(My.Settings.txt_d)
            'Dim pass_ As Double = sm.GetSerial(DT.Rows(0)(1).ToString())
            'TXT_PSS.Text = pass_
            TXT_GUID.Text = DT.Rows(0)(2).ToString()
        Else
            TXT_NAME.Text = Nothing
            TXT_PSS.Text = Nothing
            TXT_GUID.Text = Nothing
        End If
    End Sub

    Private Sub حفظToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles حفظToolStripMenuItem.Click
        Try


            If TXT_NAME.Text = Nothing Then
                MessageBox.Show(" لايوجد اسم  ", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
            '---------------------------------------------------------------------
            If TXT_PSS.Text = Nothing Then
                MessageBox.Show(" لايوجد  كلمة مرور", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
            '---------------------------------------------------------------------
            Dim sm As New CLS_PS
            Dim serial As Double
            serial = sm.GetSerial(TXT_PSS.Text)
            '---------------------------------------------------------------------
            Dim DT As New DataTable
            DT.Clear()
            DT = CLS_USER_.SEARSH_NAME(TXT_NAME.Text)
            If DT.Rows.Count > 0 Then
                MessageBox.Show(" اسم  موجود من قبل ", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
            '---------------------------------------------------------------------
            CLS_USER_.add_(TXT_NAME.Text, Val(serial))
            show_guid_us000()

            save_bt000()
            save_et000()
            save_show()
            MessageBox.Show("   تمت عملية  الحفظ بنجاح ", "تاكيد", MessageBoxButtons.OK, MessageBoxIcon.Information)


        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub
    Sub save_show()
        CLS_SHOW_USE_.delete_(TXT_GUID.Text)

        CLS_SHOW_USE_.ADD_(TXT_GUID.Text,
                           Convert.ToInt32(Check_FI.Checked),
                           Convert.ToInt32(Check_FI1.Checked),
                           Convert.ToInt32(Check_FI2.Checked),
                           Convert.ToInt32(Check_FI3.Checked),
                           Convert.ToInt32(Check_FI4.Checked),
                           Convert.ToInt32(Check_FI5.Checked),
                           Convert.ToInt32(Check_FI6.Checked),
                           Convert.ToInt32(Check_FI7.Checked),
                           Convert.ToInt32(Check_FI8.Checked),
                           Convert.ToInt32(Check_FI9.Checked),
                           Convert.ToInt32(Check_FI10.Checked),
                           Convert.ToInt32(Check_ACC.Checked),
                           Convert.ToInt32(Check_ACC1.Checked),
                           Convert.ToInt32(Check_ACC2.Checked),
                           Convert.ToInt32(Check_ACC3.Checked),
                           Convert.ToInt32(Check_ACC4.Checked),
                           Convert.ToInt32(Check_ACC5.Checked),
                           Convert.ToInt32(Check_ACC6.Checked),
                           Convert.ToInt32(Check_ACC7.Checked),
                           Convert.ToInt32(Check_ACC8.Checked),
                           Convert.ToInt32(Check_ACC9.Checked),
                           Convert.ToInt32(Check_ACC10.Checked),
                           Convert.ToInt32(Check_ACC11.Checked),
                           Convert.ToInt32(Check_ACC12.Checked),
                           Convert.ToInt32(Check_MT.Checked),
                           Convert.ToInt32(Check_MT1.Checked),
                           Convert.ToInt32(Check_MT2.Checked),
                           Convert.ToInt32(Check_MT3.Checked),
                           Convert.ToInt32(Check_MT4.Checked),
                           Convert.ToInt32(Check_MT5.Checked),
                           Convert.ToInt32(Check_MT6.Checked),
                           Convert.ToInt32(Check_MT7.Checked),
                           Convert.ToInt32(Check_MT8.Checked),
                           Convert.ToInt32(Check_MT9.Checked),
                           Convert.ToInt32(Check_MT10.Checked),
                            Convert.ToInt32(Check_INV.Checked),
                    Convert.ToInt32(Check_INV1.Checked),
                      Convert.ToInt32(Check_INV2.Checked),
                      Convert.ToInt32(Check_INV3.Checked),
                      Convert.ToInt32(Check_INV4.Checked),
                      Convert.ToInt32(Check_INV5.Checked),
                      Convert.ToInt32(Check_INV6.Checked),
                      Convert.ToInt32(Check_INV7.Checked),
                      Convert.ToInt32(Check_INV8.Checked),
                      Convert.ToInt32(Check_INV9.Checked),
                      Convert.ToInt32(Check_INV10.Checked),
                      Convert.ToInt32(Check_INV11.Checked),
                      Convert.ToInt32(Check_INV12.Checked),
                      Convert.ToInt32(Check_INV13.Checked),
                      Convert.ToInt32(Check_INV14.Checked),
                      Convert.ToInt32(Check_INV15.Checked),
                        Convert.ToInt32(Check_EMP.Checked),
                      Convert.ToInt32(Check_EMP1.Checked),
                      Convert.ToInt32(Check_EMP2.Checked),
                      Convert.ToInt32(Check_EMP3.Checked),
                      Convert.ToInt32(Check_EMP4.Checked),
                      Convert.ToInt32(Check_EMP5.Checked),
                      Convert.ToInt32(Check_EMP6.Checked),
                      Convert.ToInt32(Check_EMP7.Checked),
                      Convert.ToInt32(Check_EMP8.Checked),
                      Convert.ToInt32(Check_EMP9.Checked),
                      Convert.ToInt32(Check_EMP10.Checked),
                      Convert.ToInt32(Check_REP_ACC.Checked),
                       Convert.ToInt32(Check_REP_ACC1.Checked),
                      Convert.ToInt32(Check_REP_ACC2.Checked),
                      Convert.ToInt32(Check_REP_ACC3.Checked),
                      Convert.ToInt32(Check_REP_ACC4.Checked),
                      Convert.ToInt32(Check_REP_ACC5.Checked),
                      Convert.ToInt32(Check_REP_ACC6.Checked),
                      Convert.ToInt32(Check_REP_ACC7.Checked),
                      Convert.ToInt32(Check_REP_ACC8.Checked),
                      Convert.ToInt32(Check_REP_ACC9.Checked),
                      Convert.ToInt32(Check_REP_ACC10.Checked),
                        Convert.ToInt32(Check_REP_MT.Checked),
                      Convert.ToInt32(Check_REP_MT1.Checked),
                      Convert.ToInt32(Check_REP_MT2.Checked),
                      Convert.ToInt32(Check_REP_MT3.Checked),
                      Convert.ToInt32(Check_REP_MT4.Checked),
                      Convert.ToInt32(Check_REP_MT5.Checked),
                      Convert.ToInt32(Check_REP_MT6.Checked),
                      Convert.ToInt32(Check_REP_MT7.Checked),
                      Convert.ToInt32(Check_REP_MT8.Checked),
                      Convert.ToInt32(Check_REP_MT9.Checked),
                      Convert.ToInt32(Check_REP_MT10.Checked),
                      Convert.ToInt32(Check_REP_MT11.Checked),
                      Convert.ToInt32(Check_REP_MT12.Checked),
                     Convert.ToInt32(Check_SETT.Checked),
                      Convert.ToInt32(Check_SETT1.Checked),
                      Convert.ToInt32(Check_SETT2.Checked),
                      Convert.ToInt32(Check_SETT3.Checked),
                      Convert.ToInt32(Check_SETT4.Checked),
                      Convert.ToInt32(Check_SETT5.Checked),
                      Convert.ToInt32(Check_SETT6.Checked),
                      Convert.ToInt32(Check_SETT7.Checked))

        'CLS_SHOW_USE_.ADD_(TXT_GUID.Text,
        '              Convert.ToInt32(Check_FI.Checked),
        '              Convert.ToInt32(Check_FI1.Checked),
        '              Convert.ToInt32(Check_FI2.Checked),
        '              Convert.ToInt32(Check_FI3.Checked),
        '              Convert.ToInt32(Check_FI4.Checked),
        '              Convert.ToInt32(Check_FI5.Checked),
        '              Convert.ToInt32(Check_FI6.Checked),
        '              Convert.ToInt32(Check_FI7.Checked),
        '              Convert.ToInt32(Check_FI8.Checked),
        '              Convert.ToInt32(Check_FI9.Checked),
        '              Convert.ToInt32(Check_FI10.Checked),
        '              Convert.ToInt32(Check_ACC.Checked),
        '              Convert.ToInt32(Check_ACC1.Checked),
        '              Convert.ToInt32(Check_ACC2.Checked),
        '              Convert.ToInt32(Check_ACC3.Checked),
        '              Convert.ToInt32(Check_ACC4.Checked),
        '              Convert.ToInt32(Check_ACC5.Checked),
        '              Convert.ToInt32(Check_ACC6.Checked),
        '              Convert.ToInt32(Check_ACC7.Checked),
        '              Convert.ToInt32(Check_ACC8.Checked),
        '              Convert.ToInt32(Check_ACC9.Checked),
        '              Convert.ToInt32(Check_ACC10.Checked),
        '              Convert.ToInt32(Check_ACC11.Checked),
        '              Convert.ToInt32(Check_ACC12.Checked),
        '              Convert.ToInt32(Check_MT.Checked),
        '              Convert.ToInt32(Check_MT1.Checked),
        '              Convert.ToInt32(Check_MT2.Checked),
        '              Convert.ToInt32(Check_MT3.Checked),
        '              Convert.ToInt32(Check_MT4.Checked),
        '              Convert.ToInt32(Check_MT5.Checked),
        '              Convert.ToInt32(Check_MT6.Checked),
        '              Convert.ToInt32(Check_MT7.Checked),
        '              Convert.ToInt32(Check_MT8.Checked),
        '              Convert.ToInt32(Check_MT9.Checked),
        '              Convert.ToInt32(Check_MT10.Checked),
        '              Convert.ToInt32(Check_EMP.Checked),
        '              Convert.ToInt32(Check_EMP1.CheckState),
        '              Convert.ToInt32(Check_EMP2.Checked),
        '              Convert.ToInt32(Check_EMP3.Checked),
        '              Convert.ToInt32(Check_EMP4.Checked),
        '              Convert.ToInt32(Check_EMP5.Checked),
        '              Convert.ToInt32(Check_EMP6.Checked),
        '              Convert.ToInt32(Check_EMP7.Checked),
        '              Convert.ToInt32(Check_EMP8.Checked),
        '              Convert.ToInt32(Check_EMP9.Checked),
        '              Convert.ToInt32(Check_EMP10.Checked),
        '              Convert.ToInt32(Check_INV.Checked),
        '              Convert.ToInt32(Check_INV1.Checked),
        '              Convert.ToInt32(Check_INV2.Checked),
        '              Convert.ToInt32(Check_INV3.Checked),
        '              Convert.ToInt32(Check_INV4.Checked),
        '              Convert.ToInt32(Check_INV5.Checked),
        '              Convert.ToInt32(Check_INV6.Checked),
        '              Convert.ToInt32(Check_INV7.Checked),
        '              Convert.ToInt32(Check_INV8.Checked),
        '              Convert.ToInt32(Check_INV9.Checked),
        '              Convert.ToInt32(Check_INV10.Checked),
        '              Convert.ToInt32(Check_INV11.Checked),
        '              Convert.ToInt32(Check_INV12.Checked),
        '              Convert.ToInt32(Check_INV13.Checked),
        '              Convert.ToInt32(Check_INV14.Checked),
        '              Convert.ToInt32(Check_INV15.Checked),
        '              Convert.ToInt32(Check_REP_ACC.Checked),
        '              Convert.ToInt32(Check_REP_ACC1.Checked),
        '              Convert.ToInt32(Check_REP_ACC2.Checked),
        '              Convert.ToInt32(Check_REP_ACC3.Checked),
        '              Convert.ToInt32(Check_REP_ACC4.Checked),
        '              Convert.ToInt32(Check_REP_ACC5.Checked),
        '              Convert.ToInt32(Check_REP_ACC6.Checked),
        '              Convert.ToInt32(Check_REP_ACC7.Checked),
        '              Convert.ToInt32(Check_REP_ACC8.Checked),
        '              Convert.ToInt32(Check_REP_ACC9.Checked),
        '              Convert.ToInt32(Check_REP_ACC10.Checked),
        '              Convert.ToInt32(Check_REP_MT.Checked),
        '              Convert.ToInt32(Check_REP_MT1.Checked),
        '              Convert.ToInt32(Check_REP_MT2.Checked),
        '              Convert.ToInt32(Check_REP_MT3.Checked),
        '              Convert.ToInt32(Check_REP_MT4.Checked),
        '              Convert.ToInt32(Check_REP_MT5.Checked),
        '              Convert.ToInt32(Check_REP_MT6.Checked),
        '              Convert.ToInt32(Check_REP_MT7.Checked),
        '              Convert.ToInt32(Check_REP_MT8.Checked),
        '              Convert.ToInt32(Check_REP_MT9.Checked),
        '              Convert.ToInt32(Check_REP_MT10.Checked),
        '              Convert.ToInt32(Check_REP_MT11.Checked),
        '              Convert.ToInt32(Check_REP_MT12.Checked),
        '              Convert.ToInt32(Check_SETT.Checked),
        '              Convert.ToInt32(Check_SETT1.Checked),
        '              Convert.ToInt32(Check_SETT2.Checked),
        '              Convert.ToInt32(Check_SETT3.Checked),
        '              Convert.ToInt32(Check_SETT4.Checked),
        '              Convert.ToInt32(Check_SETT5.Checked),
        '              Convert.ToInt32(Check_SETT6.Checked),
        '              Convert.ToInt32(Check_SETT.Checked))


    End Sub
    Sub save_bt000()
        If TXT_GUID.Text <> Nothing Then
            US00_BT_.delete_BT(TXT_GUID.Text)
        End If
        For i As Integer = 0 To DGV_BT000.Rows.Count - 1
            US00_BT_.ADD_Bt(TXT_GUID.Text, DGV_BT000.Rows(i).Cells(0).Value, DGV_BT000.Rows(i).Cells(2).Value, DGV_BT000.Rows(i).Cells(3).Value, DGV_BT000.Rows(i).Cells(4).Value, DGV_BT000.Rows(i).Cells(5).Value, DGV_BT000.Rows(i).Cells(6).Value)
        Next
    End Sub
    Sub save_et000()
        If TXT_GUID.Text <> Nothing Then
            US00_BT_.delete_ET(TXT_GUID.Text)
        End If
        For i As Integer = 0 To DGV_ET000.Rows.Count - 1
            US00_BT_.ADD_ET(TXT_GUID.Text, DGV_ET000.Rows(i).Cells(0).Value, DGV_ET000.Rows(i).Cells(2).Value, DGV_ET000.Rows(i).Cells(3).Value, DGV_ET000.Rows(i).Cells(4).Value, DGV_ET000.Rows(i).Cells(5).Value, DGV_ET000.Rows(i).Cells(6).Value)
        Next
    End Sub
    Sub show_guid_us000()
       
        Dim DT_N As New DataTable
        DT_N.Clear()
        DT_N = CLS_USER_.GUID_us000(Val(TXT_ID.Text))
        If DT_N.Rows.Count > 0 Then
            TXT_GUID.Text = DT_N.Rows(0)(0).ToString()
        Else
            TXT_GUID.Text = Nothing
            Exit Sub
        End If
    End Sub
    Private Sub تعديلToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles تعديلToolStripMenuItem.Click
        Try

            If TXT_GUID.Text = Nothing Then
                MessageBox.Show(" لايوجد اسم ", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
            '---------------------------------------------------------------------

            If TXT_NAME.Text = Nothing Then
                MessageBox.Show(" لايوجد اسم ", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
            '---------------------------------------------------------------------
            If TXT_PSS.Text = Nothing Then
                MessageBox.Show(" لايوجد  كلمة مرور", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
            '---------------------------------------------------------------------

            Dim sm As New CLS_PS
            Dim serial As Double
            serial = sm.GetSerial(TXT_PSS.Text)
            '---------------------------------------------------------------------

            CLS_USER_.UPDATE_(TXT_NAME.Text, Val(serial), TXT_GUID.Text)

            save_bt000()
            save_et000()
            save_show()
            MessageBox.Show("   تمت عملية  التعديل بنجاح ", "تاكيد", MessageBoxButtons.OK, MessageBoxIcon.Information)


        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

   
    Private Sub TXT_GUID_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TXT_GUID.TextChanged
        Try
            If TXT_GUID.Text = Nothing Then
                Exit Sub
            End If
            use_ET000()
            use_bt000()
            use_show()
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
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
            Check_FI.Checked = Convert.ToBoolean(dt.Rows(0)(0).ToString())
            Check_FI1.Checked = Convert.ToBoolean(dt.Rows(0)(1).ToString())
            Check_FI2.Checked = Convert.ToBoolean(dt.Rows(0)(2).ToString())
            Check_FI3.Checked = Convert.ToBoolean(dt.Rows(0)(3).ToString())
            Check_FI4.Checked = Convert.ToBoolean(dt.Rows(0)(4).ToString())
            Check_FI5.Checked = Convert.ToBoolean(dt.Rows(0)(5).ToString())
            Check_FI6.Checked = Convert.ToBoolean(dt.Rows(0)(6).ToString())
            Check_FI7.Checked = Convert.ToBoolean(dt.Rows(0)(7).ToString())
            Check_FI8.Checked = Convert.ToBoolean(dt.Rows(0)(8).ToString())
            Check_FI9.Checked = Convert.ToBoolean(dt.Rows(0)(9).ToString())
            Check_FI10.Checked = Convert.ToBoolean(dt.Rows(0)(10).ToString())


            Check_ACC.Checked = Convert.ToBoolean(dt.Rows(0)(11).ToString())
            Check_ACC1.Checked = Convert.ToBoolean(dt.Rows(0)(12).ToString())
            Check_ACC2.Checked = Convert.ToBoolean(dt.Rows(0)(13).ToString())
            Check_ACC3.Checked = Convert.ToBoolean(dt.Rows(0)(14).ToString())
            Check_ACC4.Checked = Convert.ToBoolean(dt.Rows(0)(15).ToString())
            Check_ACC5.Checked = Convert.ToBoolean(dt.Rows(0)(16).ToString())
            Check_ACC6.Checked = Convert.ToBoolean(dt.Rows(0)(17).ToString())
            Check_ACC7.Checked = Convert.ToBoolean(dt.Rows(0)(18).ToString())
            Check_ACC8.Checked = Convert.ToBoolean(dt.Rows(0)(19).ToString())
            Check_ACC9.Checked = Convert.ToBoolean(dt.Rows(0)(20).ToString())
            Check_ACC10.Checked = Convert.ToBoolean(dt.Rows(0)(21).ToString())
            Check_ACC11.Checked = Convert.ToBoolean(dt.Rows(0)(22).ToString())
            Check_ACC12.Checked = Convert.ToBoolean(dt.Rows(0)(23).ToString())

            Check_MT.Checked = Convert.ToBoolean(dt.Rows(0)(24).ToString())
            Check_MT1.Checked = Convert.ToBoolean(dt.Rows(0)(25).ToString())
            Check_MT2.Checked = Convert.ToBoolean(dt.Rows(0)(26).ToString())
            Check_MT3.Checked = Convert.ToBoolean(dt.Rows(0)(27).ToString())
            Check_MT4.Checked = Convert.ToBoolean(dt.Rows(0)(28).ToString())
            Check_MT5.Checked = Convert.ToBoolean(dt.Rows(0)(29).ToString())
            Check_MT6.Checked = Convert.ToBoolean(dt.Rows(0)(30).ToString())
            Check_MT7.Checked = Convert.ToBoolean(dt.Rows(0)(31).ToString())
            Check_MT8.Checked = Convert.ToBoolean(dt.Rows(0)(32).ToString())
            Check_MT9.Checked = Convert.ToBoolean(dt.Rows(0)(33).ToString())
            Check_MT10.Checked = Convert.ToBoolean(dt.Rows(0)(34).ToString())

            Check_INV.Checked = Convert.ToBoolean(dt.Rows(0)(35).ToString())
            Check_INV1.Checked = Convert.ToBoolean(dt.Rows(0)(36).ToString())
            Check_INV2.Checked = Convert.ToBoolean(dt.Rows(0)(37).ToString())
            Check_INV3.Checked = Convert.ToBoolean(dt.Rows(0)(38).ToString())
            Check_INV4.Checked = Convert.ToBoolean(dt.Rows(0)(39).ToString())
            Check_INV5.Checked = Convert.ToBoolean(dt.Rows(0)(40).ToString())
            Check_INV6.Checked = Convert.ToBoolean(dt.Rows(0)(41).ToString())
            Check_INV7.Checked = Convert.ToBoolean(dt.Rows(0)(42).ToString())
            Check_INV8.Checked = Convert.ToBoolean(dt.Rows(0)(43).ToString())
            Check_INV9.Checked = Convert.ToBoolean(dt.Rows(0)(44).ToString())
            Check_INV10.Checked = Convert.ToBoolean(dt.Rows(0)(45).ToString())
            Check_INV11.Checked = Convert.ToBoolean(dt.Rows(0)(46).ToString())
            Check_INV12.Checked = Convert.ToBoolean(dt.Rows(0)(47).ToString())
            Check_INV13.Checked = Convert.ToBoolean(dt.Rows(0)(48).ToString())
            Check_INV14.Checked = Convert.ToBoolean(dt.Rows(0)(49).ToString())
            Check_INV15.Checked = Convert.ToBoolean(dt.Rows(0)(50).ToString())

            Check_EMP.Checked = Convert.ToBoolean(dt.Rows(0)(51).ToString())
            Check_EMP1.Checked = Convert.ToBoolean(dt.Rows(0)(52).ToString())
            Check_EMP2.Checked = Convert.ToBoolean(dt.Rows(0)(53).ToString())
            Check_EMP3.Checked = Convert.ToBoolean(dt.Rows(0)(54).ToString())
            Check_EMP4.Checked = Convert.ToBoolean(dt.Rows(0)(55).ToString())
            Check_EMP5.Checked = Convert.ToBoolean(dt.Rows(0)(56).ToString())
            Check_EMP6.Checked = Convert.ToBoolean(dt.Rows(0)(57).ToString())
            Check_EMP7.Checked = Convert.ToBoolean(dt.Rows(0)(58).ToString())
            Check_EMP8.Checked = Convert.ToBoolean(dt.Rows(0)(59).ToString())
            Check_EMP9.Checked = Convert.ToBoolean(dt.Rows(0)(60).ToString())
            Check_EMP10.Checked = Convert.ToBoolean(dt.Rows(0)(61).ToString())

            Check_REP_ACC.Checked = Convert.ToBoolean(dt.Rows(0)(62).ToString())
            Check_REP_ACC1.Checked = Convert.ToBoolean(dt.Rows(0)(63).ToString())
            Check_REP_ACC2.Checked = Convert.ToBoolean(dt.Rows(0)(64).ToString())
            Check_REP_ACC3.Checked = Convert.ToBoolean(dt.Rows(0)(65).ToString())
            Check_REP_ACC4.Checked = Convert.ToBoolean(dt.Rows(0)(66).ToString())
            Check_REP_ACC5.Checked = Convert.ToBoolean(dt.Rows(0)(67).ToString())
            Check_REP_ACC6.Checked = Convert.ToBoolean(dt.Rows(0)(68).ToString())
            Check_REP_ACC7.Checked = Convert.ToBoolean(dt.Rows(0)(69).ToString())
            Check_REP_ACC8.Checked = Convert.ToBoolean(dt.Rows(0)(70).ToString())
            Check_REP_ACC9.Checked = Convert.ToBoolean(dt.Rows(0)(71).ToString())
            Check_REP_ACC10.Checked = Convert.ToBoolean(dt.Rows(0)(72).ToString())

            Check_REP_MT.Checked = Convert.ToBoolean(dt.Rows(0)(73).ToString())
            Check_REP_MT1.Checked = Convert.ToBoolean(dt.Rows(0)(74).ToString())
            Check_REP_MT2.Checked = Convert.ToBoolean(dt.Rows(0)(75).ToString())
            Check_REP_MT3.Checked = Convert.ToBoolean(dt.Rows(0)(76).ToString())
            Check_REP_MT4.Checked = Convert.ToBoolean(dt.Rows(0)(77).ToString())
            Check_REP_MT5.Checked = Convert.ToBoolean(dt.Rows(0)(78).ToString())
            Check_REP_MT6.Checked = Convert.ToBoolean(dt.Rows(0)(79).ToString())
            Check_REP_MT7.Checked = Convert.ToBoolean(dt.Rows(0)(80).ToString())
            Check_REP_MT8.Checked = Convert.ToBoolean(dt.Rows(0)(81).ToString())
            Check_REP_MT9.Checked = Convert.ToBoolean(dt.Rows(0)(82).ToString())
            Check_REP_MT10.Checked = Convert.ToBoolean(dt.Rows(0)(83).ToString())
            Check_REP_MT11.Checked = Convert.ToBoolean(dt.Rows(0)(84).ToString())
            Check_REP_MT12.Checked = Convert.ToBoolean(dt.Rows(0)(85).ToString())


            Check_SETT.Checked = Convert.ToBoolean(dt.Rows(0)(86).ToString())
            Check_SETT1.Checked = Convert.ToBoolean(dt.Rows(0)(87).ToString())
            Check_SETT2.Checked = Convert.ToBoolean(dt.Rows(0)(88).ToString())
            Check_SETT3.Checked = Convert.ToBoolean(dt.Rows(0)(89).ToString())
            Check_SETT4.Checked = Convert.ToBoolean(dt.Rows(0)(90).ToString())
            Check_SETT5.Checked = Convert.ToBoolean(dt.Rows(0)(91).ToString())
            Check_SETT6.Checked = Convert.ToBoolean(dt.Rows(0)(92).ToString())
            Check_SETT7.Checked = Convert.ToBoolean(dt.Rows(0)(93).ToString())

        End If
    End Sub
    Sub use_bt000()
        If TXT_GUID.Text = Nothing Then
            Exit Sub
        End If
        Dim count_ As Integer = 0
        Dim dt As New DataTable
        dt.Clear()
        dt = US00_BT_.GUID_BT_(TXT_GUID.Text)
        If dt.Rows.Count > 0 Then
            For i As Integer = 0 To DGV_BT000.Rows.Count - 1
                Dim dt1 As New DataTable
                dt1.Clear()

                'ISINSERT,ISUPDATE,ISDELETE,ISprint ,ISSHOW 
                dt1 = US00_BT_.GUID_BT_us(DGV_BT000.Rows(i).Cells(0).Value.ToString(), TXT_GUID.Text)
                If dt1.Rows.Count > 0 Then
                    DGV_BT000.Rows(i).Cells(2).Value = dt1.Rows(0)(0).ToString()
                    DGV_BT000.Rows(i).Cells(3).Value = dt1.Rows(0)(1).ToString()
                    DGV_BT000.Rows(i).Cells(4).Value = dt1.Rows(0)(2).ToString()
                    DGV_BT000.Rows(i).Cells(5).Value = dt1.Rows(0)(3).ToString()
                    DGV_BT000.Rows(i).Cells(6).Value = dt1.Rows(0)(4).ToString()
                Else
                    DGV_BT000.Rows(i).Cells(2).Value = False
                    DGV_BT000.Rows(i).Cells(3).Value = False
                    DGV_BT000.Rows(i).Cells(4).Value = False
                    DGV_BT000.Rows(i).Cells(5).Value = False
                    DGV_BT000.Rows(i).Cells(6).Value = False
                End If
            Next
        End If
    End Sub
    Sub use_ET000()
        If TXT_GUID.Text = Nothing Then
            Exit Sub
        End If
        Dim count_ As Integer = 0
        Dim dt As New DataTable
        dt.Clear()
        dt = US00_BT_.GUID_ET_(TXT_GUID.Text)
        If dt.Rows.Count > 0 Then
            For i As Integer = 0 To DGV_ET000.Rows.Count - 1
                Dim dt1 As New DataTable
                dt1.Clear()

                'ISINSERT,ISUPDATE,ISDELETE,ISprint ,ISSHOW 
                dt1 = US00_BT_.GUID_ET_us(DGV_ET000.Rows(i).Cells(0).Value.ToString(), TXT_GUID.Text)
                If dt1.Rows.Count > 0 Then
                    DGV_ET000.Rows(i).Cells(2).Value = dt1.Rows(0)(0).ToString()
                    DGV_ET000.Rows(i).Cells(3).Value = dt1.Rows(0)(1).ToString()
                    DGV_ET000.Rows(i).Cells(4).Value = dt1.Rows(0)(2).ToString()
                    DGV_ET000.Rows(i).Cells(5).Value = dt1.Rows(0)(3).ToString()
                    DGV_ET000.Rows(i).Cells(6).Value = dt1.Rows(0)(4).ToString()
                Else
                    DGV_ET000.Rows(i).Cells(2).Value = False
                    DGV_ET000.Rows(i).Cells(3).Value = False
                    DGV_ET000.Rows(i).Cells(4).Value = False
                    DGV_ET000.Rows(i).Cells(5).Value = False
                    DGV_ET000.Rows(i).Cells(6).Value = False
                End If
            Next
        End If
    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then


            For i As Integer = 0 To DGV_ET000.Rows.Count - 1
                DGV_ET000.Rows(i).Cells(2).Value = True
                DGV_ET000.Rows(i).Cells(3).Value = True
                DGV_ET000.Rows(i).Cells(4).Value = True
                DGV_ET000.Rows(i).Cells(5).Value = True
                DGV_ET000.Rows(i).Cells(6).Value = True
            Next

            For ii As Integer = 0 To DGV_BT000.Rows.Count - 1
                DGV_BT000.Rows(ii).Cells(2).Value = True
                DGV_BT000.Rows(ii).Cells(3).Value = True
                DGV_BT000.Rows(ii).Cells(4).Value = True
                DGV_BT000.Rows(ii).Cells(5).Value = True
                DGV_BT000.Rows(ii).Cells(6).Value = True
            Next
        End If
    End Sub

    Private Sub TXT_PSS_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TXT_PSS.KeyPress
        If Not (Asc(e.KeyChar) = 8) Then
            If Not ((Asc(e.KeyChar) >= 97 And Asc(e.KeyChar) <= 122) Or (Asc(e.KeyChar) >= 65 And Asc(e.KeyChar) <= 90)) Then
                e.KeyChar = ChrW(0)
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub TXT_PSS_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TXT_PSS.TextChanged

    End Sub
End Class