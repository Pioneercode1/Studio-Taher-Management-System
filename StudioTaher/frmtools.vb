Imports System.Data
Imports System.Data.SqlClient
Imports System.Management

Public Class frmtools
    Dim idp As String ' المعالج رقم
    Dim idp1 As String ' التسجیل رقم
    Dim idp2 As String ' التفعیل رقم
    Dim conn As New SqlConnection
    Dim ds As New DataSet
    Dim da As New SqlDataAdapter
    Public cmd As New SqlCommand
    Public Function OnlyNumeric(ByVal Key As String) As Boolean

        If (Key >= 48 And Key <= 57) Or Key = 8 Then
            OnlyNumeric = False
        Else
            OnlyNumeric = True
        End If
    End Function
    Public Function OnlyCharacter(ByVal key As String) As Boolean
        If ((key >= 65 And key <= 90) Or (key >= 97 And key <= 122) Or key = 8) Then
            OnlyCharacter = False
        Else
            OnlyCharacter = True
        End If
    End Function
    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        Try
            Me.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "ستديو وفيديو طاهر")
        End Try

    End Sub

    Private Sub btnserialok_Click(sender As Object, e As EventArgs) Handles btnserialok.Click
        Try
            If Len(Trim(TextBoxUser.Text)) = 0 Then
                MessageBox.Show("من فضلك ادخل الرقم التسلسلى", "ستديو وفيديو طاهر", MessageBoxButtons.OK, MessageBoxIcon.Error)
                TextBoxReg.Focus()
                Exit Sub
            End If
            '  جمالي متغير '
            idp2 = idp1
            If TextBoxUser.Text = idp2 Then
                '     حفظ الاعدادت
                My.Settings.nameuser = TextBoxUser.Text
                My.Settings.Save()
                MessageBox.Show("شكرا جزيلا لك على ثقتك بنا", "ستديو وفيديو طاهر")
                Labeserialsend.Visible = False
                Labeserial.Visible = False
                Labeokay.Visible = True
                TextBoxReg.Visible = False
                TextBoxUser.Visible = False
                btnserialok.Visible = False
                btnserial.Visible = False
                My.Settings.mysavety = True
                My.Settings.Save()
            Else
                MessageBox.Show("من فضلك ادخل رقم صحيح", "ستديو وفيديو طاهر", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "ستديو وفيديو طاهر")
        End Try

    End Sub
    Public Sub myconnaction2()
        Try
            conn = New SqlConnection("Data Source=.\SQLExpress; INITIAL CATALOG=StudioTaher;INTEGRATED SECURITY=True;")
            ds = New DataSet
            da = New SqlDataAdapter("select * from disgnphoto", conn)
            da.Fill(ds, "disgnphoto")
            conn.Open()
            conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message, "ستديو وفيديو طاهر")
        End Try

    End Sub


    Public Sub myconnaction()
        Try
            conn = New SqlConnection("Data Source=.\SQLExpress; INITIAL CATALOG=StudioTaher;INTEGRATED SECURITY=True;")
            ds = New DataSet
            da = New SqlDataAdapter("select * from loginAdmin", conn)
            da.Fill(ds, "loginAdmin")
            conn.Open()
        Catch ex As SqlException
            MsgBox(ex.Message, "ستديو وفيديو طاهر")
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub btnsave_Click(sender As Object, e As EventArgs) Handles btnsave.Click
        Try
            If txtPassword.Text <> txtPassword2.Text Then
                MessageBox.Show("كلمة المرور غير متطابقة", "ستديو وفيديو طاهر")
                Exit Sub
            End If
            myconnaction()
            cmd = New SqlCommand("INSERT INTO loginAdmin(UserName,Password,JobEmployee)" & _
            "VALUES('" & txtUserName.Text & "','" & txtPassword.Text & "','" & cbJobEmployee.Text & "')", conn)
            If conn.State = ConnectionState.Open Then conn.Close()
            conn.Open()
            cmd.ExecuteNonQuery()
            conn.Close()
            MessageBox.Show("تم حفظ المستخدم بنجاح", "ستديو وفيديو طاهر")
        Catch ex As Exception
            MessageBox.Show(ex.Message, "ستديو وفيديو طاهر")
        End Try

    End Sub

    Private Sub btndelete_Click(sender As Object, e As EventArgs) Handles btndelete.Click
        Try
            If txtUserName.Text = "" Then
                MessageBox.Show("من فضلك ادخل اسم المستخدم", "ستوديو وفيديو طاهر")
                Return
                txtUserName.Focus()
            End If

            If MessageBox.Show("هل انت تريد حذف هذا المستخدم", "ستوديو وفيديو طاهر", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
                myconnaction()
                cmd = New SqlCommand("DELETE FROM loginAdmin WHERE UserName ='" & txtUserName.Text & "'", conn)
                If conn.State = ConnectionState.Open Then conn.Close()
                conn.Open()
                cmd.ExecuteNonQuery()
                conn.Close()
                MessageBox.Show("تم الحذف بنجاح", "ستوديو وفيديو طاهر")
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "ستديو وفيديو طاهر")
        End Try

    End Sub
    Private Sub btnserial_Click(sender As Object, e As EventArgs) Handles btnserial.Click
        Try
            Dim Searcher As ManagementObjectSearcher
            Searcher = New ManagementObjectSearcher("Select ProcessorId From Win32_Processor")
            For Each Device As ManagementObject In Searcher.Get
                For Each Prop As PropertyData In Device.Properties
                    idp = (Prop.Value.ToString)
                Next
            Next
            idp = Obfuscate(idp)
            idp = Str2Int(idp)
            TextBoxReg.Text = idp
            idp1 = Obfuscate(idp)
            idp1 = Str2Int(idp1)
            idp1 = (idp1.Substring(0, 14))
        Catch ex As Exception
            MessageBox.Show(ex.Message, "ستديو وفيديو طاهر")
        End Try

    End Sub

    Private Sub btnaddLBsize_Click(sender As Object, e As EventArgs) Handles btnaddLBsize.Click
        Try
            If Len(Trim(txtLBsize.Text)) = 0 Then
                MessageBox.Show("من فضلك ادخل المقاس", "ستديو وفيديو طاهر", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtLBsize.Focus()
                Return
            End If
            If Len(Trim(txtcbprise.Text)) = 0 Then
                MessageBox.Show("من فضلك ادخل السعر", "ستديو وفيديو طاهر", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtcbprise.Focus()
                Return
            End If
            myconnaction2()
            cmd = New SqlCommand("INSERT INTO disgnphoto(custsize,custprise)" & _
          "VALUES('" & txtLBsize.Text & "','" & txtcbprise.Text & "')", conn)
            If conn.State = ConnectionState.Open Then conn.Close()
            conn.Open()
            cmd.ExecuteNonQuery()
            conn.Close()
            MessageBox.Show("تم حفظ الاعدادات بنجاح", "ستديو وفيديو طاهر")
            txtLBsize.Text = ""
            txtcbprise.Text = ""
        Catch ex As SqlException
            MsgBox(ex.Message, "ستديو وفيديو طاهر")
        End Try
    End Sub
    Private Sub btncleansi_Click(sender As Object, e As EventArgs) Handles btncleansi.Click
        Try
            If MessageBox.Show("هل انت تريد حذف هذا المقاس", "ستوديو وفيديو طاهر", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
                myconnaction2()
                cmd = New SqlCommand("DELETE FROM disgnphoto WHERE custsize ='" & txtLBsize.Text & "'", conn)
                If conn.State = ConnectionState.Open Then conn.Close()
                conn.Open()
                cmd.ExecuteNonQuery()
                conn.Close()
                MessageBox.Show("تم الحذف بنجاح", "ستوديو وفيديو طاهر")
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "ستديو وفيديو طاهر")
        End Try

    End Sub

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

    Private Sub txtcbprise_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtcbprise.KeyPress
        Try
            e.Handled = OnlyNumeric(Asc(e.KeyChar))
        Catch ex As Exception
            MessageBox.Show(ex.Message, "ستديو وفيديو طاهر")
        End Try

    End Sub

    Private Sub TextBoxUser_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBoxUser.KeyPress

        Try
            e.Handled = OnlyNumeric(Asc(e.KeyChar))
        Catch ex As Exception
            MessageBox.Show(ex.Message, "ستديو وفيديو طاهر")
        End Try
    End Sub

    Private Sub cbJobEmployee_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbJobEmployee.SelectedIndexChanged

    End Sub

    Private Sub TabPage4_Click(sender As Object, e As EventArgs) Handles TabPage4.Click

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub


    Private Sub Labeserialsend_Click(sender As Object, e As EventArgs) Handles Labeserialsend.Click

    End Sub

    Private Sub Labeserial_Click(sender As Object, e As EventArgs) Handles Labeserial.Click

    End Sub
End Class