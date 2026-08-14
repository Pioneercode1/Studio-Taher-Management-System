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

Public Class FrmMarrage

    Dim Idp As String
    Dim Idp1 As String
    Dim idp2 As String

    Dim ds As New DataSet
    Dim da As New SqlDataAdapter
    Dim dv As New DataView
    Dim cur As CurrencyManager

    ' الاتصال الرئيسي وجلب البيانات
    Public Sub myconnaction()
        Try
            Using conn As New SqlConnection(Module1.ConStr)
                ds = New DataSet()
                da = New SqlDataAdapter("SELECT * FROM marage", conn)
                da.Fill(ds, "marage")
            End Using

            dv = New DataView(ds.Tables("marage"))
            cur = CType(Me.BindingContext(dv), CurrencyManager)
            dgrview.DataSource = dv

            ' تفريغ ثم إعادة ربط عناصر التحكم بالبيانات
            txtCusId.DataBindings.Clear()
            txtCusname.DataBindings.Clear()
            txtCusAddress.DataBindings.Clear()
            txtCusNots.DataBindings.Clear()
            txtAllPrise.DataBindings.Clear()
            txtCusPhone.DataBindings.Clear()
            txtCusOrder.DataBindings.Clear()
            txtgavet.DataBindings.Clear()
            txtJetPrise.DataBindings.Clear()
            txtSetPrise.DataBindings.Clear()
            DtFriDate.DataBindings.Clear()
            DtSecDate.DataBindings.Clear()
            cbAboutOrder.DataBindings.Clear()

            txtCusId.DataBindings.Add("Text", dv, "CusId")
            txtCusname.DataBindings.Add("Text", dv, "Cusname")
            txtCusAddress.DataBindings.Add("Text", dv, "CusAddress")
            txtCusNots.DataBindings.Add("Text", dv, "CusNots")
            txtAllPrise.DataBindings.Add("Text", dv, "AllPrise")
            txtCusPhone.DataBindings.Add("Text", dv, "CusPhone")
            txtCusOrder.DataBindings.Add("Text", dv, "CusOrder")
            txtgavet.DataBindings.Add("Text", dv, "gavet")
            txtJetPrise.DataBindings.Add("Text", dv, "JetPrise")
            txtSetPrise.DataBindings.Add("Text", dv, "SetPrise")
            DtFriDate.DataBindings.Add("Value", dv, "FriDate", True, DataSourceUpdateMode.OnValidation, DBNull.Value)
            DtSecDate.DataBindings.Add("Value", dv, "SecDate", True, DataSourceUpdateMode.OnValidation, DBNull.Value)
            cbAboutOrder.DataBindings.Add("Text", dv, "AboutOrder")

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

    ' تفريغ النص لإضافة سجل جديد
    Public Sub ClearAllText()
        Try
            txtCusId.Clear()
            txtCusname.Clear()
            txtCusAddress.Clear()
            txtCusNots.Clear()
            txtAllPrise.Clear()
            txtCusPhone.Clear()
            txtCusOrder.Clear()
            txtgavet.Clear()
            txtJetPrise.Clear()
            txtSetPrise.Clear()
            cbAboutOrder.SelectedIndex = -1
            DtFriDate.Value = DateTime.Now
            DtSecDate.Value = DateTime.Now
            txtpostion.Text = "سجل جديد"
        Catch ex As Exception
            MessageBox.Show(ex.Message, "ستديو وفيديو طاهر")
        End Try
    End Sub

    ' دوان التنقل بين السجلات مع الحماية
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

    ' حذف عميل
    Private Sub btndelete_Click(sender As Object, e As EventArgs) Handles btndelete.Click
        Try
            If String.IsNullOrWhiteSpace(txtCusId.Text) Then
                MessageBox.Show("من فضلك اختر عميلاً لحذفه", "ستوديو وفيديو طاهر", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If

            If MessageBox.Show("هل أنت متأكد من حذف هذا العميل؟", "ستوديو وفيديو طاهر", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                Dim query As String = "DELETE FROM marage WHERE CusId = @CusId"

                Using conn As New SqlConnection(Module1.ConStr)
                    Using cmd As New SqlCommand(query, conn)
                        cmd.Parameters.Add("@CusId", SqlDbType.Int).Value = Convert.ToInt32(txtCusId.Text)
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

    ' تعديل بيانات العميل
    Private Sub btnupdate_Click(sender As Object, e As EventArgs) Handles btnupdate.Click
        Try
            If String.IsNullOrWhiteSpace(txtCusId.Text) Then
                MessageBox.Show("اختر عميلاً لتعديل بياناته", "ستوديو وفيديو طاهر", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If

            Dim query As String = "UPDATE marage SET Cusname = @CusName, CusAddress = @CusAddress, CusNots = @CusNots, AllPrise = @AllPrise, " &
                                 "CusPhone = @CusPhone, CusOrder = @CusOrder, gavet = @gavet, JetPrise = @JetPrise, SetPrise = @SetPrise, " &
                                 "FriDate = @FriDate, SecDate = @SecDate, AboutOrder = @AboutOrder, OrderBy = @OrderBy WHERE CusId = @CusId"

            Using conn As New SqlConnection(Module1.ConStr)
                Using cmd As New SqlCommand(query, conn)
                    cmd.Parameters.Add("@CusId", SqlDbType.Int).Value = Convert.ToInt32(txtCusId.Text)
                    cmd.Parameters.Add("@CusName", SqlDbType.NVarChar).Value = txtCusname.Text.Trim()
                    cmd.Parameters.Add("@CusAddress", SqlDbType.NVarChar).Value = txtCusAddress.Text.Trim()
                    cmd.Parameters.Add("@CusNots", SqlDbType.NVarChar).Value = txtCusNots.Text.Trim()
                    cmd.Parameters.Add("@AllPrise", SqlDbType.Decimal).Value = If(IsNumeric(txtAllPrise.Text), Convert.ToDecimal(txtAllPrise.Text), 0)
                    cmd.Parameters.Add("@CusPhone", SqlDbType.NVarChar).Value = txtCusPhone.Text.Trim()
                    cmd.Parameters.Add("@CusOrder", SqlDbType.NVarChar).Value = txtCusOrder.Text.Trim()
                    cmd.Parameters.Add("@gavet", SqlDbType.NVarChar).Value = txtgavet.Text.Trim()
                    cmd.Parameters.Add("@JetPrise", SqlDbType.Decimal).Value = If(IsNumeric(txtJetPrise.Text), Convert.ToDecimal(txtJetPrise.Text), 0)
                    cmd.Parameters.Add("@SetPrise", SqlDbType.Decimal).Value = If(IsNumeric(txtSetPrise.Text), Convert.ToDecimal(txtSetPrise.Text), 0)
                    cmd.Parameters.Add("@FriDate", SqlDbType.Date).Value = DtFriDate.Value.Date
                    cmd.Parameters.Add("@SecDate", SqlDbType.Date).Value = DtSecDate.Value.Date
                    cmd.Parameters.Add("@AboutOrder", SqlDbType.NVarChar).Value = cbAboutOrder.Text.Trim()
                    cmd.Parameters.Add("@OrderBy", SqlDbType.NVarChar).Value = empname.Text.Trim()

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

    ' حفظ عميل جديد
    Private Sub btnsave_Click(sender As Object, e As EventArgs) Handles btnsave.Click
        Try
            ' التحقق من ملئ البيانات الأساسية
            If String.IsNullOrWhiteSpace(txtCusname.Text) Then
                MessageBox.Show("من فضلك ادخل اسم العميل", "ستديو وفيديو طاهر", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                txtCusname.Focus()
                Exit Sub
            End If

            Dim query As String = "INSERT INTO marage (Cusname, CusAddress, CusNots, AllPrise, CusPhone, CusOrder, gavet, JetPrise, SetPrise, FriDate, SecDate, AboutOrder, OrderBy) " &
                                 "VALUES (@CusName, @CusAddress, @CusNots, @AllPrise, @CusPhone, @CusOrder, @gavet, @JetPrise, @SetPrise, @FriDate, @SecDate, @AboutOrder, @OrderBy)"

            Using conn As New SqlConnection(Module1.ConStr)
                Using cmd As New SqlCommand(query, conn)
                    cmd.Parameters.Add("@CusName", SqlDbType.NVarChar).Value = txtCusname.Text.Trim()
                    cmd.Parameters.Add("@CusAddress", SqlDbType.NVarChar).Value = txtCusAddress.Text.Trim()
                    cmd.Parameters.Add("@CusNots", SqlDbType.NVarChar).Value = txtCusNots.Text.Trim()
                    cmd.Parameters.Add("@AllPrise", SqlDbType.Decimal).Value = If(IsNumeric(txtAllPrise.Text), Convert.ToDecimal(txtAllPrise.Text), 0)
                    cmd.Parameters.Add("@CusPhone", SqlDbType.NVarChar).Value = txtCusPhone.Text.Trim()
                    cmd.Parameters.Add("@CusOrder", SqlDbType.NVarChar).Value = txtCusOrder.Text.Trim()
                    cmd.Parameters.Add("@gavet", SqlDbType.NVarChar).Value = txtgavet.Text.Trim()
                    cmd.Parameters.Add("@JetPrise", SqlDbType.Decimal).Value = If(IsNumeric(txtJetPrise.Text), Convert.ToDecimal(txtJetPrise.Text), 0)
                    cmd.Parameters.Add("@SetPrise", SqlDbType.Decimal).Value = If(IsNumeric(txtSetPrise.Text), Convert.ToDecimal(txtSetPrise.Text), 0)
                    cmd.Parameters.Add("@FriDate", SqlDbType.Date).Value = DtFriDate.Value.Date
                    cmd.Parameters.Add("@SecDate", SqlDbType.Date).Value = DtSecDate.Value.Date
                    cmd.Parameters.Add("@AboutOrder", SqlDbType.NVarChar).Value = cbAboutOrder.Text.Trim()
                    cmd.Parameters.Add("@OrderBy", SqlDbType.NVarChar).Value = empname.Text.Trim()

                    conn.Open()
                    cmd.ExecuteNonQuery()
                End Using
            End Using

            MessageBox.Show("تم الحفظ بنجاح", "ستديو وفيديو طاهر", MessageBoxButtons.OK, MessageBoxIcon.Information)
            myconnaction()
            MoveLast()
            ShowPosition()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "ستديو وفيديو طاهر")
        End Try
    End Sub

    ' زر عميل جديد
    Private Sub btnnew_Click(sender As Object, e As EventArgs) Handles btnnew.Click
        Try
            ClearAllText()
            empname.Text = cuname
        Catch ex As Exception
            MessageBox.Show(ex.Message, "ستديو وفيديو طاهر")
        End Try
    End Sub

    ' ضبط عناوين أعمدة الجدول
    Private Sub FrmMarrage_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        Try
            If dgrview.Columns.Count >= 14 Then
                dgrview.Columns(0).HeaderText = "كود العميل"
                dgrview.Columns(1).HeaderText = "اسم العميل"
                dgrview.Columns(2).HeaderText = "تليفون العميل"
                dgrview.Columns(3).HeaderText = "عنوان العميل"
                dgrview.Columns(4).HeaderText = "تاريخ التصوير"
                dgrview.Columns(5).HeaderText = "تاريخ التسليم"
                dgrview.Columns(6).HeaderText = "طلبات العميل"
                dgrview.Columns(7).HeaderText = "المبلغ الاجمالى"
                dgrview.Columns(8).HeaderText = "المبلغ المدفوع"
                dgrview.Columns(9).HeaderText = "المبلغ المتبقى"
                dgrview.Columns(10).HeaderText = "الخصم"
                dgrview.Columns(11).HeaderText = "ملاحظات"
                dgrview.Columns(12).HeaderText = "الموظف"
                dgrview.Columns(13).HeaderText = "حالة التسليم"
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "ستديو وفيديو طاهر")
        End Try
    End Sub

    ' تحميل الشاشة والتحقق من التفعيل
    Private Sub FrmMarrage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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

                MessageBox.Show("لم يتم تفعيل البرنامج، يرجى تفعيل البرنامج.", "ستديو وفيديو طاهر", MessageBoxButtons.OK, MessageBoxIcon.Stop)
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

    ' البحث برقم العميل
    Private Sub btnsearchunit_Click(sender As Object, e As EventArgs) Handles btnsearchunit.Click
        Try
            If String.IsNullOrWhiteSpace(txtsearchunit.Text) Then Exit Sub
            dgrview.ClearSelection()
            dv.Sort = "CusId"
            Dim index As Integer = dv.Find(txtsearchunit.Text.Trim())
            If index <> -1 Then
                cur.Position = index
                dgrview.Rows(cur.Position).Selected = True
                ShowPosition()
            Else
                MessageBox.Show("لم يتم العثور على العميل بهذا الكود", "ستديو وفيديو طاهر", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "ستديو وفيديو طاهر")
        End Try
    End Sub

    ' البحث اللحظي باسم العميل عبر الفلترة المباشرة (فائق السرعة)
    Private Sub txtcustsearch_TextChanged(sender As Object, e As EventArgs) Handles txtcustsearch.TextChanged
        Try
            If dv IsNot Nothing Then
                Dim filterText As String = txtcustsearch.Text.Trim().Replace("'", "''")
                dv.RowFilter = String.Format("Cusname LIKE '%{0}%'", filterText)
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

    ' فتح شاشة الطباعة
    Private Sub btnprinte_Click(sender As Object, e As EventArgs) Handles btnprinte.Click
        Try
            frmprintemarrage.Show()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "ستديو وفيديو طاهر")
        End Try
    End Sub

    ' منع كتابة الحروف في حقول المبالغ المالية
    Private Sub txtAllPrise_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSetPrise.KeyPress, txtsearchunit.KeyPress, txtJetPrise.KeyPress, txtgavet.KeyPress, txtAllPrise.KeyPress
        Try
            If Asc(e.KeyChar) <> 13 AndAlso Asc(e.KeyChar) <> 8 AndAlso Not Char.IsDigit(e.KeyChar) Then
                e.Handled = True
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "ستديو وفيديو طاهر")
        End Try
    End Sub

End Class