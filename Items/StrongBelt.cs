using Terraria;
using Terraria.ModLoader;

namespace Tremor.Items
{
	public class StrongBelt:TremorModItem
	{

		public override void SetDefaults()
		{

			item.width = 30;
			item.height = 24;
			item.value = 25000;
			item.rare = 2;
			item.accessory = true;
		}

		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Strong Belt");
			Tooltip.SetDefault("15% increased minion knockback");
		}

		public override void UpdateAccessory(Player player, bool hideVisual)

		{
			player.GetKnockback(DamageClass.Summon) += 0.15f;
		}
	}
}
