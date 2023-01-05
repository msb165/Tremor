using Terraria.ID;
using Terraria.ModLoader;

namespace Tremor.Items
{
	public class TinySai:TremorModItem
	{
		public override void SetDefaults()
		{

			item.damage = 8;
			item.DamageType = DamageClass.Melee;
			item.width = 32;
			item.height = 32;
			item.useTime = 9;
			item.useAnimation = 9;
			item.useStyle = 3;
			item.knockBack = 2;
			item.value = 600;
			item.rare = 1;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
		}

		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Tiny Sai");
			Tooltip.SetDefault("");
		}

	}
}
