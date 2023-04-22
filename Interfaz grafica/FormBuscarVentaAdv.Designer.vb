<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormBuscarVentaAdv
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.FiltroCantidadMax = New System.Windows.Forms.NumericUpDown()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.FiltroCantidadMin = New System.Windows.Forms.NumericUpDown()
        Me.DTFechaMax = New System.Windows.Forms.DateTimePicker()
        Me.DTFechaMin = New System.Windows.Forms.DateTimePicker()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.FiltroPrecioTMax = New System.Windows.Forms.NumericUpDown()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.FiltroPrecioTMin = New System.Windows.Forms.NumericUpDown()
        Me.DataGridViewVentas = New System.Windows.Forms.DataGridView()
        Me.BtnBuscarVenta = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.FiltroCantidadMax, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FiltroCantidadMin, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FiltroPrecioTMax, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FiltroPrecioTMin, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridViewVentas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Gainsboro
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.FiltroCantidadMax)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.FiltroCantidadMin)
        Me.Panel1.Controls.Add(Me.DTFechaMax)
        Me.Panel1.Controls.Add(Me.DTFechaMin)
        Me.Panel1.Controls.Add(Me.Label11)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.FiltroPrecioTMax)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.FiltroPrecioTMin)
        Me.Panel1.Location = New System.Drawing.Point(154, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(480, 366)
        Me.Panel1.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(327, 173)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 21)
        Me.Label1.TabIndex = 26
        Me.Label1.Text = "Hasta"
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(266, 268)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(196, 21)
        Me.Label4.TabIndex = 25
        Me.Label4.Text = "Cantidad maxima vendida"
        '
        'FiltroCantidadMax
        '
        Me.FiltroCantidadMax.Location = New System.Drawing.Point(278, 308)
        Me.FiltroCantidadMax.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        Me.FiltroCantidadMax.Name = "FiltroCantidadMax"
        Me.FiltroCantidadMax.Size = New System.Drawing.Size(136, 20)
        Me.FiltroCantidadMax.TabIndex = 24
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(96, 173)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 21)
        Me.Label3.TabIndex = 23
        Me.Label3.Text = "Desde"
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(38, 268)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(185, 21)
        Me.Label2.TabIndex = 22
        Me.Label2.Text = "Cantidad minima vendida"
        '
        'FiltroCantidadMin
        '
        Me.FiltroCantidadMin.Location = New System.Drawing.Point(51, 308)
        Me.FiltroCantidadMin.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        Me.FiltroCantidadMin.Name = "FiltroCantidadMin"
        Me.FiltroCantidadMin.Size = New System.Drawing.Size(139, 20)
        Me.FiltroCantidadMin.TabIndex = 21
        '
        'DTFechaMax
        '
        Me.DTFechaMax.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DTFechaMax.Location = New System.Drawing.Point(249, 209)
        Me.DTFechaMax.Name = "DTFechaMax"
        Me.DTFechaMax.Size = New System.Drawing.Size(213, 20)
        Me.DTFechaMax.TabIndex = 20
        '
        'DTFechaMin
        '
        Me.DTFechaMin.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DTFechaMin.Location = New System.Drawing.Point(12, 209)
        Me.DTFechaMin.Name = "DTFechaMin"
        Me.DTFechaMin.Size = New System.Drawing.Size(211, 20)
        Me.DTFechaMin.TabIndex = 19
        '
        'Label11
        '
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(297, 78)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(117, 21)
        Me.Label11.TabIndex = 16
        Me.Label11.Text = "Precio máximo"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(128, 19)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(242, 20)
        Me.Label9.TabIndex = 15
        Me.Label9.Text = "Filtro de busqueda de ventas"
        '
        'FiltroPrecioTMax
        '
        Me.FiltroPrecioTMax.Location = New System.Drawing.Point(278, 116)
        Me.FiltroPrecioTMax.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        Me.FiltroPrecioTMax.Name = "FiltroPrecioTMax"
        Me.FiltroPrecioTMax.Size = New System.Drawing.Size(136, 20)
        Me.FiltroPrecioTMax.TabIndex = 7
        '
        'Label10
        '
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(72, 78)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(118, 21)
        Me.Label10.TabIndex = 15
        Me.Label10.Text = "Precio mínimo"
        '
        'FiltroPrecioTMin
        '
        Me.FiltroPrecioTMin.Location = New System.Drawing.Point(51, 116)
        Me.FiltroPrecioTMin.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        Me.FiltroPrecioTMin.Name = "FiltroPrecioTMin"
        Me.FiltroPrecioTMin.Size = New System.Drawing.Size(139, 20)
        Me.FiltroPrecioTMin.TabIndex = 15
        '
        'DataGridViewVentas
        '
        Me.DataGridViewVentas.AllowUserToAddRows = False
        Me.DataGridViewVentas.AllowUserToDeleteRows = False
        Me.DataGridViewVentas.BackgroundColor = System.Drawing.SystemColors.Info
        Me.DataGridViewVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewVentas.Location = New System.Drawing.Point(34, 429)
        Me.DataGridViewVentas.Name = "DataGridViewVentas"
        Me.DataGridViewVentas.ReadOnly = True
        Me.DataGridViewVentas.Size = New System.Drawing.Size(708, 150)
        Me.DataGridViewVentas.TabIndex = 18
        '
        'BtnBuscarVenta
        '
        Me.BtnBuscarVenta.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnBuscarVenta.Location = New System.Drawing.Point(559, 384)
        Me.BtnBuscarVenta.Name = "BtnBuscarVenta"
        Me.BtnBuscarVenta.Size = New System.Drawing.Size(75, 23)
        Me.BtnBuscarVenta.TabIndex = 19
        Me.BtnBuscarVenta.Text = "Buscar"
        Me.BtnBuscarVenta.UseVisualStyleBackColor = True
        '
        'FormBuscarVentaAdv
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.ClientSize = New System.Drawing.Size(779, 607)
        Me.Controls.Add(Me.BtnBuscarVenta)
        Me.Controls.Add(Me.DataGridViewVentas)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "FormBuscarVentaAdv"
        Me.Text = "FormBuscarVentaAdv"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.FiltroCantidadMax, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FiltroCantidadMin, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FiltroPrecioTMax, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FiltroPrecioTMin, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridViewVentas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents FiltroCantidadMax As NumericUpDown
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents FiltroCantidadMin As NumericUpDown
    Friend WithEvents DTFechaMax As DateTimePicker
    Friend WithEvents DTFechaMin As DateTimePicker
    Friend WithEvents Label11 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents FiltroPrecioTMax As NumericUpDown
    Friend WithEvents Label10 As Label
    Friend WithEvents FiltroPrecioTMin As NumericUpDown
    Friend WithEvents DataGridViewVentas As DataGridView
    Friend WithEvents BtnBuscarVenta As Button
End Class
