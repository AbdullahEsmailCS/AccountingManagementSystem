Imports System.IO
Public Class FRM_LOAD_REP
    Public ISOK_ As Boolean = False
    Private Sub FRM_LOAD_REP_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
       
    End Sub

    Private Sub dgv_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgv.CellClick
        Try
            ISOK_ = True
            Close()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub dgv_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgv.CellContentClick

    End Sub

    Private Sub TXT_PATH_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TXT_PATH.TextChanged
        Try
            Dim path As String
            ' ضبط أرتفاع السطر حسب رغبتك '
            Me.dgv.RowTemplate.Height = 40

           

            path = TXT_PATH.Text
          


            Dim files() As String = _
                IO.Directory.GetFiles(path, "*.*") _
                .Where(Function(fn) fn.ToLower().EndsWith(".rpt")).ToArray

            ' إضافة سطر في الداتاجريدفيو - العمود الأول اسم الملف والعمود الثاني الصورة '
            For Each fn As String In files


                'Dim FileInfo As New FileInfo(IO.Path.GetFileName(fn))

                Me.dgv.Rows.Add(New Object() {IO.Path.GetFileName(fn), path + "\" + IO.Path.GetFileName(fn)})
            Next
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub
End Class