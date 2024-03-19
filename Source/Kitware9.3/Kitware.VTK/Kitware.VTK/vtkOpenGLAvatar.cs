using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkOpenGLAvatar
	/// </summary>
	/// <remarks>
	///    OpenGL Avatar
	///
	/// vtkOpenGLAvatar is a concrete implementation of the abstract class vtkAvatar.
	/// vtkOpenGLAvatar interfaces to the OpenGL rendering library.
	/// </remarks>
	// Token: 0x020000B9 RID: 185
	public class vtkOpenGLAvatar : vtkAvatar
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x060028F6 RID: 10486 RVA: 0x0003C40F File Offset: 0x0003A60F
		static vtkOpenGLAvatar()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkOpenGLAvatar.MRClassNameKey, Type.GetType("Kitware.VTK.vtkOpenGLAvatar"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x060028F7 RID: 10487 RVA: 0x0003C437 File Offset: 0x0003A637
		public vtkOpenGLAvatar(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x060028F8 RID: 10488
		[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkOpenGLAvatar_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060028F9 RID: 10489 RVA: 0x0003C448 File Offset: 0x0003A648
		public new static vtkOpenGLAvatar New()
		{
			vtkOpenGLAvatar result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkOpenGLAvatar.vtkOpenGLAvatar_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkOpenGLAvatar)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060028FA RID: 10490 RVA: 0x0003C49C File Offset: 0x0003A69C
		public vtkOpenGLAvatar() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkOpenGLAvatar.vtkOpenGLAvatar_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x060028FB RID: 10491 RVA: 0x0003C4E0 File Offset: 0x0003A6E0
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x060028FC RID: 10492
		[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkOpenGLAvatar_GetBounds_01(HandleRef pThis);

		/// <summary>
		/// Actual Avatar render method.
		/// </summary>
		// Token: 0x060028FD RID: 10493 RVA: 0x0003C4EC File Offset: 0x0003A6EC
		public override double[] GetBounds()
		{
			IntPtr intPtr = vtkOpenGLAvatar.vtkOpenGLAvatar_GetBounds_01(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[6];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x060028FE RID: 10494
		[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkOpenGLAvatar_GetLabelTextProperty_02(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Actual Avatar render method.
		/// </summary>
		// Token: 0x060028FF RID: 10495 RVA: 0x0003C534 File Offset: 0x0003A734
		public vtkTextProperty GetLabelTextProperty()
		{
			vtkTextProperty vtkTextProperty = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkOpenGLAvatar.vtkOpenGLAvatar_GetLabelTextProperty_02(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkTextProperty = (vtkTextProperty)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkTextProperty.Register(null);
				}
			}
			return vtkTextProperty;
		}

		// Token: 0x06002900 RID: 10496
		[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkOpenGLAvatar_GetNumberOfGenerationsFromBase_03(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06002901 RID: 10497 RVA: 0x0003C5A4 File Offset: 0x0003A7A4
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkOpenGLAvatar.vtkOpenGLAvatar_GetNumberOfGenerationsFromBase_03(base.GetCppThis(), type);
		}

		// Token: 0x06002902 RID: 10498
		[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkOpenGLAvatar_GetNumberOfGenerationsFromBaseType_04([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06002903 RID: 10499 RVA: 0x0003C5C4 File Offset: 0x0003A7C4
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkOpenGLAvatar.vtkOpenGLAvatar_GetNumberOfGenerationsFromBaseType_04(type);
		}

		// Token: 0x06002904 RID: 10500
		[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkOpenGLAvatar_IsA_05(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06002905 RID: 10501 RVA: 0x0003C5E0 File Offset: 0x0003A7E0
		public override int IsA(string type)
		{
			return vtkOpenGLAvatar.vtkOpenGLAvatar_IsA_05(base.GetCppThis(), type);
		}

		// Token: 0x06002906 RID: 10502
		[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkOpenGLAvatar_IsTypeOf_06([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06002907 RID: 10503 RVA: 0x0003C600 File Offset: 0x0003A800
		public new static int IsTypeOf(string type)
		{
			return vtkOpenGLAvatar.vtkOpenGLAvatar_IsTypeOf_06(type);
		}

		// Token: 0x06002908 RID: 10504
		[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkOpenGLAvatar_NewInstance_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06002909 RID: 10505 RVA: 0x0003C61C File Offset: 0x0003A81C
		public new vtkOpenGLAvatar NewInstance()
		{
			vtkOpenGLAvatar result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkOpenGLAvatar.vtkOpenGLAvatar_NewInstance_08(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkOpenGLAvatar)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600290A RID: 10506
		[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkOpenGLAvatar_RenderOpaqueGeometry_09(HandleRef pThis, HandleRef vp);

		/// <summary>
		/// Actual Avatar render method.
		/// </summary>
		// Token: 0x0600290B RID: 10507 RVA: 0x0003C678 File Offset: 0x0003A878
		public override int RenderOpaqueGeometry(vtkViewport vp)
		{
			return vtkOpenGLAvatar.vtkOpenGLAvatar_RenderOpaqueGeometry_09(base.GetCppThis(), (vp == null) ? default(HandleRef) : vp.GetCppThis());
		}

		// Token: 0x0600290C RID: 10508
		[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkOpenGLAvatar_RenderTranslucentPolygonalGeometry_10(HandleRef pThis, HandleRef vp);

		/// <summary>
		/// Actual Avatar render method.
		/// </summary>
		// Token: 0x0600290D RID: 10509 RVA: 0x0003C6AC File Offset: 0x0003A8AC
		public override int RenderTranslucentPolygonalGeometry(vtkViewport vp)
		{
			return vtkOpenGLAvatar.vtkOpenGLAvatar_RenderTranslucentPolygonalGeometry_10(base.GetCppThis(), (vp == null) ? default(HandleRef) : vp.GetCppThis());
		}

		// Token: 0x0600290E RID: 10510
		[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkOpenGLAvatar_SafeDownCast_11(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600290F RID: 10511 RVA: 0x0003C6E0 File Offset: 0x0003A8E0
		public new static vtkOpenGLAvatar SafeDownCast(vtkObjectBase o)
		{
			vtkOpenGLAvatar vtkOpenGLAvatar = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkOpenGLAvatar.vtkOpenGLAvatar_SafeDownCast_11((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkOpenGLAvatar = (vtkOpenGLAvatar)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkOpenGLAvatar.Register(null);
				}
			}
			return vtkOpenGLAvatar;
		}

		// Token: 0x06002910 RID: 10512
		[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOpenGLAvatar_SetLabel_12(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string label);

		/// <summary>
		/// Actual Avatar render method.
		/// </summary>
		// Token: 0x06002911 RID: 10513 RVA: 0x0003C75F File Offset: 0x0003A95F
		public void SetLabel(string label)
		{
			vtkOpenGLAvatar.vtkOpenGLAvatar_SetLabel_12(base.GetCppThis(), label);
		}

		// Token: 0x06002912 RID: 10514
		[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOpenGLAvatar_SetLeftShowRay_13(HandleRef pThis, byte v);

		/// <summary>
		/// Actual Avatar render method.
		/// </summary>
		// Token: 0x06002913 RID: 10515 RVA: 0x0003C76F File Offset: 0x0003A96F
		public void SetLeftShowRay(bool v)
		{
			vtkOpenGLAvatar.vtkOpenGLAvatar_SetLeftShowRay_13(base.GetCppThis(), v ? (byte)1 : (byte)0);
		}

		// Token: 0x06002914 RID: 10516
		[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOpenGLAvatar_SetRayLength_14(HandleRef pThis, double length);

		/// <summary>
		/// Actual Avatar render method.
		/// </summary>
		// Token: 0x06002915 RID: 10517 RVA: 0x0003C787 File Offset: 0x0003A987
		public void SetRayLength(double length)
		{
			vtkOpenGLAvatar.vtkOpenGLAvatar_SetRayLength_14(base.GetCppThis(), length);
		}

		// Token: 0x06002916 RID: 10518
		[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOpenGLAvatar_SetRightShowRay_15(HandleRef pThis, byte v);

		/// <summary>
		/// Actual Avatar render method.
		/// </summary>
		// Token: 0x06002917 RID: 10519 RVA: 0x0003C797 File Offset: 0x0003A997
		public void SetRightShowRay(bool v)
		{
			vtkOpenGLAvatar.vtkOpenGLAvatar_SetRightShowRay_15(base.GetCppThis(), v ? (byte)1 : (byte)0);
		}

		// Token: 0x06002918 RID: 10520
		[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOpenGLAvatar_SetShowHandsOnly_16(HandleRef pThis, byte val);

		/// <summary>
		/// Actual Avatar render method.
		/// </summary>
		// Token: 0x06002919 RID: 10521 RVA: 0x0003C7AF File Offset: 0x0003A9AF
		public override void SetShowHandsOnly(bool val)
		{
			vtkOpenGLAvatar.vtkOpenGLAvatar_SetShowHandsOnly_16(base.GetCppThis(), val ? (byte)1 : (byte)0);
		}

		// Token: 0x0600291A RID: 10522
		[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOpenGLAvatar_SetUseLeftHand_17(HandleRef pThis, byte val);

		/// <summary>
		/// Actual Avatar render method.
		/// </summary>
		// Token: 0x0600291B RID: 10523 RVA: 0x0003C7C7 File Offset: 0x0003A9C7
		public override void SetUseLeftHand(bool val)
		{
			vtkOpenGLAvatar.vtkOpenGLAvatar_SetUseLeftHand_17(base.GetCppThis(), val ? (byte)1 : (byte)0);
		}

		// Token: 0x0600291C RID: 10524
		[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOpenGLAvatar_SetUseRightHand_18(HandleRef pThis, byte val);

		/// <summary>
		/// Actual Avatar render method.
		/// </summary>
		// Token: 0x0600291D RID: 10525 RVA: 0x0003C7DF File Offset: 0x0003A9DF
		public override void SetUseRightHand(bool val)
		{
			vtkOpenGLAvatar.vtkOpenGLAvatar_SetUseRightHand_18(base.GetCppThis(), val ? (byte)1 : (byte)0);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400055E RID: 1374
		public new const string MRFullTypeName = "Kitware.VTK.vtkOpenGLAvatar";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400055F RID: 1375
		public new static readonly string MRClassNameKey = "class vtkOpenGLAvatar";
	}
}
