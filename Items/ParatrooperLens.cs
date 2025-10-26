using Terraria;
using Terraria.ModLoader;

namespace Tremor.Items
{
	public class ParatrooperLens:TremorModItem
	{

		public override void SetDefaults()
		{

			Item.width = 27;
			Item.height = 26;
			Item.rare = 11;
			Item.value = 3000000;

			Item.accessory = true;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Paratrooper's Lens");
			// Tooltip.SetDefault("Increases projectile's speed twice");
		}

		public override void UpdateAccessory(Player player, bool hideVisual)
		{
			player.AddBuff(ModContent.BuffType<Buffs.ShootSpeedBuff2>(), 2);
		}
	}
}
