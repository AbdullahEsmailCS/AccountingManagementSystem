Public Class Form1
    'Public Sub RefreshMyTextBox()
    '    If Me.InvokeRequired() Then
    '        Me.Invoke(Sub() RefreshMyTextBox())
    '    Else
    '        'Code to refresh your textbox here
    '    End If
    'End Sub
    Private mdgvr As String
    Public Sub New(ByVal dgvr As String)
        InitializeComponent()
        TextBox1.Text = dgvr
        mdgvr = dgvr
    End Sub
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class