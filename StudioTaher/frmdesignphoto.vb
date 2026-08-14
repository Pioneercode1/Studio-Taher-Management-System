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

Public Class frmdesignphoto

    Dim _value As Decimal = 0

    Public ds As New DataSet
    Public da As New SqlDataAdapter
    Public dv As New DataView
    Public cur As CurrencyManager

    ' جلب قائمة المقاسات والأسعار من قاعدة البيانات
    Public Sub myconnaction()
        Try
            Using conn As New SqlConnection(Module1.ConStr)
                ds = New DataSet()
                da = New SqlDataAdapter("SELECT * FROM disgnphoto", conn)
                da.Fill(ds, "disgnphoto")
            End Using

            dv = New DataView(ds.Tables("disgnphoto"))
            cur = CType(Me.BindingContext(dv), CurrencyManager)
            grdv.DataSource = dv

        Catch ex As Exception
            MessageBox.Show(ex.Message, "ستديو وفيديو طاهر")
        End Try
    End Sub

    ' تحميل الشاشة وربط الحقول بالجدول
    Private Sub frmdesignphoto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            myconnaction()

            txtcustprise.DataBindings.Clear()
            txtcustsize.DataBindings.Clear()

            txtcustprise.DataBindings.Add("Text", dv, "custprise")
            txtcustsize.DataBindings.Add("Text", dv, "custsize")

            ' ضبط عناوين وأحجام أعمدة الجدول
            If grdv.Columns.Count >= 2 Then
                With grdv
                    .Columns(0).HeaderText = "قائمة المقاسات"
                    .Columns(0).Width = 270
                    .Columns(1).HeaderText = "قائمة الاسعار"
                    .Columns(1).Width = 70
                End With
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "ستديو وفيديو طاهر")
        End Try
    End Sub

    ' تأكيد الاختيار وإرسال البيانات لشاشة FrmPhoto
    Private Sub btnok_Click(sender As Object, e As EventArgs) Handles btnok.Click
        Try
            ' التحقق من اختيار الكمية/العدد
            If CBunit.SelectedIndex = -1 OrElse String.IsNullOrWhiteSpace(CBunit.Text) Then
                MessageBox.Show("من فضلك اختر العدد", "ستوديو وفيديو طاهر", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                CBunit.Focus()
                Exit Sub
            End If

            ' تحويل وحساب المبالغ والكمية بأمان
            Dim unitPrice As Decimal = 0
            Dim unitCount As Integer = 0

            Decimal.TryParse(txtcustprise.Text, unitPrice)
            Integer.TryParse(CBunit.Text, unitCount)

            _value = unitPrice * unitCount

            ' 1. حساب وإضافة المبلغ الإجمالي في شاشة FrmPhoto
            Dim currentAllPrice As Decimal = 0
            Decimal.TryParse(FrmPhoto.txtallprise.Text, currentAllPrice)
            FrmPhoto.txtallprise.Text = (currentAllPrice + _value).ToString()

            ' 2. إدراج مقاس الصور في FrmPhoto
            If String.IsNullOrWhiteSpace(FrmPhoto.txtcusSize1.Text) Then
                FrmPhoto.txtcusSize1.Text = txtcustsize.Text.Trim()
            Else
                FrmPhoto.txtcusSize1.Text &= vbNewLine & txtcustsize.Text.Trim()
            End If

            ' 3. إدراج عدد الصور في FrmPhoto
            If String.IsNullOrWhiteSpace(FrmPhoto.txtCusNum1.Text) Then
                FrmPhoto.txtCusNum1.Text = CBunit.Text.Trim()
            Else
                FrmPhoto.txtCusNum1.Text &= vbNewLine & CBunit.Text.Trim()
            End If

            Me.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "ستديو وفيديو طاهر")
        End Try
    End Sub

    ' زر الإغلاق / الإلغاء
    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        Try
            Me.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "ستديو وفيديو طاهر")
        End Try
    End Sub

End Class