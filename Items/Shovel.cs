using Terraria.ID;
using Terraria.ModLoader;

namespace Tremor.Items
{
	public class Shovel:TremorModItem
	{
		public override void SetDefaults()
		{

			item.damage = 24;
			item.DamageType = DamageClass.Melee;
			item.width = 46;
			item.height = 50;
			item.useTime = 15;
			item.useAnimation = 15;
			item.useStyle = 1;
			item.knockBack = 7;
			item.value = 121000;
			item.rare = 2;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
		}

		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Shovel");
			Tooltip.SetDefault("");
		}

	}
}
