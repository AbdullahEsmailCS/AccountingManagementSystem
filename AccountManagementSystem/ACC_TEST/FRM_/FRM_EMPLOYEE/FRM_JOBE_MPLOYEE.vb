Public Class FRM_JOBE_MPLOYEE

    Dim CLS_JOBE_MPLOYEE_ As New CLS_JOBE_MPLOYEE

    Private Sub F_CATEGORY_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            SHOW_CATEGORY()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Sub SHOW_CATEGORY()
        Dim DT As New DataTable
        DT.Clear()
        DT = CLS_JOBE_MPLOYEE_.SHOW_CATEGORY()
        DGV.DataSource = DT
    End Sub

    Sub ADD_CATEGORY()
        CLS_JOBE_MPLOYEE_.ADD_CATEGORY(TXT_NAME.Text)
    End Sub

    Sub UPDATE_CATEGORY()
        CLS_JOBE_MPLOYEE_.UPDATE_CATEGORY(TXT_NAME.Text, TXT_ID.Text)
    End Sub

    Sub CLEARE()
        TXT_ID.Text = ""
        TXT_NAME.Text = ""
    End Sub


    Private Sub Tool_NEW_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_NEW.Click
        Try
            CLEARE()
            SHOW_CATEGORY()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub DataGridView1_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGV.CellClick
        Try
            Dim I As Integer = DGV.CurrentRow.Index
            TXT_ID.Text = DGV.Rows(I).Cells(0).Value.ToString()
            TXT_NAME.Text = DGV.Rows(I).Cells(1).Value.ToString()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGV.CellContentClick

    End Sub

    Private Sub Tool_SAVE_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_SAVE.Click
        Try
            If TXT_NAME.Text = "" Then
                MessageBox.Show("الاسم فارغ", "تاكيد", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End If
            If TXT_ID.Text = "" Then
                ADD_CATEGORY()
                MessageBox.Show("تمت عملية الحفظ بنجاح", "تاكيد", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                UPDATE_CATEGORY()
                MessageBox.Show("تمت عملية التعديل بنجاح", "تاكيد", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
            SHOW_CATEGORY()
            CLEARE()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
End Class