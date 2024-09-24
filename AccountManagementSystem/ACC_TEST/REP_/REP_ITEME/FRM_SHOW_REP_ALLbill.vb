Public Class FRM_SHOW_REP_ALLbill

    Private Sub جديدToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles جديدToolStripMenuItem.Click
        Try
           


            Dim dt As New DataTable
            With dt
                .Columns.Add("number")
                .Columns.Add("b1_date")
                .Columns.Add("b1_customer")
                .Columns.Add("b1_note")
                .Columns.Add("b2_barcode")
                .Columns.Add("b2_iteme")
                .Columns.Add("b2_qty")
                .Columns.Add("b2_price")
                .Columns.Add("b2_disc")
                .Columns.Add("b2_extra")
                .Columns.Add("b2_total")
                .Columns.Add("b2_unit")


                .Columns.Add("total_bill2")
                .Columns.Add("disc")
                .Columns.Add("total")

                .Columns.Add("type_bill")








            End With

            '-------------------------------------------------------
            For I As Integer = 0 To DGV.Rows.Count - 1
                If DGV.Rows(I).Cells(0).Value <> Nothing Then

                    '                      1                      2                          3                          4                5                        6                              7                         8                           9                              10                               11                  
                    dt.Rows.Add(DGV.Rows(I).Cells(1).Value, DGV.Rows(I).Cells(0).Value, DGV.Rows(I).Cells(3).Value, Me.Text, DGV.Rows(I).Cells(8).Value, DGV.Rows(I).Cells(9).Value, DGV.Rows(I).Cells(10).Value, DGV.Rows(I).Cells(11).Value, DGV.Rows(I).Cells(12).Value, DGV.Rows(I).Cells(13).Value, DGV.Rows(I).Cells(14).Value, "", "", "", DGV.Rows(I).Cells(17).Value)
                End If

            Next
            '-------------------------------------------------------
            Dim rptDoc As CrystalDecisions.CrystalReports.Engine.ReportDocument
            rptDoc = New Crystal_ITEME

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

                    For i = 1 To Me.DGV.RowCount
                        .cells(i + 1, 1) = Me.DGV.Rows(i - 1).Cells(0).Value

                        For j = 0 To DGV.Columns.Count - 1
                            .cells(j + 1) = DGV.Columns(j).HeaderText
                            .cells(i + 1, j + 1) = DGV.Rows(i - 1).Cells(j).Value

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