<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CreateForm
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
        Me.components = New System.ComponentModel.Container()
        Dim Animation3 As Guna.UI2.AnimatorNS.Animation = New Guna.UI2.AnimatorNS.Animation()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CreateForm))
        Me.Guna2Elipse1 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.Guna2ShadowForm1 = New Guna.UI2.WinForms.Guna2ShadowForm(Me.components)
        Me.Guna2PictureBox1 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.Guna2AnimateWindow1 = New Guna.UI2.WinForms.Guna2AnimateWindow(Me.components)
        Me.Guna2DragControl1 = New Guna.UI2.WinForms.Guna2DragControl(Me.components)
        Me.Guna2ControlBox2 = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.Guna2ControlBox1 = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.pnlregis = New Guna.UI2.WinForms.Guna2Panel()
        Me.txtEmailCreate = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtPasswordCreate = New Guna.UI2.WinForms.Guna2TextBox()
        Me.lblPasswordError = New System.Windows.Forms.Label()
        Me.txtDOB = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtName = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.BtnCreate = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.lblLogin = New System.Windows.Forms.Label()
        Me.Guna2Transition1 = New Guna.UI2.WinForms.Guna2Transition()
        Me.Guna2AnimateWindow2 = New Guna.UI2.WinForms.Guna2AnimateWindow(Me.components)
        Me.lblPasswordError1 = New System.Windows.Forms.Label()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlregis.SuspendLayout()
        Me.SuspendLayout()
        '
        'Guna2Elipse1
        '
        Me.Guna2Elipse1.BorderRadius = 20
        Me.Guna2Elipse1.TargetControl = Me
        '
        'Guna2ShadowForm1
        '
        Me.Guna2ShadowForm1.TargetForm = Me
        '
        'Guna2PictureBox1
        '
        Me.Guna2Transition1.SetDecoration(Me.Guna2PictureBox1, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Guna2PictureBox1.Image = CType(resources.GetObject("Guna2PictureBox1.Image"), System.Drawing.Image)
        Me.Guna2PictureBox1.ImageRotate = 0!
        Me.Guna2PictureBox1.Location = New System.Drawing.Point(-1, -34)
        Me.Guna2PictureBox1.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Guna2PictureBox1.Name = "Guna2PictureBox1"
        Me.Guna2PictureBox1.Size = New System.Drawing.Size(378, 522)
        Me.Guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Guna2PictureBox1.TabIndex = 0
        Me.Guna2PictureBox1.TabStop = False
        '
        'Guna2AnimateWindow1
        '
        Me.Guna2AnimateWindow1.TargetForm = Me
        '
        'Guna2DragControl1
        '
        Me.Guna2DragControl1.DockIndicatorTransparencyValue = 0.6R
        Me.Guna2DragControl1.TargetControl = Me
        Me.Guna2DragControl1.UseTransparentDrag = True
        '
        'Guna2ControlBox2
        '
        Me.Guna2ControlBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2ControlBox2.Animated = True
        Me.Guna2ControlBox2.BackColor = System.Drawing.Color.Transparent
        Me.Guna2ControlBox2.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox
        Me.Guna2Transition1.SetDecoration(Me.Guna2ControlBox2, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Guna2ControlBox2.FillColor = System.Drawing.Color.White
        Me.Guna2ControlBox2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Guna2ControlBox2.IconColor = System.Drawing.Color.Black
        Me.Guna2ControlBox2.Location = New System.Drawing.Point(759, 12)
        Me.Guna2ControlBox2.Name = "Guna2ControlBox2"
        Me.Guna2ControlBox2.Size = New System.Drawing.Size(25, 23)
        Me.Guna2ControlBox2.TabIndex = 11
        '
        'Guna2ControlBox1
        '
        Me.Guna2ControlBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2ControlBox1.Animated = True
        Me.Guna2ControlBox1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Transition1.SetDecoration(Me.Guna2ControlBox1, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Guna2ControlBox1.FillColor = System.Drawing.Color.White
        Me.Guna2ControlBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Guna2ControlBox1.IconColor = System.Drawing.Color.Black
        Me.Guna2ControlBox1.Location = New System.Drawing.Point(790, 12)
        Me.Guna2ControlBox1.Name = "Guna2ControlBox1"
        Me.Guna2ControlBox1.Size = New System.Drawing.Size(25, 23)
        Me.Guna2ControlBox1.TabIndex = 12
        '
        'pnlregis
        '
        Me.pnlregis.BackColor = System.Drawing.Color.White
        Me.pnlregis.Controls.Add(Me.lblPasswordError1)
        Me.pnlregis.Controls.Add(Me.txtEmailCreate)
        Me.pnlregis.Controls.Add(Me.txtPasswordCreate)
        Me.pnlregis.Controls.Add(Me.lblPasswordError)
        Me.pnlregis.Controls.Add(Me.txtDOB)
        Me.pnlregis.Controls.Add(Me.txtName)
        Me.pnlregis.Controls.Add(Me.Label4)
        Me.pnlregis.Controls.Add(Me.BtnCreate)
        Me.pnlregis.Controls.Add(Me.lblLogin)
        Me.Guna2Transition1.SetDecoration(Me.pnlregis, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.pnlregis.Location = New System.Drawing.Point(433, 31)
        Me.pnlregis.Name = "pnlregis"
        Me.pnlregis.Size = New System.Drawing.Size(287, 397)
        Me.pnlregis.TabIndex = 14
        '
        'txtEmailCreate
        '
        Me.txtEmailCreate.BorderRadius = 8
        Me.txtEmailCreate.Cursor = System.Windows.Forms.Cursors.PanSW
        Me.Guna2Transition1.SetDecoration(Me.txtEmailCreate, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.txtEmailCreate.DefaultText = "E-mail"
        Me.txtEmailCreate.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtEmailCreate.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtEmailCreate.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtEmailCreate.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtEmailCreate.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtEmailCreate.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtEmailCreate.ForeColor = System.Drawing.SystemColors.ScrollBar
        Me.txtEmailCreate.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtEmailCreate.IconLeft = CType(resources.GetObject("txtEmailCreate.IconLeft"), System.Drawing.Image)
        Me.txtEmailCreate.Location = New System.Drawing.Point(24, 74)
        Me.txtEmailCreate.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtEmailCreate.Name = "txtEmailCreate"
        Me.txtEmailCreate.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtEmailCreate.PlaceholderText = ""
        Me.txtEmailCreate.SelectedText = ""
        Me.txtEmailCreate.Size = New System.Drawing.Size(233, 42)
        Me.txtEmailCreate.TabIndex = 13
        '
        'txtPasswordCreate
        '
        Me.txtPasswordCreate.BorderRadius = 8
        Me.txtPasswordCreate.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Guna2Transition1.SetDecoration(Me.txtPasswordCreate, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.txtPasswordCreate.DefaultText = "Password"
        Me.txtPasswordCreate.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtPasswordCreate.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtPasswordCreate.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtPasswordCreate.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtPasswordCreate.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtPasswordCreate.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtPasswordCreate.ForeColor = System.Drawing.SystemColors.ScrollBar
        Me.txtPasswordCreate.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtPasswordCreate.IconLeft = CType(resources.GetObject("txtPasswordCreate.IconLeft"), System.Drawing.Image)
        Me.txtPasswordCreate.Location = New System.Drawing.Point(23, 218)
        Me.txtPasswordCreate.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtPasswordCreate.Name = "txtPasswordCreate"
        Me.txtPasswordCreate.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtPasswordCreate.PlaceholderText = ""
        Me.txtPasswordCreate.SelectedText = ""
        Me.txtPasswordCreate.Size = New System.Drawing.Size(233, 42)
        Me.txtPasswordCreate.TabIndex = 12
        '
        'lblPasswordError
        '
        Me.lblPasswordError.AutoSize = True
        Me.Guna2Transition1.SetDecoration(Me.lblPasswordError, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.lblPasswordError.Location = New System.Drawing.Point(37, 263)
        Me.lblPasswordError.Name = "lblPasswordError"
        Me.lblPasswordError.Size = New System.Drawing.Size(0, 15)
        Me.lblPasswordError.TabIndex = 11
        '
        'txtDOB
        '
        Me.txtDOB.BorderRadius = 8
        Me.txtDOB.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Guna2Transition1.SetDecoration(Me.txtDOB, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.txtDOB.DefaultText = "Date of Birth"
        Me.txtDOB.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtDOB.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtDOB.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtDOB.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtDOB.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtDOB.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtDOB.ForeColor = System.Drawing.SystemColors.ScrollBar
        Me.txtDOB.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtDOB.IconLeft = CType(resources.GetObject("txtDOB.IconLeft"), System.Drawing.Image)
        Me.txtDOB.Location = New System.Drawing.Point(24, 170)
        Me.txtDOB.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtDOB.Name = "txtDOB"
        Me.txtDOB.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtDOB.PlaceholderText = ""
        Me.txtDOB.SelectedText = ""
        Me.txtDOB.Size = New System.Drawing.Size(233, 42)
        Me.txtDOB.TabIndex = 10
        '
        'txtName
        '
        Me.txtName.BorderRadius = 8
        Me.txtName.Cursor = System.Windows.Forms.Cursors.PanSW
        Me.Guna2Transition1.SetDecoration(Me.txtName, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.txtName.DefaultText = "Name"
        Me.txtName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtName.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtName.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtName.ForeColor = System.Drawing.SystemColors.ScrollBar
        Me.txtName.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtName.IconLeft = CType(resources.GetObject("txtName.IconLeft"), System.Drawing.Image)
        Me.txtName.Location = New System.Drawing.Point(23, 122)
        Me.txtName.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtName.Name = "txtName"
        Me.txtName.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtName.PlaceholderText = ""
        Me.txtName.SelectedText = ""
        Me.txtName.Size = New System.Drawing.Size(233, 42)
        Me.txtName.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Guna2Transition1.SetDecoration(Me.Label4, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label4.Location = New System.Drawing.Point(29, 27)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(211, 25)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Create A New Account"
        '
        'BtnCreate
        '
        Me.BtnCreate.Animated = True
        Me.BtnCreate.AutoRoundedCorners = True
        Me.BtnCreate.BorderRadius = 21
        Me.Guna2Transition1.SetDecoration(Me.BtnCreate, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.BtnCreate.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BtnCreate.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BtnCreate.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BtnCreate.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BtnCreate.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BtnCreate.FillColor = System.Drawing.Color.Goldenrod
        Me.BtnCreate.FillColor2 = System.Drawing.Color.Goldenrod
        Me.BtnCreate.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold)
        Me.BtnCreate.ForeColor = System.Drawing.Color.White
        Me.BtnCreate.Location = New System.Drawing.Point(24, 297)
        Me.BtnCreate.Name = "BtnCreate"
        Me.BtnCreate.Size = New System.Drawing.Size(233, 45)
        Me.BtnCreate.TabIndex = 5
        Me.BtnCreate.Text = "CREATE ACCOUNT"
        '
        'lblLogin
        '
        Me.lblLogin.AutoSize = True
        Me.lblLogin.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Guna2Transition1.SetDecoration(Me.lblLogin, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.lblLogin.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLogin.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.lblLogin.Location = New System.Drawing.Point(220, 356)
        Me.lblLogin.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblLogin.Name = "lblLogin"
        Me.lblLogin.Size = New System.Drawing.Size(37, 13)
        Me.lblLogin.TabIndex = 6
        Me.lblLogin.Text = "Login"
        '
        'Guna2Transition1
        '
        Me.Guna2Transition1.Cursor = Nothing
        Animation3.AnimateOnlyDifferences = True
        Animation3.BlindCoeff = CType(resources.GetObject("Animation3.BlindCoeff"), System.Drawing.PointF)
        Animation3.LeafCoeff = 0!
        Animation3.MaxTime = 1.0!
        Animation3.MinTime = 0!
        Animation3.MosaicCoeff = CType(resources.GetObject("Animation3.MosaicCoeff"), System.Drawing.PointF)
        Animation3.MosaicShift = CType(resources.GetObject("Animation3.MosaicShift"), System.Drawing.PointF)
        Animation3.MosaicSize = 0
        Animation3.Padding = New System.Windows.Forms.Padding(0)
        Animation3.RotateCoeff = 0!
        Animation3.RotateLimit = 0!
        Animation3.ScaleCoeff = CType(resources.GetObject("Animation3.ScaleCoeff"), System.Drawing.PointF)
        Animation3.SlideCoeff = CType(resources.GetObject("Animation3.SlideCoeff"), System.Drawing.PointF)
        Animation3.TimeCoeff = 0!
        Animation3.TransparencyCoeff = 0!
        Me.Guna2Transition1.DefaultAnimation = Animation3
        '
        'lblPasswordError1
        '
        Me.lblPasswordError1.AutoSize = True
        Me.Guna2Transition1.SetDecoration(Me.lblPasswordError1, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.lblPasswordError1.Font = New System.Drawing.Font("Segoe UI Emoji", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPasswordError1.Location = New System.Drawing.Point(43, 263)
        Me.lblPasswordError1.Name = "lblPasswordError1"
        Me.lblPasswordError1.Size = New System.Drawing.Size(31, 12)
        Me.lblPasswordError1.TabIndex = 14
        Me.lblPasswordError1.Text = "Label1"
        '
        'CreateForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(827, 450)
        Me.Controls.Add(Me.pnlregis)
        Me.Controls.Add(Me.Guna2ControlBox1)
        Me.Controls.Add(Me.Guna2ControlBox2)
        Me.Controls.Add(Me.Guna2PictureBox1)
        Me.Guna2Transition1.SetDecoration(Me, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Name = "CreateForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlregis.ResumeLayout(False)
        Me.pnlregis.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents Guna2PictureBox1 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents Guna2ShadowForm1 As Guna.UI2.WinForms.Guna2ShadowForm
    Friend WithEvents Guna2AnimateWindow1 As Guna.UI2.WinForms.Guna2AnimateWindow
    Friend WithEvents Guna2DragControl1 As Guna.UI2.WinForms.Guna2DragControl
    Friend WithEvents Guna2ControlBox2 As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents Guna2ControlBox1 As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents pnlregis As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents txtName As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents BtnCreate As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents lblLogin As Label
    Friend WithEvents txtDOB As Guna.UI2.WinForms.Guna2TextBox



    Friend WithEvents Guna2Transition1 As Guna.UI2.WinForms.Guna2Transition
    Friend WithEvents Guna2AnimateWindow2 As Guna.UI2.WinForms.Guna2AnimateWindow
    Friend WithEvents lblPasswordError As Label
    Friend WithEvents txtEmailCreate As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtPasswordCreate As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents lblPasswordError1 As Label
End Class
