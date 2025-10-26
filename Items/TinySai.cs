using Terraria.ID;
using Terraria.ModLoader;

namespace Tremor.Items
{
	public class TinySai:TremorModItem
	{
		public override void SetDefaults()
		{

			Item.damage = 8;
			Item.DamageType = DamageClass.Melee;
			Item.width = 32;
			Item.height = 32;
			Item.useTime = 9;
			Item.useAnimation = 9;
			Item.useStyle = 3;
			Item.knockBack = 2;
			Item.value = 600;
			Item.rare = 1;
			Item.UseSound = SoundID.Item1;
			Item.autoReuse = true;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Tiny Sai");
			// Tooltip.SetDefault("");
		}

	}
}
