Class MainWindow
    Dim ViewModel As New MainViewModel(modelo)
    Private Sub Button_Click(sender As Object, e As RoutedEventArgs)
        Grid1.DataContext = ViewModel
    End Sub

    Private Sub ListBox_MouseDoubleClick(sender As Object, e As MouseButtonEventArgs)
        Dim f As New Window1(lb.SelectedItem)
        f.ShowDialog()
        ViewModel = New MainViewModel(modelo)
        Grid1.DataContext = ViewModel
    End Sub
End Class
