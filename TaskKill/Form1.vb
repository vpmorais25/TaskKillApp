﻿Public Class Form1

    Dim Process As String


    Private Sub taskkill()

        Shell("PowerShell /c taskkill /f /im " + Process)

    End Sub

    Private Sub Bkill_Click(sender As Object, e As EventArgs) Handles Bkill.Click

        Process = TBprocesso.Text

        Select Case MsgBox("EXECUTAR COMANDO KILL  " + Process + "  ???", vbYesNo)
            Case MsgBoxResult.Yes
                taskkill()
            Case MsgBoxResult.No
                MsgBox("NAO EXECUTADO")
        End Select

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TBprocesso.Text = "excel.exe"
    End Sub
End Class
