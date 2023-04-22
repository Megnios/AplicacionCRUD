<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormMainWindow
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnProductosAlta = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.BtnProductosBus = New System.Windows.Forms.Button()
        Me.BtnProductosMod = New System.Windows.Forms.Button()
        Me.BtnProductosBaja = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.BtnVentasBus = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BtnVentasAlta = New System.Windows.Forms.Button()
        Me.BtnVentasMod = New System.Windows.Forms.Button()
        Me.BtnVentasBaja = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.BtnClientesBus = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.BtnClientesAlta = New System.Windows.Forms.Button()
        Me.BtnClientesMod = New System.Windows.Forms.Button()
        Me.BtnClientesBaja = New System.Windows.Forms.Button()
        Me.BtnConsultarVTotal = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.BtnRepListProd = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Arial", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Snow
        Me.Label1.Location = New System.Drawing.Point(28, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(188, 41)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Productos"
        '
        'BtnProductosAlta
        '
        Me.BtnProductosAlta.BackColor = System.Drawing.Color.Ivory
        Me.BtnProductosAlta.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnProductosAlta.Location = New System.Drawing.Point(71, 80)
        Me.BtnProductosAlta.Name = "BtnProductosAlta"
        Me.BtnProductosAlta.Size = New System.Drawing.Size(100, 28)
        Me.BtnProductosAlta.TabIndex = 3
        Me.BtnProductosAlta.Text = "Alta"
        Me.BtnProductosAlta.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.Panel1.Controls.Add(Me.BtnProductosBus)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.BtnProductosAlta)
        Me.Panel1.Controls.Add(Me.BtnProductosMod)
        Me.Panel1.Controls.Add(Me.BtnProductosBaja)
        Me.Panel1.Location = New System.Drawing.Point(12, 36)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(245, 287)
        Me.Panel1.TabIndex = 4
        '
        'BtnProductosBus
        '
        Me.BtnProductosBus.BackColor = System.Drawing.Color.Ivory
        Me.BtnProductosBus.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnProductosBus.Location = New System.Drawing.Point(71, 235)
        Me.BtnProductosBus.Name = "BtnProductosBus"
        Me.BtnProductosBus.Size = New System.Drawing.Size(100, 28)
        Me.BtnProductosBus.TabIndex = 6
        Me.BtnProductosBus.Text = "Búsqueda"
        Me.BtnProductosBus.UseVisualStyleBackColor = False
        '
        'BtnProductosMod
        '
        Me.BtnProductosMod.BackColor = System.Drawing.Color.Ivory
        Me.BtnProductosMod.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnProductosMod.Location = New System.Drawing.Point(71, 183)
        Me.BtnProductosMod.Name = "BtnProductosMod"
        Me.BtnProductosMod.Size = New System.Drawing.Size(100, 28)
        Me.BtnProductosMod.TabIndex = 5
        Me.BtnProductosMod.Text = "Modificar"
        Me.BtnProductosMod.UseVisualStyleBackColor = False
        '
        'BtnProductosBaja
        '
        Me.BtnProductosBaja.BackColor = System.Drawing.Color.Ivory
        Me.BtnProductosBaja.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnProductosBaja.Location = New System.Drawing.Point(71, 131)
        Me.BtnProductosBaja.Name = "BtnProductosBaja"
        Me.BtnProductosBaja.Size = New System.Drawing.Size(100, 28)
        Me.BtnProductosBaja.TabIndex = 4
        Me.BtnProductosBaja.Text = "Baja"
        Me.BtnProductosBaja.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.Panel2.Controls.Add(Me.BtnVentasBus)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.BtnVentasAlta)
        Me.Panel2.Controls.Add(Me.BtnVentasMod)
        Me.Panel2.Controls.Add(Me.BtnVentasBaja)
        Me.Panel2.Location = New System.Drawing.Point(276, 36)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(245, 287)
        Me.Panel2.TabIndex = 5
        '
        'BtnVentasBus
        '
        Me.BtnVentasBus.BackColor = System.Drawing.Color.Ivory
        Me.BtnVentasBus.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnVentasBus.Location = New System.Drawing.Point(71, 235)
        Me.BtnVentasBus.Name = "BtnVentasBus"
        Me.BtnVentasBus.Size = New System.Drawing.Size(100, 28)
        Me.BtnVentasBus.TabIndex = 6
        Me.BtnVentasBus.Text = "Búsqueda"
        Me.BtnVentasBus.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.Label2.Font = New System.Drawing.Font("Arial", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Snow
        Me.Label2.Location = New System.Drawing.Point(28, 13)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label2.Size = New System.Drawing.Size(188, 41)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Ventas"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BtnVentasAlta
        '
        Me.BtnVentasAlta.BackColor = System.Drawing.Color.Ivory
        Me.BtnVentasAlta.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnVentasAlta.Location = New System.Drawing.Point(71, 80)
        Me.BtnVentasAlta.Name = "BtnVentasAlta"
        Me.BtnVentasAlta.Size = New System.Drawing.Size(100, 28)
        Me.BtnVentasAlta.TabIndex = 3
        Me.BtnVentasAlta.Text = "Alta"
        Me.BtnVentasAlta.UseVisualStyleBackColor = False
        '
        'BtnVentasMod
        '
        Me.BtnVentasMod.BackColor = System.Drawing.Color.Ivory
        Me.BtnVentasMod.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnVentasMod.Location = New System.Drawing.Point(71, 183)
        Me.BtnVentasMod.Name = "BtnVentasMod"
        Me.BtnVentasMod.Size = New System.Drawing.Size(100, 28)
        Me.BtnVentasMod.TabIndex = 5
        Me.BtnVentasMod.Text = "Modificar"
        Me.BtnVentasMod.UseVisualStyleBackColor = False
        '
        'BtnVentasBaja
        '
        Me.BtnVentasBaja.BackColor = System.Drawing.Color.Ivory
        Me.BtnVentasBaja.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnVentasBaja.Location = New System.Drawing.Point(71, 131)
        Me.BtnVentasBaja.Name = "BtnVentasBaja"
        Me.BtnVentasBaja.Size = New System.Drawing.Size(100, 28)
        Me.BtnVentasBaja.TabIndex = 4
        Me.BtnVentasBaja.Text = "Baja"
        Me.BtnVentasBaja.UseVisualStyleBackColor = False
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.Panel3.Controls.Add(Me.BtnClientesBus)
        Me.Panel3.Controls.Add(Me.Label3)
        Me.Panel3.Controls.Add(Me.BtnClientesAlta)
        Me.Panel3.Controls.Add(Me.BtnClientesMod)
        Me.Panel3.Controls.Add(Me.BtnClientesBaja)
        Me.Panel3.Location = New System.Drawing.Point(543, 36)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(245, 287)
        Me.Panel3.TabIndex = 7
        '
        'BtnClientesBus
        '
        Me.BtnClientesBus.BackColor = System.Drawing.Color.Ivory
        Me.BtnClientesBus.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnClientesBus.Location = New System.Drawing.Point(71, 235)
        Me.BtnClientesBus.Name = "BtnClientesBus"
        Me.BtnClientesBus.Size = New System.Drawing.Size(100, 28)
        Me.BtnClientesBus.TabIndex = 6
        Me.BtnClientesBus.Text = "Búsqueda"
        Me.BtnClientesBus.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.Label3.Font = New System.Drawing.Font("Arial", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Snow
        Me.Label3.Location = New System.Drawing.Point(28, 13)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(188, 41)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Clientes"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BtnClientesAlta
        '
        Me.BtnClientesAlta.BackColor = System.Drawing.Color.Ivory
        Me.BtnClientesAlta.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnClientesAlta.Location = New System.Drawing.Point(71, 80)
        Me.BtnClientesAlta.Name = "BtnClientesAlta"
        Me.BtnClientesAlta.Size = New System.Drawing.Size(100, 28)
        Me.BtnClientesAlta.TabIndex = 3
        Me.BtnClientesAlta.Text = "Alta"
        Me.BtnClientesAlta.UseVisualStyleBackColor = False
        '
        'BtnClientesMod
        '
        Me.BtnClientesMod.BackColor = System.Drawing.Color.Ivory
        Me.BtnClientesMod.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnClientesMod.Location = New System.Drawing.Point(71, 183)
        Me.BtnClientesMod.Name = "BtnClientesMod"
        Me.BtnClientesMod.Size = New System.Drawing.Size(100, 28)
        Me.BtnClientesMod.TabIndex = 5
        Me.BtnClientesMod.Text = "Modificar"
        Me.BtnClientesMod.UseVisualStyleBackColor = False
        '
        'BtnClientesBaja
        '
        Me.BtnClientesBaja.BackColor = System.Drawing.Color.Ivory
        Me.BtnClientesBaja.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnClientesBaja.Location = New System.Drawing.Point(71, 131)
        Me.BtnClientesBaja.Name = "BtnClientesBaja"
        Me.BtnClientesBaja.Size = New System.Drawing.Size(100, 28)
        Me.BtnClientesBaja.TabIndex = 4
        Me.BtnClientesBaja.Text = "Baja"
        Me.BtnClientesBaja.UseVisualStyleBackColor = False
        '
        'BtnConsultarVTotal
        '
        Me.BtnConsultarVTotal.BackColor = System.Drawing.Color.Ivory
        Me.BtnConsultarVTotal.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnConsultarVTotal.Location = New System.Drawing.Point(614, 390)
        Me.BtnConsultarVTotal.Name = "BtnConsultarVTotal"
        Me.BtnConsultarVTotal.Size = New System.Drawing.Size(100, 28)
        Me.BtnConsultarVTotal.TabIndex = 7
        Me.BtnConsultarVTotal.Text = "Click Aquí"
        Me.BtnConsultarVTotal.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Ivory
        Me.Button1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(347, 390)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(100, 28)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "Click Aquí"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'BtnRepListProd
        '
        Me.BtnRepListProd.BackColor = System.Drawing.Color.Ivory
        Me.BtnRepListProd.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnRepListProd.Location = New System.Drawing.Point(69, 390)
        Me.BtnRepListProd.Name = "BtnRepListProd"
        Me.BtnRepListProd.Size = New System.Drawing.Size(100, 28)
        Me.BtnRepListProd.TabIndex = 8
        Me.BtnRepListProd.Text = "Click Aquí"
        Me.BtnRepListProd.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Sitka Heading", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(12, 340)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(232, 28)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "LISTADO DE PRODUCTOS"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Sitka Heading", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(325, 340)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(166, 28)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "DATOS DE VENTA"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Sitka Heading", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(587, 340)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(159, 28)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "TOTAL VENDIDO"
        '
        'FormMainWindow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.PeachPuff
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.BtnRepListProd)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.BtnConsultarVTotal)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "FormMainWindow"
        Me.Text = "Form1"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents BtnProductosAlta As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents BtnProductosBus As Button
    Friend WithEvents BtnProductosMod As Button
    Friend WithEvents BtnProductosBaja As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents BtnVentasBus As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents BtnVentasAlta As Button
    Friend WithEvents BtnVentasMod As Button
    Friend WithEvents BtnVentasBaja As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents BtnClientesBus As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents BtnClientesAlta As Button
    Friend WithEvents BtnClientesMod As Button
    Friend WithEvents BtnClientesBaja As Button
    Friend WithEvents BtnConsultarVTotal As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents BtnRepListProd As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
End Class
