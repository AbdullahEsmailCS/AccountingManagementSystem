Public Class FRM_ITEME_DAY

    Dim CLS_CURRENCY_ As New CLS_CURRENCY
    Dim CLS_JOB_ As New CLS_JOB
    Dim CLS_BILL_ As New CLS_BILL
    Private Sub FRM_REP_BILL_DAY_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            DTP1.Value = Today
            DTP2.Value = Today
            SHOW_JOB()

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
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
    'Sub SHOW_CURRENCY()
    '    Dim DT As New DataTable
    '    DT.Clear()
    '    DT = CLS_CURRENCY_.SELECT_
    '    If DT.Rows.Count > 0 Then
    '        TXT_GUID_CURRENCY.Text = DT.Rows(0)(0).ToString()
    '        TXT_CURRENCY.Text = DT.Rows(0)(1).ToString()
    '        TXT_CURRENCY_VAL.Text = DT.Rows(0)(2).ToString()

    '    End If
    'End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
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

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'Try
        '    Dim F As New FRM_ALL_CURRENCY
        '    F.ShowDialog()
        '    If F.IS_YES = True Then
        '        Dim I As Integer = F.DGV.CurrentRow.Index
        '        TXT_GUID_CURRENCY.Text = F.DGV.Rows(I).Cells(0).Value.ToString()
        '        TXT_CURRENCY.Text = F.DGV.Rows(I).Cells(2).Value.ToString()
        '        TXT_CURRENCY_VAL.Text = Val(F.DGV.Rows(I).Cells(4).Value.ToString()).ToString("0.00")

        '    End If

        'Catch ex As Exception

        'End Try
    End Sub

    Private Sub جديدToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles جديدToolStripMenuItem.Click
        Try
            If TXT_ITEME_GUID.Text = Nothing Then
                MessageBox.Show("يجب اختيار مادة", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If

            Dim COUNT_ As Integer = 0
            Dim MM As Double = 0
            Dim DD As Double = 0
            Dim FF As Double = 0
            Dim bal_ As Double = 0

            Dim F As New FRM_SHOW_REP_ALLbill

            Dim DT As New DataTable
            DT.Clear()

            DT = CLS_BILL_.rep_ITEME(TXT_GUID_JOB.Text, DTP1.Value.ToShortDateString(), DTP2.Value.ToShortDateString(), TXT_ITEME_GUID.Text)
            If DT.Rows.Count > 0 Then

                F.DGV.RowCount = DT.Rows.Count
                'F.DGV.Rows.Add()
                For I As Integer = 0 To DT.Rows.Count - 1
                    F.DGV.Rows(COUNT_).Cells(0).Value = Convert.ToDateTime(DT.Rows(I)(0).ToString()).ToShortDateString()
                    F.DGV.Rows(COUNT_).Cells(1).Value = DT.Rows(I)(1).ToString()
                    F.DGV.Rows(COUNT_).Cells(2).Value = DT.Rows(I)(2).ToString()
                    F.DGV.Rows(COUNT_).Cells(3).Value = DT.Rows(I)(3).ToString()
                    F.DGV.Rows(COUNT_).Cells(4).Value = DT.Rows(I)(4).ToString()
                    F.DGV.Rows(COUNT_).Cells(5).Value = DT.Rows(I)(5).ToString()

                    F.DGV.Rows(COUNT_).Cells(6).Value = DT.Rows(I)(6).ToString()
                    F.DGV.Rows(COUNT_).Cells(7).Value = DT.Rows(I)(7).ToString()
                    F.DGV.Rows(COUNT_).Cells(8).Value = DT.Rows(I)(8).ToString()
                    F.DGV.Rows(COUNT_).Cells(9).Value = DT.Rows(I)(9).ToString()
                    F.DGV.Rows(COUNT_).Cells(10).Value = DT.Rows(I)(10).ToString()

                    F.DGV.Rows(COUNT_).Cells(11).Value = DT.Rows(I)(11).ToString()
                    F.DGV.Rows(COUNT_).Cells(12).Value = DT.Rows(I)(12).ToString()
                    F.DGV.Rows(COUNT_).Cells(13).Value = DT.Rows(I)(13).ToString()
                    F.DGV.Rows(COUNT_).Cells(14).Value = DT.Rows(I)(14).ToString()
                    F.DGV.Rows(COUNT_).Cells(15).Value = DT.Rows(I)(15).ToString()
                    F.DGV.Rows(COUNT_).Cells(16).Value = DT.Rows(I)(16).ToString()
                    'MessageBox.Show(DT.Rows(I)(17).ToString())
                    If DT.Rows(I)(17).ToString() = "0" Or DT.Rows(I)(17).ToString() = "3" Or DT.Rows(I)(17).ToString() = "5" Or DT.Rows(I)(17).ToString() = "7" Then
                        bal_ = bal_ + (Val(DT.Rows(I)(10).ToString()) * Val(DT.Rows(I)(18).ToString()))
                    Else
                        bal_ = bal_ - (Val(DT.Rows(I)(10).ToString()) * Val(DT.Rows(I)(18).ToString()))
                    End If

                    F.DGV.Rows(COUNT_).Cells(17).Value = Val(bal_)




                    COUNT_ = COUNT_ + 1
                Next


                F.DTP1.Value = DTP1.Value
                F.DTP2.Value = DTP2.Value

                F.TXT_JOB.Text = TXT_JOB.Text
                'F.DGV.Rows(0).Cells(1).Value = "رصيد"
                'F.DGV.Rows(0).Cells(2).Value = "100000"
                F.Text = "يومية المواد"
                F.ShowDialog()
            Else
                MessageBox.Show("لايوجد حركة    ضمن هذه الفترة", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            Dim F As New FRM_ALL_ITEME
            F.ShowDialog()
            If F.isyes = True Then
                Dim i As Integer = F.DGV.CurrentRow.Index
                TXT_ITEME_GUID.Text = F.DGV.Rows(i).Cells(0).Value.ToString()
                TXT_ITEME_NAME.Text = F.DGV.Rows(i).Cells(2).Value.ToString()
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub TXT_ITEME_NAME_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TXT_ITEME_NAME.KeyPress
        e.Handled = True
    End Sub

    Private Sub TXT_ITEME_NAME_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TXT_ITEME_NAME.TextChanged

    End Sub

    Private Sub TXT_JOB_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TXT_JOB.KeyPress
        e.Handled = True
    End Sub

    Private Sub TXT_JOB_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TXT_JOB.TextChanged

    End Sub
End Class