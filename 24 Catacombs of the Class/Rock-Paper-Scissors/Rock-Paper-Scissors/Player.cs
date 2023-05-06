using System;
namespace Rock_Paper_Scissors
{
	public class Player
	{
		// fields
		private string _name;
		private string _weapon;
		private int _wins;

		// properties
		public string Name
		{
			get => _name;
			set => _name = value;
		}

		public string Weapon
		{
			get => _weapon;
			set => _weapon = value;
		}

		public int Wins
		{
			get => _wins;
			set => _wins = value;
		}

		// constructors
		public Player()
		{
	 
		}

		public Player(string name)
		{
			this.Name = name;
		}

	}
}

