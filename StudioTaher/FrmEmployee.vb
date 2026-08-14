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

Public Class FrmEmployee

    Dim Idp As String
    Dim Idp1 As String
    Dim idp2 As String

    Dim ds As New DataSet
    Dim da As New SqlDataAdapter
    Dim dv As New DataView
    Dim cur As CurrencyManager

    ' الاتصال الرئيسي وجلب بيانات الموظفين
    Public Sub myconnaction()
        Try
            Using conn As New SqlConnection(Module1.ConStr)
                ds = New DataSet()
                da = New SqlDataAdapter("SELECT * FROM EmployeeResource", conn)
                da.Fill(ds, "EmployeeResource")
            End Using

            dv = New DataView(ds.Tables("EmployeeResource"))
            cur = CType(Me.BindingContext(dv), CurrencyManager)
            dgrview.DataSource = dv

            ' تفريغ ثم إعادة ربط عناصر التحكم بالبيانات
            txtEmpId.DataBindings.Clear()
            txtEmpName.DataBindings.Clear()
            txtEmpNotes.DataBindings.Clear()
            txtEmpAddress.DataBindings.Clear()
            txtEmpJop.DataBindings.Clear()
            txtEmpPhone.DataBindings.Clear()
            DtworkDate.DataBindings.Clear()
            txtEmpPrise.DataBindings.Clear()
            txtEmpSchool.DataBindings.Clear()
            cbEmpServise.DataBindings.Clear()

            txtEmpId.DataBindings.Add("Text", dv, "EmpId")
            txtEmpName.DataBindings.Add("Text", dv, "EmpName")
            txtEmpNotes.DataBindings.Add("Text", dv, "EmpNotes")
            txtEmpAddress.DataBindings.Add("Text", dv, "EmpAddress")
            txtEmpJop.DataBindings.Add("Text", dv, "EmpJop")
            txtEmpPhone.DataBindings.Add("Text", dv, "EmpPhone")
            DtworkDate.DataBindings.Add("Value", dv, "workDate", True, DataSourceUpdateMode.OnValidation, DBNull.Value)
            txtEmpPrise.DataBindings.Add("Text", dv, "EmpPrise")
            txtEmpSchool.DataBindings.Add("Text", dv, "EmpSchool")
            cbEmpServise.DataBindings.Add("Text", dv, "EmpServise")

        Catch ex As Exception
            MessageBox.Show(ex.Message, "ستديو وفيديو طاهر")
        End Try
    End Sub

    ' عرض موقع السجل الحالي
    Public Sub ShowPosition()
        Try
            If cur IsNot Nothing AndAlso cur.Count > 0 Then
                txtpostion.Text = "السجل رقم " & (cur.Position + 1) & " من " & cur.Count
            Else
                txtpostion.Text = "لا توجد سجلات"
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "ستديو وفيديو طاهر")
        End Try
    End Sub

    ' تفريغ الحقول لإضافة موظف جديد
    Public Sub ClearAllText()
        Try
            txtEmpId.Clear()
            txtEmpName.Clear()
            txtEmpNotes.Clear()
            txtEmpAddress.Clear()
            txtEmpJop.Clear()
            txtEmpPhone.Clear()
            txtEmpPrise.Clear()
            txtEmpSchool.Clear()
            cbEmpServise.SelectedIndex = -1
            DtworkDate.Value = DateTime.Now
            txtpostion.Text = "سجل جديد"
        Catch ex As Exception
            MessageBox.Show(ex.Message, "ستديو وفيديو طاهر")
        End Try
    End Sub

    ' دوال التنقل بين السجلات
    Public Sub MoveLast()
        Try
            If cur IsNot Nothing AndAlso cur.Count > 0 Then cur.Position = cur.Count - 1
        Catch ex As Exception
            MessageBox.Show(ex.Message, "ستديو وفيديو طاهر")
        End Try
    End Sub

    Public Sub Movepre()
        Try
            If cur IsNot Nothing AndAlso cur.Position > 0 Then cur.Position -= 1
        Catch ex As Exception
            MessageBox.Show(ex.Message, "ستديو وفيديو طاهر")
        End Try
    End Sub

    Public Sub MoveNext()
        Try
            If cur IsNot Nothing AndAlso cur.Position < cur.Count - 1 Then cur.Position += 1
        Catch ex As Exception
            MessageBox.Show(ex.Message, "ستديو وفيديو طاهر")
        End Try
    End Sub

    Public Sub MoveFirst()
        Try
            If cur IsNot Nothing AndAlso cur.Count > 0 Then cur.Position = 0
        Catch ex As Exception
            MessageBox.Show(ex.Message, "ستديو وفيديو طاهر")
        End Try
    End Sub

    ' حفظ موظف جديد
    Private Sub btnsave_Click(sender As Object, e As EventArgs) Handles btnsave.Click
        Try
            If String.IsNullOrWhiteSpace(txtEmpName.Text) Then
                MessageBox.Show("من فضلك أدخل اسم الموظف", "ستديو وفيديو طاهر", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                txtEmpName.Focus()
                Exit Sub
            End If

            Dim query As String = "INSERT INTO EmployeeResource (EmpName, EmpNotes, EmpAddress, EmpServise, EmpJop, EmpPhone, workDate, EmpPrise, EmpSchool) " &
                                 "VALUES (@EmpName, @EmpNotes, @EmpAddress, @EmpServise, @EmpJop, @EmpPhone, @workDate, @EmpPrise, @EmpSchool)"

            Using conn As New SqlConnection(Module1.ConStr)
                Using cmd As New SqlCommand(query, conn)
                    cmd.Parameters.Add("@EmpName", SqlDbType.NVarChar).Value = txtEmpName.Text.Trim()
                    cmd.Parameters.Add("@EmpNotes", SqlDbType.NVarChar).Value = txtEmpNotes.Text.Trim()
                    cmd.Parameters.Add("@EmpAddress", SqlDbType.NVarChar).Value = txtEmpAddress.Text.Trim()
                    cmd.Parameters.Add("@EmpServise", SqlDbType.NVarChar).Value = cbEmpServise.Text.Trim()
                    cmd.Parameters.Add("@EmpJop", SqlDbType.NVarChar).Value = txtEmpJop.Text.Trim()
                    cmd.Parameters.Add("@EmpPhone", SqlDbType.NVarChar).Value = txtEmpPhone.Text.Trim()
                    cmd.Parameters.Add("@workDate", SqlDbType.Date).Value = DtworkDate.Value.Date
                    cmd.Parameters.Add("@EmpPrise", SqlDbType.Decimal).Value = If(IsNumeric(txtEmpPrise.Text), Convert.ToDecimal(txtEmpPrise.Text), 0)
                    cmd.Parameters.Add("@EmpSchool", SqlDbType.NVarChar).Value = txtEmpSchool.Text.Trim()

                    conn.Open()
                    cmd.ExecuteNonQuery()
                End Using
            End Using

            MessageBox.Show("تم الحفظ بنجاح", "ستوديو وفيديو طاهر", MessageBoxButtons.OK, MessageBoxIcon.Information)
            myconnaction()
            MoveLast()
            ShowPosition()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "ستديو وفيديو طاهر")
        End Try
    End Sub

    ' تعديل بيانات موظف
    Private Sub btnupdate_Click(sender As Object, e As EventArgs) Handles btnupdate.Click
        Try
            If String.IsNullOrWhiteSpace(txtEmpId.Text) Then
                MessageBox.Show("اختر موظفاً لتعديل بياناته", "ستوديو وفيديو طاهر", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If

            Dim query As String = "UPDATE EmployeeResource SET EmpName = @EmpName, EmpNotes = @EmpNotes, EmpAddress = @EmpAddress, " &
                                 "EmpServise = @EmpServise, EmpJop = @EmpJop, EmpPhone = @EmpPhone, workDate = @workDate, " &
                                 "EmpPrise = @EmpPrise, EmpSchool = @EmpSchool WHERE EmpId = @EmpId"

            Using conn As New SqlConnection(Module1.ConStr)
                Using cmd As New SqlCommand(query, conn)
                    cmd.Parameters.Add("@EmpId", SqlDbType.Int).Value = Convert.ToInt32(txtEmpId.Text)
                    cmd.Parameters.Add("@EmpName", SqlDbType.NVarChar).Value = txtEmpName.Text.Trim()
                    cmd.Parameters.Add("@EmpNotes", SqlDbType.NVarChar).Value = txtEmpNotes.Text.Trim()
                    cmd.Parameters.Add("@EmpAddress", SqlDbType.NVarChar).Value = txtEmpAddress.Text.Trim()
                    cmd.Parameters.Add("@EmpServise", SqlDbType.NVarChar).Value = cbEmpServise.Text.Trim()
                    cmd.Parameters.Add("@EmpJop", SqlDbType.NVarChar).Value = txtEmpJop.Text.Trim()
                    cmd.Parameters.Add("@EmpPhone", SqlDbType.NVarChar).Value = txtEmpPhone.Text.Trim()
                    cmd.Parameters.Add("@workDate", SqlDbType.Date).Value = DtworkDate.Value.Date
                    cmd.Parameters.Add("@EmpPrise", SqlDbType.Decimal).Value = If(IsNumeric(txtEmpPrise.Text), Convert.ToDecimal(txtEmpPrise.Text), 0)
                    cmd.Parameters.Add("@EmpSchool", SqlDbType.NVarChar).Value = txtEmpSchool.Text.Trim()

                    conn.Open()
                    cmd.ExecuteNonQuery()
                End Using
            End Using

            MessageBox.Show("تم التعديل بنجاح", "ستوديو وفيديو طاهر", MessageBoxButtons.OK, MessageBoxIcon.Information)
            myconnaction()
            ShowPosition()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "ستديو وفيديو طاهر")
        End Try
    End Sub

    ' حذف موظف
    Private Sub btndelete_Click(sender As Object, e As EventArgs) Handles btndelete.Click
        Try
            If String.IsNullOrWhiteSpace(txtEmpId.Text) Then
                MessageBox.Show("من فضلك اختر موظفاً لحذفه", "ستوديو وفيديو طاهر", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If

            If MessageBox.Show("هل أنت متأكد من حذف هذا الموظف؟", "ستوديو وفيديو طاهر", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                Dim query As String = "DELETE FROM EmployeeResource WHERE EmpId = @EmpId"

                Using conn As New SqlConnection(Module1.ConStr)
                    Using cmd As New SqlCommand(query, conn)
                        cmd.Parameters.Add("@EmpId", SqlDbType.Int).Value = Convert.ToInt32(txtEmpId.Text)
                        conn.Open()
                        cmd.ExecuteNonQuery()
                    End Using
                End Using

                MessageBox.Show("تم الحذف بنجاح", "ستوديو وفيديو طاهر", MessageBoxButtons.OK, MessageBoxIcon.Information)
                myconnaction()
                ShowPosition()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "ستديو وفيديو طاهر")
        End Try
    End Sub

    ' زر موظف جديد
    Private Sub btnnew_Click(sender As Object, e As EventArgs) Handles btnnew.Click
        Try
            ClearAllText()
            empname.Text = cuname
        Catch ex As Exception
            MessageBox.Show(ex.Message, "ستديو وفيديو طاهر")
        End Try
    End Sub

    ' تعيين عناوين أعمدة الجدول عند تفعيل الشاشة
    Private Sub FrmEmployee_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        Try
            If dgrview.Columns.Count >= 10 Then
                dgrview.Columns(0).HeaderText = "كود الموظف"
                dgrview.Columns(1).HeaderText = "اسم الموظف"
                dgrview.Columns(2).HeaderText = "عنوان الموظف"
                dgrview.Columns(3).HeaderText = "تليفون الموظف"
                dgrview.Columns(4).HeaderText = "المؤهل الدراسى"
                dgrview.Columns(5).HeaderText = "الرقم القومى"
                dgrview.Columns(6).HeaderText = "صلاحيات الموظف"
                dgrview.Columns(7).HeaderText = "المسمى الوظيفي"
                dgrview.Columns(8).HeaderText = "الراتب الشهرى"
                dgrview.Columns(9).HeaderText = "تاريخ العمل"
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "ستديو وفيديو طاهر")
        End Try
    End Sub

    ' تحميل الشاشة والتحقق من التفعيل
    Private Sub FrmEmployee_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            myconnaction()
            ShowPosition()
            empname.Text = cuname

            If My.Settings.mysavety = False Then
                Dim Searcher As New ManagementObjectSearcher("Select ProcessorId From Win32_Processor")
                For Each Device As ManagementObject In Searcher.Get()
                    For Each Prop As PropertyData In Device.Properties
                        If Prop.Value IsNot Nothing Then Idp = Prop.Value.ToString()
                    Next
                Next
                Idp = Obfuscate(Idp)
                Idp = Str2Int(Idp)
                frmtools.TextBoxReg.Text = Idp
                Idp1 = Obfuscate(Idp)
                Idp1 = Str2Int(Idp1)
                If Idp1.Length >= 14 Then Idp1 = Idp1.Substring(0, 14)

                If My.Settings.nameuser = Idp1 Then Exit Sub

                MessageBox.Show("لم يتم تفعيل البرنامج يرجى تفعيل البرنامج ", "ستديو وفيديو طاهر", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                Application.Exit()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "ستديو وفيديو طاهر")
        End Try
    End Sub

    ' أحداث أزرار التنقل
    Private Sub btnMoveFirst_Click(sender As Object, e As EventArgs) Handles btnMoveFirst.Click
        MoveFirst()
        ShowPosition()
    End Sub

    Private Sub btnMovenext_Click(sender As Object, e As EventArgs) Handles btnMovenext.Click
        MoveNext()
        ShowPosition()
    End Sub

    Private Sub btnMovepre_Click(sender As Object, e As EventArgs) Handles btnMovepre.Click
        Movepre()
        ShowPosition()
    End Sub

    Private Sub btnMoveLast_Click(sender As Object, e As EventArgs) Handles btnMoveLast.Click
        MoveLast()
        ShowPosition()
    End Sub

    ' البحث بكود الموظف
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            If String.IsNullOrWhiteSpace(txtsearchunit.Text) Then Exit Sub
            dgrview.ClearSelection()
            dv.Sort = "EmpId"
            Dim index As Integer = dv.Find(txtsearchunit.Text.Trim())
            If index <> -1 Then
                cur.Position = index
                dgrview.Rows(cur.Position).Selected = True
                ShowPosition()
            Else
                MessageBox.Show("لم يتم العثور على الموظف بهذا الكود", "ستديو وفيديو طاهر", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "ستديو وفيديو طاهر")
        End Try
    End Sub

    ' البحث اللحظي باسم الموظف عبر الفلترة المباشرة
    Private Sub txtcustsearch_TextChanged(sender As Object, e As EventArgs) Handles txtcustsearch.TextChanged
        Try
            If dv IsNot Nothing Then
                Dim filterText As String = txtcustsearch.Text.Trim().Replace("'", "''")
                dv.RowFilter = String.Format("EmpName LIKE '%{0}%'", filterText)
                ShowPosition()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "ستديو وفيديو طاهر")
        End Try
    End Sub

    ' تصغير وإغلاق الشاشة
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click, Button8.Click
        Try
            FrmOP.Show()
            Me.Hide()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "ستديو وفيديو طاهر")
        End Try
    End Sub

    ' فتح شاشة طباعة بيانات الموظف
    Private Sub btnprinte_Click(sender As Object, e As EventArgs) Handles btnprinte.Click
        Try
            frmprinteemployee.Show()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "ستديو وفيديو طاهر")
        End Try
    End Sub

    ' التحقق من إدخال الأرقام فقط في الحقول المحددة
    Private Sub txtsearchunit_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtsearchunit.KeyPress, txtEmpPrise.KeyPress
        Try
            If Asc(e.KeyChar) <> 13 AndAlso Asc(e.KeyChar) <> 8 AndAlso Not Char.IsDigit(e.KeyChar) Then
                e.Handled = True
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "ستديو وفيديو طاهر")
        End Try
    End Sub

End Class