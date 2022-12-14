Imports System.ComponentModel

Public Class Form1

    Dim Inicio As Date
    Dim Final As Date
    Dim MiHora As Date

    Dim diasemana As String
    Dim BS As New BindingSource

    Dim Cancelado As Boolean
    Dim Ruta As String

    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        SerialPort1.Close()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AbrirConexion()

        PoblarGrid()

        For Each PuertoDisponible As String In My.Computer.Ports.SerialPortNames
            Puertos.Items.Add(PuertoDisponible)
        Next
        If Puertos.Items.Count > 0 Then
            Puertos.Text = Puertos.Items(0)
            SerialPort1.PortName = Puertos.Text
            SerialPort1.Open()
            SerialPort1.Write("0")
            btnActivar_Click(True, e)
        Else
            Puertos.Items.Clear()
            Puertos.Text = ""
        End If

    End Sub

    Public Sub PoblarGrid()
        Dim da As New OleDb.OleDbDataAdapter("select * from alarmas", Conexion)
        Dim ds As New DataSet
        da.Fill(ds)

        DataGridView1.AutoGenerateColumns = False
        BS.DataSource = ds.Tables(0)
        DataGridView1.DataSource = BS

    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        Dim Hora As String = Now.ToString("hh:mm:ss tt")

        Dim Domingo As String = "0"
        Dim Lunes As String = "0"
        Dim Martes As String = "0"
        Dim Miercoles As String = "0"
        Dim Jueves As String = "0"
        Dim Viernes As String = "0"
        Dim Sabado As String = "0"


        Dim cmd As New OleDb.OleDbCommand("insert into alarmas(domingo,lunes,martes,miercoles,jueves,viernes,sabado,hora) values('" & Domingo & "','" & Lunes & "','" & Martes & "','" & Miercoles & "','" & Jueves & "','" & Viernes & "','" & Sabado & "','" & Hora & "')", Conexion)
        cmd.ExecuteNonQuery()


        PoblarGrid()
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        If DataGridView1.Rows.Count > 0 Then

            For Each fila As DataGridViewRow In DataGridView1.Rows

                If Not IsDBNull(DataGridView1.CurrentRow.Cells("ID").Value) Then
                    BS.EndEdit()

                    Dim Hora As String = Now.ToString("hh:mm:ss tt")

                    Dim Domingo As String = IIf(fila.Cells("domingo").Value = True, "1", "0")
                    Dim Lunes As String = IIf(fila.Cells("lunes").Value = True, "1", "0")
                    Dim Martes As String = IIf(fila.Cells("martes").Value = True, "1", "0")
                    Dim Miercoles As String = IIf(fila.Cells("miercoles").Value = True, "1", "0")
                    Dim Jueves As String = IIf(fila.Cells("jueves").Value = True, "1", "0")
                    Dim Viernes As String = IIf(fila.Cells("viernes").Value = True, "1", "0")
                    Dim Sabado As String = IIf(fila.Cells("sabado").Value = True, "1", "0")
                    Hora = IIf(fila.Cells("hora").Value.ToString = "", Hora, fila.Cells("hora").Value)

                    Dim cmd As New OleDb.OleDbCommand("update alarmas set domingo='" & Domingo & "',lunes='" & Lunes & "',martes='" & Martes & "',miercoles='" & Miercoles & "',jueves='" & Jueves & "',viernes='" & Viernes & "',sabado='" & Sabado & "',hora='" & Hora & "' where id=" & fila.Cells("ID").Value, Conexion)
                    cmd.ExecuteNonQuery()

                End If
            Next
            PoblarGrid()
        End If
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        If DataGridView1.Rows.Count > 0 Then
            Dim cmd As New OleDb.OleDbCommand("delete * from alarmas where id=" & DataGridView1.CurrentRow.Cells("ID").Value, Conexion)
            cmd.ExecuteNonQuery()

            PoblarGrid()
        End If
    End Sub

    Private Sub btnActivar_Click(sender As Object, e As EventArgs) Handles btnActivar.Click

        If btnActivar.BackColor = Color.Red Then
            btnActivar.Text = "Activar Alarma"
            btnActivar.BackColor = Color.Gainsboro
            Timer2.Stop()
            Cancelado = True


        Else
            Cancelado = False
            btnActivar.BackColor = Color.Red

            Timer2.Start()
            btnActivar.Text = "Desactivar Alarma"
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label1.Text = Now.ToString("hh:mm:ss tt")
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        For Each fila As DataGridViewRow In DataGridView1.Rows

            Inicio = fila.Cells("HORA").Value
            Final = Inicio.AddSeconds(10)
            MiHora = CDate(Now.ToString("hh:mm:ss tt"))


            Dim MyDate As Date : Dim MyWeekDay As Integer
            MyDate = Format(Today.Date, "yyyy/MM/dd")
            MyWeekDay = Weekday(MyDate)

            diasemana = VerificaDia(MyWeekDay)


            If fila.Cells(diasemana).Value = True Then

                If Label1.Text.Length > 0 And fila.Cells("HORA").Value.ToString.Length > 0 Then

                    If MiHora = CDate(Inicio) Then
                        SerialPort1.Write("1")
                    End If
                    If MiHora = Final Then
                        SerialPort1.Write("0")
                    End If



                        MiHora = Now.ToString("hh:mm:ss tt")

                End If
            End If


        Next

    End Sub

    Private Function VerificaDia(ByVal dia As Integer)
        If dia = 1 Then
            diasemana = "DOMINGO"
        ElseIf dia = 2 Then
            diasemana = "LUNES"
        ElseIf dia = 3 Then
            diasemana = "MARTES"
        ElseIf dia = 4 Then
            diasemana = "MIERCOLES"
        ElseIf dia = 5 Then
            diasemana = "JUEVES"
        ElseIf dia = 6 Then
            diasemana = "VIERNES"
        ElseIf dia = 7 Then
            diasemana = "SABADO"
        End If

        Return diasemana
    End Function

    Private Sub BackgroundWorker1_DoWork(sender As Object, e As DoWorkEventArgs) Handles BackgroundWorker1.DoWork

    End Sub

    Private Sub BackgroundWorker1_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles BackgroundWorker1.RunWorkerCompleted

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        If DataGridView1.Rows.Count > 0 Then
            If DataGridView1.Columns(e.ColumnIndex).Name = "SONIDO" Then
                OpenFileDialog1.InitialDirectory = (My.Computer.FileSystem.CurrentDirectory & "\Alarmas")
                OpenFileDialog1.Filter = "wav files (*.wav)|*.wav|All files (*.*)|*.*"
                Dim result As DialogResult = OpenFileDialog1.ShowDialog()

                If result = Windows.Forms.DialogResult.OK Then
                    DataGridView1.CurrentRow.Cells("SONIDO").Value = "Alarmas\" & System.IO.Path.GetFileName(OpenFileDialog1.FileName)
                End If
            End If
        End If
    End Sub

    Private Sub DataGridView1_CellMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DataGridView1.CellMouseDoubleClick
        If DataGridView1.Columns(e.ColumnIndex).Name = "HORA" Then
            Dim Hora As String = Now.ToString("hh:mm:ss tt")
            DataGridView1.CurrentRow.Cells("HORA").Value = Hora
        End If
    End Sub

    Private Sub Puertos_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Puertos.SelectedIndexChanged

    End Sub
End Class
