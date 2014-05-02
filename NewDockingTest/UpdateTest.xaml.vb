Imports System.Threading
Imports System.Threading.Tasks

Public Class UpdateTest

    Public Sub New()

        InitializeComponent()


    End Sub

    Private Sub btn1_Click_1(sender As Object, e As RoutedEventArgs)
        'txb1.Text = "Done"
        bi1.Visibility = Windows.Visibility.Visible

        Dim t As New Task(New Action(AddressOf DoWork))
        t.Start()

        'Application.Current.Dispatcher.BeginInvoke(New Action(AddressOf DoWork), Windows.Threading.DispatcherPriority.ContextIdle)
    End Sub


    Private Sub DoWork()
        For i = 0 To 1000000000
            Dim x = i + 1
        Next
        Application.Current.Dispatcher.BeginInvoke(New Action(AddressOf Done), Windows.Threading.DispatcherPriority.ContextIdle)

    End Sub

    Private Sub Done()
        bi1.Visibility = Windows.Visibility.Collapsed



    End Sub

    

End Class
