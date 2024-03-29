<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Removeevent
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
        Me.components = New System.ComponentModel.Container()
        Me.EfentDataSet = New Projecta.EfentDataSet()
        Me.ManagersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ManagersTableAdapter = New Projecta.EfentDataSetTableAdapters.ManagersTableAdapter()
        Me.EventsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EfentDataSet1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EfentDataSet1 = New Projecta.EfentDataSet()
        Me.EventsTableAdapter = New Projecta.EfentDataSetTableAdapters.EventsTableAdapter()
        Me.Btndelete = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Txteventname = New System.Windows.Forms.TextBox()
        Me.Lbleventname = New System.Windows.Forms.Label()
        Me.Btncloze = New System.Windows.Forms.Button()
        CType(Me.EfentDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ManagersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EventsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EfentDataSet1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EfentDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'EfentDataSet
        '
        Me.EfentDataSet.DataSetName = "EfentDataSet"
        Me.EfentDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ManagersBindingSource
        '
        Me.ManagersBindingSource.DataMember = "Managers"
        Me.ManagersBindingSource.DataSource = Me.EfentDataSet
        '
        'ManagersTableAdapter
        '
        Me.ManagersTableAdapter.ClearBeforeFill = True
        '
        'EventsBindingSource
        '
        Me.EventsBindingSource.DataMember = "Events"
        Me.EventsBindingSource.DataSource = Me.EfentDataSet1BindingSource
        '
        'EfentDataSet1BindingSource
        '
        Me.EfentDataSet1BindingSource.DataSource = Me.EfentDataSet1
        Me.EfentDataSet1BindingSource.Position = 0
        '
        'EfentDataSet1
        '
        Me.EfentDataSet1.DataSetName = "EfentDataSet"
        Me.EfentDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'EventsTableAdapter
        '
        Me.EventsTableAdapter.ClearBeforeFill = True
        '
        'Btndelete
        '
        Me.Btndelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btndelete.ForeColor = System.Drawing.Color.Red
        Me.Btndelete.Location = New System.Drawing.Point(104, 209)
        Me.Btndelete.Name = "Btndelete"
        Me.Btndelete.Size = New System.Drawing.Size(172, 48)
        Me.Btndelete.TabIndex = 0
        Me.Btndelete.Text = "Delete"
        Me.Btndelete.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(337, 124)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Label1"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(341, 64)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Label2"
        '
        'Txteventname
        '
        Me.Txteventname.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txteventname.Location = New System.Drawing.Point(317, 61)
        Me.Txteventname.Multiline = True
        Me.Txteventname.Name = "Txteventname"
        Me.Txteventname.Size = New System.Drawing.Size(281, 50)
        Me.Txteventname.TabIndex = 3
        '
        'Lbleventname
        '
        Me.Lbleventname.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbleventname.ForeColor = System.Drawing.Color.White
        Me.Lbleventname.Location = New System.Drawing.Point(39, 32)
        Me.Lbleventname.Name = "Lbleventname"
        Me.Lbleventname.Size = New System.Drawing.Size(254, 90)
        Me.Lbleventname.TabIndex = 4
        Me.Lbleventname.Text = "Enter event name"
        Me.Lbleventname.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Btncloze
        '
        Me.Btncloze.BackColor = System.Drawing.Color.Red
        Me.Btncloze.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btncloze.Location = New System.Drawing.Point(423, 209)
        Me.Btncloze.Name = "Btncloze"
        Me.Btncloze.Size = New System.Drawing.Size(175, 48)
        Me.Btncloze.TabIndex = 5
        Me.Btncloze.Text = "Close"
        Me.Btncloze.UseVisualStyleBackColor = False
        '
        'Removeevent
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Btncloze)
        Me.Controls.Add(Me.Lbleventname)
        Me.Controls.Add(Me.Txteventname)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Btndelete)
        Me.Name = "Removeevent"
        Me.Text = "Remove Event"
        CType(Me.EfentDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ManagersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EventsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EfentDataSet1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EfentDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents EfentDataSet As EfentDataSet
    Friend WithEvents ManagersBindingSource As BindingSource
    Friend WithEvents ManagersTableAdapter As EfentDataSetTableAdapters.ManagersTableAdapter
    Friend WithEvents EfentDataSet1BindingSource As BindingSource
    Friend WithEvents EfentDataSet1 As EfentDataSet
    Friend WithEvents EventsBindingSource As BindingSource
    Friend WithEvents EventsTableAdapter As EfentDataSetTableAdapters.EventsTableAdapter
    Friend WithEvents Btndelete As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Txteventname As TextBox
    Friend WithEvents Lbleventname As Label
    Friend WithEvents Btncloze As Button
End Class
