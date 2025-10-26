using Terraria.ModLoader;

namespace Tremor.NPCs.Bosses.CogLord.Items
{
	[AutoloadEquip(EquipType.Head)]
	public class CogLordMask:TremorModItem
	{

		public override void SetDefaults()
		{

			Item.width = 20;
			Item.height = 24;
			Item.rare = 1;
			Item.vanity = true;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Cog Lord Mask");
			// Tooltip.SetDefault("");
		}

	}
}
