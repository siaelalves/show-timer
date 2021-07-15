<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class main
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
        Me.lblTm = New System.Windows.Forms.Label()
        Me.tm = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'lblTm
        '
        Me.lblTm.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblTm.BackColor = System.Drawing.Color.White
        Me.lblTm.Font = New System.Drawing.Font("Arial", 144.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTm.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblTm.Location = New System.Drawing.Point(0, 0)
        Me.lblTm.Name = "lblTm"
        Me.lblTm.Size = New System.Drawing.Size(908, 264)
        Me.lblTm.TabIndex = 0
        Me.lblTm.Text = "Tempo"
        Me.lblTm.TextAlign = System.Drawing.ContentAlignment.BottomRight
        '
        'tm
        '
        Me.tm.Enabled = True
        Me.tm.Interval = 1000
        '
        'main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(909, 266)
        Me.Controls.Add(Me.lblTm)
        Me.Cursor = System.Windows.Forms.Cursors.SizeAll
        Me.KeyPreview = True
        Me.Name = "main"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "S H O W    T I M E R"
        Me.TopMost = True
        Me.TransparencyKey = System.Drawing.Color.White
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblTm As System.Windows.Forms.Label
    Friend WithEvents tm As System.Windows.Forms.Timer

End Class
