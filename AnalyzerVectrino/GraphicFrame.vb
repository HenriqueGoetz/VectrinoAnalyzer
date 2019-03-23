Imports System.IO
Imports System.Text
Imports System.Windows.Forms.DataVisualization.Charting

Public Class GraphicFrame

    Private probe1 As ArrayList
    Private probe2 As ArrayList
    Private probe3 As ArrayList


    Public Sub initializeGraphics()

        With Chart1
            'define o tipo de gráfico
            .Series(0).ChartType = DataVisualization.Charting.SeriesChartType.FastPoint
            .Series(0).Color = Color.Blue

            .Series.Add(1)
            .Series(1).ChartType = DataVisualization.Charting.SeriesChartType.FastPoint
            .Series(1).Color = Color.Brown

            .Series(0).LegendText = "Y"
            .Series(1).LegendText = "Y filtered"
            .ChartAreas(0).AxisY.Title = "Y"
            .ChartAreas(0).AxisX.Title = "X"

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

            'define o tipo de gráfico
            .Series(0).ChartType = DataVisualization.Charting.SeriesChartType.FastPoint
            .Series(0).Color = Color.Blue

            .Series.Add(1)
            .Series(1).ChartType = DataVisualization.Charting.SeriesChartType.FastPoint
            .Series(1).Color = Color.Brown

            .Series(0).LegendText = "Y"
            .Series(1).LegendText = "Y filtered"
            .ChartAreas(0).AxisY.Title = "Y"
            .ChartAreas(0).AxisX.Title = "X"

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

            'define o tipo de gráfico
            .Series(0).ChartType = DataVisualization.Charting.SeriesChartType.FastPoint
            .Series(0).Color = Color.Blue

            .Series.Add(1)
            .Series(1).ChartType = DataVisualization.Charting.SeriesChartType.FastPoint
            .Series(1).Color = Color.Brown

            .Series(0).LegendText = "Y"
            .Series(1).LegendText = "Y filtered"
            .ChartAreas(0).AxisY.Title = "Y"
            .ChartAreas(0).AxisX.Title = "X"

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

            For i As Integer = 0 To probe1.Count - 1
                arrayTimeY.Add(probe1(i).getTime())
                arrayY.Add(probe1(i).getYVel())
                If (probe1(i).getYCor() >= cor) Then
                    arrayTimeYFiltered.Add(probe1(i).getTime())
                    arrayYFiltered.Add(probe1(i).getYVel())
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

            For i As Integer = 0 To probe2.Count - 1
                arrayTimeY.Add(probe2(i).getTime())
                arrayY.Add(probe2(i).getYVel())
                If (probe2(i).getYCor() >= cor) Then
                    arrayTimeYFiltered.Add(probe2(i).getTime())
                    arrayYFiltered.Add(probe2(i).getYVel())
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

            For i As Integer = 0 To probe3.Count - 1
                arrayTimeY.Add(probe3(i).getTime())
                arrayY.Add(probe3(i).getYVel())
                If (probe3(i).getYCor() >= cor) Then
                    arrayTimeYFiltered.Add(probe3(i).getTime())
                    arrayYFiltered.Add(probe3(i).getYVel())
                End If
            Next

            .Series(0).Points.DataBindXY(arrayTimeY, arrayY)
            .Series(1).Points.DataBindXY(arrayTimeYFiltered, arrayYFiltered)

        End With

    End Sub

    Public Sub loadProbes(p1 As ArrayList, p2 As ArrayList, p3 As ArrayList)
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
                newFile.Append("Probe" & ";" & "Sample" & ";" & "Time" & ";" & "Y" & ";" & "Y-Cor" & ";" & " " & ";" & " " & ";" & "Probe" & ";" & "Sample" & ";" & "Time" & ";" & "Y" & ";" & "Y-Cor" & ";" & " " & ";" & " " & ";" & "Probe" & ";" & "Sample" & ";" & "Time" & ";" & "Y" & ";" & "Y-Cor")
                newFile.AppendLine()
                Dim i As Integer = 0
                While i < probe1.Count - 1
                    newFile.Append("0" & ";" & probe1(i).getSample() & ";" & probe1(i).getTime() & ";" & probe1(i).getYVel() & ";" & probe1(i).getYCor() & ";" & " " & ";" & " " & ";" & "1" & ";" & probe2(i).getSample() & ";" & probe2(i).getTime() & ";" & probe2(i).getYVel() & ";" & probe2(i).getYCor() & ";" & " " & ";" & " " & ";" & "2" & ";" & probe3(i).getSample() & ";" & probe3(i).getTime() & ";" & probe3(i).getYVel() & ";" & probe3(i).getYCor())
                    newFile.AppendLine()
                    i = i + 1
                End While

                Dim fs As FileStream = File.Create(savePathDialog.FileName & ".csv")
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
End Class