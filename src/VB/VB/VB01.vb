Public Class VB01
    Implements IVBSeries
    'Public Function GetValue() As Integer
    '    Return 3000
    'End Function

    Private Function IVBSeries_GetValue() As Integer Implements IVBSeries.GetValue
        Return 3000
    End Function
End Class
