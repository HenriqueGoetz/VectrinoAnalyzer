Imports AnalyzerVectrino
Public Class Probe
    Private number As Integer
    Private data As ArrayList = New ArrayList()
    Private serialNumber As String
    Private port As String


    Public Sub Clear()
        data.Clear()
        serialNumber = String.Empty
        port = String.Empty
    End Sub

    Public Function getData() As ArrayList
        Return data
    End Function

    Public Sub setSerialNumber(value As String)
        serialNumber = value
    End Sub

    Public Function getSerialNumber() As String
        Return serialNumber
    End Function


    Public Sub setPort(value As String)
        port = value
    End Sub

    Public Function getPort() As String
        Return port
    End Function

End Class
