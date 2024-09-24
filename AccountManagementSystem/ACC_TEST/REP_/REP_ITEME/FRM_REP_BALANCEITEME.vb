Public Class FRM_REP_BALANCEITEME
    Dim CLS_BILL_ As New CLS_BILL
    Private Sub FRM_REP_BALANCEITEME_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            DTP1.Value = Today
            DTP2.Value = Today


        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub جديدToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles جديدToolStripMenuItem.Click
        Try
            Dim COUNT_ As Integer = 0



            Dim DT As New DataTable
            DT.Clear()
            DT = CLS_BILL_.rep_BALANCE_DATE(DTP1.Value.ToShortDateString(), DTP2.Value.ToShortDateString())
            If DT.Rows.Count > 0 Then


                DGV.RowCount = DT.Rows.Count
                For I As Integer = 0 To DT.Rows.Count - 1
                    DGV.Rows(COUNT_).Cells(0).Value = DT.Rows(I)(0).ToString()
                    DGV.Rows(COUNT_).Cells(1).Value = DT.Rows(I)(1).ToString()
                    DGV.Rows(COUNT_).Cells(2).Value = DT.Rows(I)(2).ToString()
                    DGV.Rows(COUNT_).Cells(3).Value = DT.Rows(I)(4).ToString()



                    COUNT_ = COUNT_ + 1
                Next



            Else
                MessageBox.Show("لايوجد حركة    ضمن هذه الفترة", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub
End Class