Public Class FRM_ITEME_ALL
    Dim ClS_CATEGORYE_ As New ClS_CATEGORYE
    Dim CLS_JOB_ As New CLS_JOB
    Dim CLS_STORE_ As New CLS_STORE
    Dim ClS_TYPE_BILL_ As New ClS_TYPE_BILL
    Dim CLS_BILL_ As New CLS_BILL

    Dim JOB__ As String
    Dim STORE__ As String
    Dim CATEGOY__ As String
    Dim typebill__ As String
    Private Sub FRM_ITEME_ALL_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            DTP1.Value = Today
            DTP2.Value = Today
            show_gr000()
            show_job()
            show_STORE()
            show_TYPE_BILL()
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub
    Sub show_TYPE_BILL()
        Dim COUNT__ As Integer = 0
        Dim dt As New DataTable
        dt.Clear()
        dt = ClS_TYPE_BILL_.ALL__()
        If dt.Rows.Count > 0 Then
            DGV_ClS_TYPE_BILL.RowCount = dt.Rows.Count
            For I As Integer = 0 To dt.Rows.Count - 1
                DGV_ClS_TYPE_BILL.Rows(COUNT__).Cells(0).Value = dt.Rows(I)(0).ToString()
                DGV_ClS_TYPE_BILL.Rows(COUNT__).Cells(1).Value = dt.Rows(I)(1).ToString()
                DGV_ClS_TYPE_BILL.Rows(COUNT__).Cells(2).Value = True
                COUNT__ = COUNT__ + 1
            Next
        End If
    End Sub
    Sub show_gr000()
        Dim COUNT__ As Integer = 0
        Dim dt As New DataTable
        dt.Clear()
        dt = ClS_CATEGORYE_.ALL__()
        If dt.Rows.Count > 0 Then
            DGV_CATGORY.RowCount = dt.Rows.Count
            For I As Integer = 0 To dt.Rows.Count - 1
                DGV_CATGORY.Rows(COUNT__).Cells(0).Value = dt.Rows(I)(0).ToString()
                DGV_CATGORY.Rows(COUNT__).Cells(1).Value = dt.Rows(I)(1).ToString()
                DGV_CATGORY.Rows(COUNT__).Cells(2).Value = True
                COUNT__ = COUNT__ + 1
            Next
        End If
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
    Sub show_STORE()
        Dim COUNT__ As Integer = 0
        Dim dt As New DataTable
        dt.Clear()
        dt = CLS_STORE_.ALL__()
        If dt.Rows.Count > 0 Then
            DGV_STORE.RowCount = dt.Rows.Count
            For I As Integer = 0 To dt.Rows.Count - 1
                DGV_STORE.Rows(COUNT__).Cells(0).Value = dt.Rows(I)(0).ToString()
                DGV_STORE.Rows(COUNT__).Cells(1).Value = dt.Rows(I)(1).ToString()
                DGV_STORE.Rows(COUNT__).Cells(2).Value = True
                COUNT__ = COUNT__ + 1
            Next
        End If
    End Sub

    Private Sub جديدToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles جديدToolStripMenuItem.Click
        Try
            DGV_JOB.ReadOnly = True
            DGV_STORE.ReadOnly = True
            DGV_CATGORY.ReadOnly = True
            DGV_ClS_TYPE_BILL.ReadOnly = True

            DGV_typebill___00()
            DGV_JOB_00()
            DGV_STORE_00()
            DGV_CATEGORY_00()


            DGV_ClS_TYPE_BILL.ReadOnly = False
            DGV_CATGORY.ReadOnly = False
            DGV_JOB.ReadOnly = False
            DGV_STORE.ReadOnly = False

            Dim COUNT_ As Integer = 0
            Dim MM As Double = 0
            Dim DD As Double = 0
            Dim FF As Double = 0


            Dim F As New FROM_SHOP_REP_EXELL

            Dim DT As New DataTable
            DT.Clear()

            DT = CLS_BILL_.SEARSH__all_(DTP1.Value.ToShortDateString(), DTP2.Value.ToShortDateString(), JOB__, STORE__, CATEGOY__, typebill__)

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



                    COUNT_ = COUNT_ + 1


                Next

 
                F.Text = "تقرير مواد تفصيلي  "
                F.ShowDialog()
            Else
                MessageBox.Show("لايوجد حركة    ضمن هذه الفترة", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error)
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
                JOB__1 = "BILL1.GUID_JOB=" + "'" + DGV_JOB.Rows(i).Cells(0).Value + "'"
                JOB__ = JOB__1 + "or " + JOB__
            End If
        Next
        JOB__ = JOB__ + "  " + "BILL1.GUID_JOB='00000000-0000-0000-0000-000000000000"

    End Sub
    Sub DGV_STORE_00()
        STORE__ = Nothing
        Dim STORE__1
        For i As Integer = 0 To DGV_STORE.Rows.Count - 1
            If DGV_STORE.Rows(i).Cells(2).Value = True Then
                STORE__1 = "BILL2.guid_store=" + "'" + DGV_STORE.Rows(i).Cells(0).Value + "'"
                STORE__ = STORE__1 + "or " + STORE__
            End If
        Next
        STORE__ = STORE__ + "  " + "BILL2.guid_store='00000000-0000-0000-0000-000000000000"

    End Sub
    Sub DGV_CATEGORY_00()
        CATEGOY__ = Nothing
        Dim CATEGOY__1
        For i As Integer = 0 To DGV_CATGORY.Rows.Count - 1
            If DGV_CATGORY.Rows(i).Cells(2).Value = True Then
                CATEGOY__1 = "ITEME.GROUP_GUID=" + "'" + DGV_CATGORY.Rows(i).Cells(0).Value + "'"
                CATEGOY__ = CATEGOY__1 + "or " + CATEGOY__
            End If
        Next
        CATEGOY__ = CATEGOY__ + "  " + "ITEME.GROUP_GUID='00000000-0000-0000-0000-000000000000"

    End Sub
    Sub DGV_typebill___00()
        typebill__ = Nothing
        Dim typebill____1
        For i As Integer = 0 To DGV_ClS_TYPE_BILL.Rows.Count - 1
            If DGV_ClS_TYPE_BILL.Rows(i).Cells(2).Value = True Then
                typebill____1 = "BILL1.PARENT_GUID=" + "'" + DGV_ClS_TYPE_BILL.Rows(i).Cells(0).Value + "'"
                typebill__ = typebill____1 + "or " + typebill__
            End If
        Next
        typebill__ = typebill__ + "  " + "BILL1.PARENT_GUID='00000000-0000-0000-0000-000000000000"

    End Sub
End Class