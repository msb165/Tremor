using Terraria.ID;
using Terraria.ModLoader;

namespace Tremor.Items
{
	public class RustySlasher:TremorModItem
	{
		public override void SetDefaults()
		{

			Item.damage = 16;
			Item.DamageType = DamageClass.Melee;
			Item.width = 42;
			Item.height = 46;
			Item.useTime = 13;
			Item.useAnimation = 13;
			Item.useStyle = 1;
			Item.knockBack = 8;
			Item.value = 10000;
			Item.rare = 2;
			Item.UseSound = SoundID.Item71;
			Item.autoReuse = true;
			Item.useTurn = true;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Rusty Slasher");
			// Tooltip.SetDefault("");
		}

	}
}
