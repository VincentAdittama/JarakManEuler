<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Title = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ANS = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Y2 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.X2 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Y1 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.x1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Eul = New System.Windows.Forms.RadioButton()
        Me.Man = New System.Windows.Forms.RadioButton()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Title
        '
        Me.Title.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Title.AutoSize = True
        Me.Title.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Title.Location = New System.Drawing.Point(202, 19)
        Me.Title.Name = "Title"
        Me.Title.Size = New System.Drawing.Size(235, 32)
        Me.Title.TabIndex = 0
        Me.Title.Text = "Distance Calculator"
        Me.Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.GroupBox1.Controls.Add(Me.ANS)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.GroupBox3)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.Eul)
        Me.GroupBox1.Controls.Add(Me.Man)
        Me.GroupBox1.Controls.Add(Me.Title)
        Me.GroupBox1.Location = New System.Drawing.Point(81, 25)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(629, 397)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        '
        'ANS
        '
        Me.ANS.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.ANS.Location = New System.Drawing.Point(202, 305)
        Me.ANS.Name = "ANS"
        Me.ANS.Size = New System.Drawing.Size(235, 29)
        Me.ANS.TabIndex = 9
        Me.ANS.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label5.Location = New System.Drawing.Point(294, 287)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(41, 15)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "HASIL"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Y2)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.X2)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Location = New System.Drawing.Point(224, 204)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(181, 80)
        Me.GroupBox3.TabIndex = 8
        Me.GroupBox3.TabStop = False
        '
        'Y2
        '
        Me.Y2.AcceptsTab = True
        Me.Y2.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Y2.Location = New System.Drawing.Point(32, 38)
        Me.Y2.Name = "Y2"
        Me.Y2.Size = New System.Drawing.Size(149, 23)
        Me.Y2.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 41)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(20, 15)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Y2"
        '
        'X2
        '
        Me.X2.AcceptsTab = True
        Me.X2.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.X2.Location = New System.Drawing.Point(32, 9)
        Me.X2.Name = "X2"
        Me.X2.Size = New System.Drawing.Size(149, 23)
        Me.X2.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 12)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(20, 15)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "X2"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Y1)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.x1)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Location = New System.Drawing.Point(224, 118)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(181, 80)
        Me.GroupBox2.TabIndex = 6
        Me.GroupBox2.TabStop = False
        '
        'Y1
        '
        Me.Y1.AcceptsTab = True
        Me.Y1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Y1.Location = New System.Drawing.Point(32, 38)
        Me.Y1.Name = "Y1"
        Me.Y1.Size = New System.Drawing.Size(149, 23)
        Me.Y1.TabIndex = 6
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 41)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(20, 15)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Y1"
        '
        'x1
        '
        Me.x1.AcceptsTab = True
        Me.x1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.x1.Location = New System.Drawing.Point(32, 9)
        Me.x1.Name = "x1"
        Me.x1.Size = New System.Drawing.Size(149, 23)
        Me.x1.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(20, 15)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "X1"
        '
        'Eul
        '
        Me.Eul.AutoSize = True
        Me.Eul.Location = New System.Drawing.Point(256, 93)
        Me.Eul.Name = "Eul"
        Me.Eul.Size = New System.Drawing.Size(76, 19)
        Me.Eul.TabIndex = 3
        Me.Eul.TabStop = True
        Me.Eul.Text = "Euclidean"
        Me.Eul.UseVisualStyleBackColor = True
        '
        'Man
        '
        Me.Man.AutoSize = True
        Me.Man.Location = New System.Drawing.Point(256, 68)
        Me.Man.Name = "Man"
        Me.Man.Size = New System.Drawing.Size(83, 19)
        Me.Man.TabIndex = 1
        Me.Man.TabStop = True
        Me.Man.Text = "Manhattan"
        Me.Man.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Title As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Man As RadioButton
    Friend WithEvents Eul As RadioButton
    Friend WithEvents Label1 As Label
    Friend WithEvents x1 As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Y1 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Y2 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents X2 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents ANS As TextBox
    Friend WithEvents Label5 As Label
End Class
