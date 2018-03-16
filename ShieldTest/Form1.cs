using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace ShieldTest
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		#region "Global Variables"

		Pen MainPenGreen = new Pen(Color.Green);
		Pen MainPenOrange = new Pen(Color.Orange);
		Pen MainPenRed = new Pen(Color.Red);
		Pen MainPenBlack = new Pen(Color.Black);
		SolidBrush Decaybrush = new SolidBrush(Color.FromArgb(255,0,0,0));
		SolidBrush ShieldPen = new SolidBrush(Color.FromArgb(255,57,255,20));
		SolidBrush ShieldPenOrange = new SolidBrush(Color.FromArgb(255, 255, 191, 0));
		SolidBrush ShieldPenRed = new SolidBrush(Color.FromArgb(255, 255, 24, 24));
		SolidBrush ShieldPenBlack = new SolidBrush(Color.FromArgb(255, 0, 0, 0));
		Random Rand = new Random();


		bool decayShield = false;

		bool opening = true;

		bool playing = false;

		bool goodInput = false;

		//invader properties:
		bool dirLeft;
		bool dirRight;
		int amountEnemies = 10;
		int InvSpeed = 5;
		string InvSpeedTxt = "5";
		bool goingLeft = false;
		bool goingRight = true;


		//player properties:
		bool spacePressed = false;
		int points = 0;
		int playerMoveSpeed = 8;
		Point TankPos = new Point(375, 475);
		bool missileShot = false;
		bool shootable = true;
		bool isPressed;



		bool shieldAlive = true;
		int shieldDecay = 0;
		bool shouldDecay = false;


		const int DECAY_SIZE = 20;

		//Creates a List to store previous rectangles, so that upon refreshing the screen, the shield and prior decays are not erased.
		List<Rectangle> DecayStore = new List<Rectangle>();

		#endregion





		HelpMe frmHelpMe = new HelpMe();
		private void keyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Left || e.KeyCode == Keys.A)
			{
				dirLeft = true;
			}
			if(e.KeyCode == Keys.Right || e.KeyCode == Keys.D)
			{
				dirRight = true;
			}

			if (e.KeyCode == Keys.Space && shootable)
			{
				shootable = false;
				shoot();
				
			}
			if (e.KeyCode == Keys.H)
			{
				playing = false;
				frmHelpMe.Show();
				GameTimer.Stop();
				labelPaused.Show();
				labelHelp.Show();
			}
			if (e.KeyCode == Keys.P)
			{
				if (playing) {
					playing = false;
					GameTimer.Stop();
					labelPaused.Show();
					labelHelp.Show();

				} else if (!playing){
					playing = true;
					GameTimer.Start();
					labelPaused.Hide();
					labelHelp.Hide();
				}
				
			}
		}

		private void keyUp(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Left || e.KeyCode == Keys.A)
			{
				dirLeft = false;
			}
			if (e.KeyCode == Keys.Right || e.KeyCode == Keys.D)
			{
				dirRight = false;
			}
		}


		private void GameTimer_Tick(object sender, EventArgs e)
		{
			if (opening)
			{
				GameTimer.Stop();
				if (Int32.TryParse(Microsoft.VisualBasic.Interaction.InputBox("How fast would you like enemies to move? \n[Default is: 5] \nPlease set it to a value between 1 and 10.", "Invasion Speed", ""), out InvSpeed))
				{

					if (InvSpeed >= 0 && InvSpeed <= 10)
					{
						opening = false;
						label3.Text = "Diffic:" + InvSpeed;
						goodInput = true;
					}
					else
					{
						opening = true;
						GameTimer.Start();
					}
				}
				else
				{
					GameTimer.Start();
				}
			}
			if (goodInput)
			{
				label2.Text = "Points: " + points;
				TankPos = tank.Location;
				if (dirLeft)
				{
					tank.Location = new Point((tank.Location.X - playerMoveSpeed), 475);

				}
				else if (dirRight)
				{
					tank.Location = new Point((tank.Location.X + playerMoveSpeed), 475);
				}


				foreach (Control picInvader in this.Controls)
				{
					if (picInvader.Tag == "Invader" && picInvader is PictureBox)
					{
						if (((PictureBox)picInvader).Bounds.IntersectsWith(tank.Bounds))
						{
							endGame();
						}

						if (goingRight)
						{
							((PictureBox)picInvader).Location = new Point((((PictureBox)picInvader).Location.X + InvSpeed), ((PictureBox)picInvader).Location.Y);
						}
						else if (goingLeft)
						{
							((PictureBox)picInvader).Location = new Point((((PictureBox)picInvader).Location.X - InvSpeed), ((PictureBox)picInvader).Location.Y);
						}


						if (((PictureBox)picInvader).Location.X > 850)
						{
							goingLeft = true;
							goingRight = false;
							invadersDown();

						}
						if (((PictureBox)picInvader).Location.X < 0)
						{
							goingLeft = false;
							goingRight = true;
							invadersDown();
						}

					}

				}


				if (missileShot)
				{

					Missile.Show();
					Missile.Location = new Point((Missile.Location.X), (Missile.Location.Y - 20));
					label1.Text = "m:" + Missile.Location.Y;
					if (Missile.Location.Y <= -30)
					{
						Missile.Hide();
						Missile.Location = new Point(875, 530);
						missileShot = false;
						shootable = true;

					}


					if (Missile.Location.Y <= 383 && shieldAlive && Missile.Location.X >= 336 && Missile.Location.X <= 510)
					{
						Missile.Hide();
						Missile.Location = new Point(875, 530);
						missileShot = false;
						shootable = true;
						decayShield = true;
						Refresh();
						shouldDecay = true;

					}

				}

				foreach (Control picInv in this.Controls)
				{
					if (picInv is PictureBox && picInv.Tag == "Invader")
					{
						if (picInv.Bounds.IntersectsWith(Missile.Bounds))
						{
							points++;
							this.Controls.Remove(picInv);
							Missile.Hide();
							Missile.Location = new Point(875, 530);
							missileShot = false;
							shootable = true;
						}

					}

				}

				if (points >= amountEnemies)
				{
					GameTimer.Stop();
					MessageBox.Show("Victory!");

				}

			}
		}
		private void shoot()
		{
			Missile.Show();
			Missile.BringToFront();
			Missile.Location = new Point(tank.Location.X, (tank.Location.Y - 20));
			missileShot = true;
		}

		private void invadersDown()
		{
			//((PictureBox)picInvader).Location = new Point((((PictureBox)picInvader).Location.X), (((PictureBox)picInvader).Location.Y + 50 ));
			pictureBox2.Location = new Point(pictureBox2.Location.X, (pictureBox2.Location.Y + 50));
			pictureBox3.Location = new Point(pictureBox3.Location.X, (pictureBox3.Location.Y + 50));
			pictureBox4.Location = new Point(pictureBox4.Location.X, (pictureBox4.Location.Y + 50));
			pictureBox5.Location = new Point(pictureBox5.Location.X, (pictureBox5.Location.Y + 50));
			pictureBox6.Location = new Point(pictureBox6.Location.X, (pictureBox6.Location.Y + 50));
			pictureBox7.Location = new Point(pictureBox7.Location.X, (pictureBox7.Location.Y + 50));
			pictureBox8.Location = new Point(pictureBox8.Location.X, (pictureBox8.Location.Y + 50));
			pictureBox9.Location = new Point(pictureBox9.Location.X, (pictureBox9.Location.Y + 50));
			pictureBox10.Location = new Point(pictureBox10.Location.X, (pictureBox10.Location.Y + 50));
			pictureBox12.Location = new Point(pictureBox12.Location.X, (pictureBox12.Location.Y + 50));
		}

		private void endGame()
		{
			GameTimer.Stop();
			label1.Text = "Game over";


		}

		#region "Decay and Shield Drawing"
		private void Form1_Paint(object sender, PaintEventArgs e)
		{
			Graphics g = e.Graphics;

			//Main Shield creation:
			Point LTriL = new Point(370, 425);
			Point CubeLT = new Point((LTriL.X + 48), (LTriL.Y - 48));
			Point CubeRT = new Point((LTriL.X + 96), (LTriL.Y - 48));
			Point CubeBL = new Point((LTriL.X + 48), LTriL.Y);
			Point CubeBR = new Point((LTriL.X + 96), LTriL.Y);
			Point RTriR = new Point((LTriL.X + 144), LTriL.Y);



			Point[] MainShield =
			{
					LTriL,
					CubeLT,
					CubeRT,
					RTriR
				};


			if (shieldAlive)
			{
				//Changes colour of shield depending on its health.
				if (shieldDecay <= 10)
				{
					g.FillPolygon(ShieldPen, MainShield);
					g.DrawPolygon(MainPenGreen, MainShield);
					if (shouldDecay)
					{
						shieldDecay += 1;
						shouldDecay = false;
					}
				}
				else if (shieldDecay <= 20 && shieldDecay > 10)
				{
					g.FillPolygon(ShieldPenOrange, MainShield);
					g.DrawPolygon(MainPenOrange, MainShield);
					if (shouldDecay)
					{
						shieldDecay += 1;
						shouldDecay = false;
					}
				}
				else if (shieldDecay <= 30 && shieldDecay > 20)
				{
					g.FillPolygon(ShieldPenRed, MainShield);
					g.DrawPolygon(MainPenRed, MainShield);
					if (shouldDecay)
					{
						shieldDecay += 1;
						shouldDecay = false;
					}
				}
				else if (shieldDecay > 30)
				{
					
					g.FillPolygon(ShieldPenBlack, MainShield);
					g.DrawPolygon(MainPenBlack, MainShield);
					shieldAlive = false;
					Refresh();
				}


			}
			if (shieldAlive == false)
			{
				g.FillPolygon(ShieldPenBlack, MainShield);
				g.DrawPolygon(MainPenBlack, MainShield);
			}


			if (decayShield == true && shieldAlive)
			{
				//Decides whether to place the decay in the Left Triangle, Centre Square, or Right Triangle of the Trapezoid Shield
				switch(Rand.Next(1, 4))
					{
					case 1:
						//LTri
						//Splits the triangle into 3 cubes, to make life easier.
						switch (Rand.Next(1, 4))
						{
							case 1:
								Rectangle decayLTri1 = new Rectangle((LTriL.X + Rand.Next(12, 24)), (LTriL.Y - Rand.Next(0, 12)), DECAY_SIZE, DECAY_SIZE);
								this.DecayStore.Add(decayLTri1);
								//label1.Text = "Ltri1";
								break;

							case 2:
								Rectangle decayLTri2 = new Rectangle((LTriL.X + Rand.Next(24, 48)), (LTriL.Y - Rand.Next(0, 24)), DECAY_SIZE, DECAY_SIZE);
								this.DecayStore.Add(decayLTri2);
								//label1.Text = "Ltri2";
								break;

							case 3:
								Rectangle decayLTri3 = new Rectangle((LTriL.X + Rand.Next(36, 48)), (LTriL.Y - Rand.Next(24, 36)), DECAY_SIZE, DECAY_SIZE);
								this.DecayStore.Add(decayLTri3);
								//label1.Text = "Ltri3";
								break;

						}
						break;

					case 2:
						//Square
						Rectangle decayCube = new Rectangle((CubeLT.X + Rand.Next(0, 46)), (CubeLT.Y + Rand.Next(0, 26)), DECAY_SIZE, DECAY_SIZE);
						this.DecayStore.Add(decayCube);
						//label1.Text = "Cube";
						break;

					case 3:
						//RTri
						//Splits the triangle into 3 cubes, to make life easier.
						switch (Rand.Next(1, 4))
						{
							case 1:
								Rectangle decayRTri1 = new Rectangle((RTriR.X - Rand.Next(12, 24)), (RTriR.Y - Rand.Next(0, 12)), DECAY_SIZE, DECAY_SIZE);
								this.DecayStore.Add(decayRTri1);
								//label1.Text = "Rtri1";
								break;

							case 2:
								Rectangle decayRTri2 = new Rectangle((RTriR.X - Rand.Next(24, 48)), (RTriR.Y - Rand.Next(0, 24)), DECAY_SIZE, DECAY_SIZE);
								this.DecayStore.Add(decayRTri2);
								//label1.Text = "Rtri2";
								break;

							case 3:
								Rectangle decayRTri3 = new Rectangle((RTriR.X - Rand.Next(36, 48)), (RTriR.Y - Rand.Next(24, 36)), DECAY_SIZE, DECAY_SIZE);
								this.DecayStore.Add(decayRTri3);
								//label1.Text = "Rtri3";
								break;

						}
						break;
				}



				//Add the decay spot to the list of decay, so that upon invalidation and re-drawing, the decay will stay.
				

				g.FillRectangles(Decaybrush, DecayStore.ToArray());
				decayShield = false;
			}
		}




		private void Form1_Load(object sender, EventArgs e)
		{
		}


		#endregion
	}
}
