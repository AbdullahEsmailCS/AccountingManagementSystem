Public Class FRM_NOTE

    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Dim webAddress As String = "http://www.acc-prog.com/"
        Process.Start(webAddress)
    End Sub
End Class