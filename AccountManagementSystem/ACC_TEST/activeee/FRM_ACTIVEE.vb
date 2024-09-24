Public Class FRM_ACTIVEE

    Dim serial As Double
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
          
            Dim sm As New SecurityManager
            serial = sm.GetSerial
            txtSerial.Text = serial
        Catch ex As Exception

        End Try
     
    End Sub

    Private Sub btnActivate_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnActivate.Click
        Dim key As Double
        If Not Long.TryParse(txtKey.Text, key) Then
            MessageBox.Show("Invalid activation key")
            Exit Sub
        End If

        Dim sm As New SecurityManager
        Dim key_pc As Double = sm.CheckKey(Val(serial))
        If Val(key_pc) = Val(txtKey.Text) Then
            My.Settings.txt_d = txtKey.Text
            My.Settings.Save()
            Application.Exit()
            MessageBox.Show("Activation was successful")
        Else
            MessageBox.Show("eror")
        End If


    End Sub

    

    
    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Application.Exit()
    End Sub
End Class