Public Class FRM_ACCOUNT
    Dim CLS_ACCOUNT_ As New CLS_ACCOUNT
    Dim CLS_END_ As New ClS_END
    Dim DT_node As New DataTable

    Dim CLS_DAY_ As New CLS_DAY
    Dim CLS_BILL_ As New CLS_BILL
    Dim CLS_CASH_DAY_ As New CLS_CASH_DAY


    Dim CLS_CU_VEN_ As New CLS_CU_VEN
    Dim CLS_EMPLOYEE_ As New CLS_EMPLOYEE

    Private Sub FRM_ACCOUNT_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            TreeView1.ImageList = ImageList1
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub
   
    Sub CREATENODE()
        Dim TRN As New TreeNode
        Dim DT As New DataTable
        DT.Clear()
        DT = CLS_ACCOUNT_.SHOW_
        For I As Integer = 0 To DT.Rows.Count - 1
            If DT.Rows(I)(2).ToString() = "00000000-0000-0000-0000-000000000000" Then
                TRN = New TreeNode(DT.Rows(I)(1).ToString() + " " + DT.Rows(I)(3).ToString())

                TRN.Tag = DT.Rows(I)(0).ToString()

                If DT.Rows(I)(5).ToString() <> "0" Then

                    TRN.ImageIndex = 0
                    TRN.SelectedImageIndex = 0
                Else

                    TRN.ImageIndex = 1
                    TRN.SelectedImageIndex = 1
                End If



                TreeView1.Nodes.Add(TRN)
            End If
        Next
        For Each NODE As TreeNode In TreeView1.Nodes
            CHELD(NODE)
        Next
    End Sub
    Sub CHELD(ByVal NODE As TreeNode)
        Dim TRN As New TreeNode
        Dim DT As New DataTable
        DT.Clear()
        DT = CLS_ACCOUNT_.SHOW_
        For I As Integer = 0 To DT.Rows.Count - 1
            Dim GUID_ As String = NODE.Tag
            If DT.Rows(I)(2).ToString() = GUID_ Then
                TRN = New TreeNode(DT.Rows(I)(1).ToString() + " " + DT.Rows(I)(3).ToString())
                TRN.Tag = DT.Rows(I)(0).ToString()


                If DT.Rows(I)(5).ToString() <> "0" Then
                    TRN.ImageIndex = 0
                    TRN.SelectedImageIndex = 0
                Else
                    TRN.ImageIndex = 1
                    TRN.SelectedImageIndex = 1
                End If


                NODE.Nodes.Add(TRN)
                CHELD(TRN)
            End If
        Next
    End Sub
   
    Private Sub ButtonX1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub CMB_END_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        e.Handled = True
    End Sub

    Private Sub CMB_END_MarginChanged(ByVal sender As Object, ByVal e As System.EventArgs)

    End Sub

    

    Private Sub CMB_END_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

  

   

    Private Sub TreeView1_AfterSelect(ByVal sender As System.Object, ByVal e As System.Windows.Forms.TreeViewEventArgs) Handles TreeView1.AfterSelect
        Try
            Dim F As New FRM_NEW_ACCOUNT
            Dim GUID____ As String = TreeView1.SelectedNode.Tag
           

            DT_node.Clear()
            DT_node = CLS_ACCOUNT_.GUID_TREEE(GUID____)
            If DT_node.Rows.Count > 0 Then
                DGV.DataSource = DT_node
                DGV.Columns(0).Visible = False
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub ButtonX3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub TXT_GUID_PARENT_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub



    Private Sub ButtonX5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub حفظToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles حفظToolStripMenuItem.Click



        'Try
        '    If TXT_NAME.Text = Nothing Then
        '        MessageBox.Show("يجب ادخال اسم الحساب", "نقص", MessageBoxButtons.OK, MessageBoxIcon.Error)
        '        Exit Sub
        '    End If
        '    '------------------------------------------------------------
        '    If TXT_GUID_PARENT.Text = Nothing Then
        '        MessageBox.Show("يجب ادخال الحساب الرئيسي", "نقص", MessageBoxButtons.OK, MessageBoxIcon.Error)
        '        Exit Sub
        '    End If
        '    '------------------------------------------------------------

        '    Dim dt_ As New DataTable
        '    dt_.Clear()
        '    dt_ = CLS_ACCOUNT_.searsh_account_day2(TXT_GUID_PARENT.Text)
        '    If dt_.Rows.Count > 0 Then
        '        MessageBox.Show("الحساب الرئيسي مدخل من قبل في السندات او الفواتير لايمكن اضافته حساب رئيسي", "نقص", MessageBoxButtons.OK, MessageBoxIcon.Error)
        '        Exit Sub
        '    End If
        '    '------------------------------------------------------------
        '    Dim DT As New DataTable
        '    DT.Clear()
        '    DT = CLS_ACCOUNT_.SEARSH_NAME(TXT_NAME.Text)
        '    If DT.Rows.Count > 0 Then
        '        MessageBox.Show("الاسم موجود من قبل", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error)
        '        Exit Sub
        '    End If
        '    '------------------------------------------------------------
        '    Dim COD__ As Double

        '    Dim DT_COD As New DataTable
        '    DT_COD.Clear()
        '    DT_COD = CLS_ACCOUNT_.COD_(TXT_GUID_PARENT.Text)
        '    If DT_COD.Rows.Count > 0 Then

        '        COD__ = Val(DT_COD.Rows(0)(0).ToString())
        '    End If
        '    If COD__ = "0" Then
        '        COD__ = Val(TXT_CODE_PARENT_GUID.Text) * 10000 + 1
        '    End If
        '    '------------------------------------------------------------------
        '    CLS_ACCOUNT_.ADD_(TXT_NAME.Text, TXT_GUID_PARENT.Text, Val(COD__), Convert.ToInt32(CMB_END.SelectedValue), 0, 0, 0)
        '    update_sons()
        '    MessageBox.Show("تمت عملية الحفظ بنجاح", "تاكيد", MessageBoxButtons.OK, MessageBoxIcon.Information)
        'Catch ex As Exception
        '    MessageBox.Show(ex.ToString)
        'End Try
    End Sub


    Private Sub تعديلToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles تعديلToolStripMenuItem.Click
        Try
            'If TXT_NAME.Text = Nothing Then
            '    MessageBox.Show("يجب ادخال اسم الحساب", "نقص", MessageBoxButtons.OK, MessageBoxIcon.Error)
            '    Exit Sub
            'End If
            ''------------------------------------------------------------
            'If TXT_GUID_PARENT.Text = Nothing Then
            '    MessageBox.Show("يجب ادخال الحساب الرئيسي", "نقص", MessageBoxButtons.OK, MessageBoxIcon.Error)
            '    Exit Sub
            'End If

            ''------------------------------------------------------------
            'Dim dt_ As New DataTable
            'dt_.Clear()
            'dt_ = CLS_ACCOUNT_.searsh_account_day2(TXT_GUID_PARENT.Text)
            'If dt_.Rows.Count > 0 Then
            '    MessageBox.Show("الحساب الرئيسي مدخل من قبل في السندات او الفواتير لايمكن اضافته حساب رئيسي", "نقص", MessageBoxButtons.OK, MessageBoxIcon.Error)
            '    Exit Sub
            'End If
            ''------------------------------------------------------------
            'CLS_ACCOUNT_.UPDATE_(TXT_NAME.Text, TXT_GUID_PARENT.Text, Convert.ToInt32(CMB_END.SelectedValue), TXT_GUID.Text)
            'update_sons()
            'MessageBox.Show("تمت عملية التعديل  بنجاح", "تاكيد", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Dim F As New FRM_NEW_ACCOUNT
            F.TXT_GUID.Text = TreeView1.SelectedNode.Tag
            F.ShowDialog()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub ToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem1.Click
        Try
            DT_node.Clear()
            'DGV.RowCount = 0
            TreeView1.Nodes.Clear()
            CREATENODE()
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub TXT_CODE_PARENT_GUID_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub جديدToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles جديدToolStripMenuItem.Click
        Try




            DT_node.Clear()
            Dim F As New FRM_NEW_ACCOUNT
            F.cmb_()
            Dim DT As New DataTable
            DT.Clear()
            DT = CLS_ACCOUNT_.SHOW_GUID(TreeView1.SelectedNode.Tag)
            If DT.Rows.Count > 0 Then
                'TXT_NAME.Text = DT.Rows(0)(0).ToString()
                F.TXT_PARENT.Text = TreeView1.SelectedNode.Text
                F.TXT_GUID_PARENT.Text = TreeView1.SelectedNode.Tag
                F.CMB_END.SelectedValue = Convert.ToString(DT.Rows(0)(3).ToString())




                'F.TXT_GUID.Text = TreeView1.SelectedNode.Tag
                F.TXT_NAME.Text = Nothing
                F.ShowDialog()
            End If
        Catch ex As Exception

        End Try


    End Sub

    Private Sub TreeView1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles TreeView1.DoubleClick
        Try
            Dim F As New FRM_NEW_ACCOUNT
            F.cmb_()
            F.TXT_GUID.Text = TreeView1.SelectedNode.Tag
            F.ShowDialog()

        Catch ex As Exception

        End Try
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGV.CellClick



    End Sub

    Private Sub DataGridView1_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGV.CellContentClick

    End Sub

    Private Sub DataGridView1_CellDoubleClick(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGV.CellDoubleClick
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
        Try
            Dim F As New FRM_NEW_ACCOUNT
            F.cmb_()
            Dim DT As New DataTable
            DT.Clear()
            DT = CLS_ACCOUNT_.SHOW_GUID(TreeView1.SelectedNode.Tag)
            If DT.Rows.Count > 0 Then
                'TXT_NAME.Text = DT.Rows(0)(0).ToString()
                F.TXT_PARENT.Text = TreeView1.SelectedNode.Text
                F.TXT_GUID_PARENT.Text = TreeView1.SelectedNode.Tag
                F.CMB_END.SelectedValue = Convert.ToString(DT.Rows(0)(3).ToString())




                'F.TXT_GUID.Text = TreeView1.SelectedNode.Tag
                F.TXT_NAME.Text = Nothing
                F.ShowDialog()
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub ربطببطاقةزبونToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ربطببطاقةزبونToolStripMenuItem.Click

        Try
            Dim F As New FRM_TRF2

            Dim DT As New DataTable
            DT.Clear()
            DT = CLS_ACCOUNT_.SHOW_GUID(TreeView1.SelectedNode.Tag)
            If DT.Rows.Count > 0 Then
                name___name = DT.Rows(0)(0).ToString()
            End If


            number_day___ = 2


            F.ShowDialog()
            number_day___ = 3
        Catch ex As Exception

        End Try

    End Sub

    Private Sub ربطببطاقةموظفToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ربطببطاقةموظفToolStripMenuItem.Click
        Try
            Dim F As New FRM_EMPLOYEE

            Dim DT As New DataTable
            DT.Clear()
            DT = CLS_ACCOUNT_.SHOW_GUID(TreeView1.SelectedNode.Tag)
            If DT.Rows.Count > 0 Then
                name___name = DT.Rows(0)(0).ToString()
            End If


            number_day___ = 2


            F.ShowDialog()
            number_day___ = 3
        Catch ex As Exception

        End Try
    End Sub

    Private Sub حذفحسابToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles حذفحسابToolStripMenuItem.Click
        Try
            Dim dt As New DataTable
            dt.Clear()
            dt = CLS_DAY_.delete_account(TreeView1.SelectedNode.Tag)
            If dt.Rows.Count > 0 Then
                MessageBox.Show("الحساب موجود بسند القيد", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                Exit Sub
            End If
            '-----------------------------------------------------------------------
            Dim dt_cash As New DataTable
            dt_cash.Clear()
            dt_cash = CLS_CASH_DAY_.delete_account(TreeView1.SelectedNode.Tag)
            If dt_cash.Rows.Count > 0 Then
                MessageBox.Show("الحساب موجود بسندات القبض والصرف ", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                Exit Sub
            End If


            '-----------------------------------------------------------------------
            Dim dt_acc As New DataTable
            dt_acc.Clear()
            dt_acc = CLS_ACCOUNT_.delete_account(TreeView1.SelectedNode.Tag)
            If dt_acc.Rows.Count > 0 Then
                MessageBox.Show("لايمكن حذف الحساب الرئيسي", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                Exit Sub
            End If
            '-----------------------------------------------------------------------
            Dim dt_bill As New DataTable
            dt_bill.Clear()
            dt_bill = CLS_BILL_.delete_account(TreeView1.SelectedNode.Tag)
            If dt_bill.Rows.Count > 0 Then
                MessageBox.Show("لايمكن حذف الحساب لانه موجود بالفواتير غير مرحلة", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                Exit Sub
            End If
            '-----------------------------------------------------------------------
            Dim dt_em As New DataTable
            dt_em.Clear()
            dt_em = CLS_EMPLOYEE_.delete_account(TreeView1.SelectedNode.Tag)
            If dt_em.Rows.Count > 0 Then
                MessageBox.Show("هذا حساب مربوط ببطاقة موظف يجب حذفه من البطاقة ", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                Exit Sub
            End If

            '---------------------------------------------------------------------
            If MessageBox.Show("هل انت متاكد من عملية الحذف", "تنبيه", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = Windows.Forms.DialogResult.Yes Then


                CLS_ACCOUNT_.delete_(TreeView1.SelectedNode.Tag)

                MessageBox.Show("   تمت عملية الحذف   بنجاح ", "تاكيد", MessageBoxButtons.OK, MessageBoxIcon.Information)


            End If



        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub
End Class