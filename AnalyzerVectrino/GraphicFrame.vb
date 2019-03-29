Imports System.IO
Imports System.Text
Imports System.Windows.Forms.DataVisualization.Charting

Public Class GraphicFrame

    Private probe1 As Probe
    Private probe2 As Probe
    Private probe3 As Probe


    Public Sub initializeGraphics()

        With Chart1
            .Titles.Clear()
            .Titles.Add("Probe 0 -" & " " & probe1.getSerialNumber() & " - " & probe1.getPort())

            'define o tipo de gráfico
            .Series(0).ChartType = DataVisualization.Charting.SeriesChartType.FastPoint
            .Series(0).Color = Color.Blue
            .Series(0).MarkerSize = 1

            .Series.Add(1)
            .Series(1).ChartType = DataVisualization.Charting.SeriesChartType.FastPoint
            .Series(1).Color = Color.Brown
            .Series(1).MarkerSize = 1

            .Series(0).LegendText = "Y"
            .Series(1).LegendText = "Y filtered"
            .ChartAreas(0).AxisY.Title = "Speed"

            .ChartAreas(0).AxisX.Title = "Time"

            .ChartAreas(0).Area3DStyle.LightStyle = LightStyle.Simplistic
            'define a fonte e a cor
            .ChartAreas(0).AxisY.TitleFont = New Font("Times New Roman", 12, FontStyle.Bold)
            .ChartAreas(0).AxisY.TitleForeColor = Color.Blue
            'define a paleta de cores usada
            .Palette = ChartColorPalette.Chocolate
            'desabilita a exibição 3D
            .ChartAreas(0).Area3DStyle.Enable3D = False
        End With

        With Chart2
            .Titles.Clear()
            .Titles.Add("Probe 1 -" & " " & probe2.getSerialNumber() & " - " & probe2.getPort())
            'define o tipo de gráfico
            .Series(0).ChartType = DataVisualization.Charting.SeriesChartType.FastPoint
            .Series(0).Color = Color.Blue
            .Series(0).MarkerSize = 1

            .Series.Add(1)
            .Series(1).ChartType = DataVisualization.Charting.SeriesChartType.FastPoint
            .Series(1).Color = Color.Brown
            .Series(1).MarkerSize = 1

            .Series(0).LegendText = "Y"
            .Series(1).LegendText = "Y filtered"
            .ChartAreas(0).AxisY.Title = "Speed"
            .ChartAreas(0).AxisX.Title = "Time"

            .ChartAreas(0).Area3DStyle.LightStyle = LightStyle.Simplistic
            'define a fonte e a cor
            .ChartAreas(0).AxisY.TitleFont = New Font("Times New Roman", 12, FontStyle.Bold)
            .ChartAreas(0).AxisY.TitleForeColor = Color.Blue
            'define a paleta de cores usada
            .Palette = ChartColorPalette.Chocolate
            'desabilita a exibição 3D
            .ChartAreas(0).Area3DStyle.Enable3D = False
        End With

        With Chart3
            .Titles.Clear()
            .Titles.Add("Probe 2 -" & " " & probe3.getSerialNumber() & " - " & probe3.getPort())
            'define o tipo de gráfico
            .Series(0).ChartType = DataVisualization.Charting.SeriesChartType.FastPoint
            .Series(0).Color = Color.Blue
            .Series(0).MarkerSize = 1

            .Series.Add(1)
            .Series(1).ChartType = DataVisualization.Charting.SeriesChartType.FastPoint
            .Series(1).Color = Color.Brown
            .Series(1).MarkerSize = 1

            .Series(0).LegendText = "Y"
            .Series(1).LegendText = "Y filtered"
            .ChartAreas(0).AxisY.Title = "Speed"
            .ChartAreas(0).AxisX.Title = "Time"

            .ChartAreas(0).Area3DStyle.LightStyle = LightStyle.Simplistic
            'define a fonte e a cor
            .ChartAreas(0).AxisY.TitleFont = New Font("Times New Roman", 12, FontStyle.Bold)
            .ChartAreas(0).AxisY.TitleForeColor = Color.Blue
            'define a paleta de cores usada
            .Palette = ChartColorPalette.Chocolate
            'desabilita a exibição 3D
            .ChartAreas(0).Area3DStyle.Enable3D = False
        End With

    End Sub

    Public Sub putOnGraphics(cor As Integer)

        With Chart1
            Dim arrayTimeY As New ArrayList
            Dim arrayY As New ArrayList
            Dim arrayTimeYFiltered As New ArrayList
            Dim arrayYFiltered As New ArrayList

            For i As Integer = 0 To probe1.getData().Count - 1
                arrayTimeY.Add(probe1.getData()(i).getTime())
                arrayY.Add(probe1.getData()(i).getYVel())
                If (probe1.getData()(i).getYCor() >= cor) Then
                    arrayTimeYFiltered.Add(probe1.getData()(i).getTime())
                    arrayYFiltered.Add(probe1.getData()(i).getYVel())
                End If
            Next

            .Series(0).Points.DataBindXY(arrayTimeY, arrayY)
            .Series(1).Points.DataBindXY(arrayTimeYFiltered, arrayYFiltered)

        End With

        With Chart2
            Dim arrayTimeY As New ArrayList
            Dim arrayY As New ArrayList
            Dim arrayTimeYFiltered As New ArrayList
            Dim arrayYFiltered As New ArrayList

            For i As Integer = 0 To probe2.getData().Count - 1
                arrayTimeY.Add(probe2.getData()(i).getTime())
                arrayY.Add(probe2.getData()(i).getYVel())
                If (probe2.getData()(i).getYCor() >= cor) Then
                    arrayTimeYFiltered.Add(probe2.getData()(i).getTime())
                    arrayYFiltered.Add(probe2.getData()(i).getYVel())
                End If
            Next

            .Series(0).Points.DataBindXY(arrayTimeY, arrayY)
            .Series(1).Points.DataBindXY(arrayTimeYFiltered, arrayYFiltered)

        End With

        With Chart3
            Dim arrayTimeY As New ArrayList
            Dim arrayY As New ArrayList
            Dim arrayTimeYFiltered As New ArrayList
            Dim arrayYFiltered As New ArrayList

            For i As Integer = 0 To probe3.getData().Count - 1
                arrayTimeY.Add(probe3.getData()(i).getTime())
                arrayY.Add(probe3.getData()(i).getYVel())
                If (probe3.getData()(i).getYCor() >= cor) Then
                    arrayTimeYFiltered.Add(probe3.getData()(i).getTime())
                    arrayYFiltered.Add(probe3.getData()(i).getYVel())
                End If
            Next

            .Series(0).Points.DataBindXY(arrayTimeY, arrayY)
            .Series(1).Points.DataBindXY(arrayTimeYFiltered, arrayYFiltered)

        End With

    End Sub

    Public Sub loadProbes(p1 As Probe, p2 As Probe, p3 As Probe)
        probe1 = p1
        probe2 = p2
        probe3 = p3
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

        Dim savePathDialog As New SaveFileDialog()

        If savePathDialog.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            Try
                Dim newFile As New System.Text.StringBuilder()

                newFile.Append("Result of Vectrino Analyzer")
                newFile.AppendLine()
                newFile.AppendLine()
                newFile.Append("Correlation: " & ";" & txtBoxCor.Text)
                newFile.AppendLine()
                newFile.Append("Probe" & ";" & "SerialNumber" & ";" & "Port" & ";" & " " & ";" & " " & ";" & " " & ";" & " " & ";" & " " & ";" & "Probe" & ";" & "SerialNumber" & ";" & "Port" & ";" & " " & ";" & " " & ";" & " " & ";" & " " & ";" & " " & ";" & "Probe" & ";" & "SerialNumber" & ";" & "Port")
                newFile.AppendLine()
                newFile.Append("0" & ";" & probe1.getSerialNumber & ";" & probe1.getPort & ";" & " " & ";" & " " & ";" & " " & ";" & " " & ";" & " " & ";" & "1" & ";" & probe2.getSerialNumber & ";" & probe2.getPort & ";" & " " & ";" & " " & ";" & " " & ";" & " " & ";" & " " & ";" & "2" & ";" & probe3.getSerialNumber & ";" & probe3.getPort)
                newFile.AppendLine()
                newFile.Append("Sample" & ";" & "Time" & ";" & "Y" & ";" & "Y-Cor" & ";" & "Y-Filtered" & ";" & " " & ";" & " " & ";" & ";" & "Sample" & ";" & "Time" & ";" & "Y" & ";" & "Y-Cor" & ";" & "Y-Filtered" & ";" & " " & ";" & " " & ";" & ";" & "Sample" & ";" & "Time" & ";" & "Y" & ";" & "Y-Cor" & ";" & "Y-Filtered")
                newFile.AppendLine()
                Dim i As Integer = 0
                While i < probe1.getData().Count - 1
                    newFile.Append(probe1.getData()(i).getSample() & ";" & probe1.getData()(i).getTime() & ";" & probe1.getData()(i).getYVel() & ";" & probe1.getData()(i).getYCor() & ";" & filterY(probe1.getData()(i)) & ";" & " " & ";" & " " & ";" & ";" & probe2.getData()(i).getSample() & ";" & probe2.getData()(i).getTime() & ";" & probe2.getData()(i).getYVel() & ";" & probe2.getData()(i).getYCor() & ";" & filterY(probe2.getData()(i)) & ";" & " " & ";" & " " & ";" & ";" & probe3.getData()(i).getSample() & ";" & probe3.getData()(i).getTime() & ";" & probe3.getData()(i).getYVel() & ";" & probe3.getData()(i).getYCor() & ";" & filterY(probe3.getData()(i)))
                    newFile.AppendLine()
                    i = i + 1
                End While

                Dim fs As FileStream = File.Create(savePathDialog.FileName & ".txt")
                Dim info As Byte() = New UTF8Encoding(True).GetBytes(newFile.ToString)
                fs.Write(info, 0, info.Length)
                fs.Close()

            Catch Ex As Exception
                MessageBox.Show("Cannot read the folder path. Original error: " & Ex.Message)
            End Try
        End If
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        If (IsNumeric(txtBoxCor.Text)) Then
            putOnGraphics(txtBoxCor.Text)
            Me.Refresh()
        End If
    End Sub

    Private Function filterY(data As Data)
        If (txtBoxCor.Text <= data.getYCor) Then
            Return data.getYVel
        Else
            Return -999999
        End If
    End Function
End Class