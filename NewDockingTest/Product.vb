Public Class Product
    Public Property Name() As String
        Get
            Return m_Name
        End Get
        Set(value As String)
            m_Name = value
        End Set
    End Property
    Private m_Name As String
    Public Property Quantity() As Integer
        Get
            Return m_Quantity
        End Get
        Set(value As Integer)
            m_Quantity = value
        End Set
    End Property
    Private m_Quantity As Integer
    Public Property Price() As Double
        Get
            Return m_Price
        End Get
        Set(value As Double)
            m_Price = value
        End Set
    End Property
    Private m_Price As Double
    Public Property [Date]() As DateTime
        Get
            Return m_Date
        End Get
        Set(value As DateTime)
            m_Date = value
        End Set
    End Property
    Private m_Date As DateTime
End Class
