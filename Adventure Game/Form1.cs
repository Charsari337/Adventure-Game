using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.Threading;

namespace Adventure_Game
{
    public partial class Form1 : Form
    {
        Random ranGen = new Random();
        int scene = 0;
        public Form1()
        {
            InitializeComponent();

            scene = 0;

            
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.M) //redButt press.
            {
                if (scene == 0)
                {
                    scene = 1;
                }
                else if (scene == 1)
                {
                    scene = 3;
                }
                else if (scene == 2)
                {
                    scene = 99;
                }
                else if (scene == 3)
                {
                    scene = 4;
                }
                else if (scene == 4)
                {
                    scene = 7;
                }
                else if (scene == 5)
                {
                    scene = 99;
                }
                else if (scene == 6)
                {
                    scene = 99;
                }
                else if (scene == 7)
                {
                    scene = 8;
                }
                else if (scene == 8)
                {
                    scene = 9;
                }
                else if (scene == 9)
                {
                    scene = 11;
                }
                else if (scene == 10)
                {
                    scene = 23;
                }
                else if (scene == 11)
                {
                    scene = 13;
                }
                else if (scene == 12)
                {
                    scene = 15;
                }
                else if (scene == 13)
                {
                    scene = 0;
                }
                else if (scene == 14)
                {
                    scene = 0;
                }
                else if (scene == 15)
                {
                    scene = 17;
                }
                else if (scene == 16)
                {
                    scene = 19;
                }
                else if (scene == 17)
                {
                    scene = 0;
                }
                else if (scene == 18)
                {
                    scene = 0;
                }
                else if (scene == 19)
                {
                    scene = 0;
                }
                else if (scene == 20)
                {
                    scene = 21;
                }
                else if (scene == 21)
                {
                    scene = 0;
                }
                else if (scene == 22)
                {
                    scene = 3;
                }
                else if (scene == 23)
                {
                    scene = 0;
                }
                else if (scene == 24)
                {
                    scene = 0;
                }
                else if (scene == 25) //% thing here!
                {
                    Random ranGen = new Random();
                    int ranNum = ranGen.Next(1, 101);
                    if (ranNum >= 50) 
                    {
                        scene = 27;
                    }
                    else
                    {
                        scene = 28;
                    }
                    
                }
                else if (scene == 26)
                {
                    scene = 34;
                }
                else if (scene == 27)
                {
                    scene = 0;
                }
                else if (scene == 28)
                {
                    scene = 30;
                }
                else if (scene == 29)
                {
                    scene = 0;
                }
                else if (scene == 30)
                {
                    scene = 32;
                }
                else if (scene == 31)
                {
                    scene = 0;
                }
                else if (scene == 32)
                {
                    scene = 3;
                }
                else if (scene == 33)
                {
                    scene = 0;
                }
                else if (scene == 34)
                {
                    scene = 0;
                }
                else if (scene == 35)
                {
                    scene = 0;
                }
                else if (scene == 36)
                {
                    scene = 0;
                }
                else if (scene == 37)
                {
                    scene = 0;
                }
            }
            else if (e.KeyCode == Keys.B)
            {
                if (scene == 0)
                {
                    scene = 2;
                }
                else if (scene == 1)
                {
                    scene = 99;
                }
                else if (scene == 2)
                {
                    scene = 3;
                }
                else if (scene == 3)
                {
                    scene = 5;
                }
                else if (scene == 4)
                {
                    scene = 99;
                }
                else if (scene == 5)
                {
                    scene = 6;
                }
                else if (scene == 6)
                {
                    scene = 26;
                }
                else if (scene == 7)
                {
                    scene = 99;
                }
                else if (scene == 8) //Chance
                {
                    Random ranGen = new Random();
                    int ranNum = ranGen.Next(1, 101);
                    if (ranNum >= 25)
                    {
                        scene = 36;
                    }
                    else
                    {
                        scene = 10; 
                    }
                    
                }
                else if (scene == 9)
                {
                    scene = 12;
                }
                else if (scene == 10)
                {
                    scene = 24;
                }
                else if (scene == 11)
                {
                    scene = 14;
                }
                else if (scene == 12)
                {
                    scene = 16;
                }
                else if (scene == 13)
                {
                    scene = 11;
                }
                else if (scene == 14)
                {
                    scene = 3;
                }
                else if (scene == 15)
                {
                    scene = 18;
                }
                else if (scene == 16)
                {
                    scene = 20;
                }
                else if (scene == 17)
                {
                    scene = 15;
                }
                else if (scene == 18)
                {
                    scene = 3;
                }
                else if (scene == 19)
                {
                    scene = 16;
                }
                else if (scene == 20)
                {
                    scene = 22;
                }
                else if (scene == 21)
                {
                    scene = 99;
                }
                else if (scene == 22)
                {
                    scene = 99;
                }
                else if (scene == 23)
                {
                    scene = 3;
                }
                else if (scene == 24)
                {
                    scene = 10;
                }
                else if (scene == 25) //% thing here!
                {
                    scene = 29;
                }
                else if (scene == 26)
                {
                    scene = 35;
                }
                else if (scene == 27)
                {
                    scene = 99;
                }
                else if (scene == 28)
                {
                    scene = 37;
                }
                else if (scene == 29)
                {
                    scene = 25;
                }
                else if (scene == 30)
                {
                    scene = 31;
                }
                else if (scene == 31)
                {
                    scene = 30;
                }
                else if (scene == 32)
                {
                    scene = 33;
                }
                else if (scene == 33)
                {
                    scene = 99;
                }
                else if (scene == 34)
                {
                    scene = 26;
                }
                else if (scene == 35)
                {
                    scene = 26;
                }
                else if (scene == 36)
                {
                    scene = 8;
                }
                else if (scene == 37)
                {
                    scene = 28;
                }
            }

