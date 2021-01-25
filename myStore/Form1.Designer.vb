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
        Me.lblMyStore = New System.Windows.Forms.Label()
        Me.lbl11Pro = New System.Windows.Forms.Label()
        Me.lblGalaxy = New System.Windows.Forms.Label()
        Me.lblPixel = New System.Windows.Forms.Label()
        Me.txt11Pro = New System.Windows.Forms.TextBox()
        Me.txtGalaxy = New System.Windows.Forms.TextBox()
        Me.txtPixel = New System.Windows.Forms.TextBox()
        Me.lblSub = New System.Windows.Forms.Label()
        Me.btnOrder = New System.Windows.Forms.Button()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblMyStore
        '
        Me.lblMyStore.AutoSize = True
        Me.lblMyStore.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMyStore.Location = New System.Drawing.Point(0, 0)
        Me.lblMyStore.Name = "lblMyStore"
        Me.lblMyStore.Size = New System.Drawing.Size(122, 31)
        Me.lblMyStore.TabIndex = 0
        Me.lblMyStore.Text = "My Store"
        '
        'lbl11Pro
        '
        Me.lbl11Pro.AutoSize = True
        Me.lbl11Pro.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl11Pro.Location = New System.Drawing.Point(3, 81)
        Me.lbl11Pro.Name = "lbl11Pro"
        Me.lbl11Pro.Size = New System.Drawing.Size(297, 20)
        Me.lbl11Pro.TabIndex = 1
        Me.lbl11Pro.Text = "iPhone 11 Pro                                   $1,379"
        '
        'lblGalaxy
        '
        Me.lblGalaxy.AutoSize = True
        Me.lblGalaxy.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGalaxy.Location = New System.Drawing.Point(3, 126)
        Me.lblGalaxy.Name = "lblGalaxy"
        Me.lblGalaxy.Size = New System.Drawing.Size(295, 20)
        Me.lblGalaxy.TabIndex = 2
        Me.lblGalaxy.Text = "Samsung Galaxy Note 10+            $1,459"
        '
        'lblPixel
        '
        Me.lblPixel.AutoSize = True
        Me.lblPixel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPixel.Location = New System.Drawing.Point(3, 171)
        Me.lblPixel.Name = "lblPixel"
        Me.lblPixel.Size = New System.Drawing.Size(295, 20)
        Me.lblPixel.TabIndex = 3
        Me.lblPixel.Text = "Google Pixel 4 XL                            $1,129"
        '
        'txt11Pro
        '
        Me.txt11Pro.Location = New System.Drawing.Point(378, 81)
        Me.txt11Pro.Name = "txt11Pro"
        Me.txt11Pro.Size = New System.Drawing.Size(100, 20)
        Me.txt11Pro.TabIndex = 7
        '
        'txtGalaxy
        '
        Me.txtGalaxy.Location = New System.Drawing.Point(378, 126)
        Me.txtGalaxy.Name = "txtGalaxy"
        Me.txtGalaxy.Size = New System.Drawing.Size(100, 20)
        Me.txtGalaxy.TabIndex = 8
        '
        'txtPixel
        '
        Me.txtPixel.Location = New System.Drawing.Point(378, 171)
        Me.txtPixel.Name = "txtPixel"
        Me.txtPixel.Size = New System.Drawing.Size(100, 20)
        Me.txtPixel.TabIndex = 9
        '
        'lblSub
        '
        Me.lblSub.AutoSize = True
        Me.lblSub.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSub.Location = New System.Drawing.Point(657, 172)
        Me.lblSub.Name = "lblSub"
        Me.lblSub.Size = New System.Drawing.Size(95, 20)
        Me.lblSub.TabIndex = 11
        Me.lblSub.Text = "Subtotal: $0"
        '
        'btnOrder
        '
        Me.btnOrder.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOrder.Location = New System.Drawing.Point(657, 81)
        Me.btnOrder.Name = "btnOrder"
        Me.btnOrder.Size = New System.Drawing.Size(120, 54)
        Me.btnOrder.TabIndex = 12
        Me.btnOrder.Text = "Order"
        Me.btnOrder.UseVisualStyleBackColor = True
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal.Location = New System.Drawing.Point(657, 229)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(61, 20)
        Me.lblTotal.TabIndex = 13
        Me.lblTotal.Text = "Total: $"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1153, 437)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.btnOrder)
        Me.Controls.Add(Me.lblSub)
        Me.Controls.Add(Me.txtPixel)
        Me.Controls.Add(Me.txtGalaxy)
        Me.Controls.Add(Me.txt11Pro)
        Me.Controls.Add(Me.lblPixel)
        Me.Controls.Add(Me.lblGalaxy)
        Me.Controls.Add(Me.lbl11Pro)
        Me.Controls.Add(Me.lblMyStore)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblMyStore As System.Windows.Forms.Label
    Friend WithEvents lbl11Pro As System.Windows.Forms.Label
    Friend WithEvents lblGalaxy As System.Windows.Forms.Label
    Friend WithEvents lblPixel As System.Windows.Forms.Label
    Friend WithEvents txt11Pro As System.Windows.Forms.TextBox
    Friend WithEvents txtGalaxy As System.Windows.Forms.TextBox
    Friend WithEvents txtPixel As System.Windows.Forms.TextBox
    Friend WithEvents lblSub As System.Windows.Forms.Label
    Friend WithEvents btnOrder As System.Windows.Forms.Button
    Friend WithEvents lblTotal As System.Windows.Forms.Label

End Class
