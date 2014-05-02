Imports System.Collections.ObjectModel

Public Class winHasItems

    Private Coll As New ObservableCollection(Of mData)

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        Dim names As New List(Of String)
        names.Add("Bob")
        names.Add("Jane")
        names.Add("Freddy")
        names.Add("Bungle")
        names.Add("Zippy")

        For i = 1 To 1000000
            For Each item In names
                Coll.Add(New mData(item))
            Next
        Next

        radGridView.ItemsSource = Coll


    End Sub

    Private Sub btnAdd_Click_1(sender As Object, e As RoutedEventArgs)
        Coll.Add(New mData("Ray"))
    End Sub

    Private Sub btnRemove_Click_1(sender As Object, e As RoutedEventArgs)
        Coll.Clear()
    End Sub
End Class
