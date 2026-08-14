Public Class frmprintphoto
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            Me.WindowState = FormWindowState.Minimized
        Catch ex As Exception
            MessageBox.Show(ex.Message, "ستديو وفيديو طاهر")
        End Try
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        Try
            Me.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "ستديو وفيديو طاهر")
        End Try
    End Sub

    Private Sub frmprintphoto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Me.CustomerPhotoTableAdapter.Connection.ConnectionString = Module1.ConStr
            Me.CustomerPhotoTableAdapter.FillBy1(Me.StudioTaherDataSet.CustomerPhoto, FrmPhoto.txtcusid.Text)
            Me.ReportViewer1.RefreshReport()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "ستديو وفيديو طاهر")
        End Try
    End Sub

End Class