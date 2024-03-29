<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Managerlogin
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
        Me.Lblwelcome = New System.Windows.Forms.Label()
        Me.Btnaddevent = New System.Windows.Forms.Button()
        Me.Btnremoveevent = New System.Windows.Forms.Button()
        Me.Btnclose3 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Lblwelcome
        '
        Me.Lblwelcome.BackColor = System.Drawing.Color.White
        Me.Lblwelcome.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lblwelcome.ForeColor = System.Drawing.Color.Blue
        Me.Lblwelcome.Location = New System.Drawing.Point(244, 21)
        Me.Lblwelcome.Name = "Lblwelcome"
        Me.Lblwelcome.Size = New System.Drawing.Size(299, 26)
        Me.Lblwelcome.TabIndex = 0
        Me.Lblwelcome.Text = "Welcome,Event Manager"
        Me.Lblwelcome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Btnaddevent
        '
        Me.Btnaddevent.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btnaddevent.Location = New System.Drawing.Point(33, 132)
        Me.Btnaddevent.Name = "Btnaddevent"
        Me.Btnaddevent.Size = New System.Drawing.Size(243, 47)
        Me.Btnaddevent.TabIndex = 1
        Me.Btnaddevent.Text = "Add/list an event"
        Me.Btnaddevent.UseVisualStyleBackColor = True
        '
        'Btnremoveevent
        '
        Me.Btnremoveevent.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btnremoveevent.ForeColor = System.Drawing.Color.Red
        Me.Btnremoveevent.Location = New System.Drawing.Point(448, 132)
        Me.Btnremoveevent.Name = "Btnremoveevent"
        Me.Btnremoveevent.Size = New System.Drawing.Size(269, 47)
        Me.Btnremoveevent.TabIndex = 2
        Me.Btnremoveevent.Text = "Remove/delist an event"
        Me.Btnremoveevent.UseVisualStyleBackColor = True
        '
        'Btnclose3
        '
        Me.Btnclose3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btnclose3.ForeColor = System.Drawing.Color.Red
        Me.Btnclose3.Location = New System.Drawing.Point(230, 262)
        Me.Btnclose3.Name = "Btnclose3"
        Me.Btnclose3.Size = New System.Drawing.Size(278, 47)
        Me.Btnclose3.TabIndex = 4
        Me.Btnclose3.Text = "Close"
        Me.Btnclose3.UseVisualStyleBackColor = True
        '
        'Managerlogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(800, 477)
        Me.Controls.Add(Me.Btnclose3)
        Me.Controls.Add(Me.Btnremoveevent)
        Me.Controls.Add(Me.Btnaddevent)
        Me.Controls.Add(Me.Lblwelcome)
        Me.Name = "Managerlogin"
        Me.Text = "Managerlogin"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Lblwelcome As Label
    Friend WithEvents Btnaddevent As Button
    Friend WithEvents Btnremoveevent As Button
    Friend WithEvents Btnclose3 As Button
End Class
