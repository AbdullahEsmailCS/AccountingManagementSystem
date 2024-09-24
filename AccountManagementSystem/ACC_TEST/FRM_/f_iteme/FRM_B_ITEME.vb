Public Class FRM_B_ITEME

    Dim CLS_STORE_ As New CLS_STORE
    Dim CLS_ITEME_ As New CLS_ITEME
    Dim CLS_ACCOUNT_ As New CLS_ACCOUNT
    Dim CLS_BILL_ As New CLS_BILL

    Dim id_day As Integer = 0
    Dim CLS_CURRENCY_ As New CLS_CURRENCY
    Dim CLS_JOB_ As New CLS_JOB

    Dim ClS_TYPE_BILL_ As New ClS_TYPE_BILL
    Dim day_iteme As String
    Dim day_dis As String
    Dim day_cash As String
    Dim is_day As Integer
    Dim CLS_CU_VEN_ As New CLS_CU_VEN
    Dim US00_BT_ As New US00_BT
    Dim column_index As Integer = 0


    Dim CLS_B_ As New CLS_B
    Dim max_id_b As Integer = 0
    Dim note_b As String

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Try
            Dim F As New FRM_ALL_STORE
            F.ShowDialog()
            If F.IS_YES = True Then
                Dim I As Integer = F.DGV.CurrentRow.Index
                TXT_GUID_STORE.Text = F.DGV.Rows(I).Cells(2).Value.ToString()
                TXT_STORE.Text = F.DGV.Rows(I).Cells(1).Value.ToString()
            End If
        Catch ex As Exception

        End Try
    End Sub

    
    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        Try
            MAX_()
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub
    Sub MAX_()
        Dim DT As New DataTable
        DT.Clear()
        DT = CLS_BILL_.MAX_(TXT_PARENT_GUID.Text)
        If DT.Rows.Count > 0 Then
            TXT_ID.Text = DT.Rows(0)(0).ToString()
        End If
    End Sub

    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click
        Try
            Dim max___ As Double = 0
            Dim DT As New DataTable
            DT.Clear()
            DT = CLS_BILL_.MAX_(TXT_PARENT_GUID.Text)
            If DT.Rows.Count > 0 Then
                max___ = DT.Rows(0)(0).ToString()
            End If

            TXT_ID.Text = TXT_ID.Text + 1
            If Val(TXT_ID.Text) > Val(max___) Then
                TXT_ID.Text = max___
                MessageBox.Show("هذا اكبر رقم", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

        Catch ex As Exception

        End Try
    End Sub

    Private Sub PictureBox4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox4.Click
        Try
            Dim min___ As Double = 0
            Dim DT As New DataTable
            DT.Clear()
            DT = CLS_BILL_.MIN_(TXT_PARENT_GUID.Text)
            If DT.Rows.Count > 0 Then
                min___ = DT.Rows(0)(0).ToString()
            End If

            TXT_ID.Text = TXT_ID.Text - 1
            If Val(TXT_ID.Text) < Val(min___) Then
                TXT_ID.Text = min___
                MessageBox.Show("هذا اصغر رقم", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

        Catch ex As Exception

        End Try
    End Sub

    Private Sub PictureBox3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox3.Click

        Try
            MIN_()
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub
    Sub MIN_()
        Dim DT As New DataTable
        DT.Clear()
        DT = CLS_BILL_.MIN_(TXT_PARENT_GUID.Text)
        If DT.Rows.Count > 0 Then
            TXT_ID.Text = DT.Rows(0)(0).ToString()
        End If
    End Sub

    Private Sub FRM_BILL_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If MessageBox.Show("هل متاكد من الخروج", "تنبيه", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.No Then
            e.Cancel = True
        End If
    End Sub

    Private Sub FRM_BILL_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            MAX_1()
            TXT_TOTAL_SUB.Text = "0"

            'For I As Integer = 0 To 1000
            '    DGV.Rows.Add()
            'Next
            SHOW_JOB()
            SHOW_CURRENCY()
            SHOW_store()
            us000()
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub
    Sub us000()


        Dim count_ As Integer = 0
        Dim dt As New DataTable
        dt.Clear()
        dt = US00_BT_.GUID_BT_(guid_user_log)
        If dt.Rows.Count > 0 Then
            Dim dt1 As New DataTable
            dt1.Clear()

            'ISINSERT,ISUPDATE,ISDELETE,ISprint ,ISSHOW 
            dt1 = US00_BT_.GUID_BT_us(TXT_PARENT_GUID.Text, guid_user_log)
            If dt1.Rows.Count > 0 Then
                'ISINSERT,ISUPDATE,ISDELETE,ISprint ,ISSHOW
                If dt1.Rows(0)(0) = False Then
                    Nav_SAVE.Enabled = False
                Else
                    Nav_SAVE.Enabled = True
                End If
                '-----------------------
                If dt1.Rows(0)(1) = False Then
                    NavUPDATE.Enabled = False
                Else
                    NavUPDATE.Enabled = True
                End If
                '-----------------------
                If dt1.Rows(0)(2) = False Then
                    NavDELETE.Enabled = False
                Else
                    NavDELETE.Enabled = True
                End If
                '-----------------------
                If dt1.Rows(0)(3) = False Then
                    NavPRENT.Enabled = False
                Else
                    NavPRENT.Enabled = True
                End If
                '-----------------------
                If dt1.Rows(0)(4) = False Then

                    'Close()
                End If
                '-----------------------
                '-----------------------
                '-----------------------


            End If

        End If
    End Sub
    Sub account_bill()
        Dim dt As New DataTable
        dt.Clear()
        dt = ClS_TYPE_BILL_.SHOW_account(TXT_PARENT_GUID.Text)
        If dt.Rows.Count > 0 Then
            day_iteme = dt.Rows(0)(0).ToString()
            day_dis = dt.Rows(0)(1).ToString()
            day_cash = dt.Rows(0)(2).ToString()
            is_day = Val(dt.Rows(0)(3).ToString())
        End If
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
    Sub SHOW_store()
        Dim DT As New DataTable
        DT.Clear()
        DT = CLS_STORE_.SELECT_
        If DT.Rows.Count > 0 Then
            TXT_STORE.Text = DT.Rows(0)(1).ToString()
            TXT_GUID_STORE.Text = DT.Rows(0)(2).ToString()
        End If
    End Sub
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
    Sub MAX_1()
        Dim DT As New DataTable
        DT.Clear()
        DT = CLS_BILL_.MAX_1(TXT_PARENT_GUID.Text)
        If DT.Rows.Count > 0 Then
            TXT_ID.Text = DT.Rows(0)(0).ToString()
        End If
    End Sub

    Private Sub DGV_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGV.CellClick
        Try
            Dim I As Integer = DGV.CurrentCell.RowIndex
            Dim J As Integer = DGV.CurrentCell.ColumnIndex
            If J = 9 Then
                If DGV.Rows(I).Cells(0).Value <> Nothing Then
                    Dim DT As New DataTable
                    DT.Clear()

                    DT = CLS_ITEME_.SHOW_UNIT__(DGV.Rows(I).Cells(0).Value.ToString())
                    If DT.Rows.Count > 0 Then

                        Dim F As New FRM_ALL_UNIT
                        '1
                        F.DGV.Rows.Add(DT.Rows(0)(0).ToString(), DT.Rows(0)(1).ToString())

                        '2
                        If DT.Rows(0)(2).ToString() <> Nothing Then
                            F.DGV.Rows.Add(DT.Rows(0)(2).ToString(), DT.Rows(0)(3).ToString())
                        End If

                        '3
                        If DT.Rows(0)(4).ToString() <> Nothing Then
                            F.DGV.Rows.Add(DT.Rows(0)(4).ToString(), DT.Rows(0)(5).ToString())
                        End If


                        F.ShowDialog()

                        If F.IS_YES = True Then
                            Dim II As Integer = F.DGV.CurrentRow.Index
                            DGV.Rows(I).Cells(9).Value = F.DGV.Rows(II).Cells(0).Value.ToString()
                            DGV.Rows(I).Cells(10).Value = F.DGV.Rows(II).Cells(1).Value.ToString()

                        End If

                    End If

                End If


            End If


        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub





    Private Sub DGV_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGV.CellContentClick

    End Sub

    Private Sub DGV_CellEndEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGV.CellEndEdit
        Try
            Dim I As Integer = DGV.CurrentCell.RowIndex
            Dim J As Integer = DGV.CurrentCell.ColumnIndex


            Dim qty_ As Double = Val(DGV.Rows(I).Cells(3).Value)
            Dim price_ As Double = Val(DGV.Rows(I).Cells(4).Value)

            Dim disc_ As Double = Val(DGV.Rows(I).Cells(5).Value)
            Dim extea_ As Double = Val(DGV.Rows(I).Cells(6).Value)


            If J = 1 Then

                If DGV.Rows(I).Cells(1).Value = Nothing Then
                    Exit Sub
                End If
                'باركود1
                Dim DT As New DataTable
                DT.Clear()
                DT = CLS_ITEME_.searsh_BARCODE_1(DGV.Rows(I).Cells(J).Value.ToString())
                If DT.Rows.Count > 0 Then
                    DGV.Rows(I).Cells(0).Value = DT.Rows(0)(0).ToString()
                    DGV.Rows(I).Cells(1).Value = DT.Rows(0)(1).ToString()
                    DGV.Rows(I).Cells(2).Value = DT.Rows(0)(2).ToString()
                    DGV.Rows(I).Cells(3).Value = 1
                    DGV.Rows(I).Cells(4).Value = 1
                    DGV.Rows(I).Cells(5).Value = 0
                    DGV.Rows(I).Cells(6).Value = 0
                    DGV.Rows(I).Cells(7).Value = 1

                    DGV.Rows(I).Cells(9).Value = DT.Rows(0)(3).ToString()
                    DGV.Rows(I).Cells(10).Value = 1
                    DGV.Rows(I).Cells(11).Value = TXT_GUID_STORE.Text
                    DGV.Rows(I).Cells(12).Value = TXT_STORE.Text
                    DGV.Rows(I).Cells(13).Value = True
                Else
                    DGV.Rows(I).Cells(0).Value = Nothing
                    'DGV.Rows(I).Cells(1).Value = Nothing
                    DGV.Rows(I).Cells(2).Value = Nothing
                    DGV.Rows(I).Cells(3).Value = Nothing
                    DGV.Rows(I).Cells(4).Value = Nothing
                    DGV.Rows(I).Cells(5).Value = Nothing
                    DGV.Rows(I).Cells(6).Value = Nothing
                    DGV.Rows(I).Cells(7).Value = Nothing

                    DGV.Rows(I).Cells(9).Value = Nothing
                    DGV.Rows(I).Cells(10).Value = Nothing
                    DGV.Rows(I).Cells(11).Value = Nothing
                    DGV.Rows(I).Cells(12).Value = Nothing
                    DGV.Rows(I).Cells(13).Value = False
                    'باركود2
                    Dim DT2 As New DataTable
                    DT2.Clear()
                    DT2 = CLS_ITEME_.searsh_BARCODE_2(DGV.Rows(I).Cells(J).Value.ToString())
                    If DT2.Rows.Count > 0 Then
                        DGV.Rows(I).Cells(0).Value = DT2.Rows(0)(0).ToString()
                        DGV.Rows(I).Cells(1).Value = DT2.Rows(0)(1).ToString()
                        DGV.Rows(I).Cells(2).Value = DT2.Rows(0)(2).ToString()
                        DGV.Rows(I).Cells(3).Value = 1
                        DGV.Rows(I).Cells(4).Value = 1
                        DGV.Rows(I).Cells(5).Value = 0
                        DGV.Rows(I).Cells(6).Value = 0
                        DGV.Rows(I).Cells(7).Value = 1

                        DGV.Rows(I).Cells(9).Value = DT2.Rows(0)(3).ToString()
                        DGV.Rows(I).Cells(10).Value = DT2.Rows(0)(4).ToString()
                        DGV.Rows(I).Cells(11).Value = TXT_GUID_STORE.Text
                        DGV.Rows(I).Cells(12).Value = TXT_STORE.Text
                        DGV.Rows(I).Cells(13).Value = True


                    Else

                        DGV.Rows(I).Cells(0).Value = Nothing
                        'DGV.Rows(I).Cells(1).Value = Nothing
                        DGV.Rows(I).Cells(2).Value = Nothing
                        DGV.Rows(I).Cells(3).Value = Nothing
                        DGV.Rows(I).Cells(4).Value = Nothing
                        DGV.Rows(I).Cells(5).Value = Nothing
                        DGV.Rows(I).Cells(6).Value = Nothing
                        DGV.Rows(I).Cells(7).Value = Nothing

                        DGV.Rows(I).Cells(9).Value = Nothing
                        DGV.Rows(I).Cells(10).Value = Nothing
                        DGV.Rows(I).Cells(11).Value = Nothing
                        DGV.Rows(I).Cells(12).Value = Nothing
                        DGV.Rows(I).Cells(13).Value = False


                        'باركود3
                        Dim DT3 As New DataTable
                        DT3.Clear()
                        DT3 = CLS_ITEME_.searsh_BARCODE_3(DGV.Rows(I).Cells(J).Value.ToString())
                        If DT3.Rows.Count > 0 Then
                            DGV.Rows(I).Cells(0).Value = DT3.Rows(0)(0).ToString()
                            DGV.Rows(I).Cells(1).Value = DT3.Rows(0)(1).ToString()
                            DGV.Rows(I).Cells(2).Value = DT3.Rows(0)(2).ToString()
                            DGV.Rows(I).Cells(3).Value = 1
                            DGV.Rows(I).Cells(4).Value = 1
                            DGV.Rows(I).Cells(5).Value = 0
                            DGV.Rows(I).Cells(6).Value = 0
                            DGV.Rows(I).Cells(7).Value = 1

                            DGV.Rows(I).Cells(9).Value = DT3.Rows(0)(3).ToString()
                            DGV.Rows(I).Cells(10).Value = DT3.Rows(0)(4).ToString()
                            DGV.Rows(I).Cells(11).Value = TXT_GUID_STORE.Text
                            DGV.Rows(I).Cells(12).Value = TXT_STORE.Text
                            DGV.Rows(I).Cells(13).Value = True
                        Else
                            DGV.Rows(I).Cells(0).Value = Nothing
                            DGV.Rows(I).Cells(1).Value = Nothing
                            DGV.Rows(I).Cells(2).Value = Nothing
                            DGV.Rows(I).Cells(3).Value = Nothing
                            DGV.Rows(I).Cells(4).Value = Nothing
                            DGV.Rows(I).Cells(5).Value = Nothing
                            DGV.Rows(I).Cells(6).Value = Nothing
                            DGV.Rows(I).Cells(7).Value = Nothing

                            DGV.Rows(I).Cells(9).Value = Nothing
                            DGV.Rows(I).Cells(10).Value = Nothing
                            DGV.Rows(I).Cells(11).Value = Nothing
                            DGV.Rows(I).Cells(12).Value = Nothing
                            DGV.Rows(I).Cells(13).Value = False
                        End If

                    End If
                    '----------------------------------------------------------------------------
                End If





            End If
            '----------------------------------------

            If J = 2 Then
                'اذا كان الاسم مشابهيجلب اقرب اسم
                If DGV.Rows(I).Cells(J).Value <> Nothing Then
                    Dim dt = New DataTable
                    dt.Clear()
                    dt = CLS_ITEME_.searsh_name___(DGV.Rows(I).Cells(J).Value.ToString())
                    If dt.Rows.Count > 0 Then
                        DGV.Rows(I).Cells(0).Value = dt.Rows(0)(0).ToString()
                        DGV.Rows(I).Cells(1).Value = dt.Rows(0)(1).ToString()
                        DGV.Rows(I).Cells(2).Value = dt.Rows(0)(2).ToString()
                        DGV.Rows(I).Cells(3).Value = 1
                        DGV.Rows(I).Cells(4).Value = 1
                        DGV.Rows(I).Cells(5).Value = 0
                        DGV.Rows(I).Cells(6).Value = 0
                        DGV.Rows(I).Cells(7).Value = 1

                        DGV.Rows(I).Cells(9).Value = dt.Rows(0)(3).ToString()
                        DGV.Rows(I).Cells(10).Value = 1
                        DGV.Rows(I).Cells(11).Value = TXT_GUID_STORE.Text
                        DGV.Rows(I).Cells(12).Value = TXT_STORE.Text
                        DGV.Rows(I).Cells(13).Value = True



                        'والا تظهر نافذة البحث
                    Else
                        'DGV.Rows(i).Cells(0).Value = Nothing
                        'DGV.Rows(i).Cells(2).Value = Nothing
                        Dim f As New FRM_ALL_ITEME
                        f.TXT_SEARSH.Text = DGV.Rows(I).Cells(J).Value.ToString()
                        f.ShowDialog()
                        If f.isyes = True Then
                            'Dim ii As Integer = f.DGV.CurrentRow.Index
                            For ii As Integer = 0 To f.DGV.Rows.Count - 1
                                If f.DGV.Rows(ii).Cells(5).Value = True Then
                                    'DGV.Rows.Add(f.DGV.Rows(ii).Cells(0).Value.ToString(), f.DGV.Rows(ii).Cells(3).Value.ToString(), f.DGV.Rows(ii).Cells(1).Value.ToString())
                                    DGV.Rows(I).Cells(0).Value = f.DGV.Rows(ii).Cells(0).Value.ToString()
                                    DGV.Rows(I).Cells(1).Value = f.DGV.Rows(ii).Cells(1).Value.ToString()
                                    DGV.Rows(I).Cells(2).Value = f.DGV.Rows(ii).Cells(2).Value.ToString()


                                    DGV.Rows(I).Cells(3).Value = 1
                                    DGV.Rows(I).Cells(4).Value = 1
                                    DGV.Rows(I).Cells(5).Value = 0
                                    DGV.Rows(I).Cells(6).Value = 0
                                    DGV.Rows(I).Cells(7).Value = 1




                                    DGV.Rows(I).Cells(9).Value = f.DGV.Rows(ii).Cells(3).Value.ToString()
                                    DGV.Rows(I).Cells(10).Value = 1
                                    DGV.Rows(I).Cells(11).Value = TXT_GUID_STORE.Text
                                    DGV.Rows(I).Cells(12).Value = TXT_STORE.Text
                                    DGV.Rows(I).Cells(13).Value = True

                                    I = I + 1
                                End If
                            Next

                        End If
                    End If
                End If
            End If


            '------------------------------------------------
            If J = 3 Or J = 4 Or J = 5 Or J = 6 Then
                If DGV.Rows(I).Cells(3).Value = Nothing Then
                    DGV.Rows(I).Cells(3).Value = "1"
                End If
                If DGV.Rows(I).Cells(4).Value = Nothing Then
                    DGV.Rows(I).Cells(4).Value = "1"
                End If


                DGV.Rows(I).Cells(7).Value = (Val(qty_) * Val(price_)) + Val(extea_) - Val(disc_)



            End If


            total_()
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub
    Sub total_()
        Dim tot_ As Double = 0
        For i As Integer = 0 To DGV.Rows.Count - 1
            If DGV.Rows(i).Cells(0).Value <> Nothing Then
                tot_ = Val(tot_) + Val(DGV.Rows(i).Cells(7).Value)

            End If
        Next


        TXT_TOTAL_SUB.Text = tot_.ToString()
        


    End Sub

    Private Sub TXT_ID_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TXT_ID.KeyPress
        e.Handled = True
    End Sub
    Private Sub TXT_ID_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TXT_ID.TextChanged
        Try
            DGV.Rows.Clear()
            bill1()
            If TXT_GUID.Text <> Nothing Then
                bill2()
                total_()
            Else
                For I As Integer = 0 To 999
                    DGV.Rows.Add()
                    DGV.Rows(I).HeaderCell.Value = (DGV.Rows(I).Index + 1).ToString
                Next
            End If
            '--------------------------------------------------------------------
            If TXT_GUID.Text <> Nothing Then
                SHOW_B()

            Else
                For I As Integer = 0 To 999
                    DGV_B.Rows.Add()
                    DGV_B.Rows(I).HeaderCell.Value = (DGV_B.Rows(I).Index + 1).ToString
                Next
            End If


            'If Val(TXT_ID.Text) > 10 Then
            '    Close()
            'End If
            '--------------------------------------------------------------------
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub
    Sub SHOW_B()
        For II As Integer = 0 To 1000
            DGV_B.Rows.Add()
            DGV_B.Rows(II).HeaderCell.Value = (DGV.Rows(II).Index + 1).ToString
        Next

        Dim COUNT_ As Integer = 0

        Dim DT As New DataTable
        DT.Clear()
        DT = CLS_BILL_.show_bil2(TXT_GUID.Text)
        If DT.Rows.Count > 0 Then

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
    Sub bill2()
        For II As Integer = 0 To 1000
            DGV.Rows.Add()
            DGV.Rows(II).HeaderCell.Value = (DGV.Rows(II).Index + 1).ToString
        Next

        Dim COUNT_ As Integer = 0

        Dim DT As New DataTable
        DT.Clear()
        DT = CLS_BILL_.show_bil2(TXT_GUID.Text)
        If DT.Rows.Count > 0 Then

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

    Sub bill1()

        Dim dt As New DataTable
        dt.Clear()
        dt = CLS_BILL_.show_bill1_B(Val(TXT_ID.Text), TXT_PARENT_GUID.Text)
        If dt.Rows.Count > 0 Then
            DTP1.Value = Convert.ToDateTime(dt.Rows(0)(9).ToString())
            TXT_GUID_CUSTOMER.Text = dt.Rows(0)(4).ToString()
            'TXT_NAME_CUSTOMET.Text = dt.Rows(0)(5).ToString()
            TXT_NOTE.Text = dt.Rows(0)(6).ToString()

            TXT_STORE.Text = dt.Rows(0)(8).ToString()
            TXT_GUID_STORE.Text = dt.Rows(0)(7).ToString()

            TXT_GUID.Text = dt.Rows(0)(0).ToString()

            'TXT_DISC.Text = dt.Rows(0)(10).ToString()
            CMB_TYPE_PAY.Text = dt.Rows(0)(11).ToString()

            TXT_GUID_CURRENCY.Text = dt.Rows(0)(12).ToString()

            TXT_CURRENCY.Text = dt.Rows(0)(13).ToString()

            TXT_CURRENCY_VAL.Text = Val(dt.Rows(0)(14).ToString()).ToString("0.000")

        Else
            DTP1.Value = Today
            'TXT_GUID_CUSTOMER.Text = Nothing
            'TXT_NAME_CUSTOMET.Text = Nothing
            TXT_NOTE.Text = Nothing

            'TXT_STORE.Text = Nothing
            'TXT_GUID_STORE.Text = Nothing

            TXT_GUID.Text = Nothing

        End If
    End Sub

    Private Sub حفظToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Nav_SAVE.Click
        Try

            DGV.ReadOnly = True

            If TXT_GUID.Text <> Nothing Then
                MessageBox.Show(" يجب ضغط جديد اولا ", "نقص", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                Exit Sub
            End If
            '------------------------------------------------------------------------
            If TXT_TOTAL_SUB.Text = "0" Then
                MessageBox.Show(" مجموع الفاتورة =0", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
            '---------------------------------------------------------------------
            If TXT_GUID_CUSTOMER.Text = Nothing Then
                MessageBox.Show("  يجب اخيار الطرف الثاني", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If

            '---------------------------------------------------------------------

            If TXT_GUID_STORE.Text = Nothing Then
                MessageBox.Show("   يجب اختيار مستودع ", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
            '---------------------------------------------------------------------
            If TXT_GUID.Text <> Nothing Then
                MessageBox.Show("   الفاتورة موجودة من قبل لايمكن الحفظ", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If







            MAX_1()
            add_bill1()
            add_bill2()
            balance____()

            If is_day = 1 Then
                If TXT_NUMBER_TYPE.Text = "7" Then


                    avg____()

                End If
            End If

            DGV.ReadOnly = False

            NavUPDATE.Enabled = False
            NavDELETE.Enabled = False
            MessageBox.Show("   تمت عملية حفظ الفاتورة بنجاح ", "تاكيد", MessageBoxButtons.OK, MessageBoxIcon.Information)



        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub
    Sub avg____()

        For i As Integer = 0 To DGV.Rows.Count - 1
            If DGV.Rows(i).Cells(0).Value <> Nothing Then
                Dim dt_ As New DataTable
                dt_.Clear()
                dt_ = CLS_ITEME_.iteme_avg(DGV.Rows(i).Cells(0).Value.ToString())
                If dt_.Rows.Count > 0 Then
                    CLS_ITEME_.BUANCE_avg(Val(dt_.Rows(0)(3).ToString()), DGV.Rows(i).Cells(0).Value.ToString())
                End If
            End If



        Next
    End Sub

    Sub add_bill1()
        CLS_BILL_.ADD_BILL1(TXT_PARENT_GUID.Text,
                            Val(TXT_ID.Text),
                            TXT_GUID_CUSTOMER.Text,
                            TXT_NOTE.Text,
                            TXT_GUID_STORE.Text,
                            DTP1.Value, Val(0),
                            CMB_TYPE_PAY.Text,
                            TXT_GUID_JOB.Text,
                            TXT_GUID_CURRENCY.Text,
                            Val(TXT_CURRENCY_VAL.Text),
                            0,
                            guid_user_log,
                            0,
                            Val(TXT_TOTAL_SUB.Text) * Val(TXT_CURRENCY_VAL.Text),
                            0,
                            Val(TXT_TOTAL_SUB.Text),
                            0,
                            0,
                            "",
                           "",
                            "",
                           "",
                           "",
                            "",
                            "",
                            0,
                            "00000000-0000-0000-0000-000000000000",
                            "00000000-0000-0000-0000-000000000000",
                            0,
                            "00000000-0000-0000-0000-000000000000",
                            DTP_TIME.Value)
    End Sub

    Sub update_bill1()
        CLS_BILL_.update_BILL1(TXT_PARENT_GUID.Text,
                               Val(TXT_ID.Text),
                               TXT_GUID_CUSTOMER.Text,
                               TXT_NOTE.Text,
                               TXT_GUID_STORE.Text,
                               DTP1.Value,
                               Val(0),
                               CMB_TYPE_PAY.Text,
                               TXT_GUID_JOB.Text,
                               TXT_GUID_CURRENCY.Text,
                               Val(TXT_CURRENCY_VAL.Text),
                               TXT_GUID.Text,
                               guid_user_log,
                               0,
                               Val(TXT_TOTAL_SUB.Text) * Val(TXT_CURRENCY_VAL.Text),
                               0,
                               Val(TXT_TOTAL_SUB.Text),
                               0,
                               0,
                               "",
                                "",
                                "",
                               "",
                                "",
                                "",
                               "",
                                0,
                                "00000000-0000-0000-0000-000000000000",
                                "00000000-0000-0000-0000-000000000000",
                                 0,
                                  "00000000-0000-0000-0000-000000000000",
                                DTP_TIME.Value)
    End Sub
    Sub delete_bill2()
        CLS_BILL_.delete_bill2(TXT_GUID.Text)
    End Sub
    Sub delete_bill1()
        CLS_BILL_.delete_bill1(TXT_GUID.Text)
    End Sub
    Sub add_bill2()
        Dim dt As New DataTable
        dt.Clear()
        dt = CLS_BILL_.guid__(TXT_PARENT_GUID.Text, Val(TXT_ID.Text))
        TXT_GUID.Text = dt.Rows(0)(0).ToString()

        For i As Integer = 0 To DGV.Rows.Count - 1

            If DGV.Rows(i).Cells(0).Value <> Nothing Then

                Dim note_ As String
                If DGV.Rows(i).Cells(8).Value = Nothing Then
                    note_ = TXT_ID.Text + "/" + Me.Text
                Else
                    note_ = DGV.Rows(i).Cells(8).Value.ToString()
                End If


                Dim recep_ As Integer
                If DGV.Rows(i).Cells(13).Value = True Then
                    recep_ = 1
                Else
                    recep_ = 0
                End If



                CLS_BILL_.ADD_BILL2(TXT_GUID.Text, DGV.Rows(i).Cells(0).Value.ToString(), Val(DGV.Rows(i).Cells(3).Value), Val(DGV.Rows(i).Cells(4).Value), note_, Val(DGV.Rows(i).Cells(5).Value), Val(DGV.Rows(i).Cells(6).Value), DGV.Rows(i).Cells(11).Value.ToString(), DGV.Rows(i).Cells(9).Value.ToString(), Val(DGV.Rows(i).Cells(10).Value), Val(recep_), DGV.Rows(i).Cells(1).Value.ToString())




            End If
        Next


    End Sub
    Sub balance____()

        For i As Integer = 0 To DGV.Rows.Count - 1
            If DGV.Rows(i).Cells(0).Value <> Nothing Then
                If DGV.Rows(i).Cells(13).Value = True Then



                    Dim dt_ As New DataTable
                    dt_.Clear()
                    dt_ = CLS_ITEME_.balance____(DGV.Rows(i).Cells(0).Value.ToString())
                    If dt_.Rows.Count > 0 Then
                        CLS_ITEME_.BUANCE_ADD(Val(dt_.Rows(0)(1).ToString()), DGV.Rows(i).Cells(0).Value.ToString())
                    End If
                End If
            End If



        Next
    End Sub
    Sub update_bill2()

        For i As Integer = 0 To DGV.Rows.Count - 1

            If DGV.Rows(i).Cells(0).Value <> Nothing Then

                Dim note_ As String
                If DGV.Rows(i).Cells(8).Value = Nothing Then
                    note_ = TXT_ID.Text + "/" + Me.Text
                Else
                    note_ = DGV.Rows(i).Cells(8).Value.ToString()
                End If


                Dim recep_ As Integer
                If DGV.Rows(i).Cells(13).Value = True Then
                    recep_ = 1
                Else
                    recep_ = 0
                End If



                CLS_BILL_.ADD_BILL2(TXT_GUID.Text, DGV.Rows(i).Cells(0).Value.ToString(), Val(DGV.Rows(i).Cells(3).Value), Val(DGV.Rows(i).Cells(4).Value), note_, Val(DGV.Rows(i).Cells(5).Value), Val(DGV.Rows(i).Cells(6).Value), DGV.Rows(i).Cells(11).Value.ToString(), DGV.Rows(i).Cells(9).Value.ToString(), Val(DGV.Rows(i).Cells(10).Value), Val(recep_), DGV.Rows(i).Cells(1).Value.ToString())





            End If
        Next


    End Sub
   
   

    Private Sub ComboBox1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles CMB_TYPE_PAY.KeyPress
        e.Handled = True
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CMB_TYPE_PAY.SelectedIndexChanged

    End Sub

    Private Sub جديدToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles جديدToolStripMenuItem.Click
        Try
            new__()
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub
    Sub new__()
        MAX_1()

        DGV.Rows.Clear()
        For I As Integer = 0 To 999
            DGV.Rows.Add()
            DGV.Rows(I).HeaderCell.Value = (DGV.Rows(I).Index + 1).ToString
        Next

        TXT_TOTAL_SUB.Text = "0"
       
        TXT_NOTE.Text = Nothing
        DTP1.Value = Today
        NavUPDATE.Enabled = True
        NavDELETE.Enabled = True
    End Sub
    Private Sub TXT_DISC_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If (e.KeyChar >= "a" And e.KeyChar <= "z") Or (e.KeyChar >= "A" And e.KeyChar <= "Z") Or (e.KeyChar >= "ا" And e.KeyChar <= "ي") Then
            e.Handled = True
        End If
    End Sub

    Private Sub TXT_DISC_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            total_()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub تعديلToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NavUPDATE.Click
        Try


            DGV.ReadOnly = True
            If TXT_GUID.Text = Nothing Then
                MessageBox.Show("  لايوجد فاتورة", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
            '---------------------------------------------------------------------
            If TXT_TOTAL_SUB.Text = "0" Then
                MessageBox.Show(" مجموع الفاتورة =0", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
            '---------------------------------------------------------------------
            If TXT_GUID_CUSTOMER.Text = Nothing Then
                MessageBox.Show("  يجب اخيار الطرف الثاني", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If

            '---------------------------------------------------------------------

            If TXT_GUID_STORE.Text = Nothing Then
                MessageBox.Show("   يجب اختيار مستودع ", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
            '---------------------------------------------------------------------

            update_bill1()
            delete_bill2()
            update_bill2()
            balance____()
            DGV.ReadOnly = False

            If is_day = 1 Then
                If TXT_NUMBER_TYPE.Text = "7" Then


                    avg____()

                End If
            End If

            '----------------------------
            MAX_1_b()
            note_b = "0"
            add_b1()

            add_b2()
            '-------------------------------------


            MessageBox.Show("   تمت عملية تعديل الفاتورة بنجاح ", "تاكيد", MessageBoxButtons.OK, MessageBoxIcon.Information)




        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub
    Sub add_b2()
        Dim GUID__ As String
        Dim dt As New DataTable
        dt.Clear()
        dt = CLS_B_.guid__(TXT_PARENT_GUID.Text, Val(max_id_b))
        GUID__ = dt.Rows(0)(0).ToString()

        For i As Integer = 0 To DGV_B.Rows.Count - 1

            If DGV_B.Rows(i).Cells("guid1").Value <> Nothing Then


                'If DGV_B.Rows(i).Cells("note1").Value = Nothing Then
                '    note_b = TXT_ID.Text + "/" + Me.Text
                'Else
                '    note_ = DGV_B.Rows(i).Cells("note1").Value.ToString()
                'End If


                Dim recep_ As Integer
                If DGV_B.Rows(i).Cells("recipt1").Value = True Then
                    recep_ = 1
                Else
                    recep_ = 0
                End If



                CLS_B_.ADD_BILL2(GUID__, DGV_B.Rows(i).Cells("guid1").Value.ToString(), Val(DGV_B.Rows(i).Cells("qty1").Value), Val(DGV_B.Rows(i).Cells("price1").Value), note_b, Val(DGV_B.Rows(i).Cells("disc1").Value), Val(DGV_B.Rows(i).Cells("extra1").Value), DGV_B.Rows(i).Cells("guid_store1").Value.ToString(), DGV_B.Rows(i).Cells("unit1").Value.ToString(), Val(DGV_B.Rows(i).Cells("qty_unit1").Value), Val(recep_), DGV_B.Rows(i).Cells("barcode1").Value.ToString())




            End If
        Next


    End Sub
    Sub add_b1()
  



        CLS_B_.ADD_BILL1(TXT_PARENT_GUID.Text,
                         Val(TXT_ID.Text),
                         TXT_GUID_CUSTOMER.Text,
                         note_b,
                         TXT_GUID_STORE.Text,
                         DTP1.Value, Val(0),
                         CMB_TYPE_PAY.Text,
                         TXT_GUID_JOB.Text,
                         TXT_GUID_CURRENCY.Text,
                         Val(TXT_CURRENCY_VAL.Text),
                         Val(TXT_ID.Text),
                         guid_user_log,
                         0,
                         Val(TXT_TOTAL_SUB.Text) * Val(TXT_CURRENCY_VAL.Text),
                         0,
                         Val(TXT_TOTAL_SUB.Text),
                         0,
                         0,
                         "",
                        "",
                         "",
                        "",
                        "",
                         "",
                         "",
                         0,
                         "00000000-0000-0000-0000-000000000000",
                         "00000000-0000-0000-0000-000000000000",
                         0,
                         "00000000-0000-0000-0000-000000000000",
                         DTP_TIME.Value)
    End Sub
    Sub MAX_1_b()
        Dim DT As New DataTable
        DT.Clear()
        DT = CLS_B_.MAX_1(TXT_PARENT_GUID.Text)
        If DT.Rows.Count > 0 Then
            max_id_b = DT.Rows(0)(0).ToString()
        End If
    End Sub

    Private Sub حذفToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NavDELETE.Click
        Try




            If TXT_GUID.Text = Nothing Then
                MessageBox.Show("  لايوجد فاتورة", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
            '---------------------------------------------------------------------
            If MessageBox.Show("هل انت متاكد من عملية الحذف", "تنبيه", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = Windows.Forms.DialogResult.Yes Then
                DGV.ReadOnly = True
                'حذف الفاتورة
                'delete_bill2()
                delete_bill1()
                balance____()
                '---------------------------------------------------------------------
                DGV.ReadOnly = False
                If is_day = 1 Then
                    If TXT_NUMBER_TYPE.Text = "7" Then


                        avg____()

                    End If
                End If
                MessageBox.Show("   تمت عملية حذف الفاتورة بنجاح ", "تاكيد", MessageBoxButtons.OK, MessageBoxIcon.Information)
                '----------------------------
                MAX_1_b()
                note_b = "1"
                add_b1()

                add_b2()
                '-------------------------------------

                TXT_GUID.Text = Nothing

            End If





        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    
   
 

    Private Sub TXT_NAME_CUSTOMET_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        e.Handled = True
    End Sub

    Private Sub TXT_NAME_CUSTOMET_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub TXT_STORE_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        e.Handled = True
    End Sub

    Private Sub TXT_STORE_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub TXT_TOTAL_SUB_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TXT_TOTAL_SUB.KeyPress
        e.Handled = True
    End Sub

    Private Sub TXT_TOTAL_SUB_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TXT_TOTAL_SUB.TextChanged

    End Sub

    Private Sub TXT_TOTAL_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        e.Handled = True
    End Sub

    Private Sub TXT_TOTAL_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub


    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
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

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Try
            Dim F As New FRM_ALL_CURRENCY
            F.ShowDialog()
            If F.IS_YES = True Then
                Dim I As Integer = F.DGV.CurrentRow.Index
                TXT_GUID_CURRENCY.Text = F.DGV.Rows(I).Cells(0).Value.ToString()
                TXT_CURRENCY.Text = F.DGV.Rows(I).Cells(2).Value.ToString()
                TXT_CURRENCY_VAL.Text = Val(F.DGV.Rows(I).Cells(4).Value.ToString()).ToString("0.00")
                total_()
            End If

        Catch ex As Exception

        End Try
    End Sub

    Private Sub TXT_PARENT_GUID_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TXT_PARENT_GUID.TextChanged
        Try
            account_bill()
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub TXT_CURRENCY_VAL_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TXT_CURRENCY_VAL.KeyPress
        If (e.KeyChar >= "a" And e.KeyChar <= "z") Or (e.KeyChar >= "A" And e.KeyChar <= "Z") Or (e.KeyChar >= "ا" And e.KeyChar <= "ي") Then
            e.Handled = True
        End If
    End Sub

    Private Sub TXT_CURRENCY_VAL_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TXT_CURRENCY_VAL.TextChanged

    End Sub

    Private Sub GroupPanel2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupPanel2.Click

    End Sub

    Private Sub ToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NavPRENT.Click
        Try
            Dim dt1 As New DataTable
            dt1.Clear()
            dt1 = CLS_BILL_.show_bill1(Val(TXT_ID.Text), TXT_PARENT_GUID.Text)
            If dt1.Rows.Count < 0 Then
                MessageBox.Show("  لايمكن طباعة فاتورة غير موجود", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If


            Dim dt As New DataTable
            With dt
                .Columns.Add("b1_date")
                .Columns.Add("b1_customer")
                .Columns.Add("b1_job")
                .Columns.Add("b1_note")
                .Columns.Add("b1_pay")
                .Columns.Add("b1_store")
                .Columns.Add("b1_currency")

                .Columns.Add("b2_barcode")
                .Columns.Add("b2_iteme")
                .Columns.Add("b2_qty")
                .Columns.Add("b2_price")
                .Columns.Add("b2_disc")
                .Columns.Add("b2_extra")
                .Columns.Add("b2_total")
                .Columns.Add("b2_note")
                .Columns.Add("b2_unit")


                .Columns.Add("total_bill2")
                .Columns.Add("disc")
                .Columns.Add("total")
                .Columns.Add("number")
                .Columns.Add("type_bill")








            End With

            '-------------------------------------------------------
            For I As Integer = 0 To DGV.Rows.Count - 1
                If DGV.Rows(I).Cells(0).Value <> Nothing Then
                    dt.Rows.Add(DTP1.Value.ToShortDateString(), "", TXT_JOB.Text, TXT_NOTE.Text, CMB_TYPE_PAY.Text, TXT_STORE.Text, TXT_CURRENCY.Text, DGV.Rows(I).Cells(1).Value, DGV.Rows(I).Cells(2).Value, DGV.Rows(I).Cells(3).Value, DGV.Rows(I).Cells(4).Value, DGV.Rows(I).Cells(5).Value, DGV.Rows(I).Cells(6).Value, DGV.Rows(I).Cells(7).Value, DGV.Rows(I).Cells(8).Value, DGV.Rows(I).Cells(9).Value, Val(TXT_TOTAL_SUB.Text), 0, Val(TXT_TOTAL_SUB.Text), Val(TXT_ID.Text), Me.Text)
                End If

            Next
            '-------------------------------------------------------

            Dim rptDoc As New CrystalDecisions.CrystalReports.Engine.ReportDocument
            'rptDoc = New Crystal_bill

            Dim FF As New FRM_LOAD_REP

            FF.TXT_PATH.Text = "C:\conn\PRT\bill"

            FF.ShowDialog()

            Dim PATH_REP As String
            If FF.ISOK_ = True Then
                Dim III As Integer = FF.dgv.CurrentRow.Index
                PATH_REP = FF.dgv.Rows(III).Cells(1).Value.ToString()
                rptDoc.Load(PATH_REP)
            End If


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

    Private Sub TXT_STORE_KeyPress1(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TXT_STORE.KeyPress
        e.Handled = True
    End Sub

    Private Sub TXT_STORE_TextChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TXT_STORE.TextChanged

    End Sub

    

 
    Private Sub حذفالسطرToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles حذفالسطرToolStripMenuItem.Click
        Try
            If MessageBox.Show("هل انت متاكد من عملية حذف السطر", "تنبيه", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = Windows.Forms.DialogResult.Yes Then

                DGV.Rows.RemoveAt(DGV.CurrentRow.Index)
                total_()
                For I As Integer = 0 To 999

                    DGV.Rows(I).HeaderCell.Value = (DGV.Rows(I).Index + 1).ToString
                Next
            End If


        Catch ex As Exception

        End Try
    End Sub

    Private Sub حشرسطرToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles حشرسطرToolStripMenuItem.Click
        Try
            Dim iI As Integer = DGV.CurrentRow.Index
            DGV.Rows.Insert(iI)
            For I As Integer = 0 To 999

                DGV.Rows(I).HeaderCell.Value = (DGV.Rows(I).Index + 1).ToString
            Next
        Catch ex As Exception

        End Try
    End Sub

    Private Sub TXT_JOB_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TXT_JOB.KeyPress
        e.Handled = True
    End Sub

    Private Sub TXT_JOB_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TXT_JOB.TextChanged

    End Sub

    Private Sub DGV_EditingControlShowing(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewEditingControlShowingEventArgs) Handles DGV.EditingControlShowing
        Dim i As Integer = DGV.CurrentCell.RowIndex
        Dim j As Integer = DGV.CurrentCell.ColumnIndex


        If j = 3 Or j = 4 Or j = 5 Or j = 6 Then
            column_index = DGV.CurrentCell().ColumnIndex

            Dim TextEdit As TextBox = e.Control

            RemoveHandler TextEdit.KeyPress, AddressOf TextBox_KeyPress_Number
            AddHandler TextEdit.KeyPress, AddressOf TextBox_KeyPress_Number
        End If
    End Sub
    Public Sub TextBox_KeyPress_Number(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)

        Dim i As Integer = DGV.CurrentCell.RowIndex
        Dim j As Integer = DGV.CurrentCell.ColumnIndex

        If j = 3 Or j = 4 Or j = 5 Or j = 6 Then
            Select Case column_index = 0
                Case 0

                    If (e.KeyChar >= "a" And e.KeyChar <= "z") Or (e.KeyChar >= "A" And e.KeyChar <= "Z") Or (e.KeyChar >= "ا" And e.KeyChar <= "ي") Then
                        e.Handled = True
                    End If



            End Select

        End If
    End Sub

    Private Sub بحثToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles بحثToolStripMenuItem.Click
        Try
            Dim I As Integer = DGV.CurrentCell.RowIndex
            Dim J As Integer = DGV.CurrentCell.ColumnIndex
            Dim f As New FRM_ALL_ITEME

            f.ShowDialog()
            If f.isyes = True Then

                For ii As Integer = 0 To f.DGV.Rows.Count - 1
                    If f.DGV.Rows(ii).Cells(5).Value = True Then
                        'DGV.Rows.Add(f.DGV.Rows(ii).Cells(0).Value.ToString(), f.DGV.Rows(ii).Cells(3).Value.ToString(), f.DGV.Rows(ii).Cells(1).Value.ToString())
                        DGV.Rows(I).Cells(0).Value = f.DGV.Rows(ii).Cells(0).Value.ToString()
                        DGV.Rows(I).Cells(1).Value = f.DGV.Rows(ii).Cells(1).Value.ToString()
                        DGV.Rows(I).Cells(2).Value = f.DGV.Rows(ii).Cells(2).Value.ToString()


                        DGV.Rows(I).Cells(3).Value = 1
                        DGV.Rows(I).Cells(4).Value = 1
                        DGV.Rows(I).Cells(5).Value = 0
                        DGV.Rows(I).Cells(6).Value = 0
                        DGV.Rows(I).Cells(7).Value = 1




                        DGV.Rows(I).Cells(9).Value = f.DGV.Rows(ii).Cells(3).Value.ToString()
                        DGV.Rows(I).Cells(10).Value = 1
                        DGV.Rows(I).Cells(11).Value = TXT_GUID_STORE.Text
                        DGV.Rows(I).Cells(12).Value = TXT_STORE.Text
                        DGV.Rows(I).Cells(13).Value = True

                        I = I + 1
                    End If
                Next

            End If





            total_()

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try


    End Sub

    Private Sub بطاقةحسابToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles بطاقةحسابToolStripMenuItem.Click
        Try

            Dim I As Integer = DGV.CurrentRow.Index
            Dim F As New FRM_ITEME
            F.SHOW_CMB()
            F.TXT_ITEME_GUID.Text = DGV.Rows(I).Cells(0).Value.ToString()
            F.ShowDialog()

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub حسابجديدToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles حسابجديدToolStripMenuItem.Click
        Dim F As New FRM_ITEME
        F.SHOW_CMB()

        F.ShowDialog()
    End Sub

    Private Sub TXT_CURRENCY_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TXT_CURRENCY.KeyPress
        e.Handled = True
    End Sub

    Private Sub TXT_CURRENCY_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TXT_CURRENCY.TextChanged

    End Sub
End Class