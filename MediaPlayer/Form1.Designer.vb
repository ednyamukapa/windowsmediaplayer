<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main))
        Me.ofdMain = New System.Windows.Forms.OpenFileDialog()
        Me.menuItems = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BrowseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PlayerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VolumeUpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VolumeDownToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MuteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PlayPauseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StopToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.wmPlayer = New AxWMPLib.AxWindowsMediaPlayer()
        Me.menuItems.SuspendLayout()
        CType(Me.wmPlayer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ofdMain
        '
        Me.ofdMain.FileName = "ofdMain"
        '
        'menuItems
        '
        Me.menuItems.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.PlayerToolStripMenuItem, Me.AboutToolStripMenuItem})
        Me.menuItems.Location = New System.Drawing.Point(0, 0)
        Me.menuItems.Name = "menuItems"
        Me.menuItems.Size = New System.Drawing.Size(785, 24)
        Me.menuItems.TabIndex = 0
        Me.menuItems.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BrowseToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'BrowseToolStripMenuItem
        '
        Me.BrowseToolStripMenuItem.Name = "BrowseToolStripMenuItem"
        Me.BrowseToolStripMenuItem.Size = New System.Drawing.Size(112, 22)
        Me.BrowseToolStripMenuItem.Text = "Browse"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(112, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'PlayerToolStripMenuItem
        '
        Me.PlayerToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.VolumeUpToolStripMenuItem, Me.VolumeDownToolStripMenuItem, Me.MuteToolStripMenuItem, Me.PlayPauseToolStripMenuItem, Me.StopToolStripMenuItem})
        Me.PlayerToolStripMenuItem.Name = "PlayerToolStripMenuItem"
        Me.PlayerToolStripMenuItem.Size = New System.Drawing.Size(51, 20)
        Me.PlayerToolStripMenuItem.Text = "Player"
        '
        'VolumeUpToolStripMenuItem
        '
        Me.VolumeUpToolStripMenuItem.Name = "VolumeUpToolStripMenuItem"
        Me.VolumeUpToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.VolumeUpToolStripMenuItem.Text = "Volume Up"
        '
        'VolumeDownToolStripMenuItem
        '
        Me.VolumeDownToolStripMenuItem.Name = "VolumeDownToolStripMenuItem"
        Me.VolumeDownToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.VolumeDownToolStripMenuItem.Text = "Volume Down"
        '
        'MuteToolStripMenuItem
        '
        Me.MuteToolStripMenuItem.Name = "MuteToolStripMenuItem"
        Me.MuteToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.MuteToolStripMenuItem.Text = "Mute"
        '
        'PlayPauseToolStripMenuItem
        '
        Me.PlayPauseToolStripMenuItem.Name = "PlayPauseToolStripMenuItem"
        Me.PlayPauseToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.PlayPauseToolStripMenuItem.Text = "Play"
        '
        'StopToolStripMenuItem
        '
        Me.StopToolStripMenuItem.Name = "StopToolStripMenuItem"
        Me.StopToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.StopToolStripMenuItem.Text = "Stop"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(52, 20)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'wmPlayer
        '
        Me.wmPlayer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.wmPlayer.Enabled = True
        Me.wmPlayer.Location = New System.Drawing.Point(0, 24)
        Me.wmPlayer.Name = "wmPlayer"
        Me.wmPlayer.OcxState = CType(resources.GetObject("wmPlayer.OcxState"), System.Windows.Forms.AxHost.State)
        Me.wmPlayer.Size = New System.Drawing.Size(785, 512)
        Me.wmPlayer.TabIndex = 1
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(785, 536)
        Me.Controls.Add(Me.wmPlayer)
        Me.Controls.Add(Me.menuItems)
        Me.KeyPreview = True
        Me.MainMenuStrip = Me.menuItems
        Me.Name = "Main"
        Me.Text = "Media Player"
        Me.menuItems.ResumeLayout(False)
        Me.menuItems.PerformLayout()
        CType(Me.wmPlayer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ofdMain As System.Windows.Forms.OpenFileDialog
    Friend WithEvents menuItems As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BrowseToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PlayerToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents VolumeUpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents VolumeDownToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MuteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PlayPauseToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StopToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents wmPlayer As AxWMPLib.AxWindowsMediaPlayer

End Class
