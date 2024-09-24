Public Class Form2

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim sm As New CLS_PS

        Dim show_ac As Double = Val(My.Settings.txt_d)

        TextBox2.Text = sm.GetSerial(TextBox1.Text)
        'TextBox2.Text
        'serial = sm.GetSerial(TextBox1.Text)
       
    End Sub
End Class