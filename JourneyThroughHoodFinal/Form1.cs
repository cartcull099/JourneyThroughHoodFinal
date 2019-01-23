using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.Media;

/// <summary>
/// Journey Through The hood adventure game, FINAL
/// Carter Culliton, Adam Monteith 
/// January 2019 
/// Mr. Theodoropolus
/// </summary>

namespace JourneyThroughHoodFinal
{
    public partial class JourneyHood : Form
    {
        //setting scene to scene 1, initalizing random generator, and sound player
        int scene = 1;
        Random randgen = new Random();
        SoundPlayer player;

        public JourneyHood()
        {
            InitializeComponent();
            player = new SoundPlayer(Properties.Resources.scream2);
        }

        //if, else statements for scene changes (Q key)
        private void JourneyHood_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Q)
            {
                if (scene == 1)
                {
                    scene = 2;
                }

                else if (scene == 2)
                {
                    scene = 3;
                }

                else if (scene == 3)
                {
                    scene = 1;
                }

                else if (scene == 4)
                {
                    scene = 5;
                }

                else if (scene == 5)
                {
                    scene = 1;
                }

                else if (scene == 6)
                {
                    scene = 7;
                }

                else if (scene == 7)
                {
                    scene = 1;
                }

                else if (scene == 8)
                {
                    scene = 9;
                }

                else if (scene == 9)
                {
                    scene = 1;
                }

                else if (scene == 10)
                {
                    scene = 11;
                }

                else if (scene == 11)
                {
                    scene = 1;
                }

                else if (scene == 12)
                {
                    scene = 13;
                }

                else if (scene == 13)
                {
                    scene = 14;
                }

                else if (scene == 14)
                {
                    scene = 1;
                }

                else if (scene == 15)
                {
                    scene = 1;
                }

                else if (scene == 16)
                {
                    scene = 17;
                }

                else if (scene == 17)
                {
                    scene = 1;
                }

                else if (scene == 18)
                {
                    scene = 1;
                }

                else if (scene == 19)
                {
                    scene = 20;
                }

                else if (scene == 20)
                {
                    scene = 1;
                }

                else if (scene == 21)
                {
                    scene = 22;
                }

                else if (scene == 22)
                {
                    scene = 1;
                }

                else if (scene == 23)
                {
                    scene = 24;
                }

                else if (scene == 24)
                {
                    scene = 1;
                }

                else if (scene == 25)
                {
                    scene = 26;
                }

                else if (scene == 26)
                {
                    scene = 1;
                }

                else if (scene == 27)
                {
                    scene = 28;
                }

                else if (scene == 28)
                {
                    scene = 1;
                }

                else if (scene == 29)
                {
                    scene = 30;
                }

                else if (scene == 30)
                {
                    scene = 31;
                }

                else if (scene == 31)
                {
                    scene = 1;
                }

                else if (scene == 32)
                {
                    scene = 1;
                }

                else if (scene == 33)
                {
                    scene = 34;
                }

                else if (scene == 34)
                {
                    scene = 1;
                }

                else if (scene == 35)
                {
                    scene = 1;
                }
            }

