using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Tremor.Items
{
	public class GolemCore:TremorModItem
	{
		public override void SetDefaults()
		{
			Item.Size = new Vector2(38);
			Item.value = 100000;
			Item.rare = 8;
			ItemID.Sets.ItemNoGravity[Item.type] = true;
			ItemID.Sets.ItemIconPulse[Item.type] = true;
		}

		public override void GrabRange(Player player, ref int grabRange)
		{
			grabRange *= 3;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Golem Core");
			// Tooltip.SetDefault("The ancient and mysterious mechanism");
		}

	}
}
