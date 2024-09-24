Public Class FRM_DAY_CASH
    Dim cls_account_ As New CLS_ACCOUNT
    Dim CLS_DAY_ As New CLS_DAY
    Dim CLS_CASH_DAY_ As New CLS_CASH_DAY
    Dim id_day As Integer = 0
    Dim guid_day As String
    Dim CLS_CURRENCY_ As New CLS_CURRENCY
    Dim CLS_JOB_ As New CLS_JOB
    Dim ClS_TYPE_CASH_ As New ClS_TYPE_CASH
    Dim US00_BT_ As New US00_BT

    Private Sub DGV_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)
        Try
            Dim i As Integer = DGV.CurrentCell.RowIndex
            Dim j As Integer = DGV.CurrentCell.ColumnIndex


            If j = 2 Then

                Dim f As New FRM_ALL_ACCOUNT
                f.ShowDialog()
                If f.IS_YES = True Then
                    Dim ii As Integer = f.DGV.CurrentRow.Index

                    DGV.Rows(i).Cells(0).Value = f.DGV.Rows(ii).Cells(0).Value.ToString()
                    DGV.Rows(i).Cells(1).Value = f.DGV.Rows(ii).Cells(3).Value.ToString()
                    DGV.Rows(i).Cells(2).Value = f.DGV.Rows(ii).Cells(1).Value.ToString()
                End If
            End If

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub DGV_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)

    End Sub

    Private Sub DGV_CellEndEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)
        Try
            Dim i As Integer = DGV.CurrentCell.RowIndex
            Dim j As Integer = DGV.CurrentCell.ColumnIndex


            If j = 1 Then
                If DGV.Rows(i).Cells(j).Value <> Nothing Then
                    Dim dt = New DataTable
                    dt.Clear()
                    dt = cls_account_.searsh_code(Val(DGV.Rows(i).Cells(j).Value))
                    If dt.Rows.Count > 0 Then
                        DGV.Rows(i).Cells(0).Value = dt.Rows(0)(0).ToString()
                        DGV.Rows(i).Cells(2).Value = dt.Rows(0)(1).ToString()
                    Else
                        DGV.Rows(i).Cells(0).Value = Nothing
                        DGV.Rows(i).Cells(2).Value = Nothing
                    End If
                End If
            End If


            total_()
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub
    Sub total_()
        'Dim deb_ As Double = 0
        'Dim cre_ As Double = 0
        'For i As Integer = 0 To DGV.Rows.Count - 1
        '    If DGV.Rows(i).Cells(0).Value <> Nothing Then
        '        deb_ = Val(deb_) + Val(DGV.Rows(i).Cells(3).Value)
        '        cre_ = Val(cre_) + Val(DGV.Rows(i).Cells(4).Value)
        '    End If

        'Next
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
        'TXT_D.Text = deb_.ToString()
        'TXT_C.Text = cre_.ToString()
        'TXT_DEF.Text = (Val(deb_) - Val(cre_)).ToString()



        If TXT_CODE.Text = "0" Then
            TXT_TOTAL.Text = cre_.ToString("0.000")
        Else
            TXT_TOTAL.Text = deb_.ToString("0.000")
        End If
        'TXT_D.Text = deb_.ToString()
        'TXT_C.Text = cre_.ToString()
        'TXT_DEF.Text = (Val(deb_) - Val(cre_)).ToString()

    End Sub
    Sub MAX_1()
        Dim DT As New DataTable
        DT.Clear()
        DT = CLS_CASH_DAY_.MAX_1(TXT_PARENTGUID.Text)
        If DT.Rows.Count > 0 Then
            TXT_ID.Text = DT.Rows(0)(0).ToString()
        End If
    End Sub
    Sub MAX_1_b()
        Dim DT As New DataTable
        DT.Clear()
        DT = CLS_CASH_DAY_.MAX_1(TXT_PARENTGUID.Text)
        If DT.Rows.Count > 0 Then
            TXT_ID.Text = DT.Rows(0)(0).ToString()
        End If
    End Sub
    Private Sub FRM_DAY_CASH_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If MessageBox.Show("هل متاكد من الخروج", "تنبيه", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.No Then
            e.Cancel = True
        End If
    End Sub
    Private Sub FRM_DAY_CASH_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            If number_day___ = 0 Then
                MAX_1()
            Else

            End If

            SHOW_JOB()
            SHOW_CURRENCY()
            SHOW_CASH()
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
            dt1 = US00_BT_.GUID_ET_us(TXT_PARENTGUID.Text, guid_user_log)
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
    Sub SHOW_CASH()
        Dim DT As New DataTable
        DT.Clear()
        DT = ClS_TYPE_CASH_.SHOW_CASH(TXT_PARENTGUID.Text)
        If DT.Rows.Count > 0 Then
            TXT_GUID_CASH.Text = DT.Rows(0)(0).ToString()
            TXT_NAME_CASH.Text = DT.Rows(0)(1).ToString()
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
  
    Sub add_credit()
        'سندات الصرف القيد المحاسبي
        Dim note_ As String

        note_ = TXT_ID.Text + "/" + Me.Text

        ''الى حساب الصندوق
        'CLS_DAY_.add_day2(guid_day,
        '                  TXT_GUID_CASH.Text,
        '                 0,
        '                   Val(TXT_TOTAL.Text),
        '                  note_, TXT_GUID_JOB.Text, TXT_GUID_CURRENCY.Text, Val(TXT_CURRENCY_VAL.Text))




        'من حساب الاقلام



        For i As Integer = 0 To DGV.Rows.Count - 1
            If DGV.Rows(i).Cells(0).Value <> Nothing Then


                If DGV.Rows(i).Cells(5).Value = Nothing Then
                    note_ = TXT_ID.Text + "/" + Me.Text
                Else
                    note_ = DGV.Rows(i).Cells(5).Value.ToString()
                End If

                If DGV.Rows(i).Cells(3).Value = Nothing Then
                    DGV.Rows(i).Cells(3).Value = 0

                End If
                If DGV.Rows(i).Cells(4).Value = Nothing Then
                    DGV.Rows(i).Cells(4).Value = 0

                End If

                CLS_DAY_.add_day2(guid_day,
                                  DGV.Rows(i).Cells(0).Value.ToString(),
                                    Val(DGV.Rows(i).Cells(3).Value),
                                 0,
                                  note_,
                                    DGV.Rows(i).Cells(6).Value.ToString(),
                                  DGV.Rows(i).Cells(8).Value.ToString(),
                                  Val(DGV.Rows(i).Cells(10).Value))





                'الى حساب الصندوق
                CLS_DAY_.add_day2(guid_day,
                                  TXT_GUID_CASH.Text,
                                 0,
                                    Val(DGV.Rows(i).Cells(3).Value),
                                  note_,
                                  DGV.Rows(i).Cells(6).Value.ToString(),
                                      DGV.Rows(i).Cells(8).Value.ToString(),
                                      Val(DGV.Rows(i).Cells(10).Value))
            End If



        Next





    End Sub
    Sub add_debit()
        'سندات القبض القيد المحاسبي
        Dim note_ As String

        note_ = TXT_ID.Text + "/" + Me.Text

        ' ''من حساب الصندوق
        'CLS_DAY_.add_day2(guid_day,
        '                  TXT_GUID_CASH.Text,
        '                  Val(TXT_TOTAL.Text),
        '                  0,
        '                  note_, TXT_GUID_JOB.Text, TXT_GUID_CURRENCY.Text, Val(TXT_CURRENCY_VAL.Text))

        'الى حساب الاقلام
        For i As Integer = 0 To DGV.Rows.Count - 1


            If DGV.Rows(i).Cells(0).Value <> Nothing Then


                If DGV.Rows(i).Cells(5).Value = Nothing Then
                    note_ = TXT_ID.Text + "/" + Me.Text
                Else
                    note_ = DGV.Rows(i).Cells(5).Value.ToString()
                End If

                If DGV.Rows(i).Cells(3).Value = Nothing Then
                    DGV.Rows(i).Cells(3).Value = 0

                End If
                If DGV.Rows(i).Cells(4).Value = Nothing Then
                    DGV.Rows(i).Cells(4).Value = 0

                End If
                'من حساب الصندوق
                CLS_DAY_.add_day2(guid_day,
                                  TXT_GUID_CASH.Text,
                                  Val(DGV.Rows(i).Cells(4).Value),
                                  0,
                                  note_,
                                  DGV.Rows(i).Cells(6).Value.ToString(),
                                  DGV.Rows(i).Cells(8).Value.ToString(),
                                  Val(DGV.Rows(i).Cells(10).Value))




                CLS_DAY_.add_day2(guid_day,
                                  DGV.Rows(i).Cells(0).Value.ToString(),
                                  0,
                                   Val(DGV.Rows(i).Cells(4).Value),
                                  note_,
                                    DGV.Rows(i).Cells(6).Value.ToString(),
                                  DGV.Rows(i).Cells(8).Value.ToString(),
                                  Val(DGV.Rows(i).Cells(10).Value))
            End If
        Next



    End Sub
    Sub MAX_day_()

        Dim DT As New DataTable
        DT.Clear()
        DT = CLS_DAY_.MAX_1()
        If DT.Rows.Count > 0 Then
            id_day = DT.Rows(0)(0).ToString()
        End If
    End Sub
    Sub add_day1()
        MAX_day_()

        Dim note_ As String = TXT_ID.Text + "/" + Me.Text
        CLS_DAY_.add_day1(Val(id_day), DTP.Value.ToShortDateString(), TXT_NOTE.Text, TXT_GUID.Text, note_, TXT_GUID_JOB.Text, TXT_GUID_CURRENCY.Text, Val(TXT_CURRENCY_VAL.Text), guid_user_log)


    End Sub
    Sub show_guid_day()
        Dim dt As New DataTable
        dt.Clear()
        dt = CLS_DAY_.guid__(Val(id_day))
        guid_day = dt.Rows(0)(0).ToString()
    End Sub
    Sub add_day_cash()

        CLS_CASH_DAY_.ADD_(Val(TXT_ID.Text),
                           TXT_GUID_CASH.Text,
                           TXT_NOTE.Text,
                           TXT_PARENTGUID.Text,
                           DTP.Value,
                           TXT_GUID_JOB.Text,
                           TXT_GUID_CURRENCY.Text,
                           Val(TXT_CURRENCY_VAL.Text),
                           guid_user_log, TXT_number_document.Text,
                           TXT_name_recip.Text,
                           TXT_mobile_recipt.Text, 1, 0, DTP.Value)
    End Sub


    Sub show_guid_cash()
        Dim dt As New DataTable
        dt.Clear()
        dt = CLS_CASH_DAY_.guid__(Val(TXT_ID.Text), TXT_PARENTGUID.Text)
        If dt.Rows.Count > 0 Then
            TXT_GUID.Text = dt.Rows(0)(0).ToString()
        End If
    End Sub

  
    Sub update_cash_day()
        CLS_CASH_DAY_.UPDATE_(TXT_GUID_CASH.Text, TXT_NOTE.Text, TXT_PARENTGUID.Text, DTP.Value, TXT_GUID.Text, TXT_GUID_JOB.Text, TXT_GUID_CURRENCY.Text, Val(TXT_CURRENCY_VAL.Text), guid_user_log, TXT_number_document.Text, TXT_name_recip.Text, TXT_mobile_recipt.Text, 1, 0, DTP.Value)
    End Sub


    Sub delete_day1()
        CLS_DAY_.delete_day1_bill(TXT_GUID.Text)
    End Sub




    Sub MAX_()
        Dim DT As New DataTable
        DT.Clear()
        DT = CLS_CASH_DAY_.MAX_(TXT_PARENTGUID.Text)
        If DT.Rows.Count > 0 Then
            TXT_ID.Text = DT.Rows(0)(0).ToString()
        End If
    End Sub
   

    
 
    Sub MIN_()
        Dim DT As New DataTable
        DT.Clear()
        DT = CLS_CASH_DAY_.MIN_(TXT_PARENTGUID.Text)
        If DT.Rows.Count > 0 Then
            TXT_ID.Text = DT.Rows(0)(0).ToString()
        End If
    End Sub

    Private Sub TXT_ID_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        e.Handled = True
    End Sub

   
    Sub SHOW_DAY2()
        For II As Integer = 0 To 999
            DGV.Rows.Add()
            DGV.Rows(II).HeaderCell.Value = (DGV.Rows(II).Index + 1).ToString
        Next

        Dim COUNT_ As Integer = 0

        Dim DT As New DataTable
        DT.Clear()
        DT = CLS_DAY_.show_day2_CASH(TXT_GUID_DAY.Text, TXT_GUID_CASH.Text)
        If DT.Rows.Count > 0 Then

            For I As Integer = 0 To DT.Rows.Count - 1
                DGV.Rows(COUNT_).Cells(0).Value = DT.Rows(I)(0).ToString()
                DGV.Rows(COUNT_).Cells(1).Value = DT.Rows(I)(1).ToString()
                DGV.Rows(COUNT_).Cells(2).Value = DT.Rows(I)(2).ToString()
                DGV.Rows(COUNT_).Cells(3).Value = (Val(DT.Rows(I)(3).ToString()) / Val(DT.Rows(I)(10).ToString())).ToString("0.000")
                DGV.Rows(COUNT_).Cells(4).Value = (Val(DT.Rows(I)(4).ToString()) / Val(DT.Rows(I)(10).ToString())).ToString("0.000")
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
    Sub show_day()
        If TXT_GUID.Text <> Nothing Then


            Dim dt As New DataTable
            dt.Clear()
            dt = CLS_DAY_.number_day_bill(TXT_GUID.Text)
            If dt.Rows.Count > 0 Then
                lbl_number_day.Text = dt.Rows(0)(0).ToString()
                TXT_GUID_DAY.Text = dt.Rows(0)(1).ToString()
            Else
                lbl_number_day.Text = "0"
                TXT_GUID_DAY.Text = Nothing
            End If
        End If
    End Sub
    Sub show_catsh()
        '                                    0                   1                       2                        3                   4               5                          6           
        'dt = CON.SELECT_TXT("SELECT     dbo.CASH_DAY.GUID, dbo.CASH_DAY.NUMBER, dbo.CASH_DAY.GUID_ACCOUNT, dbo.ACCOUNT.NAME, dbo.CASH_DAY.NOTE, dbo.CASH_DAY.PARENT_GUID, dbo.CASH_DAY.DATE FROM         dbo.CASH_DAY INNER JOIN            dbo.ACCOUNT ON dbo.CASH_DAY.GUID_ACCOUNT = dbo.ACCOUNT.GUID where (CASH_DAY.PARENT_GUID='" & PARENT_ & "')and(.CASH_DAY.NUMBER=" & id_ & ")")

        Dim dt As New DataTable
        dt.Clear()
        dt = CLS_CASH_DAY_.show_(Val(TXT_ID.Text), TXT_PARENTGUID.Text)
        If dt.Rows.Count > 0 Then
            DTP.Value = Convert.ToDateTime(dt.Rows(0)(6).ToString())
            TXT_GUID_CASH.Text = dt.Rows(0)(2).ToString()
            TXT_NAME_CASH.Text = dt.Rows(0)(3).ToString()
            TXT_NOTE.Text = dt.Rows(0)(4).ToString()
            TXT_PARENTGUID.Text = dt.Rows(0)(5).ToString()
            TXT_GUID.Text = dt.Rows(0)(0).ToString()


            TXT_GUID_JOB.Text = dt.Rows(0)(7).ToString()
            TXT_JOB.Text = dt.Rows(0)(8).ToString()

            TXT_GUID_CURRENCY.Text = dt.Rows(0)(9).ToString()
            TXT_CURRENCY.Text = dt.Rows(0)(10).ToString()
            TXT_CURRENCY_VAL.Text = Val(dt.Rows(0)(11).ToString()).ToString("0.00")

            TXT_number_document.Text = dt.Rows(0)(12).ToString()
            TXT_name_recip.Text = dt.Rows(0)(13).ToString()
            TXT_mobile_recipt.Text = dt.Rows(0)(14).ToString()
        Else


            'TXT_GUID_CASH.Text = Nothing
            'TXT_NAME_CASH.Text = Nothing
            TXT_NOTE.Text = Nothing
            TXT_GUID.Text = Nothing
            'TXT_PARENTGUID.Text = Nothing

            TXT_number_document.Text = Nothing
            TXT_name_recip.Text = Nothing
            TXT_mobile_recipt.Text = Nothing
        End If
    End Sub

    'Private Sub حذفToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles حذفToolStripMenuItem.Click
    '    Try

    '        If TXT_GUID.Text = Nothing Then
    '            MessageBox.Show("  لايوجد سند", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '            Exit Sub
    '        End If
    '        '---------------------------------------------------------------------
    '        If MessageBox.Show("هل انت متاكد من عملية الحذف", "تنبيه", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = Windows.Forms.DialogResult.Yes Then
    '            'حذف راس السند
    '            delete_daycash()

    '            '---------------------------------------------------------------------
    '            'حذف سند القيد
    '            delete_day1()
    '            '---------------------------------------------------------------------
    '            show_day()
    '            MessageBox.Show("   تمت عملية حذف السند بنجاح ", "تاكيد", MessageBoxButtons.OK, MessageBoxIcon.Information)
    '            TXT_GUID.Text = Nothing

    '        End If





    '    Catch ex As Exception
    '        MessageBox.Show(ex.ToString)
    '    End Try
    'End Sub
    Sub delete_daycash()
        CLS_CASH_DAY_.DELETE_(TXT_GUID.Text)

    End Sub
  
    Sub new__()
        MAX_1()
        TXT_TOTAL.Text = "0"


        lbl_number_day.Text = "0"
        TXT_NOTE.Text = Nothing
        DTP.Value = Today
    End Sub

    Private Sub TXT_TOTAL_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TXT_TOTAL.KeyPress
        e.Handled = True
    End Sub

    Private Sub TXT_TOTAL_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TXT_TOTAL.TextChanged

    End Sub

    Private Sub TXT_NAME_CASH_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TXT_NAME_CASH.KeyPress
        e.Handled = True
    End Sub

    Private Sub TXT_NAME_CASH_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TXT_NAME_CASH.TextChanged

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

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
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

    Private Sub DGV_CellClick1(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGV.CellClick
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

    Private Sub DGV_CellContentClick_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGV.CellContentClick

    End Sub

    Private Sub DGV_CellEndEdit1(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGV.CellEndEdit
        Try
            'Dim i As Integer = DGV.CurrentCell.RowIndex
            'Dim j As Integer = DGV.CurrentCell.ColumnIndex

            ''عند الكتابة بالمدين
            'If j = 3 Then
            '    DGV.Rows(i).Cells(4).Value = Nothing
            'End If
            ''عند الكتابة بالدائن
            'If j = 4 Then
            '    DGV.Rows(i).Cells(3).Value = Nothing
            'End If


            'If j = 1 Then
            '    If DGV.Rows(i).Cells(j).Value <> Nothing Then
            '        Dim dt = New DataTable
            '        dt.Clear()
            '        dt = cls_account_.searsh_code(Val(DGV.Rows(i).Cells(j).Value))
            '        If dt.Rows.Count > 0 Then
            '            DGV.Rows(i).Cells(0).Value = dt.Rows(0)(0).ToString()
            '            DGV.Rows(i).Cells(2).Value = dt.Rows(0)(1).ToString()
            '        Else
            '            DGV.Rows(i).Cells(0).Value = Nothing
            '            DGV.Rows(i).Cells(2).Value = Nothing
            '        End If
            '    End If
            'End If

            'If DGV.Rows(i).Cells(6).Value = Nothing Then
            '    DGV.Rows(i).Cells(6).Value = TXT_GUID_JOB.Text
            '    DGV.Rows(i).Cells(7).Value = TXT_JOB.Text
            'End If
            'If DGV.Rows(i).Cells(8).Value = Nothing Then
            '    DGV.Rows(i).Cells(8).Value = TXT_GUID_CURRENCY.Text
            '    DGV.Rows(i).Cells(9).Value = TXT_CURRENCY.Text
            '    DGV.Rows(i).Cells(10).Value = Val(TXT_CURRENCY_VAL.Text).ToString("0.00")
            'End If

            'total_()

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
                            DGV.Rows(i).Cells(2).Value = Nothing
                        End If
                    End If
                End If
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
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

   
  
 
 

    

    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click
        Try
            Dim max___ As Double = 0
            Dim DT As New DataTable
            DT.Clear()
            DT = CLS_CASH_DAY_.MAX_(TXT_PARENTGUID.Text)
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

    Private Sub PictureBox4_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox4.Click
        Try
            Dim min___ As Double = 0
            Dim DT As New DataTable
            DT.Clear()
            DT = CLS_CASH_DAY_.MIN_(TXT_PARENTGUID.Text)
            If DT.Rows.Count > 0 Then
                min___ = DT.Rows(0)(0).ToString()
            End If

            TXT_ID.Text = TXT_ID.Text - 1
            If Val(TXT_ID.Text) < Val(min___) Then
                TXT_ID.Text = min___
                MessageBox.Show("هذا اصغر رقم", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub PictureBox3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox3.Click
        Try
            MIN_()
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub جديدToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles جديدToolStripMenuItem.Click

        Try
            new__()
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub حفظToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Nav_SAVE.Click
        Try
            If TXT_GUID.Text <> Nothing Then
                MessageBox.Show(" يجب ضغط جديد اولا ", "نقص", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                Exit Sub
            End If
            '------------------------------------------------------------------------
            If TXT_TOTAL.Text = "0" Then
                MessageBox.Show("لايوجد مبالغ", "نقص", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                Exit Sub
            End If
            '------------------------------------------------------------------------
            If TXT_GUID_CASH.Text = Nothing Then
                MessageBox.Show(" يجب اختيار حساب النقدية", "نقص", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                Exit Sub
            End If

            '------------------------------------------------------------------------
            MAX_1()
            add_day_cash()
            show_guid_cash()
            add_day1()
            show_guid_day()

            If TXT_CODE.Text = "0" Then
                add_debit()
            Else
                add_credit()
            End If
            show_day()
            MessageBox.Show("   تمت عملية حفظ السند بنجاح ", "تاكيد", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub تعديلToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NavUPDATE.Click
        Try
            If TXT_GUID.Text = Nothing Then
                MessageBox.Show("لايوجد سند ", "نقص", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                Exit Sub
            End If
            '------------------------------------------------------------------------

            If TXT_TOTAL.Text = "0" Then
                MessageBox.Show("لايوجد مبالغ", "نقص", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                Exit Sub
            End If
            '------------------------------------------------------------------------
            If TXT_GUID_CASH.Text = Nothing Then
                MessageBox.Show(" يجب اختيار حساب النقدية", "نقص", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                Exit Sub
            End If
            '------------------------------------------------------------------------

            update_cash_day()
            delete_day1()


            add_day1()
            show_guid_day()

            If TXT_CODE.Text = "0" Then
                add_debit()
            Else
                add_credit()
            End If
            show_day()
            MessageBox.Show("   تمت عملية التعديل   بنجاح ", "تاكيد", MessageBoxButtons.OK, MessageBoxIcon.Information)

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

    

    Private Sub ToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NavDELETE.Click
        Try

            If TXT_GUID.Text = Nothing Then
                MessageBox.Show("  لايوجد سند", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
            '---------------------------------------------------------------------
            If MessageBox.Show("هل انت متاكد من عملية الحذف", "تنبيه", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = Windows.Forms.DialogResult.Yes Then
                'حذف راس السند
                delete_daycash()


                '---------------------------------------------------------------------
                show_day()
                MessageBox.Show("   تمت عملية حذف السند بنجاح ", "تاكيد", MessageBoxButtons.OK, MessageBoxIcon.Information)
                TXT_GUID.Text = Nothing

            End If





        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub TXT_ID_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TXT_ID.TextChanged
        Try
            DGV.Rows.Clear()
            show_catsh()
            show_day()
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
            'If Val(TXT_ID.Text) > 10 Then
            '    Close()
            'End If
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

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            number_day___ = 0
            Dim f As New FRM_ALL_ACCOUNT
            f.ShowDialog()
            If f.IS_YES = True Then
                Dim i As Integer = f.DGV.CurrentRow.Index
                TXT_GUID_CASH.Text = f.DGV.Rows(i).Cells(0).Value.ToString()
                TXT_NAME_CASH.Text = f.DGV.Rows(i).Cells(1).Value.ToString()
            End If
            number_day___ = 0
        Catch ex As Exception

        End Try
    End Sub

    Private Sub TXT_PARENTGUID_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TXT_PARENTGUID.TextChanged

    End Sub

    Private Sub TXT_CURRENCY_VAL_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles TXT_CURRENCY_VAL.KeyPress
        If (e.KeyChar >= "a" And e.KeyChar <= "z") Or (e.KeyChar >= "A" And e.KeyChar <= "Z") Or (e.KeyChar >= "ا" And e.KeyChar <= "ي") Then
            e.Handled = True
        End If
    End Sub

    Private Sub TXT_CURRENCY_VAL_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TXT_CURRENCY_VAL.TextChanged

    End Sub

    Private Sub ToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NavPRENT.Click
        Try
            Dim dt_ As New DataTable
            dt_.Clear()
            dt_ = CLS_DAY_.number_day_bill(TXT_GUID.Text)
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
                    dt.Rows.Add(TXT_ID.Text, DTP.Value.ToShortDateString(), TXT_NOTE.Text, TXT_JOB.Text, TXT_CURRENCY.Text, TXT_CURRENCY_VAL.Text, TXT_TOTAL.Text, TXT_TOTAL.Text, DGV.Rows(I).Cells(1).Value, DGV.Rows(I).Cells(2).Value, DGV.Rows(I).Cells(3).Value, DGV.Rows(I).Cells(4).Value, DGV.Rows(I).Cells(5).Value, DGV.Rows(I).Cells(7).Value, DGV.Rows(I).Cells(9).Value, DGV.Rows(I).Cells(10).Value)
                End If

            Next

            Dim rptDoc As New CrystalDecisions.CrystalReports.Engine.ReportDocument
            Dim FF As New FRM_LOAD_REP

            If DGV.Columns(3).Visible = False Then
                FF.TXT_PATH.Text = "C:\conn\PRT\PRT_KBD"
            Else
                FF.TXT_PATH.Text = "C:\conn\PRT\PRT_SRF"
            End If
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
            MessageBox.Show(ex.ToString)
        End Try
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

    Private Sub TXT_CURRENCY_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles TXT_CURRENCY.KeyPress
        e.Handled = True
    End Sub

    Private Sub TXT_CURRENCY_TextChanged(sender As System.Object, e As System.EventArgs) Handles TXT_CURRENCY.TextChanged

    End Sub

    Private Sub TXT_JOB_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles TXT_JOB.KeyPress
        e.Handled = True
    End Sub

    Private Sub TXT_JOB_TextChanged(sender As System.Object, e As System.EventArgs) Handles TXT_JOB.TextChanged

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