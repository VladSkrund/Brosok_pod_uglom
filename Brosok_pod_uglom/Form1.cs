using System;
using System.Drawing;
using System.Windows.Forms;

namespace Brosok_pod_uglom
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        float TimeInterval = 0.1f;
        float CoordinateX = 0;
        float CoordinateY = 605;
        float Velocity;
        float VelocityY;
        float VelocityX;
        float AccelerationY;
        float AccelerationX ;
        float ForceX;
        float ForceY;
        float DragCoefficient = 0.01f;
        float g = 9.81f;
        float angle;
        float Mass;
        
      
        private void Start_MouseClick(object sender, MouseEventArgs e)
        {
            float.TryParse(VelocityTextBox.Text, out Velocity);
            float.TryParse(Mass_.Text, out Mass);
            float.TryParse(Angle_.Text, out angle);
            VelocityY = (float)(Velocity * (Math.Sin(angle * Math.PI / 180)));
            VelocityX = (float)(Velocity * (Math.Cos(angle * Math.PI / 180)));
            timer1.Start();
            timer1.Interval = 1;
        }
        static void GetForceX( float DragCoefficient, float VelocityX, out float ForceX)
        {
            ForceX = DragCoefficient * VelocityX * VelocityX;
        }
        static void GetForceForY(float DragCoefficient, float VelocityY, float Mass,float g, out float ForceY)
        {
            ForceY = Mass * g - DragCoefficient * VelocityY * VelocityY;
        }
     static void GetAccelerationX( float ForceX, float Mass, out float AccelerationX)
        {
            AccelerationX = -ForceX / Mass;
        }
        static void GetAccelerationY(float ForceY, float Mass, out float AccelerationY)
        {
            AccelerationY = ForceY / Mass;
        }
        static void GetVelocityX(float AccelerationX, float TimeInterval, ref float VelocityX)
        {
            VelocityX += AccelerationX * TimeInterval;
        }
        static void GetVelocityY(float AccelerationY, float TimeInterval, ref float VelocityY)
        {
            VelocityY -= AccelerationY * TimeInterval;
        }
        static void GetCoordinateX (float VelocityX, float AccelerationX, float TimeInterval, ref float CoordinateX)
        {
            CoordinateX += VelocityX + AccelerationX * (TimeInterval * TimeInterval) / 2;
        }
        static void GetCoordinateY(float VelocityY, float AccelerationY, float TimeInterval, ref float CoordinateY)
        {
            CoordinateY -= VelocityY - AccelerationY * (TimeInterval * TimeInterval) / 2;
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            //Equations of movement for X axes 
            GetForceX(DragCoefficient, VelocityX, out ForceX); //ForceX = DragCoefficient * VelocityX * VelocityX;
            GetAccelerationX(ForceX, Mass, out AccelerationX); //AccelerationX = -ForceX / Mass;
            GetVelocityX(AccelerationX, TimeInterval, ref VelocityX); //VelocityX += AccelerationX * TimeInterval;
            GetCoordinateX(VelocityX, AccelerationX, TimeInterval, ref CoordinateX); //CoordinateX += VelocityX + AccelerationX * (TimeInterval * TimeInterval) / 2;

            //Equations of movement for Y axes 
            GetForceForY(DragCoefficient, VelocityY, Mass, g, out ForceY); //ForceY = Mass * g - DragCoefficient * VelocityY * VelocityY;
            GetAccelerationY(ForceY, Mass, out AccelerationY); //AccelerationY = ForceY / Mass;
            GetVelocityY(AccelerationY, TimeInterval, ref VelocityY); //VelocityY -= AccelerationY * TimeInterval;
            GetCoordinateY(VelocityY, AccelerationY, TimeInterval, ref CoordinateY); //CoordinateY -=  VelocityY - AccelerationY * (TimeInterval * TimeInterval) / 2;

            // Rebound off the floor
            if (CoordinateY > 605)
            {
                VelocityY = -(VelocityY - (VelocityY/ 5));
                VelocityX = VelocityX - (VelocityX / 5);
                CoordinateY = 605;
            }
            // Rebound off the celling
            else if (CoordinateY < 0)
            {
                VelocityY = -(VelocityY - (VelocityY / 5));
                VelocityX = VelocityX - (VelocityX / 5);
                CoordinateY = 0;
            }
            // Rebound off the right wall
            else if (CoordinateX > 1275)
            {
                VelocityX = -(VelocityX - (VelocityX / 5));
                VelocityY = VelocityY - (VelocityY / 5);
                CoordinateX = 1275;
            }
            // Rebound off the left wall
            else if (CoordinateX < 0)
            {
                VelocityX = -(VelocityX - (VelocityX / 5));
                VelocityY = VelocityY - (VelocityY / 5);
                CoordinateX = 0;
            }
           

            pictureBox1.Refresh();
        }
        private void pictureBox1_Paint_1(object sender, PaintEventArgs e)   
        {
        
            e.Graphics.FillEllipse(Brushes.Green, CoordinateX, CoordinateY, 20, 20);
            e.Graphics.FillRectangle(Brushes.Gray, -10, 625, 2000, 10);
            
        }

        private void Stop_MouseClick(object sender, MouseEventArgs e)
        {
            timer1.Stop();
        }

        private void RefreshButton_MouseClick(object sender, MouseEventArgs e)
        {

            TimeInterval = 0.1f;
            CoordinateX = 0;
            CoordinateY = 605;
            Velocity = 0;
            VelocityY =0;
            VelocityX =0;
            AccelerationY =0;
            AccelerationX =0;
            ForceX =0;
            ForceY =0;
            DragCoefficient = 0.01f;
            g = 9.81f;
            angle = 0;
            Mass = 0;
            pictureBox1.Refresh();
        }
    }

}
