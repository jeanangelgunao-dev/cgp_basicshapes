Imports System.Collections.Generic
Public Class Form1


    Dim currentFloor As Integer = 1
    Dim targetFloor As Integer = 1

    Dim floorQueue As New Queue(Of Integer)
    Dim elevatorMoving As Boolean = False
    Dim waitingToMove As Boolean = False

    Dim floor1Y As Integer
    Dim floor2Y As Integer
    Dim floor3Y As Integer
    Dim floor4Y As Integer

    Dim doorOpening As Boolean = False
    Dim doorClosing As Boolean = False
    Dim leftDoorClosedPos As Integer
    Dim rightDoorClosedPos As Integer


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        floor1Y = pnlCabin.Top
        floor2Y = floor1Y - 100
        floor3Y = floor2Y - 100
        floor4Y = floor3Y - 100

        lblCurrentFloor.Text = "1"
        lblDirection.Text = "● IDLE"
        lblDoorStatus.Text = "Door: Closed"
        leftDoorClosedPos = pnlDoorLeft.Left
        rightDoorClosedPos = pnlDoorRight.Left
        HighlightFloorButton(1)

    End Sub

    Private Function GetFloorPosition(floor As Integer) As Integer

        Select Case floor

            Case 1
                Return floor1Y

            Case 2
                Return floor2Y

            Case 3
                Return floor3Y

            Case 4
                Return floor4Y

        End Select

        Return floor1Y

    End Function

    Private Sub MoveElevator(floor As Integer)

        floorQueue.Enqueue(floor)

        If Not elevatorMoving Then

            ProcessNextFloor()

        End If

    End Sub
    Private Sub ProcessNextFloor()

        If floorQueue.Count = 0 Then

            elevatorMoving = False
            Exit Sub

        End If

        elevatorMoving = True

        targetFloor = floorQueue.Dequeue()

        HighlightFloorButton(targetFloor)

        waitingToMove = True

        CloseDoor()

    End Sub

    Private Sub HighlightFloorButton(floor As Integer)

        btnFloor1.BackColor = SystemColors.Control
        btnFloor2.BackColor = SystemColors.Control
        btnFloor3.BackColor = SystemColors.Control
        btnFloor4.BackColor = SystemColors.Control

        Select Case floor

            Case 1
                btnFloor1.BackColor = Color.LightGreen

            Case 2
                btnFloor2.BackColor = Color.LightGreen

            Case 3
                btnFloor3.BackColor = Color.LightGreen

            Case 4
                btnFloor4.BackColor = Color.LightGreen

        End Select

    End Sub

    Private Sub tmrElevator_Tick(sender As Object, e As EventArgs) Handles tmrElevator.Tick

        Dim targetY As Integer = GetFloorPosition(targetFloor)

        If pnlCabin.Top > targetY Then

            pnlCabin.Top -= 2

            lblDirection.Text = "↑ UP"
            lblDirection.ForeColor = Color.Green

        ElseIf pnlCabin.Top < targetY Then

            pnlCabin.Top += 2

            lblDirection.Text = "↓ DOWN"
            lblDirection.ForeColor = Color.Red

        Else

            tmrElevator.Stop()

            currentFloor = targetFloor

            lblCurrentFloor.Text = currentFloor.ToString()

            lblDirection.Text = "● IDLE"
            lblDirection.ForeColor = Color.Blue

            OpenDoor()

            tmrWait.Start()

        End If

    End Sub

    Private Sub OpenDoor()

        doorOpening = True
        doorClosing = False

        tmrDoor.Start()

    End Sub

    Private Sub CloseDoor()

        doorClosing = True
        doorOpening = False

        tmrDoor.Start()

    End Sub

    Private Sub tmrWait_Tick(sender As Object, e As EventArgs) Handles tmrWait.Tick

        tmrWait.Stop()

        ProcessNextFloor()

    End Sub
    Private Sub tmrDoor_Tick(sender As Object, e As EventArgs) Handles tmrDoor.Tick

        If doorOpening Then

            pnlDoorLeft.Left -= 1
            pnlDoorRight.Left += 1

            If pnlDoorLeft.Left <= -20 Then

                tmrDoor.Stop()

                lblDoorStatus.Text = "Door: Open"

            End If

        End If

        If doorClosing Then

            pnlDoorLeft.Left += 1
            pnlDoorRight.Left -= 1

            If pnlDoorLeft.Left >= 0 Then

                pnlDoorLeft.Left = leftDoorClosedPos
                pnlDoorRight.Left = rightDoorClosedPos

                tmrDoor.Stop()

                lblDoorStatus.Text = "Door: Closed"

                If waitingToMove Then

                    waitingToMove = False

                    tmrElevator.Start()

                End If

            End If

        End If

    End Sub

    Private Sub btnFloor1_Click(sender As Object, e As EventArgs) Handles btnFloor1.Click

        MoveElevator(1)

    End Sub

    Private Sub btnFloor2_Click(sender As Object, e As EventArgs) Handles btnFloor2.Click

        MoveElevator(2)

    End Sub

    Private Sub btnFloor3_Click(sender As Object, e As EventArgs) Handles btnFloor3.Click

        MoveElevator(3)

    End Sub

    Private Sub btnFloor4_Click(sender As Object, e As EventArgs) Handles btnFloor4.Click

        MoveElevator(4)

    End Sub

    Private Sub btnOpenDoor_Click(sender As Object, e As EventArgs) Handles btnOpenDoor.Click

        OpenDoor()

    End Sub

    Private Sub btnCloseDoor_Click(sender As Object, e As EventArgs) Handles btnCloseDoor.Click

        CloseDoor()

    End Sub

End Class