<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMain
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmMain))
        Me.cbUserType = New System.Windows.Forms.ComboBox()
        Me.txtname = New System.Windows.Forms.TextBox()
        Me.txtpassord = New System.Windows.Forms.TextBox()
        Me.Button13 = New System.Windows.Forms.Button()
        Me.InsedCus = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'cbUserType
        '
        Me.cbUserType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbUserType.FormattingEnabled = True
        Me.cbUserType.Items.AddRange(New Object() {resources.GetString("cbUserType.Items"), resources.GetString("cbUserType.Items1"), resources.GetString("cbUserType.Items2")})
        resources.ApplyResources(Me.cbUserType, "cbUserType")
        Me.cbUserType.Name = "cbUserType"
        Me.cbUserType.Tag = ""
        '
        'txtname
        '
        Me.txtname.BorderStyle = System.Windows.Forms.BorderStyle.None
        resources.ApplyResources(Me.txtname, "txtname")
        Me.txtname.Name = "txtname"
        Me.txtname.Tag = ""
        '
        'txtpassord
        '
        Me.txtpassord.BorderStyle = System.Windows.Forms.BorderStyle.None
        resources.ApplyResources(Me.txtpassord, "txtpassord")
        Me.txtpassord.Name = "txtpassord"
        '
        'Button13
        '
        resources.ApplyResources(Me.Button13, "Button13")
        Me.Button13.BackColor = System.Drawing.Color.Transparent
        Me.Button13.ForeColor = System.Drawing.Color.White
        Me.Button13.Name = "Button13"
        Me.Button13.UseVisualStyleBackColor = False
        '
        'InsedCus
        '
        Me.InsedCus.BackColor = System.Drawing.Color.Transparent
        resources.ApplyResources(Me.InsedCus, "InsedCus")
        Me.InsedCus.FlatAppearance.BorderSize = 0
        Me.InsedCus.ForeColor = System.Drawing.Color.Black
        Me.InsedCus.Name = "InsedCus"
        Me.InsedCus.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.BackgroundImage = Global.StudioTaher.My.Resources.Resources.Untitleخخ
        resources.ApplyResources(Me.Button1, "Button1")
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.ForeColor = System.Drawing.Color.Black
        Me.Button1.Name = "Button1"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label1
        '
        resources.ApplyResources(Me.Label1, "Label1")
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Name = "Label1"
        '
        'FrmMain
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Teal
        Me.BackgroundImage = Global.StudioTaher.My.Resources.Resources._001
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Button13)
        Me.Controls.Add(Me.cbUserType)
        Me.Controls.Add(Me.InsedCus)
        Me.Controls.Add(Me.txtname)
        Me.Controls.Add(Me.txtpassord)
        Me.DoubleBuffered = True
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmMain"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cbUserType As System.Windows.Forms.ComboBox
    Friend WithEvents txtname As System.Windows.Forms.TextBox
    Friend WithEvents txtpassord As System.Windows.Forms.TextBox
    Friend WithEvents Button13 As System.Windows.Forms.Button
    Friend WithEvents InsedCus As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
