using Terraria.ID;
using Terraria.ModLoader;

namespace Tremor.Items
{
	public class Tremor:TremorModItem
	{
		public override void SetDefaults()
		{

			item.damage = 210;
			item.DamageType = DamageClass.Melee;
			item.width = 70;
			item.height = 70;
			item.useTime = 18;
			item.useAnimation = 16;
			item.useStyle = 1;
			item.knockBack = 8;
			item.value = 67800;
			item.rare = 10;
			item.UseSound = SoundID.Item71;
			item.autoReuse = true;
		}

		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("The Tremor");
			Tooltip.SetDefault("");
		}

	}
}
