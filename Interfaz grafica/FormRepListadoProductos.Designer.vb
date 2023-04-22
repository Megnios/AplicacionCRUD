<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormRepListadoProductos
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
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.ProductosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DSListadoProductos = New Trabajo.DSListadoProductos()
        Me.RVListadoProductos = New Microsoft.Reporting.WinForms.ReportViewer()
        CType(Me.ProductosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DSListadoProductos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ProductosBindingSource
        '
        Me.ProductosBindingSource.DataMember = "Productos"
        Me.ProductosBindingSource.DataSource = Me.DSListadoProductos
        '
        'DSListadoProductos
        '
        Me.DSListadoProductos.DataSetName = "DSListadoProductos"
        Me.DSListadoProductos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'RVListadoProductos
        '
        Me.RVListadoProductos.BackColor = System.Drawing.Color.SeaShell
        ReportDataSource1.Name = "DSListadoProductos"
        ReportDataSource1.Value = Me.ProductosBindingSource
        Me.RVListadoProductos.LocalReport.DataSources.Add(ReportDataSource1)
        Me.RVListadoProductos.LocalReport.ReportEmbeddedResource = "Trabajo.ReporteListadoProductos.rdlc"
        Me.RVListadoProductos.Location = New System.Drawing.Point(12, 12)
        Me.RVListadoProductos.Name = "RVListadoProductos"
        Me.RVListadoProductos.ServerReport.BearerToken = Nothing
        Me.RVListadoProductos.Size = New System.Drawing.Size(776, 436)
        Me.RVListadoProductos.TabIndex = 0
        '
        'FormRepListadoProductos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.RVListadoProductos)
        Me.Name = "FormRepListadoProductos"
        Me.Text = "FormRepListadoProductos"
        CType(Me.ProductosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DSListadoProductos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents RVListadoProductos As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents ProductosBindingSource As BindingSource
    Friend WithEvents DSListadoProductos As DSListadoProductos
End Class
