<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class SnakeInstellingen
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SnakeInstellingen))
        Me.lblSnelheidTekst = New System.Windows.Forms.Label()
        Me.txtSnelheid = New System.Windows.Forms.TextBox()
        Me.lblTip = New System.Windows.Forms.Label()
        Me.lblTekstRijen = New System.Windows.Forms.Label()
        Me.txtAantalRijen = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtAantalKolommen = New System.Windows.Forms.TextBox()
        Me.btnStart = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblSnelheidTekst
        '
        Me.lblSnelheidTekst.AutoSize = True
        Me.lblSnelheidTekst.Location = New System.Drawing.Point(12, 9)
        Me.lblSnelheidTekst.Name = "lblSnelheidTekst"
        Me.lblSnelheidTekst.Size = New System.Drawing.Size(48, 13)
        Me.lblSnelheidTekst.TabIndex = 11
        Me.lblSnelheidTekst.Text = "Snelheid"
        Me.lblSnelheidTekst.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtSnelheid
        '
        Me.txtSnelheid.Location = New System.Drawing.Point(180, 12)
        Me.txtSnelheid.Name = "txtSnelheid"
        Me.txtSnelheid.Size = New System.Drawing.Size(92, 20)
        Me.txtSnelheid.TabIndex = 12
        Me.txtSnelheid.Text = "200"
        Me.txtSnelheid.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblTip
        '
        Me.lblTip.Location = New System.Drawing.Point(12, 35)
        Me.lblTip.Name = "lblTip"
        Me.lblTip.Size = New System.Drawing.Size(260, 35)
        Me.lblTip.TabIndex = 13
        Me.lblTip.Text = "Tip: Hoe lager het getal, hoe sneller de slang beweegt! (Beginwaarde = 200ms)"
        Me.lblTip.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblTekstRijen
        '
        Me.lblTekstRijen.AutoSize = True
        Me.lblTekstRijen.Location = New System.Drawing.Point(12, 80)
        Me.lblTekstRijen.Name = "lblTekstRijen"
        Me.lblTekstRijen.Size = New System.Drawing.Size(59, 13)
        Me.lblTekstRijen.TabIndex = 14
        Me.lblTekstRijen.Text = "Aantal rijen"
        Me.lblTekstRijen.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtAantalRijen
        '
        Me.txtAantalRijen.Location = New System.Drawing.Point(180, 73)
        Me.txtAantalRijen.Name = "txtAantalRijen"
        Me.txtAantalRijen.Size = New System.Drawing.Size(92, 20)
        Me.txtAantalRijen.TabIndex = 16
        Me.txtAantalRijen.Text = "20"
        Me.txtAantalRijen.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 106)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(88, 13)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "Aantal kolommen"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtAantalKolommen
        '
        Me.txtAantalKolommen.Location = New System.Drawing.Point(180, 106)
        Me.txtAantalKolommen.Name = "txtAantalKolommen"
        Me.txtAantalKolommen.Size = New System.Drawing.Size(92, 20)
        Me.txtAantalKolommen.TabIndex = 18
        Me.txtAantalKolommen.Text = "30"
        Me.txtAantalKolommen.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnStart
        '
        Me.btnStart.Location = New System.Drawing.Point(46, 143)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(181, 82)
        Me.btnStart.TabIndex = 19
        Me.btnStart.Text = "Start!"
        Me.btnStart.UseVisualStyleBackColor = True
        '
        'SnakeInstellingen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(277, 250)
        Me.Controls.Add(Me.btnStart)
        Me.Controls.Add(Me.txtAantalKolommen)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtAantalRijen)
        Me.Controls.Add(Me.lblTekstRijen)
        Me.Controls.Add(Me.lblTip)
        Me.Controls.Add(Me.txtSnelheid)
        Me.Controls.Add(Me.lblSnelheidTekst)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "SnakeInstellingen"
        Me.Text = "Snake instellingen"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblSnelheidTekst As Label
    Friend WithEvents txtSnelheid As TextBox
    Friend WithEvents lblTip As Label
    Friend WithEvents lblTekstRijen As Label
    Friend WithEvents txtAantalRijen As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtAantalKolommen As TextBox
    Friend WithEvents btnStart As Button
End Class
