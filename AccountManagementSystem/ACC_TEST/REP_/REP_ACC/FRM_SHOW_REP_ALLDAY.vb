Public Class FRM_SHOW_REP_ALLDAY

    Private Sub DGV_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGV.CellContentClick
       
    End Sub

    Private Sub DGV_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGV.CellDoubleClick
        Try
            number_day___ = 1
            Dim i As Integer = DGV.CurrentRow.Index
            Dim f As New FRM_DAY
            f.TXT_ID.Text = Val(DGV.Rows(i).Cells(1).Value)
            f.ShowDialog()
            number_day___ = 0
        Catch ex As Exception

        End Try
    End Sub

    Private Sub جديدToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles جديدToolStripMenuItem.Click
        Try
          
            '-------------------------------------------------------
            Dim dt As New DataTable
            With dt
                .Columns.Add("number")
                .Columns.Add("date")
                .Columns.Add("account")
                .Columns.Add("d")
                .Columns.Add("c")
                .Columns.Add("note")
                '.Columns.Add("job")
                '.Columns.Add("currency")
                '.Columns.Add("val_currency")
                .Columns.Add("total_d")
                .Columns.Add("total_c")
                .Columns.Add("repd1")
                .Columns.Add("repd2")
                .Columns.Add("repjob")
                .Columns.Add("repcurrency")
                .Columns.Add("rep_valcurrency")
                '.Columns.Add("customer")
                .Columns.Add("note_rep")
                .Columns.Add("defrent")
            End With

            '-------------------------------------------------------
            For I As Integer = 0 To DGV.Rows.Count - 1

                dt.Rows.Add(DGV.Rows(I).Cells(1).Value, DGV.Rows(I).Cells(2).Value, DGV.Rows(I).Cells(3).Value, DGV.Rows(I).Cells(4).Value, DGV.Rows(I).Cells(5).Value, DGV.Rows(I).Cells(6).Value, TXT_M.Text, TXT_D.Text, DTP1.Value.ToShortDateString(), DTP2.Value.ToShortDateString(), TXT_JOB.Text, TXT_CURRENCY.Text, TXT_CURRENCY_VAL.Text, Me.Text, TXT_F.Text)


            Next
            '-------------------------------------------------------
            Dim rptDoc As CrystalDecisions.CrystalReports.Engine.ReportDocument
            rptDoc = New Crystal_account

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

    Private Sub FRM_SHOW_REP_ALLDAY_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class