using Terraria.ID;
using Terraria.ModLoader;

namespace Tremor.Items
{
	public class ShadowCutter:TremorModItem
	{
		public override void SetDefaults()
		{

			Item.damage = 60;
			Item.DamageType = DamageClass.Melee;
			Item.width = 48;
			Item.height = 48;
			Item.useTime = 25;
			Item.useAnimation = 35;
			Item.useStyle = 1;
			Item.knockBack = 7;
			Item.value = 20150;
			Item.rare = 6;
			Item.UseSound = SoundID.Item1;
			Item.autoReuse = false;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Shadow Cutter");
			// Tooltip.SetDefault("");
		}

	}
}
