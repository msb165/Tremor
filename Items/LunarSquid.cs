using Terraria;
using Terraria.ModLoader;

namespace Tremor.Items
{
	public class LunarSquid:TremorModItem
	{
		public override void SetDefaults()
		{

			Item.questItem = true;
			Item.maxStack = 1;
			Item.width = 26;
			Item.height = 26;
			Item.uniqueStack = true;
			Item.rare = -11;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Lunar Squid");
			// Tooltip.SetDefault("");
		}

		public override bool IsQuestFish()
		{
			return true;
		}

		public override bool IsAnglerQuestAvailable()
		{
			return Main.hardMode;
		}

		public override void AnglerQuestChat(ref string description, ref string catchLocation)
		{
			description = "This creature is clearly not of earthly origin... In any case, I should get it for my collection of extraterrestrial trinkets!";
			catchLocation = "Anywhere";
		}
	}
}
