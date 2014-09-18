Public Class SplashScreen

    Private Sub SplashScreen_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        For i = 0 To progressBar.Maximum
            progressBar.Value = i
        Next
    End Sub

End Class