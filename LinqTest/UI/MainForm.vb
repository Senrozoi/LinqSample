Public Class MainForm

    Private _StreamSorce As IStreamSorce

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'セーフティTry-Catch
        Try
            ComboBox1.DataSource = System.Enum.GetValues(GetType(StreamSorceType))
        Catch ex As Exception
            MsgBox(ex.Message & vbCrLf & ex.StackTrace)
            Me.Close()
        End Try

    End Sub


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSorceLoad.Click
        'セーフティTry-Catch
        Try
            Dim Ssorce As StreamSorceType = DirectCast(ComboBox1.SelectedItem, StreamSorceType)
            Dim FT As New StreamSorceFactory
            _StreamSorce = FT.Create(Ssorce)
            Me.IPeepleBindingSource.DataSource = _StreamSorce.AsQueryable
        Catch ex As Exception
            MsgBox(ex.Message & vbCrLf & ex.StackTrace)
            Me.Close()
        End Try



        'Dim Query = From P In Peeples
        '            Where P.age > 50

        'Query = From P In Query
        '        Where P.PeepleID > 5

        'Dim Query = Peeples.Where(Function(P) P.age > 50).Where(Function(p) p.ID > 5)

    End Sub


    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        'セーフティTry-Catch
        Try
            If _StreamSorce Is Nothing Then
                Exit Sub
            End If
            _StreamSorce.Update()
        Catch ex As Exception
            MsgBox(ex.Message & vbCrLf & ex.StackTrace)
        End Try
        
    End Sub
End Class
