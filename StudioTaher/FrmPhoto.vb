Imports System.Data
Imports System.Data.SqlClient
Imports System.IO
Imports System.Management

Public Class FrmPhoto

    Dim Idp As String
    Dim Idp1 As String
    Dim idp2 As String

    Public ds As New DataSet
    Public da As New SqlDataAdapter
    Public dv As New DataView
    Public cur As CurrencyManager

    ' الاتصال الرئيسي وجلب بيانات تصوير العملاء
    Public Sub myconnaction()
        Try
            Using conn As New SqlConnection(Module1.ConStr)
                ds = New DataSet()
                da = New SqlDataAdapter("SELECT * FROM CustomerPhoto", conn)
                da.Fill(ds, "CustomerPhoto")
            End Using

            dv = New DataView(ds.Tables("CustomerPhoto"))
            cur = CType(Me.BindingContext(dv), CurrencyManager)
            dgrview.DataSource = dv

            ' تفريغ ثم إعادة ربط عناصر التحكم بالبيانات
            txtcusid.DataBindings.Clear()
            txtcusname.DataBindings.Clear()
            txtallprise.DataBindings.Clear()
            txtcusnotes.DataBindings.Clear()
            txtcusSize1.DataBindings.Clear()
            txtCusNum1.DataBindings.Clear()
            txtgetprise.DataBindings.Clear()
            txtsetprise.DataBindings.Clear()
            txtCusGavet.DataBindings.Clear()
            CoEmpName.DataBindings.Clear()
            CoAboutOrder.DataBindings.Clear()
            DtFristDate.DataBindings.Clear()
            DtTwoDate.DataBindings.Clear()
            txtcusphone.DataBindings.Clear()

            txtcusid.DataBindings.Add("Text", dv, "CusId")
            txtcusname.DataBindings.Add("Text", dv, "CusName")
            txtallprise.DataBindings.Add("Text", dv, "AllPrise")
            txtcusnotes.DataBindings.Add("Text", dv, "CusNotes")
            txtcusSize1.DataBindings.Add("Text", dv, "CusSize")
            txtCusNum1.DataBindings.Add("Text", dv, "CusUnit")
            txtgetprise.DataBindings.Add("Text", dv, "JetPrise")
            txtsetprise.DataBindings.Add("Text", dv, "SetPrise")
            txtCusGavet.DataBindings.Add("Text", dv, "CusGavet")
            CoEmpName.DataBindings.Add("Text", dv, "OrderBy")
            CoAboutOrder.DataBindings.Add("Text", dv, "AboutOrder")
            DtFristDate.DataBindings.Add("Value", dv, "FriDate", True, DataSourceUpdateMode.OnValidation, DateTime.Now)
            DtTwoDate.DataBindings.Add("Value", dv, "SecDate", True, DataSourceUpdateMode.OnValidation, DateTime.Now)
            txtcusphone.DataBindings.Add("Text", dv, "CusPhone")

        Catch ex As Exception
            MessageBox.Show(ex.Message, "ستديو وفيديو طاهر")
        End Try
    End Sub

    ' حساب المتبقى بأمان
    Private Sub CalculateRemaining()
        Dim allPrise As Decimal = 0
        Dim getPrise As Decimal = 0
        Decimal.TryParse(txtallprise.Text, allPrise)
        Decimal.TryParse(txtgetprise.Text, getPrise)
        txtsetprise.Text = (allPrise - getPrise).ToString()
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
        empname.Text = cuname
    End Sub

    ' تفريغ الحقول لإضافة عمل جديد
    Public Sub ClearAllText()
        Try
            txtcusid.Clear()
            txtcusname.Clear()
            txtallprise.Clear()
            txtcusnotes.Clear()
            txtcusSize1.Clear()
            txtCusNum1.Clear()
            txtgetprise.Clear()
            txtsetprise.Clear()
            txtCusGavet.Clear()
            CoAboutOrder.SelectedIndex = -1
            CoAboutOrder.Text = ""
            txtcusphone.Clear()
            DtFristDate.Value = DateTime.Now
            DtTwoDate.Value = DateTime.Now
            txtsearchunit.Clear()
            txtcustsearch.Clear()
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

    ' حفظ سجل تصوير جديد
    Private Sub btnsave_Click(sender As Object, e As EventArgs) Handles btnsave.Click
        Try
            If String.IsNullOrWhiteSpace(txtcusname.Text) Then
                MessageBox.Show("من فضلك أدخل اسم العميل", "ستديو وفيديو طاهر", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                txtcusname.Focus()
                Exit Sub
            End If

            CalculateRemaining()

            Dim query As String = "INSERT INTO CustomerPhoto (CusName, AllPrise, CusNotes, CusSize, CusUnit, JetPrise, SetPrise, CusGavet, OrderBy, AboutOrder, FriDate, SecDate, CusPhone) " &
                                 "VALUES (@CusName, @AllPrise, @CusNotes, @CusSize, @CusUnit, @JetPrise, @SetPrise, @CusGavet, @OrderBy, @AboutOrder, @FriDate, @SecDate, @CusPhone)"

            Using conn As New SqlConnection(Module1.ConStr)
                Using cmd As New SqlCommand(query, conn)
                    cmd.Parameters.Add("@CusName", SqlDbType.NVarChar).Value = txtcusname.Text.Trim()
                    cmd.Parameters.Add("@AllPrise", SqlDbType.Decimal).Value = If(IsNumeric(txtallprise.Text), Convert.ToDecimal(txtallprise.Text), 0)
                    cmd.Parameters.Add("@CusNotes", SqlDbType.NVarChar).Value = txtcusnotes.Text.Trim()
                    cmd.Parameters.Add("@CusSize", SqlDbType.NVarChar).Value = txtcusSize1.Text.Trim()
                    cmd.Parameters.Add("@CusUnit", SqlDbType.NVarChar).Value = txtCusNum1.Text.Trim()
                    cmd.Parameters.Add("@JetPrise", SqlDbType.Decimal).Value = If(IsNumeric(txtgetprise.Text), Convert.ToDecimal(txtgetprise.Text), 0)
                    cmd.Parameters.Add("@SetPrise", SqlDbType.Decimal).Value = If(IsNumeric(txtsetprise.Text), Convert.ToDecimal(txtsetprise.Text), 0)
                    cmd.Parameters.Add("@CusGavet", SqlDbType.NVarChar).Value = txtCusGavet.Text.Trim()
                    cmd.Parameters.Add("@OrderBy", SqlDbType.NVarChar).Value = empname.Text.Trim()
                    cmd.Parameters.Add("@AboutOrder", SqlDbType.NVarChar).Value = CoAboutOrder.Text.Trim()
                    cmd.Parameters.Add("@FriDate", SqlDbType.Date).Value = DtFristDate.Value.Date
                    cmd.Parameters.Add("@SecDate", SqlDbType.Date).Value = DtTwoDate.Value.Date
                    cmd.Parameters.Add("@CusPhone", SqlDbType.NVarChar).Value = txtcusphone.Text.Trim()

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

    ' تعديل بيانات العميل
    Private Sub btnupdata_Click(sender As Object, e As EventArgs) Handles btnupdata.Click
        Try
            If String.IsNullOrWhiteSpace(txtcusid.Text) Then
                MessageBox.Show("من فضلك اختر عميلاً للتعديل", "ستوديو وفيديو طاهر", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If

            CalculateRemaining()

            Dim query As String = "UPDATE CustomerPhoto SET CusName = @CusName, AllPrise = @AllPrise, CusNotes = @CusNotes, " &
                                 "CusSize = @CusSize, CusUnit = @CusUnit, JetPrise = @JetPrise, SetPrise = @SetPrise, " &
                                 "CusGavet = @CusGavet, OrderBy = @OrderBy, AboutOrder = @AboutOrder, " &
                                 "FriDate = @FriDate, SecDate = @SecDate, CusPhone = @CusPhone WHERE CusId = @CusId"

            Using conn As New SqlConnection(Module1.ConStr)
                Using cmd As New SqlCommand(query, conn)
                    cmd.Parameters.Add("@CusId", SqlDbType.Int).Value = Convert.ToInt32(txtcusid.Text)
                    cmd.Parameters.Add("@CusName", SqlDbType.NVarChar).Value = txtcusname.Text.Trim()
                    cmd.Parameters.Add("@AllPrise", SqlDbType.Decimal).Value = If(IsNumeric(txtallprise.Text), Convert.ToDecimal(txtallprise.Text), 0)
                    cmd.Parameters.Add("@CusNotes", SqlDbType.NVarChar).Value = txtcusnotes.Text.Trim()
                    cmd.Parameters.Add("@CusSize", SqlDbType.NVarChar).Value = txtcusSize1.Text.Trim()
                    cmd.Parameters.Add("@CusUnit", SqlDbType.NVarChar).Value = txtCusNum1.Text.Trim()
                    cmd.Parameters.Add("@JetPrise", SqlDbType.Decimal).Value = If(IsNumeric(txtgetprise.Text), Convert.ToDecimal(txtgetprise.Text), 0)
                    cmd.Parameters.Add("@SetPrise", SqlDbType.Decimal).Value = If(IsNumeric(txtsetprise.Text), Convert.ToDecimal(txtsetprise.Text), 0)
                    cmd.Parameters.Add("@CusGavet", SqlDbType.NVarChar).Value = txtCusGavet.Text.Trim()
                    cmd.Parameters.Add("@OrderBy", SqlDbType.NVarChar).Value = empname.Text.Trim()
                    cmd.Parameters.Add("@AboutOrder", SqlDbType.NVarChar).Value = CoAboutOrder.Text.Trim()
                    cmd.Parameters.Add("@FriDate", SqlDbType.Date).Value = DtFristDate.Value.Date
                    cmd.Parameters.Add("@SecDate", SqlDbType.Date).Value = DtTwoDate.Value.Date
                    cmd.Parameters.Add("@CusPhone", SqlDbType.NVarChar).Value = txtcusphone.Text.Trim()

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

    ' حذف سجل عميل
    Private Sub btndelete_Click(sender As Object, e As EventArgs) Handles btndelete.Click
        Try
            If String.IsNullOrWhiteSpace(txtcusid.Text) Then
                MessageBox.Show("من فضلك اختر عميلاً لحذفه", "ستوديو وفيديو طاهر", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If

            If MessageBox.Show("هل أنت متأكد من حذف هذا العميل؟", "ستوديو وفيديو طاهر", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                Dim query As String = "DELETE FROM CustomerPhoto WHERE CusId = @CusId"

                Using conn As New SqlConnection(Module1.ConStr)
                    Using cmd As New SqlCommand(query, conn)
                        cmd.Parameters.Add("@CusId", SqlDbType.Int).Value = Convert.ToInt32(txtcusid.Text)
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

    ' زر عميل جديد
    Private Sub btnnew_Click(sender As Object, e As EventArgs) Handles btnnew.Click
        Try
            ClearAllText()
            empname.Text = cuname
        Catch ex As Exception
            MessageBox.Show(ex.Message, "ستديو وفيديو طاهر")
        End Try
    End Sub

    ' تحميل الشاشة والتحقق من التفعيل
    Private Sub FrmPhoto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            empname.Text = cuname
            DtFristDate.Value = DateTime.Now
            DtTwoDate.Value = DateTime.Now
            myconnaction()
            ShowPosition()

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

    ' البحث بكود العميل
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

    ' البحث اللحظي باسم العميل عبر الفلترة المباشرة
    Private Sub txtcustsearch_TextChanged(sender As Object, e As EventArgs) Handles txtcustsearch.TextChanged
        Try
            If dv IsNot Nothing Then
                Dim filterText As String = txtcustsearch.Text.Trim().Replace("'", "''")
                dv.RowFilter = String.Format("CusName LIKE '%{0}%'", filterText)
                ShowPosition()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "ستديو وفيديو طاهر")
        End Try
    End Sub

    ' التحكم بحالة التسليم وحقول المبالغ والتاريخ
    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        Try
            If CheckBox1.Checked Then
                DtTwoDate.Value = DateTime.Now
                DtTwoDate.Enabled = False
                txtsetprise.Enabled = False
                txtgetprise.Enabled = False
                txtallprise.Enabled = False
                CoAboutOrder.Text = "تم التسليم"
            Else
                DtTwoDate.Enabled = True
                txtsetprise.Enabled = True
                txtgetprise.Enabled = True
                txtallprise.Enabled = True
                CoAboutOrder.Text = ""
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "ستديو وفيديو طاهر")
        End Try
    End Sub

    ' تعيين عناوين أعمدة الجدول عند تفعيل الشاشة
    Private Sub FrmPhoto_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        Try
            If dgrview.Columns.Count >= 14 Then
                dgrview.Columns(0).HeaderText = "كود العميل"
                dgrview.Columns(1).HeaderText = "اسم العميل"
                dgrview.Columns(2).HeaderText = "مقاس الصور"
                dgrview.Columns(3).HeaderText = "عدد الصور"
                dgrview.Columns(4).HeaderText = "المبلغ الاجمالى"
                dgrview.Columns(5).HeaderText = "المبلغ المدفوع"
                dgrview.Columns(6).HeaderText = "المبلغ المتبقى"
                dgrview.Columns(7).HeaderText = "الخصم"
                dgrview.Columns(8).HeaderText = "الموظف"
                dgrview.Columns(9).HeaderText = "حالة التسليم"
                dgrview.Columns(10).HeaderText = "تاريخ التصوير"
                dgrview.Columns(11).HeaderText = "تاريخ التسليم"
                dgrview.Columns(12).HeaderText = "ملاحظات"
                dgrview.Columns(13).HeaderText = "تليفون العميل"
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "ستديو وفيديو طاهر")
        End Try
        DtTwoDate.Value = DateTime.Now
        DtFristDate.Value = DateTime.Now
    End Sub

    ' التنقل بين الشاشات
    Private Sub btnback_Click(sender As Object, e As EventArgs) Handles btnback.Click, Button13.Click
        Try
            FrmOP.Show()
            Me.Hide()
            DtTwoDate.Enabled = True
            txtsetprise.Enabled = True
            txtgetprise.Enabled = True
            txtallprise.Enabled = True
        Catch ex As Exception
            MessageBox.Show(ex.Message, "ستديو وفيديو طاهر")
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub btnPhoto_Click(sender As Object, e As EventArgs) Handles btnPhoto.Click
        Try
            frmdesignphoto.ShowDialog()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "ستديو وفيديو طاهر")
        End Try
    End Sub

    Private Sub btnprinte_Click(sender As Object, e As EventArgs) Handles btnprinte.Click
        Try
            frmprintphoto.Show()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "ستديو وفيديو طاهر")
        End Try
    End Sub

    ' السماح بالأرقام والمسح فقط في الحقول الرقمية
    Private Sub FrmPhoto_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtsetprise.KeyPress, txtsearchunit.KeyPress, txtgetprise.KeyPress, txtCusNum1.KeyPress, txtallprise.KeyPress
        Try
            If Asc(e.KeyChar) <> 13 AndAlso Asc(e.KeyChar) <> 8 AndAlso Not Char.IsDigit(e.KeyChar) Then
                e.Handled = True
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "ستديو وفيديو طاهر")
        End Try
    End Sub

    Private Sub FrmPhoto_MouseMove(sender As Object, e As MouseEventArgs) Handles Me.MouseMove
        empname.Text = cuname
    End Sub

End Class