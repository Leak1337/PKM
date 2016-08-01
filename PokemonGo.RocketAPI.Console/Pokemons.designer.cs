namespace PokemonGo.RocketAPI.Console
{
    partial class Pokemons
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pokemons));
            this.PokemonListView = new System.Windows.Forms.ListView();
            this.btnreload = new System.Windows.Forms.Button();
            this.btnEvolve = new System.Windows.Forms.Button();
            this.btnUpgrade = new System.Windows.Forms.Button();
            this.btnTransfer = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.transferToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.powerUpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.evolveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusTexbox = new System.Windows.Forms.TextBox();
            this.checkBoxreload = new System.Windows.Forms.CheckBox();
            this.reloadsecondstextbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.reloadtimer = new System.Windows.Forms.Timer(this.components);
            this.btnFullPowerUp = new System.Windows.Forms.Button();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // PokemonListView
            // 
            this.PokemonListView.AllowColumnReorder = true;
            this.PokemonListView.FullRowSelect = true;
            this.PokemonListView.GridLines = true;
            this.PokemonListView.Location = new System.Drawing.Point(12, 12);
            this.PokemonListView.Name = "PokemonListView";
            this.PokemonListView.Size = new System.Drawing.Size(687, 387);
            this.PokemonListView.TabIndex = 0;
            this.PokemonListView.UseCompatibleStateImageBehavior = false;
            this.PokemonListView.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listView1_MouseClick);
            // 
            // btnreload
            // 
            this.btnreload.BackColor = System.Drawing.Color.Lime;
            this.btnreload.Location = new System.Drawing.Point(13, 407);
            this.btnreload.Name = "btnreload";
            this.btnreload.Size = new System.Drawing.Size(136, 23);
            this.btnreload.TabIndex = 1;
            this.btnreload.Text = "Liste neu laden";
            this.btnreload.UseVisualStyleBackColor = false;
            this.btnreload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // btnEvolve
            // 
            this.btnEvolve.BackColor = System.Drawing.Color.Yellow;
            this.btnEvolve.Location = new System.Drawing.Point(149, 436);
            this.btnEvolve.Name = "btnEvolve";
            this.btnEvolve.Size = new System.Drawing.Size(135, 23);
            this.btnEvolve.TabIndex = 2;
            this.btnEvolve.Text = "Entwickeln";
            this.btnEvolve.UseVisualStyleBackColor = false;
            this.btnEvolve.Click += new System.EventHandler(this.btnEvolve_Click);
            // 
            // btnUpgrade
            // 
            this.btnUpgrade.BackColor = System.Drawing.Color.Yellow;
            this.btnUpgrade.Location = new System.Drawing.Point(290, 435);
            this.btnUpgrade.Name = "btnUpgrade";
            this.btnUpgrade.Size = new System.Drawing.Size(135, 23);
            this.btnUpgrade.TabIndex = 3;
            this.btnUpgrade.Text = "Power Up";
            this.btnUpgrade.UseVisualStyleBackColor = false;
            this.btnUpgrade.Click += new System.EventHandler(this.btnUpgrade_Click);
            // 
            // btnTransfer
            // 
            this.btnTransfer.BackColor = System.Drawing.Color.Red;
            this.btnTransfer.Location = new System.Drawing.Point(564, 407);
            this.btnTransfer.Name = "btnTransfer";
            this.btnTransfer.Size = new System.Drawing.Size(135, 23);
            this.btnTransfer.TabIndex = 4;
            this.btnTransfer.Text = "Verschicken";
            this.btnTransfer.UseVisualStyleBackColor = false;
            this.btnTransfer.Click += new System.EventHandler(this.btnTransfer_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.transferToolStripMenuItem,
            this.powerUpToolStripMenuItem,
            this.evolveToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(123, 70);
            this.contextMenuStrip1.Closing += new System.Windows.Forms.ToolStripDropDownClosingEventHandler(this.contextMenuStrip1_Closing);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // transferToolStripMenuItem
            // 
            this.transferToolStripMenuItem.Name = "transferToolStripMenuItem";
            this.transferToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.transferToolStripMenuItem.Text = "Transfer";
            this.transferToolStripMenuItem.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // powerUpToolStripMenuItem
            // 
            this.powerUpToolStripMenuItem.Name = "powerUpToolStripMenuItem";
            this.powerUpToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.powerUpToolStripMenuItem.Text = "PowerUp";
            this.powerUpToolStripMenuItem.Click += new System.EventHandler(this.powerUpToolStripMenuItem_Click);
            // 
            // evolveToolStripMenuItem
            // 
            this.evolveToolStripMenuItem.Name = "evolveToolStripMenuItem";
            this.evolveToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.evolveToolStripMenuItem.Text = "Evolve";
            this.evolveToolStripMenuItem.Visible = false;
            this.evolveToolStripMenuItem.Click += new System.EventHandler(this.evolveToolStripMenuItem_Click);
            // 
            // statusTexbox
            // 
            this.statusTexbox.Enabled = false;
            this.statusTexbox.Location = new System.Drawing.Point(13, 463);
            this.statusTexbox.Name = "statusTexbox";
            this.statusTexbox.Size = new System.Drawing.Size(686, 20);
            this.statusTexbox.TabIndex = 5;
            this.statusTexbox.TextChanged += new System.EventHandler(this.statusTexbox_TextChanged);
            // 
            // checkBoxreload
            // 
            this.checkBoxreload.AutoSize = true;
            this.checkBoxreload.Location = new System.Drawing.Point(273, 409);
            this.checkBoxreload.Name = "checkBoxreload";
            this.checkBoxreload.Size = new System.Drawing.Size(97, 17);
            this.checkBoxreload.TabIndex = 6;
            this.checkBoxreload.Text = "Neu laden alle:";
            this.checkBoxreload.UseVisualStyleBackColor = true;
            this.checkBoxreload.CheckedChanged += new System.EventHandler(this.checkboxReload_CheckedChanged);
            // 
            // reloadsecondstextbox
            // 
            this.reloadsecondstextbox.Location = new System.Drawing.Point(376, 407);
            this.reloadsecondstextbox.Name = "reloadsecondstextbox";
            this.reloadsecondstextbox.Size = new System.Drawing.Size(37, 20);
            this.reloadsecondstextbox.TabIndex = 7;
            this.reloadsecondstextbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.reloadsecondstextbox_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(419, 413);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(12, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "s";
            // 
            // reloadtimer
            // 
            this.reloadtimer.Interval = 1000;
            this.reloadtimer.Tick += new System.EventHandler(this.reloadtimer_Tick);
            // 
            // btnFullPowerUp
            // 
            this.btnFullPowerUp.BackColor = System.Drawing.Color.Yellow;
            this.btnFullPowerUp.Location = new System.Drawing.Point(431, 436);
            this.btnFullPowerUp.Name = "btnFullPowerUp";
            this.btnFullPowerUp.Size = new System.Drawing.Size(135, 23);
            this.btnFullPowerUp.TabIndex = 11;
            this.btnFullPowerUp.Text = "Full Power Up";
            this.btnFullPowerUp.UseVisualStyleBackColor = false;
            this.btnFullPowerUp.Click += new System.EventHandler(this.btnFullPowerUp_Click);
            // 
            // Pokemons
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 488);
            this.Controls.Add(this.btnFullPowerUp);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.reloadsecondstextbox);
            this.Controls.Add(this.checkBoxreload);
            this.Controls.Add(this.statusTexbox);
            this.Controls.Add(this.btnTransfer);
            this.Controls.Add(this.btnUpgrade);
            this.Controls.Add(this.btnEvolve);
            this.Controls.Add(this.btnreload);
            this.Controls.Add(this.PokemonListView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Pokemons";
            this.Text = "Pokemon Liste";
            this.Load += new System.EventHandler(this.Pokemons_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView PokemonListView;
        private System.Windows.Forms.Button btnreload;
        private System.Windows.Forms.Button btnEvolve;
        private System.Windows.Forms.Button btnUpgrade;
        private System.Windows.Forms.Button btnTransfer;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem transferToolStripMenuItem;
        private System.Windows.Forms.TextBox statusTexbox;
        private System.Windows.Forms.ToolStripMenuItem powerUpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem evolveToolStripMenuItem;
        private System.Windows.Forms.CheckBox checkBoxreload;
        private System.Windows.Forms.TextBox reloadsecondstextbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer reloadtimer;
        private System.Windows.Forms.Button btnFullPowerUp;
    }
}