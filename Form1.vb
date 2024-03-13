Imports System.Xml.Schema

Public Class Form1
    'Miguel A. Melendez Hernandez
    'Y00598196
    'PROYECTO TIENDA VOLLEYBALL



    'BOTON ANADIR'

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnAnadir.Click
        'Variables
        Dim totalIngresos As Integer = 0
        Dim totalnivel As Integer = 0
        Dim totalnivel2 As Integer = 0
        Dim totalnivel3 As Integer = 0
        Dim totalAsistencia As Integer = 0
        Dim dia As Integer = 1

        'Constantes
        Const cmultiplicar As Integer = 20
        Const cmultiplicar_1 As Integer = 15
        Const cmultiplicar_2 As Integer = 10

        ' Lista para almacenar los nombres de los días de la semana
        Dim DiasDeSemana As New List(Of String) From {"Lunes", "Martes", "Miércoles", "Jueves", "Viernes", "Sábado", "Domingo"}

        Dim Resultado As String = ""
        Do While dia <= 7
            Try


                ' CANTIDAD DE ASIENTOS VENDIDOS
                Dim nivel1 As Integer = CInt(InputBox("Ingrese los datos del Nivel 1 " & DiasDeSemana(dia - 1)))

                Dim nivel2 As Integer = CInt(InputBox("Ingrese los datos del Nivel 2 " & DiasDeSemana(dia - 1)))

                Dim nivel3 As Integer = CInt(InputBox("Ingrese los datos del Nivel 3 " & DiasDeSemana(dia - 1)))

                ' CALCULA Y SE AGREGA AL RESULTADO
                Dim ingresoDia As Integer = nivel1 * cmultiplicar + nivel2 * cmultiplicar_1 + nivel3 * cmultiplicar_2
                Dim total1 As Integer = nivel1 * cmultiplicar
                Dim total2 As Integer = nivel2 * cmultiplicar_1
                Dim total3 As Integer = nivel3 * cmultiplicar_2

                Dim ingresoporDia As Integer = nivel1 + nivel2 + nivel3

                TotalSemanal.Items.Add(Resultado)
                TotalSemanal.Items.Add((DiasDeSemana(dia - 1)))
                TotalSemanal.Items.Add("Nivel 1:" & vbCrLf & nivel1.ToString())
                TotalSemanal.Items.Add("Nivel 2:" & vbCrLf & nivel2.ToString())
                TotalSemanal.Items.Add("Nivel 3:" & vbCrLf & nivel3.ToString())
                TotalSemanal.Items.Add("Total de Asistencia" & totalAsistencia)
                TotalSemanal.Items.Add(Resultado)
                TotalSemanal.Items.Add("Total Semanal: " & totalIngresos.ToString("c2"))
                TotalSemanal.Items.Add("")

                ' TOTAL DE INGRESOS POR DIA
                totalIngresos += ingresoDia
                totalnivel += nivel1
                totalnivel2 += nivel2
                totalnivel3 += nivel3
                totalAsistencia = totalnivel + totalnivel2 + totalnivel3
            Catch ex As Exception
                MessageBox.Show("Por favor, ingrese datos válidos para el día " & DiasDeSemana(dia - 1))
                Exit Sub
            End Try
            dia += 1
        Loop


    End Sub

    'Boton Borrar
    Private Sub btnBorrar_Click_1(sender As Object, e As EventArgs) Handles btnBorrar.Click

        TotalSemanal.Items.Clear()
    End Sub
    'Boton Salir
    Private Sub btnSalir_Click_1(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub
End Class