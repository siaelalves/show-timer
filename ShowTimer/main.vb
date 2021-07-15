Public Class main

    Dim startmove As Boolean = False

    Private Sub tm_Tick(sender As Object, e As EventArgs) Handles tm.Tick
        lblTm.Text = Now.ToString("HH:mm:ss")

    End Sub

    Private Sub main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblTm.Text = Now.ToString("HH:mm:ss")
    End Sub

    Private Sub lblTm_Click(sender As Object, e As EventArgs) Handles lblTm.Click
        If startmove = True Then
            startmove = False
            Return
        Else
            startmove = True
        End If

    End Sub

    Private Sub lblTm_MouseMove(sender As Object, e As MouseEventArgs) Handles lblTm.MouseMove
        'If startmove = True Then
        '    Me.Location = New System.Drawing.Point(CInt(MousePosition.X + (Me.Size.Width / 2)),
        '                                           CInt(MousePosition.Y + (Me.Size.Height / 2)))
        'End If
    End Sub

    Private Sub main_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        'Me.FormBorderStyle = Windows.Forms.FormBorderStyle.None
    End Sub

    Private Sub lblTm_DoubleClick(sender As Object, e As EventArgs) Handles lblTm.DoubleClick
        Me.FormBorderStyle = Windows.Forms.FormBorderStyle.Sizable
    End Sub
End Class
