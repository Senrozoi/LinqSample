Imports System.Linq.Expressions

Public Class ExpressionCreater(Of T)

    Private _Propertys() As System.Reflection.PropertyInfo

    Public Sub New()
        Dim t As Type = GetType(T)
        _Propertys = t.GetProperties
    End Sub


    ''' <summary>
    ''' 対象としている型のプロパティ一覧を取得します。
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function GetPropertyNames() As System.Reflection.PropertyInfo()
        Return _Propertys
    End Function


    Public Function CreateTree() As Expression(Of Func(Of String, Boolean))

    End Function





End Class
