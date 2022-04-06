
namespace LAB3D
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this._canvas = new Tao.Platform.Windows.SimpleOpenGlControl();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // _canvas
            // 
            this._canvas.AccumBits = ((byte)(0));
            this._canvas.AutoCheckErrors = false;
            this._canvas.AutoFinish = false;
            this._canvas.AutoMakeCurrent = true;
            this._canvas.AutoSwapBuffers = true;
            this._canvas.BackColor = System.Drawing.Color.Black;
            this._canvas.ColorBits = ((byte)(32));
            this._canvas.DepthBits = ((byte)(16));
            this._canvas.Location = new System.Drawing.Point(-2, -3);
            this._canvas.Name = "_canvas";
            this._canvas.Size = new System.Drawing.Size(805, 455);
            this._canvas.StencilBits = ((byte)(0));
            this._canvas.TabIndex = 0;
            this._canvas.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this._canvas_KeyPress);
            this._canvas.MouseEnter += new System.EventHandler(this._canvas_MouseEnter);
            this._canvas.MouseLeave += new System.EventHandler(this._canvas_MouseLeave);
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this._canvas);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Tao.Platform.Windows.SimpleOpenGlControl _canvas;
        private System.Windows.Forms.Timer timer;
    }
}

