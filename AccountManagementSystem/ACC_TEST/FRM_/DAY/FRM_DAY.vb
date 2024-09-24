Public Class FRM_DAY
    Dim cls_account_ As New CLS_ACCOUNT
    Dim CLS_DAY_ As New CLS_DAY
    Dim CLS_CURRENCY_ As New CLS_CURRENCY
    Dim CLS_JOB_ As New CLS_JOB
    Dim GUID___ As String
    Dim column_index As Integer = 0

    Dim US00_BT_ As New US00_BT
    'Private f1 As Form1
    'Public Sub New(ByRef f As Form)
    '    InitializeComponent()

    '    Me.f1 = f
    'End Sub
    'Private _isDataModified As Boolean = False
    'Public Property IsDataModified() As Boolean
    '    Get
    '        Return _isDataModified
    '    End Get
    '    Set(ByVal value As Boolean)
    '        If Not value.Equals(_isDataModified) Then
    '            _isDataModified = value
    '        End If
    '    End Set
    'End Property
    Private Sub FRM_DAY_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If MessageBox.Show("هل متاكد من الخروج", "تنبيه", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.No Then
            e.Cancel = True
        End If
    End Sub


    Private Sub FRM_DAY_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            If number_day___ = 0 Then
                MAX_1()
                SHOW_JOB()
                SHOW_CURRENCY()
            Else

            End If

          
            'For I As Integer = 0 To 1000
            '    DGV.Rows.Add()
            '    DGV.Rows(I).HeaderCell.Value = (DGV.Rows(I).Index + 1).ToString
            'Next

            'For I As Integer = 0 To DGV.Rows.Count - 1

            '    DGV.Rows(I).HeaderCell.Value = (DGV.Rows(I).Index + 1).ToString
            'Next

            'For Each row As DataGridViewRow In DGV.Rows

            '    If row.IsNewRow Then Continue For

            '    row.HeaderCell.Value = (row.Index + 1).ToString

            'Next

            'DGV.AutoResizeRowHeadersWidth(DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders)

            SHOW_US000_BT()

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub
    Sub SHOW_US000_BT()

        Dim count_ As Integer = 0
        Dim dt As New DataTable
        dt.Clear()
        dt = US00_BT_.GUID_ET_(guid_user_log)
        If dt.Rows.Count > 0 Then
            Dim dt1 As New DataTable
            dt1.Clear()

            'ISINSERT,ISUPDATE,ISDELETE,ISprint ,ISSHOW 
            dt1 = US00_BT_.GUID_ET_us("00000000-0000-0000-0000-000000000000", guid_user_log)
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
    Sub SHOW_JOB()
        Dim DT As New DataTable
        DT.Clear()
        DT = CLS_JOB_.SELECT_
        If DT.Rows.Count > 0 Then
            TXT_JOB.Text = DT.Rows(0)(1).ToString()
            TXT_GUID_JOB.Text = DT.Rows(0)(2).ToString()
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
        DT = CLS_DAY_.MAX_1()
        If DT.Rows.Count > 0 Then
            TXT_ID.Text = DT.Rows(0)(0).ToString()
        End If
    End Sub
    Private Sub TXT_ID_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TXT_ID.KeyPress
        'e.Handled = True
    End Sub

    
    Sub show_day1()
        Dim dt As New DataTable
        dt.Clear()
        dt = CLS_DAY_.show_day1(Val(TXT_ID.Text))
        If dt.Rows.Count > 0 Then
            TXT_GUID.Text = dt.Rows(0)(0).ToString()
            DTP.Value = Convert.ToDateTime(dt.Rows(0)(2).ToString())
            TXT_NOTE.Text = dt.Rows(0)(3).ToString()
            TXT_TYPE.Text = dt.Rows(0)(4).ToString()
            TXT_PARENT_TYPE.Text = dt.Rows(0)(5).ToString()

            TXT_GUID_JOB.Text = dt.Rows(0)(6).ToString()
            TXT_JOB.Text = dt.Rows(0)(7).ToString()

            TXT_GUID_CURRENCY.Text = dt.Rows(0)(8).ToString()
            TXT_CURRENCY.Text = dt.Rows(0)(9).ToString()
            TXT_CURRENCY_VAL.Text = Val(dt.Rows(0)(10).ToString()).ToString("0.00")
        Else
            TXT_NOTE.Text = Nothing
            TXT_GUID.Text = Nothing

            TXT_TYPE.Text = "00000000-0000-0000-0000-000000000000"
            TXT_PARENT_TYPE.Text = "00000000-0000-0000-0000-000000000000"
        End If

    End Sub
    Sub SHOW_DAY2()
        DGV.Rows.Clear()

        For II As Integer = 0 To 999
            DGV.Rows.Add()
            DGV.Rows(II).HeaderCell.Value = (DGV.Rows(II).Index + 1).ToString
        Next

        Dim COUNT_ As Integer = 0

        Dim DT As New DataTable
        DT.Clear()
        DT = CLS_DAY_.show_day2(TXT_GUID.Text)
        If DT.Rows.Count > 0 Then

            For I As Integer = 0 To DT.Rows.Count - 1
                DGV.Rows(COUNT_).Cells(0).Value = DT.Rows(I)(0).ToString()
                DGV.Rows(COUNT_).Cells(1).Value = DT.Rows(I)(1).ToString()
                DGV.Rows(COUNT_).Cells(2).Value = DT.Rows(I)(2).ToString()
                DGV.Rows(COUNT_).Cells(3).Value = Val(DT.Rows(I)(3).ToString()) / Val(DT.Rows(I)(10).ToString())
                DGV.Rows(COUNT_).Cells(4).Value = Val(DT.Rows(I)(4).ToString()) / Val(DT.Rows(I)(10).ToString())
                DGV.Rows(COUNT_).Cells(5).Value = DT.Rows(I)(5).ToString()

                DGV.Rows(COUNT_).Cells(6).Value = DT.Rows(I)(6).ToString()
                DGV.Rows(COUNT_).Cells(7).Value = DT.Rows(I)(7).ToString()

                DGV.Rows(COUNT_).Cells(8).Value = DT.Rows(I)(8).ToString()
                DGV.Rows(COUNT_).Cells(9).Value = DT.Rows(I)(9).ToString()
                DGV.Rows(COUNT_).Cells(10).Value = DT.Rows(I)(10).ToString()

                COUNT_ = COUNT_ + 1

            Next




        End If
    End Sub
   
    Sub total_()
        Dim deb_ As Double = 0
        Dim curr_deb_ As Double = 0

        Dim cre_ As Double = 0
        Dim curr_cre__ As Double = 0

        For i As Integer = 0 To DGV.Rows.Count - 1
            If DGV.Rows(i).Cells(0).Value <> Nothing Then


                If DGV.Rows(i).Cells(8).Value = TXT_GUID_CURRENCY.Text Then
                    deb_ = Val(deb_) + (Val(DGV.Rows(i).Cells(3).Value))
                    cre_ = Val(cre_) + (Val(DGV.Rows(i).Cells(4).Value))
                Else


                    curr_deb_ = Val(DGV.Rows(i).Cells(3).Value) * Val(DGV.Rows(i).Cells(10).Value)
                    deb_ = Val(deb_) + (curr_deb_) / Val(TXT_CURRENCY_VAL.Text)

                    curr_cre__ = Val(DGV.Rows(i).Cells(4).Value) * Val(DGV.Rows(i).Cells(10).Value)
                    cre_ = Val(cre_) + (curr_cre__) / Val(TXT_CURRENCY_VAL.Text)

                End If





            End If

        Next
        TXT_D.Text = deb_.ToString("0.000")
        TXT_C.Text = cre_.ToString("0.000")
        TXT_DEF.Text = (Val(deb_) - Val(cre_)).ToString("0.000")

    End Sub
    Private Sub TXT_D_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TXT_D.KeyPress
        e.Handled = True
    End Sub

    Private Sub TXT_D_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TXT_D.TextChanged

    End Sub

    Private Sub TXT_C_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TXT_C.KeyPress
        e.Handled = True
    End Sub

    Private Sub TXT_C_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TXT_C.TextChanged

    End Sub

    Private Sub TXT_DEF_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TXT_DEF.KeyPress
        e.Handled = True
    End Sub

   


    Private Sub DGV_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGV.CellClick
        Try


            Dim i As Integer = DGV.CurrentCell.RowIndex
            Dim j As Integer = DGV.CurrentCell.ColumnIndex

            'Dim frm As New Form1("2")
            'frm.Refresh()
            'Dim frm As Form1 = DirectCast(sender, Form1)
            'frm.TextBox1.Text = "55"
            'If frm.Redisplay Then
            'reload the dataset that is bound to the datagridview
            'End If
            'Form1.Update
            '          If Form1.Show = DialogResult.OK Then
            '              If Form1.IsDataModified Then
            'Dim cm as CurrencyManager(BindingContext(dg.DataSource), CurrencyManager)
            '                  cm.Refresh()
            '              End If
            '          End If
            '          Form1.TextBox1.Text = DGV.Rows(i).Cells(0).Value.ToString()
            'If j = 2 Then
            'Dim f As New FRM_ALL_ACCOUNT
            'f.ShowDialog()
            'If f.IS_YES = True Then
            '    Dim ii As Integer = f.DGV.CurrentRow.Index

            '    DGV.Rows(i).Cells(0).Value = f.DGV.Rows(ii).Cells(0).Value.ToString()
            '    DGV.Rows(i).Cells(1).Value = f.DGV.Rows(ii).Cells(3).Value.ToString()
            '    DGV.Rows(i).Cells(2).Value = f.DGV.Rows(ii).Cells(1).Value.ToString()
            'End If
            'End If


            If j = 7 Then
                Dim F As New FRM_ALL_HOB
                F.ShowDialog()
                If F.IS_YES = True Then
                    Dim II As Integer = F.DGV.CurrentRow.Index
                    DGV.Rows(i).Cells(6).Value = F.DGV.Rows(II).Cells(2).Value.ToString()
                    DGV.Rows(i).Cells(7).Value = F.DGV.Rows(II).Cells(1).Value.ToString()

                End If
            End If

            If j = 9 Then
                Dim F As New FRM_ALL_CURRENCY
                F.ShowDialog()
                If F.IS_YES = True Then
                    Dim II As Integer = F.DGV.CurrentRow.Index
                    DGV.Rows(i).Cells(8).Value = F.DGV.Rows(II).Cells(0).Value.ToString()
                    DGV.Rows(i).Cells(9).Value = F.DGV.Rows(II).Cells(2).Value.ToString()
                    DGV.Rows(i).Cells(10).Value = Val(F.DGV.Rows(II).Cells(4).Value.ToString()).ToString("0.00")
                    total_()
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

  

   

    
    Private Sub DGV_CellEndEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGV.CellEndEdit
        Try
            Dim i As Integer = DGV.CurrentCell.RowIndex
            Dim j As Integer = DGV.CurrentCell.ColumnIndex

            'عند الكتابة بالمدين
            If j = 3 Then
                DGV.Rows(i).Cells(4).Value = Nothing
            End If
            'عند الكتابة بالدائن
            If j = 4 Then
                DGV.Rows(i).Cells(3).Value = Nothing
            End If

            '-----------------------------------------------------
            If j = 1 Then
                If DGV.Rows(i).Cells(j).Value <> Nothing Then
                    Dim dt = New DataTable
                    dt.Clear()
                    dt = cls_account_.searsh_code(Val(DGV.Rows(i).Cells(j).Value))
                    If dt.Rows.Count > 0 Then
                        DGV.Rows(i).Cells(0).Value = dt.Rows(0)(0).ToString()
                        DGV.Rows(i).Cells(2).Value = dt.Rows(0)(1).ToString()

                        If DGV.Rows(i).Cells(6).Value = Nothing Then
                            DGV.Rows(i).Cells(6).Value = TXT_GUID_JOB.Text
                            DGV.Rows(i).Cells(7).Value = TXT_JOB.Text
                        End If
                        If DGV.Rows(i).Cells(8).Value = Nothing Then
                            DGV.Rows(i).Cells(8).Value = TXT_GUID_CURRENCY.Text
                            DGV.Rows(i).Cells(9).Value = TXT_CURRENCY.Text
                            DGV.Rows(i).Cells(10).Value = Val(TXT_CURRENCY_VAL.Text).ToString("0.000")
                        End If
                    Else
                        DGV.Rows(i).Cells(0).Value = Nothing
                        DGV.Rows(i).Cells(1).Value = Nothing
                        DGV.Rows(i).Cells(2).Value = Nothing
                    End If
                End If
            End If
            '----------------------------------------
            If j = 2 Then
                If DGV.Rows(i).Cells(j).Value <> Nothing Then
                    Dim dt = New DataTable
                    dt.Clear()
                    dt = cls_account_.searsh_name___(DGV.Rows(i).Cells(j).Value.ToString())
                    If dt.Rows.Count > 0 Then
                        DGV.Rows(i).Cells(0).Value = dt.Rows(0)(0).ToString()
                        DGV.Rows(i).Cells(1).Value = dt.Rows(0)(3).ToString()
                        DGV.Rows(i).Cells(2).Value = dt.Rows(0)(1).ToString()



                        If DGV.Rows(i).Cells(6).Value = Nothing Then
                            DGV.Rows(i).Cells(6).Value = TXT_GUID_JOB.Text
                            DGV.Rows(i).Cells(7).Value = TXT_JOB.Text
                        End If
                        If DGV.Rows(i).Cells(8).Value = Nothing Then
                            DGV.Rows(i).Cells(8).Value = TXT_GUID_CURRENCY.Text
                            DGV.Rows(i).Cells(9).Value = TXT_CURRENCY.Text
                            DGV.Rows(i).Cells(10).Value = Val(TXT_CURRENCY_VAL.Text).ToString("0.000")
                        End If
                    Else
                        'DGV.Rows(i).Cells(0).Value = Nothing
                        'DGV.Rows(i).Cells(2).Value = Nothing
                        Dim f As New FRM_ALL_ACCOUNT
                        f.TXT_SEARSH.Text = DGV.Rows(i).Cells(j).Value.ToString()
                        f.ShowDialog()
                        If f.IS_YES = True Then
                            'Dim ii As Integer = f.DGV.CurrentRow.Index
                            For ii As Integer = 0 To f.DGV.Rows.Count - 1
                                If f.DGV.Rows(ii).Cells(5).Value = True Then
                                    'DGV.Rows.Add(f.DGV.Rows(ii).Cells(0).Value.ToString(), f.DGV.Rows(ii).Cells(3).Value.ToString(), f.DGV.Rows(ii).Cells(1).Value.ToString())
                                    DGV.Rows(i).Cells(0).Value = f.DGV.Rows(ii).Cells(0).Value.ToString()
                                    DGV.Rows(i).Cells(1).Value = f.DGV.Rows(ii).Cells(3).Value.ToString()
                                    DGV.Rows(i).Cells(2).Value = f.DGV.Rows(ii).Cells(1).Value.ToString()


                                    If DGV.Rows(i).Cells(6).Value = Nothing Then
                                        DGV.Rows(i).Cells(6).Value = TXT_GUID_JOB.Text
                                        DGV.Rows(i).Cells(7).Value = TXT_JOB.Text
                                    End If
                                    If DGV.Rows(i).Cells(8).Value = Nothing Then
                                        DGV.Rows(i).Cells(8).Value = TXT_GUID_CURRENCY.Text
                                        DGV.Rows(i).Cells(9).Value = TXT_CURRENCY.Text
                                        DGV.Rows(i).Cells(10).Value = Val(TXT_CURRENCY_VAL.Text).ToString("0.000")
                                    End If

                                    i = i + 1
                                End If
                            Next
                          
                        End If
                    End If
                End If
            End If
           

            total_()
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
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
        DT = CLS_DAY_.MAX_()
        If DT.Rows.Count > 0 Then
            TXT_ID.Text = DT.Rows(0)(0).ToString()
        End If
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
        DT = CLS_DAY_.MIN_()
        If DT.Rows.Count > 0 Then
            TXT_ID.Text = DT.Rows(0)(0).ToString()
        End If
    End Sub

  
    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click
        Try
            Dim max___ As Double = 0
            Dim DT As New DataTable
            DT.Clear()
            DT = CLS_DAY_.MAX_()
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
            DT = CLS_DAY_.MIN_()
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

    Private Sub DGV_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGV.CellContentClick
      
    End Sub

    Sub add_day1()
        Dim note_ As String = TXT_ID.Text + "/" + "سند قيد"
        CLS_DAY_.add_day1(Val(TXT_ID.Text), DTP.Value.ToShortDateString(), TXT_NOTE.Text, "00000000-0000-0000-0000-000000000000", note_, TXT_GUID_JOB.Text, TXT_GUID_CURRENCY.Text, Val(TXT_CURRENCY_VAL.Text), guid_user_log)
    End Sub

    Sub add_day2()
        Dim dt As New DataTable
        dt.Clear()
        dt = CLS_DAY_.guid__(Val(TXT_ID.Text))
        TXT_GUID.Text = dt.Rows(0)(0).ToString()


        For i As Integer = 0 To DGV.Rows.Count - 1
            If DGV.Rows(i).Cells(0).Value <> Nothing Then
                Dim note_ As String

                If DGV.Rows(i).Cells(5).Value = Nothing Then
                    note_ = TXT_ID.Text + "/" + "سند قيد"
                Else
                    note_ = DGV.Rows(i).Cells(5).Value.ToString()
                End If

                If DGV.Rows(i).Cells(3).Value = Nothing Then
                    DGV.Rows(i).Cells(3).Value = 0
               
                End If
                If DGV.Rows(i).Cells(4).Value = Nothing Then
                    DGV.Rows(i).Cells(4).Value = 0

                End If

                CLS_DAY_.add_day2(TXT_GUID.Text,
                                  DGV.Rows(i).Cells(0).Value.ToString(),
                                  Val(DGV.Rows(i).Cells(3).Value),
                                  Val(DGV.Rows(i).Cells(4).Value),
                                  note_,
                                  DGV.Rows(i).Cells(6).Value.ToString(),
                                  DGV.Rows(i).Cells(8).Value.ToString(),
                                  Val(DGV.Rows(i).Cells(10).Value))
            End If
        Next
    End Sub


    Private Sub حفظToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Nav_SAVE.Click
        Try
            If TXT_TYPE.Text <> "00000000-0000-0000-0000-000000000000" Then
                MessageBox.Show("  لايمكن اضافة  سند مرتبط", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
            '---------------------------------------------------------------------

            '---------------------------------------------------------------------
            If TXT_D.Text = "0.000" Then
                MessageBox.Show(" المدين =0", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
            '---------------------------------------------------------------------
            If TXT_C.Text = "0.000" Then
                MessageBox.Show(" الدائن =0", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If

            '---------------------------------------------------------------------

            If TXT_DEF.Text <> "0.000" Then
                MessageBox.Show(" القيد غير متوازن ", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
            '---------------------------------------------------------------------
            MAX_1()
            add_day1()
            add_day2()

            MessageBox.Show("   تمت عملية حفظ السند بنجاح ", "تاكيد", MessageBoxButtons.OK, MessageBoxIcon.Information)


        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub


    Private Sub جديدToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles جديدToolStripMenuItem.Click
        Try
            MAX_1()
            DTP.Value = Today
            TXT_GUID.Text = Nothing
            TXT_NOTE.Text = Nothing
            'TXT_TYPE.Text = ""
            DGV.Rows.Clear()
            For I As Integer = 0 To 1000
                DGV.Rows.Add()
            Next
            total_()
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub


    Sub update_day1()
        CLS_DAY_.update_day1(DTP.Value.ToShortDateString(), TXT_NOTE.Text, "00000000-0000-0000-0000-000000000000", TXT_ID.Text + "/" + "سند قيد", TXT_GUID.Text, TXT_GUID_JOB.Text, TXT_GUID_CURRENCY.Text, Val(TXT_CURRENCY_VAL.Text), guid_user_log)
    End Sub


    Private Sub تعديلToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NavUPDATE.Click
        Try
            If TXT_TYPE.Text <> "00000000-0000-0000-0000-000000000000" Then
                MessageBox.Show("  لايمكن تعديل سند مرتبط", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If

            If TXT_GUID.Text = Nothing Then
                MessageBox.Show("  لايوجد سند قيد", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
            '---------------------------------------------------------------------
            If TXT_D.Text = "0.000" Then
                MessageBox.Show(" المدين =0", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
            '---------------------------------------------------------------------
            If TXT_C.Text = "0.000" Then
                MessageBox.Show(" الدائن =0", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If

            '---------------------------------------------------------------------

            If TXT_DEF.Text <> "0.000" Then
                MessageBox.Show(" القيد غير متوازن ", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
            '---------------------------------------------------------------------
            update_day1()
            CLS_DAY_.delete_day2(TXT_GUID.Text)
            add_day2()

            MessageBox.Show("   تمت عملية التعديل السند بنجاح ", "تاكيد", MessageBoxButtons.OK, MessageBoxIcon.Information)


        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
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

    Private Sub TXT_ID_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TXT_ID.TextChanged
        Try
            DGV.Rows.Clear()

            show_day1()
            If TXT_GUID.Text <> Nothing Then
                SHOW_DAY2()
                'DGV.Rows(0).Visible = False
                total_()
            Else
                For I As Integer = 0 To 999
                    DGV.Rows.Add()
                    DGV.Rows(I).HeaderCell.Value = (DGV.Rows(I).Index + 1).ToString
                Next
            End If
            'If Val(TXT_ID.Text) > 20 Then
            '    Close()
            'End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub حذفToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NavDELETE.Click
        Try
            If TXT_TYPE.Text <> "00000000-0000-0000-0000-000000000000" Then
                MessageBox.Show("  لايمكن حذف سند مرتبط", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If

            '---------------------------------------------------------------------
            If MessageBox.Show("هل انت متاكد من عملية الحذف", "تنبيه", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = Windows.Forms.DialogResult.Yes Then
                CLS_DAY_.delete_day1(TXT_GUID.Text)
                MessageBox.Show("   تمت عملية حذف السند بنجاح ", "تاكيد", MessageBoxButtons.OK, MessageBoxIcon.Information)
                MAX_1()

            End If





        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub ToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NavPRENT.Click
        Try
            Dim dt_ As New DataTable
            dt_.Clear()
            dt_ = CLS_DAY_.show_day1(Val(TXT_ID.Text))
            If dt_.Rows.Count > 0 Then
            Else
                MessageBox.Show("  لايمكن طباعة سند غير موجود", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
            '-------------------------------------------------------
            Dim dt As New DataTable
            With dt
                .Columns.Add("d1_number")
                .Columns.Add("d1_date")
                .Columns.Add("d1_note")
                .Columns.Add("d1_job")
                .Columns.Add("d1_currency")
                .Columns.Add("d1_valcurrency")
                .Columns.Add("d1_debet")
                .Columns.Add("d1_credit")
                .Columns.Add("d2_codeaccount")
                .Columns.Add("d2_account")
                .Columns.Add("d2_debit")
                .Columns.Add("d2_credit")
                .Columns.Add("d2_note")
                .Columns.Add("d2_job")
                .Columns.Add("d2_currency")
                .Columns.Add("d2_valcurrency")
            End With

            '-------------------------------------------------------
            For I As Integer = 0 To DGV.Rows.Count - 1
                If DGV.Rows(I).Cells(0).Value <> Nothing Then
                    dt.Rows.Add(TXT_ID.Text, DTP.Value.ToShortDateString(), TXT_NOTE.Text, TXT_JOB.Text, TXT_CURRENCY.Text, TXT_CURRENCY_VAL.Text, TXT_D.Text, TXT_C.Text, DGV.Rows(I).Cells(1).Value, DGV.Rows(I).Cells(2).Value, DGV.Rows(I).Cells(3).Value, DGV.Rows(I).Cells(4).Value, DGV.Rows(I).Cells(5).Value, DGV.Rows(I).Cells(7).Value, DGV.Rows(I).Cells(9).Value, DGV.Rows(I).Cells(10).Value)
                End If

            Next
            '-------------------------------------------------------
            Dim rptDoc As CrystalDecisions.CrystalReports.Engine.ReportDocument
            rptDoc = New Crystal__DAY

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

    Private Sub DGV_DefaultCellStyleChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles DGV.DefaultCellStyleChanged

    End Sub
 
    Private Sub DGV_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles DGV.KeyPress
        'If (e.KeyChar = CType(ChrW(Keys.Enter), Char)) Then
        '    Dim i As Integer = DGV.CurrentRow.Index
        '    MessageBox.Show(i.ToString)
        'End If
    End Sub

    Private Sub DGV_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles DGV.Click
        Try
            Dim i As Integer = DGV.CurrentCell.RowIndex
            Dim j As Integer = DGV.CurrentCell.ColumnIndex


            'If j = 2 Then
            '    Dim f As New FRM_ALL_ACCOUNT
            '    f.ShowDialog()
            '    If f.IS_YES = True Then
            '        Dim ii As Integer = f.DGV.CurrentRow.Index

            '        DGV.Rows(i).Cells(0).Value = f.DGV.Rows(ii).Cells(0).Value.ToString()
            '        DGV.Rows(i).Cells(1).Value = f.DGV.Rows(ii).Cells(3).Value.ToString()
            '        DGV.Rows(i).Cells(2).Value = f.DGV.Rows(ii).Cells(1).Value.ToString()
            '    End If
            'End If


            If j = 7 Then
                Dim F As New FRM_ALL_HOB
                F.ShowDialog()
                If F.IS_YES = True Then
                    Dim II As Integer = F.DGV.CurrentRow.Index
                    DGV.Rows(i).Cells(6).Value = F.DGV.Rows(II).Cells(2).Value.ToString()
                    DGV.Rows(i).Cells(7).Value = F.DGV.Rows(II).Cells(1).Value.ToString()

                End If
            End If

            If j = 9 Then
                Dim F As New FRM_ALL_CURRENCY
                F.ShowDialog()
                If F.IS_YES = True Then
                    Dim II As Integer = F.DGV.CurrentRow.Index
                    DGV.Rows(i).Cells(8).Value = F.DGV.Rows(II).Cells(0).Value.ToString()
                    DGV.Rows(i).Cells(9).Value = F.DGV.Rows(II).Cells(2).Value.ToString()
                    DGV.Rows(i).Cells(10).Value = Val(F.DGV.Rows(II).Cells(4).Value.ToString()).ToString("0.00")
                    total_()
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub ToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem2.Click
        Try

            Dim ID__ As Integer = 0



            Dim F As New FRM_COPY
            F.ShowDialog()


            If F.IS_YES = True Then

                ID__ = F.TXT_ID.Text
                Dim dt As New DataTable
                dt.Clear()
                dt = CLS_DAY_.show_day1_COPY(Val(ID__))
                If dt.Rows.Count > 0 Then
                    GUID___ = dt.Rows(0)(0).ToString()
                    SHOW_DAY_COPY()
                    total_()
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub

    Sub SHOW_DAY_COPY()
        DGV.Rows.Clear()

        For II As Integer = 0 To 999
            DGV.Rows.Add()
            DGV.Rows(II).HeaderCell.Value = (DGV.Rows(II).Index + 1).ToString
        Next

        Dim COUNT_ As Integer = 0

        Dim DT As New DataTable
        DT.Clear()
        DT = CLS_DAY_.show_day2(GUID___)
        If DT.Rows.Count > 0 Then

            For I As Integer = 0 To DT.Rows.Count - 1
                DGV.Rows(COUNT_).Cells(0).Value = DT.Rows(I)(0).ToString()
                DGV.Rows(COUNT_).Cells(1).Value = DT.Rows(I)(1).ToString()
                DGV.Rows(COUNT_).Cells(2).Value = DT.Rows(I)(2).ToString()
                DGV.Rows(COUNT_).Cells(3).Value = Val(DT.Rows(I)(3).ToString()) / Val(DT.Rows(I)(10).ToString())
                DGV.Rows(COUNT_).Cells(4).Value = Val(DT.Rows(I)(4).ToString()) / Val(DT.Rows(I)(10).ToString())
                'DGV.Rows(COUNT_).Cells(5).Value = DT.Rows(I)(5).ToString()

                DGV.Rows(COUNT_).Cells(6).Value = DT.Rows(I)(6).ToString()
                DGV.Rows(COUNT_).Cells(7).Value = DT.Rows(I)(7).ToString()

                DGV.Rows(COUNT_).Cells(8).Value = DT.Rows(I)(8).ToString()
                DGV.Rows(COUNT_).Cells(9).Value = DT.Rows(I)(9).ToString()
                DGV.Rows(COUNT_).Cells(10).Value = DT.Rows(I)(10).ToString()

                COUNT_ = COUNT_ + 1

            Next




        End If
    End Sub

    Private Sub DGV_EditingControlShowing(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewEditingControlShowingEventArgs) Handles DGV.EditingControlShowing
        Dim i As Integer = DGV.CurrentCell.RowIndex
        Dim j As Integer = DGV.CurrentCell.ColumnIndex


        If j = 3 Or j = 4 Then
            column_index = DGV.CurrentCell().ColumnIndex

            Dim TextEdit As TextBox = e.Control

            RemoveHandler TextEdit.KeyPress, AddressOf TextBox_KeyPress_Number
            AddHandler TextEdit.KeyPress, AddressOf TextBox_KeyPress_Number
        End If
    End Sub
    Public Sub TextBox_KeyPress_Number(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)

        Dim i As Integer = DGV.CurrentCell.RowIndex
        Dim j As Integer = DGV.CurrentCell.ColumnIndex

        If j = 3 Or j = 4 Then
            Select Case column_index = 0
                Case 0

                    If (e.KeyChar >= "a" And e.KeyChar <= "z") Or (e.KeyChar >= "A" And e.KeyChar <= "Z") Or (e.KeyChar >= "ا" And e.KeyChar <= "ي") Then
                        e.Handled = True
                    End If



            End Select

        End If
    End Sub

    Private Sub حذفالسطرToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles حذفالسطرToolStripMenuItem.Click

        Try
            If MessageBox.Show("هل انت متاكد من عملية حذف السطر", "تنبيه", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = Windows.Forms.DialogResult.Yes Then
                CLS_DAY_.delete_day1(TXT_GUID.Text)
                  DGV.Rows.RemoveAt(DGV.CurrentRow.Index)
                total_()
            End If


        Catch ex As Exception

        End Try

    End Sub

    Private Sub TXT_JOB_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles TXT_JOB.KeyPress
        e.Handled = True
    End Sub

    Private Sub TXT_JOB_TextChanged(sender As System.Object, e As System.EventArgs) Handles TXT_JOB.TextChanged

    End Sub

    Private Sub TXT_CURRENCY_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles TXT_CURRENCY.KeyPress
        e.Handled = True
    End Sub

    Private Sub TXT_CURRENCY_TextChanged(sender As System.Object, e As System.EventArgs) Handles TXT_CURRENCY.TextChanged

    End Sub

    Private Sub TXT_CURRENCY_VAL_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles TXT_CURRENCY_VAL.KeyPress
        If (e.KeyChar >= "a" And e.KeyChar <= "z") Or (e.KeyChar >= "A" And e.KeyChar <= "Z") Or (e.KeyChar >= "ا" And e.KeyChar <= "ي") Then
            e.Handled = True
        End If
    End Sub

    Private Sub TXT_CURRENCY_VAL_TextChanged(sender As System.Object, e As System.EventArgs) Handles TXT_CURRENCY_VAL.TextChanged

    End Sub

    Private Sub DGV_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles DGV.DoubleClick

     


    End Sub

    Private Sub DGV_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGV.CellDoubleClick
 
    End Sub

    Private Sub بحثToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles بحثToolStripMenuItem.Click
        Try
            Dim i As Integer = DGV.CurrentCell.RowIndex
            Dim j As Integer = DGV.CurrentCell.ColumnIndex




            Dim f As New FRM_ALL_ACCOUNT

            f.ShowDialog()
            If f.IS_YES = True Then
                'Dim ii As Integer = f.DGV.CurrentRow.Index
                For ii As Integer = 0 To f.DGV.Rows.Count - 1
                    If f.DGV.Rows(ii).Cells(5).Value = True Then
                        'DGV.Rows.Add(f.DGV.Rows(ii).Cells(0).Value.ToString(), f.DGV.Rows(ii).Cells(3).Value.ToString(), f.DGV.Rows(ii).Cells(1).Value.ToString())
                        DGV.Rows(i).Cells(0).Value = f.DGV.Rows(ii).Cells(0).Value.ToString()
                        DGV.Rows(i).Cells(1).Value = f.DGV.Rows(ii).Cells(3).Value.ToString()
                        DGV.Rows(i).Cells(2).Value = f.DGV.Rows(ii).Cells(1).Value.ToString()


                        If DGV.Rows(i).Cells(6).Value = Nothing Then
                            DGV.Rows(i).Cells(6).Value = TXT_GUID_JOB.Text
                            DGV.Rows(i).Cells(7).Value = TXT_JOB.Text
                        End If
                        If DGV.Rows(i).Cells(8).Value = Nothing Then
                            DGV.Rows(i).Cells(8).Value = TXT_GUID_CURRENCY.Text
                            DGV.Rows(i).Cells(9).Value = TXT_CURRENCY.Text
                            DGV.Rows(i).Cells(10).Value = Val(TXT_CURRENCY_VAL.Text).ToString("0.00")
                        End If

                        i = i + 1
                    End If
                Next

            End If



        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub بطاقةحسابToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles بطاقةحسابToolStripMenuItem.Click
        Try
            Dim I As Integer = DGV.CurrentRow.Index
            Dim F As New FRM_NEW_ACCOUNT
            F.cmb_()
            F.TXT_GUID.Text = DGV.Rows(I).Cells(0).Value.ToString()
            F.ShowDialog()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub حسابجديدToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles حسابجديدToolStripMenuItem.Click
        Dim F As New FRM_NEW_ACCOUNT
        F.cmb_()
        F.ShowDialog()
    End Sub
End Class