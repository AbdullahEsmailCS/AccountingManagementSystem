Imports System.Data.SqlClient
Imports System.IO
Public Class FRM_LOGIN
    Dim CLS_USER_ As New CLS_USER
    Public isok As Boolean = False
    Private Sub Tool_SAVE_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub FRM_LOGIN_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
       
    End Sub

    Private Sub Tool_DELETE_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_DELETE.Click
        Application.Exit()
    End Sub
    

    Private Sub ButtonX1_Click(sender As System.Object, e As System.EventArgs) Handles ButtonX1.Click

        Try
            Dim sm As New CLS_PS

            Dim show_ac As Double = Val(My.Settings.txt_d)


            Dim pass_ As Double = sm.GetSerial(TXT_PASS.Text)
            Dim dt As New DataTable
            dt = CLS_USER_.show_pas(TXT_NAME.Text, Val(pass_))
            If dt.Rows.Count > 0 Then
                TXT_GUID.Text = dt.Rows(0)(0).ToString()
                Dim guid__ As New System.IO.StreamWriter("C:\conn\txt_g.txt")
                guid__.Write(dt.Rows(0)(0).ToString())
                guid__.Close()
                isok = True
                Close()
            Else

                MessageBox.Show("يجب التاكد من المستخدم وكلمة المرور", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If


        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub GroupPanel1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupPanel1.Click

    End Sub

    Private Sub TXT_PASS_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TXT_PASS.KeyPress
        If Not (Asc(e.KeyChar) = 8) Then
            If Not ((Asc(e.KeyChar) >= 97 And Asc(e.KeyChar) <= 122) Or (Asc(e.KeyChar) >= 65 And Asc(e.KeyChar) <= 90)) Then
                e.KeyChar = ChrW(0)
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub TXT_PASS_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TXT_PASS.TextChanged

    End Sub

    Private Sub TXT_GUID_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TXT_GUID.TextChanged

    End Sub
End Class