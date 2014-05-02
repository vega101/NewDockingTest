Public Class FilterItemTemplateSelector
    Inherits DataTemplateSelector

    Private _IsSourceTemplate As DataTemplate
    Private _IsFilterTemplate As DataTemplate

    Public Overrides Function SelectTemplate(item As Object, container As DependencyObject) As DataTemplate
        If TypeOf item Is mData Then
            Dim source As mData = TryCast(item, mData)
            If source.IsNodalFolder Then
                Return IsSourceTemplate
            Else
                Return IsFilterTemplate
            End If
        End If
        Return Nothing
    End Function

    Public Property IsSourceTemplate() As DataTemplate
        Get
            Return Me._IsSourceTemplate
        End Get
        Set(value As DataTemplate)
            Me._IsSourceTemplate = value
        End Set
    End Property

    Public Property IsFilterTemplate() As DataTemplate
        Get
            Return Me._IsFilterTemplate
        End Get
        Set(value As DataTemplate)
            Me._IsFilterTemplate = value
        End Set
    End Property
End Class