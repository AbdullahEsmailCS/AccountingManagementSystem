Imports System.IO
Public Class FRM_ITEME
    Dim CLS_ITEME_ As New CLS_ITEME
    Dim CLS_CURRENCY_ As New CLS_CURRENCY
    Private Sub GroupPanel1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupPanel1.Click

    End Sub

    Private Sub ButtonX4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX4.Click
        Try
            Dim F As New FRM_ALL_GROUP
            F.ShowDialog()
            If F.IS_YES = True Then
                Dim I As Integer = F.DGV.CurrentRow.Index
                TXT_NAME_GROUP.Text = F.DGV.Rows(I).Cells(1).Value.ToString()
                TXT_GROUP_GUID.Text = F.DGV.Rows(I).Cells(2).Value.ToString()
            Else
                TXT_NAME_GROUP.Text = Nothing
                TXT_GROUP_GUID.Text = Nothing
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub حفظToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles حفظToolStripMenuItem.Click
        Try
           



            If TXT_GROUP_GUID.Text = Nothing Then
                MessageBox.Show("يجب ادخال  تصنيف المادة", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
            '---------------------------------------------------------
            If TXT_NAME_ITEME.Text = Nothing Then
                MessageBox.Show("يجب ادخال  اسم المادة", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
            '---------------------------------------------------------

            Dim DT As New DataTable
            DT.Clear()
            DT = CLS_ITEME_.NAME(TXT_NAME_ITEME.Text)
            If DT.Rows.Count > 0 Then
                MessageBox.Show("اسم المادة مكرر", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If

            '---------------------------------------------------------
            'If TXT_BARCODE_1.Text <> Nothing Then
            '    Dim DT1 As New DataTable
            '    DT1.Clear()
            '    DT1 = CLS_ITEME_.BARCODE(TXT_BARCODE_1.Text)
            '    If DT1.Rows.Count > 0 Then
            '        MessageBox.Show("باركود المادة مكرر", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error)
            '        Exit Sub
            '    End If
            'End If

            '---------------------------------------------------------

            Dim msn As New MemoryStream
            pic.Image.Save(msn, pic.Image.RawFormat)
            Dim bytimage As Byte() = msn.ToArray()

            CLS_ITEME_.ADD_(TXT_NAME_ITEME.Text,
                            TXT_NOTE.Text,
                            TXT_GROUP_GUID.Text,
                            0,
                            0,
                            bytimage,
                            Comb_unit1.Text,
                            Comb_unit2.Text,
                            Comb_unit3.Text,
                            Val(TXT_UNIT_1.Text),
                            Val(TXT_UNIT_2.Text),
                            Val(TXT_UNIT_3.Text),
                            TXT_BARCODE_1.Text,
                            TXT_BARCODE_2.Text,
                            TXT_BARCODE_3.Text,
                            TXT_LATENE.Text,
                           CMB_Company.Text,
                           CMB_Provenance.Text,
                           CMB_Quality.Text,
                           CMB_Color.Text,
                           CMB_Model.Text,
                           CMB_Dim.Text,
                           CMB_Pos.Text,
                           CMB_Origin.Text,
                           Convert.ToDateTime(Now.ToShortDateString()),
                           guid_user_log,
                              TXT_GUID_CURRENCY.Text,
                             Val(TXT_Whole.Text),
                             Val(TXT_Half.Text),
                             Val(TXT_EndUser.Text),
                             Val(TXT_Vendor.Text),
                             Val(TXT_Export.Text),
                             Val(TXT_Retail.Text),
                             Val(TXT_LastPrice.Text),
                             Val(TXT_OrderLimit.Text),
                             Val(TXT_MAX_QTY.Text),
                             Val(TXT_MIN_QTY.Text),
                             0)
            MessageBox.Show("   تمت عملية الحفظ بنجاح ", "تاكيد", MessageBoxButtons.OK, MessageBoxIcon.Information)
            SHOW_CMB()

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub
    
    Private Sub بحثToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles بحثToolStripMenuItem.Click
        Try
            Dim F As New FRM_ALL_ITEME
            F.ShowDialog()
            If F.isyes = True Then
                Dim i As Integer = F.DGV.CurrentRow.Index
                TXT_ITEME_GUID.Text = F.DGV.Rows(i).Cells(0).Value.ToString()
             
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub تعديلToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles تعديلToolStripMenuItem.Click
        Try


            If TXT_ITEME_GUID.Text = Nothing Then
                MessageBox.Show("لايمكن التعديل", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
            '---------------------------------------------------------
            If TXT_GROUP_GUID.Text = Nothing Then
                MessageBox.Show("يجب ادخال  تصنيف المادة", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
            '---------------------------------------------------------
            If TXT_NAME_ITEME.Text = Nothing Then
                MessageBox.Show("يجب ادخال  اسم المادة", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
            '---------------------------------------------------------

            'Dim DT As New DataTable
            'DT.Clear()
            'DT = CLS_ITEME_.NAME(TXT_NAME_ITEME.Text)
            'If DT.Rows.Count > 0 Then
            '    MessageBox.Show("اسم المادة مكرر", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error)
            '    Exit Sub
            'End If

            '---------------------------------------------------------
            'If TXT_BARCODE.Text <> Nothing Then
            '    Dim DT1 As New DataTable
            '    DT1.Clear()
            '    DT1 = CLS_ITEME_.BARCODE(TXT_BARCODE.Text)
            '    If DT1.Rows.Count > 0 Then
            '        MessageBox.Show("باركود المادة مكرر", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error)
            '        Exit Sub
            '    End If
            'End If

            '---------------------------------------------------------

            Dim msn As New MemoryStream
            pic.Image.Save(msn, pic.Image.RawFormat)
            Dim bytimage As Byte() = msn.ToArray()
            CLS_ITEME_.update__(TXT_NAME_ITEME.Text,
                            TXT_NOTE.Text,
                            TXT_GROUP_GUID.Text,
                            0,
                            0,
                            bytimage,
                            Comb_unit1.Text,
                            Comb_unit2.Text,
                            Comb_unit3.Text,
                            Val(TXT_UNIT_1.Text),
                            Val(TXT_UNIT_2.Text),
                            Val(TXT_UNIT_3.Text),
                            TXT_BARCODE_1.Text,
                            TXT_BARCODE_2.Text,
                            TXT_BARCODE_3.Text,
                            TXT_LATENE.Text,
                           CMB_Company.Text,
                           CMB_Provenance.Text,
                           CMB_Quality.Text,
                           CMB_Color.Text,
                           CMB_Model.Text,
                           CMB_Dim.Text,
                           CMB_Pos.Text,
                           CMB_Origin.Text,
                           TXT_ITEME_GUID.Text,
                             guid_user_log,
                             TXT_GUID_CURRENCY.Text,
                             Val(TXT_Whole.Text),
                             Val(TXT_Half.Text),
                             Val(TXT_EndUser.Text),
                             Val(TXT_Vendor.Text),
                             Val(TXT_Export.Text),
                             Val(TXT_Retail.Text),
                             Val(TXT_LastPrice.Text),
                             Val(TXT_OrderLimit.Text),
                             Val(TXT_MAX_QTY.Text),
                             Val(TXT_MIN_QTY.Text),
                             0)


            MessageBox.Show("   تمت عملية التعديل بنجاح ", "تاكيد", MessageBoxButtons.OK, MessageBoxIcon.Information)


        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

   

    

    

    Private Sub pic_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pic.Click
        Dim ofd As New OpenFileDialog
        ofd.Filter = "اختر صورة|*.jpg;*.png;*.gig;"
        If ofd.ShowDialog = Windows.Forms.DialogResult.OK Then
            pic.Image = Image.FromFile(ofd.FileName)
        End If
    End Sub

    Private Sub TXT_ITEME_GUID_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TXT_ITEME_GUID.TextChanged
        Try
            If TXT_ITEME_GUID.Text <> Nothing Then
                Dim dt As New DataTable
                dt.Clear()
                dt = CLS_ITEME_.searsh_guid(TXT_ITEME_GUID.Text)
                If dt.Rows.Count > 0 Then
                    TXT_GROUP_GUID.Text = dt.Rows(0)(0).ToString()
                    TXT_NAME_GROUP.Text = dt.Rows(0)(1).ToString()
                    TXT_NAME_ITEME.Text = dt.Rows(0)(2).ToString()
                    TXT_NOTE.Text = dt.Rows(0)(3).ToString()
                    TXT_BALANCE.Text = dt.Rows(0)(4).ToString()
                    TXT_AVERAGE.Text = Val(dt.Rows(0)(5).ToString()).ToString("0.000")
                    Dim imgByteArray() As Byte
                    imgByteArray = dt.Rows(0)(6)

                    Dim Stream As New MemoryStream(imgByteArray, True)
                    Dim Img As System.Drawing.Image = New Bitmap(Stream)
                    pic.Image = Img


                    Comb_unit1.Text = dt.Rows(0)(7).ToString()
                    TXT_UNIT_1.Text = dt.Rows(0)(8).ToString()
                    TXT_BARCODE_1.Text = dt.Rows(0)(9).ToString()

                    Comb_unit2.Text = dt.Rows(0)(10).ToString()
                    TXT_UNIT_2.Text = dt.Rows(0)(11).ToString()
                    TXT_BARCODE_2.Text = dt.Rows(0)(12).ToString()


                    Comb_unit3.Text = dt.Rows(0)(13).ToString()
                    TXT_UNIT_3.Text = dt.Rows(0)(14).ToString()
                    TXT_BARCODE_3.Text = dt.Rows(0)(15).ToString()



                    CMB_Company.Text = dt.Rows(0)(16).ToString()
                    CMB_Provenance.Text = dt.Rows(0)(17).ToString()
                    CMB_Quality.Text = dt.Rows(0)(18).ToString()
                    CMB_Color.Text = dt.Rows(0)(19).ToString()


                    CMB_Model.Text = dt.Rows(0)(20).ToString()
                    CMB_Dim.Text = dt.Rows(0)(21).ToString()
                    CMB_Pos.Text = dt.Rows(0)(22).ToString()
                    CMB_Origin.Text = dt.Rows(0)(23).ToString()

                    TXT_LATENE.Text = dt.Rows(0)(24).ToString()

                    TXT_GUID_CURRENCY.Text = dt.Rows(0)(25).ToString()
                    TXT_CURRENCY.Text = dt.Rows(0)(26).ToString()


                    TXT_Whole.Text = dt.Rows(0)(27).ToString()
                    TXT_Half.Text = dt.Rows(0)(28).ToString()
                    TXT_EndUser.Text = dt.Rows(0)(29).ToString()
                    TXT_Vendor.Text = dt.Rows(0)(30).ToString()


                    TXT_Export.Text = dt.Rows(0)(31).ToString()
                    TXT_Retail.Text = dt.Rows(0)(32).ToString()
                    TXT_LastPrice.Text = dt.Rows(0)(33).ToString()


                    TXT_OrderLimit.Text = dt.Rows(0)(34).ToString()
                    TXT_MAX_QTY.Text = dt.Rows(0)(35).ToString()
                    TXT_MIN_QTY.Text = dt.Rows(0)(36).ToString()





                Else
                    cleare_()

                End If
            End If
        Catch ex As Exception

        End Try
    End Sub
    Sub cleare_()
        
        TXT_NAME_ITEME.Text = Nothing
        TXT_AVERAGE.Text = 0
        TXT_BALANCE.Text = 0
        'TXT_ITEME_GUID.Text = Nothing
        TXT_NAME_ITEME.Text = Nothing
        TXT_NOTE.Text = Nothing
        pic.Image = PictureBox1.Image


        Comb_unit1.Text = "وحدة1"

        TXT_BARCODE_1.Text = Nothing

        Comb_unit2.Text = Nothing
        TXT_UNIT_2.Text = Nothing
        TXT_BARCODE_2.Text = Nothing


        Comb_unit3.Text = Nothing
        TXT_UNIT_3.Text = Nothing
        TXT_BARCODE_3.Text = Nothing

        CMB_Company.Text = Nothing
        CMB_Provenance.Text = Nothing
        CMB_Quality.Text = Nothing
        CMB_Color.Text = Nothing


        CMB_Model.Text = Nothing
        CMB_Dim.Text = Nothing
        CMB_Pos.Text = Nothing
        CMB_Origin.Text = Nothing
        TXT_LATENE.Text = Nothing



        TXT_Whole.Text = 0
        TXT_Half.Text = 0
        TXT_EndUser.Text = 0
        TXT_Vendor.Text = 0


        TXT_Export.Text = 0
        TXT_Retail.Text = 0
        TXT_LastPrice.Text = 0
        TXT_MAX_QTY.Text = 0

        TXT_MIN_QTY.Text = 0
        TXT_OrderLimit.Text = 0

    End Sub
    Private Sub جديدToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles جديدToolStripMenuItem.Click
        Try
         
            'TXT_GROUP_GUID.Text = Nothing
            'TXT_NAME_GROUP.Text = Nothing
            TXT_NAME_ITEME.Text = Nothing
            TXT_NOTE.Text = Nothing
            TXT_LATENE.Text = Nothing
            TXT_BALANCE.Text = 0
            TXT_AVERAGE.Text = 0
            pic.Image = PictureBox1.Image

            Comb_unit1.Text = "وحدة1"

            TXT_BARCODE_1.Text = Nothing

            Comb_unit2.Text = Nothing
            TXT_UNIT_2.Text = Nothing
            TXT_BARCODE_2.Text = Nothing


            Comb_unit3.Text = Nothing
            TXT_UNIT_3.Text = Nothing
            TXT_BARCODE_3.Text = Nothing
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Comb_unit1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Comb_unit1.SelectedIndexChanged

    End Sub

    Private Sub Comb_unit1_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Comb_unit1.Validated
        If Comb_unit1.Text = Nothing Then
            Comb_unit1.Text = "وحدة1"
        End If
    End Sub

    Private Sub TXT_NAME_GROUP_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TXT_NAME_GROUP.KeyPress
        e.Handled = True
    End Sub

    Sub SHOW_CMB()
        CMB_Dim.DataSource = CLS_ITEME_.CMB_Dim_DT()
        CMB_Dim.DisplayMember = "Dim"
        '----------------------------------------------------------------------
        CMB_Origin.DataSource = CLS_ITEME_.CMB_Origin_DT()
        CMB_Origin.DisplayMember = "Origin"
        '----------------------------------------------------------------------
        CMB_Pos.DataSource = CLS_ITEME_.CMB_Pos_DT()
        CMB_Pos.DisplayMember = "Pos"
        '----------------------------------------------------------------------
        CMB_Company.DataSource = CLS_ITEME_.CMB_Company_DT()
        CMB_Company.DisplayMember = "Company"
        '----------------------------------------------------------------------
        CMB_Color.DataSource = CLS_ITEME_.CMB_Color_DT()
        CMB_Color.DisplayMember = "Color"
        '----------------------------------------------------------------------
        CMB_Provenance.DataSource = CLS_ITEME_.CMB_Provenance_DT()
        CMB_Provenance.DisplayMember = "Provenance"
        '----------------------------------------------------------------------
        CMB_Quality.DataSource = CLS_ITEME_.CMB_Quality_DT()
        CMB_Quality.DisplayMember = "Quality"
        '----------------------------------------------------------------------
        CMB_Model.DataSource = CLS_ITEME_.CMB_Model_DT()
        CMB_Model.DisplayMember = "Model"
        '----------------------------------------------------------------------
     

    End Sub

    Private Sub FRM_ITEME_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Try
            SHOW_CURRENCY()
        Catch ex As Exception

        End Try
    End Sub
    Sub SHOW_CURRENCY()
        Dim DT As New DataTable
        DT.Clear()
        DT = CLS_CURRENCY_.SELECT_
        If DT.Rows.Count > 0 Then
            TXT_GUID_CURRENCY.Text = DT.Rows(0)(0).ToString()
            TXT_CURRENCY.Text = DT.Rows(0)(1).ToString()


        End If
    End Sub
    Private Sub TXT_GROUP_GUID_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TXT_GROUP_GUID.TextChanged

    End Sub

    Private Sub TXT_Whole_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles TXT_Whole.KeyPress
        If (e.KeyChar >= "a" And e.KeyChar <= "z") Or (e.KeyChar >= "A" And e.KeyChar <= "Z") Or (e.KeyChar >= "ا" And e.KeyChar <= "ي") Then
            e.Handled = True
        End If
    End Sub

    Private Sub TXT_Whole_TextChanged(sender As System.Object, e As System.EventArgs) Handles TXT_Whole.TextChanged

    End Sub

    Private Sub TXT_Half_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles TXT_Half.KeyPress
        If (e.KeyChar >= "a" And e.KeyChar <= "z") Or (e.KeyChar >= "A" And e.KeyChar <= "Z") Or (e.KeyChar >= "ا" And e.KeyChar <= "ي") Then
            e.Handled = True
        End If
    End Sub

    Private Sub TXT_Half_TextChanged(sender As System.Object, e As System.EventArgs) Handles TXT_Half.TextChanged

    End Sub

    Private Sub TXT_EndUser_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles TXT_EndUser.KeyPress
        If (e.KeyChar >= "a" And e.KeyChar <= "z") Or (e.KeyChar >= "A" And e.KeyChar <= "Z") Or (e.KeyChar >= "ا" And e.KeyChar <= "ي") Then
            e.Handled = True
        End If
    End Sub

    Private Sub TXT_EndUser_TextChanged(sender As System.Object, e As System.EventArgs) Handles TXT_EndUser.TextChanged

    End Sub

    Private Sub TXT_Vendor_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles TXT_Vendor.KeyPress
        If (e.KeyChar >= "a" And e.KeyChar <= "z") Or (e.KeyChar >= "A" And e.KeyChar <= "Z") Or (e.KeyChar >= "ا" And e.KeyChar <= "ي") Then
            e.Handled = True
        End If
    End Sub

    Private Sub TXT_Vendor_TextChanged(sender As System.Object, e As System.EventArgs) Handles TXT_Vendor.TextChanged

    End Sub

    Private Sub TXT_Export_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles TXT_Export.KeyPress
        If (e.KeyChar >= "a" And e.KeyChar <= "z") Or (e.KeyChar >= "A" And e.KeyChar <= "Z") Or (e.KeyChar >= "ا" And e.KeyChar <= "ي") Then
            e.Handled = True
        End If
    End Sub

    Private Sub TXT_Export_TextChanged(sender As System.Object, e As System.EventArgs) Handles TXT_Export.TextChanged

    End Sub

    Private Sub TXT_Retail_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles TXT_Retail.KeyPress
        If (e.KeyChar >= "a" And e.KeyChar <= "z") Or (e.KeyChar >= "A" And e.KeyChar <= "Z") Or (e.KeyChar >= "ا" And e.KeyChar <= "ي") Then
            e.Handled = True
        End If
    End Sub

    Private Sub TXT_Retail_TextChanged(sender As System.Object, e As System.EventArgs) Handles TXT_Retail.TextChanged

    End Sub

    Private Sub TextBoxX7_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles TXT_LastPrice.KeyPress
        If (e.KeyChar >= "a" And e.KeyChar <= "z") Or (e.KeyChar >= "A" And e.KeyChar <= "Z") Or (e.KeyChar >= "ا" And e.KeyChar <= "ي") Then
            e.Handled = True
        End If
    End Sub

    Private Sub TextBoxX7_TextChanged(sender As System.Object, e As System.EventArgs) Handles TXT_LastPrice.TextChanged

    End Sub

    Private Sub TextBoxX8_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles TXT_OrderLimit.KeyPress
        If (e.KeyChar >= "a" And e.KeyChar <= "z") Or (e.KeyChar >= "A" And e.KeyChar <= "Z") Or (e.KeyChar >= "ا" And e.KeyChar <= "ي") Then
            e.Handled = True
        End If
    End Sub

    Private Sub TextBoxX8_TextChanged(sender As System.Object, e As System.EventArgs) Handles TXT_OrderLimit.TextChanged

    End Sub

    Private Sub TXT_MAX_QTY_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles TXT_MAX_QTY.KeyPress
        If (e.KeyChar >= "a" And e.KeyChar <= "z") Or (e.KeyChar >= "A" And e.KeyChar <= "Z") Or (e.KeyChar >= "ا" And e.KeyChar <= "ي") Then
            e.Handled = True
        End If
    End Sub

    Private Sub TXT_MAX_QTY_TextChanged(sender As System.Object, e As System.EventArgs) Handles TXT_MAX_QTY.TextChanged

    End Sub

    Private Sub TXT_MIN_QTY_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles TXT_MIN_QTY.KeyPress
        If (e.KeyChar >= "a" And e.KeyChar <= "z") Or (e.KeyChar >= "A" And e.KeyChar <= "Z") Or (e.KeyChar >= "ا" And e.KeyChar <= "ي") Then
            e.Handled = True
        End If
    End Sub

    Private Sub TXT_MIN_QTY_TextChanged(sender As System.Object, e As System.EventArgs) Handles TXT_MIN_QTY.TextChanged

    End Sub

    Private Sub TXT_CURRENCY_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles TXT_CURRENCY.KeyPress
        e.Handled = True
    End Sub

    Private Sub TXT_CURRENCY_TextChanged(sender As System.Object, e As System.EventArgs) Handles TXT_CURRENCY.TextChanged

    End Sub

    Private Sub Button4_Click(sender As System.Object, e As System.EventArgs) Handles Button4.Click
        Try
            Dim F As New FRM_ALL_CURRENCY
            F.ShowDialog()
            If F.IS_YES = True Then
                Dim I As Integer = F.DGV.CurrentRow.Index
                TXT_GUID_CURRENCY.Text = F.DGV.Rows(I).Cells(0).Value.ToString()
                TXT_CURRENCY.Text = F.DGV.Rows(I).Cells(2).Value.ToString()
 
            End If

        Catch ex As Exception

        End Try
    End Sub
End Class