<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class login
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(login))
        Me.Loginbox = New System.Windows.Forms.GroupBox()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.exitbtn = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.userpass = New System.Windows.Forms.TextBox()
        Me.username = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Loginbox.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Loginbox
        '
        Me.Loginbox.Controls.Add(Me.LinkLabel1)
        Me.Loginbox.Controls.Add(Me.SimpleButton1)
        Me.Loginbox.Controls.Add(Me.Label6)
        Me.Loginbox.Controls.Add(Me.Label5)
        Me.Loginbox.Controls.Add(Me.exitbtn)
        Me.Loginbox.Controls.Add(Me.Button1)
        Me.Loginbox.Controls.Add(Me.PictureBox1)
        Me.Loginbox.Controls.Add(Me.Label2)
        Me.Loginbox.Controls.Add(Me.Label1)
        Me.Loginbox.Controls.Add(Me.userpass)
        Me.Loginbox.Controls.Add(Me.username)
        Me.Loginbox.Location = New System.Drawing.Point(122, 145)
        Me.Loginbox.Name = "Loginbox"
        Me.Loginbox.Size = New System.Drawing.Size(522, 260)
        Me.Loginbox.TabIndex = 0
        Me.Loginbox.TabStop = False
        Me.Loginbox.Text = "Login"
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.LinkLabel1.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.LinkLabel1.LinkColor = System.Drawing.Color.Navy
        Me.LinkLabel1.Location = New System.Drawing.Point(452, 16)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(64, 16)
        Me.LinkLabel1.TabIndex = 8
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Settings"
        Me.LinkLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.LinkLabel1.VisitedLinkColor = System.Drawing.Color.Black
        '
        'SimpleButton1
        '
        Me.SimpleButton1.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
        Me.SimpleButton1.ImageOptions.Image = Global.Belsoh2.My.Resources.Resources.hide_32x32
        Me.SimpleButton1.Location = New System.Drawing.Point(408, 131)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(38, 29)
        Me.SimpleButton1.TabIndex = 3
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Red
        Me.Label6.Location = New System.Drawing.Point(38, 220)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(63, 20)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "Label5"
        Me.Label6.Visible = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Red
        Me.Label5.Location = New System.Drawing.Point(230, 163)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(63, 20)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Label5"
        Me.Label5.Visible = False
        '
        'exitbtn
        '
        Me.exitbtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.exitbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.exitbtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.exitbtn.Location = New System.Drawing.Point(381, 206)
        Me.exitbtn.Name = "exitbtn"
        Me.exitbtn.Size = New System.Drawing.Size(100, 34)
        Me.exitbtn.TabIndex = 5
        Me.exitbtn.Text = "Exit"
        Me.exitbtn.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(234, 206)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(106, 37)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Login"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(54, 46)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(153, 151)
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(291, 98)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(106, 25)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Password"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(291, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(110, 25)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Username"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'userpass
        '
        Me.userpass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.userpass.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.userpass.Location = New System.Drawing.Point(234, 131)
        Me.userpass.Name = "userpass"
        Me.userpass.Size = New System.Drawing.Size(213, 29)
        Me.userpass.TabIndex = 2
        Me.userpass.UseSystemPasswordChar = True
        '
        'username
        '
        Me.username.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.username.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.username.Location = New System.Drawing.Point(234, 66)
        Me.username.Name = "username"
        Me.username.Size = New System.Drawing.Size(213, 29)
        Me.username.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.SkyBlue
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label3.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label3.Image = CType(resources.GetObject("Label3.Image"), System.Drawing.Image)
        Me.Label3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label3.Location = New System.Drawing.Point(122, 73)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(522, 57)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "BELSOH PHARMACY"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(486, 20)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(83, 25)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Label4"
        '
        'login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(752, 450)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Loginbox)
        Me.MaximizeBox = False
        Me.Name = "login"
        Me.Text = "BELSOH PHARMACY"
        Me.Loginbox.ResumeLayout(False)
        Me.Loginbox.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Loginbox As GroupBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents exitbtn As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Label6 As Label
    Friend WithEvents userpass As TextBox
    Friend WithEvents username As TextBox
    Friend WithEvents LinkLabel1 As LinkLabel
End Class
