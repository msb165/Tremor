using Terraria.ModLoader;

namespace Tremor.Items
{
	public class TearsofDeath:TremorModItem
	{

		public override void SetDefaults()
		{

			item.width = 40;
			item.height = 28;
			item.maxStack = 99;

			item.value = 100;
			item.rare = 3;
		}

		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Tears of Death");
			Tooltip.SetDefault("Unstable ingredient");
		}

	}
}
