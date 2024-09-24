Imports System.Data.SqlClient
Imports DevComponents.DotNetBar
Public Class FRM_POS

    Public WithEvents newButton_ITEME As ButtonX
    Dim ClS_CATEGORYE_ As New ClS_CATEGORYE
    Dim CLS_ITEME_ As New CLS_ITEME
    Dim CLS_SET_POS_ As New CLS_SET_POS
    Dim ClS_TYPE_BILL_ As New ClS_TYPE_BILL
    Dim guid_cu As String
    Dim guid_stor As String
    Dim guid_currency As String
    Dim val_currency As Double
    Dim guid_job As String
    Dim show_iteme As Integer
    Dim iRowIndex As Integer = 0
    Dim day_iteme As String
    Dim day_dis As String
    Dim day_cash As String
    Dim is_day As Integer

   
    Sub show_guid()
        Dim dt As New DataTable
        dt.Clear()
        dt = CLS_SET_POS_.SEARSH_pos(guid_user_log)
        If dt.Rows.Count > 0 Then
            TXT_GUID_CUSTOMER.Text = dt.Rows(0)(0).ToString()
            guid_stor = dt.Rows(0)(1).ToString()
            guid_currency = dt.Rows(0)(2).ToString()
            val_currency = dt.Rows(0)(3).ToString()
            guid_job = dt.Rows(0)(4).ToString()
            show_iteme = dt.Rows(0)(5).ToString()
            'If show___ = 0 Then
            '    Group_show_iteme.Visible = False
            'Else
            '    Group_show_iteme.Visible = True
            'End If
        Else
            MessageBox.Show("يجب تحديد اعدادات نقطة البيع")
            Close()
        End If
    End Sub
    Public Sub show_group_iteme()

        Dim DT As New DataTable
        DT.Clear()
        DT = ClS_CATEGORYE_.SELECT_

        If DT.Rows.Count > 0 Then

            For I As Integer = 0 To DT.Rows.Count - 1
                newButton_ITEME = New ButtonX
                newButton_ITEME.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
                newButton_ITEME.Height = 70
                newButton_ITEME.Width = 180
                newButton_ITEME.Left = (I Mod 1) * 180
                newButton_ITEME.Top = (I \ 1) * 70
                newButton_ITEME.Text = DT.Rows(I)(1).ToString()
                newButton_ITEME.Name = DT.Rows(I)(2).ToString()
                newButton_ITEME.BackColor = Color.Transparent
                newButton_ITEME.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
                newButton_ITEME.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
                newButton_ITEME.Shape = New DevComponents.DotNetBar.EllipticalShapeDescriptor()
                '==========================
                AddHandler newButton_ITEME.Click, AddressOf Button_group
                Group_itme.Controls.Add(newButton_ITEME)
            Next
        End If


    End Sub
    Private Sub Button_group(ByVal sender As Object, ByVal e As EventArgs)
        'Group_iteme.Controls.Clear()
        Dim guid_ As String = sender.name
        Dim name_ As String = sender.Text
        Dim dt As New DataTable
        dt.Clear()
        dt = CLS_ITEME_.pos_NAME(guid_)
        If dt.Rows.Count > 0 Then

            Dim tol_gro As Integer = Group_iteme.Size.Width
            For I As Integer = 0 To dt.Rows.Count - 1


                newButton_ITEME = New ButtonX
                newButton_ITEME.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
                newButton_ITEME.Height = 70
                newButton_ITEME.Width = (tol_gro / Val(5)) - 2
                newButton_ITEME.Left = (I Mod 5) * (newButton_ITEME.Width)
                newButton_ITEME.Top = (I \ 5) * 70
                newButton_ITEME.Text = dt.Rows(I)(1).ToString()
                newButton_ITEME.Name = dt.Rows(I)(0).ToString()
                newButton_ITEME.BackColor = Color.Transparent
                newButton_ITEME.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
                newButton_ITEME.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
                newButton_ITEME.Shape = New DevComponents.DotNetBar.EllipticalShapeDescriptor()
                '==========================
                AddHandler newButton_ITEME.Click, AddressOf Button_iteme
                Group_iteme.Controls.Add(newButton_ITEME)
            Next
        End If

    End Sub
    Private Sub Button_iteme(ByVal sender As Object, ByVal e As EventArgs)
        Try



            Dim guid_ As String = sender.name
            Dim name_ As String = sender.Text
            Dim press_ As Integer
            '-----------------------------------------------------


            If DGV.Rows.Count = 0 Then
                Dim DT As New DataTable
                DT.Clear()
                DT = CLS_ITEME_.searsh_NAME_POS(guid_)
                If DT.Rows.Count > 0 Then
                    If TXT_TYPE_PRICE.Text = "0" Then
                        press_ = Val(DT.Rows(0)(5).ToString()) / Val(val_currency)
                    ElseIf TXT_TYPE_PRICE.Text = "1" Then
                        press_ = Val(DT.Rows(0)(6).ToString()) / Val(val_currency)
                    ElseIf TXT_TYPE_PRICE.Text = "2" Then
                        press_ = Val(DT.Rows(0)(7).ToString()) / Val(val_currency)
                    ElseIf TXT_TYPE_PRICE.Text = "3" Then
                        press_ = Val(DT.Rows(0)(8).ToString()) / Val(val_currency)
                    ElseIf TXT_TYPE_PRICE.Text = "4" Then
                        press_ = Val(DT.Rows(0)(9).ToString()) / Val(val_currency)
                    ElseIf TXT_TYPE_PRICE.Text = "5" Then
                        press_ = Val(DT.Rows(0)(10).ToString()) / Val(val_currency)
                    ElseIf TXT_TYPE_PRICE.Text = "6" Then
                        press_ = Val(DT.Rows(0)(11).ToString()) / Val(val_currency)
                    End If

                    DGV.Rows.Add(guid_, DT.Rows(0)(1).ToString(), name_, 1, Val(press_), 0, 0, Val(press_), "", DT.Rows(0)(3).ToString(), 1, guid_stor, "", True)
                End If


                DGV.Rows(0).Selected = True


                total_()








                Dim currentr As Integer = DGV.Rows.Count - 1
                DGV.ClearSelection()
                DGV.Rows(currentr).Cells(2).Selected = True
                iRowIndex = Me.DGV.SelectedCells.Item(0).RowIndex
                'DGV.Select()
            Else


                For i As Integer = 0 To DGV.Rows.Count - 1
                    If DGV.Rows(i).Cells("guid").Value.ToString() = guid_ Then

                        DGV.Rows(i).Cells("qty").Value = Val(DGV.Rows(i).Cells("qty").Value) + 1

                        DGV.Rows(i).Cells("total").Value = (Val(DGV.Rows(i).Cells("qty").Value) * Val(DGV.Rows(i).Cells("price").Value)).ToString("0.00")

                        DGV.Rows(i).Selected = True
                        total_()



                        Dim currentr As Integer = DGV.Rows.Count - 1
                        DGV.ClearSelection()
                        DGV.Rows(currentr).Cells(2).Selected = True
                        iRowIndex = Me.DGV.SelectedCells.Item(i).RowIndex
                        'DGV.Select()
                        Exit Sub
                    End If

                Next

                For i As Integer = 0 To DGV.Rows.Count - 1
                    If DGV.Rows(i).Cells("guid").Value.ToString() <> guid_ Then


                        Dim DT As New DataTable
                        DT.Clear()
                        DT = CLS_ITEME_.searsh_NAME_POS(guid_)
                        If DT.Rows.Count > 0 Then
                            If TXT_TYPE_PRICE.Text = "0" Then
                                press_ = Val(DT.Rows(0)(5).ToString()) / Val(val_currency)
                            ElseIf TXT_TYPE_PRICE.Text = "1" Then
                                press_ = Val(DT.Rows(0)(6).ToString()) / Val(val_currency)
                            ElseIf TXT_TYPE_PRICE.Text = "2" Then
                                press_ = Val(DT.Rows(0)(7).ToString()) / Val(val_currency)
                            ElseIf TXT_TYPE_PRICE.Text = "3" Then
                                press_ = Val(DT.Rows(0)(8).ToString()) / Val(val_currency)
                            ElseIf TXT_TYPE_PRICE.Text = "4" Then
                                press_ = Val(DT.Rows(0)(9).ToString()) / Val(val_currency)
                            ElseIf TXT_TYPE_PRICE.Text = "5" Then
                                press_ = Val(DT.Rows(0)(10).ToString()) / Val(val_currency)
                            ElseIf TXT_TYPE_PRICE.Text = "6" Then
                                press_ = Val(DT.Rows(0)(11).ToString()) / Val(val_currency)
                            End If

                            DGV.Rows.Add(guid_, DT.Rows(0)(1).ToString(), name_, 1, Val(press_), 0, 0, Val(press_), "", DT.Rows(0)(3).ToString(), 1, guid_stor, "", True)
                        End If



                        Dim currentr As Integer = DGV.Rows.Count - 1
                        DGV.ClearSelection()
                        DGV.Rows(currentr).Cells(2).Selected = True
                        'DGV.Select()

                        iRowIndex = Me.DGV.SelectedCells.Item(i).RowIndex


                        total_()
                        Exit Sub
                    End If

                Next

            End If

        Catch ex As Exception

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
        Dim TOT____ As Double = Val(TXT_TOTAL_SUB.Text) - Val(TXT_DISC.Text) + Val(TXT_VAL_TRANSFROT.Text)

        TXT_TOTAL.Text = TOT____.ToString("0.000")
        'TXT_TOTAL.Text = (Val(tot_) + Val(xtra_) - Val(TXT_DISC.Text) - Val(disc_)).ToString("0.000")


        For I As Integer = 0 To DGV.Rows.Count - 1

            DGV.Rows(I).HeaderCell.Value = (DGV.Rows(I).Index + 1).ToString
            DGV.Rows(I).DefaultCellStyle.BackColor = Color.White
        Next

        DGV.Rows(iRowIndex).DefaultCellStyle.BackColor = Color.CadetBlue
    End Sub

   

    Private Sub TXT_PARENT_GUID_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TXT_PARENT_GUID.TextChanged
        Try
            account_bill()
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
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

    Private Sub ButtonX6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX6.Click
        TXT_CALCALUTER.Text += "9"
    End Sub

    Private Sub ButtonX5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX5.Click
        TXT_CALCALUTER.Text += "8"
    End Sub

    Private Sub ButtonX4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX4.Click
        TXT_CALCALUTER.Text += "7"
    End Sub

    Private Sub ButtonX9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX9.Click
        TXT_CALCALUTER.Text += "6"
    End Sub

    Private Sub ButtonX10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX10.Click
        TXT_CALCALUTER.Text += "5"
    End Sub

    Private Sub ButtonX11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX11.Click
        TXT_CALCALUTER.Text += "4"
    End Sub

    Private Sub ButtonX17_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX17.Click
        TXT_CALCALUTER.Text += "3"
    End Sub

    Private Sub ButtonX18_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX18.Click
        TXT_CALCALUTER.Text += "2"
    End Sub

    Private Sub ButtonX19_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX19.Click
        TXT_CALCALUTER.Text += "1"
    End Sub

    Private Sub ButtonX7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX7.Click
        TXT_CALCALUTER.Text = Nothing
    End Sub

    Private Sub ButtonX8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX8.Click
        Try
            'Dim i As Integer = DGV.CurrentRow.Selected = True

            If TXT_CALCALUTER.Text = Nothing Then
                MessageBox.Show("لايوجد  كمية", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
        
            DGV.Rows(iRowIndex).Cells("qty").Value = Val(TXT_CALCALUTER.Text)
            Dim total___ As Double = (Val(DGV.Rows(iRowIndex).Cells("qty").Value) * Val(DGV.Rows(iRowIndex).Cells("price").Value)) - Val(DGV.Rows(iRowIndex).Cells("disc").Value) + Val(DGV.Rows(iRowIndex).Cells("extra").Value)
            DGV.Rows(iRowIndex).Cells("total").Value = total___.ToString("0.00")

            TXT_CALCALUTER.Text = Nothing
            total_()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub DGV_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGV.CellClick
        Try
            Dim i As Integer = DGV.CurrentRow.Index
            iRowIndex = Me.DGV.SelectedCells.Item(i).RowIndex
            For Ii As Integer = 0 To DGV.Rows.Count - 1


                DGV.Rows(Ii).DefaultCellStyle.BackColor = Color.White
            Next

            DGV.Rows(iRowIndex).DefaultCellStyle.BackColor = Color.CadetBlue
        Catch ex As Exception

        End Try
    End Sub

    Private Sub DGV_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGV.CellContentClick

    End Sub

    Private Sub ButtonX12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX12.Click
        Try

            If TXT_CALCALUTER.Text = Nothing Then
                MessageBox.Show("لايوجد  مبلغ", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
            DGV.Rows(iRowIndex).Cells("price").Value = Val(TXT_CALCALUTER.Text)
            Dim total___ As Double = (Val(DGV.Rows(iRowIndex).Cells("qty").Value) * Val(DGV.Rows(iRowIndex).Cells("price").Value)) - Val(DGV.Rows(iRowIndex).Cells("disc").Value) + Val(DGV.Rows(iRowIndex).Cells("extra").Value)
            DGV.Rows(iRowIndex).Cells("total").Value = total___.ToString("0.00")

            TXT_CALCALUTER.Text = Nothing
            total_()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub ButtonX20_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX20.Click
        Try
            Dim i As Integer = DGV.CurrentRow.Index
            If MessageBox.Show("هل انت متاكد من عملية الحذف", "تنبيه", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = Windows.Forms.DialogResult.Yes Then
                DGV.Rows.RemoveAt(DGV.CurrentRow.Index)

                total_()
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub ButtonX2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX2.Click
        Try
            If MessageBox.Show("هل انت متاكد من عملية الحذف", "تنبيه", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = Windows.Forms.DialogResult.Yes Then
                DGV.Rows.Clear()

                total_()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        End Try

    End Sub



    Private Sub Group_iteme_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Group_iteme.Click

    End Sub



    Private Sub ButtonX24_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX24.Click
        Try
            Dim f As New FRM_ALL_CUSTOMER_POS
            f.ShowDialog()
            If f.isok = True Then
                Dim I As Integer = f.DGV.CurrentRow.Index

                TXT_GUID_CUSTOMER.Text = f.DGV.Rows(I).Cells(13).Value.ToString()
                TXT_NAME_CUSTOMET.Text = f.DGV.Rows(I).Cells(2).Value.ToString()
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub ButtonX22_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX22.Click
        Try
            Dim guid_ As String = sender.name
            Dim f As New FRM_ALL_ITEME_POS
            'f.TXT_SEARSH.Text = DGV.Rows(I).Cells(J).Value.ToString()
            f.ShowDialog()
            If f.isyes = True Then
                Dim ii As Integer = f.DGV.CurrentRow.Index
                guid_ = f.DGV.Rows(ii).Cells(0).Value.ToString()
            Else
                Exit Sub
            End If



 
            Dim press_ As Integer
            '-----------------------------------------------------


            If DGV.Rows.Count = 0 Then
                Dim DT As New DataTable
                DT.Clear()
                DT = CLS_ITEME_.searsh_NAME_POS(guid_)
                If DT.Rows.Count > 0 Then
                    If TXT_TYPE_PRICE.Text = "0" Then
                        press_ = Val(DT.Rows(0)(5).ToString()) / Val(val_currency)
                    ElseIf TXT_TYPE_PRICE.Text = "1" Then
                        press_ = Val(DT.Rows(0)(6).ToString()) / Val(val_currency)
                    ElseIf TXT_TYPE_PRICE.Text = "2" Then
                        press_ = Val(DT.Rows(0)(7).ToString()) / Val(val_currency)
                    ElseIf TXT_TYPE_PRICE.Text = "3" Then
                        press_ = Val(DT.Rows(0)(8).ToString()) / Val(val_currency)
                    ElseIf TXT_TYPE_PRICE.Text = "4" Then
                        press_ = Val(DT.Rows(0)(9).ToString()) / Val(val_currency)
                    ElseIf TXT_TYPE_PRICE.Text = "5" Then
                        press_ = Val(DT.Rows(0)(10).ToString()) / Val(val_currency)
                    ElseIf TXT_TYPE_PRICE.Text = "6" Then
                        press_ = Val(DT.Rows(0)(11).ToString()) / Val(val_currency)
                    End If

                    DGV.Rows.Add(guid_, DT.Rows(0)(1).ToString(), DT.Rows(0)(2).ToString(), 1, Val(press_), 0, 0, Val(press_), "", DT.Rows(0)(3).ToString(), 1, guid_stor, "", True)
                End If


                DGV.Rows(0).Selected = True


                total_()








                Dim currentr As Integer = DGV.Rows.Count - 1
                DGV.ClearSelection()
                DGV.Rows(currentr).Cells(2).Selected = True
                iRowIndex = Me.DGV.SelectedCells.Item(0).RowIndex
                'DGV.Select()
            Else


                For i As Integer = 0 To DGV.Rows.Count - 1
                    If DGV.Rows(i).Cells("guid").Value.ToString() = guid_ Then

                        DGV.Rows(i).Cells("qty").Value = Val(DGV.Rows(i).Cells("qty").Value) + 1

                        DGV.Rows(i).Cells("total").Value = (Val(DGV.Rows(i).Cells("qty").Value) * Val(DGV.Rows(i).Cells("price").Value)).ToString("0.00")

                        DGV.Rows(i).Selected = True
                        total_()



                        Dim currentr As Integer = DGV.Rows.Count - 1
                        DGV.ClearSelection()
                        DGV.Rows(currentr).Cells(2).Selected = True
                        iRowIndex = Me.DGV.SelectedCells.Item(i).RowIndex
                        'DGV.Select()
                        Exit Sub
                    End If

                Next

                For i As Integer = 0 To DGV.Rows.Count - 1
                    If DGV.Rows(i).Cells("guid").Value.ToString() <> guid_ Then


                        Dim DT As New DataTable
                        DT.Clear()
                        DT = CLS_ITEME_.searsh_NAME_POS(guid_)
                        If DT.Rows.Count > 0 Then
                            If TXT_TYPE_PRICE.Text = "0" Then
                                press_ = Val(DT.Rows(0)(5).ToString()) / Val(val_currency)
                            ElseIf TXT_TYPE_PRICE.Text = "1" Then
                                press_ = Val(DT.Rows(0)(6).ToString()) / Val(val_currency)
                            ElseIf TXT_TYPE_PRICE.Text = "2" Then
                                press_ = Val(DT.Rows(0)(7).ToString()) / Val(val_currency)
                            ElseIf TXT_TYPE_PRICE.Text = "3" Then
                                press_ = Val(DT.Rows(0)(8).ToString()) / Val(val_currency)
                            ElseIf TXT_TYPE_PRICE.Text = "4" Then
                                press_ = Val(DT.Rows(0)(9).ToString()) / Val(val_currency)
                            ElseIf TXT_TYPE_PRICE.Text = "5" Then
                                press_ = Val(DT.Rows(0)(10).ToString()) / Val(val_currency)
                            ElseIf TXT_TYPE_PRICE.Text = "6" Then
                                press_ = Val(DT.Rows(0)(11).ToString()) / Val(val_currency)
                            End If

                            DGV.Rows.Add(guid_, DT.Rows(0)(1).ToString(), DT.Rows(0)(2).ToString(), 1, Val(press_), 0, 0, Val(press_), "", DT.Rows(0)(3).ToString(), 1, guid_stor, "", True)
                        End If



                        Dim currentr As Integer = DGV.Rows.Count - 1
                        DGV.ClearSelection()
                        DGV.Rows(currentr).Cells(2).Selected = True
                        'DGV.Select()

                        iRowIndex = Me.DGV.SelectedCells.Item(i).RowIndex


                        total_()
                        Exit Sub
                    End If

                Next

            End If


            '    'Dim ii As Integer = f.DGV.CurrentRow.Index


            '    'DGV.Rows.Add(f.DGV.Rows(ii).Cells(0).Value.ToString(), f.DGV.Rows(ii).Cells(3).Value.ToString(), f.DGV.Rows(ii).Cells(1).Value.ToString())
            '    DGV.Rows(I).Cells(0).Value = f.DGV.Rows(ii).Cells(0).Value.ToString()
            '    DGV.Rows(I).Cells(1).Value = f.DGV.Rows(ii).Cells(1).Value.ToString()
            '    DGV.Rows(I).Cells(2).Value = f.DGV.Rows(ii).Cells(2).Value.ToString()


            '    DGV.Rows(I).Cells(3).Value = 1
            '    If TXT_TYPE_PRICE.Text = "0" Then
            '        DGV.Rows(I).Cells("price").Value = Val(f.DGV.Rows(ii).Cells(6).Value.ToString()) / Val(TXT_CURRENCY_VAL.Text)
            '    ElseIf TXT_TYPE_PRICE.Text = "1" Then
            '        DGV.Rows(I).Cells("price").Value = Val(f.DGV.Rows(ii).Cells(7).Value.ToString()) / Val(TXT_CURRENCY_VAL.Text)
            '    ElseIf TXT_TYPE_PRICE.Text = "2" Then
            '        DGV.Rows(I).Cells("price").Value = Val(f.DGV.Rows(ii).Cells(8).Value.ToString()) / Val(TXT_CURRENCY_VAL.Text)
            '    ElseIf TXT_TYPE_PRICE.Text = "3" Then
            '        DGV.Rows(I).Cells("price").Value = Val(f.DGV.Rows(ii).Cells(9).Value.ToString()) / Val(TXT_CURRENCY_VAL.Text)
            '    ElseIf TXT_TYPE_PRICE.Text = "4" Then
            '        DGV.Rows(I).Cells("price").Value = Val(f.DGV.Rows(ii).Cells(10).Value.ToString()) / Val(TXT_CURRENCY_VAL.Text)
            '    ElseIf TXT_TYPE_PRICE.Text = "5" Then
            '        DGV.Rows(I).Cells("price").Value = Val(f.DGV.Rows(ii).Cells(11).Value.ToString()) / Val(TXT_CURRENCY_VAL.Text)
            '    ElseIf TXT_TYPE_PRICE.Text = "6" Then
            '        DGV.Rows(I).Cells("price").Value = Val(f.DGV.Rows(ii).Cells(12).Value.ToString()) / Val(TXT_CURRENCY_VAL.Text)
            '    End If
            '    DGV.Rows(I).Cells(5).Value = 0
            '    DGV.Rows(I).Cells(6).Value = 0
            '    DGV.Rows(I).Cells(7).Value = 1




            '    DGV.Rows(I).Cells(9).Value = f.DGV.Rows(ii).Cells(3).Value.ToString()
            '    DGV.Rows(I).Cells(10).Value = 1
            '    DGV.Rows(I).Cells(11).Value = TXT_GUID_STORE.Text
            '    DGV.Rows(I).Cells(12).Value = TXT_STORE.Text
            '    DGV.Rows(I).Cells(13).Value = True




            'End If

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub ButtonX1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX1.Click
        If MessageBox.Show("هل انت متاكد من   الخروج", "تنبيه", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = Windows.Forms.DialogResult.Yes Then
            Close()
        End If
    End Sub

    Private Sub FRM_POS_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            'For I As Integer = 0 To 999
            '    DGV.Rows.Add()
            '    DGV.Rows(I).HeaderCell.Value = (DGV.Rows(I).Index + 1).ToString
            'Next

            'guid_user_log
            Me.DGV.RowTemplate.Height = 40
            show_guid()
            show_group_iteme()
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub ButtonX16_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX16.Click
        Try
            'Dim i As Integer = DGV.CurrentRow.Selected = True

            If TXT_CALCALUTER.Text = Nothing Then
                MessageBox.Show("لايوجد  كمية", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If

            DGV.Rows(iRowIndex).Cells("disc").Value = Val(TXT_CALCALUTER.Text)
            Dim total___ As Double = (Val(DGV.Rows(iRowIndex).Cells("qty").Value) * Val(DGV.Rows(iRowIndex).Cells("price").Value)) - Val(DGV.Rows(iRowIndex).Cells("disc").Value) + Val(DGV.Rows(iRowIndex).Cells("extra").Value)
            DGV.Rows(iRowIndex).Cells("total").Value = total___.ToString("0.00")

            TXT_CALCALUTER.Text = Nothing
            total_()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub ButtonX25_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX25.Click
        Try
            'Dim i As Integer = DGV.CurrentRow.Selected = True

            If TXT_CALCALUTER.Text = Nothing Then
                MessageBox.Show("لايوجد  كمية", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If

            DGV.Rows(iRowIndex).Cells("extra").Value = Val(TXT_CALCALUTER.Text)
            Dim total___ As Double = (Val(DGV.Rows(iRowIndex).Cells("qty").Value) * Val(DGV.Rows(iRowIndex).Cells("price").Value)) - Val(DGV.Rows(iRowIndex).Cells("disc").Value) + Val(DGV.Rows(iRowIndex).Cells("extra").Value)
            DGV.Rows(iRowIndex).Cells("total").Value = total___.ToString("0.00")

            TXT_CALCALUTER.Text = Nothing
            total_()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub ButtonX26_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX26.Click
        Try
            'Dim i As Integer = DGV.CurrentRow.Selected = True

            If TXT_CALCALUTER.Text = Nothing Then
                MessageBox.Show("لايوجد  كمية", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If

            TXT_DISC.Text = Val(TXT_CALCALUTER.Text)
           
            TXT_CALCALUTER.Text = Nothing
            total_()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub ButtonX15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX15.Click
        TXT_CALCALUTER.Text += "0"
    End Sub

    Private Sub ButtonX14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX14.Click
        TXT_CALCALUTER.Text += "00"
    End Sub

    Private Sub ButtonX13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX13.Click
        TXT_CALCALUTER.Text += "."
    End Sub

    Private Sub TXT_TYPE_PRICE_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TXT_TYPE_PRICE.TextChanged

    End Sub

    Private Sub ButtonX3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX3.Click
        Try
            Dim f As New FRM_ALL_EMPLOYEE_POS
            f.ShowDialog()
            If f.isok = True Then
                Dim I As Integer = f.DGV.CurrentRow.Index

                TXT_EMPLOYEE_GUID.Text = f.DGV.Rows(I).Cells(13).Value.ToString()
                TXT_NAME_EMPLOYEE.Text = f.DGV.Rows(I).Cells(2).Value.ToString()
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub ButtonX21_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX21.Click
        Try
            'Dim i As Integer = DGV.CurrentRow.Selected = True

            If TXT_CALCALUTER.Text = Nothing Then
                MessageBox.Show("لايوجد  كمية", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If

            TXT_VAL_TRANSFROT.Text = Val(TXT_CALCALUTER.Text)

            TXT_CALCALUTER.Text = Nothing
            total_()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub TXT_CALCALUTER_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TXT_CALCALUTER.TextChanged
       
    End Sub
    Sub barcode_1(ByVal barcode As String)
        Try

          
         

            'Dim unit As String
            'Dim qty_unit As Double


            'Dim press_ As Integer
            ''-----------------------------------------------------


            'If DGV.Rows.Count = 0 Then
            '    Dim DT As New DataTable
            '    DT.Clear()
            '    DT = CLS_ITEME_.searsh_BARCODE_pos(barcode)
            '    If DT.Rows.Count > 0 Then
            '        If TXT_TYPE_PRICE.Text = "0" Then
            '            press_ = Val(DT.Rows(0)(5).ToString()) / Val(val_currency)
            '        ElseIf TXT_TYPE_PRICE.Text = "1" Then
            '            press_ = Val(DT.Rows(0)(6).ToString()) / Val(val_currency)
            '        ElseIf TXT_TYPE_PRICE.Text = "2" Then
            '            press_ = Val(DT.Rows(0)(7).ToString()) / Val(val_currency)
            '        ElseIf TXT_TYPE_PRICE.Text = "3" Then
            '            press_ = Val(DT.Rows(0)(8).ToString()) / Val(val_currency)
            '        ElseIf TXT_TYPE_PRICE.Text = "4" Then
            '            press_ = Val(DT.Rows(0)(9).ToString()) / Val(val_currency)
            '        ElseIf TXT_TYPE_PRICE.Text = "5" Then
            '            press_ = Val(DT.Rows(0)(10).ToString()) / Val(val_currency)
            '        ElseIf TXT_TYPE_PRICE.Text = "6" Then
            '            press_ = Val(DT.Rows(0)(11).ToString()) / Val(val_currency)
            '        End If

            '        'باركود1
            '        If DT.Rows(0)(1).ToString() = barcode Then

            '            unit = DT.Rows(0)(3).ToString()
            '            qty_unit = DT.Rows(0)(4).ToString()

            '        End If

            '        'باركود2
            '        If DT.Rows(0)(16).ToString() = barcode Then

            '            unit = DT.Rows(0)(12).ToString()
            '            qty_unit = DT.Rows(0)(13).ToString()

            '        End If
            '        'باركود3
            '        If DT.Rows(0)(17).ToString() = barcode Then

            '            unit = DT.Rows(0)(14).ToString()
            '            qty_unit = DT.Rows(0)(15).ToString()

            '        End If


            '        DGV.Rows.Add(DT.Rows(0)(0).ToString(), barcode, DT.Rows(0)(2).ToString(), 1, Val(press_), 0, 0, Val(press_) * Val(qty_unit), "", unit, qty_unit, guid_stor, "", True)
            '    End If


            '    DGV.Rows(0).Selected = True


            '    total_()








            '    Dim currentr As Integer = DGV.Rows.Count - 1
            '    DGV.ClearSelection()
            '    DGV.Rows(currentr).Cells(2).Selected = True
            '    iRowIndex = Me.DGV.SelectedCells.Item(0).RowIndex
            '    'DGV.Select()
            'Else


            '    For i As Integer = 0 To DGV.Rows.Count - 1
            '        If DGV.Rows(i).Cells("barcode").Value.ToString() = barcode Then

            '            DGV.Rows(i).Cells("qty").Value = Val(DGV.Rows(i).Cells("qty").Value) + 1

            '            DGV.Rows(i).Cells("total").Value = (Val(DGV.Rows(i).Cells("qty").Value) * Val(DGV.Rows(i).Cells("price").Value)).ToString("0.00")

            '            DGV.Rows(i).Selected = True
            '            total_()



            '            Dim currentr As Integer = DGV.Rows.Count - 1
            '            DGV.ClearSelection()
            '            DGV.Rows(currentr).Cells(2).Selected = True
            '            iRowIndex = Me.DGV.SelectedCells.Item(i).RowIndex
            '            'DGV.Select()
            '            Exit Sub
            '        End If

            '    Next

            '    For i As Integer = 0 To DGV.Rows.Count - 1
            '        If DGV.Rows(i).Cells("barcode").Value.ToString() <> barcode Then


            '            Dim DT As New DataTable
            '            DT.Clear()
            '            DT = CLS_ITEME_.searsh_BARCODE_pos(barcode)
            '            If DT.Rows.Count > 0 Then
            '                If TXT_TYPE_PRICE.Text = "0" Then
            '                    press_ = Val(DT.Rows(0)(5).ToString()) / Val(val_currency)
            '                ElseIf TXT_TYPE_PRICE.Text = "1" Then
            '                    press_ = Val(DT.Rows(0)(6).ToString()) / Val(val_currency)
            '                ElseIf TXT_TYPE_PRICE.Text = "2" Then
            '                    press_ = Val(DT.Rows(0)(7).ToString()) / Val(val_currency)
            '                ElseIf TXT_TYPE_PRICE.Text = "3" Then
            '                    press_ = Val(DT.Rows(0)(8).ToString()) / Val(val_currency)
            '                ElseIf TXT_TYPE_PRICE.Text = "4" Then
            '                    press_ = Val(DT.Rows(0)(9).ToString()) / Val(val_currency)
            '                ElseIf TXT_TYPE_PRICE.Text = "5" Then
            '                    press_ = Val(DT.Rows(0)(10).ToString()) / Val(val_currency)
            '                ElseIf TXT_TYPE_PRICE.Text = "6" Then
            '                    press_ = Val(DT.Rows(0)(11).ToString()) / Val(val_currency)
            '                End If
            '                'باركود1
            '                If DT.Rows(0)(1).ToString() = barcode Then

            '                    unit = DT.Rows(0)(3).ToString()
            '                    qty_unit = DT.Rows(0)(4).ToString()

            '                End If

            '                'باركود2
            '                If DT.Rows(0)(16).ToString() = barcode Then

            '                    unit = DT.Rows(0)(12).ToString()
            '                    qty_unit = DT.Rows(0)(13).ToString()

            '                End If
            '                'باركود3
            '                If DT.Rows(0)(17).ToString() = barcode Then

            '                    unit = DT.Rows(0)(14).ToString()
            '                    qty_unit = DT.Rows(0)(15).ToString()

            '                End If




            '                DGV.Rows.Add(DT.Rows(0)(0).ToString(), barcode, DT.Rows(0)(2).ToString(), 1, Val(press_), 0, 0, Val(press_) * Val(qty_unit), "", unit, qty_unit, guid_stor, "", True)
            '            End If



            '            Dim currentr As Integer = DGV.Rows.Count - 1
            '            DGV.ClearSelection()
            '            DGV.Rows(currentr).Cells(2).Selected = True
            '            'DGV.Select()

            '            iRowIndex = Me.DGV.SelectedCells.Item(i).RowIndex


            '            total_()
            '            Exit Sub
            '        End If

            '    Next

            'End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub
   
    Private Sub btn_oo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_oo.Click
        Try
            barcode_1(TXT_CALCALUTER.Text)
      
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub
End Class