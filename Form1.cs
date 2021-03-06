﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

// Phi Long Tran <191624>, Viet Cuong Nguyen <191515>, Manuel Wessner <191711>
namespace Meine_Fußball_Mannschaft
{   
    /// <summary>
    /// UI logic
    /// </summary>
    public partial class Form1 : Form
    {   
        /// <summary>
        /// XML file which contains all information about the players
        /// </summary>
        private readonly IEnumerable<XElement> _player;

        /// <summary>
        /// list of all player objects from the same club
        /// </summary>
        private readonly Squad _squad;

        /// <summary>
        /// currently selected player in UI
        /// </summary>
        private Player _currentPlayer;

        /// <summary>
        /// base path of player data
        /// </summary>
        private const string BasePath = @"Resources\Players\";

        /// <summary>
        /// default constructor
        /// </summary>
        public Form1()
        {
            InitializeComponent();
            

            try
            {
                var playerXml = XElement.Load(BasePath + "SpielerData.xml");
                _player = playerXml.Element("SpielerListe").Elements("Spieler");
            }
            catch (XmlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (NullReferenceException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            _squad = new Squad();

            try
            {
                foreach (var element in _player)
                {
                    var player = new Player();
                    player.Name = element.Element("Name").Value;
                    player.Vorname = element.Element("Vorname").Value;
                    player.Bild = player.Name + " " + player.Vorname + ".jpg";
                    player.Position = element.Element("Position").Value.ToUpper();
                    player.Rueckennummer = element.Element("Rueckennummer").Value;
                    player.Seit = element.Element("Seit").Value;
                    player.GeburtsDatum = element.Element("GeburtsDatum").Value;
                    player.GroesseInCm = element.Element("GroesseInCm").Value;
                    player.GewichtInKg = element.Element("GewichtInKg").Value;
                    player.SpieleInBundesliga = element.Element("SpieleInBundesliga").Value;
                    player.ToreInBundesliga = element.Element("ToreInBundesliga").Value;
                    player.Nation = element.Element("Nation").Value;
                    player.Laenderspiele = element.Element("Laenderspiele").Value;
                    player.NameGesamt = player.Vorname + " " + player.Name;
                    _squad.PlayerList.Add(player);
                }
                FirstPlayer();
            }
            catch (NullReferenceException ex)
            {
                b_next.Enabled = false;
                b_last.Enabled = false;
                b_previous.Enabled = false;
                b_first.Enabled = false;
                c_box.Enabled = false;
                Console.WriteLine(ex.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        /// <summary>
        /// when switching to a new player, loads all information and image belonging to a this player 
        /// </summary>
        /// <param name="player"> chosen player </param>
        private void UpdatePlayer(Player player)
        {
            t_name.Text = player.Name;
            t_vorname.Text = player.Vorname;
            t_position.Text = player.Position;
            t_nummer.Text = player.Rueckennummer;
            t_seit.Text = player.Seit;
            t_geboren.Text = player.GeburtsDatum;
            t_groesse.Text = player.GroesseInCm;
            t_gewicht.Text = player.GewichtInKg;
            t_spieletore.Text = player.SpieleInBundesliga + " / " + player.ToreInBundesliga;
            t_nation.Text = player.Nation;
            t_laenderspiele.Text = player.Laenderspiele;
            _currentPlayer = player;

            try
            {
                var size = new Size(218, 327);
                var playerBitmap = new Bitmap(BasePath + player.Bild, true);
                var resizedPlayerBitmap = new Bitmap(playerBitmap, size); // resize pictures
                p_box.Image = resizedPlayerBitmap;
            }
            catch (ArgumentException ex)
            {
                p_box.Image = null;
                Console.WriteLine(ex.Message);
            }
            catch (NullReferenceException ex)
            {
                p_box.Image = null;
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                p_box.Image = null;
                Console.WriteLine(ex.Message);
            }
        }

        /// <summary>
        /// shows the complete name of all players in the combo box
        /// </summary>
        private void ShowPlayerList()
        {
            c_box.DataSource = _squad.PlayerList;
            c_box.DisplayMember = "nameGesamt";
            c_box.SelectedIndex = _squad.PlayerList.IndexOf(_currentPlayer);
        }

        /// <summary>
        /// switches to the last player of the list
        /// </summary>
        private void LastPlayer()
        {
            UpdatePlayer(_squad.PlayerList.Last());
            ShowPlayerList();
            b_next.Enabled = false;
            b_last.Enabled = false;
        }

        /// <summary>
        /// switches to the first player of the list
        /// </summary>
        private void FirstPlayer()
        {
            UpdatePlayer(_squad.PlayerList[0]);
            ShowPlayerList();
            b_previous.Enabled = false;
            b_first.Enabled = false;
        }

        /// <summary>
        /// event listener for the combo box
        /// </summary>
        /// <param name="sender"> c_box </param>
        /// <param name="e"> triggered event </param>
        private void c_box_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!b_previous.Enabled && !b_first.Enabled)
            {
                b_previous.Enabled = true;
                b_first.Enabled = true;
            }

            if (!b_next.Enabled && !b_last.Enabled)
            {
                b_next.Enabled = true;
                b_last.Enabled = true;
            }

            var selectedIndex = c_box.SelectedIndex;

            try
            {
                if (selectedIndex == 0)
                {
                    b_previous.Enabled = false;
                    b_first.Enabled = false;
                }
                if (selectedIndex == _squad.PlayerList.Count - 1)
                {
                    b_next.Enabled = false;
                    b_last.Enabled = false;
                }
                UpdatePlayer(_squad.PlayerList[selectedIndex]);
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        /// <summary>
        /// event listener for the next button
        /// </summary>
        /// <param name="sender"> b_next </param>
        /// <param name="e"> triggered event </param>
        private void b_next_Click(object sender, EventArgs e)
        {
            if (!b_previous.Enabled && !b_first.Enabled)
            {
                b_first.Enabled = true;
                b_previous.Enabled = true;
            }
            var indexOf = _squad.PlayerList.IndexOf(_currentPlayer);

            try
            {
                if (indexOf < _squad.PlayerList.Count - 1)
                    UpdatePlayer(_squad.PlayerList[indexOf + 1]);
                else
                    LastPlayer();
                ShowPlayerList();
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        /// <summary>
        /// event listener for the previous button
        /// </summary>
        /// <param name="sender"> b_previous </param>
        /// <param name="e"> triggered event </param>
        private void b_previous_Click(object sender, EventArgs e)
        {
            if (!b_next.Enabled && !b_last.Enabled)
            {
                b_last.Enabled = true;
                b_next.Enabled = true;
            }
            var indexOf = _squad.PlayerList.IndexOf(_currentPlayer);
            try
            {
                if (indexOf > 0)
                    UpdatePlayer(_squad.PlayerList[indexOf - 1]);
                else
                    FirstPlayer();
                ShowPlayerList();
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        /// <summary>
        /// event listener for the last button
        /// </summary>
        /// <param name="sender"> b_last </param>
        /// <param name="e"> triggered event </param>
        private void b_last_Click(object sender, EventArgs e)
        {
            if (!b_previous.Enabled && !b_first.Enabled)
            {
                b_first.Enabled = true;
                b_previous.Enabled = true;
            }
            try
            {
                LastPlayer();
                ShowPlayerList();
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        /// <summary>
        /// event listener for the first button
        /// </summary>
        /// <param name="sender"> b_first </param>
        /// <param name="e"> triggered event </param>
        private void b_first_Click(object sender, EventArgs e)
        {
            if (!b_next.Enabled && !b_last.Enabled)
            {
                b_last.Enabled = true;
                b_next.Enabled = true;
            }
            try
            {
                FirstPlayer();
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}