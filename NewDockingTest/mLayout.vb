Imports System.ComponentModel

Public Class mLayout
    Implements INotifyPropertyChanged

    Private _LayoutControl As UserControl

    Public Property LayoutControl() As UserControl
        Get
            Return Me._LayoutControl
        End Get
        Set(value As UserControl)
            Me._LayoutControl = value
            NotifyPropertyChanged("LayoutControl")
        End Set
    End Property

    Public Event PropertyChanged(sender As Object, e As PropertyChangedEventArgs) Implements INotifyPropertyChanged.PropertyChanged

    Public Sub NotifyPropertyChanged(propertyName As String)
        RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(propertyName))
    End Sub

End Class