            //if, else statements for scene changes (W key)
            else if (e.KeyCode == Keys.W)
            {
                if (scene == 2)
                {
                    scene = 4;
                }

                else if (scene == 4)
                {
                    scene = 6;
                }

                else if (scene == 6)
                {
                    scene = 8;
                }

                else if (scene == 8)
                {
                    scene = 10;
                }

                else if (scene == 10)
                {
                    scene = 12;
                }

                else if (scene == 12)
                {
                    scene = 16;
                }

                else if (scene == 16)
                {
                    scene = 18;
                }

                else if (scene == 2)
                {
                    scene = 4;
                }

                else if (scene == 18)
                {
                    scene = 36;
                }

                else if (scene == 1)
                {
                    scene = 19;
                }

                else if (scene == 19)
                {
                    scene = 21;
                }

                else if (scene == 21)
                {
                    scene = 23;
                }

                else if (scene == 23)
                {
                    scene = 25;
                }

                else if (scene == 25)
                {
                    scene = 27;
                }

                else if (scene == 27)
                {
                    scene = 29;
                }

                else if (scene == 29)
                {
                    scene = 33;
                }

                else if (scene == 33)
                {
                    scene = 35;
                }

                else if (scene == 35)
                {
                    scene = 36;
                }

                else if (scene == 30)
                {
                    scene = 32;
                }

                else if (scene == 32)
                {
                    scene = 36;
                }

                else if (scene == 34)
                {
                    scene = 36;
                }

                else if (scene == 35)
                {
                    scene = 36;
                }

                else if (scene == 30)
                {
                    scene = 32;
                }

                else if (scene == 3)
                {
                    scene = 36;
                }

                else if (scene == 5)
                {
                    scene = 36;
                }

                else if (scene == 7)
                {
                    scene = 36;
                }

                else if (scene == 9)
                {
                    scene = 36;
                }

                else if (scene == 11)
                {
                    scene = 36;
                }

                else if (scene == 13)
                {
                    scene = 36;
                }

                else if (scene == 15)
                {
                    scene = 36;
                }

                else if (scene == 17)
                {
                    scene = 36;
                }

                else if (scene == 20)
                {
                    scene = 36;
                }

                else if (scene == 22)
                {
                    scene = 36;
                }

                else if (scene == 24)
                {
                    scene = 36;
                }

                else if (scene == 26)
                {
                    scene = 36;
                }

                else if (scene == 28)
                {
                    scene = 36;
                }

                else if (scene == 31)
                {
                    scene = 36;
                }
            }

