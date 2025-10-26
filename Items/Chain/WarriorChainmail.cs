using Terraria.ModLoader;

namespace Tremor.Items.Chain
{
	[AutoloadEquip(EquipType.Body)]
	public class WarriorChainmail:TremorModItem
	{

		public override void SetDefaults()
		{

			Item.width = 26;
			Item.height = 18;
			Item.value = 1000;
			Item.rare = 2;
			Item.vanity = true;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Warrior Chainmail");
			// Tooltip.SetDefault("");
		}

	}
}
