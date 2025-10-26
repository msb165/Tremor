using Terraria;
using Terraria.ModLoader;

namespace Tremor.Items
{
	[AutoloadEquip(EquipType.Wings)]
	public class WhaleFlippers:TremorModItem
	{

		public override void SetDefaults()
		{

			Item.width = 22;
			Item.height = 20;

			Item.value = 80000;
			Item.rare = 8;
			Item.accessory = true;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Whale Flippers");
			// Tooltip.SetDefault("Allows flight and slow fall");
		}

		//these wings use the same values as the solar wings

		public override void UpdateAccessory(Player player, bool hideVisual)
		{
			player.wingTimeMax = 183;
		}

		public override void VerticalWingSpeeds(Player player, ref float ascentWhenFalling, ref float ascentWhenRising,
			ref float maxCanAscendMultiplier, ref float maxAscentMultiplier, ref float constantAscend)
		{
			ascentWhenFalling = 0.85f;
			ascentWhenRising = 0.15f;
			maxCanAscendMultiplier = 1f;
			maxAscentMultiplier = 3f;
			constantAscend = 0.135f;
		}

		public override void HorizontalWingSpeeds(Player player, ref float speed, ref float acceleration)
		{
			speed = 9f;
			acceleration *= 2.5f;
		}
	}
}
