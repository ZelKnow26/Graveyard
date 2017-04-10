using System;
using System.Windows.Controls;
using Hearthstone_Deck_Tracker.Plugins;

namespace HDT.Plugins.Graveyard
{
	public class GraveyardPlugin : IPlugin
	{
		public Graveyard GraveyardInstance;

		public string Author
		{
			get { return "RedHatter"; }
		}

		public string ButtonText
		{
			get { return "Settings"; }
		}

		public string Description
		{
			get { return "Displays minions that have died this game. Includes specialized displays: deathrattle minions for N'Zoth decks, resurrect chance for Resurrect Priest, and Murloc minions with a damage calculator for Anyfin Can Happen."; }
		}

		public MenuItem MenuItem
		{
			get { return null; }
		}

		public string Name
		{
			get { return "Graveyard"; }
		}

		public void OnButtonPress()
		{
			SettingsView.Flyout.IsOpen = true;
		}

		public void OnLoad()
		{
			GraveyardInstance = new Graveyard();
		}

		public void OnUnload()
		{
			GraveyardInstance.Dispose();
			GraveyardInstance = null;
		}

		public void OnUpdate() {}

		public Version Version
		{
			get { return new Version(1, 2, 0); }
		}
	}
}
