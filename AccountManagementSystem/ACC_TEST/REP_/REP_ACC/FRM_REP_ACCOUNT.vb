Public Class FRM_REP_ACCOUNT
    Dim CLS_CURRENCY_ As New CLS_CURRENCY
    Dim CLS_JOB_ As New CLS_JOB
    Dim CLS_DAY_ As New CLS_DAY
    Dim JOB__ As String
    

    Private Sub FRM_REP_ACCOUNT_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Try
            DTP1.Value = Today
            DTP2.Value = Today
            SHOW_JOB()
            SHOW_CURRENCY()
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try

    End Sub
    Sub show_job()
        Dim COUNT__ As Integer = 0
        Dim dt As New DataTable
        dt.Clear()
        dt = CLS_JOB_.ALL__()
        If dt.Rows.Count > 0 Then
            DGV_JOB.RowCount = dt.Rows.Count
            For I As Integer = 0 To dt.Rows.Count - 1
                DGV_JOB.Rows(COUNT__).Cells(0).Value = dt.Rows(I)(0).ToString()
                DGV_JOB.Rows(COUNT__).Cells(1).Value = dt.Rows(I)(1).ToString()
                DGV_JOB.Rows(COUNT__).Cells(2).Value = True
                COUNT__ = COUNT__ + 1
            Next
        End If
    End Sub
    'Sub SHOW_JOB()
    '    Dim DT As New DataTable
    '    DT.Clear()
    '    DT = CLS_JOB_.SELECT_
    '    If DT.Rows.Count > 0 Then
    '        TXT_JOB.Text = DT.Rows(0)(1).ToString()
    '        TXT_GUID_JOB.Text = DT.Rows(0)(2).ToString()
    '    End If
    'End Sub
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

   
 

    Private Sub جديدToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles جديدToolStripMenuItem.Click
        Try
            DTP1.Enabled = False
            DTP2.Enabled = False
            Dim BLANCE__ As Double = 0

            If TXT_GUID_ACCOUNT.Text = Nothing Then
                MessageBox.Show("لايوجد حساب", "نقص", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If

            Dim COUNT_1 As Integer = 0
            Dim COUNT_ As Integer = 1





            Dim MM_B As Double = 0
            Dim DD_B As Double = 0
            Dim FF_B As Double = 0













            '---------------------------------------------------
            Dim MM As Double = 0
            Dim DD As Double = 0
            Dim FF As Double = 0
            DGV_JOB.ReadOnly = True

            DGV_JOB_00()


            DGV_JOB.ReadOnly = False

            Dim F As New FRM_SHOW_REP_ACCOUNT


            '===========================================================================================================================================
            ''الرصيد السابق

            Dim DT_B As New DataTable
            DT_B.Clear()
            DT_B = CLS_DAY_.rep_BEFORE_ACCOUNT(JOB__, DTP1.Value.ToShortDateString(), TXT_GUID_ACCOUNT.Text)
            If DT_B.Rows.Count > 0 Then


                F.DGV_BEFORE.RowCount = DT_B.Rows.Count
                For I As Integer = 0 To DT_B.Rows.Count - 1
                    F.DGV_BEFORE.Rows(COUNT_1).Cells(0).Value = DT_B.Rows(I)(0).ToString()
                    F.DGV_BEFORE.Rows(COUNT_1).Cells(1).Value = DT_B.Rows(I)(1).ToString()
                    F.DGV_BEFORE.Rows(COUNT_1).Cells(2).Value = Convert.ToDateTime(DT_B.Rows(I)(2).ToString()).ToShortDateString()
                    F.DGV_BEFORE.Rows(COUNT_1).Cells(3).Value = DT_B.Rows(I)(13).ToString()
                    'F.DGV.Rows(COUNT_).Cells(4).Value = DT.Rows(I)(14).ToString()
                    'F.DGV.Rows(COUNT_).Cells(5).Value = DT.Rows(I)(15).ToString()
                    ''============================================================================
                    If TXT_GUID_CURRENCY.Text <> DT_B.Rows(I)(20).ToString() Then
                        F.DGV_BEFORE.Rows(COUNT_1).Cells(4).Value = Val(DT_B.Rows(I)(14).ToString()) / Val(TXT_CURRENCY_VAL.Text)

                    Else
                        F.DGV_BEFORE.Rows(COUNT_1).Cells(4).Value = Val(DT_B.Rows(I)(14).ToString()) / Val(DT_B.Rows(I)(22).ToString())

                    End If


                    If TXT_GUID_CURRENCY.Text <> DT_B.Rows(I)(20).ToString() Then
                        F.DGV_BEFORE.Rows(COUNT_1).Cells(5).Value = Val(DT_B.Rows(I)(15).ToString()) / Val(TXT_CURRENCY_VAL.Text)

                    Else
                        F.DGV_BEFORE.Rows(COUNT_1).Cells(5).Value = Val(DT_B.Rows(I)(15).ToString()) / Val(DT_B.Rows(I)(22).ToString())

                    End If


                    BLANCE__ = Val(BLANCE__) + (Val(F.DGV_BEFORE.Rows(COUNT_1).Cells(4).Value) - Val(F.DGV_BEFORE.Rows(COUNT_1).Cells(5).Value))
                    F.DGV_BEFORE.Rows(COUNT_1).Cells(6).Value = BLANCE__.ToString("0.00")

                    ''============================================================================
                    F.DGV_BEFORE.Rows(COUNT_1).Cells(7).Value = DT_B.Rows(I)(16).ToString()

                    F.DGV_BEFORE.Rows(COUNT_1).Cells(8).Value = DT_B.Rows(I)(19).ToString()


                    F.DGV_BEFORE.Rows(COUNT_1).Cells(9).Value = DT_B.Rows(I)(20).ToString()
                    F.DGV_BEFORE.Rows(COUNT_1).Cells(10).Value = DT_B.Rows(I)(21).ToString()
                    F.DGV_BEFORE.Rows(COUNT_1).Cells(11).Value = DT_B.Rows(I)(22).ToString()
                    F.DGV_BEFORE.Rows(COUNT_1).Cells(12).Value = DT_B.Rows(I)(5).ToString()


                    F.DGV_BEFORE.Rows(COUNT_1).Cells(13).Value = (Val(DT_B.Rows(I)(14).ToString()) / Val(DT_B.Rows(I)(22).ToString())).ToString("0.00")
                    F.DGV_BEFORE.Rows(COUNT_1).Cells(14).Value = (Val(DT_B.Rows(I)(15).ToString()) / Val(DT_B.Rows(I)(22).ToString())).ToString("0.00")


                    MM_B = Val(MM_B) + Val(Val(F.DGV_BEFORE.Rows(COUNT_1).Cells(4).Value))
                    DD_B = Val(DD_B) + Val(Val(F.DGV_BEFORE.Rows(COUNT_1).Cells(5).Value))

                    COUNT_1 = COUNT_1 + 1
                Next

            End If

            F.TXT_BEFORE.Text = (Val(MM_B) - Val(DD_B)).ToString("0.00")
            F.DGV.Rows.Add("", "", "", "رصيد سابق", F.TXT_BEFORE.Text)
                '===========================================================================================================================================
                'كشف حساب
                Dim DT As New DataTable
                DT.Clear()
                DT = CLS_DAY_.rep_SEARSH_ACCOUNT(JOB__, DTP1.Value.ToShortDateString(), DTP2.Value.ToShortDateString(), TXT_GUID_ACCOUNT.Text)
                If DT.Rows.Count > 0 Then
                F.DGV.RowCount = DT.Rows.Count + 1

                    For I As Integer = 0 To DT.Rows.Count - 1
                        F.DGV.Rows(COUNT_).Cells(0).Value = DT.Rows(I)(0).ToString()
                        F.DGV.Rows(COUNT_).Cells(1).Value = DT.Rows(I)(1).ToString()
                        F.DGV.Rows(COUNT_).Cells(2).Value = Convert.ToDateTime(DT.Rows(I)(2).ToString()).ToShortDateString()
                        F.DGV.Rows(COUNT_).Cells(3).Value = DT.Rows(I)(13).ToString()
                        'F.DGV.Rows(COUNT_).Cells(4).Value = DT.Rows(I)(14).ToString()
                        'F.DGV.Rows(COUNT_).Cells(5).Value = DT.Rows(I)(15).ToString()
                        ''============================================================================
                        If TXT_GUID_CURRENCY.Text <> DT.Rows(I)(20).ToString() Then
                            F.DGV.Rows(COUNT_).Cells(4).Value = Val(DT.Rows(I)(14).ToString()) / Val(TXT_CURRENCY_VAL.Text)

                        Else
                            F.DGV.Rows(COUNT_).Cells(4).Value = Val(DT.Rows(I)(14).ToString()) / Val(DT.Rows(I)(22).ToString())

                        End If


                        If TXT_GUID_CURRENCY.Text <> DT.Rows(I)(20).ToString() Then
                            F.DGV.Rows(COUNT_).Cells(5).Value = Val(DT.Rows(I)(15).ToString()) / Val(TXT_CURRENCY_VAL.Text)

                        Else
                            F.DGV.Rows(COUNT_).Cells(5).Value = Val(DT.Rows(I)(15).ToString()) / Val(DT.Rows(I)(22).ToString())

                        End If


                        BLANCE__ = Val(BLANCE__) + (Val(F.DGV.Rows(COUNT_).Cells(4).Value) - Val(F.DGV.Rows(COUNT_).Cells(5).Value))
                        F.DGV.Rows(COUNT_).Cells(6).Value = BLANCE__.ToString("0.00")

                        ''============================================================================
                        F.DGV.Rows(COUNT_).Cells(7).Value = DT.Rows(I)(16).ToString()

                        F.DGV.Rows(COUNT_).Cells(8).Value = DT.Rows(I)(19).ToString()


                        F.DGV.Rows(COUNT_).Cells(9).Value = DT.Rows(I)(20).ToString()
                        F.DGV.Rows(COUNT_).Cells(10).Value = DT.Rows(I)(21).ToString()
                        F.DGV.Rows(COUNT_).Cells(11).Value = DT.Rows(I)(22).ToString()
                        F.DGV.Rows(COUNT_).Cells(12).Value = DT.Rows(I)(5).ToString()


                        F.DGV.Rows(COUNT_).Cells(13).Value = (Val(DT.Rows(I)(14).ToString()) / Val(DT.Rows(I)(22).ToString())).ToString("0.00")
                        F.DGV.Rows(COUNT_).Cells(14).Value = (Val(DT.Rows(I)(15).ToString()) / Val(DT.Rows(I)(22).ToString())).ToString("0.00")


                        MM = Val(MM) + Val(Val(F.DGV.Rows(COUNT_).Cells(4).Value))
                        DD = Val(DD) + Val(Val(F.DGV.Rows(COUNT_).Cells(5).Value))

                        COUNT_ = COUNT_ + 1
                    Next





                    F.DTP1.Value = DTP1.Value
                    F.DTP2.Value = DTP2.Value
                    F.TXT_CURRENCY.Text = TXT_CURRENCY.Text
                    F.TXT_CURRENCY_VAL.Text = TXT_CURRENCY_VAL.Text






                F.TXT_M.Text = (Val(MM) + Val(F.TXT_BEFORE.Text)).ToString("0.00")
                    F.TXT_D.Text = DD.ToString("0.00")
                F.TXT_F.Text = (Val(MM) - Val(DD) + Val(F.TXT_BEFORE.Text)).ToString("0.00")
                '-----------------------------------------------------------------------------------
                'التحليل
                Dim count_CELL As Integer = 3
                Dim COUNT_WEEK As Integer = 0

                Dim DATE_SEASH As New DateTime
                COUNT_WEEK = DateDiff(DateInterval.Weekday, DTP1.Value, DTP2.Value)
                'If COUNT_WEEK = 0 Then
                '    Exit Sub
                'End If
                Dim dtp_new As New DateTime

                Dim dtp As New DateTime
                dtp = DTP1.Value

                F.DGV_THLILE.Rows.Add(TXT_GUID_ACCOUNT.Text, TXT_NAME_ACCOUNT.Text, "المدين")
                F.DGV_THLILE.Rows.Add(TXT_GUID_ACCOUNT.Text, TXT_NAME_ACCOUNT.Text, "الدائن")
                For i As Integer = 0 To Val(COUNT_WEEK)


                    Dim col As New DataGridViewTextBoxColumn
                    col.DataPropertyName = count_CELL
                    If i = 0 Then

                        DATE_SEASH = dtp
                    Else

                        DATE_SEASH = dtp.AddDays(7)

                    End If


                    dtp = Convert.ToDateTime(DATE_SEASH)
                    If i = 0 Then
                        dtp_new = dtp.AddDays(7)
                        col.HeaderText = dtp + " TO " + dtp_new.AddDays(-1)
                    Else
                        dtp_new = dtp.AddDays(7)
                        col.HeaderText = dtp + " TO " + dtp_new.AddDays(-1)
                    End If

                    '---------------------------------------------------------------------------------

                  

                    F.DGV_THLILE.Columns.Add(col)

                    'For jj As Integer = 0 To F.DGV_THLILE.Rows.Count - 1
                    Dim DTT As New DataTable
                    DTT.Clear()
                    DTT = CLS_DAY_.SEARSH_DRS_MONYE_date(F.DGV_THLILE.Rows(0).Cells(0).Value.ToString(), dtp, dtp_new.AddDays(-1))
                    If DTT.Rows.Count > 0 Then
                        F.DGV_THLILE.Rows(0).Cells(count_CELL).Value = Val(DTT.Rows(0).Item(0).ToString()) / Val(TXT_CURRENCY_VAL.Text)
                    End If



                    Dim DTTC As New DataTable
                    DTTC.Clear()
                    DTTC = CLS_DAY_.SEARSH_DRS_MONYE_dateC(F.DGV_THLILE.Rows(1).Cells(0).Value.ToString(), dtp, dtp_new.AddDays(-1))
                    If DTTC.Rows.Count > 0 Then
                        F.DGV_THLILE.Rows(1).Cells(count_CELL).Value = Val(DTTC.Rows(0).Item(0).ToString()) / Val(TXT_CURRENCY_VAL.Text)
                    End If
                    '    Exit For
                    'Next

                    'DATE_SEASH = dtp.AddDays(7)
                    'col.HeaderText = dtp.AddDays(6) + " TO " + dtp_new.AddDays(6)
                    col.Name = count_CELL + 1
                    count_CELL = count_CELL + 1

                    'rows_CELL = rows_CELL + 1




                Next






                F.Text = " كشف حساب"
                F.ShowDialog()
            Else
                MessageBox.Show("لايوجد حركة  حساب ضمن هذه الفترة", "حركة حساب", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
            DTP1.Enabled = True
            DTP2.Enabled = True
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub
    Sub DGV_THLILE()
      
    End Sub
    Sub DGV_JOB_00()
        JOB__ = Nothing
        Dim JOB__1
        For i As Integer = 0 To DGV_JOB.Rows.Count - 1
            If DGV_JOB.Rows(i).Cells(2).Value = True Then
                JOB__1 = "View_DAY2.GUID_JOB_DAY2=" + "'" + DGV_JOB.Rows(i).Cells(0).Value + "'"
                JOB__ = JOB__1 + "or " + JOB__
            End If
        Next
        JOB__ = JOB__ + "  " + "View_DAY2.GUID_JOB_DAY2='00000000-0000-0000-0000-000000000000"

    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
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

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        Try
            number_day___ = 1
            Dim f As New FRM_ALL_ACCOUNT
            f.ShowDialog()
            If f.IS_YES = True Then
                Dim i As Integer = f.DGV.CurrentRow.Index
                TXT_GUID_ACCOUNT.Text = f.DGV.Rows(i).Cells(0).Value.ToString()
                TXT_NAME_ACCOUNT.Text = f.DGV.Rows(i).Cells(1).Value.ToString()
            End If
            number_day___ = 0

        Catch ex As Exception

        End Try
    End Sub
End Class