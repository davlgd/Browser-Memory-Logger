//  Copyright © 2011-2012 LEGRAND David <david@pcinpact.com>    
//  
//  This file is part of PC INpact Browser Memory Logger.
//
//  PC INpact Browser Memory Logger is free software: you can redistribute it and/or modify
//  it under the terms of the GNU General Public License as published by
//  the Free Software Foundation, either version 3 of the License, or
//  (at your option) any later version.
//
//  PC INpact Browser Memory Logger is distributed in the hope that it will be useful,
//  but WITHOUT ANY WARRANTY; without even the implied warranty of
//  MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
//  GNU General Public License for more details.
//
//  You should have received a copy of the GNU General Public License
//  along with PC INpact Browser Memory Logger.  If not, see <http://www.gnu.org/licenses/>.

namespace NXi_Browser_Memory_Logger
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tUpdate = new System.Windows.Forms.Timer(this.components);
            this.chkLog = new System.Windows.Forms.CheckBox();
            this.btnCsvOpen = new System.Windows.Forms.Button();
            this.lnkNXi = new System.Windows.Forms.LinkLabel();
            this.lbResult = new System.Windows.Forms.ListBox();
            this.btnCsvClean = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tUpdate
            // 
            this.tUpdate.Interval = 1000;
            this.tUpdate.Tick += new System.EventHandler(this.tUpdate_Tick);
            // 
            // chkLog
            // 
            this.chkLog.AutoSize = true;
            this.chkLog.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkLog.Location = new System.Drawing.Point(235, 90);
            this.chkLog.Name = "chkLog";
            this.chkLog.Size = new System.Drawing.Size(159, 17);
            this.chkLog.TabIndex = 2;
            this.chkLog.Text = "Enregistrer les valeurs (CSV)";
            this.chkLog.UseVisualStyleBackColor = true;
            // 
            // btnCsvOpen
            // 
            this.btnCsvOpen.Enabled = false;
            this.btnCsvOpen.Location = new System.Drawing.Point(253, 47);
            this.btnCsvOpen.Name = "btnCsvOpen";
            this.btnCsvOpen.Size = new System.Drawing.Size(141, 29);
            this.btnCsvOpen.TabIndex = 3;
            this.btnCsvOpen.Text = "Ouvrir le fichier CSV";
            this.btnCsvOpen.UseVisualStyleBackColor = true;
            this.btnCsvOpen.Click += new System.EventHandler(this.btnCSVOpen_Click);
            // 
            // lnkNXi
            // 
            this.lnkNXi.AutoSize = true;
            this.lnkNXi.Location = new System.Drawing.Point(12, 110);
            this.lnkNXi.Name = "lnkNXi";
            this.lnkNXi.Size = new System.Drawing.Size(87, 13);
            this.lnkNXi.TabIndex = 4;
            this.lnkNXi.TabStop = true;
            this.lnkNXi.Text = "Next INpact.com";
            this.lnkNXi.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkNXi_LinkClicked);
            // 
            // lbResult
            // 
            this.lbResult.FormattingEnabled = true;
            this.lbResult.Location = new System.Drawing.Point(12, 12);
            this.lbResult.Name = "lbResult";
            this.lbResult.Size = new System.Drawing.Size(218, 95);
            this.lbResult.Sorted = true;
            this.lbResult.TabIndex = 6;
            this.lbResult.SelectedIndexChanged += new System.EventHandler(this.lbResult_SelectedIndexChanged);
            // 
            // btnCsvClean
            // 
            this.btnCsvClean.Location = new System.Drawing.Point(253, 12);
            this.btnCsvClean.Name = "btnCsvClean";
            this.btnCsvClean.Size = new System.Drawing.Size(141, 29);
            this.btnCsvClean.TabIndex = 7;
            this.btnCsvClean.Text = "Nettoyer les fichiers CSV";
            this.btnCsvClean.UseVisualStyleBackColor = true;
            this.btnCsvClean.Click += new System.EventHandler(this.btnCsvClean_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(406, 132);
            this.Controls.Add(this.btnCsvClean);
            this.Controls.Add(this.lbResult);
            this.Controls.Add(this.lnkNXi);
            this.Controls.Add(this.btnCsvOpen);
            this.Controls.Add(this.chkLog);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer tUpdate;
        private System.Windows.Forms.CheckBox chkLog;
        private System.Windows.Forms.Button btnCsvOpen;
        private System.Windows.Forms.LinkLabel lnkNXi;
        private System.Windows.Forms.ListBox lbResult;
        private System.Windows.Forms.Button btnCsvClean;
    }
}

