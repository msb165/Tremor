using Terraria.ID;
using Terraria.ModLoader;

namespace Tremor.Items.Arach
{
	public class Arachnophobia:TremorModItem
	{
		public override void SetDefaults()
		{

			Item.damage = 18;
			Item.DamageType = DamageClass.Melee;
			Item.width = 48;
			Item.height = 48;
			Item.useTime = 35;
			Item.useAnimation = 35;
			Item.useStyle = 1;
			Item.knockBack = 7;
			Item.shoot = 378;
			Item.shootSpeed = 14f;
			Item.value = 12500;
			Item.rare = 3;
			Item.UseSound = SoundID.Item1;
			Item.autoReuse = true;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Arachnophobia");
			// Tooltip.SetDefault("");
		}

	}
}
