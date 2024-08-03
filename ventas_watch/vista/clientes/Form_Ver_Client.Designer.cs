namespace ventas_watch.vista.clientes
{
    partial class Form_Ver_Client
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
            this.listViewClient = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // listViewClient
            // 
            this.listViewClient.HideSelection = false;
            this.listViewClient.Location = new System.Drawing.Point(218, 133);
            this.listViewClient.Name = "listViewClient";
            this.listViewClient.Size = new System.Drawing.Size(490, 186);
            this.listViewClient.TabIndex = 0;
            this.listViewClient.UseCompatibleStateImageBehavior = false;
            // 
            // Form_Ver_Client
            // 
            this.ClientSize = new System.Drawing.Size(936, 466);
            this.Controls.Add(this.listViewClient);
            this.Name = "Form_Ver_Client";
            this.Load += new System.EventHandler(this.Form_Ver_Client_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvClient;
        private System.Windows.Forms.ListView listViewClient;
    }
}