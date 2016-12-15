<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PassVault
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PassVault))
        Me.LoginUserNametxt = New System.Windows.Forms.TextBox()
        Me.LoginPasswordtxt = New System.Windows.Forms.TextBox()
        Me.LoginBtn = New System.Windows.Forms.Button()
        Me.PasswordLoginlbl = New System.Windows.Forms.Label()
        Me.LoginUserNamelbl = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CreateAccountBtn = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'LoginUserNametxt
        '
        Me.LoginUserNametxt.BackColor = System.Drawing.Color.White
        Me.LoginUserNametxt.Location = New System.Drawing.Point(250, 137)
        Me.LoginUserNametxt.Name = "LoginUserNametxt"
        Me.LoginUserNametxt.Size = New System.Drawing.Size(100, 20)
        Me.LoginUserNametxt.TabIndex = 0
        '
        'LoginPasswordtxt
        '
        Me.LoginPasswordtxt.BackColor = System.Drawing.Color.White
        Me.LoginPasswordtxt.Location = New System.Drawing.Point(250, 180)
        Me.LoginPasswordtxt.Name = "LoginPasswordtxt"
        Me.LoginPasswordtxt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.LoginPasswordtxt.Size = New System.Drawing.Size(100, 20)
        Me.LoginPasswordtxt.TabIndex = 1
        '
        'LoginBtn
        '
        Me.LoginBtn.BackColor = System.Drawing.Color.White
        Me.LoginBtn.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LoginBtn.Location = New System.Drawing.Point(216, 234)
        Me.LoginBtn.Name = "LoginBtn"
        Me.LoginBtn.Size = New System.Drawing.Size(73, 30)
        Me.LoginBtn.TabIndex = 2
        Me.LoginBtn.Text = "Login"
        Me.LoginBtn.UseVisualStyleBackColor = False
        '
        'PasswordLoginlbl
        '
        Me.PasswordLoginlbl.AutoSize = True
        Me.PasswordLoginlbl.BackColor = System.Drawing.Color.Bisque
        Me.PasswordLoginlbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PasswordLoginlbl.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PasswordLoginlbl.Location = New System.Drawing.Point(158, 180)
        Me.PasswordLoginlbl.Name = "PasswordLoginlbl"
        Me.PasswordLoginlbl.Size = New System.Drawing.Size(88, 20)
        Me.PasswordLoginlbl.TabIndex = 3
        Me.PasswordLoginlbl.Text = "Password:"
        '
        'LoginUserNamelbl
        '
        Me.LoginUserNamelbl.AutoSize = True
        Me.LoginUserNamelbl.BackColor = System.Drawing.Color.Bisque
        Me.LoginUserNamelbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LoginUserNamelbl.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LoginUserNamelbl.Location = New System.Drawing.Point(149, 137)
        Me.LoginUserNamelbl.Name = "LoginUserNamelbl"
        Me.LoginUserNamelbl.Size = New System.Drawing.Size(97, 20)
        Me.LoginUserNamelbl.TabIndex = 4
        Me.LoginUserNamelbl.Text = "User Name:"
        '
        'Label2
        '
        Me.Label2.AutoEllipsis = True
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Bisque
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label2.Font = New System.Drawing.Font("Trajan Pro", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(150, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(198, 42)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "PassVault"
        '
        'CreateAccountBtn
        '
        Me.CreateAccountBtn.BackColor = System.Drawing.Color.White
        Me.CreateAccountBtn.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CreateAccountBtn.Location = New System.Drawing.Point(161, 270)
        Me.CreateAccountBtn.Name = "CreateAccountBtn"
        Me.CreateAccountBtn.Size = New System.Drawing.Size(176, 30)
        Me.CreateAccountBtn.TabIndex = 6
        Me.CreateAccountBtn.Text = "Create Account"
        Me.CreateAccountBtn.UseVisualStyleBackColor = False
        '
        'PassVault
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(499, 336)
        Me.Controls.Add(Me.CreateAccountBtn)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.LoginUserNamelbl)
        Me.Controls.Add(Me.PasswordLoginlbl)
        Me.Controls.Add(Me.LoginBtn)
        Me.Controls.Add(Me.LoginPasswordtxt)
        Me.Controls.Add(Me.LoginUserNametxt)
        Me.Location = New System.Drawing.Point(10, 10)
        Me.Name = "PassVault"
        Me.Text = "Login Screen"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LoginUserNametxt As System.Windows.Forms.TextBox
    Friend WithEvents LoginPasswordtxt As System.Windows.Forms.TextBox
    Friend WithEvents LoginBtn As System.Windows.Forms.Button
    Friend WithEvents PasswordLoginlbl As System.Windows.Forms.Label
    Friend WithEvents LoginUserNamelbl As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents CreateAccountBtn As System.Windows.Forms.Button

End Class
