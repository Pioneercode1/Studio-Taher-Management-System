<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmEmployee
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmEmployee))
        Me.txtEmpId = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.EmpIdPerson = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtEmpAddress = New System.Windows.Forms.TextBox()
        Me.cbEmpServise = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtEmpJop = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtEmpSchool = New System.Windows.Forms.TextBox()
        Me.txtEmpPrise = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DtworkDate = New System.Windows.Forms.DateTimePicker()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtEmpNotes = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtEmpName = New System.Windows.Forms.TextBox()
        Me.txtEmpPhone = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtpostion = New System.Windows.Forms.TextBox()
        Me.txtcustsearch = New System.Windows.Forms.TextBox()
        Me.dgrview = New System.Windows.Forms.DataGridView()
        Me.txtsearchunit = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button13 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.btnMoveLast = New System.Windows.Forms.Button()
        Me.btnMoveFirst = New System.Windows.Forms.Button()
        Me.btnMovepre = New System.Windows.Forms.Button()
        Me.btnMovenext = New System.Windows.Forms.Button()
        Me.btnprinte = New System.Windows.Forms.Button()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.btnupdate = New System.Windows.Forms.Button()
        Me.btndelete = New System.Windows.Forms.Button()
        Me.btnsave = New System.Windows.Forms.Button()
        Me.btnnew = New System.Windows.Forms.Button()
        Me.empname = New System.Windows.Forms.TextBox()
        CType(Me.dgrview, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtEmpId
        '
        resources.ApplyResources(Me.txtEmpId, "txtEmpId")
        Me.txtEmpId.Name = "txtEmpId"
        '
        'Label11
        '
        resources.ApplyResources(Me.Label11, "Label11")
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Name = "Label11"
        '
        'EmpIdPerson
        '
        resources.ApplyResources(Me.EmpIdPerson, "EmpIdPerson")
        Me.EmpIdPerson.Name = "EmpIdPerson"
        '
        'Label10
        '
        resources.ApplyResources(Me.Label10, "Label10")
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Name = "Label10"
        '
        'txtEmpAddress
        '
        resources.ApplyResources(Me.txtEmpAddress, "txtEmpAddress")
        Me.txtEmpAddress.Name = "txtEmpAddress"
        '
        'cbEmpServise
        '
        resources.ApplyResources(Me.cbEmpServise, "cbEmpServise")
        Me.cbEmpServise.FormattingEnabled = True
        Me.cbEmpServise.Items.AddRange(New Object() {resources.GetString("cbEmpServise.Items"), resources.GetString("cbEmpServise.Items1"), resources.GetString("cbEmpServise.Items2")})
        Me.cbEmpServise.Name = "cbEmpServise"
        '
        'Label9
        '
        resources.ApplyResources(Me.Label9, "Label9")
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Name = "Label9"
        '
        'txtEmpJop
        '
        resources.ApplyResources(Me.txtEmpJop, "txtEmpJop")
        Me.txtEmpJop.Name = "txtEmpJop"
        '
        'Label8
        '
        resources.ApplyResources(Me.Label8, "Label8")
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Name = "Label8"
        '
        'txtEmpSchool
        '
        resources.ApplyResources(Me.txtEmpSchool, "txtEmpSchool")
        Me.txtEmpSchool.Name = "txtEmpSchool"
        '
        'txtEmpPrise
        '
        resources.ApplyResources(Me.txtEmpPrise, "txtEmpPrise")
        Me.txtEmpPrise.Name = "txtEmpPrise"
        '
        'Label3
        '
        resources.ApplyResources(Me.Label3, "Label3")
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Name = "Label3"
        '
        'Label7
        '
        resources.ApplyResources(Me.Label7, "Label7")
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Name = "Label7"
        '
        'Label2
        '
        resources.ApplyResources(Me.Label2, "Label2")
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Name = "Label2"
        '
        'DtworkDate
        '
        resources.ApplyResources(Me.DtworkDate, "DtworkDate")
        Me.DtworkDate.Name = "DtworkDate"
        '
        'Label6
        '
        resources.ApplyResources(Me.Label6, "Label6")
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Name = "Label6"
        '
        'txtEmpNotes
        '
        resources.ApplyResources(Me.txtEmpNotes, "txtEmpNotes")
        Me.txtEmpNotes.Name = "txtEmpNotes"
        '
        'Label1
        '
        resources.ApplyResources(Me.Label1, "Label1")
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Name = "Label1"
        '
        'Label4
        '
        resources.ApplyResources(Me.Label4, "Label4")
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Name = "Label4"
        '
        'txtEmpName
        '
        resources.ApplyResources(Me.txtEmpName, "txtEmpName")
        Me.txtEmpName.Name = "txtEmpName"
        '
        'txtEmpPhone
        '
        resources.ApplyResources(Me.txtEmpPhone, "txtEmpPhone")
        Me.txtEmpPhone.Name = "txtEmpPhone"
        '
        'Label5
        '
        resources.ApplyResources(Me.Label5, "Label5")
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Name = "Label5"
        '
        'txtpostion
        '
        resources.ApplyResources(Me.txtpostion, "txtpostion")
        Me.txtpostion.Name = "txtpostion"
        Me.txtpostion.ReadOnly = True
        '
        'txtcustsearch
        '
        resources.ApplyResources(Me.txtcustsearch, "txtcustsearch")
        Me.txtcustsearch.Name = "txtcustsearch"
        '
        'dgrview
        '
        resources.ApplyResources(Me.dgrview, "dgrview")
        Me.dgrview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgrview.Name = "dgrview"
        '
        'txtsearchunit
        '
        resources.ApplyResources(Me.txtsearchunit, "txtsearchunit")
        Me.txtsearchunit.Name = "txtsearchunit"
        '
        'Button1
        '
        resources.ApplyResources(Me.Button1, "Button1")
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.Name = "Button1"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button13
        '
        resources.ApplyResources(Me.Button13, "Button13")
        Me.Button13.BackColor = System.Drawing.Color.Transparent
        Me.Button13.BackgroundImage = Global.StudioTaher.My.Resources.Resources._3
        Me.Button13.ForeColor = System.Drawing.Color.White
        Me.Button13.Name = "Button13"
        Me.Button13.UseVisualStyleBackColor = False
        '
        'Button2
        '
        resources.ApplyResources(Me.Button2, "Button2")
        Me.Button2.BackColor = System.Drawing.Color.Transparent
        Me.Button2.BackgroundImage = Global.StudioTaher.My.Resources.Resources._22
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Name = "Button2"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.BackgroundImage = Global.StudioTaher.My.Resources.Resources.Untitledححح
        resources.ApplyResources(Me.PictureBox2, "PictureBox2")
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.TabStop = False
        '
        'Label16
        '
        resources.ApplyResources(Me.Label16, "Label16")
        Me.Label16.BackColor = System.Drawing.Color.Transparent
        Me.Label16.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label16.Image = Global.StudioTaher.My.Resources.Resources.Search
        Me.Label16.Name = "Label16"
        '
        'btnMoveLast
        '
        resources.ApplyResources(Me.btnMoveLast, "btnMoveLast")
        Me.btnMoveLast.BackColor = System.Drawing.Color.Transparent
        Me.btnMoveLast.BackgroundImage = Global.StudioTaher.My.Resources.Resources.go_first
        Me.btnMoveLast.Name = "btnMoveLast"
        Me.btnMoveLast.UseVisualStyleBackColor = False
        '
        'btnMoveFirst
        '
        resources.ApplyResources(Me.btnMoveFirst, "btnMoveFirst")
        Me.btnMoveFirst.BackColor = System.Drawing.Color.Transparent
        Me.btnMoveFirst.BackgroundImage = Global.StudioTaher.My.Resources.Resources.back
        Me.btnMoveFirst.Name = "btnMoveFirst"
        Me.btnMoveFirst.UseVisualStyleBackColor = False
        '
        'btnMovepre
        '
        resources.ApplyResources(Me.btnMovepre, "btnMovepre")
        Me.btnMovepre.BackColor = System.Drawing.Color.Transparent
        Me.btnMovepre.BackgroundImage = Global.StudioTaher.My.Resources.Resources.finish
        Me.btnMovepre.Name = "btnMovepre"
        Me.btnMovepre.UseVisualStyleBackColor = False
        '
        'btnMovenext
        '
        resources.ApplyResources(Me.btnMovenext, "btnMovenext")
        Me.btnMovenext.BackColor = System.Drawing.Color.Transparent
        Me.btnMovenext.BackgroundImage = Global.StudioTaher.My.Resources.Resources._next
        Me.btnMovenext.Name = "btnMovenext"
        Me.btnMovenext.UseVisualStyleBackColor = False
        '
        'btnprinte
        '
        resources.ApplyResources(Me.btnprinte, "btnprinte")
        Me.btnprinte.BackColor = System.Drawing.Color.Transparent
        Me.btnprinte.BackgroundImage = Global.StudioTaher.My.Resources.Resources.printer__01216_
        Me.btnprinte.Name = "btnprinte"
        Me.btnprinte.UseVisualStyleBackColor = False
        '
        'Button8
        '
        resources.ApplyResources(Me.Button8, "Button8")
        Me.Button8.BackColor = System.Drawing.Color.Transparent
        Me.Button8.BackgroundImage = Global.StudioTaher.My.Resources.Resources._exit
        Me.Button8.Name = "Button8"
        Me.Button8.UseVisualStyleBackColor = False
        '
        'btnupdate
        '
        resources.ApplyResources(Me.btnupdate, "btnupdate")
        Me.btnupdate.BackColor = System.Drawing.Color.Transparent
        Me.btnupdate.BackgroundImage = Global.StudioTaher.My.Resources.Resources.xfce_graphics
        Me.btnupdate.Name = "btnupdate"
        Me.btnupdate.UseVisualStyleBackColor = False
        '
        'btndelete
        '
        resources.ApplyResources(Me.btndelete, "btndelete")
        Me.btndelete.BackColor = System.Drawing.Color.Transparent
        Me.btndelete.BackgroundImage = Global.StudioTaher.My.Resources.Resources.Actions_edit_clear_icon
        Me.btndelete.Name = "btndelete"
        Me.btndelete.UseVisualStyleBackColor = False
        '
        'btnsave
        '
        resources.ApplyResources(Me.btnsave, "btnsave")
        Me.btnsave.BackColor = System.Drawing.Color.Transparent
        Me.btnsave.BackgroundImage = Global.StudioTaher.My.Resources.Resources.save
        Me.btnsave.Name = "btnsave"
        Me.btnsave.UseVisualStyleBackColor = False
        '
        'btnnew
        '
        resources.ApplyResources(Me.btnnew, "btnnew")
        Me.btnnew.BackColor = System.Drawing.Color.Transparent
        Me.btnnew.BackgroundImage = Global.StudioTaher.My.Resources.Resources.Actions_contact_new_icon
        Me.btnnew.Name = "btnnew"
        Me.btnnew.UseVisualStyleBackColor = False
        '
        'empname
        '
        Me.empname.BorderStyle = System.Windows.Forms.BorderStyle.None
        resources.ApplyResources(Me.empname, "empname")
        Me.empname.Name = "empname"
        '
        'FrmEmployee
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gray
        Me.BackgroundImage = Global.StudioTaher.My.Resources.Resources._010
        Me.Controls.Add(Me.empname)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Button13)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.txtsearchunit)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.dgrview)
        Me.Controls.Add(Me.txtcustsearch)
        Me.Controls.Add(Me.txtpostion)
        Me.Controls.Add(Me.btnMoveLast)
        Me.Controls.Add(Me.btnMoveFirst)
        Me.Controls.Add(Me.btnMovepre)
        Me.Controls.Add(Me.btnMovenext)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtEmpId)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.EmpIdPerson)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txtEmpAddress)
        Me.Controls.Add(Me.cbEmpServise)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtEmpJop)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtEmpSchool)
        Me.Controls.Add(Me.txtEmpPrise)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.DtworkDate)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtEmpNotes)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtEmpName)
        Me.Controls.Add(Me.txtEmpPhone)
        Me.Controls.Add(Me.btnnew)
        Me.Controls.Add(Me.btnprinte)
        Me.Controls.Add(Me.Button8)
        Me.Controls.Add(Me.btnupdate)
        Me.Controls.Add(Me.btndelete)
        Me.Controls.Add(Me.btnsave)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmEmployee"
        CType(Me.dgrview, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnprinte As System.Windows.Forms.Button
    Friend WithEvents Button8 As System.Windows.Forms.Button
    Friend WithEvents btnupdate As System.Windows.Forms.Button
    Friend WithEvents btndelete As System.Windows.Forms.Button
    Friend WithEvents btnsave As System.Windows.Forms.Button
    Friend WithEvents btnnew As System.Windows.Forms.Button
    Friend WithEvents txtEmpId As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents EmpIdPerson As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtEmpAddress As System.Windows.Forms.TextBox
    Friend WithEvents cbEmpServise As System.Windows.Forms.ComboBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtEmpJop As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtEmpSchool As System.Windows.Forms.TextBox
    Friend WithEvents txtEmpPrise As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents DtworkDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtEmpNotes As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtEmpName As System.Windows.Forms.TextBox
    Friend WithEvents txtEmpPhone As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtpostion As System.Windows.Forms.TextBox
    Friend WithEvents btnMoveLast As System.Windows.Forms.Button
    Friend WithEvents btnMoveFirst As System.Windows.Forms.Button
    Friend WithEvents btnMovepre As System.Windows.Forms.Button
    Friend WithEvents btnMovenext As System.Windows.Forms.Button
    Friend WithEvents txtcustsearch As System.Windows.Forms.TextBox
    Friend WithEvents dgrview As System.Windows.Forms.DataGridView
    Friend WithEvents txtsearchunit As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents Button13 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents empname As System.Windows.Forms.TextBox
End Class
