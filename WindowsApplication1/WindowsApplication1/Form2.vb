Public Class SnakeInstellingen
    'De globale variabelen die  én in Snake form worden gebruikt én in SnakeInstellingen.
    Public AANGEPASTESNELHEIDSNAKE As Integer
    Public VELDAANTALKOLOMMEN As Integer
    Public VELDAANTALRIJEN As Integer
    Public Function Aantalkolommen() As Integer
        'Dit zorgt ervoor dat de programma niet kan crashen, als de gebruiker 0 intypt zorgt het toch voor dat het niet een
        'veld van 0 kolommen maakt. In plaats daarvan maakt het programma 3 kolommen. Idem bij het niets invullen van de textbox,
        'dan wordt de standaardgrootte (30 kolommen) aangenomen. Of bij het invoeren van een negatief getal.
        'Idem concept bij aantalrijen() én aangepastesnelheid()
        If txtAantalKolommen.Text = "" Then
            VELDAANTALKOLOMMEN = 30
        ElseIf txtAantalKolommen.Text = 0 Then
            VELDAANTALKOLOMMEN = 3
        ElseIf txtAantalKolommen.Text < 0 Then
            VELDAANTALKOLOMMEN = 3
        Else
            VELDAANTALKOLOMMEN = txtAantalKolommen.Text
        End If
        Return 0
    End Function
    Public Function Aantalrijen() As Integer
        If txtAantalRijen.Text = "" Then
            VELDAANTALRIJEN = 20
        ElseIf txtAantalRijen.Text = 0 Then
            VELDAANTALRIJEN = 3
        ElseIf txtAantalRijen.Text < 0 Then
            VELDAANTALRIJEN = 3
        Else
            VELDAANTALRIJEN = txtAantalRijen.Text
        End If
        Return 0
    End Function
    Public Function Aangepastesnelheid() As Integer
        If txtSnelheid.Text = "" Then
            AANGEPASTESNELHEIDSNAKE = 200
        ElseIf txtSnelheid.Text = 0 Then
            AANGEPASTESNELHEIDSNAKE = 15
        ElseIf txtSnelheid.Text < 0 Then
            AANGEPASTESNELHEIDSNAKE = 15
        Else
            AANGEPASTESNELHEIDSNAKE = txtSnelheid.Text
        End If
        Return 0
    End Function
    Private Sub BtnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        'Bij het drukken van de button Start krijgen de globale variabelen van SnakeInstellingen form hun waarden. 
        Aangepastesnelheid()
        Aantalkolommen()
        Aantalrijen()
        My.Forms.Snake.Show()
    End Sub
End Class

'http://www.iconarchive.com/show/animal-icons-by-martin-berube/snake-icon.html voor icon