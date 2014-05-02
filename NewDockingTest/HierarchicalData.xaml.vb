Imports System.Collections.ObjectModel

Public Class HierarchicalData

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        Dim coll As New ObservableCollection(Of mData)

        Dim subColumns As New ObservableCollection(Of mData)
        subColumns.Add(New mData("Sub1", False, Nothing))
        subColumns.Add(New mData("Sub2", False, Nothing))
        subColumns.Add(New mData("Sub3", False, Nothing))

        coll.Add(New mData("one", True, subColumns))
        coll.Add(New mData("two", True, subColumns))

        ic1.ItemsSource = coll

    End Sub

End Class
