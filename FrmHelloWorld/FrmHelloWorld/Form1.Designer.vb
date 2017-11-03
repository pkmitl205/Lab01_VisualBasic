<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnHelloWorld = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnHelloWorld
        '
        Me.btnHelloWorld.BackColor = System.Drawing.Color.Yellow
        Me.btnHelloWorld.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnHelloWorld.ForeColor = System.Drawing.Color.Red
        Me.btnHelloWorld.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnHelloWorld.Location = New System.Drawing.Point(119, 53)
        Me.btnHelloWorld.Name = "btnHelloWorld"
        Me.btnHelloWorld.Size = New System.Drawing.Size(137, 51)
        Me.btnHelloWorld.TabIndex = 0
        Me.btnHelloWorld.Text = "ลาเบล"
        Me.btnHelloWorld.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(384, 161)
        Me.Controls.Add(Me.btnHelloWorld)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "HelloWorld"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnHelloWorld As Button
End Class