            switch (scene)
            {
                case 0:
                    pictureBox1.BackgroundImage = Properties.Resources.scene_0_opening;
                    outputlabel.Text = "You and 5 of your friends find yourselves running around your school at night.";
                    Refresh();
                    Thread.Sleep(3000);
                    outputlabel.Text += "\n...When you first entered the school did you stay as one whole group or split into two?";
                    redButtLabel.Text = "Stay together.";
                    blueButtLabel.Text = "Split into two groups.";
                    break;
                case 1:
                    pictureBox1.BackgroundImage = Properties.Resources.scene_stay_together;
                    outputlabel.Text = "All of you think it is best to stay all together to make sure no one is trying to mess with the others.";
                    redButtLabel.Text = "Continue";
                    blueButtLabel.Text = "";
                    break;
                case 2:
                    pictureBox1.BackgroundImage = Properties.Resources.scene_1;
                    outputlabel.Text = "You split into two groups.";
                    redButtLabel.Text = "Continue.";
                    blueButtLabel.Text = "";
                    break;
                case 3:
                    pictureBox1.BackgroundImage = Properties.Resources.scene_3;
                    outputlabel.Text = "Your school has 2 floors. Which one do you go to first with your group?";
                    redButtLabel.Text = "Continue on the first floor.";
                    blueButtLabel.Text = "Explore the second floor.";
                    break;
                case 4:
                    pictureBox1.BackgroundImage = Properties.Resources.scene_4;
                    outputlabel.Text = "You and your group decided to continue on the first floor.";
                    Refresh();
                    Thread.Sleep(3000);
                    outputlabel.Text += "\n...Press red to continue.";
                    redButtLabel.Text = "Continue.";
                    blueButtLabel.Text = "";
                    break;
                case 5:
                    pictureBox1.BackgroundImage = Properties.Resources.scene_5;
                    outputlabel.Text = "You and your group decided to check the second floor first.";
                    Refresh();
                    Thread.Sleep(3000);
                    outputlabel.Text = "\n...Press red tow continue.";
                    redButtLabel.Text = "Continue.";
                    blueButtLabel.Text = "";
                    break;
                case 6:
                    pictureBox1.BackgroundImage = Properties.Resources.scene_6;
                    outputlabel.Text = "The second floor has the legend about the school's library. If you enter the library and throw a book over a shelf, the night librarian will throw it back over and hunt down those in the library.";
                    Refresh();
                    Thread.Sleep(5000);
                    outputlabel.Text = "...Once in the library, there is a single table lamp on. You all want to see if the librarian is real so you choose to throw the book. Who do you choose to throw the book? You or another friend?";
                    redButtLabel.Text = "You throw it.";
                    blueButtLabel.Text = "Have someone else.";
                    break;
                case 7:
                    pictureBox1.BackgroundImage = Properties.Resources.scene_7;
                    outputlabel.Text = "The urban legend that is said to be on the first floor exists in the gym.";
                    redButtLabel.Text = "Continue.";
                    blueButtLabel.Text = "";
                    break;
                case 8:
                    pictureBox1.BackgroundImage = Properties.Resources.scene_8;
                    outputlabel.Text = "It is said that the gym houses 4 ghosts; 3 sports students and 1 gym teacher. There are two possibilities when entering the gym. Either you are approached by the 3 students or caught by the teacher.";
                    Refresh();
                    Thread.Sleep(5000);
                    outputlabel.Text = "...You find at the center of the gym there is a dodgeball and a basket ball. You go over to pick them up. Which of the two do you pickup?";
                    redButtLabel.Text = "Dodgeball.";
                    blueButtLabel.Text = "Basket Ball.";
                    break;
                case 9:
                    pictureBox1.BackgroundImage = Properties.Resources.scene_7;
                    outputlabel.Text = "Upon picking up the dodgeball your group hears that gym doors close. You turn to see the three students standing in your way.";
                    Refresh();
                    Thread.Sleep(3000);
                    outputlabel.Text += "...Do you run or stay composed?";
                    redButtLabel.Text = "Run away!";
                    blueButtLabel.Text = "Don't move and stay calm";
                    break;
                case 10:
                    pictureBox1.BackgroundImage = Properties.Resources.scene_10;
                    outputlabel.Text = "When you pick up the basket ball the storage room opens. You hear footsteps walking towards you but don't see anything.";
                    Refresh();
                    Thread.Sleep(3000);
                    outputlabel.Text = "...Do you run or stay composed?";
                    redButtLabel.Text = "Run away.";
                    blueButtLabel.Text = "Don't move and stay calm.";
                    break;
                case 11:
                    pictureBox1.BackgroundImage = Properties.Resources.scene_11;
                    outputlabel.Text = "Everyone one decides to start running away from the ghosts however looking behind you, you see that you are being chased.";
                    Refresh();
                    Thread.Sleep(5000);
                    outputlabel.Text = "You have to lose the ghosts but how? You can either find places to hide or find another exit. ";
                    redButtLabel.Text = "Hide.";
                    blueButtLabel.Text = "Find an different exit.";
                    break;
                case 12:
                    pictureBox1.BackgroundImage = Properties.Resources.scene_12;
                    outputlabel.Text = "You tell your group not to move. The three ghosts begin to approach you. Once the distance has closed they ask if you want to play a game.";
                    Refresh();
                    Thread.Sleep(3500);
                    outputlabel.Text = "\n...Do you agree to play or try to get out?";
                    redButtLabel.Text = "Agree to play.";
                    blueButtLabel.Text = "Try to get out.";
                    break;
                case 13:
                    pictureBox1.BackgroundImage = Properties.Resources.death_end;
                    outputlabel.Text = "You and the others decide to find places to hide. However hiding proved to be useless and you all were killed.";
                    Refresh();
                    Thread.Sleep(3000);
                    outputlabel.Text += "\n...Restart or go back an event?";
                    redButtLabel.Text = "Restart";
                    blueButtLabel.Text = "Roll back.";
                    break;
                case 14:
                    pictureBox1.BackgroundImage = Properties.Resources.scene_14;
                    outputlabel.Text = "A member of your group says there is an exit in the back of the stage so you break for the stage. The stage exit was unlocked and your group was able to escape.";
                    Refresh();
                    Thread.Sleep(3500);
                    outputlabel.Text += "\n...Even after escaping do you want to go back in and explore?";
                    redButtLabel.Text = "Leave and go home safe.";
                    blueButtLabel.Text = "Continue exploring.";
                    break;
                case 15:
                    pictureBox1.BackgroundImage = Properties.Resources.scene_15;
                    outputlabel.Text = "You agreed to play a game of dodgeball with them. Your group is on edge and questions how they should play the game?";
                    Refresh();
                    Thread.Sleep(500);
                    outputlabel.Text += "\n...Play to win or play to lose?";
                    redButtLabel.Text = "Play to win.";
                    blueButtLabel.Text = "play to lose.";
                    break;
                case 16:
                    pictureBox1.BackgroundImage = Properties.Resources.scene_16;
                    outputlabel.Text = "You try to make excuse such as running late for class and only checking out the place.  ";
                    Refresh();
                    Thread.Sleep(500);
                    outputlabel.Text += "\n...What excuse do you make as a group? You are running late for class or you are checking out the gym.";
                    redButtLabel.Text = "Pretend you are running late for class.";
                    blueButtLabel.Text = "Say that your are just checking out the gym.";
                    break;
                case 17:
                    pictureBox1.BackgroundImage = Properties.Resources.death_end;
                    outputlabel.Text = "You come to the conclusion that you must win to live. The game doesn't last long ending in a complete victory for you! Your group however is killed as the three students call over the gym teacher... slaughtering you.";

                    outputlabel.Text += "\n...Restart or go back an event?";
                    redButtLabel.Text = "Restart.";
                    blueButtLabel.Text = "Roll back.";
                    break;
                case 18:
                    pictureBox1.BackgroundImage = Properties.Resources.Live;
                    outputlabel.Text = "Your group is uncertain about whether they can beat ghosts in a game. Feeling doubtful throughout the whole thing you lose. Now that the game is over you fear for what might happen next, but the three ghosts step aside and the doors open. You are allowed to leave and exit the school.";
                    Refresh();
                    Thread.Sleep(500);
                    outputlabel.Text += "\n...Spared by the ghosts of the gym do you still feel you you continue exploring?";
                    redButtLabel.Text = "Leave.";
                    blueButtLabel.Text = "Continue.";
                    break;
                case 19:
                    pictureBox1.BackgroundImage = Properties.Resources.death_end;
                    outputlabel.Text = "You group lies about running late for class. The ghosts grin at you and yell of the gym teacher. Who you can only hear get closer to you but cannot see promptly killing you all.";
                    Refresh();
                    Thread.Sleep(500);
                    outputlabel.Text += "\n...Restart or go back an event?";
                    redButtLabel.Text = "Restart.";
                    blueButtLabel.Text = "Roll back.";
                    break;
                case 20:
                    pictureBox1.BackgroundImage = Properties.Resources.Live;
                    outputlabel.Text = "You say you are only taking a quick look at the gym. The three ghosts slowly disappear after hearing that.";
                    Refresh();
                    Thread.Sleep(500);
                    outputlabel.Text += "\n...Do you and your group leave the building or continue?";
                    redButtLabel.Text = "Leave.";
                    blueButtLabel.Text = "Continue exploring.";
                    break;
                case 21:
                    pictureBox1.BackgroundImage = Properties.Resources.leaving;
                    outputlabel.Text = "Completely scared you decided with your group to leave now that you are safe.";
                    Refresh();
                    Thread.Sleep(3500);
                    redButtLabel.Text = "Restart";
                    blueButtLabel.Text = "";
                    break;
                case 22:
                    pictureBox1.BackgroundImage = Properties.Resources._continue;
                    outputlabel.Text = "You feel that you all still have some courage left in you so you continue to the other floors.";
                    Refresh();
                    Thread.Sleep(3500);
                    redButtLabel.Text = "Continue.";
                    blueButtLabel.Text = "";
                    break;
                case 23:
                    pictureBox1.BackgroundImage = Properties.Resources.Live;
                    outputlabel.Text = "Running away through where you entered you look back to find you are safe.";
                    Refresh();
                    Thread.Sleep(500);
                    outputlabel.Text += "\n...Do you and your group still have the courage to continue or do you never come back to the school past school hours.";
                    redButtLabel.Text = "Leave.";
                    blueButtLabel.Text = "Continue.";
                    break;
                case 24:
                    pictureBox1.BackgroundImage = Properties.Resources.death_end;
                    outputlabel.Text = "Staying still gets you killed. You are never able to see the what it was but could hear it get quieter as you die.";
                    Refresh();
                    Thread.Sleep(500);
                    outputlabel.Text += "\n...Restart or go back an event?";
                    redButtLabel.Text = "Restart.";
                    blueButtLabel.Text = "Roll back.";
                    break;
                case 25:
                    pictureBox1.BackgroundImage = Properties.Resources.scene_17;
                        outputlabel.Text = "You choose to throw the book yourself, tossing it over the shelf you picked the book from. Once it lands you hear a distant scream. You look back to the shelf and find at its foot that the book is on your side.";
                        Refresh();
                        Thread.Sleep(500);
                        outputlabel.Text = "Everyone is scared but what do you do? Do you try to hide in the library or run away?";
                        redButtLabel.Text = "Get everyone together.";
                        blueButtLabel.Text = "Run away!";
                    break;
                case 26:
                    pictureBox1.BackgroundImage = Properties.Resources.scene_24;
                    outputlabel.Text = "One of your friends throws the book over and you hear and hear a distant scream. Looking back at the self you find the book is now on your side at the foot of the shelf. The friend who threw the book becomes too freaked out and runs towards the entrance but is caught but the librarian.";
                    Refresh();
                    Thread.Sleep(500);
                    outputlabel.Text += "\n...Seeing your friend die you all panic. Do you try to keep everyone together or try to run the library?";
                    redButtLabel.Text = "Get everyone together.";
                    blueButtLabel.Text = "Run away";
                    break;
                case 27:
                    pictureBox1.BackgroundImage = Properties.Resources.hoax;
                    outputlabel.Text = "The other group of friends jump out and scare you. Looks like it was all a hoax.";
                    outputlabel.Text += "\n...Restart?";
                    redButtLabel.Text = "Restart.";
                    blueButtLabel.Text = "";
                    break;
                case 28:
                    pictureBox1.BackgroundImage = Properties.Resources.scene_28;
                    outputlabel.Text = "You tell everyone to hide, finding different places. Look out to where you are hiding and see your friend across from you. The librarian picks up the book and looks around.";
                    Refresh();
                    Thread.Sleep(5500);
                    outputlabel.Text = "They begin towards your friend's hiding spot but they can't get out.";
                    outputlabel.Text += "\n...Do you save your friend or watch them die?";
                    redButtLabel.Text = "Save them.";
                    blueButtLabel.Text = "Let them die.";
                    break;
                case 29:
                    pictureBox1.BackgroundImage = Properties.Resources.death_end;
                    outputlabel.Text = "You all try to flee but the librarian is right at the entrance blocking your path. You all die and are stuffed into the selves.";
                    Refresh();
                    Thread.Sleep(500);
                    outputlabel.Text += "\n...Restart or go back an event?";
                    redButtLabel.Text = "Restart";
                    blueButtLabel.Text = "Roll back.";
                    break;
                case 30:
                    pictureBox1.BackgroundImage = Properties.Resources.scene_30;
                    outputlabel.Text = "You decide to save them but how will you do it? Will you make yourself a distraction or throw something?";
                    redButtLabel.Text = "Be a distraction.";
                    blueButtLabel.Text = "Throw a book.";
                    break;
                case 31:
                    pictureBox1.BackgroundImage = Properties.Resources.death_end;
                    outputlabel.Text = "You decide to throw a book somewhere else. Once it is in the air the librarian screams but starts bolting towards you. You are killed but your friend was able to escape.";
                    Refresh();
                    Thread.Sleep(500);
                    outputlabel.Text += "\n...Restart or go back an event?";
                    redButtLabel.Text = "Restart.";
                    blueButtLabel.Text = "Roll back.";
                    break;
                case 32:
                    pictureBox1.BackgroundImage = Properties.Resources.Live;
                    outputlabel.Text = "You decide to get up and start running, grabbing the attention of the librarian who doesn't quite understand. This however allows your friend to slip out of their spot and you all leave the building.";
                    Refresh();
                    Thread.Sleep(500);
                    outputlabel.Text += "\n...You and your friends make it out of the library alive but do you think you should continue to explore?";
                    redButtLabel.Text = "Continue.";
                    blueButtLabel.Text = "Stop exploring.";
                    break;
                case 33:
                    pictureBox1.BackgroundImage = Properties.Resources.leaving;
                    outputlabel.Text = "You all decide that you should go back home.";
                    redButtLabel.Text = "Restart.";
                    blueButtLabel.Text = "";
                    break;
                case 34:
                    pictureBox1.BackgroundImage = Properties.Resources.death_end;
                    outputlabel.Text = "You try to keep everyone together, running to find a place to hide. The librarian already has seen you though and kills all of you.";
                    Refresh();
                    Thread.Sleep(500);
                    outputlabel.Text = "Restart or go back an event?";
                    redButtLabel.Text = "Restart.";
                    blueButtLabel.Text = "Roll back.";
                    break;
                case 35:
                    pictureBox1.BackgroundImage = Properties.Resources.scene_32;
                    outputlabel.Text = "Everyone is frozen but you find the strength to move, leaving behind your friends. You hide away trying to monitor the librarian. Eventually you make it out but only you.";
                    Refresh();
                    Thread.Sleep(500);
                    outputlabel.Text = "Restart or go back an event?";
                    redButtLabel.Text = "Restart.";
                    blueButtLabel.Text = "Roll back.";
                    break;
                case 36:
                    pictureBox1.BackgroundImage = Properties.Resources.hoax;
                    outputlabel.Text = "The other group of friends walk out. You all laugh at the thought that there would actually be a ghost. So I guess it was just a hoax.";
                    Refresh();
                    Thread.Sleep(500);
                    outputlabel.Text = "Restart or go back an event?";
                    redButtLabel.Text = "Restart.";
                    blueButtLabel.Text = "Roll back.";
                    break;
                case 37:
                    pictureBox1.BackgroundImage = Properties.Resources.death_end;
                    outputlabel.Text = "You can't get yourself to save them and so you watch them die. You would then become the next target and die as well.";
                    Refresh();
                    Thread.Sleep(500);
                    outputlabel.Text += "\n...Restart or go back an event?";
                    redButtLabel.Text = "Restart.";
                    blueButtLabel.Text = "Roll back.";
                    break;
            }
        }

      
    }
}
