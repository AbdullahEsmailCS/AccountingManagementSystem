Public Class FRM_REP_ALLDAY
    Dim CLS_CURRENCY_ As New CLS_CURRENCY
    Dim CLS_JOB_ As New CLS_JOB
    Dim CLS_DAY_ As New CLS_DAY
    Dim JOB__ As String
    Private Sub FRM_REP_ALLDAY_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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

    

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
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

    Private Sub جديدToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles جديدToolStripMenuItem.Click
        Try


            DGV_JOB.ReadOnly = True
            
            DGV_JOB_00()
           
 
            DGV_JOB.ReadOnly = False
          





            Dim COUNT_ As Integer = 0
            Dim MM As Double = 0
            Dim DD As Double = 0
            Dim FF As Double = 0


            Dim F As New FRM_SHOW_REP_ALLDAY

            Dim DT As New DataTable
            DT.Clear()
            DT = CLS_DAY_.rep_all_day(DTP1.Value.ToShortDateString(), DTP2.Value.ToShortDateString(), JOB__)
            If DT.Rows.Count > 0 Then
                F.DGV.RowCount = DT.Rows.Count
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
                    ''============================================================================
                    F.DGV.Rows(COUNT_).Cells(6).Value = DT.Rows(I)(16).ToString()

                    F.DGV.Rows(COUNT_).Cells(7).Value = DT.Rows(I)(19).ToString()


                    F.DGV.Rows(COUNT_).Cells(8).Value = DT.Rows(I)(20).ToString()
                    F.DGV.Rows(COUNT_).Cells(9).Value = DT.Rows(I)(21).ToString()
                    F.DGV.Rows(COUNT_).Cells(10).Value = DT.Rows(I)(22).ToString()
                    F.DGV.Rows(COUNT_).Cells(11).Value = DT.Rows(I)(5).ToString()


                    F.DGV.Rows(COUNT_).Cells(12).Value = (Val(DT.Rows(I)(14).ToString()) / Val(DT.Rows(I)(22).ToString())).ToString("0.00")
                    F.DGV.Rows(COUNT_).Cells(13).Value = (Val(DT.Rows(I)(15).ToString()) / Val(DT.Rows(I)(22).ToString())).ToString("0.00")


                    MM = Val(MM) + Val(Val(F.DGV.Rows(COUNT_).Cells(4).Value))
                    DD = Val(DD) + Val(Val(F.DGV.Rows(COUNT_).Cells(5).Value))

                    COUNT_ = COUNT_ + 1
                Next

                F.DTP1.Value = DTP1.Value
                F.DTP2.Value = DTP2.Value
                F.TXT_CURRENCY.Text = TXT_CURRENCY.Text
                F.TXT_CURRENCY_VAL.Text = TXT_CURRENCY_VAL.Text



                F.TXT_M.Text = MM.ToString("0.00")
                F.TXT_D.Text = DD.ToString("0.00")
                F.TXT_F.Text = (Val(MM) - Val(DD)).ToString("0.00")

                F.Text = "الحركة اليومية"
                F.ShowDialog()
            Else
                MessageBox.Show("لايوجد حركة  حساب ضمن هذه الفترة", "حركة حساب", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
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
End Class