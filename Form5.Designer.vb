<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form5
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form5))
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.DateTB = New System.Windows.Forms.TextBox()
        Me.TimeTB = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.LocationCB = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.BrowserCB = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Button1.Image = Global.WindowsApplication3.My.Resources.Resources._226335
        Me.Button1.Location = New System.Drawing.Point(246, 103)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Crypt It!"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label1.Image = Global.WindowsApplication3.My.Resources.Resources._226335
        Me.Label1.Location = New System.Drawing.Point(20, 72)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Location :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label2.Image = Global.WindowsApplication3.My.Resources.Resources._226335
        Me.Label2.Location = New System.Drawing.Point(20, 149)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(36, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Date :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label3.Image = Global.WindowsApplication3.My.Resources.Resources._226335
        Me.Label3.Location = New System.Drawing.Point(20, 183)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(36, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Time :"
        '
        'DateTB
        '
        Me.DateTB.Location = New System.Drawing.Point(106, 146)
        Me.DateTB.Name = "DateTB"
        Me.DateTB.Size = New System.Drawing.Size(121, 20)
        Me.DateTB.TabIndex = 5
        '
        'TimeTB
        '
        Me.TimeTB.Location = New System.Drawing.Point(106, 183)
        Me.TimeTB.Name = "TimeTB"
        Me.TimeTB.Size = New System.Drawing.Size(121, 20)
        Me.TimeTB.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Showcard Gothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label4.Image = Global.WindowsApplication3.My.Resources.Resources._226335
        Me.Label4.Location = New System.Drawing.Point(114, 9)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(101, 27)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Crypto"
        '
        'LocationCB
        '
        Me.LocationCB.FormattingEnabled = True
        Me.LocationCB.Items.AddRange(New Object() {"Japan", "United Kingdom", "Australia", "Hong Kong", "Switzerland", "Brazil", "Denmark", "Italy", "India", "Egypt", "Finland", "France", "Germany", "New Zealand", "Poland", "Canada", "Russia", "Singapore"})
        Me.LocationCB.Location = New System.Drawing.Point(106, 64)
        Me.LocationCB.Name = "LocationCB"
        Me.LocationCB.Size = New System.Drawing.Size(121, 21)
        Me.LocationCB.TabIndex = 8
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label5.Image = Global.WindowsApplication3.My.Resources.Resources._226335
        Me.Label5.Location = New System.Drawing.Point(20, 108)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(51, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Browser :"
        '
        'BrowserCB
        '
        Me.BrowserCB.FormattingEnabled = True
        Me.BrowserCB.Items.AddRange(New Object() {"Google Chrome", "Mozilla Firefox", "Internet Explorer"})
        Me.BrowserCB.Location = New System.Drawing.Point(106, 105)
        Me.BrowserCB.Name = "BrowserCB"
        Me.BrowserCB.Size = New System.Drawing.Size(121, 21)
        Me.BrowserCB.TabIndex = 10
        '
        'Form5
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.WindowsApplication3.My.Resources.Resources._226335
        Me.ClientSize = New System.Drawing.Size(333, 224)
        Me.Controls.Add(Me.BrowserCB)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.LocationCB)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TimeTB)
        Me.Controls.Add(Me.DateTB)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Form5"
        Me.Text = "Crypto"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents DateTB As TextBox
    Friend WithEvents TimeTB As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents LocationCB As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents BrowserCB As ComboBox
End Class
