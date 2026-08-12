Imports System.Data
Imports System.Data.SqlClient
Imports System.IO
Imports System.Management
Public Class FrmPhoto
    Dim Idp As String
    Dim Idp1 As String
    Dim idp2 As String
    Public Conn As New SqlConnection
    Public ds As New DataSet
    Public da As New SqlDataAdapter
    Public dv As New DataView
    Public cur As CurrencyManager
    Public cmd As New SqlCommand
    Public Sub myconnaction()
        Try
            Conn = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB; INITIAL CATALOG=StudioTaher;INTEGRATED SECURITY=True;")
            ds = New DataSet
            da = New SqlDataAdapter("select * from CustomerPhoto", Conn)
            da.Fill(ds, "CustomerPhoto")
            dv = New DataView(ds.Tables("CustomerPhoto"))
            cur = CType(Me.BindingContext(dv), CurrencyManager)
            dgrview.DataSource = dv
            Conn.Open()
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

            txtcusid.DataBindings.Add("text", dv, "CusId")
            txtcusname.DataBindings.Add("text", dv, "CusName")
            txtallprise.DataBindings.Add("text", dv, "AllPrise")
            txtcusnotes.DataBindings.Add("text", dv, "CusNotes")
            txtcusSize1.DataBindings.Add("text", dv, "CusSize")
            txtCusNum1.DataBindings.Add("text", dv, "CusUnit")
            txtgetprise.DataBindings.Add("text", dv, "JetPrise")
            txtsetprise.DataBindings.Add("text", dv, "SetPrise")
            txtCusGavet.DataBindings.Add("text", dv, "CusGavet")
            CoEmpName.DataBindings.Add("text", dv, "OrderBy")
            CoAboutOrder.DataBindings.Add("text", dv, "AboutOrder")
            DtFristDate.DataBindings.Add("Value", dv, "FriDate")
            DtTwoDate.DataBindings.Add("Value", dv, "SecDate")
            txtcusphone.DataBindings.Add("text", dv, "CusPhone")
        Catch ex As SqlException
            MessageBox.Show(ex.Message, "ستديو وفيديو طاهر")
        Finally
            Conn.Close()
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
        Catch ex As Exception
            MessageBox.Show(ex.Message)
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
    Private Sub btnnew_Click(sender As Object, e As EventArgs) Handles btnnew.Click
        Try
            ClearAllText()
            empname.Text = cuname
        Catch ex As Exception
            MessageBox.Show(ex.Message, "ستديو وفيديو طاهر")
        End Try

    End Sub

    Private Sub btnback_Click(sender As Object, e As EventArgs) Handles btnback.Click
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
    Private Sub FrmPhoto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            empname.Text = cuname
            DtFristDate.Value = Now
            DtTwoDate.Value = Now
            myconnaction()
            ShowPosition()
            'createfolderday()
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

    Private Sub btnsave_Click(sender As Object, e As EventArgs) Handles btnsave.Click
        Try
            'If Directory.Exists(My.Settings.mycreatechak & "\" & "'" & txtcusname.Text & "'") Then Return
            'Directory.CreateDirectory(My.Settings.mycreatechak & "\" & txtcusname.Text.ToString & "_" & txtcusid.Text.ToString)
            txtsetprise.Text = txtallprise.Text - txtgetprise.Text
            cmd = New SqlCommand("INSERT INTO CustomerPhoto(CusName,AllPrise,CusNotes,CusSize,CusUnit,JetPrise,SetPrise,CusGavet,OrderBy,AboutOrder,FriDate,SecDate,CusPhone)" & _
           "VALUES('" & txtcusname.Text & "','" & txtallprise.Text & "','" & txtcusnotes.Text & "','" & txtcusSize1.Text & "','" & txtCusNum1.Text & "','" & txtgetprise.Text & "','" & txtsetprise.Text & "','" & txtCusGavet.Text & "','" & empname.Text & "','" & CoAboutOrder.Text & "', '" & DtFristDate.Value.ToString("yyyy/MM/dd") & "','" & DtTwoDate.Value.ToString("yyyy/MM/dd") & "','" & txtcusphone.Text & "')", Conn)

            If Conn.State = ConnectionState.Open Then Conn.Close()
            Conn.Open()
            cmd.ExecuteNonQuery()
            Conn.Close()
            MessageBox.Show("تم الحفظ بنجاح", "ستوديو وفيديو طاهر")
            myconnaction()
            ShowPosition()
            'Process.Start(My.Settings.mycreatechak)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "ستديو وفيديو طاهر")
        End Try
    End Sub
    Private Sub btndelete_Click(sender As Object, e As EventArgs) Handles btndelete.Click
        Try
            If MessageBox.Show("هل انت تريد حذف هذا العميل", "ستوديو وفيديو طاهر", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
                cmd = New SqlCommand("DELETE FROM CustomerPhoto WHERE cusid ='" & txtcusid.Text & "'", Conn)
                If Conn.State = ConnectionState.Open Then Conn.Close()
                Conn.Open()
                cmd.ExecuteNonQuery()
                Conn.Close()

                myconnaction()
                ShowPosition()
                MessageBox.Show("تم الحذف بنجاح", "ستوديو وفيديو طاهر")
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "ستديو وفيديو طاهر")
        End Try

        'WHERE users='name' AND groups='sona
    End Sub

    Private Sub btnupdata_Click(sender As Object, e As EventArgs) Handles btnupdata.Click
        Try
            txtsetprise.Text = txtallprise.Text - txtgetprise.Text
            cmd = New SqlCommand("UPDATE CustomerPhoto SET CusName = @CusName,AllPrise = @AllPrise,CusNotes = @CusNotes,CusSize = @CusSize,CusUnit = @CusUnit,JetPrise = @JetPrise,SetPrise = @SetPrise,CusGavet = @CusGavet, OrderBy = @OrderBy,AboutOrder = @AboutOrder,FriDate = @FriDate,SecDate = @SecDate,CusPhone = @CusPhone WHERE cusid ='" & txtcusid.Text & "'", Conn)
            With cmd.Parameters
                .AddWithValue("@CusName", txtcusname.Text).DbType = DbType.String
                .AddWithValue("@AllPrise", txtallprise.Text).DbType = DbType.Double
                .AddWithValue("@CusNotes", txtcusnotes.Text).DbType = DbType.String
                .AddWithValue("@CusSize", txtcusSize1.Text).DbType = DbType.String
                .AddWithValue("@CusUnit", txtCusNum1.Text).DbType = DbType.String
                .AddWithValue("@JetPrise", txtgetprise.Text).DbType = DbType.Double
                .AddWithValue("@SetPrise", txtsetprise.Text).DbType = DbType.Double
                .AddWithValue("@CusGavet", txtCusGavet.Text).DbType = DbType.String
                .AddWithValue("@OrderBy", empname.Text).DbType = DbType.String
                .AddWithValue("@AboutOrder", CoAboutOrder.Text).DbType = DbType.String
                .AddWithValue("@FriDate", DtFristDate.Value).DbType = DbType.DateTime
                .AddWithValue("@SecDate", DtTwoDate.Value).DbType = DbType.DateTime
                .AddWithValue("@CusPhone", txtcusphone.Text).DbType = DbType.String
            End With
            If Conn.State = ConnectionState.Open Then Conn.Close()
            Conn.Open()
            cmd.ExecuteNonQuery()
            Conn.Close()
            MessageBox.Show("تم التعديل بنجاح", "ستوديو وفيديو طاهر")
            myconnaction()
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
            Conn = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB; INITIAL CATALOG=StudioTaher;INTEGRATED SECURITY=True;")
            ds = New DataSet
            da = New SqlDataAdapter(String.Format("select * from CustomerPhoto where CusName like '%{0}%'", txtcustsearch.Text), Conn)
            da.Fill(ds, "CustomerPhoto")
            dv = New DataView(ds.Tables("CustomerPhoto"))
            cur = CType(Me.BindingContext(dv), CurrencyManager)
            dgrview.DataSource = dv
            Conn.Open()
            Conn.Close()
            ShowPosition()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "ستديو وفيديو طاهر")
        End Try

    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        Try
            DtTwoDate.Value = Now
            DtTwoDate.Enabled = False
            txtsetprise.Enabled = False
            txtgetprise.Enabled = False
            txtallprise.Enabled = False
            CoAboutOrder.Text = "تم التسليم"
        Catch ex As Exception
            MessageBox.Show(ex.Message, "ستديو وفيديو طاهر")
        End Try

    End Sub

    Private Sub CheckBox1_MouseLeave(sender As Object, e As EventArgs) Handles CheckBox1.MouseLeave
        Try
            If CheckBox1.Checked = False Then
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

    Private Sub FrmPhoto_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        Try
            With dgrview
                .Columns(0).HeaderText = "كود العميل"
                .Columns(1).HeaderText = "اسم العميل"
                .Columns(2).HeaderText = "مقاس الصور"
                .Columns(3).HeaderText = "عدد الصور"
                .Columns(4).HeaderText = "المبلغ الاجمالى"
                .Columns(5).HeaderText = "المبلغ المدفوع"
                .Columns(6).HeaderText = "المبلغ المتبقى"
                .Columns(7).HeaderText = "الخصم"
                .Columns(8).HeaderText = "الموظف"
                .Columns(9).HeaderText = "حالة التسليم"
                .Columns(10).HeaderText = "تاريخ التصوير"
                .Columns(11).HeaderText = "تاريخ التسليم"
                .Columns(12).HeaderText = "ملاحظات"
                .Columns(13).HeaderText = "تليفون العميل"
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message, "ستديو وفيديو طاهر")
        End Try
        DtTwoDate.Value = Now
        DtFristDate.Value = Now

    End Sub
    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        Try
            FrmOP.Show()
            Me.Hide()
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

    Private Sub FrmPhoto_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtsetprise.KeyPress, txtsearchunit.KeyPress, txtgetprise.KeyPress, txtCusNum1.KeyPress, txtallprise.KeyPress, MyBase.KeyPress
        Try
            If Asc(e.KeyChar) <> 13 AndAlso Asc(e.KeyChar) <> 8 _
       AndAlso Not IsNumeric(e.KeyChar) Then
                e.Handled = True
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "ستديو وفيديو طاهر")
        End Try

    End Sub


    Private Sub FrmPhoto_MouseMove(sender As Object, e As MouseEventArgs) Handles Me.MouseMove
        empname.Text = cuname
    End Sub

    Private Sub DtFristDate_ValueChanged(sender As Object, e As EventArgs) Handles DtFristDate.ValueChanged

    End Sub
End Class