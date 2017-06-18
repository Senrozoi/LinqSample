''' <summary>
''' abstractFactoryパターンでいうファクトリクラス
''' </summary>
''' <remarks></remarks>
Public Class StreamSorceFactory

    ''' <summary>
    ''' 指定されたソースに対応するIStreamSorceの実装のインスタンスを返します。
    ''' </summary>
    ''' <param name="Sorce"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function Create(ByVal Sorce As StreamSorceType) As IStreamSorce

        Dim StreamSorceImple As IStreamSorce

        Select Case Sorce

            Case StreamSorceType.EXCEL
                StreamSorceImple = New ExcelStreamSorce

            Case StreamSorceType.MDB
                StreamSorceImple = New MdbStreamSorce

            Case StreamSorceType.ACCDB
                StreamSorceImple = New AccdbStreamSorce

            Case StreamSorceType.XML
                StreamSorceImple = New XmlStreamSorce

            Case Else
                Throw New ArgumentException("実装されていないデータソースを指定してませんかね・・?")
        End Select
        Return StreamSorceImple

    End Function
End Class
