namespace Zork.Builder
{
    partial class ZorkBuilder
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.mainMenuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.ZorkTabControl = new System.Windows.Forms.TabControl();
            this.WorldInfoTab = new System.Windows.Forms.TabPage();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.isModifiedToolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.RoomListboxLabel = new System.Windows.Forms.Label();
            this.NeighborLabel = new System.Windows.Forms.Label();
            this.RoomDesciptionLabel = new System.Windows.Forms.Label();
            this.RoomNameLabel = new System.Windows.Forms.Label();
            this.DeleteRoomButton = new System.Windows.Forms.Button();
            this.AddRoomButton = new System.Windows.Forms.Button();
            this.NeighborsGroupbox = new System.Windows.Forms.GroupBox();
            this.SouthNeighborControl = new Zork.Builder.UserControls.NeighborsUserControl();
            this.EastNeighborControl = new Zork.Builder.UserControls.NeighborsUserControl();
            this.WestNeighborControl = new Zork.Builder.UserControls.NeighborsUserControl();
            this.NorthNeighborControl = new Zork.Builder.UserControls.NeighborsUserControl();
            this.RoomDesciptionTextbox = new System.Windows.Forms.TextBox();
            this.roomsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gameViewModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.RoomNameTextbox = new System.Windows.Forms.TextBox();
            this.RoomsListBox = new System.Windows.Forms.ListBox();
            this.StartingLocationComboBox = new System.Windows.Forms.ComboBox();
            this.StartingLocationLabel = new System.Windows.Forms.Label();
            this.GameInfoTab = new System.Windows.Forms.TabPage();
            this.WelcomeMessageTextbox = new System.Windows.Forms.TextBox();
            this.FilenameTextbox = new System.Windows.Forms.TextBox();
            this.WelcomeMessageLabel = new System.Windows.Forms.Label();
            this.FilenameLabel = new System.Windows.Forms.Label();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.mainMenuStrip.SuspendLayout();
            this.ZorkTabControl.SuspendLayout();
            this.WorldInfoTab.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.NeighborsGroupbox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.roomsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gameViewModelBindingSource)).BeginInit();
            this.GameInfoTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainMenuStrip
            // 
            this.mainMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.mainMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.mainMenuStrip.Name = "mainMenuStrip";
            this.mainMenuStrip.Size = new System.Drawing.Size(681, 28);
            this.mainMenuStrip.TabIndex = 0;
            this.mainMenuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.toolStripMenuItem3,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.toolStripMenuItem2,
            this.exitToolStripMenuItem,
            this.toolStripMenuItem1});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 26);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.newToolStripMenuItem.Text = "&New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(221, 6);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.saveAsToolStripMenuItem.Text = "Save As...";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(221, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(221, 6);
            // 
            // ZorkTabControl
            // 
            this.ZorkTabControl.Controls.Add(this.WorldInfoTab);
            this.ZorkTabControl.Controls.Add(this.GameInfoTab);
            this.ZorkTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ZorkTabControl.Location = new System.Drawing.Point(0, 28);
            this.ZorkTabControl.Multiline = true;
            this.ZorkTabControl.Name = "ZorkTabControl";
            this.ZorkTabControl.SelectedIndex = 0;
            this.ZorkTabControl.Size = new System.Drawing.Size(681, 568);
            this.ZorkTabControl.TabIndex = 1;
            // 
            // WorldInfoTab
            // 
            this.WorldInfoTab.Controls.Add(this.statusStrip);
            this.WorldInfoTab.Controls.Add(this.RoomListboxLabel);
            this.WorldInfoTab.Controls.Add(this.NeighborLabel);
            this.WorldInfoTab.Controls.Add(this.RoomDesciptionLabel);
            this.WorldInfoTab.Controls.Add(this.RoomNameLabel);
            this.WorldInfoTab.Controls.Add(this.DeleteRoomButton);
            this.WorldInfoTab.Controls.Add(this.AddRoomButton);
            this.WorldInfoTab.Controls.Add(this.NeighborsGroupbox);
            this.WorldInfoTab.Controls.Add(this.RoomDesciptionTextbox);
            this.WorldInfoTab.Controls.Add(this.RoomNameTextbox);
            this.WorldInfoTab.Controls.Add(this.RoomsListBox);
            this.WorldInfoTab.Controls.Add(this.StartingLocationComboBox);
            this.WorldInfoTab.Controls.Add(this.StartingLocationLabel);
            this.WorldInfoTab.Location = new System.Drawing.Point(4, 25);
            this.WorldInfoTab.Name = "WorldInfoTab";
            this.WorldInfoTab.Padding = new System.Windows.Forms.Padding(3);
            this.WorldInfoTab.Size = new System.Drawing.Size(673, 539);
            this.WorldInfoTab.TabIndex = 0;
            this.WorldInfoTab.Text = "World Information";
            this.WorldInfoTab.UseVisualStyleBackColor = true;
            // 
            // statusStrip
            // 
            this.statusStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.isModifiedToolStripStatusLabel1});
            this.statusStrip.Location = new System.Drawing.Point(3, 510);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(667, 26);
            this.statusStrip.TabIndex = 12;
            this.statusStrip.Text = "statusStrip1";
            // 
            // isModifiedToolStripStatusLabel1
            // 
            this.isModifiedToolStripStatusLabel1.Name = "isModifiedToolStripStatusLabel1";
            this.isModifiedToolStripStatusLabel1.Size = new System.Drawing.Size(97, 20);
            this.isModifiedToolStripStatusLabel1.Text = "Modified: No";
            // 
            // RoomListboxLabel
            // 
            this.RoomListboxLabel.AutoSize = true;
            this.RoomListboxLabel.Location = new System.Drawing.Point(9, 62);
            this.RoomListboxLabel.Name = "RoomListboxLabel";
            this.RoomListboxLabel.Size = new System.Drawing.Size(56, 17);
            this.RoomListboxLabel.TabIndex = 11;
            this.RoomListboxLabel.Text = "Rooms:";
            // 
            // NeighborLabel
            // 
            this.NeighborLabel.AutoSize = true;
            this.NeighborLabel.Location = new System.Drawing.Point(235, 247);
            this.NeighborLabel.Name = "NeighborLabel";
            this.NeighborLabel.Size = new System.Drawing.Size(77, 17);
            this.NeighborLabel.TabIndex = 10;
            this.NeighborLabel.Text = "Neighbors:";
            // 
            // RoomDesciptionLabel
            // 
            this.RoomDesciptionLabel.AutoSize = true;
            this.RoomDesciptionLabel.Location = new System.Drawing.Point(235, 130);
            this.RoomDesciptionLabel.Name = "RoomDesciptionLabel";
            this.RoomDesciptionLabel.Size = new System.Drawing.Size(124, 17);
            this.RoomDesciptionLabel.TabIndex = 9;
            this.RoomDesciptionLabel.Text = "Room Description:";
            // 
            // RoomNameLabel
            // 
            this.RoomNameLabel.AutoSize = true;
            this.RoomNameLabel.Location = new System.Drawing.Point(235, 62);
            this.RoomNameLabel.Name = "RoomNameLabel";
            this.RoomNameLabel.Size = new System.Drawing.Size(90, 17);
            this.RoomNameLabel.TabIndex = 8;
            this.RoomNameLabel.Text = "Room Name:";
            // 
            // DeleteRoomButton
            // 
            this.DeleteRoomButton.Location = new System.Drawing.Point(110, 480);
            this.DeleteRoomButton.Name = "DeleteRoomButton";
            this.DeleteRoomButton.Size = new System.Drawing.Size(90, 31);
            this.DeleteRoomButton.TabIndex = 7;
            this.DeleteRoomButton.Text = "Delete";
            this.DeleteRoomButton.UseVisualStyleBackColor = true;
            this.DeleteRoomButton.Click += new System.EventHandler(this.DeleteRoomButton_Click);
            // 
            // AddRoomButton
            // 
            this.AddRoomButton.Location = new System.Drawing.Point(12, 480);
            this.AddRoomButton.Name = "AddRoomButton";
            this.AddRoomButton.Size = new System.Drawing.Size(90, 31);
            this.AddRoomButton.TabIndex = 6;
            this.AddRoomButton.Text = "Add";
            this.AddRoomButton.UseVisualStyleBackColor = true;
            this.AddRoomButton.Click += new System.EventHandler(this.AddRoomButton_Click);
            // 
            // NeighborsGroupbox
            // 
            this.NeighborsGroupbox.Controls.Add(this.SouthNeighborControl);
            this.NeighborsGroupbox.Controls.Add(this.EastNeighborControl);
            this.NeighborsGroupbox.Controls.Add(this.WestNeighborControl);
            this.NeighborsGroupbox.Controls.Add(this.NorthNeighborControl);
            this.NeighborsGroupbox.Location = new System.Drawing.Point(235, 247);
            this.NeighborsGroupbox.Name = "NeighborsGroupbox";
            this.NeighborsGroupbox.Size = new System.Drawing.Size(433, 263);
            this.NeighborsGroupbox.TabIndex = 5;
            this.NeighborsGroupbox.TabStop = false;
            // 
            // SouthNeighborControl
            // 
            this.SouthNeighborControl.Direction = Zork.Directions.South;
            this.SouthNeighborControl.Location = new System.Drawing.Point(129, 181);
            this.SouthNeighborControl.Name = "SouthNeighborControl";
            this.SouthNeighborControl.Neighbor = null;
            this.SouthNeighborControl.Room = null;
            this.SouthNeighborControl.Size = new System.Drawing.Size(161, 63);
            this.SouthNeighborControl.TabIndex = 3;
            this.SouthNeighborControl.ViewModel = null;
            // 
            // EastNeighborControl
            // 
            this.EastNeighborControl.Direction = Zork.Directions.East;
            this.EastNeighborControl.Location = new System.Drawing.Point(238, 112);
            this.EastNeighborControl.Name = "EastNeighborControl";
            this.EastNeighborControl.Neighbor = null;
            this.EastNeighborControl.Room = null;
            this.EastNeighborControl.Size = new System.Drawing.Size(161, 63);
            this.EastNeighborControl.TabIndex = 2;
            this.EastNeighborControl.ViewModel = null;
            // 
            // WestNeighborControl
            // 
            this.WestNeighborControl.Direction = Zork.Directions.West;
            this.WestNeighborControl.Location = new System.Drawing.Point(13, 112);
            this.WestNeighborControl.Name = "WestNeighborControl";
            this.WestNeighborControl.Neighbor = null;
            this.WestNeighborControl.Room = null;
            this.WestNeighborControl.Size = new System.Drawing.Size(161, 63);
            this.WestNeighborControl.TabIndex = 1;
            this.WestNeighborControl.ViewModel = null;
            // 
            // NorthNeighborControl
            // 
            this.NorthNeighborControl.Direction = Zork.Directions.North;
            this.NorthNeighborControl.Location = new System.Drawing.Point(129, 43);
            this.NorthNeighborControl.Name = "NorthNeighborControl";
            this.NorthNeighborControl.Neighbor = null;
            this.NorthNeighborControl.Room = null;
            this.NorthNeighborControl.Size = new System.Drawing.Size(161, 63);
            this.NorthNeighborControl.TabIndex = 0;
            this.NorthNeighborControl.ViewModel = null;
            // 
            // RoomDesciptionTextbox
            // 
            this.RoomDesciptionTextbox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.roomsBindingSource, "Description", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.RoomDesciptionTextbox.Location = new System.Drawing.Point(235, 150);
            this.RoomDesciptionTextbox.Multiline = true;
            this.RoomDesciptionTextbox.Name = "RoomDesciptionTextbox";
            this.RoomDesciptionTextbox.Size = new System.Drawing.Size(408, 83);
            this.RoomDesciptionTextbox.TabIndex = 4;
            this.RoomDesciptionTextbox.TextChanged += new System.EventHandler(this.RoomDesciptionTextbox_TextChanged);
            // 
            // roomsBindingSource
            // 
            this.roomsBindingSource.DataMember = "Rooms";
            this.roomsBindingSource.DataSource = this.gameViewModelBindingSource;
            // 
            // gameViewModelBindingSource
            // 
            this.gameViewModelBindingSource.DataSource = typeof(Zork.Builder.ViewModels.GameViewModel);
            // 
            // RoomNameTextbox
            // 
            this.RoomNameTextbox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.roomsBindingSource, "Name", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.RoomNameTextbox.Location = new System.Drawing.Point(235, 85);
            this.RoomNameTextbox.Name = "RoomNameTextbox";
            this.RoomNameTextbox.Size = new System.Drawing.Size(408, 22);
            this.RoomNameTextbox.TabIndex = 3;
            this.RoomNameTextbox.TextChanged += new System.EventHandler(this.RoomNameTextbox_TextChanged);
            // 
            // RoomsListBox
            // 
            this.RoomsListBox.DataSource = this.roomsBindingSource;
            this.RoomsListBox.DisplayMember = "Name";
            this.RoomsListBox.FormattingEnabled = true;
            this.RoomsListBox.ItemHeight = 16;
            this.RoomsListBox.Location = new System.Drawing.Point(12, 82);
            this.RoomsListBox.Name = "RoomsListBox";
            this.RoomsListBox.Size = new System.Drawing.Size(188, 388);
            this.RoomsListBox.TabIndex = 2;
            this.RoomsListBox.ValueMember = "Description";
            this.RoomsListBox.SelectedIndexChanged += new System.EventHandler(this.RoomsListBox_SelectedIndexChanged);
            // 
            // StartingLocationComboBox
            // 
            this.StartingLocationComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.StartingLocationComboBox.FormattingEnabled = true;
            this.StartingLocationComboBox.Location = new System.Drawing.Point(12, 35);
            this.StartingLocationComboBox.Name = "StartingLocationComboBox";
            this.StartingLocationComboBox.Size = new System.Drawing.Size(217, 24);
            this.StartingLocationComboBox.TabIndex = 1;
            // 
            // StartingLocationLabel
            // 
            this.StartingLocationLabel.AutoSize = true;
            this.StartingLocationLabel.Location = new System.Drawing.Point(9, 12);
            this.StartingLocationLabel.Name = "StartingLocationLabel";
            this.StartingLocationLabel.Size = new System.Drawing.Size(119, 17);
            this.StartingLocationLabel.TabIndex = 0;
            this.StartingLocationLabel.Text = "Starting Location:";
            // 
            // GameInfoTab
            // 
            this.GameInfoTab.Controls.Add(this.WelcomeMessageTextbox);
            this.GameInfoTab.Controls.Add(this.FilenameTextbox);
            this.GameInfoTab.Controls.Add(this.WelcomeMessageLabel);
            this.GameInfoTab.Controls.Add(this.FilenameLabel);
            this.GameInfoTab.Location = new System.Drawing.Point(4, 25);
            this.GameInfoTab.Name = "GameInfoTab";
            this.GameInfoTab.Padding = new System.Windows.Forms.Padding(3);
            this.GameInfoTab.Size = new System.Drawing.Size(673, 539);
            this.GameInfoTab.TabIndex = 1;
            this.GameInfoTab.Text = "Game Information";
            this.GameInfoTab.UseVisualStyleBackColor = true;
            // 
            // WelcomeMessageTextbox
            // 
            this.WelcomeMessageTextbox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.gameViewModelBindingSource, "WelcomeMessage", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.WelcomeMessageTextbox.Location = new System.Drawing.Point(3, 109);
            this.WelcomeMessageTextbox.Multiline = true;
            this.WelcomeMessageTextbox.Name = "WelcomeMessageTextbox";
            this.WelcomeMessageTextbox.Size = new System.Drawing.Size(494, 71);
            this.WelcomeMessageTextbox.TabIndex = 5;
            // 
            // FilenameTextbox
            // 
            this.FilenameTextbox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.gameViewModelBindingSource, "FullPath", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.FilenameTextbox.Location = new System.Drawing.Point(3, 45);
            this.FilenameTextbox.Name = "FilenameTextbox";
            this.FilenameTextbox.ReadOnly = true;
            this.FilenameTextbox.Size = new System.Drawing.Size(497, 22);
            this.FilenameTextbox.TabIndex = 3;
            // 
            // WelcomeMessageLabel
            // 
            this.WelcomeMessageLabel.AutoSize = true;
            this.WelcomeMessageLabel.Location = new System.Drawing.Point(3, 79);
            this.WelcomeMessageLabel.Name = "WelcomeMessageLabel";
            this.WelcomeMessageLabel.Size = new System.Drawing.Size(131, 17);
            this.WelcomeMessageLabel.TabIndex = 2;
            this.WelcomeMessageLabel.Text = "Welcome Message:";
            // 
            // FilenameLabel
            // 
            this.FilenameLabel.AutoSize = true;
            this.FilenameLabel.Location = new System.Drawing.Point(3, 25);
            this.FilenameLabel.Name = "FilenameLabel";
            this.FilenameLabel.Size = new System.Drawing.Size(69, 17);
            this.FilenameLabel.TabIndex = 0;
            this.FilenameLabel.Text = "Filename:";
            // 
            // openFileDialog
            // 
            this.openFileDialog.Filter = "World Files (*.json) |*.json";
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.Filter = "World Files (*.json) |*.json";
            // 
            // ZorkBuilder
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(681, 596);
            this.Controls.Add(this.ZorkTabControl);
            this.Controls.Add(this.mainMenuStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.mainMenuStrip;
            this.MaximizeBox = false;
            this.Name = "ZorkBuilder";
            this.Text = "Zork Builder";
            this.mainMenuStrip.ResumeLayout(false);
            this.mainMenuStrip.PerformLayout();
            this.ZorkTabControl.ResumeLayout(false);
            this.WorldInfoTab.ResumeLayout(false);
            this.WorldInfoTab.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.NeighborsGroupbox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.roomsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gameViewModelBindingSource)).EndInit();
            this.GameInfoTab.ResumeLayout(false);
            this.GameInfoTab.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mainMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.TabControl ZorkTabControl;
        private System.Windows.Forms.TabPage WorldInfoTab;
        private System.Windows.Forms.TabPage GameInfoTab;
        private System.Windows.Forms.TextBox WelcomeMessageTextbox;
        private System.Windows.Forms.TextBox FilenameTextbox;
        private System.Windows.Forms.Label WelcomeMessageLabel;
        private System.Windows.Forms.Label FilenameLabel;
        private System.Windows.Forms.ComboBox StartingLocationComboBox;
        private System.Windows.Forms.Label StartingLocationLabel;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.Label RoomDesciptionLabel;
        private System.Windows.Forms.Label RoomNameLabel;
        private System.Windows.Forms.Button DeleteRoomButton;
        private System.Windows.Forms.Button AddRoomButton;
        private System.Windows.Forms.TextBox RoomDesciptionTextbox;
        private System.Windows.Forms.TextBox RoomNameTextbox;
        private System.Windows.Forms.ListBox RoomsListBox;
        private System.Windows.Forms.Label RoomListboxLabel;
        private System.Windows.Forms.Label NeighborLabel;
        private System.Windows.Forms.BindingSource gameViewModelBindingSource;
        private System.Windows.Forms.BindingSource roomsBindingSource;
        private System.Windows.Forms.GroupBox NeighborsGroupbox;
        private UserControls.NeighborsUserControl SouthNeighborControl;
        private UserControls.NeighborsUserControl EastNeighborControl;
        private UserControls.NeighborsUserControl WestNeighborControl;
        private UserControls.NeighborsUserControl NorthNeighborControl;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel isModifiedToolStripStatusLabel1;
    }
}

