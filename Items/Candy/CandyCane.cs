using Terraria.ID;
using Terraria.ModLoader;

namespace Tremor.Items.Candy
{
	public class CandyCane:TremorModItem
	{
		public override void SetDefaults()
		{

			Item.damage = 14;
			Item.DamageType = DamageClass.Melee;
			Item.width = 32;
			Item.height = 28;
			Item.useTime = 32;
			Item.useAnimation = 22;
			Item.useStyle = 1;
			Item.knockBack = 7;
			Item.value = 2000;
			Item.rare = 1;
			Item.UseSound = SoundID.Item1;
			Item.autoReuse = true;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Candy Cane");
			// Tooltip.SetDefault("");
		}

	}
}
