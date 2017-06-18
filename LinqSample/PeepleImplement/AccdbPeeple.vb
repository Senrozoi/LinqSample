Public Class AccdbPeeple
    Implements IPeeple
    Private _Row As AccdbDataset.peeplesRow

    Public Sub New(ByVal Row As AccdbDataset.peeplesRow)
        _Row = Row
    End Sub

    Public Property age As Integer Implements IPeeple.Age
        Get
            Return _Row.age
        End Get
        Set(ByVal value As Integer)
            _Row.age = value
        End Set
    End Property

    Public Property FamilyName As String Implements IPeeple.FamilyName
        Get
            Return _Row.FamilyName
        End Get
        Set(ByVal value As String)
            _Row.FamilyName = value
        End Set
    End Property

    Public Property FirstName As String Implements IPeeple.FirstName
        Get
            Return _Row.FirstName
        End Get
        Set(ByVal value As String)
            _Row.FirstName = value
        End Set
    End Property

    Public Property group As Integer Implements IPeeple.Group
        Get
            Return _Row.group
        End Get
        Set(ByVal value As Integer)
            _Row.group = value
        End Set
    End Property

    Public ReadOnly Property ID As Integer Implements IPeeple.ID
        Get
            Return _Row.ID
        End Get
    End Property
End Class
