''' <summary>
''' 入れ物として機能する人間クラス
''' ただのプロパティ・・・・
''' </summary>
''' <remarks></remarks>
Public Class Peeple
    Implements IPeeple
    Private _id As Integer


    Public Sub New(ByVal ID As Integer)
        _id = ID
    End Sub

    Public ReadOnly Property ID As Integer Implements IPeeple.ID
        Get
            Return _id
        End Get
    End Property


    Public Property FamilyName As String = "" Implements IPeeple.FamilyName
    Public Property FirstName As String = "" Implements IPeeple.FirstName
    Public Property age As Integer = 0 Implements IPeeple.Age
    Public Property group As Integer = 0 Implements IPeeple.Group



End Class
