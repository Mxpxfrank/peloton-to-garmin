﻿using Dynastream.Fit;
using System.Collections.Generic;
using System.Collections.Immutable;

namespace Conversion;

public static class ExerciseMapping
{
	public static IReadOnlyCollection<string> IgnoredPelotonExercises = new HashSet<string>() 
	{
		// A
		/* AMRAP */ "98cde50f696746ff98727d5362229cfb",

		// T
		/* Transition */ "a76c5edc0641475189442ecad456057a",

		// W
		/* Warmup */ "0b67e950426440fe8b4eadc426320a56",
	};

	public static readonly Dictionary<string, GarminExercise> StrengthExerciseMappings = new()
	{
		// A
		/* Arnold Press */ { "01251235527748368069f9dc898aadf3", new (ExerciseCategory.ShoulderPress, ShoulderPressExerciseName.ArnoldPress) },

		// B
		/* Bent Over Row */ { "d60a1dd8824a49a4926f826b24f3b061", new (ExerciseCategory.Row, RowExerciseName.OneArmBentOverRow) },
		/* Bicep Curl */ { "43d404595338443baab306a6589ae7fc", new (ExerciseCategory.Curl, CurlExerciseName.StandingDumbbellBicepsCurl) },
		/* Bird Dog */ { "df8e18c5082f408b8490c4adcb0678b5", new (ExerciseCategory.Plank, PlankExerciseName.PlankWithKneeToElbow) }, 

		// C
		/* Chest Fly */ { "45207949aa384783b5d71451f7fe1c3d", new (ExerciseCategory.Flye, FlyeExerciseName.DumbbellFlye) },
		/* Clam Shell */ { "5749daaf9be3448397af9d813d760ff3", new (ExerciseCategory.HipRaise, HipRaiseExerciseName.Clams) },
		/* Crunch */ { "61ac0d64602c48fba25af7e5e5dc1f97", new (ExerciseCategory.Crunch, CrunchExerciseName.Crunch) },
		/* Concentrated Curl */ { "3695ef0ec2ce484faedc8ce2bfa2819d", new (ExerciseCategory.Curl, CurlExerciseName.SeatedDumbbellBicepsCurl) },

		// D
		/* Dead Bug */ { "3001f790c7ca471e8ba6d1b57a3a842d", new (ExerciseCategory.HipStability, HipStabilityExerciseName.DeadBug) },
		/* Deadlift */ { "cd6046306b2c4c4a8f40e169ec924eb9", new (ExerciseCategory.Deadlift, DeadliftExerciseName.DumbbellDeadlift) },
		/* Dumbbell Squat */ { "7d82b59462a54e61926077ded0becae5", new (ExerciseCategory.Squat, SquatExerciseName.DumbbellSquat) },
		/* Dumbbell Thruster */ { "5ab0baeebee94d3995cb7f2b0332f430", new (ExerciseCategory.Squat, SquatExerciseName.Thrusters) },

		// F
		/* Flutter Kick */ { "6091566fa0674afd96a22fcec3ab18ce", new (ExerciseCategory.Crunch, CrunchExerciseName.FlutterKicks) },
		/* Forearm Side Plank */ { "1c0403c4d7264d83b1c75d18c8cdac4f", new (ExerciseCategory.Plank, PlankExerciseName.SidePlank) },
		/* ForeArm Plank */ { "feb44f24e2b8487b870a35f4501069be", new (ExerciseCategory.Plank, PlankExerciseName.Plank) },
		/* Front to Back Lunge */ { "ed18d837c14746c5af38d4fa03b56918", new (ExerciseCategory.Lunge, LungeExerciseName.DumbbellLunge) },

		// G
		/* Goblet Squat */ { "588e35f7067842979485ff1e4f80df26", new (ExerciseCategory.Squat,SquatExerciseName.GobletSquat) },

		// H
		/* Hammer Curl */ { "114ce849b47a4fabbaad961188bf4f7d", new (ExerciseCategory.Curl, CurlExerciseName.DumbbellHammerCurl) },
		/* High Plank */ { "194cc4f6a88c4abd80afe9bbddb25915", new (ExerciseCategory.Plank, PlankExerciseName.StraightArmPlank) },
		/* Hip Bridge */ { "06a504988ace45faabd927af1479f454", new (ExerciseCategory.HipRaise, HipRaiseExerciseName.BarbellHipThrustOnFloor) },
		/* Hollow Hold */ { "060174b84e3744e6a19fe4ce80411113", new (ExerciseCategory.Crunch, CrunchExerciseName.HollowRock) },
		/* Hollow Rock */ { "b264d06330c5442d83ffeaff878cf31d", new (ExerciseCategory.Crunch, CrunchExerciseName.HollowRock) },

		// L
		/* Lateral Lunge */ { "fb63e1ea19264145ae6856eefacbcb22", new (ExerciseCategory.Lunge, LungeExerciseName.SlidingLateralLunge)},
		/* Leg Lift */ { "7a5f7d80783f4b77b44dad8d6a0d2fae", new (ExerciseCategory.HipRaise, HipRaiseExerciseName.LegLift)},

		// N
		/* Neutral Grip Chest Press */ { "802f10996b5048d08f320d8661f13ee1", new (ExerciseCategory.BenchPress, BenchPressExerciseName.NeutralGripDumbbellBenchPress) },

		// O
		/* Overhead Carry */ { "12057d5f9e144913a824bcae5706966c", new (ExerciseCategory.Carry, CarryExerciseName.OverheadCarry) },
		/* Overhead Extension */ { "f260623343e74d37b165071ee5903199", new (ExerciseCategory.TricepsExtension, TricepsExtensionExerciseName.OverheadDumbbellTricepsExtension) },
		/* Overhead Press */ { "ef0279948228409298cd6bf62c5b122c", new (ExerciseCategory.ShoulderPress, ShoulderPressExerciseName.OverheadDumbbellPress) },

		// P
		/* Push Up */ { "1c4d81ad487849a6995f93e1a6a4b1e4", new (ExerciseCategory.PushUp, PushUpExerciseName.PushUp) },

		// R
		/* Roll Up */ { "0b853e45afb04c31968b20fc7deaa718", new (ExerciseCategory.Core, CoreExerciseName.RollUp) },
		/* Romanian Deadlift */ { "a17b8d35d1264a2fbabe3ab28df458dc", new (ExerciseCategory.Deadlift, DeadliftExerciseName.DumbbellDeadlift) },// RDL exists in Connect but can't find it here in SDK
		/* Russian Twist */ { "5c7b2bc65abc4c44849e2119f1338120", new (ExerciseCategory.Core, CoreExerciseName.RussianTwist) },
		/* Reverse Lunge */ { "c430accc3802486a86ad2de9cb8f01cc", new (ExerciseCategory.Lunge, LungeExerciseName.ReverseSlidingLunge) },

		// S
		/* Scissor Kick */ { "f6a10df381004afba2a2b63447d9968f", new (ExerciseCategory.Crunch, CrunchExerciseName.LegLevers) },
		/* Shoulder Tap */ { "5b33283433e7479390c0d5fc11722f80", new (ExerciseCategory.Plank, PlankExerciseName.StraightArmPlankWithShoulderTouch) },
		/* Skull Crusher */ { "3c72e60de73d43f4b5a774c90dea90cd", new (ExerciseCategory.TricepsExtension, TricepsExtensionExerciseName.DumbbellLyingTricepsExtension) },
		/* Snatch */ { "0ddf8f94acfe4c2289aef5a9bf59e8d9", new (ExerciseCategory.OlympicLift, OlympicLiftExerciseName.SingleArmDumbbellSnatch) },
		/* Split Squat */ { "28833fd99466476ea273d6b94747e3db", new (ExerciseCategory.Squat, SquatExerciseName.DumbbellSplitSquat) },

		// T
		/* Table Top Lateral Leg Lift */ { "5bb2d37f052e4d2faf1b0f1de4489531", new (ExerciseCategory.Plank, PlankExerciseName.KneelingSidePlankWithLegLift) },
		/* Tricep Kickback */ { "da89d743904640d58e8b3f667f08783c", new (ExerciseCategory.TricepsExtension, TricepsExtensionExerciseName.DumbbellKickback) },
		/* Tuck up */ { "3069e7ba28b84005b71c16a3781dda8d", new (ExerciseCategory.SitUp, SitUpExerciseName.BentKneeVUp) },
		/* Twisting Mountain Climber */ { "cc70d143627c45e5b64e2cb116619899", new (ExerciseCategory.Plank, PlankExerciseName.CrossBodyMountainClimber) },

		// V
		/* V-Up */ { "715caba11593427299342c378b444e05", new(ExerciseCategory.SitUp, SitUpExerciseName.VUp) },

		// W
		/* Wide Grip Bent Over Row */ { "d861cb497fcc4e1cba994b7a949a3bac", new (ExerciseCategory.Row, RowExerciseName.WideGripSeatedCableRow) },
		/* Wide Grip Overhead Press */ { "258884d9586b45b3973228147a6b0c48", new (ExerciseCategory.ShoulderPress, ShoulderPressExerciseName.OverheadDumbbellPress) },
	};

	public static bool IsRest(this string pelotonExerciseId)
	{
		return pelotonExerciseId == "3ca251f6d68746ad91aebea5c89694ca";
	}
}

public record GarminExercise
{
	public ushort ExerciseCategory { get; init; }
	public ushort ExerciseName { get; init; }

	public GarminExercise(ushort exerciseCategory, ushort exerciseName)
	{
		ExerciseCategory = exerciseCategory;
		ExerciseName = exerciseName;
	}
}
