using System;
using System.Collections.Generic;
using System.Numerics;

namespace Recoil
{
	public enum WeaponIndex
	{
		AR,
		MP5,
		LR
	}

	public enum Barrel
	{
		Silencer,
		MuzzleBreak,
		MuzzleBoost,
		None
	}

	public enum Sight
	{
		Holo,
		Simple,
		X8,
		X16,
		None
	}

	public static class Data
	{
		public static List<Attachment> BarrelCollection = new List<Attachment>()
		{
			new Attachment("Silencer", 0.8F, 0.8F, 1.0F),
			new Attachment("Muzzle Break", 0.5F, 1.0F, 1.0F),
			new Attachment("Muzzle Boost", 1.0F, 1.0F, 0.9F)
		};

		public static List<Attachment> SightCollection = new List<Attachment>()
		{
			new Attachment("Holographic Sight", 1.18605F, 1.0F, 1.0F),
			new Attachment("Simple Sight", 0.8F, 1.0F, 1.0F),
			new Attachment("8x Scope", 3.83721F, 0.8F, 1.0F),
			new Attachment("16x Scope", 7.65116F, 0.8F, 1.0F)
		};

		public static List<Weapon> WeaponColletion = new List<Weapon>()
		{
			new Weapon("Assault Rifle", 133.33333F, new List<Vector2>(){
				new Vector2(1.390706F,-2.003941F),
				new Vector2(1.176434F,-3.844176F),
				new Vector2(3.387171F,-5.516686F),
				new Vector2(5.087049F,-7.017456F),
				new Vector2(5.094189F,-8.342467F),
				new Vector2(4.426013F,-9.487704F),
				new Vector2(3.250455F,-10.449150F),
				new Vector2(1.735450F,-11.222790F),
				new Vector2(0.048934F,-11.804600F),
				new Vector2(-1.641158F,-12.190560F),
				new Vector2(-3.166891F,-12.587130F),
				new Vector2(-4.360331F,-13.320770F),
				new Vector2(-5.053545F,-14.321280F),
				new Vector2(-5.090651F,-15.511030F),
				new Vector2(-4.489915F,-16.812420F),
				new Vector2(-3.382552F,-18.147830F),
				new Vector2(-1.899585F,-19.439660F),
				new Vector2(-0.172030F,-20.610310F),
				new Vector2(1.669086F,-21.582130F),
				new Vector2(3.492748F,-22.277550F),
				new Vector2(5.167930F,-22.618930F),
				new Vector2(6.563614F,-22.817780F),
				new Vector2(7.548776F,-23.373890F),
				new Vector2(7.992399F,-24.211390F),
				new Vector2(7.512226F,-25.237340F),
				new Vector2(6.063792F,-26.358860F),
				new Vector2(4.117367F,-27.483020F),
				new Vector2(2.143932F,-28.516920F),
				new Vector2(0.614482F,-29.367660F),
			}),

			new Weapon("MP5", 100.00000F, new List<Vector2>()
			{
				new Vector2(0.000000F,-0.868838F),
				new Vector2(0.000000F,-2.042219F),
				new Vector2(-0.000000F,-3.370441F),
				new Vector2(-0.510388F,-4.703804F),
				new Vector2(-1.687297F,-5.892606F),
				new Vector2(-2.999344F,-6.787148F),
				new Vector2(-3.915147F,-7.311441F),
				new Vector2(-3.948318F,-7.742482F),
				new Vector2(-3.224567F,-8.127406F),
				new Vector2(-2.228431F,-8.468721F),
				new Vector2(-1.438722F,-8.768936F),
				new Vector2(-1.288914F,-9.030560F),
				new Vector2(-1.598686F,-9.256100F),
				new Vector2(-2.154637F,-9.448063F),
				new Vector2(-2.826861F,-9.608960F),
				new Vector2(-3.485454F,-9.741299F),
				new Vector2(-4.000507F,-9.847586F),
				new Vector2(-4.242117F,-9.930332F),
				new Vector2(-4.184897F,-9.992043F),
				new Vector2(-3.969568F,-10.035230F),
				new Vector2(-3.629241F,-10.062400F),
				new Vector2(-3.194572F,-10.076060F),
				new Vector2(-2.696223F,-10.078720F),
				new Vector2(-2.164850F,-10.072880F),
				new Vector2(-1.631112F,-10.061060F),
				new Vector2(-1.125667F,-10.045770F),
				new Vector2(-0.679176F,-10.029510F),
				new Vector2(-0.322295F,-10.014790F),
				new Vector2(-0.085683F,-10.004120F)
			}),

			new Weapon("LR-300", 120.000000F, new List<Vector2>()
			{
				new Vector2(0.098365F,-1.004928F),
				new Vector2(0.346953F,-2.248523F),
				new Vector2(0.751220F,-3.575346F),
				new Vector2(1.326888F,-4.829963F),
				new Vector2(1.958069F,-5.858609F),
				new Vector2(2.527623F,-6.687347F),
				new Vector2(2.918412F,-7.399671F),
				new Vector2(3.007762F,-8.005643F),
				new Vector2(2.641919F,-8.515327F),
				new Vector2(1.950645F,-8.938788F),
				new Vector2(1.144313F,-9.286088F),
				new Vector2(0.433297F,-9.567291F),
				new Vector2(0.027970F,-9.793953F),
				new Vector2(0.045506F,-9.992137F),
				new Vector2(0.268510F,-10.170170F),
				new Vector2(0.640880F,-10.330370F),
				new Vector2(1.127565F,-10.475050F),
				new Vector2(1.693516F,-10.606540F),
				new Vector2(2.303682F,-10.727160F),
				new Vector2(2.923013F,-10.839230F),
				new Vector2(3.516459F,-10.945060F),
				new Vector2(4.048970F,-11.046990F),
				new Vector2(4.485496F,-11.147320F),
				new Vector2(4.790986F,-11.248380F),
				new Vector2(4.926560F,-11.352490F),
				new Vector2(4.387823F,-11.461970F),
				new Vector2(3.162740F,-11.579140F),
				new Vector2(1.714368F,-11.706320F),
				new Vector2(0.505769F,-11.845840F)
			})
		};
	}
}