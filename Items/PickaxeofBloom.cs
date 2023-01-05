using Terraria.ID;
using Terraria.ModLoader;

namespace Tremor.Items
{
	public class PickaxeofBloom:TremorModItem
	{
		public override void SetDefaults()
		{

			item.damage = 9;
			item.DamageType = DamageClass.Melee;
			item.width = 42;
			item.height = 42;
			item.useTime = 15;
			item.useAnimation = 20;
			item.pick = 68;
			item.useStyle = 1;
			item.knockBack = 5;
			item.value = 600;
			item.rare = 3;
			item.UseSound = SoundID.Item1;
			item.useTurn = true;
			item.autoReuse = true;
		}

		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Pickaxe of Bloom");
			Tooltip.SetDefault("");
		}

	}
}
