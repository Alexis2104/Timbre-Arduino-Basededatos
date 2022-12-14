<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.btnActivar = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DOMINGO = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.LUNES = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.MARTES = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.MIERCOLES = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.JUEVES = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.VIERNES = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.SABADO = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.HORA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SerialPort1 = New System.IO.Ports.SerialPort(Me.components)
        Me.Puertos = New System.Windows.Forms.ComboBox()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Agency FB", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(377, 21)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(262, 97)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "0:00:00"
        '
        'btnEliminar
        '
        Me.btnEliminar.BackColor = System.Drawing.Color.SkyBlue
        Me.btnEliminar.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEliminar.Location = New System.Drawing.Point(379, 122)
        Me.btnEliminar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(166, 65)
        Me.btnEliminar.TabIndex = 16
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.UseVisualStyleBackColor = False
        '
        'btnGuardar
        '
        Me.btnGuardar.BackColor = System.Drawing.Color.SkyBlue
        Me.btnGuardar.Font = New System.Drawing.Font("Microsoft JhengHei", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGuardar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnGuardar.Location = New System.Drawing.Point(205, 122)
        Me.btnGuardar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(166, 65)
        Me.btnGuardar.TabIndex = 15
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.UseVisualStyleBackColor = False
        '
        'btnNuevo
        '
        Me.btnNuevo.BackColor = System.Drawing.Color.SkyBlue
        Me.btnNuevo.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNuevo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnNuevo.Location = New System.Drawing.Point(31, 122)
        Me.btnNuevo.Margin = New System.Windows.Forms.Padding(4)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(166, 65)
        Me.btnNuevo.TabIndex = 14
        Me.btnNuevo.Text = "Nueva"
        Me.btnNuevo.UseVisualStyleBackColor = False
        '
        'btnActivar
        '
        Me.btnActivar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnActivar.BackColor = System.Drawing.Color.Gainsboro
        Me.btnActivar.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnActivar.Location = New System.Drawing.Point(850, 122)
        Me.btnActivar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnActivar.Name = "btnActivar"
        Me.btnActivar.Size = New System.Drawing.Size(224, 65)
        Me.btnActivar.TabIndex = 13
        Me.btnActivar.Text = "Activar Alarma"
        Me.btnActivar.UseVisualStyleBackColor = False
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'Timer2
        '
        Me.Timer2.Interval = 200
        '
        'BackgroundWorker1
        '
        Me.BackgroundWorker1.WorkerReportsProgress = True
        Me.BackgroundWorker1.WorkerSupportsCancellation = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ID, Me.DOMINGO, Me.LUNES, Me.MARTES, Me.MIERCOLES, Me.JUEVES, Me.VIERNES, Me.SABADO, Me.HORA})
        Me.DataGridView1.Location = New System.Drawing.Point(31, 207)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(4)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.Size = New System.Drawing.Size(1043, 311)
        Me.DataGridView1.TabIndex = 1
        '
        'ID
        '
        Me.ID.DataPropertyName = "id"
        Me.ID.HeaderText = "ID"
        Me.ID.MinimumWidth = 6
        Me.ID.Name = "ID"
        Me.ID.Visible = False
        '
        'DOMINGO
        '
        Me.DOMINGO.DataPropertyName = "domingo"
        Me.DOMINGO.FillWeight = 81.06736!
        Me.DOMINGO.HeaderText = "DOMINGO"
        Me.DOMINGO.MinimumWidth = 6
        Me.DOMINGO.Name = "DOMINGO"
        Me.DOMINGO.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        '
        'LUNES
        '
        Me.LUNES.DataPropertyName = "lunes"
        Me.LUNES.FillWeight = 81.06736!
        Me.LUNES.HeaderText = "LUNES"
        Me.LUNES.MinimumWidth = 6
        Me.LUNES.Name = "LUNES"
        Me.LUNES.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        '
        'MARTES
        '
        Me.MARTES.DataPropertyName = "martes"
        Me.MARTES.FillWeight = 81.06736!
        Me.MARTES.HeaderText = "MARTES"
        Me.MARTES.MinimumWidth = 6
        Me.MARTES.Name = "MARTES"
        Me.MARTES.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        '
        'MIERCOLES
        '
        Me.MIERCOLES.DataPropertyName = "miercoles"
        Me.MIERCOLES.FillWeight = 81.06736!
        Me.MIERCOLES.HeaderText = "MIERCOLES"
        Me.MIERCOLES.MinimumWidth = 6
        Me.MIERCOLES.Name = "MIERCOLES"
        Me.MIERCOLES.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        '
        'JUEVES
        '
        Me.JUEVES.DataPropertyName = "jueves"
        Me.JUEVES.FillWeight = 81.06736!
        Me.JUEVES.HeaderText = "JUEVES"
        Me.JUEVES.MinimumWidth = 6
        Me.JUEVES.Name = "JUEVES"
        Me.JUEVES.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        '
        'VIERNES
        '
        Me.VIERNES.DataPropertyName = "viernes"
        Me.VIERNES.FillWeight = 81.06736!
        Me.VIERNES.HeaderText = "VIERNES"
        Me.VIERNES.MinimumWidth = 6
        Me.VIERNES.Name = "VIERNES"
        Me.VIERNES.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        '
        'SABADO
        '
        Me.SABADO.DataPropertyName = "sabado"
        Me.SABADO.FillWeight = 81.06736!
        Me.SABADO.HeaderText = "SABADO"
        Me.SABADO.MinimumWidth = 6
        Me.SABADO.Name = "SABADO"
        Me.SABADO.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        '
        'HORA
        '
        Me.HORA.DataPropertyName = "hora"
        Me.HORA.FillWeight = 127.8237!
        Me.HORA.HeaderText = "HORA"
        Me.HORA.MinimumWidth = 6
        Me.HORA.Name = "HORA"
        Me.HORA.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.HORA.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'Puertos
        '
        Me.Puertos.FormattingEnabled = True
        Me.Puertos.Location = New System.Drawing.Point(917, 44)
        Me.Puertos.Name = "Puertos"
        Me.Puertos.Size = New System.Drawing.Size(157, 24)
        Me.Puertos.TabIndex = 17
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(1105, 531)
        Me.Controls.Add(Me.Puertos)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.btnNuevo)
        Me.Controls.Add(Me.btnActivar)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label1)
        Me.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Alarma"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents btnEliminar As Button
    Friend WithEvents btnGuardar As Button
    Friend WithEvents btnNuevo As Button
    Friend WithEvents btnActivar As Button
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Timer2 As Timer
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents SerialPort1 As IO.Ports.SerialPort
    Friend WithEvents Puertos As ComboBox
    Friend WithEvents ID As DataGridViewTextBoxColumn
    Friend WithEvents DOMINGO As DataGridViewCheckBoxColumn
    Friend WithEvents LUNES As DataGridViewCheckBoxColumn
    Friend WithEvents MARTES As DataGridViewCheckBoxColumn
    Friend WithEvents MIERCOLES As DataGridViewCheckBoxColumn
    Friend WithEvents JUEVES As DataGridViewCheckBoxColumn
    Friend WithEvents VIERNES As DataGridViewCheckBoxColumn
    Friend WithEvents SABADO As DataGridViewCheckBoxColumn
    Friend WithEvents HORA As DataGridViewTextBoxColumn
End Class
