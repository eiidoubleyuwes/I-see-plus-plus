<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.Grpbxevent = New System.Windows.Forms.GroupBox()
        Me.Btnsignup = New System.Windows.Forms.Button()
        Me.Btnlogin = New System.Windows.Forms.Button()
        Me.Txtpassword = New System.Windows.Forms.TextBox()
        Me.Lbl1_2 = New System.Windows.Forms.Label()
        Me.Txtusername = New System.Windows.Forms.TextBox()
        Me.Lbl1_1 = New System.Windows.Forms.Label()
        Me.Btnuser = New System.Windows.Forms.Button()
        Me.Btnexito = New System.Windows.Forms.Button()
        Me.Grpbxevent.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(214, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(364, 37)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Welcome to the login page"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Grpbxevent
        '
        Me.Grpbxevent.BackColor = System.Drawing.Color.Transparent
        Me.Grpbxevent.Controls.Add(Me.Btnsignup)
        Me.Grpbxevent.Controls.Add(Me.Btnlogin)
        Me.Grpbxevent.Controls.Add(Me.Txtpassword)
        Me.Grpbxevent.Controls.Add(Me.Lbl1_2)
        Me.Grpbxevent.Controls.Add(Me.Txtusername)
        Me.Grpbxevent.Controls.Add(Me.Lbl1_1)
        Me.Grpbxevent.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Grpbxevent.Location = New System.Drawing.Point(27, 85)
        Me.Grpbxevent.Name = "Grpbxevent"
        Me.Grpbxevent.Size = New System.Drawing.Size(361, 297)
        Me.Grpbxevent.TabIndex = 1
        Me.Grpbxevent.TabStop = False
        Me.Grpbxevent.Text = "EVENT MANAGERS"
        '
        'Btnsignup
        '
        Me.Btnsignup.Location = New System.Drawing.Point(193, 237)
        Me.Btnsignup.Name = "Btnsignup"
        Me.Btnsignup.Size = New System.Drawing.Size(112, 33)
        Me.Btnsignup.TabIndex = 5
        Me.Btnsignup.Text = "SIGN UP"
        Me.Btnsignup.UseVisualStyleBackColor = True
        '
        'Btnlogin
        '
        Me.Btnlogin.Location = New System.Drawing.Point(28, 237)
        Me.Btnlogin.Name = "Btnlogin"
        Me.Btnlogin.Size = New System.Drawing.Size(122, 33)
        Me.Btnlogin.TabIndex = 4
        Me.Btnlogin.Text = "LOG IN"
        Me.Btnlogin.UseVisualStyleBackColor = True
        '
        'Txtpassword
        '
        Me.Txtpassword.Location = New System.Drawing.Point(149, 152)
        Me.Txtpassword.Name = "Txtpassword"
        Me.Txtpassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.Txtpassword.Size = New System.Drawing.Size(191, 29)
        Me.Txtpassword.TabIndex = 3
        '
        'Lbl1_2
        '
        Me.Lbl1_2.AutoSize = True
        Me.Lbl1_2.Location = New System.Drawing.Point(25, 152)
        Me.Lbl1_2.Name = "Lbl1_2"
        Me.Lbl1_2.Size = New System.Drawing.Size(100, 24)
        Me.Lbl1_2.TabIndex = 2
        Me.Lbl1_2.Text = "Password"
        '
        'Txtusername
        '
        Me.Txtusername.Location = New System.Drawing.Point(164, 65)
        Me.Txtusername.Name = "Txtusername"
        Me.Txtusername.Size = New System.Drawing.Size(191, 29)
        Me.Txtusername.TabIndex = 1
        '
        'Lbl1_1
        '
        Me.Lbl1_1.AutoSize = True
        Me.Lbl1_1.Location = New System.Drawing.Point(-1, 68)
        Me.Lbl1_1.Name = "Lbl1_1"
        Me.Lbl1_1.Size = New System.Drawing.Size(159, 24)
        Me.Lbl1_1.TabIndex = 0
        Me.Lbl1_1.Text = "Company Name"
        '
        'Btnuser
        '
        Me.Btnuser.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btnuser.ForeColor = System.Drawing.Color.Black
        Me.Btnuser.Location = New System.Drawing.Point(537, 202)
        Me.Btnuser.Name = "Btnuser"
        Me.Btnuser.Size = New System.Drawing.Size(247, 59)
        Me.Btnuser.TabIndex = 2
        Me.Btnuser.Text = "AVAILABLE EVENTS"
        Me.Btnuser.UseVisualStyleBackColor = True
        '
        'Btnexito
        '
        Me.Btnexito.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btnexito.ForeColor = System.Drawing.Color.Red
        Me.Btnexito.Location = New System.Drawing.Point(562, 369)
        Me.Btnexito.Name = "Btnexito"
        Me.Btnexito.Size = New System.Drawing.Size(196, 35)
        Me.Btnexito.TabIndex = 13
        Me.Btnexito.Text = "Exit"
        Me.Btnexito.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Projecta.My.Resources.Resources.istockphoto_1189205501_612x612
        Me.ClientSize = New System.Drawing.Size(872, 513)
        Me.Controls.Add(Me.Btnexito)
        Me.Controls.Add(Me.Btnuser)
        Me.Controls.Add(Me.Grpbxevent)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Login"
        Me.Grpbxevent.ResumeLayout(False)
        Me.Grpbxevent.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Grpbxevent As GroupBox
    Friend WithEvents Txtusername As TextBox
    Friend WithEvents Lbl1_1 As Label
    Friend WithEvents Btnsignup As Button
    Friend WithEvents Btnlogin As Button
    Friend WithEvents Txtpassword As TextBox
    Friend WithEvents Lbl1_2 As Label
    Friend WithEvents Btnuser As Button
    Friend WithEvents Btnexito As Button
End Class
