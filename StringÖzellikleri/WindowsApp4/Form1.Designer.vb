<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form, bileşen listesini temizlemeyi bırakmayı geçersiz kılar.
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

    'Windows Form Tasarımcısı tarafından gerektirilir
    Private components As System.ComponentModel.IContainer

    'NOT: Aşağıdaki yordam Windows Form Tasarımcısı için gereklidir
    'Windows Form Tasarımcısı kullanılarak değiştirilebilir.  
    'Kod düzenleyicisini kullanarak değiştirmeyin.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.metin1TextBox = New System.Windows.Forms.TextBox()
        Me.diziyazButton1 = New System.Windows.Forms.Button()
        Me.metin2TextBox2 = New System.Windows.Forms.TextBox()
        Me.metinaraButton1 = New System.Windows.Forms.Button()
        Me.sondanaraButton1 = New System.Windows.Forms.Button()
        Me.metinekleButton1 = New System.Windows.Forms.Button()
        Me.metinuzunluguButton1 = New System.Windows.Forms.Button()
        Me.metnitamamlaButton1 = New System.Windows.Forms.Button()
        Me.parcasilButton1 = New System.Windows.Forms.Button()
        Me.metindegistirButton1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(32, 80)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(50, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "metin1"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(32, 112)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(50, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "metin2"
        '
        'metin1TextBox
        '
        Me.metin1TextBox.Location = New System.Drawing.Point(89, 77)
        Me.metin1TextBox.Name = "metin1TextBox"
        Me.metin1TextBox.Size = New System.Drawing.Size(209, 22)
        Me.metin1TextBox.TabIndex = 2
        '
        'diziyazButton1
        '
        Me.diziyazButton1.Location = New System.Drawing.Point(79, 137)
        Me.diziyazButton1.Name = "diziyazButton1"
        Me.diziyazButton1.Size = New System.Drawing.Size(138, 34)
        Me.diziyazButton1.TabIndex = 3
        Me.diziyazButton1.Text = "Dizi Değişkeni Yaz"
        Me.diziyazButton1.UseVisualStyleBackColor = True
        '
        'metin2TextBox2
        '
        Me.metin2TextBox2.Location = New System.Drawing.Point(89, 109)
        Me.metin2TextBox2.Name = "metin2TextBox2"
        Me.metin2TextBox2.Size = New System.Drawing.Size(209, 22)
        Me.metin2TextBox2.TabIndex = 4
        '
        'metinaraButton1
        '
        Me.metinaraButton1.Location = New System.Drawing.Point(79, 177)
        Me.metinaraButton1.Name = "metinaraButton1"
        Me.metinaraButton1.Size = New System.Drawing.Size(138, 23)
        Me.metinaraButton1.TabIndex = 5
        Me.metinaraButton1.Text = "Metin içinde arama "
        Me.metinaraButton1.UseVisualStyleBackColor = True
        '
        'sondanaraButton1
        '
        Me.sondanaraButton1.Location = New System.Drawing.Point(79, 206)
        Me.sondanaraButton1.Name = "sondanaraButton1"
        Me.sondanaraButton1.Size = New System.Drawing.Size(138, 23)
        Me.sondanaraButton1.TabIndex = 6
        Me.sondanaraButton1.Text = "Metin içinde sondan arama"
        Me.sondanaraButton1.UseVisualStyleBackColor = True
        '
        'metinekleButton1
        '
        Me.metinekleButton1.Location = New System.Drawing.Point(79, 235)
        Me.metinekleButton1.Name = "metinekleButton1"
        Me.metinekleButton1.Size = New System.Drawing.Size(138, 23)
        Me.metinekleButton1.TabIndex = 7
        Me.metinekleButton1.Text = "metin ekle"
        Me.metinekleButton1.UseVisualStyleBackColor = True
        '
        'metinuzunluguButton1
        '
        Me.metinuzunluguButton1.Location = New System.Drawing.Point(79, 264)
        Me.metinuzunluguButton1.Name = "metinuzunluguButton1"
        Me.metinuzunluguButton1.Size = New System.Drawing.Size(138, 23)
        Me.metinuzunluguButton1.TabIndex = 8
        Me.metinuzunluguButton1.Text = "metin uzunluğu"
        Me.metinuzunluguButton1.UseVisualStyleBackColor = True
        '
        'metnitamamlaButton1
        '
        Me.metnitamamlaButton1.Location = New System.Drawing.Point(79, 293)
        Me.metnitamamlaButton1.Name = "metnitamamlaButton1"
        Me.metnitamamlaButton1.Size = New System.Drawing.Size(138, 23)
        Me.metnitamamlaButton1.TabIndex = 9
        Me.metnitamamlaButton1.Text = "metni tamamla"
        Me.metnitamamlaButton1.UseVisualStyleBackColor = True
        '
        'parcasilButton1
        '
        Me.parcasilButton1.Location = New System.Drawing.Point(79, 322)
        Me.parcasilButton1.Name = "parcasilButton1"
        Me.parcasilButton1.Size = New System.Drawing.Size(138, 31)
        Me.parcasilButton1.TabIndex = 10
        Me.parcasilButton1.Text = "metinden parça sil"
        Me.parcasilButton1.UseVisualStyleBackColor = True
        '
        'metindegistirButton1
        '
        Me.metindegistirButton1.Location = New System.Drawing.Point(79, 359)
        Me.metindegistirButton1.Name = "metindegistirButton1"
        Me.metindegistirButton1.Size = New System.Drawing.Size(138, 31)
        Me.metindegistirButton1.TabIndex = 11
        Me.metindegistirButton1.Text = "metinden değiştir"
        Me.metindegistirButton1.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(553, 547)
        Me.Controls.Add(Me.metindegistirButton1)
        Me.Controls.Add(Me.parcasilButton1)
        Me.Controls.Add(Me.metnitamamlaButton1)
        Me.Controls.Add(Me.metinuzunluguButton1)
        Me.Controls.Add(Me.metinekleButton1)
        Me.Controls.Add(Me.sondanaraButton1)
        Me.Controls.Add(Me.metinaraButton1)
        Me.Controls.Add(Me.metin2TextBox2)
        Me.Controls.Add(Me.diziyazButton1)
        Me.Controls.Add(Me.metin1TextBox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents metin1TextBox As TextBox
    Friend WithEvents diziyazButton1 As Button
    Friend WithEvents metin2TextBox2 As TextBox
    Friend WithEvents metinaraButton1 As Button
    Friend WithEvents sondanaraButton1 As Button
    Friend WithEvents metinekleButton1 As Button
    Friend WithEvents metinuzunluguButton1 As Button
    Friend WithEvents metnitamamlaButton1 As Button
    Friend WithEvents parcasilButton1 As Button
    Friend WithEvents metindegistirButton1 As Button
End Class
