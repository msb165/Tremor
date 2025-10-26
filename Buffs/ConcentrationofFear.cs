using Terraria;
using Terraria.ModLoader;

namespace Tremor.Buffs
{
	public class ConcentrationofFear:TremorModBuff
	{

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Concentration of Fear");
			// Description.SetDefault("Increased all damage");
			Main.buffNoTimeDisplay[Type] = true;
		}

		public override void Update(Player player, ref int buffIndex)
		{
			player.statDefense += 15;
			player.GetCritChance(DamageClass.Generic) += 5;
			player.GetDamage(DamageClass.Generic) += 0.25f;
			player.GetAttackSpeed(DamageClass.Melee) += 0.15f;
			player.GetKnockback(DamageClass.Summon) += 0.5f;
			player.moveSpeed += 0.15f;
		}
	}
}