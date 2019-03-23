Public Class Data
    Private sample As Integer
    Private time As Double
    Private YVel As Double
    Private YCor As Integer

    Public Sub New(sample As Integer, time As Double, yVel As Double)
        Me.sample = sample
        Me.time = time
        Me.YVel = yVel
    End Sub

    Public Sub setYCor(value As Integer)
        YCor = value
    End Sub

    Public Function getSample() As Integer
        Return sample
    End Function

    Public Function getTime() As Double
        Return time
    End Function

    Public Function getYVel() As Double
        Return YVel
    End Function

    Public Function getYCor() As Integer
        Return YCor
    End Function

End Class

