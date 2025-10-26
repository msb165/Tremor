using Terraria;
using Terraria.ModLoader;

namespace Tremor.Items
{
	public class StarLantern:TremorModItem
	{

		public override void SetDefaults()
		{

			Item.width = 24;
			Item.height = 28;
			Item.value = 50000;
			Item.rare = 11;
			Item.accessory = true;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Star Lantern");
			/* Tooltip.SetDefault("25% increased magic damage\n" +
"Emits aura of light"); */
		}

		public override void UpdateAccessory(Player player, bool hideVisual)
		{
			player.AddBuff(11, 10);
			player.GetDamage(DamageClass.Magic) += 0.25f;
		}
	}
}
