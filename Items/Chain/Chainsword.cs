using Terraria.ID;
using Terraria.ModLoader;

namespace Tremor.Items.Chain
{
	public class Chainsword:TremorModItem
	{
		public override void SetDefaults()
		{

			Item.damage = 55;
			Item.DamageType = DamageClass.Melee;
			Item.width = 56;
			Item.height = 64;
			Item.useTime = 25;
			Item.useAnimation = 25;
			Item.axe = 22;

			Item.useStyle = 1;
			Item.knockBack = 4;
			Item.value = 60000;
			Item.rare = 5;
			Item.UseSound = SoundID.Item22;
			Item.autoReuse = true;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Chainsword");
			// Tooltip.SetDefault("'It looks like a sword, but its actually a saw! Buy yours today!'");
		}

	}
}
