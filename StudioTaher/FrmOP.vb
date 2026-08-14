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

Imports System.Management
Imports System.IO
Public Class FrmOP
    Dim Idp As String
    Dim Idp1 As String
    Dim idp2 As String

    Private Sub btnPhoto_Click(sender As Object, e As EventArgs) Handles btnPhoto.Click
        Try
            cuname = Me.EmpName.Text

            FrmPhoto.Show()
            Me.Hide()

        Catch ex As Exception
            MessageBox.Show(ex.Message, "ستديو وفيديو طاهر")
        End Try

    End Sub

    Private Sub btnvideo_Click(sender As Object, e As EventArgs) Handles btnvideo.Click
        Try

            FrmVideo.Show()
            Me.Hide()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "ستديو وفيديو طاهر")
        End Try

    End Sub

    Private Sub btnMarage_Click(sender As Object, e As EventArgs) Handles btnMarage.Click
        Try
            FrmMarrage.Show()
            Me.Hide()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "ستديو وفيديو طاهر")
        End Try

    End Sub

    Private Sub btnEmployee_Click(sender As Object, e As EventArgs) Handles btnEmployee.Click
        Try
            FrmEmployee.Show()
            Me.Hide()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "ستديو وفيديو طاهر")
        End Try

    End Sub
    Private Sub btnfilesearch_Click(sender As Object, e As EventArgs)
        Try
            FrmSearch.ShowDialog()
            Me.Hide()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "ستديو وفيديو طاهر")
        End Try


    End Sub
    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        Try
            If MessageBox.Show("هل تريد الخروج من البرنامج", "ستديو وفيديو طاهر", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.No Then
                Exit Sub
            End If
            Application.Exit()
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

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Try
            FrmSearch.ShowDialog()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "ستديو وفيديو طاهر")
        End Try

    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Try
            frmtools.ShowDialog()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "ستديو وفيديو طاهر")
        End Try

    End Sub

    Private Sub btnchangeuser_Click(sender As Object, e As EventArgs) Handles btnchangeuser.Click
        Try
            FrmEmployee.Close()
            frmdesignphoto.Close()
            FrmMarrage.Close()
            FrmPhoto.Close()
            frmprintphoto.Close()
            FrmSearch.Close()
            frmtools.Close()
            FrmVideo.Close()
            FrmMain.Show()
            FrmMain.txtname.Text = ""
            FrmMain.txtpassord.Text = ""
            FrmMain.cbUserType.SelectedIndex = -1
            FrmMain.cbUserType.Focus()
            Me.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "ستديو وفيديو طاهر")
        End Try

    End Sub

    'Private Sub btnsearchphoto_Click(sender As Object, e As EventArgs) Handles btnsearchphoto.Click
    '    Try
    '        Process.Start(My.Settings.mycreatechak)
    '    Catch ex As Exception
    '        MessageBox.Show(ex.Message, "ستديو وفيديو طاهر")
    '    End Try

    'End Sub

    Private Sub FrmOP_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnsearchphoto_Click(sender As Object, e As EventArgs) Handles btnsearchphoto.Click

    End Sub
End Class