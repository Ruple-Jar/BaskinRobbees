Public Class Form1
    Public Playerfirst As Boolean

    Private Sub Form2button_Click(sender As Object, e As EventArgs) Handles Form2button.Click
        If Yes.Checked = True Then
            Playerfirst = True
        Else
            Playerfirst = False
        End If

        Form2.playerfirst = Playerfirst
        Form2.Show()
    End Sub
End Class
