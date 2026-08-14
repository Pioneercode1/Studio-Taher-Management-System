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

Imports System.Data
Imports System.Data.SqlClient
Imports System.Management
Public Class FrmMain
    Public Conn As New SqlConnection
    Dim myCommand As New SqlCommand
    Dim DRuser As SqlDataReader
    Dim Idp As String
    Dim Idp1 As String
    Dim idp2 As String
    Public Sub myconnaction()
        Try
            'Conn = New SqlConnection("Data Source=.\SQLExpress; INITIAL CATALOG=StudioTaher;INTEGRATED SECURITY=True;")
            Dim connectionString As String = "Data Source=(LocalDB)\MSSQLLocalDB; Initial Catalog=StudioTaher; Integrated Security=True;"
            Conn = New SqlConnection(connectionString)
            myCommand = New SqlCommand("select UserName,Password,JobEmployee from loginAdmin where UserName = @UserName and Password = @Password and JobEmployee = @JobEmployee ", Conn)
            Dim uName As New SqlParameter("@UserName", SqlDbType.NVarChar)
            Dim uPassword As New SqlParameter("@Password", SqlDbType.NVarChar)
            Dim uType As New SqlParameter("@JobEmployee", SqlDbType.NVarChar)
            uName.Value = txtname.Text
            uPassword.Value = txtpassord.Text
            uType.Value = cbUserType.Text
            myCommand.Parameters.Add(uName)
            myCommand.Parameters.Add(uPassword)
            myCommand.Parameters.Add(uType)
            myCommand.Connection.Open()
            Dim myReader As SqlDataReader = myCommand.ExecuteReader(CommandBehavior.CloseConnection)
            Dim Login As Object = 0
            If myReader.HasRows Then
                myReader.Read()
                Login = myReader(Login)
            End If
            If Login = Nothing Then
                MessageBox.Show("اسم المستخدم غير موجود", "ستديو وفيديو طاهر")
                txtname.Text = ""
                txtpassord.Text = ""
                txtname.Focus()
                Exit Sub
            End If
            If cbUserType.Text = "المدير" Then
                FrmOP.Show()
                Me.Hide()
            End If
            If cbUserType.Text = "المساعد" Then
                FrmOP.Show()
                Me.Hide()
            End If
            If cbUserType.Text = "المحاسب" Then
                FrmOP.Show()
                Me.Hide()
            End If
            myCommand.Dispose()
            Conn.Close()
        Catch ex As SqlException
            MessageBox.Show(ex.Message, "ستديو وفيديو طاهر")
        End Try
    End Sub

    Private Sub InsedCus_Click(sender As Object, e As EventArgs) Handles InsedCus.Click
        Try

            If Len(Trim(cbUserType.Text)) = 0 Then
                MessageBox.Show("من فضلك ادخل نوع الصلاحية", "ستديو وفيديو طاهر", MessageBoxButtons.OK, MessageBoxIcon.Error)
                cbUserType.Focus()
                Exit Sub
            End If
            If Len(Trim(txtname.Text)) = 0 Then
                MessageBox.Show("من فضلك ادخل اسم المستخدم", "ستديو وفيديو طاهر", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtname.Focus()
                Exit Sub
            End If
            If Len(Trim(txtpassord.Text)) = 0 Then
                MessageBox.Show("من فضلك ادخل كلمة المرور", "ستديو وفيديو طاهر", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtpassord.Focus()
                Exit Sub
            End If
            myconnaction()
            FrmOP.EmpName.Text = txtname.Text
            FrmOP.EmpWork.Text = cbUserType.Text

        Catch ex As Exception
            MessageBox.Show(ex.Message, "ستديو وفيديو طاهر")
        End Try
    End Sub

    Private Sub ExitButtons_Click(sender As Object, e As EventArgs) Handles Button13.Click, Button1.Click
        If MessageBox.Show("هل تريد الخروج من البرنامج؟", "ستديو وفيديو طاهر", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Application.Exit()
        End If
    End Sub

    Private Sub cbUserType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbUserType.SelectedIndexChanged

    End Sub
End Class