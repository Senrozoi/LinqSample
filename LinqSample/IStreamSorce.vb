Public Interface IStreamSorce
    ''' <summary>
    ''' データソースのプロバイダ固有のIQueryableを返します。
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Function AsQueryable() As IQueryable(Of IPeeple)

    ''' <summary>
    ''' 現在の状態をデータソースに反映させます。
    ''' </summary>
    ''' <remarks></remarks>
    Sub Update()

End Interface
