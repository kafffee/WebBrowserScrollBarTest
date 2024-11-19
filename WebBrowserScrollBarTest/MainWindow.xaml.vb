Option Strict On

Class MainWindow
    Private Sub Label_MouseLeftButtonDown(sender As Object, e As MouseButtonEventArgs)
        DragMove()
    End Sub

    Private Sub brdSchliessen_MouseLeftButtonDown(sender As Object, e As MouseButtonEventArgs)

        Me.Close()
    End Sub
End Class
