using Terraria.ID;
using Terraria.ModLoader;

namespace Tremor.ZombieEvent.Items
{
	public class RottenHand:TremorModItem
	{
		public override void SetDefaults()
		{

			Item.damage = 10;
			Item.DamageType = DamageClass.Melee;
			Item.width = 26;
			Item.height = 26;
			Item.useTime = 25;
			Item.useAnimation = 25;
			Item.useStyle = 1;
			Item.knockBack = 2;
			Item.value = 3000;
			Item.rare = 1;
			Item.UseSound = SoundID.Item1;
			Item.autoReuse = true;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Rotten Hand");
			// Tooltip.SetDefault("");
		}
	}
}
