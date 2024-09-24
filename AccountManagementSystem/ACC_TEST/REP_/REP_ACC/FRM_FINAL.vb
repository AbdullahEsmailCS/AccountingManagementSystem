Public Class FRM_FINAL
    Dim CLS_DAY_ As New CLS_DAY
    Dim CLS_ITEME_ As New CLS_ITEME
    Dim TOT__ As Double = 0
    Dim dt As New DataTable
    Private Sub FRM_FINAL_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            DTP1.Value = Today
            DTP2.Value = Today




            With dt
                .Columns.Add("الرمز")
                .Columns.Add("الاسم")
                .Columns.Add("مدين")
                .Columns.Add("دائن")
                '.Columns.Add("Balance")
                .Columns.Add("مجموع المدين")
                .Columns.Add("مجموع الدائن")
                .Columns.Add("الفرق")
            End With
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub
    Sub all_()





        '---------------------------------------------
        dt.Rows.Add("", "حساب  المتاجرة")
        Dim DT1 As New DataTable
        DT1.Clear()
        'DT1 = CLS_EN000_.END_ITEME()
        'If DT1.Rows.Count > 0 Then
        '    TOTAL_END = Val(DT1.Rows(0)(0).ToString())
        'End If
        Dim mm_M As Double = 0
        Dim dd_M As Double = Val(TXT_END_ITEME.Text)
        'dd_M = Val(dd_M) + Val(TOTAL_END)
        '---------------------------------------------"0.00"
        dt.Rows.Add("", "بضاعة اخر المدة", 0, Val(TXT_END_ITEME.Text).ToString("0.00"), 0)
        '-----------------------------------------------
        Dim dt2 As New DataTable
        dt2.Clear()
        '         0             1                  2               3                4               5                  6                        7                    8
        'dbo.ac000.Code, dbo.ac000.Name, SUM(dbo.en000.Debit) AS Debite, SUM(dbo.en000.Credit)
        dt2 = CLS_DAY_.final__(3, DTP1.Value.ToShortDateString(), DTP2.Value.ToShortDateString())
        If dt2.Rows.Count > 0 Then
            For i As Integer = 0 To dt2.Rows.Count - 1
                Dim bal_ As Double = Val(dt2.Rows(i)(2).ToString()) - Val(dt2.Rows(i)(3).ToString())

                dt.Rows.Add(dt2.Rows(i)(0).ToString(), dt2.Rows(i)(1).ToString(), Val(dt2.Rows(i)(2).ToString()).ToString("0.00"), Val(dt2.Rows(i)(3).ToString()).ToString("0.00"))
                mm_M = mm_M + Val(dt2.Rows(i)(2).ToString())
                dd_M = dd_M + Val(dt2.Rows(i)(3).ToString())
            Next


        End If
        'FRKMTAG = Val(mm) - Val(dd)
        Dim FRK_M As Double = Val(mm_M) - Val(dd_M)
        dt.Rows.Add("", "مجاميع المتاجرة", 0, 0, mm_M.ToString("0.00"), dd_M.ToString("0.00"), FRK_M.ToString("0.00"))

        'dt.Rows.Add("", "الفرق", 0, 0, 0, 0, 0, FRK_M)
        '-----------------------------------------------
        dt.Rows.Add(" ######### ", " ######### ", " #########", " #########", " #########", " #########", " #########")
        dt.Rows.Add("", "حساب الارباح والخسائر")
        Dim mm_A As Double = 0
        Dim dd_A As Double = 0
        If Val(FRK_M) > 0 Then
            dt.Rows.Add("", "مجمل خسارة ", FRK_M.ToString("0.00"))
            mm_A = mm_A + FRK_M
        Else
            dt.Rows.Add("", "مجمل الربح ", 0, -1 * FRK_M.ToString("0.00"))
            dd_A = dd_A + FRK_M * -1
        End If
        'FRKMTAG = Val(dd)





        Dim dt3 As New DataTable
        dt3.Clear()
        '         0             1                  2               3                4               5                  6                        7                    8
        'dbo.ac000.Code, dbo.ac000.Name, SUM(dbo.en000.Debit) AS Debite, SUM(dbo.en000.Credit)
        dt3 = CLS_DAY_.final__(2, DTP1.Value.ToShortDateString(), DTP2.Value.ToShortDateString())
        If dt3.Rows.Count > 0 Then
            For i As Integer = 0 To dt3.Rows.Count - 1
                'Dim bal_ As Double = Val(dt3.Rows(i)(2).ToString()) - Val(dt3.Rows(i)(3).ToString())

                dt.Rows.Add(dt3.Rows(i)(0).ToString(), dt3.Rows(i)(1).ToString(), Val(dt3.Rows(i)(2).ToString()).ToString("0.00"), Val(dt3.Rows(i)(3).ToString()).ToString("0.00"))
                mm_A = mm_A + Val(dt3.Rows(i)(2).ToString())
                dd_A = dd_A + Val(dt3.Rows(i)(3).ToString())
            Next


        End If

        Dim FRK_A As Double = Val(mm_A) - Val(dd_A)
        dt.Rows.Add("", "مجاميع الارباح والخسائر", 0, 0, mm_A.ToString("0.00"), dd_M.ToString("0.00"), FRK_A.ToString("0.00"))
        '-----------------------------------------------
        dt.Rows.Add(" ######### ", " ######### ", " #########", " #########", " #########", " #########", " #########")
        dt.Rows.Add("", "الميزانية العمومية")
        Dim mm_B As Double = 0
        Dim dd_B As Double = 0
        If Val(FRK_M) > 0 Then
            dt.Rows.Add("", " خسارة ", FRK_A.ToString("0.00"))
            mm_B = mm_B + FRK_A
        Else
            dt.Rows.Add("", " الربح ", 0, (Val(FRK_A) * -1).ToString("0.00"))
            dd_B = dd_B + FRK_A * -1
        End If

        Dim dt4 As New DataTable
        dt4.Clear()
        '         0             1                  2               3                4               5                  6                        7                    8
        'dbo.ac000.Code, dbo.ac000.Name, SUM(dbo.en000.Debit) AS Debite, SUM(dbo.en000.Credit)
        dt4 = CLS_DAY_.final__(1, DTP1.Value.ToShortDateString(), DTP2.Value.ToShortDateString())
        If dt4.Rows.Count > 0 Then
            For i As Integer = 0 To dt4.Rows.Count - 1
                'Dim bal_ As Double = Val(dt4.Rows(i)(2).ToString()) - Val(dt4.Rows(i)(3).ToString())

                dt.Rows.Add(dt4.Rows(i)(0).ToString(), dt4.Rows(i)(1).ToString(), Val(dt4.Rows(i)(2).ToString()).ToString("0.00"), Val(dt4.Rows(i)(3).ToString()).ToString("0.00"))
                mm_B = mm_B + Val(dt4.Rows(i)(2).ToString())
                dd_B = dd_B + Val(dt4.Rows(i)(3).ToString())
            Next


        End If
        dt.Rows.Add("", "بضاعة اخر المدة", Val(TXT_END_ITEME.Text).ToString("0.00"), 0, 0)
        mm_B = mm_B + Val(Val(TXT_END_ITEME.Text))
        Dim FRK_B As Double = Val(mm_B) - Val(dd_B)
        dt.Rows.Add("", "مجاميع  الميزانية", 0, 0, mm_B.ToString("0.00"), dd_B.ToString("0.00"), FRK_B.ToString("0.00"))
        DGV.DataSource = dt
        '-----------------------------------------------



    End Sub

    Private Sub طباعةToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles طباعةToolStripMenuItem.Click
        Try


            TXT_END_ITEME.Text = "0"
            dt.Clear()
            TXT_END_ITEME.Text = "0"
            ITEME_END()
            If Radio_E.Checked = True Then
                TXT_END_ITEME.Text = TXT_END.Text
            Else
                TXT_END_ITEME.Text = TOT__.ToString("0.00")
            End If

            If CMB_TYPE.Text = "المتاجرة" Then

                _MM()
            ElseIf CMB_TYPE.Text = "الارباح والخسائر" Then
                EXPEN_()
            ElseIf CMB_TYPE.Text = "الميزانية" Then
                BUDJET__()
            Else
                all_()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub
    Sub ITEME_END()
        Dim COUNT__ As Integer = 0
        TOT__ = 0

        Dim DT_ITEME As New DataTable
        DT_ITEME.Clear()
        DT_ITEME = CLS_ITEME_.ITEME_END_between(DTP1.Value.ToShortDateString(), DTP2.Value.ToShortDateString())
        If DT_ITEME.Rows.Count > 0 Then
            DGV_END.RowCount = DT_ITEME.Rows.Count
            For I As Integer = 0 To DT_ITEME.Rows.Count - 1


                Dim QT_ As Double = Val(DT_ITEME.Rows(I)(2).ToString())
                Dim AVG__ As Double = Val(DT_ITEME.Rows(I)(3).ToString())
                Dim LAST_ As Double = Val(DT_ITEME.Rows(I)(4).ToString())


                DGV_END.Rows(COUNT__).Cells(0).Value = DT_ITEME.Rows(I)(0).ToString()
                DGV_END.Rows(COUNT__).Cells(1).Value = DT_ITEME.Rows(I)(1).ToString()
                DGV_END.Rows(COUNT__).Cells(2).Value = QT_
                DGV_END.Rows(COUNT__).Cells(3).Value = AVG__
                DGV_END.Rows(COUNT__).Cells(4).Value = LAST_




                If CMB_PRICE.Text = "متوسط" Then
                    DGV_END.Rows(COUNT__).Cells(5).Value = Val(QT_) * Val(AVG__)
                Else
                    DGV_END.Rows(COUNT__).Cells(5).Value = Val(QT_) * Val(LAST_)
                End If

                TOT__ = Val(TOT__) + Val(DGV_END.Rows(COUNT__).Cells(5).Value)

                COUNT__ = COUNT__ + 1
            Next


        End If
    End Sub
    Sub BUDJET__()




        'Dim dt As New DataTable


        'With dt
        '    .Columns.Add("الرمز")
        '    .Columns.Add("الاسم")
        '    .Columns.Add("مدين")
        '    .Columns.Add("دائن")
        '    '.Columns.Add("Balance")
        '    .Columns.Add("مجموع المدين")
        '    .Columns.Add("مجموع الدائن")
        '    .Columns.Add("الفرق")
        'End With


        '---------------------------------------------
        'dt.Rows.Add("", "حساب  المتاجرة")
        Dim DT1 As New DataTable
        DT1.Clear()
        'DT1 = CLS_EN000_.END_ITEME()
        'If DT1.Rows.Count > 0 Then
        '    TOTAL_END = Val(DT1.Rows(0)(0).ToString())
        'End If
        Dim mm_M As Double = 0
        Dim dd_M As Double = Val(TXT_END_ITEME.Text)
        'dd_M = Val(dd_M) + Val(TOTAL_END)
        '---------------------------------------------"0.00"
        'dt.Rows.Add("", "بضاعة اخر المدة", 0, Val(TXT_END_ITEME.Text).ToString("0.00"), 0)
        '-----------------------------------------------
        Dim dt2 As New DataTable
        dt2.Clear()
        '         0             1                  2               3                4               5                  6                        7                    8
        'dbo.ac000.Code, dbo.ac000.Name, SUM(dbo.en000.Debit) AS Debite, SUM(dbo.en000.Credit)
        dt2 = CLS_DAY_.final__(3, DTP1.Value.ToShortDateString(), DTP2.Value.ToShortDateString())
        If dt2.Rows.Count > 0 Then
            For i As Integer = 0 To dt2.Rows.Count - 1
                Dim bal_ As Double = Val(dt2.Rows(i)(2).ToString()) - Val(dt2.Rows(i)(3).ToString())

                'dt.Rows.Add(dt2.Rows(i)(0).ToString(), dt2.Rows(i)(1).ToString(), Val(dt2.Rows(i)(2).ToString()).ToString("0.00"), Val(dt2.Rows(i)(3).ToString()).ToString("0.00"))
                mm_M = mm_M + Val(dt2.Rows(i)(2).ToString())
                dd_M = dd_M + Val(dt2.Rows(i)(3).ToString())
            Next


        End If
        'FRKMTAG = Val(mm) - Val(dd)
        Dim FRK_M As Double = Val(mm_M) - Val(dd_M)
        'dt.Rows.Add("", "مجاميع المتاجرة", 0, 0, mm_M.ToString("0.00"), dd_M.ToString("0.00"), FRK_M.ToString("0.00"))

        'dt.Rows.Add("", "الفرق", 0, 0, 0, 0, 0, FRK_M)
        '-----------------------------------------------
        'dt.Rows.Add(" ######### ", " ######### ", " #########", " #########", " #########", " #########", " #########")
        'dt.Rows.Add("", "حساب الارباح والخسائر")
        Dim mm_A As Double = 0
        Dim dd_A As Double = 0
        If Val(FRK_M) > 0 Then
            'dt.Rows.Add("", "مجمل خسارة ", FRK_M.ToString("0.00"))
            mm_A = mm_A + FRK_M
        Else
            'dt.Rows.Add("", "مجمل الربح ", 0, -1 * FRK_M.ToString("0.00"))
            dd_A = dd_A + FRK_M * -1
        End If
        'FRKMTAG = Val(dd)





        Dim dt3 As New DataTable
        dt3.Clear()
        '         0             1                  2               3                4               5                  6                        7                    8
        'dbo.ac000.Code, dbo.ac000.Name, SUM(dbo.en000.Debit) AS Debite, SUM(dbo.en000.Credit)
        dt3 = CLS_DAY_.final__(2, DTP1.Value.ToShortDateString(), DTP2.Value.ToShortDateString())
        If dt3.Rows.Count > 0 Then
            For i As Integer = 0 To dt3.Rows.Count - 1
                'Dim bal_ As Double = Val(dt3.Rows(i)(2).ToString()) - Val(dt3.Rows(i)(3).ToString())

                'dt.Rows.Add(dt3.Rows(i)(0).ToString(), dt3.Rows(i)(1).ToString(), Val(dt3.Rows(i)(2).ToString()).ToString("0.00"), Val(dt3.Rows(i)(3).ToString()).ToString("0.00"))
                mm_A = mm_A + Val(dt3.Rows(i)(2).ToString())
                dd_A = dd_A + Val(dt3.Rows(i)(3).ToString())
            Next


        End If

        Dim FRK_A As Double = Val(mm_A) - Val(dd_A)
        'dt.Rows.Add("", "مجاميع الارباح والخسائر", 0, 0, mm_A.ToString("0.00"), dd_M.ToString("0.00"), FRK_A.ToString("0.00"))
        '-----------------------------------------------
        'dt.Rows.Add(" ######### ", " ######### ", " #########", " #########", " #########", " #########", " #########")
        dt.Rows.Add("", "الميزانية العمومية")
        Dim mm_B As Double = 0
        Dim dd_B As Double = 0
        If Val(FRK_M) > 0 Then
            dt.Rows.Add("", " خسارة ", FRK_A.ToString("0.00"))
            mm_B = mm_B + FRK_A
        Else
            dt.Rows.Add("", " الربح ", 0, (Val(FRK_A) * -1).ToString("0.00"))
            dd_B = dd_B + FRK_A * -1
        End If

        Dim dt4 As New DataTable
        dt4.Clear()
        '         0             1                  2               3                4               5                  6                        7                    8
        'dbo.ac000.Code, dbo.ac000.Name, SUM(dbo.en000.Debit) AS Debite, SUM(dbo.en000.Credit)
        dt4 = CLS_DAY_.final__(1, DTP1.Value.ToShortDateString(), DTP2.Value.ToShortDateString())
        If dt4.Rows.Count > 0 Then
            For i As Integer = 0 To dt4.Rows.Count - 1
                'Dim bal_ As Double = Val(dt4.Rows(i)(2).ToString()) - Val(dt4.Rows(i)(3).ToString())

                dt.Rows.Add(dt4.Rows(i)(0).ToString(), dt4.Rows(i)(1).ToString(), Val(dt4.Rows(i)(2).ToString()).ToString("0.00"), Val(dt4.Rows(i)(3).ToString()).ToString("0.00"))
                mm_B = mm_B + Val(dt4.Rows(i)(2).ToString())
                dd_B = dd_B + Val(dt4.Rows(i)(3).ToString())
            Next


        End If
        dt.Rows.Add("", "بضاعة اخر المدة", Val(TXT_END_ITEME.Text).ToString("0.00"), 0, 0)
        mm_B = mm_B + Val(Val(TXT_END_ITEME.Text))
        Dim FRK_B As Double = Val(mm_B) - Val(dd_B)
        dt.Rows.Add("", "مجاميع  الميزانية", 0, 0, mm_B.ToString("0.00"), dd_B.ToString("0.00"), FRK_B.ToString("0.00"))
        DGV.DataSource = dt
        '-----------------------------------------------



    End Sub

    Sub EXPEN_()

        'Dim dt As New DataTable


        'With dt
        '    .Columns.Add("الرمز")
        '    .Columns.Add("الاسم")
        '    .Columns.Add("مدين")
        '    .Columns.Add("دائن")
        '    '.Columns.Add("Balance")
        '    .Columns.Add("مجموع المدين")
        '    .Columns.Add("مجموع الدائن")
        '    .Columns.Add("الفرق")
        'End With


        '---------------------------------------------
        'dt.Rows.Add("", "حساب  المتاجرة")
        Dim DT1 As New DataTable
        DT1.Clear()
        'DT1 = CLS_EN000_.END_ITEME()
        'If DT1.Rows.Count > 0 Then
        '    TOTAL_END = Val(DT1.Rows(0)(0).ToString())
        'End If
        Dim mm_M As Double = 0
        Dim dd_M As Double = Val(TXT_END_ITEME.Text)
        'dd_M = Val(dd_M) + Val(TOTAL_END)
        '---------------------------------------------"0.00"
        'dt.Rows.Add("", "بضاعة اخر المدة", 0, Val(TXT_END_ITEME.Text).ToString("0.00"), 0)
        '-----------------------------------------------
        Dim dt2 As New DataTable
        dt2.Clear()
        '         0             1                  2               3                4               5                  6                        7                    8
        'dbo.ac000.Code, dbo.ac000.Name, SUM(dbo.en000.Debit) AS Debite, SUM(dbo.en000.Credit)
        dt2 = CLS_DAY_.final__(3, DTP1.Value.ToShortDateString(), DTP2.Value.ToShortDateString())
        If dt2.Rows.Count > 0 Then
            For i As Integer = 0 To dt2.Rows.Count - 1
                Dim bal_ As Double = Val(dt2.Rows(i)(2).ToString()) - Val(dt2.Rows(i)(3).ToString())

                'dt.Rows.Add(dt2.Rows(i)(0).ToString(), dt2.Rows(i)(1).ToString(), Val(dt2.Rows(i)(2).ToString()).ToString("0.00"), Val(dt2.Rows(i)(3).ToString()).ToString("0.00"))
                mm_M = mm_M + Val(dt2.Rows(i)(2).ToString())
                dd_M = dd_M + Val(dt2.Rows(i)(3).ToString())
            Next


        End If
        'FRKMTAG = Val(mm) - Val(dd)
        Dim FRK_M As Double = Val(mm_M) - Val(dd_M)
        'dt.Rows.Add("", "مجاميع المتاجرة", 0, 0, mm_M.ToString("0.00"), dd_M.ToString("0.00"), FRK_M.ToString("0.00"))

        'dt.Rows.Add("", "الفرق", 0, 0, 0, 0, 0, FRK_M)
        '-----------------------------------------------
        'dt.Rows.Add(" ######### ", " ######### ", " #########", " #########", " #########", " #########", " #########")
        dt.Rows.Add("", "حساب الارباح والخسائر")
        Dim mm_A As Double = 0
        Dim dd_A As Double = 0
        If Val(FRK_M) > 0 Then
            dt.Rows.Add("", "مجمل خسارة ", FRK_M.ToString("0.00"))
            mm_A = mm_A + FRK_M
        Else
            dt.Rows.Add("", "مجمل الربح ", 0, -1 * FRK_M.ToString("0.00"))
            dd_A = dd_A + FRK_M * -1
        End If
        'FRKMTAG = Val(dd)





        Dim dt3 As New DataTable
        dt3.Clear()
        '         0             1                  2               3                4               5                  6                        7                    8
        'dbo.ac000.Code, dbo.ac000.Name, SUM(dbo.en000.Debit) AS Debite, SUM(dbo.en000.Credit)
        dt3 = CLS_DAY_.final__(2, DTP1.Value.ToShortDateString(), DTP2.Value.ToShortDateString())
        If dt3.Rows.Count > 0 Then
            For i As Integer = 0 To dt3.Rows.Count - 1
                'Dim bal_ As Double = Val(dt3.Rows(i)(2).ToString()) - Val(dt3.Rows(i)(3).ToString())

                dt.Rows.Add(dt3.Rows(i)(0).ToString(), dt3.Rows(i)(1).ToString(), Val(dt3.Rows(i)(2).ToString()).ToString("0.00"), Val(dt3.Rows(i)(3).ToString()).ToString("0.00"))
                mm_A = mm_A + Val(dt3.Rows(i)(2).ToString())
                dd_A = dd_A + Val(dt3.Rows(i)(3).ToString())
            Next


        End If

        Dim FRK_A As Double = Val(mm_A) - Val(dd_A)
        dt.Rows.Add("", "مجاميع الارباح والخسائر", 0, 0, mm_A.ToString("0.00"), dd_M.ToString("0.00"), FRK_A.ToString("0.00"))

        DGV.DataSource = dt
    End Sub
    Sub _MM()


        'Dim dt As New DataTable


        'With dt
        '    .Columns.Add("الرمز")
        '    .Columns.Add("الاسم")
        '    .Columns.Add("مدين")
        '    .Columns.Add("دائن")
        '    '.Columns.Add("Balance")
        '    .Columns.Add("مجموع المدين")
        '    .Columns.Add("مجموع الدائن")
        '    .Columns.Add("الفرق")
        'End With


        '---------------------------------------------
        dt.Rows.Add("", "حساب  المتاجرة")
        Dim DT1 As New DataTable
        DT1.Clear()
        'DT1 = CLS_EN000_.END_ITEME()
        'If DT1.Rows.Count > 0 Then
        '    TOTAL_END = Val(DT1.Rows(0)(0).ToString())
        'End If
        Dim mm_M As Double = 0
        Dim dd_M As Double = Val(TXT_END_ITEME.Text)
        'dd_M = Val(dd_M) + Val(TOTAL_END)
        '---------------------------------------------"0.00"
        dt.Rows.Add("", "بضاعة اخر المدة", 0, Val(TXT_END_ITEME.Text).ToString("0.00"), 0)
        '-----------------------------------------------
        Dim dt2 As New DataTable
        dt2.Clear()
        '         0             1                  2               3                4               5                  6                        7                    8
        'dbo.ac000.Code, dbo.ac000.Name, SUM(dbo.en000.Debit) AS Debite, SUM(dbo.en000.Credit)
        dt2 = CLS_DAY_.final__(3, DTP1.Value.ToShortDateString(), DTP2.Value.ToShortDateString())
        If dt2.Rows.Count > 0 Then
            For i As Integer = 0 To dt2.Rows.Count - 1
                Dim bal_ As Double = Val(dt2.Rows(i)(2).ToString()) - Val(dt2.Rows(i)(3).ToString())

                dt.Rows.Add(dt2.Rows(i)(0).ToString(), dt2.Rows(i)(1).ToString(), Val(dt2.Rows(i)(2).ToString()).ToString("0.00"), Val(dt2.Rows(i)(3).ToString()).ToString("0.00"))
                mm_M = mm_M + Val(dt2.Rows(i)(2).ToString())
                dd_M = dd_M + Val(dt2.Rows(i)(3).ToString())
            Next


        End If
        'FRKMTAG = Val(mm) - Val(dd)
        Dim FRK_M As Double = Val(mm_M) - Val(dd_M)
        dt.Rows.Add("", "مجاميع المتاجرة", 0, 0, mm_M.ToString("0.00"), dd_M.ToString("0.00"), FRK_M.ToString("0.00"))
        DGV.DataSource = dt
    End Sub

    Private Sub CMB_TYPE_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles CMB_TYPE.KeyPress
        e.Handled = True
    End Sub

    Private Sub CMB_TYPE_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CMB_TYPE.SelectedIndexChanged
        Try

            CLEARE__()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub CMB_PRICE_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles CMB_PRICE.KeyPress
        e.Handled = True
    End Sub

    
    Private Sub CMB_PRICE_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CMB_PRICE.SelectedIndexChanged
        Try

            CLEARE__()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub TXT_END_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TXT_END.KeyPress
        If (e.KeyChar >= "a" And e.KeyChar <= "z") Or (e.KeyChar >= "A" And e.KeyChar <= "Z") Or (e.KeyChar >= "ا" And e.KeyChar <= "ي") Then
            e.Handled = True
        End If
    End Sub

    Private Sub TXT_END_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TXT_END.TextChanged
        Try

            CLEARE__()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub DTP1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DTP1.Click
        Try

            CLEARE__()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub DTP2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DTP2.Click
        Try

            CLEARE__()
        Catch ex As Exception

        End Try
    End Sub
    Sub CLEARE__()
        dt.Clear()
    End Sub

    Private Sub Radio_E_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Radio_E.CheckedChanged
        Try

            CLEARE__()
            DGV_END.Rows.Clear()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Radio_P_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Radio_P.CheckedChanged
        Try

            CLEARE__()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub ToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem1.Click
        Try
            Try





                Dim oldCI As System.Globalization.CultureInfo = _
    System.Threading.Thread.CurrentThread.CurrentCulture
                System.Threading.Thread.CurrentThread.CurrentCulture = _
                    New System.Globalization.CultureInfo("en-US")

                'System.Threading.Thread.CurrentThread.CurrentCulture = oldCI

                '        If Not (System.Threading.Thread.CurrentThread.CurrentCulture.LCID = _
                'New System.Globalization.CultureInfo("en-US").LCID) Then
                Dim ExcelApp1 As Object, ExcelBook As Object
                Dim ExcelSheet As Object
                'Dim ii As Integer = 1
                'Dim jj As Integer = 1

                'ExcelApp1 = CreateObject(ExcelFormatOptions)
                ExcelApp1 = CreateObject("Excel.Application")
                ExcelBook = ExcelApp1.WorkBooks.Add
                System.Threading.Thread.CurrentThread.CurrentCulture = oldCI
                ExcelSheet = ExcelBook.WorkSheets(1)

                With ExcelSheet

                    For i = 1 To Me.DGV_END.RowCount
                        .cells(i + 1, 1) = Me.DGV_END.Rows(i - 1).Cells(0).Value

                        For j = 0 To DGV_END.Columns.Count - 1
                            .cells(j + 1) = DGV_END.Columns(j).HeaderText
                            .cells(i + 1, j + 1) = DGV_END.Rows(i - 1).Cells(j).Value

                        Next

                    Next

                End With

                ExcelApp1.Visible = True
                '
                ExcelSheet = Nothing
                ExcelBook = Nothing
                ExcelApp1 = Nothing


            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
        Catch ex As Exception

        End Try
    End Sub

    Private Sub جديدToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles جديدToolStripMenuItem.Click
        Try



            Dim dt As New DataTable
            With dt
                .Columns.Add("CODE")
                .Columns.Add("ACCOUNT")
                .Columns.Add("D")
                .Columns.Add("C")
                .Columns.Add("DEF")
                .Columns.Add("from")
                .Columns.Add("to")
            End With

            Dim dt1 As DateTime = DTP1.Value.ToShortDateString()
            Dim dt2 As DateTime = DTP2.Value.ToShortDateString()
            '-------------------------------------------------------
            For I As Integer = 0 To DGV.Rows.Count - 1

                dt.Rows.Add(DGV.Rows(I).Cells(0).Value, DGV.Rows(I).Cells(1).Value, DGV.Rows(I).Cells(2).Value, DGV.Rows(I).Cells(3).Value, DGV.Rows(I).Cells(6).Value, dt1, dt2)


            Next
            '-------------------------------------------------------
            Dim rptDoc As CrystalDecisions.CrystalReports.Engine.ReportDocument
            rptDoc = New Crystal_END_ACCOUNT

            rptDoc.SetDataSource(dt)


            Dim f As New FRM_PRINT
            f.CrystalReportViewer1.ReportSource = rptDoc


            f.ShowDialog()
        Catch ex As Exception

        End Try
    End Sub
End Class