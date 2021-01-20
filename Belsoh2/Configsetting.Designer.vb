<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Configsetting
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(55, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(246, 25)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Configuration Settings"
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Appearance.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SimpleButton1.Appearance.Options.UseFont = True
        Me.SimpleButton1.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
        Me.SimpleButton1.Location = New System.Drawing.Point(101, 214)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(160, 40)
        Me.SimpleButton1.TabIndex = 3
        Me.SimpleButton1.Text = "Test Connection"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(34, 51)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 16)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Server"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(14, 91)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(68, 16)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Database"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(14, 130)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(71, 16)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Username"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(14, 171)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(68, 16)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Password"
        '
        'TextBox4
        '
        Me.TextBox4.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.Belsoh2.My.MySettings.Default, "Dbpassword", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.TextBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox4.Location = New System.Drawing.Point(88, 165)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(239, 21)
        Me.TextBox4.TabIndex = 1
        Me.TextBox4.Text = Global.Belsoh2.My.MySettings.Default.Dbpassword
        Me.TextBox4.UseSystemPasswordChar = True
        '
        'TextBox3
        '
        Me.TextBox3.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.Belsoh2.My.MySettings.Default, "Dbuser", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.TextBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox3.Location = New System.Drawing.Point(88, 124)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(239, 21)
        Me.TextBox3.TabIndex = 1
        Me.TextBox3.Text = Global.Belsoh2.My.MySettings.Default.Dbuser
        '
        'TextBox2
        '
        Me.TextBox2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.Belsoh2.My.MySettings.Default, "Dbdatabase", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.TextBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.Location = New System.Drawing.Point(88, 85)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(239, 21)
        Me.TextBox2.TabIndex = 1
        Me.TextBox2.Text = Global.Belsoh2.My.MySettings.Default.Dbdatabase
        '
        'TextBox1
        '
        Me.TextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.Belsoh2.My.MySettings.Default, "Dbserver", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(88, 48)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(239, 21)
        Me.TextBox1.TabIndex = 1
        Me.TextBox1.Text = Global.Belsoh2.My.MySettings.Default.Dbserver
        '
        'Configsetting
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(352, 294)
        Me.Controls.Add(Me.SimpleButton1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.MaximizeBox = False
        Me.Name = "Configsetting"
        Me.Text = "Configsetting"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Label5 As Label
End Class
