Public Class FRM_REP_INV_UPDATE

    Dim ClS_TYPE_BILL_ As New ClS_TYPE_BILL
    Dim CLS_B_ As New CLS_B
    Dim PARENT__ As String
    Dim GUID_DELETE__ As String
    Dim NUMBER_DELETE As Integer = 0
    Dim CLS_BILL_ As New CLS_BILL
    Private Sub FRM_REP_INV_DELETE_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            TYPE___BILL()
        Catch ex As Exception

        End Try
    End Sub
    Sub TYPE___BILL()
        Dim DT As New DataTable
        DT.Clear()
        DT = ClS_TYPE_BILL_.SHOW_
        If DT.Rows.Count > 0 Then

            DGV_BT_NAME.DataSource = DT
            DGV_BT_NAME.Columns(0).Visible = False
        End If
    End Sub

    Private Sub DGV_BT_NAME_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGV_BT_NAME.CellClick
        Try
            Dim I As Integer = DGV_BT_NAME.CurrentRow.Index
            PARENT__ = DGV_BT_NAME.Rows(I).Cells(0).Value.ToString()
            '-------------------------------
            DGV_B.Rows.Clear()
            DGV.Rows.Clear()
            '-------------------------------
            Dim DT As New DataTable
            DT.Clear()
            DT = CLS_B_.SHOW_NUM_UPDATE(PARENT__)
            If DT.Rows.Count > 0 Then
                DGV_NUMBER_DELETE.DataSource = DT
                DGV_NUMBER_DELETE.Columns(0).Visible = False
            Else
                DT.Clear()
                DGV_NUMBER_DELETE.DataSource = DT
            End If

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub DGV_NUMBER_DELETE_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGV_NUMBER_DELETE.CellClick
        Try
            Dim I As Integer = DGV_NUMBER_DELETE.CurrentRow.Index
            GUID_DELETE__ = DGV_NUMBER_DELETE.Rows(I).Cells(0).Value.ToString()
            NUMBER_DELETE = Val(DGV_NUMBER_DELETE.Rows(I).Cells(1).Value.ToString())
            DGV.Rows.Clear()
            DGV_B.Rows.Clear()

            b1_SHOW()
            b2_SHOW()


            BILL_1()
            If TXT_GUID.Text = Nothing Then
                Exit Sub
            End If
            bill2()
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub
    Sub bill2()


        Dim COUNT_ As Integer = 0

        Dim DT As New DataTable
        DT.Clear()
        DT = CLS_BILL_.show_bil2(TXT_GUID.Text)
        If DT.Rows.Count > 0 Then
            DGV.RowCount = DT.Rows.Count
            For I As Integer = 0 To DT.Rows.Count - 1
                DGV.Rows(COUNT_).Cells(0).Value = DT.Rows(I)(0).ToString()
                DGV.Rows(COUNT_).Cells(1).Value = DT.Rows(I)(1).ToString()
                DGV.Rows(COUNT_).Cells(2).Value = DT.Rows(I)(2).ToString()
                DGV.Rows(COUNT_).Cells(3).Value = DT.Rows(I)(3).ToString()
                DGV.Rows(COUNT_).Cells(4).Value = DT.Rows(I)(4).ToString()
                DGV.Rows(COUNT_).Cells(5).Value = DT.Rows(I)(5).ToString()
                DGV.Rows(COUNT_).Cells(6).Value = DT.Rows(I)(6).ToString()

                DGV.Rows(COUNT_).Cells(7).Value = DT.Rows(I)(7).ToString()
                DGV.Rows(COUNT_).Cells(8).Value = DT.Rows(I)(8).ToString()
                DGV.Rows(COUNT_).Cells(9).Value = DT.Rows(I)(9).ToString()
                DGV.Rows(COUNT_).Cells(10).Value = DT.Rows(I)(10).ToString()
                DGV.Rows(COUNT_).Cells(11).Value = DT.Rows(I)(11).ToString()
                DGV.Rows(COUNT_).Cells(12).Value = DT.Rows(I)(12).ToString()

                Dim recep_ As Integer = Val(DT.Rows(I)(13).ToString())
                If recep_ = 1 Then
                    DGV.Rows(COUNT_).Cells(13).Value = True
                Else
                    DGV.Rows(COUNT_).Cells(13).Value = False
                End If




                COUNT_ = COUNT_ + 1

            Next




        End If
    End Sub
    Sub BILL_1()

        Dim dt As New DataTable
        dt.Clear()
        dt = CLS_BILL_.show_bill1_DELETE(Val(NUMBER_DELETE), PARENT__)
        If dt.Rows.Count > 0 Then
            DTP_BILL.Value = Convert.ToDateTime(dt.Rows(0)(0).ToString())
            TXT_USER_BILL.Text = dt.Rows(0)(1).ToString()
            TXT_GUID.Text = dt.Rows(0)(2).ToString()

        Else
            DTP_BILL.Value = Today
            TXT_GUID.Text = Nothing
            TXT_USER_BILL.Text = Nothing
        End If
    End Sub





    Sub b1_SHOW()

        Dim dt As New DataTable
        dt.Clear()
        dt = CLS_B_.show_bill1_DELETE(GUID_DELETE__)
        If dt.Rows.Count > 0 Then
            DTP1.Value = Convert.ToDateTime(dt.Rows(0)(0).ToString())
            TXT_USER.Text = dt.Rows(0)(1).ToString()


        Else
            DTP1.Value = Today

            TXT_USER.Text = Nothing
        End If
    End Sub
    Sub b2_SHOW()

        Dim COUNT_ As Integer = 0

        Dim DT As New DataTable
        DT.Clear()
        DT = CLS_B_.show_bil2(GUID_DELETE__)
        If DT.Rows.Count > 0 Then
            DGV_B.RowCount = DT.Rows.Count
            For I As Integer = 0 To DT.Rows.Count - 1
                DGV_B.Rows(COUNT_).Cells(0).Value = DT.Rows(I)(0).ToString()
                DGV_B.Rows(COUNT_).Cells(1).Value = DT.Rows(I)(1).ToString()
                DGV_B.Rows(COUNT_).Cells(2).Value = DT.Rows(I)(2).ToString()
                DGV_B.Rows(COUNT_).Cells(3).Value = DT.Rows(I)(3).ToString()
                DGV_B.Rows(COUNT_).Cells(4).Value = DT.Rows(I)(4).ToString()
                DGV_B.Rows(COUNT_).Cells(5).Value = DT.Rows(I)(5).ToString()
                DGV_B.Rows(COUNT_).Cells(6).Value = DT.Rows(I)(6).ToString()

                DGV_B.Rows(COUNT_).Cells(7).Value = DT.Rows(I)(7).ToString()
                DGV_B.Rows(COUNT_).Cells(8).Value = DT.Rows(I)(8).ToString()
                DGV_B.Rows(COUNT_).Cells(9).Value = DT.Rows(I)(9).ToString()
                DGV_B.Rows(COUNT_).Cells(10).Value = DT.Rows(I)(10).ToString()
                DGV_B.Rows(COUNT_).Cells(11).Value = DT.Rows(I)(11).ToString()
                DGV_B.Rows(COUNT_).Cells(12).Value = DT.Rows(I)(12).ToString()

                Dim recep_ As Integer = Val(DT.Rows(I)(13).ToString())
                If recep_ = 1 Then
                    DGV_B.Rows(COUNT_).Cells(13).Value = True
                Else
                    DGV_B.Rows(COUNT_).Cells(13).Value = False
                End If




                COUNT_ = COUNT_ + 1

            Next




        End If
    End Sub
    Private Sub DGV_NUMBER_DELETE_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGV_NUMBER_DELETE.CellContentClick

    End Sub

    Private Sub DGV_BT_NAME_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGV_BT_NAME.CellContentClick

    End Sub
End Class