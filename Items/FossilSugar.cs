using Terraria.ID;
using Terraria.ModLoader;

namespace Tremor.Items
{
	public class FossilSugar:TremorModItem
	{
		public override void SetDefaults()
		{

			Item.width = 28;
			Item.height = 30;

			Item.useTime = 20;
			Item.useAnimation = 20;
			Item.useStyle = 1;
			Item.knockBack = 6;
			Item.value = 30000;
			Item.rare = 2;
			Item.UseSound = SoundID.Item79;
			Item.noMelee = true;
			Item.mountType = ModContent.MountType<Mounts.Antlion>();
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Fossil Sugar");
			// Tooltip.SetDefault("Summons a rideable Antlion mount");
		}

	}
}
