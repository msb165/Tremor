using Terraria.ID;
using Terraria.ModLoader;

namespace Tremor.Items
{
	public class NorthAxe:TremorModItem
	{
		public override void SetDefaults()
		{

			Item.damage = 5;
			Item.DamageType = DamageClass.Melee;
			Item.width = 36;
			Item.height = 36;
			Item.useTime = 20;
			Item.useAnimation = 20;
			Item.axe = 9;
			Item.useStyle = 1;
			Item.knockBack = 3;
			Item.value = 100;
			Item.rare = 1;
			Item.UseSound = SoundID.Item1;
			Item.autoReuse = true;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("North Axe");
			// Tooltip.SetDefault("");
		}

	}
}
