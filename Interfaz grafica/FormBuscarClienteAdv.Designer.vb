<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormBuscarClienteAdv
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
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.FiltroPrecioMax = New System.Windows.Forms.NumericUpDown()
        Me.FiltroPrecioMin = New System.Windows.Forms.NumericUpDown()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtIdProducto = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnBuscarCliente = New System.Windows.Forms.Button()
        Me.DataGridViewClientes = New System.Windows.Forms.DataGridView()
        Me.Panel1.SuspendLayout()
        CType(Me.FiltroPrecioMax, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FiltroPrecioMin, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridViewClientes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Gainsboro
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.FiltroPrecioMax)
        Me.Panel1.Controls.Add(Me.FiltroPrecioMin)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.TxtIdProducto)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(34, 34)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(627, 213)
        Me.Panel1.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(92, 161)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(137, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Precio maximo gastado"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(95, 110)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(134, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Precio minimo gastado"
        '
        'FiltroPrecioMax
        '
        Me.FiltroPrecioMax.Location = New System.Drawing.Point(235, 159)
        Me.FiltroPrecioMax.Maximum = New Decimal(New Integer() {100000, 0, 0, 0})
        Me.FiltroPrecioMax.Name = "FiltroPrecioMax"
        Me.FiltroPrecioMax.Size = New System.Drawing.Size(227, 20)
        Me.FiltroPrecioMax.TabIndex = 6
        '
        'FiltroPrecioMin
        '
        Me.FiltroPrecioMin.Location = New System.Drawing.Point(235, 108)
        Me.FiltroPrecioMin.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        Me.FiltroPrecioMin.Name = "FiltroPrecioMin"
        Me.FiltroPrecioMin.Size = New System.Drawing.Size(227, 20)
        Me.FiltroPrecioMin.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(17, 56)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(212, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "ID Producto comprado por el cliente"
        '
        'TxtIdProducto
        '
        Me.TxtIdProducto.Location = New System.Drawing.Point(235, 56)
        Me.TxtIdProducto.Name = "TxtIdProducto"
        Me.TxtIdProducto.Size = New System.Drawing.Size(227, 20)
        Me.TxtIdProducto.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(251, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(144, 20)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Datos del cliente"
        '
        'BtnBuscarCliente
        '
        Me.BtnBuscarCliente.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnBuscarCliente.Location = New System.Drawing.Point(586, 264)
        Me.BtnBuscarCliente.Name = "BtnBuscarCliente"
        Me.BtnBuscarCliente.Size = New System.Drawing.Size(75, 23)
        Me.BtnBuscarCliente.TabIndex = 6
        Me.BtnBuscarCliente.Text = "Buscar"
        Me.BtnBuscarCliente.UseVisualStyleBackColor = True
        '
        'DataGridViewClientes
        '
        Me.DataGridViewClientes.BackgroundColor = System.Drawing.SystemColors.Info
        Me.DataGridViewClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewClientes.Location = New System.Drawing.Point(34, 309)
        Me.DataGridViewClientes.Name = "DataGridViewClientes"
        Me.DataGridViewClientes.Size = New System.Drawing.Size(627, 206)
        Me.DataGridViewClientes.TabIndex = 7
        '
        'FormBuscarClienteAdv
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.ClientSize = New System.Drawing.Size(692, 538)
        Me.Controls.Add(Me.DataGridViewClientes)
        Me.Controls.Add(Me.BtnBuscarCliente)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "FormBuscarClienteAdv"
        Me.Text = "FormBuscarClienteAdv"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.FiltroPrecioMax, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FiltroPrecioMin, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridViewClientes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents FiltroPrecioMax As NumericUpDown
    Friend WithEvents FiltroPrecioMin As NumericUpDown
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtIdProducto As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents BtnBuscarCliente As Button
    Friend WithEvents DataGridViewClientes As DataGridView
End Class
