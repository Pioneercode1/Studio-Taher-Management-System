<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmPhoto
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmPhoto))
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtcusname = New System.Windows.Forms.TextBox()
        Me.txtcusid = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.DtFristDate = New System.Windows.Forms.DateTimePicker()
        Me.DtTwoDate = New System.Windows.Forms.DateTimePicker()
        Me.dgrview = New System.Windows.Forms.DataGridView()
        Me.txtcusnotes = New System.Windows.Forms.TextBox()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.btnPhoto = New System.Windows.Forms.ToolStripButton()
        Me.label55 = New System.Windows.Forms.Label()
        Me.txtcusSize1 = New System.Windows.Forms.TextBox()
        Me.txtCusNum1 = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtallprise = New System.Windows.Forms.TextBox()
        Me.txtgetprise = New System.Windows.Forms.TextBox()
        Me.txtsetprise = New System.Windows.Forms.TextBox()
        Me.txtCusGavet = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.CoAboutOrder = New System.Windows.Forms.ComboBox()
        Me.txtcusphone = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtpostion = New System.Windows.Forms.TextBox()
        Me.btnback = New System.Windows.Forms.Button()
        Me.btndelete = New System.Windows.Forms.Button()
        Me.btnprinte = New System.Windows.Forms.Button()
        Me.btnsave = New System.Windows.Forms.Button()
        Me.btnupdata = New System.Windows.Forms.Button()
        Me.btnnew = New System.Windows.Forms.Button()
        Me.btnMoveLast = New System.Windows.Forms.Button()
        Me.btnMovepre = New System.Windows.Forms.Button()
        Me.btnMoveFirst = New System.Windows.Forms.Button()
        Me.btnMovenext = New System.Windows.Forms.Button()
        Me.txtcustsearch = New System.Windows.Forms.TextBox()
        Me.btnsearchunit = New System.Windows.Forms.Button()
        Me.txtsearchunit = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Button13 = New System.Windows.Forms.Button()
        Me.CoEmpName = New System.Windows.Forms.TextBox()
        Me.empname = New System.Windows.Forms.TextBox()
        CType(Me.dgrview, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label11
        '
        Me.Label11.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Location = New System.Drawing.Point(191, 232)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(97, 19)
        Me.Label11.TabIndex = 50
        Me.Label11.Text = "اسم الموظف"
        '
        'txtcusname
        '
        Me.txtcusname.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtcusname.Location = New System.Drawing.Point(783, 98)
        Me.txtcusname.MaxLength = 50
        Me.txtcusname.Name = "txtcusname"
        Me.txtcusname.Size = New System.Drawing.Size(280, 27)
        Me.txtcusname.TabIndex = 1
        '
        'txtcusid
        '
        Me.txtcusid.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtcusid.Enabled = False
        Me.txtcusid.Location = New System.Drawing.Point(128, 72)
        Me.txtcusid.Name = "txtcusid"
        Me.txtcusid.Size = New System.Drawing.Size(126, 27)
        Me.txtcusid.TabIndex = 48
        Me.txtcusid.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label9
        '
        Me.Label9.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Location = New System.Drawing.Point(444, 256)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(89, 19)
        Me.Label9.TabIndex = 47
        Me.Label9.Text = "تاريخ التصوير"
        '
        'Label8
        '
        Me.Label8.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Location = New System.Drawing.Point(433, 308)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(100, 19)
        Me.Label8.TabIndex = 46
        Me.Label8.Text = "تاريخ الاستلام"
        '
        'Label7
        '
        Me.Label7.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Location = New System.Drawing.Point(180, 50)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(78, 19)
        Me.Label7.TabIndex = 45
        Me.Label7.Text = "رقم الوصل"
        '
        'Label6
        '
        Me.Label6.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Location = New System.Drawing.Point(975, 76)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(90, 19)
        Me.Label6.TabIndex = 44
        Me.Label6.Text = "اسم العميل"
        '
        'Label5
        '
        Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Location = New System.Drawing.Point(811, 268)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(68, 19)
        Me.Label5.TabIndex = 43
        Me.Label5.Text = "ملاحظات"
        '
        'DtFristDate
        '
        Me.DtFristDate.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DtFristDate.CustomFormat = "yyyy/MM/dd 00:00"
        Me.DtFristDate.Location = New System.Drawing.Point(333, 278)
        Me.DtFristDate.MaxDate = New Date(2030, 1, 31, 0, 0, 0, 0)
        Me.DtFristDate.MinDate = New Date(2016, 1, 1, 0, 0, 0, 0)
        Me.DtFristDate.Name = "DtFristDate"
        Me.DtFristDate.Size = New System.Drawing.Size(200, 27)
        Me.DtFristDate.TabIndex = 9
        Me.DtFristDate.Value = New Date(2017, 7, 14, 0, 0, 0, 0)
        '
        'DtTwoDate
        '
        Me.DtTwoDate.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DtTwoDate.CustomFormat = "yyyy/MM/dd 00:00"
        Me.DtTwoDate.Location = New System.Drawing.Point(333, 330)
        Me.DtTwoDate.Name = "DtTwoDate"
        Me.DtTwoDate.Size = New System.Drawing.Size(200, 27)
        Me.DtTwoDate.TabIndex = 10
        '
        'dgrview
        '
        Me.dgrview.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgrview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgrview.Location = New System.Drawing.Point(-2, 378)
        Me.dgrview.Name = "dgrview"
        Me.dgrview.Size = New System.Drawing.Size(1095, 259)
        Me.dgrview.TabIndex = 40
        '
        'txtcusnotes
        '
        Me.txtcusnotes.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtcusnotes.Location = New System.Drawing.Point(554, 290)
        Me.txtcusnotes.MaxLength = 300
        Me.txtcusnotes.Multiline = True
        Me.txtcusnotes.Name = "txtcusnotes"
        Me.txtcusnotes.Size = New System.Drawing.Size(321, 71)
        Me.txtcusnotes.TabIndex = 12
        Me.txtcusnotes.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.ToolStrip1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnPhoto})
        Me.ToolStrip1.Location = New System.Drawing.Point(907, 41)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(184, 28)
        Me.ToolStrip1.TabIndex = 3
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'btnPhoto
        '
        Me.btnPhoto.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.btnPhoto.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnPhoto.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnPhoto.Name = "btnPhoto"
        Me.btnPhoto.Size = New System.Drawing.Size(172, 25)
        Me.btnPhoto.Text = "قائمة المقاسات والاسعار"
        '
        'label55
        '
        Me.label55.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.label55.AutoSize = True
        Me.label55.BackColor = System.Drawing.Color.Transparent
        Me.label55.Location = New System.Drawing.Point(801, 144)
        Me.label55.Name = "label55"
        Me.label55.Size = New System.Drawing.Size(136, 19)
        Me.label55.TabIndex = 53
        Me.label55.Text = "المقاسات المطلوبة"
        '
        'txtcusSize1
        '
        Me.txtcusSize1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtcusSize1.Location = New System.Drawing.Point(677, 169)
        Me.txtcusSize1.MaxLength = 300
        Me.txtcusSize1.Multiline = True
        Me.txtcusSize1.Name = "txtcusSize1"
        Me.txtcusSize1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtcusSize1.Size = New System.Drawing.Size(256, 85)
        Me.txtcusSize1.TabIndex = 4
        Me.txtcusSize1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtCusNum1
        '
        Me.txtCusNum1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtCusNum1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCusNum1.Location = New System.Drawing.Point(553, 169)
        Me.txtCusNum1.MaxLength = 50
        Me.txtCusNum1.Multiline = True
        Me.txtCusNum1.Name = "txtCusNum1"
        Me.txtCusNum1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtCusNum1.Size = New System.Drawing.Size(94, 85)
        Me.txtCusNum1.TabIndex = 11
        Me.txtCusNum1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label10
        '
        Me.Label10.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Location = New System.Drawing.Point(609, 144)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(42, 19)
        Me.Label10.TabIndex = 58
        Me.Label10.Text = "العدد"
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(954, 293)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(115, 19)
        Me.Label1.TabIndex = 63
        Me.Label1.Text = "المبلغ الاجمالى"
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(963, 166)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(106, 19)
        Me.Label2.TabIndex = 64
        Me.Label2.Text = "المبلغ المدفوع"
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Location = New System.Drawing.Point(958, 232)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(109, 19)
        Me.Label4.TabIndex = 66
        Me.Label4.Text = "المبلغ المتبقى"
        '
        'txtallprise
        '
        Me.txtallprise.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtallprise.Location = New System.Drawing.Point(965, 315)
        Me.txtallprise.MaxLength = 8
        Me.txtallprise.Name = "txtallprise"
        Me.txtallprise.Size = New System.Drawing.Size(100, 27)
        Me.txtallprise.TabIndex = 5
        Me.txtallprise.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtgetprise
        '
        Me.txtgetprise.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtgetprise.Location = New System.Drawing.Point(963, 188)
        Me.txtgetprise.MaxLength = 8
        Me.txtgetprise.Name = "txtgetprise"
        Me.txtgetprise.Size = New System.Drawing.Size(100, 27)
        Me.txtgetprise.TabIndex = 6
        Me.txtgetprise.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtsetprise
        '
        Me.txtsetprise.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtsetprise.Enabled = False
        Me.txtsetprise.Location = New System.Drawing.Point(963, 254)
        Me.txtsetprise.MaxLength = 8
        Me.txtsetprise.Name = "txtsetprise"
        Me.txtsetprise.Size = New System.Drawing.Size(100, 27)
        Me.txtsetprise.TabIndex = 8
        Me.txtsetprise.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtCusGavet
        '
        Me.txtCusGavet.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtCusGavet.Location = New System.Drawing.Point(315, 174)
        Me.txtCusGavet.MaxLength = 50
        Me.txtCusGavet.Multiline = True
        Me.txtCusGavet.Name = "txtCusGavet"
        Me.txtCusGavet.Size = New System.Drawing.Size(187, 55)
        Me.txtCusGavet.TabIndex = 13
        Me.txtCusGavet.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label12
        '
        Me.Label12.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Location = New System.Drawing.Point(457, 152)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(49, 19)
        Me.Label12.TabIndex = 81
        Me.Label12.Text = "الهدية"
        '
        'CoAboutOrder
        '
        Me.CoAboutOrder.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CoAboutOrder.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
        Me.CoAboutOrder.FormattingEnabled = True
        Me.CoAboutOrder.Location = New System.Drawing.Point(98, 330)
        Me.CoAboutOrder.MaxLength = 20
        Me.CoAboutOrder.Name = "CoAboutOrder"
        Me.CoAboutOrder.Size = New System.Drawing.Size(200, 27)
        Me.CoAboutOrder.TabIndex = 15
        '
        'txtcusphone
        '
        Me.txtcusphone.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtcusphone.Location = New System.Drawing.Point(433, 101)
        Me.txtcusphone.MaxLength = 30
        Me.txtcusphone.Name = "txtcusphone"
        Me.txtcusphone.Size = New System.Drawing.Size(253, 27)
        Me.txtcusphone.TabIndex = 2
        Me.txtcusphone.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label13
        '
        Me.Label13.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Location = New System.Drawing.Point(589, 72)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(101, 19)
        Me.Label13.TabIndex = 83
        Me.Label13.Text = "تليفون العميل"
        '
        'Label14
        '
        Me.Label14.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.Location = New System.Drawing.Point(205, 308)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(99, 19)
        Me.Label14.TabIndex = 85
        Me.Label14.Text = "حالة التسليم"
        '
        'txtpostion
        '
        Me.txtpostion.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtpostion.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtpostion.Location = New System.Drawing.Point(728, 643)
        Me.txtpostion.Name = "txtpostion"
        Me.txtpostion.ReadOnly = True
        Me.txtpostion.Size = New System.Drawing.Size(252, 23)
        Me.txtpostion.TabIndex = 90
        Me.txtpostion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnback
        '
        Me.btnback.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnback.BackColor = System.Drawing.Color.Transparent
        Me.btnback.BackgroundImage = Global.StudioTaher.My.Resources.Resources._exit
        Me.btnback.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnback.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnback.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnback.Location = New System.Drawing.Point(589, 675)
        Me.btnback.Name = "btnback"
        Me.btnback.Size = New System.Drawing.Size(75, 38)
        Me.btnback.TabIndex = 21
        Me.btnback.UseVisualStyleBackColor = False
        '
        'btndelete
        '
        Me.btndelete.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btndelete.BackColor = System.Drawing.Color.Transparent
        Me.btndelete.BackgroundImage = Global.StudioTaher.My.Resources.Resources.Actions_edit_clear_icon
        Me.btndelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btndelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btndelete.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btndelete.Location = New System.Drawing.Point(762, 675)
        Me.btndelete.Name = "btndelete"
        Me.btndelete.Size = New System.Drawing.Size(75, 38)
        Me.btndelete.TabIndex = 19
        Me.btndelete.Text = "حذف"
        Me.btndelete.UseVisualStyleBackColor = False
        '
        'btnprinte
        '
        Me.btnprinte.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnprinte.BackColor = System.Drawing.Color.Transparent
        Me.btnprinte.BackgroundImage = Global.StudioTaher.My.Resources.Resources.printer__01216_
        Me.btnprinte.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnprinte.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnprinte.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnprinte.Location = New System.Drawing.Point(681, 675)
        Me.btnprinte.Name = "btnprinte"
        Me.btnprinte.Size = New System.Drawing.Size(75, 38)
        Me.btnprinte.TabIndex = 20
        Me.btnprinte.Text = "الفاتورة"
        Me.btnprinte.UseVisualStyleBackColor = False
        '
        'btnsave
        '
        Me.btnsave.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnsave.BackColor = System.Drawing.Color.Transparent
        Me.btnsave.BackgroundImage = Global.StudioTaher.My.Resources.Resources.save
        Me.btnsave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnsave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnsave.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsave.Location = New System.Drawing.Point(924, 675)
        Me.btnsave.Name = "btnsave"
        Me.btnsave.Size = New System.Drawing.Size(75, 38)
        Me.btnsave.TabIndex = 17
        Me.btnsave.Text = "حفظ"
        Me.btnsave.UseVisualStyleBackColor = False
        '
        'btnupdata
        '
        Me.btnupdata.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnupdata.BackColor = System.Drawing.Color.Transparent
        Me.btnupdata.BackgroundImage = Global.StudioTaher.My.Resources.Resources.xfce_graphics
        Me.btnupdata.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnupdata.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnupdata.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnupdata.Location = New System.Drawing.Point(843, 675)
        Me.btnupdata.Name = "btnupdata"
        Me.btnupdata.Size = New System.Drawing.Size(75, 38)
        Me.btnupdata.TabIndex = 18
        Me.btnupdata.Text = "تعديل"
        Me.btnupdata.UseVisualStyleBackColor = False
        '
        'btnnew
        '
        Me.btnnew.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnnew.BackColor = System.Drawing.Color.Transparent
        Me.btnnew.BackgroundImage = Global.StudioTaher.My.Resources.Resources.Actions_contact_new_icon
        Me.btnnew.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnnew.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnnew.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnnew.Location = New System.Drawing.Point(1005, 675)
        Me.btnnew.Name = "btnnew"
        Me.btnnew.Size = New System.Drawing.Size(75, 38)
        Me.btnnew.TabIndex = 16
        Me.btnnew.Text = "جديد"
        Me.btnnew.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnnew.UseVisualStyleBackColor = False
        '
        'btnMoveLast
        '
        Me.btnMoveLast.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMoveLast.BackColor = System.Drawing.Color.Transparent
        Me.btnMoveLast.BackgroundImage = Global.StudioTaher.My.Resources.Resources.go_first
        Me.btnMoveLast.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnMoveLast.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMoveLast.Location = New System.Drawing.Point(626, 644)
        Me.btnMoveLast.Name = "btnMoveLast"
        Me.btnMoveLast.Size = New System.Drawing.Size(45, 23)
        Me.btnMoveLast.TabIndex = 27
        Me.btnMoveLast.UseVisualStyleBackColor = False
        '
        'btnMovepre
        '
        Me.btnMovepre.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMovepre.BackColor = System.Drawing.Color.Transparent
        Me.btnMovepre.BackgroundImage = Global.StudioTaher.My.Resources.Resources.back
        Me.btnMovepre.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnMovepre.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMovepre.Location = New System.Drawing.Point(677, 644)
        Me.btnMovepre.Name = "btnMovepre"
        Me.btnMovepre.Size = New System.Drawing.Size(45, 23)
        Me.btnMovepre.TabIndex = 26
        Me.btnMovepre.UseVisualStyleBackColor = False
        '
        'btnMoveFirst
        '
        Me.btnMoveFirst.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMoveFirst.BackColor = System.Drawing.Color.Transparent
        Me.btnMoveFirst.BackgroundImage = Global.StudioTaher.My.Resources.Resources.finish
        Me.btnMoveFirst.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnMoveFirst.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMoveFirst.Location = New System.Drawing.Point(1037, 643)
        Me.btnMoveFirst.Name = "btnMoveFirst"
        Me.btnMoveFirst.Size = New System.Drawing.Size(45, 23)
        Me.btnMoveFirst.TabIndex = 24
        Me.btnMoveFirst.UseVisualStyleBackColor = False
        '
        'btnMovenext
        '
        Me.btnMovenext.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMovenext.BackColor = System.Drawing.Color.Transparent
        Me.btnMovenext.BackgroundImage = Global.StudioTaher.My.Resources.Resources._next
        Me.btnMovenext.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnMovenext.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMovenext.Location = New System.Drawing.Point(986, 643)
        Me.btnMovenext.Name = "btnMovenext"
        Me.btnMovenext.Size = New System.Drawing.Size(45, 24)
        Me.btnMovenext.TabIndex = 25
        Me.btnMovenext.UseVisualStyleBackColor = False
        '
        'txtcustsearch
        '
        Me.txtcustsearch.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtcustsearch.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcustsearch.Location = New System.Drawing.Point(333, 644)
        Me.txtcustsearch.MaxLength = 50
        Me.txtcustsearch.Name = "txtcustsearch"
        Me.txtcustsearch.Size = New System.Drawing.Size(214, 23)
        Me.txtcustsearch.TabIndex = 22
        Me.txtcustsearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnsearchunit
        '
        Me.btnsearchunit.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnsearchunit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnsearchunit.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsearchunit.Location = New System.Drawing.Point(231, 644)
        Me.btnsearchunit.Name = "btnsearchunit"
        Me.btnsearchunit.Size = New System.Drawing.Size(90, 24)
        Me.btnsearchunit.TabIndex = 164
        Me.btnsearchunit.Text = "بحث برقم الوصل"
        Me.btnsearchunit.UseVisualStyleBackColor = True
        '
        'txtsearchunit
        '
        Me.txtsearchunit.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtsearchunit.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtsearchunit.Location = New System.Drawing.Point(98, 644)
        Me.txtsearchunit.Name = "txtsearchunit"
        Me.txtsearchunit.Size = New System.Drawing.Size(125, 23)
        Me.txtsearchunit.TabIndex = 23
        Me.txtsearchunit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label16
        '
        Me.Label16.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label16.AutoSize = True
        Me.Label16.BackColor = System.Drawing.Color.Transparent
        Me.Label16.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label16.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Image = Global.StudioTaher.My.Resources.Resources.Search
        Me.Label16.Location = New System.Drawing.Point(553, 645)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(62, 13)
        Me.Label16.TabIndex = 167
        Me.Label16.Text = "بحث بالاسم"
        '
        'CheckBox1
        '
        Me.CheckBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.BackColor = System.Drawing.Color.Transparent
        Me.CheckBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CheckBox1.Location = New System.Drawing.Point(180, 105)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(98, 23)
        Me.CheckBox1.TabIndex = 168
        Me.CheckBox1.Text = "تصوير فورى"
        Me.CheckBox1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button2.BackColor = System.Drawing.Color.Transparent
        Me.Button2.BackgroundImage = Global.StudioTaher.My.Resources.Resources._22
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Button2.ForeColor = System.Drawing.Color.Transparent
        Me.Button2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Button2.Location = New System.Drawing.Point(990, 2)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(43, 34)
        Me.Button2.TabIndex = 30
        Me.Button2.UseVisualStyleBackColor = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.BackgroundImage = Global.StudioTaher.My.Resources.Resources.Untitledff
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.PictureBox2.Location = New System.Drawing.Point(12, 50)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(87, 79)
        Me.PictureBox2.TabIndex = 176
        Me.PictureBox2.TabStop = False
        '
        'Button13
        '
        Me.Button13.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button13.BackColor = System.Drawing.Color.Transparent
        Me.Button13.BackgroundImage = Global.StudioTaher.My.Resources.Resources._3
        Me.Button13.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button13.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button13.ForeColor = System.Drawing.Color.White
        Me.Button13.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Button13.Location = New System.Drawing.Point(1039, 2)
        Me.Button13.Name = "Button13"
        Me.Button13.Size = New System.Drawing.Size(43, 34)
        Me.Button13.TabIndex = 28
        Me.Button13.UseVisualStyleBackColor = False
        '
        'CoEmpName
        '
        Me.CoEmpName.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.CoEmpName.Enabled = False
        Me.CoEmpName.Location = New System.Drawing.Point(149, 255)
        Me.CoEmpName.Name = "CoEmpName"
        Me.CoEmpName.Size = New System.Drawing.Size(135, 20)
        Me.CoEmpName.TabIndex = 177
        '
        'empname
        '
        Me.empname.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.empname.Enabled = False
        Me.empname.Location = New System.Drawing.Point(12, 693)
        Me.empname.Name = "empname"
        Me.empname.Size = New System.Drawing.Size(104, 20)
        Me.empname.TabIndex = 178
        '
        'FrmPhoto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gray
        Me.BackgroundImage = Global.StudioTaher.My.Resources.Resources._010
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1092, 717)
        Me.Controls.Add(Me.empname)
        Me.Controls.Add(Me.CoEmpName)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Button13)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.txtsearchunit)
        Me.Controls.Add(Me.btnsearchunit)
        Me.Controls.Add(Me.txtcustsearch)
        Me.Controls.Add(Me.btnback)
        Me.Controls.Add(Me.btndelete)
        Me.Controls.Add(Me.btnprinte)
        Me.Controls.Add(Me.btnsave)
        Me.Controls.Add(Me.btnupdata)
        Me.Controls.Add(Me.btnnew)
        Me.Controls.Add(Me.txtpostion)
        Me.Controls.Add(Me.btnMoveLast)
        Me.Controls.Add(Me.btnMovepre)
        Me.Controls.Add(Me.btnMoveFirst)
        Me.Controls.Add(Me.btnMovenext)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.txtcusphone)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.CoAboutOrder)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.txtCusGavet)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtallprise)
        Me.Controls.Add(Me.txtgetprise)
        Me.Controls.Add(Me.txtsetprise)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txtCusNum1)
        Me.Controls.Add(Me.label55)
        Me.Controls.Add(Me.txtcusSize1)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.txtcusname)
        Me.Controls.Add(Me.txtcusid)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.DtFristDate)
        Me.Controls.Add(Me.DtTwoDate)
        Me.Controls.Add(Me.dgrview)
        Me.Controls.Add(Me.txtcusnotes)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "FrmPhoto"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "شاشة الصور"
        CType(Me.dgrview, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtcusname As System.Windows.Forms.TextBox
    Friend WithEvents txtcusid As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents DtFristDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents DtTwoDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents dgrview As System.Windows.Forms.DataGridView
    Friend WithEvents txtcusnotes As System.Windows.Forms.TextBox
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents btnPhoto As System.Windows.Forms.ToolStripButton
    Friend WithEvents label55 As System.Windows.Forms.Label
    Friend WithEvents txtcusSize1 As System.Windows.Forms.TextBox
    Friend WithEvents txtCusNum1 As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtallprise As System.Windows.Forms.TextBox
    Friend WithEvents txtgetprise As System.Windows.Forms.TextBox
    Friend WithEvents txtsetprise As System.Windows.Forms.TextBox
    Friend WithEvents btnprinte As System.Windows.Forms.Button
    Friend WithEvents btnback As System.Windows.Forms.Button
    Friend WithEvents btnupdata As System.Windows.Forms.Button
    Friend WithEvents btndelete As System.Windows.Forms.Button
    Friend WithEvents btnnew As System.Windows.Forms.Button
    Friend WithEvents btnsave As System.Windows.Forms.Button
    Friend WithEvents txtCusGavet As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents CoAboutOrder As System.Windows.Forms.ComboBox
    Friend WithEvents txtcusphone As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents btnMovenext As System.Windows.Forms.Button
    Friend WithEvents btnMoveFirst As System.Windows.Forms.Button
    Friend WithEvents btnMovepre As System.Windows.Forms.Button
    Friend WithEvents btnMoveLast As System.Windows.Forms.Button
    Friend WithEvents txtpostion As System.Windows.Forms.TextBox
    Friend WithEvents txtcustsearch As System.Windows.Forms.TextBox
    Friend WithEvents btnsearchunit As System.Windows.Forms.Button
    Friend WithEvents txtsearchunit As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents Button13 As System.Windows.Forms.Button
    Friend WithEvents CoEmpName As System.Windows.Forms.TextBox
    Friend WithEvents empname As System.Windows.Forms.TextBox
End Class
