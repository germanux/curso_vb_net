Imports System.Threading

Public Class Form_Thread
    Private trd1, trd2 As Thread

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        trd1 = New Thread(AddressOf ThreadTask)
        trd1.IsBackground = True
        trd1.Start()

        trd2 = New Thread(AddressOf ThreadTask)
        trd2.IsBackground = True
        trd2.Start()
        MessageBox.Show("HA TERMINADO LOAD")
    End Sub

    Shared contadorHilos As Integer

    Private Async Sub ThreadTask()
        Dim stp As Integer
        Dim numeroHilo As Integer
        Dim rnd As New Random()
        contadorHilos = contadorHilos + 1
        numeroHilo = contadorHilos

        stp = rnd.Next(3000, 6000)
        Thread.Sleep(stp)
        MessageBox.Show("HAN PASADO " & stp & " ms EN HILO " & numeroHilo)
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MessageBox.Show("This is the main thread")
    End Sub

    Private Sub ProgressBar1_Click(sender As Object, e As EventArgs) Handles ProgressBar1.Click

    End Sub
End Class
