using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///  vtkAvatar
	/// </summary>
	/// <remarks>
	///  Renders head and hands for a user in VR
	///
	/// Set position and orientation for the head and two hands,
	/// shows an observer where the avatar is looking and pointing.
	/// </remarks>
	// Token: 0x020000B8 RID: 184
	public class vtkAvatar : vtkActor
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06002886 RID: 10374 RVA: 0x0003BCE3 File Offset: 0x00039EE3
		static vtkAvatar()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkAvatar.MRClassNameKey, Type.GetType("Kitware.VTK.vtkAvatar"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06002887 RID: 10375 RVA: 0x0003BD0B File Offset: 0x00039F0B
		public vtkAvatar(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06002888 RID: 10376
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAvatar_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06002889 RID: 10377 RVA: 0x0003BD1C File Offset: 0x00039F1C
		public new static vtkAvatar New()
		{
			vtkAvatar result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkAvatar.vtkAvatar_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkAvatar)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600288A RID: 10378 RVA: 0x0003BD70 File Offset: 0x00039F70
		public vtkAvatar() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkAvatar.vtkAvatar_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600288B RID: 10379 RVA: 0x0003BDB4 File Offset: 0x00039FB4
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600288C RID: 10380
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAvatar_GetHeadOrientation_01(HandleRef pThis);

		/// <summary>
		/// Set/Get the head and hand transforms.
		/// </summary>
		// Token: 0x0600288D RID: 10381 RVA: 0x0003BDC0 File Offset: 0x00039FC0
		public virtual double[] GetHeadOrientation()
		{
			IntPtr intPtr = vtkAvatar.vtkAvatar_GetHeadOrientation_01(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x0600288E RID: 10382
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAvatar_GetHeadOrientation_02(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

		/// <summary>
		/// Set/Get the head and hand transforms.
		/// </summary>
		// Token: 0x0600288F RID: 10383 RVA: 0x0003BE08 File Offset: 0x0003A008
		public virtual void GetHeadOrientation(ref double _arg1, ref double _arg2, ref double _arg3)
		{
			vtkAvatar.vtkAvatar_GetHeadOrientation_02(base.GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
		}

		// Token: 0x06002890 RID: 10384
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAvatar_GetHeadOrientation_03(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Set/Get the head and hand transforms.
		/// </summary>
		// Token: 0x06002891 RID: 10385 RVA: 0x0003BE1A File Offset: 0x0003A01A
		public virtual void GetHeadOrientation(IntPtr _arg)
		{
			vtkAvatar.vtkAvatar_GetHeadOrientation_03(base.GetCppThis(), _arg);
		}

		// Token: 0x06002892 RID: 10386
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAvatar_GetHeadPosition_04(HandleRef pThis);

		/// <summary>
		/// Set/Get the head and hand transforms.
		/// </summary>
		// Token: 0x06002893 RID: 10387 RVA: 0x0003BE2C File Offset: 0x0003A02C
		public virtual double[] GetHeadPosition()
		{
			IntPtr intPtr = vtkAvatar.vtkAvatar_GetHeadPosition_04(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x06002894 RID: 10388
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAvatar_GetHeadPosition_05(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

		/// <summary>
		/// Set/Get the head and hand transforms.
		/// </summary>
		// Token: 0x06002895 RID: 10389 RVA: 0x0003BE74 File Offset: 0x0003A074
		public virtual void GetHeadPosition(ref double _arg1, ref double _arg2, ref double _arg3)
		{
			vtkAvatar.vtkAvatar_GetHeadPosition_05(base.GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
		}

		// Token: 0x06002896 RID: 10390
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAvatar_GetHeadPosition_06(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Set/Get the head and hand transforms.
		/// </summary>
		// Token: 0x06002897 RID: 10391 RVA: 0x0003BE86 File Offset: 0x0003A086
		public virtual void GetHeadPosition(IntPtr _arg)
		{
			vtkAvatar.vtkAvatar_GetHeadPosition_06(base.GetCppThis(), _arg);
		}

		// Token: 0x06002898 RID: 10392
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAvatar_GetLeftHandOrientation_07(HandleRef pThis);

		/// <summary>
		/// Set/Get the head and hand transforms.
		/// </summary>
		// Token: 0x06002899 RID: 10393 RVA: 0x0003BE98 File Offset: 0x0003A098
		public virtual double[] GetLeftHandOrientation()
		{
			IntPtr intPtr = vtkAvatar.vtkAvatar_GetLeftHandOrientation_07(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x0600289A RID: 10394
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAvatar_GetLeftHandOrientation_08(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

		/// <summary>
		/// Set/Get the head and hand transforms.
		/// </summary>
		// Token: 0x0600289B RID: 10395 RVA: 0x0003BEE0 File Offset: 0x0003A0E0
		public virtual void GetLeftHandOrientation(ref double _arg1, ref double _arg2, ref double _arg3)
		{
			vtkAvatar.vtkAvatar_GetLeftHandOrientation_08(base.GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
		}

		// Token: 0x0600289C RID: 10396
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAvatar_GetLeftHandOrientation_09(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Set/Get the head and hand transforms.
		/// </summary>
		// Token: 0x0600289D RID: 10397 RVA: 0x0003BEF2 File Offset: 0x0003A0F2
		public virtual void GetLeftHandOrientation(IntPtr _arg)
		{
			vtkAvatar.vtkAvatar_GetLeftHandOrientation_09(base.GetCppThis(), _arg);
		}

		// Token: 0x0600289E RID: 10398
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAvatar_GetLeftHandPosition_10(HandleRef pThis);

		/// <summary>
		/// Set/Get the head and hand transforms.
		/// </summary>
		// Token: 0x0600289F RID: 10399 RVA: 0x0003BF04 File Offset: 0x0003A104
		public virtual double[] GetLeftHandPosition()
		{
			IntPtr intPtr = vtkAvatar.vtkAvatar_GetLeftHandPosition_10(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x060028A0 RID: 10400
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAvatar_GetLeftHandPosition_11(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

		/// <summary>
		/// Set/Get the head and hand transforms.
		/// </summary>
		// Token: 0x060028A1 RID: 10401 RVA: 0x0003BF4C File Offset: 0x0003A14C
		public virtual void GetLeftHandPosition(ref double _arg1, ref double _arg2, ref double _arg3)
		{
			vtkAvatar.vtkAvatar_GetLeftHandPosition_11(base.GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
		}

		// Token: 0x060028A2 RID: 10402
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAvatar_GetLeftHandPosition_12(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Set/Get the head and hand transforms.
		/// </summary>
		// Token: 0x060028A3 RID: 10403 RVA: 0x0003BF5E File Offset: 0x0003A15E
		public virtual void GetLeftHandPosition(IntPtr _arg)
		{
			vtkAvatar.vtkAvatar_GetLeftHandPosition_12(base.GetCppThis(), _arg);
		}

		// Token: 0x060028A4 RID: 10404
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkAvatar_GetNumberOfGenerationsFromBase_13(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060028A5 RID: 10405 RVA: 0x0003BF70 File Offset: 0x0003A170
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkAvatar.vtkAvatar_GetNumberOfGenerationsFromBase_13(base.GetCppThis(), type);
		}

		// Token: 0x060028A6 RID: 10406
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkAvatar_GetNumberOfGenerationsFromBaseType_14([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060028A7 RID: 10407 RVA: 0x0003BF90 File Offset: 0x0003A190
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkAvatar.vtkAvatar_GetNumberOfGenerationsFromBaseType_14(type);
		}

		// Token: 0x060028A8 RID: 10408
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAvatar_GetRightHandOrientation_15(HandleRef pThis);

		/// <summary>
		/// Set/Get the head and hand transforms.
		/// </summary>
		// Token: 0x060028A9 RID: 10409 RVA: 0x0003BFAC File Offset: 0x0003A1AC
		public virtual double[] GetRightHandOrientation()
		{
			IntPtr intPtr = vtkAvatar.vtkAvatar_GetRightHandOrientation_15(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x060028AA RID: 10410
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAvatar_GetRightHandOrientation_16(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

		/// <summary>
		/// Set/Get the head and hand transforms.
		/// </summary>
		// Token: 0x060028AB RID: 10411 RVA: 0x0003BFF4 File Offset: 0x0003A1F4
		public virtual void GetRightHandOrientation(ref double _arg1, ref double _arg2, ref double _arg3)
		{
			vtkAvatar.vtkAvatar_GetRightHandOrientation_16(base.GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
		}

		// Token: 0x060028AC RID: 10412
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAvatar_GetRightHandOrientation_17(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Set/Get the head and hand transforms.
		/// </summary>
		// Token: 0x060028AD RID: 10413 RVA: 0x0003C006 File Offset: 0x0003A206
		public virtual void GetRightHandOrientation(IntPtr _arg)
		{
			vtkAvatar.vtkAvatar_GetRightHandOrientation_17(base.GetCppThis(), _arg);
		}

		// Token: 0x060028AE RID: 10414
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAvatar_GetRightHandPosition_18(HandleRef pThis);

		/// <summary>
		/// Set/Get the head and hand transforms.
		/// </summary>
		// Token: 0x060028AF RID: 10415 RVA: 0x0003C018 File Offset: 0x0003A218
		public virtual double[] GetRightHandPosition()
		{
			IntPtr intPtr = vtkAvatar.vtkAvatar_GetRightHandPosition_18(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x060028B0 RID: 10416
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAvatar_GetRightHandPosition_19(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

		/// <summary>
		/// Set/Get the head and hand transforms.
		/// </summary>
		// Token: 0x060028B1 RID: 10417 RVA: 0x0003C060 File Offset: 0x0003A260
		public virtual void GetRightHandPosition(ref double _arg1, ref double _arg2, ref double _arg3)
		{
			vtkAvatar.vtkAvatar_GetRightHandPosition_19(base.GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
		}

		// Token: 0x060028B2 RID: 10418
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAvatar_GetRightHandPosition_20(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Set/Get the head and hand transforms.
		/// </summary>
		// Token: 0x060028B3 RID: 10419 RVA: 0x0003C072 File Offset: 0x0003A272
		public virtual void GetRightHandPosition(IntPtr _arg)
		{
			vtkAvatar.vtkAvatar_GetRightHandPosition_20(base.GetCppThis(), _arg);
		}

		// Token: 0x060028B4 RID: 10420
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkAvatar_GetShowHandsOnly_21(HandleRef pThis);

		/// <summary>
		/// Show just the hands. Default false.
		/// </summary>
		// Token: 0x060028B5 RID: 10421 RVA: 0x0003C084 File Offset: 0x0003A284
		public virtual bool GetShowHandsOnly()
		{
			return vtkAvatar.vtkAvatar_GetShowHandsOnly_21(base.GetCppThis()) != 0;
		}

		// Token: 0x060028B6 RID: 10422
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAvatar_GetUpVector_22(HandleRef pThis);

		/// <summary>
		/// Up vector, in world coords. Must be normalized.
		/// </summary>
		// Token: 0x060028B7 RID: 10423 RVA: 0x0003C0AC File Offset: 0x0003A2AC
		public virtual double[] GetUpVector()
		{
			IntPtr intPtr = vtkAvatar.vtkAvatar_GetUpVector_22(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x060028B8 RID: 10424
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAvatar_GetUpVector_23(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

		/// <summary>
		/// Up vector, in world coords. Must be normalized.
		/// </summary>
		// Token: 0x060028B9 RID: 10425 RVA: 0x0003C0F4 File Offset: 0x0003A2F4
		public virtual void GetUpVector(ref double _arg1, ref double _arg2, ref double _arg3)
		{
			vtkAvatar.vtkAvatar_GetUpVector_23(base.GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
		}

		// Token: 0x060028BA RID: 10426
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAvatar_GetUpVector_24(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Up vector, in world coords. Must be normalized.
		/// </summary>
		// Token: 0x060028BB RID: 10427 RVA: 0x0003C106 File Offset: 0x0003A306
		public virtual void GetUpVector(IntPtr _arg)
		{
			vtkAvatar.vtkAvatar_GetUpVector_24(base.GetCppThis(), _arg);
		}

		// Token: 0x060028BC RID: 10428
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkAvatar_GetUseLeftHand_25(HandleRef pThis);

		/// <summary>
		/// Normally, hand position/orientation is set explicitly.
		/// If set to false, hand and arm will follow the torso
		/// in a neutral position.
		/// </summary>
		// Token: 0x060028BD RID: 10429 RVA: 0x0003C118 File Offset: 0x0003A318
		public virtual bool GetUseLeftHand()
		{
			return vtkAvatar.vtkAvatar_GetUseLeftHand_25(base.GetCppThis()) != 0;
		}

		// Token: 0x060028BE RID: 10430
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkAvatar_GetUseRightHand_26(HandleRef pThis);

		/// <summary>
		/// Normally, hand position/orientation is set explicitly.
		/// If set to false, hand and arm will follow the torso
		/// in a neutral position.
		/// </summary>
		// Token: 0x060028BF RID: 10431 RVA: 0x0003C140 File Offset: 0x0003A340
		public virtual bool GetUseRightHand()
		{
			return vtkAvatar.vtkAvatar_GetUseRightHand_26(base.GetCppThis()) != 0;
		}

		// Token: 0x060028C0 RID: 10432
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAvatar_IsA_27(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060028C1 RID: 10433 RVA: 0x0003C168 File Offset: 0x0003A368
		public override int IsA(string type)
		{
			return vtkAvatar.vtkAvatar_IsA_27(base.GetCppThis(), type);
		}

		// Token: 0x060028C2 RID: 10434
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAvatar_IsTypeOf_28([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060028C3 RID: 10435 RVA: 0x0003C188 File Offset: 0x0003A388
		public new static int IsTypeOf(string type)
		{
			return vtkAvatar.vtkAvatar_IsTypeOf_28(type);
		}

		// Token: 0x060028C4 RID: 10436
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAvatar_NewInstance_30(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060028C5 RID: 10437 RVA: 0x0003C1A4 File Offset: 0x0003A3A4
		public new vtkAvatar NewInstance()
		{
			vtkAvatar result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkAvatar.vtkAvatar_NewInstance_30(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkAvatar)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x060028C6 RID: 10438
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAvatar_SafeDownCast_31(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060028C7 RID: 10439 RVA: 0x0003C200 File Offset: 0x0003A400
		public new static vtkAvatar SafeDownCast(vtkObjectBase o)
		{
			vtkAvatar vtkAvatar = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkAvatar.vtkAvatar_SafeDownCast_31((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkAvatar = (vtkAvatar)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkAvatar.Register(null);
				}
			}
			return vtkAvatar;
		}

		// Token: 0x060028C8 RID: 10440
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAvatar_SetHeadOrientation_32(HandleRef pThis, double _arg1, double _arg2, double _arg3);

		/// <summary>
		/// Set/Get the head and hand transforms.
		/// </summary>
		// Token: 0x060028C9 RID: 10441 RVA: 0x0003C27F File Offset: 0x0003A47F
		public virtual void SetHeadOrientation(double _arg1, double _arg2, double _arg3)
		{
			vtkAvatar.vtkAvatar_SetHeadOrientation_32(base.GetCppThis(), _arg1, _arg2, _arg3);
		}

		// Token: 0x060028CA RID: 10442
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAvatar_SetHeadOrientation_33(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Set/Get the head and hand transforms.
		/// </summary>
		// Token: 0x060028CB RID: 10443 RVA: 0x0003C291 File Offset: 0x0003A491
		public virtual void SetHeadOrientation(IntPtr _arg)
		{
			vtkAvatar.vtkAvatar_SetHeadOrientation_33(base.GetCppThis(), _arg);
		}

		// Token: 0x060028CC RID: 10444
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAvatar_SetHeadPosition_34(HandleRef pThis, double _arg1, double _arg2, double _arg3);

		/// <summary>
		/// Set/Get the head and hand transforms.
		/// </summary>
		// Token: 0x060028CD RID: 10445 RVA: 0x0003C2A1 File Offset: 0x0003A4A1
		public virtual void SetHeadPosition(double _arg1, double _arg2, double _arg3)
		{
			vtkAvatar.vtkAvatar_SetHeadPosition_34(base.GetCppThis(), _arg1, _arg2, _arg3);
		}

		// Token: 0x060028CE RID: 10446
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAvatar_SetHeadPosition_35(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Set/Get the head and hand transforms.
		/// </summary>
		// Token: 0x060028CF RID: 10447 RVA: 0x0003C2B3 File Offset: 0x0003A4B3
		public virtual void SetHeadPosition(IntPtr _arg)
		{
			vtkAvatar.vtkAvatar_SetHeadPosition_35(base.GetCppThis(), _arg);
		}

		// Token: 0x060028D0 RID: 10448
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAvatar_SetLeftHandOrientation_36(HandleRef pThis, double _arg1, double _arg2, double _arg3);

		/// <summary>
		/// Set/Get the head and hand transforms.
		/// </summary>
		// Token: 0x060028D1 RID: 10449 RVA: 0x0003C2C3 File Offset: 0x0003A4C3
		public virtual void SetLeftHandOrientation(double _arg1, double _arg2, double _arg3)
		{
			vtkAvatar.vtkAvatar_SetLeftHandOrientation_36(base.GetCppThis(), _arg1, _arg2, _arg3);
		}

		// Token: 0x060028D2 RID: 10450
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAvatar_SetLeftHandOrientation_37(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Set/Get the head and hand transforms.
		/// </summary>
		// Token: 0x060028D3 RID: 10451 RVA: 0x0003C2D5 File Offset: 0x0003A4D5
		public virtual void SetLeftHandOrientation(IntPtr _arg)
		{
			vtkAvatar.vtkAvatar_SetLeftHandOrientation_37(base.GetCppThis(), _arg);
		}

		// Token: 0x060028D4 RID: 10452
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAvatar_SetLeftHandPosition_38(HandleRef pThis, double _arg1, double _arg2, double _arg3);

		/// <summary>
		/// Set/Get the head and hand transforms.
		/// </summary>
		// Token: 0x060028D5 RID: 10453 RVA: 0x0003C2E5 File Offset: 0x0003A4E5
		public virtual void SetLeftHandPosition(double _arg1, double _arg2, double _arg3)
		{
			vtkAvatar.vtkAvatar_SetLeftHandPosition_38(base.GetCppThis(), _arg1, _arg2, _arg3);
		}

		// Token: 0x060028D6 RID: 10454
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAvatar_SetLeftHandPosition_39(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Set/Get the head and hand transforms.
		/// </summary>
		// Token: 0x060028D7 RID: 10455 RVA: 0x0003C2F7 File Offset: 0x0003A4F7
		public virtual void SetLeftHandPosition(IntPtr _arg)
		{
			vtkAvatar.vtkAvatar_SetLeftHandPosition_39(base.GetCppThis(), _arg);
		}

		// Token: 0x060028D8 RID: 10456
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAvatar_SetRightHandOrientation_40(HandleRef pThis, double _arg1, double _arg2, double _arg3);

		/// <summary>
		/// Set/Get the head and hand transforms.
		/// </summary>
		// Token: 0x060028D9 RID: 10457 RVA: 0x0003C307 File Offset: 0x0003A507
		public virtual void SetRightHandOrientation(double _arg1, double _arg2, double _arg3)
		{
			vtkAvatar.vtkAvatar_SetRightHandOrientation_40(base.GetCppThis(), _arg1, _arg2, _arg3);
		}

		// Token: 0x060028DA RID: 10458
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAvatar_SetRightHandOrientation_41(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Set/Get the head and hand transforms.
		/// </summary>
		// Token: 0x060028DB RID: 10459 RVA: 0x0003C319 File Offset: 0x0003A519
		public virtual void SetRightHandOrientation(IntPtr _arg)
		{
			vtkAvatar.vtkAvatar_SetRightHandOrientation_41(base.GetCppThis(), _arg);
		}

		// Token: 0x060028DC RID: 10460
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAvatar_SetRightHandPosition_42(HandleRef pThis, double _arg1, double _arg2, double _arg3);

		/// <summary>
		/// Set/Get the head and hand transforms.
		/// </summary>
		// Token: 0x060028DD RID: 10461 RVA: 0x0003C329 File Offset: 0x0003A529
		public virtual void SetRightHandPosition(double _arg1, double _arg2, double _arg3)
		{
			vtkAvatar.vtkAvatar_SetRightHandPosition_42(base.GetCppThis(), _arg1, _arg2, _arg3);
		}

		// Token: 0x060028DE RID: 10462
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAvatar_SetRightHandPosition_43(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Set/Get the head and hand transforms.
		/// </summary>
		// Token: 0x060028DF RID: 10463 RVA: 0x0003C33B File Offset: 0x0003A53B
		public virtual void SetRightHandPosition(IntPtr _arg)
		{
			vtkAvatar.vtkAvatar_SetRightHandPosition_43(base.GetCppThis(), _arg);
		}

		// Token: 0x060028E0 RID: 10464
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAvatar_SetShowHandsOnly_44(HandleRef pThis, byte _arg);

		/// <summary>
		/// Show just the hands. Default false.
		/// </summary>
		// Token: 0x060028E1 RID: 10465 RVA: 0x0003C34B File Offset: 0x0003A54B
		public virtual void SetShowHandsOnly(bool _arg)
		{
			vtkAvatar.vtkAvatar_SetShowHandsOnly_44(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x060028E2 RID: 10466
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAvatar_SetUpVector_45(HandleRef pThis, double _arg1, double _arg2, double _arg3);

		/// <summary>
		/// Up vector, in world coords. Must be normalized.
		/// </summary>
		// Token: 0x060028E3 RID: 10467 RVA: 0x0003C363 File Offset: 0x0003A563
		public virtual void SetUpVector(double _arg1, double _arg2, double _arg3)
		{
			vtkAvatar.vtkAvatar_SetUpVector_45(base.GetCppThis(), _arg1, _arg2, _arg3);
		}

		// Token: 0x060028E4 RID: 10468
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAvatar_SetUpVector_46(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Up vector, in world coords. Must be normalized.
		/// </summary>
		// Token: 0x060028E5 RID: 10469 RVA: 0x0003C375 File Offset: 0x0003A575
		public virtual void SetUpVector(IntPtr _arg)
		{
			vtkAvatar.vtkAvatar_SetUpVector_46(base.GetCppThis(), _arg);
		}

		// Token: 0x060028E6 RID: 10470
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAvatar_SetUseLeftHand_47(HandleRef pThis, byte _arg);

		/// <summary>
		/// Normally, hand position/orientation is set explicitly.
		/// If set to false, hand and arm will follow the torso
		/// in a neutral position.
		/// </summary>
		// Token: 0x060028E7 RID: 10471 RVA: 0x0003C385 File Offset: 0x0003A585
		public virtual void SetUseLeftHand(bool _arg)
		{
			vtkAvatar.vtkAvatar_SetUseLeftHand_47(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x060028E8 RID: 10472
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAvatar_SetUseRightHand_48(HandleRef pThis, byte _arg);

		/// <summary>
		/// Normally, hand position/orientation is set explicitly.
		/// If set to false, hand and arm will follow the torso
		/// in a neutral position.
		/// </summary>
		// Token: 0x060028E9 RID: 10473 RVA: 0x0003C39D File Offset: 0x0003A59D
		public virtual void SetUseRightHand(bool _arg)
		{
			vtkAvatar.vtkAvatar_SetUseRightHand_48(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x060028EA RID: 10474
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAvatar_ShowHandsOnlyOff_49(HandleRef pThis);

		/// <summary>
		/// Show just the hands. Default false.
		/// </summary>
		// Token: 0x060028EB RID: 10475 RVA: 0x0003C3B5 File Offset: 0x0003A5B5
		public virtual void ShowHandsOnlyOff()
		{
			vtkAvatar.vtkAvatar_ShowHandsOnlyOff_49(base.GetCppThis());
		}

		// Token: 0x060028EC RID: 10476
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAvatar_ShowHandsOnlyOn_50(HandleRef pThis);

		/// <summary>
		/// Show just the hands. Default false.
		/// </summary>
		// Token: 0x060028ED RID: 10477 RVA: 0x0003C3C4 File Offset: 0x0003A5C4
		public virtual void ShowHandsOnlyOn()
		{
			vtkAvatar.vtkAvatar_ShowHandsOnlyOn_50(base.GetCppThis());
		}

		// Token: 0x060028EE RID: 10478
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAvatar_UseLeftHandOff_51(HandleRef pThis);

		/// <summary>
		/// Normally, hand position/orientation is set explicitly.
		/// If set to false, hand and arm will follow the torso
		/// in a neutral position.
		/// </summary>
		// Token: 0x060028EF RID: 10479 RVA: 0x0003C3D3 File Offset: 0x0003A5D3
		public virtual void UseLeftHandOff()
		{
			vtkAvatar.vtkAvatar_UseLeftHandOff_51(base.GetCppThis());
		}

		// Token: 0x060028F0 RID: 10480
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAvatar_UseLeftHandOn_52(HandleRef pThis);

		/// <summary>
		/// Normally, hand position/orientation is set explicitly.
		/// If set to false, hand and arm will follow the torso
		/// in a neutral position.
		/// </summary>
		// Token: 0x060028F1 RID: 10481 RVA: 0x0003C3E2 File Offset: 0x0003A5E2
		public virtual void UseLeftHandOn()
		{
			vtkAvatar.vtkAvatar_UseLeftHandOn_52(base.GetCppThis());
		}

		// Token: 0x060028F2 RID: 10482
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAvatar_UseRightHandOff_53(HandleRef pThis);

		/// <summary>
		/// Normally, hand position/orientation is set explicitly.
		/// If set to false, hand and arm will follow the torso
		/// in a neutral position.
		/// </summary>
		// Token: 0x060028F3 RID: 10483 RVA: 0x0003C3F1 File Offset: 0x0003A5F1
		public virtual void UseRightHandOff()
		{
			vtkAvatar.vtkAvatar_UseRightHandOff_53(base.GetCppThis());
		}

		// Token: 0x060028F4 RID: 10484
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAvatar_UseRightHandOn_54(HandleRef pThis);

		/// <summary>
		/// Normally, hand position/orientation is set explicitly.
		/// If set to false, hand and arm will follow the torso
		/// in a neutral position.
		/// </summary>
		// Token: 0x060028F5 RID: 10485 RVA: 0x0003C400 File Offset: 0x0003A600
		public virtual void UseRightHandOn()
		{
			vtkAvatar.vtkAvatar_UseRightHandOn_54(base.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400055C RID: 1372
		public new const string MRFullTypeName = "Kitware.VTK.vtkAvatar";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400055D RID: 1373
		public new static readonly string MRClassNameKey = "class vtkAvatar";
	}
}
