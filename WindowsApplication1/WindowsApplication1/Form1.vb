Option Explicit On
Option Strict On

Public Class Snake
    'Matrix van 30 breed (tot 29) en 20 hoog (tot 19): ingevoerde waarde zorgt voor gewenste resultaat +1,
    'daarom dat er bij aantalkolommen en aantalrijen -1 staan.
    ReadOnly VELD(SnakeInstellingen.VELDAANTALKOLOMMEN - 1, SnakeInstellingen.VELDAANTALRIJEN - 1) As Label
    'Dimensies van de beginpositie van de slang. Voor geen fouten te voorkomen zorg ik voor een dynamische startpositie van
    'de slang i.p.v. een  statische. 
    ReadOnly XSLANGBEGINPOSITIE As Integer = CInt((SnakeInstellingen.VELDAANTALKOLOMMEN / 2))
    ReadOnly YSLANGBEGINPOSITIE As Integer = CInt((SnakeInstellingen.VELDAANTALRIJEN / 2))
    'Toetsen voor het laten voortbewegen van de slang in het begin op False zetten zodat er in het begin niets gebeurt.
    Private PIJLOMHOOG As Boolean = False
    Private PIJLOMLAAG As Boolean = False
    Private PIJLLINKS As Boolean = False
    Private PIJLRECHTS As Boolean = False
    'Algemene kleuren van het spel zodat kleuraanpassingen snel gemaakt kunnen worden
    ReadOnly SLANGKLEUR As Color = Color.Black
    ReadOnly VELDKLEUR As Color = Color.White
    ReadOnly APPELKLEUR As Color = Color.Red
    'Bij initialisatie voor elk coordinaatpositie een nieuwe lijst maken
    Private OUDEXLIJST As List(Of Integer) = New List(Of Integer)
    Private OUDEYLIJST As List(Of Integer) = New List(Of Integer)
    Private NIEUWEXLIJST As List(Of Integer) = New List(Of Integer)
    Private NIEUWEYLIJST As List(Of Integer) = New List(Of Integer)
    Private Sub Snake_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Wanneer het spel start, komt er een speeldveld, een beginslang, een appel met een random positie tevoorschijn. De gameover scherm is dan niet
        'geactiveerd en de timer staat aan voor wanneer je een toets wil indrukken.
        Verschijnenvanbord()
        Verschijnbeginslang()
        Verschijnappel()
        Me.KeyPreview = True
        tmrTime.Enabled = True
        tmrScore.Enabled = True
        txtGameOver.Visible = False
    End Sub
    Private Sub BtnNieuwSpel_Click(sender As Object, e As EventArgs) Handles btnNieuwSpel.Click
        'Bij het drukken van button NieuwSpel wordt het spelbord gereset, wordt elk lijst leeggemaakt, verschijnt er een nieuw slang, een appel op een
        'random positie en krijgt de Huidige Score de waarde 0. De game over textbox verdwijnt dan ook.
        Resethetveld()
        Resetdelijst()
        Verschijnbeginslang()
        Verschijnappel()
        tmrTime.Enabled = True
        tmrScore.Enabled = True
        txtGameOver.Visible = False
        lblHuidige.Text = CType(0, String)
        lblHuidigeTimerSec.Text = CType(0, String)
        lblHuidigeTimerMin.Text = CType(0, String)
    End Sub
    Public Function Verschijnappel() As Integer
        'Dimensies van de random locatie van beginpositie van de appel
        Dim RANDOM As System.Random = New Random()
        Dim XAPPEL As Integer = RANDOM.Next(0, VELD.GetLength(0) - 1)
        Dim YAPPEL As Integer = RANDOM.Next(0, VELD.GetLength(1) - 1)
        'Zolang de appel dezelfde coördinaten heeft als de beginpositie van de slang, dan moet het op een andere plaats verschijnen.
        While VELD(XAPPEL, YAPPEL).BackColor = SLANGKLEUR
            RANDOM = New Random()
            XAPPEL = RANDOM.Next(0, VELD.GetLength(0) - 1)
            YAPPEL = RANDOM.Next(0, VELD.GetLength(1) - 1)
        End While
        'Kleurgeving van de appel
        VELD(XAPPEL, YAPPEL).BackColor = APPELKLEUR
        Return 0
    End Function
    Public Function Verschijnbeginslang() As Integer
        'Dit laat een nieuwe zwarte slangenkop spawnen in het (ongeveer) midden van het veld)
        OUDEXLIJST.Add(XSLANGBEGINPOSITIE)
        OUDEYLIJST.Add(YSLANGBEGINPOSITIE)
        NIEUWEXLIJST.Add(XSLANGBEGINPOSITIE)
        NIEUWEYLIJST.Add(YSLANGBEGINPOSITIE)
        'Kleur van de slang
        VELD(OUDEXLIJST(0), OUDEYLIJST(0)).BackColor = SLANGKLEUR
        Return 0
    End Function
    Public Function Verschijnenvanbord() As Integer
        'Zorgt voor het verschijnen van het speelbord
        For i As Integer = VELD.GetLowerBound(0) To VELD.GetUpperBound(0)
            For j As Integer = VELD.GetLowerBound(1) To VELD.GetUpperBound(1)
                'x,y locatie in het venster
                'zorgt voor een duidelijke onderscheiding tussen elk blokje
                'kleur van het vierkantje
                VELD(i, j) = New Label With {
                    .Size = New Size(20, 20),
                    .Name = "tile_" & i & "_" & j,
                    .Location = New Point(20 * i + 125, 20 * j),
                    .BorderStyle = BorderStyle.Fixed3D,
                    .BackColor = VELDKLEUR
                }
                'voeg toe aan GUI
                Me.Controls.Add(VELD(i, j))
            Next
        Next
        Return 0
    End Function
    Public Function Resetdelijst() As Integer
        'Alle waarden van de lijsten gaan weg.
        OUDEXLIJST = New List(Of Integer)
        OUDEYLIJST = New List(Of Integer)
        NIEUWEXLIJST = New List(Of Integer)
        NIEUWEYLIJST = New List(Of Integer)
        Return 0
    End Function
    Public Function Resethetveld() As Integer
        'Alle veldvakjes die niet de kleur hebben van het veld, krijgen de kleur van het veld
        For i As Integer = VELD.GetLowerBound(0) To VELD.GetUpperBound(0)
            For j As Integer = VELD.GetLowerBound(1) To VELD.GetUpperBound(1)
                If Not VELD(i, j).BackColor = VELDKLEUR Then
                    VELD(i, j).BackColor = VELDKLEUR
                End If
            Next
        Next
        Return 0
    End Function
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles tmrTime.Tick
        'De timer zorgt voor een tick om de 200ms/15ms/ of de toegestane waarde.
        tmrTime.Interval = SnakeInstellingen.AANGEPASTESNELHEIDSNAKE
        'Bij elke beweging voert het een aantal checkt uit.
        If PIJLLINKS Then
            If Controleerlinks() Then
                If Controleerlinksappel() Then
                    Beweeglinksappel()
                Else
                    Beweeglinks()
                End If
            Else
                Gameover()
            End If
        ElseIf PIJLRECHTS Then
            If Controleerrechts() Then
                If Controleerrechtsappel() Then
                    Beweegrechtsappel()
                Else
                    Beweegrechts()
                End If
            Else
                Gameover()
            End If
        ElseIf PIJLOMHOOG Then
            If Controleeromhoog() Then
                If Controleeromhoogappel() Then
                    Beweegomhoogappel()
                Else
                    Beweegomhoog()
                End If
            Else
                Gameover()
            End If
        ElseIf PIJLOMLAAG Then
            If Controleeromlaag() Then
                If Controleeromlaagappel() Then
                    Beweegomlaagappel()
                Else
                    Beweegomlaag()
                End If
            Else
                Gameover()
            End If
        End If
    End Sub
    Private Sub TmrScore_Tick(sender As Object, e As EventArgs) Handles tmrScore.Tick
        lblHuidigeTimerSec.Text = CType(CInt(lblHuidigeTimerSec.Text) + 1, String)
        If CInt(lblHuidigeTimerSec.Text) > 59 Then
            lblHuidigeTimerSec.Text = CType(0, String)
            lblHuidigeTimerMin.Text = CType(CInt(lblHuidigeTimerMin.Text) + 1, String)
        End If
    End Sub
    Public Function Controleerlinks() As Boolean
        'Als de x waarde van de slang kleiner is dan nul, dan geeft het false terug 
        'waardoor je terrechtkomt bij de gameover() functie. Dan stopt het spel.
        'Idem concept bij controleerrechts(),controleeromhoog(),controleeromlaag().
        If OUDEXLIJST(0) - 1 < VELD.GetLowerBound(0) Then
            VELD(OUDEXLIJST(0), OUDEYLIJST(0)).BackColor = VELDKLEUR
            OUDEXLIJST(0) = VELD.GetUpperBound(0)
            'Return False
        End If
        'Als de kleur van het vakje richting de beweging (links) zwart is, dus uw slang, 
        'dan kom je terrecht bij de gameover() functie. Dan stopt het spel.
        'Idem concept bij controleerrechts(),controleeromhoog(),controleeromlaag().
        If VELD(OUDEXLIJST(0) - 1, OUDEYLIJST(0)).BackColor = SLANGKLEUR Then
            Return False
        End If
        Return True
    End Function
    Public Function Controleerrechts() As Boolean
        If OUDEXLIJST(0) + 1 > VELD.GetUpperBound(0) Then
            VELD(OUDEXLIJST(0), OUDEYLIJST(0)).BackColor = VELDKLEUR
            OUDEXLIJST(0) = VELD.GetLowerBound(0)
            'Return False
        End If
        If VELD(OUDEXLIJST(0) + 1, OUDEYLIJST(0)).BackColor = SLANGKLEUR Then
            Return False
        End If
        Return True
    End Function
    Public Function Controleeromhoog() As Boolean
        If OUDEYLIJST(0) - 1 < VELD.GetLowerBound(1) Then
            VELD(OUDEXLIJST(0), OUDEYLIJST(0)).BackColor = VELDKLEUR
            OUDEYLIJST(0) = VELD.GetUpperBound(1)
            'Return False
        End If
        If VELD(OUDEXLIJST(0), OUDEYLIJST(0) - 1).BackColor = SLANGKLEUR Then
            Return False
        End If
        Return True
    End Function
    Public Function Controleeromlaag() As Boolean
        If OUDEYLIJST(0) + 1 > VELD.GetUpperBound(1) Then
            VELD(OUDEXLIJST(0), OUDEYLIJST(0)).BackColor = VELDKLEUR
            OUDEYLIJST(0) = VELD.GetLowerBound(1)
            'Return False
        End If
        If VELD(OUDEXLIJST(0), OUDEYLIJST(0) + 1).BackColor = SLANGKLEUR Then
            Return False
        End If
        Return True
    End Function
    Public Function Controleerlinksappel() As Boolean
        'Controleert of er links van de slang een vak is met de kleur rood of niet.
        'Idem concept met controleerrechtsappel(),controleeromhoogappel(),controleeromlaagappel().
        Return VELD(OUDEXLIJST(0) - 1, OUDEYLIJST(0)).BackColor = APPELKLEUR
    End Function
    Public Function Controleerrechtsappel() As Boolean
        Return VELD(OUDEXLIJST(0) + 1, OUDEYLIJST(0)).BackColor = APPELKLEUR
    End Function
    Public Function Controleeromhoogappel() As Boolean
        Return VELD(OUDEXLIJST(0), OUDEYLIJST(0) - 1).BackColor = APPELKLEUR
    End Function
    Public Function Controleeromlaagappel() As Boolean
        Return VELD(OUDEXLIJST(0), OUDEYLIJST(0) + 1).BackColor = APPELKLEUR
    End Function
    Public Function Beweeglinks() As Integer
        'Maak nieuwe lijst leeg
        NIEUWEXLIJST = New List(Of Integer)
        NIEUWEYLIJST = New List(Of Integer)
        'Voeg nieuw coordinaat toe
        NIEUWEXLIJST.Add(OUDEXLIJST(0) - 1)
        NIEUWEYLIJST.Add(OUDEYLIJST(0))
        For i As Integer = 0 To OUDEXLIJST.Count - 2
            NIEUWEXLIJST.Add(OUDEXLIJST(i))
            NIEUWEYLIJST.Add(OUDEYLIJST(i))
        Next
        Bordaanpassen()
        Return 0
    End Function
    Public Function Beweegrechts() As Integer
        'Maak nieuwe lijst leeg
        NIEUWEXLIJST = New List(Of Integer)
        NIEUWEYLIJST = New List(Of Integer)
        'Voeg nieuw coordinaat toe
        NIEUWEXLIJST.Add(OUDEXLIJST(0) + 1)
        NIEUWEYLIJST.Add(OUDEYLIJST(0))
        For i As Integer = 0 To OUDEXLIJST.Count - 2
            NIEUWEXLIJST.Add(OUDEXLIJST(i))
            NIEUWEYLIJST.Add(OUDEYLIJST(i))
        Next
        Bordaanpassen()
        Return 0
    End Function
    Public Function Beweegomhoog() As Integer
        'Maak nieuwe lijst leeg
        NIEUWEXLIJST = New List(Of Integer)
        NIEUWEYLIJST = New List(Of Integer)
        'Voeg nieuw coordinaat toe
        NIEUWEXLIJST.Add(OUDEXLIJST(0))
        NIEUWEYLIJST.Add(OUDEYLIJST(0) - 1)
        For i As Integer = 0 To OUDEXLIJST.Count - 2
            NIEUWEXLIJST.Add(OUDEXLIJST(i))
            NIEUWEYLIJST.Add(OUDEYLIJST(i))
        Next
        Bordaanpassen()
        Return 0
    End Function
    Public Function Beweegomlaag() As Integer
        'Maak nieuwe lijst leeg
        NIEUWEXLIJST = New List(Of Integer)
        NIEUWEYLIJST = New List(Of Integer)
        'Voeg nieuw coordinaat toe
        NIEUWEXLIJST.Add(OUDEXLIJST(0))
        NIEUWEYLIJST.Add(OUDEYLIJST(0) + 1)
        For i As Integer = 0 To OUDEXLIJST.Count - 2
            NIEUWEXLIJST.Add(OUDEXLIJST(i))
            NIEUWEYLIJST.Add(OUDEYLIJST(i))
        Next
        Bordaanpassen()
        Return 0
    End Function
    Public Function Beweeglinksappel() As Integer
        'De plaats waar de appel lag, wordt toevoegd aan de lijst van de slang. Dit zorgt voor het langer maken van de slang. 
        'Elke keer wanneer deze functie wordt uitgevoerd, worden er zoals de opgave vroeg 10 punten toegevoegd aan de label Huidige Score.
        'Hetzelfde geldt bij beweegrechtsappel,beweegomhoogappel, beweegomlaagappel.
        NIEUWEXLIJST = New List(Of Integer)
        NIEUWEYLIJST = New List(Of Integer)
        NIEUWEXLIJST.Add(OUDEXLIJST(0) - 1)
        NIEUWEYLIJST.Add(OUDEYLIJST(0))
        For i As Integer = 0 To OUDEXLIJST.Count - 1
            NIEUWEXLIJST.Add(OUDEXLIJST(i))
            NIEUWEYLIJST.Add(OUDEYLIJST(i))
        Next
        Bordaanpassen()
        Verschijnappel()
        lblHuidige.Text = CType(CInt(lblHuidige.Text) + 10, String)
        Return 0
    End Function
    Public Function Beweegrechtsappel() As Integer
        NIEUWEXLIJST = New List(Of Integer)
        NIEUWEYLIJST = New List(Of Integer)
        NIEUWEXLIJST.Add(OUDEXLIJST(0) + 1)
        NIEUWEYLIJST.Add(OUDEYLIJST(0))
        For i As Integer = 0 To OUDEXLIJST.Count - 1
            NIEUWEXLIJST.Add(OUDEXLIJST(i))
            NIEUWEYLIJST.Add(OUDEYLIJST(i))
        Next
        Bordaanpassen()
        Verschijnappel()
        lblHuidige.Text = CType(CInt(lblHuidige.Text) + 10, String)
        Return 0
    End Function
    Public Function Beweegomhoogappel() As Integer
        NIEUWEXLIJST = New List(Of Integer)
        NIEUWEYLIJST = New List(Of Integer)
        NIEUWEXLIJST.Add(OUDEXLIJST(0))
        NIEUWEYLIJST.Add(OUDEYLIJST(0) - 1)
        For i As Integer = 0 To OUDEXLIJST.Count - 1
            NIEUWEXLIJST.Add(OUDEXLIJST(i))
            NIEUWEYLIJST.Add(OUDEYLIJST(i))
        Next
        Bordaanpassen()
        Verschijnappel()
        lblHuidige.Text = CType(CInt(lblHuidige.Text) + 10, String)
        Return 0
    End Function
    Public Function Beweegomlaagappel() As Integer
        NIEUWEXLIJST = New List(Of Integer)
        NIEUWEYLIJST = New List(Of Integer)
        NIEUWEXLIJST.Add(OUDEXLIJST(0))
        NIEUWEYLIJST.Add(OUDEYLIJST(0) + 1)
        For i As Integer = 0 To OUDEXLIJST.Count - 1
            NIEUWEXLIJST.Add(OUDEXLIJST(i))
            NIEUWEYLIJST.Add(OUDEYLIJST(i))
        Next
        Bordaanpassen()
        Verschijnappel()
        lblHuidige.Text = CType(CInt(lblHuidige.Text) + 10, String)
        Return 0
    End Function
    Public Function Gameover() As Integer
        'De timer wordt uitgeschakeld, de textbox Game Over komt tevoorschijn. Wanneer de waarde van Huidige score groter is dan de
        'waarde van high score, dan vervangt de huidige score de high score.
        tmrTime.Enabled = False
        tmrScore.Enabled = False
        txtGameOver.Visible = True
        If CInt(lblHigh.Text) < CInt(lblHuidige.Text) Then
            lblHigh.Text = lblHuidige.Text
            lblHighScoreTimerSec.Text = lblHuidigeTimerSec.Text
            lblHighScoreTimerMin.Text = lblHuidigeTimerMin.Text
        End If
        Return 0
    End Function
    Private Sub Snake_KeyUp(sender As Object, e As KeyEventArgs) Handles Me.KeyUp
        'Het besturingspaneel: als je een richting op gaat, kan je niet in de tegenovergestelde richting gaan.
        Select Case e.KeyCode
            Case Keys.Right
                If Not PIJLLINKS Then
                    PIJLOMLAAG = False
                    PIJLLINKS = False
                    PIJLOMHOOG = False
                    PIJLRECHTS = True
                End If
            Case Keys.Left
                If Not PIJLRECHTS Then
                    PIJLOMLAAG = False
                    PIJLLINKS = True
                    PIJLOMHOOG = False
                    PIJLRECHTS = False
                End If
            Case Keys.Up
                If Not PIJLOMLAAG Then
                    PIJLOMLAAG = False
                    PIJLLINKS = False
                    PIJLOMHOOG = True
                    PIJLRECHTS = False
                End If
            Case Keys.Down
                If Not PIJLOMHOOG Then
                    PIJLOMLAAG = True
                    PIJLLINKS = False
                    PIJLOMHOOG = False
                    PIJLRECHTS = False
                End If
        End Select
    End Sub
    Public Function Bordaanpassen() As Boolean
        'Verwijder de oude slang, vervang door nieuwe slang
        For i As Integer = 0 To OUDEXLIJST.Count - 1
            VELD(OUDEXLIJST(i), OUDEYLIJST(i)).BackColor = VELDKLEUR
        Next
        For i As Integer = 0 To NIEUWEXLIJST.Count - 1
            VELD(NIEUWEXLIJST(i), NIEUWEYLIJST(i)).BackColor = SLANGKLEUR
        Next
        OUDEXLIJST = Lijstkopie(NIEUWEXLIJST)
        OUDEYLIJST = Lijstkopie(NIEUWEYLIJST)
        Return True
    End Function
    Public Function Lijstkopie(ByVal lijst As List(Of Integer)) As List(Of Integer)
        'Deze functie kopieert een lijst van integers naar een nieuwe lijst, zonder referenties te gebruiken.
        Dim nieuwelijst As New List(Of Integer)
        For i As Integer = 0 To lijst.Count - 1
            nieuwelijst.Add(lijst(i))
        Next
        Return nieuwelijst
    End Function
End Class

'http://www.iconarchive.com/show/animal-icons-by-martin-berube/snake-icon.html voor icon