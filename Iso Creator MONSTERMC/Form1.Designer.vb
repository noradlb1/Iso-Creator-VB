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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.textBoxVolumeName = New System.Windows.Forms.TextBox()
        Me.txtPath = New System.Windows.Forms.TextBox()
        Me.labelStatus = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.progressBar = New System.Windows.Forms.ProgressBar()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.LinkDiscord = New System.Windows.Forms.LinkLabel()
        Me.LinkTelegram = New System.Windows.Forms.LinkLabel()
        Me.LinkYoutube = New System.Windows.Forms.LinkLabel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'textBoxVolumeName
        '
        Me.textBoxVolumeName.Location = New System.Drawing.Point(11, 72)
        Me.textBoxVolumeName.Name = "textBoxVolumeName"
        Me.textBoxVolumeName.Size = New System.Drawing.Size(188, 20)
        Me.textBoxVolumeName.TabIndex = 20
        Me.textBoxVolumeName.Text = "Volume Name"
        '
        'txtPath
        '
        Me.txtPath.Location = New System.Drawing.Point(12, 43)
        Me.txtPath.Name = "txtPath"
        Me.txtPath.Size = New System.Drawing.Size(188, 20)
        Me.txtPath.TabIndex = 19
        Me.txtPath.Text = "txtPath"
        '
        'labelStatus
        '
        Me.labelStatus.AutoSize = True
        Me.labelStatus.Location = New System.Drawing.Point(156, 23)
        Me.labelStatus.Name = "labelStatus"
        Me.labelStatus.Size = New System.Drawing.Size(43, 13)
        Me.labelStatus.TabIndex = 18
        Me.labelStatus.Text = "Status: "
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(206, 69)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(89, 23)
        Me.Button2.TabIndex = 17
        Me.Button2.Text = "Button2"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(206, 40)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(89, 23)
        Me.Button1.TabIndex = 16
        Me.Button1.Text = "Select Folder"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'progressBar
        '
        Me.progressBar.Location = New System.Drawing.Point(12, 98)
        Me.progressBar.Name = "progressBar"
        Me.progressBar.Size = New System.Drawing.Size(283, 23)
        Me.progressBar.TabIndex = 22
        '
        'lblStatus
        '
        Me.lblStatus.AutoSize = True
        Me.lblStatus.Location = New System.Drawing.Point(9, 23)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(43, 13)
        Me.lblStatus.TabIndex = 23
        Me.lblStatus.Text = "Status: "
        '
        'LinkDiscord
        '
        Me.LinkDiscord.AutoSize = True
        Me.LinkDiscord.Location = New System.Drawing.Point(8, 137)
        Me.LinkDiscord.Name = "LinkDiscord"
        Me.LinkDiscord.Size = New System.Drawing.Size(43, 13)
        Me.LinkDiscord.TabIndex = 24
        Me.LinkDiscord.TabStop = True
        Me.LinkDiscord.Text = "Discord"
        '
        'LinkTelegram
        '
        Me.LinkTelegram.AutoSize = True
        Me.LinkTelegram.Location = New System.Drawing.Point(121, 137)
        Me.LinkTelegram.Name = "LinkTelegram"
        Me.LinkTelegram.Size = New System.Drawing.Size(51, 13)
        Me.LinkTelegram.TabIndex = 25
        Me.LinkTelegram.TabStop = True
        Me.LinkTelegram.Text = "Telegram"
        '
        'LinkYoutube
        '
        Me.LinkYoutube.AutoSize = True
        Me.LinkYoutube.Location = New System.Drawing.Point(251, 137)
        Me.LinkYoutube.Name = "LinkYoutube"
        Me.LinkYoutube.Size = New System.Drawing.Size(47, 13)
        Me.LinkYoutube.TabIndex = 26
        Me.LinkYoutube.TabStop = True
        Me.LinkYoutube.Text = "Youtube"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 161)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(180, 13)
        Me.Label1.TabIndex = 27
        Me.Label1.Text = "Contact me to program your own tool"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(305, 180)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.LinkYoutube)
        Me.Controls.Add(Me.LinkTelegram)
        Me.Controls.Add(Me.LinkDiscord)
        Me.Controls.Add(Me.lblStatus)
        Me.Controls.Add(Me.textBoxVolumeName)
        Me.Controls.Add(Me.txtPath)
        Me.Controls.Add(Me.labelStatus)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.progressBar)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.Text = "Iso Creator MONSTERMC"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents textBoxVolumeName As TextBox
    Friend WithEvents txtPath As TextBox
    Friend WithEvents labelStatus As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents progressBar As ProgressBar
    Friend WithEvents lblStatus As Label
    Friend WithEvents LinkDiscord As LinkLabel
    Friend WithEvents LinkTelegram As LinkLabel
    Friend WithEvents LinkYoutube As LinkLabel
    Friend WithEvents Label1 As Label
End Class
