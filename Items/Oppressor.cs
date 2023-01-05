using Terraria.ID;
using Terraria.ModLoader;

namespace Tremor.Items
{
	public class Oppressor:TremorModItem
	{
		public override void SetDefaults()
		{

			item.damage = 67;
			item.DamageType = DamageClass.Melee;
			item.width = 35;
			item.height = 20;
			item.useTime = 20;
			item.useAnimation = 20;
			item.useStyle = 1;
			item.knockBack = 20;
			item.value = 150000;
			item.rare = 8;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
		}

		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Oppressor");
			Tooltip.SetDefault("");
		}

	}
}

