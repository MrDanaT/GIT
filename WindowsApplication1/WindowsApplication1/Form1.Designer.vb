<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Snake
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Snake))
        Me.btnNieuwSpel = New System.Windows.Forms.Button()
        Me.lblHuidigeScore = New System.Windows.Forms.Label()
        Me.lblHighScore = New System.Windows.Forms.Label()
        Me.tmrTime = New System.Windows.Forms.Timer(Me.components)
        Me.txtGameOver = New System.Windows.Forms.TextBox()
        Me.lblHuidige = New System.Windows.Forms.Label()
        Me.lblHigh = New System.Windows.Forms.Label()
        Me.lblHuidigeScoreTImer = New System.Windows.Forms.Label()
        Me.lblHuidigeTimerMin = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblHighScoreTimerMin = New System.Windows.Forms.Label()
        Me.tmrScore = New System.Windows.Forms.Timer(Me.components)
        Me.lblHuidigeTimerMinTekst = New System.Windows.Forms.Label()
        Me.lblHuidigeTimerSec = New System.Windows.Forms.Label()
        Me.lblHuidigeTimerSecTekst = New System.Windows.Forms.Label()
        Me.lblHighScoreTimerMinTekst = New System.Windows.Forms.Label()
        Me.lblHighScoreTimerSec = New System.Windows.Forms.Label()
        Me.lblHighScoreTimerSecTekst = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnNieuwSpel
        '
        Me.btnNieuwSpel.AutoSize = True
        Me.btnNieuwSpel.Location = New System.Drawing.Point(12, 12)
        Me.btnNieuwSpel.Name = "btnNieuwSpel"
        Me.btnNieuwSpel.Size = New System.Drawing.Size(95, 54)
        Me.btnNieuwSpel.TabIndex = 0
        Me.btnNieuwSpel.Text = "Start nieuw spel!"
        Me.btnNieuwSpel.UseVisualStyleBackColor = True
        '
        'lblHuidigeScore
        '
        Me.lblHuidigeScore.AutoSize = True
        Me.lblHuidigeScore.Location = New System.Drawing.Point(9, 222)
        Me.lblHuidigeScore.Name = "lblHuidigeScore"
        Me.lblHuidigeScore.Size = New System.Drawing.Size(74, 13)
        Me.lblHuidigeScore.TabIndex = 1
        Me.lblHuidigeScore.Text = "Huidige Score"
        Me.lblHuidigeScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblHighScore
        '
        Me.lblHighScore.AutoSize = True
        Me.lblHighScore.Location = New System.Drawing.Point(9, 238)
        Me.lblHighScore.Name = "lblHighScore"
        Me.lblHighScore.Size = New System.Drawing.Size(60, 13)
        Me.lblHighScore.TabIndex = 2
        Me.lblHighScore.Text = "High Score"
        Me.lblHighScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tmrTime
        '
        Me.tmrTime.Enabled = True
        Me.tmrTime.Interval = 200
        '
        'txtGameOver
        '
        Me.txtGameOver.BackColor = System.Drawing.SystemColors.Window
        Me.txtGameOver.Font = New System.Drawing.Font("Microsoft Sans Serif", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGameOver.Location = New System.Drawing.Point(258, 171)
        Me.txtGameOver.Name = "txtGameOver"
        Me.txtGameOver.ReadOnly = True
        Me.txtGameOver.Size = New System.Drawing.Size(370, 80)
        Me.txtGameOver.TabIndex = 5
        Me.txtGameOver.Text = "Game Over!"
        '
        'lblHuidige
        '
        Me.lblHuidige.AutoSize = True
        Me.lblHuidige.Location = New System.Drawing.Point(94, 222)
        Me.lblHuidige.Name = "lblHuidige"
        Me.lblHuidige.Size = New System.Drawing.Size(13, 13)
        Me.lblHuidige.TabIndex = 8
        Me.lblHuidige.Text = "0"
        Me.lblHuidige.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblHigh
        '
        Me.lblHigh.AutoSize = True
        Me.lblHigh.Location = New System.Drawing.Point(94, 238)
        Me.lblHigh.Name = "lblHigh"
        Me.lblHigh.Size = New System.Drawing.Size(13, 13)
        Me.lblHigh.TabIndex = 9
        Me.lblHigh.Text = "0"
        Me.lblHigh.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblHuidigeScoreTImer
        '
        Me.lblHuidigeScoreTImer.AutoSize = True
        Me.lblHuidigeScoreTImer.Location = New System.Drawing.Point(9, 261)
        Me.lblHuidigeScoreTImer.Name = "lblHuidigeScoreTImer"
        Me.lblHuidigeScoreTImer.Size = New System.Drawing.Size(64, 13)
        Me.lblHuidigeScoreTImer.TabIndex = 10
        Me.lblHuidigeScoreTImer.Text = "Timer Score"
        Me.lblHuidigeScoreTImer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblHuidigeTimerMin
        '
        Me.lblHuidigeTimerMin.AutoSize = True
        Me.lblHuidigeTimerMin.Location = New System.Drawing.Point(12, 274)
        Me.lblHuidigeTimerMin.Name = "lblHuidigeTimerMin"
        Me.lblHuidigeTimerMin.Size = New System.Drawing.Size(13, 13)
        Me.lblHuidigeTimerMin.TabIndex = 11
        Me.lblHuidigeTimerMin.Text = "0"
        Me.lblHuidigeTimerMin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 298)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(84, 13)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Timer Highscore"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblHighScoreTimerMin
        '
        Me.lblHighScoreTimerMin.AutoSize = True
        Me.lblHighScoreTimerMin.Location = New System.Drawing.Point(12, 311)
        Me.lblHighScoreTimerMin.Name = "lblHighScoreTimerMin"
        Me.lblHighScoreTimerMin.Size = New System.Drawing.Size(13, 13)
        Me.lblHighScoreTimerMin.TabIndex = 13
        Me.lblHighScoreTimerMin.Text = "0"
        Me.lblHighScoreTimerMin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tmrScore
        '
        Me.tmrScore.Interval = 1000
        '
        'lblHuidigeTimerMinTekst
        '
        Me.lblHuidigeTimerMinTekst.AutoSize = True
        Me.lblHuidigeTimerMinTekst.Location = New System.Drawing.Point(22, 274)
        Me.lblHuidigeTimerMinTekst.Name = "lblHuidigeTimerMinTekst"
        Me.lblHuidigeTimerMinTekst.Size = New System.Drawing.Size(23, 13)
        Me.lblHuidigeTimerMinTekst.TabIndex = 14
        Me.lblHuidigeTimerMinTekst.Text = "min"
        Me.lblHuidigeTimerMinTekst.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblHuidigeTimerSec
        '
        Me.lblHuidigeTimerSec.AutoSize = True
        Me.lblHuidigeTimerSec.Location = New System.Drawing.Point(51, 274)
        Me.lblHuidigeTimerSec.Name = "lblHuidigeTimerSec"
        Me.lblHuidigeTimerSec.Size = New System.Drawing.Size(13, 13)
        Me.lblHuidigeTimerSec.TabIndex = 15
        Me.lblHuidigeTimerSec.Text = "0"
        Me.lblHuidigeTimerSec.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblHuidigeTimerSecTekst
        '
        Me.lblHuidigeTimerSecTekst.AutoSize = True
        Me.lblHuidigeTimerSecTekst.Location = New System.Drawing.Point(70, 274)
        Me.lblHuidigeTimerSecTekst.Name = "lblHuidigeTimerSecTekst"
        Me.lblHuidigeTimerSecTekst.Size = New System.Drawing.Size(24, 13)
        Me.lblHuidigeTimerSecTekst.TabIndex = 16
        Me.lblHuidigeTimerSecTekst.Text = "sec"
        Me.lblHuidigeTimerSecTekst.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblHighScoreTimerMinTekst
        '
        Me.lblHighScoreTimerMinTekst.AutoSize = True
        Me.lblHighScoreTimerMinTekst.Location = New System.Drawing.Point(22, 311)
        Me.lblHighScoreTimerMinTekst.Name = "lblHighScoreTimerMinTekst"
        Me.lblHighScoreTimerMinTekst.Size = New System.Drawing.Size(23, 13)
        Me.lblHighScoreTimerMinTekst.TabIndex = 17
        Me.lblHighScoreTimerMinTekst.Text = "min"
        Me.lblHighScoreTimerMinTekst.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblHighScoreTimerSec
        '
        Me.lblHighScoreTimerSec.AutoSize = True
        Me.lblHighScoreTimerSec.Location = New System.Drawing.Point(51, 311)
        Me.lblHighScoreTimerSec.Name = "lblHighScoreTimerSec"
        Me.lblHighScoreTimerSec.Size = New System.Drawing.Size(13, 13)
        Me.lblHighScoreTimerSec.TabIndex = 18
        Me.lblHighScoreTimerSec.Text = "0"
        Me.lblHighScoreTimerSec.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblHighScoreTimerSecTekst
        '
        Me.lblHighScoreTimerSecTekst.AutoSize = True
        Me.lblHighScoreTimerSecTekst.Location = New System.Drawing.Point(70, 311)
        Me.lblHighScoreTimerSecTekst.Name = "lblHighScoreTimerSecTekst"
        Me.lblHighScoreTimerSecTekst.Size = New System.Drawing.Size(24, 13)
        Me.lblHighScoreTimerSecTekst.TabIndex = 19
        Me.lblHighScoreTimerSecTekst.Text = "sec"
        Me.lblHighScoreTimerSecTekst.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Snake
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackColor = System.Drawing.Color.DarkGreen
        Me.ClientSize = New System.Drawing.Size(848, 461)
        Me.Controls.Add(Me.lblHighScoreTimerSecTekst)
        Me.Controls.Add(Me.lblHighScoreTimerSec)
        Me.Controls.Add(Me.lblHighScoreTimerMinTekst)
        Me.Controls.Add(Me.lblHuidigeTimerSecTekst)
        Me.Controls.Add(Me.lblHuidigeTimerSec)
        Me.Controls.Add(Me.lblHuidigeTimerMinTekst)
        Me.Controls.Add(Me.lblHighScoreTimerMin)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblHuidigeTimerMin)
        Me.Controls.Add(Me.lblHuidigeScoreTImer)
        Me.Controls.Add(Me.lblHigh)
        Me.Controls.Add(Me.lblHuidige)
        Me.Controls.Add(Me.txtGameOver)
        Me.Controls.Add(Me.lblHighScore)
        Me.Controls.Add(Me.lblHuidigeScore)
        Me.Controls.Add(Me.btnNieuwSpel)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Snake"
        Me.Text = "ss"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnNieuwSpel As Button
    Friend WithEvents lblHuidigeScore As Label
    Friend WithEvents lblHighScore As Label
    Friend WithEvents tmrTime As Timer
    Friend WithEvents txtGameOver As TextBox
    Friend WithEvents lblHuidige As Label
    Friend WithEvents lblHigh As Label
    Friend WithEvents lblHuidigeScoreTImer As Label
    Friend WithEvents lblHuidigeTimerMin As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lblHighScoreTimerMin As Label
    Friend WithEvents tmrScore As Timer
    Friend WithEvents lblHuidigeTimerMinTekst As Label
    Friend WithEvents lblHuidigeTimerSec As Label
    Friend WithEvents lblHuidigeTimerSecTekst As Label
    Friend WithEvents lblHighScoreTimerMinTekst As Label
    Friend WithEvents lblHighScoreTimerSec As Label
    Friend WithEvents lblHighScoreTimerSecTekst As Label
End Class
