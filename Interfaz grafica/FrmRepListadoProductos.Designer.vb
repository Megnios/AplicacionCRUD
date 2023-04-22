<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmRepListadoProductos
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
        Me.RepListadoProductos = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.DSListadoProductos = New Trabajo.DSListadoProductos()
        Me.ProductosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.DSListadoProductos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RepListadoProductos
        '
        ReportDataSource1.Name = "DSListadoProductos"
        ReportDataSource1.Value = Me.ProductosBindingSource
        Me.RepListadoProductos.LocalReport.DataSources.Add(ReportDataSource1)
        Me.RepListadoProductos.LocalReport.ReportEmbeddedResource = "Trabajo.RepListadoProductos.rdlc"
        Me.RepListadoProductos.Location = New System.Drawing.Point(12, 12)
        Me.RepListadoProductos.Name = "RepListadoProductos"
        Me.RepListadoProductos.ServerReport.BearerToken = Nothing
        Me.RepListadoProductos.Size = New System.Drawing.Size(776, 433)
        Me.RepListadoProductos.TabIndex = 0
        '
        'DSListadoProductos
        '
        Me.DSListadoProductos.DataSetName = "DSListadoProductos"
        Me.DSListadoProductos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ProductosBindingSource
        '
        Me.ProductosBindingSource.DataMember = "Productos"
        Me.ProductosBindingSource.DataSource = Me.DSListadoProductos
        '
        'FrmRepListadoProductos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.RepListadoProductos)
        Me.Name = "FrmRepListadoProductos"
        Me.Text = "FrmRepListadoProductos"
        CType(Me.DSListadoProductos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents RepListadoProductos As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents ProductosBindingSource As BindingSource
    Friend WithEvents DSListadoProductos As DSListadoProductos
End Class
