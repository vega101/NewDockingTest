Imports System.Collections.ObjectModel
Imports System.ComponentModel

Public Class vmLayouts
    Implements INotifyPropertyChanged

    Private _LayoutCollection As ObservableCollection(Of mLayout)
    Private _CurrentLayout As mLayout

    Public Property LayoutCollection() As ObservableCollection(Of mLayout)
        Get
            Return Me._LayoutCollection
        End Get
        Set
            Me._LayoutCollection = Value
            NotifyPropertyChanged("LayoutCollection")
        End Set
    End Property

    Public Property CurrentLayout() As mLayout
        Get
            Return Me._CurrentLayout
        End Get
        Set(value As mLayout)
            Me._CurrentLayout = value
            NotifyPropertyChanged("CurrentLayout")
        End Set
    End Property

    Public Event PropertyChanged(sender As Object, e As PropertyChangedEventArgs) Implements INotifyPropertyChanged.PropertyChanged

    Public Sub NotifyPropertyChanged(propertyName As String)
        RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(propertyName))
    End Sub

    Public Sub New()
        LayoutCollection = New ObservableCollection(Of mLayout)

        LayoutCollection.Add(New mLayout With {.LayoutControl = New ucLayout1})
        LayoutCollection.Add(New mLayout With {.LayoutControl = New ucLayout2})

        CurrentLayout = LayoutCollection(0)

    End Sub
End Class
