namespace PBL3_Project;

partial class Form1
{
    private System.ComponentModel.IContainer components = null;

    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    private void InitializeComponent()
    {
        this.btnTest = new System.Windows.Forms.Button();
        this.SuspendLayout();
        
        this.btnTest.Location = new System.Drawing.Point(180, 30);
        this.btnTest.Name = "btnTest";
        this.btnTest.Size = new System.Drawing.Size(150, 40);
        this.btnTest.TabIndex = 0;
        this.btnTest.Text = "Kiểm tra kết nối";
        this.btnTest.UseVisualStyleBackColor = true;
        this.btnTest.Click += new System.EventHandler(this.btnTest_Click);

        this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(600, 450);
        this.Controls.Add(this.btnTest);
        this.Name = "Form1";
        this.Text = "PBL3 - Quan Ly Shop Giay";
        this.ResumeLayout(false);
    }

    #endregion

    private System.Windows.Forms.Button btnTest;
}