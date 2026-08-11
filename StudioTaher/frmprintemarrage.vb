Public Class frmprintemarrage

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Try
            Me.WindowState = FormWindowState.Minimized
        Catch ex As Exception
            MessageBox.Show(ex.Message, "ستديو وفيديو طاهر")
        End Try
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click

        Try
            Me.Hide()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "ستديو وفيديو طاهر")
        End Try
    End Sub

    Private Sub frmprintemarrage_Activated(sender As Object, e As EventArgs) Handles Me.Activated

        Try
            Me.marageTableAdapter.FillBy(Me.StudioTaherDataSet.marage, FrmMarrage.txtCusId.Text)
            Me.ReportViewer1.RefreshReport()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "ستديو وفيديو طاهر")
        End Try
    End Sub

End Class