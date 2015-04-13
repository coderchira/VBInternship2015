Public Class Product
    Private _name As String
    Public Property Name() As String
        Get
            Return _name
        End Get
        Set(ByVal value As String)
            _name = value
        End Set
    End Property
    Private _brand As String
    Public Property Brand() As String
        Get
            Return _brand
        End Get
        Set(ByVal value As String)
            _brand = value
        End Set
    End Property
    Private _color As String
    Public Property Color() As String
        Get
            Return _color
        End Get
        Set(ByVal value As String)
            _color = value
        End Set
    End Property


End Class
