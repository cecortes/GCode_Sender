Imports System.IO

Public Class Form1
#Region "GLOBALES"
    Dim ruta As String = ""

#End Region

#Region "METODOS"
    ''' <summary>
    ''' Habilita los elementos necesarios
    ''' No recibe ni devuelve nada
    ''' </summary>
    Public Sub Habilitar()
        cboPorts.Enabled = True
        cboBaudios.Enabled = True
        cboParidad.Enabled = True
        txtDataBits.Enabled = True
        txtStopBits.Enabled = True
        txtFlujo.Enabled = True
        txtXonCh.Enabled = True
        txtXoffCh.Enabled = True
        btnSend.Enabled = True
    End Sub

    ''' <summary>
    ''' Deshabilita los elementos necesarios
    ''' No recibe ni devuelve nada
    ''' </summary>
    Public Sub Deshabilitar()
        cboPorts.Enabled = False
        cboBaudios.Enabled = False
        cboParidad.Enabled = False
        txtDataBits.Enabled = False
        txtStopBits.Enabled = False
        txtFlujo.Enabled = False
        txtXonCh.Enabled = False
        txtXoffCh.Enabled = False
        btnSend.Enabled = False
    End Sub
#End Region

#Region "FUNCIONES"
    ''' <summary>
    ''' Se encarga de abrir la ruta del archivo y por medio de un objeto streamreader
    ''' leer el contenido del archivo para volcarlo en un array de retorno con los
    ''' saltos de línea incluidos.
    ''' </summary>
    ''' <param name="ruta"></param>
    ''' <returns></returns>
    Public Function AbrirArchivo(ByVal ruta As String)
        'Locales
        Dim objReader As New StreamReader(ruta)
        Dim sLine As String = ""
        Dim Texto As String = ""
        Dim arrText As New ArrayList()

        'Rutina para leer línea por línea
        Do
            sLine = objReader.ReadLine()

            'Evaluamos el contenido de la línea
            If Not sLine Is Nothing Then
                'Capturamos el resultado en un array
                arrText.Add(sLine + vbCrLf)
            End If

        Loop Until sLine Is Nothing

        'Cerramos el lector
        objReader.Close()

        'Agregamos el contenido del arreglo a la variable texto y la devolvemos
        For Each sLine In arrText
            Texto += sLine
        Next

        Return Texto
    End Function
#End Region

#Region "EVENTOS"

    ''' <summary>
    ''' Se encarga de cargar los valores necesarios.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Obtenemos los nombres de los puertos en un array y los pasamos al combo
        Dim Ports As String() = System.IO.Ports.SerialPort.GetPortNames()

        'Evaluamos el número de puertos encontrados
        If Ports.Length = 0 Then
            'Mensaje usuario
            MsgBox("No se encontraron puertos disponibles", MsgBoxStyle.Information, "GcodeSender (C) 2020")

            'Deshabilitamos el combobox
            Deshabilitar()
        Else
            'Agregamos los puertos al combo
            cboPorts.Items.AddRange(Ports)

            'Habilitamos el combo
            Habilitar()

            'Posicion en index 0
            cboPorts.Text = cboPorts.Items.Item(0)
            cboBaudios.Text = cboBaudios.Items.Item(3)
            cboParidad.Text = cboParidad.Items.Item(0)

            'Labels y textos
            lblPath.Text = ""
        End If
    End Sub

    ''' <summary>
    ''' Se encarga de abrir el dialogo y obtener el path del archivo
    ''' Vacía el contenido del texto en un rich text
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnGcode_Click(sender As Object, e As EventArgs) Handles btnGcode.Click
        Dim abrir As New OpenFileDialog

        'Iniciando las configuraciones del openfile dialog
        abrir.Filter = "Gcode | *.NC | Texto | *.txt | Todos los archivos | *.*"

        'Evaluamos el botón Ok para capturar el path
        If (abrir.ShowDialog = Windows.Forms.DialogResult.OK) Then
            lblPath.Text = abrir.FileName

            'Capturamos el path en su variable
            ruta = lblPath.Text

            'Llamamos a la función encargada de leer el archivo
            'txtArchivo.Text = AbrirArchivo(lblPath.Text)

            Dim texto As String = My.Computer.FileSystem.ReadAllText(lblPath.Text)

            txtArchivo.Text = texto
        End If

    End Sub

    Private Sub btnSend_Click(sender As Object, e As EventArgs) Handles btnSend.Click
        'Locales
        Dim objReader As New StreamReader(ruta)
        Dim sLine As String = ""

        pbEdo.Value = 0

        Try
            With Serial
                .BaudRate = Convert.ToInt32(cboBaudios.Text)
                .DataBits = Convert.ToInt32(txtDataBits.Text)
                .Parity = Ports.Parity.Even
                .StopBits = Ports.StopBits.Two
                .Handshake = Ports.Handshake.XOnXOff
                .PortName = cboPorts.Text
                .Open()

                If .IsOpen Then
                    MsgBox("Conectado")
                End If
            End With
        Catch ex As Exception
            MsgBox("Error " + ex.ToString)
        End Try

        If Serial.IsOpen Then
            'Rutina para leer línea por línea
            Do
                sLine = objReader.ReadLine()

                'Evaluamos el contenido de la línea
                If Not sLine Is Nothing Then
                    Serial.WriteLine(vbCr + sLine)
                End If

                If pbEdo.Value = 100 Then
                    pbEdo.Value = 0
                Else
                    pbEdo.Value = pbEdo.Value + 10
                End If

            Loop Until sLine Is Nothing

            pbEdo.Value = 100

            'Cerramos el lector
            objReader.Close()

            'Cerramos el puerto al finalizar la transmisión
            Serial.Close()
        End If
    End Sub


#End Region
End Class
