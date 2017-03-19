namespace musicPlayer
{
    partial class MainForm
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
            this.gb_info = new System.Windows.Forms.GroupBox();
            this.tb_Naam = new System.Windows.Forms.TextBox();
            this.cb_Artist = new System.Windows.Forms.ComboBox();
            this.rb_Song = new System.Windows.Forms.RadioButton();
            this.rb_Artist = new System.Windows.Forms.RadioButton();
            this.rb_Playlist = new System.Windows.Forms.RadioButton();
            this.btn_Toevoegen = new System.Windows.Forms.Button();
            this.lbl_Naam = new System.Windows.Forms.Label();
            this.lbl_Jaar = new System.Windows.Forms.Label();
            this.lb_Song = new System.Windows.Forms.ListBox();
            this.lb_Artist = new System.Windows.Forms.ListBox();
            this.lb_Playlist = new System.Windows.Forms.ListBox();
            this.num_Year = new System.Windows.Forms.NumericUpDown();
            this.lbl_Artiest = new System.Windows.Forms.Label();
            this.btn_Play = new System.Windows.Forms.Button();
            this.btn_Stop = new System.Windows.Forms.Button();
            this.gb_info.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_Year)).BeginInit();
            this.SuspendLayout();
            // 
            // gb_info
            // 
            this.gb_info.Controls.Add(this.lbl_Artiest);
            this.gb_info.Controls.Add(this.num_Year);
            this.gb_info.Controls.Add(this.lbl_Jaar);
            this.gb_info.Controls.Add(this.lbl_Naam);
            this.gb_info.Controls.Add(this.btn_Toevoegen);
            this.gb_info.Controls.Add(this.rb_Playlist);
            this.gb_info.Controls.Add(this.rb_Artist);
            this.gb_info.Controls.Add(this.rb_Song);
            this.gb_info.Controls.Add(this.cb_Artist);
            this.gb_info.Controls.Add(this.tb_Naam);
            this.gb_info.Location = new System.Drawing.Point(13, 13);
            this.gb_info.Name = "gb_info";
            this.gb_info.Size = new System.Drawing.Size(200, 225);
            this.gb_info.TabIndex = 0;
            this.gb_info.TabStop = false;
            this.gb_info.Text = "Informatie";
            // 
            // tb_Naam
            // 
            this.tb_Naam.Location = new System.Drawing.Point(6, 38);
            this.tb_Naam.Name = "tb_Naam";
            this.tb_Naam.Size = new System.Drawing.Size(121, 20);
            this.tb_Naam.TabIndex = 0;
            // 
            // cb_Artist
            // 
            this.cb_Artist.FormattingEnabled = true;
            this.cb_Artist.Location = new System.Drawing.Point(7, 117);
            this.cb_Artist.Name = "cb_Artist";
            this.cb_Artist.Size = new System.Drawing.Size(121, 21);
            this.cb_Artist.TabIndex = 2;
            // 
            // rb_Song
            // 
            this.rb_Song.AutoSize = true;
            this.rb_Song.Location = new System.Drawing.Point(6, 148);
            this.rb_Song.Name = "rb_Song";
            this.rb_Song.Size = new System.Drawing.Size(64, 17);
            this.rb_Song.TabIndex = 3;
            this.rb_Song.TabStop = true;
            this.rb_Song.Text = "Nummer";
            this.rb_Song.UseVisualStyleBackColor = true;
            // 
            // rb_Artist
            // 
            this.rb_Artist.AutoSize = true;
            this.rb_Artist.Location = new System.Drawing.Point(6, 171);
            this.rb_Artist.Name = "rb_Artist";
            this.rb_Artist.Size = new System.Drawing.Size(54, 17);
            this.rb_Artist.TabIndex = 4;
            this.rb_Artist.TabStop = true;
            this.rb_Artist.Text = "Artiest";
            this.rb_Artist.UseVisualStyleBackColor = true;
            // 
            // rb_Playlist
            // 
            this.rb_Playlist.AutoSize = true;
            this.rb_Playlist.Location = new System.Drawing.Point(6, 194);
            this.rb_Playlist.Name = "rb_Playlist";
            this.rb_Playlist.Size = new System.Drawing.Size(57, 17);
            this.rb_Playlist.TabIndex = 5;
            this.rb_Playlist.TabStop = true;
            this.rb_Playlist.Text = "Playlist";
            this.rb_Playlist.UseVisualStyleBackColor = true;
            // 
            // btn_Toevoegen
            // 
            this.btn_Toevoegen.Location = new System.Drawing.Point(77, 148);
            this.btn_Toevoegen.Name = "btn_Toevoegen";
            this.btn_Toevoegen.Size = new System.Drawing.Size(117, 63);
            this.btn_Toevoegen.TabIndex = 6;
            this.btn_Toevoegen.Text = "Toevoegen";
            this.btn_Toevoegen.UseVisualStyleBackColor = true;
            this.btn_Toevoegen.Click += new System.EventHandler(this.btn_Toevoegen_Click);
            // 
            // lbl_Naam
            // 
            this.lbl_Naam.AutoSize = true;
            this.lbl_Naam.Location = new System.Drawing.Point(6, 20);
            this.lbl_Naam.Name = "lbl_Naam";
            this.lbl_Naam.Size = new System.Drawing.Size(35, 13);
            this.lbl_Naam.TabIndex = 7;
            this.lbl_Naam.Text = "Naam";
            // 
            // lbl_Jaar
            // 
            this.lbl_Jaar.AutoSize = true;
            this.lbl_Jaar.Location = new System.Drawing.Point(6, 61);
            this.lbl_Jaar.Name = "lbl_Jaar";
            this.lbl_Jaar.Size = new System.Drawing.Size(27, 13);
            this.lbl_Jaar.TabIndex = 8;
            this.lbl_Jaar.Text = "Jaar";
            // 
            // lb_Song
            // 
            this.lb_Song.FormattingEnabled = true;
            this.lb_Song.Location = new System.Drawing.Point(219, 16);
            this.lb_Song.Name = "lb_Song";
            this.lb_Song.Size = new System.Drawing.Size(183, 225);
            this.lb_Song.TabIndex = 1;
            // 
            // lb_Artist
            // 
            this.lb_Artist.FormattingEnabled = true;
            this.lb_Artist.Location = new System.Drawing.Point(408, 17);
            this.lb_Artist.Name = "lb_Artist";
            this.lb_Artist.Size = new System.Drawing.Size(183, 225);
            this.lb_Artist.TabIndex = 2;
            // 
            // lb_Playlist
            // 
            this.lb_Playlist.FormattingEnabled = true;
            this.lb_Playlist.Location = new System.Drawing.Point(597, 17);
            this.lb_Playlist.Name = "lb_Playlist";
            this.lb_Playlist.Size = new System.Drawing.Size(183, 225);
            this.lb_Playlist.TabIndex = 3;
            // 
            // num_Year
            // 
            this.num_Year.Location = new System.Drawing.Point(7, 78);
            this.num_Year.Maximum = new decimal(new int[] {
            2100,
            0,
            0,
            0});
            this.num_Year.Minimum = new decimal(new int[] {
            1900,
            0,
            0,
            0});
            this.num_Year.Name = "num_Year";
            this.num_Year.Size = new System.Drawing.Size(63, 20);
            this.num_Year.TabIndex = 9;
            this.num_Year.Value = new decimal(new int[] {
            2017,
            0,
            0,
            0});
            // 
            // lbl_Artiest
            // 
            this.lbl_Artiest.AutoSize = true;
            this.lbl_Artiest.Location = new System.Drawing.Point(5, 101);
            this.lbl_Artiest.Name = "lbl_Artiest";
            this.lbl_Artiest.Size = new System.Drawing.Size(36, 13);
            this.lbl_Artiest.TabIndex = 10;
            this.lbl_Artiest.Text = "Artiest";
            // 
            // btn_Play
            // 
            this.btn_Play.Location = new System.Drawing.Point(13, 241);
            this.btn_Play.Name = "btn_Play";
            this.btn_Play.Size = new System.Drawing.Size(83, 23);
            this.btn_Play.TabIndex = 4;
            this.btn_Play.Text = "Play";
            this.btn_Play.UseVisualStyleBackColor = true;
            this.btn_Play.Click += new System.EventHandler(this.btn_Play_Click);
            // 
            // btn_Stop
            // 
            this.btn_Stop.Location = new System.Drawing.Point(119, 241);
            this.btn_Stop.Name = "btn_Stop";
            this.btn_Stop.Size = new System.Drawing.Size(94, 23);
            this.btn_Stop.TabIndex = 5;
            this.btn_Stop.Text = "Stop";
            this.btn_Stop.UseVisualStyleBackColor = true;
            this.btn_Stop.Click += new System.EventHandler(this.btn_Stop_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 270);
            this.Controls.Add(this.btn_Stop);
            this.Controls.Add(this.btn_Play);
            this.Controls.Add(this.lb_Playlist);
            this.Controls.Add(this.lb_Artist);
            this.Controls.Add(this.lb_Song);
            this.Controls.Add(this.gb_info);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.gb_info.ResumeLayout(false);
            this.gb_info.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_Year)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_info;
        private System.Windows.Forms.Label lbl_Artiest;
        private System.Windows.Forms.NumericUpDown num_Year;
        private System.Windows.Forms.Label lbl_Jaar;
        private System.Windows.Forms.Label lbl_Naam;
        private System.Windows.Forms.Button btn_Toevoegen;
        private System.Windows.Forms.RadioButton rb_Playlist;
        private System.Windows.Forms.RadioButton rb_Artist;
        private System.Windows.Forms.RadioButton rb_Song;
        private System.Windows.Forms.ComboBox cb_Artist;
        private System.Windows.Forms.TextBox tb_Naam;
        private System.Windows.Forms.ListBox lb_Song;
        private System.Windows.Forms.ListBox lb_Artist;
        private System.Windows.Forms.ListBox lb_Playlist;
        private System.Windows.Forms.Button btn_Play;
        private System.Windows.Forms.Button btn_Stop;
    }
}

