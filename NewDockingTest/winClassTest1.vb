Public Class winClassTest1


End Class

Public Class vBase

    Private _ItemID As Integer


    Public Property ItemID() As Integer
        Get
            Return Me._ItemID
        End Get
        Set
            Me._ItemID = Value
        End Set
    End Property

End Class

Public Class vChild
    Inherits vBase

    Private _ItemText As String

    Public Property ItemText() As String
        Get
            Return Me._ItemText
        End Get
        Set(value As String)
            Me._ItemText = Value
        End Set
    End Property

End Class
