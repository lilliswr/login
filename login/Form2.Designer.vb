<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class LoginForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LoginForm))
        Me.Guna2PictureBox1 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.txtPasswordLogin = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtEmailLogin = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnCreate = New Guna.UI2.WinForms.Guna2Button()
        Me.btnLogin = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnShow = New Guna.UI2.WinForms.Guna2CustomRadioButton()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Guna2PictureBox1
        '
        Me.Guna2PictureBox1.Image = CType(resources.GetObject("Guna2PictureBox1.Image"), System.Drawing.Image)
        Me.Guna2PictureBox1.ImageRotate = 0!
        Me.Guna2PictureBox1.Location = New System.Drawing.Point(-1, -34)
        Me.Guna2PictureBox1.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Guna2PictureBox1.Name = "Guna2PictureBox1"
        Me.Guna2PictureBox1.Size = New System.Drawing.Size(378, 522)
        Me.Guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Guna2PictureBox1.TabIndex = 1
        Me.Guna2PictureBox1.TabStop = False
        '
        'txtPasswordLogin
        '
        Me.txtPasswordLogin.Animated = True
        Me.txtPasswordLogin.BorderRadius = 8
        Me.txtPasswordLogin.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtPasswordLogin.DefaultText = "Password"
        Me.txtPasswordLogin.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtPasswordLogin.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtPasswordLogin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtPasswordLogin.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtPasswordLogin.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtPasswordLogin.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtPasswordLogin.ForeColor = System.Drawing.SystemColors.ScrollBar
        Me.txtPasswordLogin.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtPasswordLogin.IconLeft = CType(resources.GetObject("txtPasswordLogin.IconLeft"), System.Drawing.Image)
        Me.txtPasswordLogin.Location = New System.Drawing.Point(446, 146)
        Me.txtPasswordLogin.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtPasswordLogin.Name = "txtPasswordLogin"
        Me.txtPasswordLogin.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtPasswordLogin.PlaceholderText = ""
        Me.txtPasswordLogin.SelectedText = ""
        Me.txtPasswordLogin.Size = New System.Drawing.Size(233, 42)
        Me.txtPasswordLogin.TabIndex = 2
        '
        'txtEmailLogin
        '
        Me.txtEmailLogin.Animated = True
        Me.txtEmailLogin.BorderRadius = 8
        Me.txtEmailLogin.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtEmailLogin.DefaultText = "E-mail"
        Me.txtEmailLogin.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtEmailLogin.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtEmailLogin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtEmailLogin.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtEmailLogin.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtEmailLogin.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtEmailLogin.ForeColor = System.Drawing.SystemColors.ScrollBar
        Me.txtEmailLogin.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtEmailLogin.IconLeft = CType(resources.GetObject("txtEmailLogin.IconLeft"), System.Drawing.Image)
        Me.txtEmailLogin.Location = New System.Drawing.Point(446, 88)
        Me.txtEmailLogin.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtEmailLogin.Name = "txtEmailLogin"
        Me.txtEmailLogin.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtEmailLogin.PlaceholderText = ""
        Me.txtEmailLogin.SelectedText = ""
        Me.txtEmailLogin.Size = New System.Drawing.Size(233, 42)
        Me.txtEmailLogin.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label3.Location = New System.Drawing.Point(501, 43)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(108, 25)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "User Login"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label1.Location = New System.Drawing.Point(516, 191)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(93, 15)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Show Password"
        '
        'btnCreate
        '
        Me.btnCreate.AutoRoundedCorners = True
        Me.btnCreate.BorderRadius = 21
        Me.btnCreate.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnCreate.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnCreate.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnCreate.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnCreate.FillColor = System.Drawing.Color.Transparent
        Me.btnCreate.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnCreate.ForeColor = System.Drawing.Color.DimGray
        Me.btnCreate.Image = CType(resources.GetObject("btnCreate.Image"), System.Drawing.Image)
        Me.btnCreate.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.btnCreate.Location = New System.Drawing.Point(470, 357)
        Me.btnCreate.Name = "btnCreate"
        Me.btnCreate.Size = New System.Drawing.Size(200, 45)
        Me.btnCreate.TabIndex = 7
        Me.btnCreate.Text = "Create Account"
        '
        'btnLogin
        '
        Me.btnLogin.AutoRoundedCorners = True
        Me.btnLogin.BorderRadius = 21
        Me.btnLogin.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnLogin.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnLogin.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnLogin.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnLogin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnLogin.FillColor = System.Drawing.Color.DarkGoldenrod
        Me.btnLogin.FillColor2 = System.Drawing.Color.Goldenrod
        Me.btnLogin.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold)
        Me.btnLogin.ForeColor = System.Drawing.Color.White
        Me.btnLogin.Location = New System.Drawing.Point(446, 226)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(233, 45)
        Me.btnLogin.TabIndex = 5
        Me.btnLogin.Text = "LOGIN"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label2.Location = New System.Drawing.Point(478, 274)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(168, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Forgot username or password?"
        '
        'btnShow
        '
        Me.btnShow.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnShow.CheckedState.BorderThickness = 0
        Me.btnShow.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnShow.CheckedState.InnerColor = System.Drawing.Color.White
        Me.btnShow.Location = New System.Drawing.Point(491, 191)
        Me.btnShow.Name = "btnShow"
        Me.btnShow.Size = New System.Drawing.Size(20, 20)
        Me.btnShow.TabIndex = 10
        Me.btnShow.Text = "Guna2CustomRadioButton1"
        Me.btnShow.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.btnShow.UncheckedState.BorderThickness = 2
        Me.btnShow.UncheckedState.FillColor = System.Drawing.Color.Transparent
        Me.btnShow.UncheckedState.InnerColor = System.Drawing.Color.Transparent
        '
        'LoginForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(827, 450)
        Me.Controls.Add(Me.btnShow)
        Me.Controls.Add(Me.txtPasswordLogin)
        Me.Controls.Add(Me.btnCreate)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnLogin)
        Me.Controls.Add(Me.txtEmailLogin)
        Me.Controls.Add(Me.Guna2PictureBox1)
        Me.Controls.Add(Me.Label3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "LoginForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form2"
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Guna2PictureBox1 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents txtPasswordLogin As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtEmailLogin As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnCreate As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnLogin As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents Label2 As Label
    Friend WithEvents btnShow As Guna.UI2.WinForms.Guna2CustomRadioButton
End Class
