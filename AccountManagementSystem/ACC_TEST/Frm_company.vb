Public Class Frm_company

    Private Sub Pictur_LOGO_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Pictur_LOGO.Click
        Try
            Dim ofd As New OpenFileDialog
            ofd.Filter = "اختر صورة|*.jpg;*.png;*.gig;"
            If ofd.ShowDialog = Windows.Forms.DialogResult.OK Then
                Pictur_LOGO.Image = Image.FromFile(ofd.FileName)


                My.Settings.TXTPATH_LOGO = ofd.FileName

                My.Settings.Save()
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Frm_company_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            TXT_NAME.Text = My.Settings.TXT_NAME
            TXT_PHONE.Text = My.Settings.TXT_PHONE
            TXT_MOBILE.Text = My.Settings.TXT_MOBILE
            TXT_EMAIL.Text = My.Settings.TXT_EMAIL
            TXT_WEB.Text = My.Settings.TXT_WEB

            Pictur_LOGO.Image = Image.FromFile(My.Settings.TXTPATH_LOGO)


        Catch ex As Exception

        End Try
    End Sub

    Private Sub Tool_SAVE_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_SAVE.Click
        Try
            My.Settings.TXT_NAME = TXT_NAME.Text
            My.Settings.TXT_PHONE = TXT_PHONE.Text
            My.Settings.TXT_MOBILE = TXT_MOBILE.Text
            My.Settings.TXT_EMAIL = TXT_EMAIL.Text
            My.Settings.TXT_WEB = TXT_WEB.Text
            MessageBox.Show("تمت عملية الحفظ بنجاح", "تاكيد", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Catch ex As Exception

        End Try
    End Sub
End Class