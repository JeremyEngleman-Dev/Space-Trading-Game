using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Space_Station
{
    public partial class GameForm : Form
    {
        public GameForm()
        {
            bool EquipmentC = false;
            int EQ = 0;
            int totalCost = 0;

            Random random = new Random();

            Player player;
            Station station;
            Ship ship;
            List<Ship> shiplist = new List<Ship>();
            List<Events> ActiveEvents = new List<Events>();

            InitializeComponent();
            NewPlayer();
            NewStation();

            this.Size = new Size(788, 464);

            //Form defaults and settings
            WaresLV.View = View.Details;
            WaresLV.FullRowSelect = true;
            WaresLVP.View = View.Details;
            WaresLVP.FullRowSelect = true;
            DealerList.View = View.Details;
            DealerList.FullRowSelect = true;

            //Prevent column width changes in both ListViews
            WaresLV.ColumnWidthChanging += new ColumnWidthChangingEventHandler(WaresLV_ColumnWidthChanging);

            void WaresLV_ColumnWidthChanging(object sender, ColumnWidthChangingEventArgs e)
            {
                e.Cancel = true;
                e.NewWidth = WaresLV.Columns[e.ColumnIndex].Width;
            }

            WaresLVP.ColumnWidthChanging += new ColumnWidthChangingEventHandler(WaresLVP_ColumnWidthChanging);

            void WaresLVP_ColumnWidthChanging(object sender, ColumnWidthChangingEventArgs e)
            {
                e.Cancel = true;
                e.NewWidth = WaresLVP.Columns[e.ColumnIndex].Width;
            }

            DealerList.ColumnWidthChanging += new ColumnWidthChangingEventHandler(DealerList_ColumnWidthChanging);

            void DealerList_ColumnWidthChanging(object sender, ColumnWidthChangingEventArgs e)
            {
                e.Cancel = true;
                e.NewWidth = DealerList.Columns[e.ColumnIndex].Width;
            }

            //Event handlers for main buttons
            JumpButton.Click += new EventHandler(JumpButton_Click);
            FuelButton.Click += new EventHandler(FuelButton_Click);

            //Fuel button clicked
            void FuelButton_Click(object sender, EventArgs e)
            {
                FuelBoxAmount.Text = "1";
                MenuView("Fuel", true);
            }

            //Jump button clicked
            void JumpButton_Click(object sender, EventArgs e)
            {
                if (ship.FuelCurrent >= ship.FuelBurn)
                {
                    FuelAdjust(ship.FuelBurn, false);
                    player.TotalJumps += 1;
                    NewStation();
                }
                else
                {
                    MessageBox.Show("You do not have enough fuel to jump");
                }
            }

            //Generate new station
            void NewStation()
            {
                WaresLV.Items.Clear();
                EquipmentC = false;

                station = new Station();
                StationLabel.Text = station.Name;
                station.FuelPrice = random.Next(2, 12);
                station.FuelStock = random.Next(100, 500);

                //Initially hide sub menus
                MenuView("Equipment", false);
                MenuView("Ships", false);
                MenuView("Fuel", false);
                MenuView("Buy", false);
                MenuView("Sell", false);

                if (player.TotalJumps >= 50)
                {
                    int jumps = player.TotalJumps;
                    double fuelprice = 0;
                    double wareamount = 0;
                    while (jumps >= 50)
                    {
                        jumps -= 50;
                        fuelprice += 0.5;
                        wareamount += 4;
                    }
                    station.FuelPrice += (int)(fuelprice * station.FuelPrice);
                    station.FuelStock += (int)(fuelprice * station.FuelStock);
                    for (int i = 0; i < station.StationStock.Count; i++)
                    {
                        station.StationStock[i].Amount += (int)(wareamount * station.StationStock.Count);
                    }
                }

                FuelCost.Text = string.Format("Fuel Price: {0}", station.FuelPrice);
                FuelAmount.Text = string.Format("{0}", station.FuelStock);
                FuelBoxAmount.Text = "1";

                ChanceOnEquipment();
                ListViewRefresh();

                ScoreTotal(0, 0, 0);
            }

            //Adds a new player to the game
            void NewPlayer()
            {
                //Add Ship name prompt here

                player = new Player();
                ship = new Ship(100);
                ShipLabel.Text = string.Format("Ship:  " + ship.ShipName);
                FuelLevel.Text = string.Format("Fuel Level: {0}/{1}", ship.FuelCurrent, ship.FuelMax);
                FuelLevelBar.Maximum = ship.FuelMax;
                FuelLevelBar.Value = ship.FuelCurrent;
                VolumeLevel.Text = string.Format("Cargo Volume: {0}/{1}", ship.CargoCurrent, ship.CargoMax);
                VolumeLevelBar.Maximum = ship.CargoMax;
                VolumeLevelBar.Value = ship.CargoCurrent;
                PlayerMoneyCount.Text = string.Format("Money: " + "{0}" + " Cr", player.PlayerMoney);
                EngineLevel.Text = string.Format("Fuel per jump: " + ship.FuelBurn);
            }

            //Used to spend or purchase fuel
            void FuelAdjust(int amount, bool adjust)
            {
                if (adjust)
                {
                    ship.FuelCurrent += amount;
                    if (ship.FuelCurrent > ship.FuelMax)
                    {
                        ship.FuelCurrent = ship.FuelMax;
                    }
                    player.PlayerMoney -= (int)(station.FuelPrice * FuelBoxAmount.Value);
                }
                else
                {
                    ship.FuelCurrent -= amount;
                    if (ship.FuelCurrent < 0)
                    {
                        ship.FuelCurrent = 0;
                    }
                }
                FuelLevel.Text = string.Format("Fuel Level: {0}/{1}", ship.FuelCurrent, ship.FuelMax);
                FuelLevelBar.Value = ship.FuelCurrent;
            }

            //Used to show and hide Buy, Sell or Fuel buying and selling options
            long FuelBuyMax;
            int WareBuyMax;
            int WareSellMax;
            void MenuView(string view, bool visible)
            {
                switch (view)
                {
                    case "Fuel":
                        if (visible)
                        {
                            FuelBuyMax = (player.PlayerMoney < station.FuelStock * station.FuelPrice) ? (player.PlayerMoney / station.FuelPrice) : station.FuelStock; //Check how many player can buy based on money
                            FuelBuyMax = (FuelBuyMax > ship.FuelMax - ship.FuelCurrent) ? (ship.FuelMax - ship.FuelCurrent) : FuelBuyMax; //Check how many player can buy based on available space in fuel tank
                            FuelBuyMax = (FuelBuyMax > station.FuelStock) ? station.FuelStock : FuelBuyMax; //Check how many player can buy based on stations fuel stock
                            FuelBoxAmount.Maximum = FuelBuyMax;
                            FuelBoxCost.Text = string.Format("Total cost: " + (int)(station.FuelPrice * FuelBoxAmount.Value)) + " Cr";
                            FuelBoxAmount.Text = "1";
                            MenuView("Buy", false);
                            MenuView("Sell", false);
                            FuelBox.Location = new Point(12, 290);

                            FuelBox.Show();
                        }
                        else
                        {
                            FuelBox.Hide();
                            FuelBoxAmount.Text = "1";
                        }
                        break;
                    case "Buy":
                        if (visible)
                        {
                            int wareIndex = WaresLV.SelectedItems[0].Index;
                            if (player.PlayerMoney / station.StationStock[wareIndex].CurrentValue < 1)
                            {
                                WareBuyMax = 0;
                            }
                            else
                            {
                                WareBuyMax = (player.PlayerMoney < station.StationStock[wareIndex].Amount * station.StationStock[wareIndex].CurrentValue) ? (int)(player.PlayerMoney / station.StationStock[wareIndex].CurrentValue) : (int)station.StationStock[wareIndex].Amount; //Check how many player can buy based on money
                            }
                            WareBuyMax = (WareBuyMax > ((ship.CargoMax - ship.CargoCurrent) / station.StationStock[wareIndex].Volume)) ? (int)((ship.CargoMax - ship.CargoCurrent) / station.StationStock[wareIndex].Volume) : WareBuyMax; //Check how many player can buy based on volume
                            WareBuyMax = (WareBuyMax > station.StationStock[wareIndex].Amount) ? (int)station.StationStock[wareIndex].Amount : (int)WareBuyMax; //Check how many player can buy based on station ware stock
                            if (ship.ShipHull.Count > 7)
                            {
                                int itemID = (int)station.StationStock[wareIndex].ID;
                                if (!ship.ShipHull.Exists(x => x.ID == itemID))
                                {
                                    WareBuyMax = 0;
                                    BuyBoxTitle.Text = "There is not enough room for another ware in your ship";
                                }
                                else
                                {
                                    BuyBoxTitle.Text = "How many would you like to buy?";
                                }
                            }
                            else
                            {
                                BuyBoxTitle.Text = "How many would you like to buy?";
                            }
                            BuyBoxAmount.Maximum = WareBuyMax;
                            BuyBox.Location = new Point(12, 290);
                            MenuView("Fuel", false);
                            MenuView("Sell", false);
                            BuyBoxAmount.Text = "1";

                            BuyBox.Show();
                        }
                        else
                        {
                            BuyBox.Hide();
                        }
                        break;
                    case "Sell":
                        if (visible)
                        {
                            int wareIndex = WaresLVP.SelectedItems[0].Index;
                            WareSellMax = (int)ship.ShipHull[wareIndex].Amount;

                            SellBoxAmount.Maximum = WareSellMax;
                            SellBox.Location = new Point(410, 290);
                            MenuView("Buy", false);
                            MenuView("Fuel", false);
                            SellBoxAmount.Text = "1";
                            SellBoxCargo.Text = string.Format("Cargo volume: " + SellBoxAmount.Value * ship.ShipHull[wareIndex].Volume);
                            SellBox.Show();
                        }
                        else
                        {
                            SellBox.Hide();
                        }
                        break;
                    case "Equipment":
                        if (visible)
                        {
                            ShipBox.Location = new Point(12, 412);
                            ShipBox.Size = new Size(747, 123);
                            ShipBoxConfirm.Location = new Point(654, 85);
                            ShipBoxCost.Location = new Point(535, 88);
                            ShipBoxAmount.Location = new Point(450, 85);
                            ShipBoxMax.Location = new Point(412, 85);
                            this.Height = 587;
                            ShipBox.Show();
                        }
                        else
                        {
                            this.Height = 464;
                            ShipBox.Hide();
                        }
                        break;
                    case "Ships":
                        if (visible)
                        {
                            DealerBox.Location = new Point(12, 412);

                            this.Height = 587;

                            DealerBox.Show();
                        }
                        else
                        {
                            this.Height = 464;

                            DealerBox.Hide();
                        }
                        break;
                }
            }

            //FuelBoxCost calculation when changed
            FuelBoxAmount.ValueChanged += new EventHandler(FuelBoxAmount_Changed);

            void FuelBoxAmount_Changed(object sender, EventArgs e)
            {
                FuelBoxCost.Text = string.Format("Total cost: " + (int)(station.FuelPrice * FuelBoxAmount.Value)) + " Cr";
            }

            //FuelBoxConfirm click action
            FuelBoxConfirm.Click += new EventHandler(FuelBoxConfirm_Click);

            void FuelBoxConfirm_Click(object sender, EventArgs e)
            {
                FuelAdjust((int)FuelBoxAmount.Value, true);
                FuelLevelBar.Value = ship.FuelCurrent;
                FuelLevel.Text = string.Format("Fuel Level: {0}/{1}", ship.FuelCurrent, ship.FuelMax);
                PlayerMoneyCount.Text = string.Format("Money: " + "{0}" + " Cr", player.PlayerMoney);
                station.FuelStock -= (int)FuelBoxAmount.Value;
                FuelAmount.Text = string.Format("" + station.FuelStock);
                if (EquipmentC)
                {
                    RefreshEquipment();
                }
                MenuView("Fuel", false);
            }

            //Action when station ware is highlighted
            WaresLV.ItemSelectionChanged += new ListViewItemSelectionChangedEventHandler(WaresLV_ItemSelectionChanged);

            void WaresLV_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
            {
                if (WaresLV.SelectedItems.Count > 0)
                {
                    int wareCheck = WaresLV.SelectedItems[0].Index;
                    if (wareCheck > station.StationStock.Count)
                    {
                        return;
                    }
                    else
                    {
                        BuyBoxAmount.Text = "1";
                        BuyBoxCost.Text = string.Format("Total cost: {0, 7} Cr", (station.StationStock[wareCheck].CurrentValue));
                        BuyBoxVolume.Text = string.Format("Total volume: {0, 6}", (BuyBoxAmount.Value * station.StationStock[wareCheck].Volume));
                    }
                }
                else
                {
                    return;
                }

                for (int i = 0; i < ship.ShipHull.Count; i++)
                {
                    WaresLVP.Items[i].BackColor = Color.White;
                    WaresLVP.Items[i].ForeColor = Color.Black;
                }

                for (int i = 0; i < station.StationStock.Count; i++)
                {
                    WaresLV.Items[i].BackColor = Color.White;
                    WaresLV.Items[i].ForeColor = Color.Black;
                }

                MenuView("Buy", true);
            }

            //Show BuyBox when WaresLV is clicked
            WaresLV.Click += new EventHandler(WaresLV_Click);

            void WaresLV_Click(object sender, EventArgs e)
            {
                MenuView("Buy", true);
            }

            WaresLVP.Click += new EventHandler(WaresLVP_Click);

            void WaresLVP_Click(object sender, EventArgs e)
            {
                MenuView("Sell", true);
            }

            //BuyBox cost and volume calculation when changed
            BuyBoxAmount.ValueChanged += new EventHandler(BuyBoxAmount_Changed);

            void BuyBoxAmount_Changed(object sender, EventArgs e)
            {
                int wareCheck = WaresLV.SelectedItems[0].Index;
                BuyBoxCost.Text = string.Format("Total cost: {0, 7} Cr", (station.StationStock[wareCheck].CurrentValue * BuyBoxAmount.Value));
                BuyBoxVolume.Text = string.Format("Total volume: {0, 6} ", (BuyBoxAmount.Value * station.StationStock[wareCheck].Volume));
            }

            //BuyBoxConfirm click action
            BuyBoxConfirm.Click += new EventHandler(BuyBoxConfirm_Click);

            void BuyBoxConfirm_Click(object sender, EventArgs e)
            {
                //Checks if Buy box is 0 and if so does nothing
                if (BuyBoxAmount.Value == 0)
                {
                    return;
                }

                int wareCheck = WaresLV.SelectedItems[0].Index;
                player.PlayerMoney -= (int)station.StationStock[wareCheck].CurrentValue * (int)BuyBoxAmount.Value;
                ScoreTotal((int)station.StationStock[wareCheck].CurrentValue * (int)BuyBoxAmount.Value, 0, 0);
                PlayerMoneyCount.Text = string.Format("Money: " + "{0}" + " Cr", player.PlayerMoney);

                int itemID = station.StationStock[wareCheck].ID.Value;
                int index = 0;
                if (!ship.ShipHull.Exists(x => x.ID == itemID))
                {
                    ship.ShipHull.Add(new Ware(itemID, (int)BuyBoxAmount.Value));
                    index = ship.ShipHull.FindIndex(x => x.ID == itemID);
                }
                else
                {
                    index = ship.ShipHull.FindIndex(x => x.ID == itemID);
                    ship.ShipHull[index].Amount += (int)BuyBoxAmount.Value;
                }
                ship.ShipHull[index].Purchased += (station.StationStock[wareCheck].CurrentValue * (int)BuyBoxAmount.Value);

                station.StationStock[wareCheck].Amount -= (int)BuyBoxAmount.Value;
                ship.CargoCurrent += station.StationStock[wareCheck].Volume.Value * (int)BuyBoxAmount.Value;
                VolumeLevelBar.Value = ship.CargoCurrent;
                VolumeLevel.Text = string.Format("Cargo Volume: {0}/{1}", ship.CargoCurrent, ship.CargoMax);

                if (EquipmentC)
                {
                    RefreshEquipment();
                }
                ListViewRefresh();
                MenuView("Buy", false);
            }

            //When the confirm button is clicked under the Sell box
            SellBoxConfirm.Click += new EventHandler(SellBoxConfirm_Click);

            void SellBoxConfirm_Click(object sender, EventArgs e)
            {
                //Checks if Sell box is 0 and if so does nothing
                if (SellBoxAmount.Value == 0)
                {
                    return;
                }

                int wareCheck = WaresLVP.SelectedItems[0].Index;
                int itemID = ship.ShipHull[wareCheck].ID.Value;
                if (station.StationStock.Exists(x => x.ID == itemID))
                {
                    int index = station.StationStock.FindIndex(x => x.ID == itemID);
                    player.PlayerMoney += ((int)station.StationStock[index].CurrentValue * (int)SellBoxAmount.Value);
                    ScoreTotal(0, ((int)station.StationStock[index].CurrentValue * (int)SellBoxAmount.Value), 0);
                    station.StationStock[index].Amount += (int)SellBoxAmount.Value;
                    ship.CargoCurrent -= station.StationStock[index].Volume.Value * (int)SellBoxAmount.Value;
                    ship.ShipHull[wareCheck].Purchased -= (int)station.StationStock[index].CurrentValue * (int)SellBoxAmount.Value;
                    if (ship.ShipHull[wareCheck].Purchased < 0)
                    {
                        ship.ShipHull[wareCheck].Purchased = 0;
                    }
                    ship.ShipHull[wareCheck].Amount -= (int)SellBoxAmount.Value;
                    if (ship.ShipHull[wareCheck].Amount < 1)
                    {
                        ship.ShipHull.RemoveAt(wareCheck);
                    }

                    PlayerMoneyCount.Text = string.Format("Money: " + "{0}" + " Cr", player.PlayerMoney);
                    VolumeLevelBar.Value = ship.CargoCurrent;
                    VolumeLevel.Text = string.Format("Cargo Volume: {0}/{1}", ship.CargoCurrent, ship.CargoMax);

                    if (EquipmentC)
                    {
                        RefreshEquipment();
                    }
                    ListViewRefresh();
                    MenuView("Sell", false);
                }
            }

            //SellBox cost calculation when changed
            SellBoxAmount.ValueChanged += new EventHandler(SellBoxAmount_Changed);

            void SellBoxAmount_Changed(object sender, EventArgs e)
            {
                int wareCheck = WaresLVP.SelectedItems[0].Index;
                int itemID = ship.ShipHull[wareCheck].ID.Value;
                if (station.StationStock.Exists(x => x.ID == itemID))
                {
                    int index = station.StationStock.FindIndex(x => x.ID == itemID);
                    SellBoxCost.Text = string.Format("Total revenue: {0, 7} Cr", (SellBoxAmount.Value * station.StationStock[index].CurrentValue));
                }
                SellBoxCargo.Text = string.Format("Cargo volume: " + SellBoxAmount.Value * ship.ShipHull[wareCheck].Volume);
            }

            //Action when ship ware is highlighted
            WaresLVP.ItemSelectionChanged += new ListViewItemSelectionChangedEventHandler(WaresLVP_ItemSelectionChanged);

            void WaresLVP_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
            {
                //timer1.Interval = 2000;
                //timer1.Start();

                //while(exitFlag == false)
                //{
                //    Application.DoEvents();
                //}

                if (WaresLVP.SelectedItems.Count > 0)
                {
                    int wareCheck = WaresLVP.SelectedItems[0].Index;
                    if (wareCheck > ship.ShipHull.Count)
                    {
                        return;
                    }
                    else
                    {
                        int itemID = ship.ShipHull[wareCheck].ID.Value;
                        int stationIndex = station.StationStock.FindIndex(x => x.ID == itemID);
                        if (station.StationStock.Exists(x => x.ID == itemID))//search
                        {
                            SellBoxCost.Text = string.Format("Total profit: {0, 7} Cr", (SellBoxAmount.Value * station.StationStock[stationIndex].CurrentValue));
                            SellBoxTitle.Text = "How many would you like to sell?";
                            for (int i = 0; i < ship.ShipHull.Count; i++)
                            {
                                if (i == wareCheck)
                                {
                                    WaresLVP.Items[i].BackColor = Color.CornflowerBlue;
                                    WaresLVP.Items[i].ForeColor = Color.White;
                                }
                                else
                                {
                                    WaresLVP.Items[i].BackColor = Color.White;
                                    WaresLVP.Items[i].ForeColor = Color.Black;
                                }
                            }

                            for (int i = 0; i < station.StationStock.Count; i++)
                            {
                                if (i == stationIndex)
                                {
                                    WaresLV.Items[i].BackColor = Color.CornflowerBlue;
                                    WaresLV.Items[i].ForeColor = Color.White;
                                }
                                else
                                {
                                    WaresLV.Items[i].BackColor = Color.White;
                                    WaresLV.Items[i].ForeColor = Color.Black;
                                }
                            }

                            MenuView("Sell", true);
                        }
                        else
                        {
                            SellBoxCost.Text = string.Format("Total profit: 0 Cr");
                            SellBoxTitle.Text = "This station does not buy this ware";

                            for (int i = 0; i < ship.ShipHull.Count; i++)
                            {
                                WaresLVP.Items[i].BackColor = Color.White;
                                WaresLVP.Items[i].ForeColor = Color.Black;
                            }

                            for (int i = 0; i < station.StationStock.Count; i++)
                            {
                                WaresLV.Items[i].BackColor = Color.White;
                                WaresLV.Items[i].ForeColor = Color.Black;
                            }

                            MenuView("Sell", true);
                        }
                    }
                }
                else
                {
                    return;
                }
                MenuView("Sell", true);
            }

            //Displays arrows and mean purchase price of wares in the ship that exist in the station
            void Presence(int present, bool showHide, int val)
            {
                switch (present)
                {
                    case 0:
                        if (showHide)
                        {
                            pre0.Text = string.Format(val + " >");
                            pre0.Show();
                        }
                        else
                        {
                            pre0.Hide();
                        }
                        break;
                    case 1:
                        if (showHide)
                        {
                            pre1.Text = string.Format(val + " >");
                            pre1.Show();
                        }
                        else
                        {
                            pre1.Hide();
                        }
                        break;
                    case 2:
                        if (showHide)
                        {
                            pre2.Text = string.Format(val + " >");
                            pre2.Show();
                        }
                        else
                        {
                            pre2.Hide();
                        }
                        break;
                    case 3:
                        if (showHide)
                        {
                            pre3.Text = string.Format(val + " >");
                            pre3.Show();
                        }
                        else
                        {
                            pre3.Hide();
                        }
                        break;
                    case 4:
                        if (showHide)
                        {
                            pre4.Text = string.Format(val + " >");
                            pre4.Show();
                        }
                        else
                        {
                            pre4.Hide();
                        }
                        break;
                    case 5:
                        if (showHide)
                        {
                            pre5.Text = string.Format(val + " >");
                            pre5.Show();
                        }
                        else
                        {
                            pre5.Hide();
                        }
                        break;
                    case 6:
                        if (showHide)
                        {
                            pre6.Text = string.Format(val + " >");
                            pre6.Show();
                        }
                        else
                        {
                            pre6.Hide();
                        }
                        break;
                    case 7:
                        if (showHide)
                        {
                            pre7.Text = string.Format(val + " >");
                            pre7.Show();
                        }
                        else
                        {
                            pre7.Hide();
                        }
                        break;
                }
            }

            //Refreshes both ListView boxes and "presence" arrows
            void ListViewRefresh()
            {
                WaresLV.Items.Clear();
                WaresLVP.Items.Clear(); 
                for (int i = 0; i < station.StockVariety; i++)
                {
                    var item = new ListViewItem(new[] { station.StationStock[i].Name, station.StationStock[i].Volume.ToString(), station.StationStock[i].CurrentValue.ToString(), station.StationStock[i].Amount.ToString() });
                    WaresLV.Items.Add(item);
                }

                for (int i = 0; i < ship.ShipHull.Count; i++)
                {
                    var item2 = new ListViewItem(new[] { ship.ShipHull[i].Name, string.Format((ship.ShipHull[i].Volume * ship.ShipHull[i].Amount) + " (" + ship.ShipHull[i].Volume + " per)"), ship.ShipHull[i].Amount.ToString() });
                    WaresLVP.Items.Add(item2);
                }

                ship.CargoCurrent = 0;
                for (int i = 0; i < ship.ShipHull.Count; i++)
                {
                    ship.CargoCurrent += (int)(ship.ShipHull[i].Volume * ship.ShipHull[i].Amount);
                }

                int itemID;
                for (int i = 0; i < ship.ShipHull.Count; i++)
                {
                    itemID = ship.ShipHull[i].ID.Value;
                    if (station.StationStock.Exists(x => x.ID == itemID))
                    {
                        if (ship.ShipHull[i].Purchased == 0)
                        {
                            ship.ShipHull[i].meanPurchased = 0;
                        }
                        else
                        {
                            ship.ShipHull[i].meanPurchased = (int)(ship.ShipHull[i].Purchased / ship.ShipHull[i].Amount);
                        }
                        Presence(i, true, (int)ship.ShipHull[i].meanPurchased.Value);
                    }
                    else
                    {
                        Presence(i, false, 0);
                    }
                }

                for (int i = ship.ShipHull.Count; i < 8; i++)
                {
                    Presence(i, false, 0);
                }
            }


            void ChanceOnEquipment()
            {
                //No equipment or ship dealer for the first 10 jumps of the game
                if (player.TotalJumps < 10)
                {
                    return;
                }

                int randomChance = random.Next(10000);
                //int randomChance = 50;
                if (randomChance < 700)
                {
                    EquipmentC = true;
                    EQ = 0;
                    while (EQ == 0)
                    {
                        EQ = random.Next(4) + 1;

                        if (EQ == 1 & ship.EQFuelLevel == ship.EQFuelMaxLevel)
                        {
                            EQ = 0;
                            continue;
                        }

                        if (EQ == 2 & ship.EQCargoLevel == ship.EQCargoMaxLevel)
                        {
                            EQ = 0;
                            continue;
                        }

                        if (EQ == 3 & ship.EQEngineLevel == ship.EQEngineMaxLevel)
                        {
                            EQ = 0;
                            continue;
                        }
                    }

                    if (EQ == 4)
                    {
                        ShipListCreate();
                    }
                    RefreshEquipment();
                }
                else
                {
                    EquipmentC = false;
                }
            }

            void RefreshEquipment()
            {
                if (EquipmentC)
                {
                    switch (EQ)
                    {
                        case 1:
                            totalCost = EQPriceChange(ship.EQFuelCost, ship.EQFuelRate, ship.EQFuelLevel);
                            int fuelTotal = EQMax(ship.EQFuelCost, ship.EQFuelRate, ship.EQFuelLevel);
                            fuelTotal = (ship.EQFuelMaxLevel - ship.EQFuelLevel > fuelTotal) ? (fuelTotal) : (ship.EQFuelMaxLevel - ship.EQFuelLevel);
                            ShipBoxAmount.Maximum = fuelTotal;
                            ShipBoxItem.Text = "Fuel Tank Volume";
                            if (ShipBoxAmount.Maximum == 0)
                            {
                                ShipBoxAmount.Value = 0;
                                ShipBoxCost.Text = string.Format(EQPriceChange(ship.EQFuelCost, ship.EQFuelRate, ship.EQFuelLevel) + " Cr");
                            }
                            else
                            {
                                ShipBoxAmount.Value = 1;
                                ShipBoxCost.Text = string.Format(EQPriceChange(ship.EQFuelCost, ship.EQFuelRate, ship.EQFuelLevel) + " Cr");
                            }
                            ShipBoxLevel.Text = string.Format("Equipment level: " + ship.EQFuelLevel + "/" + ship.EQFuelMaxLevel);
                            ShipBoxTotalUpgrade.Text = string.Format("Total expanded fuel: " + (ship.EQFuelAdjust * ShipBoxAmount.Value));
                            MenuView("Equipment", true);
                            break;
                        case 2:
                            totalCost = EQPriceChange(ship.EQCargoCost, ship.EQCargoRate, ship.EQCargoLevel);
                            int cargoTotal = EQMax(ship.EQCargoCost, ship.EQCargoRate, ship.EQCargoLevel);
                            cargoTotal = (ship.EQCargoMaxLevel - ship.EQCargoLevel > cargoTotal) ? (cargoTotal) : (ship.EQCargoMaxLevel - ship.EQCargoLevel);
                            ShipBoxAmount.Maximum = cargoTotal;
                            ShipBoxItem.Text = "Cargo Extension";
                            if (ShipBoxAmount.Maximum == 0)
                            {
                                ShipBoxAmount.Value = 0;
                                ShipBoxCost.Text = string.Format(EQPriceChange(ship.EQCargoCost, ship.EQCargoRate, ship.EQCargoLevel) + " Cr");
                            }
                            else
                            {
                                ShipBoxAmount.Value = 1;
                                ShipBoxCost.Text = string.Format(EQPriceChange(ship.EQCargoCost, ship.EQCargoRate, ship.EQCargoLevel) + " Cr");
                            }
                            ShipBoxLevel.Text = string.Format("Equipment level: " + ship.EQCargoLevel + "/" + ship.EQCargoMaxLevel);
                            ShipBoxTotalUpgrade.Text = string.Format("Total expanded cargo: " + (ship.EQCargoAdjust * ShipBoxAmount.Value));
                            MenuView("Equipment", true);
                            break;
                        case 3:
                            totalCost = EQPriceChange(ship.EQEngineCost, ship.EQEngineRate, ship.EQEngineLevel);
                            int engineTotal = EQMax(ship.EQEngineCost, ship.EQEngineRate, ship.EQEngineLevel); //Checks how many total the player can afford
                            engineTotal = (ship.EQEngineMaxLevel - ship.EQEngineLevel > engineTotal) ? (engineTotal) : (ship.EQEngineMaxLevel - ship.EQEngineLevel); //Checks if total upgrades left is greater than affordable upgrades
                            ShipBoxAmount.Maximum = engineTotal;
                            ShipBoxItem.Text = "Engine Tuning";
                            if (ShipBoxAmount.Maximum == 0)
                            {
                                ShipBoxAmount.Value = 0;
                                ShipBoxCost.Text = string.Format(EQPriceChange(ship.EQEngineCost, ship.EQEngineRate, ship.EQEngineLevel) + " Cr");
                            }
                            else
                            {
                                ShipBoxAmount.Value = 1;
                                ShipBoxCost.Text = string.Format(EQPriceChange(ship.EQEngineCost, ship.EQEngineRate, ship.EQEngineLevel) + " Cr");
                            }
                            ShipBoxLevel.Text = string.Format("Equipment level: " + ship.EQEngineLevel + "/" + ship.EQEngineMaxLevel);
                            ShipBoxTotalUpgrade.Text = string.Format("Total engine burn reduction: " + (ship.EQEngineAdjust * ShipBoxAmount.Value));
                            MenuView("Equipment", true);
                            break;
                        case 4:
                            DealerList.Items.Clear();
                            for (int i = 0; i < shiplist.Count; i++)
                            {
                                var item = new ListViewItem(new[] { shiplist[i].ShipName, string.Format("" + shiplist[i].FuelMax), string.Format("" + shiplist[i].FuelBurn), string.Format("" + shiplist[i].CargoMax), string.Format("" + shiplist[i].CrewSlot), string.Format("" + shiplist[i].ShipPrice) });
                                DealerList.Items.Add(item);
                            }

                            MenuView("Ships", true);
                            break;
                    }
                }
            }

            void ShipListCreate()
            {
                shiplist.Clear();
                DealerList.Items.Clear();

                shiplist.Add(new Ship(100));
                shiplist.Add(new Ship(101));
                shiplist.Add(new Ship(200));
                shiplist.Add(new Ship(201));
                shiplist.Add(new Ship(300));
                shiplist.Add(new Ship(301));

                for (int i = 0; i < 3; i++)
                {
                    int size = shiplist.Count;
                    int choice = random.Next(size);
                    shiplist.RemoveAt(choice);
                }

                for (int i = 0; i < shiplist.Count; i++)
                {
                    var item = new ListViewItem(new[] { shiplist[i].ShipName, string.Format("" + shiplist[i].FuelMax), string.Format("" + shiplist[i].FuelBurn), string.Format("" + shiplist[i].CargoMax), string.Format("" + shiplist[i].CrewSlot), string.Format("" + shiplist[i].ShipPrice) });
                    DealerList.Items.Add(item);
                }
            }

            ShipBoxConfirm.Click += new EventHandler(ShipBoxConfirm_Click);

            void ShipBoxConfirm_Click(object sender, EventArgs e)
            {
                if (ShipBoxAmount.Value == 0)
                {
                    return;
                }

                switch (EQ)
                {
                    case 1:
                        //Subtract upgrade cost from player money
                        player.PlayerMoney -= totalCost;
                        //Increase the level of fuel upgrades for future cost
                        ship.EQFuelLevel += (int)ShipBoxAmount.Value;
                        //Increase maximum ship fuel by 20 per fuel upgrade
                        ship.FuelMax += (int)ShipBoxAmount.Value * ship.EQFuelAdjust;
                        //Update fuel bar maximum
                        FuelLevelBar.Maximum = ship.FuelMax;
                        //Refresh fuel bar text for updated curent/max fuel
                        FuelLevel.Text = string.Format("Fuel Level: {0}/{1}", ship.FuelCurrent, ship.FuelMax);
                        //Refresh fuel bar for current amount
                        FuelLevelBar.Value = ship.FuelCurrent;
                        //Refresh player money amount
                        PlayerMoneyCount.Text = string.Format("Money: " + "{0}" + " Cr", player.PlayerMoney);
                        //Increase EQ Purchase player score
                        ScoreTotal(0, 0, totalCost);
                        MenuView("Equipment", false);
                        EquipmentC = false;
                        break;
                    case 2:
                        //Subtract upgrade cost from player money
                        player.PlayerMoney -= totalCost;
                        //Increase the level of volume upgrades for future cost
                        ship.EQCargoLevel += (int)ShipBoxAmount.Value;
                        //Increase maximum ship cargo volume by 100 per fuel upgrade
                        ship.CargoMax += (int)ShipBoxAmount.Value * ship.EQCargoAdjust;
                        //Update volume bar maximum
                        VolumeLevelBar.Maximum = ship.CargoMax;
                        //Refresh volume bar text for updated curent/max volume
                        VolumeLevel.Text = string.Format("Cargo Volume: {0}/{1}", ship.CargoCurrent, ship.CargoMax);
                        //Refresh volume bar for current amount
                        VolumeLevelBar.Value = ship.CargoCurrent;
                        //Refresh player money amount
                        PlayerMoneyCount.Text = string.Format("Money: " + "{0}" + " Cr", player.PlayerMoney);
                        //Increase EQ Purchase player score
                        ScoreTotal(0, 0, totalCost);
                        MenuView("Equipment", false);
                        EquipmentC = false;
                        break;
                    case 3:
                        //Subtract upgrade cost from player money
                        player.PlayerMoney -= totalCost;
                        //Increase the level of engine upgrades for future cost
                        ship.EQEngineLevel += (int)ShipBoxAmount.Value;
                        //Increase engine efficiency
                        ship.FuelBurn -= (int)ShipBoxAmount.Value * ship.EQEngineAdjust;
                        //Update engine level text on main screen
                        EngineLevel.Text = string.Format("Fuel per jump: " + ship.FuelBurn);
                        //Refresh player money amount
                        PlayerMoneyCount.Text = string.Format("Money: " + "{0}" + " Cr", player.PlayerMoney);
                        //Increase EQ Purchase player score
                        ScoreTotal(0,0,totalCost);
                        MenuView("Equipment", false);
                        EquipmentC = false;
                        break;
                }
            }

            int EQMax(int price, double rate, int level)
            {
                int Max = 0;
                long Money = player.PlayerMoney;
                int Next = (int)(price * Math.Pow(rate, level));
                while (Money >= Next)
                {
                    Money -= Next;
                    Max += 1;
                    Next = (int)(Next * rate);
                }
                return Max;
            }

            //ShipBoxAmount value changed calculation
            ShipBoxAmount.ValueChanged += new EventHandler(ShipBoxAmount_Changed);

            void ShipBoxAmount_Changed(object sender, EventArgs e)
            {
                int tempLevel = 0;
                switch (EQ)
                {
                    case 1:
                        totalCost = 0;
                        tempLevel = ship.EQFuelLevel;
                        for (int i = tempLevel; i < (ShipBoxAmount.Value); i++)
                        {
                            totalCost += EQPriceChange(ship.EQFuelCost, ship.EQFuelRate, tempLevel);
                            tempLevel += 1;
                        }
                        if (totalCost == 0)
                        {
                            totalCost = EQPriceChange(ship.EQFuelCost, ship.EQFuelRate, tempLevel);
                        }
                        ShipBoxCost.Text = string.Format(totalCost + " Cr");
                        ShipBoxTotalUpgrade.Text = string.Format("Total expanded fuel: " + (ship.EQFuelAdjust * ShipBoxAmount.Value));
                        break;
                    case 2:
                        totalCost = 0;
                        tempLevel = ship.EQCargoLevel;
                        for (int i = tempLevel; i < (ship.EQCargoLevel + ShipBoxAmount.Value); i++)
                        {
                            totalCost += EQPriceChange(ship.EQCargoCost, ship.EQCargoRate, tempLevel);
                            tempLevel += 1;
                        }
                        if (totalCost == 0)
                        {
                            totalCost = EQPriceChange(ship.EQFuelCost, ship.EQFuelRate, tempLevel);
                        }
                        ShipBoxCost.Text = string.Format(totalCost + " Cr");
                        ShipBoxTotalUpgrade.Text = string.Format("Total expanded cargo: " + (ship.EQCargoAdjust * ShipBoxAmount.Value));
                        break;
                    case 3:
                        totalCost = 0;
                        tempLevel = ship.EQEngineLevel;
                        for (int i = tempLevel; i < (ship.EQEngineLevel + ShipBoxAmount.Value); i++)
                        {
                            totalCost += EQPriceChange(ship.EQEngineCost, ship.EQEngineRate, tempLevel);
                            tempLevel += 1;
                        }
                        if (totalCost == 0)
                        {
                            totalCost = EQPriceChange(ship.EQEngineCost, ship.EQEngineRate, tempLevel);
                        }
                        ShipBoxCost.Text = string.Format(totalCost + " Cr");
                        ShipBoxTotalUpgrade.Text = string.Format("Total engine burn reduction: " + (ship.EQEngineAdjust * ShipBoxAmount.Value));
                        break;       
                }
            }

            int EQPriceChange(int price, double rate, int itemlevel)
            {
                int EQprice = (int)(price * Math.Pow(rate, itemlevel));
                return EQprice;
            }

            //Fuel max button
            FuelBoxMax.Click += new EventHandler(FuelBoxMax_Click);

            void FuelBoxMax_Click(object sender, EventArgs e)
            {
                FuelBoxAmount.Value = FuelBoxAmount.Maximum;
            }

            //Buy max button
            BuyBoxMax.Click += new EventHandler(BuyBoxMax_Click);

            void BuyBoxMax_Click(object sender, EventArgs e)
            {
                BuyBoxAmount.Value = BuyBoxAmount.Maximum;
            }

            //Sell max button
            SellBoxMax.Click += new EventHandler(SellBoxMax_Click);

            void SellBoxMax_Click(object sender, EventArgs e)
            {
                SellBoxAmount.Value = SellBoxAmount.Maximum;
            }

            //Ship max button
            ShipBoxMax.Click += new EventHandler(ShipBoxMax_Click);

            void ShipBoxMax_Click(object sender, EventArgs e)
            {
                ShipBoxAmount.Value = ShipBoxAmount.Maximum;
            }

            void ScoreTotal(long bought, long sold, int eq)
            {
                player.TotalPurchased += bought;
                player.TotalSold += sold;
                long moneytotal = player.TotalSold - player.TotalPurchased;
                player.EQTotalPurchased += eq;
                player.PlayerScore = moneytotal + player.EQTotalPurchased + (player.TotalJumps * 10);
                PlayerScore.Text = string.Format("Score: " + player.PlayerScore);
                TotalJumps.Text = string.Format("Jumps: " + player.TotalJumps);
            }

            DealerConfirm.Click += new EventHandler(DealerConfirm_Click);

            void DealerConfirm_Click(object sender, EventArgs e)
            {
                //Find new ship to apply settings for
                int shipChoice = DealerList.SelectedItems[0].Index;
                int ID = shiplist[shipChoice].ShipID;
                int cargototal = 0;
                for (int i = 0; i < ship.ShipHull.Count; i++)
                {
                    cargototal += (int)(ship.ShipHull[i].Volume * ship.ShipHull[i].Amount);
                }

                if (player.PlayerMoney > shiplist[shipChoice].ShipPrice)
                {
                    if (shiplist[shipChoice].CargoMax < cargototal) //check if ship storage is smaller than current ship
                    {
                        MessageBox.Show("You need to clear " + (cargototal - shiplist[shipChoice].CargoMax) + " of cargo space to buy this ship");
                        return;
                    }
                    else
                    {
                        player.PlayerMoney -= shiplist[shipChoice].ShipPrice;

                        //Transfer shiphull to temporary list
                        List<Ware> Transfer = new List<Ware>();
                        Transfer = ship.ShipHull;

                        //Create new ship
                        ship = new Ship(ID);

                        //Transfer wares to new ship
                        ship.ShipHull = Transfer;

                        //Regenerate new ship listbox
                        ListViewRefresh();

                        //Apply new values to game screen
                        ShipLabel.Text = string.Format("Ship:  " + ship.ShipName);
                        FuelLevel.Text = string.Format("Fuel Level: {0}/{1}", ship.FuelCurrent, ship.FuelMax);
                        FuelLevelBar.Maximum = ship.FuelMax;
                        FuelLevelBar.Value = ship.FuelCurrent;
                        VolumeLevel.Text = string.Format("Cargo Volume: {0}/{1}", ship.CargoCurrent, ship.CargoMax);
                        VolumeLevelBar.Maximum = ship.CargoMax;
                        VolumeLevelBar.Value = ship.CargoCurrent;
                        PlayerMoneyCount.Text = string.Format("Money: " + "{0}" + " Cr", player.PlayerMoney);
                        EngineLevel.Text = string.Format("Fuel per jump: " + ship.FuelBurn);
                    }
                }
                else
                {
                    MessageBox.Show("You do not have enough money to buy this ship");
                }
            }

            DiscardButton.Click += new EventHandler(DiscardButton_Click);

            void DiscardButton_Click(object sender, EventArgs e)
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure?", " ", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    int wareCheck = WaresLVP.SelectedItems[0].Index;

                    ship.CargoCurrent -= (int)(ship.ShipHull[wareCheck].Volume * SellBoxAmount.Value);
                    ship.ShipHull[wareCheck].Amount -= (int)SellBoxAmount.Value;
                    if (ship.ShipHull[wareCheck].Amount < 1)
                    {
                        ship.ShipHull.RemoveAt(wareCheck);
                    }

                    VolumeLevelBar.Value = ship.CargoCurrent;
                    VolumeLevel.Text = string.Format("Cargo Volume: {0}/{1}", ship.CargoCurrent, ship.CargoMax);

                    if (EquipmentC)
                    {
                        RefreshEquipment();
                    }
                    ListViewRefresh();
                    MenuView("Sell", false);
                }
                else if (dialogResult == DialogResult.No)
                {
                    return;
                }
            }
        }

        //private void Timer1_Tick(object sender, EventArgs e)
        //{

        //}
    }
}
