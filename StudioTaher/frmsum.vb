'
' Copyright (c) 2026 pioneercode, Inc.
'
' Licensed under the Apache License, Version 2.0 (the "License");
' you may not use this file except in compliance with the License.
' You may obtain a copy of the License at
'
'     http://www.apache.org/licenses/LICENSE-2.0
'
' Unless required by applicable law or agreed to in writing, software
' distributed under the License is distributed on an "AS IS" BASIS,
' WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
' See the License for the specific language governing permissions and
' limitations under the License.
'

Public Class frmsum

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        Try
            FrmOP.Show()
            Me.Hide()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "ستديو وفيديو طاهر")
        End Try
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Try
            Me.WindowState = FormWindowState.Minimized
        Catch ex As Exception
            MessageBox.Show(ex.Message, "ستديو وفيديو طاهر")
        End Try
    End Sub
End Class