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
        Me.pnlShaft = New System.Windows.Forms.Panel()
        Me.pnlCabin = New System.Windows.Forms.Panel()
        Me.pnlDoorRight = New System.Windows.Forms.Panel()
        Me.pnlDoorLeft = New System.Windows.Forms.Panel()
        Me.lblFloor1 = New System.Windows.Forms.Label()
        Me.lblFloor2 = New System.Windows.Forms.Label()
        Me.lblFloor3 = New System.Windows.Forms.Label()
        Me.lblFloor4 = New System.Windows.Forms.Label()
        Me.lblCurrentFloor = New System.Windows.Forms.Label()
        Me.lblDirection = New System.Windows.Forms.Label()
        Me.lblDoorStatus = New System.Windows.Forms.Label()
        Me.btnFloor4 = New System.Windows.Forms.Button()
        Me.btnFloor3 = New System.Windows.Forms.Button()
        Me.btnFloor2 = New System.Windows.Forms.Button()
        Me.btnFloor1 = New System.Windows.Forms.Button()
        Me.btnOpenDoor = New System.Windows.Forms.Button()
        Me.btnCloseDoor = New System.Windows.Forms.Button()
        Me.tmrElevator = New System.Windows.Forms.Timer(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tmrDoor = New System.Windows.Forms.Timer(Me.components)
        Me.tmrWait = New System.Windows.Forms.Timer(Me.components)
        Me.pnlShaft.SuspendLayout()
        Me.pnlCabin.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlShaft
        '
        Me.pnlShaft.AccessibleName = "pnlShaft"
        Me.pnlShaft.BackColor = System.Drawing.Color.DimGray
        Me.pnlShaft.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlShaft.Controls.Add(Me.pnlCabin)
        Me.pnlShaft.Location = New System.Drawing.Point(254, 65)
        Me.pnlShaft.Name = "pnlShaft"
        Me.pnlShaft.Size = New System.Drawing.Size(180, 500)
        Me.pnlShaft.TabIndex = 0
        '
        'pnlCabin
        '
        Me.pnlCabin.BackColor = System.Drawing.Color.Silver
        Me.pnlCabin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlCabin.Controls.Add(Me.pnlDoorRight)
        Me.pnlCabin.Controls.Add(Me.pnlDoorLeft)
        Me.pnlCabin.Location = New System.Drawing.Point(43, 394)
        Me.pnlCabin.Name = "pnlCabin"
        Me.pnlCabin.Size = New System.Drawing.Size(90, 70)
        Me.pnlCabin.TabIndex = 0
        '
        'pnlDoorRight
        '
        Me.pnlDoorRight.BackColor = System.Drawing.Color.Gray
        Me.pnlDoorRight.Location = New System.Drawing.Point(45, 0)
        Me.pnlDoorRight.Name = "pnlDoorRight"
        Me.pnlDoorRight.Size = New System.Drawing.Size(45, 70)
        Me.pnlDoorRight.TabIndex = 1
        '
        'pnlDoorLeft
        '
        Me.pnlDoorLeft.BackColor = System.Drawing.Color.Gray
        Me.pnlDoorLeft.Location = New System.Drawing.Point(0, 0)
        Me.pnlDoorLeft.Name = "pnlDoorLeft"
        Me.pnlDoorLeft.Size = New System.Drawing.Size(45, 70)
        Me.pnlDoorLeft.TabIndex = 0
        '
        'lblFloor1
        '
        Me.lblFloor1.AutoSize = True
        Me.lblFloor1.Location = New System.Drawing.Point(168, 491)
        Me.lblFloor1.Name = "lblFloor1"
        Me.lblFloor1.Size = New System.Drawing.Size(48, 16)
        Me.lblFloor1.TabIndex = 1
        Me.lblFloor1.Text = "Floor 1"
        '
        'lblFloor2
        '
        Me.lblFloor2.AutoSize = True
        Me.lblFloor2.Location = New System.Drawing.Point(168, 361)
        Me.lblFloor2.Name = "lblFloor2"
        Me.lblFloor2.Size = New System.Drawing.Size(48, 16)
        Me.lblFloor2.TabIndex = 2
        Me.lblFloor2.Text = "Floor 2"
        '
        'lblFloor3
        '
        Me.lblFloor3.AutoSize = True
        Me.lblFloor3.Location = New System.Drawing.Point(168, 239)
        Me.lblFloor3.Name = "lblFloor3"
        Me.lblFloor3.Size = New System.Drawing.Size(48, 16)
        Me.lblFloor3.TabIndex = 3
        Me.lblFloor3.Text = "Floor 3"
        '
        'lblFloor4
        '
        Me.lblFloor4.AutoSize = True
        Me.lblFloor4.Location = New System.Drawing.Point(168, 123)
        Me.lblFloor4.Name = "lblFloor4"
        Me.lblFloor4.Size = New System.Drawing.Size(48, 16)
        Me.lblFloor4.TabIndex = 4
        Me.lblFloor4.Text = "Floor 4"
        '
        'lblCurrentFloor
        '
        Me.lblCurrentFloor.BackColor = System.Drawing.Color.Black
        Me.lblCurrentFloor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblCurrentFloor.Font = New System.Drawing.Font("Consolas", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCurrentFloor.ForeColor = System.Drawing.Color.Lime
        Me.lblCurrentFloor.Location = New System.Drawing.Point(593, 53)
        Me.lblCurrentFloor.Name = "lblCurrentFloor"
        Me.lblCurrentFloor.Size = New System.Drawing.Size(180, 60)
        Me.lblCurrentFloor.TabIndex = 5
        Me.lblCurrentFloor.Text = "1"
        Me.lblCurrentFloor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblDirection
        '
        Me.lblDirection.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDirection.Location = New System.Drawing.Point(593, 138)
        Me.lblDirection.Name = "lblDirection"
        Me.lblDirection.Size = New System.Drawing.Size(180, 40)
        Me.lblDirection.TabIndex = 6
        Me.lblDirection.Text = "Direction: Idle"
        Me.lblDirection.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblDoorStatus
        '
        Me.lblDoorStatus.AutoSize = True
        Me.lblDoorStatus.Location = New System.Drawing.Point(634, 195)
        Me.lblDoorStatus.Name = "lblDoorStatus"
        Me.lblDoorStatus.Size = New System.Drawing.Size(86, 16)
        Me.lblDoorStatus.TabIndex = 7
        Me.lblDoorStatus.Text = "Door: Closed"
        '
        'btnFloor4
        '
        Me.btnFloor4.Location = New System.Drawing.Point(805, 214)
        Me.btnFloor4.Name = "btnFloor4"
        Me.btnFloor4.Size = New System.Drawing.Size(75, 37)
        Me.btnFloor4.TabIndex = 8
        Me.btnFloor4.Text = "4"
        Me.btnFloor4.UseVisualStyleBackColor = True
        '
        'btnFloor3
        '
        Me.btnFloor3.Location = New System.Drawing.Point(805, 257)
        Me.btnFloor3.Name = "btnFloor3"
        Me.btnFloor3.Size = New System.Drawing.Size(75, 35)
        Me.btnFloor3.TabIndex = 9
        Me.btnFloor3.Text = "3"
        Me.btnFloor3.UseVisualStyleBackColor = True
        '
        'btnFloor2
        '
        Me.btnFloor2.Location = New System.Drawing.Point(805, 298)
        Me.btnFloor2.Name = "btnFloor2"
        Me.btnFloor2.Size = New System.Drawing.Size(75, 36)
        Me.btnFloor2.TabIndex = 10
        Me.btnFloor2.Text = "2"
        Me.btnFloor2.UseVisualStyleBackColor = True
        '
        'btnFloor1
        '
        Me.btnFloor1.Location = New System.Drawing.Point(805, 340)
        Me.btnFloor1.Name = "btnFloor1"
        Me.btnFloor1.Size = New System.Drawing.Size(75, 37)
        Me.btnFloor1.TabIndex = 11
        Me.btnFloor1.Text = "1"
        Me.btnFloor1.UseVisualStyleBackColor = True
        '
        'btnOpenDoor
        '
        Me.btnOpenDoor.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnOpenDoor.Location = New System.Drawing.Point(792, 402)
        Me.btnOpenDoor.Name = "btnOpenDoor"
        Me.btnOpenDoor.Size = New System.Drawing.Size(102, 34)
        Me.btnOpenDoor.TabIndex = 12
        Me.btnOpenDoor.Text = "Open Door"
        Me.btnOpenDoor.UseVisualStyleBackColor = False
        '
        'btnCloseDoor
        '
        Me.btnCloseDoor.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnCloseDoor.Location = New System.Drawing.Point(792, 460)
        Me.btnCloseDoor.Name = "btnCloseDoor"
        Me.btnCloseDoor.Size = New System.Drawing.Size(102, 34)
        Me.btnCloseDoor.TabIndex = 13
        Me.btnCloseDoor.Text = "Close Door"
        Me.btnCloseDoor.UseVisualStyleBackColor = False
        '
        'tmrElevator
        '
        Me.tmrElevator.Interval = 20
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(621, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(121, 20)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Current Floor"
        '
        'tmrDoor
        '
        Me.tmrDoor.Interval = 20
        '
        'tmrWait
        '
        Me.tmrWait.Interval = 2000
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(942, 591)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnCloseDoor)
        Me.Controls.Add(Me.btnOpenDoor)
        Me.Controls.Add(Me.btnFloor1)
        Me.Controls.Add(Me.btnFloor2)
        Me.Controls.Add(Me.btnFloor3)
        Me.Controls.Add(Me.btnFloor4)
        Me.Controls.Add(Me.lblDoorStatus)
        Me.Controls.Add(Me.lblDirection)
        Me.Controls.Add(Me.lblCurrentFloor)
        Me.Controls.Add(Me.lblFloor4)
        Me.Controls.Add(Me.lblFloor3)
        Me.Controls.Add(Me.lblFloor2)
        Me.Controls.Add(Me.lblFloor1)
        Me.Controls.Add(Me.pnlShaft)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.pnlShaft.ResumeLayout(False)
        Me.pnlCabin.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pnlShaft As Panel
    Friend WithEvents lblFloor1 As Label
    Friend WithEvents lblFloor2 As Label
    Friend WithEvents lblFloor3 As Label
    Friend WithEvents lblFloor4 As Label
    Friend WithEvents lblCurrentFloor As Label
    Friend WithEvents lblDirection As Label
    Friend WithEvents lblDoorStatus As Label
    Friend WithEvents btnFloor4 As Button
    Friend WithEvents btnFloor3 As Button
    Friend WithEvents btnFloor2 As Button
    Friend WithEvents btnFloor1 As Button
    Friend WithEvents btnOpenDoor As Button
    Friend WithEvents btnCloseDoor As Button
    Friend WithEvents tmrElevator As Timer
    Friend WithEvents Label1 As Label
    Friend WithEvents pnlCabin As Panel
    Friend WithEvents pnlDoorLeft As Panel
    Friend WithEvents pnlDoorRight As Panel
    Friend WithEvents tmrDoor As Timer
    Friend WithEvents tmrWait As Timer
End Class
