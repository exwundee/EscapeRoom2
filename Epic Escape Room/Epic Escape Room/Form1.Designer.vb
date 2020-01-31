<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.Title = New System.Windows.Forms.TabPage()
        Me.btnPlay = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.North = New System.Windows.Forms.TabPage()
        Me.N_E = New System.Windows.Forms.Button()
        Me.N_S = New System.Windows.Forms.Button()
        Me.timer1 = New System.Windows.Forms.TextBox()
        Me.door = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.East = New System.Windows.Forms.TabPage()
        Me.E_W = New System.Windows.Forms.Button()
        Me.E_N = New System.Windows.Forms.Button()
        Me.timer2 = New System.Windows.Forms.TextBox()
        Me.safe = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.West = New System.Windows.Forms.TabPage()
        Me.W_S = New System.Windows.Forms.Button()
        Me.W_E = New System.Windows.Forms.Button()
        Me.timer3 = New System.Windows.Forms.TextBox()
        Me.dwrBottom = New System.Windows.Forms.PictureBox()
        Me.dwrTop = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.South = New System.Windows.Forms.TabPage()
        Me.S_N = New System.Windows.Forms.Button()
        Me.S_W = New System.Windows.Forms.Button()
        Me.timer4 = New System.Windows.Forms.TextBox()
        Me.wind = New System.Windows.Forms.PictureBox()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.Window = New System.Windows.Forms.TabPage()
        Me.timer5 = New System.Windows.Forms.TextBox()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        Me.Screamer = New System.Windows.Forms.TabPage()
        Me.PictureBox7 = New System.Windows.Forms.PictureBox()
        Me.gameTimer = New System.Windows.Forms.Timer(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TabControl1.SuspendLayout()
        Me.Title.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.North.SuspendLayout()
        CType(Me.door, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.East.SuspendLayout()
        CType(Me.safe, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.West.SuspendLayout()
        CType(Me.dwrBottom, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dwrTop, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.South.SuspendLayout()
        CType(Me.wind, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Window.SuspendLayout()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Screamer.SuspendLayout()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.Title)
        Me.TabControl1.Controls.Add(Me.North)
        Me.TabControl1.Controls.Add(Me.East)
        Me.TabControl1.Controls.Add(Me.West)
        Me.TabControl1.Controls.Add(Me.South)
        Me.TabControl1.Controls.Add(Me.Window)
        Me.TabControl1.Controls.Add(Me.Screamer)
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(803, 451)
        Me.TabControl1.TabIndex = 0
        '
        'Title
        '
        Me.Title.Controls.Add(Me.btnPlay)
        Me.Title.Controls.Add(Me.PictureBox1)
        Me.Title.Location = New System.Drawing.Point(4, 22)
        Me.Title.Name = "Title"
        Me.Title.Padding = New System.Windows.Forms.Padding(3)
        Me.Title.Size = New System.Drawing.Size(795, 425)
        Me.Title.TabIndex = 0
        Me.Title.Text = "Title"
        Me.Title.UseVisualStyleBackColor = True
        '
        'btnPlay
        '
        Me.btnPlay.Font = New System.Drawing.Font("Segoe UI", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPlay.Location = New System.Drawing.Point(49, 299)
        Me.btnPlay.Name = "btnPlay"
        Me.btnPlay.Size = New System.Drawing.Size(111, 51)
        Me.btnPlay.TabIndex = 1
        Me.btnPlay.Text = "PLAY"
        Me.btnPlay.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Epic_Escape_Room.My.Resources.Resources.title
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(799, 429)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'North
        '
        Me.North.Controls.Add(Me.N_E)
        Me.North.Controls.Add(Me.N_S)
        Me.North.Controls.Add(Me.timer1)
        Me.North.Controls.Add(Me.door)
        Me.North.Controls.Add(Me.PictureBox2)
        Me.North.Location = New System.Drawing.Point(4, 22)
        Me.North.Name = "North"
        Me.North.Padding = New System.Windows.Forms.Padding(3)
        Me.North.Size = New System.Drawing.Size(795, 425)
        Me.North.TabIndex = 1
        Me.North.Text = "N"
        Me.North.UseVisualStyleBackColor = True
        '
        'N_E
        '
        Me.N_E.Font = New System.Drawing.Font("Segoe UI", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.N_E.Location = New System.Drawing.Point(761, 174)
        Me.N_E.Name = "N_E"
        Me.N_E.Size = New System.Drawing.Size(28, 75)
        Me.N_E.TabIndex = 5
        Me.N_E.Text = ">"
        Me.N_E.UseVisualStyleBackColor = True
        '
        'N_S
        '
        Me.N_S.Font = New System.Drawing.Font("Segoe UI", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.N_S.Location = New System.Drawing.Point(6, 174)
        Me.N_S.Name = "N_S"
        Me.N_S.Size = New System.Drawing.Size(28, 75)
        Me.N_S.TabIndex = 4
        Me.N_S.Text = "<"
        Me.N_S.UseVisualStyleBackColor = True
        '
        'timer1
        '
        Me.timer1.Enabled = False
        Me.timer1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.timer1.Location = New System.Drawing.Point(3, 3)
        Me.timer1.Name = "timer1"
        Me.timer1.Size = New System.Drawing.Size(67, 31)
        Me.timer1.TabIndex = 3
        Me.timer1.Text = "0:0"
        '
        'door
        '
        Me.door.Image = Global.Epic_Escape_Room.My.Resources.Resources.door1
        Me.door.Location = New System.Drawing.Point(329, 113)
        Me.door.Name = "door"
        Me.door.Size = New System.Drawing.Size(141, 213)
        Me.door.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.door.TabIndex = 2
        Me.door.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.Epic_Escape_Room.My.Resources.Resources.open_door
        Me.PictureBox2.Location = New System.Drawing.Point(-2, -2)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(799, 429)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 1
        Me.PictureBox2.TabStop = False
        '
        'East
        '
        Me.East.Controls.Add(Me.E_W)
        Me.East.Controls.Add(Me.E_N)
        Me.East.Controls.Add(Me.timer2)
        Me.East.Controls.Add(Me.safe)
        Me.East.Controls.Add(Me.PictureBox3)
        Me.East.Location = New System.Drawing.Point(4, 22)
        Me.East.Name = "East"
        Me.East.Padding = New System.Windows.Forms.Padding(3)
        Me.East.Size = New System.Drawing.Size(795, 425)
        Me.East.TabIndex = 2
        Me.East.Text = "E"
        Me.East.UseVisualStyleBackColor = True
        '
        'E_W
        '
        Me.E_W.Font = New System.Drawing.Font("Segoe UI", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.E_W.Location = New System.Drawing.Point(761, 175)
        Me.E_W.Name = "E_W"
        Me.E_W.Size = New System.Drawing.Size(28, 75)
        Me.E_W.TabIndex = 7
        Me.E_W.Text = ">"
        Me.E_W.UseVisualStyleBackColor = True
        '
        'E_N
        '
        Me.E_N.Font = New System.Drawing.Font("Segoe UI", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.E_N.Location = New System.Drawing.Point(6, 175)
        Me.E_N.Name = "E_N"
        Me.E_N.Size = New System.Drawing.Size(28, 75)
        Me.E_N.TabIndex = 6
        Me.E_N.Text = "<"
        Me.E_N.UseVisualStyleBackColor = True
        '
        'timer2
        '
        Me.timer2.Enabled = False
        Me.timer2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.timer2.Location = New System.Drawing.Point(3, 3)
        Me.timer2.Name = "timer2"
        Me.timer2.Size = New System.Drawing.Size(67, 31)
        Me.timer2.TabIndex = 4
        Me.timer2.Text = "0:0"
        '
        'safe
        '
        Me.safe.Image = Global.Epic_Escape_Room.My.Resources.Resources.safe1
        Me.safe.Location = New System.Drawing.Point(323, 252)
        Me.safe.Name = "safe"
        Me.safe.Size = New System.Drawing.Size(141, 82)
        Me.safe.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.safe.TabIndex = 3
        Me.safe.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.Epic_Escape_Room.My.Resources.Resources.template
        Me.PictureBox3.Location = New System.Drawing.Point(-2, -2)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(799, 429)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 1
        Me.PictureBox3.TabStop = False
        '
        'West
        '
        Me.West.Controls.Add(Me.W_S)
        Me.West.Controls.Add(Me.W_E)
        Me.West.Controls.Add(Me.timer3)
        Me.West.Controls.Add(Me.dwrBottom)
        Me.West.Controls.Add(Me.dwrTop)
        Me.West.Controls.Add(Me.PictureBox4)
        Me.West.Location = New System.Drawing.Point(4, 22)
        Me.West.Name = "West"
        Me.West.Padding = New System.Windows.Forms.Padding(3)
        Me.West.Size = New System.Drawing.Size(795, 425)
        Me.West.TabIndex = 3
        Me.West.Text = "W"
        Me.West.UseVisualStyleBackColor = True
        '
        'W_S
        '
        Me.W_S.Font = New System.Drawing.Font("Segoe UI", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.W_S.Location = New System.Drawing.Point(761, 175)
        Me.W_S.Name = "W_S"
        Me.W_S.Size = New System.Drawing.Size(28, 75)
        Me.W_S.TabIndex = 7
        Me.W_S.Text = ">"
        Me.W_S.UseVisualStyleBackColor = True
        '
        'W_E
        '
        Me.W_E.Font = New System.Drawing.Font("Segoe UI", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.W_E.Location = New System.Drawing.Point(6, 175)
        Me.W_E.Name = "W_E"
        Me.W_E.Size = New System.Drawing.Size(28, 75)
        Me.W_E.TabIndex = 6
        Me.W_E.Text = "<"
        Me.W_E.UseVisualStyleBackColor = True
        '
        'timer3
        '
        Me.timer3.Enabled = False
        Me.timer3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.timer3.Location = New System.Drawing.Point(3, 3)
        Me.timer3.Name = "timer3"
        Me.timer3.Size = New System.Drawing.Size(67, 31)
        Me.timer3.TabIndex = 5
        Me.timer3.Text = "0:0"
        '
        'dwrBottom
        '
        Me.dwrBottom.Image = Global.Epic_Escape_Room.My.Resources.Resources.dresser1
        Me.dwrBottom.Location = New System.Drawing.Point(318, 312)
        Me.dwrBottom.Name = "dwrBottom"
        Me.dwrBottom.Size = New System.Drawing.Size(141, 17)
        Me.dwrBottom.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.dwrBottom.TabIndex = 4
        Me.dwrBottom.TabStop = False
        '
        'dwrTop
        '
        Me.dwrTop.Image = Global.Epic_Escape_Room.My.Resources.Resources.dresser1
        Me.dwrTop.Location = New System.Drawing.Point(318, 299)
        Me.dwrTop.Name = "dwrTop"
        Me.dwrTop.Size = New System.Drawing.Size(141, 17)
        Me.dwrTop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.dwrTop.TabIndex = 3
        Me.dwrTop.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = Global.Epic_Escape_Room.My.Resources.Resources.room
        Me.PictureBox4.Location = New System.Drawing.Point(-2, -2)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(799, 429)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 1
        Me.PictureBox4.TabStop = False
        '
        'South
        '
        Me.South.Controls.Add(Me.S_N)
        Me.South.Controls.Add(Me.S_W)
        Me.South.Controls.Add(Me.timer4)
        Me.South.Controls.Add(Me.wind)
        Me.South.Controls.Add(Me.PictureBox5)
        Me.South.Location = New System.Drawing.Point(4, 22)
        Me.South.Name = "South"
        Me.South.Padding = New System.Windows.Forms.Padding(3)
        Me.South.Size = New System.Drawing.Size(795, 425)
        Me.South.TabIndex = 4
        Me.South.Text = "S"
        Me.South.UseVisualStyleBackColor = True
        '
        'S_N
        '
        Me.S_N.Font = New System.Drawing.Font("Segoe UI", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.S_N.Location = New System.Drawing.Point(761, 175)
        Me.S_N.Name = "S_N"
        Me.S_N.Size = New System.Drawing.Size(28, 75)
        Me.S_N.TabIndex = 7
        Me.S_N.Text = ">"
        Me.S_N.UseVisualStyleBackColor = True
        '
        'S_W
        '
        Me.S_W.Font = New System.Drawing.Font("Segoe UI", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.S_W.Location = New System.Drawing.Point(6, 175)
        Me.S_W.Name = "S_W"
        Me.S_W.Size = New System.Drawing.Size(28, 75)
        Me.S_W.TabIndex = 6
        Me.S_W.Text = "<"
        Me.S_W.UseVisualStyleBackColor = True
        '
        'timer4
        '
        Me.timer4.Enabled = False
        Me.timer4.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.timer4.Location = New System.Drawing.Point(3, 3)
        Me.timer4.Name = "timer4"
        Me.timer4.Size = New System.Drawing.Size(67, 31)
        Me.timer4.TabIndex = 5
        Me.timer4.Text = "0:0"
        '
        'wind
        '
        Me.wind.Image = Global.Epic_Escape_Room.My.Resources.Resources.window1
        Me.wind.Location = New System.Drawing.Point(316, 92)
        Me.wind.Name = "wind"
        Me.wind.Size = New System.Drawing.Size(141, 189)
        Me.wind.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.wind.TabIndex = 4
        Me.wind.TabStop = False
        '
        'PictureBox5
        '
        Me.PictureBox5.Image = Global.Epic_Escape_Room.My.Resources.Resources.template
        Me.PictureBox5.Location = New System.Drawing.Point(-2, -2)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(799, 429)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox5.TabIndex = 1
        Me.PictureBox5.TabStop = False
        '
        'Window
        '
        Me.Window.Controls.Add(Me.timer5)
        Me.Window.Controls.Add(Me.btnBack)
        Me.Window.Controls.Add(Me.PictureBox6)
        Me.Window.Location = New System.Drawing.Point(4, 22)
        Me.Window.Name = "Window"
        Me.Window.Padding = New System.Windows.Forms.Padding(3)
        Me.Window.Size = New System.Drawing.Size(795, 425)
        Me.Window.TabIndex = 5
        Me.Window.Text = "Window"
        Me.Window.UseVisualStyleBackColor = True
        '
        'timer5
        '
        Me.timer5.Enabled = False
        Me.timer5.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.timer5.Location = New System.Drawing.Point(3, 3)
        Me.timer5.Name = "timer5"
        Me.timer5.Size = New System.Drawing.Size(67, 31)
        Me.timer5.TabIndex = 4
        Me.timer5.Text = "0:0"
        '
        'btnBack
        '
        Me.btnBack.Font = New System.Drawing.Font("Segoe UI", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.Location = New System.Drawing.Point(8, 365)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(119, 51)
        Me.btnBack.TabIndex = 2
        Me.btnBack.Text = "BACK"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'PictureBox6
        '
        Me.PictureBox6.Image = Global.Epic_Escape_Room.My.Resources.Resources.window21
        Me.PictureBox6.Location = New System.Drawing.Point(-2, -2)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(799, 429)
        Me.PictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox6.TabIndex = 1
        Me.PictureBox6.TabStop = False
        '
        'Screamer
        '
        Me.Screamer.Controls.Add(Me.PictureBox7)
        Me.Screamer.Location = New System.Drawing.Point(4, 22)
        Me.Screamer.Name = "Screamer"
        Me.Screamer.Padding = New System.Windows.Forms.Padding(3)
        Me.Screamer.Size = New System.Drawing.Size(795, 425)
        Me.Screamer.TabIndex = 6
        Me.Screamer.Text = "Screamer"
        Me.Screamer.UseVisualStyleBackColor = True
        '
        'PictureBox7
        '
        Me.PictureBox7.Image = Global.Epic_Escape_Room.My.Resources.Resources.clapped
        Me.PictureBox7.Location = New System.Drawing.Point(-2, -2)
        Me.PictureBox7.Name = "PictureBox7"
        Me.PictureBox7.Size = New System.Drawing.Size(799, 429)
        Me.PictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox7.TabIndex = 1
        Me.PictureBox7.TabStop = False
        '
        'gameTimer
        '
        Me.gameTimer.Interval = 1000
        '
        'Panel1
        '
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(814, 22)
        Me.Panel1.TabIndex = 1
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "Form1"
        Me.Text = "Escape Clappy"
        Me.TabControl1.ResumeLayout(False)
        Me.Title.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.North.ResumeLayout(False)
        Me.North.PerformLayout()
        CType(Me.door, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.East.ResumeLayout(False)
        Me.East.PerformLayout()
        CType(Me.safe, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.West.ResumeLayout(False)
        Me.West.PerformLayout()
        CType(Me.dwrBottom, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dwrTop, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.South.ResumeLayout(False)
        Me.South.PerformLayout()
        CType(Me.wind, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Window.ResumeLayout(False)
        Me.Window.PerformLayout()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Screamer.ResumeLayout(False)
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents Title As TabPage
    Friend WithEvents North As TabPage
    Friend WithEvents East As TabPage
    Friend WithEvents West As TabPage
    Friend WithEvents South As TabPage
    Friend WithEvents Window As TabPage
    Friend WithEvents Screamer As TabPage
    Friend WithEvents btnPlay As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents gameTimer As Timer
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents PictureBox7 As PictureBox
    Friend WithEvents door As PictureBox
    Friend WithEvents safe As PictureBox
    Friend WithEvents dwrTop As PictureBox
    Friend WithEvents dwrBottom As PictureBox
    Friend WithEvents wind As PictureBox
    Friend WithEvents btnBack As Button
    Friend WithEvents timer1 As TextBox
    Friend WithEvents timer2 As TextBox
    Friend WithEvents timer3 As TextBox
    Friend WithEvents timer4 As TextBox
    Friend WithEvents timer5 As TextBox
    Friend WithEvents N_E As Button
    Friend WithEvents N_S As Button
    Friend WithEvents E_W As Button
    Friend WithEvents E_N As Button
    Friend WithEvents W_S As Button
    Friend WithEvents W_E As Button
    Friend WithEvents S_N As Button
    Friend WithEvents S_W As Button
    Friend WithEvents Panel1 As Panel
End Class
