<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormRepDatosVenta
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
        Me.RepDatosVenta = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.SuspendLayout()
        '
        'RepDatosVenta
        '
        Me.RepDatosVenta.BackColor = System.Drawing.Color.SeaShell
        Me.RepDatosVenta.LocalReport.ReportEmbeddedResource = "Trabajo.ReportDatosVenta.rdlc"
        Me.RepDatosVenta.Location = New System.Drawing.Point(1, 0)
        Me.RepDatosVenta.Name = "RepDatosVenta"
        Me.RepDatosVenta.ServerReport.BearerToken = Nothing
        Me.RepDatosVenta.Size = New System.Drawing.Size(845, 649)
        Me.RepDatosVenta.TabIndex = 0
        '
        'FormRepDatosVenta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(847, 647)
        Me.Controls.Add(Me.RepDatosVenta)
        Me.Name = "FormRepDatosVenta"
        Me.Text = "FormRepDatosVenta"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents RepDatosVenta As Microsoft.Reporting.WinForms.ReportViewer
End Class
