using Terraria.ID;
using Terraria.ModLoader;

namespace Tremor.Items
{
	public class Tremor:TremorModItem
	{
		public override void SetDefaults()
		{

			Item.damage = 210;
			Item.DamageType = DamageClass.Melee;
			Item.width = 70;
			Item.height = 70;
			Item.useTime = 18;
			Item.useAnimation = 16;
			Item.useStyle = 1;
			Item.knockBack = 8;
			Item.value = 67800;
			Item.rare = 10;
			Item.UseSound = SoundID.Item71;
			Item.autoReuse = true;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("The Tremor");
			// Tooltip.SetDefault("");
		}

	}
}
