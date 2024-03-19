using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	// Token: 0x02000017 RID: 23
	public class vtkDICOMVM : WrappedObject
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06000351 RID: 849 RVA: 0x0000BEBA File Offset: 0x0000A0BA
		static vtkDICOMVM()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkDICOMVM.MRClassNameKey, Type.GetType("Kitware.VTK.vtkDICOMVM"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06000352 RID: 850 RVA: 0x0000BEE2 File Offset: 0x0000A0E2
		public vtkDICOMVM(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06000353 RID: 851 RVA: 0x0000BEF0 File Offset: 0x0000A0F0
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06000354 RID: 852
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDICOMVM_GetMax_01(HandleRef pThis);

		// Token: 0x06000355 RID: 853 RVA: 0x0000BEFC File Offset: 0x0000A0FC
		public int GetMax()
		{
			return vtkDICOMVM.vtkDICOMVM_GetMax_01(base.GetCppThis());
		}

		// Token: 0x06000356 RID: 854
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDICOMVM_GetMin_02(HandleRef pThis);

		// Token: 0x06000357 RID: 855 RVA: 0x0000BF1C File Offset: 0x0000A11C
		public int GetMin()
		{
			return vtkDICOMVM.vtkDICOMVM_GetMin_02(base.GetCppThis());
		}

		// Token: 0x06000358 RID: 856
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDICOMVM_GetStep_03(HandleRef pThis);

		// Token: 0x06000359 RID: 857 RVA: 0x0000BF3C File Offset: 0x0000A13C
		public int GetStep()
		{
			return vtkDICOMVM.vtkDICOMVM_GetStep_03(base.GetCppThis());
		}

		// Token: 0x0600035A RID: 858
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkDICOMVM_IsValid_04(HandleRef pThis);

		// Token: 0x0600035B RID: 859 RVA: 0x0000BF5C File Offset: 0x0000A15C
		public bool IsValid()
		{
			return vtkDICOMVM.vtkDICOMVM_IsValid_04(base.GetCppThis()) != 0;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400016C RID: 364
		public new const string MRFullTypeName = "Kitware.VTK.vtkDICOMVM";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400016D RID: 365
		public new static readonly string MRClassNameKey = "class vtkDICOMVM";

		// Token: 0x02000018 RID: 24
		public enum EnumType
		{
			/// <summary>enum member</summary>
			// Token: 0x0400016F RID: 367
			M0,
			/// <summary>enum member</summary>
			// Token: 0x04000170 RID: 368
			M0T1,
			/// <summary>enum member</summary>
			// Token: 0x04000171 RID: 369
			M0T10 = 10,
			/// <summary>enum member</summary>
			// Token: 0x04000172 RID: 370
			M0T11,
			/// <summary>enum member</summary>
			// Token: 0x04000173 RID: 371
			M0T12,
			/// <summary>enum member</summary>
			// Token: 0x04000174 RID: 372
			M0T13,
			/// <summary>enum member</summary>
			// Token: 0x04000175 RID: 373
			M0T14,
			/// <summary>enum member</summary>
			// Token: 0x04000176 RID: 374
			M0T15,
			/// <summary>enum member</summary>
			// Token: 0x04000177 RID: 375
			M0T16,
			/// <summary>enum member</summary>
			// Token: 0x04000178 RID: 376
			M0T17,
			/// <summary>enum member</summary>
			// Token: 0x04000179 RID: 377
			M0T18,
			/// <summary>enum member</summary>
			// Token: 0x0400017A RID: 378
			M0T19,
			/// <summary>enum member</summary>
			// Token: 0x0400017B RID: 379
			M0T2 = 2,
			/// <summary>enum member</summary>
			// Token: 0x0400017C RID: 380
			M0T20 = 20,
			/// <summary>enum member</summary>
			// Token: 0x0400017D RID: 381
			M0T21,
			/// <summary>enum member</summary>
			// Token: 0x0400017E RID: 382
			M0T22,
			/// <summary>enum member</summary>
			// Token: 0x0400017F RID: 383
			M0T23,
			/// <summary>enum member</summary>
			// Token: 0x04000180 RID: 384
			M0T24,
			/// <summary>enum member</summary>
			// Token: 0x04000181 RID: 385
			M0T25,
			/// <summary>enum member</summary>
			// Token: 0x04000182 RID: 386
			M0T26,
			/// <summary>enum member</summary>
			// Token: 0x04000183 RID: 387
			M0T27,
			/// <summary>enum member</summary>
			// Token: 0x04000184 RID: 388
			M0T28,
			/// <summary>enum member</summary>
			// Token: 0x04000185 RID: 389
			M0T29,
			/// <summary>enum member</summary>
			// Token: 0x04000186 RID: 390
			M0T2N = 254,
			/// <summary>enum member</summary>
			// Token: 0x04000187 RID: 391
			M0T3 = 3,
			/// <summary>enum member</summary>
			// Token: 0x04000188 RID: 392
			M0T30 = 30,
			/// <summary>enum member</summary>
			// Token: 0x04000189 RID: 393
			M0T31,
			/// <summary>enum member</summary>
			// Token: 0x0400018A RID: 394
			M0T32,
			/// <summary>enum member</summary>
			// Token: 0x0400018B RID: 395
			M0T3N = 253,
			/// <summary>enum member</summary>
			// Token: 0x0400018C RID: 396
			M0T4 = 4,
			/// <summary>enum member</summary>
			// Token: 0x0400018D RID: 397
			M0T4N = 252,
			/// <summary>enum member</summary>
			// Token: 0x0400018E RID: 398
			M0T5 = 5,
			/// <summary>enum member</summary>
			// Token: 0x0400018F RID: 399
			M0T6,
			/// <summary>enum member</summary>
			// Token: 0x04000190 RID: 400
			M0T63 = 63,
			/// <summary>enum member</summary>
			// Token: 0x04000191 RID: 401
			M0T64,
			/// <summary>enum member</summary>
			// Token: 0x04000192 RID: 402
			M0T7 = 7,
			/// <summary>enum member</summary>
			// Token: 0x04000193 RID: 403
			M0T8,
			/// <summary>enum member</summary>
			// Token: 0x04000194 RID: 404
			M0T9,
			/// <summary>enum member</summary>
			// Token: 0x04000195 RID: 405
			M0T99 = 99,
			/// <summary>enum member</summary>
			// Token: 0x04000196 RID: 406
			M0TN = 255,
			/// <summary>enum member</summary>
			// Token: 0x04000197 RID: 407
			M1 = 257,
			/// <summary>enum member</summary>
			// Token: 0x04000198 RID: 408
			M10 = 2570,
			/// <summary>enum member</summary>
			// Token: 0x04000199 RID: 409
			M100 = 25700,
			/// <summary>enum member</summary>
			// Token: 0x0400019A RID: 410
			M1024 = 33792,
			/// <summary>enum member</summary>
			// Token: 0x0400019B RID: 411
			M10TN = 2815,
			/// <summary>enum member</summary>
			// Token: 0x0400019C RID: 412
			M11 = 2827,
			/// <summary>enum member</summary>
			// Token: 0x0400019D RID: 413
			M110 = 28270,
			/// <summary>enum member</summary>
			// Token: 0x0400019E RID: 414
			M11TN = 3071,
			/// <summary>enum member</summary>
			// Token: 0x0400019F RID: 415
			M12 = 3084,
			/// <summary>enum member</summary>
			// Token: 0x040001A0 RID: 416
			M127 = 32639,
			/// <summary>enum member</summary>
			// Token: 0x040001A1 RID: 417
			M128 = 32896,
			/// <summary>enum member</summary>
			// Token: 0x040001A2 RID: 418
			M12TN = 3327,
			/// <summary>enum member</summary>
			// Token: 0x040001A3 RID: 419
			M13 = 3341,
			/// <summary>enum member</summary>
			// Token: 0x040001A4 RID: 420
			M13TN = 3583,
			/// <summary>enum member</summary>
			// Token: 0x040001A5 RID: 421
			M14 = 3598,
			/// <summary>enum member</summary>
			// Token: 0x040001A6 RID: 422
			M14TN = 3839,
			/// <summary>enum member</summary>
			// Token: 0x040001A7 RID: 423
			M15 = 3855,
			/// <summary>enum member</summary>
			// Token: 0x040001A8 RID: 424
			M15TN = 4095,
			/// <summary>enum member</summary>
			// Token: 0x040001A9 RID: 425
			M16 = 4112,
			/// <summary>enum member</summary>
			// Token: 0x040001AA RID: 426
			M16TN = 4351,
			/// <summary>enum member</summary>
			// Token: 0x040001AB RID: 427
			M17 = 4369,
			/// <summary>enum member</summary>
			// Token: 0x040001AC RID: 428
			M17TN = 4607,
			/// <summary>enum member</summary>
			// Token: 0x040001AD RID: 429
			M18 = 4626,
			/// <summary>enum member</summary>
			// Token: 0x040001AE RID: 430
			M18TN = 4863,
			/// <summary>enum member</summary>
			// Token: 0x040001AF RID: 431
			M19 = 4883,
			/// <summary>enum member</summary>
			// Token: 0x040001B0 RID: 432
			M19TN = 5119,
			/// <summary>enum member</summary>
			// Token: 0x040001B1 RID: 433
			M1T10 = 266,
			/// <summary>enum member</summary>
			// Token: 0x040001B2 RID: 434
			M1T11,
			/// <summary>enum member</summary>
			// Token: 0x040001B3 RID: 435
			M1T12,
			/// <summary>enum member</summary>
			// Token: 0x040001B4 RID: 436
			M1T13,
			/// <summary>enum member</summary>
			// Token: 0x040001B5 RID: 437
			M1T14,
			/// <summary>enum member</summary>
			// Token: 0x040001B6 RID: 438
			M1T15,
			/// <summary>enum member</summary>
			// Token: 0x040001B7 RID: 439
			M1T16,
			/// <summary>enum member</summary>
			// Token: 0x040001B8 RID: 440
			M1T17,
			/// <summary>enum member</summary>
			// Token: 0x040001B9 RID: 441
			M1T18,
			/// <summary>enum member</summary>
			// Token: 0x040001BA RID: 442
			M1T19,
			/// <summary>enum member</summary>
			// Token: 0x040001BB RID: 443
			M1T2 = 258,
			/// <summary>enum member</summary>
			// Token: 0x040001BC RID: 444
			M1T20 = 276,
			/// <summary>enum member</summary>
			// Token: 0x040001BD RID: 445
			M1T21,
			/// <summary>enum member</summary>
			// Token: 0x040001BE RID: 446
			M1T22,
			/// <summary>enum member</summary>
			// Token: 0x040001BF RID: 447
			M1T23,
			/// <summary>enum member</summary>
			// Token: 0x040001C0 RID: 448
			M1T24,
			/// <summary>enum member</summary>
			// Token: 0x040001C1 RID: 449
			M1T25,
			/// <summary>enum member</summary>
			// Token: 0x040001C2 RID: 450
			M1T26,
			/// <summary>enum member</summary>
			// Token: 0x040001C3 RID: 451
			M1T27,
			/// <summary>enum member</summary>
			// Token: 0x040001C4 RID: 452
			M1T28,
			/// <summary>enum member</summary>
			// Token: 0x040001C5 RID: 453
			M1T29,
			/// <summary>enum member</summary>
			// Token: 0x040001C6 RID: 454
			M1T3 = 259,
			/// <summary>enum member</summary>
			// Token: 0x040001C7 RID: 455
			M1T30 = 286,
			/// <summary>enum member</summary>
			// Token: 0x040001C8 RID: 456
			M1T31,
			/// <summary>enum member</summary>
			// Token: 0x040001C9 RID: 457
			M1T32,
			/// <summary>enum member</summary>
			// Token: 0x040001CA RID: 458
			M1T4 = 260,
			/// <summary>enum member</summary>
			// Token: 0x040001CB RID: 459
			M1T5,
			/// <summary>enum member</summary>
			// Token: 0x040001CC RID: 460
			M1T6,
			/// <summary>enum member</summary>
			// Token: 0x040001CD RID: 461
			M1T63 = 319,
			/// <summary>enum member</summary>
			// Token: 0x040001CE RID: 462
			M1T64,
			/// <summary>enum member</summary>
			// Token: 0x040001CF RID: 463
			M1T7 = 263,
			/// <summary>enum member</summary>
			// Token: 0x040001D0 RID: 464
			M1T8,
			/// <summary>enum member</summary>
			// Token: 0x040001D1 RID: 465
			M1T9,
			/// <summary>enum member</summary>
			// Token: 0x040001D2 RID: 466
			M1T99 = 355,
			/// <summary>enum member</summary>
			// Token: 0x040001D3 RID: 467
			M1TN = 511,
			/// <summary>enum member</summary>
			// Token: 0x040001D4 RID: 468
			M2 = 514,
			/// <summary>enum member</summary>
			// Token: 0x040001D5 RID: 469
			M20 = 5140,
			/// <summary>enum member</summary>
			// Token: 0x040001D6 RID: 470
			M2048 = 34816,
			/// <summary>enum member</summary>
			// Token: 0x040001D7 RID: 471
			M20TN = 5375,
			/// <summary>enum member</summary>
			// Token: 0x040001D8 RID: 472
			M21 = 5397,
			/// <summary>enum member</summary>
			// Token: 0x040001D9 RID: 473
			M21TN = 5631,
			/// <summary>enum member</summary>
			// Token: 0x040001DA RID: 474
			M22 = 5654,
			/// <summary>enum member</summary>
			// Token: 0x040001DB RID: 475
			M22TN = 5887,
			/// <summary>enum member</summary>
			// Token: 0x040001DC RID: 476
			M23 = 5911,
			/// <summary>enum member</summary>
			// Token: 0x040001DD RID: 477
			M23TN = 6143,
			/// <summary>enum member</summary>
			// Token: 0x040001DE RID: 478
			M24 = 6168,
			/// <summary>enum member</summary>
			// Token: 0x040001DF RID: 479
			M24TN = 6399,
			/// <summary>enum member</summary>
			// Token: 0x040001E0 RID: 480
			M25 = 6425,
			/// <summary>enum member</summary>
			// Token: 0x040001E1 RID: 481
			M255 = 33023,
			/// <summary>enum member</summary>
			// Token: 0x040001E2 RID: 482
			M256,
			/// <summary>enum member</summary>
			// Token: 0x040001E3 RID: 483
			M25TN = 6655,
			/// <summary>enum member</summary>
			// Token: 0x040001E4 RID: 484
			M26 = 6682,
			/// <summary>enum member</summary>
			// Token: 0x040001E5 RID: 485
			M26TN = 6911,
			/// <summary>enum member</summary>
			// Token: 0x040001E6 RID: 486
			M27 = 6939,
			/// <summary>enum member</summary>
			// Token: 0x040001E7 RID: 487
			M27TN = 7167,
			/// <summary>enum member</summary>
			// Token: 0x040001E8 RID: 488
			M28 = 7196,
			/// <summary>enum member</summary>
			// Token: 0x040001E9 RID: 489
			M28TN = 7423,
			/// <summary>enum member</summary>
			// Token: 0x040001EA RID: 490
			M29 = 7453,
			/// <summary>enum member</summary>
			// Token: 0x040001EB RID: 491
			M29TN = 7679,
			/// <summary>enum member</summary>
			// Token: 0x040001EC RID: 492
			M2T10 = 522,
			/// <summary>enum member</summary>
			// Token: 0x040001ED RID: 493
			M2T11,
			/// <summary>enum member</summary>
			// Token: 0x040001EE RID: 494
			M2T12,
			/// <summary>enum member</summary>
			// Token: 0x040001EF RID: 495
			M2T13,
			/// <summary>enum member</summary>
			// Token: 0x040001F0 RID: 496
			M2T14,
			/// <summary>enum member</summary>
			// Token: 0x040001F1 RID: 497
			M2T15,
			/// <summary>enum member</summary>
			// Token: 0x040001F2 RID: 498
			M2T16,
			/// <summary>enum member</summary>
			// Token: 0x040001F3 RID: 499
			M2T17,
			/// <summary>enum member</summary>
			// Token: 0x040001F4 RID: 500
			M2T18,
			/// <summary>enum member</summary>
			// Token: 0x040001F5 RID: 501
			M2T19,
			/// <summary>enum member</summary>
			// Token: 0x040001F6 RID: 502
			M2T20,
			/// <summary>enum member</summary>
			// Token: 0x040001F7 RID: 503
			M2T21,
			/// <summary>enum member</summary>
			// Token: 0x040001F8 RID: 504
			M2T22,
			/// <summary>enum member</summary>
			// Token: 0x040001F9 RID: 505
			M2T23,
			/// <summary>enum member</summary>
			// Token: 0x040001FA RID: 506
			M2T24,
			/// <summary>enum member</summary>
			// Token: 0x040001FB RID: 507
			M2T25,
			/// <summary>enum member</summary>
			// Token: 0x040001FC RID: 508
			M2T26,
			/// <summary>enum member</summary>
			// Token: 0x040001FD RID: 509
			M2T27,
			/// <summary>enum member</summary>
			// Token: 0x040001FE RID: 510
			M2T28,
			/// <summary>enum member</summary>
			// Token: 0x040001FF RID: 511
			M2T29,
			/// <summary>enum member</summary>
			// Token: 0x04000200 RID: 512
			M2T2N = 766,
			/// <summary>enum member</summary>
			// Token: 0x04000201 RID: 513
			M2T3 = 515,
			/// <summary>enum member</summary>
			// Token: 0x04000202 RID: 514
			M2T30 = 542,
			/// <summary>enum member</summary>
			// Token: 0x04000203 RID: 515
			M2T31,
			/// <summary>enum member</summary>
			// Token: 0x04000204 RID: 516
			M2T32,
			/// <summary>enum member</summary>
			// Token: 0x04000205 RID: 517
			M2T4 = 516,
			/// <summary>enum member</summary>
			// Token: 0x04000206 RID: 518
			M2T5,
			/// <summary>enum member</summary>
			// Token: 0x04000207 RID: 519
			M2T6,
			/// <summary>enum member</summary>
			// Token: 0x04000208 RID: 520
			M2T63 = 575,
			/// <summary>enum member</summary>
			// Token: 0x04000209 RID: 521
			M2T64,
			/// <summary>enum member</summary>
			// Token: 0x0400020A RID: 522
			M2T7 = 519,
			/// <summary>enum member</summary>
			// Token: 0x0400020B RID: 523
			M2T8,
			/// <summary>enum member</summary>
			// Token: 0x0400020C RID: 524
			M2T9,
			/// <summary>enum member</summary>
			// Token: 0x0400020D RID: 525
			M2T99 = 611,
			/// <summary>enum member</summary>
			// Token: 0x0400020E RID: 526
			M2TN = 767,
			/// <summary>enum member</summary>
			// Token: 0x0400020F RID: 527
			M3 = 771,
			/// <summary>enum member</summary>
			// Token: 0x04000210 RID: 528
			M30 = 7710,
			/// <summary>enum member</summary>
			// Token: 0x04000211 RID: 529
			M30T30N = 7906,
			/// <summary>enum member</summary>
			// Token: 0x04000212 RID: 530
			M30TN = 7935,
			/// <summary>enum member</summary>
			// Token: 0x04000213 RID: 531
			M31 = 7967,
			/// <summary>enum member</summary>
			// Token: 0x04000214 RID: 532
			M31TN = 8191,
			/// <summary>enum member</summary>
			// Token: 0x04000215 RID: 533
			M32 = 8224,
			/// <summary>enum member</summary>
			// Token: 0x04000216 RID: 534
			M32TN = 8447,
			/// <summary>enum member</summary>
			// Token: 0x04000217 RID: 535
			M35 = 8995,
			/// <summary>enum member</summary>
			// Token: 0x04000218 RID: 536
			M35TN = 9215,
			/// <summary>enum member</summary>
			// Token: 0x04000219 RID: 537
			M3T10 = 778,
			/// <summary>enum member</summary>
			// Token: 0x0400021A RID: 538
			M3T11,
			/// <summary>enum member</summary>
			// Token: 0x0400021B RID: 539
			M3T12,
			/// <summary>enum member</summary>
			// Token: 0x0400021C RID: 540
			M3T13,
			/// <summary>enum member</summary>
			// Token: 0x0400021D RID: 541
			M3T14,
			/// <summary>enum member</summary>
			// Token: 0x0400021E RID: 542
			M3T15,
			/// <summary>enum member</summary>
			// Token: 0x0400021F RID: 543
			M3T16,
			/// <summary>enum member</summary>
			// Token: 0x04000220 RID: 544
			M3T17,
			/// <summary>enum member</summary>
			// Token: 0x04000221 RID: 545
			M3T18,
			/// <summary>enum member</summary>
			// Token: 0x04000222 RID: 546
			M3T19,
			/// <summary>enum member</summary>
			// Token: 0x04000223 RID: 547
			M3T20,
			/// <summary>enum member</summary>
			// Token: 0x04000224 RID: 548
			M3T21,
			/// <summary>enum member</summary>
			// Token: 0x04000225 RID: 549
			M3T22,
			/// <summary>enum member</summary>
			// Token: 0x04000226 RID: 550
			M3T23,
			/// <summary>enum member</summary>
			// Token: 0x04000227 RID: 551
			M3T24,
			/// <summary>enum member</summary>
			// Token: 0x04000228 RID: 552
			M3T25,
			/// <summary>enum member</summary>
			// Token: 0x04000229 RID: 553
			M3T26,
			/// <summary>enum member</summary>
			// Token: 0x0400022A RID: 554
			M3T27,
			/// <summary>enum member</summary>
			// Token: 0x0400022B RID: 555
			M3T28,
			/// <summary>enum member</summary>
			// Token: 0x0400022C RID: 556
			M3T29,
			/// <summary>enum member</summary>
			// Token: 0x0400022D RID: 557
			M3T30,
			/// <summary>enum member</summary>
			// Token: 0x0400022E RID: 558
			M3T31,
			/// <summary>enum member</summary>
			// Token: 0x0400022F RID: 559
			M3T32,
			/// <summary>enum member</summary>
			// Token: 0x04000230 RID: 560
			M3T3N = 1021,
			/// <summary>enum member</summary>
			// Token: 0x04000231 RID: 561
			M3T4 = 772,
			/// <summary>enum member</summary>
			// Token: 0x04000232 RID: 562
			M3T5,
			/// <summary>enum member</summary>
			// Token: 0x04000233 RID: 563
			M3T6,
			/// <summary>enum member</summary>
			// Token: 0x04000234 RID: 564
			M3T63 = 831,
			/// <summary>enum member</summary>
			// Token: 0x04000235 RID: 565
			M3T64,
			/// <summary>enum member</summary>
			// Token: 0x04000236 RID: 566
			M3T7 = 775,
			/// <summary>enum member</summary>
			// Token: 0x04000237 RID: 567
			M3T8,
			/// <summary>enum member</summary>
			// Token: 0x04000238 RID: 568
			M3T9,
			/// <summary>enum member</summary>
			// Token: 0x04000239 RID: 569
			M3T99 = 867,
			/// <summary>enum member</summary>
			// Token: 0x0400023A RID: 570
			M3TN = 1023,
			/// <summary>enum member</summary>
			// Token: 0x0400023B RID: 571
			M4 = 1028,
			/// <summary>enum member</summary>
			// Token: 0x0400023C RID: 572
			M4096 = 36864,
			/// <summary>enum member</summary>
			// Token: 0x0400023D RID: 573
			M47 = 12079,
			/// <summary>enum member</summary>
			// Token: 0x0400023E RID: 574
			M47T47N = 12241,
			/// <summary>enum member</summary>
			// Token: 0x0400023F RID: 575
			M47TN = 12287,
			/// <summary>enum member</summary>
			// Token: 0x04000240 RID: 576
			M4T10 = 1034,
			/// <summary>enum member</summary>
			// Token: 0x04000241 RID: 577
			M4T11,
			/// <summary>enum member</summary>
			// Token: 0x04000242 RID: 578
			M4T12,
			/// <summary>enum member</summary>
			// Token: 0x04000243 RID: 579
			M4T13,
			/// <summary>enum member</summary>
			// Token: 0x04000244 RID: 580
			M4T14,
			/// <summary>enum member</summary>
			// Token: 0x04000245 RID: 581
			M4T15,
			/// <summary>enum member</summary>
			// Token: 0x04000246 RID: 582
			M4T16,
			/// <summary>enum member</summary>
			// Token: 0x04000247 RID: 583
			M4T17,
			/// <summary>enum member</summary>
			// Token: 0x04000248 RID: 584
			M4T18,
			/// <summary>enum member</summary>
			// Token: 0x04000249 RID: 585
			M4T19,
			/// <summary>enum member</summary>
			// Token: 0x0400024A RID: 586
			M4T20,
			/// <summary>enum member</summary>
			// Token: 0x0400024B RID: 587
			M4T21,
			/// <summary>enum member</summary>
			// Token: 0x0400024C RID: 588
			M4T22,
			/// <summary>enum member</summary>
			// Token: 0x0400024D RID: 589
			M4T23,
			/// <summary>enum member</summary>
			// Token: 0x0400024E RID: 590
			M4T24,
			/// <summary>enum member</summary>
			// Token: 0x0400024F RID: 591
			M4T25,
			/// <summary>enum member</summary>
			// Token: 0x04000250 RID: 592
			M4T26,
			/// <summary>enum member</summary>
			// Token: 0x04000251 RID: 593
			M4T27,
			/// <summary>enum member</summary>
			// Token: 0x04000252 RID: 594
			M4T28,
			/// <summary>enum member</summary>
			// Token: 0x04000253 RID: 595
			M4T29,
			/// <summary>enum member</summary>
			// Token: 0x04000254 RID: 596
			M4T30,
			/// <summary>enum member</summary>
			// Token: 0x04000255 RID: 597
			M4T31,
			/// <summary>enum member</summary>
			// Token: 0x04000256 RID: 598
			M4T32,
			/// <summary>enum member</summary>
			// Token: 0x04000257 RID: 599
			M4T4N = 1276,
			/// <summary>enum member</summary>
			// Token: 0x04000258 RID: 600
			M4T5 = 1029,
			/// <summary>enum member</summary>
			// Token: 0x04000259 RID: 601
			M4T6,
			/// <summary>enum member</summary>
			// Token: 0x0400025A RID: 602
			M4T63 = 1087,
			/// <summary>enum member</summary>
			// Token: 0x0400025B RID: 603
			M4T64,
			/// <summary>enum member</summary>
			// Token: 0x0400025C RID: 604
			M4T7 = 1031,
			/// <summary>enum member</summary>
			// Token: 0x0400025D RID: 605
			M4T8,
			/// <summary>enum member</summary>
			// Token: 0x0400025E RID: 606
			M4T9,
			/// <summary>enum member</summary>
			// Token: 0x0400025F RID: 607
			M4T99 = 1123,
			/// <summary>enum member</summary>
			// Token: 0x04000260 RID: 608
			M4TN = 1279,
			/// <summary>enum member</summary>
			// Token: 0x04000261 RID: 609
			M5 = 1285,
			/// <summary>enum member</summary>
			// Token: 0x04000262 RID: 610
			M511 = 33279,
			/// <summary>enum member</summary>
			// Token: 0x04000263 RID: 611
			M512,
			/// <summary>enum member</summary>
			// Token: 0x04000264 RID: 612
			M5T10 = 1290,
			/// <summary>enum member</summary>
			// Token: 0x04000265 RID: 613
			M5T11,
			/// <summary>enum member</summary>
			// Token: 0x04000266 RID: 614
			M5T12,
			/// <summary>enum member</summary>
			// Token: 0x04000267 RID: 615
			M5T13,
			/// <summary>enum member</summary>
			// Token: 0x04000268 RID: 616
			M5T14,
			/// <summary>enum member</summary>
			// Token: 0x04000269 RID: 617
			M5T15,
			/// <summary>enum member</summary>
			// Token: 0x0400026A RID: 618
			M5T16,
			/// <summary>enum member</summary>
			// Token: 0x0400026B RID: 619
			M5T17,
			/// <summary>enum member</summary>
			// Token: 0x0400026C RID: 620
			M5T18,
			/// <summary>enum member</summary>
			// Token: 0x0400026D RID: 621
			M5T19,
			/// <summary>enum member</summary>
			// Token: 0x0400026E RID: 622
			M5T20,
			/// <summary>enum member</summary>
			// Token: 0x0400026F RID: 623
			M5T21,
			/// <summary>enum member</summary>
			// Token: 0x04000270 RID: 624
			M5T22,
			/// <summary>enum member</summary>
			// Token: 0x04000271 RID: 625
			M5T23,
			/// <summary>enum member</summary>
			// Token: 0x04000272 RID: 626
			M5T24,
			/// <summary>enum member</summary>
			// Token: 0x04000273 RID: 627
			M5T25,
			/// <summary>enum member</summary>
			// Token: 0x04000274 RID: 628
			M5T26,
			/// <summary>enum member</summary>
			// Token: 0x04000275 RID: 629
			M5T27,
			/// <summary>enum member</summary>
			// Token: 0x04000276 RID: 630
			M5T28,
			/// <summary>enum member</summary>
			// Token: 0x04000277 RID: 631
			M5T29,
			/// <summary>enum member</summary>
			// Token: 0x04000278 RID: 632
			M5T30,
			/// <summary>enum member</summary>
			// Token: 0x04000279 RID: 633
			M5T31,
			/// <summary>enum member</summary>
			// Token: 0x0400027A RID: 634
			M5T32,
			/// <summary>enum member</summary>
			// Token: 0x0400027B RID: 635
			M5T5N = 1531,
			/// <summary>enum member</summary>
			// Token: 0x0400027C RID: 636
			M5T6 = 1286,
			/// <summary>enum member</summary>
			// Token: 0x0400027D RID: 637
			M5T63 = 1343,
			/// <summary>enum member</summary>
			// Token: 0x0400027E RID: 638
			M5T64,
			/// <summary>enum member</summary>
			// Token: 0x0400027F RID: 639
			M5T7 = 1287,
			/// <summary>enum member</summary>
			// Token: 0x04000280 RID: 640
			M5T8,
			/// <summary>enum member</summary>
			// Token: 0x04000281 RID: 641
			M5T9,
			/// <summary>enum member</summary>
			// Token: 0x04000282 RID: 642
			M5T99 = 1379,
			/// <summary>enum member</summary>
			// Token: 0x04000283 RID: 643
			M5TN = 1535,
			/// <summary>enum member</summary>
			// Token: 0x04000284 RID: 644
			M6 = 1542,
			/// <summary>enum member</summary>
			// Token: 0x04000285 RID: 645
			M63 = 16191,
			/// <summary>enum member</summary>
			// Token: 0x04000286 RID: 646
			M63TN = 16383,
			/// <summary>enum member</summary>
			// Token: 0x04000287 RID: 647
			M64 = 16448,
			/// <summary>enum member</summary>
			// Token: 0x04000288 RID: 648
			M64TN = 16639,
			/// <summary>enum member</summary>
			// Token: 0x04000289 RID: 649
			M6T10 = 1546,
			/// <summary>enum member</summary>
			// Token: 0x0400028A RID: 650
			M6T11,
			/// <summary>enum member</summary>
			// Token: 0x0400028B RID: 651
			M6T12,
			/// <summary>enum member</summary>
			// Token: 0x0400028C RID: 652
			M6T13,
			/// <summary>enum member</summary>
			// Token: 0x0400028D RID: 653
			M6T14,
			/// <summary>enum member</summary>
			// Token: 0x0400028E RID: 654
			M6T15,
			/// <summary>enum member</summary>
			// Token: 0x0400028F RID: 655
			M6T16,
			/// <summary>enum member</summary>
			// Token: 0x04000290 RID: 656
			M6T17,
			/// <summary>enum member</summary>
			// Token: 0x04000291 RID: 657
			M6T18,
			/// <summary>enum member</summary>
			// Token: 0x04000292 RID: 658
			M6T19,
			/// <summary>enum member</summary>
			// Token: 0x04000293 RID: 659
			M6T20,
			/// <summary>enum member</summary>
			// Token: 0x04000294 RID: 660
			M6T21,
			/// <summary>enum member</summary>
			// Token: 0x04000295 RID: 661
			M6T22,
			/// <summary>enum member</summary>
			// Token: 0x04000296 RID: 662
			M6T23,
			/// <summary>enum member</summary>
			// Token: 0x04000297 RID: 663
			M6T24,
			/// <summary>enum member</summary>
			// Token: 0x04000298 RID: 664
			M6T25,
			/// <summary>enum member</summary>
			// Token: 0x04000299 RID: 665
			M6T26,
			/// <summary>enum member</summary>
			// Token: 0x0400029A RID: 666
			M6T27,
			/// <summary>enum member</summary>
			// Token: 0x0400029B RID: 667
			M6T28,
			/// <summary>enum member</summary>
			// Token: 0x0400029C RID: 668
			M6T29,
			/// <summary>enum member</summary>
			// Token: 0x0400029D RID: 669
			M6T30,
			/// <summary>enum member</summary>
			// Token: 0x0400029E RID: 670
			M6T31,
			/// <summary>enum member</summary>
			// Token: 0x0400029F RID: 671
			M6T32,
			/// <summary>enum member</summary>
			// Token: 0x040002A0 RID: 672
			M6T63 = 1599,
			/// <summary>enum member</summary>
			// Token: 0x040002A1 RID: 673
			M6T64,
			/// <summary>enum member</summary>
			// Token: 0x040002A2 RID: 674
			M6T6N = 1786,
			/// <summary>enum member</summary>
			// Token: 0x040002A3 RID: 675
			M6T7 = 1543,
			/// <summary>enum member</summary>
			// Token: 0x040002A4 RID: 676
			M6T8,
			/// <summary>enum member</summary>
			// Token: 0x040002A5 RID: 677
			M6T9,
			/// <summary>enum member</summary>
			// Token: 0x040002A6 RID: 678
			M6T99 = 1635,
			/// <summary>enum member</summary>
			// Token: 0x040002A7 RID: 679
			M6TN = 1791,
			/// <summary>enum member</summary>
			// Token: 0x040002A8 RID: 680
			M7 = 1799,
			/// <summary>enum member</summary>
			// Token: 0x040002A9 RID: 681
			M768 = 33536,
			/// <summary>enum member</summary>
			// Token: 0x040002AA RID: 682
			M7T10 = 1802,
			/// <summary>enum member</summary>
			// Token: 0x040002AB RID: 683
			M7T11,
			/// <summary>enum member</summary>
			// Token: 0x040002AC RID: 684
			M7T12,
			/// <summary>enum member</summary>
			// Token: 0x040002AD RID: 685
			M7T13,
			/// <summary>enum member</summary>
			// Token: 0x040002AE RID: 686
			M7T14,
			/// <summary>enum member</summary>
			// Token: 0x040002AF RID: 687
			M7T15,
			/// <summary>enum member</summary>
			// Token: 0x040002B0 RID: 688
			M7T16,
			/// <summary>enum member</summary>
			// Token: 0x040002B1 RID: 689
			M7T17,
			/// <summary>enum member</summary>
			// Token: 0x040002B2 RID: 690
			M7T18,
			/// <summary>enum member</summary>
			// Token: 0x040002B3 RID: 691
			M7T19,
			/// <summary>enum member</summary>
			// Token: 0x040002B4 RID: 692
			M7T20,
			/// <summary>enum member</summary>
			// Token: 0x040002B5 RID: 693
			M7T21,
			/// <summary>enum member</summary>
			// Token: 0x040002B6 RID: 694
			M7T22,
			/// <summary>enum member</summary>
			// Token: 0x040002B7 RID: 695
			M7T23,
			/// <summary>enum member</summary>
			// Token: 0x040002B8 RID: 696
			M7T24,
			/// <summary>enum member</summary>
			// Token: 0x040002B9 RID: 697
			M7T25,
			/// <summary>enum member</summary>
			// Token: 0x040002BA RID: 698
			M7T26,
			/// <summary>enum member</summary>
			// Token: 0x040002BB RID: 699
			M7T27,
			/// <summary>enum member</summary>
			// Token: 0x040002BC RID: 700
			M7T28,
			/// <summary>enum member</summary>
			// Token: 0x040002BD RID: 701
			M7T29,
			/// <summary>enum member</summary>
			// Token: 0x040002BE RID: 702
			M7T30,
			/// <summary>enum member</summary>
			// Token: 0x040002BF RID: 703
			M7T31,
			/// <summary>enum member</summary>
			// Token: 0x040002C0 RID: 704
			M7T32,
			/// <summary>enum member</summary>
			// Token: 0x040002C1 RID: 705
			M7T63 = 1855,
			/// <summary>enum member</summary>
			// Token: 0x040002C2 RID: 706
			M7T64,
			/// <summary>enum member</summary>
			// Token: 0x040002C3 RID: 707
			M7T7N = 2041,
			/// <summary>enum member</summary>
			// Token: 0x040002C4 RID: 708
			M7T8 = 1800,
			/// <summary>enum member</summary>
			// Token: 0x040002C5 RID: 709
			M7T9,
			/// <summary>enum member</summary>
			// Token: 0x040002C6 RID: 710
			M7T99 = 1891,
			/// <summary>enum member</summary>
			// Token: 0x040002C7 RID: 711
			M7TN = 2047,
			/// <summary>enum member</summary>
			// Token: 0x040002C8 RID: 712
			M8 = 2056,
			/// <summary>enum member</summary>
			// Token: 0x040002C9 RID: 713
			M8192 = 40960,
			/// <summary>enum member</summary>
			// Token: 0x040002CA RID: 714
			M8T10 = 2058,
			/// <summary>enum member</summary>
			// Token: 0x040002CB RID: 715
			M8T11,
			/// <summary>enum member</summary>
			// Token: 0x040002CC RID: 716
			M8T12,
			/// <summary>enum member</summary>
			// Token: 0x040002CD RID: 717
			M8T13,
			/// <summary>enum member</summary>
			// Token: 0x040002CE RID: 718
			M8T14,
			/// <summary>enum member</summary>
			// Token: 0x040002CF RID: 719
			M8T15,
			/// <summary>enum member</summary>
			// Token: 0x040002D0 RID: 720
			M8T16,
			/// <summary>enum member</summary>
			// Token: 0x040002D1 RID: 721
			M8T17,
			/// <summary>enum member</summary>
			// Token: 0x040002D2 RID: 722
			M8T18,
			/// <summary>enum member</summary>
			// Token: 0x040002D3 RID: 723
			M8T19,
			/// <summary>enum member</summary>
			// Token: 0x040002D4 RID: 724
			M8T20,
			/// <summary>enum member</summary>
			// Token: 0x040002D5 RID: 725
			M8T21,
			/// <summary>enum member</summary>
			// Token: 0x040002D6 RID: 726
			M8T22,
			/// <summary>enum member</summary>
			// Token: 0x040002D7 RID: 727
			M8T23,
			/// <summary>enum member</summary>
			// Token: 0x040002D8 RID: 728
			M8T24,
			/// <summary>enum member</summary>
			// Token: 0x040002D9 RID: 729
			M8T25,
			/// <summary>enum member</summary>
			// Token: 0x040002DA RID: 730
			M8T26,
			/// <summary>enum member</summary>
			// Token: 0x040002DB RID: 731
			M8T27,
			/// <summary>enum member</summary>
			// Token: 0x040002DC RID: 732
			M8T28,
			/// <summary>enum member</summary>
			// Token: 0x040002DD RID: 733
			M8T29,
			/// <summary>enum member</summary>
			// Token: 0x040002DE RID: 734
			M8T30,
			/// <summary>enum member</summary>
			// Token: 0x040002DF RID: 735
			M8T31,
			/// <summary>enum member</summary>
			// Token: 0x040002E0 RID: 736
			M8T32,
			/// <summary>enum member</summary>
			// Token: 0x040002E1 RID: 737
			M8T63 = 2111,
			/// <summary>enum member</summary>
			// Token: 0x040002E2 RID: 738
			M8T64,
			/// <summary>enum member</summary>
			// Token: 0x040002E3 RID: 739
			M8T8N = 2296,
			/// <summary>enum member</summary>
			// Token: 0x040002E4 RID: 740
			M8T9 = 2057,
			/// <summary>enum member</summary>
			// Token: 0x040002E5 RID: 741
			M8T99 = 2147,
			/// <summary>enum member</summary>
			// Token: 0x040002E6 RID: 742
			M8TN = 2303,
			/// <summary>enum member</summary>
			// Token: 0x040002E7 RID: 743
			M9 = 2313,
			/// <summary>enum member</summary>
			// Token: 0x040002E8 RID: 744
			M99 = 25443,
			/// <summary>enum member</summary>
			// Token: 0x040002E9 RID: 745
			M99TN = 25599,
			/// <summary>enum member</summary>
			// Token: 0x040002EA RID: 746
			M9T10 = 2314,
			/// <summary>enum member</summary>
			// Token: 0x040002EB RID: 747
			M9T11,
			/// <summary>enum member</summary>
			// Token: 0x040002EC RID: 748
			M9T12,
			/// <summary>enum member</summary>
			// Token: 0x040002ED RID: 749
			M9T13,
			/// <summary>enum member</summary>
			// Token: 0x040002EE RID: 750
			M9T14,
			/// <summary>enum member</summary>
			// Token: 0x040002EF RID: 751
			M9T15,
			/// <summary>enum member</summary>
			// Token: 0x040002F0 RID: 752
			M9T16,
			/// <summary>enum member</summary>
			// Token: 0x040002F1 RID: 753
			M9T17,
			/// <summary>enum member</summary>
			// Token: 0x040002F2 RID: 754
			M9T18,
			/// <summary>enum member</summary>
			// Token: 0x040002F3 RID: 755
			M9T19,
			/// <summary>enum member</summary>
			// Token: 0x040002F4 RID: 756
			M9T20,
			/// <summary>enum member</summary>
			// Token: 0x040002F5 RID: 757
			M9T21,
			/// <summary>enum member</summary>
			// Token: 0x040002F6 RID: 758
			M9T22,
			/// <summary>enum member</summary>
			// Token: 0x040002F7 RID: 759
			M9T23,
			/// <summary>enum member</summary>
			// Token: 0x040002F8 RID: 760
			M9T24,
			/// <summary>enum member</summary>
			// Token: 0x040002F9 RID: 761
			M9T25,
			/// <summary>enum member</summary>
			// Token: 0x040002FA RID: 762
			M9T26,
			/// <summary>enum member</summary>
			// Token: 0x040002FB RID: 763
			M9T27,
			/// <summary>enum member</summary>
			// Token: 0x040002FC RID: 764
			M9T28,
			/// <summary>enum member</summary>
			// Token: 0x040002FD RID: 765
			M9T29,
			/// <summary>enum member</summary>
			// Token: 0x040002FE RID: 766
			M9T30,
			/// <summary>enum member</summary>
			// Token: 0x040002FF RID: 767
			M9T31,
			/// <summary>enum member</summary>
			// Token: 0x04000300 RID: 768
			M9T32,
			/// <summary>enum member</summary>
			// Token: 0x04000301 RID: 769
			M9T63 = 2367,
			/// <summary>enum member</summary>
			// Token: 0x04000302 RID: 770
			M9T64,
			/// <summary>enum member</summary>
			// Token: 0x04000303 RID: 771
			M9T99 = 2403,
			/// <summary>enum member</summary>
			// Token: 0x04000304 RID: 772
			M9T9N = 2551,
			/// <summary>enum member</summary>
			// Token: 0x04000305 RID: 773
			M9TN = 2559
		}
	}
}
