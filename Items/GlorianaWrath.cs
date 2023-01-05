using Terraria.ID;
using Terraria.ModLoader;

namespace Tremor.Items
{
	public class GlorianaWrath:TremorModItem
	{
		public override void SetDefaults()
		{

			item.damage = 54;
			item.DamageType = DamageClass.Melee;
			item.width = 40;
			item.height = 40;

			item.useTime = 20;
			item.useAnimation = 20;
			item.useStyle = 1;
			item.knockBack = 6;
			item.value = 20000;
			item.rare = 9;
			item.expert = true;
			item.shoot = 10;
			item.shootSpeed = 16f;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
		}

		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Gloriana Wrath");
			Tooltip.SetDefault("Cleanses infected areas.");
		}

	}
}
