Imports System.Data
Imports System.Data.SqlClient

Imports System.Management
Public Class FrmEmployee
    Dim Idp As String
    Dim Idp1 As String
    Dim idp2 As String
    Dim conn As New SqlConnection
    Dim ds As New DataSet
    Dim da As New SqlDataAdapter
    Dim dv As New DataView
    Dim cur As CurrencyManager
    Public cmd As New SqlCommand

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Try
            Me.Hide()
            FrmOP.Show()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "ستديو وفيديو طاهر")
        End Try

    End Sub

    Public Sub myconnaction()
        Try
            conn = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB; INITIAL CATALOG=StudioTaher;INTEGRATED SECURITY=True;")
            ds = New DataSet
            da = New SqlDataAdapter("select * from EmployeeResource", conn)
            da.Fill(ds, "EmployeeResource")
            dv = New DataView(ds.Tables("EmployeeResource"))
            cur = CType(Me.BindingContext(dv), CurrencyManager)
            dgrview.DataSource = dv
            conn.Open()

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

            txtEmpId.DataBindings.Add("text", dv, "EmpId")
            txtEmpName.DataBindings.Add("text", dv, "EmpName")
            txtEmpNotes.DataBindings.Add("text", dv, "EmpNotes")
            txtEmpAddress.DataBindings.Add("text", dv, "EmpAddress")
            txtEmpJop.DataBindings.Add("text", dv, "EmpJop")
            txtEmpPhone.DataBindings.Add("text", dv, "EmpPhone")
            DtworkDate.DataBindings.Add("text", dv, "workDate")
            txtEmpPrise.DataBindings.Add("text", dv, "EmpPrise")
            txtEmpSchool.DataBindings.Add("text", dv, "EmpSchool")
            cbEmpServise.DataBindings.Add("text", dv, "EmpSchool")

        Catch ex As SqlException
            MsgBox(ex.Message, "ستديو وفيديو طاهر")
        Finally
            conn.Close()
        End Try
    End Sub
    Public Sub ClearAllText()
        Try
            For Each ctrl As Control In Me.Controls
                If TypeOf ctrl Is TextBox Then
                    ctrl.Text = ""
                End If
            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message, "ستديو وفيديو طاهر")
        End Try

    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles btnsave.Click
        Try
            cmd = New SqlCommand("INSERT INTO EmployeeResource(EmpName,EmpNotes,EmpAddress,EmpServise,EmpJop,EmpPhone,workDate,EmpPrise,EmpSchool)" & _
        "VALUES('" & txtEmpName.Text & "','" & txtEmpNotes.Text & "','" & txtEmpAddress.Text & "', '" & cbEmpServise.Text & "','" & txtEmpJop.Text & "','" & txtEmpPhone.Text & "','" & DtworkDate.Value.ToString("yyyy/MM/dd") & "','" & txtEmpPrise.Text & "', '" & txtEmpSchool.Text & "')", conn)
            If conn.State = ConnectionState.Open Then conn.Close()
            conn.Open()
            cmd.ExecuteNonQuery()
            conn.Close()
            MessageBox.Show("تم الحفظ بنجاح", "ستوديو وفيديو طاهر")
            myconnaction()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "ستديو وفيديو طاهر")
        End Try
    End Sub

    Private Sub btnnew_Click(sender As Object, e As EventArgs) Handles btnnew.Click
        Try
            ClearAllText()
            empname.Text = cuname
        Catch ex As Exception
            MessageBox.Show(ex.Message, "ستديو وفيديو طاهر")
        End Try

    End Sub

    Private Sub FrmEmployee_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        Try
            With dgrview
                .Columns(0).HeaderText = "كود الموظف"
                .Columns(1).HeaderText = "اسم الموظف"
                .Columns(2).HeaderText = "عنوان الموظف"
                .Columns(3).HeaderText = "تليفون الموظف"
                .Columns(4).HeaderText = "المؤهل الدراسى"
                .Columns(5).HeaderText = "الرقم القومى"
                .Columns(6).HeaderText = "صلاحيات الموظف"
                .Columns(7).HeaderText = "الموسمى الوظيفة"
                .Columns(8).HeaderText = "الراتب الشهرى"
                .Columns(9).HeaderText = "تاريخ العمل"
                .Columns(10).HeaderText = "تقيم الموظف"

            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message, "ستديو وفيديو طاهر")
        End Try

    End Sub
    Private Sub FrmEmployee_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            myconnaction()
            ShowPosition()
            empname.Text = cuname
            If My.Settings.mysavety = False Then
                Dim Searcher As ManagementObjectSearcher
                Searcher = New ManagementObjectSearcher("Select ProcessorId From Win32_Processor")
                For Each Device As ManagementObject In Searcher.Get
                    For Each Prop As PropertyData In Device.Properties
                        Idp = (Prop.Value.ToString)
                    Next
                Next
                Idp = Obfuscate(Idp)
                Idp = Str2Int(Idp)
                frmtools.TextBoxReg.Text = Idp
                Idp1 = Obfuscate(Idp)
                Idp1 = Str2Int(Idp1)
                Idp1 = (Idp1.Substring(0, 14))

                If My.Settings.nameuser = Idp1 Then
                    Return
                End If
                MessageBox.Show("لم يتم تفعيل البرنامج يرجى تفعيل البرنامج ", "ستديو وفيديو طاهر")
                Application.Exit()
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "ستديو وفيديو طاهر")
        End Try

    End Sub
    Public Sub ShowPosition()
        Try
            If cur.Count > 0 Then
                txtpostion.Text = "السجل رقم" & cur.Position + 1 & " من " & cur.Count
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "ستديو وفيديو طاهر")
        End Try

    End Sub
    Public Sub MoveLast()
        Try
            cur.Position = cur.Count - 1
            ShowPosition()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "ستديو وفيديو طاهر")
        End Try

    End Sub

    Public Sub Movepre()
        Try
            cur.Position -= 1
            ShowPosition()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "ستديو وفيديو طاهر")
        End Try

    End Sub

    Public Sub MoveNext()
        Try
            cur.Position += 1
            ShowPosition()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "ستديو وفيديو طاهر")
        End Try

    End Sub

    Public Sub MoveFirst()
        Try
            cur.Position = 0
            ShowPosition()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "ستديو وفيديو طاهر")
        End Try

    End Sub
    Private Sub btnMoveFirst_Click(sender As Object, e As EventArgs) Handles btnMoveFirst.Click
        Try
            MoveFirst()
            ShowPosition()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "ستديو وفيديو طاهر")
        End Try

    End Sub

    Private Sub btnMovenext_Click(sender As Object, e As EventArgs) Handles btnMovenext.Click
        Try
            MoveNext()
            ShowPosition()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "ستديو وفيديو طاهر")
        End Try

    End Sub

    Private Sub btnMovepre_Click(sender As Object, e As EventArgs) Handles btnMovepre.Click
        Try
            Movepre()
            ShowPosition()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "ستديو وفيديو طاهر")
        End Try

    End Sub

    Private Sub btnMoveLast_Click(sender As Object, e As EventArgs) Handles btnMoveLast.Click
        Try
            MoveLast()
            ShowPosition()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "ستديو وفيديو طاهر")
        End Try

    End Sub

    Private Sub btndelete_Click(sender As Object, e As EventArgs) Handles btndelete.Click
        Try
            If MessageBox.Show("هل انت تريد حذف هذا العميل", "ستوديو وفيديو طاهر", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
                cmd = New SqlCommand("DELETE FROM EmployeeResource WHERE EmpId ='" & txtEmpId.Text & "'", conn)
                If conn.State = ConnectionState.Open Then conn.Close()
                conn.Open()
                cmd.ExecuteNonQuery()
                conn.Close()
                myconnaction()
                ShowPosition()
                MessageBox.Show("تم الحذف بنجاح", "ستوديو وفيديو طاهر")
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "ستديو وفيديو طاهر")
        End Try

    End Sub

    Private Sub btnupdate_Click(sender As Object, e As EventArgs) Handles btnupdate.Click
        Try
            cmd = New SqlCommand("UPDATE EmployeeResource SET EmpName = @EmpName,EmpNotes = @EmpNotes,EmpAddress = @EmpAddress,EmpServise = @EmpServise,EmpJop = @EmpJop,EmpPhone = @EmpPhone,workDate = @workDate,EmpPrise = @EmpPrise,EmpSchool = @EmpSchool WHERE EmpId ='" & txtEmpId.Text & "'", conn)
            With cmd.Parameters
                .AddWithValue("@EmpName", txtEmpName.Text).DbType = DbType.String
                .AddWithValue("@EmpNotes", txtEmpNotes.Text).DbType = DbType.String
                .AddWithValue("@EmpAddress", txtEmpAddress.Text).DbType = DbType.String
                .AddWithValue("@EmpServise", cbEmpServise.Text).DbType = DbType.String
                .AddWithValue("@EmpJop", txtEmpJop.Text).DbType = DbType.String
                .AddWithValue("@EmpPhone", txtEmpPhone.Text).DbType = DbType.String
                .AddWithValue("@workDate", DtworkDate.Value).DbType = DbType.DateTime
                .AddWithValue("@EmpPrise", txtEmpPrise.Text).DbType = DbType.Double
                .AddWithValue("@EmpSchool", txtEmpSchool.Text).DbType = DbType.String
            End With
            If conn.State = ConnectionState.Open Then conn.Close()
            conn.Open()
            cmd.ExecuteNonQuery()
            conn.Close()
            MessageBox.Show("تم التعديل بنجاح", "ستوديو وفيديو طاهر")
            myconnaction()
            ShowPosition()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "ستديو وفيديو طاهر")
        End Try

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            myconnaction()
            dgrview.ClearSelection()
            dv.Sort = "EmpId"
            cur.Position = dv.Find(Convert.ToString(txtsearchunit.Text))
            dgrview.Rows(cur.Position).Selected = True
            ShowPosition()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "ستديو وفيديو طاهر")
        End Try

    End Sub

    Private Sub txtcustsearch_TextChanged(sender As Object, e As EventArgs) Handles txtcustsearch.TextChanged
        Try
            dgrview.ClearSelection()
            conn = New SqlConnection("Data Source=.\SQLExpress; INITIAL CATALOG=StudioTaher;INTEGRATED SECURITY=True;")
            ds = New DataSet
            da = New SqlDataAdapter(String.Format("select * from EmployeeResource where EmpName like '%{0}%'", txtcustsearch.Text), conn)
            da.Fill(ds, "EmployeeResource")
            dv = New DataView(ds.Tables("EmployeeResource"))
            cur = CType(Me.BindingContext(dv), CurrencyManager)
            dgrview.DataSource = dv
            conn.Open()
            conn.Close()

            ShowPosition()
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

    Private Sub btnprinte_Click(sender As Object, e As EventArgs) Handles btnprinte.Click
        Try
            frmprinteemployee.Show()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "ستديو وفيديو طاهر")
        End Try

    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        Try
            FrmOP.Show()
            Me.Hide()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "ستديو وفيديو طاهر")
        End Try

    End Sub

    Private Sub txtsearchunit_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtsearchunit.KeyPress, txtEmpPrise.KeyPress, EmpIdPerson.KeyPress
        Try
            If Asc(e.KeyChar) <> 13 AndAlso Asc(e.KeyChar) <> 8 _
           AndAlso Not IsNumeric(e.KeyChar) Then
                e.Handled = True
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "ستديو وفيديو طاهر")
        End Try

    End Sub
End Class