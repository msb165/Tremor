using Terraria.ID;
using Terraria.ModLoader;

namespace Tremor.Items
{
	public class SacrificalScythe:TremorModItem
	{
		public override void SetDefaults()
		{

			Item.damage = 16;
			Item.DamageType = DamageClass.Melee;
			Item.width = 42;
			Item.height = 42;
			Item.useTime = 31;
			Item.useAnimation = 21;
			Item.useStyle = 1;
			Item.knockBack = 10;
			Item.value = 26660;
			Item.rare = 1;
			Item.UseSound = SoundID.Item1;
			Item.autoReuse = false;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Sacrifical Scythe");
			// Tooltip.SetDefault("");
		}

	}
}
