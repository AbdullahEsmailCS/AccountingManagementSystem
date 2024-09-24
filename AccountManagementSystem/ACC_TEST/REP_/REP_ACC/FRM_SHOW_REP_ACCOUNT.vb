Public Class FRM_SHOW_REP_ACCOUNT

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
                .Columns.Add("BALANCEEE")
            End With

            '-------------------------------------------------------
            For I As Integer = 0 To DGV.Rows.Count - 1

                dt.Rows.Add(DGV.Rows(I).Cells(1).Value, DGV.Rows(I).Cells(2).Value, DGV.Rows(I).Cells(3).Value, DGV.Rows(I).Cells(4).Value, DGV.Rows(I).Cells(5).Value, DGV.Rows(I).Cells(7).Value, TXT_M.Text, TXT_D.Text, DTP1.Value.ToShortDateString(), DTP2.Value.ToShortDateString(), TXT_JOB.Text, TXT_CURRENCY.Text, TXT_CURRENCY_VAL.Text, Me.Text, TXT_F.Text, DGV.Rows(I).Cells(6).Value)


            Next
            '-------------------------------------------------------
            Dim rptDoc As CrystalDecisions.CrystalReports.Engine.ReportDocument
            rptDoc = New Crystal_account_ONE

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

    Private Sub DGV_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGV.CellClick
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

    Private Sub DGV_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGV.CellContentClick

    End Sub

    Private Sub ToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem2.Click
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

                    For i = 1 To Me.DGV_BEFORE.RowCount
                        .cells(i + 1, 1) = Me.DGV_BEFORE.Rows(i - 1).Cells(0).Value

                        For j = 0 To DGV_BEFORE.Columns.Count - 1
                            .cells(j + 1) = DGV_BEFORE.Columns(j).HeaderText
                            .cells(i + 1, j + 1) = DGV_BEFORE.Rows(i - 1).Cells(j).Value

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

                    For i = 1 To Me.DGV_THLILE.RowCount
                        .cells(i + 1, 1) = Me.DGV_THLILE.Rows(i - 1).Cells(0).Value

                        For j = 0 To DGV_THLILE.Columns.Count - 1
                            .cells(j + 1) = DGV_THLILE.Columns(j).HeaderText
                            .cells(i + 1, j + 1) = DGV_THLILE.Rows(i - 1).Cells(j).Value

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
End Class