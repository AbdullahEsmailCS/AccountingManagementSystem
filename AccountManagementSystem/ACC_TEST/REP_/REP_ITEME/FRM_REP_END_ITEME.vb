Public Class FRM_REP_END_ITEME
    Dim CLS_DAY_ As New CLS_DAY
    Dim CLS_ITEME_ As New CLS_ITEME
    Dim TOT__ As Double = 0
    Dim dt As New DataTable
    Private Sub طباعةToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles طباعةToolStripMenuItem.Click
        Try
            Dim COUNT__ As Integer = 0


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

                TXT_END.Text = TOT__.ToString("0.00")
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub FRM_REP_END_ITEME_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        DTP1.Value = Today
        DTP2.Value = Today
    End Sub

    Private Sub CMB_PRICE_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles CMB_PRICE.KeyPress
        e.Handled = True
    End Sub

    Private Sub CMB_PRICE_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CMB_PRICE.SelectedIndexChanged

    End Sub

    Private Sub TXT_END_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TXT_END.KeyPress
        e.Handled = True
    End Sub

    Private Sub TXT_END_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TXT_END.TextChanged

    End Sub

    Private Sub جديدToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles جديدToolStripMenuItem.Click
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

    Private Sub ToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem1.Click
        Try



            Dim dt As New DataTable
            With dt
                .Columns.Add("ITEME")
                .Columns.Add("QTY")
                .Columns.Add("AVG")
                .Columns.Add("LAST")
                .Columns.Add("TOTAL")
                .Columns.Add("from")
                .Columns.Add("to")
            End With
            Dim dt1 As DateTime = DTP1.Value.ToShortDateString()
            Dim dt2 As DateTime = DTP2.Value.ToShortDateString()
            '-------------------------------------------------------
            For I As Integer = 0 To DGV_END.Rows.Count - 1

                dt.Rows.Add(DGV_END.Rows(I).Cells(1).Value, DGV_END.Rows(I).Cells(2).Value, DGV_END.Rows(I).Cells(3).Value, DGV_END.Rows(I).Cells(4).Value, DGV_END.Rows(I).Cells(5).Value, dt1, dt2)


            Next
            '-------------------------------------------------------
            Dim rptDoc As CrystalDecisions.CrystalReports.Engine.ReportDocument
            rptDoc = New Crystal_END_ITEME

            rptDoc.SetDataSource(dt)
         

            Dim f As New FRM_PRINT
            f.CrystalReportViewer1.ReportSource = rptDoc


            f.ShowDialog()
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub
End Class