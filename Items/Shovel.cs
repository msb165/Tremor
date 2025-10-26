using Terraria.ID;
using Terraria.ModLoader;

namespace Tremor.Items
{
	public class Shovel:TremorModItem
	{
		public override void SetDefaults()
		{

			Item.damage = 24;
			Item.DamageType = DamageClass.Melee;
			Item.width = 46;
			Item.height = 50;
			Item.useTime = 15;
			Item.useAnimation = 15;
			Item.useStyle = 1;
			Item.knockBack = 7;
			Item.value = 121000;
			Item.rare = 2;
			Item.UseSound = SoundID.Item1;
			Item.autoReuse = true;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Shovel");
			// Tooltip.SetDefault("");
		}

	}
}
