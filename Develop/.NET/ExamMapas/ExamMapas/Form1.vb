Imports System.Text

Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If TextBox1.Text = String.Empty Or TextBox2.Text = String.Empty Then

            MessageBox.Show("Captura las coordenadas .", "Missing Data")

        End If



        Try

            Dim lat As String = String.Empty

            Dim lon As String = String.Empty


            Dim queryAddress As New StringBuilder()

            queryAddress.Append("http://maps.google.com/maps?q=")



            ' build latitude part of query string

            If TextBox1.Text <> String.Empty Then

                lat = TextBox1.Text

                queryAddress.Append(lat + "%2C")

            End If



            ' build longitude part of query string

            If TextBox2.Text <> String.Empty Then

                lon = TextBox2.Text

                queryAddress.Append(lon)

            End If



            WebBrowser1.Navigate(queryAddress.ToString())



        Catch ex As Exception



            MessageBox.Show(ex.Message.ToString(), "Error")



        End Try


    End Sub
End Class
