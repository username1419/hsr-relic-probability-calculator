using hsr_relic_probability_calculator.Properties;
using System.Resources;

namespace hsr_relic_probability_calculator
{
	enum SelectionStages
	{
		RelicSet,
		PieceType,
		MainStat,
		SubStat,
		SubstatRolls
	}
	public partial class Form1 : Form
	{
		readonly Dictionary<string, double> pieceTypeProbability = new() {
			{ "Head", 1/4 },
			{ "Hand", 1/4 },
			{ "Body", 1/4 },
			{ "Feet", 1/4 },
			{ "Sphere", 1/2 },
			{ "Rope", 1/2 }
		};

		readonly Dictionary<string, Dictionary<string, double>> pieceMainStatProbability = new()
		{
			{ "Head", new() {
					{ "HP", 1 }
			} },
			{ "Hand", new() {
					{ "ATK", 1 }
			} },
			{ "Body", new() {
					{ "Crit DMG", 503d/4977 },
					{ "Crit Rate", 497d/4977 },
					{ "Healing Boost", 497d/4977 },
					{ "Effect Hit Rate", 508d/4977 },
					{ "HP%", 997d/4977 },
					{ "ATK%", 1007d/4977 },
					{ "DEF%", 968d/4977 }
			} },
			{ "Feet", new() {
					{ "SPD", 615d/4949 },
					{ "HP%", 1375d/4949 },
					{ "ATK%", 1502d/4949 },
					{ "DEF%", 1457d/4949 }
			} },
			{ "Sphere", new() {
					{ "HP%", 804d/6252 },
					{ "ATK%", 763d/6252 },
					{ "DEF%", 712d/6252 },
					{ "Elemental DMG%", 3973d/7d/6252 }
			} },
			{ "Rope", new() {
					{ "HP%", 1741d/6382 },
					{ "ATK%", 1766d/6382 },
					{ "DEF%", 1564d/6382 },
					{ "Break Effect", 960d/6382 },
					{ "Energy Regen", 351d/6382 }
			} }
		};

		readonly Dictionary<string, int> pieceSubStatProbability = new()
		{
			{ "HP", 7678 },
			{ "ATK", 7854 },
			{ "DEF", 9320 },
			{ "HP%", 7635 },
			{ "ATK%", 7808 },
			{ "DEF%", 7812 },
			{ "SPD", 3991 },
			{ "Crit Rate", 5867 },
			{ "Crit DMG", 5804 },
			{ "Effect Hit Rate", 7500 },
			{ "Effect RES", 7549 },
			{ "Break Effect", 7641 }
		};
		const double totalSubstats = 86459;

		readonly string[] relicNames = [
			"Band of Sizzling Thunder",
			"Belobog of the Architects",
			"Broken Keel",
			"Celestial Differentiator",
			"Champion of Streetwise Boxing",
			"Duran Dynasty of Running Wolves",
			"Eagle of Twilight Line",
			"Firesmith of Lava-Forging",
			"Firmament Frontline Glamoth",
			"Fleet of the Ageless",
			"Forge of the Kalpagni Lantern",
			"Genius of Brilliant Stars",
			"Guard of Wuthering Snow",
			"Hunter of Glacial Forest",
			"Inert Salsotto",
			"Iron Cavalry Against the Scourge",
			"Izumo Gensei and Takama Divine Realm",
			"Knight of Purity Palace",
			"Longevous Disciple",
			"Lushaka the Sunken Seas",
			"Messenger Traversing Hackerspace",
			"Musketeer of Wild Wheat",
			"Pan-Cosmic Commercial Enterprise",
			"Passerby of Wandering Cloud",
			"Penacony Land of the Dreams",
			"Pioneer Diver of Dead Waters",
			"Prisoner in Deep Confinement",
			"Rutilant Arena",
			"Sacerdos Relived Ordeal",
			"Scholar Lost in Erudition",
			"Sigonia the Unclaimed Desolation",
			"Space Sealing Station",
			"Sprightly Vonwacq",
			"Talia Kingdom of Banditry",
			"The Ashblazing Grand Duke",
			"The Wind-Soaring Valorous",
			"The Wondrous BananAmusement Park",
			"Thief of Shooting Meteor",
			"Wastelander of Banditry Desert",
			"Watchmaker Master of Dream Machinations"
		];

		ResourceManager resourceManager;

		readonly int[] canvernSets = [0, 4, 6, 7, 11, 12, 13, 15, 17, 18, 20, 21, 23, 25, 26, 28, 29, 34, 35, 37, 38, 39];

		readonly int[] planarSets = [1, 2, 3, 5, 8, 9, 10, 14, 16, 19, 22, 24, 27, 30, 31, 32, 33, 36];

		List<string> availableSubStats = [];

		public Form1 ( )
		{
			InitializeComponent();
		}

