Imports System.IO

Public Class FRM_BILL
    Dim CLS_STORE_ As New CLS_STORE
    Dim CLS_ITEME_ As New CLS_ITEME
    Dim CLS_ACCOUNT_ As New CLS_ACCOUNT
    Dim CLS_BILL_ As New CLS_BILL
    Dim CLS_DAY_ As New CLS_DAY
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

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            'number_day___ = 0
            'Dim f As New FRM_ALL_ACCOUNT
            'f.ShowDialog()
            'If f.IS_YES = True Then
            '    Dim i As Integer = f.DGV.CurrentRow.Index
            '    TXT_GUID_CUSTOMER.Text = f.DGV.Rows(i).Cells(0).Value.ToString()
            '    TXT_NAME_CUSTOMET.Text = f.DGV.Rows(i).Cells(1).Value.ToString()
            'End If


            Try
                Dim f As New FRM_ALL_CUS_VEN
                f.ShowDialog()
                If f.isok = True Then
                    Dim I As Integer = f.DGV.CurrentRow.Index

                    TXT_GUID_CUSTOMER.Text = f.DGV.Rows(I).Cells(13).Value.ToString()
                    TXT_NAME_CUSTOMET.Text = f.DGV.Rows(I).Cells(2).Value.ToString()
                End If
            Catch ex As Exception

            End Try
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
            TXT_TOTAL.Text = "0"
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
            TXT_TYPE_PRICE.Text = dt.Rows(0)(4).ToString()
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
    Sub MAX_1_b()
        Dim DT As New DataTable
        DT.Clear()
        DT = CLS_B_.MAX_1(TXT_PARENT_GUID.Text)
        If DT.Rows.Count > 0 Then
            max_id_b = DT.Rows(0)(0).ToString()
        End If
    End Sub

    Private Sub DGV_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGV.CellClick
        Try
            Dim I As Integer = DGV.CurrentCell.RowIndex
            Dim J As Integer = DGV.CurrentCell.ColumnIndex
            If J = 9 Then
                If DGV.Rows(I).Cells("guid").Value <> Nothing Then
                    Dim DT As New DataTable
                    DT.Clear()

                    DT = CLS_ITEME_.SHOW_UNIT__(DGV.Rows(I).Cells("guid").Value.ToString())
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
                            DGV.Rows(I).Cells("unit").Value = F.DGV.Rows(II).Cells(0).Value.ToString()
                            DGV.Rows(I).Cells("qty_unit").Value = F.DGV.Rows(II).Cells(1).Value.ToString()

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




            If J = 1 Then

                If DGV.Rows(I).Cells("barcode").Value = Nothing Then
                    Exit Sub
                End If
                'باركود1
                Dim DT As New DataTable
                DT.Clear()
                DT = CLS_ITEME_.searsh_BARCODE_1(DGV.Rows(I).Cells(J).Value.ToString())
                If DT.Rows.Count > 0 Then
                    DGV.Rows(I).Cells("guid").Value = DT.Rows(0)(0).ToString()
                    DGV.Rows(I).Cells("barcode").Value = DT.Rows(0)(1).ToString()
                    DGV.Rows(I).Cells("name_iteme").Value = DT.Rows(0)(2).ToString()
                    DGV.Rows(I).Cells("qty").Value = 1

                    If TXT_TYPE_PRICE.Text = "0" Then
                        DGV.Rows(I).Cells("price").Value = Val(DT.Rows(0)(5).ToString()) / Val(TXT_CURRENCY_VAL.Text)
                    ElseIf TXT_TYPE_PRICE.Text = "1" Then
                        DGV.Rows(I).Cells("price").Value = Val(DT.Rows(0)(6).ToString()) / Val(TXT_CURRENCY_VAL.Text)
                    ElseIf TXT_TYPE_PRICE.Text = "2" Then
                        DGV.Rows(I).Cells("price").Value = Val(DT.Rows(0)(7).ToString()) / Val(TXT_CURRENCY_VAL.Text)
                    ElseIf TXT_TYPE_PRICE.Text = "3" Then
                        DGV.Rows(I).Cells("price").Value = Val(DT.Rows(0)(8).ToString()) / Val(TXT_CURRENCY_VAL.Text)
                    ElseIf TXT_TYPE_PRICE.Text = "4" Then
                        DGV.Rows(I).Cells("price").Value = Val(DT.Rows(0)(9).ToString()) / Val(TXT_CURRENCY_VAL.Text)
                    ElseIf TXT_TYPE_PRICE.Text = "5" Then
                        DGV.Rows(I).Cells("price").Value = Val(DT.Rows(0)(10).ToString()) / Val(TXT_CURRENCY_VAL.Text)
                    ElseIf TXT_TYPE_PRICE.Text = "6" Then
                        DGV.Rows(I).Cells("price").Value = Val(DT.Rows(0)(11).ToString()) / Val(TXT_CURRENCY_VAL.Text)
                    End If



                    DGV.Rows(I).Cells("disc").Value = 0
                    DGV.Rows(I).Cells("extra").Value = 0

                    Dim qty_ As Double = Val(DGV.Rows(I).Cells("qty").Value)
                    Dim price_ As Double = Val(DGV.Rows(I).Cells("price").Value)

                    Dim disc_ As Double = Val(DGV.Rows(I).Cells("disc").Value)
                    Dim extea_ As Double = Val(DGV.Rows(I).Cells("extra").Value)
                    DGV.Rows(I).Cells(7).Value = (Val(qty_) * Val(price_)) + Val(extea_) - Val(disc_)

                    DGV.Rows(I).Cells("unit").Value = DT.Rows(0)(3).ToString()
                    DGV.Rows(I).Cells("qty_unit").Value = 1
                    DGV.Rows(I).Cells("guid_store").Value = TXT_GUID_STORE.Text
                    DGV.Rows(I).Cells("name_store").Value = TXT_STORE.Text
                    DGV.Rows(I).Cells("recipt").Value = True
                Else
                    DGV.Rows(I).Cells("guid").Value = Nothing
                    'DGV.Rows(I).Cells(1).Value = Nothing
                    DGV.Rows(I).Cells("name_iteme").Value = Nothing
                    DGV.Rows(I).Cells("qty").Value = Nothing
                    DGV.Rows(I).Cells("price").Value = Nothing
                    DGV.Rows(I).Cells("disc").Value = Nothing
                    DGV.Rows(I).Cells("extra").Value = Nothing
                    DGV.Rows(I).Cells("total").Value = Nothing

                    DGV.Rows(I).Cells("unit").Value = Nothing
                    DGV.Rows(I).Cells("qty_unit").Value = Nothing
                    DGV.Rows(I).Cells("guid_store").Value = Nothing
                    DGV.Rows(I).Cells("name_store").Value = Nothing
                    DGV.Rows(I).Cells("recipt").Value = False
                    'باركود2
                    Dim DT2 As New DataTable
                    DT2.Clear()
                    DT2 = CLS_ITEME_.searsh_BARCODE_2(DGV.Rows(I).Cells(J).Value.ToString())
                    If DT2.Rows.Count > 0 Then
                        DGV.Rows(I).Cells("guid").Value = DT2.Rows(0)(0).ToString()
                        DGV.Rows(I).Cells("barcode").Value = DT2.Rows(0)(1).ToString()
                        DGV.Rows(I).Cells("name_iteme").Value = DT2.Rows(0)(2).ToString()
                        DGV.Rows(I).Cells("qty").Value = 1
                        If TXT_TYPE_PRICE.Text = "0" Then
                            DGV.Rows(I).Cells("price").Value = Val(DT2.Rows(0)(5).ToString()) / Val(TXT_CURRENCY_VAL.Text)
                        ElseIf TXT_TYPE_PRICE.Text = "1" Then
                            DGV.Rows(I).Cells("price").Value = Val(DT2.Rows(0)(6).ToString()) / Val(TXT_CURRENCY_VAL.Text)
                        ElseIf TXT_TYPE_PRICE.Text = "2" Then
                            DGV.Rows(I).Cells("price").Value = Val(DT2.Rows(0)(7).ToString()) / Val(TXT_CURRENCY_VAL.Text)
                        ElseIf TXT_TYPE_PRICE.Text = "3" Then
                            DGV.Rows(I).Cells("price").Value = Val(DT2.Rows(0)(8).ToString()) / Val(TXT_CURRENCY_VAL.Text)
                        ElseIf TXT_TYPE_PRICE.Text = "4" Then
                            DGV.Rows(I).Cells("price").Value = Val(DT2.Rows(0)(9).ToString()) / Val(TXT_CURRENCY_VAL.Text)
                        ElseIf TXT_TYPE_PRICE.Text = "5" Then
                            DGV.Rows(I).Cells("price").Value = Val(DT2.Rows(0)(10).ToString()) / Val(TXT_CURRENCY_VAL.Text)
                        ElseIf TXT_TYPE_PRICE.Text = "6" Then
                            DGV.Rows(I).Cells("price").Value = Val(DT2.Rows(0)(11).ToString()) / Val(TXT_CURRENCY_VAL.Text)
                        End If


                        Dim qty_ As Double = Val(DGV.Rows(I).Cells("qty").Value)
                        Dim price_ As Double = Val(DGV.Rows(I).Cells("price").Value)

                        Dim disc_ As Double = Val(DGV.Rows(I).Cells("disc").Value)
                        Dim extea_ As Double = Val(DGV.Rows(I).Cells("extra").Value)
                        DGV.Rows(I).Cells(7).Value = (Val(qty_) * Val(price_)) + Val(extea_) - Val(disc_)

                        DGV.Rows(I).Cells("disc").Value = 0
                        DGV.Rows(I).Cells("extra").Value = 0
                        DGV.Rows(I).Cells("total").Value = 1

                        DGV.Rows(I).Cells("unit").Value = DT2.Rows(0)(3).ToString()
                        DGV.Rows(I).Cells("qty_unit").Value = DT2.Rows(0)(4).ToString()
                        DGV.Rows(I).Cells("guid_store").Value = TXT_GUID_STORE.Text
                        DGV.Rows(I).Cells("name_store").Value = TXT_STORE.Text
                        DGV.Rows(I).Cells("recipt").Value = True


                    Else

                        DGV.Rows(I).Cells("guid").Value = Nothing
                        'DGV.Rows(I).Cells(1).Value = Nothing
                        DGV.Rows(I).Cells("name_iteme").Value = Nothing
                        DGV.Rows(I).Cells("qty").Value = Nothing
                        DGV.Rows(I).Cells("price").Value = Nothing
                        DGV.Rows(I).Cells("disc").Value = Nothing
                        DGV.Rows(I).Cells("extra").Value = Nothing
                        DGV.Rows(I).Cells("total").Value = Nothing

                        DGV.Rows(I).Cells("unit").Value = Nothing
                        DGV.Rows(I).Cells("qty_unit").Value = Nothing
                        DGV.Rows(I).Cells("guid_store").Value = Nothing
                        DGV.Rows(I).Cells("name_store").Value = Nothing
                        DGV.Rows(I).Cells("recipt").Value = False


                        'باركود3
                        Dim DT3 As New DataTable
                        DT3.Clear()
                        DT3 = CLS_ITEME_.searsh_BARCODE_3(DGV.Rows(I).Cells(J).Value.ToString())
                        If DT3.Rows.Count > 0 Then
                            DGV.Rows(I).Cells("guid").Value = DT3.Rows(0)(0).ToString()
                            DGV.Rows(I).Cells("barcode").Value = DT3.Rows(0)(1).ToString()
                            DGV.Rows(I).Cells("name_iteme").Value = DT3.Rows(0)(2).ToString()
                            DGV.Rows(I).Cells("qty").Value = 1
                            If TXT_TYPE_PRICE.Text = "0" Then
                                DGV.Rows(I).Cells("price").Value = Val(DT3.Rows(0)(5).ToString()) / Val(TXT_CURRENCY_VAL.Text)
                            ElseIf TXT_TYPE_PRICE.Text = "1" Then
                                DGV.Rows(I).Cells("price").Value = Val(DT3.Rows(0)(6).ToString()) / Val(TXT_CURRENCY_VAL.Text)
                            ElseIf TXT_TYPE_PRICE.Text = "2" Then
                                DGV.Rows(I).Cells("price").Value = Val(DT3.Rows(0)(7).ToString()) / Val(TXT_CURRENCY_VAL.Text)
                            ElseIf TXT_TYPE_PRICE.Text = "3" Then
                                DGV.Rows(I).Cells("price").Value = Val(DT3.Rows(0)(8).ToString()) / Val(TXT_CURRENCY_VAL.Text)
                            ElseIf TXT_TYPE_PRICE.Text = "4" Then
                                DGV.Rows(I).Cells("price").Value = Val(DT3.Rows(0)(9).ToString()) / Val(TXT_CURRENCY_VAL.Text)
                            ElseIf TXT_TYPE_PRICE.Text = "5" Then
                                DGV.Rows(I).Cells("price").Value = Val(DT3.Rows(0)(10).ToString()) / Val(TXT_CURRENCY_VAL.Text)
                            ElseIf TXT_TYPE_PRICE.Text = "6" Then
                                DGV.Rows(I).Cells("price").Value = Val(DT3.Rows(0)(11).ToString()) / Val(TXT_CURRENCY_VAL.Text)
                            End If
                            DGV.Rows(I).Cells("disc").Value = 0
                            DGV.Rows(I).Cells("extra").Value = 0

                            Dim qty_ As Double = Val(DGV.Rows(I).Cells("qty").Value)
                            Dim price_ As Double = Val(DGV.Rows(I).Cells("price").Value)

                            Dim disc_ As Double = Val(DGV.Rows(I).Cells("disc").Value)
                            Dim extea_ As Double = Val(DGV.Rows(I).Cells("extra").Value)
                            DGV.Rows(I).Cells(7).Value = (Val(qty_) * Val(price_)) + Val(extea_) - Val(disc_)

                            DGV.Rows(I).Cells("unit").Value = DT3.Rows(0)(3).ToString()
                            DGV.Rows(I).Cells("qty_unit").Value = DT3.Rows(0)(4).ToString()
                            DGV.Rows(I).Cells("guid_store").Value = TXT_GUID_STORE.Text
                            DGV.Rows(I).Cells("name_store").Value = TXT_STORE.Text
                            DGV.Rows(I).Cells("recipt").Value = True
                        Else
                            DGV.Rows(I).Cells("guid").Value = Nothing
                            'DGV.Rows(I).Cells(1).Value = Nothing
                            DGV.Rows(I).Cells("name_iteme").Value = Nothing
                            DGV.Rows(I).Cells("qty").Value = Nothing
                            DGV.Rows(I).Cells("price").Value = Nothing
                            DGV.Rows(I).Cells("disc").Value = Nothing
                            DGV.Rows(I).Cells("extra").Value = Nothing
                            DGV.Rows(I).Cells("total").Value = Nothing

                            DGV.Rows(I).Cells("unit").Value = Nothing
                            DGV.Rows(I).Cells("qty_unit").Value = Nothing
                            DGV.Rows(I).Cells("guid_store").Value = Nothing
                            DGV.Rows(I).Cells("name_store").Value = Nothing
                            DGV.Rows(I).Cells("recipt").Value = False
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
                        If TXT_TYPE_PRICE.Text = "0" Then
                            DGV.Rows(I).Cells("price").Value = Val(dt.Rows(0)(6).ToString()) / Val(TXT_CURRENCY_VAL.Text)
                        ElseIf TXT_TYPE_PRICE.Text = "1" Then
                            DGV.Rows(I).Cells("price").Value = Val(dt.Rows(0)(7).ToString()) / Val(TXT_CURRENCY_VAL.Text)
                        ElseIf TXT_TYPE_PRICE.Text = "2" Then
                            DGV.Rows(I).Cells("price").Value = Val(dt.Rows(0)(8).ToString()) / Val(TXT_CURRENCY_VAL.Text)
                        ElseIf TXT_TYPE_PRICE.Text = "3" Then
                            DGV.Rows(I).Cells("price").Value = Val(dt.Rows(0)(9).ToString()) / Val(TXT_CURRENCY_VAL.Text)
                        ElseIf TXT_TYPE_PRICE.Text = "4" Then
                            DGV.Rows(I).Cells("price").Value = Val(dt.Rows(0)(10).ToString()) / Val(TXT_CURRENCY_VAL.Text)
                        ElseIf TXT_TYPE_PRICE.Text = "5" Then
                            DGV.Rows(I).Cells("price").Value = Val(dt.Rows(0)(11).ToString()) / Val(TXT_CURRENCY_VAL.Text)
                        ElseIf TXT_TYPE_PRICE.Text = "6" Then
                            DGV.Rows(I).Cells("price").Value = Val(dt.Rows(0)(12).ToString()) / Val(TXT_CURRENCY_VAL.Text)
                        End If
                        DGV.Rows(I).Cells(5).Value = 0
                        DGV.Rows(I).Cells(6).Value = 0

                        Dim qty_ As Double = Val(DGV.Rows(I).Cells("qty").Value)
                        Dim price_ As Double = Val(DGV.Rows(I).Cells("price").Value)

                        Dim disc_ As Double = Val(DGV.Rows(I).Cells("disc").Value)
                        Dim extea_ As Double = Val(DGV.Rows(I).Cells("extra").Value)
                        DGV.Rows(I).Cells(7).Value = (Val(qty_) * Val(price_)) + Val(extea_) - Val(disc_)

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
                                    If TXT_TYPE_PRICE.Text = "0" Then
                                        DGV.Rows(I).Cells("price").Value = Val(f.DGV.Rows(ii).Cells(6).Value.ToString()) / Val(TXT_CURRENCY_VAL.Text)
                                    ElseIf TXT_TYPE_PRICE.Text = "1" Then
                                        DGV.Rows(I).Cells("price").Value = Val(f.DGV.Rows(ii).Cells(7).Value.ToString()) / Val(TXT_CURRENCY_VAL.Text)
                                    ElseIf TXT_TYPE_PRICE.Text = "2" Then
                                        DGV.Rows(I).Cells("price").Value = Val(f.DGV.Rows(ii).Cells(8).Value.ToString()) / Val(TXT_CURRENCY_VAL.Text)
                                    ElseIf TXT_TYPE_PRICE.Text = "3" Then
                                        DGV.Rows(I).Cells("price").Value = Val(f.DGV.Rows(ii).Cells(9).Value.ToString()) / Val(TXT_CURRENCY_VAL.Text)
                                    ElseIf TXT_TYPE_PRICE.Text = "4" Then
                                        DGV.Rows(I).Cells("price").Value = Val(f.DGV.Rows(ii).Cells(10).Value.ToString()) / Val(TXT_CURRENCY_VAL.Text)
                                    ElseIf TXT_TYPE_PRICE.Text = "5" Then
                                        DGV.Rows(I).Cells("price").Value = Val(f.DGV.Rows(ii).Cells(11).Value.ToString()) / Val(TXT_CURRENCY_VAL.Text)
                                    ElseIf TXT_TYPE_PRICE.Text = "6" Then
                                        DGV.Rows(I).Cells("price").Value = Val(f.DGV.Rows(ii).Cells(12).Value.ToString()) / Val(TXT_CURRENCY_VAL.Text)
                                    End If
                                    DGV.Rows(I).Cells(5).Value = 0
                                    DGV.Rows(I).Cells(6).Value = 0

                                    Dim qty_ As Double = Val(DGV.Rows(I).Cells("qty").Value)
                                    Dim price_ As Double = Val(DGV.Rows(I).Cells("price").Value)

                                    Dim disc_ As Double = Val(DGV.Rows(I).Cells("disc").Value)
                                    Dim extea_ As Double = Val(DGV.Rows(I).Cells("extra").Value)
                                    DGV.Rows(I).Cells(7).Value = (Val(qty_) * Val(price_)) + Val(extea_) - Val(disc_)


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


                Dim qty_ As Double = Val(DGV.Rows(I).Cells("qty").Value)
                Dim price_ As Double = Val(DGV.Rows(I).Cells("price").Value)

                Dim disc_ As Double = Val(DGV.Rows(I).Cells("disc").Value)
                Dim extea_ As Double = Val(DGV.Rows(I).Cells("extra").Value)
                DGV.Rows(I).Cells(7).Value = (Val(qty_) * Val(price_)) + Val(extea_) - Val(disc_)

            End If
        
            If DGV.Rows(I).Cells(0).Value <> Nothing And DGV.Rows(I).Cells(11).Value <> Nothing Then
                Dim DT_BALANCE As New DataTable
                DT_BALANCE.Clear()
                DT_BALANCE = CLS_ITEME_.balance____ITEME_STORE(DGV.Rows(I).Cells(0).Value.ToString(), DGV.Rows(I).Cells(11).Value.ToString())

                If DT_BALANCE.Rows.Count > 0 Then
                    TXT_NAME_STORE_B.Text = DGV.Rows(I).Cells(2).Value.ToString()
                    TXT_NAME_ITEME_B.Text = DGV.Rows(I).Cells(12).Value.ToString()
                    TXT_BALANCE_B.Text = DT_BALANCE.Rows(0)(1).ToString()
                    If TXT_BALANCE_B.Text = Nothing Then
                        TXT_BALANCE_B.Text = "0"
                    End If
                    Dim QTY_D As Double = 0
                    QTY_D = Val(DGV.Rows(I).Cells(3).Value) * Val(DGV.Rows(I).Cells(10).Value)
                    If TXT_NUMBER_TYPE.Text = "2" Then
                        If Val(QTY_D) > Val(TXT_BALANCE_B.Text) Then
                            MessageBox.Show("الكمية اكبر من رصيد المسنتودع", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.None)
                        End If

                    End If
                Else

                    TXT_NAME_STORE_B.Text = Nothing
                    TXT_NAME_ITEME_B.Text = Nothing
                    TXT_BALANCE_B.Text = Nothing

                End If
            End If

            total_()
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub
    Sub total_()

        Dim xtra_ As Double = 0
        Dim disc_ As Double = 0
        Dim tot_ As Double = 0
        For i As Integer = 0 To DGV.Rows.Count - 1
            If DGV.Rows(i).Cells("guid").Value <> Nothing Then

                xtra_ = Val(xtra_) + Val(DGV.Rows(i).Cells("extra").Value)
                disc_ = Val(disc_) + Val(DGV.Rows(i).Cells("disc").Value)
                tot_ = Val(tot_) + Val(DGV.Rows(i).Cells("total").Value)

            End If
        Next
        TXT_EXTRA_PEL.Text = xtra_.ToString("0.000")
        TXT_DISC_PEL.Text = disc_.ToString("0.000")
        TXT_TOTAL_SUB.Text = tot_.ToString("0.000")


        TXT_TOTAL.Text = (Val(TXT_TOTAL_SUB.Text) - Val(TXT_DISC.Text)).ToString("0.000")
        'TXT_TOTAL.Text = (Val(tot_) + Val(xtra_) - Val(TXT_DISC.Text) - Val(disc_)).ToString("0.000")



    End Sub

    Private Sub TXT_ID_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TXT_ID.KeyPress
        e.Handled = True
    End Sub
    Private Sub TXT_ID_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TXT_ID.TextChanged
        Try
            TXT_NAME_STORE_B.Text = Nothing
            TXT_NAME_ITEME_B.Text = Nothing
            TXT_BALANCE_B.Text = Nothing
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
            show_day()


            '--------------------------------------------------------------------
            If TXT_GUID.Text <> Nothing Then
                SHOW_B()

            Else
                For I As Integer = 0 To 999
                    DGV_B.Rows.Add()
                    DGV_B.Rows(I).HeaderCell.Value = (DGV_B.Rows(I).Index + 1).ToString
                Next
            End If
            '--------------------------------------------------------------------
            'If Val(TXT_ID.Text) > 10 Then
            '    Close()
            'End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
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

    Sub bill1()

        Dim dt As New DataTable
        dt.Clear()
        dt = CLS_BILL_.show_bill1(Val(TXT_ID.Text), TXT_PARENT_GUID.Text)
        If dt.Rows.Count > 0 Then
            DTP1.Value = Convert.ToDateTime(dt.Rows(0)(9).ToString())
            TXT_GUID_CUSTOMER.Text = dt.Rows(0)(4).ToString()
            'TXT_NAME_CUSTOMET.Text = dt.Rows(0)(5).ToString()
            TXT_NOTE.Text = dt.Rows(0)(6).ToString()

            TXT_STORE.Text = dt.Rows(0)(8).ToString()
            TXT_GUID_STORE.Text = dt.Rows(0)(7).ToString()

            TXT_GUID.Text = dt.Rows(0)(0).ToString()


            CMB_TYPE_PAY.Text = dt.Rows(0)(11).ToString()

            TXT_GUID_CURRENCY.Text = dt.Rows(0)(12).ToString()

            TXT_CURRENCY.Text = dt.Rows(0)(13).ToString()

            TXT_CURRENCY_VAL.Text = Val(dt.Rows(0)(14).ToString()).ToString("0.00")


            'TXT_EXTRA.Text = Val(dt.Rows(0)(15).ToString()).ToString("0.00")

            Dim type___ As Integer = Val(dt.Rows(0)(16).ToString())
            If type___ = 0 Then
                Radio_disc_m.Checked = True
                Radio_disc_n.Checked = False
            Else
                Radio_disc_m.Checked = False
                Radio_disc_n.Checked = True
            End If
            TXT_R_DISC.Text = Val(dt.Rows(0)(17).ToString())
            TXT_DISC.Text = Val(dt.Rows(0)(10).ToString()).ToString("0.00")




            TXT_NAME_CUSTOMET.Text = dt.Rows(0)(18).ToString()
            TXT_MOBILE_1.Text = dt.Rows(0)(19).ToString()
            TXT_MOBILE_2.Text = dt.Rows(0)(20).ToString()
            TXT_CUNTRY.Text = dt.Rows(0)(21).ToString()
            TXT_STREET.Text = dt.Rows(0)(22).ToString()
            TXT_PHONE.Text = dt.Rows(0)(23).ToString()
            TXT_MAIL.Text = dt.Rows(0)(24).ToString()

        Else
            DTP1.Value = Today
            'TXT_GUID_CUSTOMER.Text = Nothing
            'TXT_NAME_CUSTOMET.Text = Nothing
            TXT_NOTE.Text = Nothing

            'TXT_STORE.Text = Nothing
            'TXT_GUID_STORE.Text = Nothing

            TXT_GUID.Text = Nothing
            TXT_DISC.Text = "0"
            TXT_R_DISC.Text = Nothing


            TXT_NAME_CUSTOMET.Text = Nothing
            TXT_MOBILE_1.Text = Nothing
            TXT_MOBILE_2.Text = Nothing
            TXT_CUNTRY.Text = Nothing
            TXT_STREET.Text = Nothing
            TXT_PHONE.Text = Nothing
            TXT_MAIL.Text = Nothing
        End If
    End Sub

    Private Sub حفظToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Nav_SAVE.Click
        Try

            DGV.ReadOnly = True

            DTP_TIME.Value = Today
            '------------------------------------------------------------------------

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
            'If TXT_GUID_CUSTOMER.Text = Nothing Then
            '    MessageBox.Show("  يجب اخيار الطرف الثاني", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error)
            '    Exit Sub
            'End If
            If CMB_TYPE_PAY.Text = "اجل" And TXT_GUID_CUSTOMER.Text = Nothing Then
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

            If TXT_GUID_CUSTOMER.Text = Nothing Then
                TXT_GUID_CUSTOMER.Text = "00000000-0000-0000-0000-000000000000"
            End If






            MAX_1()
            add_bill1()
            add_bill2()
            balance____()
            DGV.ReadOnly = False
            MAX_day_bill()
            If is_day = 1 Then
                If TXT_NUMBER_TYPE.Text = "0" Then
                    'مشتريات
                    add_day_purshase()

                    avg____()
                    LastPrice____()
                ElseIf TXT_NUMBER_TYPE.Text = "1" Then
                    'مردودات مشتريات
                    reture_pursh()
                    '
                    avg____()
                ElseIf TXT_NUMBER_TYPE.Text = "2" Then
                    'مبيعات
                    sales_()
                ElseIf TXT_NUMBER_TYPE.Text = "3" Then
                    'مردودات مبيعات
                    sales_return()
                End If

            End If


            show_day()


            NavUPDATE.Enabled = False
            NavDELETE.Enabled = False

            MessageBox.Show("   تمت عملية حفظ الفاتورة بنجاح ", "تاكيد", MessageBoxButtons.OK, MessageBoxIcon.Information)



        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Sub add_bill1()
        Dim type__ As Integer
        If Radio_disc_m.Checked = True Then
            type__ = 0
        Else
            type__ = 1
        End If
        CLS_BILL_.ADD_BILL1(TXT_PARENT_GUID.Text,
                            Val(TXT_ID.Text),
                            TXT_GUID_CUSTOMER.Text,
                            TXT_NOTE.Text,
                            TXT_GUID_STORE.Text,
                            DTP1.Value,
                            Val(TXT_DISC.Text) * Val(TXT_CURRENCY_VAL.Text),
                            CMB_TYPE_PAY.Text,
                            TXT_GUID_JOB.Text,
                            TXT_GUID_CURRENCY.Text,
                            Val(TXT_CURRENCY_VAL.Text),
                            0,
                            guid_user_log,
                            0,
                            Val(TXT_DISC_PEL.Text) * Val(TXT_CURRENCY_VAL.Text),
                            Val(TXT_EXTRA_PEL.Text) * Val(TXT_CURRENCY_VAL.Text),
                            Val(TXT_TOTAL.Text) * Val(TXT_CURRENCY_VAL.Text),
                            Val(type__),
                            Val(TXT_R_DISC.Text),
                            TXT_NAME_CUSTOMET.Text,
                            TXT_MOBILE_1.Text,
                            TXT_MOBILE_2.Text,
                            TXT_CUNTRY.Text,
                            TXT_STREET.Text,
                            TXT_PHONE.Text,
                            TXT_MAIL.Text,
                            0,
                            "00000000-0000-0000-0000-000000000000",
                            "00000000-0000-0000-0000-000000000000",
                            0,
                             "00000000-0000-0000-0000-000000000000",
                                DTP_TIME.Value)
    End Sub

    Sub update_bill1()
        Dim type__ As Integer
        If Radio_disc_m.Checked = True Then
            type__ = 0
        Else
            type__ = 1
        End If
        CLS_BILL_.update_BILL1(TXT_PARENT_GUID.Text,
                               Val(TXT_ID.Text),
                               TXT_GUID_CUSTOMER.Text,
                               TXT_NOTE.Text,
                               TXT_GUID_STORE.Text,
                               DTP1.Value,
                               Val(TXT_DISC.Text) * Val(TXT_CURRENCY_VAL.Text),
                               CMB_TYPE_PAY.Text,
                               TXT_GUID_JOB.Text,
                               TXT_GUID_CURRENCY.Text, Val(TXT_CURRENCY_VAL.Text),
                               TXT_GUID.Text,
                               guid_user_log,
                               0,
                               Val(TXT_DISC_PEL.Text) * Val(TXT_CURRENCY_VAL.Text),
                               Val(TXT_EXTRA_PEL.Text) * Val(TXT_CURRENCY_VAL.Text),
                               Val(TXT_TOTAL.Text) * Val(TXT_CURRENCY_VAL.Text),
                               Val(type__),
                               Val(TXT_R_DISC.Text),
                                TXT_NAME_CUSTOMET.Text,
                                TXT_MOBILE_1.Text,
                                TXT_MOBILE_2.Text,
                                TXT_CUNTRY.Text,
                                TXT_STREET.Text,
                                 TXT_PHONE.Text,
                                TXT_MAIL.Text,
                                0,
                                "00000000-0000-0000-0000-000000000000",
                                "00000000-0000-0000-0000-000000000000",
                                 0,
                                "00000000-0000-0000-0000-000000000000",
                                DTP_TIME.Value)
    End Sub
    Sub add_b1()
        Dim type__ As Integer
        If Radio_disc_m.Checked = True Then
            type__ = 0
        Else
            type__ = 1
        End If
        CLS_B_.ADD_BILL1(TXT_PARENT_GUID.Text,
                            Val(max_id_b),
                            TXT_GUID_CUSTOMER.Text,
                           note_b,
                            TXT_GUID_STORE.Text,
                            DTP1.Value,
                            Val(TXT_DISC.Text) * Val(TXT_CURRENCY_VAL.Text),
                            CMB_TYPE_PAY.Text,
                            TXT_GUID_JOB.Text,
                            TXT_GUID_CURRENCY.Text,
                            Val(TXT_CURRENCY_VAL.Text),
                            Val(TXT_ID.Text),
                            guid_user_log,
                            0,
                            Val(TXT_DISC_PEL.Text) * Val(TXT_CURRENCY_VAL.Text),
                            Val(TXT_EXTRA_PEL.Text) * Val(TXT_CURRENCY_VAL.Text),
                            Val(TXT_TOTAL.Text) * Val(TXT_CURRENCY_VAL.Text),
                            Val(type__),
                            Val(TXT_R_DISC.Text),
                            TXT_NAME_CUSTOMET.Text,
                            TXT_MOBILE_1.Text,
                            TXT_MOBILE_2.Text,
                            TXT_CUNTRY.Text,
                            TXT_STREET.Text,
                            TXT_PHONE.Text,
                            TXT_MAIL.Text,
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

            If DGV.Rows(i).Cells("guid").Value <> Nothing Then

                Dim note_ As String
                If DGV.Rows(i).Cells("note").Value = Nothing Then
                    note_ = TXT_ID.Text + "/" + Me.Text
                Else
                    note_ = DGV.Rows(i).Cells("note").Value.ToString()
                End If


                Dim recep_ As Integer
                If DGV.Rows(i).Cells("recipt").Value = True Then
                    recep_ = 1
                Else
                    recep_ = 0
                End If



                CLS_BILL_.ADD_BILL2(TXT_GUID.Text, DGV.Rows(i).Cells("guid").Value.ToString(), Val(DGV.Rows(i).Cells("qty").Value), Val(DGV.Rows(i).Cells("price").Value), note_, Val(DGV.Rows(i).Cells("disc").Value), Val(DGV.Rows(i).Cells("extra").Value), DGV.Rows(i).Cells("guid_store").Value.ToString(), DGV.Rows(i).Cells("unit").Value.ToString(), Val(DGV.Rows(i).Cells("qty_unit").Value), Val(recep_), DGV.Rows(i).Cells("barcode").Value.ToString())




            End If
        Next


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
    Sub balance____()

        For i As Integer = 0 To DGV.Rows.Count - 1
            If DGV.Rows(i).Cells(13).Value = True Then


                If DGV.Rows(i).Cells(0).Value <> Nothing Then
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
    Sub LastPrice____()

        For i As Integer = 0 To DGV.Rows.Count - 1
            If DGV.Rows(i).Cells(0).Value <> Nothing Then
              
                Dim last__ As Double = (DGV.Rows(i).Cells(4).Value * DGV.Rows(i).Cells(10).Value) / Val(TXT_CURRENCY_VAL.Text)
                CLS_ITEME_.lastprice_(Val(last__), DGV.Rows(i).Cells(0).Value.ToString())

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
    Sub MAX_day_bill()

        Dim DT As New DataTable
        DT.Clear()
        DT = CLS_DAY_.MAX_1()
        If DT.Rows.Count > 0 Then
            id_day = DT.Rows(0)(0).ToString()
        End If
    End Sub
    Sub sales_return()
        Try
            Dim guid_day As String
            Dim note_ As String = TXT_ID.Text + "/" + Me.Text
            Dim note_disc As String = TXT_ID.Text + "/" + Me.Text + "  " + "حسم"
            CLS_DAY_.add_day1(Val(id_day), DTP1.Value, TXT_NOTE.Text, TXT_GUID.Text, note_, TXT_GUID_JOB.Text, TXT_GUID_CURRENCY.Text, Val(TXT_CURRENCY_VAL.Text), guid_user_log)

            Dim dt As New DataTable
            dt.Clear()
            dt = CLS_DAY_.guid__(Val(id_day))
            guid_day = dt.Rows(0)(0).ToString()


            'اثباث مر.مبيعات
            '========================================================================================
            If Val(TXT_DISC.Text) = 0 Then
                'من حساب مرتجع مبيعات
                CLS_DAY_.add_day2(guid_day, day_iteme, Val(TXT_TOTAL_SUB.Text), 0, note_, TXT_GUID_JOB.Text, TXT_GUID_CURRENCY.Text, Val(TXT_CURRENCY_VAL.Text))


                'الى  حساب نقدا او اجل
                If CMB_TYPE_PAY.Text = "اجل" Then

                    'اجلة

                    CLS_DAY_.add_day2(guid_day, TXT_GUID_CUSTOMER.Text, 0, Val(TXT_TOTAL_SUB.Text), note_, TXT_GUID_JOB.Text, TXT_GUID_CURRENCY.Text, Val(TXT_CURRENCY_VAL.Text))
                Else
                    'نقدا
                    CLS_DAY_.add_day2(guid_day, day_cash, 0, Val(TXT_TOTAL_SUB.Text), note_, TXT_GUID_JOB.Text, TXT_GUID_CURRENCY.Text, Val(TXT_CURRENCY_VAL.Text))
                End If


                '---------------------------------------

            End If
            '----------------------------------------------------------------------

            '========================================================================================


            If Val(TXT_DISC.Text) <> 0 Then
                'من حساب مرتجع مبيعات
                CLS_DAY_.add_day2(guid_day, day_iteme, Val(TXT_TOTAL_SUB.Text), 0, note_, TXT_GUID_JOB.Text, TXT_GUID_CURRENCY.Text, Val(TXT_CURRENCY_VAL.Text))


                'الى  حساب نقدا او اجل
                If CMB_TYPE_PAY.Text = "اجل" Then

                    'اجلة

                    CLS_DAY_.add_day2(guid_day, TXT_GUID_CUSTOMER.Text, 0, Val(TXT_TOTAL_SUB.Text), note_, TXT_GUID_JOB.Text, TXT_GUID_CURRENCY.Text, Val(TXT_CURRENCY_VAL.Text))
                Else
                    'نقدا
                    CLS_DAY_.add_day2(guid_day, day_cash, 0, Val(TXT_TOTAL_SUB.Text), note_, TXT_GUID_JOB.Text, TXT_GUID_CURRENCY.Text, Val(TXT_CURRENCY_VAL.Text))
                End If


                'الى حساب حسم ممنوح
                CLS_DAY_.add_day2(guid_day, day_dis, 0, Val(TXT_DISC.Text), note_disc, TXT_GUID_JOB.Text, TXT_GUID_CURRENCY.Text, Val(TXT_CURRENCY_VAL.Text))



                '========================================================================================

            End If
        Catch ex As Exception

        End Try
    End Sub
    Sub sales_()
        Try
            Dim guid_day As String
            Dim note_ As String = TXT_ID.Text + "/" + Me.Text
            Dim note_disc As String = TXT_ID.Text + "/" + Me.Text + "  " + "حسم"
            CLS_DAY_.add_day1(Val(id_day), DTP1.Value, TXT_NOTE.Text, TXT_GUID.Text, note_, TXT_GUID_JOB.Text, TXT_GUID_CURRENCY.Text, Val(TXT_CURRENCY_VAL.Text), guid_user_log)

            Dim dt As New DataTable
            dt.Clear()
            dt = CLS_DAY_.guid__(Val(id_day))
            guid_day = dt.Rows(0)(0).ToString()


            'اثباث مبيعات
            '========================================================================================
            If Val(TXT_DISC.Text) = 0 Then
                '----------------------------------------------------------------------
                'من حساب نقدا او اجل
                If CMB_TYPE_PAY.Text = "اجل" Then

                    'اجلة

                    CLS_DAY_.add_day2(guid_day, TXT_GUID_CUSTOMER.Text, Val(TXT_TOTAL_SUB.Text), 0, note_, TXT_GUID_JOB.Text, TXT_GUID_CURRENCY.Text, Val(TXT_CURRENCY_VAL.Text))
                Else
                    'نقدا
                    CLS_DAY_.add_day2(guid_day, day_cash, Val(TXT_TOTAL_SUB.Text), 0, note_, TXT_GUID_JOB.Text, TXT_GUID_CURRENCY.Text, Val(TXT_CURRENCY_VAL.Text))
                End If


                '---------------------------------------
                'الى  حساب مبيعات
                CLS_DAY_.add_day2(guid_day, day_iteme, 0, Val(TXT_TOTAL_SUB.Text), note_, TXT_GUID_JOB.Text, TXT_GUID_CURRENCY.Text, Val(TXT_CURRENCY_VAL.Text))

            End If

            '========================================================================================


            If Val(TXT_DISC.Text) <> 0 Then


                'اثباث حسم مشتريات وهو حسم ممنوح 
                '========================================================================================

                'من حساب حسم ممنوح
                CLS_DAY_.add_day2(guid_day, day_dis, Val(TXT_DISC.Text), 0, note_disc, TXT_GUID_JOB.Text, TXT_GUID_CURRENCY.Text, Val(TXT_CURRENCY_VAL.Text))
                '----------------------------------------------------------------------
                '----------------------------------------------------------------------
                'من حساب نقدا او اجل
                If CMB_TYPE_PAY.Text = "اجل" Then

                    'اجلة

                    CLS_DAY_.add_day2(guid_day, TXT_GUID_CUSTOMER.Text, Val(TXT_TOTAL_SUB.Text) - Val(TXT_DISC.Text), 0, note_, TXT_GUID_JOB.Text, TXT_GUID_CURRENCY.Text, Val(TXT_CURRENCY_VAL.Text))
                Else
                    'نقدا
                    CLS_DAY_.add_day2(guid_day, day_cash, Val(TXT_TOTAL_SUB.Text) - Val(TXT_DISC.Text), 0, note_, TXT_GUID_JOB.Text, TXT_GUID_CURRENCY.Text, Val(TXT_CURRENCY_VAL.Text))
                End If


                '---------------------------------------
                'الى  حساب مبيعات
                CLS_DAY_.add_day2(guid_day, day_iteme, 0, Val(TXT_TOTAL_SUB.Text), note_, TXT_GUID_JOB.Text, TXT_GUID_CURRENCY.Text, Val(TXT_CURRENCY_VAL.Text))




                '========================================================================================

            End If
        Catch ex As Exception

        End Try
    End Sub
    Sub reture_pursh()
        Try
            Dim guid_day As String
            Dim note_ As String = TXT_ID.Text + "/" + Me.Text
            Dim note_disc As String = TXT_ID.Text + "/" + Me.Text + "  " + "حسم"
            CLS_DAY_.add_day1(Val(id_day), DTP1.Value, TXT_NOTE.Text, TXT_GUID.Text, note_, TXT_GUID_JOB.Text, TXT_GUID_CURRENCY.Text, Val(TXT_CURRENCY_VAL.Text), guid_user_log)

            Dim dt As New DataTable
            dt.Clear()
            dt = CLS_DAY_.guid__(Val(id_day))
            guid_day = dt.Rows(0)(0).ToString()


            '========================================================================================

            '----------------------------------------------------------------------
            If Val(TXT_DISC.Text) = 0 Then
                'من حساب نقدا او اجل
                If CMB_TYPE_PAY.Text = "اجل" Then

                    'اجلة

                    CLS_DAY_.add_day2(guid_day, TXT_GUID_CUSTOMER.Text, Val(TXT_TOTAL_SUB.Text), 0, note_, TXT_GUID_JOB.Text, TXT_GUID_CURRENCY.Text, Val(TXT_CURRENCY_VAL.Text))
                Else
                    'نقدا
                    CLS_DAY_.add_day2(guid_day, day_cash, Val(TXT_TOTAL_SUB.Text), 0, note_, TXT_GUID_JOB.Text, TXT_GUID_CURRENCY.Text, Val(TXT_CURRENCY_VAL.Text))
                End If


                '---------------------------------------
                'الى  حساب مر.مشتريات
                CLS_DAY_.add_day2(guid_day, day_iteme, 0, Val(TXT_TOTAL_SUB.Text), note_, TXT_GUID_JOB.Text, TXT_GUID_CURRENCY.Text, Val(TXT_CURRENCY_VAL.Text))

            End If



            If Val(TXT_DISC.Text) <> 0 Then


                'اثباث حسم مشتريات وهو حسم مكتسب 
                '========================================================================================

                'من حساب حسم مكتسب
                CLS_DAY_.add_day2(guid_day, day_dis, Val(TXT_DISC.Text), 0, note_disc, TXT_GUID_JOB.Text, TXT_GUID_CURRENCY.Text, Val(TXT_CURRENCY_VAL.Text))
                '----------------------------------------------------------------------
                'من حساب نقدا او اجل
                If CMB_TYPE_PAY.Text = "اجل" Then

                    'اجلة

                    CLS_DAY_.add_day2(guid_day, TXT_GUID_CUSTOMER.Text, Val(TXT_TOTAL_SUB.Text) - Val(TXT_DISC.Text), 0, note_, TXT_GUID_JOB.Text, TXT_GUID_CURRENCY.Text, Val(TXT_CURRENCY_VAL.Text))
                Else
                    'نقدا
                    CLS_DAY_.add_day2(guid_day, day_cash, Val(TXT_TOTAL_SUB.Text) - Val(TXT_DISC.Text), 0, note_, TXT_GUID_JOB.Text, TXT_GUID_CURRENCY.Text, Val(TXT_CURRENCY_VAL.Text))
                End If


                '---------------------------------------
                'الى  حساب مر.مشتريات
                CLS_DAY_.add_day2(guid_day, day_iteme, 0, Val(TXT_TOTAL_SUB.Text), note_, TXT_GUID_JOB.Text, TXT_GUID_CURRENCY.Text, Val(TXT_CURRENCY_VAL.Text))


                '========================================================================================

            End If
        Catch ex As Exception

        End Try
    End Sub
    Sub add_day_purshase()
        Try
            Dim guid_day As String
            Dim note_ As String = TXT_ID.Text + "/" + Me.Text
            Dim note_disc As String = TXT_ID.Text + "/" + Me.Text + "  " + "حسم"
            CLS_DAY_.add_day1(Val(id_day), DTP1.Value, TXT_NOTE.Text, TXT_GUID.Text, note_, TXT_GUID_JOB.Text, TXT_GUID_CURRENCY.Text, Val(TXT_CURRENCY_VAL.Text), guid_user_log)

            Dim dt As New DataTable
            dt.Clear()
            dt = CLS_DAY_.guid__(Val(id_day))
            guid_day = dt.Rows(0)(0).ToString()





            If Val(TXT_DISC.Text) = 0 Then

                'من حساب المشتريات
                CLS_DAY_.add_day2(guid_day, day_iteme, Val(TXT_TOTAL_SUB.Text), 0, note_, TXT_GUID_JOB.Text, TXT_GUID_CURRENCY.Text, Val(TXT_CURRENCY_VAL.Text))

                '----------------------------------------------------------------------
                'الى حساب نقدا او اجل
                If CMB_TYPE_PAY.Text = "اجل" Then

                    'اجلة

                    CLS_DAY_.add_day2(guid_day, TXT_GUID_CUSTOMER.Text, 0, Val(TXT_TOTAL_SUB.Text), note_, TXT_GUID_JOB.Text, TXT_GUID_CURRENCY.Text, Val(TXT_CURRENCY_VAL.Text))
                Else
                    'نقدا
                    CLS_DAY_.add_day2(guid_day, day_cash, 0, Val(TXT_TOTAL_SUB.Text), note_, TXT_GUID_JOB.Text, TXT_GUID_CURRENCY.Text, Val(TXT_CURRENCY_VAL.Text))
                End If


            End If
            '========================================================================================

            If Val(TXT_DISC.Text) <> 0 Then

                'من حساب المشتريات
                CLS_DAY_.add_day2(guid_day, day_iteme, Val(TXT_TOTAL_SUB.Text), 0, note_, TXT_GUID_JOB.Text, TXT_GUID_CURRENCY.Text, Val(TXT_CURRENCY_VAL.Text))

                'الى حساب نقدا او اجل
                If CMB_TYPE_PAY.Text = "اجل" Then

                    'اجلة

                    CLS_DAY_.add_day2(guid_day, TXT_GUID_CUSTOMER.Text, 0, Val(TXT_TOTAL_SUB.Text) - Val(TXT_DISC.Text), note_, TXT_GUID_JOB.Text, TXT_GUID_CURRENCY.Text, Val(TXT_CURRENCY_VAL.Text))
                Else
                    'نقدا
                    CLS_DAY_.add_day2(guid_day, day_cash, 0, Val(TXT_TOTAL_SUB.Text) - Val(TXT_DISC.Text), note_, TXT_GUID_JOB.Text, TXT_GUID_CURRENCY.Text, Val(TXT_CURRENCY_VAL.Text))
                End If
                'اثباث حسم مشتريات وهو حسم مكتسب 
                'الى حساب حسم مكتسب
                CLS_DAY_.add_day2(guid_day, day_dis, 0, Val(TXT_DISC.Text), note_disc, TXT_GUID_JOB.Text, TXT_GUID_CURRENCY.Text, Val(TXT_CURRENCY_VAL.Text))

                '========================================================================================
            End If
        Catch ex As Exception

        End Try
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
        TXT_GUID_CUSTOMER.Text = Nothing
        TXT_EXTRA_PEL.Text = "0"
        TXT_DISC_PEL.Text = "0"
        TXT_TOTAL_SUB.Text = "0"
        TXT_TOTAL.Text = "0"
        TXT_DISC.Text = "0"
        lbl_number_day.Text = "0"
        TXT_NOTE.Text = Nothing
        DTP1.Value = Today
        TXT_R_DISC.Text = Nothing
        NavUPDATE.Enabled = True
        NavDELETE.Enabled = True
        TXT_NAME_STORE_B.Text = Nothing
        TXT_NAME_ITEME_B.Text = Nothing
        TXT_BALANCE_B.Text = Nothing

    End Sub
    Private Sub TXT_DISC_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TXT_DISC.KeyPress
        If (e.KeyChar >= "a" And e.KeyChar <= "z") Or (e.KeyChar >= "A" And e.KeyChar <= "Z") Or (e.KeyChar >= "ا" And e.KeyChar <= "ي") Then
            e.Handled = True
        End If
    End Sub

    Private Sub TXT_DISC_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TXT_DISC.TextChanged
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
            'If TXT_GUID_CUSTOMER.Text = Nothing Then
            '    MessageBox.Show("  يجب اخيار الطرف الثاني", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error)
            '    Exit Sub
            'End If
            If CMB_TYPE_PAY.Text = "اجل" And TXT_GUID_CUSTOMER.Text = Nothing Then
                MessageBox.Show("  يجب اخيار الطرف الثاني", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub

            End If
            '---------------------------------------------------------------------

            If TXT_GUID_STORE.Text = Nothing Then
                MessageBox.Show("   يجب اختيار مستودع ", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
            '---------------------------------------------------------------------
            If TXT_GUID_CUSTOMER.Text = Nothing Then
                TXT_GUID_CUSTOMER.Text = "00000000-0000-0000-0000-000000000000"
            End If

            update_bill1()
            delete_bill2()
            update_bill2()
            balance____()
            DGV.ReadOnly = False
            delete_day1()




            MAX_day_bill()
            If is_day = 1 Then


                If TXT_NUMBER_TYPE.Text = "0" Then
                    'مشتريات
                    add_day_purshase()

                    avg____()
                ElseIf TXT_NUMBER_TYPE.Text = "1" Then
                    'مردودات مشتريات
                    reture_pursh()
                    '
                    avg____()
                ElseIf TXT_NUMBER_TYPE.Text = "2" Then
                    'مبيعات
                    sales_()
                ElseIf TXT_NUMBER_TYPE.Text = "3" Then
                    'مردودات مبيعات
                    sales_return()
                End If
            End If
            '----------------------------
            MAX_1_b()
            note_b = "0"
            add_b1()

            add_b2()
            '-------------------------------------
            show_day()

            MessageBox.Show("   تمت عملية تعديل الفاتورة بنجاح ", "تاكيد", MessageBoxButtons.OK, MessageBoxIcon.Information)




        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub
    Sub delete_day1()
        CLS_DAY_.delete_day1_bill(TXT_GUID.Text)
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
                delete_bill1()
                delete_bill2()



                balance____()
                '---------------------------------------------------------------------
                DGV.ReadOnly = False
                'حذف سند القيد
                delete_day1()
                '---------------------------------------------------------------------
                show_day()
                avg____()
                '----------------------------
                MAX_1_b()
                note_b = "1"
                add_b1()

                add_b2()
                '-------------------------------------
                MessageBox.Show("   تمت عملية حذف الفاتورة بنجاح ", "تاكيد", MessageBoxButtons.OK, MessageBoxIcon.Information)
                TXT_GUID.Text = Nothing

            End If





        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub عرضسندالقيدToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles عرضسندالقيدToolStripMenuItem.Click
        Try
            If lbl_number_day.Text <> "0" Then
                number_day___ = 1
                Dim f As New FRM_DAY
                f.TXT_ID.Text = lbl_number_day.Text
                f.ShowDialog()
                number_day___ = 0
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub
    Sub show_day()
        If TXT_GUID.Text <> Nothing Then


            Dim dt As New DataTable
            dt.Clear()
            dt = CLS_DAY_.number_day_bill(TXT_GUID.Text)
            If dt.Rows.Count > 0 Then
                lbl_number_day.Text = dt.Rows(0)(0).ToString()
            Else
                lbl_number_day.Text = "0"
            End If
        End If
    End Sub

    Private Sub TXT_GUID_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TXT_GUID.TextChanged

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

    Private Sub TXT_TOTAL_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TXT_TOTAL.KeyPress
        e.Handled = True
    End Sub

    Private Sub TXT_TOTAL_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TXT_TOTAL.TextChanged

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
                    dt.Rows.Add(DTP1.Value.ToShortDateString(), TXT_NAME_CUSTOMET.Text, TXT_JOB.Text, TXT_NOTE.Text, CMB_TYPE_PAY.Text, TXT_STORE.Text, TXT_CURRENCY.Text, DGV.Rows(I).Cells(1).Value, DGV.Rows(I).Cells(2).Value, DGV.Rows(I).Cells(3).Value, DGV.Rows(I).Cells(4).Value, DGV.Rows(I).Cells(5).Value, DGV.Rows(I).Cells(6).Value, DGV.Rows(I).Cells(7).Value, DGV.Rows(I).Cells(8).Value, DGV.Rows(I).Cells(9).Value, Val(TXT_TOTAL_SUB.Text), Val(TXT_DISC.Text), Val(TXT_TOTAL.Text), Val(TXT_ID.Text), Me.Text)
                End If

            Next
            '-------------------------------------------------------
            'Dim rptDoc As CrystalDecisions.CrystalReports.Engine.ReportDocument
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

    

    Private Sub TXT_NAME_CUSTOMET_TextChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TXT_NAME_CUSTOMET.TextChanged

    End Sub

    Private Sub TXT_GUID_CUSTOMER_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TXT_GUID_CUSTOMER.TextChanged
        Try
            If TXT_GUID_CUSTOMER.Text = "00000000-0000-0000-0000-000000000000" Then
                Exit Sub
            End If
            Dim dt As New DataTable
            dt.Clear()
            dt = CLS_CU_VEN_.SHOW_CUSTOMER_BILL(TXT_GUID_CUSTOMER.Text)
            If dt.Rows.Count <> 0 Then

                'DTP.Value = dt.Rows(0)(0).ToString()
                'TXT_NAME.Text = dt.Rows(0).Item(1).ToString()
                'TXT_LAST_NAME.Text = dt.Rows(0).Item(2).ToString()
                'TXT_NAME_COMPANY.Text = dt.Rows(0).Item(3).ToString()
                'TXT_JOB_COMPAN.Text = dt.Rows(0).Item(4).ToString()

                TXT_CUNTRY.Text = dt.Rows(0).Item(5).ToString()
                TXT_STREET.Text = dt.Rows(0).Item(6).ToString()
                TXT_PHONE.Text = dt.Rows(0).Item(7).ToString()
                TXT_MOBILE_1.Text = dt.Rows(0).Item(8).ToString()
                TXT_MOBILE_2.Text = dt.Rows(0).Item(9).ToString()


                TXT_MAIL.Text = dt.Rows(0).Item(10).ToString()
                'TXT_WEB.Text = dt.Rows(0).Item(11).ToString()

                Dim imgByteArray() As Byte
                imgByteArray = dt.Rows(0).Item(12)
                Dim Stream As New MemoryStream(imgByteArray, True)
                Dim Img As System.Drawing.Image = New Bitmap(Stream)
                pic.Image = Img
            Else
                'TXT_NAME.Text = Nothing
                'TXT_LAST_NAME.Text = Nothing
                'TXT_NAME_COMPANY.Text = Nothing
                'TXT_JOB_COMPAN.Text = Nothing
                TXT_CUNTRY.Text = Nothing
                TXT_STREET.Text = Nothing
                TXT_PHONE.Text = Nothing
                TXT_MOBILE_1.Text = Nothing
                TXT_MOBILE_2.Text = Nothing
                TXT_MAIL.Text = Nothing
                'TXT_WEB.Text = Nothing
                pic.Image = PIC_NEW.Image



            End If

        Catch ex As Exception

        End Try
    End Sub

    Private Sub حذفالسطرToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles حذفالسطرToolStripMenuItem.Click
        Try
            If MessageBox.Show("هل انت متاكد من عملية حذف السطر", "تنبيه", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = Windows.Forms.DialogResult.Yes Then
                CLS_DAY_.delete_day1(TXT_GUID.Text)
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

    Private Sub Radio_disc_m_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Radio_disc_m.CheckedChanged
        Try
            If Radio_disc_m.Checked = True Then
                TXT_R_DISC.Visible = False
                TXT_R_DISC.Text = 0
                TXT_DISC.Enabled = True
            End If
        Catch ex As Exception

        End Try
      
    End Sub

    Private Sub Radio_disc_n_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Radio_disc_n.CheckedChanged
        Try
            If Radio_disc_n.Checked = True Then
                TXT_R_DISC.Visible = True
                TXT_R_DISC.Text = Nothing
                TXT_DISC.Enabled = False
                TXT_R_DISC.Focus()
               
            End If
        Catch ex As Exception

        End Try

    End Sub

    Private Sub TXT_R_DISC_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TXT_R_DISC.KeyPress
        If (e.KeyChar >= "a" And e.KeyChar <= "z") Or (e.KeyChar >= "A" And e.KeyChar <= "Z") Or (e.KeyChar >= "ا" And e.KeyChar <= "ي") Then
            e.Handled = True
        End If
    End Sub

    Private Sub TXT_R_DISC_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TXT_R_DISC.TextChanged
        Try
            If TXT_R_DISC.Text <> Nothing Then
                Dim disc_r As Double

                disc_r = (Val(TXT_TOTAL_SUB.Text) * (TXT_R_DISC.Text)) / 100
                TXT_DISC.Text = disc_r.ToString("0.00")
            Else
                TXT_DISC.Text = 0
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            DTP_TIME.Value = Today.ToShortTimeString()
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub TXT_NAME_STORE_B_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TXT_NAME_STORE_B.KeyPress
        e.Handled = True
    End Sub

   
    Private Sub TXT_NAME_STORE_B_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TXT_NAME_STORE_B.TextChanged

    End Sub

    Private Sub TXT_NAME_ITEME_B_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TXT_NAME_ITEME_B.KeyPress
        e.Handled = True
    End Sub

    Private Sub TXT_NAME_ITEME_B_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TXT_NAME_ITEME_B.TextChanged

    End Sub

    Private Sub TXT_BALANCE_B_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TXT_BALANCE_B.KeyPress
        e.Handled = True
    End Sub

    Private Sub TXT_BALANCE_B_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TXT_BALANCE_B.TextChanged

    End Sub
End Class