<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EirInfo
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(EirInfo))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lblEir = New System.Windows.Forms.Label()
        Me.lblContenedor = New System.Windows.Forms.Label()
        Me.lblSello = New System.Windows.Forms.Label()
        Me.lblResponsable = New System.Windows.Forms.Label()
        Me.lblEmpresa = New System.Windows.Forms.Label()
        Me.txtEir = New System.Windows.Forms.TextBox()
        Me.txtContenedor = New System.Windows.Forms.TextBox()
        Me.txtSello = New System.Windows.Forms.TextBox()
        Me.txtResponsable = New System.Windows.Forms.TextBox()
        Me.txtEmpresa = New System.Windows.Forms.TextBox()
        Me.btnBack = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(73, 40)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(100, 92)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'lblEir
        '
        Me.lblEir.AutoSize = True
        Me.lblEir.Location = New System.Drawing.Point(73, 153)
        Me.lblEir.Name = "lblEir"
        Me.lblEir.Size = New System.Drawing.Size(23, 15)
        Me.lblEir.TabIndex = 1
        Me.lblEir.Text = "EIR"
        '
        'lblContenedor
        '
        Me.lblContenedor.AutoSize = True
        Me.lblContenedor.Location = New System.Drawing.Point(73, 205)
        Me.lblContenedor.Name = "lblContenedor"
        Me.lblContenedor.Size = New System.Drawing.Size(70, 15)
        Me.lblContenedor.TabIndex = 2
        Me.lblContenedor.Text = "Contenedor"
        '
        'lblSello
        '
        Me.lblSello.AutoSize = True
        Me.lblSello.Location = New System.Drawing.Point(73, 258)
        Me.lblSello.Name = "lblSello"
        Me.lblSello.Size = New System.Drawing.Size(32, 15)
        Me.lblSello.TabIndex = 3
        Me.lblSello.Text = "Sello"
        '
        'lblResponsable
        '
        Me.lblResponsable.AutoSize = True
        Me.lblResponsable.Location = New System.Drawing.Point(73, 313)
        Me.lblResponsable.Name = "lblResponsable"
        Me.lblResponsable.Size = New System.Drawing.Size(73, 15)
        Me.lblResponsable.TabIndex = 4
        Me.lblResponsable.Text = "Responsable"
        '
        'lblEmpresa
        '
        Me.lblEmpresa.AutoSize = True
        Me.lblEmpresa.Location = New System.Drawing.Point(73, 368)
        Me.lblEmpresa.Name = "lblEmpresa"
        Me.lblEmpresa.Size = New System.Drawing.Size(52, 15)
        Me.lblEmpresa.TabIndex = 5
        Me.lblEmpresa.Text = "Empresa"
        '
        'txtEir
        '
        Me.txtEir.Location = New System.Drawing.Point(73, 172)
        Me.txtEir.Name = "txtEir"
        Me.txtEir.Size = New System.Drawing.Size(100, 23)
        Me.txtEir.TabIndex = 6
        '
        'txtContenedor
        '
        Me.txtContenedor.Location = New System.Drawing.Point(73, 224)
        Me.txtContenedor.Name = "txtContenedor"
        Me.txtContenedor.Size = New System.Drawing.Size(100, 23)
        Me.txtContenedor.TabIndex = 7
        '
        'txtSello
        '
        Me.txtSello.Location = New System.Drawing.Point(73, 277)
        Me.txtSello.Name = "txtSello"
        Me.txtSello.Size = New System.Drawing.Size(100, 23)
        Me.txtSello.TabIndex = 8
        '
        'txtResponsable
        '
        Me.txtResponsable.Location = New System.Drawing.Point(73, 332)
        Me.txtResponsable.Name = "txtResponsable"
        Me.txtResponsable.Size = New System.Drawing.Size(100, 23)
        Me.txtResponsable.TabIndex = 9
        '
        'txtEmpresa
        '
        Me.txtEmpresa.Location = New System.Drawing.Point(73, 385)
        Me.txtEmpresa.Name = "txtEmpresa"
        Me.txtEmpresa.Size = New System.Drawing.Size(100, 23)
        Me.txtEmpresa.TabIndex = 10
        '
        'btnBack
        '
        Me.btnBack.Location = New System.Drawing.Point(164, 446)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(75, 23)
        Me.btnBack.TabIndex = 11
        Me.btnBack.Text = "Volver"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'EirInfo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(251, 481)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.txtEmpresa)
        Me.Controls.Add(Me.txtResponsable)
        Me.Controls.Add(Me.txtSello)
        Me.Controls.Add(Me.txtContenedor)
        Me.Controls.Add(Me.txtEir)
        Me.Controls.Add(Me.lblEmpresa)
        Me.Controls.Add(Me.lblResponsable)
        Me.Controls.Add(Me.lblSello)
        Me.Controls.Add(Me.lblContenedor)
        Me.Controls.Add(Me.lblEir)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "EirInfo"
        Me.Text = "Datos"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lblEir As Label
    Friend WithEvents lblContenedor As Label
    Friend WithEvents lblSello As Label
    Friend WithEvents lblResponsable As Label
    Friend WithEvents lblEmpresa As Label
    Friend WithEvents txtEir As TextBox
    Friend WithEvents txtContenedor As TextBox
    Friend WithEvents txtSello As TextBox
    Friend WithEvents txtResponsable As TextBox
    Friend WithEvents txtEmpresa As TextBox
    Friend WithEvents btnBack As Button
End Class
