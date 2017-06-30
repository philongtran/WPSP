using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

namespace Meine_Fußball_Mannschaft
{
    public partial class Form1 : Form
    {
        private readonly IEnumerable<XElement> _player;
        private readonly Squad _squad;
        private Player _currentPlayer;

        public Form1()
        {
            InitializeComponent();

            try
            {
                var playerXml = XElement.Load(@"Resources\SpielerData.xml");
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
                Console.WriteLine(ex.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        private void UpdatePlayer(Player s)
        {
            t_name.Text = s.Name;
            t_vorname.Text = s.Vorname;
            t_position.Text = s.Position;
            t_nummer.Text = s.Rueckennummer;
            t_seit.Text = s.Seit;
            t_geboren.Text = s.GeburtsDatum;
            t_groesse.Text = s.GroesseInCm;
            t_gewicht.Text = s.GewichtInKg;
            t_spieletore.Text = s.SpieleInBundesliga + " / " + s.ToreInBundesliga;
            t_nation.Text = s.Nation;
            t_laenderspiele.Text = s.Laenderspiele;
            _currentPlayer = s;

            try
            {
                var size = new Size(218, 327);
                var playerBitmap = new Bitmap(@"Resources\" + s.Bild, true);
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

        private void ShowPlayerList()
        {
            c_box.DataSource = _squad.PlayerList;
            c_box.DisplayMember = "nameGesamt";
            c_box.SelectedIndex = _squad.PlayerList.IndexOf(_currentPlayer);
        }

        private void LastPlayer()
        {
            UpdatePlayer(_squad.PlayerList.Last());
            ShowPlayerList();
            b_next.Enabled = false;
            b_last.Enabled = false;
        }

        private void FirstPlayer()
        {
            UpdatePlayer(_squad.PlayerList[0]);
            ShowPlayerList();
            b_previous.Enabled = false;
            b_first.Enabled = false;
        }

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