Imports System.Data
Imports System.Data.SqlClient
Imports System.Management
Public Class FrmMarrage
    Dim Idp As String
    Dim Idp1 As String
    Dim idp2 As String
    Dim conn As New SqlConnection
    Dim ds As New DataSet
    Dim da As New SqlDataAdapter
    Dim dv As New DataView
    Dim cur As CurrencyManager
    Public cmd As New SqlCommand
    Public Sub myconnaction()
        Try
            conn = New SqlConnection("Data Source=.\SQLExpress; INITIAL CATALOG=StudioTaher;INTEGRATED SECURITY=True;")
            ds = New DataSet
            da = New SqlDataAdapter("select * from marage", conn)
            da.Fill(ds, "marage")
            dv = New DataView(ds.Tables("marage"))
            cur = CType(Me.BindingContext(dv), CurrencyManager)
            dgrview.DataSource = dv
            conn.Open()

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

            txtCusId.DataBindings.Add("text", dv, "CusId")
            txtCusname.DataBindings.Add("text", dv, "Cusname")
            txtCusAddress.DataBindings.Add("text", dv, "CusAddress")
            txtCusNots.DataBindings.Add("text", dv, "CusNots")
            txtAllPrise.DataBindings.Add("text", dv, "AllPrise")
            txtCusPhone.DataBindings.Add("text", dv, "CusPhone")
            txtCusOrder.DataBindings.Add("text", dv, "CusOrder")
            txtgavet.DataBindings.Add("text", dv, "gavet")
            txtJetPrise.DataBindings.Add("text", dv, "JetPrise")
            txtSetPrise.DataBindings.Add("text", dv, "SetPrise")
            DtFriDate.DataBindings.Add("text", dv, "FriDate")
            DtSecDate.DataBindings.Add("text", dv, "SecDate")
            cbAboutOrder.DataBindings.Add("text", dv, "AboutOrder")

        Catch ex As SqlException
            MsgBox(ex.Message, "ستديو وفيديو طاهر")
        Finally
            conn.Close()
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
    Public Sub ClearAllText()
        Try
            For Each ctrl As Control In Me.Controls
                If TypeOf ctrl Is TextBox Then
                    ctrl.Text = ""
                End If
            Next
            txtpostion.Text = "سجل جديد"
        Catch ex As Exception
            MessageBox.Show(ex.Message, "ستديو وفيديو طاهر")
        End Try

    End Sub
    Public Sub MoveLast()

        Try
            cur.Position = cur.Count - 1
        Catch ex As Exception
            MessageBox.Show(ex.Message, "ستديو وفيديو طاهر")
        End Try
    End Sub

    Public Sub Movepre()

        Try
            cur.Position -= 1
        Catch ex As Exception
            MessageBox.Show(ex.Message, "ستديو وفيديو طاهر")
        End Try
    End Sub

    Public Sub MoveNext()

        Try
            cur.Position += 1
        Catch ex As Exception
            MessageBox.Show(ex.Message, "ستديو وفيديو طاهر")
        End Try
    End Sub

    Public Sub MoveFirst()

        Try
            cur.Position = 0
        Catch ex As Exception
            MessageBox.Show(ex.Message, "ستديو وفيديو طاهر")
        End Try
    End Sub

    Private Sub btndelete_Click(sender As Object, e As EventArgs) Handles btndelete.Click
        Try
            If MessageBox.Show("هل انت تريد حذف هذا العميل", "ستوديو وفيديو طاهر", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
                cmd = New SqlCommand("DELETE FROM marage WHERE CusId ='" & txtCusId.Text & "'", conn)
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
            cmd = New SqlCommand("UPDATE marage SET Cusname = @CusName,CusAddress = @CusAddress,CusNots = @CusNots,AllPrise = @AllPrise,CusPhone = @CusPhone,CusOrder = @CusOrder,gavet = @gavet, JetPrise = @JetPrise,SetPrise = @SetPrise,FriDate = @FriDate,SecDate = @SecDate,AboutOrder = @AboutOrder,OrderBy = @OrderBy WHERE CusId ='" & txtCusId.Text & "'", conn)
            With cmd.Parameters
                .AddWithValue("@CusName", txtCusname.Text).DbType = DbType.String
                .AddWithValue("@CusAddress", txtCusAddress.Text).DbType = DbType.String
                .AddWithValue("@CusNots", txtCusNots.Text).DbType = DbType.String
                .AddWithValue("@AllPrise", txtAllPrise.Text).DbType = DbType.Double
                .AddWithValue("@CusPhone", txtCusPhone.Text).DbType = DbType.String
                .AddWithValue("@CusOrder", txtCusOrder.Text).DbType = DbType.String
                .AddWithValue("@gavet", txtgavet.Text).DbType = DbType.String
                .AddWithValue("@JetPrise", txtJetPrise.Text).DbType = DbType.Double
                .AddWithValue("@SetPrise", txtSetPrise.Text).DbType = DbType.Double
                .AddWithValue("@FriDate", DtFriDate.Value).DbType = DbType.DateTime
                .AddWithValue("@SecDate", DtSecDate.Value).DbType = DbType.DateTime
                .AddWithValue("@AboutOrder", cbAboutOrder.Text).DbType = DbType.String
                .AddWithValue("@OrderBy", empname.Text).DbType = DbType.String
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

    Private Sub btnsave_Click(sender As Object, e As EventArgs) Handles btnsave.Click
        Try
            cmd = New SqlCommand("INSERT INTO marage(Cusname,CusAddress,CusNots,AllPrise,CusPhone,CusOrder,gavet,JetPrise,SetPrise,FriDate,SecDate,AboutOrder,OrderBy)" & _
         "VALUES('" & txtCusname.Text & "','" & txtCusAddress.Text & "','" & txtCusNots.Text & "','" & txtAllPrise.Text & "','" & txtCusPhone.Text & "','" & txtCusOrder.Text & "','" & txtgavet.Text & "','" & txtJetPrise.Text & "','" & txtSetPrise.Text & "','" & DtFriDate.Value.ToString("yyyy/MM/dd") & "','" & DtSecDate.Value.ToString("yyyy/MM/dd") & "','" & cbAboutOrder.Text & "','" & empname.Text & "')", conn)
            If conn.State = ConnectionState.Open Then conn.Close()
            conn.Open()
            cmd.ExecuteNonQuery()
            conn.Close()
            MessageBox.Show("تم الحفظ بنجاح", "ستديو وفيديو طاهر")
            myconnaction()
            ShowPosition()
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

    Private Sub FrmMarrage_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        Try
            With dgrview
                .Columns(0).HeaderText = "كود العميل"
                .Columns(1).HeaderText = "اسم العميل"
                .Columns(2).HeaderText = "تليفون العميل"
                .Columns(3).HeaderText = "عنوان العميل"
                .Columns(4).HeaderText = "تاريخ التصوير"
                .Columns(5).HeaderText = "تاريخ التسليم"
                .Columns(6).HeaderText = "طلبات العميل"
                .Columns(7).HeaderText = "المبلغ الاجمالى"
                .Columns(8).HeaderText = "المبلغ المدفوع"
                .Columns(9).HeaderText = "المبلغ المتبقى"
                .Columns(10).HeaderText = "الخصم"
                .Columns(11).HeaderText = "ملاحظات"
                .Columns(12).HeaderText = "الموظف"
                .Columns(13).HeaderText = "حالة التسليم"
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message, "ستديو وفيديو طاهر")
        End Try

    End Sub
    Private Sub FrmMarrage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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

    Private Sub btnsearchunit_Click(sender As Object, e As EventArgs) Handles btnsearchunit.Click
        Try
            myconnaction()
            dgrview.ClearSelection()
            dv.Sort = "CusId"
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
            da = New SqlDataAdapter(String.Format("select * from marage where Cusname like '%{0}%'", txtcustsearch.Text), conn)
            da.Fill(ds, "marage")
            dv = New DataView(ds.Tables("marage"))
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

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        Try
            FrmOP.Show()
            Me.Hide()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "ستديو وفيديو طاهر")
        End Try

    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Try
            FrmOP.Show()
            Me.Hide()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "ستديو وفيديو طاهر")
        End Try

    End Sub
    Private Sub btnprinte_Click(sender As Object, e As EventArgs) Handles btnprinte.Click
        Try
            frmprintemarrage.Show()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "ستديو وفيديو طاهر")
        End Try

    End Sub

    Private Sub txtAllPrise_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSetPrise.KeyPress, txtsearchunit.KeyPress, txtJetPrise.KeyPress, txtgavet.KeyPress, txtAllPrise.KeyPress
        Try
            If Asc(e.KeyChar) <> 13 AndAlso Asc(e.KeyChar) <> 8 _
        AndAlso Not IsNumeric(e.KeyChar) Then
                e.Handled = True
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "ستديو وفيديو طاهر")
        End Try

    End Sub

    Private Sub Label17_Click(sender As Object, e As EventArgs)

    End Sub
End Class