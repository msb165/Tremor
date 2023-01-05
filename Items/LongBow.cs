using Terraria.ID;
using Terraria.ModLoader;

namespace Tremor.Items
{
	public class LongBow:TremorModItem
	{
		public override void SetDefaults()
		{

			item.damage = 14;
			item.width = 16;
			item.height = 32;
			item.DamageType = DamageClass.Ranged;
			item.useTime = 30;
			item.shoot = 1;
			item.shootSpeed = 8f;
			item.useAnimation = 30;
			item.useStyle = 5;
			item.knockBack = 5;
			item.value = 1040;
			item.useAmmo = AmmoID.Arrow;
			item.rare = 2;
			item.UseSound = SoundID.Item5;
			item.autoReuse = true;
		}

		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Long Bow");
			Tooltip.SetDefault("");
		}

	}
}
