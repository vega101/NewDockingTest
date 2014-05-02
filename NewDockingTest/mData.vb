Imports System.Collections.ObjectModel

Public Class mData
    Private _Name As String
    Private _IsNodalFolder As Boolean
    Private _SubColumns As ObservableCollection(Of mData)

    Public Sub New(name As String, isNodalFolder As Boolean, subColumns As ObservableCollection(Of mData))
        Me._Name = name
        Me._IsNodalFolder = isNodalFolder
        Me._SubColumns = subColumns
    End Sub

    Public Sub New(name As String)
        Me._Name = name
    End Sub

    Public Property Name() As String
        Get
            Return Me._Name
        End Get
        Set(value As String)
            Me._Name = value
        End Set
    End Property

    Public Property IsNodalFolder() As Boolean
        Get
            Return Me._IsNodalFolder
        End Get
        Set(value As Boolean)
            Me._IsNodalFolder = Value
        End Set
    End Property

    Public Property SubColumns() As ObservableCollection(Of mData)
        Get
            Return Me._SubColumns
        End Get
        Set(value As ObservableCollection(Of mData))
            Me._SubColumns = Value
        End Set
    End Property

End Class
