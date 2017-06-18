Public Class XmlPeeple
    Implements IPeeple

    Private _Element As System.Xml.Linq.XElement

    Public Sub New(ByVal EmlElement As System.Xml.Linq.XElement)
        _Element = EmlElement
    End Sub


    Public Property age As Integer Implements IPeeple.Age
        Get
            Return CInt(_Element.Element("age").Value)
        End Get
        Set(ByVal value As Integer)
            _Element.Element("age").Value = value.ToString
        End Set
    End Property

    Public Property FamilyName As String Implements IPeeple.FamilyName
        Get
            Return _Element.Element("FamilyName").Value
        End Get
        Set(ByVal value As String)
            _Element.Element("FamilyName").Value = value
        End Set
    End Property

    Public Property FirstName As String Implements IPeeple.FirstName
        Get
            Return _Element.Element("FirstName").Value
        End Get
        Set(ByVal value As String)
            _Element.Element("FirstName").Value = value
        End Set
    End Property

    Public Property group As Integer Implements IPeeple.Group
        Get
            Return CInt(_Element.Element("group").Value)
        End Get
        Set(ByVal value As Integer)
            _Element.Element("group").Value = value.ToString
        End Set
    End Property

    Public ReadOnly Property ID As Integer Implements IPeeple.ID
        Get
            Return CInt(_Element.Attribute("ID").Value)
        End Get
    End Property
End Class
