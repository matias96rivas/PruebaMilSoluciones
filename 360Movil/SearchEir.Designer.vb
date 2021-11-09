<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SearchEir
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SearchEir))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lblEir = New System.Windows.Forms.Label()
        Me.txtSearchEir = New System.Windows.Forms.TextBox()
        Me.btnSearch = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(59, 48)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(100, 93)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'lblEir
        '
        Me.lblEir.AutoSize = True
        Me.lblEir.Location = New System.Drawing.Point(59, 176)
        Me.lblEir.Name = "lblEir"
        Me.lblEir.Size = New System.Drawing.Size(23, 15)
        Me.lblEir.TabIndex = 1
        Me.lblEir.Text = "EIR"
        '
        'txtSearchEir
        '
        Me.txtSearchEir.Location = New System.Drawing.Point(59, 194)
        Me.txtSearchEir.Name = "txtSearchEir"
        Me.txtSearchEir.Size = New System.Drawing.Size(100, 23)
        Me.txtSearchEir.TabIndex = 2
        '
        'btnSearch
        '
        Me.btnSearch.Location = New System.Drawing.Point(71, 235)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(75, 23)
        Me.btnSearch.TabIndex = 3
        Me.btnSearch.Text = "Buscar"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'SearchEir
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(221, 335)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.txtSearchEir)
        Me.Controls.Add(Me.lblEir)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "SearchEir"
        Me.Text = "Buscar Eir"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lblEir As Label
    Friend WithEvents txtSearchEir As TextBox
    Friend WithEvents btnSearch As Button
End Class
