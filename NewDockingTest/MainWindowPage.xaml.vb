Class MainWindowPage

    Private vm As vmLayouts

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        vm = New vmLayouts
        Me.DataContext = vm


    End Sub

    Private Sub btnlayout1_Click_1(sender As Object, e As RoutedEventArgs)
        vm.CurrentLayout = vm.LayoutCollection(0)
    End Sub

    Private Sub btnlayout2_Click_1(sender As Object, e As RoutedEventArgs)
        vm.CurrentLayout = vm.LayoutCollection(1)
    End Sub
End Class
