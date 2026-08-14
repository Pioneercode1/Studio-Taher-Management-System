Imports System.Data
Imports System.Data.SqlClient
Imports System.Management

Public Class FrmVideo

    Dim Idp As String
    Dim Idp1 As String
    Dim idp2 As String

    Public ds As New DataSet
    Public da As New SqlDataAdapter
    Public dv As New DataView
    Public cur As CurrencyManager

    ' الاتصال الرئيسي وجلب بيانات فيديو العملاء
    Public Sub myconnaction()
        Try
            Using conn As New SqlConnection(Module1.ConStr)
                ds = New DataSet()
                da = New SqlDataAdapter("SELECT * FROM CustomerVideo", conn)
                da.Fill(ds, "CustomerVideo")
            End Using

            dv = New DataView(ds.Tables("CustomerVideo"))
            cur = CType(Me.BindingContext(dv), CurrencyManager)
            dgrview.DataSource = dv

            ' تفريغ ثم إعادة ربط عناصر التحكم بالبيانات
            txtCusId.DataBindings.Clear()
            txtCusname.DataBindings.Clear()
            txtCusAdrress.DataBindings.Clear()
            txtCusNotes.DataBindings.Clear()
            txtAllPrise.DataBindings.Clear()
            txtCusPhone.DataBindings.Clear()
            txtCusOrder.DataBindings.Clear()
            txtgavet.DataBindings.Clear()
            txtJetPrise.DataBindings.Clear()
            txtSetPrise.DataBindings.Clear()
            DtFriDate.DataBindings.Clear()
            DtSecDate.DataBindings.Clear()
            cbAboutOrder.DataBindings.Clear()
            txtOrderBy.DataBindings.Clear()
            txtCameraMan.DataBindings.Clear()

            txtCusId.DataBindings.Add("Text", dv, "CusId")
            txtCusname.DataBindings.Add("Text", dv, "CusNmae")
            txtCusAdrress.DataBindings.Add("Text", dv, "CusAdrress")
            txtCusNotes.DataBindings.Add("Text", dv, "CusNotes")
            txtAllPrise.DataBindings.Add("Text", dv, "AllPrise")
            txtCusPhone.DataBindings.Add("Text", dv, "CusPhone")
            txtCusOrder.DataBindings.Add("Text", dv, "CusOrder")
            txtgavet.DataBindings.Add("Text", dv, "CusGavet")
            txtJetPrise.DataBindings.Add("Text", dv, "JetPrise")
            txtSetPrise.DataBindings.Add("Text", dv, "SetPrise")
            DtFriDate.DataBindings.Add("Value", dv, "FriDate", True, DataSourceUpdateMode.OnValidation, DateTime.Now)
            DtSecDate.DataBindings.Add("Value", dv, "SecDate", True, DataSourceUpdateMode.OnValidation, DateTime.Now)
            cbAboutOrder.DataBindings.Add("Text", dv, "AboutOrder")
            txtOrderBy.DataBindings.Add("Text", dv, "OrderBy")
            txtCameraMan.DataBindings.Add("Text", dv, "CameraMan")

        Catch ex As Exception
            MessageBox.Show(ex.Message, "ستوديو وفيديو طاهر")
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
            MessageBox.Show(ex.Message, "ستوديو وفيديو طاهر")
        End Try
    End Sub

    ' حساب المتبقى بأمان
    Private Sub CalculateRemaining()
        Dim allPrise As Decimal = 0
        Dim getPrise As Decimal = 0
        Decimal.TryParse(txtAllPrise.Text, allPrise)
        Decimal.TryParse(txtJetPrise.Text, getPrise)
        txtSetPrise.Text = (allPrise - getPrise).ToString()
    End Sub

    ' تفريغ الحقول لإضافة عمل جديد
    Public Sub ClearAllText()
        Try
            txtCusId.Clear()
            txtCusname.Clear()
            txtCusAdrress.Clear()
            txtCusNotes.Clear()
            txtAllPrise.Clear()
            txtCusPhone.Clear()
            txtCusOrder.Clear()
            txtgavet.Clear()
            txtJetPrise.Clear()
            txtSetPrise.Clear()
            cbAboutOrder.SelectedIndex = -1
            cbAboutOrder.Text = ""
            txtOrderBy.Clear()
            txtCameraMan.Clear()
            DtFriDate.Value = DateTime.Now
            DtSecDate.Value = DateTime.Now
            txtsearchunit.Clear()
            txtcustsearch.Clear()
            txtpostion.Text = "سجل جديد"
        Catch ex As Exception
            MessageBox.Show(ex.Message, "ستوديو وفيديو طاهر")
        End Try
    End Sub

    ' دوال التنقل بين السجلات
    Public Sub MoveLast()
        Try
            If cur IsNot Nothing AndAlso cur.Count > 0 Then cur.Position = cur.Count - 1
        Catch ex As Exception
            MessageBox.Show(ex.Message, "ستوديو وفيديو طاهر")
        End Try
    End Sub

    Public Sub Movepre()
        Try
            If cur IsNot Nothing AndAlso cur.Position > 0 Then cur.Position -= 1
        Catch ex As Exception
            MessageBox.Show(ex.Message, "ستوديو وفيديو طاهر")
        End Try
    End Sub

    Public Sub MoveNext()
        Try
            If cur IsNot Nothing AndAlso cur.Position < cur.Count - 1 Then cur.Position += 1
        Catch ex As Exception
            MessageBox.Show(ex.Message, "ستوديو وفيديو طاهر")
        End Try
    End Sub

    Public Sub MoveFirst()
        Try
            If cur IsNot Nothing AndAlso cur.Count > 0 Then cur.Position = 0
        Catch ex As Exception
            MessageBox.Show(ex.Message, "ستوديو وفيديو طاهر")
        End Try
    End Sub

    ' حفظ بيانات فيديو جديد
    Private Sub btnsave_Click(sender As Object, e As EventArgs) Handles btnsave.Click
        Try
            If String.IsNullOrWhiteSpace(txtCusname.Text) Then
                MessageBox.Show("من فضلك أدخل اسم العميل", "ستوديو وفيديو طاهر", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                txtCusname.Focus()
                Exit Sub
            End If

            CalculateRemaining()

            Dim query As String = "INSERT INTO CustomerVideo (CusNmae, CusAdrress, CusNotes, AllPrise, CusPhone, CusOrder, CusGavet, JetPrise, SetPrise, FriDate, SecDate, AboutOrder, OrderBy, CameraMan) " &
                                 "VALUES (@CusNmae, @CusAdrress, @CusNotes, @AllPrise, @CusPhone, @CusOrder, @CusGavet, @JetPrise, @SetPrise, @FriDate, @SecDate, @AboutOrder, @OrderBy, @CameraMan)"

            Using conn As New SqlConnection(Module1.ConStr)
                Using cmd As New SqlCommand(query, conn)
                    cmd.Parameters.Add("@CusNmae", SqlDbType.NVarChar).Value = txtCusname.Text.Trim()
                    cmd.Parameters.Add("@CusAdrress", SqlDbType.NVarChar).Value = txtCusAdrress.Text.Trim()
                    cmd.Parameters.Add("@CusNotes", SqlDbType.NVarChar).Value = txtCusNotes.Text.Trim()
                    cmd.Parameters.Add("@AllPrise", SqlDbType.Decimal).Value = If(IsNumeric(txtAllPrise.Text), Convert.ToDecimal(txtAllPrise.Text), 0)
                    cmd.Parameters.Add("@CusPhone", SqlDbType.NVarChar).Value = txtCusPhone.Text.Trim()
                    cmd.Parameters.Add("@CusOrder", SqlDbType.NVarChar).Value = txtCusOrder.Text.Trim()
                    cmd.Parameters.Add("@CusGavet", SqlDbType.NVarChar).Value = txtgavet.Text.Trim()
                    cmd.Parameters.Add("@JetPrise", SqlDbType.Decimal).Value = If(IsNumeric(txtJetPrise.Text), Convert.ToDecimal(txtJetPrise.Text), 0)
                    cmd.Parameters.Add("@SetPrise", SqlDbType.Decimal).Value = If(IsNumeric(txtSetPrise.Text), Convert.ToDecimal(txtSetPrise.Text), 0)
                    cmd.Parameters.Add("@FriDate", SqlDbType.Date).Value = DtFriDate.Value.Date
                    cmd.Parameters.Add("@SecDate", SqlDbType.Date).Value = DtSecDate.Value.Date
                    cmd.Parameters.Add("@AboutOrder", SqlDbType.NVarChar).Value = cbAboutOrder.Text.Trim()
                    cmd.Parameters.Add("@OrderBy", SqlDbType.NVarChar).Value = empname.Text.Trim()
                    cmd.Parameters.Add("@CameraMan", SqlDbType.NVarChar).Value = txtCameraMan.Text.Trim()

                    conn.Open()
                    cmd.ExecuteNonQuery()
                End Using
            End Using

            MessageBox.Show("تم الحفظ بنجاح", "ستديو وفيديو طاهر", MessageBoxButtons.OK, MessageBoxIcon.Information)
            myconnaction()
            MoveLast()
            ShowPosition()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "ستوديو وفيديو طاهر")
        End Try
    End Sub

    ' تعديل بيانات العميل
    Private Sub btnupdate_Click(sender As Object, e As EventArgs) Handles btnupdate.Click
        Try
            If String.IsNullOrWhiteSpace(txtCusId.Text) Then
                MessageBox.Show("من فضلك اختر عميلاً للتعديل", "ستوديو وفيديو طاهر", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If

            CalculateRemaining()

            Dim query As String = "UPDATE CustomerVideo SET CusNmae = @CusNmae, CusAdrress = @CusAdrress, CusNotes = @CusNotes, " &
                                 "AllPrise = @AllPrise, CusPhone = @CusPhone, CusOrder = @CusOrder, Cusgavet = @Cusgavet, " &
                                 "JetPrise = @JetPrise, SetPrise = @SetPrise, FriDate = @FriDate, SecDate = @SecDate, " &
                                 "AboutOrder = @AboutOrder, OrderBy = @OrderBy, CameraMan = @CameraMan WHERE CusId = @CusId"

            Using conn As New SqlConnection(Module1.ConStr)
                Using cmd As New SqlCommand(query, conn)
                    cmd.Parameters.Add("@CusId", SqlDbType.Int).Value = Convert.ToInt32(txtCusId.Text)
                    cmd.Parameters.Add("@CusNmae", SqlDbType.NVarChar).Value = txtCusname.Text.Trim()
                    cmd.Parameters.Add("@CusAdrress", SqlDbType.NVarChar).Value = txtCusAdrress.Text.Trim()
                    cmd.Parameters.Add("@CusNotes", SqlDbType.NVarChar).Value = txtCusNotes.Text.Trim()
                    cmd.Parameters.Add("@AllPrise", SqlDbType.Decimal).Value = If(IsNumeric(txtAllPrise.Text), Convert.ToDecimal(txtAllPrise.Text), 0)
                    cmd.Parameters.Add("@CusPhone", SqlDbType.NVarChar).Value = txtCusPhone.Text.Trim()
                    cmd.Parameters.Add("@CusOrder", SqlDbType.NVarChar).Value = txtCusOrder.Text.Trim()
                    cmd.Parameters.Add("@Cusgavet", SqlDbType.NVarChar).Value = txtgavet.Text.Trim()
                    cmd.Parameters.Add("@JetPrise", SqlDbType.Decimal).Value = If(IsNumeric(txtJetPrise.Text), Convert.ToDecimal(txtJetPrise.Text), 0)
                    cmd.Parameters.Add("@SetPrise", SqlDbType.Decimal).Value = If(IsNumeric(txtSetPrise.Text), Convert.ToDecimal(txtSetPrise.Text), 0)
                    cmd.Parameters.Add("@FriDate", SqlDbType.Date).Value = DtFriDate.Value.Date
                    cmd.Parameters.Add("@SecDate", SqlDbType.Date).Value = DtSecDate.Value.Date
                    cmd.Parameters.Add("@AboutOrder", SqlDbType.NVarChar).Value = cbAboutOrder.Text.Trim()
                    cmd.Parameters.Add("@OrderBy", SqlDbType.NVarChar).Value = empname.Text.Trim()
                    cmd.Parameters.Add("@CameraMan", SqlDbType.NVarChar).Value = txtCameraMan.Text.Trim()

                    conn.Open()
                    cmd.ExecuteNonQuery()
                End Using
            End Using

            MessageBox.Show("تم التعديل بنجاح", "ستوديو وفيديو طاهر", MessageBoxButtons.OK, MessageBoxIcon.Information)
            myconnaction()
            ShowPosition()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "ستوديو وفيديو طاهر")
        End Try
    End Sub

    ' حذف سجل عميل
    Private Sub btndelete_Click(sender As Object, e As EventArgs) Handles btndelete.Click
        Try
            If String.IsNullOrWhiteSpace(txtCusId.Text) Then
                MessageBox.Show("من فضلك اختر عميلاً لحذفه", "ستوديو وفيديو طاهر", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If

            If MessageBox.Show("هل أنت متأكد من حذف هذا العميل؟", "ستوديو وفيديو طاهر", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                Dim query As String = "DELETE FROM CustomerVideo WHERE CusId = @CusId"

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
            MessageBox.Show(ex.Message, "ستوديو وفيديو طاهر")
        End Try
    End Sub

    ' تحميل الشاشة والتحقق من التفعيل
    Private Sub FrmVideo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            empname.Text = cuname
            DtFriDate.Value = DateTime.Now
            DtSecDate.Value = DateTime.Now
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
            MessageBox.Show(ex.Message, "ستوديو وفيديو طاهر")
        End Try
    End Sub

    ' أزرار التنقل والبحث
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

    Private Sub btnnew_Click(sender As Object, e As EventArgs) Handles btnnew.Click
        ClearAllText()
        empname.Text = cuname
    End Sub

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
                MessageBox.Show("لم يتم العثور على العميل بهذا الكود", "ستوديو وفيديو طاهر", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "ستوديو وفيديو طاهر")
        End Try
    End Sub

    ' البحث اللحظي باسم العميل عبر الفلترة المباشرة
    Private Sub txtcustsearch_TextChanged(sender As Object, e As EventArgs) Handles txtcustsearch.TextChanged
        Try
            If dv IsNot Nothing Then
                Dim filterText As String = txtcustsearch.Text.Trim().Replace("'", "''")
                ' التأكد من اسم الحقل CusNmae كما هو مسجل في قاعدة البيانات
                dv.RowFilter = String.Format("CusNmae LIKE '%{0}%'", filterText)
                ShowPosition()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "ستوديو وفيديو طاهر")
        End Try
    End Sub

    ' تعيين عناوين أعمدة الجدول عند تفعيل الشاشة
    Private Sub FrmVideo_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        Try
            If dgrview.Columns.Count >= 15 Then
                dgrview.Columns(0).HeaderText = "كود العميل"
                dgrview.Columns(1).HeaderText = "اسم العميل"
                dgrview.Columns(2).HeaderText = "تليفون العميل"
                dgrview.Columns(3).HeaderText = "عنوان العميل"
                dgrview.Columns(4).HeaderText = "طلبات العميل"
                dgrview.Columns(5).HeaderText = "المبلغ الاجمالى"
                dgrview.Columns(6).HeaderText = "المبلغ المدفوع"
                dgrview.Columns(7).HeaderText = "المبلغ المتبقى"
                dgrview.Columns(8).HeaderText = "تاريخ التصوير"
                dgrview.Columns(9).HeaderText = "تاريخ التسليم"
                dgrview.Columns(10).HeaderText = "الموظف"
                dgrview.Columns(11).HeaderText = "المصورين"
                dgrview.Columns(12).HeaderText = "حالة التسليم"
                dgrview.Columns(13).HeaderText = "ملاحظات"
                dgrview.Columns(14).HeaderText = "هدية المحل"
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "ستوديو وفيديو طاهر")
        End Try
    End Sub

    ' التنقل وتقليص الشاشة
    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Try
            Me.Hide()
            FrmOP.Show()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "ستوديو وفيديو طاهر")
        End Try
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        Try
            FrmOP.Show()
            Me.Hide()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "ستوديو وفيديو طاهر")
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub btnprinte_Click(sender As Object, e As EventArgs) Handles btnprinte.Click
        Try
            frmprintevideo.Show()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "ستوديو وفيديو طاهر")
        End Try
    End Sub

    ' منع إدخال الحروف في خانات الأرقام
    Private Sub txtSetPrise_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSetPrise.KeyPress, txtsearchunit.KeyPress, txtJetPrise.KeyPress, txtAllPrise.KeyPress
        Try
            If Asc(e.KeyChar) <> 13 AndAlso Asc(e.KeyChar) <> 8 AndAlso Not Char.IsDigit(e.KeyChar) Then
                e.Handled = True
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "ستوديو وفيديو طاهر")
        End Try
    End Sub

End Class