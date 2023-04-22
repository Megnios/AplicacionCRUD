<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormBuscarProductoAdv
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
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.FiltroPrecioMax = New System.Windows.Forms.NumericUpDown()
        Me.FiltroPrecioMin = New System.Windows.Forms.NumericUpDown()
        Me.TxtCategoria = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataGridViewProductos = New System.Windows.Forms.DataGridView()
        Me.BtnBuscarProducto = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.FiltroPrecioMax, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FiltroPrecioMin, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridViewProductos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Gainsboro
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.FiltroPrecioMax)
        Me.Panel1.Controls.Add(Me.FiltroPrecioMin)
        Me.Panel1.Controls.Add(Me.TxtCategoria)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(21, 28)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(427, 240)
        Me.Panel1.TabIndex = 5
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(19, 133)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(85, 13)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Precio minimo"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(16, 183)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(88, 13)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Precio maximo"
        '
        'FiltroPrecioMax
        '
        Me.FiltroPrecioMax.Location = New System.Drawing.Point(111, 181)
        Me.FiltroPrecioMax.Maximum = New Decimal(New Integer() {100000, 0, 0, 0})
        Me.FiltroPrecioMax.Name = "FiltroPrecioMax"
        Me.FiltroPrecioMax.Size = New System.Drawing.Size(227, 20)
        Me.FiltroPrecioMax.TabIndex = 10
        '
        'FiltroPrecioMin
        '
        Me.FiltroPrecioMin.Location = New System.Drawing.Point(111, 131)
        Me.FiltroPrecioMin.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        Me.FiltroPrecioMin.Name = "FiltroPrecioMin"
        Me.FiltroPrecioMin.Size = New System.Drawing.Size(227, 20)
        Me.FiltroPrecioMin.TabIndex = 9
        '
        'TxtCategoria
        '
        Me.TxtCategoria.Location = New System.Drawing.Point(111, 83)
        Me.TxtCategoria.Name = "TxtCategoria"
        Me.TxtCategoria.Size = New System.Drawing.Size(227, 20)
        Me.TxtCategoria.TabIndex = 8
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(39, 86)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(61, 13)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Categoria"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(137, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(162, 20)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Datos del producto"
        '
        'DataGridViewProductos
        '
        Me.DataGridViewProductos.BackgroundColor = System.Drawing.SystemColors.Info
        Me.DataGridViewProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewProductos.Location = New System.Drawing.Point(21, 316)
        Me.DataGridViewProductos.Name = "DataGridViewProductos"
        Me.DataGridViewProductos.Size = New System.Drawing.Size(427, 196)
        Me.DataGridViewProductos.TabIndex = 6
        '
        'BtnBuscarProducto
        '
        Me.BtnBuscarProducto.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnBuscarProducto.Location = New System.Drawing.Point(373, 274)
        Me.BtnBuscarProducto.Name = "BtnBuscarProducto"
        Me.BtnBuscarProducto.Size = New System.Drawing.Size(75, 23)
        Me.BtnBuscarProducto.TabIndex = 7
        Me.BtnBuscarProducto.Text = "Buscar"
        Me.BtnBuscarProducto.UseVisualStyleBackColor = True
        '
        'FormBuscarProductoAdv
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.ClientSize = New System.Drawing.Size(476, 539)
        Me.Controls.Add(Me.BtnBuscarProducto)
        Me.Controls.Add(Me.DataGridViewProductos)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "FormBuscarProductoAdv"
        Me.Text = "FormBuscarProductoAdv"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.FiltroPrecioMax, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FiltroPrecioMin, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridViewProductos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label6 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents FiltroPrecioMax As NumericUpDown
    Friend WithEvents FiltroPrecioMin As NumericUpDown
    Friend WithEvents TxtCategoria As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents DataGridViewProductos As DataGridView
    Friend WithEvents BtnBuscarProducto As Button
End Class
