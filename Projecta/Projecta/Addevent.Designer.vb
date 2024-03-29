<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Addevent
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
        Me.Btnsubmitevent = New System.Windows.Forms.Button()
        Me.Lbladdevent = New System.Windows.Forms.Label()
        Me.BtnClose4 = New System.Windows.Forms.Button()
        Me.LblEventname = New System.Windows.Forms.Label()
        Me.Lbleventprice = New System.Windows.Forms.Label()
        Me.Lbleventdetails = New System.Windows.Forms.Label()
        Me.Lbleventlocation = New System.Windows.Forms.Label()
        Me.Txteventname = New System.Windows.Forms.TextBox()
        Me.Txteventprice = New System.Windows.Forms.TextBox()
        Me.Txteventdetails = New System.Windows.Forms.TextBox()
        Me.Txteventlocation = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Btnsubmitevent
        '
        Me.Btnsubmitevent.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btnsubmitevent.ForeColor = System.Drawing.Color.Blue
        Me.Btnsubmitevent.Location = New System.Drawing.Point(115, 372)
        Me.Btnsubmitevent.Name = "Btnsubmitevent"
        Me.Btnsubmitevent.Size = New System.Drawing.Size(169, 65)
        Me.Btnsubmitevent.TabIndex = 0
        Me.Btnsubmitevent.Text = "Submit"
        Me.Btnsubmitevent.UseVisualStyleBackColor = True
        '
        'Lbladdevent
        '
        Me.Lbladdevent.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbladdevent.Location = New System.Drawing.Point(110, 9)
        Me.Lbladdevent.Name = "Lbladdevent"
        Me.Lbladdevent.Size = New System.Drawing.Size(540, 50)
        Me.Lbladdevent.TabIndex = 1
        Me.Lbladdevent.Text = "Add Event Details "
        Me.Lbladdevent.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BtnClose4
        '
        Me.BtnClose4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnClose4.ForeColor = System.Drawing.Color.Red
        Me.BtnClose4.Location = New System.Drawing.Point(461, 372)
        Me.BtnClose4.Name = "BtnClose4"
        Me.BtnClose4.Size = New System.Drawing.Size(169, 65)
        Me.BtnClose4.TabIndex = 2
        Me.BtnClose4.Text = "Close"
        Me.BtnClose4.UseVisualStyleBackColor = True
        '
        'LblEventname
        '
        Me.LblEventname.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblEventname.Location = New System.Drawing.Point(119, 59)
        Me.LblEventname.Name = "LblEventname"
        Me.LblEventname.Size = New System.Drawing.Size(165, 50)
        Me.LblEventname.TabIndex = 3
        Me.LblEventname.Text = "Event Name"
        Me.LblEventname.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Lbleventprice
        '
        Me.Lbleventprice.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbleventprice.Location = New System.Drawing.Point(110, 115)
        Me.Lbleventprice.Name = "Lbleventprice"
        Me.Lbleventprice.Size = New System.Drawing.Size(165, 50)
        Me.Lbleventprice.TabIndex = 4
        Me.Lbleventprice.Text = "Event Price"
        Me.Lbleventprice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Lbleventdetails
        '
        Me.Lbleventdetails.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbleventdetails.Location = New System.Drawing.Point(70, 183)
        Me.Lbleventdetails.Name = "Lbleventdetails"
        Me.Lbleventdetails.Size = New System.Drawing.Size(245, 50)
        Me.Lbleventdetails.TabIndex = 5
        Me.Lbleventdetails.Text = "Event Details"
        Me.Lbleventdetails.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Lbleventlocation
        '
        Me.Lbleventlocation.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbleventlocation.Location = New System.Drawing.Point(70, 286)
        Me.Lbleventlocation.Name = "Lbleventlocation"
        Me.Lbleventlocation.Size = New System.Drawing.Size(239, 50)
        Me.Lbleventlocation.TabIndex = 6
        Me.Lbleventlocation.Text = "Event Location "
        Me.Lbleventlocation.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Txteventname
        '
        Me.Txteventname.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txteventname.Location = New System.Drawing.Point(290, 71)
        Me.Txteventname.Name = "Txteventname"
        Me.Txteventname.Size = New System.Drawing.Size(320, 29)
        Me.Txteventname.TabIndex = 7
        '
        'Txteventprice
        '
        Me.Txteventprice.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txteventprice.Location = New System.Drawing.Point(290, 127)
        Me.Txteventprice.Name = "Txteventprice"
        Me.Txteventprice.Size = New System.Drawing.Size(320, 29)
        Me.Txteventprice.TabIndex = 8
        '
        'Txteventdetails
        '
        Me.Txteventdetails.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txteventdetails.Location = New System.Drawing.Point(290, 183)
        Me.Txteventdetails.Multiline = True
        Me.Txteventdetails.Name = "Txteventdetails"
        Me.Txteventdetails.Size = New System.Drawing.Size(320, 88)
        Me.Txteventdetails.TabIndex = 9
        '
        'Txteventlocation
        '
        Me.Txteventlocation.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txteventlocation.Location = New System.Drawing.Point(290, 298)
        Me.Txteventlocation.Name = "Txteventlocation"
        Me.Txteventlocation.Size = New System.Drawing.Size(320, 29)
        Me.Txteventlocation.TabIndex = 10
        '
        'Addevent
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ClientSize = New System.Drawing.Size(800, 477)
        Me.Controls.Add(Me.Txteventlocation)
        Me.Controls.Add(Me.Txteventdetails)
        Me.Controls.Add(Me.Txteventprice)
        Me.Controls.Add(Me.Txteventname)
        Me.Controls.Add(Me.Lbleventlocation)
        Me.Controls.Add(Me.Lbleventdetails)
        Me.Controls.Add(Me.Lbleventprice)
        Me.Controls.Add(Me.LblEventname)
        Me.Controls.Add(Me.BtnClose4)
        Me.Controls.Add(Me.Lbladdevent)
        Me.Controls.Add(Me.Btnsubmitevent)
        Me.Name = "Addevent"
        Me.Text = "Add Event"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Btnsubmitevent As Button
    Friend WithEvents Lbladdevent As Label
    Friend WithEvents BtnClose4 As Button
    Friend WithEvents LblEventname As Label
    Friend WithEvents Lbleventprice As Label
    Friend WithEvents Lbleventdetails As Label
    Friend WithEvents Lbleventlocation As Label
    Friend WithEvents Txteventname As TextBox
    Friend WithEvents Txteventprice As TextBox
    Friend WithEvents Txteventdetails As TextBox
    Friend WithEvents Txteventlocation As TextBox
End Class
