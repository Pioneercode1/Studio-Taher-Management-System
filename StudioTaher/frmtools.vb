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

Public Class frmtools

    Dim idp As String  ' رقم المعالج
    Dim idp1 As String ' رقم التسجيل
    Dim idp2 As String ' رقم التفعيل

    ' دالة التحقق من أرقام فقط
    Public Function OnlyNumeric(ByVal Key As Integer) As Boolean
        If (Key >= 48 And Key <= 57) Or Key = 8 Then
            Return False
        Else
            Return True
        End If
    End Function

    ' دالة التحقق من أحرف فقط
    Public Function OnlyCharacter(ByVal key As Integer) As Boolean
        If ((key >= 65 And key <= 90) Or (key >= 97 And key <= 122) Or key = 8) Then
            Return False
        Else
            Return True
        End If
    End Function

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        Try
            Me.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "ستديو وفيديو طاهر")
        End Try
    End Sub

    ' التحقق من السيريال وتفعيل البرنامج
    Private Sub btnserialok_Click(sender As Object, e As EventArgs) Handles btnserialok.Click
        Try
            If Len(Trim(TextBoxUser.Text)) = 0 Then
                MessageBox.Show("من فضلك ادخل الرقم التسلسلى", "ستديو وفيديو طاهر", MessageBoxButtons.OK, MessageBoxIcon.Error)
                TextBoxReg.Focus()
                Exit Sub
            End If

            idp2 = idp1
            If TextBoxUser.Text = idp2 Then
                ' حفظ الإعدادات
                My.Settings.nameuser = TextBoxUser.Text
                My.Settings.mysavety = True
                My.Settings.Save()

                MessageBox.Show("شكرا جزيلا لك على ثقتك بنا", "ستديو وفيديو طاهر")
                Labeserialsend.Visible = False
                Labeserial.Visible = False
                Labeokay.Visible = True
                TextBoxReg.Visible = False
                TextBoxUser.Visible = False
                btnserialok.Visible = False
                btnserial.Visible = False
            Else
                MessageBox.Show("من فضلك ادخل رقم صحيح", "ستديو وفيديو طاهر", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "ستديو وفيديو طاهر")
        End Try
    End Sub

    Private Sub btnsave_Click(sender As Object, e As EventArgs) Handles btnsave.Click
        Try
            ' 1. التحقق من إدخال اسم المستخدم
            If String.IsNullOrWhiteSpace(txtUserName.Text) Then
                MessageBox.Show("من فضلك ادخل اسم المستخدم", "ستديو وفيديو طاهر", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                txtUserName.Focus()
                Exit Sub
            End If

            ' 2. التحقق من إدخال كلمة المرور
            If String.IsNullOrWhiteSpace(txtPassword.Text) Then
                MessageBox.Show("من فضلك ادخل كلمة المرور", "ستديو وفيديو طاهر", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                txtPassword.Focus()
                Exit Sub
            End If

            ' 3. التحقق من إدخال تأكيد كلمة المرور
            If String.IsNullOrWhiteSpace(txtPassword2.Text) Then
                MessageBox.Show("من فضلك أعد كتابة كلمة المرور لتأكيدها", "ستديو وفيديو طاهر", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                txtPassword2.Focus()
                Exit Sub
            End If

            ' 4. التحقق من تطابق كلمتي المرور
            If txtPassword.Text <> txtPassword2.Text Then
                MessageBox.Show("كلمة المرور غير متطابقة", "ستديو وفيديو طاهر", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                txtPassword2.Focus()
                txtPassword2.SelectAll()
                Exit Sub
            End If

            ' 5. التحقق من اختيار وظيفة/صلاحية الموظف
            If String.IsNullOrWhiteSpace(cbJobEmployee.Text) Then
                MessageBox.Show("من فضلك اختر وظيفة الموظف", "ستديو وفيديو طاهر", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                cbJobEmployee.Focus()
                Exit Sub
            End If

            ' 6. التحقق والحفظ في قاعدة البيانات
            Using conn As New SqlConnection(Module1.ConStr)
                conn.Open()

                ' التثبت من عدم تكرار اسم المستخدم
                Dim checkQuery As String = "SELECT COUNT(*) FROM loginAdmin WHERE UserName = @User"
                Using checkCmd As New SqlCommand(checkQuery, conn)
                    checkCmd.Parameters.Add("@User", SqlDbType.NVarChar).Value = txtUserName.Text.Trim()
                    Dim userCount As Integer = Convert.ToInt32(checkCmd.ExecuteScalar())

                    If userCount > 0 Then
                        MessageBox.Show("اسم المستخدم موجود بالفعل، يرجى اختيار اسم مستخدم آخر.", "ستديو وفيديو طاهر", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        txtUserName.Focus()
                        txtUserName.SelectAll()
                        Exit Sub
                    End If
                End Using

                ' إدراج البيانات
                Dim insertQuery As String = "INSERT INTO loginAdmin (UserName, Password, JobEmployee) VALUES (@User, @Pass, @Job)"
                Using cmd As New SqlCommand(insertQuery, conn)
                    cmd.Parameters.Add("@User", SqlDbType.NVarChar).Value = txtUserName.Text.Trim()
                    cmd.Parameters.Add("@Pass", SqlDbType.NVarChar).Value = txtPassword.Text.Trim()
                    cmd.Parameters.Add("@Job", SqlDbType.NVarChar).Value = cbJobEmployee.Text.Trim()

                    cmd.ExecuteNonQuery()
                End Using
            End Using

            ' 7. نجاح العملية وتفريغ الحقول
            MessageBox.Show("تم حفظ المستخدم بنجاح", "ستديو وفيديو طاهر", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtUserName.Clear()
            txtPassword.Clear()
            txtPassword2.Clear()
            cbJobEmployee.SelectedIndex = -1

        Catch ex As Exception
            MessageBox.Show(ex.Message, "ستديو وفيديو طاهر")
        End Try
    End Sub

    ' حذف مستخدم
    Private Sub btndelete_Click(sender As Object, e As EventArgs) Handles btndelete.Click
        Try
            If String.IsNullOrWhiteSpace(txtUserName.Text) Then
                MessageBox.Show("من فضلك ادخل اسم المستخدم", "ستوديو وفيديو طاهر", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                txtUserName.Focus()
                Exit Sub
            End If

            If MessageBox.Show("هل انت تريد حذف هذا المستخدم؟", "ستوديو وفيديو طاهر", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                Dim query As String = "DELETE FROM loginAdmin WHERE UserName = @User"

                Using conn As New SqlConnection(Module1.ConStr)
                    Using cmd As New SqlCommand(query, conn)
                        cmd.Parameters.Add("@User", SqlDbType.NVarChar).Value = txtUserName.Text.Trim()

                        conn.Open()
                        Dim rowsAffected As Integer = cmd.ExecuteNonQuery()

                        If rowsAffected > 0 Then
                            MessageBox.Show("تم الحذف بنجاح", "ستوديو وفيديو طاهر", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            txtUserName.Clear()
                        Else
                            MessageBox.Show("اسم المستخدم غير موجود", "ستوديو وفيديو طاهر", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        End If
                    End Using
                End Using
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "ستديو وفيديو طاهر")
        End Try
    End Sub

    ' توليد السيريال من معالج الجهاز
    Private Sub btnserial_Click(sender As Object, e As EventArgs) Handles btnserial.Click
        Try
            Dim Searcher As New ManagementObjectSearcher("Select ProcessorId From Win32_Processor")
            For Each Device As ManagementObject In Searcher.Get()
                For Each Prop As PropertyData In Device.Properties
                    If Prop.Value IsNot Nothing Then
                        idp = Prop.Value.ToString()
                    End If
                Next
            Next

            ' يستدعي الدالين المعرفتين في الـ Module
            idp = Obfuscate(idp)
            idp = Str2Int(idp)
            TextBoxReg.Text = idp

            idp1 = Obfuscate(idp)
            idp1 = Str2Int(idp1)
            If idp1.Length >= 14 Then
                idp1 = idp1.Substring(0, 14)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "ستديو وفيديو طاهر")
        End Try
    End Sub

    ' إضافة مقاس صورة وسعر جديد
    Private Sub btnaddLBsize_Click(sender As Object, e As EventArgs) Handles btnaddLBsize.Click
        Try
            If String.IsNullOrWhiteSpace(txtLBsize.Text) Then
                MessageBox.Show("من فضلك ادخل المقاس", "ستديو وفيديو طاهر", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtLBsize.Focus()
                Exit Sub
            End If

            If String.IsNullOrWhiteSpace(txtcbprise.Text) Then
                MessageBox.Show("من فضلك ادخل السعر", "ستديو وفيديو طاهر", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtcbprise.Focus()
                Exit Sub
            End If

            Dim query As String = "INSERT INTO disgnphoto (custsize, custprise) VALUES (@Size, @Price)"

            Using conn As New SqlConnection(Module1.ConStr)
                Using cmd As New SqlCommand(query, conn)
                    cmd.Parameters.Add("@Size", SqlDbType.NVarChar).Value = txtLBsize.Text.Trim()
                    cmd.Parameters.Add("@Price", SqlDbType.NVarChar).Value = txtcbprise.Text.Trim()

                    conn.Open()
                    cmd.ExecuteNonQuery()
                End Using
            End Using

            MessageBox.Show("تم حفظ الاعدادات بنجاح", "ستديو وفيديو طاهر", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtLBsize.Clear()
            txtcbprise.Clear()

        Catch ex As Exception
            MessageBox.Show(ex.Message, "ستديو وفيديو طاهر")
        End Try
    End Sub

    ' حذف مقاس
    Private Sub btncleansi_Click(sender As Object, e As EventArgs) Handles btncleansi.Click
        Try
            If String.IsNullOrWhiteSpace(txtLBsize.Text) Then
                MessageBox.Show("من فضلك ادخل المقاس المراد حذفه", "ستوديو وفيديو طاهر", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                txtLBsize.Focus()
                Exit Sub
            End If

            If MessageBox.Show("هل انت تريد حذف هذا المقاس؟", "ستوديو وفيديو طاهر", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                Dim query As String = "DELETE FROM disgnphoto WHERE custsize = @Size"

                Using conn As New SqlConnection(Module1.ConStr)
                    Using cmd As New SqlCommand(query, conn)
                        cmd.Parameters.Add("@Size", SqlDbType.NVarChar).Value = txtLBsize.Text.Trim()

                        conn.Open()
                        cmd.ExecuteNonQuery()
                    End Using
                End Using

                MessageBox.Show("تم الحذف بنجاح", "ستوديو وفيديو طاهر", MessageBoxButtons.OK, MessageBoxIcon.Information)
                txtLBsize.Clear()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "ستديو وفيديو طاهر")
        End Try
    End Sub

    ' تحميل إعدادات الشاشة عند الفتح
    Private Sub frmtools_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            If My.Settings.mysavety = True Then
                Labeserialsend.Visible = False
                Labeserial.Visible = False
                Labeokay.Visible = True
                TextBoxReg.Visible = False
                TextBoxUser.Visible = False
                btnserialok.Visible = False
                btnserial.Visible = False
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "ستديو وفيديو طاهر")
        End Try
    End Sub

    ' قبول أرقام فقط في خانة السعر
    Private Sub txtcbprise_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtcbprise.KeyPress
        Try
            e.Handled = OnlyNumeric(Asc(e.KeyChar))
        Catch ex As Exception
            MessageBox.Show(ex.Message, "ستديو وفيديو طاهر")
        End Try
    End Sub

    ' قبول أرقام فقط في خانة كود المستخدم
    Private Sub TextBoxUser_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBoxUser.KeyPress
        Try
            e.Handled = OnlyNumeric(Asc(e.KeyChar))
        Catch ex As Exception
            MessageBox.Show(ex.Message, "ستديو وفيديو طاهر")
        End Try
    End Sub

End Class