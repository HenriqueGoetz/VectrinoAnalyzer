Public Class MainFrame

    Private probe1 As ArrayList = New ArrayList()
    Private probe2 As ArrayList = New ArrayList()
    Private probe3 As ArrayList = New ArrayList()

    Private Sub btnLoadVel_Click(sender As Object, e As EventArgs) Handles btnLoadVel.Click
        Dim openFileDialog As New OpenFileDialog()
        openFileDialog.InitialDirectory = "c:\"
        openFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*"
        openFileDialog.FilterIndex = 2
        openFileDialog.RestoreDirectory = True

        probe1.Clear()
        probe2.Clear()
        probe3.Clear()

        lblVel.Text = "Need to load."
        btnLoadCor.Enabled = False
        lblCor.Text = "Need to load."
        btnShowGraphic.Enabled = False

        If openFileDialog.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            Try
                Dim filePath = openFileDialog.FileName
                Using MyReader As New Microsoft.VisualBasic.FileIO.TextFieldParser(filePath)
                    MyReader.TextFieldType = Microsoft.VisualBasic.FileIO.FieldType.Delimited
                    MyReader.SetDelimiters(vbTab)

                    Dim currentRow() As String
                    currentRow = MyReader.ReadFields()
                    currentRow = MyReader.ReadFields()

                    While Not MyReader.EndOfData
                        Try
                            currentRow = MyReader.ReadFields()
                            If (Not (currentRow(0) = String.Empty)) Then
                                Select Case (currentRow(0))
                                    Case 0
                                        probe1.Add(New Data(currentRow(1), convert(currentRow(2)), convert(currentRow(5))))
                                    Case 1
                                        probe2.Add(New Data(currentRow(1), convert(currentRow(2)), convert(currentRow(5))))
                                    Case 2
                                        probe3.Add(New Data(currentRow(1), convert(currentRow(2)), convert(currentRow(5))))
                                End Select
                            End If
                        Catch ex As Microsoft.VisualBasic.FileIO.MalformedLineException
                            MsgBox("Line " & ex.Message & "is not valid and will be skipped.")
                        End Try
                    End While
                End Using

                btnLoadCor.Enabled = True
                lblVel.Text = "Ok."

            Catch Ex As Exception
                MessageBox.Show("Cannot read file from disk. Original error: " & Ex.Message)
            End Try
        End If
    End Sub

    Private Sub btnLoadCor_Click(sender As Object, e As EventArgs) Handles btnLoadCor.Click
        Dim openFileDialog As New OpenFileDialog()
        openFileDialog.InitialDirectory = "c:\"
        openFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*"
        openFileDialog.FilterIndex = 2
        openFileDialog.RestoreDirectory = True

        If openFileDialog.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            Try
                Dim filePath = openFileDialog.FileName
                Using MyReader As New Microsoft.VisualBasic.FileIO.TextFieldParser(filePath)

                    MyReader.TextFieldType = Microsoft.VisualBasic.FileIO.FieldType.Delimited
                    MyReader.SetDelimiters(vbTab)

                    Dim currentRow() As String
                    currentRow = MyReader.ReadFields()
                    currentRow = MyReader.ReadFields()

                    Dim count As Integer = 0
                    While Not MyReader.EndOfData
                        Try
                            currentRow = MyReader.ReadFields()
                            If (Not (currentRow(0) = String.Empty)) Then
                                Select Case (currentRow(0))
                                    Case 0
                                        probe1(currentRow(1) - 1).setYCor(currentRow(5)) ' CurrentRow(1) - 1 is the sample number in the Arraylist. CurrentRow(5) is the Ycor.
                                    Case 1
                                        probe2(currentRow(1) - 1).setYCor(currentRow(5)) ' CurrentRow(1) - 1 is the sample number in the Arraylist. CurrentRow(5) is the Ycor.                                    Case 2
                                    Case 2
                                        probe3(currentRow(1) - 1).setYCor(currentRow(5)) ' CurrentRow(1) - 1 is the sample number in the Arraylist. CurrentRow(5) is the Ycor.
                                End Select
                            End If
                        Catch ex As Microsoft.VisualBasic.FileIO.MalformedLineException
                            MsgBox("Line " & ex.Message & "is not valid and will be skipped.")
                        End Try
                    End While
                End Using
                lblCor.Text = "Ok."
                btnShowGraphic.Enabled = True
            Catch Ex As Exception
                MessageBox.Show("Cannot read file from disk. Original error: " & Ex.Message)
            End Try
        End If
    End Sub

    Private Sub btnShowGraphic_Click(sender As Object, e As EventArgs) Handles btnShowGraphic.Click

        Dim frame As GraphicFrame = New GraphicFrame()
        frame.initializeGraphics()
        frame.loadProbes(probe1, probe2, probe3)
        frame.putOnGraphics(80)  '80 is the default to Correlation filter.
        frame.ShowDialog()

    End Sub

    Private Function convert(Number As String) As Double
        Dim arrayNumber() As String = Split(Number, ",")
        Dim int As Integer = arrayNumber(0)
        Return int + (arrayNumber(1) / (10 ^ arrayNumber(1).Length))
    End Function

End Class