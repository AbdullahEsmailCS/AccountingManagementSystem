Public Class FRM_REP_BALANCE
    Dim CLS_CURRENCY_ As New CLS_CURRENCY
    Dim CLS_JOB_ As New CLS_JOB
    Dim CLS_DAY_ As New CLS_DAY
    Dim DT_REP As New DataTable
    Private Sub FRM_REP_BALANCE_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            SHOW_JOB()
            DTP1.Value = Today
            DTP2.Value = Today
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

    Private Sub جديدToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles جديدToolStripMenuItem.Click
        Try
            Dim COUNT_ As Integer = 0
            Dim MM As Double = 0
            Dim DD As Double = 0

            DT_REP = CLS_DAY_.rep_BALANCE_ACCOUNT(TXT_GUID_JOB.Text, DTP1.Value.ToShortDateString(), DTP2.Value.ToShortDateString())
            If DT_REP.Rows.Count > 0 Then
                DGV.RowCount = DT_REP.Rows.Count
                For I As Integer = 0 To DT_REP.Rows.Count - 1
                    DGV.Rows(COUNT_).Cells(0).Value = DT_REP.Rows(I)(0).ToString()
                    DGV.Rows(COUNT_).Cells(1).Value = DT_REP.Rows(I)(1).ToString()
                    DGV.Rows(COUNT_).Cells(2).Value = DT_REP.Rows(I)(2).ToString()
                    DGV.Rows(COUNT_).Cells(3).Value = DT_REP.Rows(I)(3).ToString()
                    DGV.Rows(COUNT_).Cells(4).Value = DT_REP.Rows(I)(4).ToString()

                    MM = Val(MM) + Val(Val(DGV.Rows(COUNT_).Cells(2).Value))
                    DD = Val(DD) + Val(Val(DGV.Rows(COUNT_).Cells(3).Value))
                    COUNT_ = COUNT_ + 1

                Next

                TXT_M.Text = MM.ToString("0.00")
                TXT_D.Text = DD.ToString("0.00")
                TXT_F.Text = (Val(MM) - Val(DD)).ToString("0.00")
            Else
                MessageBox.Show("لايوجد حركة   ضمن هذه الفترة", "حركة حساب", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

   
    Private Sub ToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem1.Click
        Try

            '-------------------------------------------------------
            Dim dt As New DataTable
            With dt
                .Columns.Add("FD1")
                .Columns.Add("TOD2")
                .Columns.Add("JOB")
                .Columns.Add("CODE")
                .Columns.Add("ACCOUNT")
                .Columns.Add("D")
                .Columns.Add("C")
                .Columns.Add("BALANCE")
                .Columns.Add("TOTAL_D")
                .Columns.Add("TOTAL_C")
                .Columns.Add("DEF")
                
            End With

            '-------------------------------------------------------
            For I As Integer = 0 To DGV.Rows.Count - 1

                dt.Rows.Add(DTP1.Value.ToShortDateString(), DTP2.Value.ToShortDateString(), TXT_JOB.Text, DGV.Rows(I).Cells(0).Value, DGV.Rows(I).Cells(1).Value, DGV.Rows(I).Cells(2).Value, DGV.Rows(I).Cells(3).Value, DGV.Rows(I).Cells(4).Value, TXT_M.Text, TXT_D.Text, TXT_F.Text)


            Next
            '-------------------------------------------------------
            Dim rptDoc As CrystalDecisions.CrystalReports.Engine.ReportDocument
            rptDoc = New Crystal_BALANCEACCOUNT

            rptDoc.SetDataSource(dt)
            rptDoc.SetParameterValue("LOG", My.Settings.TXTPATH_LOGO)
            rptDoc.SetParameterValue("NAME", My.Settings.TXT_NAME)
            rptDoc.SetParameterValue("PHONE", My.Settings.TXT_PHONE)
            rptDoc.SetParameterValue("MOBILE", My.Settings.TXT_MOBILE)
            rptDoc.SetParameterValue("EMAIL", My.Settings.TXT_EMAIL)
            rptDoc.SetParameterValue("WEB", My.Settings.TXT_WEB)

            Dim f As New FRM_PRINT
            f.CrystalReportViewer1.ReportSource = rptDoc


            f.ShowDialog()

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub
End Class