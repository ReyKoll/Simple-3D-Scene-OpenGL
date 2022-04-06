using System;
using System.Windows.Forms;
using Tao.OpenGl;
using Tao.FreeGlut;

namespace LAB3D
{
    public partial class Form1 : Form
    {
        private float _angleX = 1;
        private float _angleY = 0;
        private float _angleZ = 0;

        private bool isAutoRotate = false;

        public Form1()
        {
            InitializeComponent();
            _canvas.InitializeContexts();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Glut.glutInit();
            Glut.glutInitDisplayMode(Glut.GLUT_DOUBLE | Glut.GLUT_RGB | Glut.GLUT_DEPTH);
            Gl.glViewport(0, 0, _canvas.Width, _canvas.Height);
            Clear();
        }

        private void Clear()
        {
            Gl.glClearColor(0.0f, 0.0f, 0.0f, 0.5f);
            Gl.glMatrixMode(Gl.GL_PROJECTION);
            Gl.glLoadIdentity();
            Glu.gluPerspective(70, _canvas.Width / _canvas.Height, 1, 1000);
            Gl.glEnable(Gl.GL_DEPTH_TEST);
        }

        private void DrawLab()
        {
            Clear();

            Gl.glTranslatef(0.0f, 0.0f, -5.0f);

            Gl.glClear(Gl.GL_COLOR_BUFFER_BIT | Gl.GL_DEPTH_BUFFER_BIT);
            Gl.glMatrixMode(Gl.GL_MODELVIEW);
            Gl.glLoadIdentity();

            Gl.glRotatef(_angleX, 1.0f, 0.0f, 0.0f);
            Gl.glRotatef(_angleY, 0.0f, 1.0f, 0.0f);
            Gl.glRotatef(_angleZ, 0.0f, 0.0f, 1.0f);

            // Cube
            Gl.glColor3f(1.0f, 1.0f, 1.0f);
            Glut.glutWireCube(2.0f);


            Gl.glBegin(Gl.GL_POLYGON);
                // Bottom
                Gl.glColor3f(1.0f, 1.0f, 1.0f);
                Gl.glVertex3f(-0.8f, -0.8f, 0.8f);
                Gl.glVertex3f(0.8f, -0.8f, 0.8f);
                Gl.glVertex3f(0.8f, -0.8f, -0.8f);
                Gl.glVertex3f(-0.8f, -0.8f, -0.8f);
            Gl.glEnd();

            Gl.glBegin(Gl.GL_POLYGON);
                // Top
                Gl.glColor3f(1.0f, 1.0f, 1.0f);
                Gl.glVertex3f(0.5f, 0.5f, -0.5f);
                Gl.glVertex3f(0.5f, 0.5f, 0.5f);
                Gl.glVertex3f(-0.5f, 0.5f, 0.5f);
                Gl.glVertex3f(-0.5f, 0.5f, -0.5f);
            Gl.glEnd();
            
            Gl.glBegin(Gl.GL_POLYGON);
                // Left & Red
                Gl.glColor3f(1.0f, 0.0f, 0.0f);
                Gl.glVertex3f(-0.8f, -0.8f, 0.8f);
                Gl.glVertex3f(-0.8f, -0.8f, -0.8f);
                Gl.glVertex3f(-0.5f, 0.5f, -0.5f);
                Gl.glVertex3f(-0.5f, 0.5f, 0.5f);
            Gl.glEnd();
            
            Gl.glBegin(Gl.GL_POLYGON);
                // Right & Green
                Gl.glColor3f(0.0f, 1.0f, 0.0f);
                Gl.glVertex3f(0.8f, -0.8f, 0.8f);
                Gl.glVertex3f(0.8f, -0.8f, -0.8f);
                Gl.glVertex3f(0.5f, 0.5f, -0.5f);
                Gl.glVertex3f(0.5f, 0.5f, 0.5f);
            Gl.glEnd();
            
            Gl.glBegin(Gl.GL_POLYGON);
                // Back & Blue
                Gl.glColor3f(0.0f, 0.0f, 1.0f);
                Gl.glVertex3f(-0.8f, -0.8f, -0.8f);
                Gl.glVertex3f(0.8f, -0.8f, -0.8f);
                Gl.glVertex3f(0.5f, 0.5f, -0.5f);
                Gl.glVertex3f(-0.5f, 0.5f, -0.5f);
            Gl.glEnd();

            Gl.glBegin(Gl.GL_POLYGON);
                // Front & Turquoise
                Gl.glColor3f(0.0f, 1.0f, 1.0f);
                Gl.glVertex3f(-0.8f, -0.8f, 0.8f);
                Gl.glVertex3f(0.8f, -0.8f, 0.8f);
                Gl.glVertex3f(0.5f, 0.5f, 0.5f);
                Gl.glVertex3f(-0.5f, 0.5f, 0.5f);
            Gl.glEnd();

            _canvas.Invalidate();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            Clear();

            if (isAutoRotate)
            {
                _angleX = (_angleX - 3) % 360;
                _angleY = (_angleY + 3) % 360;
                _angleZ = (_angleZ - 3) % 360;
            }
            DrawLab();
        }

        private void _canvas_KeyPress(object sender, KeyPressEventArgs e)
        {
            // X
            if (e.KeyChar == 'w')
                _angleX = (_angleX - 5) % 360;
            else if (e.KeyChar == 's')
                _angleX = (_angleX + 5) % 360;

            // Y
            if (e.KeyChar == 'a')
                _angleY = (_angleY - 5) % 360;
            else if (e.KeyChar == 'd')
                _angleY = (_angleY + 5) % 360;

            // Z
            if (e.KeyChar == 'r')
                _angleZ = (_angleZ - 5) % 360;
            else if (e.KeyChar == 'f')
                _angleZ = (_angleZ + 5) % 360;
        }

        private void _canvas_MouseEnter(object sender, EventArgs e)
        {
            isAutoRotate = false;
        }

        private void _canvas_MouseLeave(object sender, EventArgs e)
        {
            isAutoRotate = true;
        }
    }
}