		private void Form1_Load ( object sender, EventArgs e )
		{
			Text = "Relic Probability Calculator";
			relicSelector.Items.AddRange(relicNames);
			resourceManager = new(typeof(Resources));
			substatRolls = [subStat1Rolls, subStat2Rolls, subStat3Rolls, subStat4Rolls];
		}
		private void relicImage_Click ( object sender, EventArgs e )
		{

		}


		private void ResetSelections ( SelectionStages selectionStages )
		{
			if ( (int) selectionStages < 5 )
			{
				foreach ( TextBox rolls in substatRolls )
				{
					rolls.Text = "0";
				}

				if ( (int) selectionStages < 4 )
				{
					subStat1.Items.Clear();
					subStat2.Items.Clear();
					subStat3.Items.Clear();
					subStat4.Items.Clear();
					subStat1.Text = "";
					subStat2.Text = "";
					subStat3.Text = "";
					subStat4.Text = "";

					if ( (int) selectionStages < 3 )
					{
						mainStatSelector.Items.Clear();
						mainStatSelector.Text = "";

						if ( (int) selectionStages < 2 )
						{
							pieceTypeSelector.Items.Clear();
							pieceTypeSelector.Text = "";

							if ( (int) selectionStages < 1 )
							{
								relicSelector.Items.Clear();
								relicSelector.Text = "";

								relicImage.Image = null;
							}
						}
					}
				}
			}
		}

		private void relicSelector_SelectedIndexChanged ( object sender, EventArgs e )
		{
			string selectedItem = ( (string) relicSelector.SelectedItem ).Replace(' ', '_');

			relicImage.Image = (Bitmap) resourceManager.GetObject(selectedItem);

			ResetSelections(SelectionStages.PieceType);

			pieceTypeSelector.Items.Clear();
			if ( planarSets.Contains(relicSelector.SelectedIndex) )
			{
				pieceTypeSelector.Items.AddRange(["Sphere", "Rope"]);
			}
			else
			{
				pieceTypeSelector.Items.AddRange(["Head", "Hand", "Body", "Feet"]);
			}
		}

		private void pieceTypeSelector_SelectedIndexChanged ( object sender, EventArgs e )
		{
			if ( pieceTypeSelector.SelectedItem == null )
				return;

			ResetSelections(SelectionStages.MainStat);

			mainStatSelector.Items.Clear();
			mainStatSelector.Items.AddRange(pieceMainStatProbability[(string) pieceTypeSelector.SelectedItem].Keys.ToArray());
		}

		private void mainStatSelector_SelectedIndexChanged ( object sender, EventArgs e )
		{
			ResetSelections(SelectionStages.SubStat);

			availableSubStats.AddRange(pieceSubStatProbability.Keys);
			availableSubStats.Remove((string) mainStatSelector.SelectedItem);

			subStat1.Items.AddRange(availableSubStats.ToArray());
			subStat2.Items.AddRange(availableSubStats.ToArray());
			subStat3.Items.AddRange(availableSubStats.ToArray());
			subStat4.Items.AddRange(availableSubStats.ToArray());
		}

		string[] previousSubstats = ["", "", "", ""];
		private void subStat1_SelectedIndexChanged ( object sender, EventArgs e )
		{

		}

		private void subStat2_SelectedIndexChanged ( object sender, EventArgs e )
		{

		}

		private void subStat3_SelectedIndexChanged ( object sender, EventArgs e )
		{

		}

		private void subStat4_SelectedIndexChanged ( object sender, EventArgs e )
		{

		}

		private int totalRolls
		{
			get
			{
				int c = 0;
				for ( int i = 0; i < 4; i++ )
				{
					int.TryParse(substatRolls[i].Text, out int a);
					c += a;
				}
				return c;
			}
		}

		private void subStatRollsChanged ( TextBox sender, EventArgs e )
		{
			if ( int.TryParse(sender.Text, out int rolls) )
			{
				if ( rolls > 5 )
				{
					sender.Text = "5";
				}
				if ( rolls < 0 )
				{
					sender.Text = "0";
				}

				if ( totalRolls > 5 )
				{
					sender.Text = ( rolls - ( totalRolls - 5 ) ).ToString();
				}
			}
			else
			{
				sender.Text = "0";
			}


		}

		TextBox[] substatRolls;
		private void subStatInc ( int sender, EventArgs e )
		{
			int.TryParse(substatRolls[sender].Text, out int rolls);
			if ( rolls == 5 || totalRolls == 5 )
			{
				return;
			}
			substatRolls[sender].Text = ( rolls + 1 ).ToString();
		}

		private void subStatDec ( int sender, EventArgs e )
		{
			int.TryParse(substatRolls[sender].Text, out int rolls);
			if ( rolls == 0 )
			{
				substatRolls[sender].Text = "0";
				return;
			}
			substatRolls[sender].Text = ( rolls - 1 ).ToString();
		}

		private void subStat1Rolls_TextChanged ( object sender, EventArgs e )
		{
			subStatRollsChanged(subStat1Rolls, e);
		}