            //Switch statements for scenes, images, sounds 
            switch (scene)
            {
                
                case 1:


                    SceneOut.Text = "You exit a party at 3 am and need to get home. You find a buspass and some shoes. Do you?";
                    qOutput.Text = "Take the Bus-pass";
                    wOutput.Text = "Take the Shoes";
                    label1.Image = Properties.Resources.party;
                    break;

                case 2:
                    SceneOut.Text = "A pregnent lady is unable to get on the bus, and needs a ticket. Do you?";
                    qOutput.Text = "Keep the ticket";
                    wOutput.Text = "Give it to her";
                    label1.Image = Properties.Resources.pregnant_lady;
                    break;

                case 3:
                    SceneOut.Text = "It blows up in your hand and you die a horrible death. Do you?";
                    qOutput.Text = "Play Again";
                    wOutput.Text = "Exit";
                    label1.Image = Properties.Resources.explode;
                    player.Play();
                    break;


                case 4:
                    SceneOut.Text = "You give her the ticket, which explodes. So you run and find keys and a skateboard. Do you?";
                    qOutput.Text = "Take the keys";
                    wOutput.Text = "Take the Skateboard";
                    label1.Image = Properties.Resources.board;
                    break;

                case 5:
                    SceneOut.Text = "You turn on the car and it explodes, and you die a horrible death. Do you?";
                    qOutput.Text = "Play Again";
                    wOutput.Text = "Exit";
                    label1.Image = Properties.Resources.fast8;
                    player.Play();
                    break;

                case 6:
                    SceneOut.Text = "You rip down the streets, chased by the cops. A chopper flies overhead with a rope hanging down. Do you?";
                    qOutput.Text = "Stay on the skateboard";
                    wOutput.Text = "Grab the rope";
                    label1.Image = Properties.Resources.heli;
                    break;

                case 7:
                    SceneOut.Text = "You are shot in the head and you die a horrible death. Do you?";
                    qOutput.Text = "Play Again";
                    wOutput.Text = "Exit";
                    label1.Image = Properties.Resources.gun;
                    player.Play();
                    break;

                case 8:
                    SceneOut.Text = "On the plane, you encounter the goon squad. You have one bullet. Do you?";
                    qOutput.Text = "Shoot Ethan";
                    wOutput.Text = "Shoot Julien";
                    label1.Image = Properties.Resources.goons;
                    break;

                case 9:
                    SceneOut.Text = "You kill Ethan but then must fight Julien so you die a horrible death. Do you?";
                    qOutput.Text = "Play Again";
                    wOutput.Text = "Exit";
                    label1.Image = Properties.Resources.Julien_Notte;
                    player.Play();
                    break;

                case 10:
                    SceneOut.Text = "You kill Julien, so now you have to fight Ethan. Do you?";
                    qOutput.Text = "Punch him";
                    wOutput.Text = "Spit on him";
                    label1.Image = Properties.Resources.zehr;
                    break;

                case 11:
                    SceneOut.Text = "You miss the punch and fall out of the chopper, so you die a horrible death. Do you?";
                    qOutput.Text = "Play Again";
                    wOutput.Text = "Exit";
                    label1.Image = Properties.Resources.falling;
                    player.Play();
                    break;

                case 12:
                    SceneOut.Text = "It kills him! You go to the cockpit, where you are met at gunpoint by Mr. Culliton. He offers a choice. Do you?";
                    qOutput.Text = "Jump out of the chopper";
                    wOutput.Text = "Eat rat poison";
                    label1.Image = Properties.Resources.cockpit;
                    break;

                case 13:
                    SceneOut.Text = "You land on Homie G-Dawg wearing a jetpack. He offers you a choice. Do you?";
                    qOutput.Text = "Drop a bomb on the police";
                    wOutput.Text = "Blow yourself up";
                    label1.Image = Properties.Resources.jet;
                    break;

                case 14:
                    SceneOut.Text = "You drop the bomb but it hits your foot and detonates, and you die a horrible death. Do you?";
                    qOutput.Text = "Play Again";
                    wOutput.Text = "Exit";
                    label1.Image = Properties.Resources.explode;
                    player.Play();
                    break;

                case 15:
                    SceneOut.Text = "You sacrifice yourself and die a horrible death. Do you?";
                    qOutput.Text = "Play Again";
                    wOutput.Text = "Exit";
                    label1.Image = Properties.Resources.explode;
                    player.Play();
                    break;

                case 16:
                    SceneOut.Text = "The poison gives you superpowers. Do you?";
                    qOutput.Text = "Save yourself and escape";
                    wOutput.Text = "Stop Mr. Culliton and the runaway chopper";
                    label1.Image = Properties.Resources.superpower;
                    break;

                case 17:
                    SceneOut.Text = "You save yourself by jumping out the chopper, but your powers deactivate, and you die a horrible death. Do you?";
                    qOutput.Text = "Play Again";
                    wOutput.Text = "Exit";
                    label1.Image = Properties.Resources.falling;
                    player.Play();
                    break;

                case 18:
                    SceneOut.Text = "You try to stop the chopper but it crashes and you die a horrible death. Do you?";
                    qOutput.Text = "Play Again";
                    wOutput.Text = "Exit";
                    label1.Image = Properties.Resources.chopper_explode;
                    player.Play();
                    break;

                case 19:
                    SceneOut.Text = "A homeless man threatens to kill you if you don't give him the shoes. Do you?";
                    qOutput.Text = "Give them away";
                    wOutput.Text = "Keep them";
                    label1.Image = Properties.Resources.Real_Homeless;
                    break;

                case 20:
                    SceneOut.Text = "He takes the shoes and then kicks you in the head so you die a horrible death. Do you?";
                    qOutput.Text = "Play Again";
                    wOutput.Text = "Exit";
                    label1.Image = Properties.Resources.face_kick;
                    player.Play();
                    break;

                case 21:
                    SceneOut.Text = "You run away and he chases you until you find a gun and a pencil. Do you?";
                    qOutput.Text = "Take the gun";
                    wOutput.Text = "Take the pencil";
                    label1.Image = Properties.Resources.gun_pencil;
                    break;

                case 22:
                    SceneOut.Text = "You qucik try and shoot but accidentally shoot yourself and you die a horrible death. Do you?";
                    qOutput.Text = "Play Again";
                    wOutput.Text = "Exit";
                    label1.Image = Properties.Resources.Dead;
                    player.Play();
                    break;

                case 23:
                    SceneOut.Text = "You stab the man and he drops a bag of drugs and a bomb before he dies. Do you?";
                    qOutput.Text = "Take the drugs";
                    wOutput.Text = "Take the bomb";
                    label1.Image = Properties.Resources.homelessdead;
                    break;

                case 24:
                    SceneOut.Text = "You open the bag and it unleashes carbon monoxide so you die a horrible death. Do you?";
                    qOutput.Text = "Play Again";
                    wOutput.Text = "Exit";
                    label1.Image = Properties.Resources.gas;
                    player.Play();
                    break;

                case 25:
                    SceneOut.Text = "There is a picture of a strip club on the bomb. Do you?";
                    qOutput.Text = "Bring it to the police";
                    wOutput.Text = "Bring it to the strip club";
                    label1.Image = Properties.Resources.package;
                    break;

                case 26:
                    SceneOut.Text = "You take it to the police but they shoot you on the spot. Do you?";
                    qOutput.Text = "Play Again";
                    wOutput.Text = "Exit";
                    label1.Image = Properties.Resources.cops;
                    player.Play();
                    break;

                case 27:
                    SceneOut.Text = "At the strip club you are stopped by the bouncer. Do you?";
                    qOutput.Text = "Detonate the bomb";
                    wOutput.Text = "Leave the club";
                    label1.Image = Properties.Resources.bouncer;
                    break;

                case 28:
                    SceneOut.Text = "The bomb blows up causing you to die a horrible death. Do you?";
                    qOutput.Text = "Play Again";
                    wOutput.Text = "Exit";
                    label1.Image = Properties.Resources.explode;
                    player.Play();
                    break;

                case 29:
                    SceneOut.Text = "While walking away you fall into a river, with a glowing cave at the bottom. Do you?";
                    qOutput.Text = "Swim towards it";
                    wOutput.Text = "Swim away from it";
                    label1.Image = Properties.Resources.cave;
                    break;

                case 30:
                    SceneOut.Text = "You find a cult of murderes, who want you to take the bomb to City hall. Do you?";
                    qOutput.Text = "Take the bomb";
                    wOutput.Text = "Fight the gang";
                    label1.Image = Properties.Resources.cult;
                    break;

                case 31:
                    SceneOut.Text = "You take the bomb to city hall, but are shot on the way so you die a horrible death. Do you?";
                    qOutput.Text = "Play Again";
                    wOutput.Text = "Exit";
                    label1.Image = Properties.Resources.shooting;
                    player.Play();
                    break;

                case 32:
                    SceneOut.Text = "You fight the cult but are drowned in the river and die a horrible death. Do you?";
                    qOutput.Text = "Play Again";
                    wOutput.Text = "Exit";
                    label1.Image = Properties.Resources.river;
                    player.Play();
                    break;

                case 33:
                    SceneOut.Text = "You arrive home to find c4 on the porch. Do you?";
                    qOutput.Text = "Throw it away";
                    wOutput.Text = "Take it inside";
                    label1.Image = Properties.Resources.c4;
                    break;

                case 34:
                    SceneOut.Text = "You throw it away and it detonates and you die a horrible death. Do you?";
                    qOutput.Text = "Play Again";
                    wOutput.Text = "Exit";
                    label1.Image = Properties.Resources.explode;
                    player.Play();
                    break;

                case 35:
                    SceneOut.Text = "You take it inside and it detonates and you die a horrible death. Do you?";
                    qOutput.Text = "Play Again";
                    wOutput.Text = "Exit";
                    label1.Image = Properties.Resources.house;
                    player.Play();
                    break;

                case 36:
                    Thread.Sleep(1000);
                    Close();
                    break;
            }
        }
    }
}
