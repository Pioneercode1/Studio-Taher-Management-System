Imports System.Data
Imports System.Data.SqlClient
Public Class frmdesignphoto
    Dim _value As Integer
    Public Conn As New SqlConnection
    Public ds As New DataSet
    Public da As New SqlDataAdapter
    Public dv As New DataView
    Public cur As CurrencyManager
    Private Sub btnok_Click(sender As Object, e As EventArgs) Handles btnok.Click
        Try
            If CBunit.SelectedIndex = -1 Then
                MessageBox.Show("من فضلك اختر العدد", "ستوديو وفيديو طاهر")
                Return
            End If
            _value = txtcustprise.Text * CBunit.Text
            If FrmPhoto.txtallprise.Text = "" Then
                FrmPhoto.txtallprise.Text = +_value
            Else
                FrmPhoto.txtallprise.Text = FrmPhoto.txtallprise.Text + _value
            End If
            If FrmPhoto.txtcusSize1.Text = "" Then
                FrmPhoto.txtcusSize1.Text = txtcustsize.Text
            Else
                FrmPhoto.txtcusSize1.Text = FrmPhoto.txtcusSize1.Text & vbNewLine & txtcustsize.Text
            End If
            If FrmPhoto.txtCusNum1.Text = "" Then
                FrmPhoto.txtCusNum1.Text = CBunit.Text
            Else
                FrmPhoto.txtCusNum1.Text = FrmPhoto.txtCusNum1.Text & vbNewLine & CBunit.Text
            End If
            Me.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "ستديو وفيديو طاهر")
        End Try

    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        Try
            Me.Hide()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "ستديو وفيديو طاهر")
        End Try

    End Sub
    Public Sub myconnaction()
        Try
            Conn = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB; INITIAL CATALOG=StudioTaher;INTEGRATED SECURITY=True;")
            ds = New DataSet
            da = New SqlDataAdapter("select * from disgnphoto", Conn)
            da.Fill(ds, "disgnphoto")
            dv = New DataView(ds.Tables("disgnphoto"))
            cur = CType(Me.BindingContext(dv), CurrencyManager)
            grdv.DataSource = dv
            Conn.Open()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "ستديو وفيديو طاهر")
        End Try
    End Sub

    Private Sub frmdesignphoto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            myconnaction()
            txtcustprise.DataBindings.Clear()
            txtcustsize.DataBindings.Clear()
            txtcustprise.DataBindings.Add("text", dv, "custprise")
            txtcustsize.DataBindings.Add("text", dv, "custsize")
            With grdv
                .Columns(0).HeaderText = "قائمة المقاسات"
                .Columns(0).Width = 270
                .Columns(1).HeaderText = "قائمة الاسعار"
                .Columns(1).Width = 70
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message, "ستديو وفيديو طاهر")
        End Try


    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub txtcustsize_TextChanged(sender As Object, e As EventArgs) Handles txtcustsize.TextChanged

    End Sub

    Private Sub txtcustprise_TextChanged(sender As Object, e As EventArgs) Handles txtcustprise.TextChanged

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub
End Class