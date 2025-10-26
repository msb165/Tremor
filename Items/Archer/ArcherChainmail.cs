using Terraria.ModLoader;

namespace Tremor.Items.Archer
{
	[AutoloadEquip(EquipType.Body)]
	public class ArcherChainmail:TremorModItem
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
			// DisplayName.SetDefault("Archer Chainmail");
			// Tooltip.SetDefault("");
		}

	}
}
