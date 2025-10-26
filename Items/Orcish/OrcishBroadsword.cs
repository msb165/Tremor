using Terraria.ID;
using Terraria.ModLoader;

namespace Tremor.Items.Orcish
{
	public class OrcishBroadsword:TremorModItem
	{
		public override void SetDefaults()
		{

			Item.damage = 20;
			Item.DamageType = DamageClass.Melee;
			Item.width = 48;
			Item.height = 48;
			Item.useTime = 30;
			Item.useAnimation = 20;
			Item.useStyle = 1;
			Item.knockBack = 2;
			Item.value = 2200;
			Item.rare = 1;
			Item.UseSound = SoundID.Item1;
			Item.autoReuse = false;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Orcish Broadsword");
			// Tooltip.SetDefault("");
		}

	}
}
