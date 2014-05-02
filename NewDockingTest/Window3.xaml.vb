Imports EQATEC.Analytics.Monitor

Public Class Window3

    Private Coll As New List(Of mData)
    Private monitor As IAnalyticsMonitor

    Private Sub btnStart_Click_1(sender As Object, e As RoutedEventArgs)

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

        MessageBox.Show(Coll.Count.ToString)

    End Sub

    Private Sub btnQuery_Click_1(sender As Object, e As RoutedEventArgs)

        Dim namequery = From q In Coll Skip 100000 Take 50000 Select q.Name

        lb1.ItemsSource = namequery

    End Sub



    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        monitor = AnalyticsMonitorFactory.CreateMonitor("4DB8F1F489AA41FA9B41CDD8D050D5BB")
        Try
            monitor.Start()
        Catch ex As Exception
            MessageBox.Show("Could not start")
        End Try

    End Sub

    Private Sub Window3_Closing(sender As Object, e As ComponentModel.CancelEventArgs) Handles Me.Closing
        monitor.Stop()
    End Sub
End Class

Public Module Mod1
    <System.Runtime.CompilerServices.Extension> _
    Public Iterator Function DistinctBy(Of TSource, TKey)(source As IEnumerable(Of TSource), keySelector As Func(Of TSource, TKey)) As IEnumerable(Of TSource)
        Dim seenKeys As New HashSet(Of TKey)()
        For Each element As TSource In source
            If seenKeys.Add(keySelector(element)) Then
                Yield element
            End If
        Next
    End Function
End Module
