using Terraria.ID;
using Terraria.ModLoader;

namespace Tremor.Items
{
	public class BlacksmithHammer:TremorModItem
	{
		public override void SetDefaults()
		{

			Item.damage = 27;
			Item.DamageType = DamageClass.Melee;
			Item.width = 56;
			Item.height = 56;
			Item.useTime = 22;
			Item.useAnimation = 45;
			Item.useStyle = 1;
			Item.knockBack = 3;
			Item.value = 15000;
			Item.rare = 3;
			Item.UseSound = SoundID.Item1;
			Item.autoReuse = false;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Blacksmith Hammer");
			// Tooltip.SetDefault("");
		}

	}
}