		private void subStat1Dec_Click ( object sender, EventArgs e )
		{
			subStatDec(0, e);
		}

		private void subStat1Inc_Click ( object sender, EventArgs e )
		{
			subStatInc(0, e);
		}

		private void subStat4Inc_Click ( object sender, EventArgs e )
		{
			subStatInc(3, e);
		}

		private void subStat2Rolls_TextChanged ( object sender, EventArgs e )
		{
			subStatRollsChanged(subStat2Rolls, e);
		}

		private void subStat2Dec_Click ( object sender, EventArgs e )
		{
			subStatDec(1, e);
		}

		private void subStat3Inc_Click ( object sender, EventArgs e )
		{
			subStatInc(2, e);
		}

		private void subStat3Dec_Click ( object sender, EventArgs e )
		{
			subStatDec(2, e);
		}

		private void subStat4Rolls_TextChanged ( object sender, EventArgs e )
		{
			subStatRollsChanged(subStat4Rolls, e);
		}

		private void subStat4Dec_Click ( object sender, EventArgs e )
		{
			subStatDec(3, e);
		}

		private void subStat3Rolls_TextChanged ( object sender, EventArgs e )
		{
			subStatRollsChanged(subStat3Rolls, e);
		}

		private void subStat2Inc_Click ( object sender, EventArgs e )
		{
			subStatInc(1, e);
		}

		bool CheckEmptySelections ( )
		{
			if ( relicSelector.SelectedItem == "" )
				return true;
			if ( pieceTypeSelector.SelectedItem == "" )
				return true;
			if ( mainStatSelector.SelectedItem == "" )
				return true;
			foreach ( ComboBox t in new ComboBox[4] { subStat1, subStat2, subStat3, subStat4 } )
			{
				if ( t.SelectedItem == "" )
				{
					return true;
				}
			}
			return false;
		}

		bool CheckSameSubstats ( )
		{
			foreach ( ComboBox c in new ComboBox[4] { subStat1, subStat2, subStat3, subStat4 } )
			{
				foreach ( ComboBox k in new ComboBox[4] { subStat1, subStat2, subStat3, subStat4 } )
				{
					if ( c == k )
						continue;

					if ( c.Text == k.Text )
					{
						return true;
					}
				}
			}
			return false;
		}

		private void calcButton_Click ( object sender, EventArgs e )
		{
			if ( CheckEmptySelections() )
			{
				warningLabel.Text = "Some fields are empty";
			}
			else if ( CheckSameSubstats() )
			{
				warningLabel.Text = "Some substats are indentical";
			}
			else
			{
				double mainStatProbability = ( 1 / 2d ) * ( 1 / 4d ) * pieceMainStatProbability[pieceTypeSelector.Text][mainStatSelector.Text];
				double subStat1Probability = pieceSubStatProbability[subStat1.Text] / totalSubstats;
				double subStat2Probability = pieceSubStatProbability[subStat2.Text] / ( totalSubstats - pieceSubStatProbability[subStat1.Text] );
				double subStat3Probability = pieceSubStatProbability[subStat3.Text] / ( totalSubstats - pieceSubStatProbability[subStat1.Text] - pieceSubStatProbability[subStat2.Text] );
				double subStat4Probability = pieceSubStatProbability[subStat4.Text] / ( totalSubstats - pieceSubStatProbability[subStat1.Text] - pieceSubStatProbability[subStat2.Text] - pieceSubStatProbability[subStat3.Text] );
				double substatRollProbability = 1;
				foreach ( TextBox t in substatRolls )
				{
					int.TryParse(t.Text, out int rolls);
					substatRollProbability *= Math.Pow(0.25d, rolls);
				}
				double singleRunProbability = mainStatProbability * subStat1Probability * subStat2Probability * subStat3Probability * subStat4Probability * substatRollProbability;
				calculationResults.Text = @$"Calculation Results:
				 - Chance for every relic: {double.Round(singleRunProbability * 100, 10).ToString("0." + new string('#', 10))}%
				 - Chance for every run: {double.Round(singleRunProbability * 2.1 * 100, 10).ToString("0." + new string('#', 10))}%
				 - Chance for every day(w/o max refresh): {double.Round(singleRunProbability * 2.1 * 6 * 100, 10).ToString("0." + new string('#', 10))}%
				 - Chance for every day(with max refresh): {double.Round(singleRunProbability * 2.1 * 18 * 100, 10).ToString("0." + new string('#', 10))}%
				 - Chance for every month(w/o max refresh): {double.Round(singleRunProbability * 2.1 * 6 * 31 * 100, 10).ToString("0." + new string('#', 10))}%
				 - Chance for every month(daily max refresh: {double.Round(singleRunProbability * 2.1 * 18 * 31 * 100, 10).ToString("0." + new string('#', 10))}%
				";
			}
		}
	}
}
