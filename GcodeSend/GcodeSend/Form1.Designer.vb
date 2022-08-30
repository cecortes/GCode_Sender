<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.gbxTop = New System.Windows.Forms.GroupBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.lblPath = New System.Windows.Forms.Label()
        Me.btnGcode = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cboPorts = New System.Windows.Forms.ComboBox()
        Me.pnlLeft = New System.Windows.Forms.Panel()
        Me.pbEdo = New System.Windows.Forms.ProgressBar()
        Me.btnSend = New System.Windows.Forms.Button()
        Me.txtXoffCh = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtXonCh = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtFlujo = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cboParidad = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtStopBits = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtDataBits = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cboBaudios = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.pnlMain = New System.Windows.Forms.Panel()
        Me.txtArchivo = New System.Windows.Forms.TextBox()
        Me.Serial = New System.IO.Ports.SerialPort(Me.components)
        Me.gbxTop.SuspendLayout()
        Me.pnlLeft.SuspendLayout()
        Me.pnlMain.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbxTop
        '
        Me.gbxTop.Controls.Add(Me.Label10)
        Me.gbxTop.Controls.Add(Me.lblPath)
        Me.gbxTop.Controls.Add(Me.btnGcode)
        Me.gbxTop.Controls.Add(Me.Label1)
        Me.gbxTop.Controls.Add(Me.cboPorts)
        Me.gbxTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.gbxTop.Location = New System.Drawing.Point(0, 0)
        Me.gbxTop.Name = "gbxTop"
        Me.gbxTop.Size = New System.Drawing.Size(914, 76)
        Me.gbxTop.TabIndex = 0
        Me.gbxTop.TabStop = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(186, 21)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(59, 17)
        Me.Label10.TabIndex = 5
        Me.Label10.Text = "Archivo:"
        '
        'lblPath
        '
        Me.lblPath.AutoSize = True
        Me.lblPath.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPath.ForeColor = System.Drawing.Color.DarkGreen
        Me.lblPath.Location = New System.Drawing.Point(186, 45)
        Me.lblPath.Name = "lblPath"
        Me.lblPath.Size = New System.Drawing.Size(0, 17)
        Me.lblPath.TabIndex = 4
        '
        'btnGcode
        '
        Me.btnGcode.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnGcode.Location = New System.Drawing.Point(788, 21)
        Me.btnGcode.Name = "btnGcode"
        Me.btnGcode.Size = New System.Drawing.Size(120, 41)
        Me.btnGcode.TabIndex = 3
        Me.btnGcode.Text = "Abrir Gcode"
        Me.btnGcode.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(116, 17)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Puertos Seriales:"
        '
        'cboPorts
        '
        Me.cboPorts.FormattingEnabled = True
        Me.cboPorts.Location = New System.Drawing.Point(6, 38)
        Me.cboPorts.Name = "cboPorts"
        Me.cboPorts.Size = New System.Drawing.Size(116, 24)
        Me.cboPorts.TabIndex = 0
        '
        'pnlLeft
        '
        Me.pnlLeft.Controls.Add(Me.pbEdo)
        Me.pnlLeft.Controls.Add(Me.btnSend)
        Me.pnlLeft.Controls.Add(Me.txtXoffCh)
        Me.pnlLeft.Controls.Add(Me.Label9)
        Me.pnlLeft.Controls.Add(Me.txtXonCh)
        Me.pnlLeft.Controls.Add(Me.Label8)
        Me.pnlLeft.Controls.Add(Me.txtFlujo)
        Me.pnlLeft.Controls.Add(Me.Label7)
        Me.pnlLeft.Controls.Add(Me.cboParidad)
        Me.pnlLeft.Controls.Add(Me.Label6)
        Me.pnlLeft.Controls.Add(Me.txtStopBits)
        Me.pnlLeft.Controls.Add(Me.Label5)
        Me.pnlLeft.Controls.Add(Me.txtDataBits)
        Me.pnlLeft.Controls.Add(Me.Label4)
        Me.pnlLeft.Controls.Add(Me.Label3)
        Me.pnlLeft.Controls.Add(Me.cboBaudios)
        Me.pnlLeft.Controls.Add(Me.Label2)
        Me.pnlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnlLeft.Location = New System.Drawing.Point(0, 76)
        Me.pnlLeft.Name = "pnlLeft"
        Me.pnlLeft.Size = New System.Drawing.Size(183, 504)
        Me.pnlLeft.TabIndex = 1
        '
        'pbEdo
        '
        Me.pbEdo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pbEdo.Location = New System.Drawing.Point(3, 469)
        Me.pbEdo.Name = "pbEdo"
        Me.pbEdo.Size = New System.Drawing.Size(177, 23)
        Me.pbEdo.TabIndex = 16
        '
        'btnSend
        '
        Me.btnSend.Location = New System.Drawing.Point(42, 417)
        Me.btnSend.Name = "btnSend"
        Me.btnSend.Size = New System.Drawing.Size(100, 37)
        Me.btnSend.TabIndex = 15
        Me.btnSend.Text = "Enviar"
        Me.btnSend.UseVisualStyleBackColor = True
        '
        'txtXoffCh
        '
        Me.txtXoffCh.Location = New System.Drawing.Point(79, 264)
        Me.txtXoffCh.Name = "txtXoffCh"
        Me.txtXoffCh.Size = New System.Drawing.Size(91, 22)
        Me.txtXoffCh.TabIndex = 14
        Me.txtXoffCh.Text = "19"
        Me.txtXoffCh.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(6, 269)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(67, 17)
        Me.Label9.TabIndex = 13
        Me.Label9.Text = "Xoff Char"
        '
        'txtXonCh
        '
        Me.txtXonCh.Location = New System.Drawing.Point(79, 226)
        Me.txtXonCh.Name = "txtXonCh"
        Me.txtXonCh.Size = New System.Drawing.Size(91, 22)
        Me.txtXonCh.TabIndex = 12
        Me.txtXonCh.Text = "17"
        Me.txtXonCh.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(6, 231)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(67, 17)
        Me.Label8.TabIndex = 11
        Me.Label8.Text = "Xon Char"
        '
        'txtFlujo
        '
        Me.txtFlujo.Location = New System.Drawing.Point(67, 189)
        Me.txtFlujo.Name = "txtFlujo"
        Me.txtFlujo.Size = New System.Drawing.Size(103, 22)
        Me.txtFlujo.TabIndex = 10
        Me.txtFlujo.Text = "Xon/Xoff"
        Me.txtFlujo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(6, 194)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(38, 17)
        Me.Label7.TabIndex = 9
        Me.Label7.Text = "Flujo"
        '
        'cboParidad
        '
        Me.cboParidad.FormattingEnabled = True
        Me.cboParidad.Items.AddRange(New Object() {"Even", "Odd"})
        Me.cboParidad.Location = New System.Drawing.Point(69, 152)
        Me.cboParidad.Name = "cboParidad"
        Me.cboParidad.Size = New System.Drawing.Size(101, 24)
        Me.cboParidad.TabIndex = 8
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 159)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(57, 17)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "Paridad"
        '
        'txtStopBits
        '
        Me.txtStopBits.Location = New System.Drawing.Point(71, 122)
        Me.txtStopBits.Name = "txtStopBits"
        Me.txtStopBits.Size = New System.Drawing.Size(51, 22)
        Me.txtStopBits.TabIndex = 6
        Me.txtStopBits.Text = "2"
        Me.txtStopBits.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 127)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(64, 17)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Stop Bits"
        '
        'txtDataBits
        '
        Me.txtDataBits.Location = New System.Drawing.Point(71, 94)
        Me.txtDataBits.Name = "txtDataBits"
        Me.txtDataBits.Size = New System.Drawing.Size(51, 22)
        Me.txtDataBits.TabIndex = 4
        Me.txtDataBits.Text = "7"
        Me.txtDataBits.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 99)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(65, 17)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Data Bits"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 60)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(59, 17)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Baudios"
        '
        'cboBaudios
        '
        Me.cboBaudios.FormattingEnabled = True
        Me.cboBaudios.Items.AddRange(New Object() {"115200", "57600", "38400", "19200", "9600", "4800", "2400", "1200", "300"})
        Me.cboBaudios.Location = New System.Drawing.Point(71, 57)
        Me.cboBaudios.Name = "cboBaudios"
        Me.cboBaudios.Size = New System.Drawing.Size(99, 24)
        Me.cboBaudios.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(3, 3)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(167, 17)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Configuración del puerto:"
        '
        'pnlMain
        '
        Me.pnlMain.Controls.Add(Me.txtArchivo)
        Me.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlMain.Location = New System.Drawing.Point(183, 76)
        Me.pnlMain.Name = "pnlMain"
        Me.pnlMain.Size = New System.Drawing.Size(731, 504)
        Me.pnlMain.TabIndex = 2
        '
        'txtArchivo
        '
        Me.txtArchivo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtArchivo.Location = New System.Drawing.Point(0, 0)
        Me.txtArchivo.Multiline = True
        Me.txtArchivo.Name = "txtArchivo"
        Me.txtArchivo.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtArchivo.Size = New System.Drawing.Size(731, 504)
        Me.txtArchivo.TabIndex = 0
        '
        'Serial
        '
        Me.Serial.DataBits = 7
        Me.Serial.DiscardNull = True
        Me.Serial.Handshake = System.IO.Ports.Handshake.XOnXOff
        Me.Serial.Parity = System.IO.Ports.Parity.Even
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(914, 580)
        Me.Controls.Add(Me.pnlMain)
        Me.Controls.Add(Me.pnlLeft)
        Me.Controls.Add(Me.gbxTop)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Gcode Sender  -   César López 2020"
        Me.gbxTop.ResumeLayout(False)
        Me.gbxTop.PerformLayout()
        Me.pnlLeft.ResumeLayout(False)
        Me.pnlLeft.PerformLayout()
        Me.pnlMain.ResumeLayout(False)
        Me.pnlMain.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents gbxTop As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents cboPorts As ComboBox
    Friend WithEvents pnlLeft As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents pnlMain As Panel
    Friend WithEvents btnGcode As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents cboBaudios As ComboBox
    Friend WithEvents txtDataBits As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtStopBits As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents cboParidad As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtXoffCh As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txtXonCh As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtFlujo As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Serial As IO.Ports.SerialPort
    Friend WithEvents Label10 As Label
    Friend WithEvents lblPath As Label
    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents txtArchivo As TextBox
    Friend WithEvents btnSend As Button
    Friend WithEvents pbEdo As ProgressBar
End Class
