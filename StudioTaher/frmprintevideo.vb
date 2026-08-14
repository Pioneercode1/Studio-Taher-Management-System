Public Class frmprintevideo

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click

        Try
            Me.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "ستديو وفيديو طاهر")
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            Me.WindowState = FormWindowState.Minimized
        Catch ex As Exception
            MessageBox.Show(ex.Message, "ستديو وفيديو طاهر")
        End Try

    End Sub

    Private Sub frmprintevideo_Load(sender As Object, e As EventArgs) Handles Me.Load
        Try
            Me.CustomerVideoTableAdapter.Connection.ConnectionString = Module1.ConStr
            Me.CustomerVideoTableAdapter.FillBy(Me.StudioTaherDataSet.CustomerVideo, FrmVideo.txtCusId.Text)
            Me.ReportViewer1.RefreshReport()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "ستديو وفيديو طاهر")
        End Try
    End Sub

End Class